using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Database;
using Test.Models;

namespace Test.Repositories
{
    public class UserRepository
    {
        private readonly MySqlConnection connection;

        public UserRepository()
        {
            connection = DatabaseContext.Connection;
        }

        public async Task<Tuple<User, bool>> Get(string ident, string password)
        {
            try
            {
                await connection.OpenAsync().ConfigureAwait(false);

                string query = $"select * from users where email = '{ident}' or login = '{ident}' and password = '{password}'";
                var user = await connection.QueryFirstOrDefaultAsync<User>(query).ConfigureAwait(false);

                await connection.CloseAsync().ConfigureAwait(false);
                return Tuple.Create(user, false);
            }
            catch (MySqlException)
            {
                await connection.CloseAsync().ConfigureAwait(false);
                return Tuple.Create<User, bool>(null, true);
            }
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            try
            {
                await connection.OpenAsync().ConfigureAwait(false);

                var users = await connection.QueryAsync<User>("select * from users").ConfigureAwait(false);

                await connection.CloseAsync().ConfigureAwait(false);

                return users;
            }
            catch (MySqlException)
            {
                return Array.Empty<User>();
            }
        }

        public async Task<string> Create(User user)
        {
            try
            {
                await connection.OpenAsync().ConfigureAwait(false);

                string query = $"insert into users (email, login, password, name, phone, isAdmin) values " +
                    $"('{user.Email}', '{user.Login}', '{user.Password}', '{user.Name}', '{user.Phone}', {user.IsAdmin})";
                await connection.QueryAsync(query).ConfigureAwait(false);

                await connection.CloseAsync().ConfigureAwait(false);

                return string.Empty;
            }
            catch (MySqlException ex)
            {
                string result;
                switch (ex.Number)
                {
                    case 1062:
                        if (ex.Message.Contains("email"))
                        {
                            result = "Пользователь с таким email уже зарегистрирован.";
                        }
                        else
                        {
                            result = "Такой логин уже существует.";
                        }
                        break;

                    default:
                        result = "Ошибка регистрации. Проверьте подключение к интернету.";
                        break;
                }

                await connection.CloseAsync().ConfigureAwait(false);
                return result;
            }
        }

        public async Task<Tuple<User, bool>> GetByIdent(string ident)
        {
            try
            {
                await connection.OpenAsync().ConfigureAwait(false);

                string query = $"select * from users where email = '{ident}' or login = '{ident}'";

                var users = await connection.QueryFirstOrDefaultAsync<User>(query).ConfigureAwait(false);

                await connection.CloseAsync().ConfigureAwait(false);
                return Tuple.Create(users, false);
            }
            catch (MySqlException)
            {
                await connection.CloseAsync().ConfigureAwait(false);
                return Tuple.Create<User, bool>(null, true);
            }
        }

        public async Task Delete(int id)
        {
            await connection.OpenAsync().ConfigureAwait(false);

            string query = $"delete from users where id = '{id}'";
            await connection.QueryFirstOrDefaultAsync<User>(query).ConfigureAwait(false);

            await connection.CloseAsync().ConfigureAwait(false);
        }

        public async Task Update(User user)
        {
            await connection.OpenAsync().ConfigureAwait(false);

            string query = $"UPDATE users SET " +
                $"email = '{user.Email}', login = '{user.Login}', password = '{user.Password}', " +
                $"name = '{user.Name}', phone = '{user.Phone}', isAdmin = {user.IsAdmin} " +
                $"WHERE id = {user.Id};";
            await connection.QueryFirstOrDefaultAsync<User>(query).ConfigureAwait(false);

            await connection.CloseAsync().ConfigureAwait(false);
        }
    }
}
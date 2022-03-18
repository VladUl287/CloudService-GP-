using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Windows.Forms;
using Test.Forms;
using Test.Logic;
using Test.Models;
using Test.Repositories;
using Test.Validation;

namespace Test
{
    public partial class AdminForm : CustomForm
    {
        private readonly UserRepository userRepository;

        public AdminForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();

            timer.Tick += Timer_Elapsed;
            timer.Start();
        }

        private async void AdminForm_Shown(object sender, EventArgs e)
        {
            dgvUserList.DataSource = await userRepository.GetAll().ConfigureAwait(false);
        }

        private void Timer_Elapsed(object sender, EventArgs e)
        {
            if (!InternetConnetion.Check())
            {
                timer.Stop();
                SetNotInternet();
            }
        }

        private void SetNotInternet()
        {
            Close();
        }

        private async void DgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!InternetConnetion.Check())
            {
                SetNotInternet();
                return;
            }

            var user = (User)dgvUserList.Rows[e.RowIndex].DataBoundItem;
            if (dgvUserList.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (user.Email != Config.Email)
                {
                    await userRepository.Delete(user.Id).ConfigureAwait(false);
                    dgvUserList.DataSource = await userRepository.GetAll().ConfigureAwait(false);
                }
            }
            if (dgvUserList.Columns[e.ColumnIndex].Name == "UpdateInfo")
            {
                await userRepository.Update(user).ConfigureAwait(false);
                dgvUserList.DataSource = await userRepository.GetAll().ConfigureAwait(false);
            }
        }

        private static readonly string ch = "⛔";

        private async void BtnCreate_Click(object sender, EventArgs e)
        {
            if (!InternetConnetion.Check())
            {
                SetNotInternet();
                return;
            }

            btnRegister.Enabled = false;
            pbLoading.Visible = true;

            var user = new User
            {
                Email = tbEmail.Text,
                Name = tbName.Text,
                Login = tbLogin.Text,
                Password = tbRegPassword.Text,
                Phone = string.IsNullOrEmpty(tbPhone.Text) ? null : tbPhone.Text,
                IsAdmin = cbAdmin.Checked
            };

            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);
            if (!Validator.TryValidateObject(user, context, results, true))
            {
                lbValidation.Text = ch;

                string errors = string.Join("\n", results);

                toolTipErrors.SetToolTip(lbValidation, errors);
                lbValidation.Visible = false;
                btnRegister.Enabled = true;

                return;
            }
            else
            {
                lbValidation.Visible = false;

                var result = await userRepository.Create(user).ConfigureAwait(false);
                if (!string.IsNullOrEmpty(result))
                {
                    CustomBox.Show(result);
                }
                else
                {
                    tbEmail.Text = tbName.Text = tbLogin.Text = tbRegPassword.Text = tbPhone.Text = "";
                    dgvUserList.DataSource = await userRepository.GetAll().ConfigureAwait(false);
                    CustomBox.Show("Пользователь успешно создан.");
                }
            }

            btnRegister.Enabled = true;
            pbLoading.Visible = false;
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            if (!InternetConnetion.Check())
            {
                SetNotInternet();
                return;
            }

            dgvUserList.DataSource = await userRepository.GetAll().ConfigureAwait(false);
        }

        private void TabControlAdmin_DrawItem(object sender, DrawItemEventArgs e)
        {
            var page = tabControlAdmin.TabPages[e.Index];

            using (SolidBrush lightBrush = new SolidBrush(Color.FromArgb(155, 149, 191)))
            {
                if (e.State == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(page.BackColor), e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(lightBrush, e.Bounds);
                }

                var paddedBounds = e.Bounds;
                int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
                paddedBounds.Offset(1, yOffset);
                TextRenderer.DrawText(e.Graphics, page.Text, e.Font, paddedBounds, page.ForeColor);
            }
        }
               

        protected override void BtnExit_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Close();
        }
    }
}
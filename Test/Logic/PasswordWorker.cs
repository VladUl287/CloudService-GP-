using PasswordGenerator;

namespace Test.Logic
{
    public static class PasswordWorker
    {
        public static string Generate()
        {
            return new Password().IncludeLowercase().IncludeUppercase().LengthRequired(7).Next();
        }
    }
}
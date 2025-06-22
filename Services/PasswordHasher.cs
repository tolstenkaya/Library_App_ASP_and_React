namespace Library_App_ASP_and_React.Services
{
    public static class PasswordHasher
    {
        public static string Hash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool Verify(string password, string hashed_password)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashed_password);
        }
    }
}

namespace Modelos
{
    public static class User
    {
        private static string _userName = "";

        public static void setUserName(string username)
        {
            _userName = username;
        }

        public static string getUserName()
        {
            return _userName;
        }
    }
}

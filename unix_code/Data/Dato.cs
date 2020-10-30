using System;

namespace unix_code.Data
{
    static class Dato
    {
        static String username = "d";

        public static void saveUsername(String text)
        {
            username = text;
        }

        public static String getUsername()
        {
            return username;
        }
    }
}

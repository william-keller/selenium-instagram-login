using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Instagram.Login
{
    public static class Settings
    {
        public static string BASE_URL = "https://www.instagram.com";
        public static string LOGIN_URL = BASE_URL + "/accounts/login/";

        public static string USERNAME = "ENTER YOUR USERNAME HERE";
        public static string PASSWORD = "ENTER YOUR PASSWORD HERE";

        public static string[] USERS = new[] { "thepolicebandofficial", "metallica", "ironmaiden" };

        public static string X_LOGIN_INPUT_USERNAME = "//input[@name='username']";
        public static string X_LOGIN_INPUT_PASSWORD = "//input[@name='password']";
        public static string X_LOGIN_BTN_SUBMIT = "//button[@type='submit']";

        public static string X_HOME_NOT_NOW = "//button[contains(text(), 'Agora não')]";

        public static string X_PROFILE_BTN_FOLLOW = "//button[contains(text(), 'Seguir')]";
    }
}

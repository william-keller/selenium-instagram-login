using OpenQA.Selenium.Chrome;
using System;
using System.Threading.Tasks;

namespace Selenium.Instagram.Login
{
    public class LoginService : IDisposable
    {
        public bool IsLoggedIn;

        public LoginService()
        {
            IsLoggedIn = false;
        }

        public void Login(ChromeDriver _driver)
        {
            try
            {
                _driver.Navigate().GoToUrl(Settings.LOGIN_URL);

                Task.Delay(TimeSpan.FromSeconds(2)).Wait();

                var usernameElement = _driver.FindElementByXPath(Settings.X_LOGIN_INPUT_USERNAME);
                var passwordElement = _driver.FindElementByXPath(Settings.X_LOGIN_INPUT_PASSWORD);
                var submitElement = _driver.FindElementByXPath(Settings.X_LOGIN_BTN_SUBMIT);

                usernameElement.Clear();
                passwordElement.Clear();

                usernameElement.SendKeys(Settings.USERNAME);
                passwordElement.SendKeys(Settings.PASSWORD);

                submitElement.Click();

                Task.Delay(TimeSpan.FromSeconds(2)).Wait();

                var notNowElement = _driver.FindElementByXPath(Settings.X_HOME_NOT_NOW);
                notNowElement.Click();

                Task.Delay(TimeSpan.FromSeconds(2)).Wait();

                var notNowElement2 = _driver.FindElementByXPath(Settings.X_HOME_NOT_NOW);
                notNowElement2.Click();

                Task.Delay(TimeSpan.FromSeconds(1)).Wait();

                IsLoggedIn = true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Não foi possível fazer login. Motivo: {e.Message}");
            }
        }

        public void Dispose()
        {
            IsLoggedIn = false;
        }
    }
}

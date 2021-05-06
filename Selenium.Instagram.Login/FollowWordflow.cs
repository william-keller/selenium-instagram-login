using OpenQA.Selenium.Chrome;
using System;
using System.Threading.Tasks;

namespace Selenium.Instagram.Login
{
    public class FollowWordflow : IDisposable
    {
        private readonly ChromeDriver _driver;
        private readonly LoginService _loginService;

        public FollowWordflow(ChromeDriver chromeDriver)
        {
            _driver = chromeDriver;
            _loginService = new LoginService();
        }

        public void Follow(string username)
        {
            CheckConnection();

            var profileUrl = Settings.BASE_URL + $"/{username}";

            _driver.Navigate().GoToUrl(profileUrl);

            Task.Delay(TimeSpan.FromSeconds(2)).Wait();

            var followElement = _driver.FindElementByXPath(Settings.X_PROFILE_BTN_FOLLOW);
            followElement.Click();

            Task.Delay(TimeSpan.FromSeconds(2)).Wait();
        }

        private void CheckConnection()
        {
            if (_loginService.IsLoggedIn) return;

            _loginService.Login(_driver);

            if (!_loginService.IsLoggedIn)
                throw new Exception("Não conseguiu realizar login");
        }

        public void Dispose()
        {
            _loginService?.Dispose();
            _driver?.Dispose();
        }
    }
}

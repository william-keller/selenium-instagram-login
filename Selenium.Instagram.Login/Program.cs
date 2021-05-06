using System;
using OpenQA.Selenium.Chrome;

namespace Selenium.Instagram.Login
{
    public class Program
    {
        static void Main(string[] args)
        {
            using var driver = new ChromeDriver();

            Console.Clear();
            Console.WriteLine("# SUPER SEGUIDOR  #");
            Console.WriteLine();

            var workflow = new FollowWordflow(driver);

            Console.WriteLine("Seguindo usuários .");

            foreach (var username in Settings.USERS)
            {
                workflow.Follow(username);
                Console.Write(".");
            }

            Console.WriteLine(".");
            Console.WriteLine("Usuários seguidos com sucesso!");

            driver.Dispose();
        }
    }
}

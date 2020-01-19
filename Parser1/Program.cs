using System;
using HtmlAgilityPack;
using Parser1.Helpers;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Linq;

namespace Parser1
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.fonbet.ru/#!/bets/football/11918/18808821";

            IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory)
            {
                Url = url
            };

            var p = driver.PageSource;

            var m = driver.FindElement(By.Id("main"));
            var a = m.GetAttribute("innerHTML");

            string xpath_1 = "//*[@id=\"main\"]/div/div[2]/div[2]/div/div/div/div[2]/section/div[1]/div[3]/div[1]/div[2]/div[2]";
            string xpath_2 = "//*[@id=\"main\"]/div/div[2]/div[2]/div/div/div/div[2]/section/div[1]/div[3]/div[1]/div[2]/div[3]";
            string xpath_3 = "//*[@id=\"main\"]/div/div[2]/div[2]/div/div/div/div[2]/section/div[1]/div[3]/div[1]/div[2]/div[4]";

            var el_1 = driver.FindElement(By.XPath(xpath_1));
            var el_2 = driver.FindElement(By.XPath(xpath_2));
            var el_3 = driver.FindElement(By.XPath(xpath_3));

            var t_1 = el_1.GetAttribute("innerHTML");
            var t_2 = el_2.GetAttribute("innerHTML");
            var t_3 = el_3.GetAttribute("innerHTML");

        }
    }
}

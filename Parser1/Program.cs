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

            var m = driver.FindElement(By.Id("main"));

            string xpath = "//*[@id=\"main\"]/div/div[2]/div[2]/div/div/div/div[2]/section/div[1]/div[3]/div[1]/div[2]/div[2]";
            var links = driver.FindElements(By.XPath(xpath)).ToList();

            foreach (IWebElement link in links)
                Console.WriteLine("{0} - {1}", link.Text, link.GetAttribute("href"));

            using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
            {
                string htmlCode = client.DownloadString(url);
            }

                var d = ParsingHelper.LoadPage(url);

            string xpath_2 = "//*[@id=\"main\"]";
//            var links = d.DocumentNode.SelectNodes(xpath_2);
//            foreach (HtmlNode link in links)
//                Console.WriteLine("{0} - {1}", link.InnerText, link.GetAttributeValue("href", ""));
//            Console.WriteLine("Hello World!");

            //*[@id="main"]/div/div[2]/div[2]/div/div/div/div[2]/section/div[1]/div[3]/div[1]/div[2]
        }
    }
}

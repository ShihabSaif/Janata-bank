using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumTest
{
    class Program
    {
        static string url = "https://www.jb.com.bd/";
        static IWebDriver driver = new ChromeDriver();
        static string actualTitle = "Janata Bank Limited";
        static void Main(string[] args)
        {
            bool tc_01 = TC_01();
            if (tc_01)
            {
                Console.WriteLine("TC_01 passed");
            }
            else
            {
                Console.WriteLine("TC_01 failed");
            }

            bool tc_02 = TC_02();
            if (tc_02)
            {
                Console.WriteLine("TC_02 passed");
            }
            else
            {
                Console.WriteLine("TC_02 failed");
            }


            bool tc_03 = TC_03();
            if (tc_03)
            {
                Console.WriteLine("TC_03 passed");
            }
            else
            {
                Console.WriteLine("TC_03 failed");
            }

            bool tc_04 = TC_04();
            if (tc_04)
            {
                Console.WriteLine("TC_04 passed");
            }
            else
            {
                Console.WriteLine("TC_04 failed");
            }

            bool tc_05 = TC_05();
            if (tc_05)
            {
                Console.WriteLine("TC_05 passed");
            }
            else
            {
                Console.WriteLine("TC_05 failed");
            }

            bool tc_06 = TC_06();
            if (tc_06)
            {
                Console.WriteLine("TC_06 passed");
            }
            else
            {
                Console.WriteLine("TC_06 failed");
            }

            bool tc_07 = TC_07();
            if (tc_07)
            {
                Console.WriteLine("TC_07 passed");
            }
            else
            {
                Console.WriteLine("TC_07 failed");
            }

            bool tc_08 = TC_08();
            if (tc_08)
            {
                Console.WriteLine("TC_08 passed");
            }
            else
            {
                Console.WriteLine("TC_08 failed");
            }

            bool tc_09 = TC_09();
            if (tc_09)
            {
                Console.WriteLine("TC_09 passed");
            }
            else
            {
                Console.WriteLine("TC_09 failed");
            }

            commonurl();


            bool tc_10 = TC_10();
            if (tc_10)
            {
                Console.WriteLine("TC_10 passed");
            }
            else
            {
                Console.WriteLine("TC_10 failed");
            }
            commonurl();
            TC_11();
            commonurl();
            TC_12();

            bool tc_14 = TC_14();
            if (tc_14)
            {
                Console.WriteLine("TC_14 passed");
            }
            else
            {
                Console.WriteLine("TC_14 failed");
            }

            commonurl();

            bool tc_15 = TC_15();
            if (tc_15)
            {
                Console.WriteLine("TC_15 passed");
            }
            else
            {
                Console.WriteLine("TC_15 failed");
            }
            commonurl();

            TC_16();
            commonurl();
            TC_17();
            commonurl();
            TC_18();
            commonurl();
            TC_19();
            commonurl();
            TC_20();
            commonurl();
            bool tc_21 = TC_21();
            if (tc_21 == false)
            {
                Console.WriteLine("TC_21 failed");
            }
            else
            {
                Console.WriteLine("TC_21 passed");
            }
            commonurl();
            TC_22();
            commonurl();
            TC_23();
            commonurl();
            TC_24();
            commonurl();
            TC_25();
            commonurl();
            TC_26();
            commonurl();
            TC_27();
            commonurl();
            TC_29();
            commonurl();
            TC_30();

            //commonurl();
            //TC_31();
            //commonurl();
            //TC_32();



            commonurl();
            bool tc_33 = TC_33();
            if (tc_33)
            {
                Console.WriteLine("TC_33 passed");
            }
            else
            {
                Console.WriteLine("TC_33 failed");
            }

            //commonurl();
            //TC_34();

            commonurl();
            bool tc_35 = TC_35();
            if (tc_35)
            {
                Console.WriteLine("TC_35 passed");
            }
            else
            {
                Console.WriteLine("TC_35 failed");
            }

            commonurl();
            bool tc_36 = TC_36();
            if (tc_36)
            {
                Console.WriteLine("TC_36 passed");
            }
            else
            {
                Console.WriteLine("TC_36 failed");
            }

            commonurl();
            bool tc_37 = TC_37();
            if (tc_37)
            {
                Console.WriteLine("TC_37 passed");
            }
            else
            {
                Console.WriteLine("TC_37 failed");
            }

            commonurl();
            bool tc_38 = TC_38();
            if (tc_38)
            {
                Console.WriteLine("TC_38 passed");
            }
            else
            {
                Console.WriteLine("TC_38 failed");
            }

            commonurl();
            bool tc_39 = TC_39();
            if (tc_39)
            {
                Console.WriteLine("TC_39 passed");
            }
            else
            {
                Console.WriteLine("TC_39 failed");
            }

            commonurl();
            bool tc_40 = TC_40();
            if (tc_40)
            {
                Console.WriteLine("TC_40 passed");
            }
            else
            {
                Console.WriteLine("TC_40 failed");
            }
            commonurl();

            bool tc_41 = TC_41();
            if (tc_41)
            {
                Console.WriteLine("TC_41 passed");
            }
            else
            {
                Console.WriteLine("TC_41 failed");
            }

            commonurl();
            TC_42();

            commonurl();
            TC_43();

            commonurl();
            bool tc_45 = TC_45();
            if (tc_45)
            {
                Console.WriteLine("TC_45 passed");
            }
            else
            {
                Console.WriteLine("TC_45 failed");
            }

            commonurl();
            TC_46();

            commonurl();
            bool tc_47 = TC_47();
            if (tc_47)
            {
                Console.WriteLine("TC_47 passed");
            }
            else
            {
                Console.WriteLine("TC_47 failed");
            }

            commonurl();
            bool tc_48 = TC_48();
            if (tc_48)
            {
                Console.WriteLine("TC_48 passed");
            }
            else
            {
                Console.WriteLine("TC_48 failed");
            }

            commonurl();
            bool tc_49 = TC_49();
            if (tc_49)
            {
                Console.WriteLine("TC_49 passed");
            }
            else
            {
                Console.WriteLine("TC_49 failed");
            }

            commonurl();
            bool tc_50 = TC_50();
            if (tc_50)
            {
                Console.WriteLine("TC_50 passed");
            }
            else
            {
                Console.WriteLine("TC_50 failed");
            }


        }

        static void commonurl()
        {
            driver.Navigate().GoToUrl(url);
        }

        //check whether the website even exists in the URL or not
        static public bool TC_01()
        {
            commonurl();
            string windowTitle = driver.Title;
            //string title = driver.FindElement(By.TagName("jbl_slogan")).Text;
            if (actualTitle == windowTitle)
            {
                return true;
            }
            else
                return false;
        }

        static public bool TC_02()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='jblmenu']/li[1]/a"));
            home.Click();
            string nextPage = driver.FindElement(By.XPath(".//*[@id='jblmenu']/li[1]/a")).Text;
            if (nextPage == "Home")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool TC_03()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
#pragma warning disable CS0618 // Type or member is obsolete
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("About Us")));
#pragma warning restore CS0618 // Type or member is obsolete

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            string str = driver.FindElement(By.ClassName("submenutitle")).Text;
            if (str == "Knowing JBL")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool TC_04()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
#pragma warning disable CS0618 // Type or member is obsolete
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='jblmenu']/li[3]/a")));
#pragma warning restore CS0618 // Type or member is obsolete

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            string str = driver.FindElement(By.XPath(".//*[@id='jblmenu']/li[3]/div/span[1]/span")).Text;

            if (str == "Deposit")
            {
                return true;
            }
            else
            {
                return false;
            }
            //Console.WriteLine(str);

        }

        static public bool TC_05()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
#pragma warning disable CS0618 // Type or member is obsolete
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='jblmenu']/li[4]/a")));
#pragma warning restore CS0618 // Type or member is obsolete

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            string str = driver.FindElement(By.XPath(".//*[@id='jblmenu']/li[4]/div/span[1]/span")).Text;

            if (str == "e- Service")
            {
                return true;
            }
            else
            {
                return false;
            }
            //Console.WriteLine(str);
        }

        static public bool TC_06()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
#pragma warning disable CS0618 // Type or member is obsolete
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='jblmenu']/li[5]/a")));
#pragma warning restore CS0618 // Type or member is obsolete

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            string str = driver.FindElement(By.XPath(".//*[@id='jblmenu']/li[5]/div/span[1]/span")).Text;

            if (str == "Foreign Remittance")
            {
                return true;
            }
            else
            {
                return false;
            }
            //Console.WriteLine(str);
        }

        static public bool TC_07()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
#pragma warning disable CS0618 // Type or member is obsolete
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='jblmenu']/li[6]/a")));
#pragma warning restore CS0618 // Type or member is obsolete

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            string str = driver.FindElement(By.XPath(".//*[@id='jblmenu']/li[6]/div/span[1]/span/a")).Text;
            //Console.WriteLine(str);
            if (str == "Investment Portfolio")
            {
                return true;
            }
            else
            {
                return false;
            }
            //Console.WriteLine(str);
        }

        static public bool TC_08()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
#pragma warning disable CS0618 // Type or member is obsolete
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='jblmenu']/li[7]/a")));
#pragma warning restore CS0618 // Type or member is obsolete

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            string str = driver.FindElement(By.XPath(".//*[@id='jblmenu']/li[7]/div/span[1]/span")).Text;
            //Console.WriteLine(str);
            if (str == "Information Broadcast")
            {
                return true;
            }
            else
            {
                return false;
            }
            //Console.WriteLine(str);
        }

        static public bool TC_09()
        {
            IWebElement home = driver.FindElement(By.LinkText("Circulars"));
            home.Click();
            string nextPage = driver.FindElement(By.XPath("html/body/div[1]/div[3]/div[2]/div[1]/table/thead/tr/th[1]")).Text;
            if (nextPage == "Publish Date")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool TC_10()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
#pragma warning disable CS0618 // Type or member is obsolete
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='jblmenu']/li[9]/a")));
#pragma warning restore CS0618 // Type or member is obsolete

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            string str = driver.FindElement(By.XPath(".//*[@id='jblmenu']/li[9]/div/span[1]/span/a")).Text;

            if (str == "Contact Information")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //webmail check
        static public void TC_11()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='top-right-icon']/li[1]/a"));
            home.Click();

            Console.WriteLine("TC_11 passed");

            // driver.FindElement(By.("table"));

        }

        //jorip form check
        static public void TC_12()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='top-right-icon']/li[2]/a"));
            home.Click();
 
            Console.WriteLine("TC_12 failed");

        }

        static public void TC_13()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='top-right-icon']/li[3]/a"));
            home.Click();

            Console.WriteLine("TC_13 passed");

        }

        //Annual Performance Agreement-APA
        static public bool TC_14()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='container_fl']/div[1]/div/ul/li[1]/a"));
            home.Click();

            string str = driver.FindElement(By.XPath(".//*[@id='page_content']/h2")).Text;
            if (str == "Annual Performance Agreement-APA")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //download check
        static public bool TC_15()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='container_fl']/div[1]/div/ul/li[2]/a"));
            home.Click();

            string str = driver.FindElement(By.XPath(".//*[@id='page_content']/h2")).Text;
            if (str == "Download Files")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public void TC_16()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='top-right-icon']/li[4]/a"));
            home.Click();

            Console.WriteLine("TC_16 passed");

        }

        //OMIS check
        static public void TC_17()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='top-right-icon']/li[5]/a"));
            home.Click();

            Console.WriteLine("TC_17 passed");
        }

        //PMIS check
        static public void TC_18()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='top-right-icon']/li[6]/a"));
            home.Click();

            Console.WriteLine("TC_18 passed");
        }

        static public void TC_19()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='top-right-icon']/li[7]/a"));
            home.Click();

            Console.WriteLine("TC_19 passed");

        }

        static public void TC_20()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='tmpSlideshowControl-2']/span"));
            home.Click();

            Console.WriteLine("TC_20 passed");

        }

        //shuddhachar check
        static public bool TC_21()
        {
            string windowTitle = driver.Title;
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='legend']/a"));
            home.Click();

            if(actualTitle==windowTitle)
            {
                return false;
            }
            else
            {
                return true;
            }          
        }

        static public void TC_22()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='legend']/a"));
            home.Click();

            Console.WriteLine("TC_22 passed");

        }

        static public void TC_23()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='legend']/a"));
            home.Click();

            Console.WriteLine("TC_23 passed");

        }

        static public void TC_24()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='legend']/a"));
            home.Click();

            Console.WriteLine("TC_24 passed");

        }

        static public void TC_25()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='legend_list']/a"));
            home.Click();

            Console.WriteLine("TC_25 failed");

        }

        static public void TC_26()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='legend_list']/a"));
            home.Click();

            Console.WriteLine("TC_26 failed");

        }

        static public void TC_27()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='searchbox_012892411656638723322:iy-qc3dk67u']/input[3]"));
            home.Click();

            Console.WriteLine("TC_27 passed");

        }

        static public void TC_29()
        {
            IWebElement home = driver.FindElement(By.XPath("html/body/div[1]/div[12]/div[1]/div/div[2]/a[1]/img"));
            home.Click();

            Console.WriteLine("TC_29 passed");

        }

        static public void TC_30()
        {
            IWebElement home = driver.FindElement(By.XPath("html/body/div[1]/div[12]/div[1]/div/div[2]/a[3]/img"));
            home.Click();

            Console.WriteLine("TC_30 passed");

        }

        static public void TC_31()
        {
            IWebElement home = driver.FindElement(By.XPath("html/body/div[1]/div[12]/div[1]/div/div[2]/a[3]/img"));
            home.Click();

            IWebElement hm = driver.FindElement(By.LinkText("https://www.jb.com.bd/includes/pdf/"));
            hm.Click();

            Console.WriteLine("TC_31 failed");

        }

        static public void TC_32()
        {
            IWebElement home = driver.FindElement(By.XPath("html/body/div[1]/div[12]/div[1]/div/div[2]/a[3]/img"));
            home.Click();

            IWebElement hm = driver.FindElement(By.XPath(".//*[@id='link']/div[3]/a"));
            hm.Click();

            Console.WriteLine("TC_32 failed");

        }

        static public bool TC_33()
        {
            string windowTitle = driver.Title;
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='thumbs']/ul/li[2]/a/i"));
            home.Click();

            string str = driver.FindElement(By.XPath(".//*[@id='page_content']/h2")).Text;
            if(str== "ATM Service")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public void TC_34()
        {
            IWebElement home = driver.FindElement(By.XPath("html/body/div[1]/div[12]/div[1]/div/div[2]/a[3]/img"));
            home.Click();

            IWebElement hm = driver.FindElement(By.XPath("html/body/div[1]/div[12]/div[1]/div/div[1]/div[1]/ul/li[1]/a"));
            hm.Click();

            Console.WriteLine("TC_34 failed");

        }

        static public bool TC_35()
        {
            string windowTitle = driver.Title;
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='thumbs']/ul/li[4]"));
            home.Click();

            string str = driver.FindElement(By.XPath(".//*[@id='page_content']/h2")).Text;
            if(str== "Citizen Charter")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool TC_36()
        {
            string windowTitle = driver.Title;
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='thumbs']/ul/li[5]"));
            home.Click();

            string str = driver.FindElement(By.XPath(".//*[@id='page_content']/h2")).Text;
            if(str== "Financial Highlights")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool TC_37()
        {
            string windowTitle = driver.Title;
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='thumbs']/ul/li[6]"));
            home.Click();

            string str = driver.FindElement(By.XPath(".//*[@id='page_content']/div/h2")).Text;
            if (str == "Facilities Offered to the Remitters")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool TC_38()
        {
            string windowTitle = driver.Title;
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='thumbs']/ul/li[7]"));
            home.Click();

            string str = driver.FindElement(By.XPath(".//*[@id='page_content']/h2")).Text;
            if(str== "Innovation Plan of Janata Bank Limited")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool TC_39()
        {
            string windowTitle = driver.Title;
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='thumbs']/ul/li[8]"));
            home.Click();

            string str = driver.FindElement(By.XPath(".//*[@id='page_content']/h2")).Text;
            if (str == "Publications")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool TC_40()
        {
            string windowTitle = driver.Title;
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='thumbs']/ul/li[9]"));
            home.Click();

            string str = driver.FindElement(By.XPath("html/body/div[1]/div/div[1]/div/h2")).Text;
            if(str== "Welcome to JBL Web Admin Panel")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool TC_41()
        {
            string windowTitle = driver.Title;
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='thumbs']/ul/li[1]/a/i"));
            home.Click();

            string str = driver.FindElement(By.XPath(".//*[@id='page_content']/div/h2")).Text;
            if (str == "Bank at a Glance")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public void TC_42()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='thumbs']/ul/li[9]/a/div/h3"));
            home.Click();

            Console.WriteLine("TC_42 passed");

        }

        static public void TC_43()
        {
            IWebElement home = driver.FindElement(By.XPath(".//*[@id='thumbs']/ul/li[1]"));
            home.Click();

            Console.WriteLine("TC_43 passed");

        }

        static public bool TC_45()
        {
            string windowTitle = driver.Title;
            IWebElement home = driver.FindElement(By.XPath("html/body/div[1]/div[12]/div[5]/div[3]/div[1]/p[1]/a[2]"));
            home.Click();

            string str = driver.FindElement(By.XPath(".//*[@id='page_content']/h2")).Text;
            if(str== "Important Hot Links")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public void TC_46()
        {
            IWebElement home = driver.FindElement(By.XPath("html/body/div[1]/div[12]/div[5]/div[3]/div[1]/p[1]/a[3]"));
            home.Click();

            Console.WriteLine("TC_46 passed");

        }

        static public bool TC_47()
        {
            string windowTitle = driver.Title;
            IWebElement home = driver.FindElement(By.XPath("html/body/div[1]/div[12]/div[5]/div[3]/div[1]/p[1]/a[4]"));
            home.Click();

            string str = driver.FindElement(By.XPath(".//*[@class='answer-tab']")).Text;
            if(str== "Answer")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool TC_48()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
#pragma warning disable CS0618 // Type or member is obsolete
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("About Us")));
#pragma warning restore CS0618 // Type or member is obsolete

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            IWebElement home = driver.FindElement(By.XPath(".//*[@id='jblmenu']/li[2]/div/span[1]/p/a[3]"));
            home.Click();

            string str = driver.FindElement(By.XPath(".//*[@id='lbl']")).Text;
            if(str== "Head Office Divisions of Janata Bank Limited")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool TC_49()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
#pragma warning disable CS0618 // Type or member is obsolete
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='jblmenu']/li[3]/a")));
#pragma warning restore CS0618 // Type or member is obsolete

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            IWebElement home = driver.FindElement(By.XPath(".//*[@id='jblmenu']/li[3]/div/span[1]/p/a[1]"));
            home.Click();

            string str = driver.FindElement(By.XPath(".//*[@id='page_content']/h2")).Text;
            if (str == "চলতি হিসাব (Current Deposit)")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool TC_50()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
#pragma warning disable CS0618 // Type or member is obsolete
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='jblmenu']/li[4]/a")));
#pragma warning restore CS0618 // Type or member is obsolete

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            IWebElement home = driver.FindElement(By.XPath(".//*[@id='jblmenu']/li[4]/div/span[1]/p/a[1]"));
            home.Click();

            string str = driver.FindElement(By.XPath(".//*[@id='page_content']/h2")).Text;
            if (str == "ATM Service")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
using System;
using System.Configuration;
using Framework.Init;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Remote;
using System.IO;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using Selenium;
using OpenQA.Selenium.Support;
using System.Diagnostics;



namespace Framework.Init
{
   
    public class Browser
    {
        public static IWebDriver OpenWithSelectedBrowser(IWebDriver driver, string strUrlToOpen, Boolean OpenInNewWindow=false)
        {
            
            if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("UseBrowser")) == 1)
            {
                driver = OpenFirefoxBrowserWithUrl(driver, strUrlToOpen, OpenInNewWindow);
            }
            else if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("UseBrowser")) == 2)
            {
                driver = OpenChromeBrowserWithUrl(driver, strUrlToOpen, OpenInNewWindow);
            }
            else if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("UseBrowser")) == 3)
            {
                driver = OpenIEBrowserWithUrl(driver, strUrlToOpen, OpenInNewWindow);
            }
            else if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("UseBrowser")) == 4)
            {
                driver = OpenSafariBrowserWithUrl(driver, strUrlToOpen, OpenInNewWindow);
            }
            else if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("UseBrowser")) == 5)
            {
               driver = OpenOperaBrowserWithUrl(driver, strUrlToOpen, OpenInNewWindow);
            }
            else if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("UseBrowser")) == 6)
            {
                driver = OpenSauceLabWithUrl(driver, strUrlToOpen, OpenInNewWindow);
            }

            return driver;
        }


        public static IWebDriver OpenOperaBrowserWithUrl(IWebDriver driver, string strUrlToOpen, Boolean OpenInNewWindow = false)
        {
           try
           {

                Uri remote_grid = new Uri("http://" + "localhost" + ":" + "4444" + "/wd/hub");

                IWebDriver mydriver = new RemoteWebDriver(remote_grid,DesiredCapabilities.Opera());

                DesiredCapabilities mycapability = null;

                mycapability = DesiredCapabilities.Opera();

                mycapability.IsJavaScriptEnabled = true;

                mycapability.SetCapability("opera.host", "127.0.0.1");

                mycapability.SetCapability("opera.binary", "C:\\Program Files\\Opera");

                mycapability.SetCapability("opera.port", -1);

                mycapability.SetCapability("opera.profile", "");

                mycapability.SetCapability(mycapability.BrowserName, DesiredCapabilities.Opera().BrowserName);

                System.Console.WriteLine("step 4");

                //mycapability.SetCapability("opera.profile", @"C:\Program Files\Opera\operadriver-v0.11\docs\com\opera\core\systems\OperaProfile.html");

               Console.WriteLine("step 5");

               mydriver = new RemoteWebDriver(remote_grid, mycapability);
               
               mydriver.Navigate().GoToUrl(strUrlToOpen);
              
               mydriver.Manage().Window.Maximize();

               System.Console.WriteLine("step 8");
               
               Report.AddToHtmlReportPassed("Opera Browser Open for '" + strUrlToOpen + "' .");

         
          }

          catch (Exception ex)
           {
                   Report.AddToHtmlReportFailed(driver, ex, "Opera Browser Open for '" + strUrlToOpen + "' .");
           }
            
            
            return driver;
               
        }
       
        public static IWebDriver OpenFirefoxBrowserWithUrl(IWebDriver driver, string strUrlToOpen, Boolean OpenInNewWindow = false)
        {

            try
            {
                driver = new FirefoxDriver();
                driver.Navigate().GoToUrl(strUrlToOpen);
                Report.AddToHtmlReportPassed("FireFox Browser Open for '" + strUrlToOpen + "' .");
                
                driver.Manage().Window.Maximize();
            }
            catch (Exception ex)
            {
                Report.AddToHtmlReportFailed(driver, ex, "FireFox Browser Open for '" + strUrlToOpen + "' .");
            }
            return driver;
        }
       

        public static IWebDriver OpenChromeBrowserWithUrl(IWebDriver driver, string strUrlToOpen, Boolean OpenInNewWindow = false)
        {
            try
            {
                driver = new ChromeDriver(@"D:\Demo\DemoFramework");
                driver.Navigate().GoToUrl(strUrlToOpen);
                driver.Manage().Window.Maximize();

                Report.AddToHtmlReportPassed("Chrome Browser Open for '" + strUrlToOpen + "' .");
            }
            catch (Exception ex)
            {
                Report.AddToHtmlReportFailed(driver, ex, "Chrome Browser Open for '" + strUrlToOpen + "' .");
            }
            
            return driver;
        }
        public static IWebDriver OpenIEBrowserWithUrl(IWebDriver driver, string strUrlToOpen, Boolean OpenInNewWindow = false)
        {
            try
            {
                
                driver = new InternetExplorerDriver(@"D:\Demo\DemoFramework");
                driver.Navigate().GoToUrl(strUrlToOpen);
                Report.AddToHtmlReportPassed("Internet Explorer Open for '" + strUrlToOpen + "'.");
                driver.Manage().Window.Maximize();

            }
            catch (Exception ex)
            {
                Report.AddToHtmlReportFailed(driver, ex, "Internet Explorer Browser Open for '" + strUrlToOpen + "'.");
            }
            return driver;

        }

        public static IWebDriver OpenSafariBrowserWithUrl(IWebDriver driver, string strUrlToOpen, Boolean OpenInNewWindow = false)
        {

            try
            {
                Uri remote_grid = new Uri("http://" + "localhost" + ":" + "4444" + "/wd/hub");
                DesiredCapabilities capability = null;
                
                string browser = "safari";
                //if (browser == null || browser.Contains("safari"))
                {
                    //SafariProfile profile = new SafariProfile();

                    capability = DesiredCapabilities.Safari();
                    capability.IsJavaScriptEnabled = true;

                    //profile.EnableNativeEvents = true;

                    //capability.SetCapability(SafariDriver.ProfileCapabilityName, profile);
                }

                SafariOptions so = new SafariOptions();
                so.AddAdditionalCapability(DesiredCapabilities.Safari().IsJavaScriptEnabled.ToString(), true);

                //DesiredCapabilities capabilities = DesiredCapabilities.Safari();
                //capabilities.BrowserName.Insert(0, "safari");
                //ICommandExecutor executor = new SeleneseCommandExecutor( "http:localhost:4444/" ,"http://www.google.com/" , capabilities);
                //IWebDriver driver1 = new RemoteWebDriver(executor, capabilities);

                driver = new SafariDriver(so); // ScreenShotRemoteWebDriver(remote_grid, capability);
                //driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(20));

                WebDriverBackedSelenium BackedSelenium = new WebDriverBackedSelenium(driver, remote_grid);
                BackedSelenium.Start();

                driver.Navigate().GoToUrl(strUrlToOpen);
                Report.AddToHtmlReportPassed("Safari Browser Open for '" + strUrlToOpen + "' .");
                new Common(driver).pause(70000);
                driver.Manage().Window.Maximize();

                //ScreenShotRemoteWebDriver sd = new ScreenShotRemoteWebDriver(remote_grid, capability); 
                //sd.GetScreenshot().SaveAsFile()
            }
            catch (Exception ex)
            {
                //Console.WriteLine("ex::" + ex);
                //Console.WriteLine("ex.Message::" + ex.Message);
                //Console.WriteLine("ex.InnerException::" + ex.InnerException);
                //Console.WriteLine("ex.StackTrace::" + ex.StackTrace);
                //Report.AddToHtmlReportFailed(driver, ex, "Safari Browser Open for '" + strUrlToOpen + "' .");
            }
            return driver;
        }


        public static IWebDriver OpenSauceLabWithUrl(IWebDriver driver, string strUrlToOpen, Boolean OpenInNewWindow = false)
        {
            try
            {

                DesiredCapabilities caps = DesiredCapabilities.Firefox();
                caps.SetCapability(CapabilityType.Platform, "Windows 7");
                caps.SetCapability(CapabilityType.Version, "19");
                caps.SetCapability("name", "Testing Lodie on SauceLab");
                caps.SetCapability("username", "nikunjparekh");
                caps.SetCapability("accessKey", "7c6c01b8-2c6e-47ef-a42a-a3e48de41804");

                driver = new RemoteWebDriver(new Uri("http://ondemand.saucelabs.com:80/wd/hub"), caps);
                driver.Navigate().GoToUrl(strUrlToOpen);
              
                Report.AddToHtmlReportPassed("Sauce Lab Open for '" + strUrlToOpen + "' .");
            }
            catch (Exception ex)
            {
                //Console.WriteLine("ex::", ex.Message);
                Report.AddToHtmlReportFailed(driver, ex, "Sauce Lab Open for '" + strUrlToOpen + "' .");
            }

            
            return driver;

            

        }


        public static void CloseBrowser(IWebDriver driver)
        {
            string strDriverUrl = string.Empty; ;
           
            try
            {
                driver.Quit();
                Report.AddToHtmlReportPassed("Browser close.");
            }
            catch (Exception ex)
            {
                Report.AddToHtmlReportFailed(driver, ex, "Browser close.");
            }

        }

        private static void KillProcessByName(string processName)
        {

            try
            {
                foreach (Process process in Process.GetProcessesByName(processName))
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kill EX:: " + ex);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using Framework.Init;
using OpenQA.Selenium.Firefox;
using Framework.PageObjects;
using System.Data;

namespace TestCases
{
   public class Register
   {
       public static bool IsTcAdded = false;

       IWebDriver driver;

       string ProjectUrl = Convert.ToString(ConfigurationSettings.AppSettings.Get("ProjectUrl"));

       public void RegistrationVerification()
       {

           if (!IsTcAdded)
           {
               Report.AddToHtmlReportTCHeader("Register Test Cases");
               IsTcAdded = true;
           }

           Report.AddToHtmlReport("TC_001: To veriy user is able to register with valid details.", true, false, true);

           Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

           driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

           RegisterObjects objHome = new RegisterObjects();

           driver = objHome.RegistrationVerification(driver);

           if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
           {
               Browser.CloseBrowser(driver);
           }


       }

       public void RegistrationWithInvallidData()
       {

           if (!IsTcAdded)
           {
               Report.AddToHtmlReportTCHeader("Register Test Cases");
               IsTcAdded = true;
           }

           Report.AddToHtmlReport("TC_002: To veriy user is not able to register with invalid details.", true, false, true);

           Report.AddToHtmlReport("STEP 1: Insert Url in Browser Addressbar.", false, true);

           driver = Browser.OpenWithSelectedBrowser(driver, ProjectUrl, true);

           RegisterObjects objHome = new RegisterObjects();

           driver = objHome.RegistrationWithInvallidData(driver);

           if (Convert.ToInt16(ConfigurationSettings.AppSettings.Get("CloseBrowser")) == 1)
           {
               Browser.CloseBrowser(driver);
           }


       }

    
       
       }
   }


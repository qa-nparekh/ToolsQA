using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Init;
using OpenQA.Selenium;
using System.Configuration;
using NUnit.Framework;
using System.Collections;
using OpenQA.Selenium.Interactions;

namespace Framework.PageObjects
{
    public class RegisterObjects
    {
        IWebDriver _driver;


        /// <summary>
        /// Verify registration functionality with invalide details.
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>

        public IWebDriver RegistrationWithInvallidData(IWebDriver driver)
        {

            _driver = driver;

            RegistrationWithInvallidData();

            return _driver;
        }

        public void RegistrationWithInvallidData()
        {

            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_Home), "'Home' menu on Home page.", true, 10000);
            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_AboutUs), "'About us' menu on Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_Services), "'Services' menu on Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_Demo), "'Demo' menu on Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_Blog), "'Blog' menu on Home page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_Contact), "'Contact' menu on Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lbl_Home), "'Home' header text verification on Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lbl_Register), "'Registration' header text verification on Home page.");
            IWebElement Home_lnk_Register = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_Register), "'Registration' button under 'Registration' section on Home page.");

            Report.AddToHtmlReport("STEP 2: Click on 'Registration' link under 'Registration' section on Home page.", false, true);

            Home_lnk_Register.Click();

            new Common(_driver).pause(5000);

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_Register), "'Registration' header text verification on Registration page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_RegistrationForm), "'Registration Form' header text verification on Registration page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_FirstName), "'First Name' label text verification on Registration page.");
            IWebElement Register_txt_FirstName = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_FirstName), "'First Name' textbox on Registration page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_LastName), "'Last Name' label text verification on Registration page.");
            IWebElement Register_txt_LastName = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_LastName), "'Last Name' textbox on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_MaritalStatus), "'Marital Status' label text verification on Registration page.");
            IWebElement Register_rdo_MaritalStatus = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_rdo_MaritalStatus), "'Marital Status' radio buttons on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_Hobby), "'Hobby' label text verification on Registration page.");
            IWebElement Register_chk_Hobby = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_chk_Hobby), "'Hobby' checkbox on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_Country), "'Country' label text verification on Registration page.");
            IWebElement Register_ddl_Country = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_ddl_Country), "'Country' dropdownlist on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_DateofBirth), "'Date of Birth' label text verification on Registration page.");
            IWebElement Register_ddl_DOBdd = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_ddl_DOBdd), "'Day' dropdownlist on Registration page.");
            IWebElement Register_ddl_DOBmm = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_ddl_DOBmm), "'Month' dropdownlist on Registration page.");
            IWebElement Register_ddl_DOByy = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_ddl_DOByy), "'Year' dropdownlist on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_PhoneNumber), "'Phone Number' label text verification on Registration page.");
            IWebElement Register_txt_PhoneNumber = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_PhoneNumber), "'Phone Number' textbox on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_UserName), "'Username' label text verification on Registration page.");
            IWebElement Register_txt_UserName = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_UserName), "'Username' textbox on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_Email), "'E-mail' label text verification on Registration page.");
            IWebElement Register_txt_Email = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_Email), "'E-mail' textbox on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_AboutSelf), "'About Yourself' label text verification on Registration page.");
            IWebElement Register_txt_AboutSelf = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_AboutSelf), "'About Yourself' textbox on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_Password), "'Password' label text verification on Registration page.");
            IWebElement Register_txt_Pass = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_Pass), "'Password' textbox on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_ConfrimPass), "'Confirm Password' label text verification on Registration page.");
            IWebElement Register_txt_ConfirmPass = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_ConfirmPass), "'Confirm Password' textbox on Registration page.");

            IWebElement Register_btn_Submit = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_btn_Submit), "'Submit' button on Registration page.");

            string strFname = new Common(_driver).generateRandomString(6);

            string strLname = new Common(_driver).generateRandomString(8);

            Common.enterText(Register_txt_FirstName, strFname, true);

            new Common(_driver).pause(1000);

            Common.enterText(Register_txt_LastName, strLname, true);

            new Common(_driver).pause(1000);

            Register_rdo_MaritalStatus.Click();

            new Common(_driver).pause(1000);

            Register_chk_Hobby.Click();

            new Common(_driver).pause(1000);

            new Common(_driver).select(Register_ddl_Country, "India");

            new Common(_driver).pause(1000);

            new Common(_driver).select(Register_ddl_DOBdd, "15");

            new Common(_driver).pause(1000);

            new Common(_driver).select(Register_ddl_DOBmm, "5");

            new Common(_driver).pause(1000);

            new Common(_driver).select(Register_ddl_DOByy, "2014");

            new Common(_driver).pause(1000);

            string strPno = Common.GetRandomNumber(111111111, 999999999);

            strPno = "9" + strPno;

            Common.enterText(Register_txt_PhoneNumber, strPno, true);

            new Common(_driver).pause(1000);

            string strUser = "User_" + new Common(_driver).generateRandomString(4);

            Common.enterText(Register_txt_UserName, strUser, true);

            new Common(_driver).pause(1000);

            string strEmail = strUser + "@gmail.com";

            Common.enterText(Register_txt_Email, strEmail, true);

            new Common(_driver).pause(1000);

            String strAboutUs = new Common(_driver).generateRandomString(50);

            Common.enterText(Register_txt_AboutSelf, strAboutUs, true);

            new Common(_driver).pause(1000);

            string strPass = new Common(_driver).generateRandomString(8);

            Common.enterText(Register_txt_Pass, strPass, true);

            new Common(_driver).pause(1000);

            Common.enterText(Register_txt_ConfirmPass, strPass, true);

            new Common(_driver).pause(1000);

            Register_btn_Submit.Click();

            new Common(_driver).pause(3500);

            Report.AddToHtmlReport("<br>Data Entered", false, false, true);
            Report.AddToHtmlReport("First Name: " + strFname, false);
            Report.AddToHtmlReport("Last Name: " + strLname, false);
            Report.AddToHtmlReport("Phone Number: " + strPno, false);
            Report.AddToHtmlReport("Username: " + strUser, false);
            Report.AddToHtmlReport("E-mail: " + strEmail, false);
            Report.AddToHtmlReport("Password: " + strPass, false);
            Report.AddToHtmlReport("Confirm Password: " + strPass + "<br>", false);

            new Common(_driver).FindElement(By.XPath("//p[contains(@class,'piereg_messagexxx')]"), "'Thank you for you registration.' message text verification on Registration page.");

        }
        

        /// <summary>
        /// Verify registration functionality with invalide details.
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>

        public IWebDriver RegistrationVerification(IWebDriver driver)
        {

            _driver = driver;

            RegistrationVerification();

            return _driver;
        }

        public void RegistrationVerification()
        {

            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_Home), "'Home' menu on Home page.", true, 10000);
            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_AboutUs), "'About us' menu on Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_Services), "'Services' menu on Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_Demo), "'Demo' menu on Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_Blog), "'Blog' menu on Home page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_Contact), "'Contact' menu on Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lbl_Home), "'Home' header text verification on Home page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lbl_Register), "'Registration' header text verification on Home page.");
            IWebElement Home_lnk_Register = new Common(_driver).FindElement(By.XPath(ElementLocators.Home_lnk_Register), "'Registration' button under 'Registration' section on Home page.");

            Report.AddToHtmlReport("STEP 2: Click on 'Registration' link under 'Registration' section on Home page.", false, true);

            Home_lnk_Register.Click();

            new Common(_driver).pause(5000);

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_Register), "'Registration' header text verification on Registration page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_RegistrationForm), "'Registration Form' header text verification on Registration page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_FirstName), "'First Name' label text verification on Registration page.");
            IWebElement Register_txt_FirstName = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_FirstName), "'First Name' textbox on Registration page.");
            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_LastName), "'Last Name' label text verification on Registration page.");
            IWebElement Register_txt_LastName = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_LastName), "'Last Name' textbox on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_MaritalStatus), "'Marital Status' label text verification on Registration page.");
            IWebElement Register_rdo_MaritalStatus = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_rdo_MaritalStatus), "'Marital Status' radio buttons on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_Hobby), "'Hobby' label text verification on Registration page.");
            IWebElement Register_chk_Hobby = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_chk_Hobby), "'Hobby' checkbox on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_Country), "'Country' label text verification on Registration page.");
            IWebElement Register_ddl_Country = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_ddl_Country), "'Country' dropdownlist on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_DateofBirth), "'Date of Birth' label text verification on Registration page.");
            IWebElement Register_ddl_DOBdd = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_ddl_DOBdd), "'Day' dropdownlist on Registration page.");
            IWebElement Register_ddl_DOBmm = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_ddl_DOBmm), "'Month' dropdownlist on Registration page.");
            IWebElement Register_ddl_DOByy = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_ddl_DOByy), "'Year' dropdownlist on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_PhoneNumber), "'Phone Number' label text verification on Registration page.");
            IWebElement Register_txt_PhoneNumber = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_PhoneNumber), "'Phone Number' textbox on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_UserName), "'Username' label text verification on Registration page.");
            IWebElement Register_txt_UserName = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_UserName), "'Username' textbox on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_Email), "'E-mail' label text verification on Registration page.");
            IWebElement Register_txt_Email = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_Email), "'E-mail' textbox on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_AboutSelf), "'About Yourself' label text verification on Registration page.");
            IWebElement Register_txt_AboutSelf = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_AboutSelf), "'About Yourself' textbox on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_Password), "'Password' label text verification on Registration page.");
            IWebElement Register_txt_Pass = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_Pass), "'Password' textbox on Registration page.");

            new Common(_driver).FindElement(By.XPath(ElementLocators.Register_lbl_ConfrimPass), "'Confirm Password' label text verification on Registration page.");
            IWebElement Register_txt_ConfirmPass = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_txt_ConfirmPass), "'Confirm Password' textbox on Registration page.");

            IWebElement Register_btn_Submit = new Common(_driver).FindElement(By.XPath(ElementLocators.Register_btn_Submit), "'Submit' button on Registration page.");

            string strFname=new Common(_driver).generateRandomString(6);

            string strLname = new Common(_driver).generateRandomString(8);

            Common.enterText(Register_txt_FirstName, strFname, true);

            new Common(_driver).pause(1000);

            Common.enterText(Register_txt_LastName, strLname, true);

            new Common(_driver).pause(1000);

            Register_rdo_MaritalStatus.Click();

            new Common(_driver).pause(1000);

            Register_chk_Hobby.Click();

            new Common(_driver).pause(1000);

            new Common(_driver).select(Register_ddl_Country, "India");

            new Common(_driver).pause(1000);

            new Common(_driver).select(Register_ddl_DOBdd, "15");
            
            new Common(_driver).pause(1000);

            new Common(_driver).select(Register_ddl_DOBmm, "5");

            new Common(_driver).pause(1000);

            new Common(_driver).select(Register_ddl_DOByy, "2014");

            new Common(_driver).pause(1000);

            string strPno = Common.GetRandomNumber(111111111, 999999999);

            strPno = "9"+strPno;

            Common.enterText(Register_txt_PhoneNumber, strPno, true);

            new Common(_driver).pause(1000);

            string strUser = "User_" + new Common(_driver).generateRandomString(4);

            Common.enterText(Register_txt_UserName, strUser, true);

            new Common(_driver).pause(1000);

            string strEmail = strUser + "@gmail.com";

            Common.enterText(Register_txt_Email, strEmail, true);

            new Common(_driver).pause(1000);

            String strAboutUs = new Common(_driver).generateRandomString(50);

            Common.enterText(Register_txt_AboutSelf, strAboutUs, true);

            new Common(_driver).pause(1000);

            string strPass = new Common(_driver).generateRandomString(8);

            Common.enterText(Register_txt_Pass, strPass, true);

            new Common(_driver).pause(1000);

            Common.enterText(Register_txt_ConfirmPass, strPass, true);

            new Common(_driver).pause(1000);

            Register_btn_Submit.Click();

            new Common(_driver).pause(3500);

            Report.AddToHtmlReport("<br>Data Entered", false, false, true);
            Report.AddToHtmlReport("First Name: " +  strFname, false);
            Report.AddToHtmlReport("Last Name: " +strLname, false);
            Report.AddToHtmlReport("Phone Number: " +strPno, false);
            Report.AddToHtmlReport("Username: " + strUser, false);
            Report.AddToHtmlReport("E-mail: " +strEmail, false);
            Report.AddToHtmlReport("Password: " +strPass, false);
            Report.AddToHtmlReport("Confirm Password: " +strPass +"<br>", false);

            new Common(_driver).FindElement(By.XPath("//p[contains(@class,'piereg_message')]"), "'Thank you for you registration.' message text verification on Registration page.");
      
        }
        

        internal IWebDriver Options_CancelOnInsert(IWebDriver driver)
        {
            throw new NotImplementedException();
        }
    }
}

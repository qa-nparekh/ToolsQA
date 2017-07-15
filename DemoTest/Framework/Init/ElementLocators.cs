using System;
//using OpenQA.Selenium;

namespace Framework.Init
{
    public static class ElementLocators
    {

        #region //########### Home Page Elements ###########//

        public static String Home_lnk_Home = "//a[contains(.,'Home')]";
        public static String Home_lnk_AboutUs = "//a[contains(.,'About us')]";
        public static String Home_lnk_Services = "//a[contains(.,'Services')]";
        public static String Home_lnk_Demo = "//a[contains(.,'Demo')]";
        public static String Home_lnk_Blog = "//a[contains(.,'Blog')]";
        public static String Home_lnk_Contact = "//a[contains(.,'Contact')]";
        public static String Home_lbl_Home = "//h1[contains(.,'Home')]";
        public static String Home_lbl_Register = "//h3[contains(.,'Registration')]";
        public static String Home_lnk_Register = "//a[contains(.,'Registration')]";
     
        #endregion

        #region //########### Registration Page Elements ###########//

        public static String Register_lbl_Register = "//h1[contains(.,'Registration')]";
        public static String Register_lbl_RegistrationForm = "//h2[contains(.,'Registration Form')]";
        public static String Register_lbl_FirstName = "//label[contains(.,'First Name')]";
        public static String Register_txt_FirstName = "//input[@name='first_name']";
        public static String Register_lbl_LastName = "//label[contains(.,'Last Name')]";
        public static String Register_txt_LastName = "//input[@name='last_name']";
        public static String Register_lbl_MaritalStatus = "//label[contains(.,'Marital Status')]";
        public static String Register_rdo_MaritalStatus = "//input[@value='single']";
        public static String Register_lbl_Hobby = "//label[contains(.,'Hobby')]";
        public static String Register_chk_Hobby = "//input[@value='dance']";
        public static String Register_lbl_Country = "//label[contains(.,'Country')]";
        public static String Register_ddl_Country = "//select[@id='dropdown_7']";
        public static String Register_lbl_DateofBirth = "//label[contains(.,'Date of Birth')]";
        public static String Register_ddl_DOBmm = "//select[contains(@id,'mm_date')]";
        public static String Register_ddl_DOBdd = "//select[contains(@id,'dd_date')]";
        public static String Register_ddl_DOByy = "//select[contains(@id,'yy_date')]";
        public static String Register_lbl_PhoneNumber = "//label[contains(.,'Phone Number')]";
        public static String Register_txt_PhoneNumber = "//input[contains(@name,'phone')]";
        public static String Register_lbl_UserName = "//label[contains(.,'Username')]";
        public static String Register_txt_UserName = "//input[@name='username']";
        public static String Register_lbl_Email = "//label[contains(.,'E-mail')]";
        public static String Register_txt_Email = "//input[@name='e_mail']";
        public static String Register_lbl_AboutSelf="//label[contains(.,'About Yourself')]";
        public static String Register_txt_AboutSelf = "//textarea[@id='description']";
        public static String Register_lbl_Password = "//label[.='Password']";
        public static String Register_txt_Pass="//input[@name='password']";
        public static String Register_lbl_ConfrimPass="//label[contains(.,'Confirm Password')]";
        public static String Register_txt_ConfirmPass="//input[contains(@id,'confirm_password')]";
        public static String Register_btn_Submit="//input[@value='Submit']";

        #endregion

       

    }
}

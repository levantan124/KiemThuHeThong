using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using System.Security.Policy;
using OpenQA.Selenium;

namespace Selenium_46_Tan
{
    [TestClass]
    public class Page_46_Tan
    {
        private IWebDriver driver_46_tan; //khai bao ten bien voi kieu du lieu IWebDriver

        public Page_46_Tan(IWebDriver browser)
        {
            //doi so browser duoc truyen cho bien driver_46_tan, cho phep Page nay de mo Url
            driver_46_tan = browser; 
        }

        //LOGIN=======================================================================================================
        private By btnlogin_46_tan = By.Id("site-account-handle"); 
        private IWebElement BtnLongin_46_Tan => driver_46_tan.FindElement(btnlogin_46_tan);

        private By btn2login_46_tan = By.XPath("//button[@data-box='acc-login-box']");
        private IWebElement Btn2Longin_46_Tan => driver_46_tan.FindElement(btn2login_46_tan);

        private By username_46_tan = By.Id("login-customer[email]"); //truy cap thuoc tinh Id=email
        //dinh nghia thuoc tinh va tuong tac voi giao dien tren web
        private IWebElement Username_46_Tan => driver_46_tan.FindElement(username_46_tan);

        private By password_46_tan = By.Id("login-customer[password]"); //truy cap thuoc tinh Id=pass
        private IWebElement Password_46_Tan => driver_46_tan.FindElement(password_46_tan);

        private By login_46Click = By.Id("form_submit-login"); //truy cap thuoc tinh Id=login
        private IWebElement loginClick => driver_46_tan.FindElement(login_46Click);

        // Chuc nang Dang nhap tai khoan
        public void GoToLogin_46_Tan(string username, string password)
        {
            BtnLongin_46_Tan.Click();
            Thread.Sleep(1000);
            Btn2Longin_46_Tan.Click();
            Username_46_Tan.SendKeys(username);//nhap gia tri cua tham so username vao truong nhap lieu la Username_46
            Thread.Sleep(1000);//Dung luong thuc thi 1 khoang thoi gian, cu the o day la 2 giay
            Password_46_Tan.SendKeys(password);//nhap gia tri cua tham so password vao truong nhap lieu la Password_46
            Thread.Sleep(1000);
            loginClick.Click();//thuc hien 1 hanh dong click dinh danh la loginClick
            Thread.Sleep(2000);
            //driver_46_tan.Quit();
        }


        //SEARCH=======================================================================================================
        private By search_46_tan = By.CssSelector("input[class='input-search']");//truy cap thuoc tinh CssSelector cua search
        //dinh nghia thuoc tinh va tuong tac voi giao dien tren web
        private IWebElement Search_46_Tan => driver_46_tan.FindElement(search_46_tan);


        //Chuc nang tim kiem
        public void GoToSearch_46_Tan(string search_46_tan)
        {
            Search_46_Tan.SendKeys(search_46_tan);//nhap gia tri cua tham so search vao truong nhap lieu la Search_46
            Thread.Sleep(3000);//Dung luong thuc thi 1 khoang thoi gian, cu the o day la 3 giay
            Search_46_Tan.SendKeys(Keys.Enter);//sau khi duoc nhap lieu tim kiem, gui phim Enter de tim kiem
            Thread.Sleep(2000);
        }

        //ADD ADDRESS=======================================================================================================
        private By btnprofile_46_tan = By.Id("site-account-handle");
        private IWebElement BtnProFile_46_Tan => driver_46_tan.FindElement(btnprofile_46_tan);

        private By profile_46_tan = By.XPath("/html/body/div[1]/header/div/div/div/div[2]/div[6]/div[2]/div/div[1]/a/div[2]/div");
        private IWebElement Profile_46_Tan => driver_46_tan.FindElement(profile_46_tan);

        private By address_46_tan = By.CssSelector("li[data-tab='addresses']");
        private IWebElement AddressClick_46_Tan => driver_46_tan.FindElement(address_46_tan);

        private By btnaddress_46_tan = By.CssSelector("button[data-target='#modal-address-new-add']");
        private IWebElement BtnAddressClick_46_Tan => driver_46_tan.FindElement(btnaddress_46_tan);

        private By full_name_add_46_tan = By.Id("address_fullname_new");
        private IWebElement Full_Name_Add_46_Tan => driver_46_tan.FindElement(full_name_add_46_tan);

        private By phone_46_tan = By.Id("address_phone_new");
        private IWebElement Phone_46_Tan => driver_46_tan.FindElement(phone_46_tan);

        private By addrees1_46_tan = By.Id("address_province_new");
        private IWebElement Address1_46_Tan => driver_46_tan.FindElement(addrees1_46_tan);


        private By addrees2_46_tan = By.Id("address_address1_new");
        private IWebElement Address2_46_Tan => driver_46_tan.FindElement(addrees2_46_tan);

        private By house_46_tan = By.CssSelector("label[for='radio2_new']");
        private IWebElement House_46_Tan => driver_46_tan.FindElement(house_46_tan);


        private By submit_46_tan = By.CssSelector("#address_form_new > div.action_bottom > input");
        private IWebElement Submit_46_Tan => driver_46_tan.FindElement(submit_46_tan);
        

        //Chuc nang them dia chi giao hang
        public void GoToAddAddress_46_Tan(string fullname, string phone, string address1, string address2)
        {
            BtnProFile_46_Tan.Click();
            Thread.Sleep(500);
            Profile_46_Tan.Click();
            AddressClick_46_Tan.Click();
            BtnAddressClick_46_Tan.Click();
            Thread.Sleep(1000);
            Full_Name_Add_46_Tan.SendKeys(fullname);
            Thread.Sleep(1000);
            Phone_46_Tan.SendKeys(phone); Thread.Sleep(1000);
            Address1_46_Tan.SendKeys(address1); Thread.Sleep(1000);
            Address2_46_Tan.SendKeys(address2); Thread.Sleep(1000);
            House_46_Tan.Click();
            Thread.Sleep(500);
            Submit_46_Tan.Click() ;
        }

    }
}

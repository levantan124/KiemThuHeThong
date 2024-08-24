using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_46_Tan
{
    [TestClass]
    public class DangNhap_46_Tan
    {
        private IWebDriver driver_46_tan;
        private Page_46_Tan login_46_tan; //Khai bao bien de mo trang tuong ung thuc hien

        [TestInitialize]

        public void Setup() //thiet lap trang thai ban dau cho kiem thu
        {
            driver_46_tan = new ChromeDriver(); //Khoi tao trinh duyet Chrome
            driver_46_tan = new ChromeDriver(); //Khoi tao trinh duyet Chrome
            driver_46_tan.Manage().Window.Maximize();
            driver_46_tan.Navigate().GoToUrl("https://gearvn.com/"); //Dieu huong den Url chi dinh là Gearvn

            login_46_tan = new Page_46_Tan(driver_46_tan);//doi tuong Page_46_Tan, drive duoc truyen khi khoi tao;
        }

        [TestMethod] //==== DANG NHẬP ====
        public void Login_46_Tan()//Phuong thuc kiem thu Login_46, kiem tra chuc nang dang nhap vao web
        {
            //tuong tac voi doi tuong login_46 trong lop Page_46_Tan, thuc hien qua trinh dang nhap
            login_46_tan.GoToLogin_46_Tan("letanspeedup07@gmail.com", "Abc123)");//truyen vao phuong thuc GoToLogin bao gom ten dang nhap va mat khau
        }


        [TestMethod] //==== ĐĂNG NHẬP SAI MẬT KHẨU ====
        public void TestCase1_LoginErro1_46_Tan()
        {
            login_46_tan.GoToLogin_46_Tan("0342967699", "123445");
            Thread.Sleep(3000);
            IWebElement searchResult_46_Tan = driver_46_tan.FindElement(By.XPath("//*[@id=\"acc-login-box\"]/div/ul/li"));
            string actualResult_46_Tan = searchResult_46_Tan.Text.Trim();
            Thread.Sleep(3000);
            string expectedResult_46_Tan = "Thông tin đăng nhập không hợp lệ.";
            Thread.Sleep(3000);
            Assert.AreEqual(expectedResult_46_Tan, actualResult_46_Tan);
            driver_46_tan.Quit();
        }

        [TestMethod] //==== ĐĂNG NHẬP MẬT KHẨU TRỐNG ====
        public void TestCase2_LoginErro2_46_Tan()
        {
            login_46_tan.GoToLogin_46_Tan("0342967699", "");
            Thread.Sleep(3000);
            IWebElement searchResult_46_Tan = driver_46_tan.FindElement(By.XPath("//*[@id=\"acc-login-box\"]/div/ul/li"));
            string actualResult_46_Tan = searchResult_46_Tan.Text.Trim();
            Thread.Sleep(3000);
            string expectedResult_46_Tan = "Mật khẩu không được bỏ trống.";
            Thread.Sleep(3000);
            Assert.AreEqual(expectedResult_46_Tan, actualResult_46_Tan);
            driver_46_tan.Quit();
        }

        [TestMethod] //==== ĐĂNG NHẬP SAI ĐỊNH DẠNG TÀI KHOẢN ====
        public void TestCase3_LoginErro3_46_Tan()
        {
            login_46_tan.GoToLogin_46_Tan("03429", "123456");
            Thread.Sleep(3000);
            IWebElement searchResult_46_Tan = driver_46_tan.FindElement(By.XPath("//*[@id=\"acc-login-box\"]/div/ul/li"));
            string actualResult_46_Tan = searchResult_46_Tan.Text.Trim();
            Thread.Sleep(3000);
            string expectedResult_46_Tan = "Số điện thoại không hợp lệ.";
            Thread.Sleep(3000);
            Assert.AreEqual(expectedResult_46_Tan, actualResult_46_Tan);
            driver_46_tan.Quit();
        }

        [TestMethod] //==== ĐĂNG NHẬP TÀI KHOẢNG TRỐNG ====
        public void TestCase4_LoginErro4_46_Tan()
        {
            login_46_tan.GoToLogin_46_Tan("", "1234");
            Thread.Sleep(3000);
            IWebElement searchResult_46_Tan = driver_46_tan.FindElement(By.XPath("//*[@id=\"acc-login-box\"]/div/ul/li"));
            string actualResult_46_Tan = searchResult_46_Tan.Text.Trim();
            Thread.Sleep(3000);
            string expectedResult_46_Tan = "Email hoặc số điện thoại không được bỏ trống.";
            Thread.Sleep(3000);
            Assert.AreEqual(expectedResult_46_Tan, actualResult_46_Tan);
            driver_46_tan.Quit();
        }

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Selenium_46_Tan
{
    [TestClass]
    public class ThemDiaChi_46_Tan
    {
        private IWebDriver driver_46_tan;
        private Page_46_Tan add_address_46_tan;
        private Page_46_Tan login_46_tan;

        [TestInitialize]

        public void Setup() //thiet lap trang thai ban dau cho kiem thu
        {
            driver_46_tan = new ChromeDriver(); //Khoi tao trinh duyet Chrome
            driver_46_tan.Manage().Window.Maximize();
            driver_46_tan.Navigate().GoToUrl("https://gearvn.com/"); //Dieu huong den Url chi dinh là Gearvn

            add_address_46_tan = new Page_46_Tan(driver_46_tan);
            login_46_tan = new Page_46_Tan(driver_46_tan);
        }


        [TestMethod] //==== THÊM ĐỊA CHỈ ====
        public void TestCase1_Add_Address_46_Tan()
        {
            login_46_tan.GoToLogin_46_Tan("letanspeedup07@gmail.com", "Abc123)");
            add_address_46_tan.GoToAddAddress_46_Tan("Le Tan", "0342967699", "Hồ Chí Minh", "68");
            Thread.Sleep(2000);
            //driver_46_tan.Quit();
        }
    }
}

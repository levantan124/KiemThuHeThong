using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace Selenium_46_Tan
{
    [TestClass]
    public class TimKiem_46_Tan
    {
        private IWebDriver driver_46_tan;
        private Page_46_Tan search_46_tan; //Khai bao bien de mo trang tuong ung thuc hien

        [TestInitialize]

        public void Setup() //thiet lap trang thai ban dau cho kiem thu
        {
            driver_46_tan = new ChromeDriver(); //Khoi tao trinh duyet Chrome
            driver_46_tan.Manage().Window.Maximize();
            driver_46_tan.Navigate().GoToUrl("https://gearvn.com/"); //Dieu huong den Url chi dinh là Gearvn

            search_46_tan = new Page_46_Tan(driver_46_tan);//doi tuong Page_46_Tan, drive duoc truyen khi khoi tao;
        }

        [TestMethod] //==== TIM KIEM ====
        public void Search_46_Tan()//Phuong thuc kiem thu Search_46, kiem tra chuc nang dang nhap vao web
        {
            //tuong tac voi doi tuong search_46_tan trong lop Page_46_Tan, thuc hien qua trinh tim kiem
            search_46_tan.GoToSearch_46_Tan("Laptop gaming Acer Predator Helios 18 PH18 72 908N");
            //truyen vao phuong thuc GoToSearch_46_Tan la "Laptop gaming Acer Predator..."
        }


        [TestMethod] //==== TIM KIEM CÓ KẾT QUẢ TÌM KIẾM ====
        //Phuong thuc kiem thu TestCase1_Search_46_Tan, kiem tra chuc nang tim kiem cua web
        public void TestCase1_Search_46_Tan()
        {
            //Dieu huong den trang tim kiem va tim kiem "Laptop Asus Vivobook ..."
            search_46_tan.GoToSearch_46_Tan("Laptop Asus Vivobook 15 OLED A1505VA L1201W");
            Thread.Sleep(3000); //Dung thoi gian 3 giay
            //Xu dung Xpath de xac dinh phan tu chua ket qua mong doi, ket qua duoc luu o searchResult_46_Tan
            IWebElement searchResult_46_Tan = driver_46_tan.FindElement(By.XPath("/html/body/div[1]/main/div/div/div[1]/div[2]/div/div/div[2]/div[2]/div[1]/div/div[2]/h3/a"));
            string actualResult_46_Tan = searchResult_46_Tan.Text.Trim();//Lay van ban cua searchResult_46_Tan, bo khoang trang (Trim), ket qua moi duoc luu o actualResult_46_Tan
            Thread.Sleep(3000);
            //Ket qua mong doi duoc luu o expectedResult_46_Tan
            string expectedResult_46_Tan = "Laptop Asus Vivobook 15 OLED A1505VA L1201W"; 
            Thread.Sleep(3000);
            //So sanh ket qua mong doi va ket qua truc tiep
            Assert.AreEqual(expectedResult_46_Tan, actualResult_46_Tan);
            driver_46_tan.Quit(); //Dong trinh duyet
        }

        [TestMethod] //==== KHÔNG TÌM THẤY KẾT QUẢ TÌN KIẾM ====
        public void TestCase1_SearchError_46_Tan()
        {

            search_46_tan.GoToSearch_46_Tan("KhongThayKetQuaTimKiem");
            Thread.Sleep(3000);
            IWebElement searchResult_46_Tan = driver_46_tan.FindElement(By.XPath("//*[@id=\"search\"]/div[1]/div[3]/p[1]"));
            string actualResult_46_Tan = searchResult_46_Tan.Text.Trim();
            Thread.Sleep(3000);
            string expectedResult_46_Tan = "Rất tiếc, chúng tôi không tìm thấy kết quả cho từ khóa của bạn";
            Thread.Sleep(3000);
            Assert.AreEqual(expectedResult_46_Tan, actualResult_46_Tan);
            driver_46_tan.Quit();
        }
    }
}

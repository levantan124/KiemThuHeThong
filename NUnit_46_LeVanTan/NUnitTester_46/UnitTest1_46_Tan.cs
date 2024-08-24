using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit_46_LeVanTan;


namespace NUnitTester_46
{
    [TestClass]
    public class UnitTest1_46_Tan
    {
        private NUnit_46_Chuoi c_46;

        public TestContext TestContext { get; set; }
        [TestInitialize]

        public void Setup()
        {
            c_46 = new NUnit_46_Chuoi();
        }

        [TestMethod] // TC1: str1 = "Hello"; str2 = "World"; KQ1: "HelloWorld"
        public void Test_Ghep_Chuoi_46_Tan()
        {
            string actualResult_46_Tan;
            string str1 = "Hello";
            string str2 = "World";
            string expectedResult_46_Tan = "HelloWorld";
            NUnit46_Chuoi c_46 = new NUnit46_Chuoi(str1, str2);

            actualResult_46_Tan = c_46.Execute_46_Tan("Ghep");
            Assert.AreEqual(expectedResult_46_Tan, actualResult_46_Tan);
        }

        [TestMethod] // TC2: str1 = "HelloVietNam2024"; str2 = "7"; KQ2: "HelloVi"
        public void Test_Cat_Chuoi_46_Tan()
        {
            string actualResult_46_Tan;
            string str1 = "HelloVietNam2024";
            string str2 = "7";
            string expectedResult_46_Tan = "HelloVi";
            NUnit46_Chuoi c_46 = new NUnit46_Chuoi(str1, str2);

            actualResult_46_Tan = c_46.Execute_46_Tan("Cat");
            Assert.AreEqual(expectedResult_46_Tan, actualResult_46_Tan);
        }

        [TestMethod] // TC3: str1 = "HelloVN"; str2 = "10"; KQ3: "HelloVN"
        public void Test_Cat_Chuoi_Dai_46_Tan()
        {
            string actualResult_46_Tan;
            string str1 = "HelloVN";
            string str2 = "10";
            string expectedResult_46_Tan = "HelloVN";
            NUnit46_Chuoi c_46 = new NUnit46_Chuoi(str1, str2);

            actualResult_46_Tan = c_46.Execute_46_Tan("Cat");
            Assert.AreEqual(expectedResult_46_Tan, actualResult_46_Tan);
        }

        [TestMethod] // TC4: str1 = "HelloWORLDS!"; KQ4: "hello worlds!"
        public void Test_Chu_Thuong_46_Tan()
        {
            string actualResult_46_Tan;
            string str1 = "HelloWORLDS!";
            string str2 = "";
            string expectedResult_46_Tan = "helloworlds!";
            NUnit46_Chuoi c_46 = new NUnit46_Chuoi(str1, str2);

            actualResult_46_Tan = c_46.Execute_46_Tan("Thuong");
            Assert.AreEqual(expectedResult_46_Tan, actualResult_46_Tan);
        }

        [TestMethod] // TC5: str1 = "Hello WORLDS"; KQ5: "HELLO WORLDS"
        public void Test_Chu_Hoa_46_Tan()
        {
            string actualResult_46_Tan;
            string str1 = "Hello WORLDS";
            string str2 = "";
            string expectedResult_46_Tan = "HELLO WORLDS";
            NUnit46_Chuoi c_46 = new NUnit46_Chuoi(str1, str2);

            actualResult_46_Tan = c_46.Execute_46_Tan("Hoa");
            Assert.AreEqual(expectedResult_46_Tan, actualResult_46_Tan);
        }


        [TestMethod] // TC6: str1 = "Hello W O RLDS"; KQ6: "HelloWORLDS"
        public void Test_Xoa_Khoang_Trang_46_Tan()
        {
            string actualResult_46_Tan;
            string str1 = "Hello W O RLDS";
            string str2 = "";
            string expectedResult_46_Tan = "HelloWORLDS";
            NUnit46_Chuoi c_46 = new NUnit46_Chuoi(str1, str2);

            actualResult_46_Tan = c_46.Execute_46_Tan("KhoangTrang");
            Assert.AreEqual(expectedResult_46_Tan, actualResult_46_Tan);
        }


        [TestMethod] // TC7: str1 = "Hello W4O 9RLDS5"; KQ7: "495"
        public void Test_Lay_So_46_Tan()
        {
            string actualResult_46_Tan;
            string str1 = "Hello W4O 9RLDS5";
            string str2 = "";
            string expectedResult_46_Tan = "495";
            NUnit46_Chuoi c_46 = new NUnit46_Chuoi(str1, str2);

            actualResult_46_Tan = c_46.Execute_46_Tan("LaySo");
            Assert.AreEqual(expectedResult_46_Tan, actualResult_46_Tan);
        }

        [TestMethod] // TC8: str1 = "HelloLVT"; KQ8: "TVLolleH"
        public void Test_Dao_Chuoi_46_Tan()
        {
            string actualResult_46_Tan;
            string str1 = "HelloLVT";
            string str2 = "";
            string expectedResult_46_Tan = "TVLolleH";
            NUnit46_Chuoi c_46 = new NUnit46_Chuoi(str1, str2);

            actualResult_46_Tan = c_46.Execute_46_Tan("DaoChuoi");
            Assert.AreEqual(expectedResult_46_Tan, actualResult_46_Tan);
        }

        //Lien kêt Test data với project
        [TestMethod] //data test
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data_46_Test\TestData_46_Tan.csv", "TestData_46_Tan#csv", DataAccessMethod.Sequential)]

        public void TestWithDataSource_46_Tan()
        {
            string str1, str2, actualResult_46_Tan, expectedResult_46_Tan;
            string operation_46_Tan;

            str1 = TestContext.DataRow[0].ToString();
            str2 = TestContext.DataRow[1].ToString();

            operation_46_Tan = TestContext.DataRow[2].ToString();
            operation_46_Tan = operation_46_Tan.Remove(0, 1);
            expectedResult_46_Tan = TestContext.DataRow[3].ToString();



            NUnit46_Chuoi c_46 = new NUnit46_Chuoi(str1, str2);

            actualResult_46_Tan = c_46.Execute_46_Tan(operation_46_Tan);
            Assert.AreEqual(expectedResult_46_Tan, actualResult_46_Tan);
        }
    }
}   

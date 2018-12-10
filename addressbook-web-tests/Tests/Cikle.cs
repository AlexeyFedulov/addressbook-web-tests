using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests.Tests
{
    [TestClass]
    public class Cikle

    {
        [TestMethod] // for, foreach, while, do-while (не добален в качестве примера т.к. редко используется и конструкция простая проверка while ставится в конце тела цикла 
        public void Cikle1()
        {
            IWebDriver driver = null;
            int attempt = 0;
            while (driver.FindElements(By.Id("test" )).Count == 0 && attempt < 60)
            {
                System.Threading.Thread.Sleep(1000);
                attempt++; // или = attempt + 1
            }
            /*string[] s = new string[] { "I", "want", "to", "sleep" };//Конструкция в js
            foreach (string element in s)*/
            /*string[] s = new string[] { "I", "want", "to", "sleep" }; //так раньше выглядела итерация массива или списка на С++ например 
            for (int i=0; i<s.Length; i++) //исправил значение 10 в i<10 т.к. нет 4 элемента 0=1 i=+1 тоже самое i++(итерация +1)*/
            /*
            {
                System.Console.Out.Write(element + "\n"); //System.Console.Out.Write(s[i] + "\n");
            }*/
        }
    }
}
 
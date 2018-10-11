using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace addressbook_web_tests.Tests
{
    [TestClass]

    public class Vetvlenie
    {
        [TestMethod]
        public void TestMetod1()
        {
            double total = 900;
            bool vipClient = true;//bool-дополнительное условие vip, false-для отключения vip

            if (total > 1000 || vipClient)//если общая сумма больше 1000, &&-амперсант для выполнения двух условий, ||-по одному из двух условий
            {
                total = total * 0.9;
                System.Console.Out.Write("Скидка 10% общая сумма" + total);
            }
            else//иначе скидка не предоставляется 
            {
                System.Console.Out.Write("Скидка нет, общая сумма" + total);
            }
        }
    }
}





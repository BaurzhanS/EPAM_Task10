using Microsoft.VisualStudio.TestTools.UnitTesting;
using EPAM_Task10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using EPAM_Task10.Task1;

namespace EPAM_Task10.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        Customer customer = new Customer("Jeffrey Richter", "+1 (425) 555-0100", 1000000);

        [TestMethod()]
        public void ToStringTest1()
        {
            string expected = $"Customer record: Jeffrey Richter, 1000000.00, +1 (425) 555-0100";
            string result = customer.ToString("A", CultureInfo.InvariantCulture);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ToStringTest2()
        {
            string expected = $"Customer record: +1 (425) 555-0100";
            string result = customer.ToString("C", CultureInfo.InvariantCulture);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ToStringTest3()
        {
            string expected = $"Customer record: Jeffrey Richter, 1000000.00";
            string result = customer.ToString("B", CultureInfo.InvariantCulture);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ToStringTest4()
        {
            string expected = $"Customer record: Jeffrey Richter";
            string result = customer.ToString("N", CultureInfo.InvariantCulture);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ToStringTest5()
        {
            string expected = $"Customer record: 1000000.00";
            string result = customer.ToString("R", CultureInfo.InvariantCulture);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ToStringTest6()
        {
            string expected = $"Customer record: Jeffrey Richter, +1 (425) 555-0100";
            string result = customer.ToString("D", CultureInfo.InvariantCulture);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ToStringTest7()
        {
            string expected = $"Customer record: Jeffrey Richter, 1000000.00, +1 (425) 555-0100";
            string result = customer.ToString("G", CultureInfo.InvariantCulture);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ToStringTest8()
        {
            string expected = $"Customer record: Jeffrey Richter, 1000000,00, +1 (425) 555-0100";
            string result = customer.ToString();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ToStringTest9()
        {
            string result = customer.ToString("H", CultureInfo.InvariantCulture);
        }

        [TestMethod()]
        public void FormatProviderTest1()
        {
            IFormatProvider formatProvider = new CustomerFormatProvider();

            string expected = $"Customer record: +1 (425) 555-0100";
            string result = string.Format(formatProvider, "{0:C}", customer);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void FormatProviderTest2()
        {
            IFormatProvider formatProvider = new CustomerFormatProvider();

            string expected = $"Customer record: Jeffrey Richter Revenue: 1000000 Contact phone: +1 (425) 555-0100";
            string result = string.Format(formatProvider, "{0:E}", customer);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void FormatProviderTest3()
        {
            IFormatProvider formatProvider = new CustomerFormatProvider();
            string result = string.Format(formatProvider, "{0:P}", customer);
        }
    }   
}
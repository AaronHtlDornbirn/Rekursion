using NUnit.Framework;
using Rekursion;

namespace RekursionTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Fakultät_Nummer_RichtigeFakultätNummer()
        {
            int number1 = Fakultät.GetFakultät(1);
            int number2 = Fakultät.GetFakultät(2);
            int number3 = Fakultät.GetFakultät(3);
            int number4 = Fakultät.GetFakultät(4);
            int number5 = Fakultät.GetFakultät(5);
            Assert.AreEqual(number1, 1);
            Assert.AreEqual(number2, 1*2);
            Assert.AreEqual(number3, 1*2*3);
            Assert.AreEqual(number4, 1*2*3*4);
            Assert.AreEqual(number5, 1*2*3*4*5);           
        }

        [Test]
        public void FibonacciFolge_Nummer_RichtigeFibonacciFolgeNummer()
        {
            int number1 = FibonacciFolge.GetFibonacciFolge(1);
            int number2 = FibonacciFolge.GetFibonacciFolge(2);
            int number3 = FibonacciFolge.GetFibonacciFolge(3);
            int number4 = FibonacciFolge.GetFibonacciFolge(4);
            int number5 = FibonacciFolge.GetFibonacciFolge(5);
            Assert.AreEqual(number1, 1);
            Assert.AreEqual(number2, 1);
            Assert.AreEqual(number3, 2);
            Assert.AreEqual(number4, 3);
            Assert.AreEqual(number5, 5);
        }
    }
}
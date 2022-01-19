namespace NUnit.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void t1()
        {

            Assert.AreSame(object expected, object actual);
        }
        [Test]
        public void t2()
        {
            Assert.Contains(object anObject, IList collection);
        }
        [Test]
        public void t3()
        {
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void t4()
        {
            Assert.IsTrue(bool condition);
        }
        [Test]
        public void t5()
        {
            Assert.GreaterOrEqual(x, y);
        }
        [Test]
        public void t6()
        {
            Assert.Less(x, y);
        }
        [Test]
        public void t7()
        {
            Assert.LessOrEqual(x, y);
        }

        [Test]
        public void t8()
        {
            MyException ex = Assert.Throws<MyException>(delegate { throw new MyException("message", 42); });
            Assert.That(ex.Message, Is.EqualTo("message"));
        }

        [Test]
        public void t9()
        {
            Assert.GreaterOrEqual(x, y);
        }
        [Test]
        public void ComplexNumberTest()
        {
            ComplexNumber result = SomeCalculation();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(5.2, result.RealPart, "Real part");
                Assert.AreEqual(3.9, result.ImaginaryPart, "Imaginary part");
            });
        }
    }
}
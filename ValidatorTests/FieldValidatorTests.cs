using Battleships;
using NUnit.Framework;

namespace ValidatorTests
{
    [TestFixture]
    public class FieldValidatorTests
    {
        [Test]
        public void TestCase()
        {
            /*arrange*/
            int[,] field = 
            { {1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0} };
            /*act*/
            FieldValidator.ValidateField(field);
            bool res = FieldValidator.ValidateField(field);
            /*assert*/
            Assert.IsTrue(res);

        }
        [Test]
        public void TestCase1()
        {
            /*arrange*/
            int[,] field = 
            { { 0, 0, 0, 1, 1, 1, 0, 0, 0, 0 },
                { 0, 0, 1, 0, 1, 0, 0, 0, 0, 0 },
                { 1, 1, 1, 0, 1, 1, 0, 0, 0, 1 },
                { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 1, 0, 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 } };
            /*act*/
            bool res = FieldValidator.ValidateField(field);
            /*assert*/
            Assert.IsFalse(res);
        }
        [Test]
        public void TestCase2()
        {
            /*arrange*/
            int[,] field = 
            { {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 1, 1, 0, 1, 0, 0, 1, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {1, 0, 0, 1, 1, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {1, 0, 0, 0, 1, 1, 0, 0, 0, 1},
                {0, 0, 1, 0, 0, 0, 0, 1, 0, 0} };
            /*act*/
            bool res = FieldValidator.ValidateField(field);
            /*assert*/
            Assert.IsFalse(res);
        }
        [Test]
        public void TestCase3()
        {
            /*arrange*/
            int[,] field = 
            { {0, 1, 1, 0, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {1, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                {1, 0, 0, 1, 0, 1, 0, 0, 0, 0},
                {1, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                {0, 0, 1, 1, 1, 1, 0, 1, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1, 0, 0} };
            /*act*/
            bool res = FieldValidator.ValidateField(field);
            /*assert*/
            Assert.IsFalse(res);
        }
        [Test]
        public void TestCase4()
        {
            /*arrange*/
            int[,] field = 
            { {0, 1, 1, 1, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 1, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 1, 1, 0, 0, 0, 0, 1},
                {0, 0, 0, 1, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 1, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 1, 0, 0, 1},
                {0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
                {0, 1, 0, 0, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 1, 0, 0, 0, 0} };
            /*act*/
            bool res = FieldValidator.ValidateField(field);
            /*assert*/
            Assert.IsFalse(res);
        }
        [Test]
        public void TestCase5()
        {
            /*arrange*/
            int[,] field = 
            { {0, 0, 0, 0, 0, 0, 1, 1, 1, 0},
                {0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 1, 1, 0, 1, 0},
                {0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 1, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 1, 0, 1, 1},
                {0, 0, 0, 0, 0, 0, 1, 0, 1, 0},
                {0, 0, 1, 0, 0, 0, 1, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0} };
            /*act*/
            bool res = FieldValidator.ValidateField(field);
            /*assert*/
            Assert.IsFalse(res);
        }
        [Test]
        public void TestCase6()
        {
            /*arrange*/
            int[,] field = 
            { {0, 0, 1, 0, 0, 0, 0, 1, 0, 0},
                {1, 0, 1, 0, 1, 1, 0, 0, 0, 1},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 1, 1, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 1, 1, 0, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {1, 1, 1, 0, 0, 0, 1, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0} };
            /*act*/
            bool res = FieldValidator.ValidateField(field);
            /*assert*/
            Assert.IsFalse(res);
        }
        [Test]
        public void TestCase7()
        {
            /*arrange*/
            int[,] field = 
            {   {1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                {0, 0, 0, 1, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0} };
            /*act*/
            bool res = FieldValidator.ValidateField(field);
            /*assert*/
            Assert.IsFalse(res);
        }
        [Test]
        public void TestCase8()
        {
            /*arrange*/
            int[,] field =  {
                {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                {0, 1, 0, 1, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {1, 1, 1, 0, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1, 1, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {1, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                {1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
                {1, 0, 0, 0, 0, 1, 0, 1, 1, 0},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0} };
            /*act*/
            bool res = FieldValidator.ValidateField(field);
            /*assert*/
            Assert.IsTrue(res);
        }
        [Test]
        public void TestCase9()
        {
            /*arrange*/
            int[,] field = 
            { {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
                {1, 0, 0, 0, 0, 1, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {1, 0, 1, 1, 1, 0, 1, 1, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 1, 1, 1, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 1, 1, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 1, 1, 0, 0} };
            /*act*/
            bool res = FieldValidator.ValidateField(field);
            /*assert*/
            Assert.IsFalse(res);
        }
        [Test]
        public void TestCase10()
        {
            /*arrange*/
            int[,] field = 
            { {0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
                {0, 1, 1, 0, 0, 1, 0, 0, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 1, 0, 1, 1, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 1, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 1, 0, 0, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                {1, 0, 0, 0, 0, 0, 1, 0, 0, 0},
                {1, 0, 0, 1, 1, 0, 0, 0, 0, 0} };
            /*act*/
            bool res = FieldValidator.ValidateField(field);
            /*assert*/
            Assert.IsFalse(res);
        }
        [Test]
        public void TestCase11()
        {
            /*arrange*/
            int[,] field = 
            { {1, 0, 0, 0, 0, 1, 0, 0, 0, 1},
                {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 0, 1, 0, 1, 0, 1, 0, 0},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {0, 0, 1, 0, 1, 0, 0, 1, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {1, 0, 1, 0, 0, 1, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {1, 0, 0, 1, 0, 0, 0, 0, 0, 1} };
            /*act*/
            bool res = FieldValidator.ValidateField(field);
            /*assert*/
            Assert.IsFalse(res);
        }
        [Test]
        public void TestCase12()
        {
            /*arrange*/
            int[,] field =  {
                {1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 1, 0, 1, 0, 1, 0, 1, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 1, 0, 1, 0, 1, 0, 1, 0, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0} };
            /*act*/
            bool res = FieldValidator.ValidateField(field);
            /*assert*/
            Assert.IsFalse(res);
        }
    }
}
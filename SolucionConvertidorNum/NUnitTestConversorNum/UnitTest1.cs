using ConvertidorNum.Controllers;
using NUnit.Framework;

namespace NUnitTestConversorNum
{
    public class TestConvertidorNum
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConversorNum()
        {
            //Arrange=preparacion
            string num1 = "8";
            string esperado = "Ocho";
            ConversorNumController lit = new ConversorNumController();
            //Act=ejecution
            string resultado = lit.numeroget(num1);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);
        }
    }
}
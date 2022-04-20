using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace productionCode.Tests
{
    [TestFixture]
    public class SerialPortTests
    {
        [Test]
        public void serialPortCOM1DebeRetornar1()
        {
            //Arrange
            SerialPortParser serialPortParser = new SerialPortParser();
            //Act
            int result = serialPortParser.parsePort("COM1");
            //assert
            //Assert.IsTrue((result ==1));//
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void serialPortCOM2DebeRetornar2()
        {
            //Arrange
            SerialPortParser serialPortParser = new SerialPortParser();
            //Act
            int result = serialPortParser.parsePort("COM2");
            //assert
            //Assert.IsTrue((result == 2));//
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void serialPortDebeLanzarFormatExecption()
        {
            //Arrange y //Act
            TestDelegate throwException = () => new SerialPortParser().parsePort("COM2#");
            //Assert
            var ex = Assert.Throws<FormatException>(throwException);
            Assert.That(ex.Message, Is.EqualTo("El puerto ingresado no tiene el fomrato correcto"));
        }
    }
}

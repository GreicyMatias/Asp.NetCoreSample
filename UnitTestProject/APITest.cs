using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebApplication.Controllers;

namespace UnitTestProject
{
    [TestClass]
    public class APITest
    {
        [TestMethod]
        public void Deveria_retornar_url_do_github()
        {
            //Arrange           
            ValuesController controller = new ValuesController();

            //Act
            var result = controller.GetUrl();

            //Assert
            result.Value.Should().StartWith("https://github.com/");
        }

        [DataTestMethod]
        [DataRow(100, 5, "105,10")]
        [DataRow(100, 3, "103,03")]
        [DataRow(0, 3, "0,00")]
        public void Deveria_calcular_juros(double initialValue, int months, string expectedValue)
        {
            //Arrange
            ValuesController controller = new ValuesController();

            //Act
            var result = controller.Get(initialValue, months);

            //Assert
            result.Value.Should().Be(expectedValue);
        }
    }
}

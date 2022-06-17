using CpfValidation.Domain.Services;
using Xunit;

namespace CpfValidation.Tests
{
    public class CpfTest
    {
       
        [Theory]
        [InlineData("")]
        [InlineData("43364300801")]
        public void ValidadeCPF_Cpf_Cannot_Be_Null(string cpf)
        {
            //Arrange
            var request = new CpfService();
            
            //Act
            var resultado = request.ValidateCPF(cpf);
            //Assert
            //Assert.Equal(cpf, resultado.ToString());
            Assert.True(resultado, "O CPF NÃO deve ser nulo.");
        }

        [Theory]
        [InlineData("433643")]
        [InlineData("43364300801")]
        public void ValidadeCPF_Cpf_Must_Have_11_Characters(string cpf)
        {
            //Arrange
            var request = new CpfService();

            //Act
            var resultado = request.ValidateCPF(cpf);
            //Assert
            //Assert.Equal(cpf, resultado.ToString());
            Assert.True(resultado, "O CPF deve conter 11 caracteres.");
        }

        [Theory]
        [InlineData("44444444444")]
        [InlineData("43364300801")]
        public void ValidadeCPF_Cpf_Characters_Cannot_All_Be_The_Same(string cpf)
        {
            //Arrange
            var request = new CpfService();

            //Act
            var resultado = request.ValidateCPF(cpf);
            //Assert
            //Assert.Equal(cpf, resultado.ToString());
            Assert.True(resultado, "CPF Inválido - todos os caracteres não podem ser iguais.");
        }
    }
}

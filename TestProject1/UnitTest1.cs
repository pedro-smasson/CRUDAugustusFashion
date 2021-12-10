using Microsoft.VisualStudio.TestTools.UnitTesting;
using Augustus_Fashion.Model;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow("hdfhdf", true)]
        [DataRow("56454", false)]
        public void validar_se_input_tem_caracteres_string(string input, bool resultado)
        {
            Assert.AreEqual(Validacoes.ValidarString(input), resultado);
        }

        [DataTestMethod]
        [DataRow("421", true)]
        [DataRow("teste", false)]
        public void validar_se_input_tem_caracteres_numeric(string input, bool resultado)
        {
            Assert.AreEqual(Validacoes.ValidarNumeric(input), resultado);
        }

        [DataTestMethod]
        [DataRow("176.789.789-82", true)]
        [DataRow("4712894712", false)]
        [DataRow("gyfasgfyus", false)]
        [DataRow("@-,/", false)]
        public void validar_se_cpf_contem_numeros_pontos_e_hifen(string cpf, bool resultado) 
        {
            Assert.AreEqual(Validacoes.ValidarCpf(cpf), resultado);
        }

        [DataTestMethod]
        [DataRow("teste@teste.com", true)]
        [DataRow("teste@teste.br", true)]
        [DataRow("udsfhdsuhgios", false)]
        [DataRow("78523853", false)]
        [DataRow("?!#%", false)]
        public void validar_se_email_eh_valido(string email, bool resultado) 
        {
            Assert.AreEqual(Validacoes.ValidarEmail(email), resultado);
        }

        [DataTestMethod]
        [DataRow("24/10/2020", true)]
        [DataRow("24102077", false)]
        [DataRow("24/110/2077", false)]
        [DataRow("243/10/2077", false)]
        [DataRow("24/10/20577", false)]
        [DataRow("242/102/2077", false)]
        [DataRow("242/02/20577", false)]
        [DataRow("22/0h2/20577", false)]
        public void validar_se_data_de_nascimento_eh_valida(string data, bool resultado) 
        {
            Assert.AreEqual(Validacoes.ValidarDatas(data), resultado);
        }

        [DataTestMethod]
        [DataRow("oughds", true)]
        [DataRow("8498", true)]
        [DataRow("5847gdfgfdgfd", true)]
        [DataRow("@#$%!*&", false)]
        public void validar_se_input_contem_caracteres_string_e_numeric(string input, bool resultado) 
        {
            Assert.AreEqual(Validacoes.ValidarStringENumeric(input), resultado);
        }

        [DataTestMethod]
        [DataRow("15.706-402", true)]
        [DataRow("15;706-4021", false)]
        [DataRow("1570640", false)]
        [DataRow("gasdgds", false)]

        public void validar_se_cep_contem_numeros_ponto_e_hifen(string cep, bool resultado) 
        {
            Assert.AreEqual(Validacoes.ValidarCep(cep), resultado);
        }

        [DataTestMethod]
        [DataRow("1%", true)]
        [DataRow("10%", true)]
        [DataRow("100%", true)]
        [DataRow("gdfgdf", false)]
        public void validar_se_input_contem_numeros_e_porcentagem(string input, bool resultado) 
        {
            Assert.AreEqual(Validacoes.ValidarPorcentagem(input), resultado);
        }

        [DataTestMethod]
        [DataRow("17996331695", true)]
        [DataRow("7774", false)]
        [DataRow("uifdhuigd", false)]
        public void validar_se_celular_contem_apenas_caracteres_numericos(string celular, bool resultado)
        {
            Assert.AreEqual(Validacoes.ValidarCelular(celular), resultado);
        }

        [TestMethod]
        public void validar_se_desconto_eh_valido_ou_nao() 
        {
            string desconto = "7";

            var teste = Validacoes.ValidarDesconto(Convert.ToDecimal(desconto));

            Assert.IsTrue(teste);
        }

        [TestMethod]
        public void verificar_se_fabricante_digitado_eh_valido()
        {
            string fabricante = "Junior&Junior";

            var variavel = Validacoes.ValidarFabricante(fabricante);

            Assert.IsTrue(variavel);
        }

        [DataTestMethod]
        [DataRow("Junior&Junior", true)]
        [DataRow("Junior111111Junior", false)]
        public void validar_se_fabricante_eh_valido(string fabricante, bool resultado)
        {
            Assert.AreEqual(Validacoes.ValidarFabricante(fabricante), resultado);
        }
    }
}
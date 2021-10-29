using Microsoft.VisualStudio.TestTools.UnitTesting;
using Augustus_Fashion.Model;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void se_o_campo_conter_texto_entao_campo_eh_valido()
        {
            string nome = "teste";

            var variavel = Testes.ValidarString(nome);

            Assert.IsTrue(variavel);
        }

        [DataTestMethod]
        [DataRow("hdfhdf", true)]
        [DataRow("56454", false)]
        public void validar_se_campo_so_contem_letras(string a, bool resultado)
        {
            Assert.AreEqual(Testes.ValidarString(a), resultado);
        }

        [TestMethod]
        public void se_o_campo_conter_numero_entao_campo_eh_valido()
        {
            string numero = "1";

            var variavel = Testes.ValidarNumeric(numero);

            Assert.IsTrue(variavel);
        }

        [DataTestMethod]
        [DataRow("421", true)]
        [DataRow("teste", false)]
        public void validar_se_campo_so_contem_numeros(string a, bool resultado)
        {
            Assert.AreEqual(Testes.ValidarNumeric(a), resultado);
        }

        [TestMethod]
        public void validar_se_cpf_eh_valido() 
        {
            string cpf = "176.789.789-82";

            var variavel = Testes.validarCpf(cpf);

            Assert.IsTrue(variavel);
        }

        [DataTestMethod]
        [DataRow("176.789.789-82", true)]
        [DataRow("4712894712", false)]
        [DataRow("gyfasgfyus", false)]
        [DataRow("@-,/", false)]
        public void validar_se_cpf_eh_valido_ou_nao(string a, bool resultado) 
        {
            Assert.AreEqual(Testes.validarCpf(a), resultado);
        }

        [TestMethod]
        public void validar_se_email_eh_valido() 
        {
            string email = "teste@teste.com";

            var variavel = Testes.validarEmail(email);

            Assert.IsTrue(variavel);
        }

        [DataTestMethod]
        [DataRow("teste@teste.com", true)]
        [DataRow("teste@teste.br", true)]
        [DataRow("udsfhdsuhgios", false)]
        [DataRow("78523853", false)]
        [DataRow("?!#%", false)]
        public void validar_se_email_eh_valido_ou_nao(string a, bool resultado) 
        {
            Assert.AreEqual(Testes.validarEmail(a), resultado);
        }

        [TestMethod]
        public void validar_se_data_de_nasc_eh_valida() 
        {
            string data = "24/10/2077";

            var variavel = Testes.validarDataNasc(data);

            Assert.IsTrue(variavel);
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
        public void validar_se_data_de_nasc_eh_valida_ou_nao(string a, bool resultado) 
        {
            Assert.AreEqual(Testes.validarDataNasc(a), resultado);
        }

        [TestMethod]
        public void validar_se_campo_string_e_numerico_eh_valido()
        {
            string campo = "teste 7";

            var variavel = Testes.validarStringENumeric(campo);

            Assert.IsTrue(variavel);
        }

        [DataTestMethod]
        [DataRow("oughds", true)]
        [DataRow("8498", true)]
        [DataRow("5847gdfgfdgfd", true)]
        [DataRow("@#$%!*&", false)]
        public void validar_se_campo_string_e_numeric_eh_valido_ou_nao(string a, bool resultado) 
        {
            Assert.AreEqual(Testes.validarStringENumeric(a), resultado);
        }

        [TestMethod]
        public void validar_se_cep_eh_valido() 
        {
            string cep = "15706402";

            var variavel = Testes.validarCep(cep);

            Assert.IsTrue(variavel);
        }

        [DataTestMethod]
        [DataRow("15706402", true)]
        [DataRow("157064021", false)]
        [DataRow("1570640", false)]
        [DataRow("gasdgds", false)]

        public void validar_se_cep_eh_valido_ou_nao(string a, bool resultado) 
        {
            Assert.AreEqual(Testes.validarCep(a), resultado);
        }

        [TestMethod]
        public void validar_se_comissao_eh_valida() 
        {
            string comissao = "10%";

            var variavel = Testes.validarComissao(comissao);

            Assert.IsTrue(variavel);
        }

        [DataTestMethod]
        [DataRow("1%", true)]
        [DataRow("10%", true)]
        [DataRow("100%", true)]
        [DataRow("gdfgdf", false)]
        public void validar_se_comissao_eh_valida_ou_nao(string a, bool resultado) 
        {
            Assert.AreEqual(Testes.validarComissao(a), resultado);
        }

        [TestMethod]
        public void validar_se_celular_eh_valido() 
        {
            string celular = "17996331695";

            var variavel = Testes.validarCelular(celular);

            Assert.IsTrue(variavel);
        }

        [DataTestMethod]
        [DataRow("17996331695", true)]
        [DataRow("7774", false)]
        [DataRow("uifdhuigd", false)]
        public void validar_se_celular_eh_valido_ou_nao(string a, bool resultado) 
        {
            Assert.AreEqual(Testes.validarCelular(a), resultado);
        }
    }
}

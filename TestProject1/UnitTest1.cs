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

        //[DataTestMethod]
        //[DataRow("24/10/2077", true)]
        //[DataRow("573987598"), false]
        //[DataRow]
        //[DataRow]
        //[DataRow]
    }
}

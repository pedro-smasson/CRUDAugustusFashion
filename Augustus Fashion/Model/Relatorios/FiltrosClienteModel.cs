using Augustus_Fashion.Enums;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Augustus_Fashion.Model
{
    class FiltrosClienteModel
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public EnumOrdenarPor OrdenarPor { get; set; }
        public decimal APartir { get; set; }
        public EnumFiltrarPor FiltrarPor { get; set; }
        public string Ordem { get; set; }
        public int QuantidadeClientes { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public string OrderBy() => GetEnumDescription(OrdenarPor);

        public string Having()
        {
            var queryHaving = @" ";

            if (APartir != 0)
                queryHaving += $" having {GetEnumDescription(FiltrarPor)} > @APartir ";

            return queryHaving;
        }

        public string OrdemCrescenteOuDecrescente()
        {
            var input = @" ";

            if (Ordem == "Decrescente")
                input = " desc ";

            return input;
        }

        public string Select() 
        {
            if (QuantidadeClientes != 0)
                return " select top " + QuantidadeClientes;

            return " select ";
        }

        public static string GetEnumDescription<T>(T valor) where T : Enum
        {
            FieldInfo fieldInfo = valor.GetType().GetField(valor.ToString());

            try
            {
                DescriptionAttribute[] atributos = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

                if (atributos != null && atributos.Any())
                {
                    return atributos.First().Description;
                }

                return valor.ToString();
            }
            catch (Exception)
            {
                return " ";
            }
        }
    }
}
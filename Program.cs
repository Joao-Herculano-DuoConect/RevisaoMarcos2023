using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SAPbobsCOM;
using SAPbouiCOM;


namespace RevisaoMarcos
{
    internal static class Program
    {
        public static Application SBOAplication = null; // tipo de  variavel Aplication
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SboGuiApi sboGuiApi = null; // declarando variaveis de conexão
            string sConnection = null; // declarando variaveis de conexão

            sboGuiApi = new SboGuiApi();

            sConnection = "0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056";

        }
    }
}

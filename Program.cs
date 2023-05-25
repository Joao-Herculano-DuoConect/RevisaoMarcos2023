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

            //sConnection = "0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056";

            sboGuiApi.Connect(System.Convert.ToString(Environment.GetCommandLineArgs().GetValue(1)));
            SBOAplication = sboGuiApi.GetApplication();

            SBOAplication.ItemEvent += SBOAplication_ItemEvent;
            SBOAplication.MenuEvent += SBOAplication_MenuEvent;

            // AdicionarMenus()

            SBOAplication.StatusBar.SetText("Add-on Conectado com sucesso", BoMessageTime.bmt_Short, BoStatusBarMessageType.smt_Success);
            
        }

        private static void SBOAplication_MenuEvent(ref MenuEvent pVal, out bool BubbleEvent)
        {
            throw new NotImplementedException();
        }

        private static void SBOAplication_ItemEvent(string FormUID, ref ItemEvent pVal, out bool BubbleEvent)
        {
            throw new NotImplementedException();
        }
    }
}

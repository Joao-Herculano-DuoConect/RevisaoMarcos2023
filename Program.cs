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

            AdicionarMenus();

            SBOAplication.StatusBar.SetText("Add-on Conectado com sucesso", BoMessageTime.bmt_Short, BoStatusBarMessageType.smt_Success);

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run();
        }

        private static void SBOAplication_MenuEvent(ref MenuEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;


        }

        private static void SBOAplication_ItemEvent(string FormUID, ref ItemEvent pVal, out bool BubbleEvent)
        {

            BubbleEvent = true;



        }

        private static void AdicionarMenus()
        {
            Menus menus;
            MenuItem menuItem;

            MenuItem menuItempai = SBOAplication.Menus.Item("2048"); //id do menu de vendas
            MenuCreationParams menuCreationParams = SBOAplication.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams); //declarei a variavel
            menuCreationParams.Type = BoMenuType.mt_POPUP; // recebeu valor da variavel
            menuCreationParams.UniqueID = "2069"; // id do  formulario
            menuCreationParams.String = "Faturamento em lote"; // nome do formulario
            menuCreationParams.Enabled = true; //Habilitei o click
            menuCreationParams.Position = 3; // posição do formulario

            menus = menuItempai.SubMenus; //menuitem pai é o pai do formulario
            try
            {
                menuItem = menus.AddEx(menuCreationParams); //recebeu o valo do formulario dentro do menuItem item


            }
            catch 
            {
                menuItem = SBOAplication.Menus.Item("2048");

                
            }

    
        }
    }
}

using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoMarcos
{
    internal class FiltrarParceiro
    {
        public void Abrirform(Application aplication)
        {
            aplication.StatusBar.SetText("Abrindo formulario", BoMessageTime.bmt_Medium, BoStatusBarMessageType.smt_Warning);
            FormCreationParams formCreation = null;
            formCreation = (FormCreationParams)(aplication.CreateObject(BoCreatableObjectType.cot_FormCreationParams));
            formCreation.BorderStyle = BoFormBorderStyle.fbs_Sizable;
            formCreation.UniqueID = "FilForm";
            formCreation.FormType = "FilForm";

            Form FormFiltro = aplication.Forms.AddEx(formCreation);
            FormFiltro.Freeze(true);
            FormFiltro.Title = "Filtrar Parceiros";
            FormFiltro.Top = 40;
            FormFiltro.Left = 40;
            FormFiltro.Width = 1000;
            FormFiltro.Height = 800;
            FormFiltro.Visible = true;
        }
    }
}

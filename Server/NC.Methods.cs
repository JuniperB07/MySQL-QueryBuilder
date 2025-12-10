using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunX.NET8.WinForms;

namespace MySQL_QueryBuilder.Server
{
    partial class NewConnection
    {
        private void ResetForm()
        {
            Forms.ClearText(ControlHelper<TextBox>.Extract(this));
            newCSM = new ConnectionStringMetadata();
            txtConnectionSTR.Text = newCSM.ConnSTR;

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            connSTR = "";
        }
    }
}

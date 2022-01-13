using Datos;
using System;
using SDML3;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMDL3.BEVEL
{
    public partial class bd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                int sem = Funciones.GetWeekNumber();
                date1.Value = (Request.QueryString["fecha"] != null) ? Request.QueryString["fecha"].ToString() : DateTime.Now.ToString("yyyy") + "-W" + (sem < 10 ? "0" + sem : sem.ToString());
                int semana = Funciones.getWeek(date1.Value);
                string fecha = Funciones.dayOfWeek(date1.Value);
                DataTable dt = Funciones.getDataTable("exec sp_Mod_getDatosSem_v2 '" + fecha + "',16");
                Panel1.Controls.Add(new Label { Text = Funciones.crearTablaBD(dt, semana, "BEVEL [L3]").ToString() });
            }
        }

    }

    
}
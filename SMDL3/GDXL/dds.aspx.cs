using Datos;
using System;
using SDML3;
using System.Data;
using System.Web.UI.WebControls;

namespace SMDL3.GDXL
{
    public partial class dds : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                int sem = Funciones.GetWeekNumber();
                date1.Value = (Request.QueryString["fecha"] != null) ? Request.QueryString["fecha"].ToString() : DateTime.Now.ToString("yyyy") + "-W" + (sem < 10 ? "0" + sem : sem.ToString());
                int semana = Funciones.getWeek(date1.Value);
                string fecha = Funciones.dayOfWeek(date1.Value);
                DataTable dt = Funciones.getDataTable("exec sp_Mod_getDDSSem_v2 '" + fecha + "',13");
                Panel1.Controls.Add(new Label { Text = Funciones.crearTablaDDS(dt, semana, "GD XL [L3]").ToString() });
            }
        }
        }
}
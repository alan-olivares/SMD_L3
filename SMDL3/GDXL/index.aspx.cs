using Datos;
using System;
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
using SDML3;

namespace SMDL3.GDXL
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                int sem = Funciones.GetWeekNumber();
                date1.Value = (Request.QueryString["fecha"] != null) ? Request.QueryString["fecha"].ToString() : DateTime.Now.ToString("yyyy") + "-W" + (sem < 10 ? "0" + sem : sem.ToString());
                //int semana = Funciones.getWeek(date1.Value);
                string fecha = Funciones.dayOfWeek(date1.Value);

                string connStrCrypt = ConfigurationManager.ConnectionStrings["SQLConn"].ConnectionString;
                string connStr = Cipher.Decrypt(connStrCrypt, "Pims.2020");
                //Console.Write(connStr);
                SqlConnection sqlConn = new SqlConnection(connStr);
                SqlCommand sqlcmd;
                sqlcmd = new SqlCommand("exec sp_Mod_getDatos_v2 '" + fecha + "', 13", sqlConn);
                sqlConn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                StringBuilder sb = new StringBuilder();
                sb.Append("<thead>");
                sb.Append("<tr>");
                foreach (DataColumn dc in dt.Columns)
                {
                    if ((dc.ColumnName.ToUpper() != "ORDENAREA") && (dc.ColumnName.ToUpper() != "ORDENIND"))
                    {
                        sb.Append("<th>");
                        sb.Append(dc.ColumnName.ToString());
                        sb.Append("</th>");
                    }
                }
                sb.Append("</tr></thead>");
                sb.Append("<tbody>");
                foreach (DataRow dr in dt.Rows)
                {
                    sb.Append("<tr>");
                    foreach (DataColumn dc in dt.Columns)
                    {
                        if ((dc.ColumnName.ToUpper() != "ORDENAREA") && (dc.ColumnName.ToUpper() != "AREA") && (dc.ColumnName.ToUpper() != "ORDENIND") && (dc.ColumnName.ToUpper() != "INDICADOR") && (dc.ColumnName.ToUpper() != "UNIDAD"))
                        {
                            sb.Append("<td style=\"text-align:right\">");
                            Double val;
                            bool res;
                            res = Double.TryParse(dr[dc.ColumnName].ToString(), out val);
                            if (val > 0)
                            {
                                sb.Append(val.ToString("#,##0.00"));
                            }
                            sb.Append("</td>");
                        }
                        else
                        {
                            if ((dc.ColumnName.ToUpper() == "AREA") || (dc.ColumnName.ToUpper() == "INDICADOR") || (dc.ColumnName.ToUpper() == "UNIDAD"))
                            {
                                sb.Append("<td style=\"text-align:left\">");
                                sb.Append(dr[dc.ColumnName].ToString());
                                sb.Append("</td>");
                            }
                        }
                    }
                    sb.Append("</tr>");
                }
                sb.Append("</tbody>");
                //sb.Append("<tfoot>");
                //sb.Append("<tr>");
                //foreach (DataColumn dc in dt.Columns)
                //{
                //    if ((dc.ColumnName.ToUpper() != "ORDENAREA") && (dc.ColumnName.ToUpper() != "ORDENIND"))
                //    {
                //        sb.Append("<th>");
                //        sb.Append(dc.ColumnName.ToString());
                //        sb.Append("</th>");
                //    }
                //}
                //sb.Append("</tr></tfoot>");
                sqlConn.Close();
                Panel1.Controls.Add(new Label { Text = sb.ToString() });
            }
        }
    }
}
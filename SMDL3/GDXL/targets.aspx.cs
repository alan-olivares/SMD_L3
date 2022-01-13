using Datos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SMDL3.GDXL
{
    public partial class targets : System.Web.UI.Page
    {
        private static string connStrCrypt = ConfigurationManager.ConnectionStrings["SQLConn"].ConnectionString;
        //string cadena=Cipher.Decrypt("zH6yzH99uG94MV7JLMSEvCFFcYJGojn8s9XRTXGoptj2Rs9/LvN97bcVqBnXE3wV/ncgnncmBIzIs7ClvBcZQeqMW02Kn3BmulCHsPh1kqgghbWGuKm7I+MKUJUIEGxHsEiPnweFskBE60gAM85UHA4Tjhn3DUpK2nivZ6d5mkHMdGpvUXPixqMjqxlKqTB4MNmY6M1NeDoeB5acNmCQzA==","Pims.2020");
        //string cadena = Cipher.Encrypt("Data Source=PC2;Initial Catalog=EmployeeDB;User ID=sa;Password=pims.2016;MultipleActiveResultSets=True;", "Pims.2020");
        private static string connStr = Cipher.Decrypt(connStrCrypt, "Pims.2020");
        //Console.Write(connStr);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenaCampos();
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                sqlConn.Open();
                SqlCommand sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt233.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(233).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt234.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(234).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt235.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(235).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt237.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(237).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt238.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(238).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt239.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(239).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt241.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(241).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt242.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(242).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt243.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(243).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt245.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(245).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt246.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(246).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt247.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(247).ToString());
                sqlcmd.ExecuteNonQuery();


                llenaCampos();
            }
        }
        void llenaCampos()
        {
            DataTable dtbl = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                SqlCommand sqlcmd = new SqlCommand("EXEC sp_Mod_getTargets 13", sqlConn);
                sqlConn.Open();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        switch (reader.GetInt32(0))
                        {
                            case 233:
                                txt233.Text=reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 234:
                                txt234.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 235:
                                txt235.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 237:
                                txt237.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 238:
                                txt238.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 239:
                                txt239.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 241:
                                txt241.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 242:
                                txt242.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 243:
                                txt243.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 245:
                                txt245.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 246:
                                txt246.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 247:
                                txt247.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            default:
                                break;
                        }
                    }
                }
                reader.Close();
            }

        }

    }
}
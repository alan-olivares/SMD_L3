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

namespace SMDL3.BEVEL
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
                sqlcmd.Parameters.AddWithValue("@valor", txt369.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(369).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt370.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(370).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt371.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(371).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt373.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(373).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt374.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(374).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt375.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(375).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt377.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(377).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt378.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(378).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt379.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(379).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt381.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(381).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt382.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(382).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt383.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(383).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt385.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(385).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt386.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(386).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt387.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(387).ToString());
                sqlcmd.ExecuteNonQuery();

                llenaCampos();
            }
        }
        void llenaCampos()
        {
            DataTable dtbl = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                SqlCommand sqlcmd = new SqlCommand("EXEC sp_Mod_getTargets 16", sqlConn);
                sqlConn.Open();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        switch (reader.GetInt32(0))
                        {
                            case 369:
                                txt369.Text=reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 370:
                                txt370.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 371:
                                txt371.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 373:
                                txt373.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 374:
                                txt374.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 375:
                                txt375.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 377:
                                txt377.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 378:
                                txt378.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 379:
                                txt379.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 381:
                                txt381.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 382:
                                txt382.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 383:
                                txt383.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 385:
                                txt385.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 386:
                                txt386.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 387:
                                txt387.Text = reader.GetDouble(1).ToString("##0.00");
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
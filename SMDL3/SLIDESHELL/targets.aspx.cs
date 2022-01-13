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

namespace SMDL3.SLIDESHELL
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
                sqlcmd.Parameters.AddWithValue("@valor", txt419.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(419).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt420.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(420).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt421.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(421).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt423.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(423).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt424.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(424).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt425.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(425).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt427.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(427).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt428.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(428).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt429.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(429).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt431.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(431).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt432.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(432).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt433.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(433).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt435.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(435).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt436.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(436).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt437.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(437).ToString());
                sqlcmd.ExecuteNonQuery();
                llenaCampos();
            }
        }
        void llenaCampos()
        {
            DataTable dtbl = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                SqlCommand sqlcmd = new SqlCommand("EXEC sp_Mod_getTargets 17", sqlConn);
                sqlConn.Open();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        switch (reader.GetInt32(0))
                        {
                            case 419:
                                txt419.Text=reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 420:
                                txt420.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 421:
                                txt421.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 423:
                                txt423.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 424:
                                txt424.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 425:
                                txt425.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 427:
                                txt427.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 428:
                                txt428.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 429:
                                txt429.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 431:
                                txt431.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 432:
                                txt432.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 433:
                                txt433.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 435:
                                txt435.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 436:
                                txt436.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 437:
                                txt437.Text = reader.GetDouble(1).ToString("##0.00");
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
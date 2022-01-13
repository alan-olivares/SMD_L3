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

namespace SMDL3.SIDEPACK
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
                sqlcmd.Parameters.AddWithValue("@valor", txt469.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(469).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt470.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(470).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt471.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(471).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt473.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(473).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt474.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(474).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt475.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(475).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt477.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(477).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt478.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(478).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt479.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(479).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt481.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(481).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt482.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(482).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt483.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(483).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt485.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(485).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt486.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(486).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt487.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(487).ToString());
                sqlcmd.ExecuteNonQuery();

                llenaCampos();
            }
        }
        void llenaCampos()
        {
            DataTable dtbl = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                SqlCommand sqlcmd = new SqlCommand("EXEC sp_Mod_getTargets 18", sqlConn);
                sqlConn.Open();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        switch (reader.GetInt32(0))
                        {
                            case 469:
                                txt469.Text=reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 470:
                                txt470.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 471:
                                txt471.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 473:
                                txt473.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 474:
                                txt474.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 475:
                                txt475.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 477:
                                txt477.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 478:
                                txt478.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 479:
                                txt479.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 481:
                                txt481.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 482:
                                txt482.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 483:
                                txt483.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 485:
                                txt485.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 486:
                                txt486.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 487:
                                txt487.Text = reader.GetDouble(1).ToString("##0.00");
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
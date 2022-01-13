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

namespace SMDL3.GD
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
                sqlcmd.Parameters.AddWithValue("@valor", txt273.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(273).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt274.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(274).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt275.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(275).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt277.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(277).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt278.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(278).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt279.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(279).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt281.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(281).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt282.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(282).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt283.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(283).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt285.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(285).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt286.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(286).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt287.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(287).ToString());
                sqlcmd.ExecuteNonQuery();


                llenaCampos();
            }
        }
        void llenaCampos()
        {
            DataTable dtbl = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                SqlCommand sqlcmd = new SqlCommand("EXEC sp_Mod_getTargets 14", sqlConn);
                sqlConn.Open();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        switch (reader.GetInt32(0))
                        {
                            case 273:
                                txt273.Text=reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 274:
                                txt274.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 275:
                                txt275.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 277:
                                txt277.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 278:
                                txt278.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 279:
                                txt279.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 281:
                                txt281.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 282:
                                txt282.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 283:
                                txt283.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 285:
                                txt285.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 286:
                                txt286.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 287:
                                txt287.Text = reader.GetDouble(1).ToString("##0.00");
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
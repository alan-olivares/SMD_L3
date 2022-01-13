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

namespace SMDL3.FOCKE
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
                sqlcmd.Parameters.AddWithValue("@valor", txt319.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(319).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt320.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(320).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt321.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(321).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt323.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(323).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt324.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(324).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt325.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(325).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt327.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(327).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt328.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(328).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt329.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(329).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt331.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(331).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt332.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(332).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt333.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(333).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt335.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(335).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt336.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(336).ToString());
                sqlcmd.ExecuteNonQuery();

                sqlcmd = new SqlCommand("UPDATE En_Targets SET Value=@valor WHERE IndicadorId=@indicador", sqlConn);
                sqlcmd.Parameters.AddWithValue("@valor", txt337.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@indicador", Convert.ToInt32(337).ToString());
                sqlcmd.ExecuteNonQuery();
                llenaCampos();
            }
        }
        void llenaCampos()
        {
            DataTable dtbl = new DataTable();
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                SqlCommand sqlcmd = new SqlCommand("EXEC sp_Mod_getTargets 15", sqlConn);
                sqlConn.Open();
                SqlDataReader reader = sqlcmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        switch (reader.GetInt32(0))
                        {
                            case 319:
                                txt319.Text=reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 320:
                                txt320.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 321:
                                txt321.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 323:
                                txt323.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 324:
                                txt324.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 325:
                                txt325.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 327:
                                txt327.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 328:
                                txt328.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 329:
                                txt329.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 331:
                                txt331.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 332:
                                txt332.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 333:
                                txt333.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 335:
                                txt335.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 336:
                                txt336.Text = reader.GetDouble(1).ToString("##0.00");
                                break;
                            case 337:
                                txt337.Text = reader.GetDouble(1).ToString("##0.00");
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
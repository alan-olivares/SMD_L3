using System;
using System.Globalization;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Datos;
using System.Configuration;
using System.Diagnostics;

namespace SDML3
{
    public class Funciones
    {

        public static int GetWeekNumber()
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }
        public static DateTime dayOfWeek(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;
            DateTime firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            var weekNum = weekOfYear;
            if (firstWeek == 1)
            {
                weekNum -= 1;
            }
            var result = firstThursday.AddDays(weekNum * 7);
            return result.AddDays(-3);
        }
        public static String dayOfWeek(String fecha)
        {
            int year = getYear(fecha);
            int semana = getWeek(fecha);
            return dayOfWeek(year, semana).ToString("yyyy-MM-dd");
        }
        public static int getWeek(String fecha)
        {
            int semana = Int32.Parse(fecha.Substring(fecha.IndexOf('W') + 1));
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour < 7 && GetWeekNumber() == semana)
                semana--;
            return semana;
        }
        public static int getYear(String fecha)
        {
            return Int32.Parse(fecha.Substring(0, 4));
        }
        public static DataTable getDataTable(String consulta) {
            string connStrCrypt = ConfigurationManager.ConnectionStrings["SQLConn"].ConnectionString;
            int desplazaSem;
            string connStr = Cipher.Decrypt(connStrCrypt, "Pims.2020");
            SqlConnection sqlConn = null;
            try
            {
                DataTable dt = new DataTable();
                sqlConn = new SqlConnection(connStr);
                SqlCommand sqlcmd;
                sqlConn.Open();
                sqlcmd = new SqlCommand(consulta, sqlConn);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
                sda.Fill(dt);
                return dt;
            }
            catch(Exception e) {
                Debug.WriteLine(e.Message);
                return null;
            }
            finally {
                if (sqlConn != null)
                    sqlConn.Close();
            }
            
        }
        private static StringBuilder tablaNula() {
            StringBuilder sb = new StringBuilder();
            sb.Append("<thead><tr><th>Problema al obtener los datos de la tabla</th></tr></thead>");
            return sb;
        } 
        public static StringBuilder crearTablaBD(DataTable dt,int semana,String titulo) {
            if (dt == null)
                return tablaNula();
            StringBuilder sb = new StringBuilder();
            sb.Append("<thead>");
            sb.Append("<tr>");
            //sb.Append("<th rowspan=\"2\"></th>");
            sb.Append("<th style=\"color:white; background-color: #C00000\" align=\"center\" rowspan=\"2\" colspan = \"2\"><b>       DASHBOARD "+titulo+"       </b></th>");
            sb.Append("<th style=\"color:white; background-color: #C00000\" align=\"center\" colspan=\"8\" ></b>W" + semana + "</b></th>");
            //sb.Append("<th rowspan=\"2\"> WTD </th></tr>");
            sb.Append("<tr>");
            foreach (DataColumn dc in dt.Columns)
            {
                if ((dc.ColumnName.ToUpper() != "ORDENAREA") && (dc.ColumnName.ToUpper() != "AREA") && (dc.ColumnName.ToUpper() != "ORDENIND") && (dc.ColumnName.ToUpper() != "INDICADOR") && (dc.ColumnName.ToUpper() != "UNIDAD") && (dc.ColumnName.ToUpper() != "CLASE") && (dc.ColumnName.ToUpper() != "HEADCOLOR") && (dc.ColumnName.ToUpper() != "MIDCOLOR") && (dc.ColumnName.ToUpper() != "DETALLECOLOR") && (dc.ColumnName.ToUpper() != "FONTCOLOR"))
                {
                    sb.Append("<th style=\"background-color: #FFE699\">");
                    sb.Append(dc.ColumnName.ToString());
                    sb.Append("</th>");
                }
            }
            sb.Append(getDaysStyle());
            sb.Append("<tbody>");
            int flag = 0;
            foreach (DataRow dr in dt.Rows)
            {
                flag++;

                int val = 0;
                bool res = Int32.TryParse(dr[5].ToString(), out val);
                if (val == 1) //clase titulo
                {
                    sb.Append("<tr>");
                    sb.Append("<td colspan=\"10\" style=\"text-align:center; color: #" + dr[9].ToString() + "; background-color: #" + dr[6].ToString() + "\"><b>");
                    sb.Append(dr[3].ToString());
                    sb.Append("</b></td>");
                }
                else
                {
                    if (val == 2)
                    {
                        sb.Append("<tr>");
                        sb.Append("<td style=\"text-align:left; color: #000000; background-color: #" + dr[6].ToString() + "\">");
                        sb.Append(dr[3].ToString());
                        sb.Append("</td>");
                        sb.Append("<td style=\"text-align:right; color: #000000; background-color: #" + dr[7].ToString() + "\">");
                        sb.Append(dr[4].ToString());
                        sb.Append("</td>");
                    }
                    else
                    {
                        sb.Append("<tr>");
                        sb.Append("<td style=\"text-align:left; color: #000000; background-color: #" + dr[6].ToString() + "\">");
                        sb.Append(dr[3].ToString());
                        sb.Append("</td>");
                        sb.Append("<td style=\"text-align:right; color: #000000; background-color: #" + dr[6].ToString() + "\">");
                        sb.Append(dr[4].ToString());
                        sb.Append("</td>");
                    }
                    Double total = 0;
                    for (int j = 1; j < 8; j++)
                    {
                        Double dato = 0;
                        res = Double.TryParse(dr[j + 9].ToString(), out dato);
                        if (dato > 0)
                        {
                            sb.Append("<td style=\"text-align:right; color:#000000; background-color: #" + dr[8].ToString() + "\">");
                            sb.Append(dato.ToString("#,##0.00"));
                        }
                        else
                            sb.Append("<td style=\"text-align:right; color:#000000; background-color: #" + dr[8].ToString() + "\">");
                        sb.Append("</td>");
                        total += dato;
                    }
                    if (total > 0)
                    {
                        sb.Append("<td style=\"text-align:right; color:#000000; background-color: #FFE699\">");
                        sb.Append(total.ToString("#,##0.00"));
                    }
                    else
                        sb.Append("<td style=\"text-align:right; color:#000000; background-color: #FFE699\">");
                    sb.Append("</td>");
                }
                sb.Append("</tr>");
            }
            sb.Append("<tr style=\"background-color: white;  border:none; height: 30px\"><td style=\"border:none\" colspan=\"10\"></th></tr></tbody>");
            return sb;
        }

        private static string getDaysStyle() {
            return "<th style=\"background-color: #FFE699\"></th>" +
                "<tr><th style=\"background-color: #806000\" colspan=\"2\"></th>" +
                "<th style=\"background-color: #BDD7EE\">MON</th>" +
                "<th style=\"background-color: #BDD7EE\">TUE</th>" +
                "<th style=\"background-color: #BDD7EE\">WED</th>" +
                "<th style=\"background-color: #BDD7EE\">THU</th>" +
                "<th style=\"background-color: #BDD7EE\">FRI</th>" +
                "<th style=\"background-color: #BDD7EE\">SAT</th>" +
                "<th style=\"background-color: #BDD7EE\">SUN</th>" +
                "<th style=\"background-color: #BDD7EE\">WTD</th></tr></thead>";
        }

        public static StringBuilder crearTablaDDS(DataTable dt, int semana, String titulo) {
            if (dt == null)
                return tablaNula();
            StringBuilder sb = new StringBuilder();
            sb.Append("<thead>");
            sb.Append("<tr>");
            sb.Append("<th style=\"color:white; background-color: #C00000\" align=\"center\" rowspan=\"2\" colspan = \"3\"><b>       DASHBOARD "+titulo+"       </b></th>");
            sb.Append("<th style=\"color:white; background-color: #C00000\" align=\"center\" colspan=\"8\" ></b>W" + semana+ "</b></th>");
            sb.Append("<tr>");
            foreach (DataColumn dc in dt.Columns)
            {
                if ((dc.ColumnName.ToUpper() != "ORDENAREA") && (dc.ColumnName.ToUpper() != "AREA") && (dc.ColumnName.ToUpper() != "ORDENIND") && (dc.ColumnName.ToUpper() != "INDICADOR") && (dc.ColumnName.ToUpper() != "UNIDAD") && (dc.ColumnName.ToUpper() != "CLASE") && (dc.ColumnName.ToUpper() != "HEADCOLOR") && (dc.ColumnName.ToUpper() != "MIDCOLOR") && (dc.ColumnName.ToUpper() != "DETALLECOLOR") && (dc.ColumnName.ToUpper() != "FONTCOLOR") && (dc.ColumnName.ToUpper() != "VALUE"))
                {
                    sb.Append("<th style=\"background-color: #FFE699\">");
                    sb.Append(dc.ColumnName.ToString());
                    sb.Append("</th>");
                }
            }
            sb.Append(getDaysStyle());
            sb.Append("<tbody>");
            int flag = 0;
            foreach (DataRow dr in dt.Rows)
            {
                flag++;

                int val = 0;
                bool res = Int32.TryParse(dr[5].ToString(), out val);
                if (val == 1) //clase titulo
                {
                    sb.Append("<tr>");
                    sb.Append("<td colspan=\"11\" style=\"text-align:center; color: #" + dr[9].ToString() + "; background-color: #" + dr[6].ToString() + "\"><b>");
                    sb.Append(dr[3].ToString());
                    sb.Append("</b></td>");
                }
                else
                {
                    if (val == 2)
                    {
                        sb.Append("<tr>");
                        sb.Append("<td style=\"text-align:left; color: #000000; background-color: #" + dr[6].ToString() + "\" colspan=\"2\">");
                        sb.Append(dr[3].ToString());
                        sb.Append("</td>");
                        sb.Append("<td style=\"text-align:right; color: #000000; background-color: #" + dr[7].ToString() + "\">");
                        sb.Append(dr[4].ToString());
                        sb.Append("</td>");
                    }
                    else
                    {
                        sb.Append("<tr>");
                        sb.Append("<td style=\"text-align:left; color: #000000; background-color: #" + dr[6].ToString() + "\">");
                        sb.Append(dr[3].ToString());
                        sb.Append("</td>");
                        sb.Append("<td style=\"text-align:right; color: #000000; background-color: #" + dr[6].ToString() + "\">");
                        sb.Append(dr[4].ToString());
                        sb.Append("</td>");
                        sb.Append("<td style=\"text-align:right; color: #000000; background-color: #" + dr[6].ToString() + "\">");
                        sb.Append(dr[10].ToString());
                        sb.Append("</td>");
                    }
                    Double total = 0;
                    for (int j = 1; j < 8; j++)
                    {
                        Double dato = 0;
                        res = Double.TryParse(dr[j + 10].ToString(), out dato);
                        if (dato > 0)
                        {
                            Double dato2 = 0;
                            res = Double.TryParse(dr[10].ToString(), out dato2);
                            if ((dato2 > 0) && (dato > dato2))
                                sb.Append("<td style=\"text-align:right; color:#000000; background-color: #FFC7CE\">");
                            else
                                sb.Append("<td style=\"text-align:right; color:#000000; background-color: #" + dr[8].ToString() + "\">");
                            sb.Append(dato.ToString("#,##0.00"));
                        }
                        else
                            sb.Append("<td style=\"text-align:right; color:#000000; background-color: #" + dr[8].ToString() + "\">");
                        sb.Append("</td>");
                        total += dato;
                    }
                    if (total > 0)
                    {
                        sb.Append("<td style=\"text-align:right; color:#000000; background-color: #FFE699\">");
                        sb.Append(total.ToString("#,##0.00"));
                    }
                    else
                        sb.Append("<td style=\"text-align:right; color:#000000; background-color: #FFE699\">");
                    sb.Append("</td>");
                }
                sb.Append("</tr>");
            }
            sb.Append("<tr style=\"background-color: white;  border:none; height: 30px\"><td style=\"border:none\" colspan=\"10\"></th></tr></tbody>");
            return sb;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using Project2_Engi3675;

namespace Project2_Engi3675
{
    public class PageLoad
    {
        public void Page_Load(object sender, EventArgs e)
        {
            // the database connection uses integrated security using windows credentials
            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1; Port=5432; Database=Animals; Integrated Security=true;");

            // opening a connection can cause errors, so we will catch any exceptions using the try/catch/finally blocks
            try
            {
                conn.Open();

                // query the database and begin reading results
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.\"Animals\"", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                // iterate through rows and create asp columns for the webpage
                while (dr.Read())
                {
                    // convert pulled results to strings
                    string column1 = 
                    string column2 = string.Format("{0}\n", dr[1]);
                    string column3 = 
                    string column4 =

                    // create a row for each row pulled
                    TableRow newRow1 = new TableRow();
                    TableCell newCell1 = new TableCell();
                    TableCell newCell2 = new TableCell();
                    TableCell newCell3 = new TableCell();
                    TableCell newCell4 = new TableCell();

                    newRow1.Cells.Add(newCell1);
                    newRow1.Cells.Add(newCell2);

                    Label newLabel1 = new Label();
                    Label newLabel2 = new Label();

                    newLabel1.Text = column1;
                    newLabel2.Text = column2;

                    // add labels to each cell and add cells to the rows
                    newCell1.Controls.Add(newLabel1);
                    newCell2.Controls.Add(newLabel2);

                    newRow1.Cells.Add(newCell1);
                    newRow1.Cells.Add(newCell2);

                    this.tblPaint.Rows.Add(newRow1);
                }
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
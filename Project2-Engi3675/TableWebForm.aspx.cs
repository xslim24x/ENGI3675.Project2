using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AnimalData;

namespace Project2_Engi3675
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<int, Animal> AnimalData = ServerConn.DataDict();

            // iterate through rows and create asp columns for the webpage
            foreach (KeyValuePair<int, Animal>a in AnimalData)
            {
                // convert pulled results to strings
                string column1 = a.Key.ToString();
                string column2 = a.Value.AnimalBreed;
                double column3 = a.Value.AnimalWeight;
                double column4 = a.Value.AnimalAge;

                // create a row for each row pulled
                TableRow newRow1 = new TableRow();
                TableCell newCell1 = new TableCell();
                TableCell newCell2 = new TableCell();
                TableCell newCell3 = new TableCell();
                TableCell newCell4 = new TableCell();

                newRow1.Cells.Add(newCell1);
                newRow1.Cells.Add(newCell2);
                newRow1.Cells.Add(newCell3);
                newRow1.Cells.Add(newCell4);

                Label newLabel1 = new Label();
                Label newLabel2 = new Label();
                Label newLabel3 = new Label();
                Label newLabel4 = new Label();

                newLabel1.Text = column1;
                newLabel2.Text = column2;
                newLabel3.Text = column3.ToString();
                newLabel4.Text = column4.ToString();


                // add labels to each cell and add cells to the rows
                newCell1.Controls.Add(newLabel1);
                newCell2.Controls.Add(newLabel2);
                newCell3.Controls.Add(newLabel3);
                newCell4.Controls.Add(newLabel2);

                newRow1.Cells.Add(newCell1);
                newRow1.Cells.Add(newCell2);
                newRow1.Cells.Add(newCell3);
                newRow1.Cells.Add(newCell4);


                this.tblAnimals.Rows.Add(newRow1);
            }
        }
    }
}
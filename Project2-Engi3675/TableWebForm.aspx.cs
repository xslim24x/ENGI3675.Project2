namespace Project2_Engi3675
{
    using System;
    using System.Collections.Generic;
    using System.Web.UI.WebControls;
    using AnimalData;

    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<int, Animal> animalData = ServerConn.DataDict();

            // iterate through rows and create asp columns for the webpage
            foreach (KeyValuePair<int, Animal> a in animalData)
            {
                TableRow tbrow = new TableRow();

                TableCell[] c = new TableCell[6];

                for (int i = 0; i < 6; i++)
                {
                    c[i] = new TableCell();
                }

                c[0].Text = a.Key.ToString();
                c[1].Text = "<input type=\"text\" value=\"" + a.Value.AnimalBreed + "\"/>";
                c[2].Text = "<input type=\"text\" value=\"" + a.Value.AnimalWeight.ToString() + "\"/>";
                c[3].Text = "<input type=\"text\" value=\"" + a.Value.AnimalAge.ToString() + "\"/>";
                c[4].Text = "<Button ID=\"UpdateDB\" runat=\"server\" OnClick=\"dataUpdate\" type=\"Submit\">" + "Submit" + "</button>";
                foreach (TableCell i in c)
                {
                    tbrow.Cells.Add(i);
                }

                tblAnimals.Rows.Add(tbrow);
            }
        }
    }
}
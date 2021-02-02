using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MegaDeskAngeles
{
    public partial class SearchQuotes : Form
    {
        public List<DeskQuote> allTheQuotes;
        private readonly MainMenu mainMenu;

        public SearchQuotes(List<DeskQuote> allTheQuotes, MainMenu theMainMenu)
        {
            this.allTheQuotes = allTheQuotes;

            InitializeComponent();
            mainMenu = theMainMenu;
        }

        //close SearchQuotes and return to Main Menu
        private void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            //MainMenu viewMainMenu = (MainMenu)Tag;
            //viewMainMenu.Show();
            mainMenu.Show();
            Close(); //close SearchQuotes window
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            // Set ComboBoxMaterial options
            List<DesktopMaterial> desktopMaterial = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            ComboBoxMaterial.DataSource = desktopMaterial;


            // Add datagridQuotes header
            //dataGridQuotes.ColumnCount = 8;
            //dataGridQuotes.Columns[0].HeaderCell.Value = "Customer Name";
            //dataGridQuotes.Columns[1].HeaderCell.Value = "Quote Date";
            //dataGridQuotes.Columns[2].HeaderCell.Value = "Desk Width";
            //dataGridQuotes.Columns[3].HeaderCell.Value = "Desk Depth";
            //dataGridQuotes.Columns[4].HeaderCell.Value = "Desk Drawers";
            //dataGridQuotes.Columns[5].HeaderCell.Value = "Desk Depth";
            //dataGridQuotes.Columns[6].HeaderCell.Value = "Rush Order";
            //dataGridQuotes.Columns[7].HeaderCell.Value = "Quote Price";

        }

        private void ComboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {


            Quotes quotesFound = new Quotes();
            List<Quotes> quotes = new List<Quotes>();

            foreach (var item in allTheQuotes)
            {
                int materialItem = (int)ComboBoxMaterial.SelectedItem;
                if ((int)item.desk.Material == materialItem)
                {
                    var material = (DesktopMaterial)materialItem;
                    quotesFound.CustomerName = item.CustomerName;
                    quotesFound.QuoteDate = item.QuoteDate;
                    quotesFound.Width = item.desk.Width;
                    quotesFound.Depth = item.desk.Depth;
                    quotesFound.Material = material.ToString();
                    quotesFound.Drawers = item.desk.Drawers;
                    quotesFound.RushOption = item.RushOption;
                    quotesFound.TotalCost = item.TotalCost;

                    quotes.Add(quotesFound);
                }
            }
            //quotesFound.customerName = "a";
            //quotesFound.quoteDate = "11/11/11";
            //quotesFound.width = 70;
            //quotesFound.depth = 70;
            //quotesFound.material = "Oak";
            //quotesFound.drawers = 4;
            //quotesFound.rushOption = "3 days";
            //quotesFound.totalCost = 1200;




            //var source = new BindingSource();

            //source.DataSource = quotes;

            dataGridQuotes.AutoGenerateColumns = true;
            dataGridQuotes.DataSource = quotes;
            Console.WriteLine(dataGridQuotes.Rows.Count);
        }
    }
}

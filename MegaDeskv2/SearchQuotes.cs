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

        private void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            Close(); //close SearchQuotes window
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            // Set ComboBoxMaterial options
            List<DesktopMaterial> desktopMaterial = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            ComboBoxMaterial.DataSource = desktopMaterial;
        }

        private void ComboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set struct with all columns required for the datagrid
            Quotes quotesFound = new Quotes();
            List<Quotes> quotes = new List<Quotes>();

            // Fill quotes list with the records that match the search
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
                    quotesFound.Area = item.desk.CalculateArea();
                    quotes.Add(quotesFound);
                }
            }

            // Update datagrid
            dataGridQuotes.AutoGenerateColumns = true;
            dataGridQuotes.DataSource = quotes;
        }

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Return to Main Menu
            mainMenu.Show();
        }
    }
}

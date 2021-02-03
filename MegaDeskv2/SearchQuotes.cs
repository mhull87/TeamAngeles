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
                    quotesFound.Area = item.desk.CalculateArea();
                    quotes.Add(quotesFound);
                }
            }

            dataGridQuotes.AutoGenerateColumns = true;
            dataGridQuotes.DataSource = quotes;
            Console.WriteLine(dataGridQuotes.Rows.Count);
        }
    }
}

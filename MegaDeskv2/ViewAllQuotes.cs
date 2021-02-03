using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MegaDeskAngeles
{
    public partial class ViewAllQuotes : Form
    {
        public List<DeskQuote> allTheQuotes;

        public ViewAllQuotes(List<DeskQuote> allTheQuotes)
        {
            this.allTheQuotes = allTheQuotes;
            InitializeComponent();
        }

        /// <summary>
        /// close ViewAllQuotes window and return to Main Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            Close(); //close ViewAllQuotes window
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            Quotes quotesFound = new Quotes();
            List<Quotes> quotes = new List<Quotes>();

            foreach (var item in allTheQuotes)
            {
                    quotesFound.CustomerName = item.CustomerName;
                    quotesFound.QuoteDate = item.QuoteDate;
                    quotesFound.Width = item.desk.Width;
                    quotesFound.Depth = item.desk.Depth;
                    quotesFound.Material = item.desk.Material.ToString();
                    quotesFound.Drawers = item.desk.Drawers;
                    quotesFound.RushOption = item.RushOption;
                    quotesFound.TotalCost = item.TotalCost;
                    quotesFound.Area = item.desk.CalculateArea();
                    quotes.Add(quotesFound);
            }

            dataGridViewAll.AutoGenerateColumns = true;
            dataGridViewAll.DataSource = quotes;
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Return to Main Menu
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
        }
    }
}

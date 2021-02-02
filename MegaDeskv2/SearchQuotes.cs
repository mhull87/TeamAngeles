using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskAngeles
{
    public partial class SearchQuotes : Form
    {
        public List<DeskQuote> allTheQuotes;
        private MainMenu mainMenu;

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

            quotesFound.customerName = "a";
            quotesFound.quoteDate ="11/11/11"
            
            var source = new BindingSource();

            source.DataSource = allTheQuotes;
            dataGridQuotes.DataSource = source;
        }
    }
}

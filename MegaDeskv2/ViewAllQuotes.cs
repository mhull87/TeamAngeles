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
    public partial class ViewAllQuotes : Form
    {
        public List<DeskQuote> AllTheQuotes;

        public ViewAllQuotes(List<DeskQuote> AllTheQuotes) 
        {
            InitializeComponent();
            this.AllTheQuotes = AllTheQuotes;

            /*var list = new BindingList<DeskQuote>(AllTheQuotes);
            dataGridViewAll.DataSource = list;*/

            //dataGridViewAll.DataSource = AllTheQuotes; this didn't work
        }

        /// <summary>
        /// close ViewAllQuotes window and return to Main Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close(); //close ViewAllQuotes window
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            dataGridViewAll.DataSource = AllTheQuotes;
        }
    }
}

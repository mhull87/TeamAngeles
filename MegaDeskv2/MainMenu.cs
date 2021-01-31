using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MegaDeskAngeles
{
    public partial class MainMenu : Form
    {
        public List<DeskQuote> AllTheQuotes;
        public MainMenu()
        {
            InitializeComponent();
            AllTheQuotes = new List<DeskQuote>();
        }

        //exit application
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// go to AddQuote, hide MainMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddNewQuote_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = new AddQuote(AllTheQuotes, this)
            {
                Tag = this
            };
            viewAddQuote.Show(this);
            Hide(); //hide MainMenu            
        }

        /// <summary>
        /// Go to ViewAllQuotes, hide MainMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes
            {
                Tag = this
            };
            viewAllQuotes.Show(this);
            Hide(); //hide MainMenu
        }

        /// <summary>
        /// got to SearchQuotes, hide MainMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes
            {
                Tag = this
            };
            viewSearchQuotes.Show(this);
            Hide(); //hide MainMenu
        }
    }
}

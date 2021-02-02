using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace MegaDeskAngeles
{
    public partial class MainMenu : Form
    {
        public List<DeskQuote> AllTheQuotes;

        

        public MainMenu()
        {
            InitializeComponent();
            AllTheQuotes = new List<DeskQuote>();

            //deserializing list of quotes into AllTheQuotes object from quotes.json
            //see https://stackoverflow.com/questions/16416138/c-sharp-json-file-into-list
           
            try
            {
                string json = File.ReadAllText("quotes.json", System.Text.Encoding.UTF8);
                AllTheQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
                Console.WriteLine("revisar json");
            }
            catch (Exception ex)
            {

                MessageBox.Show("No quotes added", String.Format("Error: {0}", ex.Message));
            }
            
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
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes(AllTheQuotes) 
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
            SearchQuotes viewSearchQuotes = new SearchQuotes(this.AllTheQuotes, this);
            viewSearchQuotes.Show(this);
            Hide(); //hide MainMenu
        }
    }
}

﻿using System;
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
        public SearchQuotes() //List<DeskQuote> AllTheQuotes
        {
            InitializeComponent();
        }

        //close SearchQuotes and return to Main Menu
        private void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close(); //close SearchQuotes window
        }
    }
}

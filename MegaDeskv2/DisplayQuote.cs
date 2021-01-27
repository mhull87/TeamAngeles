using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Wicker
{
    public partial class DisplayQuote : Form
    {
        Desk _desk = new Desk();

        public DisplayQuote(Desk desk)
        {
            _desk = desk;
            InitializeComponent();
        }

        


        private void ButtonBack_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = (AddQuote)Tag;
            viewAddQuote.Show(); //return to AddQuote form
            Close(); //close DisplayQuote form
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            TextBoxDate.Text = _desk.QuoteDate.ToShortDateString();
            TextBoxName.Text = _desk.CustomerName;
            TextBoxWidth.Text = _desk.Width.ToString();
            TextBoxDepth.Text = _desk.Depth.ToString();
            TextBoxDrawers.Text = _desk.Drawers.ToString();
            TextBoxMaterial.Text = _desk.Material.ToString();
            TextBoxRush.Text = _desk.ProductionDays.ToString();
            TextBoxPrice.Text = $@"$ {_desk.Price}.00";
        }
    }
}

using System;
using System.Windows.Forms;

namespace MegaDeskAngeles

{
    public partial class DisplayQuote : Form
    {
        readonly Desk Desk = new Desk();

        public DisplayQuote(Desk desk)
        {
            Desk = desk;
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
            TextBoxDate.Text = Desk.QuoteDate.ToShortDateString();
            TextBoxName.Text = Desk.CustomerName;
            TextBoxWidth.Text = Desk.Width.ToString();
            TextBoxDepth.Text = Desk.Depth.ToString();
            TextBoxDrawers.Text = Desk.Drawers.ToString();
            TextBoxMaterial.Text = Desk.Material.ToString();
            TextBoxRush.Text = Desk.ShippingBox.ToString();
            TextBoxPrice.Text = $@"${Desk.Price}.00";
        }
    }
}

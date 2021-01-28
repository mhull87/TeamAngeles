using System;
using System.Windows.Forms;

namespace MegaDesk_Wicker

{
    public partial class DisplayQuote : Form
    {
        readonly Desk desk = new Desk();

        public DisplayQuote(Desk desk)
        {
            this.desk = desk;
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
            TextBoxDate.Text = desk.QuoteDate.ToShortDateString();
            TextBoxName.Text = desk.CustomerName;
            TextBoxWidth.Text = desk.Width.ToString();
            TextBoxDepth.Text = desk.Depth.ToString();
            TextBoxDrawers.Text = desk.Drawers.ToString();
            TextBoxMaterial.Text = desk.Material.ToString();
            TextBoxRush.Text = desk.ProductionDays.ToString();
            TextBoxPrice.Text = $@"${desk.Price}.00";
        }
    }
}

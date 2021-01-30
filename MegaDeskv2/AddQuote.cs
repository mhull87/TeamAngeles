using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MegaDeskAngeles
{
    public partial class AddQuote : Form
    {

        DateTime todayDate = DateTime.Today;

        List<DeskQuote> AllTheQuotes;
        public AddQuote(List<DeskQuote> AllTheQuotes)
        {
            InitializeComponent();
            LabelDate.Text = todayDate.ToString("MMM dd, yyyy");
            this.AllTheQuotes = AllTheQuotes;
        }

        public Desk Desk = new Desk();
        public DeskQuote DeskQuote = new DeskQuote();

        /// <summary>
        /// Close AddQuote and return to Main Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close(); //close AddQuote window
        }

        private void TextBoxWidth_Validating(object sender, CancelEventArgs e)
        {
            int widthInput = 0;
            try
            {
                widthInput = int.Parse(TextBoxWidth.Text);
            }
            catch (FormatException)
            {
                e.Cancel = true;
                errorProvider1.SetError(TextBoxWidth, "Please provide a number");
                errorProvider2.SetError(TextBoxWidth, "");
                errorProvider3.SetError(TextBoxWidth, "");
            }

            if (widthInput < Desk.MINWIDTH || widthInput > Desk.MAXWIDTH)
            {
                e.Cancel = true;
                errorProvider1.SetError(TextBoxWidth, "");
                errorProvider2.SetError(TextBoxWidth, "Number out of range");
                errorProvider3.SetError(TextBoxWidth, "");
            }
            else
            {
                errorProvider1.SetError(TextBoxWidth, "");
                errorProvider2.SetError(TextBoxWidth, "");
                errorProvider3.SetError(TextBoxWidth, ""); //Correct

                //set input into _desk
                Desk.width = widthInput;
            }
        }

        private void TextBoxDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            //determine if the keypress is a digit and no control characters
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;  //cancels the Keypress event
            }
        }

        private void TextBoxDepth_Validating(object sender, CancelEventArgs e)
        {
            int depthInput;
            try
            {
                depthInput = int.Parse(TextBoxDepth.Text);
            }
            catch (Exception)
            {
                throw;
            }
            if (depthInput < Desk.MINDEPTH || depthInput > Desk.MAXDEPTH)
            {
                //not in range
                e.Cancel = true;
                //TextBoxDepth.BackColor = Color.Tomato;
                errorProvider1.SetError(TextBoxDepth, "");
                errorProvider2.SetError(TextBoxDepth, "Not in range");
                errorProvider3.SetError(TextBoxDepth, "");
            }
            else
            {
                //in range
                //TextBoxDepth.BackColor = SystemColors.Window;
                errorProvider1.SetError(TextBoxDepth, "");
                errorProvider2.SetError(TextBoxDepth, "");
                errorProvider3.SetError(TextBoxDepth, ""); //Correct

                // set input into _desk
                Desk.depth = depthInput;
            }
        }

        private void TextBoxCustomerName_Validating(object sender, CancelEventArgs e)
        {
            string nameInput = TextBoxCustomerName.Text;
            if (nameInput == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(TextBoxCustomerName, "Please enter a name");
                errorProvider2.SetError(TextBoxCustomerName, "");
                errorProvider3.SetError(TextBoxCustomerName, "");
            }
            else
            {
                errorProvider1.SetError(TextBoxCustomerName, "");
                errorProvider2.SetError(TextBoxCustomerName, "");
                errorProvider3.SetError(TextBoxCustomerName, ""); //Correct

                // set input into _desk
                DeskQuote.customerName = nameInput;
            }
        }

        private void ComboBoxDrawers_Validating(object sender, CancelEventArgs e)
        {
            int drawerInput = int.Parse(UpDownDrawers.Text);
            //'drawerInput == 0' causes a validation error if 0 drawers is selected
            if (drawerInput == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(UpDownDrawers, "Please select a number");
                errorProvider2.SetError(UpDownDrawers, "");
                errorProvider3.SetError(UpDownDrawers, "");
            }
            else
            {
                errorProvider1.SetError(UpDownDrawers, "");
                errorProvider2.SetError(UpDownDrawers, "");
                errorProvider3.SetError(UpDownDrawers, ""); //Correct

                // set input into _desk
                Desk.drawers = drawerInput;
            }
        }

        private void ValidateDesk()
        {
            var deskWidth = TextBoxWidth.Text;
            var deskDepth = TextBoxDepth.Text;
            var drawerNum = UpDownDrawers.Text;
            var materialType = ComboBoxMaterial.SelectedItem;

            if (deskWidth != String.Empty)
            {
                Desk.width = Convert.ToInt32(deskWidth);
            }
            if (deskDepth != String.Empty)
            {
                Desk.depth = Convert.ToInt32(deskDepth);
            }
                Desk.Material = (DesktopMaterial)materialType;
            if (drawerNum != String.Empty)
            {
                Desk.drawers = Convert.ToInt32(drawerNum);
            }
        }

        private void ValidateDeskQuote()
        {
            var customerName = TextBoxCustomerName.Text;
            var todayDate = LabelDate.Text;
            var rushTime = RushBox.Text;

            if (customerName != String.Empty)
            {
                DeskQuote.customerName = customerName;
            }
            if (todayDate != String.Empty)
            {
                DeskQuote.quoteDate = todayDate;
            }
            if (rushTime != String.Empty)
            {
                DeskQuote.rushOption = rushTime;
            }
            DeskQuote.desk = Desk;
        }

        private void ButtonGetQuote_Click(object sender, EventArgs e)
        {
            ValidateDesk();
            ValidateDeskQuote();
            var displayQuote = new DisplayQuote(AllTheQuotes, DeskQuote)
            {
                Tag = this
            };
            displayQuote.Show(this);
            Hide(); //hide AddQuote form
        }

        private void ComboBoxMaterial_Click(object sender, EventArgs e)
        {
            //populate materials combobox with enum List<DesktopMaterial> values
            List<DesktopMaterial> desktopMaterial = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            ComboBoxMaterial.DataSource = desktopMaterial;
        }
    }
}
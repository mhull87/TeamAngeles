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
        readonly DateTime todayDate = DateTime.Today;
        readonly List<DeskQuote> AllTheQuotes;

        //desk not required; it is inside deskquote
        public DeskQuote DeskQuote;

        private readonly MainMenu mainMenu;

        public AddQuote(List<DeskQuote> AllTheQuotes, MainMenu theMainMenu)
        {
            InitializeComponent();
            LabelDate.Text = todayDate.ToString("MMM dd, yyyy");
            this.AllTheQuotes = AllTheQuotes;
            DeskQuote = new DeskQuote();
            mainMenu = theMainMenu;
        }

        /// <summary>
        /// Close AddQuote and return to Main Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMainMenu_Click(object sender, EventArgs e)
        {
            Close(); //close AddQuote form
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
                DeskQuote.desk.Width = widthInput;
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
                DeskQuote.desk.Depth = depthInput;
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
                DeskQuote.CustomerName = nameInput;
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
                DeskQuote.desk.Drawers = drawerInput;
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
                DeskQuote.desk.Width = Convert.ToInt32(deskWidth);
            }
            if (deskDepth != String.Empty)
            {
                DeskQuote.desk.Depth = Convert.ToInt32(deskDepth);
            }
            DeskQuote.desk.Material = (DesktopMaterial)materialType;
            if (drawerNum != String.Empty)
            {
                DeskQuote.desk.Drawers = Convert.ToInt32(drawerNum);
            }
        }

        private void ValidateDeskQuote()
        {
            var customerName = TextBoxCustomerName.Text;
            var todayDate = LabelDate.Text;
            var rushTime = RushBox.Text;

            if (customerName != String.Empty)
            {
                DeskQuote.CustomerName = customerName;
            }
            if (todayDate != String.Empty)
            {
                DeskQuote.QuoteDate = todayDate;
            }
            if (rushTime != String.Empty)
            {
                DeskQuote.RushOption = rushTime;
            }
        }

        private void ButtonGetQuote_Click(object sender, EventArgs e)
        {
            ValidateDesk();
            ValidateDeskQuote();
            var displayQuote = new DisplayQuote(AllTheQuotes, DeskQuote, mainMenu)
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

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Go back to Main Menu
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
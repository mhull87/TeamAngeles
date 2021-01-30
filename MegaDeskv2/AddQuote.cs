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
        public AddQuote()
        {
            InitializeComponent();
        }

        public Desk desk = new Desk();

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
                desk.Width = widthInput;
            }
        }

        //since this is a KeyPress event and not a Validating event, the errorProviders did not work correctly. Used color state change instead.
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
                desk.Depth = depthInput;
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            //get the date
            LabelDate.Text = DateTime.Now.ToShortDateString();
            desk.QuoteDate = DateTime.Now;
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
                desk.CustomerName = nameInput;
            }
        }

        private void ComboBoxDrawers_Validating(object sender, CancelEventArgs e)
        {
            int drawerInput = int.Parse(ComboBoxDrawers.Text);
            if (drawerInput == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(ComboBoxDrawers, "Please select a number");
                errorProvider2.SetError(ComboBoxDrawers, "");
                errorProvider3.SetError(ComboBoxDrawers, "");
            }
            else
            {
                errorProvider1.SetError(ComboBoxDrawers, "");
                errorProvider2.SetError(ComboBoxDrawers, "");
                errorProvider3.SetError(ComboBoxDrawers, ""); //Correct

                // set input into _desk
                desk.Drawers = drawerInput;
            }
        }

/*        private void ComboBoxMaterial_Validating(object sender, CancelEventArgs e)
        {
            DesktopMaterial materialInput = (DesktopMaterial)ComboBoxMaterial.SelectedItem;
            if (materialInput == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(ComboBoxMaterial, "Please select a material");
                errorProvider2.SetError(ComboBoxMaterial, "");
                errorProvider3.SetError(ComboBoxMaterial, "");
            }
            else
            {
                errorProvider1.SetError(ComboBoxMaterial, "");
                errorProvider2.SetError(ComboBoxMaterial, "");
                errorProvider3.SetError(ComboBoxMaterial, ""); //Correct

                // set input into _desk
                desk.Material = materialInput;
            }
        }

        private void ComboBoxRush_Validating(object sender, CancelEventArgs e)
        {
            int rushInput = int.Parse(ComboBoxRush.Text);
            if (rushInput == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(ComboBoxRush, "Please select a number");
                errorProvider2.SetError(ComboBoxRush, "");
                errorProvider3.SetError(ComboBoxRush, "");
            }
            else
            {
                errorProvider1.SetError(ComboBoxRush, "");
                errorProvider2.SetError(ComboBoxRush, "");
                errorProvider3.SetError(ComboBoxRush, ""); //Correct

                // set input into _desk
                desk.ProductionDays = rushInput;
            }
        }
*/
        private void CalculateQuote()
        {
            //base desk price
            desk.Price = 200;

            //get area
            desk.Area = desk.Width * desk.Depth;

            //add surface area charge, $1 per in^2 above 1000in^2
            if (desk.Area > 1000)
            {
                desk.Price += (desk.Area - 1000);
            }

            //add drawers charge
            desk.Price += (desk.Drawers * 50);

            //add materials charge
            switch (desk.Material)
            {
                case DesktopMaterial.Oak:
                    desk.Price += 200;
                    break;
                case DesktopMaterial.Laminate:
                    desk.Price += 100;
                    break;
                case DesktopMaterial.Pine:
                    desk.Price += 50;
                    break;
                case DesktopMaterial.Rosewood:
                    desk.Price += 300;
                    break;
                case DesktopMaterial.Veneer:
                    desk.Price += 125;
                    break;
                default:
                    desk.Price += 0;
                    //send an alert to warn the user about default use
                    MessageBox.Show("Desktop Material charge defaulted to $0");
                    break;
            }
            /*
                        //calculate rush order charge, if any
                        int rush;
                        switch (desk.ProductionDays)
                        {
                            case 3:
                                if (desk.Area < 1000)
                                    rush = 60;
                                else if (desk.Area < 2000)
                                    rush = 70;
                                else
                                    rush = 80;
                                break;
                            case 5:
                                if (desk.Area < 1000)
                                    rush = 40;
                                else if (desk.Area < 2000)
                                    rush = 50;
                                else
                                    rush = 60;
                                break;
                            case 7:
                                if (desk.Area < 1000)
                                    rush = 30;
                                else if (desk.Area < 2000)
                                    rush = 35;
                                else
                                    rush = 40;
                                break;
                            case 14:
                                rush = 0;
                                break;
                            default:
                                rush = 0;
                                //send an alarm to warn the user about default use
                                MessageBox.Show("Rush Order charge defaulted to $0");
                                break;
                        }


                        //add rush charge to price

            */
            int Shipping = ShippingSelection(desk.Area);
            desk.Price += Shipping;
        }

        public int ShippingSelection(int Area)
        {
            if (Rush3.Checked)
            {
                if (Area < 1000)
                {
                    return 60;
                }
                else if (Area > 999 && Area < 2001)
                {
                    return 70;
                }
                else
                {
                    return 80;
                }
            }
            else if (Rush5.Checked)
            {
                if (Area < 1000)
                {
                    return 40;
                }
                else if (Area > 999 && Area < 2001)
                {
                    return 50;
                }
                else
                {
                    return 60;
                }
            }
            else if (Rush7.Checked)
            {
                if (Area < 1000)
                {
                    return 30;
                }
                else if (Area > 999 && Area < 2001)
                {
                    return 35;
                }
                else
                {
                    return 40;
                }
            }
            else
            {
                return 0;
            }
        }


        private void ButtonGetQuote_Click(object sender, EventArgs e)
        {
            CalculateQuote();
            var displayQuote = new DisplayQuote(desk)
            {
                Tag = this
            };
            displayQuote.Show(this);
            Hide(); //hide AddQuote form
        }

        private void ComboBoxMaterial_Click(object sender, EventArgs e)
        {
            List<DesktopMaterial> desktopMaterial = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            ComboBoxMaterial.DataSource = desktopMaterial;
        }
    }
}

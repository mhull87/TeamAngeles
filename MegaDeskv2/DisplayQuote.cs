using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace MegaDeskAngeles

{
    public partial class DisplayQuote : Form
    {
        //readonly Desk Desk;
        readonly DeskQuote DeskQuote;
        readonly List<DeskQuote> AllTheQuotes;

        private readonly MainMenu mainMenu;

        public DisplayQuote(List<DeskQuote> AllTheQuotes, DeskQuote deskQuote, MainMenu theMainMenu)
        {
            DeskQuote = deskQuote;
            // Desk = desk; removed desk, referring to it thorugh the deskQuote and only passing deskQuote to save
            InitializeComponent();
            this.AllTheQuotes = AllTheQuotes;
            mainMenu = theMainMenu;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = (AddQuote)Tag;
            viewAddQuote.Show(); //return to AddQuote form
            Close(); //close DisplayQuote form
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            TextBoxDate.Text = DeskQuote.QuoteDate;
            TextBoxName.Text = DeskQuote.CustomerName;
            TextBoxWidth.Text = DeskQuote.desk.Width.ToString();
            TextBoxDepth.Text = DeskQuote.desk.Depth.ToString();
            TextBoxDrawers.Text = DeskQuote.desk.Drawers.ToString();
            TextBoxMaterial.Text = DeskQuote.desk.Material.ToString();
            TextBoxRush.Text = DeskQuote.RushOption.ToString();
            TextBoxPrice.Text = $@"${DeskQuote.TotalQuote()}.00";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            //This block successfully saves the quotes to memory. Can be pulled out with Json or straight from memory. See quotes.json file.
            //add current qoute to quote list
            AllTheQuotes.Add(DeskQuote);

            //serializing to json string
            var jsonString = JsonConvert.SerializeObject(AllTheQuotes);

            // See https://docs.microsoft.com/en-us/dotnet/api/system.io.file.openwrite?view=net-5.0            
            FileStream fs = File.OpenWrite("quotes.json");
            Byte[] bytes = new UTF8Encoding(true).GetBytes(jsonString);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();

            LabelSaveStatus.Text = "Okay"; //quote saved notice

            //add code to return to main menu
            mainMenu.Show();
            this.Close();
        }

        private void TextBoxDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace MegaDeskAngeles

{
    public partial class DisplayQuote : Form
    {
        //readonly Desk Desk;
        readonly DeskQuote DeskQuote;

        List<DeskQuote> AllTheQuotes;

        private MainMenu mainMenu;

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
            TextBoxDate.Text = DeskQuote.quoteDate;
            TextBoxName.Text = DeskQuote.customerName;
            TextBoxWidth.Text = DeskQuote.desk.width.ToString();
            TextBoxDepth.Text = DeskQuote.desk.depth.ToString();
            TextBoxDrawers.Text = DeskQuote.desk.drawers.ToString();
            TextBoxMaterial.Text = DeskQuote.desk.Material.ToString();
            TextBoxRush.Text = DeskQuote.rushOption.ToString();
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
            Byte[] bytes = new System.Text.UTF8Encoding(true).GetBytes(jsonString);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();

            LabelSaveStatus.Text = "Okay"; //quote saved notice

            //add code to return to main menu
            mainMenu.Show();
            this.Close();
            

           


            // This code is totally useless here, but will be useful to write out the saved quotes. Use elsewhere!
            ////deserializing to object
            //var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DeskQuote>>(jsonString);
        }

       
        //example code for a method to add a new object to an existing JSON file
        /*public string AddObjectsToJson<T>(string json, List<T> objects)
        {
            List<T> list = JsonConvert.DeserializeObject<List<T>>(json);
            list.AddRange(objects);
            return JsonConvert.SerializeObject(list);
        }*/

        //example code using method above
        /*public string AddObjectsToJson<T>(string json, List<T> objects)
        {
            List<T> list = JsonConvert.DeserializeObject<List<T>>(json);
            list.AddRange(objects);
            return JsonConvert.SerializeObject(list);
        }*/
    }
}
using System;
using System.Windows.Forms;

namespace MegaDeskAngeles

{
    public partial class DisplayQuote : Form
    {
        readonly Desk Desk;
        readonly DeskQuote DeskQuote;

        public DisplayQuote(Desk desk, DeskQuote deskQuote)
        {
            DeskQuote = deskQuote;
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
            TextBoxDate.Text = DeskQuote.quoteDate;
            TextBoxName.Text = DeskQuote.customerName;
            TextBoxWidth.Text = Desk.width.ToString();
            TextBoxDepth.Text = Desk.depth.ToString();
            TextBoxDrawers.Text = Desk.drawers.ToString();
            TextBoxMaterial.Text = Desk.Material.ToString();
            TextBoxRush.Text = DeskQuote.rushOption.ToString();
            TextBoxPrice.Text = $@"${DeskQuote.TotalQuote()}.00";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            //send desk obj to json file



            //serializing to json string
            //sending/returning desk but it should be quote
            /*var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(desk);

            //deserializing to object
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Desk>(jsonString);*/
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
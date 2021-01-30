using System;
using System.Windows.Forms;
using Newtonsoft.Json;

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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
                       
            //send desk obj to json file



            //serializing to json string
            //sending/returning desk but it should be quote
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(Desk);

            //deserializing to object
            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Desk>(jsonString);
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

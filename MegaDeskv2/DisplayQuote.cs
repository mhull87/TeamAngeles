using System;
using System.Windows.Forms;

namespace MegaDeskAngeles

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
            TextBoxRush.Text = desk.Shipping.ToString();
            TextBoxPrice.Text = $@"${desk.Price}.00";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
                       
            //send desk obj to json file



            //serializing to json string
            //sending/returning desk but it should be quote
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(desk);

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

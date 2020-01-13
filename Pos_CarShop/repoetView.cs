using MongoDB.Driver;
using Newtonsoft.Json;
using Pos_CarShop.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pos_CarShop
{
    public partial class repoetView : Form
    {
        public readonly IMongoCollection<ProductModel> _GetDatabaseservice;
        public readonly IMongoCollection<cartModel> _GetCartservice;
        public readonly IMongoCollection<logModel> _GetLogtservice;

        public repoetView()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Shop_db");

            _GetDatabaseservice = database.GetCollection<ProductModel>("product");
            _GetCartservice = database.GetCollection<cartModel>("cart");
            _GetLogtservice = database.GetCollection<logModel>("log");
        }

        private void repoetView_Load(object sender, EventArgs e)
        {
            var data = _GetLogtservice.Find(it => true).FirstOrDefault();

            var json = JsonConvert.SerializeObject(data);

            XNode node = JsonConvert.DeserializeXNode(json,"root");
            System.IO.StringReader xmlSR = new System.IO.StringReader(node.ToString());

            dataSet.ReadXml(xmlSR);

            //DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);
        }
    }
}
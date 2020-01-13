using MongoDB.Driver;
using MongoDB.Driver.Linq;
using OfficeOpenXml;
using Pos_CarShop.Models;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

namespace Pos_CarShop
{
    public partial class main : Form
    {
        public readonly IMongoCollection<ProductModel> _GetDatabaseservice;
        public readonly IMongoCollection<cartModel> _GetCartservice;
        public readonly IMongoCollection<logModel> _GetLogtservice;

        public main()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Shop_db");

            _GetDatabaseservice = database.GetCollection<ProductModel>("product");
            _GetCartservice = database.GetCollection<cartModel>("cart");
            _GetLogtservice = database.GetCollection<logModel>("log");
        }

        private void main_Load(object sender, EventArgs e)
        {
            double allPrice = 0;

            welcome1.Visible = true;
            addproduct1.Visible = false;

            var cartData = _GetCartservice.Find(it => true).ToList();

            string root = @"D:\POS_Log";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }

            cartGridView.DataSource = cartData;

            foreach (var summary in cartData)
            {
                allPrice = allPrice + summary.price;
            }

            sumCallabel.Text = allPrice.ToString();

            timer1.Start();
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void GotoProductTypeBtn_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;
            select_Product.Visible = true;

            sparePartsBox.Visible = true;
            eletroBox.Visible = true;
            enginsBox.Visible = true;
            fixBox.Visible = true;
            powerUnitBox.Visible = true;
            suspensionBox.Visible = true;
            tiresWheelsBox.Visible = true;

            bannerPic.Visible = false;
            dataGridView.Visible = false;
            welcome1.Visible = false;
            addproduct1.Visible = false;
        }

        private void welcomeBtn_Click(object sender, EventArgs e)
        {
            sparePartsBox.Visible = false;
            eletroBox.Visible = false;
            enginsBox.Visible = false;
            fixBox.Visible = false;
            powerUnitBox.Visible = false;
            suspensionBox.Visible = false;
            tiresWheelsBox.Visible = false;

            label12.Visible = false;
            SearchBox.Visible = false;
            SearchButton.Visible = false;
            select_Product.Visible = false;

            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;

            bannerPic.Visible = true;
            dataGridView.Visible = false;
            welcome1.Visible = true;
            addproduct1.Visible = false;
        }

        private void addProductbutton_Click(object sender, EventArgs e)
        {
            sparePartsBox.Visible = false;
            eletroBox.Visible = false;
            enginsBox.Visible = false;
            fixBox.Visible = false;
            powerUnitBox.Visible = false;
            suspensionBox.Visible = false;
            tiresWheelsBox.Visible = false;

            label12.Visible = false;
            SearchBox.Visible = false;
            SearchButton.Visible = false;
            select_Product.Visible = false;

            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;

            welcome1.Visible = false;
            addproduct1.Visible = true;

            dataGridView.Visible = false;

            bannerPic.Visible = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string strKeyword = SearchBox.Text;

            var ds = _GetDatabaseservice.Find(it =>
            it.productType.Contains(strKeyword) ||
            it.productName.Contains(strKeyword) ||
            it.brand.Contains(strKeyword)).ToList();

            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;
            select_Product.Visible = true;

            dataGridView.Visible = true;
            dataGridView.DataSource = ds;
        }

        private void sparePartsBox_Click(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;
            select_Product.Visible = true;

            dataGridView.Visible = true;
            var data = _GetDatabaseservice.Find(it => it.productType.Contains("ของแต่ง")).ToList();
            if (data == null)
            {
                MessageBox.Show("ไม่มีสินค้าประเภท ของแต่ง ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = data;
            }
        }

        private void eletroBox_Click(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;
            select_Product.Visible = true;

            dataGridView.Visible = true;
            var data = _GetDatabaseservice.Find(it => it.productType.Contains("ระบบไฟ")).ToList();
            if (data == null)
            {
                MessageBox.Show("ไม่มีสินค้าประเภท ระบบไฟ ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = data;
            }
        }

        private void enginsBox_Click(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;
            select_Product.Visible = true;

            dataGridView.Visible = true;
            var data = _GetDatabaseservice.Find(it => it.productType.Contains("เครื่องยนต์")).ToList();
            if (data == null)
            {
                MessageBox.Show("ไม่มีสินค้าประเภท เครื่องยนต์ ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = data;
            }
        }

        private void fixBox_Click(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;
            select_Product.Visible = true;

            dataGridView.Visible = true;
            var data = _GetDatabaseservice.Find(it => it.productType.Contains("อุปกรณซ่อมบำรุง")).ToList();
            if (data.Count <= 0)
            {
                MessageBox.Show("ไม่มีสินค้าประเภท อุปกรณซ่อมบำรุง ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = data;
            }
        }

        private void powerUnitBox_Click(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;
            select_Product.Visible = true;

            dataGridView.Visible = true;
            var data = _GetDatabaseservice.Find(it => it.productType.Contains("ชุดขับเคลื่อน")).ToList();
            if (data.Count <= 0)
            {
                MessageBox.Show("ไม่มีสินค้าประเภท ชุดขับเคลื่อน ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = data;
            }
        }

        private void suspensionBox_Click(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;
            select_Product.Visible = true;

            dataGridView.Visible = true;
            var data = _GetDatabaseservice.Find(it => it.productType.Contains("ช่วงล่าง")).ToList();
            if (data.Count <= 0)
            {
                MessageBox.Show("ไม่มีสินค้าประเภท ช่วงล่าง ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = data;
            }
        }

        private void tiresWheelsBox_Click(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;
            select_Product.Visible = true;

            dataGridView.Visible = true;
            var data = _GetDatabaseservice.Find(it => it.productType.Contains("ล้อ / ยางรถ")).ToList();
            if (data.Count <= 0)
            {
                MessageBox.Show("ไม่มีสินค้าประเภท ล้อ / ยางรถ ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = data;
            }
        }

        private void select_Product_Click(object sender, EventArgs e)
        {
            var data = dataGridView.CurrentRow.Cells["_productName"].Value.ToString();
            var getdata = _GetDatabaseservice.Find(it => it.productName == data).FirstOrDefault();

            ProductModel defProduct = new ProductModel
            {
                Id = getdata.Id,
                productType = getdata.productType,
                productName = getdata.productName,
                brand = getdata.brand,
                countProduct = getdata.countProduct - 1,
                price = getdata.price,
                discription = getdata.discription
            };

            _GetDatabaseservice.DeleteOne(it => it.productName == data);
            _GetDatabaseservice.InsertOne(defProduct);

            cartModel defCart = new cartModel
            {
                productType = defProduct.productType,
                productName = defProduct.productName,
                brand = defProduct.brand,
                price = defProduct.price,
                discription = defProduct.discription
            };

            _GetCartservice.InsertOne(defCart);
            var cartData = _GetCartservice.Find(it => true).ToList();
            cartGridView.DataSource = cartData;

            var productData = _GetDatabaseservice.Find(it => it.productType == defProduct.productType).ToList();
            dataGridView.DataSource = productData;

            double allPrice = 0;

            foreach (var summary in cartData)
            {
                allPrice = allPrice + summary.price;
            }

            sumCallabel.Text = allPrice.ToString();
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            var data = cartGridView.CurrentRow.Cells["productName"].Value.ToString();
            var getdata = _GetDatabaseservice.Find(it => it.productName == data).FirstOrDefault();

            ProductModel defProduct = new ProductModel
            {
                Id = getdata.Id,
                productType = getdata.productType,
                productName = getdata.productName,
                brand = getdata.brand,
                countProduct = getdata.countProduct + 1,
                price = getdata.price,
                discription = getdata.discription
            };
            _GetCartservice.DeleteOne(it => it.productName == data);
            _GetDatabaseservice.DeleteOne(it => it.productName == data);

            _GetDatabaseservice.InsertOne(defProduct);

            var cartData = _GetCartservice.Find(it => true).ToList();
            cartGridView.DataSource = cartData;

            var productData = _GetDatabaseservice.Find(it => it.productType == defProduct.productType).ToList();
            dataGridView.DataSource = productData;

            double allPrice = 0;

            foreach (var summary in cartData)
            {
                allPrice = allPrice + summary.price;
            }

            sumCallabel.Text = allPrice.ToString();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            var totalIncome = 0.00;
            var getlog = _GetCartservice.Find(it => true).ToList();

            var getproductname = getlog
                .GroupBy(it => it.productName)
                .Select(it => new saleProductModel { Name = it.Key, count = it.Count() })
                .ToList();

            foreach (var item in getproductname)
            {
                var data = _GetDatabaseservice.Find(it => it.productName == item.Name).FirstOrDefault();

                totalIncome += (data.price * item.count);
            }

            logModel def = new logModel
            {
                TradinDate = DateTime.Now,
                sumPrice = totalIncome,
                saleProducts = getproductname
            };

            _GetLogtservice.InsertOne(def);

            //_GetCartservice.DeleteManyAsync(it => true);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            var getlog = _GetCartservice.Find(it => true).ToList();

            var getproductname = getlog
                .GroupBy(it => it.productName)
                .Select(it => new saleProductModel { Name = it.Key, count = it.Count() })
                .ToList();

            foreach (var item in getproductname)
            {
                var data = _GetDatabaseservice.Find(it => it.productName == item.Name).FirstOrDefault();
                ProductModel defProduct = new ProductModel
                {
                    Id = data.Id,
                    productType = data.productType,
                    productName = data.productName,
                    brand = data.brand,
                    countProduct = data.countProduct + item.count,
                    price = data.price,
                    discription = data.discription
                };

                _GetDatabaseservice.DeleteOne(it => it.productName == data.productName);

                _GetDatabaseservice.InsertOne(defProduct);
            }

            _GetCartservice.DeleteManyAsync(it => true);

            var cartData = _GetCartservice.Find(it => true).ToList();
            cartGridView.DataSource = cartData;

            var productData = _GetDatabaseservice.Find(it => true).ToList();
            dataGridView.DataSource = productData;

            double allPrice = 0;

            foreach (var summary in cartData)
            {
                allPrice = allPrice + summary.price;
            }

            sumCallabel.Text = allPrice.ToString();
        }

        private void SalesummaryDay_Click(object sender, EventArgs e)
        {
            string filePath = $@"D:\POS_Log\Report{DateTime.Now.ToString("dd/MM/yyyy")}.xlsx";

            using (var excelPackage = new ExcelPackage())
            {
                var worksheet = excelPackage.Workbook.Worksheets.Add($"Sale summary report{DateTime.Now.ToString("dd/MM/yyyy")}");

                worksheet.Cells["A1"].Value = "Sale summary report";

                excelPackage.SaveAs(new FileInfo(filePath));
            }



            repoetView RepoetView = new repoetView();
            RepoetView.Show();

            try
            {
                Process.Start(@"D:\POS_Log");
            }
            catch (Exception)
            {
                Directory.CreateDirectory(@"D:\POS_Log");
            }
            finally
            {
                Process.Start(@"D:\POS_Log");
            }
        }
    }
}
namespace Pos_CarShop.UserController
{
    partial class Addproduct
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.typeProductBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameProductBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productCountBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.discriptionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.brandBox = new System.Windows.Forms.TextBox();
            this.priceProductBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.AddProductBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceProductBox)).BeginInit();
            this.SuspendLayout();
            // 
            // typeProductBox1
            // 
            this.typeProductBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeProductBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.typeProductBox1.FormattingEnabled = true;
            this.typeProductBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.typeProductBox1.Items.AddRange(new object[] {
            "ของแต่ง",
            "ระบบไฟ",
            "เครื่องยนต์",
            "อุปกรณซ่อมบำรุง",
            "ชุดขับเคลื่อน",
            "ช่วงล่าง",
            "ล้อ / ยางรถ"});
            this.typeProductBox1.Location = new System.Drawing.Point(87, 75);
            this.typeProductBox1.Name = "typeProductBox1";
            this.typeProductBox1.Size = new System.Drawing.Size(121, 21);
            this.typeProductBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ประเภทสินค้า";
            // 
            // nameProductBox
            // 
            this.nameProductBox.Location = new System.Drawing.Point(86, 139);
            this.nameProductBox.Name = "nameProductBox";
            this.nameProductBox.Size = new System.Drawing.Size(192, 20);
            this.nameProductBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ชื่อสินค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "จำนวนสินค้า";
            // 
            // productCountBox
            // 
            this.productCountBox.Location = new System.Drawing.Point(86, 255);
            this.productCountBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.productCountBox.Name = "productCountBox";
            this.productCountBox.Size = new System.Drawing.Size(120, 20);
            this.productCountBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "คำอธิบายสินค้า";
            // 
            // discriptionBox
            // 
            this.discriptionBox.Location = new System.Drawing.Point(83, 378);
            this.discriptionBox.Name = "discriptionBox";
            this.discriptionBox.Size = new System.Drawing.Size(434, 20);
            this.discriptionBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ยี่ห้อ";
            // 
            // brandBox
            // 
            this.brandBox.Location = new System.Drawing.Point(83, 200);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(192, 20);
            this.brandBox.TabIndex = 9;
            // 
            // priceProductBox
            // 
            this.priceProductBox.DecimalPlaces = 2;
            this.priceProductBox.Location = new System.Drawing.Point(86, 313);
            this.priceProductBox.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.priceProductBox.Name = "priceProductBox";
            this.priceProductBox.Size = new System.Drawing.Size(120, 20);
            this.priceProductBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "ราคาสินค้า";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductBtn.Location = new System.Drawing.Point(83, 439);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(192, 50);
            this.AddProductBtn.TabIndex = 13;
            this.AddProductBtn.Text = "เพิ่มสินค้า";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // Addproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.priceProductBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.brandBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.discriptionBox);
            this.Controls.Add(this.productCountBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameProductBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeProductBox1);
            this.Name = "Addproduct";
            this.Size = new System.Drawing.Size(598, 540);
            ((System.ComponentModel.ISupportInitialize)(this.productCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceProductBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeProductBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameProductBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown productCountBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox discriptionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox brandBox;
        private System.Windows.Forms.NumericUpDown priceProductBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddProductBtn;
    }
}

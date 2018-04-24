namespace Proj9PizzaDelivery
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbPizza = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstBxToppings = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboCrust = new System.Windows.Forms.ComboBox();
            this.cmboSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxWaterQty = new System.Windows.Forms.TextBox();
            this.txtBxSodaQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmboSpecialty = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.tbPizza.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPizza
            // 
            this.tbPizza.Controls.Add(this.tabPage1);
            this.tbPizza.Controls.Add(this.tabPage2);
            this.tbPizza.Controls.Add(this.tabPage3);
            this.tbPizza.Location = new System.Drawing.Point(2, 11);
            this.tbPizza.Name = "tbPizza";
            this.tbPizza.SelectedIndex = 0;
            this.tbPizza.Size = new System.Drawing.Size(440, 389);
            this.tbPizza.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.lstBxToppings);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmboCrust);
            this.tabPage1.Controls.Add(this.cmboSize);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pizza";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstBxToppings
            // 
            this.lstBxToppings.CheckOnClick = true;
            this.lstBxToppings.FormattingEnabled = true;
            this.lstBxToppings.Items.AddRange(new object[] {
            "Pepperoni",
            "Mushroom",
            "Green Peppers",
            "Olives",
            "Chicken",
            "Sausage",
            "Onion",
            "Pineapple",
            "Tomato",
            "Sauerkraut",
            "Hot Dogs",
            "Beef"});
            this.lstBxToppings.Location = new System.Drawing.Point(24, 170);
            this.lstBxToppings.Name = "lstBxToppings";
            this.lstBxToppings.ScrollAlwaysVisible = true;
            this.lstBxToppings.Size = new System.Drawing.Size(161, 174);
            this.lstBxToppings.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toppings - $1.50 Each";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type Of Crust";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // cmboCrust
            // 
            this.cmboCrust.FormattingEnabled = true;
            this.cmboCrust.Items.AddRange(new object[] {
            "Thin & Crispy Crust",
            "Hand Tossed",
            "Pan",
            "Stuffed Crust"});
            this.cmboCrust.Location = new System.Drawing.Point(242, 84);
            this.cmboCrust.Name = "cmboCrust";
            this.cmboCrust.Size = new System.Drawing.Size(167, 24);
            this.cmboCrust.TabIndex = 2;
            // 
            // cmboSize
            // 
            this.cmboSize.FormattingEnabled = true;
            this.cmboSize.Items.AddRange(new object[] {
            "Small (8\")-$9.95",
            "Medium (12\")-$12.95",
            "Large (16\")-$15.95"});
            this.cmboSize.Location = new System.Drawing.Point(24, 84);
            this.cmboSize.Name = "cmboSize";
            this.cmboSize.Size = new System.Drawing.Size(167, 24);
            this.cmboSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Selections";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtBxWaterQty);
            this.tabPage2.Controls.Add(this.txtBxSodaQty);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(432, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Beverages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Soda Cost is $1.75 - Water is free!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Water";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Soda";
            // 
            // txtBxWaterQty
            // 
            this.txtBxWaterQty.Location = new System.Drawing.Point(189, 159);
            this.txtBxWaterQty.Name = "txtBxWaterQty";
            this.txtBxWaterQty.Size = new System.Drawing.Size(86, 22);
            this.txtBxWaterQty.TabIndex = 2;
            // 
            // txtBxSodaQty
            // 
            this.txtBxSodaQty.Location = new System.Drawing.Point(189, 93);
            this.txtBxSodaQty.Name = "txtBxSodaQty";
            this.txtBxSodaQty.Size = new System.Drawing.Size(86, 22);
            this.txtBxSodaQty.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Drink Selections";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmboSpecialty);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(432, 360);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Specialty Items";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmboSpecialty
            // 
            this.cmboSpecialty.FormattingEnabled = true;
            this.cmboSpecialty.Items.AddRange(new object[] {
            "",
            "Wings-$5.00",
            "Cheese Sticks-$4.00",
            "Garlic Bread-$3.00"});
            this.cmboSpecialty.Location = new System.Drawing.Point(127, 75);
            this.cmboSpecialty.Name = "cmboSpecialty";
            this.cmboSpecialty.Size = new System.Drawing.Size(154, 24);
            this.cmboSpecialty.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(122, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Specialty Items";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(262, 419);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(127, 44);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(242, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.Location = new System.Drawing.Point(28, 503);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(84, 20);
            this.lblErrorMsg.TabIndex = 4;
            this.lblErrorMsg.Text = "Welcome!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 537);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.tbPizza);
            this.Name = "Form1";
            this.Text = "B & D Pizza Express";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbPizza.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbPizza;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboCrust;
        private System.Windows.Forms.ComboBox cmboSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxWaterQty;
        private System.Windows.Forms.TextBox txtBxSodaQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmboSpecialty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.CheckedListBox lstBxToppings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}


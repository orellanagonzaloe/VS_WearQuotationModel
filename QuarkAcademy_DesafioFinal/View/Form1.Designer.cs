namespace QuarkAcademy_DesafioFinal
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
            this.StoreName = new System.Windows.Forms.Label();
            this.SellerName = new System.Windows.Forms.Label();
            this.SellerCode = new System.Windows.Forms.Label();
            this.SellerHistory = new System.Windows.Forms.LinkLabel();
            this.StoreAddress = new System.Windows.Forms.Label();
            this.RB_shirt = new System.Windows.Forms.RadioButton();
            this.RB_trouser = new System.Windows.Forms.RadioButton();
            this.RB_s_s = new System.Windows.Forms.RadioButton();
            this.RB_s_l = new System.Windows.Forms.RadioButton();
            this.RB_s_n = new System.Windows.Forms.RadioButton();
            this.RB_s_m = new System.Windows.Forms.RadioButton();
            this.RB_t_n = new System.Windows.Forms.RadioButton();
            this.RB_t_s = new System.Windows.Forms.RadioButton();
            this._AvailableUnits = new System.Windows.Forms.Label();
            this.AvailableUnits = new System.Windows.Forms.Label();
            this.RB_std = new System.Windows.Forms.RadioButton();
            this.RB_prem = new System.Windows.Forms.RadioButton();
            this.Quote = new System.Windows.Forms.Button();
            this.Quotation = new System.Windows.Forms.Label();
            this.UnitaryPrice = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // StoreName
            // 
            this.StoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreName.Location = new System.Drawing.Point(11, 9);
            this.StoreName.Name = "StoreName";
            this.StoreName.Size = new System.Drawing.Size(188, 35);
            this.StoreName.TabIndex = 0;
            this.StoreName.Text = "Store Name";
            this.StoreName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SellerName
            // 
            this.SellerName.AutoSize = true;
            this.SellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerName.Location = new System.Drawing.Point(26, 68);
            this.SellerName.Name = "SellerName";
            this.SellerName.Size = new System.Drawing.Size(82, 16);
            this.SellerName.TabIndex = 1;
            this.SellerName.Text = "Seller Name";
            // 
            // SellerCode
            // 
            this.SellerCode.AutoSize = true;
            this.SellerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerCode.Location = new System.Drawing.Point(182, 68);
            this.SellerCode.Name = "SellerCode";
            this.SellerCode.Size = new System.Drawing.Size(78, 16);
            this.SellerCode.TabIndex = 2;
            this.SellerCode.Text = "Seller Code";
            // 
            // SellerHistory
            // 
            this.SellerHistory.AutoSize = true;
            this.SellerHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerHistory.Location = new System.Drawing.Point(326, 68);
            this.SellerHistory.Name = "SellerHistory";
            this.SellerHistory.Size = new System.Drawing.Size(95, 16);
            this.SellerHistory.TabIndex = 3;
            this.SellerHistory.TabStop = true;
            this.SellerHistory.Text = "Quotes History";
            this.SellerHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SellerHistory_LinkClicked);
            // 
            // StoreAddress
            // 
            this.StoreAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StoreAddress.Location = new System.Drawing.Point(228, 9);
            this.StoreAddress.Name = "StoreAddress";
            this.StoreAddress.Size = new System.Drawing.Size(215, 35);
            this.StoreAddress.TabIndex = 4;
            this.StoreAddress.Text = "Store Address";
            this.StoreAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RB_shirt
            // 
            this.RB_shirt.AutoSize = true;
            this.RB_shirt.Location = new System.Drawing.Point(249, 21);
            this.RB_shirt.Name = "RB_shirt";
            this.RB_shirt.Size = new System.Drawing.Size(51, 20);
            this.RB_shirt.TabIndex = 5;
            this.RB_shirt.Text = "Shirt";
            this.RB_shirt.UseVisualStyleBackColor = true;
            this.RB_shirt.CheckedChanged += new System.EventHandler(this.RB_shirt_CheckedChanged);
            // 
            // RB_trouser
            // 
            this.RB_trouser.AutoSize = true;
            this.RB_trouser.Checked = true;
            this.RB_trouser.Location = new System.Drawing.Point(79, 21);
            this.RB_trouser.Name = "RB_trouser";
            this.RB_trouser.Size = new System.Drawing.Size(72, 20);
            this.RB_trouser.TabIndex = 6;
            this.RB_trouser.TabStop = true;
            this.RB_trouser.Text = "Trouser";
            this.RB_trouser.UseVisualStyleBackColor = true;
            this.RB_trouser.CheckedChanged += new System.EventHandler(this.RB_trouser_CheckedChanged);
            // 
            // RB_s_s
            // 
            this.RB_s_s.AutoSize = true;
            this.RB_s_s.Enabled = false;
            this.RB_s_s.Location = new System.Drawing.Point(22, 19);
            this.RB_s_s.Name = "RB_s_s";
            this.RB_s_s.Size = new System.Drawing.Size(56, 20);
            this.RB_s_s.TabIndex = 7;
            this.RB_s_s.TabStop = true;
            this.RB_s_s.Text = "Short";
            this.RB_s_s.UseVisualStyleBackColor = true;
            this.RB_s_s.CheckedChanged += new System.EventHandler(this.RB_s_s_CheckedChanged);
            // 
            // RB_s_l
            // 
            this.RB_s_l.AutoSize = true;
            this.RB_s_l.Enabled = false;
            this.RB_s_l.Location = new System.Drawing.Point(141, 19);
            this.RB_s_l.Name = "RB_s_l";
            this.RB_s_l.Size = new System.Drawing.Size(55, 20);
            this.RB_s_l.TabIndex = 8;
            this.RB_s_l.TabStop = true;
            this.RB_s_l.Text = "Long";
            this.RB_s_l.UseVisualStyleBackColor = true;
            this.RB_s_l.CheckedChanged += new System.EventHandler(this.RB_s_l_CheckedChanged);
            // 
            // RB_s_n
            // 
            this.RB_s_n.AutoSize = true;
            this.RB_s_n.Enabled = false;
            this.RB_s_n.Location = new System.Drawing.Point(19, 29);
            this.RB_s_n.Name = "RB_s_n";
            this.RB_s_n.Size = new System.Drawing.Size(69, 20);
            this.RB_s_n.TabIndex = 9;
            this.RB_s_n.TabStop = true;
            this.RB_s_n.Text = "Normal";
            this.RB_s_n.UseVisualStyleBackColor = true;
            this.RB_s_n.CheckedChanged += new System.EventHandler(this.RB_s_n_CheckedChanged);
            // 
            // RB_s_m
            // 
            this.RB_s_m.AutoSize = true;
            this.RB_s_m.Enabled = false;
            this.RB_s_m.Location = new System.Drawing.Point(141, 29);
            this.RB_s_m.Name = "RB_s_m";
            this.RB_s_m.Size = new System.Drawing.Size(52, 20);
            this.RB_s_m.TabIndex = 10;
            this.RB_s_m.TabStop = true;
            this.RB_s_m.Text = "Mao";
            this.RB_s_m.UseVisualStyleBackColor = true;
            this.RB_s_m.CheckedChanged += new System.EventHandler(this.RB_s_m_CheckedChanged);
            // 
            // RB_t_n
            // 
            this.RB_t_n.AutoSize = true;
            this.RB_t_n.Checked = true;
            this.RB_t_n.Location = new System.Drawing.Point(13, 19);
            this.RB_t_n.Name = "RB_t_n";
            this.RB_t_n.Size = new System.Drawing.Size(69, 20);
            this.RB_t_n.TabIndex = 11;
            this.RB_t_n.TabStop = true;
            this.RB_t_n.Text = "Normal";
            this.RB_t_n.UseVisualStyleBackColor = true;
            this.RB_t_n.CheckedChanged += new System.EventHandler(this.RB_t_n_CheckedChanged);
            // 
            // RB_t_s
            // 
            this.RB_t_s.AutoSize = true;
            this.RB_t_s.Location = new System.Drawing.Point(121, 19);
            this.RB_t_s.Name = "RB_t_s";
            this.RB_t_s.Size = new System.Drawing.Size(51, 20);
            this.RB_t_s.TabIndex = 12;
            this.RB_t_s.Text = "Slim";
            this.RB_t_s.UseVisualStyleBackColor = true;
            this.RB_t_s.CheckedChanged += new System.EventHandler(this.RB_t_s_CheckedChanged);
            // 
            // _AvailableUnits
            // 
            this._AvailableUnits.AutoSize = true;
            this._AvailableUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._AvailableUnits.Location = new System.Drawing.Point(222, 511);
            this._AvailableUnits.Name = "_AvailableUnits";
            this._AvailableUnits.Size = new System.Drawing.Size(130, 24);
            this._AvailableUnits.TabIndex = 13;
            this._AvailableUnits.Text = "Available units";
            // 
            // AvailableUnits
            // 
            this.AvailableUnits.AutoSize = true;
            this.AvailableUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableUnits.Location = new System.Drawing.Point(358, 511);
            this.AvailableUnits.Name = "AvailableUnits";
            this.AvailableUnits.Size = new System.Drawing.Size(16, 24);
            this.AvailableUnits.TabIndex = 14;
            this.AvailableUnits.Text = "-";
            // 
            // RB_std
            // 
            this.RB_std.AutoSize = true;
            this.RB_std.Checked = true;
            this.RB_std.Location = new System.Drawing.Point(24, 29);
            this.RB_std.Name = "RB_std";
            this.RB_std.Size = new System.Drawing.Size(80, 20);
            this.RB_std.TabIndex = 15;
            this.RB_std.TabStop = true;
            this.RB_std.Text = "Standard";
            this.RB_std.UseVisualStyleBackColor = true;
            this.RB_std.CheckedChanged += new System.EventHandler(this.RB_std_CheckedChanged);
            // 
            // RB_prem
            // 
            this.RB_prem.AutoSize = true;
            this.RB_prem.Location = new System.Drawing.Point(130, 29);
            this.RB_prem.Name = "RB_prem";
            this.RB_prem.Size = new System.Drawing.Size(78, 20);
            this.RB_prem.TabIndex = 16;
            this.RB_prem.Text = "Premium";
            this.RB_prem.UseVisualStyleBackColor = true;
            this.RB_prem.CheckedChanged += new System.EventHandler(this.RB_prem_CheckedChanged);
            // 
            // Quote
            // 
            this.Quote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quote.Location = new System.Drawing.Point(243, 408);
            this.Quote.Name = "Quote";
            this.Quote.Size = new System.Drawing.Size(178, 60);
            this.Quote.TabIndex = 17;
            this.Quote.Text = "Quote";
            this.Quote.UseVisualStyleBackColor = true;
            this.Quote.Click += new System.EventHandler(this.Quote_Click);
            // 
            // Quotation
            // 
            this.Quotation.AutoSize = true;
            this.Quotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quotation.Location = new System.Drawing.Point(109, 511);
            this.Quotation.Name = "Quotation";
            this.Quotation.Size = new System.Drawing.Size(16, 24);
            this.Quotation.TabIndex = 18;
            this.Quotation.Text = "-";
            // 
            // UnitaryPrice
            // 
            this.UnitaryPrice.Location = new System.Drawing.Point(113, 408);
            this.UnitaryPrice.Name = "UnitaryPrice";
            this.UnitaryPrice.Size = new System.Drawing.Size(98, 20);
            this.UnitaryPrice.TabIndex = 19;
            this.UnitaryPrice.Text = "0";
            this.UnitaryPrice.KeyPress += UnitaryPrice_KeyPress;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(112, 448);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(99, 20);
            this.Quantity.TabIndex = 20;
            this.Quantity.Text = "0";
            this.Quantity.KeyPress += Quantity_KeyPress;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Unitary Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Quantity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_trouser);
            this.groupBox1.Controls.Add(this.RB_shirt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 56);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wear type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB_t_s);
            this.groupBox2.Controls.Add(this.RB_t_n);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 51);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trouser type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RB_s_l);
            this.groupBox3.Controls.Add(this.RB_s_s);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(247, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 51);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shirt sleeves";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RB_s_m);
            this.groupBox4.Controls.Add(this.RB_s_n);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(250, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 59);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Shirt collar";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RB_prem);
            this.groupBox5.Controls.Add(this.RB_std);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(113, 322);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(214, 61);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Wear quality";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.UnitaryPrice);
            this.Controls.Add(this.Quotation);
            this.Controls.Add(this.Quote);
            this.Controls.Add(this.AvailableUnits);
            this.Controls.Add(this._AvailableUnits);
            this.Controls.Add(this.StoreAddress);
            this.Controls.Add(this.SellerHistory);
            this.Controls.Add(this.SellerCode);
            this.Controls.Add(this.SellerName);
            this.Controls.Add(this.StoreName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Wear quotation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label StoreName;
        public System.Windows.Forms.Label SellerName;
        public System.Windows.Forms.Label SellerCode;
        public System.Windows.Forms.LinkLabel SellerHistory;
        public System.Windows.Forms.Label StoreAddress;
        public System.Windows.Forms.RadioButton RB_shirt;
        public System.Windows.Forms.RadioButton RB_trouser;
        public System.Windows.Forms.RadioButton RB_s_s;
        public System.Windows.Forms.RadioButton RB_s_l;
        public System.Windows.Forms.RadioButton RB_s_n;
        public System.Windows.Forms.RadioButton RB_s_m;
        public System.Windows.Forms.RadioButton RB_t_n;
        public System.Windows.Forms.RadioButton RB_t_s;
        private System.Windows.Forms.Label _AvailableUnits;
        public System.Windows.Forms.Label AvailableUnits;
        public System.Windows.Forms.RadioButton RB_std;
        public System.Windows.Forms.RadioButton RB_prem;
        private System.Windows.Forms.Button Quote;
        public System.Windows.Forms.Label Quotation;
        public System.Windows.Forms.TextBox UnitaryPrice;
        public System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
    }
}


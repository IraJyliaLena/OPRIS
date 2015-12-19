namespace PetShop
{
    partial class frmPets
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBreed = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbPet = new System.Windows.Forms.GroupBox();
            this.txtSaleDate = new System.Windows.Forms.TextBox();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.cmbCashier = new System.Windows.Forms.ComboBox();
            this.lblCashier = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.lblPetName = new System.Windows.Forms.Label();
            this.gbBreed = new System.Windows.Forms.GroupBox();
            this.btnAddBreed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSpecies = new System.Windows.Forms.GroupBox();
            this.cbSpecies = new System.Windows.Forms.ComboBox();
            this.btnAddMore = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.gbPet.SuspendLayout();
            this.gbBreed.SuspendLayout();
            this.gbSpecies.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(218, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Порода животного:";
            // 
            // cbBreed
            // 
            this.cbBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBreed.FormattingEnabled = true;
            this.cbBreed.Location = new System.Drawing.Point(117, 25);
            this.cbBreed.Name = "cbBreed";
            this.cbBreed.Size = new System.Drawing.Size(154, 21);
            this.cbBreed.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(111, 223);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gbPet
            // 
            this.gbPet.Controls.Add(this.dtBirthday);
            this.gbPet.Controls.Add(this.txtSaleDate);
            this.gbPet.Controls.Add(this.lblSaleDate);
            this.gbPet.Controls.Add(this.cmbCashier);
            this.gbPet.Controls.Add(this.lblCashier);
            this.gbPet.Controls.Add(this.txtPrice);
            this.gbPet.Controls.Add(this.lblPrice);
            this.gbPet.Controls.Add(this.lblBirthDate);
            this.gbPet.Controls.Add(this.rbFemale);
            this.gbPet.Controls.Add(this.rbMale);
            this.gbPet.Controls.Add(this.lblSex);
            this.gbPet.Controls.Add(this.txtPetName);
            this.gbPet.Controls.Add(this.lblPetName);
            this.gbPet.Location = new System.Drawing.Point(4, 118);
            this.gbPet.Name = "gbPet";
            this.gbPet.Size = new System.Drawing.Size(314, 101);
            this.gbPet.TabIndex = 12;
            this.gbPet.TabStop = false;
            this.gbPet.Text = "Информация о животном";
            // 
            // txtSaleDate
            // 
            this.txtSaleDate.Location = new System.Drawing.Point(316, 72);
            this.txtSaleDate.Name = "txtSaleDate";
            this.txtSaleDate.Size = new System.Drawing.Size(164, 20);
            this.txtSaleDate.TabIndex = 15;
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Location = new System.Drawing.Point(313, 58);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(83, 13);
            this.lblSaleDate.TabIndex = 14;
            this.lblSaleDate.Text = "Дата продажи:";
            // 
            // cmbCashier
            // 
            this.cmbCashier.FormattingEnabled = true;
            this.cmbCashier.Location = new System.Drawing.Point(316, 32);
            this.cmbCashier.Name = "cmbCashier";
            this.cmbCashier.Size = new System.Drawing.Size(164, 21);
            this.cmbCashier.TabIndex = 13;
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.Location = new System.Drawing.Point(313, 18);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(47, 13);
            this.lblCashier.TabIndex = 12;
            this.lblCashier.Text = "Кассир:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(149, 72);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(155, 20);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(146, 58);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Цена:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(146, 19);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(89, 13);
            this.lblBirthDate.TabIndex = 5;
            this.lblBirthDate.Text = "Дата рождения:";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbFemale.Location = new System.Drawing.Point(51, 72);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(33, 17);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.Text = "ж";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(12, 72);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(33, 17);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "м";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(9, 58);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(30, 13);
            this.lblSex.TabIndex = 2;
            this.lblSex.Text = "Пол:";
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(12, 33);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(127, 20);
            this.txtPetName.TabIndex = 1;
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Location = new System.Drawing.Point(9, 19);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(46, 13);
            this.lblPetName.TabIndex = 0;
            this.lblPetName.Text = "Кличка:";
            // 
            // gbBreed
            // 
            this.gbBreed.Controls.Add(this.btnAddBreed);
            this.gbBreed.Controls.Add(this.label2);
            this.gbBreed.Controls.Add(this.cbBreed);
            this.gbBreed.Location = new System.Drawing.Point(4, 56);
            this.gbBreed.Name = "gbBreed";
            this.gbBreed.Size = new System.Drawing.Size(314, 56);
            this.gbBreed.TabIndex = 11;
            this.gbBreed.TabStop = false;
            this.gbBreed.Text = "Порода";
            // 
            // btnAddBreed
            // 
            this.btnAddBreed.Location = new System.Drawing.Point(276, 23);
            this.btnAddBreed.Name = "btnAddBreed";
            this.btnAddBreed.Size = new System.Drawing.Size(28, 23);
            this.btnAddBreed.TabIndex = 8;
            this.btnAddBreed.Text = "+";
            this.btnAddBreed.UseVisualStyleBackColor = true;
            this.btnAddBreed.Click += new System.EventHandler(this.btnAddBreed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вид животного:";
            // 
            // gbSpecies
            // 
            this.gbSpecies.Controls.Add(this.label1);
            this.gbSpecies.Controls.Add(this.cbSpecies);
            this.gbSpecies.Location = new System.Drawing.Point(4, 4);
            this.gbSpecies.Name = "gbSpecies";
            this.gbSpecies.Size = new System.Drawing.Size(314, 46);
            this.gbSpecies.TabIndex = 10;
            this.gbSpecies.TabStop = false;
            this.gbSpecies.Text = "Вид";
            // 
            // cbSpecies
            // 
            this.cbSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecies.FormattingEnabled = true;
            this.cbSpecies.Location = new System.Drawing.Point(117, 18);
            this.cbSpecies.Name = "cbSpecies";
            this.cbSpecies.Size = new System.Drawing.Size(189, 21);
            this.cbSpecies.TabIndex = 0;
            this.cbSpecies.SelectedIndexChanged += new System.EventHandler(this.cbSpecies_SelectedIndexChanged);
            // 
            // btnAddMore
            // 
            this.btnAddMore.Location = new System.Drawing.Point(4, 223);
            this.btnAddMore.Name = "btnAddMore";
            this.btnAddMore.Size = new System.Drawing.Size(90, 25);
            this.btnAddMore.TabIndex = 15;
            this.btnAddMore.Text = "Добавить ещё";
            this.btnAddMore.UseVisualStyleBackColor = true;
            this.btnAddMore.Visible = false;
            this.btnAddMore.Click += new System.EventHandler(this.btnAddMore_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(324, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 93);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фото";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 74);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "Обзор...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(149, 33);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(155, 20);
            this.dtBirthday.TabIndex = 16;
            // 
            // frmPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddMore);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbPet);
            this.Controls.Add(this.gbBreed);
            this.Controls.Add(this.gbSpecies);
            this.Name = "frmPets";
            this.Text = "frmPets";
            this.Load += new System.EventHandler(this.frmPets_Load);
            this.gbPet.ResumeLayout(false);
            this.gbPet.PerformLayout();
            this.gbBreed.ResumeLayout(false);
            this.gbBreed.PerformLayout();
            this.gbSpecies.ResumeLayout(false);
            this.gbSpecies.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBreed;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gbPet;
        private System.Windows.Forms.TextBox txtSaleDate;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.ComboBox cmbCashier;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.GroupBox gbBreed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSpecies;
        private System.Windows.Forms.ComboBox cbSpecies;
        private System.Windows.Forms.Button btnAddMore;
        private System.Windows.Forms.Button btnAddBreed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtBirthday;
    }
}
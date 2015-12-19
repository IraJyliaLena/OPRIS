namespace PetShop
{
    partial class frmSelect
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
            this.btOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbZnach = new System.Windows.Forms.TextBox();
            this.btOr = new System.Windows.Forms.Button();
            this.btAnd = new System.Windows.Forms.Button();
            this.btNot = new System.Windows.Forms.Button();
            this.btMore = new System.Windows.Forms.Button();
            this.btLess = new System.Windows.Forms.Button();
            this.btEqual = new System.Windows.Forms.Button();
            this.lbFilds = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btShop = new System.Windows.Forms.Button();
            this.btAddField = new System.Windows.Forms.Button();
            this.rtbSelect = new System.Windows.Forms.RichTextBox();
            this.btnAddZnach = new System.Windows.Forms.Button();
            this.moreEqual = new System.Windows.Forms.Button();
            this.lessEqual = new System.Windows.Forms.Button();
            this.butCansel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(493, 144);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(283, 27);
            this.btOk.TabIndex = 35;
            this.btOk.Text = "Применить";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Запрос";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Значение:";
            // 
            // tbZnach
            // 
            this.tbZnach.Location = new System.Drawing.Point(306, 72);
            this.tbZnach.Name = "tbZnach";
            this.tbZnach.Size = new System.Drawing.Size(147, 20);
            this.tbZnach.TabIndex = 31;
            // 
            // btOr
            // 
            this.btOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOr.Location = new System.Drawing.Point(232, 24);
            this.btOr.Name = "btOr";
            this.btOr.Size = new System.Drawing.Size(43, 34);
            this.btOr.TabIndex = 30;
            this.btOr.Text = "Or";
            this.btOr.UseVisualStyleBackColor = true;
            this.btOr.Click += new System.EventHandler(this.btOr_Click);
            // 
            // btAnd
            // 
            this.btAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAnd.Location = new System.Drawing.Point(232, 64);
            this.btAnd.Name = "btAnd";
            this.btAnd.Size = new System.Drawing.Size(43, 34);
            this.btAnd.TabIndex = 29;
            this.btAnd.Text = "And";
            this.btAnd.UseVisualStyleBackColor = true;
            this.btAnd.Click += new System.EventHandler(this.btAnd_Click);
            // 
            // btNot
            // 
            this.btNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNot.Location = new System.Drawing.Point(232, 104);
            this.btNot.Name = "btNot";
            this.btNot.Size = new System.Drawing.Size(43, 34);
            this.btNot.TabIndex = 28;
            this.btNot.Text = "Not";
            this.btNot.UseVisualStyleBackColor = true;
            this.btNot.Click += new System.EventHandler(this.btNot_Click);
            // 
            // btMore
            // 
            this.btMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMore.Location = new System.Drawing.Point(183, 64);
            this.btMore.Name = "btMore";
            this.btMore.Size = new System.Drawing.Size(43, 34);
            this.btMore.TabIndex = 27;
            this.btMore.Text = ">";
            this.btMore.UseVisualStyleBackColor = true;
            this.btMore.Click += new System.EventHandler(this.btMore_Click);
            // 
            // btLess
            // 
            this.btLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btLess.Location = new System.Drawing.Point(183, 104);
            this.btLess.Name = "btLess";
            this.btLess.Size = new System.Drawing.Size(43, 34);
            this.btLess.TabIndex = 26;
            this.btLess.Text = "<";
            this.btLess.UseVisualStyleBackColor = true;
            this.btLess.Click += new System.EventHandler(this.btLess_Click);
            // 
            // btEqual
            // 
            this.btEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEqual.Location = new System.Drawing.Point(183, 24);
            this.btEqual.Name = "btEqual";
            this.btEqual.Size = new System.Drawing.Size(43, 34);
            this.btEqual.TabIndex = 25;
            this.btEqual.Text = "=";
            this.btEqual.UseVisualStyleBackColor = true;
            this.btEqual.Click += new System.EventHandler(this.btEqual_Click);
            // 
            // lbFilds
            // 
            this.lbFilds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFilds.FormattingEnabled = true;
            this.lbFilds.ItemHeight = 16;
            this.lbFilds.Items.AddRange(new object[] {
            "Пол",
            "Порода",
            "Вид",
            "Дата рождения",
            "Цена"});
            this.lbFilds.Location = new System.Drawing.Point(12, 24);
            this.lbFilds.Name = "lbFilds";
            this.lbFilds.Size = new System.Drawing.Size(165, 100);
            this.lbFilds.TabIndex = 24;
            this.lbFilds.SelectedIndexChanged += new System.EventHandler(this.lbFilds_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Выбрать поля:";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(648, 108);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(128, 27);
            this.btClear.TabIndex = 22;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(937, 190);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btShop
            // 
            this.btShop.Location = new System.Drawing.Point(743, 401);
            this.btShop.Name = "btShop";
            this.btShop.Size = new System.Drawing.Size(206, 27);
            this.btShop.TabIndex = 36;
            this.btShop.Text = "Перейти к продаже";
            this.btShop.UseVisualStyleBackColor = true;
            this.btShop.Click += new System.EventHandler(this.btShop_Click);
            // 
            // btAddField
            // 
            this.btAddField.Location = new System.Drawing.Point(12, 128);
            this.btAddField.Name = "btAddField";
            this.btAddField.Size = new System.Drawing.Size(128, 27);
            this.btAddField.TabIndex = 37;
            this.btAddField.Text = "Добавить";
            this.btAddField.UseVisualStyleBackColor = true;
            this.btAddField.Click += new System.EventHandler(this.btAddField_Click);
            // 
            // rtbSelect
            // 
            this.rtbSelect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbSelect.Location = new System.Drawing.Point(493, 24);
            this.rtbSelect.Name = "rtbSelect";
            this.rtbSelect.ReadOnly = true;
            this.rtbSelect.Size = new System.Drawing.Size(283, 75);
            this.rtbSelect.TabIndex = 38;
            this.rtbSelect.Text = "";
            // 
            // btnAddZnach
            // 
            this.btnAddZnach.Location = new System.Drawing.Point(383, 98);
            this.btnAddZnach.Name = "btnAddZnach";
            this.btnAddZnach.Size = new System.Drawing.Size(70, 26);
            this.btnAddZnach.TabIndex = 39;
            this.btnAddZnach.Text = "Добавить";
            this.btnAddZnach.UseVisualStyleBackColor = true;
            this.btnAddZnach.Click += new System.EventHandler(this.btnAddZnach_Click);
            // 
            // moreEqual
            // 
            this.moreEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moreEqual.Location = new System.Drawing.Point(183, 144);
            this.moreEqual.Name = "moreEqual";
            this.moreEqual.Size = new System.Drawing.Size(43, 34);
            this.moreEqual.TabIndex = 40;
            this.moreEqual.Text = ">=";
            this.moreEqual.UseVisualStyleBackColor = true;
            this.moreEqual.Click += new System.EventHandler(this.moreEqual_Click);
            // 
            // lessEqual
            // 
            this.lessEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lessEqual.Location = new System.Drawing.Point(232, 144);
            this.lessEqual.Name = "lessEqual";
            this.lessEqual.Size = new System.Drawing.Size(43, 34);
            this.lessEqual.TabIndex = 41;
            this.lessEqual.Text = "<=";
            this.lessEqual.UseVisualStyleBackColor = true;
            this.lessEqual.Click += new System.EventHandler(this.lessEqual_Click);
            // 
            // butCansel
            // 
            this.butCansel.Location = new System.Drawing.Point(493, 108);
            this.butCansel.Name = "butCansel";
            this.butCansel.Size = new System.Drawing.Size(128, 27);
            this.butCansel.TabIndex = 42;
            this.butCansel.Text = "<-- Отмена";
            this.butCansel.UseVisualStyleBackColor = true;
            this.butCansel.Click += new System.EventHandler(this.butCansel_Click);
            // 
            // frmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 440);
            this.Controls.Add(this.butCansel);
            this.Controls.Add(this.lessEqual);
            this.Controls.Add(this.moreEqual);
            this.Controls.Add(this.btnAddZnach);
            this.Controls.Add(this.rtbSelect);
            this.Controls.Add(this.btAddField);
            this.Controls.Add(this.btShop);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbZnach);
            this.Controls.Add(this.btOr);
            this.Controls.Add(this.btAnd);
            this.Controls.Add(this.btNot);
            this.Controls.Add(this.btMore);
            this.Controls.Add(this.btLess);
            this.Controls.Add(this.btEqual);
            this.Controls.Add(this.lbFilds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSelect";
            this.Text = "Подобрать животное";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSelect_FormClosed);
            this.Load += new System.EventHandler(this.frmSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbZnach;
        private System.Windows.Forms.Button btOr;
        private System.Windows.Forms.Button btAnd;
        private System.Windows.Forms.Button btNot;
        private System.Windows.Forms.Button btMore;
        private System.Windows.Forms.Button btLess;
        private System.Windows.Forms.Button btEqual;
        private System.Windows.Forms.ListBox lbFilds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btShop;
        private System.Windows.Forms.Button btAddField;
        private System.Windows.Forms.RichTextBox rtbSelect;
        private System.Windows.Forms.Button btnAddZnach;
        private System.Windows.Forms.Button moreEqual;
        private System.Windows.Forms.Button lessEqual;
        private System.Windows.Forms.Button butCansel;
    }
}
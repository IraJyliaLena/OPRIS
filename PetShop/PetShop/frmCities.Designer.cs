namespace PetShop
{
    partial class frmCities
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
            this.dgvCities = new System.Windows.Forms.DataGridView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.butChange = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butCansel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCities
            // 
            this.dgvCities.AllowUserToAddRows = false;
            this.dgvCities.AllowUserToDeleteRows = false;
            this.dgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCities.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvCities.Location = new System.Drawing.Point(0, 0);
            this.dgvCities.MultiSelect = false;
            this.dgvCities.Name = "dgvCities";
            this.dgvCities.ReadOnly = true;
            this.dgvCities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCities.Size = new System.Drawing.Size(265, 265);
            this.dgvCities.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(168, 20);
            this.tbName.TabIndex = 1;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(47, 55);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(127, 23);
            this.butAdd.TabIndex = 3;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(318, 118);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(127, 23);
            this.butChange.TabIndex = 4;
            this.butChange.Text = "Изменить";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(318, 160);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(127, 23);
            this.butDel.TabIndex = 5;
            this.butDel.Text = "Удалить";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.butAdd);
            this.groupBox1.Location = new System.Drawing.Point(271, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 89);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить город";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // butCansel
            // 
            this.butCansel.Location = new System.Drawing.Point(318, 230);
            this.butCansel.Name = "butCansel";
            this.butCansel.Size = new System.Drawing.Size(127, 23);
            this.butCansel.TabIndex = 7;
            this.butCansel.Text = "Закрыть";
            this.butCansel.UseVisualStyleBackColor = true;
            this.butCansel.Click += new System.EventHandler(this.butCansel_Click);
            // 
            // frmCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 265);
            this.Controls.Add(this.butCansel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.dgvCities);
            this.Name = "frmCities";
            this.Text = "Города";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCities_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCities;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butChange;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butCansel;
    }
}
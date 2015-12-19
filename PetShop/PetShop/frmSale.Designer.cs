namespace PetShop
{
    partial class frmSale
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
            this.dgvPets = new System.Windows.Forms.DataGridView();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPets
            // 
            this.dgvPets.AllowUserToAddRows = false;
            this.dgvPets.AllowUserToDeleteRows = false;
            this.dgvPets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPets.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPets.Location = new System.Drawing.Point(0, 0);
            this.dgvPets.MultiSelect = false;
            this.dgvPets.Name = "dgvPets";
            this.dgvPets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPets.Size = new System.Drawing.Size(980, 219);
            this.dgvPets.TabIndex = 0;
            this.dgvPets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(625, 238);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(136, 49);
            this.btnSale.TabIndex = 1;
            this.btnSale.Text = "Продать";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(831, 238);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 49);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnQ
            // 
            this.btnQ.Location = new System.Drawing.Point(12, 238);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(137, 49);
            this.btnQ.TabIndex = 3;
            this.btnQ.Text = "Подобрать животное";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.btnQ_Click);
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 310);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.dgvPets);
            this.Name = "frmSale";
            this.Text = "Продажа животного";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPets;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnQ;
    }
}
namespace PetShop
{
    partial class frmBreeds
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
            this.butChange = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.dgvBreeds = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreeds)).BeginInit();
            this.SuspendLayout();
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(104, 286);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(86, 37);
            this.butChange.TabIndex = 10;
            this.butChange.Text = "Изменить";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(196, 286);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(86, 37);
            this.butDel.TabIndex = 9;
            this.butDel.Text = "Удалить";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(343, 286);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(86, 37);
            this.butClose.TabIndex = 8;
            this.butClose.Text = "Закрыть";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(12, 286);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(86, 37);
            this.butAdd.TabIndex = 7;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // dgvBreeds
            // 
            this.dgvBreeds.AllowUserToAddRows = false;
            this.dgvBreeds.AllowUserToDeleteRows = false;
            this.dgvBreeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBreeds.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvBreeds.Location = new System.Drawing.Point(0, 0);
            this.dgvBreeds.MultiSelect = false;
            this.dgvBreeds.Name = "dgvBreeds";
            this.dgvBreeds.ReadOnly = true;
            this.dgvBreeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBreeds.Size = new System.Drawing.Size(447, 271);
            this.dgvBreeds.TabIndex = 6;
            // 
            // frmBreeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 328);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.dgvBreeds);
            this.Name = "frmBreeds";
            this.Text = "Породы";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreeds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butChange;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butAdd;
        public System.Windows.Forms.DataGridView dgvBreeds;
    }
}
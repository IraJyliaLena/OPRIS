namespace PetShop
{
    partial class frmSpecies
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
            this.dgvSpecies = new System.Windows.Forms.DataGridView();
            this.butCansel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecies)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSpecies
            // 
            this.dgvSpecies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSpecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecies.Location = new System.Drawing.Point(0, 0);
            this.dgvSpecies.MultiSelect = false;
            this.dgvSpecies.Name = "dgvSpecies";
            this.dgvSpecies.ReadOnly = true;
            this.dgvSpecies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSpecies.Size = new System.Drawing.Size(256, 291);
            this.dgvSpecies.TabIndex = 0;
            // 
            // butCansel
            // 
            this.butCansel.Location = new System.Drawing.Point(309, 230);
            this.butCansel.Name = "butCansel";
            this.butCansel.Size = new System.Drawing.Size(127, 23);
            this.butCansel.TabIndex = 11;
            this.butCansel.Text = "Закрыть";
            this.butCansel.UseVisualStyleBackColor = true;
            this.butCansel.Click += new System.EventHandler(this.butCansel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.butAdd);
            this.groupBox1.Location = new System.Drawing.Point(262, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 89);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить вид";
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
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(309, 160);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(127, 23);
            this.butDel.TabIndex = 9;
            this.butDel.Text = "Удалить";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(309, 118);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(127, 23);
            this.butChange.TabIndex = 8;
            this.butChange.Text = "Изменить";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // frmSpecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 291);
            this.Controls.Add(this.butCansel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.dgvSpecies);
            this.Name = "frmSpecies";
            this.Text = "Виды животных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSpecies_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecies)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpecies;
        private System.Windows.Forms.Button butCansel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butChange;
    }
}
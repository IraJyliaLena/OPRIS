﻿namespace PetShop
{
    partial class frmProviders
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
            this.dgvProviders = new System.Windows.Forms.DataGridView();
            this.butAdd = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProviders
            // 
            this.dgvProviders.AllowUserToAddRows = false;
            this.dgvProviders.AllowUserToDeleteRows = false;
            this.dgvProviders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviders.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProviders.Location = new System.Drawing.Point(0, 0);
            this.dgvProviders.MultiSelect = false;
            this.dgvProviders.Name = "dgvProviders";
            this.dgvProviders.ReadOnly = true;
            this.dgvProviders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProviders.Size = new System.Drawing.Size(908, 349);
            this.dgvProviders.TabIndex = 1;
            this.dgvProviders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProviders_CellContentClick);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(12, 365);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(117, 37);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(779, 365);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(117, 37);
            this.butClose.TabIndex = 3;
            this.butClose.Text = "Закрыть";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(258, 365);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(117, 37);
            this.butDel.TabIndex = 4;
            this.butDel.Text = "Удалить";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butChange
            // 
            this.butChange.Location = new System.Drawing.Point(135, 365);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(117, 37);
            this.butChange.TabIndex = 5;
            this.butChange.Text = "Изменить";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // frmProviders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 414);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.dgvProviders);
            this.Name = "frmProviders";
            this.Text = "Данные о поставщиках";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProviders_FormClosed);
            this.Load += new System.EventHandler(this.frmProviders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvProviders;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butChange;
    }
}
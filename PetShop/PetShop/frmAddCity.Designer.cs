namespace PetShop
{
    partial class frmAddCity
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
            this.tbValue = new System.Windows.Forms.TextBox();
            this.butOk = new System.Windows.Forms.Button();
            this.butCansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(12, 12);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(309, 20);
            this.tbValue.TabIndex = 0;
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(12, 47);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(115, 23);
            this.butOk.TabIndex = 1;
            this.butOk.Text = "ОК";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butCansel
            // 
            this.butCansel.Location = new System.Drawing.Point(211, 47);
            this.butCansel.Name = "butCansel";
            this.butCansel.Size = new System.Drawing.Size(110, 23);
            this.butCansel.TabIndex = 2;
            this.butCansel.Text = "Отмена";
            this.butCansel.UseVisualStyleBackColor = true;
            this.butCansel.Click += new System.EventHandler(this.butCansel_Click);
            // 
            // frmAddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 85);
            this.Controls.Add(this.butCansel);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.tbValue);
            this.Name = "frmAddCity";
            this.Text = "frmAddCity";
            this.Load += new System.EventHandler(this.frmAddCity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butCansel;
    }
}
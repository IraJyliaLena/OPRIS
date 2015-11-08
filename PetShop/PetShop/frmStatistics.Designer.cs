namespace PetShop
{
    partial class frmStatistics
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
            this.spcStats = new System.Windows.Forms.SplitContainer();
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.dtSecondDate = new System.Windows.Forms.DateTimePicker();
            this.lblPo = new System.Windows.Forms.Label();
            this.dtFirstDate = new System.Windows.Forms.DateTimePicker();
            this.lblDates = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spcStats)).BeginInit();
            this.spcStats.Panel1.SuspendLayout();
            this.spcStats.Panel2.SuspendLayout();
            this.spcStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.SuspendLayout();
            // 
            // spcStats
            // 
            this.spcStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcStats.Location = new System.Drawing.Point(0, 0);
            this.spcStats.Name = "spcStats";
            this.spcStats.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcStats.Panel1
            // 
            this.spcStats.Panel1.Controls.Add(this.dgvStats);
            // 
            // spcStats.Panel2
            // 
            this.spcStats.Panel2.Controls.Add(this.btnPrint);
            this.spcStats.Panel2.Controls.Add(this.btnAccept);
            this.spcStats.Panel2.Controls.Add(this.dtSecondDate);
            this.spcStats.Panel2.Controls.Add(this.lblPo);
            this.spcStats.Panel2.Controls.Add(this.dtFirstDate);
            this.spcStats.Panel2.Controls.Add(this.lblDates);
            this.spcStats.Panel2.Controls.Add(this.lblProfit);
            this.spcStats.Size = new System.Drawing.Size(614, 271);
            this.spcStats.SplitterDistance = 183;
            this.spcStats.TabIndex = 0;
            // 
            // dgvStats
            // 
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStats.Location = new System.Drawing.Point(0, 0);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.Size = new System.Drawing.Size(614, 183);
            this.dgvStats.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(254, 54);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Печать отчета";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(522, 22);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(82, 23);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Применить";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // dtSecondDate
            // 
            this.dtSecondDate.Location = new System.Drawing.Point(385, 25);
            this.dtSecondDate.Name = "dtSecondDate";
            this.dtSecondDate.Size = new System.Drawing.Size(121, 20);
            this.dtSecondDate.TabIndex = 4;
            // 
            // lblPo
            // 
            this.lblPo.AutoSize = true;
            this.lblPo.Location = new System.Drawing.Point(360, 30);
            this.lblPo.Name = "lblPo";
            this.lblPo.Size = new System.Drawing.Size(19, 13);
            this.lblPo.TabIndex = 3;
            this.lblPo.Text = "по";
            // 
            // dtFirstDate
            // 
            this.dtFirstDate.Location = new System.Drawing.Point(233, 25);
            this.dtFirstDate.Name = "dtFirstDate";
            this.dtFirstDate.Size = new System.Drawing.Size(121, 20);
            this.dtFirstDate.TabIndex = 2;
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Location = new System.Drawing.Point(6, 30);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(224, 13);
            this.lblDates.TabIndex = 1;
            this.lblDates.Text = "Показаны результаты в промежутке дат с";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(6, 7);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(117, 13);
            this.lblProfit.TabIndex = 0;
            this.lblProfit.Text = "Прибыль от продажи:";
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 271);
            this.Controls.Add(this.spcStats);
            this.Name = "frmStatistics";
            this.Text = "Статистика по продажам";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStatistics_FormClosed);
            this.spcStats.Panel1.ResumeLayout(false);
            this.spcStats.Panel2.ResumeLayout(false);
            this.spcStats.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcStats)).EndInit();
            this.spcStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcStats;
        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.DateTimePicker dtSecondDate;
        private System.Windows.Forms.Label lblPo;
        private System.Windows.Forms.DateTimePicker dtFirstDate;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnPrint;

    }
}
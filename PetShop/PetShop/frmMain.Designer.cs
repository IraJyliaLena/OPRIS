namespace PetShop
{
    partial class frmMain
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
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выйтиИзПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myMenu = new System.Windows.Forms.MenuStrip();
            this.работаСДаннымиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.городаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.животныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.породыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPets = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvProvider = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.подобратьЖивотноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myMenu.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 6);
            // 
            // выйтиИзПользователяToolStripMenuItem
            // 
            this.выйтиИзПользователяToolStripMenuItem.Name = "выйтиИзПользователяToolStripMenuItem";
            this.выйтиИзПользователяToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.выйтиИзПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.выйтиИзПользователяToolStripMenuItem.Click += new System.EventHandler(this.выйтиИзПользователяToolStripMenuItem_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиИзПользователяToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выйтиToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // myMenu
            // 
            this.myMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.работаСДаннымиToolStripMenuItem,
            this.продажаToolStripMenuItem,
            this.подобратьЖивотноеToolStripMenuItem});
            this.myMenu.Location = new System.Drawing.Point(0, 0);
            this.myMenu.Name = "myMenu";
            this.myMenu.Size = new System.Drawing.Size(648, 24);
            this.myMenu.TabIndex = 2;
            this.myMenu.Text = "menuStrip1";
            // 
            // работаСДаннымиToolStripMenuItem
            // 
            this.работаСДаннымиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видыToolStripMenuItem,
            this.городаToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.животныеToolStripMenuItem,
            this.породыToolStripMenuItem,
            this.поставщикиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.работаСДаннымиToolStripMenuItem.Name = "работаСДаннымиToolStripMenuItem";
            this.работаСДаннымиToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.работаСДаннымиToolStripMenuItem.Text = "Работа с данными";
            // 
            // видыToolStripMenuItem
            // 
            this.видыToolStripMenuItem.Name = "видыToolStripMenuItem";
            this.видыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.видыToolStripMenuItem.Text = "Виды";
            // 
            // городаToolStripMenuItem
            // 
            this.городаToolStripMenuItem.Name = "городаToolStripMenuItem";
            this.городаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.городаToolStripMenuItem.Text = "Города";
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.должностиToolStripMenuItem.Text = "Должности";
            // 
            // животныеToolStripMenuItem
            // 
            this.животныеToolStripMenuItem.Name = "животныеToolStripMenuItem";
            this.животныеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.животныеToolStripMenuItem.Text = "Животные";
            // 
            // породыToolStripMenuItem
            // 
            this.породыToolStripMenuItem.Name = "породыToolStripMenuItem";
            this.породыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.породыToolStripMenuItem.Text = "Породы";
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click_1);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // продажаToolStripMenuItem
            // 
            this.продажаToolStripMenuItem.Name = "продажаToolStripMenuItem";
            this.продажаToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.продажаToolStripMenuItem.Text = "Продажа";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage3);
            this.tcMain.Controls.Add(this.tabPage4);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 24);
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(648, 263);
            this.tcMain.TabIndex = 3;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPets);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(640, 237);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "  Животные  ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPets
            // 
            this.dgvPets.AllowUserToAddRows = false;
            this.dgvPets.AllowUserToDeleteRows = false;
            this.dgvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPets.Location = new System.Drawing.Point(3, 3);
            this.dgvPets.MultiSelect = false;
            this.dgvPets.Name = "dgvPets";
            this.dgvPets.ReadOnly = true;
            this.dgvPets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPets.Size = new System.Drawing.Size(634, 231);
            this.dgvPets.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvProvider);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(640, 237);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Поставщики";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvProvider
            // 
            this.dgvProvider.AllowUserToAddRows = false;
            this.dgvProvider.AllowUserToDeleteRows = false;
            this.dgvProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProvider.Location = new System.Drawing.Point(0, 0);
            this.dgvProvider.MultiSelect = false;
            this.dgvProvider.Name = "dgvProvider";
            this.dgvProvider.ReadOnly = true;
            this.dgvProvider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvider.Size = new System.Drawing.Size(640, 237);
            this.dgvProvider.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvEmployee);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(640, 237);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Сотрудники";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(640, 237);
            this.dgvEmployee.TabIndex = 0;
            // 
            // подобратьЖивотноеToolStripMenuItem
            // 
            this.подобратьЖивотноеToolStripMenuItem.Name = "подобратьЖивотноеToolStripMenuItem";
            this.подобратьЖивотноеToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.подобратьЖивотноеToolStripMenuItem.Text = "Подобрать животное";
            this.подобратьЖивотноеToolStripMenuItem.Click += new System.EventHandler(this.подобратьЖивотноеToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 287);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.myMenu);
            this.Name = "frmMain";
            this.Text = "Магазин домашних животных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.myMenu.ResumeLayout(false);
            this.myMenu.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvider)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.MenuStrip myMenu;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvPets;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvProvider;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.ToolStripMenuItem работаСДаннымиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem городаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem животныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem породыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подобратьЖивотноеToolStripMenuItem;
    }
}
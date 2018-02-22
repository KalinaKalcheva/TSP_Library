namespace Library1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.читателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новЧитателToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всичкиЧитателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.търсенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изтриванеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаКнигаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всичкиКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.търсенеНаКнигаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изтриванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструкцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaShell;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.читателиToolStripMenuItem,
            this.книгиToolStripMenuItem,
            this.помощToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 27);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // читателиToolStripMenuItem
            // 
            this.читателиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новЧитателToolStripMenuItem,
            this.всичкиЧитателиToolStripMenuItem,
            this.търсенеToolStripMenuItem,
            this.изтриванеToolStripMenuItem1});
            this.читателиToolStripMenuItem.Font = new System.Drawing.Font("a_FuturaRound", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.читателиToolStripMenuItem.Name = "читателиToolStripMenuItem";
            this.читателиToolStripMenuItem.Size = new System.Drawing.Size(87, 23);
            this.читателиToolStripMenuItem.Text = "Читатели";
            // 
            // новЧитателToolStripMenuItem
            // 
            this.новЧитателToolStripMenuItem.Name = "новЧитателToolStripMenuItem";
            this.новЧитателToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.новЧитателToolStripMenuItem.Text = "Нов Читател";
            this.новЧитателToolStripMenuItem.Click += new System.EventHandler(this.новЧитателToolStripMenuItem_Click);
            // 
            // всичкиЧитателиToolStripMenuItem
            // 
            this.всичкиЧитателиToolStripMenuItem.Name = "всичкиЧитателиToolStripMenuItem";
            this.всичкиЧитателиToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.всичкиЧитателиToolStripMenuItem.Text = "Всички Читатели";
            this.всичкиЧитателиToolStripMenuItem.Click += new System.EventHandler(this.всичкиЧитателиToolStripMenuItem_Click);
            // 
            // търсенеToolStripMenuItem
            // 
            this.търсенеToolStripMenuItem.Name = "търсенеToolStripMenuItem";
            this.търсенеToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.търсенеToolStripMenuItem.Text = "Търсене";
            this.търсенеToolStripMenuItem.Click += new System.EventHandler(this.търсенеToolStripMenuItem_Click);
            // 
            // изтриванеToolStripMenuItem1
            // 
            this.изтриванеToolStripMenuItem1.Name = "изтриванеToolStripMenuItem1";
            this.изтриванеToolStripMenuItem1.Size = new System.Drawing.Size(198, 24);
            this.изтриванеToolStripMenuItem1.Text = "Изтриване";
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаКнигаToolStripMenuItem,
            this.всичкиКнигиToolStripMenuItem,
            this.търсенеНаКнигаToolStripMenuItem,
            this.изтриванеToolStripMenuItem});
            this.книгиToolStripMenuItem.Font = new System.Drawing.Font("a_FuturaRound", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.книгиToolStripMenuItem.Text = "Книги";
            // 
            // новаКнигаToolStripMenuItem
            // 
            this.новаКнигаToolStripMenuItem.Name = "новаКнигаToolStripMenuItem";
            this.новаКнигаToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.новаКнигаToolStripMenuItem.Text = "Нова Книга";
            this.новаКнигаToolStripMenuItem.Click += new System.EventHandler(this.новаКнигаToolStripMenuItem_Click);
            // 
            // всичкиКнигиToolStripMenuItem
            // 
            this.всичкиКнигиToolStripMenuItem.Name = "всичкиКнигиToolStripMenuItem";
            this.всичкиКнигиToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.всичкиКнигиToolStripMenuItem.Text = "Всички книги";
            this.всичкиКнигиToolStripMenuItem.Click += new System.EventHandler(this.всичкиКнигиToolStripMenuItem_Click);
            // 
            // търсенеНаКнигаToolStripMenuItem
            // 
            this.търсенеНаКнигаToolStripMenuItem.Name = "търсенеНаКнигаToolStripMenuItem";
            this.търсенеНаКнигаToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.търсенеНаКнигаToolStripMenuItem.Text = "Търсене ";
            this.търсенеНаКнигаToolStripMenuItem.Click += new System.EventHandler(this.търсенеНаКнигаToolStripMenuItem_Click);
            // 
            // изтриванеToolStripMenuItem
            // 
            this.изтриванеToolStripMenuItem.Name = "изтриванеToolStripMenuItem";
            this.изтриванеToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.изтриванеToolStripMenuItem.Text = "Изтриване";
            // 
            // помощToolStripMenuItem
            // 
            this.помощToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструкцииToolStripMenuItem,
            this.заАвтораToolStripMenuItem});
            this.помощToolStripMenuItem.Font = new System.Drawing.Font("a_FuturaRound", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.помощToolStripMenuItem.Name = "помощToolStripMenuItem";
            this.помощToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.помощToolStripMenuItem.Text = "Помощ";
            // 
            // инструкцииToolStripMenuItem
            // 
            this.инструкцииToolStripMenuItem.Name = "инструкцииToolStripMenuItem";
            this.инструкцииToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.инструкцииToolStripMenuItem.Text = "Инструкции";
            // 
            // заАвтораToolStripMenuItem
            // 
            this.заАвтораToolStripMenuItem.Name = "заАвтораToolStripMenuItem";
            this.заАвтораToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.заАвтораToolStripMenuItem.Text = "За автора";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 350);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(834, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LIBRARY";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem читателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новЧитателToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всичкиЧитателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаКнигаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всичкиКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem търсенеНаКнигаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструкцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заАвтораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem търсенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изтриванеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изтриванеToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}


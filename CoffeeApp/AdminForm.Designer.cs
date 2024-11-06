namespace CoffeeApp
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            toolStrip1 = new ToolStrip();
            ButtonAdd = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ButtonFilter = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            ButtonSearch = new ToolStripButton();
            TextBoxSearch = new ToolStripTextBox();
            toolStripSeparator2 = new ToolStripSeparator();
            ButtonSort = new ToolStripSplitButton();
            MenuItemSortName = new ToolStripMenuItem();
            MenuItemSortPopularity = new ToolStripMenuItem();
            MenuItemSortCheap = new ToolStripMenuItem();
            MenuItemSortExpensive = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            ButtonCasa = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            ButtonDropDB = new ToolStripButton();
            panel1 = new Panel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.SaddleBrown;
            toolStrip1.Font = new Font("Segoe UI", 10F);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ButtonAdd, toolStripSeparator1, ButtonFilter, toolStripSeparator3, ButtonSearch, TextBoxSearch, toolStripSeparator2, ButtonSort, toolStripSeparator4, ButtonCasa, toolStripSeparator5, ButtonDropDB });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0);
            toolStrip1.RightToLeft = RightToLeft.No;
            toolStrip1.Size = new Size(786, 30);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // ButtonAdd
            // 
            ButtonAdd.BackColor = Color.SaddleBrown;
            ButtonAdd.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonAdd.ForeColor = Color.FromArgb(224, 224, 224);
            ButtonAdd.Image = (Image)resources.GetObject("ButtonAdd.Image");
            ButtonAdd.ImageTransparentColor = Color.Magenta;
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(78, 27);
            ButtonAdd.Text = "Додати";
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 30);
            // 
            // ButtonFilter
            // 
            ButtonFilter.BackColor = Color.SaddleBrown;
            ButtonFilter.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonFilter.ForeColor = Color.FromArgb(224, 224, 224);
            ButtonFilter.Image = (Image)resources.GetObject("ButtonFilter.Image");
            ButtonFilter.ImageTransparentColor = Color.Magenta;
            ButtonFilter.Name = "ButtonFilter";
            ButtonFilter.Size = new Size(113, 27);
            ButtonFilter.Text = "Фільтрувати";
            ButtonFilter.Click += ButtonFilter_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 30);
            // 
            // ButtonSearch
            // 
            ButtonSearch.BackColor = Color.SaddleBrown;
            ButtonSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ButtonSearch.ForeColor = Color.FromArgb(82, 38, 7);
            ButtonSearch.Image = (Image)resources.GetObject("ButtonSearch.Image");
            ButtonSearch.ImageTransparentColor = Color.Magenta;
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(24, 27);
            ButtonSearch.Text = "toolStripButton2";
            ButtonSearch.ToolTipText = "Пошук";
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.BackColor = Color.LightGray;
            TextBoxSearch.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TextBoxSearch.ForeColor = Color.SaddleBrown;
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(237, 30);
            TextBoxSearch.Text = "Пошук...";
            TextBoxSearch.Leave += TextBoxSearch_Leave;
            TextBoxSearch.KeyPress += TextBoxSearch_KeyPress;
            TextBoxSearch.Click += TextBoxSearch_Click;
            TextBoxSearch.TextChanged += TextBoxSearch_TextChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 30);
            // 
            // ButtonSort
            // 
            ButtonSort.AutoSize = false;
            ButtonSort.BackColor = Color.SaddleBrown;
            ButtonSort.DropDownItems.AddRange(new ToolStripItem[] { MenuItemSortName, MenuItemSortPopularity, MenuItemSortCheap, MenuItemSortExpensive });
            ButtonSort.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonSort.ForeColor = Color.FromArgb(224, 224, 224);
            ButtonSort.Image = (Image)resources.GetObject("ButtonSort.Image");
            ButtonSort.ImageTransparentColor = Color.Magenta;
            ButtonSort.Name = "ButtonSort";
            ButtonSort.Size = new Size(182, 27);
            ButtonSort.Text = "За популярністю";
            // 
            // MenuItemSortName
            // 
            MenuItemSortName.BackColor = Color.SaddleBrown;
            MenuItemSortName.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MenuItemSortName.ForeColor = Color.FromArgb(224, 224, 224);
            MenuItemSortName.Name = "MenuItemSortName";
            MenuItemSortName.Size = new Size(234, 22);
            MenuItemSortName.Text = "За назвою";
            MenuItemSortName.Click += MenuItemSortName_Click;
            // 
            // MenuItemSortPopularity
            // 
            MenuItemSortPopularity.BackColor = Color.SaddleBrown;
            MenuItemSortPopularity.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MenuItemSortPopularity.ForeColor = Color.FromArgb(224, 224, 224);
            MenuItemSortPopularity.Name = "MenuItemSortPopularity";
            MenuItemSortPopularity.Size = new Size(234, 22);
            MenuItemSortPopularity.Text = "За популярністю";
            MenuItemSortPopularity.Click += MenuItemSortPopularity_Click;
            // 
            // MenuItemSortCheap
            // 
            MenuItemSortCheap.BackColor = Color.SaddleBrown;
            MenuItemSortCheap.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MenuItemSortCheap.ForeColor = Color.FromArgb(224, 224, 224);
            MenuItemSortCheap.Name = "MenuItemSortCheap";
            MenuItemSortCheap.Size = new Size(234, 22);
            MenuItemSortCheap.Text = "Від дешевих до дорогих";
            MenuItemSortCheap.Click += MenuItemSortCheap_Click;
            // 
            // MenuItemSortExpensive
            // 
            MenuItemSortExpensive.BackColor = Color.SaddleBrown;
            MenuItemSortExpensive.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MenuItemSortExpensive.ForeColor = Color.FromArgb(224, 224, 224);
            MenuItemSortExpensive.Name = "MenuItemSortExpensive";
            MenuItemSortExpensive.Size = new Size(234, 22);
            MenuItemSortExpensive.Text = "Від дорогих до дешевих";
            MenuItemSortExpensive.Click += MenuItemSortExpensive_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 30);
            // 
            // ButtonCasa
            // 
            ButtonCasa.BackColor = Color.SaddleBrown;
            ButtonCasa.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonCasa.ForeColor = Color.FromArgb(224, 224, 224);
            ButtonCasa.Image = (Image)resources.GetObject("ButtonCasa.Image");
            ButtonCasa.ImageTransparentColor = Color.Magenta;
            ButtonCasa.Name = "ButtonCasa";
            ButtonCasa.RightToLeft = RightToLeft.No;
            ButtonCasa.Size = new Size(62, 27);
            ButtonCasa.Text = "Каса";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 30);
            // 
            // ButtonDropDB
            // 
            ButtonDropDB.BackColor = Color.SaddleBrown;
            ButtonDropDB.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonDropDB.ForeColor = Color.FromArgb(82, 38, 7);
            ButtonDropDB.Image = (Image)resources.GetObject("ButtonDropDB.Image");
            ButtonDropDB.ImageTransparentColor = Color.Magenta;
            ButtonDropDB.Name = "ButtonDropDB";
            ButtonDropDB.Size = new Size(24, 27);
            ButtonDropDB.ToolTipText = "Скидання БД";
            ButtonDropDB.Click += ButtonDropDB_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Beige;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 30);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 341);
            panel1.TabIndex = 2;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 371);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminForm";
            Text = "Адміністратор";
            FormClosed += AdminForm_FormClosed;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ButtonFilter;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton ButtonSearch;
        private ToolStripTextBox TextBoxSearch;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSplitButton ButtonSort;
        private ToolStripMenuItem MenuItemSortName;
        private ToolStripMenuItem MenuItemSortCheap;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton ButtonCasa;
        private ToolStripButton ButtonAdd;
        private Panel panel1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton ButtonDropDB;
        private ToolStripMenuItem MenuItemSortExpensive;
        private ToolStripMenuItem MenuItemSortPopularity;
    }
}
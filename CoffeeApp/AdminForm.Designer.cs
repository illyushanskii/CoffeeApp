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
            toolStripSeparator1 = new ToolStripSeparator();
            ButtonFilter = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            ButtonSearch = new ToolStripButton();
            TextBoxSearch = new ToolStripTextBox();
            toolStripSeparator2 = new ToolStripSeparator();
            ButtonSort = new ToolStripSplitButton();
            MenuItemSortName = new ToolStripMenuItem();
            MenuItemSortCheap = new ToolStripMenuItem();
            MenuItemSortExpensive = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            ButtonAdd = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 10F);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { ButtonAdd, toolStripSeparator1, ButtonFilter, toolStripSeparator3, ButtonSearch, TextBoxSearch, toolStripSeparator2, ButtonSort, toolStripSeparator4, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0);
            toolStrip1.Size = new Size(769, 30);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 30);
            // 
            // ButtonFilter
            // 
            ButtonFilter.Image = (Image)resources.GetObject("ButtonFilter.Image");
            ButtonFilter.ImageTransparentColor = Color.Magenta;
            ButtonFilter.Name = "ButtonFilter";
            ButtonFilter.Size = new Size(128, 27);
            ButtonFilter.Text = "Фільтрувати";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 30);
            // 
            // ButtonSearch
            // 
            ButtonSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ButtonSearch.Image = (Image)resources.GetObject("ButtonSearch.Image");
            ButtonSearch.ImageTransparentColor = Color.Magenta;
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(29, 27);
            ButtonSearch.Text = "toolStripButton2";
            ButtonSearch.ToolTipText = "Пошук";
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Font = new Font("Segoe UI", 10F);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(270, 30);
            TextBoxSearch.Text = "Пошук...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 30);
            // 
            // ButtonSort
            // 
            ButtonSort.DropDownItems.AddRange(new ToolStripItem[] { MenuItemSortName, MenuItemSortCheap, MenuItemSortExpensive });
            ButtonSort.Image = (Image)resources.GetObject("ButtonSort.Image");
            ButtonSort.ImageTransparentColor = Color.Magenta;
            ButtonSort.Name = "ButtonSort";
            ButtonSort.Size = new Size(142, 27);
            ButtonSort.Text = "Сортування";
            // 
            // MenuItemSortName
            // 
            MenuItemSortName.Name = "MenuItemSortName";
            MenuItemSortName.Size = new Size(283, 28);
            MenuItemSortName.Text = "Назва";
            // 
            // MenuItemSortCheap
            // 
            MenuItemSortCheap.Name = "MenuItemSortCheap";
            MenuItemSortCheap.Size = new Size(283, 28);
            MenuItemSortCheap.Text = "Від дешевих до дорогих";
            // 
            // MenuItemSortExpensive
            // 
            MenuItemSortExpensive.Name = "MenuItemSortExpensive";
            MenuItemSortExpensive.Size = new Size(283, 28);
            MenuItemSortExpensive.Text = "Від дорогих до дешевих";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 30);
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.RightToLeft = RightToLeft.No;
            toolStripButton1.Size = new Size(70, 27);
            toolStripButton1.Text = "Каса";
            // 
            // ButtonAdd
            // 
            ButtonAdd.Image = (Image)resources.GetObject("ButtonAdd.Image");
            ButtonAdd.ImageTransparentColor = Color.Magenta;
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(91, 27);
            ButtonAdd.Text = "Додати";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 450);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            Text = "Адміністратор";
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
        private ToolStripMenuItem MenuItemSortExpensive;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton1;
        private ToolStripButton ButtonAdd;
    }
}
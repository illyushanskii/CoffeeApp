namespace CoffeeApp
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            LabelAdmin = new ToolStripLabel();
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
            ButtonCart = new ToolStripButton();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Beige;
            toolStrip1.Font = new Font("Segoe UI", 10F);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { LabelAdmin, toolStripSeparator1, ButtonFilter, toolStripSeparator3, ButtonSearch, TextBoxSearch, toolStripSeparator2, ButtonSort, toolStripSeparator4, ButtonCart });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0);

            toolStrip1.Size = new Size(920, 32);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // LabelAdmin
            // 
            LabelAdmin.BackColor = Color.Beige;
            LabelAdmin.Font = new Font("Jokerman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelAdmin.Image = (Image)resources.GetObject("LabelAdmin.Image");
            LabelAdmin.Name = "LabelAdmin";
            LabelAdmin.Size = new Size(158, 29);
            LabelAdmin.Text = "Coffee Vibe";
            LabelAdmin.MouseDown += LabelAdmin_MouseDown;
            LabelAdmin.MouseUp += LabelAdmin_MouseUp;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 32);
            // 
            // ButtonFilter
            // 
            ButtonFilter.BackColor = Color.Beige;
            ButtonFilter.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonFilter.Image = (Image)resources.GetObject("ButtonFilter.Image");
            ButtonFilter.ImageTransparentColor = Color.Magenta;
            ButtonFilter.Name = "ButtonFilter";
            ButtonFilter.Size = new Size(135, 29);
            ButtonFilter.Text = "Фільтрувати";
            ButtonFilter.Click += ButtonFilter_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 32);
            // 
            // ButtonSearch
            // 
            ButtonSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ButtonSearch.Image = (Image)resources.GetObject("ButtonSearch.Image");
            ButtonSearch.ImageTransparentColor = Color.Magenta;
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(29, 29);
            ButtonSearch.Text = "toolStripButton2";
            ButtonSearch.ToolTipText = "Пошук";
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.BackColor = SystemColors.Window;
            TextBoxSearch.Font = new Font("Segoe UI", 10F);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(270, 32);
            TextBoxSearch.Text = "Пошук...";
            TextBoxSearch.Leave += TextBoxSearch_Leave;
            TextBoxSearch.KeyPress += TextBoxSearch_KeyPress;
            TextBoxSearch.Click += TextBoxSearch_Click;
            TextBoxSearch.TextChanged += TextBoxSearch_TextChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 32);
            // 
            // ButtonSort
            // 
            ButtonSort.AutoSize = false;
            ButtonSort.BackColor = Color.Beige;
            ButtonSort.DropDownItems.AddRange(new ToolStripItem[] { MenuItemSortName, MenuItemSortPopularity, MenuItemSortCheap, MenuItemSortExpensive });
            ButtonSort.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonSort.Image = (Image)resources.GetObject("ButtonSort.Image");
            ButtonSort.ImageTransparentColor = Color.Magenta;
            ButtonSort.Name = "ButtonSort";
            ButtonSort.Size = new Size(182, 27);
            ButtonSort.Text = "За популярністю";
            // 
            // MenuItemSortName
            // 
            MenuItemSortName.BackColor = Color.Beige;
            MenuItemSortName.Name = "MenuItemSortName";
            MenuItemSortName.Size = new Size(294, 26);
            MenuItemSortName.Text = "За назвою";
            MenuItemSortName.Click += MenuItemSortName_Click;
            // 
            // MenuItemSortPopularity
            // 
            MenuItemSortPopularity.BackColor = Color.Beige;
            MenuItemSortPopularity.Name = "MenuItemSortPopularity";
            MenuItemSortPopularity.Size = new Size(294, 26);
            MenuItemSortPopularity.Text = "За популярністю";
            MenuItemSortPopularity.Click += MenuItemSortPopularity_Click;
            // 
            // MenuItemSortCheap
            // 
            MenuItemSortCheap.BackColor = Color.Beige;
            MenuItemSortCheap.Name = "MenuItemSortCheap";
            MenuItemSortCheap.Size = new Size(294, 26);
            MenuItemSortCheap.Text = "Від дешевих до дорогих";
            MenuItemSortCheap.Click += MenuItemSortCheap_Click;
            // 
            // MenuItemSortExpensive
            // 
            MenuItemSortExpensive.BackColor = Color.Beige;
            MenuItemSortExpensive.Name = "MenuItemSortExpensive";
            MenuItemSortExpensive.Size = new Size(294, 26);
            MenuItemSortExpensive.Text = "Від дорогих до дешевих";
            MenuItemSortExpensive.Click += MenuItemSortExpensive_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 32);
            // 
            // ButtonCart
            // 
            ButtonCart.BackColor = Color.Beige;
            ButtonCart.Image = (Image)resources.GetObject("ButtonCart.Image");
            ButtonCart.ImageTransparentColor = Color.Magenta;
            ButtonCart.Name = "ButtonCart";
            ButtonCart.RightToLeft = RightToLeft.No;
            ButtonCart.Size = new Size(86, 29);
            ButtonCart.Text = "Кошик";
            ButtonCart.Click += ButtonCart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Tan;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 32);
            panel1.Name = "panel1";

            panel1.Size = new Size(920, 443);
            panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(920, 475);

            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainForm";
            Text = "Coffee...";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripTextBox TextBoxSearch;
        private ToolStripButton ButtonSearch;
        private ToolStripButton ButtonFilter;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSplitButton ButtonSort;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem MenuItemSortName;
        private ToolStripMenuItem MenuItemSortCheap;
        private ToolStripMenuItem MenuItemSortExpensive;
        public ToolStripButton ButtonCart;
        private ToolStripLabel LabelAdmin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Panel panel1;
        private ToolStripMenuItem MenuItemSortPopularity;
    }
}
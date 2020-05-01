namespace BookShelf
{
    partial class BookShelf
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookShelfLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naming = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddNew = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowMagazines = new System.Windows.Forms.Button();
            this.ShowBooks = new System.Windows.Forms.Button();
            this.ShowAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.ApplyFilterButton = new System.Windows.Forms.Button();
            this.GenreCheckBox = new System.Windows.Forms.CheckBox();
            this.NumberCheckBox = new System.Windows.Forms.CheckBox();
            this.FrequencyCheckBox = new System.Windows.Forms.CheckBox();
            this.PriceCheckBox = new System.Windows.Forms.CheckBox();
            this.PagesCheckBox = new System.Windows.Forms.CheckBox();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.AuthorCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseFilterLabel = new System.Windows.Forms.Label();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.OpenFilterLabel = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.FilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.Size = new System.Drawing.Size(1062, 36);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 32);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(194, 32);
            this.createNewToolStripMenuItem.Text = "Create new";
            this.createNewToolStripMenuItem.Click += new System.EventHandler(this.CreateNewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(194, 32);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(194, 32);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(194, 32);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.itemToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(65, 32);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magazineToolStripMenuItem1,
            this.bookToolStripMenuItem1});
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(175, 32);
            this.addNewToolStripMenuItem.Text = "Add new";
            // 
            // magazineToolStripMenuItem1
            // 
            this.magazineToolStripMenuItem1.Name = "magazineToolStripMenuItem1";
            this.magazineToolStripMenuItem1.Size = new System.Drawing.Size(183, 32);
            this.magazineToolStripMenuItem1.Text = "Magazine";
            this.magazineToolStripMenuItem1.Click += new System.EventHandler(this.MagazineToolStripMenuItem1_Click);
            // 
            // bookToolStripMenuItem1
            // 
            this.bookToolStripMenuItem1.Name = "bookToolStripMenuItem1";
            this.bookToolStripMenuItem1.Size = new System.Drawing.Size(183, 32);
            this.bookToolStripMenuItem1.Text = "Book";
            this.bookToolStripMenuItem1.Click += new System.EventHandler(this.BookToolStripMenuItem1_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(175, 32);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(175, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutAuthorToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(67, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.viewHelpToolStripMenuItem.Text = "View help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.ViewHelpToolStripMenuItem_Click);
            // 
            // aboutAuthorToolStripMenuItem
            // 
            this.aboutAuthorToolStripMenuItem.Name = "aboutAuthorToolStripMenuItem";
            this.aboutAuthorToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.aboutAuthorToolStripMenuItem.Text = "About author";
            this.aboutAuthorToolStripMenuItem.Click += new System.EventHandler(this.AboutAuthorToolStripMenuItem_Click);
            // 
            // BookShelfLabel
            // 
            this.BookShelfLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookShelfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookShelfLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BookShelfLabel.Location = new System.Drawing.Point(0, 36);
            this.BookShelfLabel.Name = "BookShelfLabel";
            this.BookShelfLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.BookShelfLabel.Size = new System.Drawing.Size(1062, 76);
            this.BookShelfLabel.TabIndex = 1;
            this.BookShelfLabel.Text = "Book Shelf";
            this.BookShelfLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Author,
            this.Naming,
            this.Pages,
            this.Year,
            this.Price,
            this.Frequency,
            this.Number,
            this.Genre});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(219, 115);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(2560, 1440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(819, 353);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            // 
            // Naming
            // 
            this.Naming.HeaderText = "Name";
            this.Naming.MinimumWidth = 6;
            this.Naming.Name = "Naming";
            // 
            // Pages
            // 
            this.Pages.HeaderText = "Pages";
            this.Pages.MinimumWidth = 6;
            this.Pages.Name = "Pages";
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.MinimumWidth = 6;
            this.Frequency.Name = "Frequency";
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            // 
            // AddNew
            // 
            this.AddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNew.Location = new System.Drawing.Point(219, 500);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(147, 38);
            this.AddNew.TabIndex = 3;
            this.AddNew.Text = "Add new\r\n";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Update
            // 
            this.Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update.Location = new System.Drawing.Point(404, 500);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(147, 38);
            this.Update.TabIndex = 4;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShowMagazines);
            this.panel1.Controls.Add(this.ShowBooks);
            this.panel1.Controls.Add(this.ShowAll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 180);
            this.panel1.TabIndex = 5;
            // 
            // ShowMagazines
            // 
            this.ShowMagazines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowMagazines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowMagazines.Location = new System.Drawing.Point(0, 135);
            this.ShowMagazines.Name = "ShowMagazines";
            this.ShowMagazines.Size = new System.Drawing.Size(184, 38);
            this.ShowMagazines.TabIndex = 8;
            this.ShowMagazines.Text = "Show Magazines";
            this.ShowMagazines.UseVisualStyleBackColor = true;
            this.ShowMagazines.Click += new System.EventHandler(this.ShowMagazines_Click);
            // 
            // ShowBooks
            // 
            this.ShowBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ShowBooks.Location = new System.Drawing.Point(0, 91);
            this.ShowBooks.Name = "ShowBooks";
            this.ShowBooks.Size = new System.Drawing.Size(184, 38);
            this.ShowBooks.TabIndex = 7;
            this.ShowBooks.Text = "Show Books";
            this.ShowBooks.UseVisualStyleBackColor = true;
            this.ShowBooks.Click += new System.EventHandler(this.ShowBooks_Click);
            // 
            // ShowAll
            // 
            this.ShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ShowAll.Location = new System.Drawing.Point(0, 47);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(184, 38);
            this.ShowAll.TabIndex = 6;
            this.ShowAll.Text = "Show All";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nav Bar Menu";
            // 
            // FilterPanel
            // 
            this.FilterPanel.Controls.Add(this.ApplyFilterButton);
            this.FilterPanel.Controls.Add(this.GenreCheckBox);
            this.FilterPanel.Controls.Add(this.NumberCheckBox);
            this.FilterPanel.Controls.Add(this.FrequencyCheckBox);
            this.FilterPanel.Controls.Add(this.PriceCheckBox);
            this.FilterPanel.Controls.Add(this.PagesCheckBox);
            this.FilterPanel.Controls.Add(this.NameCheckBox);
            this.FilterPanel.Controls.Add(this.AuthorCheckBox);
            this.FilterPanel.Controls.Add(this.CloseFilterLabel);
            this.FilterPanel.Controls.Add(this.FilterLabel);
            this.FilterPanel.Location = new System.Drawing.Point(10, 301);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(186, 256);
            this.FilterPanel.TabIndex = 6;
            this.FilterPanel.Visible = false;
            // 
            // ApplyFilterButton
            // 
            this.ApplyFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ApplyFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ApplyFilterButton.Location = new System.Drawing.Point(22, 201);
            this.ApplyFilterButton.Name = "ApplyFilterButton";
            this.ApplyFilterButton.Size = new System.Drawing.Size(118, 38);
            this.ApplyFilterButton.TabIndex = 15;
            this.ApplyFilterButton.Text = "Apply";
            this.ApplyFilterButton.UseVisualStyleBackColor = true;
            // 
            // GenreCheckBox
            // 
            this.GenreCheckBox.AutoSize = true;
            this.GenreCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenreCheckBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.GenreCheckBox.Location = new System.Drawing.Point(22, 177);
            this.GenreCheckBox.Name = "GenreCheckBox";
            this.GenreCheckBox.Size = new System.Drawing.Size(82, 24);
            this.GenreCheckBox.TabIndex = 14;
            this.GenreCheckBox.Text = "Genre";
            this.GenreCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumberCheckBox
            // 
            this.NumberCheckBox.AutoSize = true;
            this.NumberCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberCheckBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.NumberCheckBox.Location = new System.Drawing.Point(22, 155);
            this.NumberCheckBox.Name = "NumberCheckBox";
            this.NumberCheckBox.Size = new System.Drawing.Size(96, 24);
            this.NumberCheckBox.TabIndex = 12;
            this.NumberCheckBox.Text = "Number";
            this.NumberCheckBox.UseVisualStyleBackColor = true;
            // 
            // FrequencyCheckBox
            // 
            this.FrequencyCheckBox.AutoSize = true;
            this.FrequencyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FrequencyCheckBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FrequencyCheckBox.Location = new System.Drawing.Point(22, 133);
            this.FrequencyCheckBox.Name = "FrequencyCheckBox";
            this.FrequencyCheckBox.Size = new System.Drawing.Size(118, 24);
            this.FrequencyCheckBox.TabIndex = 10;
            this.FrequencyCheckBox.Text = "Frequency";
            this.FrequencyCheckBox.UseVisualStyleBackColor = true;
            // 
            // PriceCheckBox
            // 
            this.PriceCheckBox.AutoSize = true;
            this.PriceCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceCheckBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.PriceCheckBox.Location = new System.Drawing.Point(22, 111);
            this.PriceCheckBox.Name = "PriceCheckBox";
            this.PriceCheckBox.Size = new System.Drawing.Size(75, 24);
            this.PriceCheckBox.TabIndex = 8;
            this.PriceCheckBox.Text = "Price";
            this.PriceCheckBox.UseVisualStyleBackColor = true;
            // 
            // PagesCheckBox
            // 
            this.PagesCheckBox.AutoSize = true;
            this.PagesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PagesCheckBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.PagesCheckBox.Location = new System.Drawing.Point(22, 89);
            this.PagesCheckBox.Name = "PagesCheckBox";
            this.PagesCheckBox.Size = new System.Drawing.Size(83, 24);
            this.PagesCheckBox.TabIndex = 6;
            this.PagesCheckBox.Text = "Pages";
            this.PagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameCheckBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.NameCheckBox.Location = new System.Drawing.Point(22, 67);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(79, 24);
            this.NameCheckBox.TabIndex = 4;
            this.NameCheckBox.Text = "Name";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // AuthorCheckBox
            // 
            this.AuthorCheckBox.AutoSize = true;
            this.AuthorCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorCheckBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.AuthorCheckBox.Location = new System.Drawing.Point(22, 45);
            this.AuthorCheckBox.Name = "AuthorCheckBox";
            this.AuthorCheckBox.Size = new System.Drawing.Size(86, 24);
            this.AuthorCheckBox.TabIndex = 3;
            this.AuthorCheckBox.Text = "Author";
            this.AuthorCheckBox.UseVisualStyleBackColor = true;
            // 
            // CloseFilterLabel
            // 
            this.CloseFilterLabel.AutoSize = true;
            this.CloseFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseFilterLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CloseFilterLabel.Location = new System.Drawing.Point(161, 92);
            this.CloseFilterLabel.Name = "CloseFilterLabel";
            this.CloseFilterLabel.Size = new System.Drawing.Size(25, 25);
            this.CloseFilterLabel.TabIndex = 2;
            this.CloseFilterLabel.Text = "<";
            this.CloseFilterLabel.Click += new System.EventHandler(this.CloseFilterLabel_Click);
            this.CloseFilterLabel.MouseLeave += new System.EventHandler(this.CloseFilterLabel_MouseLeave);
            this.CloseFilterLabel.MouseHover += new System.EventHandler(this.CloseFilterLabel_MouseHover);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FilterLabel.Location = new System.Drawing.Point(61, 15);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(60, 25);
            this.FilterLabel.TabIndex = 1;
            this.FilterLabel.Text = "Filter";
            // 
            // OpenFilterLabel
            // 
            this.OpenFilterLabel.AutoSize = true;
            this.OpenFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFilterLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpenFilterLabel.Location = new System.Drawing.Point(5, 396);
            this.OpenFilterLabel.Name = "OpenFilterLabel";
            this.OpenFilterLabel.Size = new System.Drawing.Size(25, 25);
            this.OpenFilterLabel.TabIndex = 15;
            this.OpenFilterLabel.Text = ">";
            this.OpenFilterLabel.Click += new System.EventHandler(this.OpenFilterLabel_Click);
            this.OpenFilterLabel.MouseLeave += new System.EventHandler(this.OpenFilterLabel_MouseLeave);
            this.OpenFilterLabel.MouseHover += new System.EventHandler(this.OpenFilterLabel_MouseHover);
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(588, 500);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(147, 38);
            this.Delete.TabIndex = 16;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // BookShelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BookShelfLabel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.OpenFilterLabel);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "BookShelf";
            this.Text = "Book Shelf";
            this.Load += new System.EventHandler(this.BookShelf_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FilterPanel.ResumeLayout(false);
            this.FilterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magazineToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAuthorToolStripMenuItem;
        private System.Windows.Forms.Label BookShelfLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShowMagazines;
        private System.Windows.Forms.Button ShowBooks;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Label CloseFilterLabel;
        private System.Windows.Forms.CheckBox GenreCheckBox;
        private System.Windows.Forms.CheckBox NumberCheckBox;
        private System.Windows.Forms.CheckBox FrequencyCheckBox;
        private System.Windows.Forms.CheckBox PriceCheckBox;
        private System.Windows.Forms.CheckBox PagesCheckBox;
        private System.Windows.Forms.CheckBox NameCheckBox;
        private System.Windows.Forms.CheckBox AuthorCheckBox;
        private System.Windows.Forms.Label OpenFilterLabel;
        private System.Windows.Forms.Button ApplyFilterButton;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naming;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
    }
}


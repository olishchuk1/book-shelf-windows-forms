using System.Windows.Forms;

namespace BookShelf
{
    partial class Insert
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
            this.magazinePanel = new System.Windows.Forms.Panel();
            this.MagazineFrequencyValidation = new System.Windows.Forms.Label();
            this.MagazinePriceValidation = new System.Windows.Forms.Label();
            this.MagazineYearValidation = new System.Windows.Forms.Label();
            this.MagazinePagesValidation = new System.Windows.Forms.Label();
            this.MagazineNameValidation = new System.Windows.Forms.Label();
            this.MagazineAuthorValidation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MagazineAddButton = new System.Windows.Forms.Button();
            this.MagazineCancel = new System.Windows.Forms.Button();
            this.MagazineNumberLabel = new System.Windows.Forms.Label();
            this.MagazineFrequancyLabel = new System.Windows.Forms.Label();
            this.MagazinePriceLabel = new System.Windows.Forms.Label();
            this.MagazineYearLabel = new System.Windows.Forms.Label();
            this.MagazinePagesLabel = new System.Windows.Forms.Label();
            this.MagazineNameLabel = new System.Windows.Forms.Label();
            this.MagazineAuthorLabel = new System.Windows.Forms.Label();
            this.MagazineNumber = new System.Windows.Forms.TextBox();
            this.MagazineFrequency = new System.Windows.Forms.TextBox();
            this.MagazinePrice = new System.Windows.Forms.TextBox();
            this.MagazineYear = new System.Windows.Forms.TextBox();
            this.MagazinePages = new System.Windows.Forms.TextBox();
            this.MagazineName = new System.Windows.Forms.TextBox();
            this.MagazineAuthor = new System.Windows.Forms.TextBox();
            this.MagazineNumberValidation = new System.Windows.Forms.Label();
            this.bookPanel = new System.Windows.Forms.Panel();
            this.BookGenreValidation = new System.Windows.Forms.Label();
            this.BookCancel = new System.Windows.Forms.Button();
            this.BookPriceValidation = new System.Windows.Forms.Label();
            this.BookPagesValidation = new System.Windows.Forms.Label();
            this.BookYearValidation = new System.Windows.Forms.Label();
            this.BookNameValidation = new System.Windows.Forms.Label();
            this.BookAuthorValidation = new System.Windows.Forms.Label();
            this.BookLabel = new System.Windows.Forms.Label();
            this.BookAddButton = new System.Windows.Forms.Button();
            this.BookGenreLabel = new System.Windows.Forms.Label();
            this.BookPriceLabel = new System.Windows.Forms.Label();
            this.BookYearLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BookAuthorLabel = new System.Windows.Forms.Label();
            this.BookGenre = new System.Windows.Forms.TextBox();
            this.BookPrice = new System.Windows.Forms.TextBox();
            this.BookYear = new System.Windows.Forms.TextBox();
            this.BookPages = new System.Windows.Forms.TextBox();
            this.BookName = new System.Windows.Forms.TextBox();
            this.BookAuthor = new System.Windows.Forms.TextBox();
            this.magazinePanel.SuspendLayout();
            this.bookPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // magazinePanel
            // 
            this.magazinePanel.CausesValidation = false;
            this.magazinePanel.Controls.Add(this.MagazineFrequencyValidation);
            this.magazinePanel.Controls.Add(this.MagazinePriceValidation);
            this.magazinePanel.Controls.Add(this.MagazineYearValidation);
            this.magazinePanel.Controls.Add(this.MagazinePagesValidation);
            this.magazinePanel.Controls.Add(this.MagazineNameValidation);
            this.magazinePanel.Controls.Add(this.MagazineAuthorValidation);
            this.magazinePanel.Controls.Add(this.label1);
            this.magazinePanel.Controls.Add(this.MagazineAddButton);
            this.magazinePanel.Controls.Add(this.MagazineCancel);
            this.magazinePanel.Controls.Add(this.MagazineNumberLabel);
            this.magazinePanel.Controls.Add(this.MagazineFrequancyLabel);
            this.magazinePanel.Controls.Add(this.MagazinePriceLabel);
            this.magazinePanel.Controls.Add(this.MagazineYearLabel);
            this.magazinePanel.Controls.Add(this.MagazinePagesLabel);
            this.magazinePanel.Controls.Add(this.MagazineNameLabel);
            this.magazinePanel.Controls.Add(this.MagazineAuthorLabel);
            this.magazinePanel.Controls.Add(this.MagazineNumber);
            this.magazinePanel.Controls.Add(this.MagazineFrequency);
            this.magazinePanel.Controls.Add(this.MagazinePrice);
            this.magazinePanel.Controls.Add(this.MagazineYear);
            this.magazinePanel.Controls.Add(this.MagazinePages);
            this.magazinePanel.Controls.Add(this.MagazineName);
            this.magazinePanel.Controls.Add(this.MagazineAuthor);
            this.magazinePanel.Controls.Add(this.MagazineNumberValidation);
            this.magazinePanel.Location = new System.Drawing.Point(146, 15);
            this.magazinePanel.MaximumSize = new System.Drawing.Size(566, 561);
            this.magazinePanel.MinimumSize = new System.Drawing.Size(566, 561);
            this.magazinePanel.Name = "magazinePanel";
            this.magazinePanel.Size = new System.Drawing.Size(566, 561);
            this.magazinePanel.TabIndex = 0;
            // 
            // MagazineFrequencyValidation
            // 
            this.MagazineFrequencyValidation.AutoSize = true;
            this.MagazineFrequencyValidation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MagazineFrequencyValidation.Location = new System.Drawing.Point(296, 317);
            this.MagazineFrequencyValidation.Name = "MagazineFrequencyValidation";
            this.MagazineFrequencyValidation.Size = new System.Drawing.Size(134, 17);
            this.MagazineFrequencyValidation.TabIndex = 26;
            this.MagazineFrequencyValidation.Text = "should be a number";
            this.MagazineFrequencyValidation.Visible = false;
            // 
            // MagazinePriceValidation
            // 
            this.MagazinePriceValidation.AutoSize = true;
            this.MagazinePriceValidation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MagazinePriceValidation.Location = new System.Drawing.Point(295, 265);
            this.MagazinePriceValidation.Name = "MagazinePriceValidation";
            this.MagazinePriceValidation.Size = new System.Drawing.Size(193, 17);
            this.MagazinePriceValidation.TabIndex = 25;
            this.MagazinePriceValidation.Text = "the price should be a number";
            this.MagazinePriceValidation.Visible = false;
            // 
            // MagazineYearValidation
            // 
            this.MagazineYearValidation.AutoSize = true;
            this.MagazineYearValidation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MagazineYearValidation.Location = new System.Drawing.Point(295, 216);
            this.MagazineYearValidation.Name = "MagazineYearValidation";
            this.MagazineYearValidation.Size = new System.Drawing.Size(190, 17);
            this.MagazineYearValidation.TabIndex = 24;
            this.MagazineYearValidation.Text = "the year should be a number";
            this.MagazineYearValidation.Visible = false;
            // 
            // MagazinePagesValidation
            // 
            this.MagazinePagesValidation.AutoSize = true;
            this.MagazinePagesValidation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MagazinePagesValidation.Location = new System.Drawing.Point(296, 167);
            this.MagazinePagesValidation.Name = "MagazinePagesValidation";
            this.MagazinePagesValidation.Size = new System.Drawing.Size(134, 17);
            this.MagazinePagesValidation.TabIndex = 23;
            this.MagazinePagesValidation.Text = "should be a number";
            this.MagazinePagesValidation.Visible = false;
            // 
            // MagazineNameValidation
            // 
            this.MagazineNameValidation.AutoSize = true;
            this.MagazineNameValidation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MagazineNameValidation.Location = new System.Drawing.Point(296, 119);
            this.MagazineNameValidation.Name = "MagazineNameValidation";
            this.MagazineNameValidation.Size = new System.Drawing.Size(218, 17);
            this.MagazineNameValidation.TabIndex = 21;
            this.MagazineNameValidation.Text = "the length should be less than 30";
            this.MagazineNameValidation.Visible = false;
            // 
            // MagazineAuthorValidation
            // 
            this.MagazineAuthorValidation.AutoSize = true;
            this.MagazineAuthorValidation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MagazineAuthorValidation.Location = new System.Drawing.Point(296, 69);
            this.MagazineAuthorValidation.Name = "MagazineAuthorValidation";
            this.MagazineAuthorValidation.Size = new System.Drawing.Size(210, 17);
            this.MagazineAuthorValidation.TabIndex = 20;
            this.MagazineAuthorValidation.Text = "the lengt should be less than 25";
            this.MagazineAuthorValidation.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(167, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add new magazine:";
            // 
            // MagazineAddButton
            // 
            this.MagazineAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MagazineAddButton.Location = new System.Drawing.Point(122, 510);
            this.MagazineAddButton.Name = "MagazineAddButton";
            this.MagazineAddButton.Size = new System.Drawing.Size(147, 38);
            this.MagazineAddButton.TabIndex = 16;
            this.MagazineAddButton.Text = "Add";
            this.MagazineAddButton.UseVisualStyleBackColor = true;
            this.MagazineAddButton.Click += new System.EventHandler(this.MagazineAddButton_Click);
            // 
            // MagazineCancel
            // 
            this.MagazineCancel.CausesValidation = false;
            this.MagazineCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MagazineCancel.Location = new System.Drawing.Point(298, 510);
            this.MagazineCancel.Name = "MagazineCancel";
            this.MagazineCancel.Size = new System.Drawing.Size(147, 38);
            this.MagazineCancel.TabIndex = 15;
            this.MagazineCancel.Text = "Cancel";
            this.MagazineCancel.UseVisualStyleBackColor = true;
            this.MagazineCancel.Click += new System.EventHandler(this.MagazineCancel_Click);
            // 
            // MagazineNumberLabel
            // 
            this.MagazineNumberLabel.AutoSize = true;
            this.MagazineNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MagazineNumberLabel.ForeColor = System.Drawing.Color.Snow;
            this.MagazineNumberLabel.Location = new System.Drawing.Point(64, 390);
            this.MagazineNumberLabel.Name = "MagazineNumberLabel";
            this.MagazineNumberLabel.Size = new System.Drawing.Size(192, 26);
            this.MagazineNumberLabel.TabIndex = 14;
            this.MagazineNumberLabel.Text = "Magazine number:";
            // 
            // MagazineFrequancyLabel
            // 
            this.MagazineFrequancyLabel.AutoSize = true;
            this.MagazineFrequancyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MagazineFrequancyLabel.ForeColor = System.Drawing.Color.Snow;
            this.MagazineFrequancyLabel.Location = new System.Drawing.Point(64, 337);
            this.MagazineFrequancyLabel.Name = "MagazineFrequancyLabel";
            this.MagazineFrequancyLabel.Size = new System.Drawing.Size(213, 26);
            this.MagazineFrequancyLabel.TabIndex = 13;
            this.MagazineFrequancyLabel.Text = "Frequancy (t/month):";
            // 
            // MagazinePriceLabel
            // 
            this.MagazinePriceLabel.AutoSize = true;
            this.MagazinePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MagazinePriceLabel.ForeColor = System.Drawing.Color.Snow;
            this.MagazinePriceLabel.Location = new System.Drawing.Point(64, 285);
            this.MagazinePriceLabel.Name = "MagazinePriceLabel";
            this.MagazinePriceLabel.Size = new System.Drawing.Size(229, 26);
            this.MagazinePriceLabel.TabIndex = 12;
            this.MagazinePriceLabel.Text = "Price of the magazine:";
            // 
            // MagazineYearLabel
            // 
            this.MagazineYearLabel.AutoSize = true;
            this.MagazineYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MagazineYearLabel.ForeColor = System.Drawing.Color.Snow;
            this.MagazineYearLabel.Location = new System.Drawing.Point(64, 236);
            this.MagazineYearLabel.Name = "MagazineYearLabel";
            this.MagazineYearLabel.Size = new System.Drawing.Size(193, 26);
            this.MagazineYearLabel.TabIndex = 11;
            this.MagazineYearLabel.Text = "Year of publishing:";
            // 
            // MagazinePagesLabel
            // 
            this.MagazinePagesLabel.AutoSize = true;
            this.MagazinePagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MagazinePagesLabel.ForeColor = System.Drawing.Color.Snow;
            this.MagazinePagesLabel.Location = new System.Drawing.Point(64, 185);
            this.MagazinePagesLabel.Name = "MagazinePagesLabel";
            this.MagazinePagesLabel.Size = new System.Drawing.Size(185, 26);
            this.MagazinePagesLabel.TabIndex = 10;
            this.MagazinePagesLabel.Text = "Number of pages:";
            // 
            // MagazineNameLabel
            // 
            this.MagazineNameLabel.AutoSize = true;
            this.MagazineNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MagazineNameLabel.ForeColor = System.Drawing.Color.Snow;
            this.MagazineNameLabel.Location = new System.Drawing.Point(64, 136);
            this.MagazineNameLabel.Name = "MagazineNameLabel";
            this.MagazineNameLabel.Size = new System.Drawing.Size(173, 26);
            this.MagazineNameLabel.TabIndex = 9;
            this.MagazineNameLabel.Text = "Magazine name:";
            // 
            // MagazineAuthorLabel
            // 
            this.MagazineAuthorLabel.AutoSize = true;
            this.MagazineAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MagazineAuthorLabel.ForeColor = System.Drawing.Color.Snow;
            this.MagazineAuthorLabel.Location = new System.Drawing.Point(64, 89);
            this.MagazineAuthorLabel.Name = "MagazineAuthorLabel";
            this.MagazineAuthorLabel.Size = new System.Drawing.Size(143, 26);
            this.MagazineAuthorLabel.TabIndex = 8;
            this.MagazineAuthorLabel.Text = "Author name:";
            // 
            // MagazineNumber
            // 
            this.MagazineNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MagazineNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MagazineNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MagazineNumber.Location = new System.Drawing.Point(299, 390);
            this.MagazineNumber.Name = "MagazineNumber";
            this.MagazineNumber.Size = new System.Drawing.Size(215, 25);
            this.MagazineNumber.TabIndex = 6;
            this.MagazineNumber.Validating += new System.ComponentModel.CancelEventHandler(this.MagazineNumber_Validating);
            // 
            // MagazineFrequency
            // 
            this.MagazineFrequency.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MagazineFrequency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MagazineFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MagazineFrequency.Location = new System.Drawing.Point(299, 337);
            this.MagazineFrequency.Name = "MagazineFrequency";
            this.MagazineFrequency.Size = new System.Drawing.Size(215, 25);
            this.MagazineFrequency.TabIndex = 5;
            this.MagazineFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.MagazineFrequency_Validating);
            // 
            // MagazinePrice
            // 
            this.MagazinePrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MagazinePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MagazinePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MagazinePrice.Location = new System.Drawing.Point(299, 285);
            this.MagazinePrice.Name = "MagazinePrice";
            this.MagazinePrice.Size = new System.Drawing.Size(215, 25);
            this.MagazinePrice.TabIndex = 4;
            this.MagazinePrice.Validating += new System.ComponentModel.CancelEventHandler(this.MagazinePrice_Validating);
            // 
            // MagazineYear
            // 
            this.MagazineYear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MagazineYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MagazineYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MagazineYear.Location = new System.Drawing.Point(299, 236);
            this.MagazineYear.Name = "MagazineYear";
            this.MagazineYear.Size = new System.Drawing.Size(215, 25);
            this.MagazineYear.TabIndex = 3;
            this.MagazineYear.Validating += new System.ComponentModel.CancelEventHandler(this.MagazineYear_Validating);
            // 
            // MagazinePages
            // 
            this.MagazinePages.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MagazinePages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MagazinePages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MagazinePages.Location = new System.Drawing.Point(298, 185);
            this.MagazinePages.Name = "MagazinePages";
            this.MagazinePages.Size = new System.Drawing.Size(216, 25);
            this.MagazinePages.TabIndex = 2;
            this.MagazinePages.Validating += new System.ComponentModel.CancelEventHandler(this.MagazinePages_Validating);
            // 
            // MagazineName
            // 
            this.MagazineName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MagazineName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MagazineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MagazineName.Location = new System.Drawing.Point(298, 139);
            this.MagazineName.Name = "MagazineName";
            this.MagazineName.Size = new System.Drawing.Size(216, 25);
            this.MagazineName.TabIndex = 1;
            this.MagazineName.Validating += new System.ComponentModel.CancelEventHandler(this.MagazineName_Validating);
            // 
            // MagazineAuthor
            // 
            this.MagazineAuthor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MagazineAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MagazineAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MagazineAuthor.Location = new System.Drawing.Point(298, 89);
            this.MagazineAuthor.Name = "MagazineAuthor";
            this.MagazineAuthor.Size = new System.Drawing.Size(216, 25);
            this.MagazineAuthor.TabIndex = 0;
            this.MagazineAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.MagazineAuthor_Validating);
            // 
            // MagazineNumberValidation
            // 
            this.MagazineNumberValidation.AutoSize = true;
            this.MagazineNumberValidation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.MagazineNumberValidation.Location = new System.Drawing.Point(296, 370);
            this.MagazineNumberValidation.Name = "MagazineNumberValidation";
            this.MagazineNumberValidation.Size = new System.Drawing.Size(134, 17);
            this.MagazineNumberValidation.TabIndex = 27;
            this.MagazineNumberValidation.Text = "should be a number";
            this.MagazineNumberValidation.Visible = false;
            // 
            // bookPanel
            // 
            this.bookPanel.CausesValidation = false;
            this.bookPanel.Controls.Add(this.BookGenreValidation);
            this.bookPanel.Controls.Add(this.BookCancel);
            this.bookPanel.Controls.Add(this.BookPriceValidation);
            this.bookPanel.Controls.Add(this.BookPagesValidation);
            this.bookPanel.Controls.Add(this.BookYearValidation);
            this.bookPanel.Controls.Add(this.BookNameValidation);
            this.bookPanel.Controls.Add(this.BookAuthorValidation);
            this.bookPanel.Controls.Add(this.BookLabel);
            this.bookPanel.Controls.Add(this.BookAddButton);
            this.bookPanel.Controls.Add(this.BookGenreLabel);
            this.bookPanel.Controls.Add(this.BookPriceLabel);
            this.bookPanel.Controls.Add(this.BookYearLabel);
            this.bookPanel.Controls.Add(this.label7);
            this.bookPanel.Controls.Add(this.BookNameLabel);
            this.bookPanel.Controls.Add(this.BookAuthorLabel);
            this.bookPanel.Controls.Add(this.BookGenre);
            this.bookPanel.Controls.Add(this.BookPrice);
            this.bookPanel.Controls.Add(this.BookYear);
            this.bookPanel.Controls.Add(this.BookPages);
            this.bookPanel.Controls.Add(this.BookName);
            this.bookPanel.Controls.Add(this.BookAuthor);
            this.bookPanel.Location = new System.Drawing.Point(146, 15);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(566, 561);
            this.bookPanel.TabIndex = 18;
            // 
            // BookGenreValidation
            // 
            this.BookGenreValidation.AutoSize = true;
            this.BookGenreValidation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.BookGenreValidation.Location = new System.Drawing.Point(291, 341);
            this.BookGenreValidation.Name = "BookGenreValidation";
            this.BookGenreValidation.Size = new System.Drawing.Size(218, 17);
            this.BookGenreValidation.TabIndex = 24;
            this.BookGenreValidation.Text = "the length should be less than 15";
            this.BookGenreValidation.Visible = false;
            // 
            // BookCancel
            // 
            this.BookCancel.CausesValidation = false;
            this.BookCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookCancel.Location = new System.Drawing.Point(294, 500);
            this.BookCancel.Name = "BookCancel";
            this.BookCancel.Size = new System.Drawing.Size(147, 38);
            this.BookCancel.TabIndex = 15;
            this.BookCancel.Text = "Cancel";
            this.BookCancel.UseVisualStyleBackColor = true;
            this.BookCancel.Click += new System.EventHandler(this.BookCancel_Click);
            // 
            // BookPriceValidation
            // 
            this.BookPriceValidation.AutoSize = true;
            this.BookPriceValidation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.BookPriceValidation.Location = new System.Drawing.Point(295, 289);
            this.BookPriceValidation.Name = "BookPriceValidation";
            this.BookPriceValidation.Size = new System.Drawing.Size(193, 17);
            this.BookPriceValidation.TabIndex = 23;
            this.BookPriceValidation.Text = "the price should be a number";
            this.BookPriceValidation.Visible = false;
            // 
            // BookPagesValidation
            // 
            this.BookPagesValidation.AutoSize = true;
            this.BookPagesValidation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.BookPagesValidation.Location = new System.Drawing.Point(291, 189);
            this.BookPagesValidation.Name = "BookPagesValidation";
            this.BookPagesValidation.Size = new System.Drawing.Size(134, 17);
            this.BookPagesValidation.TabIndex = 22;
            this.BookPagesValidation.Text = "should be a number";
            this.BookPagesValidation.Visible = false;
            // 
            // BookYearValidation
            // 
            this.BookYearValidation.AutoSize = true;
            this.BookYearValidation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.BookYearValidation.Location = new System.Drawing.Point(291, 240);
            this.BookYearValidation.Name = "BookYearValidation";
            this.BookYearValidation.Size = new System.Drawing.Size(190, 17);
            this.BookYearValidation.TabIndex = 21;
            this.BookYearValidation.Text = "the year should be a number";
            this.BookYearValidation.Visible = false;
            // 
            // BookNameValidation
            // 
            this.BookNameValidation.AutoSize = true;
            this.BookNameValidation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.BookNameValidation.Location = new System.Drawing.Point(291, 138);
            this.BookNameValidation.Name = "BookNameValidation";
            this.BookNameValidation.Size = new System.Drawing.Size(218, 17);
            this.BookNameValidation.TabIndex = 20;
            this.BookNameValidation.Text = "the length should be less than 30";
            this.BookNameValidation.Visible = false;
            // 
            // BookAuthorValidation
            // 
            this.BookAuthorValidation.AutoSize = true;
            this.BookAuthorValidation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.BookAuthorValidation.Location = new System.Drawing.Point(291, 86);
            this.BookAuthorValidation.Name = "BookAuthorValidation";
            this.BookAuthorValidation.Size = new System.Drawing.Size(210, 17);
            this.BookAuthorValidation.TabIndex = 19;
            this.BookAuthorValidation.Text = "the lengt should be less than 25";
            this.BookAuthorValidation.Visible = false;
            // 
            // BookLabel
            // 
            this.BookLabel.AutoSize = true;
            this.BookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Bold);
            this.BookLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BookLabel.Location = new System.Drawing.Point(174, 29);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Size = new System.Drawing.Size(206, 31);
            this.BookLabel.TabIndex = 17;
            this.BookLabel.Text = "Add new book:";
            // 
            // BookAddButton
            // 
            this.BookAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookAddButton.Location = new System.Drawing.Point(118, 500);
            this.BookAddButton.Name = "BookAddButton";
            this.BookAddButton.Size = new System.Drawing.Size(147, 38);
            this.BookAddButton.TabIndex = 16;
            this.BookAddButton.Text = "Add";
            this.BookAddButton.UseVisualStyleBackColor = true;
            this.BookAddButton.Click += new System.EventHandler(this.BookAddButton_Click);
            // 
            // BookGenreLabel
            // 
            this.BookGenreLabel.AutoSize = true;
            this.BookGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.BookGenreLabel.ForeColor = System.Drawing.Color.Snow;
            this.BookGenreLabel.Location = new System.Drawing.Point(61, 358);
            this.BookGenreLabel.Name = "BookGenreLabel";
            this.BookGenreLabel.Size = new System.Drawing.Size(123, 26);
            this.BookGenreLabel.TabIndex = 13;
            this.BookGenreLabel.Text = "Book genre";
            // 
            // BookPriceLabel
            // 
            this.BookPriceLabel.AutoSize = true;
            this.BookPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.BookPriceLabel.ForeColor = System.Drawing.Color.Snow;
            this.BookPriceLabel.Location = new System.Drawing.Point(61, 306);
            this.BookPriceLabel.Name = "BookPriceLabel";
            this.BookPriceLabel.Size = new System.Drawing.Size(181, 26);
            this.BookPriceLabel.TabIndex = 12;
            this.BookPriceLabel.Text = "Price of the book:";
            // 
            // BookYearLabel
            // 
            this.BookYearLabel.AutoSize = true;
            this.BookYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.BookYearLabel.ForeColor = System.Drawing.Color.Snow;
            this.BookYearLabel.Location = new System.Drawing.Point(61, 257);
            this.BookYearLabel.Name = "BookYearLabel";
            this.BookYearLabel.Size = new System.Drawing.Size(193, 26);
            this.BookYearLabel.TabIndex = 11;
            this.BookYearLabel.Text = "Year of publishing:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(61, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Number of pages:";
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.BookNameLabel.ForeColor = System.Drawing.Color.Snow;
            this.BookNameLabel.Location = new System.Drawing.Point(61, 157);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(129, 26);
            this.BookNameLabel.TabIndex = 9;
            this.BookNameLabel.Text = "Book name:";
            // 
            // BookAuthorLabel
            // 
            this.BookAuthorLabel.AutoSize = true;
            this.BookAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.BookAuthorLabel.ForeColor = System.Drawing.Color.Snow;
            this.BookAuthorLabel.Location = new System.Drawing.Point(61, 110);
            this.BookAuthorLabel.Name = "BookAuthorLabel";
            this.BookAuthorLabel.Size = new System.Drawing.Size(143, 26);
            this.BookAuthorLabel.TabIndex = 8;
            this.BookAuthorLabel.Text = "Author name:";
            // 
            // BookGenre
            // 
            this.BookGenre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BookGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.BookGenre.Location = new System.Drawing.Point(294, 361);
            this.BookGenre.Name = "BookGenre";
            this.BookGenre.Size = new System.Drawing.Size(220, 25);
            this.BookGenre.TabIndex = 5;
            this.BookGenre.Validating += new System.ComponentModel.CancelEventHandler(this.BookGenre_Validating);
            // 
            // BookPrice
            // 
            this.BookPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BookPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.BookPrice.Location = new System.Drawing.Point(294, 309);
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.Size = new System.Drawing.Size(220, 25);
            this.BookPrice.TabIndex = 4;
            this.BookPrice.Validating += new System.ComponentModel.CancelEventHandler(this.BookPrice_Validating);
            // 
            // BookYear
            // 
            this.BookYear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BookYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.BookYear.Location = new System.Drawing.Point(294, 260);
            this.BookYear.Name = "BookYear";
            this.BookYear.Size = new System.Drawing.Size(220, 25);
            this.BookYear.TabIndex = 3;
            this.BookYear.Validating += new System.ComponentModel.CancelEventHandler(this.BookYear_Validating);
            // 
            // BookPages
            // 
            this.BookPages.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BookPages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.BookPages.Location = new System.Drawing.Point(294, 209);
            this.BookPages.Name = "BookPages";
            this.BookPages.Size = new System.Drawing.Size(220, 25);
            this.BookPages.TabIndex = 2;
            this.BookPages.Validating += new System.ComponentModel.CancelEventHandler(this.BookPages_Validating);
            // 
            // BookName
            // 
            this.BookName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.BookName.Location = new System.Drawing.Point(294, 160);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(220, 25);
            this.BookName.TabIndex = 1;
            this.BookName.Validating += new System.ComponentModel.CancelEventHandler(this.BookName_Validating);
            // 
            // BookAuthor
            // 
            this.BookAuthor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BookAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.BookAuthor.Location = new System.Drawing.Point(294, 110);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(220, 25);
            this.BookAuthor.TabIndex = 0;
            this.BookAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.BookAuthor_Validating);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(34)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(856, 663);
            this.Controls.Add(this.bookPanel);
            this.Controls.Add(this.magazinePanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(874, 710);
            this.MinimumSize = new System.Drawing.Size(874, 710);
            this.Name = "Insert";
            this.Text = "Insert";
            this.magazinePanel.ResumeLayout(false);
            this.magazinePanel.PerformLayout();
            this.bookPanel.ResumeLayout(false);
            this.bookPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel magazinePanel;
        private System.Windows.Forms.TextBox MagazineNumber;
        private System.Windows.Forms.TextBox MagazineFrequency;
        private System.Windows.Forms.TextBox MagazinePrice;
        private System.Windows.Forms.TextBox MagazineYear;
        private System.Windows.Forms.TextBox MagazinePages;
        private System.Windows.Forms.TextBox MagazineName;
        private System.Windows.Forms.TextBox MagazineAuthor;
        private System.Windows.Forms.Label MagazineNumberLabel;
        private System.Windows.Forms.Label MagazineFrequancyLabel;
        private System.Windows.Forms.Label MagazinePriceLabel;
        private System.Windows.Forms.Label MagazineYearLabel;
        private System.Windows.Forms.Label MagazinePagesLabel;
        private System.Windows.Forms.Label MagazineNameLabel;
        private System.Windows.Forms.Label MagazineAuthorLabel;
        private System.Windows.Forms.Button MagazineAddButton;
        private System.Windows.Forms.Button MagazineCancel;
        private System.Windows.Forms.Panel bookPanel;
        private System.Windows.Forms.Label BookLabel;
        private System.Windows.Forms.Button BookAddButton;
        private System.Windows.Forms.Button BookCancel;
        private System.Windows.Forms.Label BookGenreLabel;
        private System.Windows.Forms.Label BookPriceLabel;
        private System.Windows.Forms.Label BookYearLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Label BookAuthorLabel;
        private System.Windows.Forms.TextBox BookGenre;
        private System.Windows.Forms.TextBox BookPrice;
        private System.Windows.Forms.TextBox BookYear;
        private System.Windows.Forms.TextBox BookPages;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox BookAuthor;
        private System.Windows.Forms.Label label1;
        private Label BookNameValidation;
        private Label BookAuthorValidation;
        private Label BookGenreValidation;
        private Label BookPriceValidation;
        private Label BookPagesValidation;
        private Label BookYearValidation;
        private Label MagazineFrequencyValidation;
        private Label MagazinePriceValidation;
        private Label MagazineYearValidation;
        private Label MagazinePagesValidation;
        private Label MagazineNameValidation;
        private Label MagazineAuthorValidation;
        private Label MagazineNumberValidation;
    }
}
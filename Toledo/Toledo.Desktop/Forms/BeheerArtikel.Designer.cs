namespace Toledo.Desktop.Forms
{
    partial class BeheerArtikel
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
            this.opslaanBtn = new MetroFramework.Controls.MetroButton();
            this.standaardPrijsInclBtw = new MetroFramework.Controls.MetroTextBox();
            this.btw6 = new MetroFramework.Controls.MetroRadioButton();
            this.btw21 = new MetroFramework.Controls.MetroRadioButton();
            this.btw0 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.standaardPrijsExclBtw = new MetroFramework.Controls.MetroTextBox();
            this.kortingsPrijsExclBtw = new MetroFramework.Controls.MetroTextBox();
            this.kortingsPrijsInclBtw = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.categorie = new System.Windows.Forms.ComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.leverbaar = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.omschrijving = new MetroFramework.Controls.MetroTextBox();
            this.artikelCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.annuleren = new MetroFramework.Controls.MetroButton();
            this.verwijderen = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // opslaanBtn
            // 
            this.opslaanBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.opslaanBtn.Highlight = false;
            this.opslaanBtn.Location = new System.Drawing.Point(727, 3);
            this.opslaanBtn.Name = "opslaanBtn";
            this.opslaanBtn.Size = new System.Drawing.Size(126, 33);
            this.opslaanBtn.Style = MetroFramework.MetroColorStyle.Magenta;
            this.opslaanBtn.StyleManager = null;
            this.opslaanBtn.TabIndex = 4;
            this.opslaanBtn.Text = "Opslaan";
            this.opslaanBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.opslaanBtn.Click += new System.EventHandler(this.opslaanBtn_Click);
            // 
            // standaardPrijsInclBtw
            // 
            this.standaardPrijsInclBtw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.standaardPrijsInclBtw.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.standaardPrijsInclBtw.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.standaardPrijsInclBtw.Location = new System.Drawing.Point(418, 300);
            this.standaardPrijsInclBtw.Multiline = false;
            this.standaardPrijsInclBtw.Name = "standaardPrijsInclBtw";
            this.standaardPrijsInclBtw.SelectedText = "";
            this.standaardPrijsInclBtw.Size = new System.Drawing.Size(293, 25);
            this.standaardPrijsInclBtw.Style = MetroFramework.MetroColorStyle.Magenta;
            this.standaardPrijsInclBtw.StyleManager = null;
            this.standaardPrijsInclBtw.TabIndex = 4;
            this.standaardPrijsInclBtw.Theme = MetroFramework.MetroThemeStyle.Light;
            this.standaardPrijsInclBtw.UseStyleColors = false;
            this.standaardPrijsInclBtw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.standaardPrijsInclBtw_KeyUp);
            // 
            // btw6
            // 
            this.btw6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btw6.AutoSize = true;
            this.btw6.CustomBackground = false;
            this.btw6.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btw6.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.btw6.Location = new System.Drawing.Point(418, 168);
            this.btw6.Name = "btw6";
            this.btw6.Size = new System.Drawing.Size(51, 24);
            this.btw6.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btw6.StyleManager = null;
            this.btw6.TabIndex = 11;
            this.btw6.Text = "6%";
            this.btw6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btw6.UseStyleColors = false;
            this.btw6.UseVisualStyleBackColor = true;
            // 
            // btw21
            // 
            this.btw21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btw21.AutoSize = true;
            this.btw21.Checked = true;
            this.btw21.CustomBackground = false;
            this.btw21.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btw21.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.btw21.Location = new System.Drawing.Point(418, 138);
            this.btw21.Name = "btw21";
            this.btw21.Size = new System.Drawing.Size(57, 24);
            this.btw21.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btw21.StyleManager = null;
            this.btw21.TabIndex = 2;
            this.btw21.TabStop = true;
            this.btw21.Text = "21%";
            this.btw21.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btw21.UseStyleColors = false;
            this.btw21.UseVisualStyleBackColor = true;
            // 
            // btw0
            // 
            this.btw0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btw0.AutoSize = true;
            this.btw0.CustomBackground = false;
            this.btw0.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.btw0.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.btw0.Location = new System.Drawing.Point(418, 198);
            this.btw0.Name = "btw0";
            this.btw0.Size = new System.Drawing.Size(51, 24);
            this.btw0.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btw0.StyleManager = null;
            this.btw0.TabIndex = 11;
            this.btw0.Text = "0%";
            this.btw0.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btw0.UseStyleColors = false;
            this.btw0.UseVisualStyleBackColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.CustomBackground = false;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel9.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel9.Location = new System.Drawing.Point(321, 137);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(91, 25);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel9.StyleManager = null;
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "BTW tarief";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel9.UseStyleColors = false;
            // 
            // standaardPrijsExclBtw
            // 
            this.standaardPrijsExclBtw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.standaardPrijsExclBtw.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.standaardPrijsExclBtw.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.standaardPrijsExclBtw.Location = new System.Drawing.Point(418, 265);
            this.standaardPrijsExclBtw.Multiline = false;
            this.standaardPrijsExclBtw.Name = "standaardPrijsExclBtw";
            this.standaardPrijsExclBtw.SelectedText = "";
            this.standaardPrijsExclBtw.Size = new System.Drawing.Size(293, 25);
            this.standaardPrijsExclBtw.Style = MetroFramework.MetroColorStyle.Magenta;
            this.standaardPrijsExclBtw.StyleManager = null;
            this.standaardPrijsExclBtw.TabIndex = 3;
            this.standaardPrijsExclBtw.Theme = MetroFramework.MetroThemeStyle.Light;
            this.standaardPrijsExclBtw.UseStyleColors = false;
            this.standaardPrijsExclBtw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.standaardPrijsExclBtw_KeyUp);
            // 
            // kortingsPrijsExclBtw
            // 
            this.kortingsPrijsExclBtw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kortingsPrijsExclBtw.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.kortingsPrijsExclBtw.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.kortingsPrijsExclBtw.Location = new System.Drawing.Point(418, 370);
            this.kortingsPrijsExclBtw.Multiline = false;
            this.kortingsPrijsExclBtw.Name = "kortingsPrijsExclBtw";
            this.kortingsPrijsExclBtw.SelectedText = "";
            this.kortingsPrijsExclBtw.Size = new System.Drawing.Size(293, 25);
            this.kortingsPrijsExclBtw.Style = MetroFramework.MetroColorStyle.Magenta;
            this.kortingsPrijsExclBtw.StyleManager = null;
            this.kortingsPrijsExclBtw.TabIndex = 5;
            this.kortingsPrijsExclBtw.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kortingsPrijsExclBtw.UseStyleColors = false;
            this.kortingsPrijsExclBtw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kortingsPrijsExclBtw_KeyUp);
            // 
            // kortingsPrijsInclBtw
            // 
            this.kortingsPrijsInclBtw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kortingsPrijsInclBtw.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.kortingsPrijsInclBtw.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.kortingsPrijsInclBtw.Location = new System.Drawing.Point(418, 405);
            this.kortingsPrijsInclBtw.Multiline = false;
            this.kortingsPrijsInclBtw.Name = "kortingsPrijsInclBtw";
            this.kortingsPrijsInclBtw.SelectedText = "";
            this.kortingsPrijsInclBtw.Size = new System.Drawing.Size(293, 25);
            this.kortingsPrijsInclBtw.Style = MetroFramework.MetroColorStyle.Magenta;
            this.kortingsPrijsInclBtw.StyleManager = null;
            this.kortingsPrijsInclBtw.TabIndex = 6;
            this.kortingsPrijsInclBtw.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kortingsPrijsInclBtw.UseStyleColors = false;
            this.kortingsPrijsInclBtw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kortingsPrijsInclBtw_KeyUp);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(208, 265);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(204, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Standaard prijs excl. BTW";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(211, 300);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(201, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Standaard prijs incl. BTW";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = false;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel5.Location = new System.Drawing.Point(228, 370);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(184, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel5.StyleManager = null;
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Kortingsprijs excl. BTW";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseStyleColors = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = false;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel6.Location = new System.Drawing.Point(231, 405);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(181, 25);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel6.StyleManager = null;
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "Kortingsprijs incl. BTW";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = false;
            // 
            // categorie
            // 
            this.categorie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categorie.BackColor = System.Drawing.SystemColors.Control;
            this.categorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorie.FormattingEnabled = true;
            this.categorie.Location = new System.Drawing.Point(418, 475);
            this.categorie.Name = "categorie";
            this.categorie.Size = new System.Drawing.Size(293, 24);
            this.categorie.TabIndex = 7;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = false;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel7.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel7.Location = new System.Drawing.Point(327, 475);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(85, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel7.StyleManager = null;
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "Categorie";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel7.UseStyleColors = false;
            // 
            // leverbaar
            // 
            this.leverbaar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leverbaar.AutoSize = true;
            this.leverbaar.Checked = true;
            this.leverbaar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leverbaar.CustomBackground = false;
            this.leverbaar.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.leverbaar.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.leverbaar.Location = new System.Drawing.Point(418, 510);
            this.leverbaar.Name = "leverbaar";
            this.leverbaar.Size = new System.Drawing.Size(33, 25);
            this.leverbaar.Style = MetroFramework.MetroColorStyle.Magenta;
            this.leverbaar.StyleManager = null;
            this.leverbaar.TabIndex = 9;
            this.leverbaar.Tag = "";
            this.leverbaar.Text = " ";
            this.leverbaar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.leverbaar.UseStyleColors = false;
            this.leverbaar.UseVisualStyleBackColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel8.CustomBackground = false;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel8.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel8.Location = new System.Drawing.Point(326, 510);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(86, 25);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel8.StyleManager = null;
            this.metroLabel8.TabIndex = 6;
            this.metroLabel8.Text = "Leverbaar";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel8.UseStyleColors = false;
            // 
            // omschrijving
            // 
            this.omschrijving.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.omschrijving.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.omschrijving.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.omschrijving.Location = new System.Drawing.Point(418, 70);
            this.omschrijving.Multiline = false;
            this.omschrijving.Name = "omschrijving";
            this.omschrijving.SelectedText = "";
            this.omschrijving.Size = new System.Drawing.Size(293, 25);
            this.omschrijving.Style = MetroFramework.MetroColorStyle.Magenta;
            this.omschrijving.StyleManager = null;
            this.omschrijving.TabIndex = 1;
            this.omschrijving.Theme = MetroFramework.MetroThemeStyle.Light;
            this.omschrijving.UseStyleColors = false;
            // 
            // artikelCode
            // 
            this.artikelCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.artikelCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.artikelCode.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.artikelCode.Location = new System.Drawing.Point(418, 35);
            this.artikelCode.Multiline = false;
            this.artikelCode.Name = "artikelCode";
            this.artikelCode.SelectedText = "";
            this.artikelCode.Size = new System.Drawing.Size(293, 25);
            this.artikelCode.Style = MetroFramework.MetroColorStyle.Magenta;
            this.artikelCode.StyleManager = null;
            this.artikelCode.TabIndex = 5;
            this.artikelCode.TabStop = false;
            this.artikelCode.Theme = MetroFramework.MetroThemeStyle.Light;
            this.artikelCode.UseStyleColors = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(315, 35);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Artikelcode";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(300, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Omschrijving";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.51598F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.48402F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.artikelCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.omschrijving, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel8, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.leverbaar, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel7, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.categorie, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel6, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel5, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.kortingsPrijsInclBtw, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.kortingsPrijsExclBtw, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.standaardPrijsExclBtw, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btw0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btw21, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btw6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.standaardPrijsInclBtw, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 555);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.opslaanBtn);
            this.flowLayoutPanel1.Controls.Add(this.annuleren);
            this.flowLayoutPanel1.Controls.Add(this.verwijderen);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 615);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(856, 37);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // annuleren
            // 
            this.annuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuleren.Highlight = false;
            this.annuleren.Location = new System.Drawing.Point(595, 3);
            this.annuleren.Name = "annuleren";
            this.annuleren.Size = new System.Drawing.Size(126, 33);
            this.annuleren.Style = MetroFramework.MetroColorStyle.Magenta;
            this.annuleren.StyleManager = null;
            this.annuleren.TabIndex = 4;
            this.annuleren.Text = "Annuleren";
            this.annuleren.Theme = MetroFramework.MetroThemeStyle.Light;
            this.annuleren.Click += new System.EventHandler(this.opslaanBtn_Click);
            // 
            // verwijderen
            // 
            this.verwijderen.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.verwijderen.Highlight = false;
            this.verwijderen.Location = new System.Drawing.Point(463, 3);
            this.verwijderen.Name = "verwijderen";
            this.verwijderen.Size = new System.Drawing.Size(126, 33);
            this.verwijderen.Style = MetroFramework.MetroColorStyle.Magenta;
            this.verwijderen.StyleManager = null;
            this.verwijderen.TabIndex = 4;
            this.verwijderen.Text = "Verwijderen";
            this.verwijderen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.verwijderen.Click += new System.EventHandler(this.opslaanBtn_Click);
            // 
            // BeheerArtikel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 672);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "BeheerArtikel";
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Beheer artikel";
            this.Load += new System.EventHandler(this.BeheerArtikel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton opslaanBtn;
        private MetroFramework.Controls.MetroTextBox standaardPrijsInclBtw;
        private MetroFramework.Controls.MetroRadioButton btw6;
        private MetroFramework.Controls.MetroRadioButton btw21;
        private MetroFramework.Controls.MetroRadioButton btw0;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox standaardPrijsExclBtw;
        private MetroFramework.Controls.MetroTextBox kortingsPrijsExclBtw;
        private MetroFramework.Controls.MetroTextBox kortingsPrijsInclBtw;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ComboBox categorie;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroCheckBox leverbaar;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox omschrijving;
        private MetroFramework.Controls.MetroTextBox artikelCode;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton annuleren;
        private MetroFramework.Controls.MetroButton verwijderen;
    }
}
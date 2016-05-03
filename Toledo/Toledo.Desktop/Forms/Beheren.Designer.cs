namespace Toledo.Desktop.Forms
{
    partial class Beheren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beheren));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.artikelenBewerken = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alleArtikelenTabPage = new MetroFramework.Controls.MetroTabPage();
            this.artikelenLijst = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Omschrijving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtwTarief = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.artikelenBewerken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.alleArtikelenTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artikelenLijst)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.artikelenBewerken);
            this.metroTabControl1.Controls.Add(this.alleArtikelenTabPage);
            this.metroTabControl1.CustomBackground = false;
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1067, 658);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTabControl1.StyleManager = null;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseStyleColors = false;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // artikelenBewerken
            // 
            this.artikelenBewerken.Controls.Add(this.pictureBox1);
            this.artikelenBewerken.CustomBackground = false;
            this.artikelenBewerken.HorizontalScrollbar = false;
            this.artikelenBewerken.HorizontalScrollbarBarColor = true;
            this.artikelenBewerken.HorizontalScrollbarHighlightOnWheel = false;
            this.artikelenBewerken.HorizontalScrollbarSize = 10;
            this.artikelenBewerken.Location = new System.Drawing.Point(4, 35);
            this.artikelenBewerken.Name = "artikelenBewerken";
            this.artikelenBewerken.Size = new System.Drawing.Size(1059, 619);
            this.artikelenBewerken.Style = MetroFramework.MetroColorStyle.Magenta;
            this.artikelenBewerken.StyleManager = null;
            this.artikelenBewerken.TabIndex = 2;
            this.artikelenBewerken.Text = "Artikel bewerken";
            this.artikelenBewerken.Theme = MetroFramework.MetroThemeStyle.Light;
            this.artikelenBewerken.VerticalScrollbar = false;
            this.artikelenBewerken.VerticalScrollbarBarColor = true;
            this.artikelenBewerken.VerticalScrollbarHighlightOnWheel = false;
            this.artikelenBewerken.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Toledo.Desktop.Properties.Resources.barcode_scan;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1059, 619);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // alleArtikelenTabPage
            // 
            this.alleArtikelenTabPage.Controls.Add(this.artikelenLijst);
            this.alleArtikelenTabPage.CustomBackground = false;
            this.alleArtikelenTabPage.HorizontalScrollbar = false;
            this.alleArtikelenTabPage.HorizontalScrollbarBarColor = true;
            this.alleArtikelenTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.alleArtikelenTabPage.HorizontalScrollbarSize = 10;
            this.alleArtikelenTabPage.Location = new System.Drawing.Point(4, 35);
            this.alleArtikelenTabPage.Name = "alleArtikelenTabPage";
            this.alleArtikelenTabPage.Size = new System.Drawing.Size(1059, 619);
            this.alleArtikelenTabPage.Style = MetroFramework.MetroColorStyle.Magenta;
            this.alleArtikelenTabPage.StyleManager = null;
            this.alleArtikelenTabPage.TabIndex = 1;
            this.alleArtikelenTabPage.Text = "Overzicht alle artikelen";
            this.alleArtikelenTabPage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.alleArtikelenTabPage.VerticalScrollbar = false;
            this.alleArtikelenTabPage.VerticalScrollbarBarColor = true;
            this.alleArtikelenTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.alleArtikelenTabPage.VerticalScrollbarSize = 10;
            // 
            // artikelenLijst
            // 
            this.artikelenLijst.AllowUserToAddRows = false;
            this.artikelenLijst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.artikelenLijst.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.artikelenLijst.BackgroundColor = System.Drawing.Color.White;
            this.artikelenLijst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artikelenLijst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.Omschrijving,
            this.BtwTarief,
            this.prijs,
            this.Categorie});
            this.artikelenLijst.Dock = System.Windows.Forms.DockStyle.Left;
            this.artikelenLijst.Location = new System.Drawing.Point(0, 0);
            this.artikelenLijst.Name = "artikelenLijst";
            this.artikelenLijst.RowHeadersWidth = 25;
            this.artikelenLijst.Size = new System.Drawing.Size(1059, 619);
            this.artikelenLijst.TabIndex = 2;
            this.artikelenLijst.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.artikelenLijst_CellContentDoubleClick);
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Barcode.DataPropertyName = "barcode";
            this.Barcode.Frozen = true;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.MinimumWidth = 100;
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // Omschrijving
            // 
            this.Omschrijving.DataPropertyName = "omschrijving";
            this.Omschrijving.FillWeight = 5F;
            this.Omschrijving.HeaderText = "Omschrijving";
            this.Omschrijving.Name = "Omschrijving";
            this.Omschrijving.ReadOnly = true;
            // 
            // BtwTarief
            // 
            this.BtwTarief.DataPropertyName = "btw";
            this.BtwTarief.FillWeight = 2F;
            this.BtwTarief.HeaderText = "Btw tarief";
            this.BtwTarief.Name = "BtwTarief";
            this.BtwTarief.ReadOnly = true;
            // 
            // prijs
            // 
            this.prijs.DataPropertyName = "prijs";
            this.prijs.FillWeight = 1F;
            this.prijs.HeaderText = "Prijs";
            this.prijs.Name = "prijs";
            // 
            // Categorie
            // 
            this.Categorie.DataPropertyName = "categorie";
            this.Categorie.FillWeight = 2F;
            this.Categorie.HeaderText = "Categorie";
            this.Categorie.Name = "Categorie";
            // 
            // Beheren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 738);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Beheren";
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Beheren";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Beheren_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.artikelenBewerken.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.alleArtikelenTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.artikelenLijst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage alleArtikelenTabPage;
        private MetroFramework.Controls.MetroTabPage artikelenBewerken;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView artikelenLijst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Omschrijving;
        private System.Windows.Forms.DataGridViewTextBoxColumn BtwTarief;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
    }
}
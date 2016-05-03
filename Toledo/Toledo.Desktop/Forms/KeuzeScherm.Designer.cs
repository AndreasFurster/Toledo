namespace Toledo.Desktop.Forms
{
    partial class KeuzeScherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeuzeScherm));
            this.artikelenBeherenBtn = new MetroFramework.Controls.MetroTile();
            this.verkopenBtn = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.dbFilename = new System.Windows.Forms.TextBox();
            this.bestandInladenBtn = new MetroFramework.Controls.MetroButton();
            this.openDatabaseFile = new System.Windows.Forms.OpenFileDialog();
            this.settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // artikelenBeherenBtn
            // 
            this.artikelenBeherenBtn.ActiveControl = null;
            this.artikelenBeherenBtn.Location = new System.Drawing.Point(23, 104);
            this.artikelenBeherenBtn.Name = "artikelenBeherenBtn";
            this.artikelenBeherenBtn.Size = new System.Drawing.Size(263, 200);
            this.artikelenBeherenBtn.Style = MetroFramework.MetroColorStyle.Magenta;
            this.artikelenBeherenBtn.StyleManager = null;
            this.artikelenBeherenBtn.TabIndex = 0;
            this.artikelenBeherenBtn.Text = "Beheren";
            this.artikelenBeherenBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.artikelenBeherenBtn.TileCount = 0;
            this.artikelenBeherenBtn.Click += new System.EventHandler(this.artikelenBeherenBtn_Click);
            // 
            // verkopenBtn
            // 
            this.verkopenBtn.ActiveControl = null;
            this.verkopenBtn.Location = new System.Drawing.Point(292, 104);
            this.verkopenBtn.Name = "verkopenBtn";
            this.verkopenBtn.Size = new System.Drawing.Size(260, 200);
            this.verkopenBtn.Style = MetroFramework.MetroColorStyle.Magenta;
            this.verkopenBtn.StyleManager = null;
            this.verkopenBtn.TabIndex = 1;
            this.verkopenBtn.Text = "Verkopen";
            this.verkopenBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.verkopenBtn.TileCount = 0;
            this.verkopenBtn.Click += new System.EventHandler(this.verkopenBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "© Zycon en Varbit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbFilename
            // 
            this.dbFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbFilename.Location = new System.Drawing.Point(24, 64);
            this.dbFilename.Name = "dbFilename";
            this.dbFilename.ReadOnly = true;
            this.dbFilename.Size = new System.Drawing.Size(262, 22);
            this.dbFilename.TabIndex = 3;
            // 
            // bestandInladenBtn
            // 
            this.bestandInladenBtn.Highlight = false;
            this.bestandInladenBtn.Location = new System.Drawing.Point(292, 64);
            this.bestandInladenBtn.Name = "bestandInladenBtn";
            this.bestandInladenBtn.Size = new System.Drawing.Size(127, 23);
            this.bestandInladenBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.bestandInladenBtn.StyleManager = null;
            this.bestandInladenBtn.TabIndex = 4;
            this.bestandInladenBtn.Text = "Bestand inladen";
            this.bestandInladenBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bestandInladenBtn.Click += new System.EventHandler(this.bestandInladenBtn_Click);
            // 
            // openDatabaseFile
            // 
            this.openDatabaseFile.Filter = "Database|*.mdf";
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(426, 64);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(126, 23);
            this.settings.TabIndex = 6;
            this.settings.Text = "Instellingen";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // KeuzeScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 356);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.bestandInladenBtn);
            this.Controls.Add(this.dbFilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.artikelenBeherenBtn);
            this.Controls.Add(this.verkopenBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "KeuzeScherm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Wat gaan we doen?";
            this.Load += new System.EventHandler(this.KeuzeScherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile verkopenBtn;
        private MetroFramework.Controls.MetroTile artikelenBeherenBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dbFilename;
        private MetroFramework.Controls.MetroButton bestandInladenBtn;
        private System.Windows.Forms.OpenFileDialog openDatabaseFile;
        private System.Windows.Forms.Button settings;
    }
}
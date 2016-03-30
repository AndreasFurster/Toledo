namespace Toledo.Desktop
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
            this.SuspendLayout();
            // 
            // artikelenBeherenBtn
            // 
            this.artikelenBeherenBtn.ActiveControl = null;
            this.artikelenBeherenBtn.Location = new System.Drawing.Point(23, 63);
            this.artikelenBeherenBtn.Name = "artikelenBeherenBtn";
            this.artikelenBeherenBtn.Size = new System.Drawing.Size(200, 200);
            this.artikelenBeherenBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.artikelenBeherenBtn.StyleManager = null;
            this.artikelenBeherenBtn.TabIndex = 0;
            this.artikelenBeherenBtn.Text = "Artikelen beheren";
            this.artikelenBeherenBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.artikelenBeherenBtn.TileCount = 0;
            this.artikelenBeherenBtn.Click += new System.EventHandler(this.artikelenBeherenBtn_Click);
            // 
            // verkopenBtn
            // 
            this.verkopenBtn.ActiveControl = null;
            this.verkopenBtn.Location = new System.Drawing.Point(243, 63);
            this.verkopenBtn.Name = "verkopenBtn";
            this.verkopenBtn.Size = new System.Drawing.Size(200, 200);
            this.verkopenBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.verkopenBtn.StyleManager = null;
            this.verkopenBtn.TabIndex = 1;
            this.verkopenBtn.Text = "Verkopen";
            this.verkopenBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.verkopenBtn.TileCount = 0;
            this.verkopenBtn.Click += new System.EventHandler(this.verkopenBtn_Click);
            // 
            // KeuzeScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 281);
            this.Controls.Add(this.artikelenBeherenBtn);
            this.Controls.Add(this.verkopenBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "KeuzeScherm";
            this.Resizable = false;
            this.Text = "Wat gaan we doen?";
            this.Load += new System.EventHandler(this.KeuzeScherm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile verkopenBtn;
        private MetroFramework.Controls.MetroTile artikelenBeherenBtn;
    }
}
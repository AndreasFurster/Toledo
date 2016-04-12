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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(KeuzeScherm));
            this.artikelenBeherenBtn = new MetroFramework.Controls.MetroTile();
            this.verkopenBtn = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
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
            this.artikelenBeherenBtn.Text = "Beheren";
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "© Zycon en Varbit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeuzeScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 314);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile verkopenBtn;
        private MetroFramework.Controls.MetroTile artikelenBeherenBtn;
        private System.Windows.Forms.Label label1;
    }
}
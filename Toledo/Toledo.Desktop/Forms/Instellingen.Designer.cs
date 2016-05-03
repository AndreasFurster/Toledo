namespace Toledo.Desktop.Forms
{
    partial class Instellingen
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
            this.newDatabase = new MetroFramework.Controls.MetroButton();
            this.saveNewDatabase = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // newDatabase
            // 
            this.newDatabase.Highlight = false;
            this.newDatabase.Location = new System.Drawing.Point(23, 63);
            this.newDatabase.Name = "newDatabase";
            this.newDatabase.Size = new System.Drawing.Size(289, 36);
            this.newDatabase.Style = MetroFramework.MetroColorStyle.Blue;
            this.newDatabase.StyleManager = null;
            this.newDatabase.TabIndex = 7;
            this.newDatabase.Text = "Nieuw verkoop administratie bestand";
            this.newDatabase.Theme = MetroFramework.MetroThemeStyle.Light;
            this.newDatabase.Click += new System.EventHandler(this.newDatabase_Click);
            // 
            // saveNewDatabase
            // 
            this.saveNewDatabase.FileName = "Verkoop administratie";
            this.saveNewDatabase.Filter = "Database|*.mdf";
            // 
            // Instellingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 575);
            this.Controls.Add(this.newDatabase);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Instellingen";
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Instellingen";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton newDatabase;
        private System.Windows.Forms.SaveFileDialog saveNewDatabase;
    }
}
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
            this.prijsInclBtw = new MetroFramework.Controls.MetroTextBox();
            this.btw6 = new MetroFramework.Controls.MetroRadioButton();
            this.btw21 = new MetroFramework.Controls.MetroRadioButton();
            this.btw0 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.prijsExclBtw = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.categorie = new System.Windows.Forms.ComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
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
            // prijsInclBtw
            // 
            this.prijsInclBtw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prijsInclBtw.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.prijsInclBtw.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.prijsInclBtw.Location = new System.Drawing.Point(418, 300);
            this.prijsInclBtw.Multiline = false;
            this.prijsInclBtw.Name = "prijsInclBtw";
            this.prijsInclBtw.SelectedText = "";
            this.prijsInclBtw.Size = new System.Drawing.Size(293, 25);
            this.prijsInclBtw.Style = MetroFramework.MetroColorStyle.Magenta;
            this.prijsInclBtw.StyleManager = null;
            this.prijsInclBtw.TabIndex = 4;
            this.prijsInclBtw.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prijsInclBtw.UseStyleColors = false;
            this.prijsInclBtw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.prijsInclBtw_KeyUp);
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
            // prijsExclBtw
            // 
            this.prijsExclBtw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prijsExclBtw.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.prijsExclBtw.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.prijsExclBtw.Location = new System.Drawing.Point(418, 265);
            this.prijsExclBtw.Multiline = false;
            this.prijsExclBtw.Name = "prijsExclBtw";
            this.prijsExclBtw.SelectedText = "";
            this.prijsExclBtw.Size = new System.Drawing.Size(293, 25);
            this.prijsExclBtw.Style = MetroFramework.MetroColorStyle.Magenta;
            this.prijsExclBtw.StyleManager = null;
            this.prijsExclBtw.TabIndex = 3;
            this.prijsExclBtw.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prijsExclBtw.UseStyleColors = false;
            this.prijsExclBtw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.prijsExclBtw_KeyUp);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(290, 265);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(122, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Prijs excl. BTW";
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
            this.metroLabel2.Location = new System.Drawing.Point(293, 300);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(119, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Prijs incl. BTW";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // categorie
            // 
            this.categorie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categorie.BackColor = System.Drawing.SystemColors.Control;
            this.categorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorie.FormattingEnabled = true;
            this.categorie.Location = new System.Drawing.Point(418, 370);
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
            this.metroLabel7.Location = new System.Drawing.Point(327, 370);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(85, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel7.StyleManager = null;
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "Categorie";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel7.UseStyleColors = false;
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
            this.tableLayoutPanel1.Controls.Add(this.metroLabel7, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.categorie, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.prijsExclBtw, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btw0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btw21, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btw6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.prijsInclBtw, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.tableLayoutPanel1.RowCount = 13;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
        private MetroFramework.Controls.MetroTextBox prijsInclBtw;
        private MetroFramework.Controls.MetroRadioButton btw6;
        private MetroFramework.Controls.MetroRadioButton btw21;
        private MetroFramework.Controls.MetroRadioButton btw0;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox prijsExclBtw;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox categorie;
        private MetroFramework.Controls.MetroLabel metroLabel7;
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
namespace Toledo.Desktop.Forms
{
    partial class Verkopen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verkopen));
            this.verkopenGrid = new System.Windows.Forms.DataGridView();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aantal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beschrijving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijsPerStuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijsTotaal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.verkoopNr = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btwHoog = new System.Windows.Forms.Label();
            this.btwLaag = new System.Windows.Forms.Label();
            this.btwVrij = new System.Windows.Forms.Label();
            this.totaalExclBtw = new System.Windows.Forms.Label();
            this.totaalInclBtw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.verkopenGrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // verkopenGrid
            // 
            this.verkopenGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.verkopenGrid.BackgroundColor = System.Drawing.Color.White;
            this.verkopenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verkopenGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.aantal,
            this.beschrijving,
            this.prijsPerStuk,
            this.prijsTotaal});
            this.verkopenGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verkopenGrid.Location = new System.Drawing.Point(20, 60);
            this.verkopenGrid.Name = "verkopenGrid";
            this.verkopenGrid.ReadOnly = true;
            this.verkopenGrid.Size = new System.Drawing.Size(1110, 725);
            this.verkopenGrid.TabIndex = 0;
            // 
            // barcode
            // 
            this.barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.barcode.DataPropertyName = "barcode";
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Visible = false;
            // 
            // aantal
            // 
            this.aantal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aantal.DataPropertyName = "aantal";
            this.aantal.FillWeight = 50F;
            this.aantal.HeaderText = "Aantal";
            this.aantal.Name = "aantal";
            this.aantal.ReadOnly = true;
            // 
            // beschrijving
            // 
            this.beschrijving.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.beschrijving.DataPropertyName = "beschrijving";
            this.beschrijving.FillWeight = 400F;
            this.beschrijving.HeaderText = "Beschrijving";
            this.beschrijving.Name = "beschrijving";
            this.beschrijving.ReadOnly = true;
            // 
            // prijsPerStuk
            // 
            this.prijsPerStuk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prijsPerStuk.DataPropertyName = "prijsPerStuk";
            this.prijsPerStuk.HeaderText = "Prijs per stuk";
            this.prijsPerStuk.Name = "prijsPerStuk";
            this.prijsPerStuk.ReadOnly = true;
            // 
            // prijsTotaal
            // 
            this.prijsTotaal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prijsTotaal.DataPropertyName = "prijsTotaal";
            this.prijsTotaal.FillWeight = 150F;
            this.prijsTotaal.HeaderText = "Prijs totaal";
            this.prijsTotaal.Name = "prijsTotaal";
            this.prijsTotaal.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.metroButton2);
            this.flowLayoutPanel1.Controls.Add(this.metroButton5);
            this.flowLayoutPanel1.Controls.Add(this.metroButton3);
            this.flowLayoutPanel1.Controls.Add(this.metroButton1);
            this.flowLayoutPanel1.Controls.Add(this.metroButton4);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.verkoopNr);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 753);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1110, 32);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = false;
            this.metroButton2.Location = new System.Drawing.Point(954, 3);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(153, 26);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 0;
            this.metroButton2.Text = "Nieuwe verkoop";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton5
            // 
            this.metroButton5.Highlight = false;
            this.metroButton5.Location = new System.Drawing.Point(795, 3);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(153, 26);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButton5.StyleManager = null;
            this.metroButton5.TabIndex = 0;
            this.metroButton5.Text = "Annuleer verkoop";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = false;
            this.metroButton3.Location = new System.Drawing.Point(636, 3);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(153, 26);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButton3.StyleManager = null;
            this.metroButton3.TabIndex = 0;
            this.metroButton3.Text = "Correctie";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(599, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(31, 26);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "-";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton4
            // 
            this.metroButton4.Highlight = false;
            this.metroButton4.Location = new System.Drawing.Point(562, 3);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(31, 26);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroButton4.StyleManager = null;
            this.metroButton4.TabIndex = 0;
            this.metroButton4.Text = "+";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "0";
            // 
            // verkoopNr
            // 
            this.verkoopNr.AutoSize = true;
            this.verkoopNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verkoopNr.Location = new System.Drawing.Point(367, 0);
            this.verkoopNr.Name = "verkoopNr";
            this.verkoopNr.Size = new System.Drawing.Size(163, 24);
            this.verkoopNr.TabIndex = 5;
            this.verkoopNr.Text = "Verkoop nummer:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btwHoog, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btwLaag, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btwVrij, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.totaalExclBtw, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.totaalInclBtw, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 625);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1110, 128);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(835, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BTW Hoog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(835, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "BTW Laag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(835, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "BTW Vrij";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(835, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Totaal excl BTW";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(835, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Totaal incl BTW";
            // 
            // btwHoog
            // 
            this.btwHoog.AutoSize = true;
            this.btwHoog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btwHoog.Location = new System.Drawing.Point(1001, 0);
            this.btwHoog.Name = "btwHoog";
            this.btwHoog.Size = new System.Drawing.Size(55, 24);
            this.btwHoog.TabIndex = 0;
            this.btwHoog.Text = "€0,00";
            // 
            // btwLaag
            // 
            this.btwLaag.AutoSize = true;
            this.btwLaag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btwLaag.Location = new System.Drawing.Point(1001, 25);
            this.btwLaag.Name = "btwLaag";
            this.btwLaag.Size = new System.Drawing.Size(55, 24);
            this.btwLaag.TabIndex = 0;
            this.btwLaag.Text = "€0,00";
            // 
            // btwVrij
            // 
            this.btwVrij.AutoSize = true;
            this.btwVrij.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btwVrij.Location = new System.Drawing.Point(1001, 50);
            this.btwVrij.Name = "btwVrij";
            this.btwVrij.Size = new System.Drawing.Size(55, 24);
            this.btwVrij.TabIndex = 0;
            this.btwVrij.Text = "€0,00";
            // 
            // totaalExclBtw
            // 
            this.totaalExclBtw.AutoSize = true;
            this.totaalExclBtw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaalExclBtw.Location = new System.Drawing.Point(1001, 75);
            this.totaalExclBtw.Name = "totaalExclBtw";
            this.totaalExclBtw.Size = new System.Drawing.Size(55, 24);
            this.totaalExclBtw.TabIndex = 0;
            this.totaalExclBtw.Text = "€0,00";
            // 
            // totaalInclBtw
            // 
            this.totaalInclBtw.AutoSize = true;
            this.totaalInclBtw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaalInclBtw.Location = new System.Drawing.Point(1001, 100);
            this.totaalInclBtw.Name = "totaalInclBtw";
            this.totaalInclBtw.Size = new System.Drawing.Size(55, 24);
            this.totaalInclBtw.TabIndex = 0;
            this.totaalInclBtw.Text = "€0,00";
            // 
            // Verkopen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 805);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.verkopenGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Verkopen";
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Verkopen";
            this.Load += new System.EventHandler(this.Verkopen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.verkopenGrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView verkopenGrid;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn aantal;
        private System.Windows.Forms.DataGridViewTextBoxColumn beschrijving;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijsPerStuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijsTotaal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label btwHoog;
        private System.Windows.Forms.Label btwLaag;
        private System.Windows.Forms.Label btwVrij;
        private System.Windows.Forms.Label totaalExclBtw;
        private System.Windows.Forms.Label totaalInclBtw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label verkoopNr;
    }
}
namespace Toledo.Desktop.Forms
{
    partial class Bevestiging
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.okBtn = new MetroFramework.Controls.MetroButton();
            this.annulerenBtn = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "metroLabel1";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.okBtn);
            this.flowLayoutPanel1.Controls.Add(this.annulerenBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 190);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(526, 28);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Highlight = false;
            this.okBtn.Location = new System.Drawing.Point(464, 3);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(59, 23);
            this.okBtn.Style = MetroFramework.MetroColorStyle.Magenta;
            this.okBtn.StyleManager = null;
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "OK";
            this.okBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // annulerenBtn
            // 
            this.annulerenBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annulerenBtn.Highlight = false;
            this.annulerenBtn.Location = new System.Drawing.Point(369, 3);
            this.annulerenBtn.Name = "annulerenBtn";
            this.annulerenBtn.Size = new System.Drawing.Size(89, 23);
            this.annulerenBtn.Style = MetroFramework.MetroColorStyle.Magenta;
            this.annulerenBtn.StyleManager = null;
            this.annulerenBtn.TabIndex = 1;
            this.annulerenBtn.Text = "Annuleren";
            this.annulerenBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Bevestiging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 238);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "Bevestiging";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Bevestiging";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton okBtn;
        private MetroFramework.Controls.MetroButton annulerenBtn;
    }
}
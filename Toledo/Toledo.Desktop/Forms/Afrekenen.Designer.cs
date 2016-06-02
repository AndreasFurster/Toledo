namespace Toledo.Desktop.Forms
{
    partial class Afrekenen
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
            this.contantBtn = new System.Windows.Forms.Button();
            this.pinnenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contantBtn
            // 
            this.contantBtn.BackColor = System.Drawing.Color.Magenta;
            this.contantBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.contantBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contantBtn.ForeColor = System.Drawing.Color.White;
            this.contantBtn.Location = new System.Drawing.Point(23, 63);
            this.contantBtn.Name = "contantBtn";
            this.contantBtn.Size = new System.Drawing.Size(271, 245);
            this.contantBtn.TabIndex = 0;
            this.contantBtn.Text = "Contant";
            this.contantBtn.UseVisualStyleBackColor = false;
            this.contantBtn.Click += new System.EventHandler(this.contantBtn_Click);
            // 
            // pinnenBtn
            // 
            this.pinnenBtn.BackColor = System.Drawing.Color.Magenta;
            this.pinnenBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.pinnenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinnenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinnenBtn.ForeColor = System.Drawing.Color.White;
            this.pinnenBtn.Location = new System.Drawing.Point(319, 63);
            this.pinnenBtn.Name = "pinnenBtn";
            this.pinnenBtn.Size = new System.Drawing.Size(271, 245);
            this.pinnenBtn.TabIndex = 0;
            this.pinnenBtn.Text = "Pinnen";
            this.pinnenBtn.UseVisualStyleBackColor = false;
            this.pinnenBtn.Click += new System.EventHandler(this.pinnenBtn_Click);
            // 
            // Afrekenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 331);
            this.Controls.Add(this.pinnenBtn);
            this.Controls.Add(this.contantBtn);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "Afrekenen";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Afrekenen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button contantBtn;
        private System.Windows.Forms.Button pinnenBtn;
    }
}
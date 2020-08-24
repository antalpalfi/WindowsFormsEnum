namespace WindowsFormsEnum
{
    partial class Form1
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmbNaam = new System.Windows.Forms.ComboBox();
            this.cmbBedrijf = new System.Windows.Forms.ComboBox();
            this.lblBedrifjInfo = new System.Windows.Forms.Label();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(156, 67);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 1;
            // 
            // cmbNaam
            // 
            this.cmbNaam.FormattingEnabled = true;
            this.cmbNaam.Location = new System.Drawing.Point(12, 67);
            this.cmbNaam.Name = "cmbNaam";
            this.cmbNaam.Size = new System.Drawing.Size(121, 21);
            this.cmbNaam.TabIndex = 2;
            this.cmbNaam.SelectedIndexChanged += new System.EventHandler(this.cmbNaam_SelectedIndexChanged);
            // 
            // cmbBedrijf
            // 
            this.cmbBedrijf.FormattingEnabled = true;
            this.cmbBedrijf.Location = new System.Drawing.Point(12, 12);
            this.cmbBedrijf.Name = "cmbBedrijf";
            this.cmbBedrijf.Size = new System.Drawing.Size(121, 21);
            this.cmbBedrijf.TabIndex = 3;
            this.cmbBedrijf.SelectedIndexChanged += new System.EventHandler(this.cmbBedrijf_SelectedIndexChanged);
            // 
            // lblBedrifjInfo
            // 
            this.lblBedrifjInfo.AutoSize = true;
            this.lblBedrifjInfo.Location = new System.Drawing.Point(140, 12);
            this.lblBedrifjInfo.Name = "lblBedrifjInfo";
            this.lblBedrifjInfo.Size = new System.Drawing.Size(0, 13);
            this.lblBedrifjInfo.TabIndex = 4;
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(325, 67);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijderen.TabIndex = 5;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(325, 96);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegen.TabIndex = 6;
            this.btnToevoegen.Text = "Add";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 193);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.lblBedrifjInfo);
            this.Controls.Add(this.cmbBedrijf);
            this.Controls.Add(this.cmbNaam);
            this.Controls.Add(this.lblInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cmbNaam;
        private System.Windows.Forms.ComboBox cmbBedrijf;
        private System.Windows.Forms.Label lblBedrifjInfo;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnToevoegen;
    }
}


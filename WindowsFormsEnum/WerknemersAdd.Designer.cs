namespace WindowsFormsEnum
{
    partial class WerknemersAdd
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLand = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.lblContract = new System.Windows.Forms.Label();
            this.numBrutto = new System.Windows.Forms.NumericUpDown();
            this.cmbContract = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBrutto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(3, 9);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brutto salari";
            // 
            // lblLand
            // 
            this.lblLand.AutoSize = true;
            this.lblLand.Location = new System.Drawing.Point(3, 62);
            this.lblLand.Name = "lblLand";
            this.lblLand.Size = new System.Drawing.Size(31, 13);
            this.lblLand.TabIndex = 2;
            this.lblLand.Text = "Land";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(71, 9);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(120, 20);
            this.txtNaam.TabIndex = 3;
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(71, 62);
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(120, 20);
            this.txtLand.TabIndex = 5;
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(3, 96);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(47, 13);
            this.lblContract.TabIndex = 6;
            this.lblContract.Text = "Contract";
            // 
            // numBrutto
            // 
            this.numBrutto.Location = new System.Drawing.Point(71, 34);
            this.numBrutto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numBrutto.Name = "numBrutto";
            this.numBrutto.Size = new System.Drawing.Size(120, 20);
            this.numBrutto.TabIndex = 7;
            // 
            // cmbContract
            // 
            this.cmbContract.FormattingEnabled = true;
            this.cmbContract.Location = new System.Drawing.Point(71, 88);
            this.cmbContract.Name = "cmbContract";
            this.cmbContract.Size = new System.Drawing.Size(121, 21);
            this.cmbContract.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(71, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // WerknemersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 179);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbContract);
            this.Controls.Add(this.numBrutto);
            this.Controls.Add(this.lblContract);
            this.Controls.Add(this.txtLand);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblLand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNaam);
            this.Name = "WerknemersAdd";
            ((System.ComponentModel.ISupportInitialize)(this.numBrutto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLand;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtLand;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.NumericUpDown numBrutto;
        private System.Windows.Forms.ComboBox cmbContract;
        private System.Windows.Forms.Button btnAdd;
    }
}
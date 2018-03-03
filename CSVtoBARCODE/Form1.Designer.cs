namespace CSVtoBARCODE
{
    partial class frmBarcodePrint
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
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cmbCode = new System.Windows.Forms.ComboBox();
            this.lblTestText = new System.Windows.Forms.Label();
            this.txtTry = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dlgBrowseFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSetFont = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Location = new System.Drawing.Point(12, 32);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.ReadOnly = true;
            this.txtFileLocation.Size = new System.Drawing.Size(356, 20);
            this.txtFileLocation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Location";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(375, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cmbCode
            // 
            this.cmbCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCode.FormattingEnabled = true;
            this.cmbCode.Items.AddRange(new object[] {
            "EAN 13",
            "CODE 128"});
            this.cmbCode.Location = new System.Drawing.Point(12, 58);
            this.cmbCode.Name = "cmbCode";
            this.cmbCode.Size = new System.Drawing.Size(226, 21);
            this.cmbCode.TabIndex = 3;
            this.cmbCode.SelectedIndexChanged += new System.EventHandler(this.cmbCode_SelectedIndexChanged);
            // 
            // lblTestText
            // 
            this.lblTestText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTestText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestText.Location = new System.Drawing.Point(12, 122);
            this.lblTestText.Name = "lblTestText";
            this.lblTestText.Size = new System.Drawing.Size(439, 94);
            this.lblTestText.TabIndex = 4;
            this.lblTestText.Text = "SAMPLE TEXT";
            // 
            // txtTry
            // 
            this.txtTry.Location = new System.Drawing.Point(12, 85);
            this.txtTry.Multiline = true;
            this.txtTry.Name = "txtTry";
            this.txtTry.Size = new System.Drawing.Size(438, 34);
            this.txtTry.TabIndex = 5;
            this.txtTry.TextChanged += new System.EventHandler(this.txtTry_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dlgBrowseFile
            // 
            this.dlgBrowseFile.FileName = "openFileDialog1";
            // 
            // btnSetFont
            // 
            this.btnSetFont.Location = new System.Drawing.Point(376, 58);
            this.btnSetFont.Name = "btnSetFont";
            this.btnSetFont.Size = new System.Drawing.Size(75, 23);
            this.btnSetFont.TabIndex = 7;
            this.btnSetFont.Text = "Set";
            this.btnSetFont.UseVisualStyleBackColor = true;
            this.btnSetFont.Click += new System.EventHandler(this.btnSetFont_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(244, 59);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(124, 20);
            this.txtSize.TabIndex = 8;
            this.txtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // frmBarcodePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 272);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.btnSetFont);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTry);
            this.Controls.Add(this.lblTestText);
            this.Controls.Add(this.cmbCode);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileLocation);
            this.Name = "frmBarcodePrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cmbCode;
        private System.Windows.Forms.Label lblTestText;
        private System.Windows.Forms.TextBox txtTry;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog dlgBrowseFile;
        private System.Windows.Forms.Button btnSetFont;
        private System.Windows.Forms.TextBox txtSize;
    }
}


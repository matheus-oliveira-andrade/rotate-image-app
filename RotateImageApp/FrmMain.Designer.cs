
namespace RotateImageApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.LblOutLocation = new System.Windows.Forms.Label();
            this.TxtBOutputLoc = new System.Windows.Forms.TextBox();
            this.BtnSelectOutput = new System.Windows.Forms.Button();
            this.FbdOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.TxtBInputFile = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.BtnInputFile = new System.Windows.Forms.Button();
            this.OfdInput = new System.Windows.Forms.OpenFileDialog();
            this.LblOrientation = new System.Windows.Forms.Label();
            this.CkB90 = new System.Windows.Forms.CheckBox();
            this.CkB180 = new System.Windows.Forms.CheckBox();
            this.ckB270 = new System.Windows.Forms.CheckBox();
            this.CkB360 = new System.Windows.Forms.CheckBox();
            this.NUDCustom = new System.Windows.Forms.NumericUpDown();
            this.LblCustom = new System.Windows.Forms.Label();
            this.BtnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCustom)).BeginInit();
            this.SuspendLayout();
            // 
            // LblOutLocation
            // 
            this.LblOutLocation.AutoSize = true;
            this.LblOutLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOutLocation.Location = new System.Drawing.Point(12, 9);
            this.LblOutLocation.Name = "LblOutLocation";
            this.LblOutLocation.Size = new System.Drawing.Size(118, 21);
            this.LblOutLocation.TabIndex = 0;
            this.LblOutLocation.Text = "Output location";
            // 
            // TxtBOutputLoc
            // 
            this.TxtBOutputLoc.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBOutputLoc.Location = new System.Drawing.Point(12, 33);
            this.TxtBOutputLoc.Multiline = true;
            this.TxtBOutputLoc.Name = "TxtBOutputLoc";
            this.TxtBOutputLoc.ReadOnly = true;
            this.TxtBOutputLoc.Size = new System.Drawing.Size(864, 37);
            this.TxtBOutputLoc.TabIndex = 1;
            // 
            // BtnSelectOutput
            // 
            this.BtnSelectOutput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSelectOutput.Location = new System.Drawing.Point(882, 33);
            this.BtnSelectOutput.Name = "BtnSelectOutput";
            this.BtnSelectOutput.Size = new System.Drawing.Size(114, 37);
            this.BtnSelectOutput.TabIndex = 2;
            this.BtnSelectOutput.Text = "Select";
            this.BtnSelectOutput.UseVisualStyleBackColor = true;
            this.BtnSelectOutput.Click += new System.EventHandler(this.BtnSelectOutput_Click);
            // 
            // TxtBInputFile
            // 
            this.TxtBInputFile.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBInputFile.Location = new System.Drawing.Point(12, 113);
            this.TxtBInputFile.Multiline = true;
            this.TxtBInputFile.Name = "TxtBInputFile";
            this.TxtBInputFile.ReadOnly = true;
            this.TxtBInputFile.Size = new System.Drawing.Size(864, 37);
            this.TxtBInputFile.TabIndex = 4;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFile.Location = new System.Drawing.Point(12, 89);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(71, 21);
            this.lblFile.TabIndex = 3;
            this.lblFile.Text = "Input file";
            // 
            // BtnInputFile
            // 
            this.BtnInputFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnInputFile.Location = new System.Drawing.Point(882, 113);
            this.BtnInputFile.Name = "BtnInputFile";
            this.BtnInputFile.Size = new System.Drawing.Size(114, 37);
            this.BtnInputFile.TabIndex = 5;
            this.BtnInputFile.Text = "Select";
            this.BtnInputFile.UseVisualStyleBackColor = true;
            this.BtnInputFile.Click += new System.EventHandler(this.BtnInputFile_Click);
            // 
            // OfdInput
            // 
            this.OfdInput.FileName = "openFileDialog1";
            // 
            // LblOrientation
            // 
            this.LblOrientation.AutoSize = true;
            this.LblOrientation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOrientation.Location = new System.Drawing.Point(12, 170);
            this.LblOrientation.Name = "LblOrientation";
            this.LblOrientation.Size = new System.Drawing.Size(50, 21);
            this.LblOrientation.TabIndex = 7;
            this.LblOrientation.Text = "Angle";
            // 
            // CkB90
            // 
            this.CkB90.AutoSize = true;
            this.CkB90.Checked = true;
            this.CkB90.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkB90.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CkB90.Location = new System.Drawing.Point(12, 194);
            this.CkB90.Name = "CkB90";
            this.CkB90.Size = new System.Drawing.Size(54, 25);
            this.CkB90.TabIndex = 8;
            this.CkB90.Text = "90º";
            this.CkB90.UseVisualStyleBackColor = true;
            // 
            // CkB180
            // 
            this.CkB180.AutoSize = true;
            this.CkB180.Checked = true;
            this.CkB180.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkB180.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CkB180.Location = new System.Drawing.Point(76, 194);
            this.CkB180.Name = "CkB180";
            this.CkB180.Size = new System.Drawing.Size(63, 25);
            this.CkB180.TabIndex = 9;
            this.CkB180.Text = "180º";
            this.CkB180.UseVisualStyleBackColor = true;
            // 
            // ckB270
            // 
            this.ckB270.AutoSize = true;
            this.ckB270.Checked = true;
            this.ckB270.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckB270.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckB270.Location = new System.Drawing.Point(145, 194);
            this.ckB270.Name = "ckB270";
            this.ckB270.Size = new System.Drawing.Size(63, 25);
            this.ckB270.TabIndex = 10;
            this.ckB270.Text = "270º";
            this.ckB270.UseVisualStyleBackColor = true;
            // 
            // CkB360
            // 
            this.CkB360.AutoSize = true;
            this.CkB360.Checked = true;
            this.CkB360.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkB360.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CkB360.Location = new System.Drawing.Point(214, 194);
            this.CkB360.Name = "CkB360";
            this.CkB360.Size = new System.Drawing.Size(63, 25);
            this.CkB360.TabIndex = 11;
            this.CkB360.Text = "360º";
            this.CkB360.UseVisualStyleBackColor = true;
            // 
            // NUDCustom
            // 
            this.NUDCustom.DecimalPlaces = 2;
            this.NUDCustom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NUDCustom.Location = new System.Drawing.Point(283, 194);
            this.NUDCustom.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.NUDCustom.Name = "NUDCustom";
            this.NUDCustom.Size = new System.Drawing.Size(79, 29);
            this.NUDCustom.TabIndex = 12;
            // 
            // LblCustom
            // 
            this.LblCustom.AutoSize = true;
            this.LblCustom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCustom.Location = new System.Drawing.Point(368, 195);
            this.LblCustom.Name = "LblCustom";
            this.LblCustom.Size = new System.Drawing.Size(64, 21);
            this.LblCustom.TabIndex = 13;
            this.LblCustom.Text = "Custom";
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGenerate.Location = new System.Drawing.Point(882, 181);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(114, 42);
            this.BtnGenerate.TabIndex = 14;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 233);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.LblCustom);
            this.Controls.Add(this.NUDCustom);
            this.Controls.Add(this.CkB360);
            this.Controls.Add(this.ckB270);
            this.Controls.Add(this.CkB180);
            this.Controls.Add(this.CkB90);
            this.Controls.Add(this.LblOrientation);
            this.Controls.Add(this.BtnInputFile);
            this.Controls.Add(this.TxtBInputFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.BtnSelectOutput);
            this.Controls.Add(this.TxtBOutputLoc);
            this.Controls.Add(this.LblOutLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rotate images";
            ((System.ComponentModel.ISupportInitialize)(this.NUDCustom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblOutLocation;
        private System.Windows.Forms.TextBox TxtBOutputLoc;
        private System.Windows.Forms.Button BtnSelectOutput;
        private System.Windows.Forms.FolderBrowserDialog FbdOutput;
        private System.Windows.Forms.TextBox TxtBInputFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button BtnInputFile;
        private System.Windows.Forms.OpenFileDialog OfdInput;
        private System.Windows.Forms.Label LblOrientation;
        private System.Windows.Forms.CheckBox CkB90;
        private System.Windows.Forms.CheckBox CkB180;
        private System.Windows.Forms.CheckBox ckB270;
        private System.Windows.Forms.CheckBox CkB360;
        private System.Windows.Forms.NumericUpDown NUDCustom;
        private System.Windows.Forms.Label LblCustom;
        private System.Windows.Forms.Button BtnGenerate;
    }
}


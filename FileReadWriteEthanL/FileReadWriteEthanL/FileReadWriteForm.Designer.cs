namespace FileReadWriteEthanL
{
    partial class frmFileReadWrite
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(59, 33);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(320, 20);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Compare strings on each line of input.txt. file";
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.Location = new System.Drawing.Point(59, 80);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(166, 20);
            this.lblSubHeading.TabIndex = 1;
            this.lblSubHeading.Text = "(Case doesn\'t matter.)";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(180, 148);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(95, 38);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(59, 240);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(281, 20);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Output has been generated to text file.";
            // 
            // frmFileReadWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 324);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmFileReadWrite";
            this.Text = "File Read/Write by Ethan";
            this.Load += new System.EventHandler(this.FrmFileReadWrite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblOutput;
    }
}


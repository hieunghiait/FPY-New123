namespace FPY
{
    partial class frmMain
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
            this.btnOpenPC = new System.Windows.Forms.Button();
            this.btnOpenCNC = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenDetail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenPC
            // 
            this.btnOpenPC.Location = new System.Drawing.Point(12, 35);
            this.btnOpenPC.Name = "btnOpenPC";
            this.btnOpenPC.Size = new System.Drawing.Size(167, 33);
            this.btnOpenPC.TabIndex = 0;
            this.btnOpenPC.Text = "OPEN FORM PC";
            this.btnOpenPC.UseVisualStyleBackColor = true;
            this.btnOpenPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // btnOpenCNC
            // 
            this.btnOpenCNC.Location = new System.Drawing.Point(12, 90);
            this.btnOpenCNC.Name = "btnOpenCNC";
            this.btnOpenCNC.Size = new System.Drawing.Size(167, 34);
            this.btnOpenCNC.TabIndex = 1;
            this.btnOpenCNC.Text = "OPEN FORM CNC";
            this.btnOpenCNC.UseVisualStyleBackColor = true;
            this.btnOpenCNC.Click += new System.EventHandler(this.btnOpenCNC_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(276, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(300, 36);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "FIRST PASS YIELD";
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpenDetail);
            this.panel1.Controls.Add(this.btnOpenPC);
            this.panel1.Controls.Add(this.btnOpenCNC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 4;
            // 
            // btnOpenDetail
            // 
            this.btnOpenDetail.Location = new System.Drawing.Point(15, 140);
            this.btnOpenDetail.Name = "btnOpenDetail";
            this.btnOpenDetail.Size = new System.Drawing.Size(164, 37);
            this.btnOpenDetail.TabIndex = 2;
            this.btnOpenDetail.Text = "OPEN FORM DETAIL";
            this.btnOpenDetail.UseVisualStyleBackColor = true;
            this.btnOpenDetail.Click += new System.EventHandler(this.btnOpenDetail_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPC;
        private System.Windows.Forms.Button btnOpenCNC;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpenDetail;
    }
}
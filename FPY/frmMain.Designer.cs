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
            this.components = new System.ComponentModel.Container();
            this.btnOpenPC = new System.Windows.Forms.Button();
            this.btnOpenCNC = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenQC = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOpenDetail = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenPC
            // 
            this.btnOpenPC.AllowDrop = true;
            this.btnOpenPC.AutoSize = true;
            this.btnOpenPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnOpenPC.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpenPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOpenPC.Location = new System.Drawing.Point(0, 0);
            this.btnOpenPC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenPC.Name = "btnOpenPC";
            this.btnOpenPC.Size = new System.Drawing.Size(89, 33);
            this.btnOpenPC.TabIndex = 0;
            this.btnOpenPC.Text = "PC";
            this.btnOpenPC.UseVisualStyleBackColor = false;
            this.btnOpenPC.Click += new System.EventHandler(this.btnPC_Click);
            // 
            // btnOpenCNC
            // 
            this.btnOpenCNC.AllowDrop = true;
            this.btnOpenCNC.AutoSize = true;
            this.btnOpenCNC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnOpenCNC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenCNC.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpenCNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCNC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOpenCNC.Location = new System.Drawing.Point(89, 0);
            this.btnOpenCNC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenCNC.Name = "btnOpenCNC";
            this.btnOpenCNC.Size = new System.Drawing.Size(100, 33);
            this.btnOpenCNC.TabIndex = 1;
            this.btnOpenCNC.Text = "CNC";
            this.btnOpenCNC.UseVisualStyleBackColor = false;
            this.btnOpenCNC.Click += new System.EventHandler(this.btnOpenCNC_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpenQC);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnOpenDetail);
            this.panel1.Controls.Add(this.btnOpenCNC);
            this.panel1.Controls.Add(this.btnOpenPC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 33);
            this.panel1.TabIndex = 4;
            // 
            // btnOpenQC
            // 
            this.btnOpenQC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnOpenQC.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpenQC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenQC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOpenQC.Location = new System.Drawing.Point(294, 0);
            this.btnOpenQC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenQC.Name = "btnOpenQC";
            this.btnOpenQC.Size = new System.Drawing.Size(99, 33);
            this.btnOpenQC.TabIndex = 3;
            this.btnOpenQC.Text = "QC";
            this.btnOpenQC.UseVisualStyleBackColor = false;
            this.btnOpenQC.Click += new System.EventHandler(this.btnOpenQC_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(534, 2);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(57, 30);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnOpenDetail
            // 
            this.btnOpenDetail.AllowDrop = true;
            this.btnOpenDetail.AutoSize = true;
            this.btnOpenDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnOpenDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpenDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDetail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOpenDetail.Location = new System.Drawing.Point(189, 0);
            this.btnOpenDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenDetail.Name = "btnOpenDetail";
            this.btnOpenDetail.Size = new System.Drawing.Size(105, 33);
            this.btnOpenDetail.TabIndex = 2;
            this.btnOpenDetail.Text = "DETAIL";
            this.btnOpenDetail.UseVisualStyleBackColor = false;
            this.btnOpenDetail.Click += new System.EventHandler(this.btnOpenDetail_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPC;
        private System.Windows.Forms.Button btnOpenCNC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpenDetail;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnOpenQC;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
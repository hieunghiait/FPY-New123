namespace FPY
{
    partial class frmDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtWO = new System.Windows.Forms.TextBox();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.labelWO = new System.Windows.Forms.Label();
            this.labelPartNum = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOutputQtyDetail = new System.Windows.Forms.TextBox();
            this.txtDMRDetail = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.txtInputQtyDetail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDMR = new System.Windows.Forms.Label();
            this.labelInputQuantity = new System.Windows.Forms.Label();
            this.txtDescriptionDetail = new System.Windows.Forms.RichTextBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtWO);
            this.panel1.Controls.Add(this.txtPartNo);
            this.panel1.Controls.Add(this.labelWO);
            this.panel1.Controls.Add(this.labelPartNum);
            this.panel1.Location = new System.Drawing.Point(67, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 141);
            this.panel1.TabIndex = 20;
            // 
            // txtWO
            // 
            this.txtWO.AcceptsTab = true;
            this.txtWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWO.Location = new System.Drawing.Point(126, 83);
            this.txtWO.Name = "txtWO";
            this.txtWO.Size = new System.Drawing.Size(127, 28);
            this.txtWO.TabIndex = 5;
            // 
            // txtPartNo
            // 
            this.txtPartNo.AcceptsTab = true;
            this.txtPartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartNo.Location = new System.Drawing.Point(126, 26);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(202, 28);
            this.txtPartNo.TabIndex = 4;
            // 
            // labelWO
            // 
            this.labelWO.AutoSize = true;
            this.labelWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWO.Location = new System.Drawing.Point(32, 82);
            this.labelWO.Name = "labelWO";
            this.labelWO.Size = new System.Drawing.Size(38, 20);
            this.labelWO.TabIndex = 1;
            this.labelWO.Text = "WO";
            // 
            // labelPartNum
            // 
            this.labelPartNum.AutoSize = true;
            this.labelPartNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartNum.Location = new System.Drawing.Point(32, 31);
            this.labelPartNum.Name = "labelPartNum";
            this.labelPartNum.Size = new System.Drawing.Size(83, 20);
            this.labelPartNum.TabIndex = 0;
            this.labelPartNum.Text = "PART NO";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(116, 242);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 37);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(270, 242);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(98, 37);
            this.btnCapNhat.TabIndex = 18;
            this.btnCapNhat.Text = "UPDATE";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtOutputQtyDetail);
            this.panel2.Controls.Add(this.txtDMRDetail);
            this.panel2.Controls.Add(this.labelDescription);
            this.panel2.Controls.Add(this.txtInputQtyDetail);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelDMR);
            this.panel2.Controls.Add(this.labelInputQuantity);
            this.panel2.Controls.Add(this.txtDescriptionDetail);
            this.panel2.Location = new System.Drawing.Point(38, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 353);
            this.panel2.TabIndex = 22;
            // 
            // txtOutputQtyDetail
            // 
            this.txtOutputQtyDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputQtyDetail.Location = new System.Drawing.Point(194, 94);
            this.txtOutputQtyDetail.Name = "txtOutputQtyDetail";
            this.txtOutputQtyDetail.Size = new System.Drawing.Size(187, 28);
            this.txtOutputQtyDetail.TabIndex = 18;
            // 
            // txtDMRDetail
            // 
            this.txtDMRDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtDMRDetail.Location = new System.Drawing.Point(194, 293);
            this.txtDMRDetail.Name = "txtDMRDetail";
            this.txtDMRDetail.Size = new System.Drawing.Size(109, 28);
            this.txtDMRDetail.TabIndex = 18;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(34, 174);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(109, 18);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "DESCRIPTION";
            // 
            // txtInputQtyDetail
            // 
            this.txtInputQtyDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputQtyDetail.Location = new System.Drawing.Point(194, 51);
            this.txtInputQtyDetail.Name = "txtInputQtyDetail";
            this.txtInputQtyDetail.ReadOnly = true;
            this.txtInputQtyDetail.Size = new System.Drawing.Size(187, 28);
            this.txtInputQtyDetail.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "OUTPUT QTY";
            // 
            // labelDMR
            // 
            this.labelDMR.AutoSize = true;
            this.labelDMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDMR.Location = new System.Drawing.Point(34, 293);
            this.labelDMR.Name = "labelDMR";
            this.labelDMR.Size = new System.Drawing.Size(43, 18);
            this.labelDMR.TabIndex = 13;
            this.labelDMR.Text = "DMR";
            // 
            // labelInputQuantity
            // 
            this.labelInputQuantity.AutoSize = true;
            this.labelInputQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputQuantity.Location = new System.Drawing.Point(34, 59);
            this.labelInputQuantity.Name = "labelInputQuantity";
            this.labelInputQuantity.Size = new System.Drawing.Size(86, 18);
            this.labelInputQuantity.TabIndex = 8;
            this.labelInputQuantity.Text = "INPUT QTY";
            // 
            // txtDescriptionDetail
            // 
            this.txtDescriptionDetail.AcceptsTab = true;
            this.txtDescriptionDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionDetail.Location = new System.Drawing.Point(194, 146);
            this.txtDescriptionDetail.Name = "txtDescriptionDetail";
            this.txtDescriptionDetail.Size = new System.Drawing.Size(234, 110);
            this.txtDescriptionDetail.TabIndex = 19;
            this.txtDescriptionDetail.Text = "";
            this.txtDescriptionDetail.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToOrderColumns = true;
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetail.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDetail.ColumnHeadersHeight = 29;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetail.Location = new System.Drawing.Point(586, 34);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 24;
            this.dgvDetail.Size = new System.Drawing.Size(884, 678);
            this.dgvDetail.TabIndex = 21;
            this.dgvDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(426, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 30);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 744);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.panel2);
            this.Name = "frmDetail";
            this.Text = "frmDetail";
            this.Load += new System.EventHandler(this.frmDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtWO;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.Label labelWO;
        private System.Windows.Forms.Label labelPartNum;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtOutputQtyDetail;
        private System.Windows.Forms.TextBox txtDMRDetail;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox txtInputQtyDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDMR;
        private System.Windows.Forms.Label labelInputQuantity;
        private System.Windows.Forms.RichTextBox txtDescriptionDetail;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Button btnDelete;
    }
}
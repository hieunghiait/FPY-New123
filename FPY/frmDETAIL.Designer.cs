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
            this.txtDetailID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtWOSearch = new System.Windows.Forms.TextBox();
            this.txtPartNoSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDetailID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtWO);
            this.panel1.Controls.Add(this.txtPartNo);
            this.panel1.Controls.Add(this.labelWO);
            this.panel1.Controls.Add(this.labelPartNum);
            this.panel1.Location = new System.Drawing.Point(92, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 160);
            this.panel1.TabIndex = 20;
            // 
            // txtDetailID
            // 
            this.txtDetailID.AcceptsTab = true;
            this.txtDetailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetailID.Location = new System.Drawing.Point(123, 10);
            this.txtDetailID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetailID.Name = "txtDetailID";
            this.txtDetailID.ReadOnly = true;
            this.txtDetailID.Size = new System.Drawing.Size(97, 28);
            this.txtDetailID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "DETAIL ID";
            // 
            // txtWO
            // 
            this.txtWO.AcceptsTab = true;
            this.txtWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWO.Location = new System.Drawing.Point(123, 113);
            this.txtWO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWO.Name = "txtWO";
            this.txtWO.Size = new System.Drawing.Size(127, 28);
            this.txtWO.TabIndex = 5;
            this.txtWO.TextChanged += new System.EventHandler(this.txtWO_TextChanged);
            // 
            // txtPartNo
            // 
            this.txtPartNo.AcceptsTab = true;
            this.txtPartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartNo.Location = new System.Drawing.Point(123, 57);
            this.txtPartNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(147, 28);
            this.txtPartNo.TabIndex = 4;
            this.txtPartNo.TextChanged += new System.EventHandler(this.txtPartNo_TextChanged);
            // 
            // labelWO
            // 
            this.labelWO.AutoSize = true;
            this.labelWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWO.Location = new System.Drawing.Point(29, 112);
            this.labelWO.Name = "labelWO";
            this.labelWO.Size = new System.Drawing.Size(38, 20);
            this.labelWO.TabIndex = 1;
            this.labelWO.Text = "WO";
            // 
            // labelPartNum
            // 
            this.labelPartNum.AutoSize = true;
            this.labelPartNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartNum.Location = new System.Drawing.Point(29, 62);
            this.labelPartNum.Name = "labelPartNum";
            this.labelPartNum.Size = new System.Drawing.Size(83, 20);
            this.labelPartNum.TabIndex = 0;
            this.labelPartNum.Text = "PART NO";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(105, 246);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 52);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(253, 246);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(117, 52);
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
            this.panel2.Location = new System.Drawing.Point(92, 396);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 295);
            this.panel2.TabIndex = 22;
            // 
            // txtOutputQtyDetail
            // 
            this.txtOutputQtyDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputQtyDetail.Location = new System.Drawing.Point(150, 80);
            this.txtOutputQtyDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutputQtyDetail.Name = "txtOutputQtyDetail";
            this.txtOutputQtyDetail.Size = new System.Drawing.Size(97, 28);
            this.txtOutputQtyDetail.TabIndex = 18;
            this.txtOutputQtyDetail.TextChanged += new System.EventHandler(this.txtOutputQtyDetail_TextChanged);
            // 
            // txtDMRDetail
            // 
            this.txtDMRDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtDMRDetail.Location = new System.Drawing.Point(150, 234);
            this.txtDMRDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDMRDetail.Name = "txtDMRDetail";
            this.txtDMRDetail.Size = new System.Drawing.Size(80, 28);
            this.txtDMRDetail.TabIndex = 18;
            this.txtDMRDetail.TextChanged += new System.EventHandler(this.txtDMRDetail_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(35, 161);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(109, 18);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "DESCRIPTION";
            // 
            // txtInputQtyDetail
            // 
            this.txtInputQtyDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputQtyDetail.Location = new System.Drawing.Point(150, 36);
            this.txtInputQtyDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputQtyDetail.Name = "txtInputQtyDetail";
            this.txtInputQtyDetail.ReadOnly = true;
            this.txtInputQtyDetail.Size = new System.Drawing.Size(97, 28);
            this.txtInputQtyDetail.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "OUTPUT QTY";
            // 
            // labelDMR
            // 
            this.labelDMR.AutoSize = true;
            this.labelDMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDMR.Location = new System.Drawing.Point(35, 244);
            this.labelDMR.Name = "labelDMR";
            this.labelDMR.Size = new System.Drawing.Size(43, 18);
            this.labelDMR.TabIndex = 13;
            this.labelDMR.Text = "DMR";
            // 
            // labelInputQuantity
            // 
            this.labelInputQuantity.AutoSize = true;
            this.labelInputQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputQuantity.Location = new System.Drawing.Point(35, 46);
            this.labelInputQuantity.Name = "labelInputQuantity";
            this.labelInputQuantity.Size = new System.Drawing.Size(86, 18);
            this.labelInputQuantity.TabIndex = 8;
            this.labelInputQuantity.Text = "INPUT QTY";
            // 
            // txtDescriptionDetail
            // 
            this.txtDescriptionDetail.AcceptsTab = true;
            this.txtDescriptionDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionDetail.Location = new System.Drawing.Point(150, 126);
            this.txtDescriptionDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescriptionDetail.Name = "txtDescriptionDetail";
            this.txtDescriptionDetail.Size = new System.Drawing.Size(277, 93);
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
            this.dgvDetail.Location = new System.Drawing.Point(732, 47);
            this.dgvDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 24;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(1217, 672);
            this.dgvDetail.TabIndex = 21;
            this.dgvDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellClick);
            this.dgvDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(392, 313);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 52);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.Location = new System.Drawing.Point(110, 312);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(126, 50);
            this.btnLoadData.TabIndex = 24;
            this.btnLoadData.Text = "LOAD DATA";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(253, 312);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 54);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtWOSearch
            // 
            this.txtWOSearch.AcceptsTab = true;
            this.txtWOSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWOSearch.Location = new System.Drawing.Point(118, 67);
            this.txtWOSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWOSearch.Name = "txtWOSearch";
            this.txtWOSearch.Size = new System.Drawing.Size(127, 28);
            this.txtWOSearch.TabIndex = 11;
            this.txtWOSearch.TextChanged += new System.EventHandler(this.txtWOSearch_TextChanged);
            // 
            // txtPartNoSearch
            // 
            this.txtPartNoSearch.AcceptsTab = true;
            this.txtPartNoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartNoSearch.Location = new System.Drawing.Point(118, 15);
            this.txtPartNoSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPartNoSearch.Name = "txtPartNoSearch";
            this.txtPartNoSearch.Size = new System.Drawing.Size(147, 28);
            this.txtPartNoSearch.TabIndex = 10;
            this.txtPartNoSearch.TextChanged += new System.EventHandler(this.txtPartNoSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "WO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "PART NO";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtWOSearch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtPartNoSearch);
            this.panel3.Location = new System.Drawing.Point(402, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 157);
            this.panel3.TabIndex = 26;
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 748);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetail";
            this.Load += new System.EventHandler(this.frmDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetailID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtWOSearch;
        private System.Windows.Forms.TextBox txtPartNoSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
    }
}
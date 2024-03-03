﻿namespace FPY
{
    partial class frmQC
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
            this.title = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtOutputQtyQC = new System.Windows.Forms.TextBox();
            this.txtDRMQC = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.txtInputQtyQC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDMR = new System.Windows.Forms.Label();
            this.labelInputQuantity = new System.Windows.Forms.Label();
            this.txtDescriptionQC = new System.Windows.Forms.RichTextBox();
            this.dgvQC = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQCID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWO = new System.Windows.Forms.TextBox();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.labelWO = new System.Windows.Forms.Label();
            this.labelPartNum = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartNoSearch = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReloadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQC)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(833, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(152, 32);
            this.title.TabIndex = 25;
            this.title.Text = "FORM QC";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(180, 340);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 49);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtOutputQtyQC
            // 
            this.txtOutputQtyQC.AcceptsTab = true;
            this.txtOutputQtyQC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputQtyQC.Location = new System.Drawing.Point(140, 57);
            this.txtOutputQtyQC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutputQtyQC.Name = "txtOutputQtyQC";
            this.txtOutputQtyQC.Size = new System.Drawing.Size(187, 28);
            this.txtOutputQtyQC.TabIndex = 18;
            // 
            // txtDRMQC
            // 
            this.txtDRMQC.AcceptsTab = true;
            this.txtDRMQC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtDRMQC.Location = new System.Drawing.Point(140, 226);
            this.txtDRMQC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDRMQC.Name = "txtDRMQC";
            this.txtDRMQC.Size = new System.Drawing.Size(109, 28);
            this.txtDRMQC.TabIndex = 18;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(25, 130);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(109, 18);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "DESCRIPTION";
            // 
            // txtInputQtyQC
            // 
            this.txtInputQtyQC.AcceptsTab = true;
            this.txtInputQtyQC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputQtyQC.Location = new System.Drawing.Point(140, 16);
            this.txtInputQtyQC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputQtyQC.Name = "txtInputQtyQC";
            this.txtInputQtyQC.ReadOnly = true;
            this.txtInputQtyQC.Size = new System.Drawing.Size(187, 28);
            this.txtInputQtyQC.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "OUTPUT QTY";
            // 
            // labelDMR
            // 
            this.labelDMR.AutoSize = true;
            this.labelDMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDMR.Location = new System.Drawing.Point(25, 232);
            this.labelDMR.Name = "labelDMR";
            this.labelDMR.Size = new System.Drawing.Size(43, 18);
            this.labelDMR.TabIndex = 13;
            this.labelDMR.Text = "DMR";
            // 
            // labelInputQuantity
            // 
            this.labelInputQuantity.AutoSize = true;
            this.labelInputQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputQuantity.Location = new System.Drawing.Point(25, 22);
            this.labelInputQuantity.Name = "labelInputQuantity";
            this.labelInputQuantity.Size = new System.Drawing.Size(86, 18);
            this.labelInputQuantity.TabIndex = 8;
            this.labelInputQuantity.Text = "INPUT QTY";
            // 
            // txtDescriptionQC
            // 
            this.txtDescriptionQC.AcceptsTab = true;
            this.txtDescriptionQC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionQC.Location = new System.Drawing.Point(140, 99);
            this.txtDescriptionQC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescriptionQC.Name = "txtDescriptionQC";
            this.txtDescriptionQC.Size = new System.Drawing.Size(233, 110);
            this.txtDescriptionQC.TabIndex = 19;
            this.txtDescriptionQC.Text = "";
            // 
            // dgvQC
            // 
            this.dgvQC.AllowUserToAddRows = false;
            this.dgvQC.AllowUserToResizeRows = false;
            this.dgvQC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQC.BackgroundColor = System.Drawing.Color.White;
            this.dgvQC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvQC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQC.Location = new System.Drawing.Point(952, 75);
            this.dgvQC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQC.MultiSelect = false;
            this.dgvQC.Name = "dgvQC";
            this.dgvQC.ReadOnly = true;
            this.dgvQC.RowHeadersVisible = false;
            this.dgvQC.RowHeadersWidth = 51;
            this.dgvQC.RowTemplate.Height = 24;
            this.dgvQC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQC.Size = new System.Drawing.Size(816, 654);
            this.dgvQC.TabIndex = 29;
            this.dgvQC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQC_CellClick);
            this.dgvQC.Click += new System.EventHandler(this.dgvQC_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtQCID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtWO);
            this.panel1.Controls.Add(this.txtPartNo);
            this.panel1.Controls.Add(this.labelWO);
            this.panel1.Controls.Add(this.labelPartNum);
            this.panel1.Location = new System.Drawing.Point(85, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 161);
            this.panel1.TabIndex = 28;
            // 
            // txtQCID
            // 
            this.txtQCID.AcceptsTab = true;
            this.txtQCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQCID.Location = new System.Drawing.Point(123, 10);
            this.txtQCID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQCID.Name = "txtQCID";
            this.txtQCID.ReadOnly = true;
            this.txtQCID.Size = new System.Drawing.Size(79, 28);
            this.txtQCID.TabIndex = 7;
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
            // 
            // txtPartNo
            // 
            this.txtPartNo.AcceptsTab = true;
            this.txtPartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartNo.Location = new System.Drawing.Point(123, 57);
            this.txtPartNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(201, 28);
            this.txtPartNo.TabIndex = 4;
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
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(48, 264);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 56);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtOutputQtyQC);
            this.panel2.Controls.Add(this.txtDRMQC);
            this.panel2.Controls.Add(this.labelDescription);
            this.panel2.Controls.Add(this.txtInputQtyQC);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelDMR);
            this.panel2.Controls.Add(this.labelInputQuantity);
            this.panel2.Controls.Add(this.txtDescriptionQC);
            this.panel2.Location = new System.Drawing.Point(53, 430);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 299);
            this.panel2.TabIndex = 30;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(180, 264);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 56);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(51, 335);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 54);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.txtPartNoSearch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(503, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 654);
            this.panel3.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(24, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "PART NO";
            // 
            // txtPartNoSearch
            // 
            this.txtPartNoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartNoSearch.Location = new System.Drawing.Point(118, 52);
            this.txtPartNoSearch.Name = "txtPartNoSearch";
            this.txtPartNoSearch.Size = new System.Drawing.Size(175, 28);
            this.txtPartNoSearch.TabIndex = 2;
            this.txtPartNoSearch.TextChanged += new System.EventHandler(this.txtPartNoSearch_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.textBox2.Location = new System.Drawing.Point(118, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 28);
            this.textBox2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "WO";
            // 
            // btnReloadData
            // 
            this.btnReloadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReloadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadData.Location = new System.Drawing.Point(301, 264);
            this.btnReloadData.Margin = new System.Windows.Forms.Padding(4);
            this.btnReloadData.Name = "btnReloadData";
            this.btnReloadData.Size = new System.Drawing.Size(167, 56);
            this.btnReloadData.TabIndex = 35;
            this.btnReloadData.Text = "RELOAD DATA";
            this.btnReloadData.UseVisualStyleBackColor = false;
            this.btnReloadData.Click += new System.EventHandler(this.btnReloadData_Click);
            // 
            // frmQC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 845);
            this.Controls.Add(this.btnReloadData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvQC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQC";
            this.Load += new System.EventHandler(this.frmQC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtOutputQtyQC;
        private System.Windows.Forms.TextBox txtDRMQC;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox txtInputQtyQC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDMR;
        private System.Windows.Forms.Label labelInputQuantity;
        private System.Windows.Forms.RichTextBox txtDescriptionQC;
        private System.Windows.Forms.DataGridView dgvQC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQCID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWO;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.Label labelWO;
        private System.Windows.Forms.Label labelPartNum;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtPartNoSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReloadData;
    }
}
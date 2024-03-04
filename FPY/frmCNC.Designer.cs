namespace FPY
{
    partial class frmCNC
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
            this.labelPartNum = new System.Windows.Forms.Label();
            this.labelWO = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.txtWO = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCNC = new System.Windows.Forms.DataGridView();
            this.labelInputQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDMR = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOutputQtyCNC = new System.Windows.Forms.TextBox();
            this.txtDMR = new System.Windows.Forms.TextBox();
            this.txtInputQtyCNC = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReloadData = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtWOSearch = new System.Windows.Forms.TextBox();
            this.txtPartNoSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCNC)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(249, 194);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(117, 52);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "UPDATE";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(92, 252);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 50);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPartNo
            // 
            this.txtPartNo.AcceptsTab = true;
            this.txtPartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartNo.Location = new System.Drawing.Point(132, 27);
            this.txtPartNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(153, 28);
            this.txtPartNo.TabIndex = 4;
            this.txtPartNo.TextChanged += new System.EventHandler(this.textBoxPartNum_TextChanged);
            // 
            // txtWO
            // 
            this.txtWO.AcceptsTab = true;
            this.txtWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWO.Location = new System.Drawing.Point(132, 82);
            this.txtWO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWO.Name = "txtWO";
            this.txtWO.Size = new System.Drawing.Size(127, 28);
            this.txtWO.TabIndex = 5;
            this.txtWO.TextChanged += new System.EventHandler(this.txtBoxWO_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtWO);
            this.panel1.Controls.Add(this.txtPartNo);
            this.panel1.Controls.Add(this.labelWO);
            this.panel1.Controls.Add(this.labelPartNum);
            this.panel1.Location = new System.Drawing.Point(56, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 142);
            this.panel1.TabIndex = 6;
            // 
            // dgvCNC
            // 
            this.dgvCNC.AllowUserToAddRows = false;
            this.dgvCNC.AllowUserToDeleteRows = false;
            this.dgvCNC.AllowUserToOrderColumns = true;
            this.dgvCNC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCNC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCNC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCNC.ColumnHeadersHeight = 29;
            this.dgvCNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCNC.Location = new System.Drawing.Point(855, 39);
            this.dgvCNC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCNC.Name = "dgvCNC";
            this.dgvCNC.ReadOnly = true;
            this.dgvCNC.RowHeadersWidth = 51;
            this.dgvCNC.RowTemplate.Height = 24;
            this.dgvCNC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCNC.Size = new System.Drawing.Size(976, 683);
            this.dgvCNC.TabIndex = 7;
            this.dgvCNC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCNC_CellClick_1);
            // 
            // labelInputQuantity
            // 
            this.labelInputQuantity.AutoSize = true;
            this.labelInputQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputQuantity.Location = new System.Drawing.Point(17, 42);
            this.labelInputQuantity.Name = "labelInputQuantity";
            this.labelInputQuantity.Size = new System.Drawing.Size(96, 20);
            this.labelInputQuantity.TabIndex = 8;
            this.labelInputQuantity.Text = "INPUT QTY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "OUTPUT QTY";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(17, 178);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(122, 20);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "DESCRIPTION";
            // 
            // labelDMR
            // 
            this.labelDMR.AutoSize = true;
            this.labelDMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDMR.Location = new System.Drawing.Point(17, 286);
            this.labelDMR.Name = "labelDMR";
            this.labelDMR.Size = new System.Drawing.Size(48, 20);
            this.labelDMR.TabIndex = 13;
            this.labelDMR.Text = "DMR";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtOutputQtyCNC);
            this.panel2.Controls.Add(this.txtDMR);
            this.panel2.Controls.Add(this.labelDescription);
            this.panel2.Controls.Add(this.txtInputQtyCNC);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelDMR);
            this.panel2.Controls.Add(this.labelInputQuantity);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Location = new System.Drawing.Point(40, 326);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 389);
            this.panel2.TabIndex = 17;
            // 
            // txtOutputQtyCNC
            // 
            this.txtOutputQtyCNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputQtyCNC.Location = new System.Drawing.Point(167, 79);
            this.txtOutputQtyCNC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutputQtyCNC.Name = "txtOutputQtyCNC";
            this.txtOutputQtyCNC.Size = new System.Drawing.Size(172, 28);
            this.txtOutputQtyCNC.TabIndex = 18;
            this.txtOutputQtyCNC.TextChanged += new System.EventHandler(this.textBoxOutputQuantity_TextChanged);
            this.txtOutputQtyCNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOutputQuantity_KeyPress);
            // 
            // txtDMR
            // 
            this.txtDMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtDMR.Location = new System.Drawing.Point(167, 278);
            this.txtDMR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDMR.Name = "txtDMR";
            this.txtDMR.Size = new System.Drawing.Size(96, 28);
            this.txtDMR.TabIndex = 18;
            this.txtDMR.TextChanged += new System.EventHandler(this.textBoxDMR_TextChanged);
            // 
            // txtInputQtyCNC
            // 
            this.txtInputQtyCNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputQtyCNC.Location = new System.Drawing.Point(167, 42);
            this.txtInputQtyCNC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputQtyCNC.Name = "txtInputQtyCNC";
            this.txtInputQtyCNC.ReadOnly = true;
            this.txtInputQtyCNC.Size = new System.Drawing.Size(136, 28);
            this.txtInputQtyCNC.TabIndex = 18;
            this.txtInputQtyCNC.TextChanged += new System.EventHandler(this.txtBoxInputQuantity_TextChanged);
            this.txtInputQtyCNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxInputQuantity_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsTab = true;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(167, 139);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(249, 118);
            this.txtDescription.TabIndex = 19;
            this.txtDescription.Text = "";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(386, 252);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 52);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReloadData
            // 
            this.btnReloadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReloadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadData.Location = new System.Drawing.Point(92, 194);
            this.btnReloadData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReloadData.Name = "btnReloadData";
            this.btnReloadData.Size = new System.Drawing.Size(139, 52);
            this.btnReloadData.TabIndex = 20;
            this.btnReloadData.Text = "RELOAD DATA";
            this.btnReloadData.UseVisualStyleBackColor = false;
            this.btnReloadData.Click += new System.EventHandler(this.btnReloadData_Click);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn.Location = new System.Drawing.Point(249, 252);
            this.btn.Margin = new System.Windows.Forms.Padding(4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(117, 52);
            this.btn.TabIndex = 21;
            this.btn.Text = "BACK";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtWOSearch);
            this.panel3.Controls.Add(this.txtPartNoSearch);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(547, 39);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 142);
            this.panel3.TabIndex = 22;
            // 
            // txtWOSearch
            // 
            this.txtWOSearch.AcceptsTab = true;
            this.txtWOSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWOSearch.Location = new System.Drawing.Point(132, 82);
            this.txtWOSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWOSearch.Name = "txtWOSearch";
            this.txtWOSearch.Size = new System.Drawing.Size(127, 28);
            this.txtWOSearch.TabIndex = 5;
            // 
            // txtPartNoSearch
            // 
            this.txtPartNoSearch.AcceptsTab = true;
            this.txtPartNoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartNoSearch.Location = new System.Drawing.Point(132, 27);
            this.txtPartNoSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPartNoSearch.Name = "txtPartNoSearch";
            this.txtPartNoSearch.Size = new System.Drawing.Size(153, 28);
            this.txtPartNoSearch.TabIndex = 4;
            this.txtPartNoSearch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "WO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "PART NO";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(386, 196);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(105, 52);
            this.btnExport.TabIndex = 23;
            this.btnExport.Text = "EXPORT EXCEL";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmCNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1924, 790);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnReloadData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvCNC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCNC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCNC";
            this.Load += new System.EventHandler(this.frmCNC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCNC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPartNum;
        private System.Windows.Forms.Label labelWO;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.TextBox txtWO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCNC;
        private System.Windows.Forms.Label labelInputQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDMR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtInputQtyCNC;
        private System.Windows.Forms.TextBox txtOutputQtyCNC;
        private System.Windows.Forms.TextBox txtDMR;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReloadData;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtWOSearch;
        private System.Windows.Forms.TextBox txtPartNoSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExport;
    }
}
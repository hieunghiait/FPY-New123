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
            this.textBoxPartNum = new System.Windows.Forms.TextBox();
            this.txtBoxWO = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCNC = new System.Windows.Forms.DataGridView();
            this.labelInputQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDMR = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxOutputQuantity = new System.Windows.Forms.TextBox();
            this.textBoxDMR = new System.Windows.Forms.TextBox();
            this.txtBoxInputQuantity = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCNC)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPartNum
            // 
            this.labelPartNum.AutoSize = true;
            this.labelPartNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartNum.Location = new System.Drawing.Point(32, 31);
            this.labelPartNum.Name = "labelPartNum";
            this.labelPartNum.Size = new System.Drawing.Size(70, 17);
            this.labelPartNum.TabIndex = 0;
            this.labelPartNum.Text = "PART NO";
            // 
            // labelWO
            // 
            this.labelWO.AutoSize = true;
            this.labelWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWO.Location = new System.Drawing.Point(32, 82);
            this.labelWO.Name = "labelWO";
            this.labelWO.Size = new System.Drawing.Size(32, 17);
            this.labelWO.TabIndex = 1;
            this.labelWO.Text = "WO";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(188, 203);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(91, 38);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "UPDATE";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(91, 203);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 38);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxPartNum
            // 
            this.textBoxPartNum.AcceptsTab = true;
            this.textBoxPartNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPartNum.Location = new System.Drawing.Point(132, 27);
            this.textBoxPartNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPartNum.Name = "textBoxPartNum";
            this.textBoxPartNum.Size = new System.Drawing.Size(153, 24);
            this.textBoxPartNum.TabIndex = 4;
            // 
            // txtBoxWO
            // 
            this.txtBoxWO.AcceptsTab = true;
            this.txtBoxWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWO.Location = new System.Drawing.Point(125, 82);
            this.txtBoxWO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxWO.Name = "txtBoxWO";
            this.txtBoxWO.Size = new System.Drawing.Size(127, 24);
            this.txtBoxWO.TabIndex = 5;
            this.txtBoxWO.TextChanged += new System.EventHandler(this.txtBoxWO_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBoxWO);
            this.panel1.Controls.Add(this.textBoxPartNum);
            this.panel1.Controls.Add(this.labelWO);
            this.panel1.Controls.Add(this.labelPartNum);
            this.panel1.Location = new System.Drawing.Point(56, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 142);
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
            this.dgvCNC.Location = new System.Drawing.Point(507, 39);
            this.dgvCNC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCNC.Name = "dgvCNC";
            this.dgvCNC.ReadOnly = true;
            this.dgvCNC.RowHeadersWidth = 51;
            this.dgvCNC.RowTemplate.Height = 24;
            this.dgvCNC.Size = new System.Drawing.Size(927, 615);
            this.dgvCNC.TabIndex = 7;
            this.dgvCNC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCNC_CellClick);
            this.dgvCNC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCNC_CellContentClick);
            // 
            // labelInputQuantity
            // 
            this.labelInputQuantity.AutoSize = true;
            this.labelInputQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputQuantity.Location = new System.Drawing.Point(25, 42);
            this.labelInputQuantity.Name = "labelInputQuantity";
            this.labelInputQuantity.Size = new System.Drawing.Size(82, 17);
            this.labelInputQuantity.TabIndex = 8;
            this.labelInputQuantity.Text = "INPUT QTY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "OUTPUT QTY";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(17, 178);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 17);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "DESCRIPTION";
            // 
            // labelDMR
            // 
            this.labelDMR.AutoSize = true;
            this.labelDMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDMR.Location = new System.Drawing.Point(17, 298);
            this.labelDMR.Name = "labelDMR";
            this.labelDMR.Size = new System.Drawing.Size(39, 17);
            this.labelDMR.TabIndex = 13;
            this.labelDMR.Text = "DMR";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxOutputQuantity);
            this.panel2.Controls.Add(this.textBoxDMR);
            this.panel2.Controls.Add(this.labelDescription);
            this.panel2.Controls.Add(this.txtBoxInputQuantity);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelDMR);
            this.panel2.Controls.Add(this.labelInputQuantity);
            this.panel2.Controls.Add(this.textBoxDescription);
            this.panel2.Location = new System.Drawing.Point(40, 265);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 353);
            this.panel2.TabIndex = 17;
            // 
            // textBoxOutputQuantity
            // 
            this.textBoxOutputQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutputQuantity.Location = new System.Drawing.Point(119, 81);
            this.textBoxOutputQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOutputQuantity.Name = "textBoxOutputQuantity";
            this.textBoxOutputQuantity.Size = new System.Drawing.Size(172, 24);
            this.textBoxOutputQuantity.TabIndex = 18;
            this.textBoxOutputQuantity.TextChanged += new System.EventHandler(this.textBoxOutputQuantity_TextChanged);
            this.textBoxOutputQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOutputQuantity_KeyPress);
            // 
            // textBoxDMR
            // 
            this.textBoxDMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.textBoxDMR.Location = new System.Drawing.Point(119, 291);
            this.textBoxDMR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDMR.Name = "textBoxDMR";
            this.textBoxDMR.Size = new System.Drawing.Size(96, 24);
            this.textBoxDMR.TabIndex = 18;
            this.textBoxDMR.TextChanged += new System.EventHandler(this.textBoxDMR_TextChanged);
            // 
            // txtBoxInputQuantity
            // 
            this.txtBoxInputQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInputQuantity.Location = new System.Drawing.Point(117, 39);
            this.txtBoxInputQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxInputQuantity.Name = "txtBoxInputQuantity";
            this.txtBoxInputQuantity.ReadOnly = true;
            this.txtBoxInputQuantity.Size = new System.Drawing.Size(136, 24);
            this.txtBoxInputQuantity.TabIndex = 18;
            this.txtBoxInputQuantity.TextChanged += new System.EventHandler(this.txtBoxInputQuantity_TextChanged);
            this.txtBoxInputQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxInputQuantity_KeyPress);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AcceptsTab = true;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(119, 143);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(249, 118);
            this.textBoxDescription.TabIndex = 19;
            this.textBoxDescription.Text = "";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1331, 660);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 35);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(294, 203);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 38);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmCNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1524, 726);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPartNum;
        private System.Windows.Forms.Label labelWO;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxPartNum;
        private System.Windows.Forms.TextBox txtBoxWO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCNC;
        private System.Windows.Forms.Label labelInputQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDMR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox textBoxDescription;
        private System.Windows.Forms.TextBox txtBoxInputQuantity;
        private System.Windows.Forms.TextBox textBoxOutputQuantity;
        private System.Windows.Forms.TextBox textBoxDMR;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
    }
}
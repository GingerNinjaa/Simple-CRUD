﻿
namespace UI.Stock
{
    partial class AllStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteArticle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AllStockDataGridView = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGoBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllStockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnDeleteArticle);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteArticle
            // 
            this.btnDeleteArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteArticle.ForeColor = System.Drawing.Color.White;
            this.btnDeleteArticle.Image = global::UI.Properties.Resources.trash_32px;
            this.btnDeleteArticle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteArticle.Location = new System.Drawing.Point(345, 4);
            this.btnDeleteArticle.Name = "btnDeleteArticle";
            this.btnDeleteArticle.Size = new System.Drawing.Size(180, 44);
            this.btnDeleteArticle.TabIndex = 3;
            this.btnDeleteArticle.Text = "Delete Article";
            this.btnDeleteArticle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteArticle.UseVisualStyleBackColor = true;
            this.btnDeleteArticle.Click += new System.EventHandler(this.btnDeleteArticle_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::UI.Properties.Resources.trash_32px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(132, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete Category";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllStockDataGridView
            // 
            this.AllStockDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllStockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AllStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllStockDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.AllStockDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllStockDataGridView.GridColor = System.Drawing.Color.Black;
            this.AllStockDataGridView.Location = new System.Drawing.Point(0, 50);
            this.AllStockDataGridView.Name = "AllStockDataGridView";
            this.AllStockDataGridView.ReadOnly = true;
            this.AllStockDataGridView.Size = new System.Drawing.Size(1084, 711);
            this.AllStockDataGridView.TabIndex = 2;
            this.AllStockDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AllStockDataGridView_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Image = global::UI.Properties.Resources.undo_32px;
            this.btnGoBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoBack.Location = new System.Drawing.Point(0, 3);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(126, 44);
            this.btnGoBack.TabIndex = 1;
            this.btnGoBack.Text = "Return";
            this.btnGoBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // AllStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.AllStockDataGridView);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllStock";
            this.Text = "AllStock";
            this.Load += new System.EventHandler(this.AllStock_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllStockDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.DataGridView AllStockDataGridView;
 //       private CompanyDBDataSet_Products companyDBDataSet_Products;
 //       private CompanyDBDataSet_ProductsTableAdapters.tblProductsTableAdapter tblProductsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDeleteArticle;
        /*
private System.Windows.Forms.DataGridView dataGridView1;
private CompanyDBDataSet1 companyDBDataSet1;
private System.Windows.Forms.BindingSource tblProductsBindingSource;
private Data.CompanyDBDataSet1TableAdapters.tblProductsTableAdapter tblProductsTableAdapter;
private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn imageNameDataGridViewTextBoxColumn;
// private CompanyDBDataSetTableAdapters.tblProductsTableAdapter tblProductsTableAdapter;
*/
    }
}
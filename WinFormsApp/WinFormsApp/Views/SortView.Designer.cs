namespace WinFormsApp
{
    partial class SortView
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
            txtValue = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            btnSort = new Button();
            label3 = new Label();
            cmbSortType = new ComboBox();
            label4 = new Label();
            lblOutput = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtValue
            // 
            txtValue.Dock = DockStyle.Fill;
            txtValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValue.Location = new Point(23, 136);
            txtValue.Multiline = true;
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(299, 74);
            txtValue.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtValue, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(btnSort, 0, 6);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(cmbSortType, 0, 5);
            tableLayoutPanel1.Controls.Add(label4, 0, 7);
            tableLayoutPanel1.Controls.Add(lblOutput, 0, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(345, 491);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(23, 108);
            label1.Name = "label1";
            label1.Size = new Size(299, 25);
            label1.TabIndex = 3;
            label1.Text = "Value:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 68);
            label2.Name = "label2";
            label2.Size = new Size(299, 40);
            label2.TabIndex = 2;
            label2.Text = "Text Sorting";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSort
            // 
            btnSort.Dock = DockStyle.Fill;
            btnSort.Location = new Point(23, 281);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(299, 34);
            btnSort.TabIndex = 6;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(23, 213);
            label3.Name = "label3";
            label3.Size = new Size(299, 25);
            label3.TabIndex = 5;
            label3.Text = "Sort Type:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbSortType
            // 
            cmbSortType.Dock = DockStyle.Fill;
            cmbSortType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSortType.FormattingEnabled = true;
            cmbSortType.Location = new Point(23, 241);
            cmbSortType.Name = "cmbSortType";
            cmbSortType.Size = new Size(299, 29);
            cmbSortType.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(23, 318);
            label4.Name = "label4";
            label4.Size = new Size(299, 25);
            label4.TabIndex = 7;
            label4.Text = "Output:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.BackColor = Color.White;
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.Dock = DockStyle.Fill;
            lblOutput.Location = new Point(23, 343);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(299, 80);
            lblOutput.TabIndex = 8;
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SortView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 491);
            Controls.Add(tableLayoutPanel1);
            Name = "SortView";
            Text = "Sort";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtValue;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private Button btnSort;
        private Label label3;
        private ComboBox cmbSortType;
        private Label label4;
        private Label lblOutput;
    }
}

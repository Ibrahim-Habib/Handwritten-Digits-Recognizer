namespace Handwritten_Digits_Recognizer
{
    partial class GUI
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
            this.confusionMatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.ClassificationMethodComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classifyButton = new System.Windows.Forms.Button();
            this.RowsHeaders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rejection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.confusionMatrixDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // confusionMatrixDataGridView
            // 
            this.confusionMatrixDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.confusionMatrixDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.confusionMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.confusionMatrixDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowsHeaders,
            this.Count,
            this.Class0,
            this.Class1,
            this.Class2,
            this.Class3,
            this.Class4,
            this.Class5,
            this.Class6,
            this.Class7,
            this.Class8,
            this.Class9,
            this.Rejection,
            this.Accuracy});
            this.confusionMatrixDataGridView.Location = new System.Drawing.Point(4, 91);
            this.confusionMatrixDataGridView.Name = "confusionMatrixDataGridView";
            this.confusionMatrixDataGridView.ReadOnly = true;
            this.confusionMatrixDataGridView.Size = new System.Drawing.Size(936, 316);
            this.confusionMatrixDataGridView.TabIndex = 0;
            // 
            // ClassificationMethodComboBox
            // 
            this.ClassificationMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassificationMethodComboBox.FormattingEnabled = true;
            this.ClassificationMethodComboBox.Items.AddRange(new object[] {
            "KNN",
            "Bayes"});
            this.ClassificationMethodComboBox.Location = new System.Drawing.Point(172, 38);
            this.ClassificationMethodComboBox.Name = "ClassificationMethodComboBox";
            this.ClassificationMethodComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassificationMethodComboBox.TabIndex = 1;
            this.ClassificationMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassificationMethodComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Classification Method";
            // 
            // classifyButton
            // 
            this.classifyButton.Location = new System.Drawing.Point(369, 27);
            this.classifyButton.Name = "classifyButton";
            this.classifyButton.Size = new System.Drawing.Size(85, 41);
            this.classifyButton.TabIndex = 3;
            this.classifyButton.Text = "Classify Test Images";
            this.classifyButton.UseVisualStyleBackColor = true;
            this.classifyButton.Click += new System.EventHandler(this.classifyButton_Click);
            // 
            // RowsHeaders
            // 
            this.RowsHeaders.HeaderText = "";
            this.RowsHeaders.Name = "RowsHeaders";
            this.RowsHeaders.ReadOnly = true;
            this.RowsHeaders.Width = 21;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 61;
            // 
            // Class0
            // 
            this.Class0.HeaderText = "Class 0";
            this.Class0.Name = "Class0";
            this.Class0.ReadOnly = true;
            this.Class0.Width = 66;
            // 
            // Class1
            // 
            this.Class1.HeaderText = "Class 1";
            this.Class1.Name = "Class1";
            this.Class1.ReadOnly = true;
            this.Class1.Width = 66;
            // 
            // Class2
            // 
            this.Class2.HeaderText = "Class 2";
            this.Class2.Name = "Class2";
            this.Class2.ReadOnly = true;
            this.Class2.Width = 66;
            // 
            // Class3
            // 
            this.Class3.HeaderText = "Class 3";
            this.Class3.Name = "Class3";
            this.Class3.ReadOnly = true;
            this.Class3.Width = 66;
            // 
            // Class4
            // 
            this.Class4.HeaderText = "Class 4";
            this.Class4.Name = "Class4";
            this.Class4.ReadOnly = true;
            this.Class4.Width = 66;
            // 
            // Class5
            // 
            this.Class5.HeaderText = "Class 5";
            this.Class5.Name = "Class5";
            this.Class5.ReadOnly = true;
            this.Class5.Width = 66;
            // 
            // Class6
            // 
            this.Class6.HeaderText = "Class 6";
            this.Class6.Name = "Class6";
            this.Class6.ReadOnly = true;
            this.Class6.Width = 66;
            // 
            // Class7
            // 
            this.Class7.HeaderText = "Class 7";
            this.Class7.Name = "Class7";
            this.Class7.ReadOnly = true;
            this.Class7.Width = 66;
            // 
            // Class8
            // 
            this.Class8.HeaderText = "Class 8";
            this.Class8.Name = "Class8";
            this.Class8.ReadOnly = true;
            this.Class8.Width = 66;
            // 
            // Class9
            // 
            this.Class9.HeaderText = "Class 9";
            this.Class9.Name = "Class9";
            this.Class9.ReadOnly = true;
            this.Class9.Width = 66;
            // 
            // Rejection
            // 
            this.Rejection.HeaderText = "Rejection";
            this.Rejection.Name = "Rejection";
            this.Rejection.ReadOnly = true;
            this.Rejection.Width = 77;
            // 
            // Accuracy
            // 
            this.Accuracy.HeaderText = "Accuracy";
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.ReadOnly = true;
            this.Accuracy.Width = 76;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 451);
            this.Controls.Add(this.classifyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassificationMethodComboBox);
            this.Controls.Add(this.confusionMatrixDataGridView);
            this.Name = "GUI";
            this.Text = "Handwritten Digits Recognizer";
            ((System.ComponentModel.ISupportInitialize)(this.confusionMatrixDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView confusionMatrixDataGridView;
        private System.Windows.Forms.ComboBox ClassificationMethodComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button classifyButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowsHeaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rejection;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accuracy;

    }
}


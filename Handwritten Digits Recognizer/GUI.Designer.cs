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
            this.ClassificationMethodComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classifyButton = new System.Windows.Forms.Button();
            this.confusionMatrixDataGridView = new System.Windows.Forms.DataGridView();
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
            this.overAllAccuracyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ClassificationGridView = new System.Windows.Forms.DataGridView();
            this.ImageNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.ExpectedClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.numOfSamplesTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.confusionMatrixDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassificationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassificationMethodComboBox
            // 
            this.ClassificationMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassificationMethodComboBox.FormattingEnabled = true;
            this.ClassificationMethodComboBox.Items.AddRange(new object[] {
            "Nearest Centroid",
            "KNN"});
            this.ClassificationMethodComboBox.Location = new System.Drawing.Point(171, 12);
            this.ClassificationMethodComboBox.Name = "ClassificationMethodComboBox";
            this.ClassificationMethodComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassificationMethodComboBox.TabIndex = 1;
            this.ClassificationMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassificationMethodComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 15);
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
            // confusionMatrixDataGridView
            // 
            this.confusionMatrixDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.confusionMatrixDataGridView.Location = new System.Drawing.Point(3, 3);
            this.confusionMatrixDataGridView.Name = "confusionMatrixDataGridView";
            this.confusionMatrixDataGridView.ReadOnly = true;
            this.confusionMatrixDataGridView.Size = new System.Drawing.Size(959, 379);
            this.confusionMatrixDataGridView.TabIndex = 5;
            // 
            // RowsHeaders
            // 
            this.RowsHeaders.HeaderText = "";
            this.RowsHeaders.Name = "RowsHeaders";
            this.RowsHeaders.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // Class0
            // 
            this.Class0.HeaderText = "Class 0";
            this.Class0.Name = "Class0";
            this.Class0.ReadOnly = true;
            // 
            // Class1
            // 
            this.Class1.HeaderText = "Class 1";
            this.Class1.Name = "Class1";
            this.Class1.ReadOnly = true;
            // 
            // Class2
            // 
            this.Class2.HeaderText = "Class 2";
            this.Class2.Name = "Class2";
            this.Class2.ReadOnly = true;
            // 
            // Class3
            // 
            this.Class3.HeaderText = "Class 3";
            this.Class3.Name = "Class3";
            this.Class3.ReadOnly = true;
            // 
            // Class4
            // 
            this.Class4.HeaderText = "Class 4";
            this.Class4.Name = "Class4";
            this.Class4.ReadOnly = true;
            // 
            // Class5
            // 
            this.Class5.HeaderText = "Class 5";
            this.Class5.Name = "Class5";
            this.Class5.ReadOnly = true;
            // 
            // Class6
            // 
            this.Class6.HeaderText = "Class 6";
            this.Class6.Name = "Class6";
            this.Class6.ReadOnly = true;
            // 
            // Class7
            // 
            this.Class7.HeaderText = "Class 7";
            this.Class7.Name = "Class7";
            this.Class7.ReadOnly = true;
            // 
            // Class8
            // 
            this.Class8.HeaderText = "Class 8";
            this.Class8.Name = "Class8";
            this.Class8.ReadOnly = true;
            // 
            // Class9
            // 
            this.Class9.HeaderText = "Class 9";
            this.Class9.Name = "Class9";
            this.Class9.ReadOnly = true;
            // 
            // Rejection
            // 
            this.Rejection.HeaderText = "Rejection";
            this.Rejection.Name = "Rejection";
            this.Rejection.ReadOnly = true;
            // 
            // Accuracy
            // 
            this.Accuracy.HeaderText = "Accuracy";
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.ReadOnly = true;
            // 
            // overAllAccuracyTextBox
            // 
            this.overAllAccuracyTextBox.Location = new System.Drawing.Point(798, 35);
            this.overAllAccuracyTextBox.Name = "overAllAccuracyTextBox";
            this.overAllAccuracyTextBox.ReadOnly = true;
            this.overAllAccuracyTextBox.Size = new System.Drawing.Size(100, 20);
            this.overAllAccuracyTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Overall Accuracy";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 381);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.confusionMatrixDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(965, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Confusion Matrix";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ClassificationGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(965, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Classification Result";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ClassificationGridView
            // 
            this.ClassificationGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassificationGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ClassificationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageNumber,
            this.Picture,
            this.ExpectedClass,
            this.Result});
            this.ClassificationGridView.Location = new System.Drawing.Point(6, 3);
            this.ClassificationGridView.Name = "ClassificationGridView";
            this.ClassificationGridView.ReadOnly = true;
            this.ClassificationGridView.Size = new System.Drawing.Size(956, 346);
            this.ClassificationGridView.TabIndex = 0;
            // 
            // ImageNumber
            // 
            this.ImageNumber.FillWeight = 101.2866F;
            this.ImageNumber.HeaderText = "Image #";
            this.ImageNumber.Name = "ImageNumber";
            this.ImageNumber.ReadOnly = true;
            // 
            // Picture
            // 
            this.Picture.FillWeight = 187.9429F;
            this.Picture.HeaderText = "Picture";
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ExpectedClass
            // 
            this.ExpectedClass.FillWeight = 56.85279F;
            this.ExpectedClass.HeaderText = "Expected Classification";
            this.ExpectedClass.Name = "ExpectedClass";
            this.ExpectedClass.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.FillWeight = 53.91778F;
            this.Result.HeaderText = "Classification Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of Testing Images";
            // 
            // numOfSamplesTextBox
            // 
            this.numOfSamplesTextBox.Location = new System.Drawing.Point(181, 39);
            this.numOfSamplesTextBox.Name = "numOfSamplesTextBox";
            this.numOfSamplesTextBox.Size = new System.Drawing.Size(100, 20);
            this.numOfSamplesTextBox.TabIndex = 10;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 459);
            this.Controls.Add(this.numOfSamplesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.overAllAccuracyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classifyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassificationMethodComboBox);
            this.Name = "GUI";
            this.Text = "Handwritten Digits Recognizer";
            ((System.ComponentModel.ISupportInitialize)(this.confusionMatrixDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassificationGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassificationMethodComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button classifyButton;
        private System.Windows.Forms.DataGridView confusionMatrixDataGridView;
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
        private System.Windows.Forms.TextBox overAllAccuracyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ClassificationGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageNumber;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numOfSamplesTextBox;

    }
}


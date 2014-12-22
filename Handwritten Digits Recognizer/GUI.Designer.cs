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
            this.KTextBox = new System.Windows.Forms.TextBox();
            this.Klabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.confusionMatrixDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // confusionMatrixDataGridView
            // 
            this.confusionMatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.confusionMatrixDataGridView.Location = new System.Drawing.Point(4, 91);
            this.confusionMatrixDataGridView.Name = "confusionMatrixDataGridView";
            this.confusionMatrixDataGridView.ReadOnly = true;
            this.confusionMatrixDataGridView.Size = new System.Drawing.Size(631, 356);
            this.confusionMatrixDataGridView.TabIndex = 0;
            // 
            // ClassificationMethodComboBox
            // 
            this.ClassificationMethodComboBox.FormattingEnabled = true;
            this.ClassificationMethodComboBox.Items.AddRange(new object[] {
            "KNN"});
            this.ClassificationMethodComboBox.Location = new System.Drawing.Point(174, 24);
            this.ClassificationMethodComboBox.Name = "ClassificationMethodComboBox";
            this.ClassificationMethodComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassificationMethodComboBox.TabIndex = 1;
            this.ClassificationMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassificationMethodComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
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
            // KTextBox
            // 
            this.KTextBox.Location = new System.Drawing.Point(200, 51);
            this.KTextBox.Name = "KTextBox";
            this.KTextBox.Size = new System.Drawing.Size(67, 20);
            this.KTextBox.TabIndex = 4;
            // 
            // Klabel
            // 
            this.Klabel.AutoSize = true;
            this.Klabel.Location = new System.Drawing.Point(127, 55);
            this.Klabel.Name = "Klabel";
            this.Klabel.Size = new System.Drawing.Size(13, 13);
            this.Klabel.TabIndex = 5;
            this.Klabel.Text = "K";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 452);
            this.Controls.Add(this.Klabel);
            this.Controls.Add(this.KTextBox);
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
        private System.Windows.Forms.TextBox KTextBox;
        private System.Windows.Forms.Label Klabel;

    }
}


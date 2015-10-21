namespace ElectricityBillCalculatorApp
{
    partial class ElectricityUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.previousUnitTextBox = new System.Windows.Forms.TextBox();
            this.currentUnitTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.totalUnitConsumedButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.detailsDataGridView = new System.Windows.Forms.DataGridView();
            this.totalUnitConsumedLabel = new System.Windows.Forms.Label();
            this.totalBillPayableLabel = new System.Windows.Forms.Label();
            this.electricityChargesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Previous Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Current Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Previous Units";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Current Units";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(110, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(429, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // previousUnitTextBox
            // 
            this.previousUnitTextBox.Location = new System.Drawing.Point(409, 53);
            this.previousUnitTextBox.Name = "previousUnitTextBox";
            this.previousUnitTextBox.Size = new System.Drawing.Size(130, 20);
            this.previousUnitTextBox.TabIndex = 2;
            this.previousUnitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // currentUnitTextBox
            // 
            this.currentUnitTextBox.Location = new System.Drawing.Point(409, 89);
            this.currentUnitTextBox.Name = "currentUnitTextBox";
            this.currentUnitTextBox.Size = new System.Drawing.Size(130, 20);
            this.currentUnitTextBox.TabIndex = 4;
            this.currentUnitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(110, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // totalUnitConsumedButton
            // 
            this.totalUnitConsumedButton.Location = new System.Drawing.Point(26, 129);
            this.totalUnitConsumedButton.Name = "totalUnitConsumedButton";
            this.totalUnitConsumedButton.Size = new System.Drawing.Size(263, 23);
            this.totalUnitConsumedButton.TabIndex = 5;
            this.totalUnitConsumedButton.Text = "Total Unit Consumed";
            this.totalUnitConsumedButton.UseVisualStyleBackColor = true;
            this.totalUnitConsumedButton.Click += new System.EventHandler(this.totalUnitConsumedButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(26, 187);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(513, 23);
            this.detailsButton.TabIndex = 8;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // detailsDataGridView
            // 
            this.detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsDataGridView.Location = new System.Drawing.Point(26, 225);
            this.detailsDataGridView.Name = "detailsDataGridView";
            this.detailsDataGridView.Size = new System.Drawing.Size(513, 198);
            this.detailsDataGridView.TabIndex = 5;
            // 
            // totalUnitConsumedLabel
            // 
            this.totalUnitConsumedLabel.AutoSize = true;
            this.totalUnitConsumedLabel.Location = new System.Drawing.Point(443, 134);
            this.totalUnitConsumedLabel.Name = "totalUnitConsumedLabel";
            this.totalUnitConsumedLabel.Size = new System.Drawing.Size(0, 13);
            this.totalUnitConsumedLabel.TabIndex = 6;
            // 
            // totalBillPayableLabel
            // 
            this.totalBillPayableLabel.AutoSize = true;
            this.totalBillPayableLabel.Location = new System.Drawing.Point(443, 163);
            this.totalBillPayableLabel.Name = "totalBillPayableLabel";
            this.totalBillPayableLabel.Size = new System.Drawing.Size(0, 13);
            this.totalBillPayableLabel.TabIndex = 6;
            // 
            // electricityChargesButton
            // 
            this.electricityChargesButton.Location = new System.Drawing.Point(26, 158);
            this.electricityChargesButton.Name = "electricityChargesButton";
            this.electricityChargesButton.Size = new System.Drawing.Size(263, 23);
            this.electricityChargesButton.TabIndex = 7;
            this.electricityChargesButton.Text = "Electricity Charges Information";
            this.electricityChargesButton.UseVisualStyleBackColor = true;
            this.electricityChargesButton.Click += new System.EventHandler(this.electricityChargesButton_Click);
            // 
            // ElectricityUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 472);
            this.Controls.Add(this.totalBillPayableLabel);
            this.Controls.Add(this.totalUnitConsumedLabel);
            this.Controls.Add(this.detailsDataGridView);
            this.Controls.Add(this.electricityChargesButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.totalUnitConsumedButton);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.currentUnitTextBox);
            this.Controls.Add(this.previousUnitTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ElectricityUI";
            this.Text = "Electricity Bill Calculator";
        
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox previousUnitTextBox;
        private System.Windows.Forms.TextBox currentUnitTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button totalUnitConsumedButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.DataGridView detailsDataGridView;
        private System.Windows.Forms.Label totalUnitConsumedLabel;
        private System.Windows.Forms.Label totalBillPayableLabel;
        private System.Windows.Forms.Button electricityChargesButton;
    }
}


namespace PlanetExample
{
    partial class Form1
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
            this.planetNameComboBox = new System.Windows.Forms.ComboBox();
            this.showPlanetNumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planet Name";
            // 
            // planetNameComboBox
            // 
            this.planetNameComboBox.FormattingEnabled = true;
            this.planetNameComboBox.Items.AddRange(new object[] {
            "Planet",
            "Satan",
            "Mars",
            "etc",
            "others"});
            this.planetNameComboBox.Location = new System.Drawing.Point(117, 29);
            this.planetNameComboBox.Name = "planetNameComboBox";
            this.planetNameComboBox.Size = new System.Drawing.Size(147, 21);
            this.planetNameComboBox.TabIndex = 1;
            // 
            // showPlanetNumberButton
            // 
            this.showPlanetNumberButton.Location = new System.Drawing.Point(117, 77);
            this.showPlanetNumberButton.Name = "showPlanetNumberButton";
            this.showPlanetNumberButton.Size = new System.Drawing.Size(147, 23);
            this.showPlanetNumberButton.TabIndex = 2;
            this.showPlanetNumberButton.Text = "Show Planet Number";
            this.showPlanetNumberButton.UseVisualStyleBackColor = true;
            this.showPlanetNumberButton.Click += new System.EventHandler(this.showPlanetNumberButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 143);
            this.Controls.Add(this.showPlanetNumberButton);
            this.Controls.Add(this.planetNameComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox planetNameComboBox;
        private System.Windows.Forms.Button showPlanetNumberButton;
    }
}


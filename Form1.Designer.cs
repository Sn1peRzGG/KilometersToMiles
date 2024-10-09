using System.Windows.Forms;

namespace KilometersToMiles
{
    partial class ConverterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.radioMilesToKm = new System.Windows.Forms.RadioButton();
            this.radioKmToMiles = new System.Windows.Forms.RadioButton();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioMilesToKm
            // 
            this.radioMilesToKm.AutoSize = true;
            this.radioMilesToKm.Location = new System.Drawing.Point(80, 50);
            this.radioMilesToKm.Name = "radioMilesToKm";
            this.radioMilesToKm.Size = new System.Drawing.Size(140, 20);
            this.radioMilesToKm.TabIndex = 0;
            this.radioMilesToKm.TabStop = true;
            this.radioMilesToKm.Text = "Miles to Kilometers";
            this.radioMilesToKm.UseVisualStyleBackColor = true;
            // 
            // radioKmToMiles
            // 
            this.radioKmToMiles.AutoSize = true;
            this.radioKmToMiles.Location = new System.Drawing.Point(80, 80);
            this.radioKmToMiles.Name = "radioKmToMiles";
            this.radioKmToMiles.Size = new System.Drawing.Size(140, 20);
            this.radioKmToMiles.TabIndex = 1;
            this.radioKmToMiles.TabStop = true;
            this.radioKmToMiles.Text = "Kilometers to Miles";
            this.radioKmToMiles.UseVisualStyleBackColor = true;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(50, 120);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(200, 22);
            this.inputTextBox.TabIndex = 2;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(50, 170);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(90, 30);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(160, 170);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 30);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(50, 150);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 16);
            this.resultLabel.TabIndex = 5;
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 240);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.radioKmToMiles);
            this.Controls.Add(this.radioMilesToKm);
            this.Name = "ConverterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioMilesToKm;
        private System.Windows.Forms.RadioButton radioKmToMiles;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

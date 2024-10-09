using System;
using System.Windows.Forms;

namespace KilometersToMiles
{
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            InitializeComponent();
            inputTextBox.KeyDown += new KeyEventHandler(inputTextBox_KeyDown);
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                double inputValue = double.Parse(inputTextBox.Text);
                double result;

                if (radioMilesToKm.Checked)
                {
                    result = inputValue * 1.60934;
                    resultLabel.Text = $"{inputValue} miles = {result:F2} km";
                }
                else if (radioKmToMiles.Checked)
                {
                    result = inputValue / 1.60934;
                    resultLabel.Text = $"{inputValue} km = {result:F2} miles";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter the correct number", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = string.Empty;
            resultLabel.Text = string.Empty;
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                convertButton_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete)
            {
                clearButton_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
        }
    }
}

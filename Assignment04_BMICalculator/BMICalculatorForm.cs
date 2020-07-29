using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment04_BMICalculator
{
  public partial class BmiCalculatorForm : Form
  {
    public BmiCalculatorForm()
    {
      InitializeComponent();
    }
    private double _weightInPounds;
    private double _weightInKgs;
    private double _heightInInches;
    private double _heightInMeters;
    private double _bmi;

    private void MetricCalculation(double weightInKgs, double heightInMeters)
    {
      _weightInKgs = weightInKgs;
      _heightInMeters = heightInMeters;
      _bmi = (weightInKgs) / Math.Pow(heightInMeters,2);
      BmiResultScale(_bmi);
      BMITextBox.Text = _bmi.ToString("F");
    }

    private void ImperialCalculation(double weightInPounds, double heightInInches)
    {
      _weightInPounds = weightInPounds;
      _heightInInches = heightInInches;
      _bmi = (weightInPounds * 703) / (heightInInches * heightInInches);
      BmiResultScale(_bmi);
      BMITextBox.Text = _bmi.ToString("F");

    }

    private void CalculateBmiButton_Click(object sender, EventArgs e)
    {
      CalculateBmiButton.Enabled = false;
      ResetButton.Enabled = true;
      if (MetricRadioButton.Checked)
      {
        MetricCalculation(double.Parse(WeightTextBox.Text), double.Parse(HeightTextBox.Text));
      }
      else if (ImperialRadioButton.Checked)
      {
        ImperialCalculation(double.Parse(WeightTextBox.Text), double.Parse(HeightTextBox.Text));

      }
    }
    public enum BarColor{Yellow,Green,Orange,Red}
    private void BmiResultScale(double _bmi)
    {
      if (_bmi < 18.5)
      {
        BmiResultTextBox.Text = (ScaleMessage.Underweight.ToString());
        BmiResultTextBox.ForeColor=Color.Black;
        BmiResultTextBox.BackColor = Color.Yellow;
        BMIResultProgressBar.ForeColor = Color.Yellow;
        BMIResultProgressBar.Value = 25;
      }
      else if ((_bmi >= 18.5) && (_bmi <= 24.9))
      {
        BmiResultTextBox.Text = (ScaleMessage.Normal.ToString());
        BmiResultTextBox.ForeColor = Color.Black;
        BmiResultTextBox.BackColor = Color.Green;
        BMIResultProgressBar.ForeColor = Color.Green;
        BMIResultProgressBar.Value = 50;
      }
      else if ((_bmi >= 25) && (_bmi <= 29.9))
      {
        BmiResultTextBox.Text = (ScaleMessage.Overweight.ToString());
        BmiResultTextBox.ForeColor = Color.Black;
        BmiResultTextBox.BackColor = Color.Orange;
        BMIResultProgressBar.ForeColor = Color.Orange;
        BMIResultProgressBar.Value = 65;
      }
      else if (_bmi >= 30)
      {
        BmiResultTextBox.Text = (ScaleMessage.Obese.ToString());
        BmiResultTextBox.ForeColor = Color.Black;
        BmiResultTextBox.BackColor = Color.Red;
        BMIResultProgressBar.ForeColor = Color.Red;
        BMIResultProgressBar.Value = 100;
      }
    }

    private void ClearFormData()
    {
      BMITextBox.Text = "BMI";
      BMITextBox.ForeColor = Color.Gray;
      BmiResultTextBox.Text = "Scale";
      BmiResultTextBox.BackColor = Color.FromName("White");
      BmiResultTextBox.ForeColor = Color.Gray;
      BMIResultProgressBar.Minimum = 0;
      BMIResultProgressBar.Maximum = 100;
      BMIResultProgressBar.Value = 0;
    }

    private void ResetFormData()
    {
      ImperialRadioButton.Checked = false;
      MetricRadioButton.Checked = false;
      HeightTextBox.Text = "0";
      WeightTextBox.Text = "0";
      CalculateBmiButton.Enabled = false;
      ResetButton.Enabled = false;
      BMITextBox.Text = "0";
      BmiResultTextBox.Text = "0";
      ClearFormData();
      ApplicationMessage("Form has been reset", "Body Mass Index Calculator");
    }
    private void ResetButton_Click(object sender, EventArgs e)
    {
      ResetFormData();
    }

    private void ImperialRadioButton_CheckedChange(object sender, EventArgs e)
    {
      if (ImperialRadioButton.Checked)
      {
        MetricRadioButton.Checked = false;
      }
      HeightTextBox.Text = "Inches";
      HeightTextBox.ForeColor = Color.Gray;
      HeightTextBox.Enabled= true;
      WeightTextBox.Text = "Pounds";
      WeightTextBox.ForeColor = Color.Gray;
      WeightTextBox.Enabled = true;
      CalculateBmiButton.Enabled = false;
      ClearFormData();
    }
    private void MetricRadioButton_CheckedChange(object sender, EventArgs e)
    {
      if (MetricRadioButton.Checked)
      {
        ImperialRadioButton.Checked = false;
      }
      HeightTextBox.Text = "Meters";
      HeightTextBox.ForeColor = Color.Gray;
      HeightTextBox.Enabled = true;
      WeightTextBox.Text = "Kgs";
      WeightTextBox.ForeColor = Color.Gray;
      WeightTextBox.Enabled = true;
      CalculateBmiButton.Enabled = false;
      ClearFormData();
    }
    private void HeightTextBox_Click(object sender, EventArgs e)
    {
      HeightTextBox.SelectAll();
    }
    private void WeightTextBox_Click(object sender, EventArgs e)
    {
      WeightTextBox.SelectAll();
    }
    private void HeightTextBox_TextChanged(object sender, EventArgs e)
    {
      if (HeightTextBox.Text == String.Empty|| WeightTextBox.Text == String.Empty)
      {
        CalculateBmiButton.Enabled = false;
        ResetButton.Enabled = true;
      }
      else
      {
        CalculateBmiButton.Enabled = true;
        ResetButton.Enabled = false;
      }
    }
    private void WeightTextBox_TextChanged(object sender, EventArgs e)
    {
      if (WeightTextBox.Text == String.Empty|| HeightTextBox.Text == String.Empty)
      {
        CalculateBmiButton.Enabled = false;
        ResetButton.Enabled = true;
      }
      else
      {
        CalculateBmiButton.Enabled = true;
        ResetButton.Enabled = false;
      }
    }
    private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsLetter(e.KeyChar))
      {
        ApplicationMessage("Enter a Numeric Value", "Body Mass Index Calculator");
        e.Handled = true;
      }
    }
    private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsLetter(e.KeyChar))
      {
        ApplicationMessage("Enter a Numeric Value", "Body Mass Index Calculator");
        e.Handled = true;
      }
    }
    private void ApplicationMessage(string message, string title)
    {
      MessageBox.Show(message, title,
        MessageBoxButtons.OK,
        MessageBoxIcon.Error);
    }
    private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
  }
}
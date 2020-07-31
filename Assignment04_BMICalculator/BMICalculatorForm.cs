using System;
using System.Drawing;
using System.Windows.Forms;
/*Name=Sukhjinder Kaur 
 *Student number= 301087895
 *Date last Modified= 29/07/2020
 *Program description= Body Mass Index Calculator which allows user to calculate BMI as per Imperial
 * or Metric units and display their body scale(Normal,Underweight,Overweight,Obese) as per BMI.
 */
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

    /// <summary>
    /// This methods calculates the BMI as per the Metric units
    /// </summary>
    /// <param name="weightInKgs"></param>
    /// <param name="heightInMeters"></param>
    private void MetricCalculation(double weightInKgs, double heightInMeters)
    {
      _weightInKgs = weightInKgs;
      _heightInMeters = heightInMeters;
      _bmi = (weightInKgs) / Math.Pow(heightInMeters, 2);
      BmiResultScale(_bmi);
      BMITextBox.Text = _bmi.ToString("F");
    }

    /// <summary>
    ///  This methods calculates the BMI as per the Imperial units
    /// </summary>
    /// <param name="weightInPounds"></param>
    /// <param name="heightInInches"></param>
    private void ImperialCalculation(double weightInPounds, double heightInInches)
    {
      _weightInPounds = weightInPounds;
      _heightInInches = heightInInches;
      _bmi = (weightInPounds * 703) / (heightInInches * heightInInches);
      BmiResultScale(_bmi);
      BMITextBox.Text = _bmi.ToString("F");

    }

    /// <summary>
    /// This method calculates and displays the body mass index when clicked on CalculateBmiButton as per the checked Imperial or Metric Unit.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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

    /// <summary>
    /// This methods displays the Body scale with color as per the BMI calculated (in the above method)
    /// also shows the progress of progressbar 
    /// </summary>
    /// <param name="_bmi"></param>
    private void BmiResultScale(double _bmi)
    {
      if (_bmi < 18.5)
      {
        BmiResultTextBox.Text = (ScaleMessage.Underweight.ToString());
        BmiResultTextBox.ForeColor = Color.Black;
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

    /// <summary>
    /// This method clear the data from the form
    /// </summary>
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

    /// <summary>
    /// This method reset the form for the new inputs
    /// </summary>
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

    /// <summary>
    /// This method call the ResetFormData() and rests the form when Reset button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ResetButton_Click(object sender, EventArgs e)
    {
      ResetFormData();
    }

    /// <summary>
    /// The ImperialRadioButton_CheckedChange() and MetricRadioButton_CheckedChange are the checked event handlers when clicked
    /// changes the calculation text in the form for user convenience keeps the bmi button disabled until the values are
    /// entered in the form and then finally clear form data for fresh use. 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ImperialRadioButton_CheckedChange(object sender, EventArgs e)
    {
      if (ImperialRadioButton.Checked)
      {
        MetricRadioButton.Checked = false;
      }

      HeightTextBox.Text = "Inches";
      HeightTextBox.ForeColor = Color.Gray;
      HeightTextBox.Enabled = true;
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

    /// <summary>
    /// HeightTextBox_Click and WeightTextBox_Click are the click event handlers for the text boxes which allows
    /// to select the text in the text box so the user don't have to use the backspace or delete option
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HeightTextBox_Click(object sender, EventArgs e)
    {
      HeightTextBox.SelectAll();
    }

    private void WeightTextBox_Click(object sender, EventArgs e)
    {
      WeightTextBox.SelectAll();
    }

    /// <summary>
    /// HeightTextBox_TextChanged and WeightTextBox_TextChanged are the text changed event handlers which disables
    /// the BMI calculate button if the text boxes are empty and enables the Rest button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HeightTextBox_TextChanged(object sender, EventArgs e)
    {
      if (HeightTextBox.Text == String.Empty || WeightTextBox.Text == String.Empty)
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
      if (WeightTextBox.Text == String.Empty || HeightTextBox.Text == String.Empty)
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

    /// <summary>
    /// This methods shows the alert messages dialog box where it shows the error message
    /// and displays the button to close the dialog box
    /// </summary>
    /// <param name="message"></param>
    /// <param name="title"></param>
    private void ApplicationMessage(string message, string title)
    {
      MessageBox.Show(message, title,
        MessageBoxButtons.OK,
        MessageBoxIcon.Error);
    }

    /// <summary>
    /// HeightTextBox_KeyPress and WeightTextBox_KeyPress are the keypress event handlers which do not allow
    /// the user to enter a letter or a negative value .
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
      {
        ApplicationMessage("Enter a Numeric Value", "Body Mass Index Calculator");
        e.Handled = true;
      }
    }

    private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
      {
        ApplicationMessage("Enter a Numeric Value", "Body Mass Index Calculator");
        e.Handled = true;
      }
    }
    private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
  }
}
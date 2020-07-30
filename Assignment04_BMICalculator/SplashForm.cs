using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment04_BMICalculator
{/*Name=Sukhjinder Kaur 
 *Student number= 301087895
 *Date last Modified= 29/07/2020
 *Program description= Splash screen loading for 3000 milliseconds which welcomes the user into application
 */

  public partial class SplashForm : Form
  {
    public SplashForm()
    {
      InitializeComponent();
    }

    private void SpalshFormTimer_Tick(object sender, EventArgs e)
    {
      Program.bmiCalculatorForm.Show();
      this.Hide();
      SpalshFormTimer.Enabled = false;
    }
  }
}
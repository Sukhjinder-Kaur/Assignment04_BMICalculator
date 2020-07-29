using System;
using System.Windows.Forms;

namespace Assignment04_BMICalculator
{
  static class Program
  {
    public static SplashForm splashForm;
    public static BmiCalculatorForm bmiCalculatorForm;
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      splashForm=new SplashForm();
      bmiCalculatorForm=new BmiCalculatorForm();
      Application.Run(splashForm);
    }
  }
}

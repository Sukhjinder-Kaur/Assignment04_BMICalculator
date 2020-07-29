using System.ComponentModel;
using System.Windows.Forms;

namespace Assignment04_BMICalculator
{
  partial class BmiCalculatorForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
      this.BMITableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.WeightTextBox = new System.Windows.Forms.TextBox();
      this.MetricRadioButton = new System.Windows.Forms.RadioButton();
      this.HeightLabel = new System.Windows.Forms.Label();
      this.YourBmiLabel = new System.Windows.Forms.Label();
      this.CalculateBmiButton = new System.Windows.Forms.Button();
      this.ResetButton = new System.Windows.Forms.Button();
      this.HeightTextBox = new System.Windows.Forms.TextBox();
      this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
      this.WeightLabel = new System.Windows.Forms.Label();
      this.BMIResultProgressBar = new System.Windows.Forms.ProgressBar();
      this.Scale = new System.Windows.Forms.Label();
      this.BMITextBox = new System.Windows.Forms.TextBox();
      this.BmiResultTextBox = new System.Windows.Forms.TextBox();
      this.HeadLabel = new System.Windows.Forms.Label();
      this.BMITableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // BMITableLayoutPanel
      // 
      this.BMITableLayoutPanel.ColumnCount = 2;
      this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.39189F));
      this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.60811F));
      this.BMITableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 2);
      this.BMITableLayoutPanel.Controls.Add(this.MetricRadioButton, 1, 0);
      this.BMITableLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
      this.BMITableLayoutPanel.Controls.Add(this.YourBmiLabel, 0, 4);
      this.BMITableLayoutPanel.Controls.Add(this.CalculateBmiButton, 0, 3);
      this.BMITableLayoutPanel.Controls.Add(this.ResetButton, 1, 3);
      this.BMITableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 1);
      this.BMITableLayoutPanel.Controls.Add(this.ImperialRadioButton, 0, 0);
      this.BMITableLayoutPanel.Controls.Add(this.WeightLabel, 0, 2);
      this.BMITableLayoutPanel.Controls.Add(this.BMIResultProgressBar, 0, 6);
      this.BMITableLayoutPanel.Controls.Add(this.Scale, 0, 5);
      this.BMITableLayoutPanel.Controls.Add(this.BMITextBox, 1, 4);
      this.BMITableLayoutPanel.Controls.Add(this.BmiResultTextBox, 1, 5);
      this.BMITableLayoutPanel.Location = new System.Drawing.Point(3, 83);
      this.BMITableLayoutPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.BMITableLayoutPanel.Name = "BMITableLayoutPanel";
      this.BMITableLayoutPanel.RowCount = 7;
      this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.96407F));
      this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.47573F));
      this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.21036F));
      this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
      this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.BMITableLayoutPanel.Size = new System.Drawing.Size(296, 345);
      this.BMITableLayoutPanel.TabIndex = 0;
      // 
      // WeightTextBox
      // 
      this.WeightTextBox.Location = new System.Drawing.Point(168, 109);
      this.WeightTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.WeightTextBox.Name = "WeightTextBox";
      this.WeightTextBox.Size = new System.Drawing.Size(120, 53);
      this.WeightTextBox.TabIndex = 10;
      this.WeightTextBox.Click += new System.EventHandler(this.WeightTextBox_Click);
      this.WeightTextBox.TextChanged += new System.EventHandler(this.WeightTextBox_TextChanged);
      this.WeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightTextBox_KeyPress);
      // 
      // MetricRadioButton
      // 
      this.MetricRadioButton.AutoSize = true;
      this.MetricRadioButton.Location = new System.Drawing.Point(168, 7);
      this.MetricRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.MetricRadioButton.Name = "MetricRadioButton";
      this.MetricRadioButton.Size = new System.Drawing.Size(120, 37);
      this.MetricRadioButton.TabIndex = 6;
      this.MetricRadioButton.TabStop = true;
      this.MetricRadioButton.Text = "Metric";
      this.MetricRadioButton.UseVisualStyleBackColor = true;
      this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChange);
      // 
      // HeightLabel
      // 
      this.HeightLabel.AutoSize = true;
      this.HeightLabel.Location = new System.Drawing.Point(8, 51);
      this.HeightLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.HeightLabel.Name = "HeightLabel";
      this.HeightLabel.Size = new System.Drawing.Size(135, 51);
      this.HeightLabel.TabIndex = 1;
      this.HeightLabel.Text = "My Height";
      // 
      // YourBmiLabel
      // 
      this.YourBmiLabel.AutoSize = true;
      this.YourBmiLabel.Location = new System.Drawing.Point(8, 208);
      this.YourBmiLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.YourBmiLabel.Name = "YourBmiLabel";
      this.YourBmiLabel.Size = new System.Drawing.Size(115, 54);
      this.YourBmiLabel.TabIndex = 3;
      this.YourBmiLabel.Text = "Your BMI";
      // 
      // CalculateBmiButton
      // 
      this.CalculateBmiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CalculateBmiButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.CalculateBmiButton.Location = new System.Drawing.Point(8, 160);
      this.CalculateBmiButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.CalculateBmiButton.Name = "CalculateBmiButton";
      this.CalculateBmiButton.Size = new System.Drawing.Size(139, 41);
      this.CalculateBmiButton.TabIndex = 7;
      this.CalculateBmiButton.Text = "BMI";
      this.CalculateBmiButton.UseVisualStyleBackColor = true;
      this.CalculateBmiButton.Click += new System.EventHandler(this.CalculateBmiButton_Click);
      // 
      // ResetButton
      // 
      this.ResetButton.Location = new System.Drawing.Point(168, 160);
      this.ResetButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.ResetButton.Name = "ResetButton";
      this.ResetButton.Size = new System.Drawing.Size(120, 41);
      this.ResetButton.TabIndex = 8;
      this.ResetButton.Text = "Reset";
      this.ResetButton.UseVisualStyleBackColor = true;
      this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
      // 
      // HeightTextBox
      // 
      this.HeightTextBox.Location = new System.Drawing.Point(168, 58);
      this.HeightTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.HeightTextBox.Name = "HeightTextBox";
      this.HeightTextBox.Size = new System.Drawing.Size(120, 53);
      this.HeightTextBox.TabIndex = 9;
      this.HeightTextBox.Click += new System.EventHandler(this.HeightTextBox_Click);
      this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
      this.HeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightTextBox_KeyPress);
      // 
      // ImperialRadioButton
      // 
      this.ImperialRadioButton.AutoSize = true;
      this.ImperialRadioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ImperialRadioButton.Location = new System.Drawing.Point(8, 7);
      this.ImperialRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.ImperialRadioButton.Name = "ImperialRadioButton";
      this.ImperialRadioButton.Size = new System.Drawing.Size(144, 37);
      this.ImperialRadioButton.TabIndex = 5;
      this.ImperialRadioButton.TabStop = true;
      this.ImperialRadioButton.Text = "Imperial";
      this.ImperialRadioButton.UseVisualStyleBackColor = true;
      this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChange);
      // 
      // WeightLabel
      // 
      this.WeightLabel.AutoSize = true;
      this.WeightLabel.Location = new System.Drawing.Point(8, 102);
      this.WeightLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.WeightLabel.Name = "WeightLabel";
      this.WeightLabel.Size = new System.Drawing.Size(144, 51);
      this.WeightLabel.TabIndex = 2;
      this.WeightLabel.Text = "My Weight";
      // 
      // BMIResultProgressBar
      // 
      this.BMIResultProgressBar.BackColor = System.Drawing.Color.White;
      this.BMITableLayoutPanel.SetColumnSpan(this.BMIResultProgressBar, 2);
      this.BMIResultProgressBar.ForeColor = System.Drawing.Color.White;
      this.BMIResultProgressBar.Location = new System.Drawing.Point(8, 316);
      this.BMIResultProgressBar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.BMIResultProgressBar.Name = "BMIResultProgressBar";
      this.BMIResultProgressBar.Size = new System.Drawing.Size(280, 17);
      this.BMIResultProgressBar.TabIndex = 4;
      // 
      // Scale
      // 
      this.Scale.AutoSize = true;
      this.Scale.Location = new System.Drawing.Point(3, 262);
      this.Scale.Name = "Scale";
      this.Scale.Size = new System.Drawing.Size(121, 46);
      this.Scale.TabIndex = 14;
      this.Scale.Text = "Scale";
      // 
      // BMITextBox
      // 
      this.BMITextBox.Location = new System.Drawing.Point(168, 215);
      this.BMITextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.BMITextBox.Name = "BMITextBox";
      this.BMITextBox.Size = new System.Drawing.Size(120, 53);
      this.BMITextBox.TabIndex = 13;
      // 
      // BmiResultTextBox
      // 
      this.BmiResultTextBox.Location = new System.Drawing.Point(168, 269);
      this.BmiResultTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.BmiResultTextBox.Name = "BmiResultTextBox";
      this.BmiResultTextBox.Size = new System.Drawing.Size(120, 53);
      this.BmiResultTextBox.TabIndex = 11;
      // 
      // HeadLabel
      // 
      this.HeadLabel.AutoSize = true;
      this.HeadLabel.Location = new System.Drawing.Point(60, 30);
      this.HeadLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.HeadLabel.Name = "HeadLabel";
      this.HeadLabel.Size = new System.Drawing.Size(282, 46);
      this.HeadLabel.TabIndex = 1;
      this.HeadLabel.Text = "BMI Calculator";
      // 
      // BmiCalculatorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(298, 424);
      this.Controls.Add(this.HeadLabel);
      this.Controls.Add(this.BMITableLayoutPanel);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.MaximizeBox = false;
      this.Name = "BmiCalculatorForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Body Mass Index Calculator";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
      this.BMITableLayoutPanel.ResumeLayout(false);
      this.BMITableLayoutPanel.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TableLayoutPanel BMITableLayoutPanel;
    private Label HeightLabel;
    private Label WeightLabel;
    private Label YourBmiLabel;
    private ProgressBar BMIResultProgressBar;
    private RadioButton MetricRadioButton;
    private RadioButton ImperialRadioButton;
    private Button CalculateBmiButton;
    private Button ResetButton;
    private TextBox BmiResultTextBox;
    private TextBox WeightTextBox;
    private TextBox HeightTextBox;
    private Label HeadLabel;
    private TextBox BMITextBox;
    private Label Scale;
  }
}
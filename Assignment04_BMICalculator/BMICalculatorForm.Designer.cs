namespace Assignment04_BMICalculator
{
  partial class BMICalculatorForm
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
      this.BMITableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.HeightLabel = new System.Windows.Forms.Label();
      this.WeightLabel = new System.Windows.Forms.Label();
      this.YourBmiLabel = new System.Windows.Forms.Label();
      this.BMIResultProgressBar = new System.Windows.Forms.ProgressBar();
      this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
      this.MetricRadioButton = new System.Windows.Forms.RadioButton();
      this.CalculateBmiButton = new System.Windows.Forms.Button();
      this.ResetButton = new System.Windows.Forms.Button();
      this.HeightTextBox = new System.Windows.Forms.TextBox();
      this.WeightTextBox = new System.Windows.Forms.TextBox();
      this.BmiResultTextBox = new System.Windows.Forms.TextBox();
      this.HeadLabel = new System.Windows.Forms.Label();
      this.BMITableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // BMITableLayoutPanel
      // 
      this.BMITableLayoutPanel.ColumnCount = 2;
      this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.BMITableLayoutPanel.Controls.Add(this.BmiResultTextBox, 1, 4);
      this.BMITableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 2);
      this.BMITableLayoutPanel.Controls.Add(this.MetricRadioButton, 1, 0);
      this.BMITableLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
      this.BMITableLayoutPanel.Controls.Add(this.WeightLabel, 0, 2);
      this.BMITableLayoutPanel.Controls.Add(this.YourBmiLabel, 0, 4);
      this.BMITableLayoutPanel.Controls.Add(this.BMIResultProgressBar, 0, 5);
      this.BMITableLayoutPanel.Controls.Add(this.CalculateBmiButton, 0, 3);
      this.BMITableLayoutPanel.Controls.Add(this.ResetButton, 1, 3);
      this.BMITableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 1);
      this.BMITableLayoutPanel.Controls.Add(this.ImperialRadioButton, 0, 0);
      this.BMITableLayoutPanel.Location = new System.Drawing.Point(3, 74);
      this.BMITableLayoutPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.BMITableLayoutPanel.Name = "BMITableLayoutPanel";
      this.BMITableLayoutPanel.RowCount = 6;
      this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
      this.BMITableLayoutPanel.Size = new System.Drawing.Size(296, 334);
      this.BMITableLayoutPanel.TabIndex = 0;
      this.BMITableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
      // 
      // HeightLabel
      // 
      this.HeightLabel.AutoSize = true;
      this.HeightLabel.Location = new System.Drawing.Point(8, 55);
      this.HeightLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.HeightLabel.Name = "HeightLabel";
      this.HeightLabel.Size = new System.Drawing.Size(124, 55);
      this.HeightLabel.TabIndex = 1;
      this.HeightLabel.Text = "Height";
      // 
      // WeightLabel
      // 
      this.WeightLabel.AutoSize = true;
      this.WeightLabel.Location = new System.Drawing.Point(8, 110);
      this.WeightLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.WeightLabel.Name = "WeightLabel";
      this.WeightLabel.Size = new System.Drawing.Size(111, 55);
      this.WeightLabel.TabIndex = 2;
      this.WeightLabel.Text = "Weight";
      // 
      // YourBmiLabel
      // 
      this.YourBmiLabel.AutoSize = true;
      this.YourBmiLabel.Location = new System.Drawing.Point(8, 220);
      this.YourBmiLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.YourBmiLabel.Name = "YourBmiLabel";
      this.YourBmiLabel.Size = new System.Drawing.Size(115, 55);
      this.YourBmiLabel.TabIndex = 3;
      this.YourBmiLabel.Text = "Your BMI";
      // 
      // BMIResultProgressBar
      // 
      this.BMITableLayoutPanel.SetColumnSpan(this.BMIResultProgressBar, 2);
      this.BMIResultProgressBar.Location = new System.Drawing.Point(8, 282);
      this.BMIResultProgressBar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.BMIResultProgressBar.Name = "BMIResultProgressBar";
      this.BMIResultProgressBar.Size = new System.Drawing.Size(280, 45);
      this.BMIResultProgressBar.TabIndex = 4;
      // 
      // ImperialRadioButton
      // 
      this.ImperialRadioButton.AutoSize = true;
      this.ImperialRadioButton.Location = new System.Drawing.Point(8, 7);
      this.ImperialRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.ImperialRadioButton.Name = "ImperialRadioButton";
      this.ImperialRadioButton.Size = new System.Drawing.Size(132, 41);
      this.ImperialRadioButton.TabIndex = 5;
      this.ImperialRadioButton.TabStop = true;
      this.ImperialRadioButton.Text = "Imperial";
      this.ImperialRadioButton.UseVisualStyleBackColor = true;
      // 
      // MetricRadioButton
      // 
      this.MetricRadioButton.AutoSize = true;
      this.MetricRadioButton.Location = new System.Drawing.Point(156, 7);
      this.MetricRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.MetricRadioButton.Name = "MetricRadioButton";
      this.MetricRadioButton.Size = new System.Drawing.Size(132, 41);
      this.MetricRadioButton.TabIndex = 6;
      this.MetricRadioButton.TabStop = true;
      this.MetricRadioButton.Text = "Metric";
      this.MetricRadioButton.UseVisualStyleBackColor = true;
      // 
      // CalculateBmiButton
      // 
      this.CalculateBmiButton.Location = new System.Drawing.Point(8, 172);
      this.CalculateBmiButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.CalculateBmiButton.Name = "CalculateBmiButton";
      this.CalculateBmiButton.Size = new System.Drawing.Size(132, 41);
      this.CalculateBmiButton.TabIndex = 7;
      this.CalculateBmiButton.Text = "BMI";
      this.CalculateBmiButton.UseVisualStyleBackColor = true;
      // 
      // ResetButton
      // 
      this.ResetButton.Location = new System.Drawing.Point(156, 172);
      this.ResetButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.ResetButton.Name = "ResetButton";
      this.ResetButton.Size = new System.Drawing.Size(132, 41);
      this.ResetButton.TabIndex = 8;
      this.ResetButton.Text = "Reset";
      this.ResetButton.UseVisualStyleBackColor = true;
      // 
      // HeightTextBox
      // 
      this.HeightTextBox.Location = new System.Drawing.Point(156, 62);
      this.HeightTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.HeightTextBox.Name = "HeightTextBox";
      this.HeightTextBox.Size = new System.Drawing.Size(132, 53);
      this.HeightTextBox.TabIndex = 9;
      // 
      // WeightTextBox
      // 
      this.WeightTextBox.Location = new System.Drawing.Point(156, 117);
      this.WeightTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.WeightTextBox.Name = "WeightTextBox";
      this.WeightTextBox.Size = new System.Drawing.Size(132, 53);
      this.WeightTextBox.TabIndex = 10;
      // 
      // BmiResultTextBox
      // 
      this.BmiResultTextBox.Location = new System.Drawing.Point(156, 227);
      this.BmiResultTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.BmiResultTextBox.Name = "BmiResultTextBox";
      this.BmiResultTextBox.Size = new System.Drawing.Size(132, 53);
      this.BmiResultTextBox.TabIndex = 11;
      // 
      // HeadLabel
      // 
      this.HeadLabel.AutoSize = true;
      this.HeadLabel.Location = new System.Drawing.Point(17, 21);
      this.HeadLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.HeadLabel.Name = "HeadLabel";
      this.HeadLabel.Size = new System.Drawing.Size(282, 46);
      this.HeadLabel.TabIndex = 1;
      this.HeadLabel.Text = "BMI Calculator";
      // 
      // BMICalculatorForm
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
      this.Name = "BMICalculatorForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Body Mass Index Calculator";
      this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
      this.BMITableLayoutPanel.ResumeLayout(false);
      this.BMITableLayoutPanel.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel BMITableLayoutPanel;
    private System.Windows.Forms.Label HeightLabel;
    private System.Windows.Forms.Label WeightLabel;
    private System.Windows.Forms.Label YourBmiLabel;
    private System.Windows.Forms.ProgressBar BMIResultProgressBar;
    private System.Windows.Forms.RadioButton MetricRadioButton;
    private System.Windows.Forms.RadioButton ImperialRadioButton;
    private System.Windows.Forms.Button CalculateBmiButton;
    private System.Windows.Forms.Button ResetButton;
    private System.Windows.Forms.TextBox BmiResultTextBox;
    private System.Windows.Forms.TextBox WeightTextBox;
    private System.Windows.Forms.TextBox HeightTextBox;
    private System.Windows.Forms.Label HeadLabel;
  }
}


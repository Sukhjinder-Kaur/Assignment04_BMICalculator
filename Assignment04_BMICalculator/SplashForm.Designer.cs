namespace Assignment04_BMICalculator
{
  partial class SplashForm
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
      this.SplashFormLabel = new System.Windows.Forms.Label();
      this.SpalshFormTimer = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // SplashFormLabel
      // 
      this.SplashFormLabel.AutoSize = true;
      this.SplashFormLabel.BackColor = System.Drawing.Color.Thistle;
      this.SplashFormLabel.Location = new System.Drawing.Point(47, 135);
      this.SplashFormLabel.Name = "SplashFormLabel";
      this.SplashFormLabel.Size = new System.Drawing.Size(304, 138);
      this.SplashFormLabel.TabIndex = 0;
      this.SplashFormLabel.Text = "     Welcome \r\n           To \r\n  BMI Calculator";
      // 
      // SpalshFormTimer
      // 
      this.SpalshFormTimer.Enabled = true;
      this.SpalshFormTimer.Interval = 3000;
      this.SpalshFormTimer.Tick += new System.EventHandler(this.SpalshFormTimer_Tick);
      // 
      // SplashForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(298, 424);
      this.ControlBox = false;
      this.Controls.Add(this.SplashFormLabel);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.MaximizeBox = false;
      this.Name = "SplashForm";
      this.Opacity = 0.8D;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label SplashFormLabel;
    private System.Windows.Forms.Timer SpalshFormTimer;
  }
}
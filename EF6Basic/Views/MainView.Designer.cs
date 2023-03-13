namespace EF6Basic.Views
{
  partial class MainView
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
      this.regControl = new EF6Basic.Views.RegControl();
      this.SuspendLayout();
      // 
      // regControl
      // 
      this.regControl.Location = new System.Drawing.Point(12, 35);
      this.regControl.Name = "regControl";
      this.regControl.Size = new System.Drawing.Size(361, 340);
      this.regControl.TabIndex = 0;
      this.regControl.SelectedTabIndexChanged += new System.EventHandler(this.regControl_SelectedTabIndexChanged);
      // 
      // MainView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.regControl);
      this.Name = "MainView";
      this.Text = "MainView";
      this.ResumeLayout(false);

    }

    #endregion

    private RegControl regControl;
  }
}
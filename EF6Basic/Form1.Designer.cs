﻿namespace EF6Basic
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnConnection = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.lblStatus = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnConnection
      // 
      this.btnConnection.Location = new System.Drawing.Point(12, 12);
      this.btnConnection.Name = "btnConnection";
      this.btnConnection.Size = new System.Drawing.Size(159, 56);
      this.btnConnection.TabIndex = 0;
      this.btnConnection.Text = "커넥션 연결";
      this.btnConnection.UseVisualStyleBackColor = true;
      this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(188, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "연결상태 :";
      // 
      // lblStatus
      // 
      this.lblStatus.AutoSize = true;
      this.lblStatus.Location = new System.Drawing.Point(256, 33);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(40, 15);
      this.lblStatus.TabIndex = 2;
      this.lblStatus.Text = "Status";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnConnection);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button btnConnection;
    private Label label1;
    private Label lblStatus;
  }
}
namespace EF6Basic.Views
{
  partial class SchoolReg
  {
    /// <summary> 
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region 구성 요소 디자이너에서 생성한 코드

    /// <summary> 
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.txtSchool = new System.Windows.Forms.TextBox();
      this.lbSchool = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(4, 10);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "학교명";
      // 
      // txtSchool
      // 
      this.txtSchool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSchool.Location = new System.Drawing.Point(65, 7);
      this.txtSchool.Name = "txtSchool";
      this.txtSchool.Size = new System.Drawing.Size(125, 27);
      this.txtSchool.TabIndex = 1;
      // 
      // lbSchool
      // 
      this.lbSchool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbSchool.FormattingEnabled = true;
      this.lbSchool.ItemHeight = 20;
      this.lbSchool.Location = new System.Drawing.Point(4, 40);
      this.lbSchool.Name = "lbSchool";
      this.lbSchool.Size = new System.Drawing.Size(186, 144);
      this.lbSchool.TabIndex = 2;
      // 
      // SchoolReg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lbSchool);
      this.Controls.Add(this.txtSchool);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "SchoolReg";
      this.Size = new System.Drawing.Size(193, 200);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label label1;
    private TextBox txtSchool;
    private ListBox lbSchool;
  }
}

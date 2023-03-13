namespace EF6Basic.Views
{
  partial class ClassReg
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
      this.lbClass = new System.Windows.Forms.ListBox();
      this.txtClass = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.cmbSchool = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lbClass
      // 
      this.lbClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbClass.FormattingEnabled = true;
      this.lbClass.ItemHeight = 20;
      this.lbClass.Location = new System.Drawing.Point(4, 70);
      this.lbClass.Name = "lbClass";
      this.lbClass.Size = new System.Drawing.Size(186, 124);
      this.lbClass.TabIndex = 5;
      // 
      // txtClass
      // 
      this.txtClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtClass.Location = new System.Drawing.Point(65, 37);
      this.txtClass.Name = "txtClass";
      this.txtClass.Size = new System.Drawing.Size(125, 27);
      this.txtClass.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(4, 6);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 20);
      this.label1.TabIndex = 3;
      this.label1.Text = "학교명";
      // 
      // cmbSchool
      // 
      this.cmbSchool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbSchool.FormattingEnabled = true;
      this.cmbSchool.Location = new System.Drawing.Point(65, 3);
      this.cmbSchool.Name = "cmbSchool";
      this.cmbSchool.Size = new System.Drawing.Size(121, 28);
      this.cmbSchool.TabIndex = 6;
      this.cmbSchool.SelectedIndexChanged += new System.EventHandler(this.cmbSchool_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(4, 41);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 20);
      this.label2.TabIndex = 7;
      this.label2.Text = "반이름";
      // 
      // ClassReg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cmbSchool);
      this.Controls.Add(this.lbClass);
      this.Controls.Add(this.txtClass);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "ClassReg";
      this.Size = new System.Drawing.Size(193, 200);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private ListBox lbClass;
    private TextBox txtClass;
    private Label label1;
    private ComboBox cmbSchool;
    private Label label2;
  }
}

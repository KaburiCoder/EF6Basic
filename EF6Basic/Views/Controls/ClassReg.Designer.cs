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
      lbClass = new ListBox();
      txtClass = new TextBox();
      label1 = new Label();
      cmbSchool = new ComboBox();
      label2 = new Label();
      SuspendLayout();
      // 
      // lbClass
      // 
      lbClass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      lbClass.FormattingEnabled = true;
      lbClass.ItemHeight = 20;
      lbClass.Location = new Point(4, 70);
      lbClass.Name = "lbClass";
      lbClass.Size = new Size(186, 124);
      lbClass.TabIndex = 5;
      // 
      // txtClass
      // 
      txtClass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtClass.Location = new Point(65, 37);
      txtClass.Name = "txtClass";
      txtClass.Size = new Size(125, 27);
      txtClass.TabIndex = 4;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(4, 6);
      label1.Margin = new Padding(4, 0, 4, 0);
      label1.Name = "label1";
      label1.Size = new Size(54, 20);
      label1.TabIndex = 3;
      label1.Text = "학교명";
      // 
      // cmbSchool
      // 
      cmbSchool.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      cmbSchool.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbSchool.FormattingEnabled = true;
      cmbSchool.Location = new Point(65, 3);
      cmbSchool.Name = "cmbSchool";
      cmbSchool.Size = new Size(121, 28);
      cmbSchool.TabIndex = 6;
      cmbSchool.SelectedIndexChanged += cmbSchool_SelectedIndexChanged;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(4, 41);
      label2.Margin = new Padding(4, 0, 4, 0);
      label2.Name = "label2";
      label2.Size = new Size(54, 20);
      label2.TabIndex = 7;
      label2.Text = "반이름";
      // 
      // ClassReg
      // 
      AutoScaleDimensions = new SizeF(9F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(label2);
      Controls.Add(cmbSchool);
      Controls.Add(lbClass);
      Controls.Add(txtClass);
      Controls.Add(label1);
      Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
      Margin = new Padding(4);
      Name = "ClassReg";
      Size = new Size(193, 200);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private ListBox lbClass;
    private TextBox txtClass;
    private Label label1;
    private ComboBox cmbSchool;
    private Label label2;
  }
}

namespace EF6Basic.Views
{
  partial class StudentReg
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
      label2 = new Label();
      cmbSchool = new ComboBox();
      txtName = new TextBox();
      label1 = new Label();
      cmbClass = new ComboBox();
      dtpBirth = new DateTimePicker();
      label3 = new Label();
      label4 = new Label();
      dgv = new DataGridView();
      이름 = new DataGridViewTextBoxColumn();
      생일 = new DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
      SuspendLayout();
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(3, 43);
      label2.Margin = new Padding(4, 0, 4, 0);
      label2.Name = "label2";
      label2.Size = new Size(54, 20);
      label2.TabIndex = 12;
      label2.Text = "반이름";
      // 
      // cmbSchool
      // 
      cmbSchool.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      cmbSchool.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbSchool.FormattingEnabled = true;
      cmbSchool.Location = new Point(64, 5);
      cmbSchool.Name = "cmbSchool";
      cmbSchool.Size = new Size(286, 28);
      cmbSchool.TabIndex = 11;
      cmbSchool.SelectedIndexChanged += cmbSchool_SelectedIndexChanged;
      // 
      // txtName
      // 
      txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtName.Location = new Point(64, 73);
      txtName.Name = "txtName";
      txtName.Size = new Size(286, 27);
      txtName.TabIndex = 9;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(3, 8);
      label1.Margin = new Padding(4, 0, 4, 0);
      label1.Name = "label1";
      label1.Size = new Size(54, 20);
      label1.TabIndex = 8;
      label1.Text = "학교명";
      // 
      // cmbClass
      // 
      cmbClass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbClass.FormattingEnabled = true;
      cmbClass.Location = new Point(64, 39);
      cmbClass.Name = "cmbClass";
      cmbClass.Size = new Size(286, 28);
      cmbClass.TabIndex = 13;
      cmbClass.SelectedIndexChanged += cmbClass_SelectedIndexChanged;
      // 
      // dtpBirth
      // 
      dtpBirth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      dtpBirth.Location = new Point(64, 106);
      dtpBirth.Name = "dtpBirth";
      dtpBirth.Size = new Size(286, 27);
      dtpBirth.TabIndex = 14;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(18, 77);
      label3.Margin = new Padding(4, 0, 4, 0);
      label3.Name = "label3";
      label3.Size = new Size(39, 20);
      label3.TabIndex = 15;
      label3.Text = "이름";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(18, 110);
      label4.Margin = new Padding(4, 0, 4, 0);
      label4.Name = "label4";
      label4.Size = new Size(39, 20);
      label4.TabIndex = 16;
      label4.Text = "생일";
      // 
      // dgv
      // 
      dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      dgv.BackgroundColor = Color.White;
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Columns.AddRange(new DataGridViewColumn[] { 이름, 생일 });
      dgv.Location = new Point(3, 139);
      dgv.Name = "dgv";
      dgv.RowTemplate.Height = 25;
      dgv.Size = new Size(347, 200);
      dgv.TabIndex = 17;
      // 
      // 이름
      // 
      이름.HeaderText = "이름";
      이름.Name = "이름";
      이름.Width = 150;
      // 
      // 생일
      // 
      생일.HeaderText = "생일";
      생일.Name = "생일";
      생일.Width = 150;
      // 
      // StudentReg
      // 
      AutoScaleDimensions = new SizeF(9F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(dgv);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(dtpBirth);
      Controls.Add(cmbClass);
      Controls.Add(label2);
      Controls.Add(cmbSchool);
      Controls.Add(txtName);
      Controls.Add(label1);
      Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
      Margin = new Padding(4);
      Name = "StudentReg";
      Size = new Size(354, 342);
      ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label2;
    private ComboBox cmbSchool;
    private TextBox txtName;
    private Label label1;
    private ComboBox cmbClass;
    private DateTimePicker dtpBirth;
    private Label label3;
    private Label label4;
    private DataGridView dgv;
    private DataGridViewTextBoxColumn 이름;
    private DataGridViewTextBoxColumn 생일;
  }
}

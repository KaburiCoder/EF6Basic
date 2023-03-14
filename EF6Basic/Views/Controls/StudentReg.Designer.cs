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
      this.label2 = new System.Windows.Forms.Label();
      this.cmbSchool = new System.Windows.Forms.ComboBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.cmbClass = new System.Windows.Forms.ComboBox();
      this.dtpBirth = new System.Windows.Forms.DateTimePicker();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.dgv = new System.Windows.Forms.DataGridView();
      this.이름 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.생일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 43);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 20);
      this.label2.TabIndex = 12;
      this.label2.Text = "반이름";
      // 
      // cmbSchool
      // 
      this.cmbSchool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbSchool.FormattingEnabled = true;
      this.cmbSchool.Location = new System.Drawing.Point(64, 5);
      this.cmbSchool.Name = "cmbSchool";
      this.cmbSchool.Size = new System.Drawing.Size(286, 28);
      this.cmbSchool.TabIndex = 11;
      this.cmbSchool.SelectedIndexChanged += new System.EventHandler(this.cmbSchool_SelectedIndexChanged);
      // 
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.Location = new System.Drawing.Point(64, 73);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(286, 27);
      this.txtName.TabIndex = 9;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 8);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 20);
      this.label1.TabIndex = 8;
      this.label1.Text = "학교명";
      // 
      // cmbClass
      // 
      this.cmbClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbClass.FormattingEnabled = true;
      this.cmbClass.Location = new System.Drawing.Point(64, 39);
      this.cmbClass.Name = "cmbClass";
      this.cmbClass.Size = new System.Drawing.Size(286, 28);
      this.cmbClass.TabIndex = 13;
      this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
      // 
      // dtpBirth
      // 
      this.dtpBirth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dtpBirth.Location = new System.Drawing.Point(64, 106);
      this.dtpBirth.Name = "dtpBirth";
      this.dtpBirth.Size = new System.Drawing.Size(286, 27);
      this.dtpBirth.TabIndex = 14;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(18, 77);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(39, 20);
      this.label3.TabIndex = 15;
      this.label3.Text = "이름";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(18, 110);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(39, 20);
      this.label4.TabIndex = 16;
      this.label4.Text = "생일";
      // 
      // dgv
      // 
      this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgv.BackgroundColor = System.Drawing.Color.White;
      this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.이름,
            this.생일});
      this.dgv.Location = new System.Drawing.Point(3, 139);
      this.dgv.Name = "dgv";
      this.dgv.RowTemplate.Height = 25;
      this.dgv.Size = new System.Drawing.Size(347, 200);
      this.dgv.TabIndex = 17;
      // 
      // 이름
      // 
      this.이름.HeaderText = "이름";
      this.이름.Name = "이름";
      this.이름.Width = 150;
      // 
      // 생일
      // 
      this.생일.HeaderText = "생일";
      this.생일.Name = "생일";
      this.생일.Width = 150;
      // 
      // StudentReg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.dgv);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.dtpBirth);
      this.Controls.Add(this.cmbClass);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cmbSchool);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "StudentReg";
      this.Size = new System.Drawing.Size(354, 342);
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

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

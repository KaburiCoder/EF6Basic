namespace EF6Basic.Views
{
  partial class RegControl
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
      this.tab = new System.Windows.Forms.TabControl();
      this.tpgSchool = new System.Windows.Forms.TabPage();
      this.schoolReg = new EF6Basic.Views.SchoolReg();
      this.tpgClass = new System.Windows.Forms.TabPage();
      this.classReg = new EF6Basic.Views.ClassReg();
      this.tpgStudent = new System.Windows.Forms.TabPage();
      this.studentReg = new EF6Basic.Views.StudentReg();
      this.tab.SuspendLayout();
      this.tpgSchool.SuspendLayout();
      this.tpgClass.SuspendLayout();
      this.tpgStudent.SuspendLayout();
      this.SuspendLayout();
      // 
      // tab
      // 
      this.tab.Controls.Add(this.tpgSchool);
      this.tab.Controls.Add(this.tpgClass);
      this.tab.Controls.Add(this.tpgStudent);
      this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tab.Location = new System.Drawing.Point(0, 0);
      this.tab.Name = "tab";
      this.tab.SelectedIndex = 0;
      this.tab.Size = new System.Drawing.Size(474, 456);
      this.tab.TabIndex = 0;
      this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
      // 
      // tpgSchool
      // 
      this.tpgSchool.Controls.Add(this.schoolReg);
      this.tpgSchool.Location = new System.Drawing.Point(4, 24);
      this.tpgSchool.Name = "tpgSchool";
      this.tpgSchool.Padding = new System.Windows.Forms.Padding(3);
      this.tpgSchool.Size = new System.Drawing.Size(466, 428);
      this.tpgSchool.TabIndex = 0;
      this.tpgSchool.Text = "School";
      this.tpgSchool.UseVisualStyleBackColor = true;
      // 
      // schoolReg
      // 
      this.schoolReg.Dock = System.Windows.Forms.DockStyle.Fill;
      this.schoolReg.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.schoolReg.Location = new System.Drawing.Point(3, 3);
      this.schoolReg.Margin = new System.Windows.Forms.Padding(4);
      this.schoolReg.Name = "schoolReg";
      this.schoolReg.SelectedValue = null;
      this.schoolReg.Size = new System.Drawing.Size(460, 422);
      this.schoolReg.TabIndex = 0;
      // 
      // tpgClass
      // 
      this.tpgClass.Controls.Add(this.classReg);
      this.tpgClass.Location = new System.Drawing.Point(4, 24);
      this.tpgClass.Name = "tpgClass";
      this.tpgClass.Padding = new System.Windows.Forms.Padding(3);
      this.tpgClass.Size = new System.Drawing.Size(466, 428);
      this.tpgClass.TabIndex = 1;
      this.tpgClass.Text = "Class";
      this.tpgClass.UseVisualStyleBackColor = true;
      // 
      // classReg
      // 
      this.classReg.Dock = System.Windows.Forms.DockStyle.Fill;
      this.classReg.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.classReg.Location = new System.Drawing.Point(3, 3);
      this.classReg.Margin = new System.Windows.Forms.Padding(4);
      this.classReg.Name = "classReg";
      this.classReg.SelectedValue = null;
      this.classReg.Size = new System.Drawing.Size(460, 422);
      this.classReg.TabIndex = 0;
      // 
      // tpgStudent
      // 
      this.tpgStudent.Controls.Add(this.studentReg);
      this.tpgStudent.Location = new System.Drawing.Point(4, 24);
      this.tpgStudent.Name = "tpgStudent";
      this.tpgStudent.Padding = new System.Windows.Forms.Padding(3);
      this.tpgStudent.Size = new System.Drawing.Size(466, 428);
      this.tpgStudent.TabIndex = 2;
      this.tpgStudent.Text = "Student";
      this.tpgStudent.UseVisualStyleBackColor = true;
      // 
      // studentReg
      // 
      this.studentReg.Dock = System.Windows.Forms.DockStyle.Fill;
      this.studentReg.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.studentReg.Location = new System.Drawing.Point(3, 3);
      this.studentReg.Margin = new System.Windows.Forms.Padding(4);
      this.studentReg.Name = "studentReg";
      this.studentReg.Size = new System.Drawing.Size(460, 422);
      this.studentReg.TabIndex = 0;
      // 
      // RegControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tab);
      this.Name = "RegControl";
      this.Size = new System.Drawing.Size(474, 456);
      this.tab.ResumeLayout(false);
      this.tpgSchool.ResumeLayout(false);
      this.tpgClass.ResumeLayout(false);
      this.tpgStudent.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private TabControl tab;
    private TabPage tpgSchool;
    private TabPage tpgClass;
    private TabPage tpgStudent;
    private SchoolReg schoolReg;
    private ClassReg classReg;
    private StudentReg studentReg;
  }
}

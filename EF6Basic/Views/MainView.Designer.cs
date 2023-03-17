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
      regControl = new RegControl();
      panel1 = new Panel();
      panel2 = new Panel();
      btnSave = new Button();
      btnDelete = new Button();
      label1 = new Label();
      splitter1 = new Splitter();
      panel3 = new Panel();
      dgv = new DataGridView();
      panel4 = new Panel();
      txtSearch = new TextBox();
      cmbSearch = new ComboBox();
      btnSearch = new Button();
      label2 = new Label();
      학교 = new DataGridViewTextBoxColumn();
      반 = new DataGridViewTextBoxColumn();
      이름 = new DataGridViewTextBoxColumn();
      생년월일 = new DataGridViewTextBoxColumn();
      panel1.SuspendLayout();
      panel2.SuspendLayout();
      panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
      panel4.SuspendLayout();
      SuspendLayout();
      // 
      // regControl
      // 
      regControl.Dock = DockStyle.Fill;
      regControl.Location = new Point(0, 41);
      regControl.Name = "regControl";
      regControl.Size = new Size(380, 409);
      regControl.TabIndex = 0;
      regControl.SelectedTabIndexChanged += regControl_SelectedTabIndexChanged;
      // 
      // panel1
      // 
      panel1.Controls.Add(regControl);
      panel1.Controls.Add(panel2);
      panel1.Dock = DockStyle.Left;
      panel1.Location = new Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new Size(380, 450);
      panel1.TabIndex = 1;
      // 
      // panel2
      // 
      panel2.Controls.Add(btnSave);
      panel2.Controls.Add(btnDelete);
      panel2.Controls.Add(label1);
      panel2.Dock = DockStyle.Top;
      panel2.Location = new Point(0, 0);
      panel2.Name = "panel2";
      panel2.Size = new Size(380, 41);
      panel2.TabIndex = 0;
      // 
      // btnSave
      // 
      btnSave.Location = new Point(282, 3);
      btnSave.Name = "btnSave";
      btnSave.Size = new Size(48, 35);
      btnSave.TabIndex = 2;
      btnSave.Text = "저장";
      btnSave.UseVisualStyleBackColor = true;
      btnSave.Click += btnSave_Click;
      // 
      // btnDelete
      // 
      btnDelete.Location = new Point(329, 3);
      btnDelete.Name = "btnDelete";
      btnDelete.Size = new Size(48, 35);
      btnDelete.TabIndex = 1;
      btnDelete.Text = "삭제";
      btnDelete.UseVisualStyleBackColor = true;
      btnDelete.Click += btnDelete_Click;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
      label1.Location = new Point(12, 9);
      label1.Name = "label1";
      label1.Size = new Size(80, 21);
      label1.TabIndex = 0;
      label1.Text = "정보 입력";
      // 
      // splitter1
      // 
      splitter1.Location = new Point(380, 0);
      splitter1.Name = "splitter1";
      splitter1.Size = new Size(3, 450);
      splitter1.TabIndex = 2;
      splitter1.TabStop = false;
      // 
      // panel3
      // 
      panel3.Controls.Add(dgv);
      panel3.Controls.Add(panel4);
      panel3.Dock = DockStyle.Fill;
      panel3.Location = new Point(383, 0);
      panel3.Name = "panel3";
      panel3.Size = new Size(444, 450);
      panel3.TabIndex = 3;
      // 
      // dgv
      // 
      dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgv.Columns.AddRange(new DataGridViewColumn[] { 학교, 반, 이름, 생년월일 });
      dgv.Dock = DockStyle.Fill;
      dgv.Location = new Point(0, 41);
      dgv.Name = "dgv";
      dgv.RowTemplate.Height = 25;
      dgv.Size = new Size(444, 409);
      dgv.TabIndex = 1;
      // 
      // panel4
      // 
      panel4.Controls.Add(txtSearch);
      panel4.Controls.Add(cmbSearch);
      panel4.Controls.Add(btnSearch);
      panel4.Controls.Add(label2);
      panel4.Dock = DockStyle.Top;
      panel4.Location = new Point(0, 0);
      panel4.Name = "panel4";
      panel4.Size = new Size(444, 41);
      panel4.TabIndex = 0;
      // 
      // txtSearch
      // 
      txtSearch.Location = new Point(209, 9);
      txtSearch.Name = "txtSearch";
      txtSearch.Size = new Size(151, 23);
      txtSearch.TabIndex = 4;
      // 
      // cmbSearch
      // 
      cmbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbSearch.FormattingEnabled = true;
      cmbSearch.Location = new Point(98, 9);
      cmbSearch.Name = "cmbSearch";
      cmbSearch.Size = new Size(105, 23);
      cmbSearch.TabIndex = 3;
      // 
      // btnSearch
      // 
      btnSearch.Location = new Point(366, 3);
      btnSearch.Name = "btnSearch";
      btnSearch.Size = new Size(48, 35);
      btnSearch.TabIndex = 2;
      btnSearch.Text = "조회";
      btnSearch.UseVisualStyleBackColor = true;
      btnSearch.Click += btnSearch_Click;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
      label2.Location = new Point(12, 9);
      label2.Name = "label2";
      label2.Size = new Size(80, 21);
      label2.TabIndex = 0;
      label2.Text = "정보 검색";
      // 
      // 학교
      // 
      학교.DataPropertyName = "SchoolName";
      학교.HeaderText = "학교";
      학교.Name = "학교";
      // 
      // 반
      // 
      반.DataPropertyName = "ClassName";
      반.HeaderText = "반";
      반.Name = "반";
      // 
      // 이름
      // 
      이름.DataPropertyName = "StudentName";
      이름.HeaderText = "이름";
      이름.Name = "이름";
      // 
      // 생년월일
      // 
      생년월일.DataPropertyName = "Birthday";
      생년월일.HeaderText = "생년월일";
      생년월일.Name = "생년월일";
      // 
      // MainView
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(827, 450);
      Controls.Add(panel3);
      Controls.Add(splitter1);
      Controls.Add(panel1);
      Name = "MainView";
      Text = "MainView";
      panel1.ResumeLayout(false);
      panel2.ResumeLayout(false);
      panel2.PerformLayout();
      panel3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
      panel4.ResumeLayout(false);
      panel4.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private RegControl regControl;
    private Panel panel1;
    private Panel panel2;
    private Button btnSave;
    private Button btnDelete;
    private Label label1;
    private Splitter splitter1;
    private Panel panel3;
    private DataGridView dgv;
    private Panel panel4;
    private TextBox txtSearch;
    private ComboBox cmbSearch;
    private Button btnSearch;
    private Label label2;
    private DataGridViewTextBoxColumn 학교;
    private DataGridViewTextBoxColumn 반;
    private DataGridViewTextBoxColumn 이름;
    private DataGridViewTextBoxColumn 생년월일;
  }
}
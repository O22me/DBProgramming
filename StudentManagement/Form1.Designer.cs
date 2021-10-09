
namespace StudentManagement
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLoadStudentInfo = new System.Windows.Forms.Button();
            this.groupBoxStudent1 = new System.Windows.Forms.GroupBox();
            this.buttonStudent1Save = new System.Windows.Forms.Button();
            this.comboBoxStudent1Gender = new System.Windows.Forms.ComboBox();
            this.textBoxStudent1ID = new System.Windows.Forms.TextBox();
            this.labelStudent1Gender = new System.Windows.Forms.Label();
            this.labelStudent1ID = new System.Windows.Forms.Label();
            this.textBoxStudent1Name = new System.Windows.Forms.TextBox();
            this.labelStudent1Name = new System.Windows.Forms.Label();
            this.groupBoxStudent2 = new System.Windows.Forms.GroupBox();
            this.buttonStudent2Save = new System.Windows.Forms.Button();
            this.comboBoxStudent2Gender = new System.Windows.Forms.ComboBox();
            this.textBoxStudent2ID = new System.Windows.Forms.TextBox();
            this.labelStudent2Gender = new System.Windows.Forms.Label();
            this.labelStudent2ID = new System.Windows.Forms.Label();
            this.textBoxStudent2Name = new System.Windows.Forms.TextBox();
            this.labelStudent2Name = new System.Windows.Forms.Label();
            this.groupBoxStudent3 = new System.Windows.Forms.GroupBox();
            this.buttonStudent3Save = new System.Windows.Forms.Button();
            this.comboBoxStudent3Gender = new System.Windows.Forms.ComboBox();
            this.textBoxStudent3ID = new System.Windows.Forms.TextBox();
            this.labelStudent3Gender = new System.Windows.Forms.Label();
            this.labelStudent3ID = new System.Windows.Forms.Label();
            this.textBoxStudent3Name = new System.Windows.Forms.TextBox();
            this.labelStudent3Name = new System.Windows.Forms.Label();
            this.groupBoxStudent1.SuspendLayout();
            this.groupBoxStudent2.SuspendLayout();
            this.groupBoxStudent3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadStudentInfo
            // 
            this.buttonLoadStudentInfo.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadStudentInfo.Name = "buttonLoadStudentInfo";
            this.buttonLoadStudentInfo.Size = new System.Drawing.Size(183, 68);
            this.buttonLoadStudentInfo.TabIndex = 0;
            this.buttonLoadStudentInfo.Text = "학생정보 불러오기";
            this.buttonLoadStudentInfo.UseVisualStyleBackColor = true;
            this.buttonLoadStudentInfo.Click += new System.EventHandler(this.buttonLoadStudentInfo_Click);
            // 
            // groupBoxStudent1
            // 
            this.groupBoxStudent1.Controls.Add(this.buttonStudent1Save);
            this.groupBoxStudent1.Controls.Add(this.comboBoxStudent1Gender);
            this.groupBoxStudent1.Controls.Add(this.textBoxStudent1ID);
            this.groupBoxStudent1.Controls.Add(this.labelStudent1Gender);
            this.groupBoxStudent1.Controls.Add(this.labelStudent1ID);
            this.groupBoxStudent1.Controls.Add(this.textBoxStudent1Name);
            this.groupBoxStudent1.Controls.Add(this.labelStudent1Name);
            this.groupBoxStudent1.Location = new System.Drawing.Point(12, 96);
            this.groupBoxStudent1.Name = "groupBoxStudent1";
            this.groupBoxStudent1.Size = new System.Drawing.Size(183, 342);
            this.groupBoxStudent1.TabIndex = 1;
            this.groupBoxStudent1.TabStop = false;
            this.groupBoxStudent1.Text = "학생1";
            // 
            // buttonStudent1Save
            // 
            this.buttonStudent1Save.Location = new System.Drawing.Point(22, 289);
            this.buttonStudent1Save.Name = "buttonStudent1Save";
            this.buttonStudent1Save.Size = new System.Drawing.Size(136, 34);
            this.buttonStudent1Save.TabIndex = 3;
            this.buttonStudent1Save.Text = "저장";
            this.buttonStudent1Save.UseVisualStyleBackColor = true;
            this.buttonStudent1Save.Click += new System.EventHandler(this.buttonStudent1Save_Click);
            // 
            // comboBoxStudent1Gender
            // 
            this.comboBoxStudent1Gender.FormattingEnabled = true;
            this.comboBoxStudent1Gender.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.comboBoxStudent1Gender.Location = new System.Drawing.Point(62, 81);
            this.comboBoxStudent1Gender.Name = "comboBoxStudent1Gender";
            this.comboBoxStudent1Gender.Size = new System.Drawing.Size(96, 20);
            this.comboBoxStudent1Gender.TabIndex = 2;
            this.comboBoxStudent1Gender.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent1Gender_SelectedIndexChanged);
            // 
            // textBoxStudent1ID
            // 
            this.textBoxStudent1ID.Location = new System.Drawing.Point(62, 54);
            this.textBoxStudent1ID.Name = "textBoxStudent1ID";
            this.textBoxStudent1ID.Size = new System.Drawing.Size(96, 21);
            this.textBoxStudent1ID.TabIndex = 1;
            this.textBoxStudent1ID.TextChanged += new System.EventHandler(this.textBoxStudent1ID_TextChanged);
            // 
            // labelStudent1Gender
            // 
            this.labelStudent1Gender.AutoSize = true;
            this.labelStudent1Gender.Location = new System.Drawing.Point(20, 84);
            this.labelStudent1Gender.Name = "labelStudent1Gender";
            this.labelStudent1Gender.Size = new System.Drawing.Size(29, 12);
            this.labelStudent1Gender.TabIndex = 0;
            this.labelStudent1Gender.Text = "성별";
            // 
            // labelStudent1ID
            // 
            this.labelStudent1ID.AutoSize = true;
            this.labelStudent1ID.Location = new System.Drawing.Point(20, 57);
            this.labelStudent1ID.Name = "labelStudent1ID";
            this.labelStudent1ID.Size = new System.Drawing.Size(29, 12);
            this.labelStudent1ID.TabIndex = 0;
            this.labelStudent1ID.Text = "학번";
            // 
            // textBoxStudent1Name
            // 
            this.textBoxStudent1Name.Location = new System.Drawing.Point(62, 27);
            this.textBoxStudent1Name.Name = "textBoxStudent1Name";
            this.textBoxStudent1Name.Size = new System.Drawing.Size(96, 21);
            this.textBoxStudent1Name.TabIndex = 1;
            this.textBoxStudent1Name.Text = "학생정보없음";
            this.textBoxStudent1Name.TextChanged += new System.EventHandler(this.textBoxStudent1Name_TextChanged);
            // 
            // labelStudent1Name
            // 
            this.labelStudent1Name.AutoSize = true;
            this.labelStudent1Name.Location = new System.Drawing.Point(20, 30);
            this.labelStudent1Name.Name = "labelStudent1Name";
            this.labelStudent1Name.Size = new System.Drawing.Size(29, 12);
            this.labelStudent1Name.TabIndex = 0;
            this.labelStudent1Name.Text = "이름";
            // 
            // groupBoxStudent2
            // 
            this.groupBoxStudent2.Controls.Add(this.buttonStudent2Save);
            this.groupBoxStudent2.Controls.Add(this.comboBoxStudent2Gender);
            this.groupBoxStudent2.Controls.Add(this.textBoxStudent2ID);
            this.groupBoxStudent2.Controls.Add(this.labelStudent2Gender);
            this.groupBoxStudent2.Controls.Add(this.labelStudent2ID);
            this.groupBoxStudent2.Controls.Add(this.textBoxStudent2Name);
            this.groupBoxStudent2.Controls.Add(this.labelStudent2Name);
            this.groupBoxStudent2.Location = new System.Drawing.Point(201, 96);
            this.groupBoxStudent2.Name = "groupBoxStudent2";
            this.groupBoxStudent2.Size = new System.Drawing.Size(183, 342);
            this.groupBoxStudent2.TabIndex = 1;
            this.groupBoxStudent2.TabStop = false;
            this.groupBoxStudent2.Text = "학생2";
            // 
            // buttonStudent2Save
            // 
            this.buttonStudent2Save.Location = new System.Drawing.Point(22, 289);
            this.buttonStudent2Save.Name = "buttonStudent2Save";
            this.buttonStudent2Save.Size = new System.Drawing.Size(136, 34);
            this.buttonStudent2Save.TabIndex = 3;
            this.buttonStudent2Save.Text = "저장";
            this.buttonStudent2Save.UseVisualStyleBackColor = true;
            this.buttonStudent2Save.Click += new System.EventHandler(this.buttonStudent2Save_Click);
            // 
            // comboBoxStudent2Gender
            // 
            this.comboBoxStudent2Gender.FormattingEnabled = true;
            this.comboBoxStudent2Gender.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.comboBoxStudent2Gender.Location = new System.Drawing.Point(62, 81);
            this.comboBoxStudent2Gender.Name = "comboBoxStudent2Gender";
            this.comboBoxStudent2Gender.Size = new System.Drawing.Size(96, 20);
            this.comboBoxStudent2Gender.TabIndex = 2;
            // 
            // textBoxStudent2ID
            // 
            this.textBoxStudent2ID.Location = new System.Drawing.Point(62, 54);
            this.textBoxStudent2ID.Name = "textBoxStudent2ID";
            this.textBoxStudent2ID.Size = new System.Drawing.Size(96, 21);
            this.textBoxStudent2ID.TabIndex = 1;
            // 
            // labelStudent2Gender
            // 
            this.labelStudent2Gender.AutoSize = true;
            this.labelStudent2Gender.Location = new System.Drawing.Point(20, 84);
            this.labelStudent2Gender.Name = "labelStudent2Gender";
            this.labelStudent2Gender.Size = new System.Drawing.Size(29, 12);
            this.labelStudent2Gender.TabIndex = 0;
            this.labelStudent2Gender.Text = "성별";
            // 
            // labelStudent2ID
            // 
            this.labelStudent2ID.AutoSize = true;
            this.labelStudent2ID.Location = new System.Drawing.Point(20, 57);
            this.labelStudent2ID.Name = "labelStudent2ID";
            this.labelStudent2ID.Size = new System.Drawing.Size(29, 12);
            this.labelStudent2ID.TabIndex = 0;
            this.labelStudent2ID.Text = "학번";
            // 
            // textBoxStudent2Name
            // 
            this.textBoxStudent2Name.Location = new System.Drawing.Point(62, 27);
            this.textBoxStudent2Name.Name = "textBoxStudent2Name";
            this.textBoxStudent2Name.Size = new System.Drawing.Size(96, 21);
            this.textBoxStudent2Name.TabIndex = 1;
            this.textBoxStudent2Name.Text = "학생정보없음";
            // 
            // labelStudent2Name
            // 
            this.labelStudent2Name.AutoSize = true;
            this.labelStudent2Name.Location = new System.Drawing.Point(20, 30);
            this.labelStudent2Name.Name = "labelStudent2Name";
            this.labelStudent2Name.Size = new System.Drawing.Size(29, 12);
            this.labelStudent2Name.TabIndex = 0;
            this.labelStudent2Name.Text = "이름";
            // 
            // groupBoxStudent3
            // 
            this.groupBoxStudent3.Controls.Add(this.buttonStudent3Save);
            this.groupBoxStudent3.Controls.Add(this.comboBoxStudent3Gender);
            this.groupBoxStudent3.Controls.Add(this.textBoxStudent3ID);
            this.groupBoxStudent3.Controls.Add(this.labelStudent3Gender);
            this.groupBoxStudent3.Controls.Add(this.labelStudent3ID);
            this.groupBoxStudent3.Controls.Add(this.textBoxStudent3Name);
            this.groupBoxStudent3.Controls.Add(this.labelStudent3Name);
            this.groupBoxStudent3.Location = new System.Drawing.Point(390, 96);
            this.groupBoxStudent3.Name = "groupBoxStudent3";
            this.groupBoxStudent3.Size = new System.Drawing.Size(183, 342);
            this.groupBoxStudent3.TabIndex = 1;
            this.groupBoxStudent3.TabStop = false;
            this.groupBoxStudent3.Text = "학생3";
            // 
            // buttonStudent3Save
            // 
            this.buttonStudent3Save.Location = new System.Drawing.Point(22, 289);
            this.buttonStudent3Save.Name = "buttonStudent3Save";
            this.buttonStudent3Save.Size = new System.Drawing.Size(136, 34);
            this.buttonStudent3Save.TabIndex = 3;
            this.buttonStudent3Save.Text = "저장";
            this.buttonStudent3Save.UseVisualStyleBackColor = true;
            this.buttonStudent3Save.Click += new System.EventHandler(this.buttonStudent3Save_Click);
            // 
            // comboBoxStudent3Gender
            // 
            this.comboBoxStudent3Gender.FormattingEnabled = true;
            this.comboBoxStudent3Gender.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.comboBoxStudent3Gender.Location = new System.Drawing.Point(62, 81);
            this.comboBoxStudent3Gender.Name = "comboBoxStudent3Gender";
            this.comboBoxStudent3Gender.Size = new System.Drawing.Size(96, 20);
            this.comboBoxStudent3Gender.TabIndex = 2;
            // 
            // textBoxStudent3ID
            // 
            this.textBoxStudent3ID.Location = new System.Drawing.Point(62, 54);
            this.textBoxStudent3ID.Name = "textBoxStudent3ID";
            this.textBoxStudent3ID.Size = new System.Drawing.Size(96, 21);
            this.textBoxStudent3ID.TabIndex = 1;
            // 
            // labelStudent3Gender
            // 
            this.labelStudent3Gender.AutoSize = true;
            this.labelStudent3Gender.Location = new System.Drawing.Point(20, 84);
            this.labelStudent3Gender.Name = "labelStudent3Gender";
            this.labelStudent3Gender.Size = new System.Drawing.Size(29, 12);
            this.labelStudent3Gender.TabIndex = 0;
            this.labelStudent3Gender.Text = "성별";
            // 
            // labelStudent3ID
            // 
            this.labelStudent3ID.AutoSize = true;
            this.labelStudent3ID.Location = new System.Drawing.Point(20, 57);
            this.labelStudent3ID.Name = "labelStudent3ID";
            this.labelStudent3ID.Size = new System.Drawing.Size(29, 12);
            this.labelStudent3ID.TabIndex = 0;
            this.labelStudent3ID.Text = "학번";
            // 
            // textBoxStudent3Name
            // 
            this.textBoxStudent3Name.Location = new System.Drawing.Point(62, 27);
            this.textBoxStudent3Name.Name = "textBoxStudent3Name";
            this.textBoxStudent3Name.Size = new System.Drawing.Size(96, 21);
            this.textBoxStudent3Name.TabIndex = 1;
            this.textBoxStudent3Name.Text = "학생정보없음";
            // 
            // labelStudent3Name
            // 
            this.labelStudent3Name.AutoSize = true;
            this.labelStudent3Name.Location = new System.Drawing.Point(20, 30);
            this.labelStudent3Name.Name = "labelStudent3Name";
            this.labelStudent3Name.Size = new System.Drawing.Size(29, 12);
            this.labelStudent3Name.TabIndex = 0;
            this.labelStudent3Name.Text = "이름";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.groupBoxStudent3);
            this.Controls.Add(this.groupBoxStudent2);
            this.Controls.Add(this.groupBoxStudent1);
            this.Controls.Add(this.buttonLoadStudentInfo);
            this.Name = "Form1";
            this.Text = "학생정보관리 시스템";
            this.groupBoxStudent1.ResumeLayout(false);
            this.groupBoxStudent1.PerformLayout();
            this.groupBoxStudent2.ResumeLayout(false);
            this.groupBoxStudent2.PerformLayout();
            this.groupBoxStudent3.ResumeLayout(false);
            this.groupBoxStudent3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadStudentInfo;
        private System.Windows.Forms.GroupBox groupBoxStudent1;
        private System.Windows.Forms.TextBox textBoxStudent1Name;
        private System.Windows.Forms.Label labelStudent1Name;
        private System.Windows.Forms.TextBox textBoxStudent1ID;
        private System.Windows.Forms.Label labelStudent1ID;
        private System.Windows.Forms.ComboBox comboBoxStudent1Gender;
        private System.Windows.Forms.Label labelStudent1Gender;
        private System.Windows.Forms.Button buttonStudent1Save;
        private System.Windows.Forms.GroupBox groupBoxStudent2;
        private System.Windows.Forms.Button buttonStudent2Save;
        private System.Windows.Forms.ComboBox comboBoxStudent2Gender;
        private System.Windows.Forms.TextBox textBoxStudent2ID;
        private System.Windows.Forms.Label labelStudent2Gender;
        private System.Windows.Forms.Label labelStudent2ID;
        private System.Windows.Forms.TextBox textBoxStudent2Name;
        private System.Windows.Forms.Label labelStudent2Name;
        private System.Windows.Forms.GroupBox groupBoxStudent3;
        private System.Windows.Forms.Button buttonStudent3Save;
        private System.Windows.Forms.ComboBox comboBoxStudent3Gender;
        private System.Windows.Forms.TextBox textBoxStudent3ID;
        private System.Windows.Forms.Label labelStudent3Gender;
        private System.Windows.Forms.Label labelStudent3ID;
        private System.Windows.Forms.TextBox textBoxStudent3Name;
        private System.Windows.Forms.Label labelStudent3Name;
    }
}


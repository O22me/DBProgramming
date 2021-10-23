
namespace StudentManagement_DB
{
    partial class Assignment06
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
            this.buttonStudent1Delete = new System.Windows.Forms.Button();
            this.buttonStudent1Save = new System.Windows.Forms.Button();
            this.comboBoxStudent1Gender = new System.Windows.Forms.ComboBox();
            this.labelStudent1Gender = new System.Windows.Forms.Label();
            this.textBoxStudent1Memo = new System.Windows.Forms.TextBox();
            this.labelStudent1Memo = new System.Windows.Forms.Label();
            this.textBoxStudent1ID = new System.Windows.Forms.TextBox();
            this.labelStudent1ID = new System.Windows.Forms.Label();
            this.textBoxStudent1Name = new System.Windows.Forms.TextBox();
            this.labelStudent1Name = new System.Windows.Forms.Label();
            this.groupBoxStudent2Info = new System.Windows.Forms.GroupBox();
            this.buttonStudent2Delete = new System.Windows.Forms.Button();
            this.buttonStudent2Save = new System.Windows.Forms.Button();
            this.comboBoxStudent2Gender = new System.Windows.Forms.ComboBox();
            this.labelStudent2Gender = new System.Windows.Forms.Label();
            this.textBoxStudent2Memo = new System.Windows.Forms.TextBox();
            this.labelStudent2Memo = new System.Windows.Forms.Label();
            this.textBoxStudent2ID = new System.Windows.Forms.TextBox();
            this.labelStudent2ID = new System.Windows.Forms.Label();
            this.textBoxStudent2Name = new System.Windows.Forms.TextBox();
            this.labelStudent2Name = new System.Windows.Forms.Label();
            this.groupBoxStudent3Info = new System.Windows.Forms.GroupBox();
            this.buttonStudent3Delete = new System.Windows.Forms.Button();
            this.buttonStudent3Save = new System.Windows.Forms.Button();
            this.comboBoxStudent3Gender = new System.Windows.Forms.ComboBox();
            this.labelStudent3Gender = new System.Windows.Forms.Label();
            this.textBoxStudent3Memo = new System.Windows.Forms.TextBox();
            this.labelStudent3Memo = new System.Windows.Forms.Label();
            this.textBoxStudent3ID = new System.Windows.Forms.TextBox();
            this.labelStudent3ID = new System.Windows.Forms.Label();
            this.textBoxStudent3Name = new System.Windows.Forms.TextBox();
            this.labelStudent3Name = new System.Windows.Forms.Label();
            this.groupBoxSettingInfo = new System.Windows.Forms.GroupBox();
            this.labelSettingInfo = new System.Windows.Forms.Label();
            this.checkBoxSettingInfo = new System.Windows.Forms.CheckBox();
            this.groupBoxStudent1.SuspendLayout();
            this.groupBoxStudent2Info.SuspendLayout();
            this.groupBoxStudent3Info.SuspendLayout();
            this.groupBoxSettingInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadStudentInfo
            // 
            this.buttonLoadStudentInfo.Location = new System.Drawing.Point(20, 20);
            this.buttonLoadStudentInfo.Name = "buttonLoadStudentInfo";
            this.buttonLoadStudentInfo.Size = new System.Drawing.Size(240, 80);
            this.buttonLoadStudentInfo.TabIndex = 0;
            this.buttonLoadStudentInfo.Text = "학생정보 불러오기";
            this.buttonLoadStudentInfo.UseVisualStyleBackColor = true;
            this.buttonLoadStudentInfo.Click += new System.EventHandler(this.buttonLoadStudentInfo_Click);
            // 
            // groupBoxStudent1
            // 
            this.groupBoxStudent1.Controls.Add(this.buttonStudent1Delete);
            this.groupBoxStudent1.Controls.Add(this.buttonStudent1Save);
            this.groupBoxStudent1.Controls.Add(this.comboBoxStudent1Gender);
            this.groupBoxStudent1.Controls.Add(this.labelStudent1Gender);
            this.groupBoxStudent1.Controls.Add(this.textBoxStudent1Memo);
            this.groupBoxStudent1.Controls.Add(this.labelStudent1Memo);
            this.groupBoxStudent1.Controls.Add(this.textBoxStudent1ID);
            this.groupBoxStudent1.Controls.Add(this.labelStudent1ID);
            this.groupBoxStudent1.Controls.Add(this.textBoxStudent1Name);
            this.groupBoxStudent1.Controls.Add(this.labelStudent1Name);
            this.groupBoxStudent1.Location = new System.Drawing.Point(20, 120);
            this.groupBoxStudent1.Name = "groupBoxStudent1";
            this.groupBoxStudent1.Size = new System.Drawing.Size(240, 310);
            this.groupBoxStudent1.TabIndex = 1;
            this.groupBoxStudent1.TabStop = false;
            this.groupBoxStudent1.Text = "학생1";
            // 
            // buttonStudent1Delete
            // 
            this.buttonStudent1Delete.Location = new System.Drawing.Point(90, 273);
            this.buttonStudent1Delete.Name = "buttonStudent1Delete";
            this.buttonStudent1Delete.Size = new System.Drawing.Size(130, 24);
            this.buttonStudent1Delete.TabIndex = 7;
            this.buttonStudent1Delete.Text = "삭제";
            this.buttonStudent1Delete.UseVisualStyleBackColor = true;
            this.buttonStudent1Delete.Click += new System.EventHandler(this.buttonStudent1Delete_Click);
            // 
            // buttonStudent1Save
            // 
            this.buttonStudent1Save.Location = new System.Drawing.Point(90, 243);
            this.buttonStudent1Save.Name = "buttonStudent1Save";
            this.buttonStudent1Save.Size = new System.Drawing.Size(130, 24);
            this.buttonStudent1Save.TabIndex = 6;
            this.buttonStudent1Save.Text = "저장";
            this.buttonStudent1Save.UseVisualStyleBackColor = true;
            this.buttonStudent1Save.Click += new System.EventHandler(this.buttonStudent1Save_Click);
            // 
            // comboBoxStudent1Gender
            // 
            this.comboBoxStudent1Gender.FormattingEnabled = true;
            this.comboBoxStudent1Gender.Location = new System.Drawing.Point(90, 81);
            this.comboBoxStudent1Gender.Name = "comboBoxStudent1Gender";
            this.comboBoxStudent1Gender.Size = new System.Drawing.Size(130, 20);
            this.comboBoxStudent1Gender.TabIndex = 4;
            // 
            // labelStudent1Gender
            // 
            this.labelStudent1Gender.AutoSize = true;
            this.labelStudent1Gender.Location = new System.Drawing.Point(25, 84);
            this.labelStudent1Gender.Name = "labelStudent1Gender";
            this.labelStudent1Gender.Size = new System.Drawing.Size(29, 12);
            this.labelStudent1Gender.TabIndex = 0;
            this.labelStudent1Gender.Text = "성별";
            // 
            // textBoxStudent1Memo
            // 
            this.textBoxStudent1Memo.Location = new System.Drawing.Point(90, 107);
            this.textBoxStudent1Memo.Multiline = true;
            this.textBoxStudent1Memo.Name = "textBoxStudent1Memo";
            this.textBoxStudent1Memo.Size = new System.Drawing.Size(130, 130);
            this.textBoxStudent1Memo.TabIndex = 5;
            // 
            // labelStudent1Memo
            // 
            this.labelStudent1Memo.AutoSize = true;
            this.labelStudent1Memo.Location = new System.Drawing.Point(25, 110);
            this.labelStudent1Memo.Name = "labelStudent1Memo";
            this.labelStudent1Memo.Size = new System.Drawing.Size(29, 12);
            this.labelStudent1Memo.TabIndex = 0;
            this.labelStudent1Memo.Text = "메모";
            // 
            // textBoxStudent1ID
            // 
            this.textBoxStudent1ID.Location = new System.Drawing.Point(90, 54);
            this.textBoxStudent1ID.Name = "textBoxStudent1ID";
            this.textBoxStudent1ID.Size = new System.Drawing.Size(130, 21);
            this.textBoxStudent1ID.TabIndex = 3;
            // 
            // labelStudent1ID
            // 
            this.labelStudent1ID.AutoSize = true;
            this.labelStudent1ID.Location = new System.Drawing.Point(25, 57);
            this.labelStudent1ID.Name = "labelStudent1ID";
            this.labelStudent1ID.Size = new System.Drawing.Size(29, 12);
            this.labelStudent1ID.TabIndex = 0;
            this.labelStudent1ID.Text = "학번";
            // 
            // textBoxStudent1Name
            // 
            this.textBoxStudent1Name.Location = new System.Drawing.Point(90, 27);
            this.textBoxStudent1Name.Name = "textBoxStudent1Name";
            this.textBoxStudent1Name.Size = new System.Drawing.Size(130, 21);
            this.textBoxStudent1Name.TabIndex = 2;
            // 
            // labelStudent1Name
            // 
            this.labelStudent1Name.AutoSize = true;
            this.labelStudent1Name.Location = new System.Drawing.Point(25, 30);
            this.labelStudent1Name.Name = "labelStudent1Name";
            this.labelStudent1Name.Size = new System.Drawing.Size(29, 12);
            this.labelStudent1Name.TabIndex = 0;
            this.labelStudent1Name.Text = "이름";
            // 
            // groupBoxStudent2Info
            // 
            this.groupBoxStudent2Info.Controls.Add(this.buttonStudent2Delete);
            this.groupBoxStudent2Info.Controls.Add(this.buttonStudent2Save);
            this.groupBoxStudent2Info.Controls.Add(this.comboBoxStudent2Gender);
            this.groupBoxStudent2Info.Controls.Add(this.labelStudent2Gender);
            this.groupBoxStudent2Info.Controls.Add(this.textBoxStudent2Memo);
            this.groupBoxStudent2Info.Controls.Add(this.labelStudent2Memo);
            this.groupBoxStudent2Info.Controls.Add(this.textBoxStudent2ID);
            this.groupBoxStudent2Info.Controls.Add(this.labelStudent2ID);
            this.groupBoxStudent2Info.Controls.Add(this.textBoxStudent2Name);
            this.groupBoxStudent2Info.Controls.Add(this.labelStudent2Name);
            this.groupBoxStudent2Info.Location = new System.Drawing.Point(280, 120);
            this.groupBoxStudent2Info.Name = "groupBoxStudent2Info";
            this.groupBoxStudent2Info.Size = new System.Drawing.Size(240, 310);
            this.groupBoxStudent2Info.TabIndex = 1;
            this.groupBoxStudent2Info.TabStop = false;
            this.groupBoxStudent2Info.Text = "학생2";
            // 
            // buttonStudent2Delete
            // 
            this.buttonStudent2Delete.Location = new System.Drawing.Point(90, 273);
            this.buttonStudent2Delete.Name = "buttonStudent2Delete";
            this.buttonStudent2Delete.Size = new System.Drawing.Size(130, 24);
            this.buttonStudent2Delete.TabIndex = 13;
            this.buttonStudent2Delete.Text = "삭제";
            this.buttonStudent2Delete.UseVisualStyleBackColor = true;
            this.buttonStudent2Delete.Click += new System.EventHandler(this.buttonStudent2Delete_Click);
            // 
            // buttonStudent2Save
            // 
            this.buttonStudent2Save.Location = new System.Drawing.Point(90, 243);
            this.buttonStudent2Save.Name = "buttonStudent2Save";
            this.buttonStudent2Save.Size = new System.Drawing.Size(130, 24);
            this.buttonStudent2Save.TabIndex = 12;
            this.buttonStudent2Save.Text = "저장";
            this.buttonStudent2Save.UseVisualStyleBackColor = true;
            this.buttonStudent2Save.Click += new System.EventHandler(this.buttonStudent2Save_Click);
            // 
            // comboBoxStudent2Gender
            // 
            this.comboBoxStudent2Gender.FormattingEnabled = true;
            this.comboBoxStudent2Gender.Location = new System.Drawing.Point(90, 81);
            this.comboBoxStudent2Gender.Name = "comboBoxStudent2Gender";
            this.comboBoxStudent2Gender.Size = new System.Drawing.Size(130, 20);
            this.comboBoxStudent2Gender.TabIndex = 10;
            // 
            // labelStudent2Gender
            // 
            this.labelStudent2Gender.AutoSize = true;
            this.labelStudent2Gender.Location = new System.Drawing.Point(25, 84);
            this.labelStudent2Gender.Name = "labelStudent2Gender";
            this.labelStudent2Gender.Size = new System.Drawing.Size(29, 12);
            this.labelStudent2Gender.TabIndex = 0;
            this.labelStudent2Gender.Text = "성별";
            // 
            // textBoxStudent2Memo
            // 
            this.textBoxStudent2Memo.Location = new System.Drawing.Point(90, 107);
            this.textBoxStudent2Memo.Multiline = true;
            this.textBoxStudent2Memo.Name = "textBoxStudent2Memo";
            this.textBoxStudent2Memo.Size = new System.Drawing.Size(130, 130);
            this.textBoxStudent2Memo.TabIndex = 11;
            // 
            // labelStudent2Memo
            // 
            this.labelStudent2Memo.AutoSize = true;
            this.labelStudent2Memo.Location = new System.Drawing.Point(25, 110);
            this.labelStudent2Memo.Name = "labelStudent2Memo";
            this.labelStudent2Memo.Size = new System.Drawing.Size(29, 12);
            this.labelStudent2Memo.TabIndex = 0;
            this.labelStudent2Memo.Text = "메모";
            // 
            // textBoxStudent2ID
            // 
            this.textBoxStudent2ID.Location = new System.Drawing.Point(90, 54);
            this.textBoxStudent2ID.Name = "textBoxStudent2ID";
            this.textBoxStudent2ID.Size = new System.Drawing.Size(130, 21);
            this.textBoxStudent2ID.TabIndex = 9;
            // 
            // labelStudent2ID
            // 
            this.labelStudent2ID.AutoSize = true;
            this.labelStudent2ID.Location = new System.Drawing.Point(25, 57);
            this.labelStudent2ID.Name = "labelStudent2ID";
            this.labelStudent2ID.Size = new System.Drawing.Size(29, 12);
            this.labelStudent2ID.TabIndex = 0;
            this.labelStudent2ID.Text = "학번";
            // 
            // textBoxStudent2Name
            // 
            this.textBoxStudent2Name.Location = new System.Drawing.Point(90, 27);
            this.textBoxStudent2Name.Name = "textBoxStudent2Name";
            this.textBoxStudent2Name.Size = new System.Drawing.Size(130, 21);
            this.textBoxStudent2Name.TabIndex = 8;
            // 
            // labelStudent2Name
            // 
            this.labelStudent2Name.AutoSize = true;
            this.labelStudent2Name.Location = new System.Drawing.Point(25, 30);
            this.labelStudent2Name.Name = "labelStudent2Name";
            this.labelStudent2Name.Size = new System.Drawing.Size(29, 12);
            this.labelStudent2Name.TabIndex = 0;
            this.labelStudent2Name.Text = "이름";
            // 
            // groupBoxStudent3Info
            // 
            this.groupBoxStudent3Info.Controls.Add(this.buttonStudent3Delete);
            this.groupBoxStudent3Info.Controls.Add(this.buttonStudent3Save);
            this.groupBoxStudent3Info.Controls.Add(this.comboBoxStudent3Gender);
            this.groupBoxStudent3Info.Controls.Add(this.labelStudent3Gender);
            this.groupBoxStudent3Info.Controls.Add(this.textBoxStudent3Memo);
            this.groupBoxStudent3Info.Controls.Add(this.labelStudent3Memo);
            this.groupBoxStudent3Info.Controls.Add(this.textBoxStudent3ID);
            this.groupBoxStudent3Info.Controls.Add(this.labelStudent3ID);
            this.groupBoxStudent3Info.Controls.Add(this.textBoxStudent3Name);
            this.groupBoxStudent3Info.Controls.Add(this.labelStudent3Name);
            this.groupBoxStudent3Info.Location = new System.Drawing.Point(540, 120);
            this.groupBoxStudent3Info.Name = "groupBoxStudent3Info";
            this.groupBoxStudent3Info.Size = new System.Drawing.Size(240, 310);
            this.groupBoxStudent3Info.TabIndex = 1;
            this.groupBoxStudent3Info.TabStop = false;
            this.groupBoxStudent3Info.Text = "학생3";
            // 
            // buttonStudent3Delete
            // 
            this.buttonStudent3Delete.Location = new System.Drawing.Point(90, 273);
            this.buttonStudent3Delete.Name = "buttonStudent3Delete";
            this.buttonStudent3Delete.Size = new System.Drawing.Size(130, 24);
            this.buttonStudent3Delete.TabIndex = 19;
            this.buttonStudent3Delete.Text = "삭제";
            this.buttonStudent3Delete.UseVisualStyleBackColor = true;
            this.buttonStudent3Delete.Click += new System.EventHandler(this.buttonStudent3Delete_Click);
            // 
            // buttonStudent3Save
            // 
            this.buttonStudent3Save.Location = new System.Drawing.Point(90, 243);
            this.buttonStudent3Save.Name = "buttonStudent3Save";
            this.buttonStudent3Save.Size = new System.Drawing.Size(130, 24);
            this.buttonStudent3Save.TabIndex = 18;
            this.buttonStudent3Save.Text = "저장";
            this.buttonStudent3Save.UseVisualStyleBackColor = true;
            this.buttonStudent3Save.Click += new System.EventHandler(this.buttonStudent3Save_Click);
            // 
            // comboBoxStudent3Gender
            // 
            this.comboBoxStudent3Gender.FormattingEnabled = true;
            this.comboBoxStudent3Gender.Location = new System.Drawing.Point(90, 81);
            this.comboBoxStudent3Gender.Name = "comboBoxStudent3Gender";
            this.comboBoxStudent3Gender.Size = new System.Drawing.Size(130, 20);
            this.comboBoxStudent3Gender.TabIndex = 16;
            // 
            // labelStudent3Gender
            // 
            this.labelStudent3Gender.AutoSize = true;
            this.labelStudent3Gender.Location = new System.Drawing.Point(25, 84);
            this.labelStudent3Gender.Name = "labelStudent3Gender";
            this.labelStudent3Gender.Size = new System.Drawing.Size(29, 12);
            this.labelStudent3Gender.TabIndex = 0;
            this.labelStudent3Gender.Text = "성별";
            // 
            // textBoxStudent3Memo
            // 
            this.textBoxStudent3Memo.Location = new System.Drawing.Point(90, 107);
            this.textBoxStudent3Memo.Multiline = true;
            this.textBoxStudent3Memo.Name = "textBoxStudent3Memo";
            this.textBoxStudent3Memo.Size = new System.Drawing.Size(130, 130);
            this.textBoxStudent3Memo.TabIndex = 17;
            // 
            // labelStudent3Memo
            // 
            this.labelStudent3Memo.AutoSize = true;
            this.labelStudent3Memo.Location = new System.Drawing.Point(25, 110);
            this.labelStudent3Memo.Name = "labelStudent3Memo";
            this.labelStudent3Memo.Size = new System.Drawing.Size(29, 12);
            this.labelStudent3Memo.TabIndex = 0;
            this.labelStudent3Memo.Text = "메모";
            // 
            // textBoxStudent3ID
            // 
            this.textBoxStudent3ID.Location = new System.Drawing.Point(90, 54);
            this.textBoxStudent3ID.Name = "textBoxStudent3ID";
            this.textBoxStudent3ID.Size = new System.Drawing.Size(130, 21);
            this.textBoxStudent3ID.TabIndex = 15;
            // 
            // labelStudent3ID
            // 
            this.labelStudent3ID.AutoSize = true;
            this.labelStudent3ID.Location = new System.Drawing.Point(25, 57);
            this.labelStudent3ID.Name = "labelStudent3ID";
            this.labelStudent3ID.Size = new System.Drawing.Size(29, 12);
            this.labelStudent3ID.TabIndex = 0;
            this.labelStudent3ID.Text = "학번";
            // 
            // textBoxStudent3Name
            // 
            this.textBoxStudent3Name.Location = new System.Drawing.Point(90, 27);
            this.textBoxStudent3Name.Name = "textBoxStudent3Name";
            this.textBoxStudent3Name.Size = new System.Drawing.Size(130, 21);
            this.textBoxStudent3Name.TabIndex = 14;
            // 
            // labelStudent3Name
            // 
            this.labelStudent3Name.AutoSize = true;
            this.labelStudent3Name.Location = new System.Drawing.Point(25, 30);
            this.labelStudent3Name.Name = "labelStudent3Name";
            this.labelStudent3Name.Size = new System.Drawing.Size(29, 12);
            this.labelStudent3Name.TabIndex = 0;
            this.labelStudent3Name.Text = "이름";
            // 
            // groupBoxSettingInfo
            // 
            this.groupBoxSettingInfo.Controls.Add(this.labelSettingInfo);
            this.groupBoxSettingInfo.Controls.Add(this.checkBoxSettingInfo);
            this.groupBoxSettingInfo.Location = new System.Drawing.Point(280, 20);
            this.groupBoxSettingInfo.Name = "groupBoxSettingInfo";
            this.groupBoxSettingInfo.Size = new System.Drawing.Size(500, 80);
            this.groupBoxSettingInfo.TabIndex = 2;
            this.groupBoxSettingInfo.TabStop = false;
            this.groupBoxSettingInfo.Text = "설정 및 정보";
            // 
            // labelSettingInfo
            // 
            this.labelSettingInfo.AutoSize = true;
            this.labelSettingInfo.Location = new System.Drawing.Point(25, 50);
            this.labelSettingInfo.Name = "labelSettingInfo";
            this.labelSettingInfo.Size = new System.Drawing.Size(131, 12);
            this.labelSettingInfo.TabIndex = 1;
            this.labelSettingInfo.Text = "현재 저장된 학생 수 : 0";
            // 
            // checkBoxSettingInfo
            // 
            this.checkBoxSettingInfo.AutoSize = true;
            this.checkBoxSettingInfo.Location = new System.Drawing.Point(25, 25);
            this.checkBoxSettingInfo.Name = "checkBoxSettingInfo";
            this.checkBoxSettingInfo.Size = new System.Drawing.Size(244, 16);
            this.checkBoxSettingInfo.TabIndex = 1;
            this.checkBoxSettingInfo.Text = "프로그램 시작시 자동으로 학생정보 로드";
            this.checkBoxSettingInfo.UseVisualStyleBackColor = true;
            this.checkBoxSettingInfo.CheckedChanged += new System.EventHandler(this.checkBoxSettingInfo_CheckedChanged);
            // 
            // Assignment06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxSettingInfo);
            this.Controls.Add(this.groupBoxStudent3Info);
            this.Controls.Add(this.groupBoxStudent2Info);
            this.Controls.Add(this.groupBoxStudent1);
            this.Controls.Add(this.buttonLoadStudentInfo);
            this.Name = "Assignment06";
            this.Text = "데이터베이스 프로그래밍 실습2";
            this.groupBoxStudent1.ResumeLayout(false);
            this.groupBoxStudent1.PerformLayout();
            this.groupBoxStudent2Info.ResumeLayout(false);
            this.groupBoxStudent2Info.PerformLayout();
            this.groupBoxStudent3Info.ResumeLayout(false);
            this.groupBoxStudent3Info.PerformLayout();
            this.groupBoxSettingInfo.ResumeLayout(false);
            this.groupBoxSettingInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadStudentInfo;
        private System.Windows.Forms.GroupBox groupBoxStudent1;
        private System.Windows.Forms.Label labelStudent1Name;
        private System.Windows.Forms.TextBox textBoxStudent1Name;
        private System.Windows.Forms.Label labelStudent1Gender;
        private System.Windows.Forms.TextBox textBoxStudent1ID;
        private System.Windows.Forms.Label labelStudent1ID;
        private System.Windows.Forms.ComboBox comboBoxStudent1Gender;
        private System.Windows.Forms.TextBox textBoxStudent1Memo;
        private System.Windows.Forms.Label labelStudent1Memo;
        private System.Windows.Forms.Button buttonStudent1Save;
        private System.Windows.Forms.Button buttonStudent1Delete;
        private System.Windows.Forms.GroupBox groupBoxStudent2Info;
        private System.Windows.Forms.Button buttonStudent2Delete;
        private System.Windows.Forms.Button buttonStudent2Save;
        private System.Windows.Forms.ComboBox comboBoxStudent2Gender;
        private System.Windows.Forms.Label labelStudent2Gender;
        private System.Windows.Forms.TextBox textBoxStudent2Memo;
        private System.Windows.Forms.Label labelStudent2Memo;
        private System.Windows.Forms.TextBox textBoxStudent2ID;
        private System.Windows.Forms.Label labelStudent2ID;
        private System.Windows.Forms.TextBox textBoxStudent2Name;
        private System.Windows.Forms.Label labelStudent2Name;
        private System.Windows.Forms.GroupBox groupBoxStudent3Info;
        private System.Windows.Forms.Button buttonStudent3Delete;
        private System.Windows.Forms.Button buttonStudent3Save;
        private System.Windows.Forms.ComboBox comboBoxStudent3Gender;
        private System.Windows.Forms.Label labelStudent3Gender;
        private System.Windows.Forms.TextBox textBoxStudent3Memo;
        private System.Windows.Forms.Label labelStudent3Memo;
        private System.Windows.Forms.TextBox textBoxStudent3ID;
        private System.Windows.Forms.Label labelStudent3ID;
        private System.Windows.Forms.TextBox textBoxStudent3Name;
        private System.Windows.Forms.Label labelStudent3Name;
        private System.Windows.Forms.GroupBox groupBoxSettingInfo;
        private System.Windows.Forms.CheckBox checkBoxSettingInfo;
        private System.Windows.Forms.Label labelSettingInfo;
    }
}


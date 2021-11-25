
namespace Gugbab
{
    partial class FormGugbab
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.labelPW = new System.Windows.Forms.Label();
            this.labelSignStatement = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.groupBoxCasher = new System.Windows.Forms.GroupBox();
            this.buttonCasher_Sundae = new System.Windows.Forms.Button();
            this.buttonCasher_Mix = new System.Windows.Forms.Button();
            this.buttonCasher_Pig = new System.Windows.Forms.Button();
            this.dateTimePickerCasher = new System.Windows.Forms.DateTimePicker();
            this.groupBoxManager = new System.Windows.Forms.GroupBox();
            this.dataGridViewTotal = new System.Windows.Forms.DataGridView();
            this.labelManagerTotal = new System.Windows.Forms.Label();
            this.buttonManagerTotal = new System.Windows.Forms.Button();
            this.dataGridViewUser1DateSell = new System.Windows.Forms.DataGridView();
            this.labelUser1DateSell = new System.Windows.Forms.Label();
            this.buttonUser1DateSell = new System.Windows.Forms.Button();
            this.labelUser2DateSell = new System.Windows.Forms.Label();
            this.buttonUser2DateSell = new System.Windows.Forms.Button();
            this.dataGridViewUser2DateSell = new System.Windows.Forms.DataGridView();
            this.comboBoxGugbab_typeDateSell = new System.Windows.Forms.ComboBox();
            this.labelGugbab_type = new System.Windows.Forms.Label();
            this.dataGridViewGugbab_typeDateSell = new System.Windows.Forms.DataGridView();
            this.buttonGugbab_typeDateSell = new System.Windows.Forms.Button();
            this.buttonGugbab_typeMonthSell = new System.Windows.Forms.Button();
            this.dataGridViewGugbab_typeMonthSell = new System.Windows.Forms.DataGridView();
            this.comboBoxGugbab_typeMonthSell = new System.Windows.Forms.ComboBox();
            this.labelGugbab_typeMonthSell = new System.Windows.Forms.Label();
            this.groupBoxCasher.SuspendLayout();
            this.groupBoxManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser1DateSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser2DateSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGugbab_typeDateSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGugbab_typeMonthSell)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(33, 26);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ShortcutsEnabled = false;
            this.textBoxID.Size = new System.Drawing.Size(88, 21);
            this.textBoxID.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(10, 29);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(16, 12);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID";
            // 
            // labelSignIn
            // 
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.Location = new System.Drawing.Point(10, 7);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(44, 12);
            this.labelSignIn.TabIndex = 1;
            this.labelSignIn.Text = "Sign In";
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(164, 26);
            this.textBoxPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.Size = new System.Drawing.Size(88, 21);
            this.textBoxPW.TabIndex = 2;
            this.textBoxPW.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPW_KeyUp);
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.Location = new System.Drawing.Point(132, 29);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(23, 12);
            this.labelPW.TabIndex = 1;
            this.labelPW.Text = "PW";
            // 
            // labelSignStatement
            // 
            this.labelSignStatement.AutoSize = true;
            this.labelSignStatement.Location = new System.Drawing.Point(351, 30);
            this.labelSignStatement.Name = "labelSignStatement";
            this.labelSignStatement.Size = new System.Drawing.Size(142, 12);
            this.labelSignStatement.TabIndex = 2;
            this.labelSignStatement.Text = "ID와 PW를 입력해주세요.";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(271, 25);
            this.buttonSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(74, 22);
            this.buttonSignIn.TabIndex = 3;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(615, 26);
            this.buttonSignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(74, 21);
            this.buttonSignOut.TabIndex = 4;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // groupBoxCasher
            // 
            this.groupBoxCasher.Controls.Add(this.buttonCasher_Sundae);
            this.groupBoxCasher.Controls.Add(this.buttonCasher_Mix);
            this.groupBoxCasher.Controls.Add(this.buttonCasher_Pig);
            this.groupBoxCasher.Controls.Add(this.dateTimePickerCasher);
            this.groupBoxCasher.Location = new System.Drawing.Point(13, 66);
            this.groupBoxCasher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCasher.Name = "groupBoxCasher";
            this.groupBoxCasher.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCasher.Size = new System.Drawing.Size(676, 129);
            this.groupBoxCasher.TabIndex = 4;
            this.groupBoxCasher.TabStop = false;
            this.groupBoxCasher.Text = "캐셔용 화면";
            // 
            // buttonCasher_Sundae
            // 
            this.buttonCasher_Sundae.Location = new System.Drawing.Point(496, 76);
            this.buttonCasher_Sundae.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCasher_Sundae.Name = "buttonCasher_Sundae";
            this.buttonCasher_Sundae.Size = new System.Drawing.Size(175, 48);
            this.buttonCasher_Sundae.TabIndex = 7;
            this.buttonCasher_Sundae.Text = "순대국밥";
            this.buttonCasher_Sundae.UseVisualStyleBackColor = true;
            this.buttonCasher_Sundae.Click += new System.EventHandler(this.buttonCasher_Sundae_Click);
            // 
            // buttonCasher_Mix
            // 
            this.buttonCasher_Mix.Location = new System.Drawing.Point(258, 76);
            this.buttonCasher_Mix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCasher_Mix.Name = "buttonCasher_Mix";
            this.buttonCasher_Mix.Size = new System.Drawing.Size(175, 48);
            this.buttonCasher_Mix.TabIndex = 6;
            this.buttonCasher_Mix.Text = "섞어국밥";
            this.buttonCasher_Mix.UseVisualStyleBackColor = true;
            this.buttonCasher_Mix.Click += new System.EventHandler(this.buttonCasher_Mix_Click);
            // 
            // buttonCasher_Pig
            // 
            this.buttonCasher_Pig.Location = new System.Drawing.Point(5, 76);
            this.buttonCasher_Pig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCasher_Pig.Name = "buttonCasher_Pig";
            this.buttonCasher_Pig.Size = new System.Drawing.Size(175, 48);
            this.buttonCasher_Pig.TabIndex = 5;
            this.buttonCasher_Pig.Text = "돼지국밥";
            this.buttonCasher_Pig.UseVisualStyleBackColor = true;
            this.buttonCasher_Pig.Click += new System.EventHandler(this.buttonCasher_Pig_Click);
            // 
            // dateTimePickerCasher
            // 
            this.dateTimePickerCasher.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimePickerCasher.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCasher.Location = new System.Drawing.Point(6, 18);
            this.dateTimePickerCasher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerCasher.Name = "dateTimePickerCasher";
            this.dateTimePickerCasher.Size = new System.Drawing.Size(207, 21);
            this.dateTimePickerCasher.TabIndex = 9;
            this.dateTimePickerCasher.TabStop = false;
            // 
            // groupBoxManager
            // 
            this.groupBoxManager.Controls.Add(this.labelGugbab_typeMonthSell);
            this.groupBoxManager.Controls.Add(this.labelGugbab_type);
            this.groupBoxManager.Controls.Add(this.comboBoxGugbab_typeMonthSell);
            this.groupBoxManager.Controls.Add(this.comboBoxGugbab_typeDateSell);
            this.groupBoxManager.Controls.Add(this.dataGridViewGugbab_typeMonthSell);
            this.groupBoxManager.Controls.Add(this.dataGridViewGugbab_typeDateSell);
            this.groupBoxManager.Controls.Add(this.buttonGugbab_typeMonthSell);
            this.groupBoxManager.Controls.Add(this.dataGridViewUser2DateSell);
            this.groupBoxManager.Controls.Add(this.buttonGugbab_typeDateSell);
            this.groupBoxManager.Controls.Add(this.buttonUser2DateSell);
            this.groupBoxManager.Controls.Add(this.dataGridViewUser1DateSell);
            this.groupBoxManager.Controls.Add(this.buttonUser1DateSell);
            this.groupBoxManager.Controls.Add(this.labelUser2DateSell);
            this.groupBoxManager.Controls.Add(this.buttonManagerTotal);
            this.groupBoxManager.Controls.Add(this.labelUser1DateSell);
            this.groupBoxManager.Controls.Add(this.labelManagerTotal);
            this.groupBoxManager.Controls.Add(this.dataGridViewTotal);
            this.groupBoxManager.Location = new System.Drawing.Point(13, 200);
            this.groupBoxManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxManager.Name = "groupBoxManager";
            this.groupBoxManager.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxManager.Size = new System.Drawing.Size(676, 762);
            this.groupBoxManager.TabIndex = 2;
            this.groupBoxManager.TabStop = false;
            this.groupBoxManager.Text = "관리자용 화면";
            // 
            // dataGridViewTotal
            // 
            this.dataGridViewTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotal.Location = new System.Drawing.Point(6, 33);
            this.dataGridViewTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTotal.Name = "dataGridViewTotal";
            this.dataGridViewTotal.RowHeadersWidth = 51;
            this.dataGridViewTotal.RowTemplate.Height = 27;
            this.dataGridViewTotal.Size = new System.Drawing.Size(662, 120);
            this.dataGridViewTotal.TabIndex = 8;
            this.dataGridViewTotal.TabStop = false;
            // 
            // labelManagerTotal
            // 
            this.labelManagerTotal.AutoSize = true;
            this.labelManagerTotal.Location = new System.Drawing.Point(6, 16);
            this.labelManagerTotal.Name = "labelManagerTotal";
            this.labelManagerTotal.Size = new System.Drawing.Size(97, 12);
            this.labelManagerTotal.TabIndex = 9;
            this.labelManagerTotal.Text = "국밥 총 판매현황";
            // 
            // buttonManagerTotal
            // 
            this.buttonManagerTotal.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonManagerTotal.Location = new System.Drawing.Point(109, 11);
            this.buttonManagerTotal.Name = "buttonManagerTotal";
            this.buttonManagerTotal.Size = new System.Drawing.Size(20, 20);
            this.buttonManagerTotal.TabIndex = 10;
            this.buttonManagerTotal.Text = "✔";
            this.buttonManagerTotal.UseVisualStyleBackColor = true;
            this.buttonManagerTotal.Click += new System.EventHandler(this.buttonManagerTotal_Click);
            // 
            // dataGridViewUser1DateSell
            // 
            this.dataGridViewUser1DateSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser1DateSell.Location = new System.Drawing.Point(6, 177);
            this.dataGridViewUser1DateSell.Name = "dataGridViewUser1DateSell";
            this.dataGridViewUser1DateSell.RowTemplate.Height = 23;
            this.dataGridViewUser1DateSell.Size = new System.Drawing.Size(662, 120);
            this.dataGridViewUser1DateSell.TabIndex = 11;
            this.dataGridViewUser1DateSell.TabStop = false;
            // 
            // labelUser1DateSell
            // 
            this.labelUser1DateSell.AutoSize = true;
            this.labelUser1DateSell.Location = new System.Drawing.Point(6, 161);
            this.labelUser1DateSell.Name = "labelUser1DateSell";
            this.labelUser1DateSell.Size = new System.Drawing.Size(93, 12);
            this.labelUser1DateSell.TabIndex = 9;
            this.labelUser1DateSell.Text = "User1 일일 판매";
            // 
            // buttonUser1DateSell
            // 
            this.buttonUser1DateSell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonUser1DateSell.Location = new System.Drawing.Point(109, 156);
            this.buttonUser1DateSell.Name = "buttonUser1DateSell";
            this.buttonUser1DateSell.Size = new System.Drawing.Size(20, 20);
            this.buttonUser1DateSell.TabIndex = 10;
            this.buttonUser1DateSell.Text = "✔";
            this.buttonUser1DateSell.UseVisualStyleBackColor = true;
            this.buttonUser1DateSell.Click += new System.EventHandler(this.buttonUser1DateSell_Click);
            // 
            // labelUser2DateSell
            // 
            this.labelUser2DateSell.AutoSize = true;
            this.labelUser2DateSell.Location = new System.Drawing.Point(6, 308);
            this.labelUser2DateSell.Name = "labelUser2DateSell";
            this.labelUser2DateSell.Size = new System.Drawing.Size(93, 12);
            this.labelUser2DateSell.TabIndex = 9;
            this.labelUser2DateSell.Text = "User2 일일 판매";
            // 
            // buttonUser2DateSell
            // 
            this.buttonUser2DateSell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonUser2DateSell.Location = new System.Drawing.Point(109, 303);
            this.buttonUser2DateSell.Name = "buttonUser2DateSell";
            this.buttonUser2DateSell.Size = new System.Drawing.Size(20, 20);
            this.buttonUser2DateSell.TabIndex = 10;
            this.buttonUser2DateSell.Text = "✔";
            this.buttonUser2DateSell.UseVisualStyleBackColor = true;
            this.buttonUser2DateSell.Click += new System.EventHandler(this.buttonUser2DateSell_Click);
            // 
            // dataGridViewUser2DateSell
            // 
            this.dataGridViewUser2DateSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser2DateSell.Location = new System.Drawing.Point(6, 323);
            this.dataGridViewUser2DateSell.Name = "dataGridViewUser2DateSell";
            this.dataGridViewUser2DateSell.RowTemplate.Height = 23;
            this.dataGridViewUser2DateSell.Size = new System.Drawing.Size(662, 120);
            this.dataGridViewUser2DateSell.TabIndex = 11;
            this.dataGridViewUser2DateSell.TabStop = false;
            // 
            // comboBoxGugbab_typeDateSell
            // 
            this.comboBoxGugbab_typeDateSell.FormattingEnabled = true;
            this.comboBoxGugbab_typeDateSell.Items.AddRange(new object[] {
            "돼지",
            "섞어",
            "순대"});
            this.comboBoxGugbab_typeDateSell.Location = new System.Drawing.Point(5, 449);
            this.comboBoxGugbab_typeDateSell.Name = "comboBoxGugbab_typeDateSell";
            this.comboBoxGugbab_typeDateSell.Size = new System.Drawing.Size(74, 20);
            this.comboBoxGugbab_typeDateSell.TabIndex = 12;
            this.comboBoxGugbab_typeDateSell.TabStop = false;
            // 
            // labelGugbab_type
            // 
            this.labelGugbab_type.AutoSize = true;
            this.labelGugbab_type.Location = new System.Drawing.Point(85, 452);
            this.labelGugbab_type.Name = "labelGugbab_type";
            this.labelGugbab_type.Size = new System.Drawing.Size(57, 12);
            this.labelGugbab_type.TabIndex = 13;
            this.labelGugbab_type.Text = "일일 판매";
            // 
            // dataGridViewGugbab_typeDateSell
            // 
            this.dataGridViewGugbab_typeDateSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGugbab_typeDateSell.Location = new System.Drawing.Point(5, 475);
            this.dataGridViewGugbab_typeDateSell.Name = "dataGridViewGugbab_typeDateSell";
            this.dataGridViewGugbab_typeDateSell.RowTemplate.Height = 23;
            this.dataGridViewGugbab_typeDateSell.Size = new System.Drawing.Size(662, 120);
            this.dataGridViewGugbab_typeDateSell.TabIndex = 11;
            this.dataGridViewGugbab_typeDateSell.TabStop = false;
            // 
            // buttonGugbab_typeDateSell
            // 
            this.buttonGugbab_typeDateSell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonGugbab_typeDateSell.Location = new System.Drawing.Point(148, 447);
            this.buttonGugbab_typeDateSell.Name = "buttonGugbab_typeDateSell";
            this.buttonGugbab_typeDateSell.Size = new System.Drawing.Size(20, 20);
            this.buttonGugbab_typeDateSell.TabIndex = 10;
            this.buttonGugbab_typeDateSell.Text = "✔";
            this.buttonGugbab_typeDateSell.UseVisualStyleBackColor = true;
            this.buttonGugbab_typeDateSell.Click += new System.EventHandler(this.buttonGugbab_type_Click);
            // 
            // buttonGugbab_typeMonthSell
            // 
            this.buttonGugbab_typeMonthSell.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonGugbab_typeMonthSell.Location = new System.Drawing.Point(148, 599);
            this.buttonGugbab_typeMonthSell.Name = "buttonGugbab_typeMonthSell";
            this.buttonGugbab_typeMonthSell.Size = new System.Drawing.Size(20, 20);
            this.buttonGugbab_typeMonthSell.TabIndex = 10;
            this.buttonGugbab_typeMonthSell.Text = "✔";
            this.buttonGugbab_typeMonthSell.UseVisualStyleBackColor = true;
            this.buttonGugbab_typeMonthSell.Click += new System.EventHandler(this.buttonGugbab_typeMonthSell_Click);
            // 
            // dataGridViewGugbab_typeMonthSell
            // 
            this.dataGridViewGugbab_typeMonthSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGugbab_typeMonthSell.Location = new System.Drawing.Point(5, 627);
            this.dataGridViewGugbab_typeMonthSell.Name = "dataGridViewGugbab_typeMonthSell";
            this.dataGridViewGugbab_typeMonthSell.RowTemplate.Height = 23;
            this.dataGridViewGugbab_typeMonthSell.Size = new System.Drawing.Size(662, 120);
            this.dataGridViewGugbab_typeMonthSell.TabIndex = 11;
            this.dataGridViewGugbab_typeMonthSell.TabStop = false;
            // 
            // comboBoxGugbab_typeMonthSell
            // 
            this.comboBoxGugbab_typeMonthSell.FormattingEnabled = true;
            this.comboBoxGugbab_typeMonthSell.Items.AddRange(new object[] {
            "돼지",
            "섞어",
            "순대"});
            this.comboBoxGugbab_typeMonthSell.Location = new System.Drawing.Point(5, 601);
            this.comboBoxGugbab_typeMonthSell.Name = "comboBoxGugbab_typeMonthSell";
            this.comboBoxGugbab_typeMonthSell.Size = new System.Drawing.Size(74, 20);
            this.comboBoxGugbab_typeMonthSell.TabIndex = 12;
            this.comboBoxGugbab_typeMonthSell.TabStop = false;
            // 
            // labelGugbab_typeMonthSell
            // 
            this.labelGugbab_typeMonthSell.AutoSize = true;
            this.labelGugbab_typeMonthSell.Location = new System.Drawing.Point(85, 604);
            this.labelGugbab_typeMonthSell.Name = "labelGugbab_typeMonthSell";
            this.labelGugbab_typeMonthSell.Size = new System.Drawing.Size(57, 12);
            this.labelGugbab_typeMonthSell.TabIndex = 13;
            this.labelGugbab_typeMonthSell.Text = "월별 판매";
            // 
            // FormGugbab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 973);
            this.Controls.Add(this.groupBoxManager);
            this.Controls.Add(this.groupBoxCasher);
            this.Controls.Add(this.buttonSignOut);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.labelSignStatement);
            this.Controls.Add(this.labelSignIn);
            this.Controls.Add(this.labelPW);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.textBoxID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGugbab";
            this.Text = "국밥매상프로그램";
            this.groupBoxCasher.ResumeLayout(false);
            this.groupBoxManager.ResumeLayout(false);
            this.groupBoxManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser1DateSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser2DateSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGugbab_typeDateSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGugbab_typeMonthSell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelSignIn;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.Label labelSignStatement;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.GroupBox groupBoxCasher;
        private System.Windows.Forms.Button buttonCasher_Sundae;
        private System.Windows.Forms.Button buttonCasher_Mix;
        private System.Windows.Forms.Button buttonCasher_Pig;
        private System.Windows.Forms.DateTimePicker dateTimePickerCasher;
        private System.Windows.Forms.GroupBox groupBoxManager;
        private System.Windows.Forms.DataGridView dataGridViewTotal;
        private System.Windows.Forms.Label labelManagerTotal;
        private System.Windows.Forms.Button buttonManagerTotal;
        private System.Windows.Forms.DataGridView dataGridViewUser1DateSell;
        private System.Windows.Forms.Label labelUser1DateSell;
        private System.Windows.Forms.Button buttonUser1DateSell;
        private System.Windows.Forms.DataGridView dataGridViewUser2DateSell;
        private System.Windows.Forms.Button buttonUser2DateSell;
        private System.Windows.Forms.Label labelUser2DateSell;
        private System.Windows.Forms.Label labelGugbab_type;
        private System.Windows.Forms.ComboBox comboBoxGugbab_typeDateSell;
        private System.Windows.Forms.DataGridView dataGridViewGugbab_typeDateSell;
        private System.Windows.Forms.Button buttonGugbab_typeDateSell;
        private System.Windows.Forms.Label labelGugbab_typeMonthSell;
        private System.Windows.Forms.ComboBox comboBoxGugbab_typeMonthSell;
        private System.Windows.Forms.DataGridView dataGridViewGugbab_typeMonthSell;
        private System.Windows.Forms.Button buttonGugbab_typeMonthSell;
    }
}


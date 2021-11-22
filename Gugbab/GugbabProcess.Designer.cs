
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
            this.buttonCasher_Blood = new System.Windows.Forms.Button();
            this.buttonCasher_Mix = new System.Windows.Forms.Button();
            this.buttonCasher_Cowhead = new System.Windows.Forms.Button();
            this.dateTimePickerCasher = new System.Windows.Forms.DateTimePicker();
            this.groupBoxManager = new System.Windows.Forms.GroupBox();
            this.dataGridViewManager = new System.Windows.Forms.DataGridView();
            this.groupBoxCasher.SuspendLayout();
            this.groupBoxManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).BeginInit();
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
            this.groupBoxCasher.Controls.Add(this.buttonCasher_Blood);
            this.groupBoxCasher.Controls.Add(this.buttonCasher_Mix);
            this.groupBoxCasher.Controls.Add(this.buttonCasher_Cowhead);
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
            // buttonCasher_Blood
            // 
            this.buttonCasher_Blood.Location = new System.Drawing.Point(496, 76);
            this.buttonCasher_Blood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCasher_Blood.Name = "buttonCasher_Blood";
            this.buttonCasher_Blood.Size = new System.Drawing.Size(175, 48);
            this.buttonCasher_Blood.TabIndex = 7;
            this.buttonCasher_Blood.Text = "선지국밥";
            this.buttonCasher_Blood.UseVisualStyleBackColor = true;
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
            // 
            // buttonCasher_Cowhead
            // 
            this.buttonCasher_Cowhead.Location = new System.Drawing.Point(5, 76);
            this.buttonCasher_Cowhead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCasher_Cowhead.Name = "buttonCasher_Cowhead";
            this.buttonCasher_Cowhead.Size = new System.Drawing.Size(175, 48);
            this.buttonCasher_Cowhead.TabIndex = 5;
            this.buttonCasher_Cowhead.Text = "소머리국밥";
            this.buttonCasher_Cowhead.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerCasher
            // 
            this.dateTimePickerCasher.Location = new System.Drawing.Point(6, 18);
            this.dateTimePickerCasher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerCasher.Name = "dateTimePickerCasher";
            this.dateTimePickerCasher.Size = new System.Drawing.Size(207, 21);
            this.dateTimePickerCasher.TabIndex = 9;
            // 
            // groupBoxManager
            // 
            this.groupBoxManager.Controls.Add(this.dataGridViewManager);
            this.groupBoxManager.Location = new System.Drawing.Point(13, 200);
            this.groupBoxManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxManager.Name = "groupBoxManager";
            this.groupBoxManager.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxManager.Size = new System.Drawing.Size(676, 350);
            this.groupBoxManager.TabIndex = 2;
            this.groupBoxManager.TabStop = false;
            this.groupBoxManager.Text = "관리자용 화면";
            // 
            // dataGridViewManager
            // 
            this.dataGridViewManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManager.Location = new System.Drawing.Point(5, 18);
            this.dataGridViewManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewManager.Name = "dataGridViewManager";
            this.dataGridViewManager.RowHeadersWidth = 51;
            this.dataGridViewManager.RowTemplate.Height = 27;
            this.dataGridViewManager.Size = new System.Drawing.Size(340, 121);
            this.dataGridViewManager.TabIndex = 8;
            this.dataGridViewManager.TabStop = false;
            // 
            // FormGugbab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 561);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).EndInit();
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
        private System.Windows.Forms.Button buttonCasher_Blood;
        private System.Windows.Forms.Button buttonCasher_Mix;
        private System.Windows.Forms.Button buttonCasher_Cowhead;
        private System.Windows.Forms.DateTimePicker dateTimePickerCasher;
        private System.Windows.Forms.GroupBox groupBoxManager;
        private System.Windows.Forms.DataGridView dataGridViewManager;
    }
}



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
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.groupBoxCasher = new System.Windows.Forms.GroupBox();
            this.labelMenuChange = new System.Windows.Forms.Label();
            this.buttonMenuChange = new System.Windows.Forms.Button();
            this.buttonNewGugbabAdd = new System.Windows.Forms.Button();
            this.labelNewGugbabPrice = new System.Windows.Forms.Label();
            this.labelNewGugbabName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxChangeAfter = new System.Windows.Forms.TextBox();
            this.textBoxNewGugbabPrice = new System.Windows.Forms.TextBox();
            this.textBoxChangeBefore = new System.Windows.Forms.TextBox();
            this.textBoxNewGugbabName = new System.Windows.Forms.TextBox();
            this.buttonGugbabSell = new System.Windows.Forms.Button();
            this.comboBoxGugbabChoiceSell = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCasher = new System.Windows.Forms.DateTimePicker();
            this.buttonManagerOption = new System.Windows.Forms.Button();
            this.groupBoxTable = new System.Windows.Forms.GroupBox();
            this.buttonTable1 = new System.Windows.Forms.Button();
            this.buttonTable3 = new System.Windows.Forms.Button();
            this.buttonTable4 = new System.Windows.Forms.Button();
            this.buttonTable2 = new System.Windows.Forms.Button();
            this.buttonTable5 = new System.Windows.Forms.Button();
            this.buttonTable6 = new System.Windows.Forms.Button();
            this.groupBoxCasher.SuspendLayout();
            this.groupBoxTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(159, 18);
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
            this.groupBoxCasher.Controls.Add(this.buttonManagerOption);
            this.groupBoxCasher.Controls.Add(this.labelMenuChange);
            this.groupBoxCasher.Controls.Add(this.buttonMenuChange);
            this.groupBoxCasher.Controls.Add(this.buttonNewGugbabAdd);
            this.groupBoxCasher.Controls.Add(this.labelNewGugbabPrice);
            this.groupBoxCasher.Controls.Add(this.labelNewGugbabName);
            this.groupBoxCasher.Controls.Add(this.label1);
            this.groupBoxCasher.Controls.Add(this.textBoxChangeAfter);
            this.groupBoxCasher.Controls.Add(this.textBoxNewGugbabPrice);
            this.groupBoxCasher.Controls.Add(this.textBoxChangeBefore);
            this.groupBoxCasher.Controls.Add(this.textBoxNewGugbabName);
            this.groupBoxCasher.Controls.Add(this.buttonGugbabSell);
            this.groupBoxCasher.Controls.Add(this.comboBoxGugbabChoiceSell);
            this.groupBoxCasher.Controls.Add(this.buttonSignOut);
            this.groupBoxCasher.Controls.Add(this.dateTimePickerCasher);
            this.groupBoxCasher.Location = new System.Drawing.Point(12, 11);
            this.groupBoxCasher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCasher.Name = "groupBoxCasher";
            this.groupBoxCasher.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCasher.Size = new System.Drawing.Size(676, 129);
            this.groupBoxCasher.TabIndex = 4;
            this.groupBoxCasher.TabStop = false;
            this.groupBoxCasher.Text = "캐셔용 화면";
            // 
            // labelMenuChange
            // 
            this.labelMenuChange.AutoSize = true;
            this.labelMenuChange.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMenuChange.Location = new System.Drawing.Point(240, 77);
            this.labelMenuChange.Name = "labelMenuChange";
            this.labelMenuChange.Size = new System.Drawing.Size(63, 13);
            this.labelMenuChange.TabIndex = 15;
            this.labelMenuChange.Text = "메뉴변경";
            // 
            // buttonMenuChange
            // 
            this.buttonMenuChange.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonMenuChange.Location = new System.Drawing.Point(414, 72);
            this.buttonMenuChange.Name = "buttonMenuChange";
            this.buttonMenuChange.Size = new System.Drawing.Size(42, 49);
            this.buttonMenuChange.TabIndex = 14;
            this.buttonMenuChange.Text = "변경";
            this.buttonMenuChange.UseVisualStyleBackColor = true;
            this.buttonMenuChange.Click += new System.EventHandler(this.buttonMenuChange_Click);
            // 
            // buttonNewGugbabAdd
            // 
            this.buttonNewGugbabAdd.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonNewGugbabAdd.Location = new System.Drawing.Point(473, 18);
            this.buttonNewGugbabAdd.Name = "buttonNewGugbabAdd";
            this.buttonNewGugbabAdd.Size = new System.Drawing.Size(42, 49);
            this.buttonNewGugbabAdd.TabIndex = 14;
            this.buttonNewGugbabAdd.Text = "추가";
            this.buttonNewGugbabAdd.UseVisualStyleBackColor = true;
            this.buttonNewGugbabAdd.Click += new System.EventHandler(this.buttonNewGugbabAdd_Click);
            // 
            // labelNewGugbabPrice
            // 
            this.labelNewGugbabPrice.AutoSize = true;
            this.labelNewGugbabPrice.Location = new System.Drawing.Point(414, 49);
            this.labelNewGugbabPrice.Name = "labelNewGugbabPrice";
            this.labelNewGugbabPrice.Size = new System.Drawing.Size(53, 12);
            this.labelNewGugbabPrice.TabIndex = 13;
            this.labelNewGugbabPrice.Text = "가격책정";
            // 
            // labelNewGugbabName
            // 
            this.labelNewGugbabName.AutoSize = true;
            this.labelNewGugbabName.Location = new System.Drawing.Point(414, 24);
            this.labelNewGugbabName.Name = "labelNewGugbabName";
            this.labelNewGugbabName.Size = new System.Drawing.Size(53, 12);
            this.labelNewGugbabName.TabIndex = 13;
            this.labelNewGugbabName.Text = "신규메뉴";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(239, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "메뉴추가";
            // 
            // textBoxChangeAfter
            // 
            this.textBoxChangeAfter.Location = new System.Drawing.Point(308, 100);
            this.textBoxChangeAfter.Name = "textBoxChangeAfter";
            this.textBoxChangeAfter.Size = new System.Drawing.Size(100, 21);
            this.textBoxChangeAfter.TabIndex = 12;
            // 
            // textBoxNewGugbabPrice
            // 
            this.textBoxNewGugbabPrice.Location = new System.Drawing.Point(308, 46);
            this.textBoxNewGugbabPrice.Name = "textBoxNewGugbabPrice";
            this.textBoxNewGugbabPrice.Size = new System.Drawing.Size(100, 21);
            this.textBoxNewGugbabPrice.TabIndex = 12;
            // 
            // textBoxChangeBefore
            // 
            this.textBoxChangeBefore.Location = new System.Drawing.Point(308, 73);
            this.textBoxChangeBefore.Name = "textBoxChangeBefore";
            this.textBoxChangeBefore.Size = new System.Drawing.Size(100, 21);
            this.textBoxChangeBefore.TabIndex = 12;
            // 
            // textBoxNewGugbabName
            // 
            this.textBoxNewGugbabName.Location = new System.Drawing.Point(308, 19);
            this.textBoxNewGugbabName.Name = "textBoxNewGugbabName";
            this.textBoxNewGugbabName.Size = new System.Drawing.Size(100, 21);
            this.textBoxNewGugbabName.TabIndex = 12;
            // 
            // buttonGugbabSell
            // 
            this.buttonGugbabSell.Location = new System.Drawing.Point(158, 42);
            this.buttonGugbabSell.Name = "buttonGugbabSell";
            this.buttonGugbabSell.Size = new System.Drawing.Size(75, 23);
            this.buttonGugbabSell.TabIndex = 11;
            this.buttonGugbabSell.Text = "판매";
            this.buttonGugbabSell.UseVisualStyleBackColor = true;
            this.buttonGugbabSell.Click += new System.EventHandler(this.buttonGugbabSell_Click);
            // 
            // comboBoxGugbabChoiceSell
            // 
            this.comboBoxGugbabChoiceSell.FormattingEnabled = true;
            this.comboBoxGugbabChoiceSell.Location = new System.Drawing.Point(6, 44);
            this.comboBoxGugbabChoiceSell.Name = "comboBoxGugbabChoiceSell";
            this.comboBoxGugbabChoiceSell.Size = new System.Drawing.Size(146, 20);
            this.comboBoxGugbabChoiceSell.TabIndex = 10;
            // 
            // dateTimePickerCasher
            // 
            this.dateTimePickerCasher.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimePickerCasher.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCasher.Location = new System.Drawing.Point(6, 18);
            this.dateTimePickerCasher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerCasher.Name = "dateTimePickerCasher";
            this.dateTimePickerCasher.Size = new System.Drawing.Size(146, 21);
            this.dateTimePickerCasher.TabIndex = 9;
            this.dateTimePickerCasher.TabStop = false;
            // 
            // buttonManagerOption
            // 
            this.buttonManagerOption.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonManagerOption.Location = new System.Drawing.Point(595, 16);
            this.buttonManagerOption.Name = "buttonManagerOption";
            this.buttonManagerOption.Size = new System.Drawing.Size(75, 105);
            this.buttonManagerOption.TabIndex = 5;
            this.buttonManagerOption.Text = "Manager\r\nOption";
            this.buttonManagerOption.UseVisualStyleBackColor = true;
            this.buttonManagerOption.Click += new System.EventHandler(this.buttonManagerOption_Click);
            // 
            // groupBoxTable
            // 
            this.groupBoxTable.Controls.Add(this.buttonTable5);
            this.groupBoxTable.Controls.Add(this.buttonTable3);
            this.groupBoxTable.Controls.Add(this.buttonTable4);
            this.groupBoxTable.Controls.Add(this.buttonTable2);
            this.groupBoxTable.Controls.Add(this.buttonTable6);
            this.groupBoxTable.Controls.Add(this.buttonTable1);
            this.groupBoxTable.Location = new System.Drawing.Point(12, 145);
            this.groupBoxTable.Name = "groupBoxTable";
            this.groupBoxTable.Size = new System.Drawing.Size(676, 758);
            this.groupBoxTable.TabIndex = 5;
            this.groupBoxTable.TabStop = false;
            this.groupBoxTable.Text = "테이블 주문(매장)";
            // 
            // buttonTable1
            // 
            this.buttonTable1.Location = new System.Drawing.Point(39, 64);
            this.buttonTable1.Name = "buttonTable1";
            this.buttonTable1.Size = new System.Drawing.Size(97, 71);
            this.buttonTable1.TabIndex = 6;
            this.buttonTable1.Text = "1번 테이블";
            this.buttonTable1.UseVisualStyleBackColor = true;
            this.buttonTable1.Click += new System.EventHandler(this.buttonTable1_Click);
            // 
            // buttonTable3
            // 
            this.buttonTable3.Location = new System.Drawing.Point(39, 156);
            this.buttonTable3.Name = "buttonTable3";
            this.buttonTable3.Size = new System.Drawing.Size(54, 164);
            this.buttonTable3.TabIndex = 6;
            this.buttonTable3.Text = "3번\r\n테이블";
            this.buttonTable3.UseVisualStyleBackColor = true;
            this.buttonTable3.Click += new System.EventHandler(this.buttonTable3_Click);
            // 
            // buttonTable4
            // 
            this.buttonTable4.Location = new System.Drawing.Point(124, 156);
            this.buttonTable4.Name = "buttonTable4";
            this.buttonTable4.Size = new System.Drawing.Size(126, 164);
            this.buttonTable4.TabIndex = 6;
            this.buttonTable4.Text = "4번 테이블";
            this.buttonTable4.UseVisualStyleBackColor = true;
            this.buttonTable4.Click += new System.EventHandler(this.buttonTable4_Click);
            // 
            // buttonTable2
            // 
            this.buttonTable2.Location = new System.Drawing.Point(233, 64);
            this.buttonTable2.Name = "buttonTable2";
            this.buttonTable2.Size = new System.Drawing.Size(97, 71);
            this.buttonTable2.TabIndex = 6;
            this.buttonTable2.Text = "2번 테이블";
            this.buttonTable2.UseVisualStyleBackColor = true;
            this.buttonTable2.Click += new System.EventHandler(this.buttonTable2_Click);
            // 
            // buttonTable5
            // 
            this.buttonTable5.Location = new System.Drawing.Point(268, 156);
            this.buttonTable5.Name = "buttonTable5";
            this.buttonTable5.Size = new System.Drawing.Size(62, 164);
            this.buttonTable5.TabIndex = 6;
            this.buttonTable5.Text = "5번\r\n테이블";
            this.buttonTable5.UseVisualStyleBackColor = true;
            this.buttonTable5.Click += new System.EventHandler(this.buttonTable5_Click);
            // 
            // buttonTable6
            // 
            this.buttonTable6.Location = new System.Drawing.Point(39, 343);
            this.buttonTable6.Name = "buttonTable6";
            this.buttonTable6.Size = new System.Drawing.Size(291, 71);
            this.buttonTable6.TabIndex = 6;
            this.buttonTable6.Text = "6번 테이블";
            this.buttonTable6.UseVisualStyleBackColor = true;
            this.buttonTable6.Click += new System.EventHandler(this.buttonTable6_Click);
            // 
            // FormGugbab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 915);
            this.Controls.Add(this.groupBoxTable);
            this.Controls.Add(this.groupBoxCasher);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGugbab";
            this.Text = "국밥매상프로그램";
            this.groupBoxCasher.ResumeLayout(false);
            this.groupBoxCasher.PerformLayout();
            this.groupBoxTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.GroupBox groupBoxCasher;
        private System.Windows.Forms.DateTimePicker dateTimePickerCasher;
        private System.Windows.Forms.ComboBox comboBoxGugbabChoiceSell;
        private System.Windows.Forms.Button buttonGugbabSell;
        private System.Windows.Forms.Label labelNewGugbabPrice;
        private System.Windows.Forms.Label labelNewGugbabName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewGugbabPrice;
        private System.Windows.Forms.TextBox textBoxNewGugbabName;
        private System.Windows.Forms.Button buttonNewGugbabAdd;
        private System.Windows.Forms.Label labelMenuChange;
        private System.Windows.Forms.Button buttonMenuChange;
        private System.Windows.Forms.TextBox textBoxChangeAfter;
        private System.Windows.Forms.TextBox textBoxChangeBefore;
        private System.Windows.Forms.Button buttonManagerOption;
        private System.Windows.Forms.GroupBox groupBoxTable;
        private System.Windows.Forms.Button buttonTable5;
        private System.Windows.Forms.Button buttonTable3;
        private System.Windows.Forms.Button buttonTable4;
        private System.Windows.Forms.Button buttonTable2;
        private System.Windows.Forms.Button buttonTable6;
        private System.Windows.Forms.Button buttonTable1;
    }
}



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
            this.buttonNewGugbabAdd = new System.Windows.Forms.Button();
            this.labelNewGugbabPrice = new System.Windows.Forms.Label();
            this.labelNewGugbabName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewGugbabPrice = new System.Windows.Forms.TextBox();
            this.textBoxNewGugbabName = new System.Windows.Forms.TextBox();
            this.buttonGugbabSell = new System.Windows.Forms.Button();
            this.comboBoxGugbabChoiceSell = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCasher = new System.Windows.Forms.DateTimePicker();
            this.groupBoxManager = new System.Windows.Forms.GroupBox();
            this.labelGugbab_typeMonthSell = new System.Windows.Forms.Label();
            this.labelGugbab_typeDateSell = new System.Windows.Forms.Label();
            this.comboBoxGugbab_typeMonthSell = new System.Windows.Forms.ComboBox();
            this.comboBoxGugbab_typeDateSell = new System.Windows.Forms.ComboBox();
            this.dataGridViewGugbab_typeMonthSell = new System.Windows.Forms.DataGridView();
            this.dataGridViewGugbab_typeDateSell = new System.Windows.Forms.DataGridView();
            this.buttonGugbab_typeMonthSell = new System.Windows.Forms.Button();
            this.dataGridViewUser2DateSell = new System.Windows.Forms.DataGridView();
            this.buttonGugbab_typeDateSell = new System.Windows.Forms.Button();
            this.buttonUser2DateSell = new System.Windows.Forms.Button();
            this.dataGridViewUser1DateSell = new System.Windows.Forms.DataGridView();
            this.buttonUser1DateSell = new System.Windows.Forms.Button();
            this.labelUser2DateSell = new System.Windows.Forms.Label();
            this.buttonManagerTotal = new System.Windows.Forms.Button();
            this.labelUser1DateSell = new System.Windows.Forms.Label();
            this.labelManagerTotal = new System.Windows.Forms.Label();
            this.dataGridViewTotal = new System.Windows.Forms.DataGridView();
            this.labelMenuChange = new System.Windows.Forms.Label();
            this.textBoxChangeBefore = new System.Windows.Forms.TextBox();
            this.textBoxChangeAfter = new System.Windows.Forms.TextBox();
            this.buttonMenuChange = new System.Windows.Forms.Button();
            this.groupBoxCasher.SuspendLayout();
            this.groupBoxManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGugbab_typeMonthSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGugbab_typeDateSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser2DateSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser1DateSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).BeginInit();
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
            // textBoxNewGugbabPrice
            // 
            this.textBoxNewGugbabPrice.Location = new System.Drawing.Point(308, 46);
            this.textBoxNewGugbabPrice.Name = "textBoxNewGugbabPrice";
            this.textBoxNewGugbabPrice.Size = new System.Drawing.Size(100, 21);
            this.textBoxNewGugbabPrice.TabIndex = 12;
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
            // groupBoxManager
            // 
            this.groupBoxManager.Controls.Add(this.labelGugbab_typeMonthSell);
            this.groupBoxManager.Controls.Add(this.labelGugbab_typeDateSell);
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
            this.groupBoxManager.Location = new System.Drawing.Point(12, 144);
            this.groupBoxManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxManager.Name = "groupBoxManager";
            this.groupBoxManager.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxManager.Size = new System.Drawing.Size(676, 762);
            this.groupBoxManager.TabIndex = 2;
            this.groupBoxManager.TabStop = false;
            this.groupBoxManager.Text = "관리자용 화면";
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
            // labelGugbab_typeDateSell
            // 
            this.labelGugbab_typeDateSell.AutoSize = true;
            this.labelGugbab_typeDateSell.Location = new System.Drawing.Point(85, 452);
            this.labelGugbab_typeDateSell.Name = "labelGugbab_typeDateSell";
            this.labelGugbab_typeDateSell.Size = new System.Drawing.Size(57, 12);
            this.labelGugbab_typeDateSell.TabIndex = 13;
            this.labelGugbab_typeDateSell.Text = "일일 판매";
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
            // labelUser1DateSell
            // 
            this.labelUser1DateSell.AutoSize = true;
            this.labelUser1DateSell.Location = new System.Drawing.Point(6, 161);
            this.labelUser1DateSell.Name = "labelUser1DateSell";
            this.labelUser1DateSell.Size = new System.Drawing.Size(93, 12);
            this.labelUser1DateSell.TabIndex = 9;
            this.labelUser1DateSell.Text = "User1 일일 판매";
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
            // textBoxChangeBefore
            // 
            this.textBoxChangeBefore.Location = new System.Drawing.Point(308, 73);
            this.textBoxChangeBefore.Name = "textBoxChangeBefore";
            this.textBoxChangeBefore.Size = new System.Drawing.Size(100, 21);
            this.textBoxChangeBefore.TabIndex = 12;
            // 
            // textBoxChangeAfter
            // 
            this.textBoxChangeAfter.Location = new System.Drawing.Point(308, 100);
            this.textBoxChangeAfter.Name = "textBoxChangeAfter";
            this.textBoxChangeAfter.Size = new System.Drawing.Size(100, 21);
            this.textBoxChangeAfter.TabIndex = 12;
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
            // FormGugbab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 915);
            this.Controls.Add(this.groupBoxManager);
            this.Controls.Add(this.groupBoxCasher);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGugbab";
            this.Text = "국밥매상프로그램";
            this.groupBoxCasher.ResumeLayout(false);
            this.groupBoxCasher.PerformLayout();
            this.groupBoxManager.ResumeLayout(false);
            this.groupBoxManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGugbab_typeMonthSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGugbab_typeDateSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser2DateSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser1DateSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.GroupBox groupBoxCasher;
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
        private System.Windows.Forms.Label labelGugbab_typeDateSell;
        private System.Windows.Forms.ComboBox comboBoxGugbab_typeDateSell;
        private System.Windows.Forms.DataGridView dataGridViewGugbab_typeDateSell;
        private System.Windows.Forms.Button buttonGugbab_typeDateSell;
        private System.Windows.Forms.Label labelGugbab_typeMonthSell;
        private System.Windows.Forms.ComboBox comboBoxGugbab_typeMonthSell;
        private System.Windows.Forms.DataGridView dataGridViewGugbab_typeMonthSell;
        private System.Windows.Forms.Button buttonGugbab_typeMonthSell;
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
    }
}


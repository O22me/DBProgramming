
namespace MarketBrowser
{
    partial class MainForm
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
            this.ButtonCSVViewer = new System.Windows.Forms.Button();
            this.textBoxCSVViewer = new System.Windows.Forms.TextBox();
            this.listBoxHeader = new System.Windows.Forms.ListBox();
            this.labelHeadList = new System.Windows.Forms.Label();
            this.textBoxSearchKeyword = new System.Windows.Forms.TextBox();
            this.labelSearchKeyword = new System.Windows.Forms.Label();
            this.textBoxSearchResult = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSQL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCSVViewer
            // 
            this.ButtonCSVViewer.Location = new System.Drawing.Point(57, 50);
            this.ButtonCSVViewer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCSVViewer.Name = "ButtonCSVViewer";
            this.ButtonCSVViewer.Size = new System.Drawing.Size(114, 50);
            this.ButtonCSVViewer.TabIndex = 0;
            this.ButtonCSVViewer.Text = "CSV 열기";
            this.ButtonCSVViewer.UseVisualStyleBackColor = true;
            this.ButtonCSVViewer.Click += new System.EventHandler(this.ButtonCSVViewer_Click);
            // 
            // textBoxCSVViewer
            // 
            this.textBoxCSVViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCSVViewer.Location = new System.Drawing.Point(654, 137);
            this.textBoxCSVViewer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCSVViewer.Multiline = true;
            this.textBoxCSVViewer.Name = "textBoxCSVViewer";
            this.textBoxCSVViewer.Size = new System.Drawing.Size(200, 370);
            this.textBoxCSVViewer.TabIndex = 1;
            // 
            // listBoxHeader
            // 
            this.listBoxHeader.FormattingEnabled = true;
            this.listBoxHeader.ItemHeight = 15;
            this.listBoxHeader.Location = new System.Drawing.Point(57, 137);
            this.listBoxHeader.Name = "listBoxHeader";
            this.listBoxHeader.Size = new System.Drawing.Size(160, 364);
            this.listBoxHeader.TabIndex = 2;
            // 
            // labelHeadList
            // 
            this.labelHeadList.AutoSize = true;
            this.labelHeadList.Location = new System.Drawing.Point(54, 110);
            this.labelHeadList.Name = "labelHeadList";
            this.labelHeadList.Size = new System.Drawing.Size(122, 15);
            this.labelHeadList.TabIndex = 3;
            this.labelHeadList.Text = "컬럼 헤드 리스트";
            // 
            // textBoxSearchKeyword
            // 
            this.textBoxSearchKeyword.Location = new System.Drawing.Point(248, 137);
            this.textBoxSearchKeyword.Name = "textBoxSearchKeyword";
            this.textBoxSearchKeyword.Size = new System.Drawing.Size(168, 25);
            this.textBoxSearchKeyword.TabIndex = 4;
            // 
            // labelSearchKeyword
            // 
            this.labelSearchKeyword.AutoSize = true;
            this.labelSearchKeyword.Location = new System.Drawing.Point(245, 110);
            this.labelSearchKeyword.Name = "labelSearchKeyword";
            this.labelSearchKeyword.Size = new System.Drawing.Size(87, 15);
            this.labelSearchKeyword.TabIndex = 3;
            this.labelSearchKeyword.Text = "검색 키워드";
            // 
            // textBoxSearchResult
            // 
            this.textBoxSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchResult.Location = new System.Drawing.Point(448, 137);
            this.textBoxSearchResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSearchResult.Multiline = true;
            this.textBoxSearchResult.Name = "textBoxSearchResult";
            this.textBoxSearchResult.Size = new System.Drawing.Size(200, 370);
            this.textBoxSearchResult.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(248, 168);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(168, 40);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "검색하기";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSQL
            // 
            this.labelSQL.AutoSize = true;
            this.labelSQL.Location = new System.Drawing.Point(245, 85);
            this.labelSQL.Name = "labelSQL";
            this.labelSQL.Size = new System.Drawing.Size(379, 15);
            this.labelSQL.TabIndex = 3;
            this.labelSQL.Text = "SELECT * FROM TABLE WHERE COL like \'%Keyword%\'";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchKeyword);
            this.Controls.Add(this.labelSQL);
            this.Controls.Add(this.labelSearchKeyword);
            this.Controls.Add(this.labelHeadList);
            this.Controls.Add(this.listBoxHeader);
            this.Controls.Add(this.textBoxSearchResult);
            this.Controls.Add(this.textBoxCSVViewer);
            this.Controls.Add(this.ButtonCSVViewer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "CSV 검색기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCSVViewer;
        private System.Windows.Forms.TextBox textBoxCSVViewer;
        private System.Windows.Forms.ListBox listBoxHeader;
        private System.Windows.Forms.Label labelHeadList;
        private System.Windows.Forms.TextBox textBoxSearchKeyword;
        private System.Windows.Forms.Label labelSearchKeyword;
        private System.Windows.Forms.TextBox textBoxSearchResult;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSQL;
    }
}


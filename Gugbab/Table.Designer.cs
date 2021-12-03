
namespace Gugbab
{
    partial class FormTable
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
            this.listBoxMenuList = new System.Windows.Forms.ListBox();
            this.buttonAddMenu = new System.Windows.Forms.Button();
            this.buttonCancelMenu = new System.Windows.Forms.Button();
            this.dataGridViewOrdered = new System.Windows.Forms.DataGridView();
            this.labelTableNumber = new System.Windows.Forms.Label();
            this.buttonPaymentComplete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdered)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMenuList
            // 
            this.listBoxMenuList.FormattingEnabled = true;
            this.listBoxMenuList.ItemHeight = 12;
            this.listBoxMenuList.Location = new System.Drawing.Point(12, 12);
            this.listBoxMenuList.Name = "listBoxMenuList";
            this.listBoxMenuList.Size = new System.Drawing.Size(174, 100);
            this.listBoxMenuList.TabIndex = 0;
            // 
            // buttonAddMenu
            // 
            this.buttonAddMenu.Location = new System.Drawing.Point(192, 12);
            this.buttonAddMenu.Name = "buttonAddMenu";
            this.buttonAddMenu.Size = new System.Drawing.Size(90, 40);
            this.buttonAddMenu.TabIndex = 1;
            this.buttonAddMenu.Text = "추가";
            this.buttonAddMenu.UseVisualStyleBackColor = true;
            this.buttonAddMenu.Click += new System.EventHandler(this.buttonAddMenu_Click);
            // 
            // buttonCancelMenu
            // 
            this.buttonCancelMenu.Location = new System.Drawing.Point(192, 72);
            this.buttonCancelMenu.Name = "buttonCancelMenu";
            this.buttonCancelMenu.Size = new System.Drawing.Size(90, 40);
            this.buttonCancelMenu.TabIndex = 1;
            this.buttonCancelMenu.Text = "취소";
            this.buttonCancelMenu.UseVisualStyleBackColor = true;
            this.buttonCancelMenu.Click += new System.EventHandler(this.buttonCancelMenu_Click);
            // 
            // dataGridViewOrdered
            // 
            this.dataGridViewOrdered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdered.Location = new System.Drawing.Point(12, 118);
            this.dataGridViewOrdered.Name = "dataGridViewOrdered";
            this.dataGridViewOrdered.RowTemplate.Height = 23;
            this.dataGridViewOrdered.Size = new System.Drawing.Size(360, 231);
            this.dataGridViewOrdered.TabIndex = 2;
            // 
            // labelTableNumber
            // 
            this.labelTableNumber.AutoSize = true;
            this.labelTableNumber.Location = new System.Drawing.Point(225, 55);
            this.labelTableNumber.Name = "labelTableNumber";
            this.labelTableNumber.Size = new System.Drawing.Size(57, 12);
            this.labelTableNumber.TabIndex = 3;
            this.labelTableNumber.Text = "번 테이블";
            // 
            // buttonPaymentComplete
            // 
            this.buttonPaymentComplete.Location = new System.Drawing.Point(288, 12);
            this.buttonPaymentComplete.Name = "buttonPaymentComplete";
            this.buttonPaymentComplete.Size = new System.Drawing.Size(84, 100);
            this.buttonPaymentComplete.TabIndex = 4;
            this.buttonPaymentComplete.Text = "결제완료";
            this.buttonPaymentComplete.UseVisualStyleBackColor = true;
            this.buttonPaymentComplete.Click += new System.EventHandler(this.buttonPaymentComplete_Click);
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.buttonPaymentComplete);
            this.Controls.Add(this.labelTableNumber);
            this.Controls.Add(this.dataGridViewOrdered);
            this.Controls.Add(this.buttonCancelMenu);
            this.Controls.Add(this.buttonAddMenu);
            this.Controls.Add(this.listBoxMenuList);
            this.Name = "FormTable";
            this.Text = "Table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMenuList;
        private System.Windows.Forms.Button buttonAddMenu;
        private System.Windows.Forms.Button buttonCancelMenu;
        private System.Windows.Forms.DataGridView dataGridViewOrdered;
        private System.Windows.Forms.Label labelTableNumber;
        private System.Windows.Forms.Button buttonPaymentComplete;
    }
}

namespace Gugbab
{
    partial class FormSignIn
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
            this.labelSignInID = new System.Windows.Forms.Label();
            this.textBoxSignInID = new System.Windows.Forms.TextBox();
            this.labelSignInPW = new System.Windows.Forms.Label();
            this.textBoxSignInPW = new System.Windows.Forms.TextBox();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.labelSignStatement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSignInID
            // 
            this.labelSignInID.AutoSize = true;
            this.labelSignInID.Location = new System.Drawing.Point(120, 120);
            this.labelSignInID.Name = "labelSignInID";
            this.labelSignInID.Size = new System.Drawing.Size(16, 12);
            this.labelSignInID.TabIndex = 0;
            this.labelSignInID.Text = "ID";
            // 
            // textBoxSignInID
            // 
            this.textBoxSignInID.Location = new System.Drawing.Point(149, 117);
            this.textBoxSignInID.Name = "textBoxSignInID";
            this.textBoxSignInID.Size = new System.Drawing.Size(100, 21);
            this.textBoxSignInID.TabIndex = 0;
            this.textBoxSignInID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSignInID_KeyUp);
            // 
            // labelSignInPW
            // 
            this.labelSignInPW.AutoSize = true;
            this.labelSignInPW.Location = new System.Drawing.Point(120, 151);
            this.labelSignInPW.Name = "labelSignInPW";
            this.labelSignInPW.Size = new System.Drawing.Size(23, 12);
            this.labelSignInPW.TabIndex = 0;
            this.labelSignInPW.Text = "PW";
            // 
            // textBoxSignInPW
            // 
            this.textBoxSignInPW.Location = new System.Drawing.Point(149, 148);
            this.textBoxSignInPW.Name = "textBoxSignInPW";
            this.textBoxSignInPW.Size = new System.Drawing.Size(100, 21);
            this.textBoxSignInPW.TabIndex = 1;
            this.textBoxSignInPW.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSignInPW_KeyUp);
            // 
            // labelSignIn
            // 
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSignIn.Location = new System.Drawing.Point(107, 75);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(195, 30);
            this.labelSignIn.TabIndex = 2;
            this.labelSignIn.Text = "국밥 판매 프로그램";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonSignIn.Location = new System.Drawing.Point(255, 115);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(47, 54);
            this.buttonSignIn.TabIndex = 2;
            this.buttonSignIn.Text = "Sign\r\nIn";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // labelSignStatement
            // 
            this.labelSignStatement.AutoSize = true;
            this.labelSignStatement.Location = new System.Drawing.Point(141, 172);
            this.labelSignStatement.Name = "labelSignStatement";
            this.labelSignStatement.Size = new System.Drawing.Size(161, 12);
            this.labelSignStatement.TabIndex = 3;
            this.labelSignStatement.Text = "환영합니다. 로그인해주세요.";
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.labelSignStatement);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.labelSignIn);
            this.Controls.Add(this.textBoxSignInPW);
            this.Controls.Add(this.labelSignInPW);
            this.Controls.Add(this.textBoxSignInID);
            this.Controls.Add(this.labelSignInID);
            this.Name = "FormSignIn";
            this.Text = "SignIn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSignIn_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSignInID;
        private System.Windows.Forms.TextBox textBoxSignInID;
        private System.Windows.Forms.Label labelSignInPW;
        private System.Windows.Forms.TextBox textBoxSignInPW;
        private System.Windows.Forms.Label labelSignIn;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label labelSignStatement;
    }
}
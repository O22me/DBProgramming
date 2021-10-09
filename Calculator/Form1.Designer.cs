
namespace Calculator
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
            this.groupBoxComboCalc = new System.Windows.Forms.GroupBox();
            this.buttonComboBoxCalculate = new System.Windows.Forms.Button();
            this.comboBoxComboCalc_Operators = new System.Windows.Forms.ComboBox();
            this.textBoxComboBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxComboBoxOperand2 = new System.Windows.Forms.TextBox();
            this.textBoxComboBoxOperand1 = new System.Windows.Forms.TextBox();
            this.labelComboBoxResult = new System.Windows.Forms.Label();
            this.labelComboBoxOperand2 = new System.Windows.Forms.Label();
            this.labelComboBoxOperator = new System.Windows.Forms.Label();
            this.labelComboBoxOperand1 = new System.Windows.Forms.Label();
            this.groupBoxRadioButtonCalc = new System.Windows.Forms.GroupBox();
            this.radioButtonRadioButtonDivision = new System.Windows.Forms.RadioButton();
            this.radioButtonRadioButtonMultiply = new System.Windows.Forms.RadioButton();
            this.radioButtonRadioButtonMinus = new System.Windows.Forms.RadioButton();
            this.radioButtonRadioButtonPlus = new System.Windows.Forms.RadioButton();
            this.buttonRadioButtonCalculate = new System.Windows.Forms.Button();
            this.textBoxRadioButtonResult = new System.Windows.Forms.TextBox();
            this.textBoxRadioButtonOperand2 = new System.Windows.Forms.TextBox();
            this.textBoxRadioButtonOperand1 = new System.Windows.Forms.TextBox();
            this.labelRadioButtonResult = new System.Windows.Forms.Label();
            this.labelRadioButtonOperand2 = new System.Windows.Forms.Label();
            this.labelRadioButtonOperator = new System.Windows.Forms.Label();
            this.labelRadioButtonOperand1 = new System.Windows.Forms.Label();
            this.groupBoxSquareRootCalculator = new System.Windows.Forms.GroupBox();
            this.radioButtonSquareRootDivision = new System.Windows.Forms.RadioButton();
            this.radioButtonSquareRootMultiply = new System.Windows.Forms.RadioButton();
            this.buttonSquareRootCalculate = new System.Windows.Forms.Button();
            this.radioButtonSquareRootMInus = new System.Windows.Forms.RadioButton();
            this.textBoxSquareRootResult = new System.Windows.Forms.TextBox();
            this.radioButtonSquareRootPlus = new System.Windows.Forms.RadioButton();
            this.textBoxSquareRootOperand2 = new System.Windows.Forms.TextBox();
            this.textBoxSquareRootOperand1 = new System.Windows.Forms.TextBox();
            this.labelSquareRootResult = new System.Windows.Forms.Label();
            this.labelSquareRootOperand2 = new System.Windows.Forms.Label();
            this.labelSquareRootOperator = new System.Windows.Forms.Label();
            this.labelSquareRootOperand1 = new System.Windows.Forms.Label();
            this.checkBoxSquareRootOperand1SqrtCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxSquareRootOperand2SqrtCheck = new System.Windows.Forms.CheckBox();
            this.groupBoxComboCalc.SuspendLayout();
            this.groupBoxRadioButtonCalc.SuspendLayout();
            this.groupBoxSquareRootCalculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxComboCalc
            // 
            this.groupBoxComboCalc.Controls.Add(this.buttonComboBoxCalculate);
            this.groupBoxComboCalc.Controls.Add(this.comboBoxComboCalc_Operators);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboBoxResult);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboBoxOperand2);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboBoxOperand1);
            this.groupBoxComboCalc.Controls.Add(this.labelComboBoxResult);
            this.groupBoxComboCalc.Controls.Add(this.labelComboBoxOperand2);
            this.groupBoxComboCalc.Controls.Add(this.labelComboBoxOperator);
            this.groupBoxComboCalc.Controls.Add(this.labelComboBoxOperand1);
            this.groupBoxComboCalc.Location = new System.Drawing.Point(12, 12);
            this.groupBoxComboCalc.Name = "groupBoxComboCalc";
            this.groupBoxComboCalc.Size = new System.Drawing.Size(592, 97);
            this.groupBoxComboCalc.TabIndex = 0;
            this.groupBoxComboCalc.TabStop = false;
            this.groupBoxComboCalc.Text = "Combobox based Calculator";
            // 
            // buttonComboBoxCalculate
            // 
            this.buttonComboBoxCalculate.Location = new System.Drawing.Point(383, 48);
            this.buttonComboBoxCalculate.Name = "buttonComboBoxCalculate";
            this.buttonComboBoxCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonComboBoxCalculate.TabIndex = 4;
            this.buttonComboBoxCalculate.Text = "Calculate";
            this.buttonComboBoxCalculate.UseVisualStyleBackColor = true;
            this.buttonComboBoxCalculate.Click += new System.EventHandler(this.buttonComboBoxCalculate_Click);
            // 
            // comboBoxComboCalc_Operators
            // 
            this.comboBoxComboCalc_Operators.FormattingEnabled = true;
            this.comboBoxComboCalc_Operators.Location = new System.Drawing.Point(127, 50);
            this.comboBoxComboCalc_Operators.Name = "comboBoxComboCalc_Operators";
            this.comboBoxComboCalc_Operators.Size = new System.Drawing.Size(121, 20);
            this.comboBoxComboCalc_Operators.TabIndex = 3;
            // 
            // textBoxComboBoxResult
            // 
            this.textBoxComboBoxResult.Location = new System.Drawing.Point(477, 50);
            this.textBoxComboBoxResult.Name = "textBoxComboBoxResult";
            this.textBoxComboBoxResult.Size = new System.Drawing.Size(100, 21);
            this.textBoxComboBoxResult.TabIndex = 2;
            // 
            // textBoxComboBoxOperand2
            // 
            this.textBoxComboBoxOperand2.Location = new System.Drawing.Point(263, 50);
            this.textBoxComboBoxOperand2.Name = "textBoxComboBoxOperand2";
            this.textBoxComboBoxOperand2.Size = new System.Drawing.Size(100, 21);
            this.textBoxComboBoxOperand2.TabIndex = 2;
            // 
            // textBoxComboBoxOperand1
            // 
            this.textBoxComboBoxOperand1.Location = new System.Drawing.Point(12, 50);
            this.textBoxComboBoxOperand1.Name = "textBoxComboBoxOperand1";
            this.textBoxComboBoxOperand1.Size = new System.Drawing.Size(100, 21);
            this.textBoxComboBoxOperand1.TabIndex = 2;
            // 
            // labelComboBoxResult
            // 
            this.labelComboBoxResult.AutoSize = true;
            this.labelComboBoxResult.Location = new System.Drawing.Point(511, 25);
            this.labelComboBoxResult.Name = "labelComboBoxResult";
            this.labelComboBoxResult.Size = new System.Drawing.Size(40, 12);
            this.labelComboBoxResult.TabIndex = 1;
            this.labelComboBoxResult.Text = "Result";
            // 
            // labelComboBoxOperand2
            // 
            this.labelComboBoxOperand2.AutoSize = true;
            this.labelComboBoxOperand2.Location = new System.Drawing.Point(281, 25);
            this.labelComboBoxOperand2.Name = "labelComboBoxOperand2";
            this.labelComboBoxOperand2.Size = new System.Drawing.Size(63, 12);
            this.labelComboBoxOperand2.TabIndex = 1;
            this.labelComboBoxOperand2.Text = "Operand 2";
            // 
            // labelComboBoxOperator
            // 
            this.labelComboBoxOperator.AutoSize = true;
            this.labelComboBoxOperator.Location = new System.Drawing.Point(156, 25);
            this.labelComboBoxOperator.Name = "labelComboBoxOperator";
            this.labelComboBoxOperator.Size = new System.Drawing.Size(53, 12);
            this.labelComboBoxOperator.TabIndex = 1;
            this.labelComboBoxOperator.Text = "Operator";
            // 
            // labelComboBoxOperand1
            // 
            this.labelComboBoxOperand1.AutoSize = true;
            this.labelComboBoxOperand1.Location = new System.Drawing.Point(31, 25);
            this.labelComboBoxOperand1.Name = "labelComboBoxOperand1";
            this.labelComboBoxOperand1.Size = new System.Drawing.Size(63, 12);
            this.labelComboBoxOperand1.TabIndex = 1;
            this.labelComboBoxOperand1.Text = "Operand 1";
            // 
            // groupBoxRadioButtonCalc
            // 
            this.groupBoxRadioButtonCalc.Controls.Add(this.radioButtonRadioButtonDivision);
            this.groupBoxRadioButtonCalc.Controls.Add(this.radioButtonRadioButtonMultiply);
            this.groupBoxRadioButtonCalc.Controls.Add(this.radioButtonRadioButtonMinus);
            this.groupBoxRadioButtonCalc.Controls.Add(this.radioButtonRadioButtonPlus);
            this.groupBoxRadioButtonCalc.Controls.Add(this.buttonRadioButtonCalculate);
            this.groupBoxRadioButtonCalc.Controls.Add(this.textBoxRadioButtonResult);
            this.groupBoxRadioButtonCalc.Controls.Add(this.textBoxRadioButtonOperand2);
            this.groupBoxRadioButtonCalc.Controls.Add(this.textBoxRadioButtonOperand1);
            this.groupBoxRadioButtonCalc.Controls.Add(this.labelRadioButtonResult);
            this.groupBoxRadioButtonCalc.Controls.Add(this.labelRadioButtonOperand2);
            this.groupBoxRadioButtonCalc.Controls.Add(this.labelRadioButtonOperator);
            this.groupBoxRadioButtonCalc.Controls.Add(this.labelRadioButtonOperand1);
            this.groupBoxRadioButtonCalc.Location = new System.Drawing.Point(12, 115);
            this.groupBoxRadioButtonCalc.Name = "groupBoxRadioButtonCalc";
            this.groupBoxRadioButtonCalc.Size = new System.Drawing.Size(592, 97);
            this.groupBoxRadioButtonCalc.TabIndex = 0;
            this.groupBoxRadioButtonCalc.TabStop = false;
            this.groupBoxRadioButtonCalc.Text = "Radio Button based Calculator";
            // 
            // radioButtonRadioButtonDivision
            // 
            this.radioButtonRadioButtonDivision.AutoSize = true;
            this.radioButtonRadioButtonDivision.Location = new System.Drawing.Point(195, 70);
            this.radioButtonRadioButtonDivision.Name = "radioButtonRadioButtonDivision";
            this.radioButtonRadioButtonDivision.Size = new System.Drawing.Size(29, 16);
            this.radioButtonRadioButtonDivision.TabIndex = 5;
            this.radioButtonRadioButtonDivision.TabStop = true;
            this.radioButtonRadioButtonDivision.Text = "/";
            this.radioButtonRadioButtonDivision.UseVisualStyleBackColor = true;
            this.radioButtonRadioButtonDivision.CheckedChanged += new System.EventHandler(this.radioButtonRadioButtonDivision_CheckedChanged);
            // 
            // radioButtonRadioButtonMultiply
            // 
            this.radioButtonRadioButtonMultiply.AutoSize = true;
            this.radioButtonRadioButtonMultiply.Location = new System.Drawing.Point(146, 70);
            this.radioButtonRadioButtonMultiply.Name = "radioButtonRadioButtonMultiply";
            this.radioButtonRadioButtonMultiply.Size = new System.Drawing.Size(29, 16);
            this.radioButtonRadioButtonMultiply.TabIndex = 5;
            this.radioButtonRadioButtonMultiply.TabStop = true;
            this.radioButtonRadioButtonMultiply.Text = "*";
            this.radioButtonRadioButtonMultiply.UseVisualStyleBackColor = true;
            this.radioButtonRadioButtonMultiply.CheckedChanged += new System.EventHandler(this.radioButtonRadioButtonMultiply_CheckedChanged);
            // 
            // radioButtonRadioButtonMinus
            // 
            this.radioButtonRadioButtonMinus.AutoSize = true;
            this.radioButtonRadioButtonMinus.Location = new System.Drawing.Point(195, 48);
            this.radioButtonRadioButtonMinus.Name = "radioButtonRadioButtonMinus";
            this.radioButtonRadioButtonMinus.Size = new System.Drawing.Size(29, 16);
            this.radioButtonRadioButtonMinus.TabIndex = 5;
            this.radioButtonRadioButtonMinus.TabStop = true;
            this.radioButtonRadioButtonMinus.Text = "-";
            this.radioButtonRadioButtonMinus.UseVisualStyleBackColor = true;
            this.radioButtonRadioButtonMinus.CheckedChanged += new System.EventHandler(this.radioButtonRadioButtonMinus_CheckedChanged);
            // 
            // radioButtonRadioButtonPlus
            // 
            this.radioButtonRadioButtonPlus.AutoSize = true;
            this.radioButtonRadioButtonPlus.Location = new System.Drawing.Point(146, 48);
            this.radioButtonRadioButtonPlus.Name = "radioButtonRadioButtonPlus";
            this.radioButtonRadioButtonPlus.Size = new System.Drawing.Size(29, 16);
            this.radioButtonRadioButtonPlus.TabIndex = 5;
            this.radioButtonRadioButtonPlus.TabStop = true;
            this.radioButtonRadioButtonPlus.Text = "+";
            this.radioButtonRadioButtonPlus.UseVisualStyleBackColor = true;
            this.radioButtonRadioButtonPlus.CheckedChanged += new System.EventHandler(this.radioButtonRadioButtonPlus_CheckedChanged);
            // 
            // buttonRadioButtonCalculate
            // 
            this.buttonRadioButtonCalculate.Location = new System.Drawing.Point(383, 48);
            this.buttonRadioButtonCalculate.Name = "buttonRadioButtonCalculate";
            this.buttonRadioButtonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonRadioButtonCalculate.TabIndex = 4;
            this.buttonRadioButtonCalculate.Text = "Calculate";
            this.buttonRadioButtonCalculate.UseVisualStyleBackColor = true;
            this.buttonRadioButtonCalculate.Click += new System.EventHandler(this.buttonRadioButtonCalculate_Click);
            // 
            // textBoxRadioButtonResult
            // 
            this.textBoxRadioButtonResult.Location = new System.Drawing.Point(477, 50);
            this.textBoxRadioButtonResult.Name = "textBoxRadioButtonResult";
            this.textBoxRadioButtonResult.Size = new System.Drawing.Size(100, 21);
            this.textBoxRadioButtonResult.TabIndex = 2;
            // 
            // textBoxRadioButtonOperand2
            // 
            this.textBoxRadioButtonOperand2.Location = new System.Drawing.Point(263, 50);
            this.textBoxRadioButtonOperand2.Name = "textBoxRadioButtonOperand2";
            this.textBoxRadioButtonOperand2.Size = new System.Drawing.Size(100, 21);
            this.textBoxRadioButtonOperand2.TabIndex = 2;
            this.textBoxRadioButtonOperand2.TextChanged += new System.EventHandler(this.textBoxRadioButtonOperand2_TextChanged);
            // 
            // textBoxRadioButtonOperand1
            // 
            this.textBoxRadioButtonOperand1.Location = new System.Drawing.Point(12, 50);
            this.textBoxRadioButtonOperand1.Name = "textBoxRadioButtonOperand1";
            this.textBoxRadioButtonOperand1.Size = new System.Drawing.Size(100, 21);
            this.textBoxRadioButtonOperand1.TabIndex = 2;
            this.textBoxRadioButtonOperand1.TextChanged += new System.EventHandler(this.textBoxRadioButtonOperand1_TextChanged);
            // 
            // labelRadioButtonResult
            // 
            this.labelRadioButtonResult.AutoSize = true;
            this.labelRadioButtonResult.Location = new System.Drawing.Point(511, 25);
            this.labelRadioButtonResult.Name = "labelRadioButtonResult";
            this.labelRadioButtonResult.Size = new System.Drawing.Size(40, 12);
            this.labelRadioButtonResult.TabIndex = 1;
            this.labelRadioButtonResult.Text = "Result";
            // 
            // labelRadioButtonOperand2
            // 
            this.labelRadioButtonOperand2.AutoSize = true;
            this.labelRadioButtonOperand2.Location = new System.Drawing.Point(281, 25);
            this.labelRadioButtonOperand2.Name = "labelRadioButtonOperand2";
            this.labelRadioButtonOperand2.Size = new System.Drawing.Size(63, 12);
            this.labelRadioButtonOperand2.TabIndex = 1;
            this.labelRadioButtonOperand2.Text = "Operand 2";
            // 
            // labelRadioButtonOperator
            // 
            this.labelRadioButtonOperator.AutoSize = true;
            this.labelRadioButtonOperator.Location = new System.Drawing.Point(156, 25);
            this.labelRadioButtonOperator.Name = "labelRadioButtonOperator";
            this.labelRadioButtonOperator.Size = new System.Drawing.Size(53, 12);
            this.labelRadioButtonOperator.TabIndex = 1;
            this.labelRadioButtonOperator.Text = "Operator";
            // 
            // labelRadioButtonOperand1
            // 
            this.labelRadioButtonOperand1.AutoSize = true;
            this.labelRadioButtonOperand1.Location = new System.Drawing.Point(31, 25);
            this.labelRadioButtonOperand1.Name = "labelRadioButtonOperand1";
            this.labelRadioButtonOperand1.Size = new System.Drawing.Size(63, 12);
            this.labelRadioButtonOperand1.TabIndex = 1;
            this.labelRadioButtonOperand1.Text = "Operand 1";
            // 
            // groupBoxSquareRootCalculator
            // 
            this.groupBoxSquareRootCalculator.Controls.Add(this.checkBoxSquareRootOperand2SqrtCheck);
            this.groupBoxSquareRootCalculator.Controls.Add(this.checkBoxSquareRootOperand1SqrtCheck);
            this.groupBoxSquareRootCalculator.Controls.Add(this.radioButtonSquareRootDivision);
            this.groupBoxSquareRootCalculator.Controls.Add(this.radioButtonSquareRootMultiply);
            this.groupBoxSquareRootCalculator.Controls.Add(this.buttonSquareRootCalculate);
            this.groupBoxSquareRootCalculator.Controls.Add(this.radioButtonSquareRootMInus);
            this.groupBoxSquareRootCalculator.Controls.Add(this.textBoxSquareRootResult);
            this.groupBoxSquareRootCalculator.Controls.Add(this.radioButtonSquareRootPlus);
            this.groupBoxSquareRootCalculator.Controls.Add(this.textBoxSquareRootOperand2);
            this.groupBoxSquareRootCalculator.Controls.Add(this.textBoxSquareRootOperand1);
            this.groupBoxSquareRootCalculator.Controls.Add(this.labelSquareRootResult);
            this.groupBoxSquareRootCalculator.Controls.Add(this.labelSquareRootOperand2);
            this.groupBoxSquareRootCalculator.Controls.Add(this.labelSquareRootOperator);
            this.groupBoxSquareRootCalculator.Controls.Add(this.labelSquareRootOperand1);
            this.groupBoxSquareRootCalculator.Location = new System.Drawing.Point(12, 218);
            this.groupBoxSquareRootCalculator.Name = "groupBoxSquareRootCalculator";
            this.groupBoxSquareRootCalculator.Size = new System.Drawing.Size(592, 97);
            this.groupBoxSquareRootCalculator.TabIndex = 0;
            this.groupBoxSquareRootCalculator.TabStop = false;
            this.groupBoxSquareRootCalculator.Text = "Square Root Calculator";
            // 
            // radioButtonSquareRootDivision
            // 
            this.radioButtonSquareRootDivision.AutoSize = true;
            this.radioButtonSquareRootDivision.Location = new System.Drawing.Point(195, 66);
            this.radioButtonSquareRootDivision.Name = "radioButtonSquareRootDivision";
            this.radioButtonSquareRootDivision.Size = new System.Drawing.Size(29, 16);
            this.radioButtonSquareRootDivision.TabIndex = 5;
            this.radioButtonSquareRootDivision.TabStop = true;
            this.radioButtonSquareRootDivision.Text = "/";
            this.radioButtonSquareRootDivision.UseVisualStyleBackColor = true;
            // 
            // radioButtonSquareRootMultiply
            // 
            this.radioButtonSquareRootMultiply.AutoSize = true;
            this.radioButtonSquareRootMultiply.Location = new System.Drawing.Point(146, 66);
            this.radioButtonSquareRootMultiply.Name = "radioButtonSquareRootMultiply";
            this.radioButtonSquareRootMultiply.Size = new System.Drawing.Size(29, 16);
            this.radioButtonSquareRootMultiply.TabIndex = 5;
            this.radioButtonSquareRootMultiply.TabStop = true;
            this.radioButtonSquareRootMultiply.Text = "*";
            this.radioButtonSquareRootMultiply.UseVisualStyleBackColor = true;
            // 
            // buttonSquareRootCalculate
            // 
            this.buttonSquareRootCalculate.Location = new System.Drawing.Point(383, 48);
            this.buttonSquareRootCalculate.Name = "buttonSquareRootCalculate";
            this.buttonSquareRootCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonSquareRootCalculate.TabIndex = 4;
            this.buttonSquareRootCalculate.Text = "Calculate";
            this.buttonSquareRootCalculate.UseVisualStyleBackColor = true;
            this.buttonSquareRootCalculate.Click += new System.EventHandler(this.buttonSquareRootCalculate_Click);
            // 
            // radioButtonSquareRootMInus
            // 
            this.radioButtonSquareRootMInus.AutoSize = true;
            this.radioButtonSquareRootMInus.Location = new System.Drawing.Point(195, 44);
            this.radioButtonSquareRootMInus.Name = "radioButtonSquareRootMInus";
            this.radioButtonSquareRootMInus.Size = new System.Drawing.Size(29, 16);
            this.radioButtonSquareRootMInus.TabIndex = 5;
            this.radioButtonSquareRootMInus.TabStop = true;
            this.radioButtonSquareRootMInus.Text = "-";
            this.radioButtonSquareRootMInus.UseVisualStyleBackColor = true;
            // 
            // textBoxSquareRootResult
            // 
            this.textBoxSquareRootResult.Location = new System.Drawing.Point(477, 50);
            this.textBoxSquareRootResult.Name = "textBoxSquareRootResult";
            this.textBoxSquareRootResult.Size = new System.Drawing.Size(100, 21);
            this.textBoxSquareRootResult.TabIndex = 2;
            // 
            // radioButtonSquareRootPlus
            // 
            this.radioButtonSquareRootPlus.AutoSize = true;
            this.radioButtonSquareRootPlus.Location = new System.Drawing.Point(146, 44);
            this.radioButtonSquareRootPlus.Name = "radioButtonSquareRootPlus";
            this.radioButtonSquareRootPlus.Size = new System.Drawing.Size(29, 16);
            this.radioButtonSquareRootPlus.TabIndex = 5;
            this.radioButtonSquareRootPlus.TabStop = true;
            this.radioButtonSquareRootPlus.Text = "+";
            this.radioButtonSquareRootPlus.UseVisualStyleBackColor = true;
            // 
            // textBoxSquareRootOperand2
            // 
            this.textBoxSquareRootOperand2.Location = new System.Drawing.Point(263, 50);
            this.textBoxSquareRootOperand2.Name = "textBoxSquareRootOperand2";
            this.textBoxSquareRootOperand2.Size = new System.Drawing.Size(100, 21);
            this.textBoxSquareRootOperand2.TabIndex = 2;
            // 
            // textBoxSquareRootOperand1
            // 
            this.textBoxSquareRootOperand1.Location = new System.Drawing.Point(12, 50);
            this.textBoxSquareRootOperand1.Name = "textBoxSquareRootOperand1";
            this.textBoxSquareRootOperand1.Size = new System.Drawing.Size(100, 21);
            this.textBoxSquareRootOperand1.TabIndex = 2;
            // 
            // labelSquareRootResult
            // 
            this.labelSquareRootResult.AutoSize = true;
            this.labelSquareRootResult.Location = new System.Drawing.Point(511, 25);
            this.labelSquareRootResult.Name = "labelSquareRootResult";
            this.labelSquareRootResult.Size = new System.Drawing.Size(40, 12);
            this.labelSquareRootResult.TabIndex = 1;
            this.labelSquareRootResult.Text = "Result";
            // 
            // labelSquareRootOperand2
            // 
            this.labelSquareRootOperand2.AutoSize = true;
            this.labelSquareRootOperand2.Location = new System.Drawing.Point(281, 25);
            this.labelSquareRootOperand2.Name = "labelSquareRootOperand2";
            this.labelSquareRootOperand2.Size = new System.Drawing.Size(63, 12);
            this.labelSquareRootOperand2.TabIndex = 1;
            this.labelSquareRootOperand2.Text = "Operand 2";
            // 
            // labelSquareRootOperator
            // 
            this.labelSquareRootOperator.AutoSize = true;
            this.labelSquareRootOperator.Location = new System.Drawing.Point(156, 25);
            this.labelSquareRootOperator.Name = "labelSquareRootOperator";
            this.labelSquareRootOperator.Size = new System.Drawing.Size(53, 12);
            this.labelSquareRootOperator.TabIndex = 1;
            this.labelSquareRootOperator.Text = "Operator";
            // 
            // labelSquareRootOperand1
            // 
            this.labelSquareRootOperand1.AutoSize = true;
            this.labelSquareRootOperand1.Location = new System.Drawing.Point(31, 25);
            this.labelSquareRootOperand1.Name = "labelSquareRootOperand1";
            this.labelSquareRootOperand1.Size = new System.Drawing.Size(63, 12);
            this.labelSquareRootOperand1.TabIndex = 1;
            this.labelSquareRootOperand1.Text = "Operand 1";
            // 
            // checkBoxSquareRootOperand1SqrtCheck
            // 
            this.checkBoxSquareRootOperand1SqrtCheck.AutoSize = true;
            this.checkBoxSquareRootOperand1SqrtCheck.Location = new System.Drawing.Point(100, 24);
            this.checkBoxSquareRootOperand1SqrtCheck.Name = "checkBoxSquareRootOperand1SqrtCheck";
            this.checkBoxSquareRootOperand1SqrtCheck.Size = new System.Drawing.Size(30, 16);
            this.checkBoxSquareRootOperand1SqrtCheck.TabIndex = 6;
            this.checkBoxSquareRootOperand1SqrtCheck.Text = "√";
            this.checkBoxSquareRootOperand1SqrtCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxSquareRootOperand2SqrtCheck
            // 
            this.checkBoxSquareRootOperand2SqrtCheck.AutoSize = true;
            this.checkBoxSquareRootOperand2SqrtCheck.Location = new System.Drawing.Point(350, 24);
            this.checkBoxSquareRootOperand2SqrtCheck.Name = "checkBoxSquareRootOperand2SqrtCheck";
            this.checkBoxSquareRootOperand2SqrtCheck.Size = new System.Drawing.Size(30, 16);
            this.checkBoxSquareRootOperand2SqrtCheck.TabIndex = 6;
            this.checkBoxSquareRootOperand2SqrtCheck.Text = "√";
            this.checkBoxSquareRootOperand2SqrtCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 327);
            this.Controls.Add(this.groupBoxSquareRootCalculator);
            this.Controls.Add(this.groupBoxRadioButtonCalc);
            this.Controls.Add(this.groupBoxComboCalc);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.groupBoxComboCalc.ResumeLayout(false);
            this.groupBoxComboCalc.PerformLayout();
            this.groupBoxRadioButtonCalc.ResumeLayout(false);
            this.groupBoxRadioButtonCalc.PerformLayout();
            this.groupBoxSquareRootCalculator.ResumeLayout(false);
            this.groupBoxSquareRootCalculator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxComboCalc;
        private System.Windows.Forms.ComboBox comboBoxComboCalc_Operators;
        private System.Windows.Forms.TextBox textBoxComboBoxOperand2;
        private System.Windows.Forms.TextBox textBoxComboBoxOperand1;
        private System.Windows.Forms.Label labelComboBoxResult;
        private System.Windows.Forms.Label labelComboBoxOperand2;
        private System.Windows.Forms.Label labelComboBoxOperator;
        private System.Windows.Forms.Label labelComboBoxOperand1;
        private System.Windows.Forms.Button buttonComboBoxCalculate;
        private System.Windows.Forms.TextBox textBoxComboBoxResult;
        private System.Windows.Forms.GroupBox groupBoxRadioButtonCalc;
        private System.Windows.Forms.RadioButton radioButtonRadioButtonPlus;
        private System.Windows.Forms.Button buttonRadioButtonCalculate;
        private System.Windows.Forms.TextBox textBoxRadioButtonResult;
        private System.Windows.Forms.TextBox textBoxRadioButtonOperand2;
        private System.Windows.Forms.TextBox textBoxRadioButtonOperand1;
        private System.Windows.Forms.Label labelRadioButtonResult;
        private System.Windows.Forms.Label labelRadioButtonOperand2;
        private System.Windows.Forms.Label labelRadioButtonOperator;
        private System.Windows.Forms.Label labelRadioButtonOperand1;
        private System.Windows.Forms.GroupBox groupBoxSquareRootCalculator;
        private System.Windows.Forms.Button buttonSquareRootCalculate;
        private System.Windows.Forms.TextBox textBoxSquareRootResult;
        private System.Windows.Forms.TextBox textBoxSquareRootOperand2;
        private System.Windows.Forms.TextBox textBoxSquareRootOperand1;
        private System.Windows.Forms.Label labelSquareRootResult;
        private System.Windows.Forms.Label labelSquareRootOperand2;
        private System.Windows.Forms.Label labelSquareRootOperator;
        private System.Windows.Forms.Label labelSquareRootOperand1;
        private System.Windows.Forms.RadioButton radioButtonRadioButtonMinus;
        private System.Windows.Forms.RadioButton radioButtonRadioButtonDivision;
        private System.Windows.Forms.RadioButton radioButtonRadioButtonMultiply;
        private System.Windows.Forms.RadioButton radioButtonSquareRootDivision;
        private System.Windows.Forms.RadioButton radioButtonSquareRootMultiply;
        private System.Windows.Forms.RadioButton radioButtonSquareRootMInus;
        private System.Windows.Forms.RadioButton radioButtonSquareRootPlus;
        private System.Windows.Forms.CheckBox checkBoxSquareRootOperand2SqrtCheck;
        private System.Windows.Forms.CheckBox checkBoxSquareRootOperand1SqrtCheck;
    }
}


namespace Fylon
{
    partial class Form_Number
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
            this.textBox_Digit = new System.Windows.Forms.TextBox();
            this.textBox_StartNumber = new System.Windows.Forms.TextBox();
            this.textBox_Between = new System.Windows.Forms.TextBox();
            this.label_Digit = new System.Windows.Forms.Label();
            this.label_StartNumber = new System.Windows.Forms.Label();
            this.label_Between = new System.Windows.Forms.Label();
            this.radioButton_Before = new System.Windows.Forms.RadioButton();
            this.radioButton_After = new System.Windows.Forms.RadioButton();
            this.button_Yes = new System.Windows.Forms.Button();
            this.button_No = new System.Windows.Forms.Button();
            this.radioButton_WholeList = new System.Windows.Forms.RadioButton();
            this.radioButton_SelectedList = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Digit
            // 
            this.textBox_Digit.Location = new System.Drawing.Point(207, 30);
            this.textBox_Digit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Digit.Name = "textBox_Digit";
            this.textBox_Digit.Size = new System.Drawing.Size(141, 28);
            this.textBox_Digit.TabIndex = 0;
            this.textBox_Digit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed);
            // 
            // textBox_StartNumber
            // 
            this.textBox_StartNumber.Location = new System.Drawing.Point(207, 70);
            this.textBox_StartNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_StartNumber.Name = "textBox_StartNumber";
            this.textBox_StartNumber.Size = new System.Drawing.Size(141, 28);
            this.textBox_StartNumber.TabIndex = 1;
            this.textBox_StartNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed);
            // 
            // textBox_Between
            // 
            this.textBox_Between.Location = new System.Drawing.Point(207, 111);
            this.textBox_Between.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Between.Name = "textBox_Between";
            this.textBox_Between.Size = new System.Drawing.Size(141, 28);
            this.textBox_Between.TabIndex = 2;
            this.textBox_Between.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // label_Digit
            // 
            this.label_Digit.AutoSize = true;
            this.label_Digit.Location = new System.Drawing.Point(146, 39);
            this.label_Digit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Digit.Name = "label_Digit";
            this.label_Digit.Size = new System.Drawing.Size(62, 18);
            this.label_Digit.TabIndex = 3;
            this.label_Digit.Text = "자리수";
            // 
            // label_StartNumber
            // 
            this.label_StartNumber.AutoSize = true;
            this.label_StartNumber.Location = new System.Drawing.Point(123, 80);
            this.label_StartNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_StartNumber.Name = "label_StartNumber";
            this.label_StartNumber.Size = new System.Drawing.Size(86, 18);
            this.label_StartNumber.TabIndex = 4;
            this.label_StartNumber.Text = "시작 숫자";
            // 
            // label_Between
            // 
            this.label_Between.AutoSize = true;
            this.label_Between.Location = new System.Drawing.Point(9, 120);
            this.label_Between.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Between.Name = "label_Between";
            this.label_Between.Size = new System.Drawing.Size(206, 18);
            this.label_Between.TabIndex = 5;
            this.label_Between.Text = "숫자와 이름 사이에 추가";
            // 
            // radioButton_Before
            // 
            this.radioButton_Before.AutoSize = true;
            this.radioButton_Before.Checked = true;
            this.radioButton_Before.Location = new System.Drawing.Point(11, 165);
            this.radioButton_Before.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Before.Name = "radioButton_Before";
            this.radioButton_Before.Size = new System.Drawing.Size(153, 22);
            this.radioButton_Before.TabIndex = 6;
            this.radioButton_Before.TabStop = true;
            this.radioButton_Before.Text = "이름 앞에 추가";
            this.radioButton_Before.UseVisualStyleBackColor = true;
            // 
            // radioButton_After
            // 
            this.radioButton_After.AutoSize = true;
            this.radioButton_After.Location = new System.Drawing.Point(203, 165);
            this.radioButton_After.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_After.Name = "radioButton_After";
            this.radioButton_After.Size = new System.Drawing.Size(153, 22);
            this.radioButton_After.TabIndex = 7;
            this.radioButton_After.TabStop = true;
            this.radioButton_After.Text = "이름 뒤에 추가";
            this.radioButton_After.UseVisualStyleBackColor = true;
            // 
            // button_Yes
            // 
            this.button_Yes.Location = new System.Drawing.Point(69, 270);
            this.button_Yes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(107, 34);
            this.button_Yes.TabIndex = 8;
            this.button_Yes.Text = "확인";
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // button_No
            // 
            this.button_No.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_No.Location = new System.Drawing.Point(220, 270);
            this.button_No.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(107, 34);
            this.button_No.TabIndex = 9;
            this.button_No.Text = "취소";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // radioButton_WholeList
            // 
            this.radioButton_WholeList.AutoSize = true;
            this.radioButton_WholeList.Checked = true;
            this.radioButton_WholeList.Location = new System.Drawing.Point(20, 18);
            this.radioButton_WholeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_WholeList.Name = "radioButton_WholeList";
            this.radioButton_WholeList.Size = new System.Drawing.Size(111, 22);
            this.radioButton_WholeList.TabIndex = 10;
            this.radioButton_WholeList.TabStop = true;
            this.radioButton_WholeList.Text = "전체 목록";
            this.radioButton_WholeList.UseVisualStyleBackColor = true;
            // 
            // radioButton_SelectedList
            // 
            this.radioButton_SelectedList.AutoSize = true;
            this.radioButton_SelectedList.Location = new System.Drawing.Point(211, 18);
            this.radioButton_SelectedList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_SelectedList.Name = "radioButton_SelectedList";
            this.radioButton_SelectedList.Size = new System.Drawing.Size(129, 22);
            this.radioButton_SelectedList.TabIndex = 11;
            this.radioButton_SelectedList.TabStop = true;
            this.radioButton_SelectedList.Text = "선택한 목록";
            this.radioButton_SelectedList.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Between);
            this.groupBox1.Controls.Add(this.textBox_Digit);
            this.groupBox1.Controls.Add(this.textBox_StartNumber);
            this.groupBox1.Controls.Add(this.textBox_Between);
            this.groupBox1.Controls.Add(this.radioButton_After);
            this.groupBox1.Controls.Add(this.label_Digit);
            this.groupBox1.Controls.Add(this.radioButton_Before);
            this.groupBox1.Controls.Add(this.label_StartNumber);
            this.groupBox1.Location = new System.Drawing.Point(17, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(366, 210);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "번호 붙이기";
            // 
            // Form_Number
            // 
            this.AcceptButton = this.button_Yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_No;
            this.ClientSize = new System.Drawing.Size(396, 320);
            this.Controls.Add(this.radioButton_SelectedList);
            this.Controls.Add(this.radioButton_WholeList);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Yes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Number";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "번호 붙이기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Digit;
        private System.Windows.Forms.TextBox textBox_StartNumber;
        private System.Windows.Forms.TextBox textBox_Between;
        private System.Windows.Forms.Label label_Digit;
        private System.Windows.Forms.Label label_StartNumber;
        private System.Windows.Forms.Label label_Between;
        private System.Windows.Forms.RadioButton radioButton_Before;
        private System.Windows.Forms.RadioButton radioButton_After;
        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.RadioButton radioButton_WholeList;
        private System.Windows.Forms.RadioButton radioButton_SelectedList;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
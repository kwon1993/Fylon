namespace Fylon
{
    partial class Form_AddString
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_AddString_Right = new System.Windows.Forms.RadioButton();
            this.radioButton_AddString_Left = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Yes = new System.Windows.Forms.Button();
            this.button_No = new System.Windows.Forms.Button();
            this.radioButton_WholeList = new System.Windows.Forms.RadioButton();
            this.radioButton_SelectedList = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_AddString_Right);
            this.groupBox1.Controls.Add(this.radioButton_AddString_Left);
            this.groupBox1.Location = new System.Drawing.Point(17, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(284, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "추가할 문자열 위치";
            // 
            // radioButton_AddString_Right
            // 
            this.radioButton_AddString_Right.AutoSize = true;
            this.radioButton_AddString_Right.Location = new System.Drawing.Point(141, 30);
            this.radioButton_AddString_Right.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_AddString_Right.Name = "radioButton_AddString_Right";
            this.radioButton_AddString_Right.Size = new System.Drawing.Size(129, 22);
            this.radioButton_AddString_Right.TabIndex = 1;
            this.radioButton_AddString_Right.Text = "문자열 뒤에";
            this.radioButton_AddString_Right.UseVisualStyleBackColor = true;
            // 
            // radioButton_AddString_Left
            // 
            this.radioButton_AddString_Left.AutoSize = true;
            this.radioButton_AddString_Left.Checked = true;
            this.radioButton_AddString_Left.Location = new System.Drawing.Point(9, 30);
            this.radioButton_AddString_Left.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_AddString_Left.Name = "radioButton_AddString_Left";
            this.radioButton_AddString_Left.Size = new System.Drawing.Size(129, 22);
            this.radioButton_AddString_Left.TabIndex = 0;
            this.radioButton_AddString_Left.TabStop = true;
            this.radioButton_AddString_Left.Text = "문자열 앞에";
            this.radioButton_AddString_Left.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(17, 132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(286, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "추가할 문자열";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // button_Yes
            // 
            this.button_Yes.Location = new System.Drawing.Point(26, 220);
            this.button_Yes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(107, 34);
            this.button_Yes.TabIndex = 2;
            this.button_Yes.Text = "확인";
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // button_No
            // 
            this.button_No.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_No.Location = new System.Drawing.Point(176, 220);
            this.button_No.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(107, 34);
            this.button_No.TabIndex = 3;
            this.button_No.Text = "취소";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // radioButton_WholeList
            // 
            this.radioButton_WholeList.AutoSize = true;
            this.radioButton_WholeList.Checked = true;
            this.radioButton_WholeList.Location = new System.Drawing.Point(26, 18);
            this.radioButton_WholeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_WholeList.Name = "radioButton_WholeList";
            this.radioButton_WholeList.Size = new System.Drawing.Size(111, 22);
            this.radioButton_WholeList.TabIndex = 4;
            this.radioButton_WholeList.TabStop = true;
            this.radioButton_WholeList.Text = "전체 목록";
            this.radioButton_WholeList.UseVisualStyleBackColor = true;
            // 
            // radioButton_SelectedList
            // 
            this.radioButton_SelectedList.AutoSize = true;
            this.radioButton_SelectedList.Location = new System.Drawing.Point(176, 18);
            this.radioButton_SelectedList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_SelectedList.Name = "radioButton_SelectedList";
            this.radioButton_SelectedList.Size = new System.Drawing.Size(129, 22);
            this.radioButton_SelectedList.TabIndex = 5;
            this.radioButton_SelectedList.Text = "선택한 목록";
            this.radioButton_SelectedList.UseVisualStyleBackColor = true;
            // 
            // Form_AddString
            // 
            this.AcceptButton = this.button_Yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_No;
            this.ClientSize = new System.Drawing.Size(321, 280);
            this.Controls.Add(this.radioButton_SelectedList);
            this.Controls.Add(this.radioButton_WholeList);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Yes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_AddString";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "문자열 추가하기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_AddString_Right;
        private System.Windows.Forms.RadioButton radioButton_AddString_Left;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.RadioButton radioButton_WholeList;
        private System.Windows.Forms.RadioButton radioButton_SelectedList;
    }
}
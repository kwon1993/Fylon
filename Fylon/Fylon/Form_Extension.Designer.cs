namespace Fylon
{
    partial class Form_Extension
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
            this.radioButton_ExtensionAdd = new System.Windows.Forms.RadioButton();
            this.radioButton_ExtensionReplace = new System.Windows.Forms.RadioButton();
            this.radioButton_ExtensionRemove = new System.Windows.Forms.RadioButton();
            this.textBox_ExtensionAdd = new System.Windows.Forms.TextBox();
            this.textBox_ExtensionReplace = new System.Windows.Forms.TextBox();
            this.radioButton_WholeList = new System.Windows.Forms.RadioButton();
            this.radioButton_SelectedList = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Yes = new System.Windows.Forms.Button();
            this.button_No = new System.Windows.Forms.Button();
            this.radioButton_LeftEnglishAndNumbers = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_ExtensionAdd
            // 
            this.radioButton_ExtensionAdd.AutoSize = true;
            this.radioButton_ExtensionAdd.Checked = true;
            this.radioButton_ExtensionAdd.Location = new System.Drawing.Point(6, 20);
            this.radioButton_ExtensionAdd.Name = "radioButton_ExtensionAdd";
            this.radioButton_ExtensionAdd.Size = new System.Drawing.Size(87, 16);
            this.radioButton_ExtensionAdd.TabIndex = 0;
            this.radioButton_ExtensionAdd.TabStop = true;
            this.radioButton_ExtensionAdd.Text = "확장자 추가";
            this.radioButton_ExtensionAdd.UseVisualStyleBackColor = true;
            this.radioButton_ExtensionAdd.CheckedChanged += new System.EventHandler(this.radioButton_ExtensionAdd_CheckedChanged);
            // 
            // radioButton_ExtensionReplace
            // 
            this.radioButton_ExtensionReplace.AutoSize = true;
            this.radioButton_ExtensionReplace.Location = new System.Drawing.Point(6, 69);
            this.radioButton_ExtensionReplace.Name = "radioButton_ExtensionReplace";
            this.radioButton_ExtensionReplace.Size = new System.Drawing.Size(87, 16);
            this.radioButton_ExtensionReplace.TabIndex = 1;
            this.radioButton_ExtensionReplace.Text = "확장자 변경";
            this.radioButton_ExtensionReplace.UseVisualStyleBackColor = true;
            this.radioButton_ExtensionReplace.CheckedChanged += new System.EventHandler(this.radioButton_ExtensionReplace_CheckedChanged);
            // 
            // radioButton_ExtensionRemove
            // 
            this.radioButton_ExtensionRemove.AutoSize = true;
            this.radioButton_ExtensionRemove.Location = new System.Drawing.Point(6, 118);
            this.radioButton_ExtensionRemove.Name = "radioButton_ExtensionRemove";
            this.radioButton_ExtensionRemove.Size = new System.Drawing.Size(87, 16);
            this.radioButton_ExtensionRemove.TabIndex = 2;
            this.radioButton_ExtensionRemove.TabStop = true;
            this.radioButton_ExtensionRemove.Text = "확장자 삭제";
            this.radioButton_ExtensionRemove.UseVisualStyleBackColor = true;
            // 
            // textBox_ExtensionAdd
            // 
            this.textBox_ExtensionAdd.Location = new System.Drawing.Point(6, 42);
            this.textBox_ExtensionAdd.Name = "textBox_ExtensionAdd";
            this.textBox_ExtensionAdd.Size = new System.Drawing.Size(100, 21);
            this.textBox_ExtensionAdd.TabIndex = 3;
            this.textBox_ExtensionAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // textBox_ExtensionReplace
            // 
            this.textBox_ExtensionReplace.Location = new System.Drawing.Point(6, 91);
            this.textBox_ExtensionReplace.Name = "textBox_ExtensionReplace";
            this.textBox_ExtensionReplace.ReadOnly = true;
            this.textBox_ExtensionReplace.Size = new System.Drawing.Size(100, 21);
            this.textBox_ExtensionReplace.TabIndex = 4;
            this.textBox_ExtensionReplace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // radioButton_WholeList
            // 
            this.radioButton_WholeList.AutoSize = true;
            this.radioButton_WholeList.Checked = true;
            this.radioButton_WholeList.Location = new System.Drawing.Point(12, 12);
            this.radioButton_WholeList.Name = "radioButton_WholeList";
            this.radioButton_WholeList.Size = new System.Drawing.Size(75, 16);
            this.radioButton_WholeList.TabIndex = 5;
            this.radioButton_WholeList.TabStop = true;
            this.radioButton_WholeList.Text = "전체 목록";
            this.radioButton_WholeList.UseVisualStyleBackColor = true;
            // 
            // radioButton_SelectedList
            // 
            this.radioButton_SelectedList.AutoSize = true;
            this.radioButton_SelectedList.Location = new System.Drawing.Point(93, 12);
            this.radioButton_SelectedList.Name = "radioButton_SelectedList";
            this.radioButton_SelectedList.Size = new System.Drawing.Size(87, 16);
            this.radioButton_SelectedList.TabIndex = 6;
            this.radioButton_SelectedList.TabStop = true;
            this.radioButton_SelectedList.Text = "선택한 목록";
            this.radioButton_SelectedList.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_LeftEnglishAndNumbers);
            this.groupBox1.Controls.Add(this.radioButton_ExtensionAdd);
            this.groupBox1.Controls.Add(this.textBox_ExtensionAdd);
            this.groupBox1.Controls.Add(this.radioButton_ExtensionRemove);
            this.groupBox1.Controls.Add(this.textBox_ExtensionReplace);
            this.groupBox1.Controls.Add(this.radioButton_ExtensionReplace);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 164);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "확장자 관리";
            // 
            // button_Yes
            // 
            this.button_Yes.Location = new System.Drawing.Point(18, 204);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(75, 23);
            this.button_Yes.TabIndex = 8;
            this.button_Yes.Text = "확인";
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // button_No
            // 
            this.button_No.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_No.Location = new System.Drawing.Point(118, 204);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(75, 23);
            this.button_No.TabIndex = 9;
            this.button_No.Text = "취소";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // radioButton_LeftEnglishAndNumbers
            // 
            this.radioButton_LeftEnglishAndNumbers.AutoSize = true;
            this.radioButton_LeftEnglishAndNumbers.Location = new System.Drawing.Point(6, 140);
            this.radioButton_LeftEnglishAndNumbers.Name = "radioButton_LeftEnglishAndNumbers";
            this.radioButton_LeftEnglishAndNumbers.Size = new System.Drawing.Size(175, 16);
            this.radioButton_LeftEnglishAndNumbers.TabIndex = 5;
            this.radioButton_LeftEnglishAndNumbers.TabStop = true;
            this.radioButton_LeftEnglishAndNumbers.Text = "영어, 숫자 제외한 문자 삭제";
            this.radioButton_LeftEnglishAndNumbers.UseVisualStyleBackColor = true;
            // 
            // Form_Extension
            // 
            this.AcceptButton = this.button_Yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_No;
            this.ClientSize = new System.Drawing.Size(210, 235);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Yes);
            this.Controls.Add(this.radioButton_SelectedList);
            this.Controls.Add(this.radioButton_WholeList);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Extension";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "확장자 관리";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_ExtensionAdd;
        private System.Windows.Forms.RadioButton radioButton_ExtensionReplace;
        private System.Windows.Forms.RadioButton radioButton_ExtensionRemove;
        private System.Windows.Forms.TextBox textBox_ExtensionAdd;
        private System.Windows.Forms.TextBox textBox_ExtensionReplace;
        private System.Windows.Forms.RadioButton radioButton_WholeList;
        private System.Windows.Forms.RadioButton radioButton_SelectedList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.RadioButton radioButton_LeftEnglishAndNumbers;
    }
}
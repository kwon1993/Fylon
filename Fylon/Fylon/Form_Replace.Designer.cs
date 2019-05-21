namespace Fylon
{
    partial class Form_Replace
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Before = new System.Windows.Forms.TextBox();
            this.textBox_After = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Yes = new System.Windows.Forms.Button();
            this.button_No = new System.Windows.Forms.Button();
            this.radioButton_WholeList = new System.Windows.Forms.RadioButton();
            this.radioButton_SelectedList = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Lear = new System.Windows.Forms.RadioButton();
            this.radioButton_All = new System.Windows.Forms.RadioButton();
            this.radioButton_Front = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "를";
            // 
            // textBox_Before
            // 
            this.textBox_Before.Location = new System.Drawing.Point(9, 30);
            this.textBox_Before.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Before.Name = "textBox_Before";
            this.textBox_Before.Size = new System.Drawing.Size(141, 28);
            this.textBox_Before.TabIndex = 1;
            this.textBox_Before.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // textBox_After
            // 
            this.textBox_After.Location = new System.Drawing.Point(9, 104);
            this.textBox_After.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_After.Name = "textBox_After";
            this.textBox_After.Size = new System.Drawing.Size(141, 28);
            this.textBox_After.TabIndex = 2;
            this.textBox_After.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "로 바꾸기";
            // 
            // button_Yes
            // 
            this.button_Yes.Location = new System.Drawing.Point(26, 212);
            this.button_Yes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(107, 34);
            this.button_Yes.TabIndex = 4;
            this.button_Yes.Text = "확인";
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // button_No
            // 
            this.button_No.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_No.Location = new System.Drawing.Point(174, 212);
            this.button_No.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(107, 34);
            this.button_No.TabIndex = 5;
            this.button_No.Text = "취소";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // radioButton_WholeList
            // 
            this.radioButton_WholeList.AutoSize = true;
            this.radioButton_WholeList.Checked = true;
            this.radioButton_WholeList.Location = new System.Drawing.Point(17, 18);
            this.radioButton_WholeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_WholeList.Name = "radioButton_WholeList";
            this.radioButton_WholeList.Size = new System.Drawing.Size(111, 22);
            this.radioButton_WholeList.TabIndex = 6;
            this.radioButton_WholeList.TabStop = true;
            this.radioButton_WholeList.Text = "전체 목록";
            this.radioButton_WholeList.UseVisualStyleBackColor = true;
            // 
            // radioButton_SelectedList
            // 
            this.radioButton_SelectedList.AutoSize = true;
            this.radioButton_SelectedList.Location = new System.Drawing.Point(157, 18);
            this.radioButton_SelectedList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_SelectedList.Name = "radioButton_SelectedList";
            this.radioButton_SelectedList.Size = new System.Drawing.Size(129, 22);
            this.radioButton_SelectedList.TabIndex = 7;
            this.radioButton_SelectedList.Text = "선택한 목록";
            this.radioButton_SelectedList.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Lear);
            this.groupBox1.Controls.Add(this.radioButton_All);
            this.groupBox1.Controls.Add(this.radioButton_Front);
            this.groupBox1.Controls.Add(this.textBox_Before);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_After);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(286, 152);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "찾아 바꾸기";
            // 
            // radioButton_Lear
            // 
            this.radioButton_Lear.AutoSize = true;
            this.radioButton_Lear.Location = new System.Drawing.Point(183, 70);
            this.radioButton_Lear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Lear.Name = "radioButton_Lear";
            this.radioButton_Lear.Size = new System.Drawing.Size(93, 22);
            this.radioButton_Lear.TabIndex = 6;
            this.radioButton_Lear.Text = "맨 뒤만";
            this.radioButton_Lear.UseVisualStyleBackColor = true;
            // 
            // radioButton_All
            // 
            this.radioButton_All.AutoSize = true;
            this.radioButton_All.Checked = true;
            this.radioButton_All.Location = new System.Drawing.Point(9, 70);
            this.radioButton_All.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_All.Name = "radioButton_All";
            this.radioButton_All.Size = new System.Drawing.Size(69, 22);
            this.radioButton_All.TabIndex = 5;
            this.radioButton_All.TabStop = true;
            this.radioButton_All.Text = "전부";
            this.radioButton_All.UseVisualStyleBackColor = true;
            // 
            // radioButton_Front
            // 
            this.radioButton_Front.AutoSize = true;
            this.radioButton_Front.Location = new System.Drawing.Point(84, 72);
            this.radioButton_Front.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Front.Name = "radioButton_Front";
            this.radioButton_Front.Size = new System.Drawing.Size(93, 22);
            this.radioButton_Front.TabIndex = 4;
            this.radioButton_Front.Text = "맨 앞만";
            this.radioButton_Front.UseVisualStyleBackColor = true;
            // 
            // Form_Replace
            // 
            this.AcceptButton = this.button_Yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_No;
            this.ClientSize = new System.Drawing.Size(323, 260);
            this.Controls.Add(this.radioButton_SelectedList);
            this.Controls.Add(this.radioButton_WholeList);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Yes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Replace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "찾아 바꾸기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Before;
        private System.Windows.Forms.TextBox textBox_After;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.RadioButton radioButton_WholeList;
        private System.Windows.Forms.RadioButton radioButton_SelectedList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Lear;
        private System.Windows.Forms.RadioButton radioButton_All;
        private System.Windows.Forms.RadioButton radioButton_Front;
    }
}
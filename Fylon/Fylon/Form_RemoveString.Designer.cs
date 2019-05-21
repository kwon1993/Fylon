namespace Fylon
{
    partial class Form_RemoveString
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
            this.radioButton_Location = new System.Windows.Forms.RadioButton();
            this.radioButton_Bind = new System.Windows.Forms.RadioButton();
            this.textBox_LocationStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_LocationEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_BindEnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_BindStart = new System.Windows.Forms.TextBox();
            this.radioButton_Type = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Combined = new System.Windows.Forms.RadioButton();
            this.radioButton_Space = new System.Windows.Forms.RadioButton();
            this.radioButton_Number = new System.Windows.Forms.RadioButton();
            this.radioButton_English = new System.Windows.Forms.RadioButton();
            this.radioButton_Korean = new System.Windows.Forms.RadioButton();
            this.radioButton_TypeLeave = new System.Windows.Forms.RadioButton();
            this.radioButton_TypeRemove = new System.Windows.Forms.RadioButton();
            this.radioButton_Typing = new System.Windows.Forms.RadioButton();
            this.textBox_Typing = new System.Windows.Forms.TextBox();
            this.button_Yes = new System.Windows.Forms.Button();
            this.button_No = new System.Windows.Forms.Button();
            this.button_Run = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_WholeList = new System.Windows.Forms.RadioButton();
            this.radioButton_SelectedList = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_Location
            // 
            this.radioButton_Location.AutoSize = true;
            this.radioButton_Location.Checked = true;
            this.radioButton_Location.Location = new System.Drawing.Point(9, 30);
            this.radioButton_Location.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Location.Name = "radioButton_Location";
            this.radioButton_Location.Size = new System.Drawing.Size(207, 22);
            this.radioButton_Location.TabIndex = 0;
            this.radioButton_Location.TabStop = true;
            this.radioButton_Location.Text = "위치 지정하여 지우기";
            this.radioButton_Location.UseVisualStyleBackColor = true;
            this.radioButton_Location.CheckedChanged += new System.EventHandler(this.radioButton_Location_CheckedChanged);
            // 
            // radioButton_Bind
            // 
            this.radioButton_Bind.AutoSize = true;
            this.radioButton_Bind.Location = new System.Drawing.Point(9, 112);
            this.radioButton_Bind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Bind.Name = "radioButton_Bind";
            this.radioButton_Bind.Size = new System.Drawing.Size(171, 22);
            this.radioButton_Bind.TabIndex = 1;
            this.radioButton_Bind.Text = "문자 사이 지우기";
            this.radioButton_Bind.UseVisualStyleBackColor = true;
            this.radioButton_Bind.CheckedChanged += new System.EventHandler(this.radioButton_Bind_CheckedChanged);
            // 
            // textBox_LocationStart
            // 
            this.textBox_LocationStart.Location = new System.Drawing.Point(9, 63);
            this.textBox_LocationStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_LocationStart.Name = "textBox_LocationStart";
            this.textBox_LocationStart.Size = new System.Drawing.Size(70, 28);
            this.textBox_LocationStart.TabIndex = 2;
            this.textBox_LocationStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "번째 부터";
            // 
            // textBox_LocationEnd
            // 
            this.textBox_LocationEnd.Location = new System.Drawing.Point(169, 63);
            this.textBox_LocationEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_LocationEnd.Name = "textBox_LocationEnd";
            this.textBox_LocationEnd.Size = new System.Drawing.Size(70, 28);
            this.textBox_LocationEnd.TabIndex = 4;
            this.textBox_LocationEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "번째 까지 지우기";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "까지 지우기";
            // 
            // textBox_BindEnd
            // 
            this.textBox_BindEnd.Location = new System.Drawing.Point(133, 146);
            this.textBox_BindEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_BindEnd.Name = "textBox_BindEnd";
            this.textBox_BindEnd.ReadOnly = true;
            this.textBox_BindEnd.Size = new System.Drawing.Size(70, 28);
            this.textBox_BindEnd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "부터";
            // 
            // textBox_BindStart
            // 
            this.textBox_BindStart.Location = new System.Drawing.Point(9, 146);
            this.textBox_BindStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_BindStart.Name = "textBox_BindStart";
            this.textBox_BindStart.ReadOnly = true;
            this.textBox_BindStart.Size = new System.Drawing.Size(70, 28);
            this.textBox_BindStart.TabIndex = 6;
            // 
            // radioButton_Type
            // 
            this.radioButton_Type.AutoSize = true;
            this.radioButton_Type.Location = new System.Drawing.Point(9, 195);
            this.radioButton_Type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Type.Name = "radioButton_Type";
            this.radioButton_Type.Size = new System.Drawing.Size(207, 22);
            this.radioButton_Type.TabIndex = 10;
            this.radioButton_Type.Text = "특정 문자형식 지우기";
            this.radioButton_Type.UseVisualStyleBackColor = true;
            this.radioButton_Type.CheckedChanged += new System.EventHandler(this.radioButton_Type_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Combined);
            this.groupBox1.Controls.Add(this.radioButton_Space);
            this.groupBox1.Controls.Add(this.radioButton_Number);
            this.groupBox1.Controls.Add(this.radioButton_English);
            this.groupBox1.Controls.Add(this.radioButton_Korean);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(9, 228);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(373, 135);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "조건";
            // 
            // radioButton_Combined
            // 
            this.radioButton_Combined.AutoSize = true;
            this.radioButton_Combined.Location = new System.Drawing.Point(9, 94);
            this.radioButton_Combined.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Combined.Name = "radioButton_Combined";
            this.radioButton_Combined.Size = new System.Drawing.Size(267, 22);
            this.radioButton_Combined.TabIndex = 7;
            this.radioButton_Combined.TabStop = true;
            this.radioButton_Combined.Text = "한글, 영어, 숫자, 스페이스바";
            this.radioButton_Combined.UseVisualStyleBackColor = true;
            // 
            // radioButton_Space
            // 
            this.radioButton_Space.AutoSize = true;
            this.radioButton_Space.Location = new System.Drawing.Point(201, 62);
            this.radioButton_Space.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Space.Name = "radioButton_Space";
            this.radioButton_Space.Size = new System.Drawing.Size(129, 22);
            this.radioButton_Space.TabIndex = 6;
            this.radioButton_Space.Text = "스페이스 바";
            this.radioButton_Space.UseVisualStyleBackColor = true;
            // 
            // radioButton_Number
            // 
            this.radioButton_Number.AutoSize = true;
            this.radioButton_Number.Location = new System.Drawing.Point(9, 62);
            this.radioButton_Number.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Number.Name = "radioButton_Number";
            this.radioButton_Number.Size = new System.Drawing.Size(69, 22);
            this.radioButton_Number.TabIndex = 6;
            this.radioButton_Number.Text = "숫자";
            this.radioButton_Number.UseVisualStyleBackColor = true;
            // 
            // radioButton_English
            // 
            this.radioButton_English.AutoSize = true;
            this.radioButton_English.Location = new System.Drawing.Point(201, 28);
            this.radioButton_English.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_English.Name = "radioButton_English";
            this.radioButton_English.Size = new System.Drawing.Size(69, 22);
            this.radioButton_English.TabIndex = 6;
            this.radioButton_English.Text = "영어";
            this.radioButton_English.UseVisualStyleBackColor = true;
            // 
            // radioButton_Korean
            // 
            this.radioButton_Korean.AutoSize = true;
            this.radioButton_Korean.Checked = true;
            this.radioButton_Korean.Location = new System.Drawing.Point(9, 28);
            this.radioButton_Korean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Korean.Name = "radioButton_Korean";
            this.radioButton_Korean.Size = new System.Drawing.Size(69, 22);
            this.radioButton_Korean.TabIndex = 6;
            this.radioButton_Korean.TabStop = true;
            this.radioButton_Korean.Text = "한글";
            this.radioButton_Korean.UseVisualStyleBackColor = true;
            // 
            // radioButton_TypeLeave
            // 
            this.radioButton_TypeLeave.AutoSize = true;
            this.radioButton_TypeLeave.Location = new System.Drawing.Point(201, 30);
            this.radioButton_TypeLeave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_TypeLeave.Name = "radioButton_TypeLeave";
            this.radioButton_TypeLeave.Size = new System.Drawing.Size(87, 22);
            this.radioButton_TypeLeave.TabIndex = 5;
            this.radioButton_TypeLeave.TabStop = true;
            this.radioButton_TypeLeave.Text = "남기기";
            this.radioButton_TypeLeave.UseVisualStyleBackColor = true;
            // 
            // radioButton_TypeRemove
            // 
            this.radioButton_TypeRemove.AutoSize = true;
            this.radioButton_TypeRemove.Checked = true;
            this.radioButton_TypeRemove.Location = new System.Drawing.Point(9, 30);
            this.radioButton_TypeRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_TypeRemove.Name = "radioButton_TypeRemove";
            this.radioButton_TypeRemove.Size = new System.Drawing.Size(87, 22);
            this.radioButton_TypeRemove.TabIndex = 4;
            this.radioButton_TypeRemove.TabStop = true;
            this.radioButton_TypeRemove.Text = "지우기";
            this.radioButton_TypeRemove.UseVisualStyleBackColor = true;
            // 
            // radioButton_Typing
            // 
            this.radioButton_Typing.AutoSize = true;
            this.radioButton_Typing.Location = new System.Drawing.Point(9, 456);
            this.radioButton_Typing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Typing.Name = "radioButton_Typing";
            this.radioButton_Typing.Size = new System.Drawing.Size(189, 22);
            this.radioButton_Typing.TabIndex = 12;
            this.radioButton_Typing.Text = "입력한 문구 지우기";
            this.radioButton_Typing.UseVisualStyleBackColor = true;
            this.radioButton_Typing.CheckedChanged += new System.EventHandler(this.radioButton_Typing_CheckedChanged);
            // 
            // textBox_Typing
            // 
            this.textBox_Typing.Location = new System.Drawing.Point(9, 489);
            this.textBox_Typing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Typing.Name = "textBox_Typing";
            this.textBox_Typing.ReadOnly = true;
            this.textBox_Typing.Size = new System.Drawing.Size(371, 28);
            this.textBox_Typing.TabIndex = 13;
            this.textBox_Typing.TextChanged += new System.EventHandler(this.textBox_Typing_TextChanged);
            this.textBox_Typing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // button_Yes
            // 
            this.button_Yes.Location = new System.Drawing.Point(26, 602);
            this.button_Yes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(107, 34);
            this.button_Yes.TabIndex = 14;
            this.button_Yes.Text = "확인";
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // button_No
            // 
            this.button_No.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_No.Location = new System.Drawing.Point(160, 600);
            this.button_No.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(107, 34);
            this.button_No.TabIndex = 15;
            this.button_No.Text = "취소";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(291, 600);
            this.button_Run.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(107, 34);
            this.button_Run.TabIndex = 16;
            this.button_Run.Text = "적용";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_TypeRemove);
            this.groupBox2.Controls.Add(this.radioButton_TypeLeave);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(9, 372);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(373, 75);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "행동";
            // 
            // radioButton_WholeList
            // 
            this.radioButton_WholeList.AutoSize = true;
            this.radioButton_WholeList.Checked = true;
            this.radioButton_WholeList.Location = new System.Drawing.Point(17, 18);
            this.radioButton_WholeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_WholeList.Name = "radioButton_WholeList";
            this.radioButton_WholeList.Size = new System.Drawing.Size(111, 22);
            this.radioButton_WholeList.TabIndex = 18;
            this.radioButton_WholeList.TabStop = true;
            this.radioButton_WholeList.Text = "전체 목록";
            this.radioButton_WholeList.UseVisualStyleBackColor = true;
            // 
            // radioButton_SelectedList
            // 
            this.radioButton_SelectedList.AutoSize = true;
            this.radioButton_SelectedList.Location = new System.Drawing.Point(199, 18);
            this.radioButton_SelectedList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_SelectedList.Name = "radioButton_SelectedList";
            this.radioButton_SelectedList.Size = new System.Drawing.Size(129, 22);
            this.radioButton_SelectedList.TabIndex = 19;
            this.radioButton_SelectedList.Text = "선택한 목록";
            this.radioButton_SelectedList.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_Location);
            this.groupBox3.Controls.Add(this.radioButton_Bind);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.textBox_LocationStart);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox_LocationEnd);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox_Typing);
            this.groupBox3.Controls.Add(this.textBox_BindStart);
            this.groupBox3.Controls.Add(this.radioButton_Typing);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.textBox_BindEnd);
            this.groupBox3.Controls.Add(this.radioButton_Type);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(17, 54);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(391, 538);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "문자열 지우기";
            // 
            // Form_RemoveString
            // 
            this.AcceptButton = this.button_Yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_No;
            this.ClientSize = new System.Drawing.Size(427, 654);
            this.Controls.Add(this.radioButton_SelectedList);
            this.Controls.Add(this.radioButton_WholeList);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Yes);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_RemoveString";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "문자열 지우기";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_Location;
        private System.Windows.Forms.RadioButton radioButton_Bind;
        private System.Windows.Forms.TextBox textBox_LocationStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_LocationEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_BindEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_BindStart;
        private System.Windows.Forms.RadioButton radioButton_Type;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_TypeLeave;
        private System.Windows.Forms.RadioButton radioButton_TypeRemove;
        private System.Windows.Forms.RadioButton radioButton_Typing;
        private System.Windows.Forms.TextBox textBox_Typing;
        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.RadioButton radioButton_Space;
        private System.Windows.Forms.RadioButton radioButton_Number;
        private System.Windows.Forms.RadioButton radioButton_English;
        private System.Windows.Forms.RadioButton radioButton_Korean;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Combined;
        private System.Windows.Forms.RadioButton radioButton_WholeList;
        private System.Windows.Forms.RadioButton radioButton_SelectedList;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
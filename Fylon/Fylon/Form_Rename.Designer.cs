namespace Fylon
{
    partial class Form_Rename
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
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Yes = new System.Windows.Forms.Button();
            this.button_No = new System.Windows.Forms.Button();
            this.label_extension = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(17, 48);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(100, 18);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "label_Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 70);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // button_Yes
            // 
            this.button_Yes.Location = new System.Drawing.Point(124, 120);
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
            this.button_No.Location = new System.Drawing.Point(280, 120);
            this.button_No.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(107, 34);
            this.button_No.TabIndex = 3;
            this.button_No.Text = "취소";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click_1);
            // 
            // label_extension
            // 
            this.label_extension.AutoSize = true;
            this.label_extension.Location = new System.Drawing.Point(390, 84);
            this.label_extension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_extension.Name = "label_extension";
            this.label_extension.Size = new System.Drawing.Size(93, 18);
            this.label_extension.TabIndex = 4;
            this.label_extension.Text = ".extension";
            // 
            // Form_Rename
            // 
            this.AcceptButton = this.button_Yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_No;
            this.ClientSize = new System.Drawing.Size(499, 172);
            this.Controls.Add(this.label_extension);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Yes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Name);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Rename";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "이름 바꾸기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.Label label_extension;
    }
}
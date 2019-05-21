namespace Fylon
{
    partial class Form_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.버전ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_RemoveAll = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_BeforeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_AfterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_CreatedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ModifiedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_RemoveSelect = new System.Windows.Forms.Button();
            this.button_AddString = new System.Windows.Forms.Button();
            this.button_Up = new System.Windows.Forms.Button();
            this.button_Down = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_RemoveString = new System.Windows.Forms.Button();
            this.button_RemoveName = new System.Windows.Forms.Button();
            this.button_Number = new System.Windows.Forms.Button();
            this.button_Replace = new System.Windows.Forms.Button();
            this.button_MoveFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Extension = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.버전ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1143, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.끝내기ToolStripMenuItem});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(60, 29);
            this.ToolStripMenuItem_File.Text = "파일";
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 버전ToolStripMenuItem
            // 
            this.버전ToolStripMenuItem.Name = "버전ToolStripMenuItem";
            this.버전ToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.버전ToolStripMenuItem.Text = "버전";
            this.버전ToolStripMenuItem.Click += new System.EventHandler(this.버전ToolStripMenuItem_Click);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(0, 40);
            this.button_Load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(107, 34);
            this.button_Load.TabIndex = 1;
            this.button_Load.Text = "불러오기";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.Button_Load_Click);
            // 
            // button_Save
            // 
            this.button_Save.Enabled = false;
            this.button_Save.Location = new System.Drawing.Point(0, 84);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(107, 34);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "변경적용";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // button_RemoveAll
            // 
            this.button_RemoveAll.Enabled = false;
            this.button_RemoveAll.Location = new System.Drawing.Point(0, 171);
            this.button_RemoveAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_RemoveAll.Name = "button_RemoveAll";
            this.button_RemoveAll.Size = new System.Drawing.Size(107, 34);
            this.button_RemoveAll.TabIndex = 3;
            this.button_RemoveAll.Text = "목록지우기";
            this.button_RemoveAll.UseVisualStyleBackColor = true;
            this.button_RemoveAll.Click += new System.EventHandler(this.Button_RemoveAll_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.AllowDrop = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_BeforeName,
            this.columnHeader_AfterName,
            this.columnHeader_Path,
            this.columnHeader_CreatedDate,
            this.columnHeader_ModifiedDate});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(116, 40);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1008, 642);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView_ColumnClick);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListDoubleClick);
            // 
            // columnHeader_BeforeName
            // 
            this.columnHeader_BeforeName.Tag = "";
            this.columnHeader_BeforeName.Text = "파일 이름";
            this.columnHeader_BeforeName.Width = 200;
            // 
            // columnHeader_AfterName
            // 
            this.columnHeader_AfterName.Tag = "";
            this.columnHeader_AfterName.Text = "바뀌는 이름";
            this.columnHeader_AfterName.Width = 200;
            // 
            // columnHeader_Path
            // 
            this.columnHeader_Path.Tag = "";
            this.columnHeader_Path.Text = "경로";
            this.columnHeader_Path.Width = 100;
            // 
            // columnHeader_CreatedDate
            // 
            this.columnHeader_CreatedDate.Text = "생성된 날짜";
            this.columnHeader_CreatedDate.Width = 100;
            // 
            // columnHeader_ModifiedDate
            // 
            this.columnHeader_ModifiedDate.Text = "수정된 날짜";
            this.columnHeader_ModifiedDate.Width = 100;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "모든파일|*.*";
            this.openFileDialog1.Title = "불러오기";
            // 
            // button_RemoveSelect
            // 
            this.button_RemoveSelect.Enabled = false;
            this.button_RemoveSelect.Location = new System.Drawing.Point(0, 214);
            this.button_RemoveSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_RemoveSelect.Name = "button_RemoveSelect";
            this.button_RemoveSelect.Size = new System.Drawing.Size(107, 34);
            this.button_RemoveSelect.TabIndex = 5;
            this.button_RemoveSelect.Text = "선택삭제";
            this.button_RemoveSelect.UseVisualStyleBackColor = true;
            this.button_RemoveSelect.Click += new System.EventHandler(this.Button_RemoveSelect_Click);
            // 
            // button_AddString
            // 
            this.button_AddString.Enabled = false;
            this.button_AddString.Location = new System.Drawing.Point(0, 302);
            this.button_AddString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_AddString.Name = "button_AddString";
            this.button_AddString.Size = new System.Drawing.Size(107, 34);
            this.button_AddString.TabIndex = 6;
            this.button_AddString.Text = "문자열추가";
            this.button_AddString.UseVisualStyleBackColor = true;
            this.button_AddString.Click += new System.EventHandler(this.Button_AddString_Click);
            // 
            // button_Up
            // 
            this.button_Up.Enabled = false;
            this.button_Up.Location = new System.Drawing.Point(9, 30);
            this.button_Up.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Up.Name = "button_Up";
            this.button_Up.Size = new System.Drawing.Size(90, 34);
            this.button_Up.TabIndex = 7;
            this.button_Up.Text = "↑";
            this.button_Up.UseVisualStyleBackColor = true;
            this.button_Up.Click += new System.EventHandler(this.Button_Up_Click);
            // 
            // button_Down
            // 
            this.button_Down.Enabled = false;
            this.button_Down.Location = new System.Drawing.Point(9, 74);
            this.button_Down.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Down.Name = "button_Down";
            this.button_Down.Size = new System.Drawing.Size(90, 34);
            this.button_Down.TabIndex = 8;
            this.button_Down.Text = "↓";
            this.button_Down.UseVisualStyleBackColor = true;
            this.button_Down.Click += new System.EventHandler(this.Button_Down_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Enabled = false;
            this.button_Reset.Location = new System.Drawing.Point(0, 128);
            this.button_Reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(107, 34);
            this.button_Reset.TabIndex = 9;
            this.button_Reset.Text = "변경취소";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // button_RemoveString
            // 
            this.button_RemoveString.Enabled = false;
            this.button_RemoveString.Location = new System.Drawing.Point(0, 345);
            this.button_RemoveString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_RemoveString.Name = "button_RemoveString";
            this.button_RemoveString.Size = new System.Drawing.Size(107, 34);
            this.button_RemoveString.TabIndex = 10;
            this.button_RemoveString.Text = "문자열삭제";
            this.button_RemoveString.UseVisualStyleBackColor = true;
            this.button_RemoveString.Click += new System.EventHandler(this.Button_RemoveString_Click);
            // 
            // button_RemoveName
            // 
            this.button_RemoveName.Enabled = false;
            this.button_RemoveName.Location = new System.Drawing.Point(0, 258);
            this.button_RemoveName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_RemoveName.Name = "button_RemoveName";
            this.button_RemoveName.Size = new System.Drawing.Size(107, 34);
            this.button_RemoveName.TabIndex = 11;
            this.button_RemoveName.Text = "이름지우기";
            this.button_RemoveName.UseVisualStyleBackColor = true;
            this.button_RemoveName.Click += new System.EventHandler(this.Button_RemoveName_Click);
            // 
            // button_Number
            // 
            this.button_Number.Enabled = false;
            this.button_Number.Location = new System.Drawing.Point(0, 388);
            this.button_Number.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Number.Name = "button_Number";
            this.button_Number.Size = new System.Drawing.Size(107, 34);
            this.button_Number.TabIndex = 12;
            this.button_Number.Text = "번호붙이기";
            this.button_Number.UseVisualStyleBackColor = true;
            this.button_Number.Click += new System.EventHandler(this.Button_Number_Click);
            // 
            // button_Replace
            // 
            this.button_Replace.Enabled = false;
            this.button_Replace.Location = new System.Drawing.Point(0, 432);
            this.button_Replace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Replace.Name = "button_Replace";
            this.button_Replace.Size = new System.Drawing.Size(107, 34);
            this.button_Replace.TabIndex = 13;
            this.button_Replace.Text = "찾아바꾸기";
            this.button_Replace.UseVisualStyleBackColor = true;
            this.button_Replace.Click += new System.EventHandler(this.Button_Replace_Click);
            // 
            // button_MoveFolder
            // 
            this.button_MoveFolder.Enabled = false;
            this.button_MoveFolder.Location = new System.Drawing.Point(0, 476);
            this.button_MoveFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_MoveFolder.Name = "button_MoveFolder";
            this.button_MoveFolder.Size = new System.Drawing.Size(107, 34);
            this.button_MoveFolder.TabIndex = 14;
            this.button_MoveFolder.Text = "폴더이동";
            this.button_MoveFolder.UseVisualStyleBackColor = true;
            this.button_MoveFolder.Click += new System.EventHandler(this.Button_MoveFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Down);
            this.groupBox1.Controls.Add(this.button_Up);
            this.groupBox1.Location = new System.Drawing.Point(0, 566);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(107, 118);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "파일 순서";
            // 
            // button_Extension
            // 
            this.button_Extension.Enabled = false;
            this.button_Extension.Location = new System.Drawing.Point(0, 519);
            this.button_Extension.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Extension.Name = "button_Extension";
            this.button_Extension.Size = new System.Drawing.Size(107, 34);
            this.button_Extension.TabIndex = 16;
            this.button_Extension.Text = "확장자관리";
            this.button_Extension.UseVisualStyleBackColor = true;
            this.button_Extension.Click += new System.EventHandler(this.Button_Extension_Click);
            // 
            // Form_Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 702);
            this.Controls.Add(this.button_Extension);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_MoveFolder);
            this.Controls.Add(this.button_Replace);
            this.Controls.Add(this.button_Number);
            this.Controls.Add(this.button_RemoveName);
            this.Controls.Add(this.button_RemoveString);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_AddString);
            this.Controls.Add(this.button_RemoveSelect);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_RemoveAll);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Main";
            this.Text = "Fylon";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_RemoveAll;
        private System.Windows.Forms.ColumnHeader columnHeader_BeforeName;
        private System.Windows.Forms.ColumnHeader columnHeader_AfterName;
        private System.Windows.Forms.ColumnHeader columnHeader_Path;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button_RemoveSelect;
        private System.Windows.Forms.Button button_AddString;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_Up;
        private System.Windows.Forms.Button button_Down;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_RemoveString;
        private System.Windows.Forms.Button button_RemoveName;
        private System.Windows.Forms.Button button_Number;
        private System.Windows.Forms.Button button_Replace;
        private System.Windows.Forms.Button button_MoveFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader_CreatedDate;
        private System.Windows.Forms.ColumnHeader columnHeader_ModifiedDate;
        private System.Windows.Forms.Button button_Extension;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 버전ToolStripMenuItem;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fylon
{
    public partial class Form_Rename : Form
    {
        Form_Main Fm;
        public Form_Rename()
        {
            InitializeComponent();
        }
        private void keyPress(Object o, KeyPressEventArgs e)//텍스트 박스에 이름 금지문자 입력안받는 함수
        {
            if (e.KeyChar == '\\' || e.KeyChar == '/' || e.KeyChar == ':' || e.KeyChar == '*' || e.KeyChar == '?' || e.KeyChar == '"'
                || e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '|')
            {
                e.Handled = true;
            }
        }
        public Form_Rename(Form_Main _form)//Form_Main 접근 허용
        {
            InitializeComponent();
            Fm = _form;

            bool b;

            if (Fm.listView1.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = Fm.listView1.SelectedItems;
                ListViewItem lvi = items[0];
                string name = lvi.SubItems[1].Text;
                string name_change, extension;
                if (Fm.FileExistsCheck(lvi.SubItems[2].Text) == true)//파일 체크
                {
                    b = name.Contains(".");//확장자 체크
                    if(b == true)
                    {
                        name_change = (name.Substring(0, name.LastIndexOf(".")));//파일이름
                        extension = (name.Substring(name.LastIndexOf(".")));//확장자
                    }
                    else
                    {
                        name_change = name;
                        extension = "";
                    }
                }
                else if (Fm.FolderExistsCheck(lvi.SubItems[2].Text) == true)//폴더 체크
                {
                    b = false;
                    name_change = name;
                    extension = "";
                }
                else
                {
                    b = false;
                    name_change = name;
                    extension = "";
                }

                label_Name.Text = name + "→";//원래 이름 표시
                label_extension.Text = extension;//확장자 표시

                textBox1.Text = name_change;
            }
        }

        private void button_Yes_Click(object sender, EventArgs e)//확인 버튼
        {
            ListView.SelectedListViewItemCollection items = Fm.listView1.SelectedItems;
            ListViewItem lvi = items[0];
            string name, extension;
            bool b;

            name = lvi.SubItems[1].Text;

            if (Fm.FileExistsCheck(lvi.SubItems[2].Text) == true)//파일 체크
            {
                b = name.Contains(".");//확장자 체크
                if(b == true)
                {
                    extension = (name.Substring(name.LastIndexOf(".")));
                }
                else
                {
                    extension = "";
                }
            }
            else if (Fm.FolderExistsCheck(lvi.SubItems[2].Text) == true)//폴더 체크
            {
                b = false;
                extension = "";
            }
            else
            {
                b = false;
                extension = "";
            }

            lvi.SubItems[1].Text = textBox1.Text + extension;//이름 변경

            this.Close();
        }
        private void button_No_Click_1(object sender, EventArgs e)//취소 버튼
        {
            this.Close();
        }
    }
}

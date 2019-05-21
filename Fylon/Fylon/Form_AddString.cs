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
    public partial class Form_AddString : Form
    {
        Form_Main Fm;
        public Form_AddString()
        {
            InitializeComponent();
        }
        public Form_AddString(Form_Main _form)//Form_Main 접근 허용
        {
            InitializeComponent();
            Fm = _form;
        }

        private void keyPress(Object o, KeyPressEventArgs e)//텍스트 박스에 이름 금지문자 입력안받는 함수
        {
            if (e.KeyChar == '\\' || e.KeyChar == '/' || e.KeyChar == ':' || e.KeyChar == '*' || e.KeyChar == '?' || e.KeyChar == '"'
                || e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '|')
            {
                e.Handled = true;
            }
        }

        private void button_Yes_Click(object sender, EventArgs e)//확인버튼
        {
            addString();
            this.Close();
        }

        private void button_No_Click(object sender, EventArgs e)//취소버튼
        {
            this.Close();
        }

        public void addString()//문자열 추가작업
        {
            string name, head, tail;
            string addName = textBox1.Text;//추가할 문자
            bool b;
            int count = radioButton_WholeList.Checked ? Fm.listView1.Items.Count : Fm.listView1.SelectedItems.Count;

            if (radioButton_AddString_Left.Checked)//문자열 앞에 추가
            {
                for (int i = 0; i < count; i++)
                {
                    ListViewItem item = radioButton_WholeList.Checked ? Fm.listView1.Items[i] : Fm.listView1.SelectedItems[i];
                    name = item.SubItems[1].Text;
                    name = addName + name;
                    item.SubItems[1].Text = name;//변경한 이름 적용
                }
            }
            else if (radioButton_AddString_Right.Checked)//문자열 뒤에 추가
            {
                for (int i = 0; i < count; i++)
                {
                    ListViewItem item = radioButton_WholeList.Checked ? Fm.listView1.Items[i] : Fm.listView1.SelectedItems[i];
                    name = item.SubItems[1].Text;
                    if (Fm.FileExistsCheck(item.SubItems[2].Text) == true)//파일일 경우
                    {
                        b = name.Contains(".");
                        if (b == true)//확장자 체크
                        {
                            head = (name.Substring(0, name.LastIndexOf(".")));//확장자 앞
                            tail = (name.Substring(name.LastIndexOf(".")));//확장자
                            name = head + addName + tail;
                        }
                        else
                        {
                            name = name + addName;
                        }
                    }
                    else if (Fm.FolderExistsCheck(item.SubItems[2].Text) == true)//폴더일 경우
                    {
                        name = name + addName;
                    }
                    else
                    {
                        name = name + addName;
                    }
                    item.SubItems[1].Text = name;//변경한 이름 적용
                }
            }

            else
            {
                MessageBox.Show("문자열을 추가할 위치를 선택해 주세요.");
            }
        }
    }
}

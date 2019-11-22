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
    public partial class Form_Extension : Form
    {
        Form_Main Fm;
        public Form_Extension()
        {
            InitializeComponent();
        }
        public Form_Extension(Form_Main _form)//Form_Main 접근 허용
        {
            InitializeComponent();
            Fm = _form;
        }

        bool English_Check(char ch)//영어 체크 함수
        {
            if ((0x61 <= ch && ch <= 0x7A) || (0x41 <= ch && ch <= 0x5A))
                return true;
            else
                return false;
        }
        bool Number_Check(char ch)//숫자 체크 함수
        {
            if (0x30 <= ch && ch <= 0x39)
                return true;
            else
                return false;
        }

        private void keyPress(Object o, KeyPressEventArgs e)//텍스트 박스에 이름 금지문자 입력안받는 함수
        {
            if (e.KeyChar == '\\' || e.KeyChar == '/' || e.KeyChar == ':' || e.KeyChar == '*' || e.KeyChar == '?' || e.KeyChar == '"'
                || e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '|' || e.KeyChar == '.')//확장자 변동을 막기위해 "."입력하지 못하게 함
            {
                e.Handled = true;
            }
        }
        //메뉴활성화
        private void radioButton_ExtensionAdd_CheckedChanged(object sender, EventArgs e)//확장자 추가 체크되있을 경우
        {
            if (radioButton_ExtensionAdd.Checked)
            {
                textBox_ExtensionAdd.ReadOnly = false;
            }
            else
            {
                textBox_ExtensionAdd.ReadOnly = true;
            }
        }
        private void radioButton_ExtensionReplace_CheckedChanged(object sender, EventArgs e)//확장자 변경 체크되있을 경우
        {
            if (radioButton_ExtensionReplace.Checked)
            {
                textBox_ExtensionReplace.ReadOnly = false;
            }
            else
            {
                textBox_ExtensionReplace.ReadOnly = true;
            }
        }

        private void button_Yes_Click(object sender, EventArgs e)//확인
        {
            Extension();
            this.Close();
        }

        private void button_No_Click(object sender, EventArgs e)//취소
        {
            this.Close();
        }

        public void Extension()
        {
            string name, addExtension;
            int count = radioButton_WholeList.Checked ? Fm.listView1.Items.Count : Fm.listView1.SelectedItems.Count;
            bool b;

            if (radioButton_ExtensionAdd.Checked)//확장자 추가
            {
                if (textBox_ExtensionAdd.Text.Length < 1)//추가할 확장자를 입력하지 않았을 경우
                {
                    MessageBox.Show("추가할 확장자를 입력해주세요.");
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        ListViewItem item = radioButton_WholeList.Checked ? Fm.listView1.Items[i] : Fm.listView1.SelectedItems[i];

                        if (Fm.FileExistsCheck(item.SubItems[2].Text) == true)//파일일 경우에만 적용
                        {
                            name = item.SubItems[1].Text;//원래 파일
                            addExtension = textBox_ExtensionAdd.Text;//추가할 확장자
                            name = name + "." + addExtension;
                            item.SubItems[1].Text = name;
                        }
                    }
                }
            }
            else if (radioButton_ExtensionReplace.Checked)//확장자 변경
            {
                if (textBox_ExtensionReplace.Text.Length < 1)//입력하지 않았을 경우
                {
                    MessageBox.Show("변경할 확장자를 입력해주세요.");
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        ListViewItem item = radioButton_WholeList.Checked ? Fm.listView1.Items[i] : Fm.listView1.SelectedItems[i];

                        if (Fm.FileExistsCheck(item.SubItems[2].Text) == true)//파일일 경우에만 적용
                        {
                            name = item.SubItems[1].Text;
                            b = name.Contains(".");
                            if (b == true)
                            {
                                name = (name.Substring(0, name.LastIndexOf(".")));//파일명만 떼어냄
                                addExtension = textBox_ExtensionReplace.Text;
                                name = name + "." + addExtension;//입력한 확장자 붙임
                                item.SubItems[1].Text = name;
                            }
                        }
                    }
                }
            }
            else if (radioButton_ExtensionRemove.Checked)//확장자 삭제
            {
                for (int i = 0; i < count; i++)
                {
                    ListViewItem item = radioButton_WholeList.Checked ? Fm.listView1.Items[i] : Fm.listView1.SelectedItems[i];

                    if (Fm.FileExistsCheck(item.SubItems[2].Text) == true)//파일일 경우에만 적용
                    {
                        name = item.SubItems[1].Text;
                        b = name.Contains(".");//확장자 체크
                        if (b == true)
                        {
                            name = (name.Substring(0, name.LastIndexOf(".")));
                            item.SubItems[1].Text = name;
                        }
                    }
                }
            }
            else if (radioButton_LeftEnglishAndNumbers.Checked)//영어와 숫자만 남기기
            {
                for (int i = 0; i < count; i++)
                {
                    ListViewItem item = radioButton_WholeList.Checked ? Fm.listView1.Items[i] : Fm.listView1.SelectedItems[i];

                    if (Fm.FileExistsCheck(item.SubItems[2].Text) == true)//파일일 경우에만 적용
                    {
                        name = item.SubItems[1].Text;
                        b = name.Contains(".");//확장자 체크
                        char[] check_char;
                        String head, tail;
                        if (b == true)
                        {
                            addExtension = (name.Substring(name.LastIndexOf(".")));//확장자 분리
                            name = (name.Substring(0, name.LastIndexOf(".")));//파일명만 떼어냄
                            check_char = addExtension.ToCharArray();//char형식으로 변환하여 유니코드 체크가 가능하도록 함

                            for (int j = addExtension.Length - 1; j >=0; j--)
                            {
                                if (English_Check(check_char[j]) == false && Number_Check(check_char[j]) == false)//영어체크, 숫자체크 둘다 false일 경우 삭제
                                {
                                    if (addExtension.Length - 1 > j)
                                    {
                                        head = (addExtension.Substring(0, j));
                                        tail = (addExtension.Substring(j + 1));
                                        addExtension = head + tail;
                                    }
                                    else if (addExtension.Length - 1 == j)
                                    {
                                        addExtension = (addExtension.Substring(0, j));
                                    }
                                    else
                                    {
                                        MessageBox.Show("error");
                                    }
                                }
                            }
                            name = name + "." + addExtension;//입력한 확장자 붙임
                            item.SubItems[1].Text = name;
                        }
                    }
                }
            }
        }
    }
}

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
    public partial class Form_Number : Form
    {
        Form_Main Fm;
        public Form_Number()
        {
            InitializeComponent();
        }
        public Form_Number(Form_Main _form)//Form_Main 접근 허용
        {
            InitializeComponent();
            Fm = _form;
        }

        private void keyPressed(Object o, KeyPressEventArgs e)//텍스트 박스에 숫자만 입력받는 함수
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void keyPress(Object o, KeyPressEventArgs e)//텍스트 박스에 이름 금지문자 입력안받는 함수
        {
            if (e.KeyChar == '\\' || e.KeyChar == '/' || e.KeyChar == ':' || e.KeyChar == '*' || e.KeyChar == '?' || e.KeyChar == '"'
                || e.KeyChar == '<' || e.KeyChar == '>' || e.KeyChar == '|')
            {
                e.Handled = true;
            }
        }

        private void button_Yes_Click(object sender, EventArgs e)//확인
        {
            renaming();
            this.Close();
        }

        private void button_No_Click(object sender, EventArgs e)//취소
        {
            this.Close();
        }

        private void renaming()
        {
            string name, number, digit, between;
            int i_number, i_digit;
            bool b;

            if (textBox_Digit.Text.Length < 1)//빈칸일시 1로 지정
            {
                textBox_Digit.Text = "1";
            }
            if (textBox_StartNumber.Text.Length < 1)//빈칸일시 1로 지정
            {
                textBox_StartNumber.Text = "1";
            }
            if (textBox_Between.Text.Length < 1)//빈칸일시 공백으로 지정
            {
                textBox_Between.Text = "";
            }

            digit = textBox_Digit.Text;//자리수
            number = textBox_StartNumber.Text;//시작숫자
            between = textBox_Between.Text;//사이 추가 문자
            i_number = int.Parse(number);
            i_digit = int.Parse(digit);

            if (radioButton_WholeList.Checked)//전체 목록 적용
            {
                if (radioButton_Before.Checked)//앞에 추가
                {
                    for (int i = 0; i < Fm.listView1.Items.Count; i++)
                    {
                        int rising_num;//숫자 증가
                        string add_digit;//자리수 추가한 숫자
                        ListViewItem item = Fm.listView1.Items[i];
                        name = item.SubItems[1].Text;
                        rising_num = i + i_number;
                        add_digit = rising_num.ToString();
                        string digit_num = Convert.ToString(rising_num);

                        if (i_digit - digit_num.Length > 0)
                        {
                            for (int j = i_digit - digit_num.Length; j > 0; j--)//자리수 만큼 앞에 0을 추가
                            {
                                add_digit = "0" + add_digit;
                            }
                        }

                        name = add_digit + between + name;
                        item.SubItems[1].Text = name;
                    }
                }
                else if (radioButton_After.Checked)//뒤에 추가
                {
                    for (int i = 0; i < Fm.listView1.Items.Count; i++)
                    {
                        int rising_num;//숫자 증가
                        string add_digit, head, tail;
                        ListViewItem item = Fm.listView1.Items[i];
                        name = item.SubItems[1].Text;
                        rising_num = i + i_number;
                        add_digit = rising_num.ToString();
                        string digit_num = Convert.ToString(rising_num);

                        if (i_digit - digit_num.Length > 0)//자리수 만큼 앞에 0을 추가
                        {
                            for (int j = i_digit - digit_num.Length; j > 0; j--)
                            {
                                add_digit = "0" + add_digit;
                            }
                        }
                        if (Fm.FileExistsCheck(item.SubItems[2].Text) == true)//파일일 경우 확장자 제거하고 진행
                        {
                            b = name.Contains(".");

                            if (b == true)
                            {
                                head = (name.Substring(0, name.LastIndexOf(".")));
                                tail = (name.Substring(name.LastIndexOf(".")));
                                name = head + between + add_digit + tail;
                            }
                            else
                            {
                                name = name + between + add_digit;
                            }
                        }
                        else if (Fm.FolderExistsCheck(item.SubItems[2].Text) == true)//폴더일 경우 그냥진행
                        {
                            b = false;
                            name = name + between + add_digit;
                        }
                        else
                        {
                            b = false;
                            name = name + between + add_digit;
                        }

                        item.SubItems[1].Text = name;
                    }
                }
                else
                {
                    MessageBox.Show("번호를 붙일 위치를 선택해주세요.");
                }
            }
            else if (radioButton_SelectedList.Checked)//선택된 것만 적용
            {
                if (radioButton_Before.Checked)//앞에 추가
                {
                    for (int i = 0; i < Fm.listView1.SelectedItems.Count; i++)
                    {
                        int rising_num;//중가 숫자
                        string add_digit;//자릿수 추가된 숫자
                        ListViewItem lvi = Fm.listView1.SelectedItems[i];
                        name = lvi.SubItems[1].Text;
                        rising_num = i + i_number;
                        add_digit = rising_num.ToString();
                        string digit_num = Convert.ToString(rising_num);

                        if (i_digit - digit_num.Length > 0)
                        {
                            for (int j = i_digit - digit_num.Length; j > 0; j--)//자릿수 만큼 0을 앞에 추가
                            {
                                add_digit = "0" + add_digit;
                            }
                        }

                        name = add_digit + between + name;
                        lvi.SubItems[1].Text = name;
                    }
                }
                else if (radioButton_After.Checked)//뒤에 추가
                {
                    for (int i = 0; i < Fm.listView1.SelectedItems.Count; i++)
                    {
                        int rising_num;//증가 숫자
                        string add_digit, head, tail;
                        ListViewItem lvi = Fm.listView1.SelectedItems[i];
                        name = lvi.SubItems[1].Text;
                        rising_num = i + i_number;
                        add_digit = rising_num.ToString();

                        if (i_digit - number.Length > 0)
                        {
                            for (int j = i_digit - number.Length; j > 0; j--)//자릿수 만큼 앞에 0을 추가
                            {
                                add_digit = "0" + add_digit;
                            }
                        }
                        if (Fm.FileExistsCheck(lvi.SubItems[2].Text) == true)//파일일 경우 확장자 제거하고 추가
                        {
                            b = name.Contains(".");

                            if (b == true)
                            {
                                head = (name.Substring(0, name.LastIndexOf(".")));
                                tail = (name.Substring(name.LastIndexOf(".")));
                                name = head + between + add_digit + tail;
                            }
                            else
                            {
                                name = name + between + add_digit;
                            }
                        }
                        else if (Fm.FolderExistsCheck(lvi.SubItems[2].Text) == true)//폴더일 경우 그냥 진행
                        {
                            b = false;
                            name = name + between + add_digit;
                        }
                        else
                        {
                            b = false;
                            name = name + between + add_digit;
                        }

                        lvi.SubItems[1].Text = name;
                    }
                }
                else
                {
                    MessageBox.Show("번호를 붙일 위치를 선택해주세요.");
                }
            }
            
        }
    }
}

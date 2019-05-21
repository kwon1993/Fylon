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
    public partial class Form_RemoveString : Form
    {
        Form_Main Fm;
        public Form_RemoveString()
        {
            InitializeComponent();
        }
        public Form_RemoveString(Form_Main _form)//Form_Main 접근 허용
        {
            InitializeComponent();
            Fm = _form;
        }

        private void keyPressed(Object o, KeyPressEventArgs e)//텍스트 박스에 숫자만 입력받는 함수
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
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

        bool Korean_Check(char ch)//한글 체크 함수
        {
            //( 한글자 || 호환용 자음 , 모음 || 자음, 모음)
            if ((0xAC00 <= ch && ch <= 0xD7A3) || (0x3131 <= ch && ch <= 0x318E) || (0x1100 <= ch && ch <= 0x11FF))
                return true;
            else
                return false;
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
        bool Space_Check(char ch)//스페이스바 체크 함수
        {
            if (0x20 == ch || 0xA0 == ch || 0x2002 <= ch && ch <= 0x200B || ch == 0x3000 || ch == 0xFEFF || ch == 0x9)
                return true;
            else
                return false;
        }

        //메뉴 활성화 제어
        private void radioButton_Location_CheckedChanged(object sender, EventArgs e)//위치 지우기 체크되있을 경우
        {
            if (radioButton_Location.Checked)
            {
                textBox_LocationStart.ReadOnly = false;
                textBox_LocationEnd.ReadOnly = false;
            }
            else
            {
                textBox_LocationStart.ReadOnly = true;
                textBox_LocationEnd.ReadOnly = true;
            }
        }

        private void radioButton_Bind_CheckedChanged(object sender, EventArgs e)//묶인곳 지우기 체크되있을 경우
        {
            if (radioButton_Bind.Checked)
            {
                textBox_BindStart.ReadOnly = false;
                textBox_BindEnd.ReadOnly = false;
            }
            else
            {
                textBox_BindStart.ReadOnly = true;
                textBox_BindEnd.ReadOnly = true;
            }
        }

        private void radioButton_Type_CheckedChanged(object sender, EventArgs e)//특정 문자형식 체크되있을 경우
        {
            if (radioButton_Type.Checked)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
        }

        private void radioButton_Typing_CheckedChanged(object sender, EventArgs e)//입력한 문구 체크되있을 경우
        {
            if (radioButton_Typing.Checked)
            {
                textBox_Typing.ReadOnly = false;
            }
            else
            {
                textBox_Typing.ReadOnly = true;
            }
        }

        private void button_Yes_Click(object sender, EventArgs e)//확인버튼
        {
            removeString();
            this.Close();
            Fm.width_Resize();//너비 재조정
        }

        private void button_No_Click(object sender, EventArgs e)//취소버튼
        {
            this.Close();
        }

        private void button_Run_Click(object sender, EventArgs e)//적용버튼
        {
            removeString();
            Fm.width_Resize();//너비 재조정
        }

        public void removeString()//메인 작업
        {
            if (radioButton_WholeList.Checked)//전체 목록 적용
            {
                if (radioButton_Location.Checked)//위치지우기
                {
                    if (textBox_LocationStart.Text.Length < 1 || textBox_LocationEnd.Text.Length < 1)//입력하지 않았을 경우
                    {
                        MessageBox.Show("시작 위치와 끝 위치를 입력해주세요.");
                    }
                    else
                    {
                        string name, length_check, head, tail;
                        int start = 0, end = 0;
                        bool b;
                        int fail_Count = 0;
                        int fail_Number;
                        string fail_List = "";


                        start = int.Parse(textBox_LocationStart.Text);
                        end = int.Parse(textBox_LocationEnd.Text);
                        if (start < 1)//시작이 1보다 작으면 1로 취급
                        {
                            start = 1;
                        }
                        start = start - 1;

                        if (start <= end)//시작위치보다 끝 위치보다 앞이거나 같을때
                        {
                            for (int i = 0; i < Fm.listView1.Items.Count; i++)
                            {
                                ListViewItem item = Fm.listView1.Items[i];
                                name = item.SubItems[1].Text;
                                if (Fm.FileExistsCheck(item.SubItems[2].Text) == true)//파일 체크
                                {
                                    b = name.Contains(".");//확장자 체크하여 확장제 제외하고 진행
                                    if (b == true)
                                    {
                                        length_check = (name.Substring(0, name.LastIndexOf(".")));
                                    }
                                    else
                                    {
                                        length_check = name;
                                    }
                                }
                                else if (Fm.FolderExistsCheck(item.SubItems[2].Text) == true)//폴더일 경우 그냥진행
                                {
                                    length_check = name;
                                }
                                else
                                {
                                    length_check = name;
                                }

                                if (length_check.Length < start)//
                                {
                                    fail_Count++;
                                    fail_Number = i + 1;
                                    if (fail_Count > 1)
                                    {
                                        fail_List = fail_List + ", " + fail_Number.ToString();
                                    }
                                    else if (fail_Count == 1)
                                    {
                                        fail_List = fail_Number.ToString();
                                    }
                                    else//나올수 없는 오류
                                    {
                                        MessageBox.Show("error");
                                    }
                                }
                                else
                                {
                                    if (end > length_check.Length)//끝 위치가 파일 길이를 넘어서는경우 파일 길이까지만 진행
                                    {
                                        head = (name.Substring(0, start));
                                        tail = (name.Substring(length_check.Length));
                                        name = head + tail;
                                    }
                                    else
                                    {
                                        head = (name.Substring(0, start));
                                        tail = (name.Substring(end));
                                        name = head + tail;
                                    }
                                }
                                item.SubItems[1].Text = name;
                            }
                            if (fail_Count > 0)//실패한 작업 알림
                            {
                                MessageBox.Show(fail_Count + "개의 항목이 시작위치보다 이름길이가 짧습니다\n"
                                    + fail_List + "번째 항목이 변경되지 않았습니다.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("시작 위치가 끝나는 위치보다 뒤에 있습니다.");
                        }
                    }
                }

                if (radioButton_Bind.Checked)//묶인곳 지우기
                {
                    if (textBox_BindStart.Text.Length < 1 || textBox_BindEnd.Text.Length < 1)//입력하지 않았을 경우
                    {
                        MessageBox.Show("문자열 범위를 입력해 주세요.");
                    }
                    else
                    {
                        string start = textBox_BindStart.Text;
                        string end = textBox_BindEnd.Text;
                        string name, head, tail, name_noex;
                        bool b, b_1, b_2;
                        int fail_Count = 0;
                        int fail_Number;
                        string fail_List = "";

                        for (int i = 0; i < Fm.listView1.Items.Count; i++)
                        {
                            ListViewItem item = Fm.listView1.Items[i];
                            name = item.SubItems[1].Text;

                            if (Fm.FileExistsCheck(item.SubItems[2].Text) == true)//파일 체크
                            {
                                b = name.Contains(".");//확장자 체크하여 확장자 제외하고 진행

                                if (b == true)
                                {
                                    name_noex = (name.Substring(0, name.LastIndexOf(".")));
                                }
                                else
                                {
                                    name_noex = name;
                                }
                            }
                            else if (Fm.FolderExistsCheck(item.SubItems[2].Text) == true)//폴더일 경우 그냥 진행
                            {
                                b = false;
                                name_noex = name;
                            }
                            else
                            {
                                b = false;
                                name_noex = name;
                            }

                            b_1 = name_noex.Contains(start);
                            b_2 = name_noex.Contains(end);

                            if (b_1 == false || b_2 == false)//시작, 끝에 입력한 문자가 없을경우 오류처리
                            {
                                fail_Count++;
                                fail_Number = i + 1;
                                if (fail_Count > 1)
                                {
                                    fail_List = fail_List + ", " + fail_Number.ToString();
                                }
                                else if (fail_Count == 1)
                                {
                                    fail_List = fail_Number.ToString();
                                }
                                else//나올수 없는 오류
                                {
                                    MessageBox.Show("error");
                                }
                            }
                            else//문제없을경우 정상진행
                            {
                                head = (name_noex.Substring(0, name.IndexOf(start)));
                                tail = (name_noex.Substring(name.LastIndexOf(end) + 1));
                                name_noex = head + tail;
                            }

                            if (b == true)//확장자 다시 붙이기
                            {
                                name = name_noex + (name.Substring(name.LastIndexOf(".")));
                            }
                            else
                            {
                                name = name_noex;
                            }

                            item.SubItems[1].Text = name;
                        }
                        if (fail_Count > 0)//실패한 작업 알림
                        {
                            MessageBox.Show(fail_Count + "개의 항목에 입력한 문자열이 존재하지 않았습니다.\n"
                                + fail_List + "번째 항목이 변경되지 않았습니다.");
                        }
                    }
                }
                if (radioButton_Type.Checked)//타입별 지우기
                {
                    string name, name_head, name_tail; ;
                    bool b;

                    for (int i = 0; i < Fm.listView1.Items.Count; i++)
                    {
                        ListViewItem item = Fm.listView1.Items[i];
                        name = item.SubItems[1].Text;
                        char[] check_char;
                        if (Fm.FileExistsCheck(item.SubItems[2].Text) == true)//파일 체크
                        {
                            b = name.Contains(".");//확장자 체크하여 제외하고 진행
                            if (b == true)
                            {
                                name_head = (name.Substring(0, name.LastIndexOf(".")));
                                name_tail = (name.Substring(name.LastIndexOf(".")));
                            }
                            else
                            {
                                name_head = name;
                                name_tail = "";
                            }
                        }
                        else if (Fm.FolderExistsCheck(item.SubItems[2].Text) == true)//폴더 체크
                        {
                            name_head = name;
                            name_tail = "";
                        }
                        else
                        {
                            name_head = name;
                            name_tail = "";
                        }
                        check_char = name_head.ToCharArray();//char형식으로 변환하여 유니코드 체크가 가능하도록 함

                        if (radioButton_TypeRemove.Checked)//타입별 지우기
                        {
                            string head, tail;

                            if (radioButton_Korean.Checked)//한국어 체크하여 맞으면 삭제
                            {

                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Korean_Check(check_char[j]) == true)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_English.Checked)//영어 체크하여 맞으면 삭제
                            {
                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (English_Check(check_char[j]) == true)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_Number.Checked)//숫자 체크하여 맞으면 삭제
                            {
                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Number_Check(check_char[j]) == true)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_Space.Checked)//스페이스바 체크하여 맞으면 삭제
                            {
                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Space_Check(check_char[j]) == true)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_Combined.Checked)//종합 체크하여 맞으면 삭제
                            {
                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Korean_Check(check_char[j]) == true || English_Check(check_char[j]) == true
                                        || Number_Check(check_char[j]) == true || Space_Check(check_char[j]) == true)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            name = name_head + name_tail;
                            item.SubItems[1].Text = name;
                        }

                        else if (radioButton_TypeLeave.Checked)//선택한 타입 남기기
                        {
                            string head, tail;

                            if (radioButton_Korean.Checked)//한국어 체크하여 아니면 삭제
                            {

                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Korean_Check(check_char[j]) == false)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_English.Checked)//영어 체크하여 아니면 삭제
                            {
                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (English_Check(check_char[j]) == false)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_Number.Checked)//숫자 체크하여 아니면 삭제
                            {
                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Number_Check(check_char[j]) == false)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_Space.Checked)//스페이스바 체크하여 아니면 삭제
                            {
                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Space_Check(check_char[j]) == false)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_Combined.Checked)//종합 체크하여 아니면 삭제
                            {

                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Korean_Check(check_char[j]) == false && English_Check(check_char[j]) == false
                                        && Number_Check(check_char[j]) == false && Space_Check(check_char[j]) == false)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }


                            name = name_head + name_tail;
                            item.SubItems[1].Text = name;
                        }

                        else
                        {
                            MessageBox.Show("체크한 문자를 남길지 지울지 선택해주세요.");
                        }
                    }
                }
                if (radioButton_Typing.Checked)//입력하여 삭제
                {
                    if (textBox_Typing.Text.Length < 1)
                    {
                        MessageBox.Show("문자열을 입력해 주세요.");
                    }
                    else
                    {
                        string remove_String;
                        string name, head, tail;
                        string name_noex;
                        int fail_Count = 0;
                        int fail_Number;
                        string fail_List = "";
                        bool b, b_2;
                        int bool_int;
                        remove_String = textBox_Typing.Text;

                        for (int i = 0; i < Fm.listView1.Items.Count; i++)
                        {
                            ListViewItem item = Fm.listView1.Items[i];
                            name = item.SubItems[1].Text;

                            if (Fm.FileExistsCheck(item.SubItems[2].Text) == true)//파일 체크
                            {
                                b = name.Contains(".");//확장자 체크
                                if (b == true)
                                {
                                    name_noex = (name.Substring(0, name.LastIndexOf(".")));
                                }
                                else
                                {
                                    name_noex = name;
                                }
                            }
                            else if (Fm.FolderExistsCheck(item.SubItems[2].Text) == true)//폴더 체크
                            {
                                b = false;
                                name_noex = name;
                            }
                            else
                            {
                                b = false;
                                name_noex = name;
                            }

                            b_2 = name_noex.Contains(remove_String);

                            if (b_2 == false)//삭제할 문구가 없으면 에러체크
                            {
                                fail_Count++;
                                fail_Number = i + 1;
                                if (fail_Count > 1)
                                {
                                    fail_List = fail_List + ", " + fail_Number.ToString();
                                }
                                else if (fail_Count == 1)
                                {
                                    fail_List = fail_Number.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("error");
                                }
                            }
                            else//정상 진행
                            {
                                bool_int = 1;
                                for (; bool_int == 1;)
                                {
                                    head = (name_noex.Substring(0, name_noex.IndexOf(remove_String)));
                                    tail = (name_noex.Substring(name_noex.IndexOf(remove_String) + textBox_Typing.Text.Length));
                                    name_noex = head + tail;

                                    b_2 = name_noex.Contains(remove_String);
                                    if (b_2 == true)
                                        bool_int = 1;
                                    else
                                        bool_int = 0;
                                }
                            }

                            if (b == true)
                            {
                                name = name_noex + (name.Substring(name.LastIndexOf(".")));
                            }
                            else
                            {
                                name = name_noex;
                            }

                            item.SubItems[1].Text = name;
                        }


                        if (fail_Count > 0)//에러항목 알림
                        {
                            MessageBox.Show(fail_Count + "개의 항목에 입력한 문자열이 존재하지 않았습니다.\n"
                                + fail_List + "번째 항목이 변경되지 않았습니다.");
                        }
                    }

                }
            }
            //아래 코드 선택목록 처리 이외 위와 같음
            else if (radioButton_SelectedList.Checked)//선택된 목록
            {
                if (radioButton_Location.Checked)//위치지우기
                {
                    if (textBox_LocationStart.Text.Length < 1 || textBox_LocationEnd.Text.Length < 1)
                    {
                        MessageBox.Show("시작 위치와 끝 위치를 입력해주세요.");
                    }
                    else
                    {
                        string name, length_check, head, tail;
                        int start = 0, end = 0;
                        bool b;

                        start = int.Parse(textBox_LocationStart.Text);
                        end = int.Parse(textBox_LocationEnd.Text);
                        if (start < 1)
                        {
                            start = 1;
                        }
                        start = start - 1;

                        if (start <= end)
                        {
                            for (int i = 0; i < Fm.listView1.SelectedItems.Count; i++)
                            {
                                ListViewItem lvi = Fm.listView1.SelectedItems[i];
                                name = lvi.SubItems[1].Text;
                                if (Fm.FileExistsCheck(lvi.SubItems[2].Text) == true)
                                {
                                    b = name.Contains(".");
                                    if (b == true)
                                    {
                                        length_check = (name.Substring(0, name.LastIndexOf(".")));
                                    }
                                    else
                                    {
                                        length_check = name;
                                    }
                                }
                                else if (Fm.FolderExistsCheck(lvi.SubItems[2].Text) == true)
                                {
                                    length_check = name;
                                }
                                else
                                {
                                    length_check = name;
                                }

                                if (end > length_check.Length)
                                {
                                    head = (name.Substring(0, start));
                                    tail = (name.Substring(length_check.Length));
                                    name = head + tail;
                                }
                                else
                                {
                                    head = (name.Substring(0, start));
                                    tail = (name.Substring(end));
                                    name = head + tail;
                                }
                                lvi.SubItems[1].Text = name;
                            }
                        }
                        else
                        {
                            MessageBox.Show("시작 위치가 끝나는 위치보다 뒤에 있습니다.");
                        }
                    }
                }

                if (radioButton_Bind.Checked)//묶인곳 지우기
                {
                    if (textBox_BindStart.Text.Length < 1 || textBox_BindEnd.Text.Length < 1)
                    {
                        MessageBox.Show("문자열 범위를 입력해 주세요.");
                    }
                    else
                    {
                        string start = textBox_BindStart.Text;
                        string end = textBox_BindEnd.Text;
                        string name, head, tail, name_noex;
                        bool b, b_1, b_2;
                        int fail_Count = 0;
                        int fail_Number;
                        string fail_List = "";

                        for (int i = 0; i < Fm.listView1.SelectedItems.Count; i++)
                        {
                            ListViewItem lvi = Fm.listView1.SelectedItems[i];
                            name = lvi.SubItems[1].Text;

                            if (Fm.FileExistsCheck(lvi.SubItems[2].Text) == true)
                            {
                                b = name.Contains(".");

                                if (b == true)
                                {
                                    name_noex = (name.Substring(0, name.LastIndexOf(".")));
                                }
                                else
                                {
                                    name_noex = name;
                                }
                            }
                            else if (Fm.FolderExistsCheck(lvi.SubItems[2].Text) == true)
                            {
                                b = false;
                                name_noex = name;
                            }
                            else
                            {
                                b = false;
                                name_noex = name;
                            }

                            b_1 = name_noex.Contains(start);
                            b_2 = name_noex.Contains(end);

                            if (b_1 == false || b_2 == false)
                            {
                                fail_Count++;
                                fail_Number = i + 1;
                                if (fail_Count > 1)
                                {
                                    fail_List = fail_List + ", " + fail_Number.ToString();
                                }
                                else if (fail_Count == 1)
                                {
                                    fail_List = fail_Number.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("error");
                                }
                            }
                            else
                            {
                                head = (name_noex.Substring(0, name.IndexOf(start)));
                                tail = (name_noex.Substring(name.LastIndexOf(end) + 1));
                                name_noex = head + tail;
                            }

                            if (b == true)
                            {
                                name = name_noex + (name.Substring(name.LastIndexOf(".")));
                            }
                            else
                            {
                                name = name_noex;
                            }

                            lvi.SubItems[1].Text = name;
                        }
                        if (fail_Count > 0)
                        {
                            MessageBox.Show(fail_Count + "개의 항목에 입력한 문자열이 존재하지 않았습니다.\n"
                               + "선택된 목록 중에서 " + fail_List + "번째 항목이 변경되지 않았습니다.");
                        }
                    }
                }
                if (radioButton_Type.Checked)//타입별 지우기
                {
                    string name, name_head, name_tail; ;
                    bool b;

                    for (int i = 0; i < Fm.listView1.SelectedItems.Count; i++)
                    {
                        ListViewItem lvi = Fm.listView1.SelectedItems[i];
                        name = lvi.SubItems[1].Text;
                        char[] check_char;
                        if (Fm.FileExistsCheck(lvi.SubItems[2].Text) == true)
                        {
                            b = name.Contains(".");
                            if (b == true)
                            {
                                name_head = (name.Substring(0, name.LastIndexOf(".")));
                                name_tail = (name.Substring(name.LastIndexOf(".")));
                            }
                            else
                            {
                                name_head = name;
                                name_tail = "";
                            }
                        }
                        else if (Fm.FolderExistsCheck(lvi.SubItems[2].Text) == true)
                        {
                            name_head = name;
                            name_tail = "";
                        }
                        else
                        {
                            name_head = name;
                            name_tail = "";
                        }
                        check_char = name_head.ToCharArray();

                        if (radioButton_TypeRemove.Checked)
                        {
                            string head, tail;

                            if (radioButton_Korean.Checked)
                            {

                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Korean_Check(check_char[j]) == true)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_English.Checked)
                            {
                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (English_Check(check_char[j]) == true)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_Number.Checked)
                            {
                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Number_Check(check_char[j]) == true)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_Space.Checked)
                            {
                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Space_Check(check_char[j]) == true)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_Combined.Checked)
                            {
                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Korean_Check(check_char[j]) == true || English_Check(check_char[j]) == true
                                        || Number_Check(check_char[j]) == true || Space_Check(check_char[j]) == true)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            name = name_head + name_tail;
                            lvi.SubItems[1].Text = name;
                        }

                        else if (radioButton_TypeLeave.Checked)
                        {
                            string head, tail;

                            if (radioButton_Korean.Checked)
                            {

                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Korean_Check(check_char[j]) == false)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_English.Checked)
                            {
                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (English_Check(check_char[j]) == false)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_Number.Checked)
                            {
                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Number_Check(check_char[j]) == false)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_Space.Checked)
                            {
                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Space_Check(check_char[j]) == false)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }

                            else if (radioButton_Combined.Checked)
                            {

                                for (int j = name_head.Length - 1; j >= 0; j--)
                                {
                                    if (Korean_Check(check_char[j]) == false && English_Check(check_char[j]) == false
                                        && Number_Check(check_char[j]) == false && Space_Check(check_char[j]) == false)
                                    {
                                        if (name_head.Length - 1 > j)
                                        {
                                            head = (name_head.Substring(0, j));
                                            tail = (name_head.Substring(j + 1));
                                            name_head = head + tail;
                                        }
                                        else if (name_head.Length - 1 == j)
                                        {
                                            name_head = (name_head.Substring(0, j));
                                        }
                                        else
                                        {
                                            MessageBox.Show("error");
                                        }
                                    }
                                }
                            }


                            name = name_head + name_tail;
                            lvi.SubItems[1].Text = name;
                        }

                        else
                        {
                            MessageBox.Show("체크한 문자를 남길지 지울지 선택해주세요.");
                        }
                    }
                }
                if (radioButton_Typing.Checked)
                {
                    if (textBox_Typing.Text.Length < 1)
                    {
                        MessageBox.Show("문자열을 입력해 주세요.");
                    }
                    else
                    {
                        string remove_String;
                        string name, head, tail;
                        string name_noex;
                        int fail_Count = 0;
                        int fail_Number;
                        string fail_List = "";
                        bool b, b_2;
                        int bool_int;
                        remove_String = textBox_Typing.Text;

                        for (int i = 0; i < Fm.listView1.SelectedItems.Count; i++)
                        {
                            ListViewItem lvi = Fm.listView1.SelectedItems[i];
                            name = lvi.SubItems[1].Text;

                            if (Fm.FileExistsCheck(lvi.SubItems[2].Text) == true)
                            {
                                b = name.Contains(".");
                                if (b == true)
                                {
                                    name_noex = (name.Substring(0, name.LastIndexOf(".")));
                                }
                                else
                                {
                                    name_noex = name;
                                }
                            }
                            else if (Fm.FolderExistsCheck(lvi.SubItems[2].Text) == true)
                            {
                                b = false;
                                name_noex = name;
                            }
                            else
                            {
                                b = false;
                                name_noex = name;
                            }

                            b_2 = name_noex.Contains(remove_String);

                            if (b_2 == false)
                            {
                                fail_Count++;
                                fail_Number = i + 1;
                                if (fail_Count > 1)
                                {
                                    fail_List = fail_List + ", " + fail_Number.ToString();
                                }
                                else if (fail_Count == 1)
                                {
                                    fail_List = fail_Number.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("error");
                                }
                            }
                            else
                            {
                                bool_int = 1;
                                for (; bool_int == 1;)
                                {
                                    head = (name_noex.Substring(0, name_noex.IndexOf(remove_String)));
                                    tail = (name_noex.Substring(name_noex.IndexOf(remove_String) + textBox_Typing.Text.Length));
                                    name_noex = head + tail;

                                    b_2 = name_noex.Contains(remove_String);
                                    if (b_2 == true)
                                        bool_int = 1;
                                    else
                                        bool_int = 0;
                                }
                            }

                            if (b == true)
                            {
                                name = name_noex + (name.Substring(name.LastIndexOf(".")));
                            }
                            else
                            {
                                name = name_noex;
                            }

                            lvi.SubItems[1].Text = name;
                        }


                        if (fail_Count > 0)
                        {
                            MessageBox.Show(fail_Count + "개의 항목에 입력한 문자열이 존재하지 않았습니다.\n"
                                + "선택된 항목 중 " + fail_List + "번째 항목이 변경되지 않았습니다.");
                        }
                    }

                }
            }

        }

        private void textBox_Typing_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

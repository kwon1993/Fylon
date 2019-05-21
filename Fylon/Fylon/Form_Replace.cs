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
    public partial class Form_Replace : Form
    {
        Form_Main Fm;
        public Form_Replace()
        {
            InitializeComponent();
        }
        public Form_Replace(Form_Main _form)//Form_Main 접근 허용
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

        private void button_Yes_Click(object sender, EventArgs e)//확인 버튼
        {
            replace();
            this.Close();
        }

        private void button_No_Click(object sender, EventArgs e)//취소 버튼
        {
            this.Close();
        }

        private void replace()
        {
            string before_text, after_text, name, name_noex, head, tail;
            int fail_Count = 0;
            int fail_Number;
            string fail_List = "";
            bool b, b_1, b_2;

            if (textBox_Before.Text.Length < 1)//입력 체크
            {
                MessageBox.Show("바꿀 문자열을 입력해주세요.");
            }
            else
            {
                before_text = textBox_Before.Text;//작업 문자열

                if (textBox_After.Text.Length < 1)//결과 문자열 입력없을시 공백으로 처리
                {
                    after_text = "";
                }
                else
                {
                    after_text = textBox_After.Text;
                }

                if (radioButton_WholeList.Checked)//전체 목록
                {
                    for (int i = 0; i < Fm.listView1.Items.Count; i++)
                    {
                        ListViewItem item = Fm.listView1.Items[i];
                        name = item.SubItems[1].Text;
                        if (Fm.FileExistsCheck(item.SubItems[2].Text) == true)//파일 체크
                        {
                            b = name.Contains(".");//확장자 체크

                            if (b == true)//확장자 분리
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

                        b_1 = name_noex.Contains(before_text);

                        if (b_1 == false)//작업할 문자열이 없는경우 오류체크
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
                            if (radioButton_All.Checked)//전부 적용 체크시
                            {
                                //string body = "";
                                //b_2 = true;
                                //for (; b_2 == true;)//바꿀 파일은 따로 분리하여 같은 문자열이 포함된 이름으로 바꿀시 무한루프 가능성 제거
                                //{
                                //    head = (name_noex.Substring(0, name_noex.IndexOf(before_text)));
                                //    tail = (name_noex.Substring(name_noex.IndexOf(before_text) + before_text.Length));
                                //    name_noex = head + after_text + tail;

                                //    body = body + (name_noex.Substring(0, name_noex.IndexOf(after_text) + after_text.Length));
                                //    name_noex = (name_noex.Substring(name_noex.IndexOf(after_text) + after_text.Length));

                                //    b_2 = name_noex.Contains(before_text);
                                //}
                                name_noex = name_noex.Replace(before_text, after_text);
                                //name_noex = body + name_noex;
                            }
                            else if (radioButton_Front.Checked)//앞에 하나만 적용할시
                            {
                                head = (name_noex.Substring(0, name_noex.IndexOf(before_text)));
                                tail = (name_noex.Substring(name_noex.IndexOf(before_text) + before_text.Length));
                                name_noex = head + after_text + tail;
                            }
                            else if (radioButton_Lear.Checked)//맨 뒤 하나만 적용할시
                            {
                                head = (name_noex.Substring(0, name_noex.LastIndexOf(before_text)));
                                tail = (name_noex.Substring(name_noex.LastIndexOf(before_text) + before_text.Length));
                                name_noex = head + after_text + tail;
                            }
                        }

                        if (b == true)//확장자가 있을경우 다시 추가
                        {
                            name = name_noex + (name.Substring(name.LastIndexOf(".")));
                        }
                        else
                        {
                            name = name_noex;
                        }

                        item.SubItems[1].Text = name;
                    }
                    if (fail_Count > 0)
                    {
                        MessageBox.Show(fail_Count + "개의 항목에 입력한 문자열이 존재하지 않았습니다.\n"
                            + fail_List + "번째 항목이 변경되지 않았습니다.");
                    }
                }
                //아래코드 선택된 목록 처리 제외하곤 모두 동일
                else if (radioButton_SelectedList.Checked)//선택한 목록만 적용
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

                        b_1 = name_noex.Contains(before_text);

                        if (b_1 == false)
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
                            if (radioButton_All.Checked)
                            {
                                //string body = "";
                                //b_2 = true;
                                //for (; b_2 == true;)
                                //{
                                //    head = (name_noex.Substring(0, name_noex.IndexOf(before_text)));
                                //    tail = (name_noex.Substring(name_noex.IndexOf(before_text) + before_text.Length));
                                //    name_noex = head + after_text + tail;

                                //    body = body + (name_noex.Substring(0, name_noex.IndexOf(after_text) + after_text.Length));
                                //    name_noex = (name_noex.Substring(name_noex.IndexOf(after_text) + after_text.Length));

                                //    b_2 = name_noex.Contains(before_text);
                                //}
                                name_noex = name_noex.Replace(before_text, after_text);
                                //name_noex = body + name_noex;
                            }
                            else if (radioButton_Front.Checked)
                            {
                                head = (name_noex.Substring(0, name_noex.IndexOf(before_text)));
                                tail = (name_noex.Substring(name_noex.IndexOf(before_text) + before_text.Length));
                                name_noex = head + after_text + tail;
                            }
                            else if (radioButton_Lear.Checked)
                            {
                                head = (name_noex.Substring(0, name_noex.LastIndexOf(before_text)));
                                tail = (name_noex.Substring(name_noex.LastIndexOf(before_text) + before_text.Length));
                                name_noex = head + after_text + tail;
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
}

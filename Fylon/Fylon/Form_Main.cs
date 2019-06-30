using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Fylon
{
    public partial class Form_Main : Form
    {
        private ListViewColumnSorter lvwColumnSorter;

        public Form_Main()
        {
            InitializeComponent();

            // ListView 열 분류기의 인스턴스를 만들고 ListView 컨트롤에 할당
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;
        }

        private void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // 클릭 된 열이 이미 정렬중인 열인지 확인
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // 정렬 방향 바꾸기.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // 정렬할 열 번호 설정; 기본은 오름차순.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }            
            // 새 정렬 옵션으로 정렬

            //정렬 종료 후 지속적인 Sorting을 제거하여 개별 목록 수정이 용이하도록 함
            this.listView1.ListViewItemSorter = lvwColumnSorter;
            this.listView1.Sort();
            this.listView1.ListViewItemSorter = null;
        }


        public class ListViewColumnSorter : System.Collections.IComparer
        {
            // 정렬할 열 지정
            private int ColumnToSort;
            // 정렬 순서 지정
            private SortOrder OrderOfSort;
            // 대소문자 비교하지 않는 비교자 개체
            private CaseInsensitiveComparer ObjectCompare;
            
            // 클래스 생성자.  요소등 초기화
            public ListViewColumnSorter()
            {
                // 열을 0으로 초기화
                ColumnToSort = 0;

                // 정렬순서 none로 초기화
                OrderOfSort = SortOrder.None;

                // CaseInsensitiveComparer object 초기화
                ObjectCompare = new CaseInsensitiveComparer();
            }

            // 이 메서드는 IComparer 인터페이스에서 상속됩니다. 대 / 소문자를 구분하지 않고 비교 한 두 개체를 비교합니다.
            // <param name="x">비교할 첫번째 객체</param>
            // <param name="y">비교할 두번째 객체</param>
            // <returns>비교 결과. "0" if equal, negative if 'x' is less than 'y' and positive if 'x' is greater than 'y'</returns>
            public int Compare(object x, object y)
            {
                int compareResult;
                ListViewItem listviewX, listviewY;

                // ListViewItem objects와 비교할 개체를 캐스팅
                listviewX = (ListViewItem)x;
                listviewY = (ListViewItem)y;

                // 두 항목 비교
                compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);

                // 개체 비교에 따른 올바른 반환값 계산
                if (OrderOfSort == SortOrder.Ascending)
                {
                    // 오름차순 정렬이면 비교 연산의 정상 결과를 반환
                    return compareResult;
                }
                else if (OrderOfSort == SortOrder.Descending)
                {
                    // 내림차순 정렬이면 비교 연산의 결과가 음수
                    return (-compareResult);
                }
                else
                {
                    // Return '0' to indicate they are equal
                    return 0;
                }
            }

            // 정렬 작업을 적용할 열의 수를 가져오거나 설정 (Defaults to '0').
            public int SortColumn
            {
                set
                {
                    ColumnToSort = value;
                }
                get
                {
                    return ColumnToSort;
                }
            }
            
            // 적용할 정렬 순서를 가져오거나 설정 (for example, 'Ascending' or 'Descending').
            public SortOrder Order
            {
                set
                {
                    OrderOfSort = value;
                }
                get
                {
                    return OrderOfSort;
                }
            }

        }

        public bool FileExistsCheck(string filePath_Check)//파일 존재 체크 함수
        {
            if (System.IO.File.Exists(filePath_Check))
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        public bool FolderExistsCheck(string folderPath_Check)//폴더 존재 체크 함수
        {
            if (System.IO.Directory.Exists(folderPath_Check))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void width_Resize()//행 길이 이름 길이에 맞게 재조정
        {
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                listView1.Columns[i].TextAlign = HorizontalAlignment.Left;
                listView1.Columns[i].Width = -2;
            }
        }
        public void width_Reset()//행 길이 초기화면으로 설정
        {
            listView1.Columns[0].Width = 200;
            listView1.Columns[1].Width = 200;
            listView1.Columns[2].Width = 100;
            listView1.Columns[3].Width = 100;
            listView1.Columns[4].Width = 100;
        }

        private void Enable_Check()//리스트에 파일목록이 하나 이상일때 메뉴 활성화
        {
            if (listView1.Items.Count < 1)
            {
                button_Save.Enabled = false;
                button_Reset.Enabled = false;
                button_RemoveAll.Enabled = false;
                button_RemoveSelect.Enabled = false;
                button_RemoveName.Enabled = false;
                button_AddString.Enabled = false;
                button_RemoveString.Enabled = false;
                button_Up.Enabled = false;
                button_Down.Enabled = false;
                button_Number.Enabled = false;
                button_Replace.Enabled = false;
                button_MoveFolder.Enabled = false;
                button_Extension.Enabled = false;
            }
            else
            {
                button_Save.Enabled = true;
                button_Reset.Enabled = true;
                button_RemoveAll.Enabled = true;
                button_RemoveSelect.Enabled = true;
                button_RemoveName.Enabled = true;
                button_AddString.Enabled = true;
                button_RemoveString.Enabled = true;
                button_Up.Enabled = true;
                button_Down.Enabled = true;
                button_Number.Enabled = true;
                button_Replace.Enabled = true;
                button_MoveFolder.Enabled = true;
                button_Extension.Enabled = true;
            }
        }

        private void ListDoubleClick(Object o, MouseEventArgs e)//더블클릭 이름 변경
        {
            Form_Rename Frn = new Form_Rename(this);
            Frn.ShowDialog();//Form_Rename 호출
            width_Resize();//너비 재조정
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)//드래그 앤 드랍 마우스 커서 표시
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void listView1_DragDrop(object sender, DragEventArgs e)//드래그 앤 드랍으로 파일 또는 폴더 추가
        {
            int addfoler = 0;//폴더추가 or 폴더 안 파일추가 선택한 옵션 저장용

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string path in files)//파일추가 반복함수
            {
                if (FolderExistsCheck(path) == true)//폴더일시 추가작업
                {
                    if (addfoler == 0)//초기 폴더추가 옵션 선택시
                    {
                        if (MessageBox.Show("폴더를 추가하려면 예, 폴더 안 파일을 추가하려면 아니오를 선택하세요.", "폴더 추가 옵션 선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int check_num = 0;
                            string name = (path.Substring(path.LastIndexOf("\\") + 1));//경로 제외한 파일명만 추출
                            string created_Date, modified_Date;
                            System.IO.FileInfo fileInfo = new System.IO.FileInfo(path);
                            created_Date = fileInfo.CreationTime.ToString();//생성한 시간
                            modified_Date = fileInfo.LastWriteTime.ToString();//최종 수정한 시간

                            string[] row = { name, name, path, created_Date, modified_Date };//데이터 추가할 순서
                            var listViewItem = new ListViewItem(row);
                            for (int i = 0; i < listView1.Items.Count; i++)//같은 파일 불러오지 않게 하는 예외 처리
                            {
                                ListViewItem item = listView1.Items[i];
                                if (listView1.Items[i].SubItems[2].Text == path)//목록의 경로와 불러오려는 파일의 경로를 비교하여 같은것이 있으면 check_num상승
                                {
                                    check_num += 1;
                                }
                            }
                            if (check_num == 0)//check_num이 0이면 중복이 없는것으로 판단하고 파일 추가
                            {
                                listView1.Items.Add(listViewItem);
                            }
                            addfoler = 1;//폴더추가 옵션 예 선택 확인용
                        }
                        else
                        {
                            System.IO.DirectoryInfo fol = new System.IO.DirectoryInfo(path);
                            foreach (var infile in fol.GetFiles())
                            {
                                string inpath = path + "\\" + infile.Name;//폴더 안 파일 경로
                                int check_num = 0;
                                string name = infile.Name;//파일명
                                string created_Date, modified_Date;
                                System.IO.FileInfo fileInfo = new System.IO.FileInfo(inpath);
                                created_Date = fileInfo.CreationTime.ToString();//생성한 시간
                                modified_Date = fileInfo.LastWriteTime.ToString();//최종 수정한 시간

                                string[] row = { name, name, inpath, created_Date, modified_Date };//데이터 추가 순서
                                var listViewItem = new ListViewItem(row);
                                for (int i = 0; i < listView1.Items.Count; i++)//같은 파일 불러오지 않게 하는 예외 처리
                                {
                                    ListViewItem item = listView1.Items[i];
                                    if (listView1.Items[i].SubItems[2].Text == inpath)//목록의 경로와 불러오려는 파일의 경로를 비교하여 같은것이 있으면 check_num상승
                                    {
                                        check_num += 1;
                                    }
                                }
                                if (check_num == 0)//check_num이 0이면 중복이 없는것으로 판단하고 파일 추가
                                {
                                    listView1.Items.Add(listViewItem);
                                }
                                addfoler = 2;//폴더추가 옵션 아니오 선택 확인용
                            }
                        }                        
                    }
                    else if (addfoler == 1)//위 폴더추가 옵션에서 예 선택시 (코드 같음)
                    {
                        int check_num = 0;
                        string name = (path.Substring(path.LastIndexOf("\\") + 1));//경로 제외한 파일명만 추출
                        string created_Date, modified_Date;
                        System.IO.FileInfo fileInfo = new System.IO.FileInfo(path);
                        created_Date = fileInfo.CreationTime.ToString();
                        modified_Date = fileInfo.LastWriteTime.ToString();

                        string[] row = { name, name, path, created_Date, modified_Date };
                        var listViewItem = new ListViewItem(row);
                        for (int i = 0; i < listView1.Items.Count; i++)//같은 파일 불러오지 않게 하는 예외 처리
                        {
                            ListViewItem item = listView1.Items[i];
                            if (listView1.Items[i].SubItems[2].Text == path)
                            {
                                check_num += 1;
                            }
                        }
                        if (check_num == 0)
                        {
                            listView1.Items.Add(listViewItem);
                        }
                        addfoler = 1;
                    }
                    else if (addfoler == 2)//위 폴더추가 옵션에서 아니오 선택시 (코드 같음)
                    {
                        System.IO.DirectoryInfo fol = new System.IO.DirectoryInfo(path);
                        foreach (var infile in fol.GetFiles())
                        {
                            string inpath = path + "\\" + infile.Name;
                            int check_num = 0;
                            string name = infile.Name;
                            string created_Date, modified_Date;
                            System.IO.FileInfo fileInfo = new System.IO.FileInfo(inpath);
                            created_Date = fileInfo.CreationTime.ToString();
                            modified_Date = fileInfo.LastWriteTime.ToString();

                            string[] row = { name, name, inpath, created_Date, modified_Date };
                            var listViewItem = new ListViewItem(row);
                            for (int i = 0; i < listView1.Items.Count; i++)//같은 파일 불러오지 않게 하는 예외 처리
                            {
                                ListViewItem item = listView1.Items[i];
                                if (listView1.Items[i].SubItems[2].Text == inpath)
                                {
                                    check_num += 1;
                                }
                            }
                            if (check_num == 0)
                            {
                                listView1.Items.Add(listViewItem);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }
                }
                else//파일 추가시 하위폴더가 없으므로 일반적으로 추가 (폴더 예 선택과 코드 같음)
                {
                    int check_num = 0;
                    string name = (path.Substring(path.LastIndexOf("\\") + 1));//경로 제외한 파일명만 추출
                    string created_Date, modified_Date;
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(path);
                    created_Date = fileInfo.CreationTime.ToString();
                    modified_Date = fileInfo.LastWriteTime.ToString();

                    string[] row = { name, name, path, created_Date, modified_Date };
                    var listViewItem = new ListViewItem(row);
                    for (int i = 0; i < listView1.Items.Count; i++)//같은 파일 불러오지 않게 하는 예외 처리
                    {
                        ListViewItem item = listView1.Items[i];
                        if (listView1.Items[i].SubItems[2].Text == path)
                        {
                            check_num += 1;
                        }
                    }
                    if (check_num == 0)
                    {
                        listView1.Items.Add(listViewItem);
                    }
                }
            }
            Enable_Check();//메뉴 활성화 체크
            width_Resize();//너비 재조정
        }

        private void Button_Load_Click(object sender, EventArgs e)//불러오기 버튼
        {
            FileOpen();
            Enable_Check();//메뉴 활성화 체크
            width_Resize();//너비 재조정
        }

        public string FileOpen()//파일 불러오기 코드 (파일만 불러오기 가능, 폴더 불가능)
        {
            //파일오픈창 생성 및 설정
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "불러오기";
            ofd.Filter = "모든 파일 (*.*) | *.*";
            ofd.Multiselect = true;//다중선택 허용

            //파일 오픈창 로드
            DialogResult dr = ofd.ShowDialog();

            //OK버튼 클릭시
            if (dr == DialogResult.OK)
            {
                foreach (string path in ofd.FileNames)//드래그 앤 드롭 파일추가와 같음
                {
                    int check_num = 0;
                    string name = (path.Substring(path.LastIndexOf("\\") + 1));//경로 제외한 파일명만 추출
                    string created_Date, modified_Date;
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(path);
                    created_Date = fileInfo.CreationTime.ToString();
                    modified_Date = fileInfo.LastWriteTime.ToString();

                    string[] row = { name, name, path, created_Date, modified_Date };
                    var listViewItem = new ListViewItem(row);
                    for (int i = 0; i < listView1.Items.Count; i++)//같은 파일 불러오지 않게 하는 예외 처리
                    {
                        ListViewItem item = listView1.Items[i];
                        if(listView1.Items[i].SubItems[2].Text == path)
                        {
                            check_num += 1;
                        }
                    }
                    if (check_num == 0)
                    {
                        listView1.Items.Add(listViewItem);
                    }
                }
            }
            //취소버튼 클릭시 또는 ESC키로 파일창을 종료 했을경우
            else if (dr == DialogResult.Cancel)
            {
                return "";
            }

            return "";
        }
        private void Button_Save_Click(object sender, EventArgs e)//변경적용 버튼
        {
            string OldPath;//기존 경로
            string NewPath;//옮길 경로
            string AddName;//바꿀 이름
            int fail_Count_exist = 0;//변경적용 실패 카운트
            int fail_Count_file = 0;
            int fail_Count_folder = 0;
            int fail_Count_Length = 0;
            int fail_Count_ZeroLength = 0;
            int fail_Number_exist;
            int fail_Number_file;
            int fail_Number_folder;
            int fail_Number_Length;
            int fail_Number_ZeroLength;
            string fail_List_exist = "";
            string fail_List_file = "";
            string fail_List_folder = "";
            string fail_List_Length = "";
            string fail_List_ZeroLength = "";
            int error_count = 0;

            for (int i = 0; i < listView1.Items.Count; i++)
            {                
                ListViewItem item = listView1.Items[i];
                if (listView1.Items[i].SubItems[0].Text != listView1.Items[i].SubItems[1].Text)//기존 파일명과 변경할 이름이 달라야 적용
                {
                    AddName = item.SubItems[1].Text;//변경할 이름
                    OldPath = item.SubItems[2].Text;//기존 경로
                    NewPath = (OldPath.Substring(0, OldPath.LastIndexOf("\\") + 1));
                    NewPath = NewPath + AddName;//변경할 경로(파일명 변경)

                    if(FileExistsCheck(OldPath) == false && FolderExistsCheck(OldPath) == false)//파일이 해당 경로에 없는 경우 에러 카운트
                    {
                        fail_Count_exist++;//해당 경로에 없는 목록 개수 기록
                        fail_Number_exist = i + 1;
                        if(fail_Count_exist > 1)//해당 경로에 없는 목록 순서 기록
                        {
                            fail_List_exist = fail_List_exist + ", " + fail_Number_exist.ToString();
                        }
                        else if (fail_Count_exist == 1)
                        {
                            fail_List_exist = fail_Number_exist.ToString();
                        }
                        else
                        {
                            error_count++;
                        }
                    }
                    else if (FileExistsCheck(NewPath) == true)//이미 해당 이름을 가진 파일이 존재할 경우
                    {
                        fail_Count_file++;
                        fail_Number_file = i + 1;
                        if (fail_Count_file > 1)
                        {
                            fail_List_file = fail_List_file + ", " + fail_Number_file.ToString();
                        }
                        else if (fail_Count_exist == 1)
                        {
                            fail_List_file = fail_Number_file.ToString();
                        }
                        else
                        {
                            error_count++;
                        }
                    }
                    else if (FolderExistsCheck(NewPath) == true)//이미 해당 이름을 가진 폴더가 존재할 경우
                    {
                        fail_Count_folder++;
                        fail_Number_folder = i + 1;
                        if (fail_Count_folder > 1)
                        {
                            fail_List_folder = fail_List_folder + ", " + fail_Number_folder.ToString();
                        }
                        else if (fail_Count_folder == 1)
                        {
                            fail_List_folder = fail_Number_folder.ToString();
                        }
                        else
                        {
                            error_count++;
                        }
                    }
                    else if (NewPath.Length >= 260)
                    {
                        fail_Count_Length++;
                        fail_Number_Length = i + 1;
                        if (fail_Count_Length > 1)
                        {
                            fail_List_Length = fail_List_Length + ", " + fail_Number_Length.ToString();
                        }
                        else if (fail_Count_Length == 1)
                        {
                            fail_List_Length = fail_Number_Length.ToString();
                        }
                        else
                        {
                            error_count++;
                        }
                    }
                    else if (AddName.Length == 0 || AddName.Substring(0, AddName.LastIndexOf(".")).Length == 0)
                    {
                        fail_Count_ZeroLength++;
                        fail_Number_ZeroLength = i + 1;
                        if (fail_Count_ZeroLength > 1)
                        {
                            fail_List_ZeroLength = fail_List_ZeroLength + ", " + fail_Number_ZeroLength.ToString();
                        }
                        else if (fail_Count_ZeroLength == 1)
                        {
                            fail_List_ZeroLength = fail_Number_ZeroLength.ToString();
                        }
                        else
                        {
                            error_count++;
                        }
                    }
                    else if (FileExistsCheck(OldPath) == true)//파일 이름 변경
                    {
                        System.IO.File.Move(OldPath, NewPath);
                        item.SubItems[0].Text = AddName;
                        item.SubItems[2].Text = NewPath;
                    }
                    else if (FolderExistsCheck(OldPath) == true)//폴더 이름 변경
                    {
                        System.IO.Directory.Move(OldPath, NewPath);
                        item.SubItems[0].Text = AddName;
                        item.SubItems[2].Text = NewPath;
                    }
                    else
                    {
                        error_count += 100000;//예기치 못한 에러 체크
                    }                    
                }
            }
            if (fail_Count_exist > 0 && fail_Count_file > 0 && fail_Count_folder > 0)//파일명 변경 할 수 없는 목록 개수와 순서 알림
            {
                MessageBox.Show(fail_Count_exist + "개의 파일 또는 폴더가 존재하지 않습니다.\n" + fail_List_exist + "번째 항목이 변경되지 않았습니다.\n"
                    + fail_Count_file + "개의 중복된 파일명이 존재합니다.\n" + fail_List_file + "번째 항목이 변경되지 않았습니다.\n"
                    + fail_Count_folder + "개의 중복된 폴더명이 존재합니다.\n" + fail_List_folder + "번째 항목이 변경되지 않았습니다.");
            }
            else if (fail_Count_exist > 0 && fail_Count_file > 0)
            {
                MessageBox.Show(fail_Count_exist + "개의 파일 또는 폴더가 존재하지 않습니다.\n" + fail_List_exist + "번째 항목이 변경되지 않았습니다.\n"
                    + fail_Count_file + "개의 중복된 파일명이 존재합니다.\n" + fail_List_file + "번째 항목이 변경되지 않았습니다.");
            }
            else if (fail_Count_exist > 0 && fail_Count_folder > 0)
            {
                MessageBox.Show(fail_Count_exist + "개의 파일 또는 폴더가 존재하지 않습니다.\n" + fail_List_exist + "번째 항목이 변경되지 않았습니다.\n"
                    + fail_Count_folder + "개의 중복된 폴더명이 존재합니다.\n" + fail_List_folder + "번째 항목이 변경되지 않았습니다.");
            }
            else if (fail_Count_file > 0 && fail_Count_folder > 0)
            {
                MessageBox.Show(fail_Count_file + "개의 중복된 파일명이 존재합니다.\n" + fail_List_file + "번째 항목이 변경되지 않았습니다.\n"
                    + fail_Count_folder + "개의 중복된 폴더명이 존재합니다.\n" + fail_List_folder + "번째 항목이 변경되지 않았습니다.");
            }
            else if (fail_Count_exist > 0)
            {
                MessageBox.Show(fail_Count_exist + "개의 파일 또는 폴더가 존재하지 않습니다.\n" + fail_List_exist + "번째 항목이 변경되지 않았습니다.\n");
            }
            else if (fail_Count_file > 0)
            {
                MessageBox.Show(fail_Count_file + "개의 중복된 파일명이 존재합니다.\n" + fail_List_file + "번째 항목이 변경되지 않았습니다.\n");
            }
            else if (fail_Count_folder > 0)
            {
                MessageBox.Show(fail_Count_folder + "개의 중복된 폴더명이 존재합니다.\n" + fail_List_folder + "번째 항목이 변경되지 않았습니다.");
            }
            if (fail_Count_Length > 0)
            {
                MessageBox.Show(fail_Count_Length + "개의 항목 이름이 너무 깁니다.\n" + fail_List_Length + "번째 항목이 변경되지 않았습니다.");
            }
            if (fail_Count_ZeroLength > 0)
            {
                MessageBox.Show(fail_Count_ZeroLength + "개의 항목의 변경할 이름이 없습니다.\n" + fail_List_ZeroLength + "번째 항목이 변경되지 않았습니다.");
            }

            width_Resize();//너비 재조정
        }

        private void Button_Reset_Click(object sender, EventArgs e)//이름 변경 내역 초기화
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ListViewItem item = listView1.Items[i];
                item.SubItems[1].Text = item.SubItems[0].Text;
            }
            width_Resize();//너비 재조정
        }

        private void Button_RemoveAll_Click(object sender, EventArgs e)//목록 지우기
        {
            listView1.Items.Clear();//listview 클리어
            Enable_Check();
            width_Reset();
        }

        private void Button_RemoveSelect_Click(object sender, EventArgs e)//선택된 목록 지우기
        {
            int cnt = listView1.SelectedItems.Count;//item개수

            for (int i = cnt - 1; i >= 0; i--)
            {
                listView1.Items.Remove(listView1.SelectedItems[i]);//선택된 개체 뒤쪽 숫자부터 제거(앞부터 제거시 순서 바뀜)
            }
            Enable_Check();
            width_Resize();//너비 재조정
        }

        private void Button_RemoveName_Click(object sender, EventArgs e)//바꿀 이름을 공백으로 만듬
        {
            string name;
            bool b;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ListViewItem item = listView1.Items[i];
                name = item.SubItems[1].Text;
                if (FileExistsCheck(item.SubItems[2].Text) == true)
                {
                    b = name.Contains(".");
                    if (b == true)
                    {
                        name = (name.Substring(name.LastIndexOf(".")));
                    }
                    else
                    {
                        name = "";
                    }
                }
                else if (FolderExistsCheck(item.SubItems[2].Text) == true)
                {
                    name = "";
                }
                item.SubItems[1].Text = name;
            }
        }

        private void Button_AddString_Click(object sender, EventArgs e)//문자열추가 버튼
        {
            Form_AddString Fas = new Form_AddString(this);
            Fas.ShowDialog();//AddString폼 호출
            width_Resize();//너비 재조정
        }

        private void Button_RemoveString_Click(object sender, EventArgs e)//문자열삭제 버튼
        {
            Form_RemoveString Frs = new Form_RemoveString(this);
            Frs.ShowDialog();
        }

        private void Button_Number_Click(object sender, EventArgs e)//번호붙이기 버튼
        {
            Form_Number Fnb = new Form_Number(this);
            Fnb.ShowDialog();
            width_Resize();//너비 재조정
        }

        private void Button_Replace_Click(object sender, EventArgs e)//찾아바꾸기 버튼
        {
            Form_Replace Frp = new Form_Replace(this);
            Frp.ShowDialog();
            width_Resize();//너비 재조정
        }

        private void Button_MoveFolder_Click(object sender, EventArgs e)//폴더이동 버튼
        {
            string OldPath;
            string NewPath;
            string NewPathLine;
            string AddName;
            int file_Remain = 0;
            int file_Samename = 0;
            int same_folder = 0;


            FolderBrowserDialog folderBrowse = new FolderBrowserDialog();

            if (folderBrowse.ShowDialog() == DialogResult.OK)//옮길 폴더 선택
            {
                NewPathLine = folderBrowse.SelectedPath;
                
                //선택목록이동
                if (MessageBox.Show("선택한 목록만 이동하려면 예, 전체 목록을 이동하려면 아니오를 선택하세요.", "이동 옵션 선택", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 0; i < listView1.SelectedItems.Count; i++)
                    {
                        ListViewItem lvi = listView1.SelectedItems[i];

                        AddName = lvi.SubItems[0].Text;
                        OldPath = lvi.SubItems[2].Text;
                        NewPath = NewPathLine + "\\" + AddName;

                        if (FileExistsCheck(OldPath) == false && FolderExistsCheck(OldPath) == false)//해당 경로에 파일 또는 폴더가 없을 시
                        {
                            file_Remain++;
                        }
                        else if (FileExistsCheck(NewPath) == true || FolderExistsCheck(NewPath) == true)//옮길 경로에 같은 이름의 파일이 존재시
                        {
                            file_Samename++;
                        }
                        else if (NewPathLine == OldPath)
                        {
                            same_folder++;
                        }
                        else if (FileExistsCheck(OldPath) == true)
                        {
                            System.IO.File.Move(OldPath, NewPath);
                            lvi.SubItems[2].Text = NewPath;
                        }
                        else if (FolderExistsCheck(OldPath) == true)
                        {
                            System.IO.Directory.Move(OldPath, NewPath);
                            lvi.SubItems[2].Text = NewPath;
                        }
                        else
                        {
                            MessageBox.Show("정의되지 않은 오류.");
                        }
                    }
                    if(same_folder > 0)
                    {
                        MessageBox.Show("선택한 목록 중에 이동시킬 폴더가 포함되어있습니다.");
                    }
                    if (file_Remain > 0)
                    {
                        MessageBox.Show(file_Remain.ToString() + "개의 파일이 존재하지 않습니다.");
                    }
                    if (file_Samename > 0)
                    {
                        MessageBox.Show(file_Samename.ToString() + "개의 이미 해당 이름을 가진 파일 또는 폴더가 있습니다.");
                    }
                }
                else//전체목록 이동
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        ListViewItem item = listView1.Items[i];

                        AddName = item.SubItems[0].Text;
                        OldPath = item.SubItems[2].Text;
                        NewPath = NewPathLine + "\\" + AddName;

                        if (FileExistsCheck(OldPath) == false && FolderExistsCheck(OldPath) == false)//해당 경로에 파일 또는 폴더가 없을 시
                        {
                            file_Remain++;
                        }
                        else if (FileExistsCheck(NewPath) == true || FolderExistsCheck(NewPath) == true)//옮길 경로에 같은 이름의 파일이 존재시
                        {
                            file_Samename++;
                        }
                        else if (NewPathLine == OldPath)
                        {
                            same_folder++;
                        }
                        else if (FileExistsCheck(OldPath) == true)
                        {
                            System.IO.File.Move(OldPath, NewPath);
                            item.SubItems[2].Text = NewPath;
                        }
                        else if (FolderExistsCheck(OldPath) == true)
                        {
                            System.IO.Directory.Move(OldPath, NewPath);
                            item.SubItems[2].Text = NewPath;
                        }
                        else
                        {
                            MessageBox.Show("정의되지 않은 오류.");
                        }
                    }
                    if (same_folder > 0)
                    {
                        MessageBox.Show("선택한 목록 중에 이동시킬 폴더가 포함되어있습니다.");
                    }
                    if (file_Remain > 0)
                    {
                        MessageBox.Show(file_Remain.ToString() + "개의 항목이 존재하지 않습니다.");
                    }
                    if(file_Samename > 0)
                    {
                        MessageBox.Show(file_Samename.ToString() + "개의 이미 해당 이름을 가진 파일 또는 폴더가 있습니다.");
                    }
                }
            }
            width_Resize();//너비 재조정
        }

        private void Button_Extension_Click(object sender, EventArgs e)//확장자 관리 버튼
        {
            Form_Extension Fex = new Form_Extension(this);
            Fex.ShowDialog();
            width_Resize();//너비 재조정
        }
        
        private void MoveItem(int index, ListViewItem item)//목록 이동 함수
        {
            // 제거
            listView1.SelectedItems[0].Remove();//목록에서 삭제
            //listView1.Items.Remove(listView1.SelectedItems[0]);

            // 추가
            listView1.Items.Insert(index, item);//바뀐 index위치로 insert

            item.Selected = true;
            item.Focused = true;

            listView1.Focus();
        }

        private void Button_Up_Click(object sender, EventArgs e)//순서 위로
        {
            //다중 선택 이동 테스트 코드
            //int cnt = listView1.SelectedItems.Count;//item개수

            //for(int i = 0; i < cnt; i++)
            //{
            //    ListViewItem upitem = (ListViewItem)listView1.SelectedItems[0].Clone();
            //    int index = listView1.SelectedItems[i].Index;

            //    if(index > 0)
            //    {
            //        index--;
            //    }

            //    MoveItem(index, upitem);
            //}

            if (listView1.SelectedItems.Count == 1)//하나 선택시만 동작
            {
                ListViewItem upitem = (ListViewItem)listView1.SelectedItems[0].Clone();//복제
                int index = listView1.SelectedItems[0].Index;//인덱스 정의

                if (index > 0)
                    index--;

                MoveItem(index, upitem);
            }
        }
        private void Button_Down_Click(object sender, EventArgs e)//순서 아래로
        {
            //다중 선택 이동 테스트 코드
            //int cnt = listView1.SelectedItems.Count;//item개수

            //for (int i = cnt - 1; i >= 0; i--)
            //{
            //    ListViewItem downitem = (ListViewItem)listView1.SelectedItems[i].Clone();
            //    int index = listView1.SelectedItems[i].Index;

            //    if(index < listView1.Items.Count - 1)
            //    {
            //        index++;
            //    }
            //    MoveItem(index, downitem);
            //}


            if (listView1.SelectedItems.Count == 1)//하나 선택시만 동작
            {
                ListViewItem downitem = (ListViewItem)listView1.SelectedItems[0].Clone();//복제
                int index = listView1.SelectedItems[0].Index;//인덱스 정의

                if (index < listView1.Items.Count - 1)
                    index++;

                MoveItem(index, downitem);
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)//종료
        {
            this.Close();
        }

        private void 버전ToolStripMenuItem_Click(object sender, EventArgs e)//버전 알림
        {
            MessageBox.Show("버전: 1.0");
        }
    }
}

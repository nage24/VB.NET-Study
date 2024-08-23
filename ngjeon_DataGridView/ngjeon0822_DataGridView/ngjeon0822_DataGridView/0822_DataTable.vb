Public Class Form1

    Public Sub New()
        ' 폼의 구성 요소 초기화
        InitializeComponent()

        ' CellValueChanged 이벤트 핸들러 등록
        AddHandler DataGridView1.CellValueChanged, AddressOf DataGridView1_CellValueChanged
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        ' 셀 값이 변경될 때 자동으로 크기 조정
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' DataProvider에서 데이터 테이블을 가져옵니다.
        Dim dt As DataTable = CreateDataTable.CreateStudentTable()

        ' DataSet을 만들고 테이블을 추가합니다.
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        ' DataGridView에 데이터 바인딩하기
        DataGridView1.DataSource = ds.Tables("Student")

        For tableCount As Integer = 0 To ds.Tables.Count - 1
            For rowIndex As Integer = 0 To ds.Tables(tableCount).Rows.Count - 1
                For colIndex As Integer = 0 To ds.Tables(tableCount).Columns.Count - 1
                    Console.Write(ds.Tables(tableCount).Rows(rowIndex).Item(colIndex).ToString)
                    Console.Write(" | ")
                Next
                Console.WriteLine()
            Next
            Console.WriteLine(" ------------------------------ ")
        Next

        Console.WriteLine()

        'DataTable 값을 DataGridView로 화면에 표시
        DataGridView1.DataSource = dt

        '01.  ---------- DataGridView의 현재 셀을 가져오거나 현재 셀 변경 ---------- 
        Console.WriteLine(" ---------- DataGridView ---------- ")
        ' 현재 셀 변경
        DataGridView1.CurrentCell = DataGridView1(4, 0)

        '현재 셀 가져오기
        Console.WriteLine(DataGridView1.CurrentCell.Value)
        Console.WriteLine(DataGridView1.CurrentCell.ColumnIndex)
        Console.WriteLine(DataGridView1.CurrentCell.RowIndex)

        '현재 셀 주소 가져오기
        Console.WriteLine("現在のセルの位置は ({0}, {1})です。",
        DataGridView1.CurrentCellAddress.X,
        DataGridView1.CurrentCellAddress.Y)

        '02.   ---------- DataGridView에서 지정한 셀을 편집하지 못하도록 방지  ---------- 
        '03.   ---------- DataGridView의 맨 아래에 있는 새 행을 숨겨 사용자가 새 행을 추가하지 못하도록 방지  ---------- 
        DataGridView1.AllowUserToAddRows = False

        '04.   ---------- DataGridView의 한 행이 새 행(새 행)인지 확인  ---------- 
        '05.   ---------- DataGridView의 행을 사용자가 삭제할 수 없도록 방지  ---------- 
        '06.   ---------- 지정된 열이 DataGridView에 있는지 확인  ---------- 
        '07.   ---------- DataGridView의 열과 행 숨기기 또는 삭제  ---------- 
        'DataGridView1.Columns(0).Visible = False

        '08.   ---------- DataGridView의 열 너비와 행 높이를 변경할 수 없도록 함  ----------

        '헤더 너비 변경 가능
        DataGridView1.RowHeadersWidthSizeMode =
                        DataGridViewRowHeadersWidthSizeMode.EnableResizing

        '헤더 높이 변경 가능
        DataGridView1.ColumnHeadersHeightSizeMode =
                        DataGridViewColumnHeadersHeightSizeMode.EnableResizing

        '09.   ---------- DataGridView의 열 너비와 행 높이를 자동으로 조정  ----------

        '13.   ---------- 선택한 열, 행, 셀 가져오기  ----------
        Console.WriteLine("SelectedCells")
        For Each c As DataGridViewCell In DataGridView1.SelectedCells
            Console.WriteLine("{0}, {1}", c.ColumnIndex, c.RowIndex)
        Next c

        '행 선택
        '행 단위 선택 옵션 해서 행 선택 가능
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DataGridView1.Rows(1).Selected = True

        '여러 행 선택
        DataGridView1.MultiSelect = True
        DataGridView1.Rows(0).Selected = True

        Console.WriteLine("SelectedRows")
        For Each r As DataGridViewRow In DataGridView1.SelectedRows
            Console.WriteLine(r.Index)
        Next r

        ' 열 선택
        ' 열의 SortMode를 DataGridViewColumnSortMode.NotSortable로 설정 한 후,
        ' 열 단위 선택 옵션 해서 열 선택 가능
        'For Each column As DataGridViewColumn In DataGridView1.Columns
        '    column.SortMode = DataGridViewColumnSortMode.NotSortable
        'Next

        'DataGridView1.SelectionMode = DataGridViewSelectionMode.FullColumnSelect

        'DataGridView1.Columns(0).Selected = True

        Console.WriteLine("SelectedColumns")
        For Each c As DataGridViewColumn In DataGridView1.SelectedColumns
            Console.WriteLine(c.Index)
        Next c

        '13.   ---------- DataGridView의 셀, 열 및 행이 현재 표시되는지 확인  ----------
        If Not DataGridView1(0, 0).Displayed Then
            DataGridView1.CurrentCell = DataGridView1(0, 0)
        End If

        If DataGridView1.Columns(0).Displayed Then
            Console.WriteLine("インデックス0の列は表示されています")
        End If

        If DataGridView1.Rows(0).Displayed Then
            Console.WriteLine("インデックス0の行は表示されています")
        End If

        '14.   ---------- DataGridView의 헤더 셀 얻기  ----------

#If False Then
        'DataGridView1의 시작 열의 텍스트 변경
        DataGridView1.Columns(0).HeaderCell.Value = "Header Column"

        'DataGridView1의 시작 줄 텍스트 변경
        DataGridView1.Rows(0).HeaderCell.Value = "Header Row"

        'DataGridView1의 왼쪽 상단 모서리에 있는 셀의 텍스트 변경
        DataGridView1.TopLeftHeaderCell.Value = "Left Top"
        DataGridView1.EndEdit()
#End If

    End Sub
End Class

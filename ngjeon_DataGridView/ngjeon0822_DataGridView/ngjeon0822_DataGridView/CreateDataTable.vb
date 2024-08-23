Public Class CreateDataTable
    Public Shared Function CreateStudentTable() As DataTable
        ' 데이터 테이블 생성
        Dim dt As New DataTable("students")

        ' 컬럼 추가
        dt.Columns.Add("StudentID", GetType(Integer))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Age", GetType(Integer))
        dt.Columns.Add("Grade", GetType(String))
        dt.Columns.Add("Score", GetType(Integer))

        ' 데이터 행 추가
        Dim dtRow As DataRow

        ' 첫 번째 학생
        dtRow = dt.NewRow()
        dtRow("StudentID") = 1
        dtRow("Name") = "A"
        dtRow("Age") = 15
        dtRow("Grade") = "10th"
        dtRow("Score") = 85
        dt.Rows.Add(dtRow)

        ' 두 번째 학생
        dtRow = dt.NewRow()
        dtRow("StudentID") = 2
        dtRow("Name") = "B"
        dtRow("Age") = 16
        dtRow("Grade") = "11th"
        dtRow("Score") = 90
        dt.Rows.Add(dtRow)

        ' 세 번째 학생
        dtRow = dt.NewRow()
        dtRow("StudentID") = 3
        dtRow("Name") = "C"
        dtRow("Age") = 14
        dtRow("Grade") = "9th"
        dtRow("Score") = 88
        dt.Rows.Add(dtRow)

        ' 네 번째 학생
        dtRow = dt.NewRow()
        dtRow("StudentID") = 4
        dtRow("Name") = "D"
        dtRow("Age") = 17
        dtRow("Grade") = "12th"
        dtRow("Score") = 92
        dt.Rows.Add(dtRow)

        Return dt
    End Function
End Class

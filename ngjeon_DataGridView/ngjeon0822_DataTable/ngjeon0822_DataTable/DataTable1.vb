Public Class DataTable1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' 1テーブル目
        Dim dt As New DataTable("people")
        dt.Columns.Add("name")
        dt.Columns.Add("old")
        dt.Columns.Add("height")

        'DataRow宣言
        Dim dtRow As DataRow

        '1行目
        dtRow = dt.NewRow
        dtRow("name") = "ひろ"
        dtRow("old") = "15"
        dtRow("height") = "150"
        '行追加
        dt.Rows.Add(dtRow)

        '2行目
        dtRow = dt.NewRow
        dtRow("name") = "にも"
        dtRow("old") = "20"
        dtRow("height") = "160"
        '行追加
        dt.Rows.Add(dtRow)

        ' 2テーブル目
        Dim dt_money As New DataTable("money")
        dt_money.Columns.Add("name")
        dt_money.Columns.Add("money")

        'DataRow宣言
        Dim dtRow_money As DataRow

        '1行目
        dtRow_money = dt_money.NewRow
        dtRow_money("name") = "ひろ"
        dtRow_money("money") = "200000"
        '行追加
        dt_money.Rows.Add(dtRow_money)

        '2行目
        dtRow_money = dt_money.NewRow
        dtRow_money("name") = "にも"
        dtRow_money("money") = "1000000"
        '行追加
        dt_money.Rows.Add(dtRow_money)

        '--------------------
        ' dataSet作成
        '--------------------
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        ds.Tables.Add(dt_money)

        For tableCount As Integer = 0 To ds.Tables.Count - 1
            For rowIndex As Integer = 0 To ds.Tables(tableCount).Rows.Count - 1
                For colIndex As Integer = 0 To ds.Tables(tableCount).Columns.Count - 1
                    Console.Write(ds.Tables(tableCount).Rows(rowIndex).Item(colIndex).ToString)
                Next
                Console.WriteLine()
            Next
        Next
    End Sub
End Class

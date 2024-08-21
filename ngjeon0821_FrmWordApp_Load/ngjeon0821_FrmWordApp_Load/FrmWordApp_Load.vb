Public Class FrmWordApp_Load
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCount.Click

    End Sub

    Private Sub FrmWordApp_Load_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim arr_question As String() = {"リンゴ", "学校", "鉛筆", "机", "鞄", "本", "部屋", "コップ", "椅子", "頭"}
        Dim arr_answer As String() = {"apple", "school", "pencil", "desk", "bag", "book", "room", "cup", "chair", "head"}
        Dim int_count As Integer = 1

        '初期値
        lblCount.Text = int_count.ToString
        lblQuestion.Text = arr_question(int_count - 1)
        txtAnswer.Text = ""
        lblAnswer.Text = arr_answer(int_count - 1)
        lblGood.Text = ""

        '表示 非表示
        lblAnswer.Visible = False
        lblGood.Visible = False

        '使用可否
        If int_count = 1 Then
            btnBefore.Enabled = False
        Else
            btnBefore.Enabled = True
        End If

        If int_count = 10 Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If


    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        '正解判定
        If txtAnswer.Text = lblAnswer.Text Then
            lblGood.Text = "〇"
            lblGood.ForeColor = Color.Blue
        Else
            lblGood.Text = "×"
            lblGood.ForeColor = Color.Red
        End If

        '表示 非表示
        lblAnswer.Visible = True
        lblGood.Visible = True
    End Sub

    Private Sub btnBefore_Click(sender As Object, e As EventArgs) Handles btnBefore.Click

        Dim arr_question As String() = {"リンゴ", "学校", "鉛筆", "机", "鞄", "本", "部屋", "コップ", "椅子", "頭"}
        Dim arr_answer As String() = {"apple", "school", "pencil", "desk", "bag", "book", "room", "cup", "chair", "head"}
        Dim int_count As Integer = CInt(lblCount.Text) - 1

        '初期値
        lblCount.Text = int_count.ToString
        lblQuestion.Text = arr_question(int_count - 1)
        txtAnswer.Text = ""
        lblAnswer.Text = arr_answer(int_count - 1)
        lblGood.Text = ""

        '表示 非表示
        lblAnswer.Visible = False
        lblGood.Visible = False

        '使用可否
        If int_count = 1 Then
            btnBefore.Enabled = False
        Else
            btnBefore.Enabled = True
        End If

        If int_count = 10 Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Dim arr_question As String() = {"リンゴ", "学校", "鉛筆", "机", "鞄", "本", "部屋", "コップ", "椅子", "頭"}
        Dim arr_answer As String() = {"apple", "school", "pencil", "desk", "bag", "book", "room", "cup", "chair", "head"}
        Dim int_count As Integer = CInt(lblCount.Text) + 1

        '初期値
        lblCount.Text = int_count.ToString
        lblQuestion.Text = arr_question(int_count - 1)
        txtAnswer.Text = ""
        lblAnswer.Text = arr_answer(int_count - 1)
        lblGood.Text = ""

        '表示 非表示
        lblAnswer.Visible = False
        lblGood.Visible = False

        '使用可否
        If int_count = 1 Then
            btnBefore.Enabled = False
        Else
            btnBefore.Enabled = True
        End If

        If int_count = 10 Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If

    End Sub
End Class

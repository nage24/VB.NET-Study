Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNg.Click
        Dim a As String
        a = txtNg.Text

        If a = "1" Then

            lblNg2.Text = "5"

        ElseIf a = "2" Then

            lblNg2.Text = "10"

        Else

            lblNg2.Text = "なし"

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblNg2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblNg.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

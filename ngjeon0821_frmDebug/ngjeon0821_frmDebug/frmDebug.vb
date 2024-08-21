Public Class frmDebug
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim int_a As Integer = 10
        Dim int_b As Integer = 30
        Dim int_c As Integer = 0
        Dim int_d As Integer = 0

        int_c = int_a * 2

        int_d = int_a + int_b + int_c

        Console.WriteLine(int_d)

    End Sub
End Class

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t As New ClassLibrary1.Hello
        MessageBox.Show(t.HelloWorld, "test", MessageBoxButtons.OK)
    End Sub
End Class

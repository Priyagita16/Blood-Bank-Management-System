Public Class Form13
    Private Sub ContinueLbl_Click(sender As Object, e As EventArgs) Handles ContinueLbl.Click
        Dim log As New Form2()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (PassTb.Text = "") Then
            MessageBox.Show("Enter Admin Password")
        ElseIf (PassTb.Text = "password") Then
            Dim log As New Form1()
            log.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Password. Contact the System Admin")
            PassTb.Text = ""
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
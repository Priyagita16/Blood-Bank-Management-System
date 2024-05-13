Imports System.Data.SqlClient
Imports Windows.Win32.System
Public Class Form2
    Private connectionString As String = "Data Source=HP-BNU44S\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False"


    Private Sub ContinueLbl_Click(sender As Object, e As EventArgs) Handles ContinueLbl.Click
        Dim log As New Form13()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sda As New SqlDataAdapter("SELECT COUNT(*) FROM EmployeeTbl WHERE EmpId='" & EmpIdTb.Text & "' AND EmpPass='" & PassTb.Text & "'", connection)
            Dim dt As New DataTable()
            sda.Fill(dt)

            If dt.Rows(0)(0).ToString() = "1" Then
                Dim mainForm As New Form3()
                mainForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Wrong Username or Password")
            End If

        End Using

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
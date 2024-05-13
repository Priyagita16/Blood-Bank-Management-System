Imports System.Data.SqlClient

Public Class Form8
    Private connectionString As String = "Data Source=HP-BNU44S\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False"

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bloodstock()

    End Sub
    Private Sub Bloodstock()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' SQL command to select all donors
                Dim query As String = "SELECT * FROM BloodTbl"

                Using adapter As New SqlDataAdapter(query, connection)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Display donor records in the DataGridView
                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error loading blood stock records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim log As New Form12()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim log As New Form4()
        log.Show()
        Me.Hide()
    End Sub


    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim log As New Form6()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim log As New Form7()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim log As New Form5()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim log As New Form9()
        log.Show()
        Me.Hide()
    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim log As New Form10()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim log As New Form2()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub
End Class
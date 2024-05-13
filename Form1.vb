Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Logging

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmpRecords()

    End Sub

    Private Sub LoadEmpRecords()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM EmployeeTbl"

                Using adapter As New SqlDataAdapter(query, connection)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception

            MessageBox.Show("Error loading donor records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private connectionString As String = "Data Source=HP-BNU44S\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False"
    Private Sub ResetFunc()
        EmpNameTb.Text = ""
        PassTb.Text = ""
        key = "0"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (EmpNameTb.Text = "" Or PassTb.Text = "") Then
            MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Using connection As New SqlConnection(connectionString)

                    connection.Open()
                    Dim query As String = "INSERT INTO EmployeeTbl values ('" + EmpNameTb.Text + "','" + PassTb.Text + "')"
                    Using command As New SqlCommand(query, connection)
                        command.ExecuteNonQuery()

                    End Using
                End Using
                MessageBox.Show("Employee Successfully Saved")
                ResetFunc()
                LoadEmpRecords()

            Catch ex As Exception
                MessageBox.Show("Error inserting donor record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If

    End Sub


    Dim key As String = "0"

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then

            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            EmpNameTb.Text = selectedRow.Cells("EmpId").Value.ToString()
            PassTb.Text = selectedRow.Cells("EmpPass").Value.ToString()
            If (EmpNameTb.Text = "") Then
                key = "0"
            Else
                key = selectedRow.Cells("EmpNum").Value.ToString()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (key = "0") Then
            MessageBox.Show("Select Employee record to be deleted")
        Else
            Try
                Using connection As New SqlConnection(connectionString)

                    connection.Open()
                    Dim query As String = "Delete FROM EmployeeTbl where EmpNum='" + key + "';"
                    Using command As New SqlCommand(query, connection)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Employee record succesfully deleted")

                    End Using
                End Using
                ResetFunc()
                LoadEmpRecords()

            Catch ex As Exception
                MessageBox.Show("An Unknown Error occurred : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (EmpNameTb.Text = "" Or PassTb.Text = "") Then
            MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Using connection As New SqlConnection(connectionString)

                    connection.Open()
                    Dim query As String = "UPDATE EmployeeTbl SET EmpId='" + EmpNameTb.Text + "',EmpPass='" + PassTb.Text + "' where EmpNum=" + key + ";"
                    Using command As New SqlCommand(query, connection)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Employee record succesfully updated")

                    End Using
                End Using
                ResetFunc()
                LoadEmpRecords()

            Catch ex As Exception
                MessageBox.Show("An Unknown Error occurred : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try


        End If
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim log As New Form2()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub
End Class


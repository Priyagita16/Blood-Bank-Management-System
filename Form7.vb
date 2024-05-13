Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.CompilerServices

Public Class Form7
    Private connectionString As String = "Data Source=HP-BNU44S\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False"

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatientRecords()
    End Sub
    Private Sub LoadPatientRecords()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' SQL command to select all donors
                Dim query As String = "SELECT * FROM PatientTbl"

                Using adapter As New SqlDataAdapter(query, connection)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Display donor records in the DataGridView
                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error loading donor records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Dim key As String

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then

            ' Get the data from the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            PNameTb.Text = selectedRow.Cells("PName").Value.ToString()
            PAgeTb.Text = selectedRow.Cells("PAge").Value.ToString()
            PGenderCb.SelectedItem = selectedRow.Cells("PGender").Value.ToString()
            PPhoneTb.Text = selectedRow.Cells("PPhone").Value.ToString()
            PBGroupCb.SelectedItem = selectedRow.Cells("PBGroup").Value.ToString()
            PAddressTb.Text = selectedRow.Cells("PAddress").Value.ToString()
            PEmailTb.Text = selectedRow.Cells("PEmail").Value.ToString()
            If (PNameTb.Text = "") Then
                key = "0"
            Else
                key = selectedRow.Cells("PNum").Value.ToString()
            End If
        End If
    End Sub
    Private Sub ResetFunc()
        PNameTb.Text = ""
        PAgeTb.Text = ""
        PPhoneTb.Text = ""
        PAddressTb.Text = ""
        PGenderCb.SelectedIndex = -1
        PBGroupCb.SelectedIndex = -1
        PEmailTb.Text = ""
        key = "0"

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (key = "0") Then
            MessageBox.Show("Select Patient record to be deleted")
        Else
            Try
                Using connection As New SqlConnection(connectionString)

                    connection.Open()
                    Dim query As String = "Delete FROM PatientTbl where PNum='" + key + "';"
                    Using command As New SqlCommand(query, connection)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Patient record succesfully deleted")

                    End Using
                End Using
                ResetFunc()
                LoadPatientRecords()

            Catch ex As Exception
                MessageBox.Show("An Unknown Error occurred : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try


        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (PNameTb.Text = "" Or PAgeTb.Text = "" Or PPhoneTb.Text = "" Or PGenderCb.SelectedIndex = -1 Or PBGroupCb.SelectedIndex = -1 Or PAddressTb.Text = "" Or PEmailTb.Text = "") Then
            MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Using connection As New SqlConnection(connectionString)

                    connection.Open()
                    Dim query As String = "UPDATE PatientTbl SET PName='" + PNameTb.Text + "',PAge=" + PAgeTb.Text + ",PPhone='" + PPhoneTb.Text + "',PGender='" + PGenderCb.SelectedItem.ToString() + "',PBGroup='" + PBGroupCb.SelectedItem.ToString() + "',PAddress='" + PAddressTb.Text + "',PEmail='" + PEmailTb.Text + "' where PNum=" + key + ";"
                    Using command As New SqlCommand(query, connection)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Patient record succesfully updated")

                    End Using
                End Using
                ResetFunc()
                LoadPatientRecords()

            Catch ex As Exception
                MessageBox.Show("An Unknown Error occurred : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try


        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim log As New Form12()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim log As New Form6()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Dim log As New Form12()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim log As New Form8()
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

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Application.Exit()
    End Sub
End Class

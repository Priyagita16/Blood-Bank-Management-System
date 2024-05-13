Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Windows.Forms
Partial Public Class Form6

    Private connectionString As String = "Data Source=HP-BNU44S\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False"
    Private Sub ResetFunc()
        PNameTb.Text = ""
        PAgeTb.Text = ""
        PPhoneTb.Text = ""
        PAddressTb.Text = ""
        PGenderCb.SelectedIndex = -1
        PBGroupCb.SelectedIndex = -1
        PEmailTb.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If InsertPatient() Then
            MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Failed to add patient. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Dim R As Boolean
    Private Function InsertPatient() As Boolean
        If (PNameTb.Text = "" Or PAgeTb.Text = "" Or PPhoneTb.Text = "" Or PGenderCb.SelectedIndex = -1 Or PBGroupCb.SelectedIndex = -1 Or PAddressTb.Text = "" Or PEmailTb.Text = "") Then
            MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Using connection As New SqlConnection(connectionString)

                    connection.Open()
                    Dim query As String = "INSERT INTO PatientTbl values ('" + PNameTb.Text + "'," + PAgeTb.Text + ",'" + PPhoneTb.Text + "','" + PGenderCb.SelectedItem.ToString() + "','" + PBGroupCb.SelectedItem.ToString() + "','" + PAddressTb.Text + "','" + PEmailTb.Text + "')"
                    Using command As New SqlCommand(query, connection)
                        command.ExecuteNonQuery()

                    End Using
                End Using
                ResetFunc()

                R = True

            Catch ex As Exception
                MessageBox.Show("Error inserting patient record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                R = False
            End Try
        End If
        Return R
    End Function

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim log As New Form5()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim log As New Form4()
        log.Show()
        Me.Hide()
    End Sub


    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Dim log As New Form12()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim log As New Form7()
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

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Application.Exit()
    End Sub
End Class

Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Windows.Forms
Partial Public Class Form4

    Private connectionString As String = "Data Source=HP-BNU44S\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False"
    Private Sub ResetFunc()
        NameTb.Text = ""
        AgeTb.Text = ""
        PhoneTb.Text = ""
        AddressTb.Text = ""
        GenderCb.SelectedIndex = -1
        BGroupCb.SelectedIndex = -1
        EmailTb.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If InsertDonor() Then
            MessageBox.Show("Donor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Failed to add donor. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Dim R As Boolean
    Private Function InsertDonor() As Boolean
        If (NameTb.Text = "" Or AgeTb.Text = "" Or PhoneTb.Text = "" Or GenderCb.SelectedIndex = -1 Or BGroupCb.SelectedIndex = -1 Or AddressTb.Text = "" Or EmailTb.Text = "") Then
            MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Using connection As New SqlConnection(connectionString)

                    connection.Open()
                    Dim query As String = "INSERT INTO DonorTbl values ('" + NameTb.Text + "'," + AgeTb.Text + ",'" + GenderCb.SelectedItem.ToString() + "','" + PhoneTb.Text + "','" + AddressTb.Text + "','" + BGroupCb.SelectedItem.ToString() + "','" + EmailTb.Text + "')"
                    Using command As New SqlCommand(query, connection)
                        command.ExecuteNonQuery()

                    End Using
                End Using
                ResetFunc()

                R = True

            Catch ex As Exception
                MessageBox.Show("Error inserting donor record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                R = False
            End Try
        End If
        Return R
    End Function

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Dim log As New Form12()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim log As New Form5()
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

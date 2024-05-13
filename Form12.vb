Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Windows.Win32.System
Public Class Form12
    Private connectionString As String = "Data Source=HP-BNU44S\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False"

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDonorRecords()
        Bloodstock()
    End Sub
    Private Sub LoadDonorRecords()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' SQL command to select all donors
                Dim query As String = "SELECT * FROM DonorTbl"

                Using adapter As New SqlDataAdapter(query, connection)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Display donor records in the DataGridView
                    DataGridView2.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error loading donor records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
    Dim oldstock As Integer
    Private Sub GetStock(BGroup As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM BloodTbl where BGroup='" + BGroup + "';"

                Dim cmd As New SqlCommand(query, connection)
                Dim dt As New DataTable()
                Dim sda As New SqlDataAdapter(cmd)
                sda.Fill(dt)

                For Each dr As DataRow In dt.Rows
                    oldstock = Convert.ToInt32(dr("BStock"))
                Next


            End Using
        Catch ex As Exception
            MessageBox.Show("An Unknown Error occurred : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then

            Dim selectedRow As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
            DNameTb.Text = selectedRow.Cells("DName").Value.ToString()
            DBGroupTb.Text = selectedRow.Cells("DBGroup").Value.ToString()
            GetStock(DBGroupTb.Text)
        End If
    End Sub
    Private Sub ResetFunc()
        DNameTb.Text = ""
        DBGroupTb.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (DNameTb.Text = "") Then
            MessageBox.Show("Select a Donor")
        Else
            Try
                Using connection As New SqlConnection(connectionString)
                    Dim stock As String = Convert.ToString(oldstock + 1)

                    connection.Open()
                    Dim query As String = "UPDATE BloodTbl SET BStock='" + stock + "'where BGroup='" + DBGroupTb.Text + "';"
                    Using command As New SqlCommand(query, connection)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Donation Successful!")

                    End Using
                End Using
                ResetFunc()
                Bloodstock()
            Catch ex As Exception
                MessageBox.Show("An Unknown Error occurred : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim log As New Form4()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim log As New Form5()
        log.Show()
        Me.Hide()
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
End Class

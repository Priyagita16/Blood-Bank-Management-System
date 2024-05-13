Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillPIDCb()
    End Sub
    Dim Con As New SqlConnection("Data Source=HP-BNU44S\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False")
    Private Sub FillPIDCb()
        Con.Open()
        Dim cmd As New SqlCommand("SELECT PNum FROM PatientTbl", Con)
        Dim rdr As SqlDataReader
        rdr = cmd.ExecuteReader()
        Dim dt As New DataTable()
        dt.Columns.Add("PNum", GetType(Integer))
        dt.Load(rdr)
        PIDCb.ValueMember = "PNum"
        PIDCb.DataSource = dt
        Con.Close()
    End Sub
    Private Sub GetData()
        Dim connectionString As String = "Data Source=HP-BNU44S\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False"
        Dim query As String = "SELECT * FROM PatientTbl WHERE PNum = @PNum;"

        Using Con As New SqlConnection(connectionString)
            Con.Open()
            Using cmd As New SqlCommand(query, Con)
                ' Use parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@PNum", PIDCb.SelectedValue)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            PNameTb.Text = reader("PName").ToString()
                            PBGroupTb.Text = reader("PBGroup").ToString()
                        End While
                    End If
                End Using
            End Using
        End Using
        Con.Close()

    End Sub
    Dim stock As Integer = 0
    Private Sub GetStock(BGroup As String)
        Con.Open()
        Dim query As String = "SELECT * FROM BloodTbl where BGroup='" + BGroup + "';"

        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable()
        Dim sda As New SqlDataAdapter(cmd)
        sda.Fill(dt)

        For Each dr As DataRow In dt.Rows
            stock = Convert.ToInt32(dr("BStock").ToString())
        Next
        Con.Close()

    End Sub
    Private Sub PIDCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles PIDCb.SelectionChangeCommitted
        GetData()
        GetStock(PBGroupTb.Text)
        If (stock > 0) Then
            Button1.Visible = True
            AvailableLbl.Text = "Stock Available"
            AvailableLbl.Visible = True
        Else
            AvailableLbl.Text = "Stock Not Available"
            AvailableLbl.Visible = True
        End If
    End Sub
    Private Sub ResetFunc()
        PNameTb.Text = ""
        PBGroupTb.Text = ""
        AvailableLbl.Visible = False
        Button1.Visible = False
    End Sub
    Private Sub UpdateStock()
        Try
            Dim newstock As String = Convert.ToString(stock - 1)
            Con.Open()
            Dim query = "UPDATE BloodTbl SET BStock='" + newstock + "' where BGroup='" + PBGroupTb.Text + "';"
            Using command = New SqlCommand(query, Con)
                command.ExecuteNonQuery()
                MessageBox.Show("Blood inventory succesfully updated")

            End Using
            Con.Close()



        Catch ex As Exception
            MessageBox.Show("An Unknown Error occurred : " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (PNameTb.Text = "") Then
            MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Con.Open()
                Dim query As String = "INSERT INTO TransferTbl values ('" + PNameTb.Text + "','" + PBGroupTb.Text + "')"
                Using command As New SqlCommand(query, Con)
                    command.ExecuteNonQuery()

                End Using
                MessageBox.Show("Transfer Successful!")
                Con.Close()
                GetStock(PBGroupTb.Text)
                UpdateStock()
                ResetFunc()


            Catch ex As Exception
                MessageBox.Show("Error occurred in transfer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

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

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim log As New Form8()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim log As New Form5()
        log.Show()
        Me.Hide()
    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim log As New Form10()
        log.Show()
        Me.Hide()
    End Sub
    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Dim log As New Form12()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim log As New Form2()
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Application.Exit()
    End Sub
End Class
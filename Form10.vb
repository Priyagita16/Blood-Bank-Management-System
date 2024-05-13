Imports System.Data.SqlClient

Public Class Form10

    Private connectionString As String = "Data Source=HP-BNU44S\SQLEXPRESS;Initial Catalog=bloodbank;Integrated Security=True;Encrypt=False"
    Private Sub GetData()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sda As New SqlDataAdapter("SELECT COUNT(*) FROM DonorTbl", connection)
            Dim dt As New DataTable()
            sda.Fill(dt)
            Label4.Text = dt.Rows(0)(0).ToString()
        End Using
    End Sub

    Private Sub GetData1()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sda1 As New SqlDataAdapter("SELECT COUNT(*) FROM TransferTbl", connection)
            Dim dt1 As New DataTable()
            sda1.Fill(dt1)
            Label14.Text = dt1.Rows(0)(0).ToString()
        End Using
    End Sub

    Private Sub GetData2()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sda2 As New SqlDataAdapter("SELECT COUNT(*) FROM EmployeeTbl", connection)
            Dim dt2 As New DataTable()
            sda2.Fill(dt2)
            Label5.Text = dt2.Rows(0)(0).ToString()
        End Using
    End Sub

    Private Sub GetData3()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sda3 As New SqlDataAdapter("SELECT SUM(BStock) FROM BloodTbl", connection)
            Dim dt3 As New DataTable()
            sda3.Fill(dt3)
            Dim Bstock As Integer = Convert.ToInt32(dt3.Rows(0)(0).ToString())
            TotalLbl.Text = "Total=" + Bstock.ToString
        End Using
    End Sub


    Private Sub GetData4()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sda4 As New SqlDataAdapter("SELECT BStock FROM BloodTbl where BGroup='" + "A+" + "'", connection)
            Dim dt4 As New DataTable()
            sda4.Fill(dt4)
            No1.Text = dt4.Rows(0)(0).ToString()
        End Using
    End Sub


    Private Sub GetData5()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sda5 As New SqlDataAdapter("SELECT BStock FROM BloodTbl where BGroup='" + "A-" + "'", connection)
            Dim dt5 As New DataTable()
            sda5.Fill(dt5)
            No2.Text = dt5.Rows(0)(0).ToString()
        End Using
    End Sub


    Private Sub GetData6()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sda6 As New SqlDataAdapter("SELECT BStock FROM BloodTbl where BGroup='" + "B+" + "'", connection)
            Dim dt6 As New DataTable()
            sda6.Fill(dt6)
            No3.Text = dt6.Rows(0)(0).ToString()
        End Using
    End Sub


    Private Sub GetData7()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sda7 As New SqlDataAdapter("SELECT BStock FROM BloodTbl where BGroup='" + "B-" + "'", connection)
            Dim dt7 As New DataTable()
            sda7.Fill(dt7)
            No4.Text = dt7.Rows(0)(0).ToString()
        End Using
    End Sub


    Private Sub GetData8()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sda8 As New SqlDataAdapter("SELECT BStock FROM BloodTbl where BGroup='" + "O+" + "'", connection)
            Dim dt8 As New DataTable()
            sda8.Fill(dt8)
            No5.Text = dt8.Rows(0)(0).ToString()
        End Using
    End Sub


    Private Sub GetData9()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sda9 As New SqlDataAdapter("SELECT BStock FROM BloodTbl where BGroup='" + "O-" + "'", connection)
            Dim dt9 As New DataTable()
            sda9.Fill(dt9)
            No6.Text = dt9.Rows(0)(0).ToString()
        End Using
    End Sub


    Private Sub GetData10()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sda10 As New SqlDataAdapter("SELECT BStock FROM BloodTbl where BGroup='" + "AB+" + "'", connection)
            Dim dt10 As New DataTable()
            sda10.Fill(dt10)
            No7.Text = dt10.Rows(0)(0).ToString()
        End Using
    End Sub


    Private Sub GetData11()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim sda11 As New SqlDataAdapter("SELECT BStock FROM BloodTbl where BGroup='" + "AB-" + "'", connection)
            Dim dt11 As New DataTable()
            sda11.Fill(dt11)
            No8.Text = dt11.Rows(0)(0).ToString()
        End Using
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
        GetData1()
        GetData2()
        GetData3()
        GetData4()
        GetData5()
        GetData6()
        GetData7()
        GetData8()
        GetData9()
        GetData10()
        GetData11()
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

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Application.Exit()
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim log As New Form2()
        log.Show()
        Me.Hide()
    End Sub


End Class


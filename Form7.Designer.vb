<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Button1 = New Button()
        PBGroupCb = New ComboBox()
        PGenderCb = New ComboBox()
        PPhoneTb = New TextBox()
        Label17 = New Label()
        PAddressTb = New TextBox()
        Label16 = New Label()
        PAgeTb = New TextBox()
        Label15 = New Label()
        Label1 = New Label()
        Label14 = New Label()
        PEmailTb = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        PNameTb = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        Label18 = New Label()
        Panel10 = New Panel()
        Label12 = New Label()
        Panel8 = New Panel()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label13 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Panel9 = New Panel()
        Panel7 = New Panel()
        Panel6 = New Panel()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Label19 = New Label()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(509, 176)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 36)
        Button1.TabIndex = 63
        Button1.Text = "EDIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PBGroupCb
        ' 
        PBGroupCb.BackColor = SystemColors.GradientInactiveCaption
        PBGroupCb.FormattingEnabled = True
        PBGroupCb.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-"})
        PBGroupCb.Location = New Point(684, 137)
        PBGroupCb.Name = "PBGroupCb"
        PBGroupCb.Size = New Size(126, 23)
        PBGroupCb.TabIndex = 62
        ' 
        ' PGenderCb
        ' 
        PGenderCb.BackColor = SystemColors.GradientInactiveCaption
        PGenderCb.FormattingEnabled = True
        PGenderCb.Items.AddRange(New Object() {"MALE", "FEMALE", "OTHER"})
        PGenderCb.Location = New Point(684, 94)
        PGenderCb.Name = "PGenderCb"
        PGenderCb.Size = New Size(126, 23)
        PGenderCb.TabIndex = 61
        ' 
        ' PPhoneTb
        ' 
        PPhoneTb.BackColor = SystemColors.GradientInactiveCaption
        PPhoneTb.Location = New Point(263, 137)
        PPhoneTb.Name = "PPhoneTb"
        PPhoneTb.Size = New Size(158, 23)
        PPhoneTb.TabIndex = 60
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(263, 120)
        Label17.Name = "Label17"
        Label17.Size = New Size(71, 15)
        Label17.TabIndex = 59
        Label17.Text = "PHONE NO:"
        ' 
        ' PAddressTb
        ' 
        PAddressTb.BackColor = SystemColors.GradientInactiveCaption
        PAddressTb.Location = New Point(264, 182)
        PAddressTb.Multiline = True
        PAddressTb.Name = "PAddressTb"
        PAddressTb.Size = New Size(157, 26)
        PAddressTb.TabIndex = 58
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(263, 163)
        Label16.Name = "Label16"
        Label16.Size = New Size(59, 15)
        Label16.TabIndex = 57
        Label16.Text = "ADDRESS:"
        ' 
        ' PAgeTb
        ' 
        PAgeTb.BackColor = SystemColors.GradientInactiveCaption
        PAgeTb.Location = New Point(477, 94)
        PAgeTb.Name = "PAgeTb"
        PAgeTb.Size = New Size(158, 23)
        PAgeTb.TabIndex = 56
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(477, 76)
        Label15.Name = "Label15"
        Label15.Size = New Size(32, 15)
        Label15.TabIndex = 55
        Label15.Text = "AGE:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(242, -2)
        Label1.Name = "Label1"
        Label1.Size = New Size(412, 36)
        Label1.TabIndex = 2
        Label1.Text = "BLOOD BANK MANAGEMENT SYSTEM"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(477, 120)
        Label14.Name = "Label14"
        Label14.Size = New Size(58, 15)
        Label14.TabIndex = 54
        Label14.Text = "EMAIL ID:"
        ' 
        ' PEmailTb
        ' 
        PEmailTb.BackColor = SystemColors.GradientInactiveCaption
        PEmailTb.Location = New Point(477, 137)
        PEmailTb.Name = "PEmailTb"
        PEmailTb.Size = New Size(158, 23)
        PEmailTb.TabIndex = 53
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(684, 120)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 15)
        Label5.TabIndex = 52
        Label5.Text = "BLOOD GROUP:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(684, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 15)
        Label4.TabIndex = 51
        Label4.Text = "GENDER:"
        ' 
        ' PNameTb
        ' 
        PNameTb.BackColor = SystemColors.GradientInactiveCaption
        PNameTb.Location = New Point(263, 94)
        PNameTb.Name = "PNameTb"
        PNameTb.Size = New Size(158, 23)
        PNameTb.TabIndex = 50
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(263, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 15)
        Label3.TabIndex = 49
        Label3.Text = "NAME:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(458, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(178, 32)
        Label2.TabIndex = 48
        Label2.Text = "PATIENTS LIST"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Red
        Panel3.Controls.Add(Label18)
        Panel3.Controls.Add(Panel10)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(Panel8)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(Panel1)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Panel9)
        Panel3.Controls.Add(Panel7)
        Panel3.Controls.Add(Panel6)
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 34)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(216, 519)
        Panel3.TabIndex = 47
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.White
        Label18.Location = New Point(42, 160)
        Label18.Name = "Label18"
        Label18.Size = New Size(102, 23)
        Label18.TabIndex = 20
        Label18.Text = "Donation"
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Firebrick
        Panel10.Location = New Point(26, 160)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(10, 27)
        Panel10.TabIndex = 19
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(42, 208)
        Label12.Name = "Label12"
        Label12.Size = New Size(81, 23)
        Label12.TabIndex = 9
        Label12.Text = "Patient"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Firebrick
        Panel8.Location = New Point(26, 116)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(10, 27)
        Panel8.TabIndex = 15
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Firebrick
        Panel5.Location = New Point(26, 299)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(10, 27)
        Panel5.TabIndex = 12
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Firebrick
        Panel4.Location = New Point(26, 351)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(10, 27)
        Panel4.TabIndex = 11
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Firebrick
        Panel1.Location = New Point(26, 21)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(10, 27)
        Panel1.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(42, 438)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(42, 38)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.White
        Label13.Location = New Point(42, 116)
        Label13.Name = "Label13"
        Label13.Size = New Size(136, 23)
        Label13.TabIndex = 10
        Label13.Text = "View Donors"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Firebrick
        Label11.Font = New Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(42, 255)
        Label11.Name = "Label11"
        Label11.Size = New Size(144, 23)
        Label11.TabIndex = 8
        Label11.Text = "View Patients"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(42, 299)
        Label10.Name = "Label10"
        Label10.Size = New Size(127, 23)
        Label10.TabIndex = 7
        Label10.Text = "Blood Stock"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(90, 445)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 23)
        Label6.TabIndex = 6
        Label6.Text = "Logout"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(42, 68)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 23)
        Label7.TabIndex = 5
        Label7.Text = "Donor"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(42, 351)
        Label8.Name = "Label8"
        Label8.Size = New Size(158, 23)
        Label8.TabIndex = 4
        Label8.Text = "Blood Transfer"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(42, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(118, 23)
        Label9.TabIndex = 3
        Label9.Text = "Dashboard"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Firebrick
        Panel9.Location = New Point(26, 68)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(10, 27)
        Panel9.TabIndex = 16
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Firebrick
        Panel7.Location = New Point(26, 208)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(10, 27)
        Panel7.TabIndex = 14
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Firebrick
        Panel6.Location = New Point(26, 255)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(190, 27)
        Panel6.TabIndex = 13
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RoyalBlue
        Panel2.Controls.Add(Label19)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(889, 34)
        Panel2.TabIndex = 46
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(264, 233)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(546, 308)
        DataGridView1.TabIndex = 64
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.OrangeRed
        Button2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(684, 176)
        Button2.Name = "Button2"
        Button2.Size = New Size(126, 36)
        Button2.TabIndex = 65
        Button2.Text = "DELETE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.WhiteSmoke
        Label19.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(858, 9)
        Label19.Name = "Label19"
        Label19.Size = New Size(19, 18)
        Label19.TabIndex = 66
        Label19.Text = "x"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(889, 553)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(PBGroupCb)
        Controls.Add(PGenderCb)
        Controls.Add(PPhoneTb)
        Controls.Add(Label17)
        Controls.Add(PAddressTb)
        Controls.Add(Label16)
        Controls.Add(PAgeTb)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(PEmailTb)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(PNameTb)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form7"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PBGroupCb As ComboBox
    Friend WithEvents PGenderCb As ComboBox
    Friend WithEvents PPhoneTb As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents PAddressTb As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents PAgeTb As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PEmailTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PNameTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label19 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel3 = New Panel()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Label9 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        EmpNameTb = New TextBox()
        Label15 = New Label()
        Label4 = New Label()
        PassTb = New TextBox()
        Button3 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Label3 = New Label()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Red
        Panel3.Controls.Add(Panel1)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label9)
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 34)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(216, 480)
        Panel3.TabIndex = 36
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Firebrick
        Panel1.Location = New Point(26, 20)
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
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(42, 20)
        Label9.Name = "Label9"
        Label9.Size = New Size(118, 23)
        Label9.TabIndex = 3
        Label9.Text = "Employees"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RoyalBlue
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(873, 34)
        Panel2.TabIndex = 35
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
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(343, 89)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(360, 259)
        DataGridView1.TabIndex = 67
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(446, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 32)
        Label2.TabIndex = 66
        Label2.Text = "EMPLOYEES"
        ' 
        ' EmpNameTb
        ' 
        EmpNameTb.BackColor = SystemColors.GradientInactiveCaption
        EmpNameTb.ForeColor = SystemColors.MenuText
        EmpNameTb.Location = New Point(321, 393)
        EmpNameTb.Name = "EmpNameTb"
        EmpNameTb.Size = New Size(183, 23)
        EmpNameTb.TabIndex = 71
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(321, 375)
        Label15.Name = "Label15"
        Label15.Size = New Size(44, 15)
        Label15.TabIndex = 70
        Label15.Text = "NAME:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(553, 375)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 69
        Label4.Text = "PASSWORD:"
        ' 
        ' PassTb
        ' 
        PassTb.BackColor = SystemColors.GradientInactiveCaption
        PassTb.ForeColor = SystemColors.MenuText
        PassTb.Location = New Point(553, 393)
        PassTb.Name = "PassTb"
        PassTb.Size = New Size(183, 23)
        PassTb.TabIndex = 68
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Button3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(285, 440)
        Button3.Name = "Button3"
        Button3.Size = New Size(129, 35)
        Button3.TabIndex = 74
        Button3.Text = "SAVE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(644, 440)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 35)
        Button1.TabIndex = 75
        Button1.Text = "DELETE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Lime
        Button2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(465, 440)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 35)
        Button2.TabIndex = 76
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(842, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(19, 18)
        Label3.TabIndex = 77
        Label3.Text = "x"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(873, 514)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Button3)
        Controls.Add(EmpNameTb)
        Controls.Add(Label15)
        Controls.Add(Label4)
        Controls.Add(PassTb)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents EmpNameTb As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PassTb As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
End Class

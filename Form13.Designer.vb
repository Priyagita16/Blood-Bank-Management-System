<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form13))
        Label1 = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        PassTb = New TextBox()
        Label3 = New Label()
        ContinueLbl = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(456, 39)
        Label1.TabIndex = 3
        Label1.Text = "BLOOD BANK MANAGEMENT SYSTEM"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.GhostWhite
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PassTb)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(111, 94)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(257, 161)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(99, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(57, 58)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Dock = DockStyle.Bottom
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(0, 114)
        Button1.Name = "Button1"
        Button1.Size = New Size(255, 45)
        Button1.TabIndex = 4
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PassTb
        ' 
        PassTb.BorderStyle = BorderStyle.FixedSingle
        PassTb.Location = New Point(99, 83)
        PassTb.Name = "PassTb"
        PassTb.PasswordChar = "*"c
        PassTb.Size = New Size(138, 23)
        PassTb.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(14, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 16)
        Label3.TabIndex = 2
        Label3.Text = "Password:"
        ' 
        ' ContinueLbl
        ' 
        ContinueLbl.AutoSize = True
        ContinueLbl.BackColor = Color.Transparent
        ContinueLbl.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        ContinueLbl.ForeColor = SystemColors.ButtonHighlight
        ContinueLbl.Location = New Point(211, 257)
        ContinueLbl.Name = "ContinueLbl"
        ContinueLbl.Size = New Size(56, 16)
        ContinueLbl.TabIndex = 4
        ContinueLbl.Text = "Cancel"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(450, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(19, 18)
        Label2.TabIndex = 6
        Label2.Text = "x"
        ' 
        ' Form13
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(481, 307)
        Controls.Add(Label2)
        Controls.Add(ContinueLbl)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form13"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form13"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PassTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ContinueLbl As Label
    Friend WithEvents Label2 As Label
End Class

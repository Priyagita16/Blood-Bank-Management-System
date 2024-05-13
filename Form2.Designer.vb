<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        Button1 = New Button()
        PassTb = New TextBox()
        Label3 = New Label()
        EmpIdTb = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        ContinueLbl = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.GhostWhite
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PassTb)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(EmpIdTb)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(111, 89)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(257, 161)
        Panel1.TabIndex = 0
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
        PassTb.Location = New Point(108, 67)
        PassTb.Name = "PassTb"
        PassTb.PasswordChar = "*"c
        PassTb.Size = New Size(129, 23)
        PassTb.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(15, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 16)
        Label3.TabIndex = 2
        Label3.Text = "Password:"
        ' 
        ' EmpIdTb
        ' 
        EmpIdTb.BorderStyle = BorderStyle.FixedSingle
        EmpIdTb.Location = New Point(108, 28)
        EmpIdTb.Name = "EmpIdTb"
        EmpIdTb.Size = New Size(129, 23)
        EmpIdTb.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(15, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 16)
        Label2.TabIndex = 0
        Label2.Text = "Username:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(456, 39)
        Label1.TabIndex = 1
        Label1.Text = "BLOOD BANK MANAGEMENT SYSTEM"
        ' 
        ' ContinueLbl
        ' 
        ContinueLbl.AutoSize = True
        ContinueLbl.BackColor = Color.Transparent
        ContinueLbl.Font = New Font("Mongolian Baiti", 11.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        ContinueLbl.ForeColor = SystemColors.ButtonHighlight
        ContinueLbl.Location = New Point(165, 253)
        ContinueLbl.Name = "ContinueLbl"
        ContinueLbl.Size = New Size(149, 16)
        ContinueLbl.TabIndex = 2
        ContinueLbl.Text = "Continue As Admin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(450, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(19, 18)
        Label4.TabIndex = 6
        Label4.Text = "x"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(481, 307)
        Controls.Add(Label4)
        Controls.Add(ContinueLbl)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PassTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EmpIdTb As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ContinueLbl As Label
    Friend WithEvents Label4 As Label
End Class

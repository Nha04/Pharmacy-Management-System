<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnClear = New Label()
        btnLogin = New Button()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLoginClose = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Perpetua Titling MT", 12F)
        Label1.Location = New Point(17, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 23)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Perpetua Titling MT", 12F)
        Label2.Location = New Point(17, 234)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 23)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Perpetua Titling MT", 13.8F)
        Label3.ForeColor = Color.MidnightBlue
        Label3.Location = New Point(138, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 27)
        Label3.TabIndex = 2
        Label3.Text = "Login"
        ' 
        ' btnClear
        ' 
        btnClear.AutoSize = True
        btnClear.Font = New Font("Perpetua Titling MT", 7.8F, FontStyle.Bold)
        btnClear.Location = New Point(151, 361)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(52, 16)
        btnClear.TabIndex = 3
        btnClear.Text = "Clear"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Silver
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Perpetua Titling MT", 9F)
        btnLogin.ForeColor = Color.ForestGreen
        btnLogin.Location = New Point(132, 320)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.ForestGreen
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 12F)
        txtUsername.ForeColor = Color.White
        txtUsername.Location = New Point(178, 169)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(177, 27)
        txtUsername.TabIndex = 5
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.ForestGreen
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 12F)
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(178, 234)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(177, 27)
        txtPassword.TabIndex = 6
        ' 
        ' btnLoginClose
        ' 
        btnLoginClose.AutoSize = True
        btnLoginClose.Font = New Font("Perpetua Titling MT", 16.2F)
        btnLoginClose.ForeColor = Color.MidnightBlue
        btnLoginClose.Location = New Point(334, 4)
        btnLoginClose.Name = "btnLoginClose"
        btnLoginClose.Size = New Size(35, 33)
        btnLoginClose.TabIndex = 7
        btnLoginClose.Text = "X"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGreen
        ClientSize = New Size(372, 458)
        Controls.Add(btnLoginClose)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(btnLogin)
        Controls.Add(btnClear)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClear As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLoginClose As Label
End Class

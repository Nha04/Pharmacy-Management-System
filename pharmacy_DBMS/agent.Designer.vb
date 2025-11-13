<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agent
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
        Panel1 = New Panel()
        btnAgentClose = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        txtEmployeeID = New TextBox()
        txtEmployeeName = New TextBox()
        txtEmployeeAge = New TextBox()
        txtEmployeePhone = New TextBox()
        txtEmployeePassword = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Panel2 = New Panel()
        btnEmployeeAdd = New Button()
        btnEmployeeEdit = New Button()
        btnEmpBack = New Button()
        btnEmployeeDelete = New Button()
        btnEmpClear = New Button()
        agentView = New DataGridView()
        Label3 = New Label()
        Panel1.SuspendLayout()
        CType(agentView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Green
        Panel1.Controls.Add(btnAgentClose)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1079, 125)
        Panel1.TabIndex = 0
        ' 
        ' btnAgentClose
        ' 
        btnAgentClose.AutoSize = True
        btnAgentClose.Font = New Font("Perpetua Titling MT", 19.8000011F)
        btnAgentClose.ForeColor = Color.MidnightBlue
        btnAgentClose.Location = New Point(1032, 2)
        btnAgentClose.Name = "btnAgentClose"
        btnAgentClose.Size = New Size(43, 41)
        btnAgentClose.TabIndex = 3
        btnAgentClose.Text = "X"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Perpetua Titling MT", 12F)
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(488, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 2
        Label2.Text = "agent"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Perpetua Titling MT", 25.8000011F)
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(350, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(377, 52)
        Label1.TabIndex = 1
        Label1.Text = "PharmaCenter"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Perpetua Titling MT", 12F)
        Label4.Location = New Point(11, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 23)
        Label4.TabIndex = 4
        Label4.Text = "Employee ID"
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.BackColor = Color.ForestGreen
        txtEmployeeID.BorderStyle = BorderStyle.None
        txtEmployeeID.Font = New Font("Segoe UI", 12F)
        txtEmployeeID.ForeColor = Color.White
        txtEmployeeID.Location = New Point(211, 230)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(177, 27)
        txtEmployeeID.TabIndex = 9
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.BackColor = Color.ForestGreen
        txtEmployeeName.BorderStyle = BorderStyle.None
        txtEmployeeName.Font = New Font("Segoe UI", 12F)
        txtEmployeeName.ForeColor = Color.White
        txtEmployeeName.Location = New Point(211, 284)
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.Size = New Size(177, 27)
        txtEmployeeName.TabIndex = 10
        ' 
        ' txtEmployeeAge
        ' 
        txtEmployeeAge.BackColor = Color.ForestGreen
        txtEmployeeAge.BorderStyle = BorderStyle.None
        txtEmployeeAge.Font = New Font("Segoe UI", 12F)
        txtEmployeeAge.ForeColor = Color.White
        txtEmployeeAge.Location = New Point(211, 334)
        txtEmployeeAge.Name = "txtEmployeeAge"
        txtEmployeeAge.Size = New Size(177, 27)
        txtEmployeeAge.TabIndex = 11
        ' 
        ' txtEmployeePhone
        ' 
        txtEmployeePhone.BackColor = Color.ForestGreen
        txtEmployeePhone.BorderStyle = BorderStyle.None
        txtEmployeePhone.Font = New Font("Segoe UI", 12F)
        txtEmployeePhone.ForeColor = Color.White
        txtEmployeePhone.Location = New Point(211, 386)
        txtEmployeePhone.Name = "txtEmployeePhone"
        txtEmployeePhone.Size = New Size(177, 27)
        txtEmployeePhone.TabIndex = 12
        ' 
        ' txtEmployeePassword
        ' 
        txtEmployeePassword.BackColor = Color.ForestGreen
        txtEmployeePassword.BorderStyle = BorderStyle.None
        txtEmployeePassword.Font = New Font("Segoe UI", 12F)
        txtEmployeePassword.ForeColor = Color.White
        txtEmployeePassword.Location = New Point(211, 436)
        txtEmployeePassword.Name = "txtEmployeePassword"
        txtEmployeePassword.Size = New Size(177, 27)
        txtEmployeePassword.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Perpetua Titling MT", 12F)
        Label5.Location = New Point(11, 282)
        Label5.Name = "Label5"
        Label5.Size = New Size(173, 23)
        Label5.TabIndex = 14
        Label5.Text = "employee name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Perpetua Titling MT", 12F)
        Label6.Location = New Point(11, 334)
        Label6.Name = "Label6"
        Label6.Size = New Size(156, 23)
        Label6.TabIndex = 15
        Label6.Text = "employee age"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Perpetua Titling MT", 12F)
        Label7.Location = New Point(11, 386)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 23)
        Label7.TabIndex = 16
        Label7.Text = "phone"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Perpetua Titling MT", 12F)
        Label8.Location = New Point(11, 436)
        Label8.Name = "Label8"
        Label8.Size = New Size(119, 23)
        Label8.TabIndex = 17
        Label8.Text = "password"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Green
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 666)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1079, 25)
        Panel2.TabIndex = 18
        ' 
        ' btnEmployeeAdd
        ' 
        btnEmployeeAdd.BackColor = Color.Silver
        btnEmployeeAdd.FlatStyle = FlatStyle.Flat
        btnEmployeeAdd.Font = New Font("Perpetua Titling MT", 9F)
        btnEmployeeAdd.ForeColor = Color.ForestGreen
        btnEmployeeAdd.Location = New Point(39, 491)
        btnEmployeeAdd.Name = "btnEmployeeAdd"
        btnEmployeeAdd.Size = New Size(72, 44)
        btnEmployeeAdd.TabIndex = 19
        btnEmployeeAdd.Text = "Add"
        btnEmployeeAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEmployeeEdit
        ' 
        btnEmployeeEdit.BackColor = Color.Silver
        btnEmployeeEdit.FlatStyle = FlatStyle.Flat
        btnEmployeeEdit.Font = New Font("Perpetua Titling MT", 9F)
        btnEmployeeEdit.ForeColor = Color.ForestGreen
        btnEmployeeEdit.Location = New Point(124, 491)
        btnEmployeeEdit.Name = "btnEmployeeEdit"
        btnEmployeeEdit.Size = New Size(72, 44)
        btnEmployeeEdit.TabIndex = 20
        btnEmployeeEdit.Text = "Edit"
        btnEmployeeEdit.UseVisualStyleBackColor = False
        ' 
        ' btnEmpBack
        ' 
        btnEmpBack.BackColor = Color.Silver
        btnEmpBack.FlatStyle = FlatStyle.Flat
        btnEmpBack.Font = New Font("Perpetua Titling MT", 9F)
        btnEmpBack.ForeColor = Color.ForestGreen
        btnEmpBack.Location = New Point(166, 556)
        btnEmpBack.Name = "btnEmpBack"
        btnEmpBack.Size = New Size(72, 44)
        btnEmpBack.TabIndex = 21
        btnEmpBack.Text = "back"
        btnEmpBack.UseVisualStyleBackColor = False
        ' 
        ' btnEmployeeDelete
        ' 
        btnEmployeeDelete.BackColor = Color.Silver
        btnEmployeeDelete.FlatStyle = FlatStyle.Flat
        btnEmployeeDelete.Font = New Font("Perpetua Titling MT", 9F)
        btnEmployeeDelete.ForeColor = Color.ForestGreen
        btnEmployeeDelete.Location = New Point(208, 491)
        btnEmployeeDelete.Name = "btnEmployeeDelete"
        btnEmployeeDelete.Size = New Size(72, 44)
        btnEmployeeDelete.TabIndex = 22
        btnEmployeeDelete.Text = "delete"
        btnEmployeeDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEmpClear
        ' 
        btnEmpClear.BackColor = Color.Silver
        btnEmpClear.FlatStyle = FlatStyle.Flat
        btnEmpClear.Font = New Font("Perpetua Titling MT", 9F)
        btnEmpClear.ForeColor = Color.ForestGreen
        btnEmpClear.Location = New Point(291, 491)
        btnEmpClear.Name = "btnEmpClear"
        btnEmpClear.Size = New Size(72, 44)
        btnEmpClear.TabIndex = 23
        btnEmpClear.Text = "clear"
        btnEmpClear.UseVisualStyleBackColor = False
        ' 
        ' agentView
        ' 
        agentView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        agentView.BackgroundColor = Color.White
        agentView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        agentView.Location = New Point(436, 206)
        agentView.Name = "agentView"
        agentView.RowHeadersWidth = 51
        agentView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        agentView.Size = New Size(631, 436)
        agentView.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Perpetua Titling MT", 14F)
        Label3.ForeColor = Color.MidnightBlue
        Label3.Location = New Point(679, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 28)
        Label3.TabIndex = 4
        Label3.Text = "agent list"
        ' 
        ' agent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGreen
        ClientSize = New Size(1079, 691)
        Controls.Add(Label3)
        Controls.Add(agentView)
        Controls.Add(btnEmpClear)
        Controls.Add(btnEmployeeDelete)
        Controls.Add(btnEmpBack)
        Controls.Add(btnEmployeeEdit)
        Controls.Add(btnEmployeeAdd)
        Controls.Add(Panel2)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtEmployeePassword)
        Controls.Add(txtEmployeePhone)
        Controls.Add(txtEmployeeAge)
        Controls.Add(txtEmployeeName)
        Controls.Add(txtEmployeeID)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "agent"
        StartPosition = FormStartPosition.CenterScreen
        Text = "agent"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(agentView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAgentClose As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtEmployeeAge As TextBox
    Friend WithEvents txtEmployeePhone As TextBox
    Friend WithEvents txtEmployeePassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEmployeeAdd As Button
    Friend WithEvents btnEmployeeEdit As Button
    Friend WithEvents btnEmpBack As Button
    Friend WithEvents btnEmployeeDelete As Button
    Friend WithEvents btnEmpClear As Button
    Friend WithEvents agentView As DataGridView
    Friend WithEvents Label3 As Label
End Class

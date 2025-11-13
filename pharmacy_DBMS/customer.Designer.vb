<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer
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
        btnCustomerClose = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        Label8 = New Label()
        txtCustomerID = New TextBox()
        btnCustomerAdd = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtCustomerName = New TextBox()
        txtCustomerAge = New TextBox()
        txtCustomerDOB = New TextBox()
        txtCustomerPhone = New TextBox()
        btnCustomerEdit = New Button()
        btnCustomerDelete = New Button()
        btnCustomerClear = New Button()
        btnCustomerBack = New Button()
        CustomerView = New DataGridView()
        Panel1.SuspendLayout()
        CType(CustomerView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Green
        Panel1.Controls.Add(btnCustomerClose)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1079, 125)
        Panel1.TabIndex = 0
        ' 
        ' btnCustomerClose
        ' 
        btnCustomerClose.AutoSize = True
        btnCustomerClose.Font = New Font("Perpetua Titling MT", 19.8000011F)
        btnCustomerClose.ForeColor = Color.MidnightBlue
        btnCustomerClose.Location = New Point(1032, 2)
        btnCustomerClose.Name = "btnCustomerClose"
        btnCustomerClose.Size = New Size(43, 41)
        btnCustomerClose.TabIndex = 4
        btnCustomerClose.Text = "X"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Perpetua Titling MT", 12F)
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(470, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 23)
        Label2.TabIndex = 3
        Label2.Text = "customer"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Perpetua Titling MT", 25.8000011F)
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(350, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(377, 52)
        Label1.TabIndex = 2
        Label1.Text = "PharmaCenter"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Green
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 666)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1079, 25)
        Panel2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Perpetua Titling MT", 12F)
        Label3.Location = New Point(13, 230)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 23)
        Label3.TabIndex = 2
        Label3.Text = "Customer ID"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Perpetua Titling MT", 14F)
        Label8.ForeColor = Color.MidnightBlue
        Label8.Location = New Point(627, 150)
        Label8.Name = "Label8"
        Label8.Size = New Size(212, 28)
        Label8.TabIndex = 7
        Label8.Text = "customber list"
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.BackColor = Color.ForestGreen
        txtCustomerID.BorderStyle = BorderStyle.None
        txtCustomerID.Font = New Font("Segoe UI", 12F)
        txtCustomerID.ForeColor = Color.White
        txtCustomerID.Location = New Point(213, 230)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.Size = New Size(177, 27)
        txtCustomerID.TabIndex = 8
        ' 
        ' btnCustomerAdd
        ' 
        btnCustomerAdd.BackColor = Color.Silver
        btnCustomerAdd.FlatStyle = FlatStyle.Flat
        btnCustomerAdd.Font = New Font("Perpetua Titling MT", 9F)
        btnCustomerAdd.ForeColor = Color.ForestGreen
        btnCustomerAdd.Location = New Point(44, 481)
        btnCustomerAdd.Name = "btnCustomerAdd"
        btnCustomerAdd.Size = New Size(72, 44)
        btnCustomerAdd.TabIndex = 9
        btnCustomerAdd.Text = "add"
        btnCustomerAdd.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Perpetua Titling MT", 12F)
        Label4.Location = New Point(13, 282)
        Label4.Name = "Label4"
        Label4.Size = New Size(183, 23)
        Label4.TabIndex = 10
        Label4.Text = "customer name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Perpetua Titling MT", 12F)
        Label5.Location = New Point(13, 334)
        Label5.Name = "Label5"
        Label5.Size = New Size(166, 23)
        Label5.TabIndex = 11
        Label5.Text = "customer age"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Perpetua Titling MT", 12F)
        Label6.Location = New Point(13, 386)
        Label6.Name = "Label6"
        Label6.Size = New Size(163, 23)
        Label6.TabIndex = 12
        Label6.Text = "date of birth"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Perpetua Titling MT", 12F)
        Label7.Location = New Point(13, 436)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 23)
        Label7.TabIndex = 13
        Label7.Text = "phone"
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.BackColor = Color.ForestGreen
        txtCustomerName.BorderStyle = BorderStyle.None
        txtCustomerName.Font = New Font("Segoe UI", 12F)
        txtCustomerName.ForeColor = Color.White
        txtCustomerName.Location = New Point(213, 282)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(177, 27)
        txtCustomerName.TabIndex = 14
        ' 
        ' txtCustomerAge
        ' 
        txtCustomerAge.BackColor = Color.ForestGreen
        txtCustomerAge.BorderStyle = BorderStyle.None
        txtCustomerAge.Font = New Font("Segoe UI", 12F)
        txtCustomerAge.ForeColor = Color.White
        txtCustomerAge.Location = New Point(213, 334)
        txtCustomerAge.Name = "txtCustomerAge"
        txtCustomerAge.Size = New Size(177, 27)
        txtCustomerAge.TabIndex = 15
        ' 
        ' txtCustomerDOB
        ' 
        txtCustomerDOB.BackColor = Color.ForestGreen
        txtCustomerDOB.BorderStyle = BorderStyle.None
        txtCustomerDOB.Font = New Font("Segoe UI", 12F)
        txtCustomerDOB.ForeColor = Color.White
        txtCustomerDOB.Location = New Point(213, 386)
        txtCustomerDOB.Name = "txtCustomerDOB"
        txtCustomerDOB.Size = New Size(177, 27)
        txtCustomerDOB.TabIndex = 16
        ' 
        ' txtCustomerPhone
        ' 
        txtCustomerPhone.BackColor = Color.ForestGreen
        txtCustomerPhone.BorderStyle = BorderStyle.None
        txtCustomerPhone.Font = New Font("Segoe UI", 12F)
        txtCustomerPhone.ForeColor = Color.White
        txtCustomerPhone.Location = New Point(213, 436)
        txtCustomerPhone.Name = "txtCustomerPhone"
        txtCustomerPhone.Size = New Size(177, 27)
        txtCustomerPhone.TabIndex = 17
        ' 
        ' btnCustomerEdit
        ' 
        btnCustomerEdit.BackColor = Color.Silver
        btnCustomerEdit.FlatStyle = FlatStyle.Flat
        btnCustomerEdit.Font = New Font("Perpetua Titling MT", 9F)
        btnCustomerEdit.ForeColor = Color.ForestGreen
        btnCustomerEdit.Location = New Point(129, 481)
        btnCustomerEdit.Name = "btnCustomerEdit"
        btnCustomerEdit.Size = New Size(72, 44)
        btnCustomerEdit.TabIndex = 18
        btnCustomerEdit.Text = "edit"
        btnCustomerEdit.UseVisualStyleBackColor = False
        ' 
        ' btnCustomerDelete
        ' 
        btnCustomerDelete.BackColor = Color.Silver
        btnCustomerDelete.FlatStyle = FlatStyle.Flat
        btnCustomerDelete.Font = New Font("Perpetua Titling MT", 9F)
        btnCustomerDelete.ForeColor = Color.ForestGreen
        btnCustomerDelete.Location = New Point(213, 481)
        btnCustomerDelete.Name = "btnCustomerDelete"
        btnCustomerDelete.Size = New Size(72, 44)
        btnCustomerDelete.TabIndex = 19
        btnCustomerDelete.Text = "delete"
        btnCustomerDelete.UseVisualStyleBackColor = False
        ' 
        ' btnCustomerClear
        ' 
        btnCustomerClear.BackColor = Color.Silver
        btnCustomerClear.FlatStyle = FlatStyle.Flat
        btnCustomerClear.Font = New Font("Perpetua Titling MT", 9F)
        btnCustomerClear.ForeColor = Color.ForestGreen
        btnCustomerClear.Location = New Point(296, 481)
        btnCustomerClear.Name = "btnCustomerClear"
        btnCustomerClear.Size = New Size(72, 44)
        btnCustomerClear.TabIndex = 20
        btnCustomerClear.Text = "clear"
        btnCustomerClear.UseVisualStyleBackColor = False
        ' 
        ' btnCustomerBack
        ' 
        btnCustomerBack.BackColor = Color.Silver
        btnCustomerBack.FlatStyle = FlatStyle.Flat
        btnCustomerBack.Font = New Font("Perpetua Titling MT", 9F)
        btnCustomerBack.ForeColor = Color.ForestGreen
        btnCustomerBack.Location = New Point(172, 544)
        btnCustomerBack.Name = "btnCustomerBack"
        btnCustomerBack.Size = New Size(72, 44)
        btnCustomerBack.TabIndex = 21
        btnCustomerBack.Text = "back"
        btnCustomerBack.UseVisualStyleBackColor = False
        ' 
        ' CustomerView
        ' 
        CustomerView.AllowUserToAddRows = False
        CustomerView.AllowUserToDeleteRows = False
        CustomerView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        CustomerView.BackgroundColor = Color.White
        CustomerView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CustomerView.Location = New Point(437, 200)
        CustomerView.Name = "CustomerView"
        CustomerView.RowHeadersVisible = False
        CustomerView.RowHeadersWidth = 51
        CustomerView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        CustomerView.Size = New Size(631, 436)
        CustomerView.TabIndex = 22
        ' 
        ' customer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGreen
        ClientSize = New Size(1079, 691)
        Controls.Add(CustomerView)
        Controls.Add(btnCustomerBack)
        Controls.Add(btnCustomerClear)
        Controls.Add(btnCustomerDelete)
        Controls.Add(btnCustomerEdit)
        Controls.Add(txtCustomerPhone)
        Controls.Add(txtCustomerDOB)
        Controls.Add(txtCustomerAge)
        Controls.Add(txtCustomerName)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnCustomerAdd)
        Controls.Add(txtCustomerID)
        Controls.Add(Label8)
        Controls.Add(Label3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "customer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "customer"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(CustomerView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCustomerClose As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents btnCustomerAdd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCustomerAge As TextBox
    Friend WithEvents txtCustomerDOB As TextBox
    Friend WithEvents txtCustomerPhone As TextBox
    Friend WithEvents btnCustomerEdit As Button
    Friend WithEvents btnCustomerDelete As Button
    Friend WithEvents btnCustomerClear As Button
    Friend WithEvents btnCustomerBack As Button
    Friend WithEvents CustomerView As DataGridView
End Class

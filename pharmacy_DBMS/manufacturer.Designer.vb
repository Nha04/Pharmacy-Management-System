<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manufacturer
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
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel1 = New Panel()
        btnManuClose = New Label()
        txtComID = New TextBox()
        Panel2 = New Panel()
        btnCompanyAdd = New Button()
        manuView = New DataGridView()
        txtComName = New TextBox()
        txtComPhone = New TextBox()
        txtComAdd = New TextBox()
        btnCompanyEdit = New Button()
        btnCompanyDelete = New Button()
        btnCompanyClear = New Button()
        btnManuBack = New Button()
        Panel1.SuspendLayout()
        CType(manuView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Green
        Label1.Font = New Font("Perpetua Titling MT", 25.8000011F)
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(350, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(377, 52)
        Label1.TabIndex = 0
        Label1.Text = "PharmaCenter"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Perpetua Titling MT", 12F)
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(430, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 23)
        Label2.TabIndex = 1
        Label2.Text = "manufacturer"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Perpetua Titling MT", 12F)
        Label3.Location = New Point(10, 229)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 23)
        Label3.TabIndex = 2
        Label3.Text = "company ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Perpetua Titling MT", 12F)
        Label4.Location = New Point(10, 281)
        Label4.Name = "Label4"
        Label4.Size = New Size(177, 23)
        Label4.TabIndex = 3
        Label4.Text = "company name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Perpetua Titling MT", 12F)
        Label5.Location = New Point(10, 385)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 23)
        Label5.TabIndex = 4
        Label5.Text = "address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Perpetua Titling MT", 12F)
        Label6.Location = New Point(10, 333)
        Label6.Name = "Label6"
        Label6.Size = New Size(170, 23)
        Label6.TabIndex = 5
        Label6.Text = "phone number"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Perpetua Titling MT", 14F)
        Label7.ForeColor = Color.MidnightBlue
        Label7.Location = New Point(618, 153)
        Label7.Name = "Label7"
        Label7.Size = New Size(267, 28)
        Label7.TabIndex = 6
        Label7.Text = "Manufacturer list"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Green
        Panel1.Controls.Add(btnManuClose)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1079, 125)
        Panel1.TabIndex = 7
        ' 
        ' btnManuClose
        ' 
        btnManuClose.AutoSize = True
        btnManuClose.Font = New Font("Perpetua Titling MT", 19.8000011F)
        btnManuClose.ForeColor = Color.MidnightBlue
        btnManuClose.Location = New Point(1032, 2)
        btnManuClose.Name = "btnManuClose"
        btnManuClose.Size = New Size(43, 41)
        btnManuClose.TabIndex = 25
        btnManuClose.Text = "X"
        ' 
        ' txtComID
        ' 
        txtComID.BackColor = Color.ForestGreen
        txtComID.BorderStyle = BorderStyle.None
        txtComID.Font = New Font("Segoe UI", 12F)
        txtComID.ForeColor = Color.White
        txtComID.Location = New Point(210, 229)
        txtComID.Name = "txtComID"
        txtComID.Size = New Size(177, 27)
        txtComID.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Green
        Panel2.Location = New Point(0, 666)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1079, 25)
        Panel2.TabIndex = 8
        ' 
        ' btnCompanyAdd
        ' 
        btnCompanyAdd.BackColor = Color.Silver
        btnCompanyAdd.FlatStyle = FlatStyle.Flat
        btnCompanyAdd.Font = New Font("Perpetua Titling MT", 9F)
        btnCompanyAdd.ForeColor = Color.ForestGreen
        btnCompanyAdd.Location = New Point(41, 448)
        btnCompanyAdd.Name = "btnCompanyAdd"
        btnCompanyAdd.Size = New Size(72, 44)
        btnCompanyAdd.TabIndex = 12
        btnCompanyAdd.Text = "Add"
        btnCompanyAdd.UseVisualStyleBackColor = False
        ' 
        ' manuView
        ' 
        manuView.BackgroundColor = Color.White
        manuView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        manuView.Location = New Point(437, 203)
        manuView.Name = "manuView"
        manuView.RowHeadersVisible = False
        manuView.RowHeadersWidth = 51
        manuView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        manuView.Size = New Size(631, 436)
        manuView.TabIndex = 17
        ' 
        ' txtComName
        ' 
        txtComName.BackColor = Color.ForestGreen
        txtComName.BorderStyle = BorderStyle.None
        txtComName.Font = New Font("Segoe UI", 12F)
        txtComName.ForeColor = Color.White
        txtComName.Location = New Point(210, 281)
        txtComName.Name = "txtComName"
        txtComName.Size = New Size(177, 27)
        txtComName.TabIndex = 18
        ' 
        ' txtComPhone
        ' 
        txtComPhone.BackColor = Color.ForestGreen
        txtComPhone.BorderStyle = BorderStyle.None
        txtComPhone.Font = New Font("Segoe UI", 12F)
        txtComPhone.ForeColor = Color.White
        txtComPhone.Location = New Point(210, 333)
        txtComPhone.Name = "txtComPhone"
        txtComPhone.Size = New Size(177, 27)
        txtComPhone.TabIndex = 19
        ' 
        ' txtComAdd
        ' 
        txtComAdd.BackColor = Color.ForestGreen
        txtComAdd.BorderStyle = BorderStyle.None
        txtComAdd.Font = New Font("Segoe UI", 12F)
        txtComAdd.ForeColor = Color.White
        txtComAdd.Location = New Point(210, 385)
        txtComAdd.Name = "txtComAdd"
        txtComAdd.Size = New Size(177, 27)
        txtComAdd.TabIndex = 20
        ' 
        ' btnCompanyEdit
        ' 
        btnCompanyEdit.BackColor = Color.Silver
        btnCompanyEdit.FlatStyle = FlatStyle.Flat
        btnCompanyEdit.Font = New Font("Perpetua Titling MT", 9F)
        btnCompanyEdit.ForeColor = Color.ForestGreen
        btnCompanyEdit.Location = New Point(126, 448)
        btnCompanyEdit.Name = "btnCompanyEdit"
        btnCompanyEdit.Size = New Size(72, 44)
        btnCompanyEdit.TabIndex = 21
        btnCompanyEdit.Text = "Edit"
        btnCompanyEdit.UseVisualStyleBackColor = False
        ' 
        ' btnCompanyDelete
        ' 
        btnCompanyDelete.BackColor = Color.Silver
        btnCompanyDelete.FlatStyle = FlatStyle.Flat
        btnCompanyDelete.Font = New Font("Perpetua Titling MT", 9F)
        btnCompanyDelete.ForeColor = Color.ForestGreen
        btnCompanyDelete.Location = New Point(210, 448)
        btnCompanyDelete.Name = "btnCompanyDelete"
        btnCompanyDelete.Size = New Size(72, 44)
        btnCompanyDelete.TabIndex = 22
        btnCompanyDelete.Text = "Delete"
        btnCompanyDelete.UseVisualStyleBackColor = False
        ' 
        ' btnCompanyClear
        ' 
        btnCompanyClear.BackColor = Color.Silver
        btnCompanyClear.FlatStyle = FlatStyle.Flat
        btnCompanyClear.Font = New Font("Perpetua Titling MT", 9F)
        btnCompanyClear.ForeColor = Color.ForestGreen
        btnCompanyClear.Location = New Point(295, 448)
        btnCompanyClear.Name = "btnCompanyClear"
        btnCompanyClear.Size = New Size(72, 44)
        btnCompanyClear.TabIndex = 23
        btnCompanyClear.Text = "clear"
        btnCompanyClear.UseVisualStyleBackColor = False
        ' 
        ' btnManuBack
        ' 
        btnManuBack.BackColor = Color.Silver
        btnManuBack.FlatStyle = FlatStyle.Flat
        btnManuBack.Font = New Font("Perpetua Titling MT", 9F)
        btnManuBack.ForeColor = Color.ForestGreen
        btnManuBack.Location = New Point(164, 508)
        btnManuBack.Name = "btnManuBack"
        btnManuBack.Size = New Size(72, 44)
        btnManuBack.TabIndex = 24
        btnManuBack.Text = "back"
        btnManuBack.UseVisualStyleBackColor = False
        ' 
        ' manufacturer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGreen
        ClientSize = New Size(1079, 691)
        Controls.Add(btnManuBack)
        Controls.Add(btnCompanyClear)
        Controls.Add(btnCompanyDelete)
        Controls.Add(btnCompanyEdit)
        Controls.Add(txtComAdd)
        Controls.Add(txtComPhone)
        Controls.Add(txtComName)
        Controls.Add(manuView)
        Controls.Add(btnCompanyAdd)
        Controls.Add(Panel2)
        Controls.Add(txtComID)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        FormBorderStyle = FormBorderStyle.None
        Name = "manufacturer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "manufacturer"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(manuView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtComID As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCompanyAdd As Button
    Friend WithEvents manuView As DataGridView
    Friend WithEvents txtComName As TextBox
    Friend WithEvents txtComPhone As TextBox
    Friend WithEvents txtComAdd As TextBox
    Friend WithEvents btnCompanyEdit As Button
    Friend WithEvents btnCompanyDelete As Button
    Friend WithEvents btnCompanyClear As Button
    Friend WithEvents btnManuBack As Button
    Friend WithEvents btnManuClose As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medicine
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
        Panel1 = New Panel()
        btnMedClose = New Label()
        Label2 = New Label()
        txtMedID = New TextBox()
        btnMedAdd = New Button()
        txtMedExp = New DateTimePicker()
        medicineView = New DataGridView()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtMedName = New TextBox()
        txtMedSellPrice = New TextBox()
        txtMedBuyPrice = New TextBox()
        txtMedQty = New TextBox()
        btnMedEdit = New Button()
        btnMedClear = New Button()
        btnMedDelete = New Button()
        btnMedBack = New Button()
        Label9 = New Label()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(medicineView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Perpetua Titling MT", 25.8000011F)
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(350, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(377, 52)
        Label1.TabIndex = 0
        Label1.Text = "PharmaCenter"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Green
        Panel1.Controls.Add(btnMedClose)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1079, 125)
        Panel1.TabIndex = 1
        ' 
        ' btnMedClose
        ' 
        btnMedClose.AutoSize = True
        btnMedClose.Font = New Font("Perpetua Titling MT", 19.8000011F)
        btnMedClose.ForeColor = Color.MidnightBlue
        btnMedClose.Location = New Point(1032, 2)
        btnMedClose.Name = "btnMedClose"
        btnMedClose.Size = New Size(43, 41)
        btnMedClose.TabIndex = 7
        btnMedClose.Text = "X"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Perpetua Titling MT", 12F)
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(474, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 23)
        Label2.TabIndex = 6
        Label2.Text = "medicine"
        ' 
        ' txtMedID
        ' 
        txtMedID.BackColor = Color.ForestGreen
        txtMedID.BorderStyle = BorderStyle.None
        txtMedID.Font = New Font("Segoe UI", 12F)
        txtMedID.ForeColor = Color.White
        txtMedID.Location = New Point(232, 202)
        txtMedID.Name = "txtMedID"
        txtMedID.Size = New Size(177, 27)
        txtMedID.TabIndex = 2
        ' 
        ' btnMedAdd
        ' 
        btnMedAdd.BackColor = Color.Silver
        btnMedAdd.FlatStyle = FlatStyle.Flat
        btnMedAdd.Font = New Font("Perpetua Titling MT", 9F)
        btnMedAdd.ForeColor = Color.ForestGreen
        btnMedAdd.Location = New Point(32, 504)
        btnMedAdd.Name = "btnMedAdd"
        btnMedAdd.Size = New Size(72, 44)
        btnMedAdd.TabIndex = 3
        btnMedAdd.Text = "Add"
        btnMedAdd.UseVisualStyleBackColor = False
        ' 
        ' txtMedExp
        ' 
        txtMedExp.Location = New Point(148, 456)
        txtMedExp.Name = "txtMedExp"
        txtMedExp.Size = New Size(262, 27)
        txtMedExp.TabIndex = 23
        ' 
        ' medicineView
        ' 
        medicineView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        medicineView.BackgroundColor = Color.White
        medicineView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        medicineView.Location = New Point(436, 202)
        medicineView.Name = "medicineView"
        medicineView.RowHeadersVisible = False
        medicineView.RowHeadersWidth = 51
        medicineView.Size = New Size(631, 436)
        medicineView.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Perpetua Titling MT", 12F)
        Label3.Location = New Point(12, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 23)
        Label3.TabIndex = 7
        Label3.Text = "Medicine ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Perpetua Titling MT", 12F)
        Label4.Location = New Point(12, 251)
        Label4.Name = "Label4"
        Label4.Size = New Size(169, 23)
        Label4.TabIndex = 8
        Label4.Text = "Medicine Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Perpetua Titling MT", 12F)
        Label5.Location = New Point(12, 303)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 23)
        Label5.TabIndex = 9
        Label5.Text = "Buying Price"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Perpetua Titling MT", 12F)
        Label6.Location = New Point(12, 355)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 23)
        Label6.TabIndex = 10
        Label6.Text = "Selling Price"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Perpetua Titling MT", 12F)
        Label7.Location = New Point(12, 407)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 23)
        Label7.TabIndex = 11
        Label7.Text = "Quantity"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Perpetua Titling MT", 12F)
        Label8.Location = New Point(12, 456)
        Label8.Name = "Label8"
        Label8.Size = New Size(106, 23)
        Label8.TabIndex = 12
        Label8.Text = "Exp date"
        ' 
        ' txtMedName
        ' 
        txtMedName.BackColor = Color.ForestGreen
        txtMedName.BorderStyle = BorderStyle.None
        txtMedName.Font = New Font("Segoe UI", 12F)
        txtMedName.ForeColor = Color.White
        txtMedName.Location = New Point(232, 251)
        txtMedName.Name = "txtMedName"
        txtMedName.Size = New Size(177, 27)
        txtMedName.TabIndex = 17
        ' 
        ' txtMedSellPrice
        ' 
        txtMedSellPrice.BackColor = Color.ForestGreen
        txtMedSellPrice.BorderStyle = BorderStyle.None
        txtMedSellPrice.Font = New Font("Segoe UI", 12F)
        txtMedSellPrice.ForeColor = Color.White
        txtMedSellPrice.Location = New Point(232, 355)
        txtMedSellPrice.Name = "txtMedSellPrice"
        txtMedSellPrice.Size = New Size(177, 27)
        txtMedSellPrice.TabIndex = 18
        ' 
        ' txtMedBuyPrice
        ' 
        txtMedBuyPrice.BackColor = Color.ForestGreen
        txtMedBuyPrice.BorderStyle = BorderStyle.None
        txtMedBuyPrice.Font = New Font("Segoe UI", 12F)
        txtMedBuyPrice.ForeColor = Color.White
        txtMedBuyPrice.Location = New Point(232, 303)
        txtMedBuyPrice.Name = "txtMedBuyPrice"
        txtMedBuyPrice.Size = New Size(177, 27)
        txtMedBuyPrice.TabIndex = 18
        ' 
        ' txtMedQty
        ' 
        txtMedQty.BackColor = Color.ForestGreen
        txtMedQty.BorderStyle = BorderStyle.None
        txtMedQty.Font = New Font("Segoe UI", 12F)
        txtMedQty.ForeColor = Color.White
        txtMedQty.Location = New Point(232, 407)
        txtMedQty.Name = "txtMedQty"
        txtMedQty.Size = New Size(177, 27)
        txtMedQty.TabIndex = 19
        ' 
        ' btnMedEdit
        ' 
        btnMedEdit.BackColor = Color.Silver
        btnMedEdit.FlatStyle = FlatStyle.Flat
        btnMedEdit.Font = New Font("Perpetua Titling MT", 9F)
        btnMedEdit.ForeColor = Color.ForestGreen
        btnMedEdit.Location = New Point(117, 504)
        btnMedEdit.Name = "btnMedEdit"
        btnMedEdit.Size = New Size(72, 44)
        btnMedEdit.TabIndex = 24
        btnMedEdit.Text = "Edit"
        btnMedEdit.UseVisualStyleBackColor = False
        ' 
        ' btnMedClear
        ' 
        btnMedClear.BackColor = Color.Silver
        btnMedClear.FlatStyle = FlatStyle.Flat
        btnMedClear.Font = New Font("Perpetua Titling MT", 9F)
        btnMedClear.ForeColor = Color.ForestGreen
        btnMedClear.Location = New Point(283, 504)
        btnMedClear.Name = "btnMedClear"
        btnMedClear.Size = New Size(72, 44)
        btnMedClear.TabIndex = 25
        btnMedClear.Text = "clear"
        btnMedClear.UseVisualStyleBackColor = False
        ' 
        ' btnMedDelete
        ' 
        btnMedDelete.BackColor = Color.Silver
        btnMedDelete.FlatStyle = FlatStyle.Flat
        btnMedDelete.Font = New Font("Perpetua Titling MT", 9F)
        btnMedDelete.ForeColor = Color.ForestGreen
        btnMedDelete.Location = New Point(201, 504)
        btnMedDelete.Name = "btnMedDelete"
        btnMedDelete.Size = New Size(72, 44)
        btnMedDelete.TabIndex = 26
        btnMedDelete.Text = "Delete"
        btnMedDelete.UseVisualStyleBackColor = False
        ' 
        ' btnMedBack
        ' 
        btnMedBack.BackColor = Color.Silver
        btnMedBack.FlatStyle = FlatStyle.Flat
        btnMedBack.Font = New Font("Perpetua Titling MT", 9F)
        btnMedBack.ForeColor = Color.ForestGreen
        btnMedBack.Location = New Point(161, 555)
        btnMedBack.Name = "btnMedBack"
        btnMedBack.Size = New Size(72, 44)
        btnMedBack.TabIndex = 27
        btnMedBack.Text = "back"
        btnMedBack.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Perpetua Titling MT", 14F)
        Label9.ForeColor = Color.MidnightBlue
        Label9.Location = New Point(675, 152)
        Label9.Name = "Label9"
        Label9.Size = New Size(180, 28)
        Label9.TabIndex = 28
        Label9.Text = "medicine list"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Green
        Panel2.Location = New Point(0, 666)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1079, 25)
        Panel2.TabIndex = 29
        ' 
        ' medicine
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGreen
        ClientSize = New Size(1079, 691)
        Controls.Add(Panel2)
        Controls.Add(Label9)
        Controls.Add(btnMedBack)
        Controls.Add(btnMedDelete)
        Controls.Add(btnMedClear)
        Controls.Add(btnMedEdit)
        Controls.Add(txtMedQty)
        Controls.Add(txtMedBuyPrice)
        Controls.Add(txtMedSellPrice)
        Controls.Add(txtMedName)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(medicineView)
        Controls.Add(txtMedExp)
        Controls.Add(btnMedAdd)
        Controls.Add(txtMedID)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "medicine"
        StartPosition = FormStartPosition.CenterScreen
        Text = "medicine"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(medicineView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtMedID As TextBox
    Friend WithEvents btnMedAdd As Button
    Friend WithEvents txtMedExp As DateTimePicker
    Friend WithEvents medicineView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMedName As TextBox
    Friend WithEvents txtMedSellPrice As TextBox
    Friend WithEvents txtMedBuyPrice As TextBox
    Friend WithEvents txtMedQty As TextBox
    Friend WithEvents btnMedEdit As Button
    Friend WithEvents btnMedClear As Button
    Friend WithEvents btnMedDelete As Button
    Friend WithEvents btnMedBack As Button
    Friend WithEvents btnMedClose As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
End Class

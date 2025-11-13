Imports System.Data.SqlClient
Imports Windows.Win32
Public Class medicine
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As SqlConnection = New SqlConnection
    Dim ds As New SqlDataAdapter
    Dim con As New SqlConnection
    Dim dt As New DataTable
    Dim daset As New DataSet
    Private Sub btnMedAdd_Click(sender As Object, e As EventArgs) Handles btnMedAdd.Click
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "INSERT INTO tblmedicine ([MedID], [MedName], [BuyPrice], [SellPrice], [Quantity], [EXPDate]) VALUES ('" & txtMedID.Text & "','" & txtMedName.Text & "','" & txtMedBuyPrice.Text & "','" & txtMedSellPrice.Text & "', '" & txtMedQty.Text & "','" & txtMedExp.Text & "')"
        Dim cmd As SqlCommand = New SqlCommand(command, myconnection)
        cmd.Parameters.Add(New SqlParameter("MedID", CType(txtMedID.Text, String)))
        cmd.Parameters.Add(New SqlParameter("MedName", CType(txtMedName.Text, String)))
        cmd.Parameters.Add(New SqlParameter("BuyPrice", CType(txtMedBuyPrice.Text, String)))
        cmd.Parameters.Add(New SqlParameter("SellPrice", CType(txtMedSellPrice.Text, String)))
        cmd.Parameters.Add(New SqlParameter("Quantity", CType(txtMedQty.Text, String)))
        cmd.Parameters.Add(New SqlParameter("EXPDate", CType(txtMedExp.Text, String)))
        MsgBox("Record Save")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtMedID.Clear()
            txtMedName.Clear()
            txtMedBuyPrice.Clear()
            txtMedSellPrice.Clear()
            txtMedQty.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        qry()
    End Sub

    Private Sub btnMedEdit_Click(sender As Object, e As EventArgs) Handles btnMedEdit.Click
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "UPDATE [tblmedicine] SET 
        [MedName]='" & txtMedName.Text & "', 
        [BuyPrice]='" & txtMedBuyPrice.Text & "', 
        [SellPrice]='" & txtMedSellPrice.Text & "', 
        [Quantity]='" & txtMedQty.Text & "', 
        [EXPDate]='" & txtMedExp.Text & "'"
        Dim cmd As SqlCommand = New SqlCommand(command, myconnection)
        cmd.Parameters.Add(New SqlParameter("MedID", CType(txtMedID.Text, String)))
        MsgBox("Record edit")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtMedID.Clear()
            txtMedName.Clear()
            txtMedBuyPrice.Clear()
            txtMedSellPrice.Clear()
            txtMedQty.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        qry()
    End Sub

    Private Sub btnMedDelete_Click(sender As Object, e As EventArgs) Handles btnMedDelete.Click
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "DELETE FROM tblmedicine WHERE MedID='" & txtMedID.Text & "'"
        Dim cmd As SqlCommand = New SqlCommand(command, myconnection)
        cmd.Parameters.Add(New SqlParameter("MedID", CType(txtMedID.Text, String)))
        MsgBox("Record delete")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtMedID.Clear()
            txtMedName.Clear()
            txtMedBuyPrice.Clear()
            txtMedSellPrice.Clear()
            txtMedQty.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        qry()
    End Sub
    Public Sub qry()
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        ds = New SqlDataAdapter("SELECT * FROM tblmedicine", pro)
        daset = New DataSet
        daset.Clear()
        ds.Fill(daset, "tblmedicine")
        medicineView.DataSource = (daset.Tables("tblmedicine"))
    End Sub

    Private Sub btnMedClose_Click(sender As Object, e As EventArgs) Handles btnMedClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMedBack_Click(sender As Object, e As EventArgs) Handles btnMedBack.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qry()
    End Sub

    Private Sub medicineView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles medicineView.CellContentClick
        txtMedID.Text = medicineView.SelectedCells(0).Value.ToString
        txtMedName.Text = medicineView.SelectedCells(1).Value.ToString
        txtMedBuyPrice.Text = medicineView.SelectedCells(2).Value.ToString
        txtMedSellPrice.Text = medicineView.SelectedCells(3).Value.ToString
        txtMedQty.Text = medicineView.SelectedCells(4).Value.ToString
        txtMedExp.Text = medicineView.SelectedCells(5).Value.ToString
    End Sub

    Private Sub btnMedClear_Click(sender As Object, e As EventArgs) Handles btnMedClear.Click
        txtMedID.Clear()
        txtMedName.Clear()
        txtMedBuyPrice.Clear()
        txtMedSellPrice.Clear()
        txtMedQty.Clear()
    End Sub
End Class
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class customer
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As SqlConnection = New SqlConnection
    Dim ds As New SqlDataAdapter
    Dim con As New SqlConnection
    Dim dt As New DataTable
    Dim daset As New DataSet
    Private Sub btnCustomerAdd_Click(sender As Object, e As EventArgs) Handles btnCustomerAdd.Click
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "INSERT INTO tblcustomer ([CusID], [CusName], [CusAge], [CusDOB], [CusPhone]) 
        VALUES ('" & txtCustomerID.Text & "', '" & txtCustomerName.Text & "', '" & txtCustomerAge.Text & "', '" & txtCustomerDOB.Text & "', '" & txtCustomerPhone.Text & "')"
        Dim cmd As SqlCommand = New SqlCommand(command, myconnection)
        cmd.Parameters.Add(New SqlParameter("CusID", CType(txtCustomerID.Text, String)))
        cmd.Parameters.Add(New SqlParameter("CusName", CType(txtCustomerName.Text, String)))
        cmd.Parameters.Add(New SqlParameter("CusAge", CType(txtCustomerAge.Text, String)))
        cmd.Parameters.Add(New SqlParameter("CusDOB", CType(txtCustomerDOB.Text, String)))
        cmd.Parameters.Add(New SqlParameter("CusPhone", CType(txtCustomerPhone.Text, String)))
        MsgBox("Record save")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtCustomerID.Clear()
            txtCustomerName.Clear()
            txtCustomerAge.Clear()
            txtCustomerDOB.Clear()
            txtCustomerPhone.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        qry()
    End Sub
    Private Sub btnCustomerEdit_Click(sender As Object, e As EventArgs) Handles btnCustomerEdit.Click
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "UPDATE [tblcustomer] SET 
        [CusName]='" & txtCustomerName.Text & "', 
        [CusAge]='" & txtCustomerAge.Text & "',
        [CusDOB]='" & txtCustomerDOB.Text & "',       
        [CusPhone]='" & txtCustomerPhone.Text & "'"
        Dim cmd As SqlCommand = New SqlCommand(command, myconnection)
        cmd.Parameters.Add(New SqlParameter("CusID", CType(txtCustomerID.Text, String)))
        MsgBox("Record edit")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtCustomerID.Clear()
            txtCustomerName.Clear()
            txtCustomerAge.Clear()
            txtCustomerDOB.Clear()
            txtCustomerPhone.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        qry()
    End Sub
    Private Sub btnCustomerDelete_Click(sender As Object, e As EventArgs) Handles btnCustomerDelete.Click
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "DELETE FROM [tblcustomer] WHERE [CusID]='" & txtCustomerID.Text & "'"
        Dim cmd As SqlCommand = New SqlCommand(command, myconnection)
        cmd.Parameters.Add(New SqlParameter("CusID", CType(txtCustomerID.Text, String)))
        MsgBox("Record delete")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtCustomerID.Clear()
            txtCustomerName.Clear()
            txtCustomerAge.Clear()
            txtCustomerDOB.Clear()
            txtCustomerPhone.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        qry()
    End Sub
    Public Sub qry()
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        ds = New SqlDataAdapter("SELECT *FROM tblcustomer", pro)
        daset = New DataSet
        daset.Clear()
        ds.Fill(daset, "tblcustomer")
        CustomerView.DataSource = (daset.Tables("tblcustomer"))
    End Sub
    Private Sub CustomerView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerView.CellContentClick
        txtCustomerID.Text = CustomerView.SelectedCells(0).Value.ToString
        txtCustomerName.Text = CustomerView.SelectedCells(1).Value.ToString
        txtCustomerAge.Text = CustomerView.SelectedCells(2).Value.ToString
        txtCustomerDOB.Text = CustomerView.SelectedCells(3).Value.ToString
        txtCustomerPhone.Text = CustomerView.SelectedCells(3).Value.ToString
    End Sub

    Private Sub btnCustomerClear_Click(sender As Object, e As EventArgs) Handles btnCustomerClear.Click
        txtCustomerID.Clear()
        txtCustomerName.Clear()
        txtCustomerAge.Clear()
        txtCustomerDOB.Clear()
        txtCustomerPhone.Clear()
    End Sub

    Private Sub btnCustomerClose_Click(sender As Object, e As EventArgs) Handles btnCustomerClose.Click
        Application.Exit()
    End Sub

    Private Sub customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qry()
    End Sub

    Private Sub btnCustomerBack_Click(sender As Object, e As EventArgs) Handles btnCustomerBack.Click
        Me.Hide()
        home.Show()
    End Sub
End Class
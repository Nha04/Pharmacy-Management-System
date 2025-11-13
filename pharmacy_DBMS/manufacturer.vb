Imports System.Data.SqlClient
Public Class manufacturer
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As SqlConnection = New SqlConnection
    Dim ds As New SqlDataAdapter
    Dim con As New SqlConnection
    Dim dt As New DataTable
    Dim daset As New DataSet
    Private Sub manufacturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qry()
    End Sub

    Private Sub btnCompanyAdd_Click(sender As Object, e As EventArgs) Handles btnCompanyAdd.Click
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "INSERT INTO tblmanufacturer ([ComID], [ComName], [ComPhone], [ComAdd]) values ('" & txtComID.Text & "', '" & txtComName.Text & "', '" & txtComPhone.Text & "', '" & txtComAdd.Text & "')"
        Dim cmd As SqlCommand = New SqlCommand(command, myconnection)
        cmd.Parameters.Add(New SqlParameter("ComID", CType(txtComID.Text, String)))
        cmd.Parameters.Add(New SqlParameter("ComName", CType(txtComName.Text, String)))
        cmd.Parameters.Add(New SqlParameter("ComPhone", CType(txtComPhone.Text, String)))
        cmd.Parameters.Add(New SqlParameter("ComAdd", CType(txtComAdd.Text, String)))
        MsgBox("Record save")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtComID.Clear()
            txtComName.Clear()
            txtComPhone.Clear()
            txtComAdd.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        qry()
    End Sub

    Private Sub btnCompanyEdit_Click(sender As Object, e As EventArgs) Handles btnCompanyEdit.Click
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "update[tblmanufacturer] set 
        [ComName]='" & txtComName.Text & "', 
        [ComPhone]='" & txtComPhone.Text & "', 
        [ComAdd]='" & txtComAdd.Text & "'"
        Dim cmd As SqlCommand = New SqlCommand(command, myconnection)
        cmd.Parameters.Add(New SqlParameter("MedID", CType(txtComID.Text, String)))
        MsgBox("Record edit")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtComID.Clear()
            txtComName.Clear()
            txtComPhone.Clear()
            txtComAdd.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        qry()
    End Sub

    Private Sub btnCompanyDelete_Click(sender As Object, e As EventArgs) Handles btnCompanyDelete.Click
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "DELETE FROM tblmanufacturer WHERE ComID='" & txtComID.Text & "'"
        Dim cmd As SqlCommand = New SqlCommand(command, myconnection)
        cmd.Parameters.Add(New SqlParameter("MedID", CType(txtComID.Text, String)))
        MsgBox("Record delete")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtComID.Clear()
            txtComName.Clear()
            txtComPhone.Clear()
            txtComAdd.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        qry()
    End Sub
    Public Sub qry()
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        ds = New SqlDataAdapter("SELECT *FROM tblmanufacturer", pro)
        daset = New DataSet
        daset.Clear()
        ds.Fill(daset, "tblmanufacturer")
        manuView.DataSource = (daset.Tables("tblmanufacturer"))
    End Sub

    Private Sub btnManuClose_Click(sender As Object, e As EventArgs) Handles btnManuClose.Click
        Application.Exit()

    End Sub

    Private Sub manuView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles manuView.CellContentClick
        txtComID.Text = manuView.SelectedCells(0).Value.ToString
        txtComName.Text = manuView.SelectedCells(1).Value.ToString
        txtComPhone.Text = manuView.SelectedCells(2).Value.ToString
        txtComAdd.Text = manuView.SelectedCells(3).Value.ToString
    End Sub

    Private Sub btnManuBack_Click(sender As Object, e As EventArgs) Handles btnManuBack.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub btnCompanyClear_Click(sender As Object, e As EventArgs) Handles btnCompanyClear.Click
        txtComID.Clear()
        txtComName.Clear()
        txtComPhone.Clear()
        txtComAdd.Clear()
    End Sub
End Class
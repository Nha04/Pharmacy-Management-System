Imports System.Data.SqlClient

Public Class agent
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As SqlConnection = New SqlConnection
    Dim ds As New SqlDataAdapter
    Dim con As New SqlConnection
    Dim dt As New DataTable
    Dim daset As New DataSet
    Private Sub btnEmployeeAdd_Click(sender As Object, e As EventArgs) Handles btnEmployeeAdd.Click
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "INSERT INTO tblagent ([EmpID], [EmpName], [EmpAge], [EmpPhone], [EmpPassword]) 
        VALUES ('" & txtEmployeeID.Text & "', '" & txtEmployeeName.Text & "', '" & txtEmployeeAge.Text & "', '" & txtEmployeePhone.Text & "', '" & txtEmployeePassword.Text & "')"
        Dim cmd As SqlCommand = New SqlCommand(command, myconnection)
        cmd.Parameters.Add(New SqlParameter("EmpID", CType(txtEmployeeID.Text, String)))
        cmd.Parameters.Add(New SqlParameter("EmpName", CType(txtEmployeeName.Text, String)))
        cmd.Parameters.Add(New SqlParameter("EmpAge", CType(txtEmployeeAge.Text, String)))
        cmd.Parameters.Add(New SqlParameter("EmpPhone", CType(txtEmployeePhone.Text, String)))
        cmd.Parameters.Add(New SqlParameter("EmpPassword", CType(txtEmployeePassword.Text, String)))
        MsgBox("Record save")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtEmployeeID.Clear()
            txtEmployeeName.Clear()
            txtEmployeeAge.Clear()
            txtEmployeePhone.Clear()
            txtEmployeePassword.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        qry()
    End Sub
    Private Sub btnEmployeeEdit_Click(sender As Object, e As EventArgs) Handles btnEmployeeEdit.Click
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "UPDATE [tblagent] SET 
        [EmpName]='" & txtEmployeeName.Text & "', 
        [EmpAge]='" & txtEmployeeAge.Text & "',
        [EmpPhone]='" & txtEmployeePhone.Text & "',       
        [EmpPassword]='" & txtEmployeePassword.Text & "'"
        Dim cmd As SqlCommand = New SqlCommand(command, myconnection)
        cmd.Parameters.Add(New SqlParameter("EmpID", CType(txtEmployeeID.Text, String)))
        MsgBox("Record edit")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtEmployeeID.Clear()
            txtEmployeeName.Clear()
            txtEmployeeAge.Clear()
            txtEmployeePhone.Clear()
            txtEmployeePassword.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        qry()
    End Sub

    Private Sub btnEmployeeDelete_Click(sender As Object, e As EventArgs) Handles btnEmployeeDelete.Click
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "DELETE FROM [tblagent] WHERE [EmpID]='" & txtEmployeeID.Text & "'"
        Dim cmd As SqlCommand = New SqlCommand(command, myconnection)
        cmd.Parameters.Add(New SqlParameter("EmpID", CType(txtEmployeeID.Text, String)))
        MsgBox("Record delete")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            txtEmployeeID.Clear()
            txtEmployeeName.Clear()
            txtEmployeeAge.Clear()
            txtEmployeePhone.Clear()
            txtEmployeePassword.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        qry()
    End Sub
    Public Sub qry()
        pro = ("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        ds = New SqlDataAdapter("SELECT * FROM tblagent", pro)
        daset = New DataSet
        daset.Clear()
        ds.Fill(daset, "tblagent")
        agentView.DataSource = (daset.Tables("tblagent"))
    End Sub

    Private Sub btnAgentClose_Click(sender As Object, e As EventArgs) Handles btnAgentClose.Click
        Application.Exit()
    End Sub

    Private Sub agent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qry()
    End Sub
    Private Sub agentView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles agentView.CellContentClick
        txtEmployeeID.Text = agentView.SelectedCells(0).Value.ToString
        txtEmployeeName.Text = agentView.SelectedCells(1).Value.ToString
        txtEmployeeAge.Text = agentView.SelectedCells(2).Value.ToString
        txtEmployeePhone.Text = agentView.SelectedCells(3).Value.ToString
        txtEmployeePassword.Text = agentView.SelectedCells(3).Value.ToString
    End Sub

    Private Sub btnEmpClear_Click(sender As Object, e As EventArgs) Handles btnEmpClear.Click
        txtEmployeeID.Clear()
        txtEmployeeName.Clear()
        txtEmployeeAge.Clear()
        txtEmployeePhone.Clear()
        txtEmployeePassword.Clear()
    End Sub

    Private Sub btnEmpBack_Click(sender As Object, e As EventArgs) Handles btnEmpBack.Click
        Me.Hide()
        home.Show()
    End Sub
End Class
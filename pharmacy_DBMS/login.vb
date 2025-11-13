Imports System.Data.SqlClient
Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As New SqlConnection("Data Source=LAPTOP-Q6SCSE66\SQLEXPRESS;Initial Catalog=pharmacy_DBMS;Integrated Security=True;TrustServerCertificate=True")
        con.Open()
        Dim query As String = "SELECT COUNT(*) FROM tblagent WHERE EmpName=@EmpName AND EmpPassword=@EmpPassword"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@EmpName", txtUsername.Text)
        cmd.Parameters.AddWithValue("@EmpPassword", txtPassword.Text)
        Dim count As Integer = Convert.ToInt64(cmd.ExecuteScalar)
        con.Close()
        If count > 0 Then
            MessageBox.Show("Login Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Clear()
            txtPassword.Clear()
            home.Show()
            Me.Hide()
        Else
            MessageBox.Show("Login Error")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnLoginClose_Click(sender As Object, e As EventArgs) Handles btnLoginClose.Click
        Me.Close()

    End Sub
End Class
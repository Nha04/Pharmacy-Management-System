Public Class home
    Private Sub medicinePicBox_Click(sender As Object, e As EventArgs) Handles medicinePicBox.Click
        Me.Hide()
        Dim Med = New medicine
        medicine.Show()
    End Sub

    Private Sub manufacturerPicBox_Click(sender As Object, e As EventArgs) Handles manufacturerPicBox.Click
        Me.Hide()
        Dim Manu = New manufacturer
        manufacturer.Show()
    End Sub

    Private Sub agentPicBox_Click(sender As Object, e As EventArgs) Handles agentPicBox.Click
        Me.Hide()
        Dim agent = New agent
        agent.Show()
    End Sub

    Private Sub logoutPicBox_Click(sender As Object, e As EventArgs) Handles logoutPicBox.Click
        Me.Hide()
        login.Show()

    End Sub

    Private Sub billingPicBox_Click(sender As Object, e As EventArgs) Handles customerPicBox.Click
        Me.Hide()
        Dim billing = New customer
        customer.Show()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

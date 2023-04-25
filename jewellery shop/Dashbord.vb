Public Class Dashbord
    Private Sub Dashbord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles ProductsBtn.Click
        Me.Hide()
        Dim pro = New Products
        pro.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles CustomerBtn.Click
        Me.Hide()
        Dim Cus = New Customers
        Cus.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles BillBtn.Click
        Me.Hide()
        Dim Bill = New Billing
        Bill.Show()
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Application.Exit()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Dim back = New Login
        back.Show()
    End Sub
End Class
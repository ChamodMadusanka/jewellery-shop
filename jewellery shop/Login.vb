Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Application.Exit()

    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If UserName.Text = "" Or Passwd.Text = "" Then
            MsgBox("Enter Your UserName And Password")
        ElseIf UserName.Text = "Chamod" And Passwd.Text = "1234" Then
            Dim Dash = New Dashbord
            Dash.Show()
            Me.Hide()
        Else
            MsgBox("UserName Or Password Is Wrong")

        End If

    End Sub
End Class
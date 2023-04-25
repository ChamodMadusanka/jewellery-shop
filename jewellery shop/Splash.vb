Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Splash
    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Dim Log = New Login
            Log.Show()
            Timer1.Enabled = False


        End If
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub progressBar1_ValueChanged(sender As Object, e As EventArgs) Handles progressBar1.ValueChanged

    End Sub
End Class

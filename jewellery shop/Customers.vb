Imports System.Data.SqlClient

Public Class Customers
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\JewelleryVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If CustNameTb.Text = "" Or PhoneTb.Text = "" Or AddressTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Con.Open()
                Dim query = "insert into CustomerTbl values('" & CustNameTb.Text & "' , '" & PhoneTb.Text & "' , '" & AddressTb.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Customer saved Successfully")
                Con.Close()
                Populate()
                Clear()

            Catch ex As Exception

            End Try
        End If



    End Sub

    Dim key = 0

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        Application.Exit()
    End Sub
    Private Sub Clear()
        CustNameTb.Text = ""
        PhoneTb.Text = ""
        AddressTb.Text = ""
        key = 0

    End Sub
    Private Sub Populate()
        Con.Open()
        Dim query = "select * from CustomerTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        CustomerDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub CustomerDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CustomerDGV.CellMouseClick
        Dim row As DataGridViewRow = CustomerDGV.Rows(e.RowIndex)
        CustNameTb.Text = row.Cells(1).Value.ToString
        PhoneTb.Text = row.Cells(2).Value.ToString
        AddressTb.Text = row.Cells(3).Value.ToString
        If CustNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MsgBox("Select The Product to Delete")
        Else
            Try
                Con.open()
                Dim query = "delete from CustomerTbl where CustId = " & key & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Customer deleted Successfully")
                Con.Close()
                Populate()
                Clear()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If CustNameTb.Text = "" Or PhoneTb.Text = "" Or AddressTb.Text = "" Then
            MsgBox("Select The Product To Edit")

        Else
            Try
                Con.open()
                Dim query = "Update CustomerTbl set CustName= '" & CustNameTb.Text & "' , CustPhone= '" & PhoneTb.Text & "' , CustAdd= '" & AddressTb.Text & "' where CustId= " & key & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Customer Updated Successfully")
                Con.Close()
                Populate()
                Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Clear()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Populate()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Hide()
        Dim Bill = New Billing
        Bill.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Dim Bill = New Products
        Bill.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
        Dim back = New Login
        back.Show()
    End Sub
End Class
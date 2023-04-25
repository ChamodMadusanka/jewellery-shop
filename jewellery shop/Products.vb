Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab

Public Class Products
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\JewelleryVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub CustomerBtn_Click(sender As Object, e As EventArgs) Handles CustomerBtn.Click
        Me.Hide()
        Dim Cus = New Customers
        Cus.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles BillBtn.Click
        Me.Hide()
        Dim Bill = New Billing
        Bill.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Hide()
        Dim back = New Dashbord
        back.Show()
    End Sub

    Private Sub Clear()
        ItemNameTb.Text = ""
        CatCb.SelectedIndex = 0
        TypeCb.SelectedIndex = 0
        PriceTb.Text = ""
        QtyTb.Text = ""
    End Sub

    Private Sub populate()
        Con.open()
        Dim query = "select * from ItemTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ProductDGV.DataSource = ds.Tables(0)

        Con.Close()

    End Sub
    Private Sub FilterType()
        Con.open()
        Dim query = "select * from ItemTbl where ItType= '"
        Dim adapter As SqlDataAdapter
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ProductDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub
    Private Sub FilterCat()
        Con.open()
        Dim query = "select * from ItemTbl where ItCat= '"
        Dim adapter As SqlDataAdapter
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ProductDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If ItemNameTb.Text = "" Or CatCb.SelectedIndex = -1 Or TypeCb.SelectedIndex = -1 Or PriceTb.Text = "" Or QtyTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Con.open()
                Dim query = "insert into ItemTbl values('" & ItemNameTb.Text & "' , '" & CatCb.SelectedItem.ToString() & "' , '" & TypeCb.SelectedItem.ToString() & "' , " & PriceTb.Text & " , " & QtyTb.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Item saved Successfully")
                Con.Close()
                populate()
                Clear()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        populate()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Clear()
    End Sub
    Dim key = 0
    Private Sub ProductDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ProductDGV.CellMouseClick

        Dim row As DataGridViewRow = ProductDGV.Rows(e.RowIndex)
        ItemNameTb.Text = row.Cells(1).Value.ToString
        CatCb.SelectedItem = row.Cells(2).Value.ToString
        TypeCb.SelectedItem = row.Cells(3).Value.ToString
        PriceTb.Text = row.Cells(4).Value.ToString
        QtyTb.Text = row.Cells(5).Value.ToString

        If ItemNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)

        End If

    End Sub

    Private Sub DeleteBtn(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        If key = 0 Then
            MsgBox("Select The Product To Delete")
        Else
            Try
                Con.open()
                Dim query = "delete from ItemTbl where ItId = " & key & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Item deleted Successfully")
                Con.Close()
                populate()
                Clear()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub UpdateBtn(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        If ItemNameTb.Text = "" Or CatCb.SelectedIndex = -1 Or TypeCb.SelectedIndex = -1 Or PriceTb.Text = "" Or QtyTb.Text = "" Then
            MsgBox("Select The product To Edit")
        Else
            Try
                Con.open()
                Dim query = "Update ItemTbl set ItName= '" & ItemNameTb.Text & "' , ItCat='" & CatCb.SelectedItem.ToString() & "' , ItType='" & TypeCb.SelectedItem.ToString() & "' , ItPrice=" & PriceTb.Text & " , ItQty= " & QtyTb.Text & " where ItId=" & key & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Item Updated Successfully")
                Con.Close()
                populate()
                Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Guna2ComboBox4_SelectionChangeCommitted(sender As Object, e As EventArgs)
        FilterCat()
    End Sub

    Private Sub Guna2ComboBox3_SelectionChangeCommitted(sender As Object, e As EventArgs)
        FilterType()
    End Sub

    Private Sub Guna2ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
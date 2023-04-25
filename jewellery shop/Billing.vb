Imports System.Data.SqlClient
Public Class Billing
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\JewelleryVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayCustomers()
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
    Private Sub DisplayProducts()
        Con.Open()
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
    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Price.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles productsBtn.Click
        Me.Hide()
        Dim pro = New Products
        pro.Show()
    End Sub

    Private Sub customerBtn_Click(sender As Object, e As EventArgs) Handles customerBtn.Click
        Me.Hide()
        Dim pro = New Customers
        pro.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        DisplayCustomers()
        DisplayProducts()
    End Sub


    Dim key = 0, Stock = 0
    Dim CustKey = 0
    Private Sub Reset()
        ProductName.Text = ""
        Qty.Text = ""
        Price.Text = ""
        CustName.Text = ""
        key = 0
        CustKey = 0
    End Sub
    Dim i = 0, GrdTot = 0

    Private Sub UpdateItem()
        Try
            Dim NewQty = Stock - Convert.ToInt32(Qty.Text)
            Con.Open()
            Dim Query = "Update ItemTble Set ItQty=" & NewQty & "Wher ItId " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            'MsgBox("Item Updated SuccessFully")
            Con.Close()
            DisplayProducts()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ProductDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDGV.CellContentClick
        Dim row As DataGridViewRow = ProductDGV.Rows(e.RowIndex)
        ProductName.Text = row.Cells(1).Value.ToString
        Price.Text = row.Cells(4).Value.ToString

        If ProductName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            Stock = Convert.ToInt32(row.Cells(5).Value.ToString)
        End If
    End Sub


    Private Sub AddBill_Click(sender As Object, e As EventArgs) Handles AddBill.Click
        If Price.Text = "" Then
            MsgBox("Enter The Quantity")
        ElseIf ProductName.Text = "" Then
            MsgBox("Select The Item")
        ElseIf Convert.ToInt32(Qty.Text) > Stock Then
            MsgBox("No Enough Stock")
        Else
            Dim rnum As Integer = BillDVG.Rows.Add()
            i = i + 1
            Dim total = Convert.ToInt32(Qty.Text) * Convert.ToInt32(Price.Text)
            BillDVG.Rows.Item(rnum).Cells("column1").Value = i
            BillDVG.Rows.Item(rnum).Cells("column2").Value = ProductName.Text
            BillDVG.Rows.Item(rnum).Cells("column3").Value = Price.Text
            BillDVG.Rows.Item(rnum).Cells("column4").Value = Qty.Text
            BillDVG.Rows.Item(rnum).Cells("column5").Value = total
            GrdTot = GrdTot + total
            Dim tot As String
            tot = "Rs" + Convert.ToString(GrdTot)
            totalLbl.Text = tot
            UpdateItem()
            Reset()
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        e.Graphics.DrawString("Jewellary Shop", New Font("Century Gothic", 25), Brushes.MidnightBlue, 300, 40)
        e.Graphics.DrawString("*****Your Bill*****", New Font("Century Gothic", 16), Brushes.MidnightBlue, 320, 90)
        Dim bm As New Bitmap(Me.BillDVG.Width, Me.BillDVG.Height)
        BillDVG.DrawToBitmap(bm, New Rectangle(0, 0, Me.BillDVG.Width, Me.BillDVG.Height))
        e.Graphics.DrawImage(bm, 85, 200)
        e.Graphics.DrawString("Total Amount Rs " + GrdTot.ToString, New Font("Century Gothic", 18), Brushes.MidnightBlue, 280, 500)
        e.Graphics.DrawString("**********Thank For Buying In Our Shop**********", New Font("Century Gothic", 15), Brushes.Crimson, 170, 580)

    End Sub
    Private Sub AddBills()
        Try
            Con.open()
            Dim query = "insert into BillTbl values(" & CustKey & ", '" & CustName.Text & "' , " & GrdTot & " , '" & DateTime.Today.Date & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            'MsgBox ("Bill Saved Successfully")
            Con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Dim back = New Login
        back.Show()
    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        AddBills()
        PrintPreviewDialog1.Show()


    End Sub

    Private Sub CustomerDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDGV.CellContentClick
        Dim row As DataGridViewRow = CustomerDGV.Rows(e.RowIndex)
        CustName.Text = row.Cells(1).Value.ToString
        If CustName.Text = "" Then
            CustKey = 0
        Else
            CustKey = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub



End Class
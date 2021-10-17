Public Class Order_list
    Dim sqda As New SQLDataAccess

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TrialList.ShowDialog()
    End Sub

    Private Sub Order_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        GRID1.AllowUserToAddRows = False
        GRID1.AllowUserToDeleteRows = False
        GRID1.AllowUserToResizeRows = False
        GRID1.AllowUserToOrderColumns = False
        GRID1.RowHeadersVisible = False
        GRID1.ReadOnly = True
        Order_Track(GRID1)
    End Sub
    Private Sub Operations(ByVal type As operationtype)
        Dim OrderModel As OrderModel = New OrderModel()

        OrderModel.TraderName = CustBox.Text
        OrderModel.PersonName = PersonBox.Text
        OrderModel.ContactNo = Contactbox.Text
        OrderModel.AlternateContact = AltContactBox.Text
        OrderModel.EmailID = EmailBox.Text
        OrderModel.ProductName = ProductBox.Text
        OrderModel.GivenDate = GivenDate.Value.Date.ToString("yyyy-MM-dd")
        OrderModel.PaymentMode = PaymentBox.Text
        OrderModel.Status = 1
        OrderModel.Remarks = RemarkBox.Text
        OrderModel.TID = If(String.IsNullOrEmpty(TcodeBox.Text), 0, TcodeBox.Text)

        If type = operationtype.Insert Then
            sqda.SavedDataOrder(OrderModel)
            MsgBox("Added Successfully!!")
        Else
            OrderModel.LeadID = LeadBox.Text
            OrderModel.Status = Statusbox.Text
            sqda.UpdateDataOrder(OrderModel)
            MsgBox("Edited Successfully!!")
        End If

        CustBox.Clear()
        PersonBox.Clear()
        Contactbox.Clear()
        AltContactBox.Clear()
        EmailBox.Clear()
        ProductBox.Clear()
        PaymentBox.Clear()
        RemarkBox.Clear()
        TcodeBox.Clear()
        Order_Track(GRID1)
    End Sub
    Public Sub Order_Track(ByVal datagridview As DataGridView)
        Dim dt As New DataTable
        dt = sqda.LoadData("OrderList")
        datagridview.DataSource = dt
        RecordLabel.Text = dt.Rows.Count.ToString("000")
    End Sub

    Private Sub GRID1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRID1.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 1 Then
                LeadBox.Text = GRID1(0, e.RowIndex).Value
                CustBox.Text = GRID1(1, e.RowIndex).Value
                PersonBox.Text = GRID1(2, e.RowIndex).Value
                Contactbox.Text = GRID1(3, e.RowIndex).Value
                AltContactBox.Text = GRID1(4, e.RowIndex).Value
                EmailBox.Text = GRID1(5, e.RowIndex).Value
                ProductBox.Text = GRID1(6, e.RowIndex).Value
                GivenDate.Value = GRID1(7, e.RowIndex).Value
                PaymentBox.Text = GRID1(8, e.RowIndex).Value
                Statusbox.Text = GRID1(9, e.RowIndex).Value
                TcodeBox.Text = GRID1(10, e.RowIndex).Value
                RemarkBox.Text = GRID1(11, e.RowIndex).Value.ToString
                Button1.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Operations(operationtype.Insert)
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As KeyEventArgs) Handles TextBox9.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(TextBox9.Text) Then
                MsgBox("Please enter a proper Filter")
                Exit Sub
            End If
            Dim dt As DataTable
            Dim dv As DataView
            dt = GRID1.DataSource
            dv = dt.DefaultView
            Try
                If TextBox9.Text.ToLower = "clear" Or TextBox9.Text.ToUpper = "CLEAR" Then
                    dv.RowFilter = ""
                Else
                    dv.RowFilter = TextBox9.Text
                End If
            Catch ex As Exception
                MsgBox("That filter didnt work , please try again!!")
            End Try

            dv.RowStateFilter = DataViewRowState.CurrentRows
            TextBox9.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox9.Text = vbCrLf
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Operations(operationtype.Update)
        Button1.Enabled = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Write the filters in this format 
1. If it is Exact search
<ColumnName> = '<Fieldvalue>'
2. If it is an approximate value
<ColumnName> like '%<value>' -- Anything ending with the value
<ColumnName> like '%<value>%' -- Anythin having the value in it.
<ColumnName> like '*<value>' -- anyting ending with <value>
<ColumnName> like '<value>*' -- Anything starting with the <value>")
    End Sub
End Class
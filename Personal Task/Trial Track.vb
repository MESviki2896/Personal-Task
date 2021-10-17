Imports Personal_Task.SQLDataAccess
Public Class Trial_Track
    Dim sqda As New SQLDataAccess
    Public Sub Trial_Track(ByVal datagridview As DataGridView)
        Dim dt As New DataTable
        dt = sqda.LoadData()
        datagridview.DataSource = dt
        RecordLabel.Text = dt.Rows.Count.ToString("000")
    End Sub
    Private Sub Trial_Track_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Personal_Task.Form1
        Trial_Track(GRID1)
        GRID1.ReadOnly = True
        GRID1.AllowUserToAddRows = False
        GRID1.AllowUserToDeleteRows = False
        GRID1.AllowUserToOrderColumns = False
        GRID1.RowHeadersVisible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Operations(operationtype.Insert)
    End Sub
    Private Sub Operations(ByVal type As operationtype)
        Dim TrialMod As TrialTrackModel = New TrialTrackModel()
        TrialMod.city = CityBox.Text
        TrialMod.Contact_Date = ContactDate.Value.Date.ToString("yyyy-MM-dd")
        TrialMod.Contact_Num = ContactBox.Text
        TrialMod.Contact_Person = PersonBox.Text
        TrialMod.CustomerName = CustBox.Text
        TrialMod.DocketNumber = DocketBox.Text
        TrialMod.ProductName = ProductBox.Text
        TrialMod.Qty = QtyBox.Text
        TrialMod.Remarks = RemarksBox.Text
        TrialMod.Sample_Date = SampleDate.Value.Date.ToString("yyyy-MM-dd")
        TrialMod.ShippingDate = ShipDate.Value.Date.ToString("yyyy-MM-dd")
        TrialMod.TMode = ShipModeBox.Text

        If type = operationtype.Insert Then
            sqda.SavedData(TrialMod)
            MsgBox("Added Successfully!!")

        Else
            TrialMod.LeadID = TCodeBox.Text
            sqda.UpdateData(TrialMod)
            MsgBox("Edited Successfully!!")
        End If

        CityBox.Clear()
        ContactBox.Clear()
        PersonBox.Clear()
        CustBox.Clear()
        DocketBox.Clear()
        ProductBox.Clear()
        QtyBox.Clear()
        RemarksBox.Clear()
        ShipModeBox.Clear()
        TCodeBox.Clear()
        Trial_Track(GRID1)
    End Sub
    Private Sub GRID1_CellContentDBClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRID1.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 1 Then
                TCodeBox.Text = GRID1(0, e.RowIndex).Value
                CustBox.Text = GRID1(1, e.RowIndex).Value
                PersonBox.Text = GRID1(3, e.RowIndex).Value
                ContactBox.Text = GRID1(4, e.RowIndex).Value
                CityBox.Text = GRID1(6, e.RowIndex).Value
                DocketBox.Text = GRID1(10, e.RowIndex).Value
                ProductBox.Text = GRID1(2, e.RowIndex).Value
                ContactDate.Value = GRID1(5, e.RowIndex).Value
                SampleDate.Value = GRID1(7, e.RowIndex).Value
                ShipDate.Value = GRID1(8, e.RowIndex).Value
                ShipModeBox.Text = GRID1(11, e.RowIndex).Value
                QtyBox.Text = GRID1(9, e.RowIndex).Value
                RemarksBox.Text = GRID1(12, e.RowIndex).Value
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Operations(operationtype.Update)
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As KeyEventArgs) Handles TextBox9.KeyDown
        If e.KeyCode = Keys.Enter Then
            Setfilter("CustomerName", TextBox9)
            'GRID1.DataSource = dv.ToTable()
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As KeyEventArgs) Handles TextBox10.KeyDown
        If e.KeyCode = Keys.Enter Then
            Setfilter("City", TextBox10)
            'GRID1.DataSource = dv.ToTable()
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As KeyEventArgs) Handles TextBox11.KeyDown
        If e.KeyCode = Keys.Enter Then
            Setfilter("ProductName", TextBox11)
            'GRID1.DataSource = dv.ToTable()
        End If
    End Sub
    Private Sub Setfilter(ByVal columnname As String, ByVal textbx As TextBox)
        Dim dv As New DataView
        dv = GetDataview()
        If dv Is Nothing Then
            Exit Sub
        End If
        Dim existdata As String = dv.RowFilter

        If String.IsNullOrEmpty(existdata) Then
            existdata = ""
            Dim filt = existdata + $"{columnname} LIKE '{textbx.Text}'"
            dv.RowFilter = filt
        Else
            If TextBox9.Text <> "" Then
                dv.RowFilter = existdata + " AND " + $"{columnname} LIKE '{textbx.Text}'"
            End If
        End If
        dv.RowStateFilter = DataViewRowState.CurrentRows
    End Sub
    Private Function GetDataview() As DataView
        Dim dv As New DataView
        Dim dt As New DataTable
        dt = GRID1.DataSource
        dv = dt.DefaultView
        If dv.Count < 0 Then
            Return Nothing
        End If
        Return dv
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dv As New DataView
        dv = GetDataview()
        If dv IsNot Nothing Then
            dv.RowFilter = String.Empty
            dv.RowStateFilter = DataViewRowState.CurrentRows
        End If
    End Sub

End Class


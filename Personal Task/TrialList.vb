Public Class TrialList
    Private Sub TrialList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GRID1.ReadOnly = True
        GRID1.RowHeadersVisible = False
        GRID1.AllowUserToAddRows = False
        GRID1.AllowUserToDeleteRows = False
        GRID1.AllowUserToOrderColumns = False
        Trial_Track.Trial_Track(GRID1)
    End Sub

    Private Sub GRID1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRID1.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 1 Then
                Order_list.TcodeBox.Text = GRID1(0, e.RowIndex).Value.ToString
                Me.Close()
            End If
        End If
    End Sub

    Private Sub TextBox1_Keydown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(TextBox1.Text) Then
                MsgBox("Please enter a Proper Filter for the fields!!")
                Exit Sub
            End If
            Dim dt As New DataTable
            Dim dv As New DataView

            dt = GRID1.DataSource
            dv = dt.DefaultView
            If TextBox1.Text.ToLower = "clear" Then
                dv.RowFilter = ""
            Else
                dv.RowFilter = TextBox1.Text
            End If
            TextBox1.Clear()
        End If
    End Sub


End Class
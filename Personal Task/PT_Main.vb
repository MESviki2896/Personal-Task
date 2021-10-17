Public Class Form1
    Private Sub changemdicolor()
        For Each ctrl As Control In Me.Controls
            If ctrl.Name = "" Then
                ctrl.BackColor = Color.FromKnownColor(KnownColor.Lavender)
            End If
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changemdicolor()
        WindowState = FormWindowState.Maximized
        BackgroundWorker1.RunWorkerAsync()
        CheckForIllegalCrossThreadCalls = False
        BackgroundWorker1.WorkerSupportsCancellation = True
    End Sub
    Private Sub Form1_END(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        BackgroundWorker1.CancelAsync()
        Threading.Thread.Sleep(100)
    End Sub
    Private Sub TralTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TralTaskToolStripMenuItem.Click
        Trial_Track.Show()
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        While Not e.Cancel
            Try
                Dim value = Now.ToString()
                Label15.Text = value
                If BackgroundWorker1.CancellationPending Then
                    Exit Sub
                End If
            Catch ex As Exception
                Exit Sub
            End Try
            Threading.Thread.Sleep(750)
        End While
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Personal_task___About.Show()
    End Sub

    Private Sub PurchaseListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseListToolStripMenuItem.Click
        Order_list.Show()
    End Sub
End Class

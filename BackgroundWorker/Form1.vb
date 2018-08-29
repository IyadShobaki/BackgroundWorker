Imports System.ComponentModel



Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For i = 0 To 25
            PictureBox1.Image = My.Resources.Cleveland
            Label1.Text = i
            BackgroundWorker1.ReportProgress(i)
            System.Threading.Thread.Sleep(200)
            Label1.Refresh()

        Next
        For i = 25 To 50
            PictureBox1.Image = My.Resources.Houston
            Label1.Text = i
            BackgroundWorker1.ReportProgress(i)
            System.Threading.Thread.Sleep(200)
            Label1.Refresh()

        Next
        For i = 50 To 75
            PictureBox1.Image = My.Resources.LasVegas
            Label1.Text = i
            BackgroundWorker1.ReportProgress(i)
            System.Threading.Thread.Sleep(200)
            Label1.Refresh()

        Next
        For i = 75 To 100
            PictureBox1.Image = My.Resources.Miami
            Label1.Text = i
            BackgroundWorker1.ReportProgress(i)
            System.Threading.Thread.Sleep(200)
            Label1.Refresh()

        Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        ProgressBar1.Value = e.ProgressPercentage

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Label1.Text = "Success!"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CheckForIllegalCrossThreadCalls = False

    End Sub
End Class

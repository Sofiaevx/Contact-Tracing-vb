Public Class ContactTracingForm
    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        Dim nextpage As New Questioner
        Me.Hide()
        nextpage.Show()
    End Sub

    Private Sub QRBtn_Click(sender As Object, e As EventArgs) Handles QRBtn.Click
        Dim scanner As New QRCode_Scanner
        Me.Hide()
        scanner.Show()
    End Sub
End Class

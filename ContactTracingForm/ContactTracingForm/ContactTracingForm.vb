Public Class ContactTracingForm
    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        Dim nextpage As New Questioner
        Me.Hide()
        nextpage.Show()
    End Sub
End Class

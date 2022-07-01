Imports System.Diagnostics
Imports System.Drawing.Imaging
Imports AForge.Video
Imports System.Drawing
Imports AForge.Video.DirectShow
Imports System.IO
Imports AForge






Public Class QRCode_Scanner

    Dim qrcodescanner As VideoCaptureDevice
    Dim bitmapscanner As Bitmap
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Dim home As New ContactTracingForm
        Me.Hide()
        home.Show()
    End Sub

    Private Sub ScanBtn_Click(sender As Object, e As EventArgs) Handles ScanBtn.Click
        Dim cameraDisplay As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        If cameraDisplay.ShowDialog() = DialogResult.OK Then
            qrcodescanner = cameraDisplay.VideoDevice
            AddHandler qrcodescanner.NewFrame, New NewFrameEventHandler(AddressOf CaptureDisplay)
            qrcodescanner.Start()
        End If
    End Sub
    Private Sub CaptureDisplay(sender As Object, eventArgs As NewFrameEventArgs)
        bitmapscanner = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        QRScanner.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
End Class
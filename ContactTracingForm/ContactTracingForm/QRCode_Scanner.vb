Imports System.Diagnostics
Imports System.Drawing.Imaging
Imports AForge.Video
Imports System.Drawing
Imports AForge.Video.DirectShow
Imports System.IO
Imports AForge
Imports ZXing
Imports ZXing.Aztec





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
            Timer.Start()
        End If
    End Sub
    Private Sub CaptureDisplay(sender As Object, eventArgs As NewFrameEventArgs)
        bitmapscanner = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        QRScanner.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If QRScanner.Image IsNot Nothing Then

            Dim qrcodescanner As BarcodeReader = New BarcodeReader()

            Dim result As ZXing.Result = qrcodescanner.Decode(DirectCast(QRScanner.Image, Bitmap))

            If result IsNot Nothing Then

                Dim question As New Questioner
                question.output = result.ToString()
                question.condition = True
                Timer.Stop()
                Me.Hide()
                question.Show()

            End If
        End If
    End Sub
End Class
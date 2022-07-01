<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QRCode_Scanner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.QRScanner = New System.Windows.Forms.PictureBox()
        Me.ScanBtn = New System.Windows.Forms.Button()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.CTlabel = New System.Windows.Forms.Label()
        Me.QRLabel = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.QRScanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QRScanner
        '
        Me.QRScanner.BackColor = System.Drawing.Color.White
        Me.QRScanner.Location = New System.Drawing.Point(29, 83)
        Me.QRScanner.Name = "QRScanner"
        Me.QRScanner.Size = New System.Drawing.Size(241, 213)
        Me.QRScanner.TabIndex = 0
        Me.QRScanner.TabStop = False
        '
        'ScanBtn
        '
        Me.ScanBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ScanBtn.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ScanBtn.Location = New System.Drawing.Point(105, 302)
        Me.ScanBtn.Name = "ScanBtn"
        Me.ScanBtn.Size = New System.Drawing.Size(86, 34)
        Me.ScanBtn.TabIndex = 2
        Me.ScanBtn.TabStop = False
        Me.ScanBtn.Text = "Scan"
        Me.ScanBtn.UseVisualStyleBackColor = False
        '
        'HomeBtn
        '
        Me.HomeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.HomeBtn.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HomeBtn.Location = New System.Drawing.Point(195, 368)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(75, 27)
        Me.HomeBtn.TabIndex = 3
        Me.HomeBtn.TabStop = False
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.UseVisualStyleBackColor = False
        '
        'CTlabel
        '
        Me.CTlabel.AutoSize = True
        Me.CTlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CTlabel.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CTlabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.CTlabel.Location = New System.Drawing.Point(82, 14)
        Me.CTlabel.Name = "CTlabel"
        Me.CTlabel.Size = New System.Drawing.Size(132, 20)
        Me.CTlabel.TabIndex = 4
        Me.CTlabel.Text = "Contact Tracing"
        '
        'QRLabel
        '
        Me.QRLabel.AutoSize = True
        Me.QRLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.QRLabel.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.QRLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.QRLabel.Location = New System.Drawing.Point(75, 40)
        Me.QRLabel.Name = "QRLabel"
        Me.QRLabel.Size = New System.Drawing.Size(148, 20)
        Me.QRLabel.TabIndex = 5
        Me.QRLabel.Text = "QR Code Scanner"
        '
        'Timer
        '
        '
        'QRCode_Scanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(299, 404)
        Me.Controls.Add(Me.QRLabel)
        Me.Controls.Add(Me.CTlabel)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.ScanBtn)
        Me.Controls.Add(Me.QRScanner)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QRCode_Scanner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QRCode_Scanner"
        CType(Me.QRScanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QRScanner As PictureBox
    Friend WithEvents ScanBtn As Button
    Friend WithEvents HomeBtn As Button
    Friend WithEvents CTlabel As Label
    Friend WithEvents QRLabel As Label
    Friend WithEvents Timer As Timer
End Class

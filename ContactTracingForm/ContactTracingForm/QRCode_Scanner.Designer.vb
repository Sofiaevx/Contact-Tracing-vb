﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ScanBtn = New System.Windows.Forms.Button()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.CTlabel = New System.Windows.Forms.Label()
        Me.QRLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(29, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 213)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(303, 20)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(478, 375)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'ScanBtn
        '
        Me.ScanBtn.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ScanBtn.Location = New System.Drawing.Point(94, 302)
        Me.ScanBtn.Name = "ScanBtn"
        Me.ScanBtn.Size = New System.Drawing.Size(86, 34)
        Me.ScanBtn.TabIndex = 2
        Me.ScanBtn.Text = "Scan"
        Me.ScanBtn.UseVisualStyleBackColor = True
        '
        'HomeBtn
        '
        Me.HomeBtn.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HomeBtn.Location = New System.Drawing.Point(195, 372)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(75, 23)
        Me.HomeBtn.TabIndex = 3
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'CTlabel
        '
        Me.CTlabel.AutoSize = True
        Me.CTlabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CTlabel.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CTlabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.CTlabel.Location = New System.Drawing.Point(82, 14)
        Me.CTlabel.Name = "CTlabel"
        Me.CTlabel.Size = New System.Drawing.Size(145, 26)
        Me.CTlabel.TabIndex = 4
        Me.CTlabel.Text = "Contact Tracing"
        '
        'QRLabel
        '
        Me.QRLabel.AutoSize = True
        Me.QRLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.QRLabel.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.QRLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.QRLabel.Location = New System.Drawing.Point(75, 40)
        Me.QRLabel.Name = "QRLabel"
        Me.QRLabel.Size = New System.Drawing.Size(159, 26)
        Me.QRLabel.TabIndex = 5
        Me.QRLabel.Text = "QR Code Scanner"
        '
        'QRCode_Scanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.QRLabel)
        Me.Controls.Add(Me.CTlabel)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.ScanBtn)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "QRCode_Scanner"
        Me.Text = "QRCode_Scanner"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ScanBtn As Button
    Friend WithEvents HomeBtn As Button
    Friend WithEvents CTlabel As Label
    Friend WithEvents QRLabel As Label
End Class

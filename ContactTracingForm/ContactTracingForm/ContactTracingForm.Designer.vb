<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContactTracingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContactTracingForm))
        Me.Info1 = New System.Windows.Forms.Label()
        Me.Info3 = New System.Windows.Forms.Label()
        Me.Info2 = New System.Windows.Forms.Label()
        Me.Info4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NextBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Info1
        '
        Me.Info1.AutoSize = True
        Me.Info1.BackColor = System.Drawing.Color.White
        Me.Info1.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Info1.Location = New System.Drawing.Point(34, 35)
        Me.Info1.Name = "Info1"
        Me.Info1.Size = New System.Drawing.Size(221, 21)
        Me.Info1.TabIndex = 0
        Me.Info1.Text = "WHAT IS CONTACT TRACING?"
        '
        'Info3
        '
        Me.Info3.AutoSize = True
        Me.Info3.BackColor = System.Drawing.Color.White
        Me.Info3.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Info3.Location = New System.Drawing.Point(34, 184)
        Me.Info3.Name = "Info3"
        Me.Info3.Size = New System.Drawing.Size(139, 21)
        Me.Info3.TabIndex = 1
        Me.Info3.Text = "HOW CAN I HELP?"
        '
        'Info2
        '
        Me.Info2.AutoSize = True
        Me.Info2.BackColor = System.Drawing.Color.White
        Me.Info2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Info2.Location = New System.Drawing.Point(34, 67)
        Me.Info2.Name = "Info2"
        Me.Info2.Size = New System.Drawing.Size(307, 85)
        Me.Info2.TabIndex = 2
        Me.Info2.Text = resources.GetString("Info2.Text")
        '
        'Info4
        '
        Me.Info4.AutoSize = True
        Me.Info4.BackColor = System.Drawing.Color.White
        Me.Info4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Info4.Location = New System.Drawing.Point(34, 217)
        Me.Info4.Name = "Info4"
        Me.Info4.Size = New System.Drawing.Size(352, 85)
        Me.Info4.TabIndex = 3
        Me.Info4.Text = resources.GetString("Info4.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(413, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 267)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.NextBtn)
        Me.Panel1.Location = New System.Drawing.Point(24, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 332)
        Me.Panel1.TabIndex = 5
        '
        'NextBtn
        '
        Me.NextBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.NextBtn.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NextBtn.Location = New System.Drawing.Point(650, 294)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(75, 26)
        Me.NextBtn.TabIndex = 0
        Me.NextBtn.Text = "Next"
        Me.NextBtn.UseVisualStyleBackColor = False
        '
        'ContactTracingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(790, 376)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Info4)
        Me.Controls.Add(Me.Info2)
        Me.Controls.Add(Me.Info3)
        Me.Controls.Add(Me.Info1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ContactTracingForm"
        Me.Text = "Contact Tracing"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Info1 As Label
    Friend WithEvents Info3 As Label
    Friend WithEvents Info2 As Label
    Friend WithEvents Info4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NextBtn As Button
End Class

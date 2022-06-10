Imports System.IO
Public Class Questioner
    Dim InfoTxtFile As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("Information.txt", True)
    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        'This block of codes is the user's personal information and will be added in the txtfile once the user click the submit button
        InfoTxtFile.WriteLine("********************************************")
        InfoTxtFile.WriteLine(vbCrLf + "Fullname: " + LNTextbox.Text + ", " + FNTextbox.Text + " " + MNTextbox.Text + ".")
        InfoTxtFile.WriteLine("Age: " + AgeTextbox.Text)
        If MaleRbtn.Checked Then
            InfoTxtFile.WriteLine("Sex: Male")
        Else
            InfoTxtFile.WriteLine("Sex: Female")
        End If
        InfoTxtFile.WriteLine("Birthday: " + BirthdayPicker.Value)
        InfoTxtFile.WriteLine("Contact Number: " + CNTextbox.Text)
        InfoTxtFile.WriteLine("Address: " + AddressTextbox.Text)
        InfoTxtFile.WriteLine("Email: " + EmailTextbox.Text + vbCrLf)
        rbtnvalue(No1, FeverLabel)
        rbtnvalue(No2, Coughslabel)
        rbtnvalue(No3, STLabel)
        rbtnvalue(No4, HeadacheLabel)
        rbtnvalue(No5, Question2Label)
        If Not No5.Checked Then
            InfoTxtFile.WriteLine("Date: " + DatePicker.Value)
            InfoTxtFile.WriteLine(Question3Label.Text + " " + Q3LNTextbox.Text + ", " + Q3FNTextbox.Text + " " + Q3MNTextbox.Text)
        End If
        InfoTxtFile.Close()
        MessageBox.Show("Submitted!!")
    End Sub


    Sub rbtnvalue(Myvalue, Myvar)
        Dim check As String
        If Myvalue.Equals("True") Then
            check = " No"
            InfoTxtFile.WriteLine(Myvar.text + check)
        Else
            check = " Yes"
            InfoTxtFile.WriteLine(Myvar.text + check)
        End If

    End Sub


    Private Sub TimerUpdate_Tick(sender As Object, e As EventArgs) Handles TimerUpdate.Tick
        If Not Yes5.Checked Then
            DatePicker.Visible = False
            DateLabel.Visible = False
            Question3Label.Visible = False
            Q3LNTextbox.Visible = False
            Q3FNTextbox.Visible = False
            Q3MNTextbox.Visible = False
            Q3FNLabel.Visible = False
            Q3MNLabel.Visible = False
            Q3LNLabel.Visible = False
            Q2Label.Visible = False
            Me.ClientSize = New System.Drawing.Size(747, 505)
            Me.SubmitBtn.Location = New System.Drawing.Point(317, 474)
        Else
            DatePicker.Visible = True
            DateLabel.Visible = True
            Question3Label.Visible = True
            Q3LNTextbox.Visible = True
            Q3FNTextbox.Visible = True
            Q3MNTextbox.Visible = True
            Q3FNLabel.Visible = True
            Q3MNLabel.Visible = True
            Q3LNLabel.Visible = True
            Q2Label.Visible = True
            Me.SubmitBtn.Location = New System.Drawing.Point(626, 587)

            Me.ClientSize = New System.Drawing.Size(747, 621)
        End If
    End Sub


End Class
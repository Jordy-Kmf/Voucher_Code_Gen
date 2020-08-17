Imports System.IO
Public Class Form1
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim prefix = bxPrefix.Text
        Dim rand As New Random

        If ckHyphen.Checked = True Then
            For j = 1 To numNCode.Value
                lstGenerated.Items.Add(prefix & "-" & rand.Next(10000, 99999) & "-" & rand.Next(10000, 99999) & "-" & rand.Next(10000, 99999))
            Next
        ElseIf ckHyphen.Checked = False Then
            For j = 1 To numNCode.Value
                lstGenerated.Items.Add(prefix & rand.Next(10000, 99999) & rand.Next(10000, 99999) & rand.Next(10000, 99999))
            Next
        End If
        If ckSort.Checked = True Then
            lstGenerated.Sorted = True
        Else lstGenerated.Sorted = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        bxPrefix.Text = bxPrefix.Text.ToUpper()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        bxPrefix.Text = bxPrefix.Text.ToLower()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Dim a = bxPrefix.Text.First
        Dim b = bxPrefix.Text.Remove(0, 1)
        bxPrefix.Text = a.ToString.ToUpper & b.ToLower
    End Sub

    Private Sub btnTFile_Click(sender As Object, e As EventArgs) Handles btnTFile.Click
        If lstGenerated.Items.Count > 0 Then
            Dim fileStream As System.IO.StreamWriter
            fileSave.Filter = "Text Files|*.txt"

            If fileSave.ShowDialog = Windows.Forms.DialogResult.OK Then
                fileStream = My.Computer.FileSystem.OpenTextFileWriter(fileSave.FileName, True)
                For Each code In lstGenerated.Items
                    fileStream.WriteLine(code)
                Next
                fileStream.Close()
            End If
        End If
    End Sub

    Private Sub ckSort_CheckedChanged(sender As Object, e As EventArgs) Handles ckSort.CheckedChanged
        If lstGenerated.Items.Count > 1 Then
            If lstGenerated.Sorted = False Then
                lstGenerated.Sorted = True
            Else lstGenerated.Sorted = False
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstGenerated.Items.Clear()
    End Sub
End Class

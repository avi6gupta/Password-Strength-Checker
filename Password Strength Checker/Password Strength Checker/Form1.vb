Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    
    Private Sub pwdBox_TextChanged(sender As Object, e As EventArgs) Handles pwdBox.TextChanged

        Dim pwd As String = pwdBox.Text



        Dim ucount As Integer = 0
        Dim lcount As Integer = 0
        Dim ncount As Integer = 0
        Dim scount As Integer = 0

        For Each c As Char In pwd
            Dim charCode As Integer = AscW(c)

            If charCode > 64 AndAlso charCode < 91 Then
                ucount += 1
            ElseIf charCode > 47 AndAlso charCode < 58 Then
                ncount += 1
            ElseIf charCode > 96 AndAlso charCode < 123 Then
                lcount += 1
            Else
                scount += 1

            End If
        Next

        Dim perfect As Integer = 100
        Dim score As Integer = 0
        Dim passLen As Integer = Len(pwd)

        score += passLen * 4
        If ucount > 0 Then
            score += (passLen - ucount) * 2
        End If

        If lcount > 0 Then
            score += (passLen - lcount) * 2
        End If
        score += ncount * 4
        score += scount * 6

        If (ucount + lcount) = passLen Then
            score -= passLen
        ElseIf ncount = passLen Then
            score -= passLen
        End If

        If score < perfect Then
            strgLabel.Text = CStr(score) & "%"
            ProgressBar.Value = score
        Else
            strgLabel.Text = "100%"
            ProgressBar.Value = 100

        End If




    End Sub
End Class

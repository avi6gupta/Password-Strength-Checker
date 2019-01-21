Partial Class Form1
    Inherits System.Windows.Forms.Form
    Private Sub DrawFormGradient(ByVal BottomColor As Color, ByVal TopColor As Color)
        ' Draws a gradient using the specified colors 
        ' on the entire page' https://www.youtube.com/watch?v=w7pNJwAnH38
        Dim objBrush As New Drawing2D.LinearGradientBrush(Me.DisplayRectangle, TopColor, BottomColor, Drawing2D.LinearGradientMode.Vertical)
        Dim objGraphics As Graphics = Me.CreateGraphics()
        objGraphics.FillRectangle(objBrush, Me.DisplayRectangle)
        objBrush.Dispose()
        objGraphics.Dispose()
    End Sub
    Private Sub pwdBox_TextChanged(sender As Object, e As EventArgs) Handles pwdBox.TextChanged


        Dim pwd As String = pwdBox.Text
        pwdBox.MaxLength = 100
        If hideChkBox.Checked = True Then
            pwdBox.UseSystemPasswordChar = True
        Else
            pwdBox.UseSystemPasswordChar = False
        End If


        Dim ucount As Integer = 0
        Dim lcount As Integer = 0
        Dim ncount As Integer = 0
        Dim scount As Integer = 0

        Dim sequential As Boolean = False
        Dim seq_up As Boolean = False
        Dim seq_low As Boolean = False
        Dim seq_num As Boolean = False
        Dim consi As Boolean = False

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
            score -= passLen * 2
        ElseIf scount = passLen Then
            score -= passLen * 3
        End If


        For i As Integer = 0 To pwd.Length - 2

            Dim seq As Integer = 1

            While AscW(pwd.Chars(i)) = AscW(pwd.Chars(i + 1)) - 1
                seq += 1
                i += 1
                If i = pwd.Length - 1 Then
                    Exit While
                End If
            End While
            If seq > 2 Then
                sequential = True
                score -= (seq - 3) * 3
            End If
        Next


        For i As Integer = 0 To pwd.Length - 2

            Dim rep_seq As Integer = 1

            While AscW(pwd.Chars(i)) = AscW(pwd.Chars(i + 1))
                rep_seq += 1
                i += 1
                If i = pwd.Length - 1 Then
                    Exit While
                End If
            End While
            If rep_seq > 1 Then
                consi = True
                Dim charCode As Integer = AscW(pwd.Chars(i))

                If charCode > 64 AndAlso charCode < 91 Then
                    score -= rep_seq
                ElseIf charCode > 47 AndAlso charCode < 58 Then
                    score -= 3 * rep_seq
                ElseIf charCode > 96 AndAlso charCode < 123 Then
                    score -= rep_seq
                Else
                    score -= 5 * rep_seq

                End If
            End If

        Next


        For i As Integer = 0 To pwd.Length - 2


            If AscW(pwd.Chars(i)) > 64 AndAlso AscW(pwd.Chars(i)) < 91 Then
                Dim consi_upper_seq As Integer = 1
                While AscW(pwd.Chars(i + 1)) > 64 AndAlso AscW(pwd.Chars(i + 1)) < 91
                    consi_upper_seq += 1
                    i += 1
                    If i = pwd.Length - 1 Then
                        Exit While
                    End If
                End While
                If consi_upper_seq > 1 Then
                    seq_up = True
                    score -= (consi_upper_seq)
                End If
            End If
        Next

        For i As Integer = 0 To pwd.Length - 2


            If AscW(pwd.Chars(i)) > 96 AndAlso AscW(pwd.Chars(i)) < 123 Then
                Dim consi_lower_seq As Integer = 1
                While AscW(pwd.Chars(i + 1)) > 96 AndAlso AscW(pwd.Chars(i + 1)) < 123
                    consi_lower_seq += 1
                    i += 1
                    If i = pwd.Length - 1 Then
                        Exit While
                    End If
                End While
                If consi_lower_seq > 1 Then
                    seq_low = True
                    score -= (consi_lower_seq)
                End If

            End If
        Next

        For i As Integer = 0 To pwd.Length - 2


            If AscW(pwd.Chars(i)) > 47 AndAlso AscW(pwd.Chars(i)) < 58 Then
                Dim consi_num_seq As Integer = 1

                While AscW(pwd.Chars(i + 1)) > 47 AndAlso AscW(pwd.Chars(i + 1)) < 58
                    consi_num_seq += 1
                    i += 1
                    If i = pwd.Length - 1 Then
                        Exit While
                    End If
                End While
                If consi_num_seq > 1 Then
                    score -= (consi_num_seq * 3)
                    seq_num = True
                End If
            End If
        Next



        If score < perfect Then
            If score <= 0 Then
                ProgressBar.Value = 0
                strgLabel.Text = "0%"
                DrawFormGradient(Color.White, Color.White)

                strString.ForeColor = Color.Red
                strString.Text = "Very Weak"
            Else
                DrawFormGradient(Color.White, Color.FromArgb(255, 255 - 2.55 * score, 1.5 * score, 0))
                If score < 20 Then

                    ProgressBar.BackColor = Color.Red
                    strString.ForeColor = Color.Red
                    strString.Text = "Very Weak"
                ElseIf score < 40 Then

                    strString.ForeColor = Color.Orange
                    strString.Text = "Weak"

                ElseIf score < 60 Then

                    strString.ForeColor = Color.YellowGreen
                    strString.Text = "Good"
                ElseIf score < 80 Then

                    strString.ForeColor = Color.Green
                    strString.Text = "Strong"
                Else

                    strString.ForeColor = Color.DarkGreen
                    strString.Text = "Very Strong"
                End If
                strgLabel.Text = CStr(score) & "%"
                ProgressBar.Value = score

            End If
        Else
            strString.ForeColor = Color.Green
            strString.Text = "Very Strong"
            strgLabel.Text = "100%"
            ProgressBar.Value = 100
        End If

        Dim count_sugg As Integer = 0
        Dim suggest As String = ""
        If passLen < 8 Then
            count_sugg += 1
            suggest += CStr(count_sugg) + ". Increasing length of password may help" + vbNewLine
        End If
        If lcount = 0 Then
            count_sugg += 1
            suggest += CStr(count_sugg) + ". Adding lowercase letter may help" + vbNewLine
        End If
        If ucount = 0 Then
            count_sugg += 1
            suggest += CStr(count_sugg) + ". Adding uppercase letter may help" + vbNewLine
        End If
        If ncount = 0 Then
            count_sugg += 1
            suggest += CStr(count_sugg) + ". Adding numbers may help" + vbNewLine
        End If
        If scount = 0 Then
            count_sugg += 1
            suggest += CStr(count_sugg) + ". Adding symbols may help" + vbNewLine
        End If
        If sequential Then
            count_sugg += 1
            suggest += CStr(count_sugg) + ". Avoid Sequences" + vbNewLine
        End If
        If consi Then
            count_sugg += 1
            suggest += CStr(count_sugg) + ". Avoid repetation" + vbNewLine
        End If
        If seq_low Then
            count_sugg += 1
            suggest += CStr(count_sugg) + ". Avoid too many lowecase together" + vbNewLine
        End If
        If seq_up Then
            count_sugg += 1
            suggest += CStr(count_sugg) + ". Avoid too many uppercase together" + vbNewLine
        End If
        If seq_num Then
            count_sugg += 1
            suggest += CStr(count_sugg) + ". Avoid too many numbers together" + vbNewLine
        End If

        suglbl.Text = suggest
    End Sub

    Private Sub hideChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles hideChkBox.CheckedChanged
        If hideChkBox.Checked = True Then
            pwdBox.UseSystemPasswordChar = True
        Else
            pwdBox.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class

Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub pwdBoxEnter_TextChanged(sender As Object, e As EventArgs) Handles pwdBoxEnter.TextChanged
        pwdBox_TextChanged(sender, e)

    End Sub
    Private Sub pwdBox_TextChanged(sender As Object, e As EventArgs) Handles pwdBox.TextChanged

        Dim pwd As String = pwdBox.Text

        Dim confpwd As String = pwdBoxEnter.Text



        If pwd = confpwd Then


            Dim ucount As Integer = 0
            Dim lcount As Integer = 0
            Dim ncount As Integer = 0
            Dim scount As Integer = 0
            Dim msncount As Integer = 0

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
                score -= passLen
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
                    score -= (rep_seq) * 3
                End If

                seqlbl.Text = rep_seq
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

                    score -= (consi_upper_seq * 2)
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

                    score -= (consi_lower_seq * 2)
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

                    score -= (consi_num_seq * 2)
                End If
            Next






            If score < perfect Then
                If score < 0 Then
                    ProgressBar.Value = 0
                    strgLabel.Text = CStr(0) & "%"
                Else
                    strgLabel.Text = CStr(score) & "%"
                    ProgressBar.Value = score
                End If
            Else
                strgLabel.Text = "100%"
                ProgressBar.Value = 100

            End If
        Else
            strgLabel.Text = "Passwords do not match"


        End If



    End Sub
End Class

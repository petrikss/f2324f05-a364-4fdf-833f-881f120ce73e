Public Class frmHitungNilai
    Private Sub input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles iTatapMuka.KeyPress, iMidTest.KeyPress, iFinalTest.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub bHitung_Click(sender As Object, e As EventArgs) Handles bHitung.Click
        If iTatapMuka.Text = "" Then
            iTatapMuka.Focus()
        ElseIf iMidTest.Text = "" Then
            iMidTest.Focus()
        ElseIf iFinalTest.Text = "" Then
            iFinalTest.Focus()
        Else
            Dim tatapMuka, midTest, finalTest, nilaiAkhir As Integer
            tatapMuka = iTatapMuka.Text
            midTest = iMidTest.Text
            finalTest = iFinalTest.Text
            nilaiAkhir = (tatapMuka + midTest + finalTest) / 3
            iNilaiAkhir.Text = nilaiAkhir
        End If
    End Sub
End Class
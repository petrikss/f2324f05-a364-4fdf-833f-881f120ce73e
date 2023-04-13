Public Class frmHotel
    Private Sub input_KeyPress(sender As TextBox, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub input_Changed(sender As TextBox, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox4.TextChanged
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            TextBox3.Text = 0
        Else
            Dim lama, harga As Integer
            lama = TextBox1.Text
            harga = TextBox2.Text
            TextBox3.Text = lama * harga
        End If
        If TextBox3.Text = "" Or TextBox4.Text = "" Then
            TextBox5.Text = 0
        Else
            Dim biaya, bayar As Integer
            biaya = TextBox3.Text
            bayar = TextBox4.Text
            TextBox5.Text = bayar - biaya
        End If
    End Sub

    Private Sub button_Click(sender As Button, e As EventArgs) Handles Button1.Click, Button2.Click
        Select Case sender.Name
            Case Button1.Name
                TextBox1.Text = 0
                TextBox2.Text = 0
                TextBox3.Text = 0
                TextBox4.Text = 0
                TextBox5.Text = 0
            Case Button2.Name
                Close()
        End Select
    End Sub
End Class

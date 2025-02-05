Public Class Form1
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim inputDesimal As Integer
        inputDesimal = Val(txtInput.Text)

        txtBiner.Text = Convert.ToString(inputDesimal, 2)
        txtOktal.Text = Convert.ToString(inputDesimal, 8)
        txtDesimal.Text = Convert.ToString(inputDesimal, 10)
        txtHeksa.Text = Convert.ToString(inputDesimal, 16).ToUpper
    End Sub
End Class

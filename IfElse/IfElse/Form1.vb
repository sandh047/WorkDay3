Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click

        If (IsNumeric(txtFirstNum.Text) = False Or IsNumeric(txtSecondNum.Text) = False) Then
            MessageBox.Show("Please type in a real Number!")
        ElseIf (CDbl(txtFirstNum.Text) < 0 Or CDbl(txtSecondNum.Text) < 0) Then
            MessageBox.Show("Please type in a Positive Number!")
        Else
            If (CDbl(txtFirstNum.Text) > CDbl(txtSecondNum.Text)) Then
                txtResult.Text = txtFirstNum.Text & " is larger than " & txtSecondNum.Text
            ElseIf (CDbl(txtFirstNum.Text) < CDbl(txtSecondNum.Text)) Then
                txtResult.Text = txtSecondNum.Text & " is larger than " & txtFirstNum.Text
            Else
                txtResult.Text = txtFirstNum.Text & " and " & txtSecondNum.Text & " are equal"
            End If
        End If


    End Sub
End Class

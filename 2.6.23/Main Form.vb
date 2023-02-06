Public Class Form1
    Private Sub lbFlavors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbFlavors.SelectedIndexChanged
        If lbFlavors.SelectedIndex = 0 Then
            picFlavors.Image = My.Resources.vanilla
        ElseIf lbFlavors.SelectedIndex = 1 Then
            picFlavors.Image = My.Resources.chocolate
        ElseIf lbFlavors.SelectedIndex = 2 Then
            picFlavors.Image = My.Resources.strawberryt
        ElseIf lbFlavors.SelectedIndex = 3 Then
            picFlavors.Image = My.Resources.mint_choc_chip
        ElseIf lbFlavors.SelectedIndex = 4 Then
            picFlavors.Image = My.Resources.birthday_cake
        End If
    End Sub

    Private Sub picFlavors_Click(sender As Object, e As EventArgs) Handles picFlavors.Click

    End Sub
End Class

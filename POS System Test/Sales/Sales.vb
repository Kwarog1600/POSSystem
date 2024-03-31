Public Class Sales
    Private Sub btSale_Click(sender As Object, e As EventArgs) Handles btSale.Click

    End Sub

    Private Sub txbxID_KeyDown(sender As Object, e As KeyEventArgs) Handles txbxID.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' If Enter key is pressed, handle the event
            txbxID_TextChanged(sender, EventArgs.Empty)
        End If
    End Sub

    Private Sub txbxID_TextChanged(sender As Object, e As EventArgs) Handles txbxID.TextChanged
        ' Your code for handling the text change
        ' This code will only execute when the Enter key is pressed
    End Sub
End Class
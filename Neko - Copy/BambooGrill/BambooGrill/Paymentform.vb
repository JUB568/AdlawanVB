Imports MySqlConnector

Public Class PaymentForm
    Private Sub Receipt_Paint(sender As Object, e As PaintEventArgs) Handles Receipt.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'this textbox should automatically be added to the customer table
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        'this textbox should automatically be added to the customer table (Address)
    End Sub

    Private Sub purdatelbl_Click(sender As Object, e As EventArgs) Handles purdatelbl.Click
        'automatically date when the form is opened
    End Sub

    Private Sub receiptnumber_Click(sender As Object, e As EventArgs) Handles receiptnumber.Click
        'automatically gets the unique receipt from my table receipt
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        'sub total
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        'discount
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        'total
    End Sub

    Private Sub chckbtn_Click(sender As Object, e As EventArgs) Handles chckbtn.Click
        'a button that will prompt a mini form or message box, hihingin kung magkano pera nung customer the - sa total ng nabili 
    End Sub


End Class

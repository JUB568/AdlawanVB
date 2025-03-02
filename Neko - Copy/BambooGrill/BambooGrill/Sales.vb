Public Class Sales
    Private Sub Dashbutton_Click(sender As Object, e As EventArgs) Handles Dashbutton.Click
        Admin_Dashboard.Show()
        Me.Close()

    End Sub

    Private Sub Orderbutton_Click(sender As Object, e As EventArgs) Handles Orderbutton.Click
        Take_Order.Show()
        Me.Close()
    End Sub

    Private Sub Invbutton_Click(sender As Object, e As EventArgs) Handles Invbutton.Click
        Inventory.Show()
        Me.Close()
    End Sub

    Private Sub Empbutton_Click(sender As Object, e As EventArgs) Handles Empbutton.Click
        Employees.Show()
        Me.Close()

    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
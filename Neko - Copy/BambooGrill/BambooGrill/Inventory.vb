Public Class Inventory
    Private Sub Dashbutton_Click(sender As Object, e As EventArgs) Handles Dashbutton.Click
        Admin_Dashboard.Show()
        Me.Close()

    End Sub

    Private Sub Orderbutton_Click(sender As Object, e As EventArgs) Handles Orderbutton.Click
        Take_Order.Show()
        Me.Close()


    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Salesbutton_Click(sender As Object, e As EventArgs) Handles Salesbutton.Click
        Sales.Show()
        Me.Close()
    End Sub

    Private Sub Empbutton_Click(sender As Object, e As EventArgs) Handles Empbutton.Click
        Employees.Show()
        Me.Close()

    End Sub
End Class
Public Class Employees
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

    Private Sub Salesbutton_Click(sender As Object, e As EventArgs) Handles Salesbutton.Click
        Sales.Show()
        Me.Close()

    End Sub

    Private Sub Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
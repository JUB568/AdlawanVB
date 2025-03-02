Public Class OrderItem
    Public Property ItemName As String
    Public Property Quantity As Integer
    Public Property Price As Decimal

    Public Sub New(itemName As String, quantity As Integer, price As Decimal)
        Me.ItemName = itemName
        Me.Quantity = quantity
        Me.Price = price
    End Sub

    Public Overrides Function ToString() As String
        Return $"{ItemName} - Qty: {Quantity} - {Price:C2}"
    End Function

End Class

Imports System.Reflection.Emit
Imports MySqlConnector
Imports System.Windows.Forms
Imports Label = System.Windows.Forms.Label
Imports System.Globalization


Public Class Take_Order
    Private Sub Dashbutton_Click(sender As Object, e As EventArgs) Handles Dashbutton.Click
        Admin_Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub Take_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized


        TabLayout.Alignment = TabAlignment.Left ' Keep tabs on the left
        TabLayout.SizeMode = TabSizeMode.Fixed ' Fix the tab size
        TabLayout.ItemSize = New Size(100, 150) ' Set tab width and height
        TabLayout.DrawMode = TabDrawMode.OwnerDrawFixed ' Enable custom drawing

        ' Handle the DrawItem event to rotate text
        AddHandler TabLayout.DrawItem, AddressOf TabControl1_DrawItem

        LoadMenuItems()
    End Sub

    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs)
        ' Get the TabControl and the TabPage being drawn
        Dim tabControl = DirectCast(sender, TabControl)
        Dim tabPage = tabControl.TabPages(e.Index)

        ' Draw the background (optional, to make the tab stand out)
        e.Graphics.FillRectangle(Brushes.White, e.Bounds)

        ' Rotate the text to make it landscape (horizontal)
        e.Graphics.TranslateTransform(e.Bounds.Left + 20, e.Bounds.Top + (e.Bounds.Height / 2))
        e.Graphics.RotateTransform(0) ' No rotation needed for horizontal text
        e.Graphics.DrawString(tabPage.Text, tabControl.Font, Brushes.Black, 0, 0)
        e.Graphics.ResetTransform() ' Reset transformations
    End Sub

    Public Sub LoadMenuItems()
        Try
            ' SQL Query to get all menu items sorted alphabetically
            Dim query As String = "SELECT ItemID, ItemName, QTY, Price FROM Inasal ORDER BY ItemName ASC"
            readQuery(query) ' Execute the query

            ' Clear previous buttons to avoid duplicates
            flpinasal.Controls.Clear()

            ' Read the menu items
            While cmdRead.Read()
                ' Create a new button
                Dim btn As New Button()
                btn.Text = cmdRead("ItemName").ToString() ' Set button text to ItemName
                btn.Tag = cmdRead("ItemID") ' Store ItemID for reference
                btn.Width = 120
                btn.Height = 50
                btn.Font = New Font("Arial", 12, FontStyle.Bold)
                btn.BackColor = Color.LightGreen ' Customize button color

                ' Add event handler for button click
                AddHandler btn.Click, AddressOf MenuItem_Click

                ' Add button to the FlowLayoutPanel
                flpinasal.Controls.Add(btn)
            End While
            cmdRead.Close()
        Catch ex As Exception
            MsgBox("Error loading menu: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub MenuItem_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim itemID As Integer = Convert.ToInt32(btn.Tag) ' Get the ItemID from Tag
        Dim itemName As String = btn.Text
        Dim sellPrice As Decimal = GetSellPriceFromDatabase(itemID) ' Fetch price using function

        ' Check if the item already exists in the table
        Dim existingRowIndex As Integer = -1
        For rowIndex As Integer = 0 To TableLayoutPanel3.RowCount - 1
            Dim lblItem As Label = TryCast(TableLayoutPanel3.GetControlFromPosition(0, rowIndex), Label)
            If lblItem IsNot Nothing AndAlso lblItem.Text = itemName Then
                existingRowIndex = rowIndex
                Exit For
            End If
        Next

        ' If the item exists, update its quantity and price
        If existingRowIndex <> -1 Then
            Dim qtyBox As TextBox = TryCast(TableLayoutPanel3.GetControlFromPosition(1, existingRowIndex), TextBox)
            Dim priceLabel As Label = TryCast(TableLayoutPanel3.GetControlFromPosition(2, existingRowIndex), Label)

            If qtyBox IsNot Nothing AndAlso priceLabel IsNot Nothing Then
                ' Increase quantity by 1
                Dim currentQty As Integer = Convert.ToInt32(qtyBox.Text)
                qtyBox.Text = (currentQty + 1).ToString() ' Update the quantity

                ' Update the price label based on the new quantity
                priceLabel.Text = (sellPrice * (currentQty + 1)).ToString("₱#,##0.00")
            End If
        Else
            ' Add a new item to the table if it doesn't exist
            AddItemToTable(itemName, 1, sellPrice) ' Default quantity is 1
        End If

        ' Call UpdateTotal after adding or updating the item
        UpdateTotal(sender, e)
    End Sub





    Private Sub AddItemToTable(itemName As String, qty As Integer, sellPrice As Decimal)
        ' Flag to indicate whether the item is already in the table
        Dim itemExists As Boolean = False

        ' Loop through all rows in TableLayoutPanel3 to check if the item exists
        For rowIndex As Integer = 0 To TableLayoutPanel3.RowCount - 1
            ' Get the Item Name from Column 0 (Item Name)
            Dim lblItem As Label = TryCast(TableLayoutPanel3.GetControlFromPosition(0, rowIndex), Label)

            ' If the item name matches the clicked item, update the quantity and price
            If lblItem IsNot Nothing AndAlso lblItem.Text = itemName Then
                ' Increase quantity by 1
                Dim qtyBox As TextBox = TryCast(TableLayoutPanel3.GetControlFromPosition(1, rowIndex), TextBox)
                Dim priceLabel As Label = TryCast(TableLayoutPanel3.GetControlFromPosition(2, rowIndex), Label)

                If qtyBox IsNot Nothing AndAlso priceLabel IsNot Nothing Then
                    qtyBox.Text = (Convert.ToInt32(qtyBox.Text) + qty).ToString() ' Increase quantity
                    priceLabel.Text = (sellPrice * Convert.ToInt32(qtyBox.Text)).ToString("₱#,##0.00")
                End If

                itemExists = True
                Exit For
            End If
        Next

        ' If the item was not found, add a new row
        If Not itemExists Then
            Dim rowIndex As Integer = TableLayoutPanel3.RowCount ' Get the next row index

            ' Add a new row to TableLayoutPanel3
            TableLayoutPanel3.RowCount += 1
            TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.AutoSize))

            ' Create labels for Item Name, Quantity, and Price
            Dim lblItem As New Label()
            lblItem.Text = itemName
            lblItem.AutoSize = True
            lblItem.Cursor = Cursors.Hand ' Change the cursor to indicate it's clickable
            lblItem.Tag = itemName ' Optional: Store the item name or ItemID as a tag

            ' Attach click event to the label
            AddHandler lblItem.Click, AddressOf lblItem_Click

            Dim txtQty As New TextBox()
            txtQty.Text = qty.ToString()
            txtQty.Width = 40
            AddHandler txtQty.TextChanged, AddressOf UpdateTotal ' Update total when qty changes

            Dim lblPrice As New Label()
            lblPrice.Text = (sellPrice * qty).ToString("₱#,##0.00") ' Display as currency for the initial quantity
            lblPrice.AutoSize = True

            ' Add controls to TableLayoutPanel3
            TableLayoutPanel3.Controls.Add(lblItem, 0, rowIndex)
            TableLayoutPanel3.Controls.Add(txtQty, 1, rowIndex)
            TableLayoutPanel3.Controls.Add(lblPrice, 2, rowIndex)
        End If
    End Sub

    Private Sub lblItem_Click(sender As Object, e As EventArgs)
        Dim clickedLabel As Label = DirectCast(sender, Label)
        Dim rowIndex As Integer = TableLayoutPanel3.GetRow(clickedLabel)

        ' Get the TextBox for quantity and Label for price
        Dim qtyBox As TextBox = TryCast(TableLayoutPanel3.GetControlFromPosition(1, rowIndex), TextBox)
        Dim priceLabel As Label = TryCast(TableLayoutPanel3.GetControlFromPosition(2, rowIndex), Label)

        If qtyBox IsNot Nothing AndAlso priceLabel IsNot Nothing Then
            ' Get the current quantity
            Dim currentQty As Integer = Convert.ToInt32(qtyBox.Text)

            If currentQty > 1 Then
                ' Decrease quantity by 1
                qtyBox.Text = (currentQty - 1).ToString()

                ' Update the price based on the reduced quantity
                Dim sellPrice As Decimal = Convert.ToDecimal(priceLabel.Text.Replace("₱", "").Trim(), CultureInfo.InvariantCulture) / currentQty
                priceLabel.Text = (sellPrice * (currentQty - 1)).ToString("₱#,##0.00")
            ElseIf currentQty = 1 Then
                ' If quantity is 1, remove the entire row and decrement the row count
                TableLayoutPanel3.Controls.RemoveAt(rowIndex * 3) ' Remove the first control (Label)
                TableLayoutPanel3.Controls.RemoveAt(rowIndex * 3) ' Remove the second control (TextBox)
                TableLayoutPanel3.Controls.RemoveAt(rowIndex * 3) ' Remove the third control (Label)
                TableLayoutPanel3.RowCount -= 1
            End If
        End If

        ' After updating, update the total
        UpdateTotal(sender, e)
    End Sub




    Private Sub UpdateTotal(sender As Object, e As EventArgs)
        Dim total As Decimal = 0

        ' Loop through all rows in TableLayoutPanel3
        For rowIndex As Integer = 0 To TableLayoutPanel3.RowCount - 1
            ' Get the Quantity TextBox from Column 1 (Qty)
            Dim qtyBox As TextBox = TryCast(TableLayoutPanel3.GetControlFromPosition(1, rowIndex), TextBox)

            ' Get the Price Label from Column 2 (Price)
            Dim priceLabel As Label = TryCast(TableLayoutPanel3.GetControlFromPosition(2, rowIndex), Label)

            ' Check if the controls exist before using them
            If qtyBox IsNot Nothing AndAlso priceLabel IsNot Nothing Then
                ' Get the quantity and price
                Dim qty As Integer = Convert.ToInt32(qtyBox.Text)
                Dim price As Decimal = Convert.ToDecimal(priceLabel.Text.Replace("₱", "").Trim(), CultureInfo.InvariantCulture)

                ' Add to total
                total += price ' Add price based on quantity
            End If
        Next

        ' Update the total label
        Label5.Text = total.ToString("₱#,##0.00")
        Label9.Text = total.ToString("₱#,##0.00")
    End Sub









    Private Function GetSellPriceFromDatabase(itemID As Integer) As Decimal
        Dim price As Decimal = 0
        Try
            Dim query As String = "SELECT SellPrice FROM inventory WHERE ItemID = @itemID"
            Using conn As New MySqlConnection(strConnection)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@itemID", itemID)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        price = Convert.ToDecimal(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error fetching price: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        Return price
    End Function



    Private Sub Invbutton_Click(sender As Object, e As EventArgs) Handles Invbutton.Click
        Inventory.Show()
        Me.Close()

    End Sub

    Private Sub Salesbutton_Click(sender As Object, e As EventArgs) Handles Salesbutton.Click
        Sales.Show()
        Me.Close()
    End Sub

    Private Sub Empbutton_Click(sender As Object, e As EventArgs) Handles Empbutton.Click
        Employees.Show()
        Me.Close()

    End Sub
    Private Sub Paymentbtn_Click(sender As Object, e As EventArgs) Handles Paymentbtn.Click


    End Sub







End Class
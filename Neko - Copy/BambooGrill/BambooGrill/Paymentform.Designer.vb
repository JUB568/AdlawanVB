<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paymentform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Receipt = New Panel()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label9 = New Label()
        Totallbl = New Label()
        Label7 = New Label()
        Disclbl = New Label()
        Label8 = New Label()
        SubTotallbl = New Label()
        Label5 = New Label()
        Label3 = New Label()
        purdatelbl = New Label()
        purdate = New Label()
        receiptnumber = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Dapricelbl = New Label()
        quantitylbl = New Label()
        Itemnamelbl = New Label()
        Panel2 = New Panel()
        chckbtn = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Receipt.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Receipt
        ' 
        Receipt.Controls.Add(TextBox2)
        Receipt.Controls.Add(TextBox1)
        Receipt.Controls.Add(Label9)
        Receipt.Controls.Add(Totallbl)
        Receipt.Controls.Add(Label7)
        Receipt.Controls.Add(Disclbl)
        Receipt.Controls.Add(Label8)
        Receipt.Controls.Add(SubTotallbl)
        Receipt.Controls.Add(Label5)
        Receipt.Controls.Add(Label3)
        Receipt.Controls.Add(purdatelbl)
        Receipt.Controls.Add(purdate)
        Receipt.Controls.Add(receiptnumber)
        Receipt.Controls.Add(Label2)
        Receipt.Controls.Add(Label1)
        Receipt.Controls.Add(TableLayoutPanel1)
        Receipt.Dock = DockStyle.Fill
        Receipt.Location = New Point(0, 0)
        Receipt.Name = "Receipt"
        Receipt.Size = New Size(990, 851)
        Receipt.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(106, 38)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(258, 27)
        TextBox2.TabIndex = 17
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(106, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(858, 642)
        Label9.Name = "Label9"
        Label9.Size = New Size(53, 20)
        Label9.TabIndex = 15
        Label9.Text = "Label9"
        ' 
        ' Totallbl
        ' 
        Totallbl.AutoSize = True
        Totallbl.Location = New Point(784, 642)
        Totallbl.Name = "Totallbl"
        Totallbl.Size = New Size(42, 20)
        Totallbl.TabIndex = 14
        Totallbl.Text = "Total"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(858, 607)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 20)
        Label7.TabIndex = 13
        Label7.Text = "Label7"
        ' 
        ' Disclbl
        ' 
        Disclbl.AutoSize = True
        Disclbl.Location = New Point(759, 607)
        Disclbl.Name = "Disclbl"
        Disclbl.Size = New Size(67, 20)
        Disclbl.TabIndex = 12
        Disclbl.Text = "Discount"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(858, 572)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 20)
        Label8.TabIndex = 11
        Label8.Text = "Label8"
        ' 
        ' SubTotallbl
        ' 
        SubTotallbl.AutoSize = True
        SubTotallbl.Location = New Point(755, 572)
        SubTotallbl.Name = "SubTotallbl"
        SubTotallbl.Size = New Size(71, 20)
        SubTotallbl.TabIndex = 10
        SubTotallbl.Text = "Sub Total"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(35, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 20)
        Label5.TabIndex = 8
        Label5.Text = "Address:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 20)
        Label3.TabIndex = 6
        Label3.Text = "Sold to:"
        ' 
        ' purdatelbl
        ' 
        purdatelbl.AutoSize = True
        purdatelbl.Location = New Point(773, 18)
        purdatelbl.Name = "purdatelbl"
        purdatelbl.Size = New Size(41, 20)
        purdatelbl.TabIndex = 5
        purdatelbl.Text = "Date"
        ' 
        ' purdate
        ' 
        purdate.AutoSize = True
        purdate.Location = New Point(723, 18)
        purdate.Name = "purdate"
        purdate.Size = New Size(44, 20)
        purdate.TabIndex = 4
        purdate.Text = "Date:"
        ' 
        ' receiptnumber
        ' 
        receiptnumber.AutoSize = True
        receiptnumber.Location = New Point(858, 47)
        receiptnumber.Name = "receiptnumber"
        receiptnumber.Size = New Size(117, 20)
        receiptnumber.TabIndex = 3
        receiptnumber.Text = "Receipt Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(723, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 20)
        Label2.TabIndex = 2
        Label2.Text = "Receipt Number:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(401, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(252, 80)
        Label1.TabIndex = 1
        Label1.Text = "Bamboo Grill Unlimited Rice" & vbCrLf & "Purok 5, Bagasbas Rd, Brgy. Borabod" & vbCrLf & "Daet, Camarines Norte" & vbCrLf & vbCrLf
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.7905121F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.612648F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(Dapricelbl, 0, 0)
        TableLayoutPanel1.Controls.Add(quantitylbl, 1, 0)
        TableLayoutPanel1.Controls.Add(Itemnamelbl, 2, 0)
        TableLayoutPanel1.Location = New Point(12, 93)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(966, 59)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Dapricelbl
        ' 
        Dapricelbl.AutoSize = True
        Dapricelbl.Dock = DockStyle.Fill
        Dapricelbl.Location = New Point(3, 0)
        Dapricelbl.Name = "Dapricelbl"
        Dapricelbl.Size = New Size(485, 59)
        Dapricelbl.TabIndex = 5
        Dapricelbl.Text = "Price"
        Dapricelbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' quantitylbl
        ' 
        quantitylbl.AutoSize = True
        quantitylbl.Dock = DockStyle.Fill
        quantitylbl.Location = New Point(494, 0)
        quantitylbl.Name = "quantitylbl"
        quantitylbl.Size = New Size(145, 59)
        quantitylbl.TabIndex = 4
        quantitylbl.Text = "Qty"
        quantitylbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Itemnamelbl
        ' 
        Itemnamelbl.AutoSize = True
        Itemnamelbl.Dock = DockStyle.Fill
        Itemnamelbl.Location = New Point(645, 0)
        Itemnamelbl.Name = "Itemnamelbl"
        Itemnamelbl.Size = New Size(318, 59)
        Itemnamelbl.TabIndex = 3
        Itemnamelbl.Text = "Item Name"
        Itemnamelbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(chckbtn)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 687)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(990, 164)
        Panel2.TabIndex = 1
        ' 
        ' chckbtn
        ' 
        chckbtn.Location = New Point(766, 19)
        chckbtn.Name = "chckbtn"
        chckbtn.Size = New Size(145, 29)
        chckbtn.TabIndex = 16
        chckbtn.Text = "Checkout"
        chckbtn.UseVisualStyleBackColor = True
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' PaymentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(990, 851)
        Controls.Add(Panel2)
        Controls.Add(Receipt)
        Name = "PaymentForm"
        Text = "Paymentform"
        Receipt.ResumeLayout(False)
        Receipt.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Receipt As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Dapricelbl As Label
    Friend WithEvents quantitylbl As Label
    Friend WithEvents Itemnamelbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents purdate As Label
    Friend WithEvents receiptnumber As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents purdatelbl As Label
    Friend WithEvents chckbtn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Totallbl As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Disclbl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents SubTotallbl As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Take_Order
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
        Dashbutton = New Button()
        Orderbutton = New Button()
        Invbutton = New Button()
        Salesbutton = New Button()
        Empbutton = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        TabLayout = New TabControl()
        InasalTab = New TabPage()
        Panel3 = New Panel()
        Paymentbtn = New Button()
        Label9 = New Label()
        Totallbl = New Label()
        Label7 = New Label()
        Disclbl = New Label()
        Label5 = New Label()
        SubTotallbl = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        Dapricelbl = New Label()
        quantitylbl = New Label()
        Itemnamelbl = New Label()
        flpinasal = New FlowLayoutPanel()
        SilogMealsTab = New TabPage()
        BeveragesTab = New TabPage()
        Coffees = New TabPage()
        DessertsTab = New TabPage()
        Settingstab = New TabPage()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        TabLayout.SuspendLayout()
        InasalTab.SuspendLayout()
        Panel3.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Dashbutton
        ' 
        Dashbutton.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Dashbutton.Dock = DockStyle.Fill
        Dashbutton.Location = New Point(3, 4)
        Dashbutton.Margin = New Padding(3, 4, 3, 4)
        Dashbutton.Name = "Dashbutton"
        Dashbutton.Size = New Size(324, 121)
        Dashbutton.TabIndex = 0
        Dashbutton.Text = "Dashboard"
        Dashbutton.UseVisualStyleBackColor = False
        ' 
        ' Orderbutton
        ' 
        Orderbutton.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Orderbutton.Dock = DockStyle.Fill
        Orderbutton.Location = New Point(333, 4)
        Orderbutton.Margin = New Padding(3, 4, 3, 4)
        Orderbutton.Name = "Orderbutton"
        Orderbutton.Size = New Size(324, 121)
        Orderbutton.TabIndex = 1
        Orderbutton.Text = "Take Order"
        Orderbutton.UseVisualStyleBackColor = False
        ' 
        ' Invbutton
        ' 
        Invbutton.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Invbutton.Dock = DockStyle.Fill
        Invbutton.Location = New Point(663, 4)
        Invbutton.Margin = New Padding(3, 4, 3, 4)
        Invbutton.Name = "Invbutton"
        Invbutton.Size = New Size(324, 121)
        Invbutton.TabIndex = 2
        Invbutton.Text = "Inventory"
        Invbutton.UseVisualStyleBackColor = False
        ' 
        ' Salesbutton
        ' 
        Salesbutton.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Salesbutton.Dock = DockStyle.Fill
        Salesbutton.Location = New Point(993, 4)
        Salesbutton.Margin = New Padding(3, 4, 3, 4)
        Salesbutton.Name = "Salesbutton"
        Salesbutton.Size = New Size(324, 121)
        Salesbutton.TabIndex = 3
        Salesbutton.Text = "Sales"
        Salesbutton.UseVisualStyleBackColor = False
        ' 
        ' Empbutton
        ' 
        Empbutton.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Empbutton.Dock = DockStyle.Fill
        Empbutton.Location = New Point(1323, 4)
        Empbutton.Margin = New Padding(3, 4, 3, 4)
        Empbutton.Name = "Empbutton"
        Empbutton.Size = New Size(328, 121)
        Empbutton.TabIndex = 4
        Empbutton.Text = "Employees"
        Empbutton.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.Controls.Add(Empbutton, 4, 0)
        TableLayoutPanel1.Controls.Add(Salesbutton, 3, 0)
        TableLayoutPanel1.Controls.Add(Invbutton, 2, 0)
        TableLayoutPanel1.Controls.Add(Orderbutton, 1, 0)
        TableLayoutPanel1.Controls.Add(Dashbutton, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Bottom
        TableLayoutPanel1.Location = New Point(0, 936)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Size = New Size(1654, 129)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1654, 936)
        Panel1.TabIndex = 5
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.Controls.Add(TabLayout)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1654, 936)
        Panel2.TabIndex = 9
        ' 
        ' TabLayout
        ' 
        TabLayout.Alignment = TabAlignment.Left
        TabLayout.Controls.Add(InasalTab)
        TabLayout.Controls.Add(SilogMealsTab)
        TabLayout.Controls.Add(BeveragesTab)
        TabLayout.Controls.Add(Coffees)
        TabLayout.Controls.Add(DessertsTab)
        TabLayout.Controls.Add(Settingstab)
        TabLayout.Dock = DockStyle.Fill
        TabLayout.Font = New Font("Segoe UI", 15.0F)
        TabLayout.ItemSize = New Size(120, 50)
        TabLayout.Location = New Point(0, 0)
        TabLayout.Margin = New Padding(3, 4, 3, 4)
        TabLayout.Multiline = True
        TabLayout.Name = "TabLayout"
        TabLayout.SelectedIndex = 0
        TabLayout.Size = New Size(1654, 936)
        TabLayout.SizeMode = TabSizeMode.Fixed
        TabLayout.TabIndex = 0
        ' 
        ' InasalTab
        ' 
        InasalTab.Controls.Add(Panel3)
        InasalTab.Controls.Add(flpinasal)
        InasalTab.Location = New Point(54, 4)
        InasalTab.Margin = New Padding(3, 4, 3, 4)
        InasalTab.Name = "InasalTab"
        InasalTab.Padding = New Padding(3, 4, 3, 4)
        InasalTab.Size = New Size(1596, 928)
        InasalTab.TabIndex = 1
        InasalTab.Text = "Inasal"
        InasalTab.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Paymentbtn)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Totallbl)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Disclbl)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(SubTotallbl)
        Panel3.Controls.Add(TableLayoutPanel3)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(1082, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(511, 920)
        Panel3.TabIndex = 1
        ' 
        ' Paymentbtn
        ' 
        Paymentbtn.Location = New Point(223, 834)
        Paymentbtn.Name = "Paymentbtn"
        Paymentbtn.Size = New Size(145, 86)
        Paymentbtn.TabIndex = 8
        Paymentbtn.Text = "Payment"
        Paymentbtn.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(374, 740)
        Label9.Name = "Label9"
        Label9.Size = New Size(87, 35)
        Label9.TabIndex = 7
        Label9.Text = "Label9"
        ' 
        ' Totallbl
        ' 
        Totallbl.AutoSize = True
        Totallbl.Location = New Point(300, 740)
        Totallbl.Name = "Totallbl"
        Totallbl.Size = New Size(68, 35)
        Totallbl.TabIndex = 6
        Totallbl.Text = "Total"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(374, 705)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 35)
        Label7.TabIndex = 5
        Label7.Text = "Label7"
        ' 
        ' Disclbl
        ' 
        Disclbl.AutoSize = True
        Disclbl.Location = New Point(255, 705)
        Disclbl.Name = "Disclbl"
        Disclbl.Size = New Size(113, 35)
        Disclbl.TabIndex = 4
        Disclbl.Text = "Discount"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(374, 670)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 35)
        Label5.TabIndex = 3
        Label5.Text = "Label5"
        ' 
        ' SubTotallbl
        ' 
        SubTotallbl.AutoSize = True
        SubTotallbl.Location = New Point(251, 670)
        SubTotallbl.Name = "SubTotallbl"
        SubTotallbl.Size = New Size(117, 35)
        SubTotallbl.TabIndex = 2
        SubTotallbl.Text = "Sub Total"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.White
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60.20202F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5252523F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 27.272728F))
        TableLayoutPanel3.Controls.Add(Dapricelbl, 2, 0)
        TableLayoutPanel3.Controls.Add(quantitylbl, 1, 0)
        TableLayoutPanel3.Controls.Add(Itemnamelbl, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Top
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle())
        TableLayoutPanel3.Size = New Size(511, 74)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Dapricelbl
        ' 
        Dapricelbl.AutoSize = True
        Dapricelbl.Dock = DockStyle.Fill
        Dapricelbl.Location = New Point(374, 0)
        Dapricelbl.Name = "Dapricelbl"
        Dapricelbl.Size = New Size(134, 74)
        Dapricelbl.TabIndex = 2
        Dapricelbl.Text = "Price"
        Dapricelbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' quantitylbl
        ' 
        quantitylbl.AutoSize = True
        quantitylbl.Dock = DockStyle.Fill
        quantitylbl.Location = New Point(310, 0)
        quantitylbl.Name = "quantitylbl"
        quantitylbl.Size = New Size(58, 74)
        quantitylbl.TabIndex = 1
        quantitylbl.Text = "Qty"
        quantitylbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Itemnamelbl
        ' 
        Itemnamelbl.AutoSize = True
        Itemnamelbl.Dock = DockStyle.Fill
        Itemnamelbl.Location = New Point(3, 0)
        Itemnamelbl.Name = "Itemnamelbl"
        Itemnamelbl.Size = New Size(301, 74)
        Itemnamelbl.TabIndex = 0
        Itemnamelbl.Text = "Item Name"
        Itemnamelbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' flpinasal
        ' 
        flpinasal.Dock = DockStyle.Fill
        flpinasal.Location = New Point(3, 4)
        flpinasal.Name = "flpinasal"
        flpinasal.Size = New Size(1590, 920)
        flpinasal.TabIndex = 0
        ' 
        ' SilogMealsTab
        ' 
        SilogMealsTab.Location = New Point(54, 4)
        SilogMealsTab.Margin = New Padding(3, 4, 3, 4)
        SilogMealsTab.Name = "SilogMealsTab"
        SilogMealsTab.Padding = New Padding(3, 4, 3, 4)
        SilogMealsTab.Size = New Size(1596, 928)
        SilogMealsTab.TabIndex = 2
        SilogMealsTab.Text = "Silog Meals"
        SilogMealsTab.UseVisualStyleBackColor = True
        ' 
        ' BeveragesTab
        ' 
        BeveragesTab.Location = New Point(54, 4)
        BeveragesTab.Margin = New Padding(3, 4, 3, 4)
        BeveragesTab.Name = "BeveragesTab"
        BeveragesTab.Padding = New Padding(3, 4, 3, 4)
        BeveragesTab.Size = New Size(1596, 928)
        BeveragesTab.TabIndex = 3
        BeveragesTab.Text = "Beverages"
        BeveragesTab.UseVisualStyleBackColor = True
        ' 
        ' Coffees
        ' 
        Coffees.Location = New Point(54, 4)
        Coffees.Margin = New Padding(3, 4, 3, 4)
        Coffees.Name = "Coffees"
        Coffees.Padding = New Padding(3, 4, 3, 4)
        Coffees.Size = New Size(1596, 928)
        Coffees.TabIndex = 4
        Coffees.Text = "Coffees"
        Coffees.UseVisualStyleBackColor = True
        ' 
        ' DessertsTab
        ' 
        DessertsTab.Location = New Point(54, 4)
        DessertsTab.Margin = New Padding(3, 4, 3, 4)
        DessertsTab.Name = "DessertsTab"
        DessertsTab.Padding = New Padding(3, 4, 3, 4)
        DessertsTab.Size = New Size(1596, 928)
        DessertsTab.TabIndex = 5
        DessertsTab.Text = "Desserts"
        DessertsTab.UseVisualStyleBackColor = True
        ' 
        ' Settingstab
        ' 
        Settingstab.Location = New Point(54, 4)
        Settingstab.Name = "Settingstab"
        Settingstab.Padding = New Padding(3)
        Settingstab.Size = New Size(1596, 928)
        Settingstab.TabIndex = 6
        Settingstab.Text = "Settings"
        Settingstab.UseVisualStyleBackColor = True
        ' 
        ' Take_Order
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1654, 1065)
        Controls.Add(Panel1)
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Take_Order"
        Text = "Take_Order"
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        TabLayout.ResumeLayout(False)
        InasalTab.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Dashbutton As Button
    Friend WithEvents Orderbutton As Button
    Friend WithEvents Invbutton As Button
    Friend WithEvents Salesbutton As Button
    Friend WithEvents Empbutton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabLayout As TabControl
    Friend WithEvents InasalTab As TabPage
    Friend WithEvents SilogMealsTab As TabPage
    Friend WithEvents BeveragesTab As TabPage
    Friend WithEvents Coffees As TabPage
    Friend WithEvents DessertsTab As TabPage
    Friend WithEvents flpinasal As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Totallbl As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Disclbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SubTotallbl As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Dapricelbl As Label
    Friend WithEvents quantitylbl As Label
    Friend WithEvents Itemnamelbl As Label
    Friend WithEvents Settingstab As TabPage
    Friend WithEvents Paymentbtn As Button
End Class

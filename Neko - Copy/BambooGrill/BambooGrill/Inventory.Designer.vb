<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        TableLayoutPanel2 = New TableLayoutPanel()
        BusinessName = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Empbutton = New Button()
        Salesbutton = New Button()
        Invbutton = New Button()
        Orderbutton = New Button()
        Dashbutton = New Button()
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        TableLayoutPanel3 = New TableLayoutPanel()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(BusinessName, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Top
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(1661, 64)
        TableLayoutPanel2.TabIndex = 4
        ' 
        ' BusinessName
        ' 
        BusinessName.AutoSize = True
        BusinessName.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        BusinessName.Dock = DockStyle.Fill
        BusinessName.Font = New Font("Segoe UI", 20F)
        BusinessName.Location = New Point(3, 0)
        BusinessName.Name = "BusinessName"
        BusinessName.Size = New Size(1655, 64)
        BusinessName.TabIndex = 0
        BusinessName.Text = "Bamboo's Grill Unlimited Rice"
        BusinessName.TextAlign = ContentAlignment.MiddleCenter
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
        TableLayoutPanel1.Location = New Point(0, 907)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1661, 129)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' Empbutton
        ' 
        Empbutton.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Empbutton.Dock = DockStyle.Fill
        Empbutton.Location = New Point(1331, 4)
        Empbutton.Margin = New Padding(3, 4, 3, 4)
        Empbutton.Name = "Empbutton"
        Empbutton.Size = New Size(327, 121)
        Empbutton.TabIndex = 4
        Empbutton.Text = "Employees"
        Empbutton.UseVisualStyleBackColor = False
        ' 
        ' Salesbutton
        ' 
        Salesbutton.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Salesbutton.Dock = DockStyle.Fill
        Salesbutton.Location = New Point(999, 4)
        Salesbutton.Margin = New Padding(3, 4, 3, 4)
        Salesbutton.Name = "Salesbutton"
        Salesbutton.Size = New Size(326, 121)
        Salesbutton.TabIndex = 3
        Salesbutton.Text = "Sales"
        Salesbutton.UseVisualStyleBackColor = False
        ' 
        ' Invbutton
        ' 
        Invbutton.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Invbutton.Dock = DockStyle.Fill
        Invbutton.Location = New Point(667, 4)
        Invbutton.Margin = New Padding(3, 4, 3, 4)
        Invbutton.Name = "Invbutton"
        Invbutton.Size = New Size(326, 121)
        Invbutton.TabIndex = 2
        Invbutton.Text = "Inventory"
        Invbutton.UseVisualStyleBackColor = False
        ' 
        ' Orderbutton
        ' 
        Orderbutton.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Orderbutton.Dock = DockStyle.Fill
        Orderbutton.Location = New Point(335, 4)
        Orderbutton.Margin = New Padding(3, 4, 3, 4)
        Orderbutton.Name = "Orderbutton"
        Orderbutton.Size = New Size(326, 121)
        Orderbutton.TabIndex = 1
        Orderbutton.Text = "Take Order"
        Orderbutton.UseVisualStyleBackColor = False
        ' 
        ' Dashbutton
        ' 
        Dashbutton.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Dashbutton.Dock = DockStyle.Fill
        Dashbutton.Location = New Point(3, 4)
        Dashbutton.Margin = New Padding(3, 4, 3, 4)
        Dashbutton.Name = "Dashbutton"
        Dashbutton.Size = New Size(326, 121)
        Dashbutton.TabIndex = 0
        Dashbutton.Text = "Dashboard"
        Dashbutton.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DataGridView1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 64)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1661, 843)
        Panel1.TabIndex = 5
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1661, 843)
        DataGridView1.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 111F))
        TableLayoutPanel3.Controls.Add(TextBox1, 0, 0)
        TableLayoutPanel3.Controls.Add(Button1, 1, 0)
        TableLayoutPanel3.Controls.Add(Button2, 0, 1)
        TableLayoutPanel3.Controls.Add(Button3, 0, 2)
        TableLayoutPanel3.Controls.Add(Button4, 0, 3)
        TableLayoutPanel3.Controls.Add(Button5, 0, 4)
        TableLayoutPanel3.Dock = DockStyle.Right
        TableLayoutPanel3.Location = New Point(1252, 64)
        TableLayoutPanel3.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 5
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel3.Size = New Size(409, 843)
        TableLayoutPanel3.TabIndex = 6
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Location = New Point(3, 4)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(292, 27)
        TextBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(301, 4)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 1
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Fill
        Button2.Location = New Point(3, 172)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(292, 160)
        Button2.TabIndex = 2
        Button2.Text = "ADD"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Dock = DockStyle.Fill
        Button3.Location = New Point(3, 340)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(292, 160)
        Button3.TabIndex = 3
        Button3.Text = "EDIT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Dock = DockStyle.Fill
        Button4.Location = New Point(3, 508)
        Button4.Margin = New Padding(3, 4, 3, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(292, 160)
        Button4.TabIndex = 4
        Button4.Text = "DELETE"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Dock = DockStyle.Fill
        Button5.Location = New Point(3, 676)
        Button5.Margin = New Padding(3, 4, 3, 4)
        Button5.Name = "Button5"
        Button5.Size = New Size(292, 163)
        Button5.TabIndex = 5
        Button5.Text = "PRINT AS PDF"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Inventory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1661, 1036)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(Panel1)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Inventory"
        Text = "Inventory"
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BusinessName As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Empbutton As Button
    Friend WithEvents Salesbutton As Button
    Friend WithEvents Invbutton As Button
    Friend WithEvents Orderbutton As Button
    Friend WithEvents Dashbutton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class

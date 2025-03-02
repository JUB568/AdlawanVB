<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Dashboard
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
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        TableLayoutPanel1 = New TableLayoutPanel()
        Empbutton = New Button()
        Salesbutton = New Button()
        Invbutton = New Button()
        Orderbutton = New Button()
        Dashbutton = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        BusinessName = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
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
        TableLayoutPanel1.Location = New Point(0, 516)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1455, 97)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Empbutton
        ' 
        Empbutton.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Empbutton.Dock = DockStyle.Fill
        Empbutton.Location = New Point(1167, 3)
        Empbutton.Name = "Empbutton"
        Empbutton.Size = New Size(285, 91)
        Empbutton.TabIndex = 4
        Empbutton.Text = "Employees"
        Empbutton.UseVisualStyleBackColor = False
        ' 
        ' Salesbutton
        ' 
        Salesbutton.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Salesbutton.Dock = DockStyle.Fill
        Salesbutton.Location = New Point(876, 3)
        Salesbutton.Name = "Salesbutton"
        Salesbutton.Size = New Size(285, 91)
        Salesbutton.TabIndex = 3
        Salesbutton.Text = "Sales"
        Salesbutton.UseVisualStyleBackColor = False
        ' 
        ' Invbutton
        ' 
        Invbutton.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Invbutton.Dock = DockStyle.Fill
        Invbutton.Location = New Point(585, 3)
        Invbutton.Name = "Invbutton"
        Invbutton.Size = New Size(285, 91)
        Invbutton.TabIndex = 2
        Invbutton.Text = "Inventory"
        Invbutton.UseVisualStyleBackColor = False
        ' 
        ' Orderbutton
        ' 
        Orderbutton.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Orderbutton.Dock = DockStyle.Fill
        Orderbutton.Location = New Point(294, 3)
        Orderbutton.Name = "Orderbutton"
        Orderbutton.Size = New Size(285, 91)
        Orderbutton.TabIndex = 1
        Orderbutton.Text = "Take Order"
        Orderbutton.UseVisualStyleBackColor = False
        ' 
        ' Dashbutton
        ' 
        Dashbutton.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Dashbutton.Dock = DockStyle.Fill
        Dashbutton.Location = New Point(3, 3)
        Dashbutton.Name = "Dashbutton"
        Dashbutton.Size = New Size(285, 91)
        Dashbutton.TabIndex = 0
        Dashbutton.Text = "Dashboard"
        Dashbutton.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(BusinessName, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Top
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(1455, 48)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' BusinessName
        ' 
        BusinessName.AutoSize = True
        BusinessName.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        BusinessName.Dock = DockStyle.Fill
        BusinessName.Font = New Font("Segoe UI", 20F)
        BusinessName.Location = New Point(3, 0)
        BusinessName.Name = "BusinessName"
        BusinessName.Size = New Size(1449, 48)
        BusinessName.TabIndex = 0
        BusinessName.Text = "Bamboo's Grill Unlimited Rice"
        BusinessName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = SystemColors.ControlDark
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(0, 48)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1455, 468)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' Admin_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1455, 613)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Name = "Admin_Dashboard"
        Text = "Admin_Dashboard"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Empbutton As Button
    Friend WithEvents Salesbutton As Button
    Friend WithEvents Invbutton As Button
    Friend WithEvents Orderbutton As Button
    Friend WithEvents Dashbutton As Button
    Friend WithEvents BusinessName As Label
End Class

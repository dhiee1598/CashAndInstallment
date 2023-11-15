<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnItem = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 60)
        Me.Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(1052, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 43)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "X"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "XYZ Appliance Center "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSales)
        Me.Panel2.Controls.Add(Me.btnItem)
        Me.Panel2.Controls.Add(Me.btnCustomer)
        Me.Panel2.Controls.Add(Me.btnHome)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(230, 631)
        Me.Panel2.TabIndex = 1
        '
        'btnSales
        '
        Me.btnSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Image = Global.XYZ.My.Resources.Resources.icon_sales
        Me.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.Location = New System.Drawing.Point(0, 373)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnSales.Size = New System.Drawing.Size(228, 74)
        Me.btnSales.TabIndex = 4
        Me.btnSales.Text = " Sales"
        Me.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnItem
        '
        Me.btnItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnItem.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnItem.FlatAppearance.BorderSize = 0
        Me.btnItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItem.Image = Global.XYZ.My.Resources.Resources.icon_item
        Me.btnItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItem.Location = New System.Drawing.Point(0, 299)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnItem.Size = New System.Drawing.Size(228, 74)
        Me.btnItem.TabIndex = 3
        Me.btnItem.Text = " Item"
        Me.btnItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnItem.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomer.FlatAppearance.BorderSize = 0
        Me.btnCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Image = Global.XYZ.My.Resources.Resources.icon_customer
        Me.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomer.Location = New System.Drawing.Point(0, 225)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnCustomer.Size = New System.Drawing.Size(228, 74)
        Me.btnCustomer.TabIndex = 2
        Me.btnCustomer.Text = " Customer"
        Me.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Image = Global.XYZ.My.Resources.Resources.icon_home
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(0, 151)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnHome.Size = New System.Drawing.Size(228, 74)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "  Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Poppins Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(40, 29, 30, 80)
        Me.Label2.Size = New System.Drawing.Size(220, 151)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dashboard"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(1100, 691)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents btnItem As System.Windows.Forms.Button
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button

End Class

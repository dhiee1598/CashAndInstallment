<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.labelCusCount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.labelItemPuchased = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.labelTotalSales = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(303, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 84)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "WELCOME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 84)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TO XYZ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(591, 84)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CASH AND INSTALLMENT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(272, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(335, 84)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "APPLICATION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 37)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Customer"
        '
        'labelCusCount
        '
        Me.labelCusCount.AutoSize = True
        Me.labelCusCount.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCusCount.Location = New System.Drawing.Point(76, 51)
        Me.labelCusCount.Name = "labelCusCount"
        Me.labelCusCount.Size = New System.Drawing.Size(65, 84)
        Me.labelCusCount.TabIndex = 1
        Me.labelCusCount.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.labelCusCount)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(12, 393)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(217, 169)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.labelItemPuchased)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(328, 393)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(217, 169)
        Me.Panel2.TabIndex = 6
        '
        'labelItemPuchased
        '
        Me.labelItemPuchased.AutoSize = True
        Me.labelItemPuchased.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelItemPuchased.Location = New System.Drawing.Point(82, 51)
        Me.labelItemPuchased.Name = "labelItemPuchased"
        Me.labelItemPuchased.Size = New System.Drawing.Size(65, 84)
        Me.labelItemPuchased.TabIndex = 1
        Me.labelItemPuchased.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(174, 37)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Puchased Item"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.labelTotalSales)
        Me.Panel3.Controls.Add(Me.label10)
        Me.Panel3.Location = New System.Drawing.Point(636, 393)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(217, 169)
        Me.Panel3.TabIndex = 7
        '
        'labelTotalSales
        '
        Me.labelTotalSales.AutoSize = True
        Me.labelTotalSales.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTotalSales.Location = New System.Drawing.Point(55, 69)
        Me.labelTotalSales.Name = "labelTotalSales"
        Me.labelTotalSales.Size = New System.Drawing.Size(44, 56)
        Me.labelTotalSales.TabIndex = 1
        Me.labelTotalSales.Text = "0"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(42, 14)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(129, 37)
        Me.label10.TabIndex = 0
        Me.label10.Text = "Total Sales"
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(865, 626)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents labelCusCount As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents labelItemPuchased As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents labelTotalSales As System.Windows.Forms.Label
    Friend WithEvents label10 As System.Windows.Forms.Label
End Class

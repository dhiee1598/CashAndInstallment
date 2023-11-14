<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSale
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.groupBoxInstallment = New System.Windows.Forms.GroupBox()
        Me.comboBoxMonthsPay = New System.Windows.Forms.ComboBox()
        Me.txtDownpayment = New System.Windows.Forms.TextBox()
        Me.txtMonthlyPayment = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.labelDiscounted = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnAddQuantity = New System.Windows.Forms.Button()
        Me.btnMinusQuantity = New System.Windows.Forms.Button()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboBoxItemID = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboBoxCustomerID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radioBtnCash = New System.Windows.Forms.RadioButton()
        Me.radioBtnInstallment = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.groupBoxInstallment.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnSubmit)
        Me.GroupBox1.Controls.Add(Me.groupBoxInstallment)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 602)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CASH OR INSTALLMENT"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(253, 562)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 34)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(156, 562)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(91, 34)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'groupBoxInstallment
        '
        Me.groupBoxInstallment.Controls.Add(Me.comboBoxMonthsPay)
        Me.groupBoxInstallment.Controls.Add(Me.txtDownpayment)
        Me.groupBoxInstallment.Controls.Add(Me.txtMonthlyPayment)
        Me.groupBoxInstallment.Controls.Add(Me.Label10)
        Me.groupBoxInstallment.Controls.Add(Me.Label8)
        Me.groupBoxInstallment.Controls.Add(Me.Label9)
        Me.groupBoxInstallment.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxInstallment.ForeColor = System.Drawing.Color.White
        Me.groupBoxInstallment.Location = New System.Drawing.Point(32, 423)
        Me.groupBoxInstallment.Name = "groupBoxInstallment"
        Me.groupBoxInstallment.Size = New System.Drawing.Size(312, 133)
        Me.groupBoxInstallment.TabIndex = 4
        Me.groupBoxInstallment.TabStop = False
        Me.groupBoxInstallment.Text = "Installment:"
        Me.groupBoxInstallment.Visible = False
        '
        'comboBoxMonthsPay
        '
        Me.comboBoxMonthsPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxMonthsPay.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxMonthsPay.FormattingEnabled = True
        Me.comboBoxMonthsPay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.comboBoxMonthsPay.Location = New System.Drawing.Point(129, 63)
        Me.comboBoxMonthsPay.Name = "comboBoxMonthsPay"
        Me.comboBoxMonthsPay.Size = New System.Drawing.Size(177, 27)
        Me.comboBoxMonthsPay.TabIndex = 4
        '
        'txtDownpayment
        '
        Me.txtDownpayment.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDownpayment.Location = New System.Drawing.Point(129, 26)
        Me.txtDownpayment.Name = "txtDownpayment"
        Me.txtDownpayment.Size = New System.Drawing.Size(177, 25)
        Me.txtDownpayment.TabIndex = 6
        Me.txtDownpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonthlyPayment
        '
        Me.txtMonthlyPayment.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyPayment.Location = New System.Drawing.Point(129, 103)
        Me.txtMonthlyPayment.Name = "txtMonthlyPayment"
        Me.txtMonthlyPayment.ReadOnly = True
        Me.txtMonthlyPayment.Size = New System.Drawing.Size(177, 25)
        Me.txtMonthlyPayment.TabIndex = 5
        Me.txtMonthlyPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 23)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Monthly Payment:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 23)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Months To Pay:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Down Payment:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.labelDiscounted)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtTotalPrice)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtQuantity)
        Me.GroupBox4.Controls.Add(Me.btnAddQuantity)
        Me.GroupBox4.Controls.Add(Me.btnMinusQuantity)
        Me.GroupBox4.Controls.Add(Me.txtItemPrice)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtItemName)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.comboBoxItemID)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(32, 205)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(312, 212)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Select Item:"
        '
        'labelDiscounted
        '
        Me.labelDiscounted.AutoSize = True
        Me.labelDiscounted.Location = New System.Drawing.Point(45, 180)
        Me.labelDiscounted.Name = "labelDiscounted"
        Me.labelDiscounted.Size = New System.Drawing.Size(95, 23)
        Me.labelDiscounted.TabIndex = 12
        Me.labelDiscounted.Text = "(Discounted)"
        Me.labelDiscounted.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Quantity:"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(146, 178)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(160, 25)
        Me.txtTotalPrice.TabIndex = 10
        Me.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Total:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(181, 134)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(65, 31)
        Me.txtQuantity.TabIndex = 8
        Me.txtQuantity.Text = "1"
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddQuantity
        '
        Me.btnAddQuantity.FlatAppearance.BorderSize = 0
        Me.btnAddQuantity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAddQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddQuantity.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddQuantity.Location = New System.Drawing.Point(256, 125)
        Me.btnAddQuantity.Name = "btnAddQuantity"
        Me.btnAddQuantity.Size = New System.Drawing.Size(50, 47)
        Me.btnAddQuantity.TabIndex = 7
        Me.btnAddQuantity.Text = "+"
        Me.btnAddQuantity.UseVisualStyleBackColor = True
        '
        'btnMinusQuantity
        '
        Me.btnMinusQuantity.FlatAppearance.BorderSize = 0
        Me.btnMinusQuantity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMinusQuantity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMinusQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinusQuantity.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinusQuantity.Location = New System.Drawing.Point(129, 125)
        Me.btnMinusQuantity.Name = "btnMinusQuantity"
        Me.btnMinusQuantity.Size = New System.Drawing.Size(46, 47)
        Me.btnMinusQuantity.TabIndex = 6
        Me.btnMinusQuantity.Text = "-"
        Me.btnMinusQuantity.UseVisualStyleBackColor = True
        '
        'txtItemPrice
        '
        Me.txtItemPrice.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemPrice.Location = New System.Drawing.Point(129, 95)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.ReadOnly = True
        Me.txtItemPrice.Size = New System.Drawing.Size(177, 25)
        Me.txtItemPrice.TabIndex = 5
        Me.txtItemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Price:"
        '
        'txtItemName
        '
        Me.txtItemName.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(129, 62)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.ReadOnly = True
        Me.txtItemName.Size = New System.Drawing.Size(177, 25)
        Me.txtItemName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Item Name:"
        '
        'comboBoxItemID
        '
        Me.comboBoxItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxItemID.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxItemID.FormattingEnabled = True
        Me.comboBoxItemID.Location = New System.Drawing.Point(129, 26)
        Me.comboBoxItemID.Name = "comboBoxItemID"
        Me.comboBoxItemID.Size = New System.Drawing.Size(177, 27)
        Me.comboBoxItemID.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Item ID:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCustomerName)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.comboBoxCustomerID)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(32, 100)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(312, 99)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select Customer:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(129, 62)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(177, 25)
        Me.txtCustomerName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer Name:"
        '
        'comboBoxCustomerID
        '
        Me.comboBoxCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxCustomerID.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxCustomerID.FormattingEnabled = True
        Me.comboBoxCustomerID.Location = New System.Drawing.Point(129, 26)
        Me.comboBoxCustomerID.Name = "comboBoxCustomerID"
        Me.comboBoxCustomerID.Size = New System.Drawing.Size(177, 27)
        Me.comboBoxCustomerID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radioBtnCash)
        Me.GroupBox2.Controls.Add(Me.radioBtnInstallment)
        Me.GroupBox2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(32, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 56)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Payment Method:"
        '
        'radioBtnCash
        '
        Me.radioBtnCash.AutoSize = True
        Me.radioBtnCash.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioBtnCash.Location = New System.Drawing.Point(38, 23)
        Me.radioBtnCash.Name = "radioBtnCash"
        Me.radioBtnCash.Size = New System.Drawing.Size(60, 26)
        Me.radioBtnCash.TabIndex = 0
        Me.radioBtnCash.Text = "CASH"
        Me.radioBtnCash.UseVisualStyleBackColor = True
        '
        'radioBtnInstallment
        '
        Me.radioBtnInstallment.AutoSize = True
        Me.radioBtnInstallment.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioBtnInstallment.Location = New System.Drawing.Point(175, 23)
        Me.radioBtnInstallment.Name = "radioBtnInstallment"
        Me.radioBtnInstallment.Size = New System.Drawing.Size(100, 26)
        Me.radioBtnInstallment.TabIndex = 1
        Me.radioBtnInstallment.Text = "INSTALLMENT"
        Me.radioBtnInstallment.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(406, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(447, 490)
        Me.DataGridView1.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(461, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(348, 56)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "ALL PURCHASED ITEM"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(762, 574)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 34)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'FormSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(865, 626)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.Name = "FormSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSale"
        Me.GroupBox1.ResumeLayout(False)
        Me.groupBoxInstallment.ResumeLayout(False)
        Me.groupBoxInstallment.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioBtnInstallment As System.Windows.Forms.RadioButton
    Friend WithEvents radioBtnCash As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboBoxCustomerID As System.Windows.Forms.ComboBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comboBoxItemID As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtItemPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnMinusQuantity As System.Windows.Forms.Button
    Friend WithEvents btnAddQuantity As System.Windows.Forms.Button
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents groupBoxInstallment As System.Windows.Forms.GroupBox
    Friend WithEvents txtDownpayment As System.Windows.Forms.TextBox
    Friend WithEvents txtMonthlyPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents comboBoxMonthsPay As System.Windows.Forms.ComboBox
    Friend WithEvents labelDiscounted As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class

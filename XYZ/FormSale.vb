Public Class FormSale

    Dim discounted As Integer

    Sub ClearText()
        radioBtnCash.Checked = False
        radioBtnInstallment.Checked = False
        comboBoxCustomerID.SelectedItem = Nothing
        txtCustomerName.Clear()
        comboBoxItemID.SelectedItem = Nothing
        txtItemName.Clear()
        txtItemPrice.Clear()
        txtTotalPrice.Clear()
        txtQuantity.Text = "1"
        btnAddQuantity.Enabled = False
        btnMinusQuantity.Enabled = False
        txtDownpayment.Clear()
        comboBoxMonthsPay.SelectedItem = Nothing
        txtMonthlyPayment.Clear()
    End Sub

    Sub DisableAll()
        radioBtnCash.Checked = False
        radioBtnInstallment.Checked = False
        comboBoxCustomerID.Enabled = False
        txtCustomerName.Enabled = False
        comboBoxItemID.Enabled = False
        txtItemName.Enabled = False
        txtItemPrice.Enabled = False
        txtTotalPrice.Enabled = False
        btnAddQuantity.Enabled = False
        txtQuantity.Enabled = False
        btnMinusQuantity.Enabled = False
        txtDownpayment.Enabled = False
        comboBoxMonthsPay.Enabled = False
        txtMonthlyPayment.Enabled = False
    End Sub

    Sub CashEnable()
        comboBoxCustomerID.Enabled = True
        txtCustomerName.Enabled = True
        comboBoxItemID.Enabled = True
        txtItemName.Enabled = True
        comboBoxCustomerID.SelectedItem = Nothing
        txtCustomerName.Clear()
        comboBoxItemID.SelectedItem = Nothing
        txtItemName.Clear()
        txtItemPrice.Clear()
        txtTotalPrice.Clear()
        txtQuantity.Text = "1"
        btnAddQuantity.Enabled = False
        btnMinusQuantity.Enabled = False
        txtDownpayment.Clear()
        comboBoxMonthsPay.SelectedItem = Nothing
        txtMonthlyPayment.Clear()
    End Sub

    Sub InstallmentEnable()
        comboBoxCustomerID.Enabled = True
        txtCustomerName.Enabled = True
        comboBoxItemID.Enabled = True
        txtItemName.Enabled = True
        txtDownpayment.Enabled = True
        comboBoxMonthsPay.Enabled = True
        txtMonthlyPayment.Enabled = True
        comboBoxCustomerID.SelectedItem = Nothing
        txtCustomerName.Clear()
        comboBoxItemID.SelectedItem = Nothing
        txtItemName.Clear()
        txtItemPrice.Clear()
        txtTotalPrice.Clear()
        txtQuantity.Text = "1"
        btnAddQuantity.Enabled = False
        btnMinusQuantity.Enabled = False
        txtDownpayment.Clear()
        comboBoxMonthsPay.SelectedItem = Nothing
        txtMonthlyPayment.Clear()

    End Sub

    Sub LoadComboBoxData()
        comboBoxCustomerID.DataSource = DisplayCustomerTable("SELECT * FROM CUSTOMER")
        comboBoxCustomerID.DisplayMember = "CUSTOMER"
        comboBoxCustomerID.ValueMember = "CUS_ID"
        comboBoxItemID.DataSource = DisplayItemTable("SELECT * FROM ITEM")
        comboBoxItemID.DisplayMember = "ITEM"
        comboBoxItemID.ValueMember = "ITEM_ID"
    End Sub

    Private Sub LoadData()
        Dim querySelect As String = "SELECT SALES_ID AS ID, CONCAT(CUSTOMER.CUS_FNAME, ' ', CUSTOMER.CUS_MNAME, ' ', CUSTOMER.CUS_LNAME) AS NAME, ITEM_NAME AS ITEM, SALES_QUANTITY AS QTY, ITEM_PRICE AS PRICE, SALES_TOTAL_PRICE AS TOTAL, SALES_CREATED_AT AS DATE FROM SALES INNER JOIN CUSTOMER ON SALES.CUS_ID = CUSTOMER.CUS_ID INNER JOIN ITEM  ON SALES.ITEM_ID = ITEM.ITEM_ID;"
        DataGridView1.DataSource = DisplaySalesTable(querySelect)
        DataGridView1.ForeColor = Color.Black
        Me.DataGridView1.DefaultCellStyle.Font = New Font("Poppins", 8)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Poppins", 9, FontStyle.Bold)
    End Sub

    ' ------------------------ FORM LOAD ------------------------
    Private Sub FormSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadComboBoxData()
        ClearText()
        DisableAll()
        LoadData()
    End Sub

    ' --------------------- FORM DEACTIVE EVENT --------------------
    Private Sub FormSale_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub

    ' ----------------- BUTTON QUANTITY CLICK PLUS, MINUS AND MOUSE ENTER AND LEAVE ------------------------
    Private Sub btnMinusQuantity_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinusQuantity.MouseEnter
        btnMinusQuantity.ForeColor = Color.Red
    End Sub
    Private Sub btnMinusQuantity_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinusQuantity.MouseLeave
        btnMinusQuantity.ForeColor = Color.Transparent
    End Sub
    Private Sub btnAddQuantity_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddQuantity.MouseEnter
        btnAddQuantity.ForeColor = Color.Red
    End Sub
    Private Sub btnAddQuantity_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddQuantity.MouseLeave
        btnAddQuantity.ForeColor = Color.Transparent
    End Sub
    Private Sub btnAddQuantity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddQuantity.Click
        Dim newQuantity As Integer = Convert.ToInt32(txtQuantity.Text) + 1

        If radioBtnCash.Checked Then
            Dim newTotal As Integer = Convert.ToInt32(discounted) * newQuantity
            txtQuantity.Text = newQuantity.ToString
            txtTotalPrice.Text = newTotal.ToString
        Else
            Dim newTotal As Integer = Convert.ToInt32(txtItemPrice.Text) * newQuantity
            txtQuantity.Text = newQuantity.ToString
            txtTotalPrice.Text = newTotal.ToString
        End If
    End Sub
    Private Sub btnMinusQuantity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinusQuantity.Click
        If Convert.ToInt32(txtQuantity.Text) > 1 Then
            Dim newQuantity As Integer = Convert.ToInt32(txtQuantity.Text) - 1

            If radioBtnCash.Checked Then
                Dim newTotal As Integer = Convert.ToInt32(txtTotalPrice.Text) - discounted
                txtQuantity.Text = newQuantity.ToString
                txtTotalPrice.Text = newTotal.ToString
            Else
                Dim newTotal As Integer = Convert.ToInt32(txtTotalPrice.Text) - txtItemPrice.Text
                txtQuantity.Text = newQuantity.ToString
                txtTotalPrice.Text = newTotal.ToString
            End If
        End If
    End Sub

    ' ----------------------RADIO BUTTON CHECK CHANGE EVENT --------------------------
    Private Sub radioBtnInstallment_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioBtnInstallment.CheckedChanged
        If radioBtnInstallment.Checked Then
            groupBoxInstallment.Visible = True
            InstallmentEnable()
        Else
            groupBoxInstallment.Visible = False
        End If
    End Sub
    Private Sub radioBtnCash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioBtnCash.CheckedChanged
        If radioBtnCash.Checked Then
            CashEnable()
            labelDiscounted.Visible = True
        Else
            labelDiscounted.Visible = False
        End If
    End Sub

    ' ----------------------------- BUTTON CLEAR -------------------------------------
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearText()
        DisableAll()
    End Sub

    ' ---------------------- COMBO BOX SELECTION CHANGe COMMITED ---------------------
    Private Sub comboBoxCustomerID_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBoxCustomerID.SelectionChangeCommitted
        Dim querySelectSingle = "SELECT * FROM CUSTOMER WHERE CUS_ID = '" & comboBoxCustomerID.Text & "';"
        txtCustomerName.Text = GetTable(querySelectSingle)("CUS_FNAME") & " " & GetTable(querySelectSingle)("CUS_MNAME") & " " & GetTable(querySelectSingle)("CUS_LNAME")
    End Sub
    Private Sub comboBoxItemID_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBoxItemID.SelectionChangeCommitted
        txtItemPrice.Enabled = True
        txtTotalPrice.Enabled = True
        btnAddQuantity.Enabled = True
        txtQuantity.Enabled = True
        btnMinusQuantity.Enabled = True
        txtQuantity.Text = "1"
        Dim querySelectSingle = "SELECT * FROM ITEM WHERE ITEM_ID = '" & comboBoxItemID.Text & "';"
        txtItemName.Text = GetTable(querySelectSingle)("ITEM_NAME")
        txtItemPrice.Text = GetTable(querySelectSingle)("ITEM_PRICE")
        If radioBtnCash.Checked Then
            If txtItemName.Text = "System Unit" Then
                discounted = Convert.ToDouble(txtItemPrice.Text) - (Convert.ToDouble(txtItemPrice.Text) * 0.02)
                txtTotalPrice.Text = discounted.ToString
            ElseIf txtItemName.Text = "Computer Set" Then
                discounted = Convert.ToDouble(txtItemPrice.Text) - (Convert.ToDouble(txtItemPrice.Text) * 0.1)
                txtTotalPrice.Text = discounted.ToString
            ElseIf txtItemName.Text = "Epson Printer" Then
                discounted = Convert.ToDouble(txtItemPrice.Text) - (Convert.ToDouble(txtItemPrice.Text) * 0.03)
                txtTotalPrice.Text = discounted.ToString
            ElseIf txtItemName.Text = "Canon Printer" Then
                discounted = Convert.ToDouble(txtItemPrice.Text) - (Convert.ToDouble(txtItemPrice.Text) * 0.05)
                txtTotalPrice.Text = discounted.ToString
            Else
                discounted = Convert.ToDouble(txtItemPrice.Text) - (Convert.ToDouble(txtItemPrice.Text) * 0.06)
                txtTotalPrice.Text = discounted.ToString
            End If
        Else
            txtTotalPrice.Text = GetTable(querySelectSingle)("ITEM_PRICE")
        End If

    End Sub

    Private Sub comboBoxMonthsPay_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBoxMonthsPay.SelectionChangeCommitted
        Dim monthlyPayment As Double = (Convert.ToDouble(txtTotalPrice.Text) - Convert.ToDouble(txtDownpayment.Text)) / Convert.ToDouble(comboBoxMonthsPay.Text)
        txtMonthlyPayment.Text = Math.Round(monthlyPayment, 2).ToString
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If radioBtnCash.Checked = False And radioBtnInstallment.Checked = False Then
            MessageBox.Show("Please select a Payment Method")
        Else
            Dim id As String = "SALES-" & Guid.NewGuid().ToString("N").Substring(0, 10)
            If radioBtnCash.Checked Then
                If comboBoxCustomerID.Text = Nothing Or comboBoxItemID.Text = Nothing Then
                    MessageBox.Show("Please fill up all required fields!")
                Else
                    ' DO SOMTHING IF ALL REQUIRED FIELDS IS FILL UP
                    Dim insertQuery = "INSERT INTO SALES(SALES_ID, CUS_ID, ITEM_ID, SALES_PAYMENT_METHOD, SALES_QUANTITY, SALES_TOTAL_PRICE) VALUES ('" & id & "', '" & comboBoxCustomerID.Text & "', '" & comboBoxItemID.Text & "', '" & radioBtnCash.Text & "', '" & txtQuantity.Text & "', '" & txtTotalPrice.Text & "');"
                    InsertNew(insertQuery)
                    MessageBox.Show("Purchase Successfully!")
                    LoadData()
                    ClearText()
                End If
            Else
                If comboBoxCustomerID.Text = Nothing Or comboBoxItemID.Text = Nothing Or txtDownpayment.Text = "" Or comboBoxMonthsPay.Text = Nothing Then
                    MessageBox.Show("Please fill up all required fields!")
                Else
                    Dim insertQuery = "INSERT INTO SALES(SALES_ID, CUS_ID, ITEM_ID, SALES_PAYMENT_METHOD, SALES_DOWNPAYMENT, SALES_MONTHLY_PAYMENT, SALES_MONTHS_TO_PAY, SALES_QUANTITY, SALES_TOTAL_PRICE) VALUES ('" & id & "', '" & comboBoxCustomerID.Text & "', '" & comboBoxItemID.Text & "', '" & radioBtnInstallment.Text & "','" & txtDownpayment.Text & "','" & txtMonthlyPayment.Text & "','" & comboBoxMonthsPay.Text & "', '" & txtQuantity.Text & "', '" & txtTotalPrice.Text & "');"
                    InsertNew(insertQuery)
                    MessageBox.Show("Purchase Successfully!")
                    LoadData()
                    ClearText()
                End If
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        On Error Resume Next
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim queryDelete As String = "DELETE FROM SALES WHERE SALES_ID = '" & DataGridView1.Item(0, i).Value & "';"
            DeleteFromTable(queryDelete)
            MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
        End If
    End Sub
End Class
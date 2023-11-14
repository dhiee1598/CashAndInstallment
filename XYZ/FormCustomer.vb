Public Class FormCustomer

    Dim isValidFname As Boolean
    Dim isValidMname As Boolean
    Dim isValidLname As Boolean
    Dim isValidAddress As Boolean
    Dim isValidContact As Boolean
    Dim isValidEmail As Boolean

    Private Sub FormCustomer_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub

    Private Sub FormCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()
        txtPath.Text = "C:;Users;Dexter;Documents;Visual Studio 2010;Projects;XYZ;XYZ;images;default-image.png"
        Me.DataGridView1.Columns(7).Visible = False
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Not isValidFname Or Not isValidMname Or Not isValidLname Or Not isValidAddress Or Not isValidEmail Or Not isValidContact Then
            MessageBox.Show("Please enter a valid input", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If btnAdd.Text = "ADD" Then
                Dim queryCheck = "SELECT * FROM CUSTOMER WHERE CUS_FNAME = '" & txtFname.Text & "' AND CUS_MNAME = '" & txtMname.Text & "' AND CUS_LNAME = '" & txtLname.Text & "'"
                If CheckForDuplicate(queryCheck) Then
                    MessageBox.Show("Customer Already Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim id As String = "CUS-" & Guid.NewGuid().ToString("N").Substring(0, 10)
                    Dim queryInsert As String = "INSERT INTO CUSTOMER VALUES('" & id & "','" & txtFname.Text & "','" & txtMname.Text & "','" & txtLname.Text & "','" & txtAddress.Text & "','" & txtEmail.Text & "','" & txtContact.Text & "','" & txtPath.Text & "');"
                    InsertNew(queryInsert)
                    MessageBox.Show("Successfully Added Customer", "New", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FormatText()
                    LoadData()
                End If
            Else
                Dim queryUpdate As String = "UPDATE CUSTOMER SET CUS_FNAME = '" & txtFname.Text & "', CUS_MNAME = '" & txtMname.Text & "', CUS_LNAME = '" & txtLname.Text & "', CUS_ADDRESS = '" & txtAddress.Text & "', CUS_EMAIL = '" & txtEmail.Text & "', CUS_CONTACT = '" & txtContact.Text & "', CUS_IMAGE = '" & txtPath.Text & "' WHERE CUS_ID = '" & txtID.Text & "';"
                UpdateFromTable(queryUpdate)
                MessageBox.Show("Customer Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
            End If
        End If
    End Sub

    Sub LoadData()
        Dim querySelect As String = "SELECT CUS_ID AS ID, CUS_FNAME AS FNAME, CUS_MNAME AS MNAME, CUS_LNAME AS LNAME, CUS_ADDRESS AS ADDRESS, CUS_EMAIL AS EMAIL, CUS_CONTACT AS CONTACT, CUS_IMAGE as PHOTO  FROM CUSTOMER;"
        DataGridView1.DataSource = DisplayCustomerTable(querySelect)
        DataGridView1.ForeColor = Color.Black
        Me.DataGridView1.DefaultCellStyle.Font = New Font("Poppins", 10)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Poppins", 11, FontStyle.Bold)
    End Sub

    Sub FormatText()
        txtFname.BackColor = Color.White
        txtMname.BackColor = Color.White
        txtLname.BackColor = Color.White
        txtAddress.BackColor = Color.White
        txtEmail.BackColor = Color.White
        txtContact.BackColor = Color.White
        txtID.Clear()
        txtFname.Clear()
        txtMname.Clear()
        txtLname.Clear()
        txtAddress.Clear()
        txtEmail.Clear()
        txtContact.Clear()
        txtPath.Text = txtPath.Text = "C:;Users;Dexter;Documents;Visual Studio 2010;Projects;XYZ;XYZ;images;default-image.png"
        profilePicBox.ImageLocation = "C:\Users\Dexter\Documents\Visual Studio 2010\Projects\XYZ\XYZ\images\default-image.png"
        txtID.Visible = False
        labelCusId.Visible = False
        btnAdd.Text = "ADD"
        btnDelete.Visible = False
        isValidFname = False
        isValidMname = False
        isValidLname = False
        isValidAddress = False
        isValidEmail = False
        isValidContact = False
        btnSearch.BackColor = Color.FromArgb(1, 1, 13)
        LoadData()
    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        OpenFileDialog1.Filter = "Jpeg|*.JPG|Bitmap|*.BMP|Gif|*.GIF"
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            profilePicBox.ImageLocation = OpenFileDialog1.FileName
            txtPath.Text = Replace(OpenFileDialog1.FileName, "\", ";")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        FormatText()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim queryDelete As String = "DELETE FROM CUSTOMER WHERE CUS_ID = '" & txtID.Text & "';"
            DeleteFromTable(queryDelete)
            MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            FormatText()
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        On Error Resume Next
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtID.Visible = True
        labelCusId.Visible = True
        Me.txtID.Text = DataGridView1.Item(0, i).Value
        Me.txtFname.Text = DataGridView1.Item(1, i).Value
        Me.txtMname.Text = DataGridView1.Item(2, i).Value
        Me.txtLname.Text = DataGridView1.Item(3, i).Value
        Me.txtAddress.Text = DataGridView1.Item(4, i).Value
        Me.txtEmail.Text = DataGridView1.Item(5, i).Value
        Me.txtContact.Text = DataGridView1.Item(6, i).Value
        Me.txtPath.Text = DataGridView1.Item(7, i).Value
        profilePicBox.ImageLocation = Replace(txtPath.Text, ";", "\")
        btnAdd.Text = "Update"
        btnDelete.Visible = True

    End Sub

    Private Sub txtFname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFname.TextChanged
        If Not txtFname.Text = "" Then
            If Not TextValidation("^[A-Z][a-z]+(\s[A-Z][a-z]+)?$", txtFname.Text) Then
                txtFname.BackColor = Color.FromArgb(255, 184, 184)
                isValidFname = False
            Else
                txtFname.BackColor = Color.White
                isValidFname = True
            End If
        Else
            txtFname.BackColor = Color.White
            isValidFname = False
        End If
    End Sub

    Private Sub txtMname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMname.TextChanged
        If Not txtMname.Text = "" Then
            If Not TextValidation("^[A-Z][a-z]+$", txtMname.Text) Then
                txtMname.BackColor = Color.FromArgb(255, 184, 184)
                isValidMname = False
            Else
                txtMname.BackColor = Color.White
                isValidMname = True
            End If
        Else
            txtMname.BackColor = Color.White
            isValidMname = False
        End If
    End Sub

    Private Sub txtLname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLname.TextChanged
        If Not txtLname.Text = "" Then
            If Not TextValidation("^[A-Z][a-z]+(\s[A-Z][a-z]+)?$", txtLname.Text) Then
                txtLname.BackColor = Color.FromArgb(255, 184, 184)
                isValidLname = False
            Else
                txtLname.BackColor = Color.White
                isValidLname = True
            End If
        Else
            txtLname.BackColor = Color.White
            isValidLname = False
        End If
    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged
        If Not txtAddress.Text = "" Then
            If Not TextValidation("^[A-Z\d][\w\.\s,-]{5,}$", txtAddress.Text) Then
                txtAddress.BackColor = Color.FromArgb(255, 184, 184)
                isValidAddress = False
            Else
                txtAddress.BackColor = Color.White
                isValidAddress = True
            End If
        Else
            txtAddress.BackColor = Color.White
            isValidAddress = False
        End If
    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged
        If Not txtEmail.Text = "" Then
            If Not TextValidation("^[\w\d_-]+@(yahoo|gmail).com$", txtEmail.Text) Then
                txtEmail.BackColor = Color.FromArgb(255, 184, 184)
                isValidEmail = False
            Else
                txtEmail.BackColor = Color.White
                isValidEmail = True
            End If
        Else
            txtEmail.BackColor = Color.White
            isValidEmail = False
        End If
    End Sub

    Private Sub txtContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContact.TextChanged
        If Not txtContact.Text = "" Then
            If Not TextValidation("^[0][0-9]{10,10}$", txtContact.Text) Then
                txtContact.BackColor = Color.FromArgb(255, 184, 184)
                isValidContact = False
            Else
                txtContact.BackColor = Color.White
                isValidContact = True
            End If
        Else
            txtContact.BackColor = Color.White
            isValidContact = False
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim customerLastName As String = InputBox("Enter customer last name:", "SEARCH")
        If Not customerLastName = "" Then
            Dim querySearch As String = "SELECT CUS_ID AS ID, CUS_FNAME AS FNAME, CUS_MNAME AS MNAME, CUS_LNAME AS LNAME, CUS_ADDRESS AS ADDRESS, CUS_EMAIL AS EMAIL, CUS_CONTACT AS CONTACT, CUS_IMAGE as PHOTO  FROM CUSTOMER WHERE CUS_LNAME LIKE '" & customerLastName & "%' ORDER BY CUS_LNAME;"
            If DisplayCustomerSearch(querySearch).Rows.Count = 0 Then
                MessageBox.Show("No Customer Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                DataGridView1.DataSource = DisplayCustomerSearch(querySearch)
                btnSearch.BackColor = Color.Navy
            End If
        End If

    End Sub

End Class
Public Class FormItem
    Dim isValidName As Boolean
    Dim isValidDescription As Boolean
    Dim isValidPrice As Boolean

    Private Sub FormItem_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub

    Private Sub FormItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim querySelect As String = "SELECT ITEM_ID AS ID, ITEM_NAME AS NAME, ITEM_DESCRIPTION AS DESCRIPTION, ITEM_PRICE AS PRICE FROM ITEM;"
        DataGridView1.DataSource = DisplayItemTable(querySelect)
        DataGridView1.ForeColor = Color.Black
        Me.DataGridView1.DefaultCellStyle.Font = New Font("Poppins", 10)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Poppins", 11, FontStyle.Bold)
    End Sub

    Private Sub FormatText()
        txtName.Clear()
        txtDescription.Clear()
        txtPrice.Clear()
        txtId.Clear()
        btnAdd.Text = "ADD"
        btnDelete.Visible = False
        labelId.Visible = False
        txtId.Visible = False
    End Sub

    Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.TextChanged
        If Not txtDescription.Text = "" Then
            If Not TextValidation("^[A-Z\d][\w\.\s,-]{5,}$", txtDescription.Text) Then
                txtDescription.BackColor = Color.FromArgb(255, 184, 184)
                isValidDescription = False
            Else
                txtDescription.BackColor = Color.White
                isValidDescription = True
            End If
        Else
            txtDescription.BackColor = Color.White
            isValidDescription = False
        End If
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        If Not txtName.Text = "" Then
            If Not TextValidation("^[A-Z][a-z]+(\s[A-Z][a-z]+)?$", txtName.Text) Then
                txtName.BackColor = Color.FromArgb(255, 184, 184)
                isValidName = False
            Else
                txtName.BackColor = Color.White
                isValidName = True
            End If
        Else
            txtName.BackColor = Color.White
            isValidName = False
        End If
    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        If Not txtPrice.Text = "" Then
            If Not TextValidation("^[0-9]{1,}$", txtPrice.Text) Then
                txtPrice.BackColor = Color.FromArgb(255, 184, 184)
                isValidPrice = False
            Else
                txtPrice.BackColor = Color.White
                isValidPrice = True
            End If
        Else
            txtPrice.BackColor = Color.White
            isValidPrice = False
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Not isValidName Or Not isValidPrice Or Not isValidDescription Then
            MessageBox.Show("Please enter a valid input", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If btnAdd.Text = "ADD" Then
                Dim queryCheck = "SELECT * FROM ITEM WHERE ITEM_NAME = '" & txtName.Text & "';"
                If CheckForDuplicate(queryCheck) Then
                    MessageBox.Show("Item Already Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim id As String = "ITEM-" & Guid.NewGuid().ToString("N").Substring(0, 10)
                    Dim queryInsert As String = "INSERT INTO ITEM VALUES('" & id & "','" & txtName.Text & "','" & txtDescription.Text & "'," & txtPrice.Text & ");"
                    InsertNew(queryInsert)
                    MessageBox.Show("Successfully Added Item", "New", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadData()
                    FormatText()
                    txtName.Focus()
                End If
            Else
                Dim queryUpdate As String = "UPDATE ITEM SET ITEM_NAME = '" & txtName.Text & "', ITEM_DESCRIPTION = '" & txtDescription.Text & "', ITEM_PRICE = '" & txtPrice.Text & "' WHERE ITEM_ID = '" & txtId.Text & "';"
                UpdateFromTable(queryUpdate)
                MessageBox.Show("Item Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        On Error Resume Next
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtId.Visible = True
        labelId.Visible = True
        Me.txtId.Text = DataGridView1.Item(0, i).Value
        Me.txtName.Text = DataGridView1.Item(1, i).Value
        Me.txtDescription.Text = DataGridView1.Item(2, i).Value
        Me.txtPrice.Text = DataGridView1.Item(3, i).Value
        btnAdd.Text = "Update"
        btnDelete.Visible = True
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        FormatText()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim queryDelete As String = "DELETE FROM ITEM WHERE ITEM_ID = '" & txtId.Text & "';"
            DeleteFromTable(queryDelete)
            MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            FormatText()
        End If
    End Sub

End Class
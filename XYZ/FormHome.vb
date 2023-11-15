Public Class FormHome


    Private Sub FormHome_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub

    Private Sub FormHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetTotalCustomer()
        GetTotalPuchasedItem()
        GetTotalSum()
    End Sub

    Sub GetTotalCustomer()
        Try
            If (con.State = ConnectionState.Open) Then
                con.Close()
            End If
            con.Open()
            command.Connection = con
            command.CommandText = "SELECT COUNT(CUS_ID) AS TOTAL_CUSTOMER FROM CUSTOMER;"
            adapter.SelectCommand = command
            reader = command.ExecuteReader
            reader.Read()
            labelCusCount.Text = reader("TOTAL_CUSTOMER")
            con.Close()
            reader.Dispose()
            command.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
            command.Dispose()
            con.Close()
        End Try
    End Sub

    Sub GetTotalPuchasedItem()
        Try
            If (con.State = ConnectionState.Open) Then
                con.Close()
            End If
            con.Open()
            command.Connection = con
            command.CommandText = "SELECT COUNT(SALES_ID) TOTAL_PUCHASED FROM SALES;"
            adapter.SelectCommand = command
            reader = command.ExecuteReader
            reader.Read()
            labelItemPuchased.Text = reader("TOTAL_PUCHASED")
            con.Close()
            reader.Dispose()
            command.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
            command.Dispose()
            con.Close()
        End Try
    End Sub

    Sub GetTotalSum()
        Try
            If (con.State = ConnectionState.Open) Then
                con.Close()
            End If
            con.Open()
            command.Connection = con
            command.CommandText = "SELECT COALESCE(SUM(SALES_TOTAL_PRICE), 0) AS TOTAL FROM SALES;"
            adapter.SelectCommand = command
            reader = command.ExecuteReader
            reader.Read()
            labelTotalSales.Text = reader("TOTAL")
            con.Close()
            reader.Dispose()
            command.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
            command.Dispose()
            con.Close()
        End Try
    End Sub
End Class
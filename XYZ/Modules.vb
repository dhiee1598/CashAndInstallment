Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Module Modules

    Public command As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public Ds As DataSet
    Public Dt As DataTable
    Public reader As MySqlDataReader
    Public con As MySqlConnection = New MySqlConnection("SERVER=localhost;UID=root;PASSWORD=dexter1510;DATABASE=midterm")

    Sub InsertNew(ByVal query)
        Try
            If (con.State = ConnectionState.Open) Then
                con.Close()
            End If
            con.Open()
            command.Connection = con
            command.CommandText = query
            command.ExecuteNonQuery()
            command.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            command.Dispose()
            con.Close()
        End Try
    End Sub

    Sub UpdateFromTable(ByVal query)
        Try
            If (con.State = ConnectionState.Open) Then
                con.Close()
            End If
            con.Open()
            command.Connection = con
            command.CommandText = query
            command.ExecuteNonQuery()
            command.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            command.Dispose()
            con.Close()
        End Try
    End Sub

    Public Function CheckForDuplicate(ByVal query) As Boolean
        Try
            If (con.State = ConnectionState.Open) Then
                con.Close()
            End If
            con.Open()
            command.Connection = con
            command.CommandText = query
            adapter.SelectCommand = command
            reader = command.ExecuteReader
            If reader.HasRows Then
                command.Dispose()
                adapter.Dispose()
                con.Close()
                Return True
            Else
                command.Dispose()
                adapter.Dispose()
                con.Close()
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            command.Dispose()
            adapter.Dispose()
            con.Close()
            Return False
        End Try
    End Function

    Public Function DisplayCustomerTable(ByVal query)
            If (con.State = ConnectionState.Open) Then
                con.Close()
            End If
            con.Open()
            command.Connection = con
            command.CommandText = query
            adapter.SelectCommand = command
            reader = command.ExecuteReader
            Dt = New DataTable
            Dt.Clear()
            Dt.Load(reader)
            command.Dispose()
            reader.Dispose()
            adapter.Dispose()
            con.Close()
            DisplayCustomerTable = Dt
    End Function

    Public Function DisplaySalesTable(ByVal query)
        If (con.State = ConnectionState.Open) Then
            con.Close()
        End If
        con.Open()
        command.Connection = con
        command.CommandText = query
        adapter.SelectCommand = command
        reader = command.ExecuteReader
        Dt = New DataTable
        Dt.Clear()
        Dt.Load(reader)
        command.Dispose()
        reader.Dispose()
        adapter.Dispose()
        con.Close()
        DisplaySalesTable = Dt
    End Function

    Public Function DisplayCustomerSearch(ByVal query)
        If (con.State = ConnectionState.Open) Then
            con.Close()
        End If
        con.Open()
        command.Connection = con
        command.CommandText = query
        adapter.SelectCommand = command
        reader = command.ExecuteReader
        Dt = New DataTable
        Dt.Clear()
        Dt.Load(reader)
        reader.Dispose()
        command.Dispose()
        adapter.Dispose()
        DisplayCustomerSearch = Dt
    End Function

    Sub DeleteFromTable(ByVal query)
        Try
            If (con.State = ConnectionState.Open) Then
                con.Close()
            End If
            con.Open()
            command.Connection = con
            command.CommandText = query
            command.ExecuteNonQuery()
            command.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function TextValidation(ByVal re As String, ByVal text As String) As Boolean
        Dim regex As Regex = New Regex(re)
        If regex.IsMatch(text) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function DisplayItemTable(ByVal query)
        If (con.State = ConnectionState.Open) Then
            con.Close()
        End If
        con.Open()
        command.Connection = con
        command.CommandText = query
        adapter.SelectCommand = command
        reader = command.ExecuteReader
        Dt = New DataTable
        Dt.Clear()
        Dt.Load(reader)
        command.Dispose()
        adapter.Dispose()
        reader.Close()
        con.Close()
        DisplayItemTable = Dt
    End Function

    Public Function GetTable(ByVal query)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        command.Connection = con
        command.CommandText = query
        adapter.SelectCommand = command
        reader = command.ExecuteReader
        reader.Read()
        GetTable = reader
        command.Dispose()
        adapter.Dispose()
    End Function

End Module

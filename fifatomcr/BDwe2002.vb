Imports System.Data.OleDb
Public Class BDwe2002
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BD.accdb")
    Private Sub bind_data()
        Dim cm1 As New OleDbCommand("select * from we2002", conn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cm1
        Dim table1 As New DataTable
        table1.Clear()
        da.Fill(table1)
        DataGridView1.DataSource = table1

    End Sub

    Private Sub BDwe2002_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind_data()
    End Sub

    Private Sub txtbusquedaclub_TextChanged(sender As Object, e As EventArgs) Handles txtbusquedaclub.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cm1 As New OleDbCommand("select * from we2002 where wename like '" & txtbusquedaclub.Text & "'", conn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cm1
        Dim table1 As New DataTable
        table1.Clear()
        da.Fill(table1)
        DataGridView1.DataSource = table1
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
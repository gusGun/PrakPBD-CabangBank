Imports System.Data.SqlClient

Public Class FrmCabangBank
    Public Conn As New SqlConnection
    Public Cmd As New SqlCommand
    Public DT As New DataTable
    Public DR As SqlDataReader
    Public StrConnect As String

    Public Function Konek(keadaan As String) As SqlConnection
        'Windows Authentication
        'StrConnect = "Data Source=nama-server;Initial Catalog=bank_xxxx;Integrated Security=True"

        'SQL Server Authentication
        StrConnect = "Data Source=rudy;Initial Catalog=bank_xxxx;User ID=sa;Password=rudy"

        Select Case keadaan
            Case "buka"
                If Conn.State = ConnectionState.Open Then
                    Conn.Close()
                    Conn = New SqlConnection(StrConnect)
                    Conn.Open()
                Else
                    Conn = New SqlConnection(StrConnect)
                    Conn.Open()
                End If
            Case "tutup"
                Conn.Close()
        End Select
        Return Conn
    End Function

    Sub RefreshTampilan()
        If Cmd.CommandText <> "" Then
            Cmd = New SqlCommand("", Konek("tutup"))
        End If

        Cmd = New SqlCommand("sp_show_cabang_bank", Konek("buka"))
        Cmd.CommandType = CommandType.StoredProcedure
        DR = Cmd.ExecuteReader

        DT = New DataTable
        DT.Load(DR)
        DataGrid1.DataSource = DT
        Cmd = New SqlCommand("", Konek("tutup"))
    End Sub

    Private Sub FrmCabangBank_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call RefreshTampilan()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Cmd = New SqlCommand("sp_Inst_CbgBank", Konek("buka"))
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.Parameters.AddWithValue("@KdCbg", "BRUG")
        Cmd.Parameters.AddWithValue("@NmCbg", "Bank Rut Unit Godean")
        Cmd.Parameters.AddWithValue("@AlmtCbg", "Jl. Godean 30")
        Cmd.ExecuteNonQuery()

        Call RefreshTampilan()
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        Cmd = New SqlCommand("sp_show_cabang_bank_kdcbg", Konek("buka"))
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.Parameters.AddWithValue("@kdcbg", "BRUS")
        DR = Cmd.ExecuteReader

        If Not DR.HasRows Then
            MsgBox("Data Tidak Ada", vbInformation + vbOKOnly, "Informasi")
        Else
            MsgBox("Data Ada", vbInformation + vbOKOnly, "Informasi")
        End If

        Cmd = New SqlCommand("", Konek("tutup"))
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Cmd = New SqlCommand("sp_Updt_Cbg", Konek("buka"))
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.Parameters.AddWithValue("@KdCbg", "BRUG")
        Cmd.Parameters.AddWithValue("@NmCbg", "Bank Rut Unit Godean 2")
        Cmd.Parameters.AddWithValue("@AlmtCbg", "Jl. Godean 30")
        Cmd.ExecuteNonQuery()

        Call RefreshTampilan()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Cmd = New SqlCommand("sp_Del_Cbg", Konek("buka"))
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.Parameters.AddWithValue("@KdCbg", "BRUG")
        Cmd.ExecuteNonQuery()

        Call RefreshTampilan()
    End Sub
End Class
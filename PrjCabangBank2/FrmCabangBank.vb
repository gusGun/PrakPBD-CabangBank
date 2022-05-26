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

    Sub RefreshText()
        TxtKodeCbg.Text = ""
        TxtNamaCbg.Text = ""
        TxtAlamatCbg.Text = ""
        TxtKodeCbg.Focus()
    End Sub

    Private Sub FrmCabangBank_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call RefreshTampilan()
        Me.MdiParent = FrmUtama
    End Sub

    Private Sub TxtKodeCbg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKodeCbg.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Cmd = New SqlCommand("sp_show_cabang_bank_kdcbg", Konek("buka"))
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@kdcbg", TxtKodeCbg.Text)
            DR = Cmd.ExecuteReader

            If Not DR.HasRows Then
                MsgBox("Data Tidak Ada")
            Else
                While DR.Read
                    TxtKodeCbg.Text = DR.GetValue(DR.GetOrdinal("kode_cabang"))
                    TxtNamaCbg.Text = DR.GetValue(DR.GetOrdinal("nama_cabang"))
                    TxtAlamatCbg.Text = DR.GetValue(DR.GetOrdinal("alamat_cabang"))
                End While
            End If

            Cmd = New SqlCommand("", Konek("tutup"))
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        On Error GoTo ErrorHand

        Cmd = New SqlCommand("sp_Inst_CbgBank", Konek("buka"))
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.Parameters.AddWithValue("@KdCbg", TxtKodeCbg.Text)
        Cmd.Parameters.AddWithValue("@NmCbg", TxtNamaCbg.Text)
        Cmd.Parameters.AddWithValue("@AlmtCbg", TxtAlamatCbg.Text)
        Cmd.ExecuteNonQuery()

ErrorHand:
        If Err.Number <> 0 Then
            MsgBox("Ada Kesalahan : " + CStr(Err.Number & vbCrLf & Err.Description), vbCritical + vbOKOnly, "Informasi")
        End If
        Call RefreshTampilan()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        On Error GoTo Errorhand

        Cmd = New SqlCommand("sp_Updt_Cbg", Konek("buka"))
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.Parameters.AddWithValue("@KdCbg", TxtKodeCbg.Text)
        Cmd.Parameters.AddWithValue("@NmCbg", TxtNamaCbg.Text)
        Cmd.Parameters.AddWithValue("@AlmtCbg", TxtAlamatCbg.Text)
        Cmd.ExecuteNonQuery()

Errorhand:
        If Err.Number <> 0 Then
            MsgBox("Ada Kesalahan : " + CStr(Err.Number & vbCrLf & Err.Description), vbCritical + vbOKOnly, "Informasi")
        End If
        Call RefreshTampilan()
        Call RefreshText()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        On Error GoTo ErrorHand

        Cmd = New SqlCommand("sp_Del_Cbg", Konek("buka"))
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.Parameters.AddWithValue("@KdCbg", TxtKodeCbg.Text)
        Cmd.ExecuteNonQuery()

ErrorHand:
        If Err.Number <> 0 Then
            MsgBox("Ada Kesalahan : " + CStr(Err.Number & vbCrLf & Err.Description), vbCritical + vbOKOnly, "Informasi")
        End If
        Call RefreshTampilan()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dispose()
    End Sub
End Class
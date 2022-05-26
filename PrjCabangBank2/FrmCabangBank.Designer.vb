<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCabangBank
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
        Me.TxtKodeCbg = New System.Windows.Forms.TextBox()
        Me.TxtNamaCbg = New System.Windows.Forms.TextBox()
        Me.TxtAlamatCbg = New System.Windows.Forms.TextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGrid1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtKodeCbg
        '
        Me.TxtKodeCbg.Location = New System.Drawing.Point(97, 28)
        Me.TxtKodeCbg.Name = "TxtKodeCbg"
        Me.TxtKodeCbg.Size = New System.Drawing.Size(100, 20)
        Me.TxtKodeCbg.TabIndex = 0
        '
        'TxtNamaCbg
        '
        Me.TxtNamaCbg.Location = New System.Drawing.Point(97, 70)
        Me.TxtNamaCbg.Name = "TxtNamaCbg"
        Me.TxtNamaCbg.Size = New System.Drawing.Size(200, 20)
        Me.TxtNamaCbg.TabIndex = 1
        '
        'TxtAlamatCbg
        '
        Me.TxtAlamatCbg.Location = New System.Drawing.Point(97, 112)
        Me.TxtAlamatCbg.Name = "TxtAlamatCbg"
        Me.TxtAlamatCbg.Size = New System.Drawing.Size(200, 20)
        Me.TxtAlamatCbg.TabIndex = 2
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(42, 145)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 30)
        Me.BtnSimpan.TabIndex = 3
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(149, 145)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 30)
        Me.BtnUpdate.TabIndex = 4
        Me.BtnUpdate.Text = "&Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(256, 145)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 30)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(363, 145)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(75, 30)
        Me.BtnKeluar.TabIndex = 6
        Me.BtnKeluar.Text = "&Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Kode Cabang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama Cabang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Alamat Cabang"
        '
        'DataGrid1
        '
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid1.Location = New System.Drawing.Point(12, 188)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(456, 280)
        Me.DataGrid1.TabIndex = 7
        '
        'FrmCabangBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 480)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.TxtAlamatCbg)
        Me.Controls.Add(Me.TxtNamaCbg)
        Me.Controls.Add(Me.TxtKodeCbg)
        Me.Name = "FrmCabangBank"
        Me.Text = "Data Cabang Bank"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtKodeCbg As TextBox
    Friend WithEvents TxtNamaCbg As TextBox
    Friend WithEvents TxtAlamatCbg As TextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGrid1 As DataGridView
End Class

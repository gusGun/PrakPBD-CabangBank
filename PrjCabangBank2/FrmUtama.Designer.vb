<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MnFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnInputBank = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnFile, Me.MnExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MnFile
        '
        Me.MnFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnInputBank})
        Me.MnFile.Name = "MnFile"
        Me.MnFile.Size = New System.Drawing.Size(37, 20)
        Me.MnFile.Text = "&File"
        '
        'MnInputBank
        '
        Me.MnInputBank.Name = "MnInputBank"
        Me.MnInputBank.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.MnInputBank.Size = New System.Drawing.Size(239, 22)
        Me.MnInputBank.Text = "&Input Data Cabang Bank"
        '
        'MnExit
        '
        Me.MnExit.Name = "MnExit"
        Me.MnExit.Size = New System.Drawing.Size(38, 20)
        Me.MnExit.Text = "E&xit"
        '
        'FrmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmUtama"
        Me.Text = "PROGRAM BANK"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MnFile As ToolStripMenuItem
    Friend WithEvents MnInputBank As ToolStripMenuItem
    Friend WithEvents MnExit As ToolStripMenuItem
End Class

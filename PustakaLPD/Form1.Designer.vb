<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.tSinopsis = New System.Windows.Forms.TextBox()
        Me.tStok = New System.Windows.Forms.TextBox()
        Me.cbPenerbit = New System.Windows.Forms.ComboBox()
        Me.cbPengarang = New System.Windows.Forms.ComboBox()
        Me.tJudul = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LVbuku = New System.Windows.Forms.ListView()
        Me.CMbuku = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtUpdate = New System.Windows.Forms.Button()
        Me.TBid = New System.Windows.Forms.TextBox()
        Me.CMbuku.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(85, 236)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 21
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'tSinopsis
        '
        Me.tSinopsis.Location = New System.Drawing.Point(85, 141)
        Me.tSinopsis.Multiline = True
        Me.tSinopsis.Name = "tSinopsis"
        Me.tSinopsis.Size = New System.Drawing.Size(463, 79)
        Me.tSinopsis.TabIndex = 20
        '
        'tStok
        '
        Me.tStok.Location = New System.Drawing.Point(85, 105)
        Me.tStok.Name = "tStok"
        Me.tStok.Size = New System.Drawing.Size(100, 20)
        Me.tStok.TabIndex = 19
        '
        'cbPenerbit
        '
        Me.cbPenerbit.FormattingEnabled = True
        Me.cbPenerbit.Location = New System.Drawing.Point(85, 74)
        Me.cbPenerbit.Name = "cbPenerbit"
        Me.cbPenerbit.Size = New System.Drawing.Size(178, 21)
        Me.cbPenerbit.TabIndex = 18
        '
        'cbPengarang
        '
        Me.cbPengarang.FormattingEnabled = True
        Me.cbPengarang.Location = New System.Drawing.Point(85, 43)
        Me.cbPengarang.Name = "cbPengarang"
        Me.cbPengarang.Size = New System.Drawing.Size(178, 21)
        Me.cbPengarang.TabIndex = 17
        '
        'tJudul
        '
        Me.tJudul.Location = New System.Drawing.Point(85, 15)
        Me.tJudul.Name = "tJudul"
        Me.tJudul.Size = New System.Drawing.Size(327, 20)
        Me.tJudul.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Stok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Sinopsis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Penerbit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Pengarang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Judul Buku"
        '
        'LVbuku
        '
        Me.LVbuku.ContextMenuStrip = Me.CMbuku
        Me.LVbuku.Location = New System.Drawing.Point(12, 291)
        Me.LVbuku.Name = "LVbuku"
        Me.LVbuku.Size = New System.Drawing.Size(586, 183)
        Me.LVbuku.TabIndex = 22
        Me.LVbuku.UseCompatibleStateImageBehavior = False
        '
        'CMbuku
        '
        Me.CMbuku.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.CMbuku.Name = "CMbuku"
        Me.CMbuku.Size = New System.Drawing.Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'BtUpdate
        '
        Me.BtUpdate.Location = New System.Drawing.Point(166, 236)
        Me.BtUpdate.Name = "BtUpdate"
        Me.BtUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtUpdate.TabIndex = 23
        Me.BtUpdate.Text = "Update"
        Me.BtUpdate.UseVisualStyleBackColor = True
        '
        'TBid
        '
        Me.TBid.Location = New System.Drawing.Point(448, 15)
        Me.TBid.Name = "TBid"
        Me.TBid.Size = New System.Drawing.Size(100, 20)
        Me.TBid.TabIndex = 24
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 486)
        Me.Controls.Add(Me.TBid)
        Me.Controls.Add(Me.BtUpdate)
        Me.Controls.Add(Me.LVbuku)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.tSinopsis)
        Me.Controls.Add(Me.tStok)
        Me.Controls.Add(Me.cbPenerbit)
        Me.Controls.Add(Me.cbPengarang)
        Me.Controls.Add(Me.tJudul)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form Buku"
        Me.CMbuku.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents tSinopsis As System.Windows.Forms.TextBox
    Friend WithEvents tStok As System.Windows.Forms.TextBox
    Friend WithEvents cbPenerbit As System.Windows.Forms.ComboBox
    Friend WithEvents cbPengarang As System.Windows.Forms.ComboBox
    Friend WithEvents tJudul As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LVbuku As System.Windows.Forms.ListView
    Friend WithEvents CMbuku As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtUpdate As System.Windows.Forms.Button
    Friend WithEvents TBid As System.Windows.Forms.TextBox

End Class

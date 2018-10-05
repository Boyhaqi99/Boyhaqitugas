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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBP = New System.Windows.Forms.TextBox()
        Me.CBB = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBJP = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.TBKP = New System.Windows.Forms.TextBox()
        Me.LVPengajuan = New System.Windows.Forms.ListView()
        Me.BTAdd = New System.Windows.Forms.Button()
        Me.BTUpdate = New System.Windows.Forms.Button()
        Me.TBbentuk = New System.Windows.Forms.TextBox()
        Me.TBid = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Pelaksana"
        '
        'TBP
        '
        Me.TBP.Location = New System.Drawing.Point(128, 23)
        Me.TBP.Name = "TBP"
        Me.TBP.Size = New System.Drawing.Size(157, 20)
        Me.TBP.TabIndex = 1
        '
        'CBB
        '
        Me.CBB.FormattingEnabled = True
        Me.CBB.Items.AddRange(New Object() {"Akademik", "Keuangan", "Marketing"})
        Me.CBB.Location = New System.Drawing.Point(128, 49)
        Me.CBB.Name = "CBB"
        Me.CBB.Size = New System.Drawing.Size(157, 21)
        Me.CBB.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bidang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jumlah Permintaan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Bentuk Dana"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Keperluan"
        '
        'TBJP
        '
        Me.TBJP.Location = New System.Drawing.Point(128, 76)
        Me.TBJP.Name = "TBJP"
        Me.TBJP.Size = New System.Drawing.Size(157, 20)
        Me.TBJP.TabIndex = 7
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(128, 114)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Tunai"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(128, 137)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(72, 17)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Cek Bank"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(128, 160)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(44, 17)
        Me.RadioButton3.TabIndex = 10
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Giro"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'TBKP
        '
        Me.TBKP.Location = New System.Drawing.Point(128, 186)
        Me.TBKP.Multiline = True
        Me.TBKP.Name = "TBKP"
        Me.TBKP.Size = New System.Drawing.Size(157, 56)
        Me.TBKP.TabIndex = 11
        '
        'LVPengajuan
        '
        Me.LVPengajuan.Location = New System.Drawing.Point(317, 23)
        Me.LVPengajuan.Name = "LVPengajuan"
        Me.LVPengajuan.Size = New System.Drawing.Size(331, 219)
        Me.LVPengajuan.TabIndex = 12
        Me.LVPengajuan.UseCompatibleStateImageBehavior = False
        '
        'BTAdd
        '
        Me.BTAdd.Location = New System.Drawing.Point(128, 270)
        Me.BTAdd.Name = "BTAdd"
        Me.BTAdd.Size = New System.Drawing.Size(75, 23)
        Me.BTAdd.TabIndex = 13
        Me.BTAdd.Text = "Add"
        Me.BTAdd.UseVisualStyleBackColor = True
        '
        'BTUpdate
        '
        Me.BTUpdate.Location = New System.Drawing.Point(210, 270)
        Me.BTUpdate.Name = "BTUpdate"
        Me.BTUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BTUpdate.TabIndex = 14
        Me.BTUpdate.Text = "Update"
        Me.BTUpdate.UseVisualStyleBackColor = True
        '
        'TBbentuk
        '
        Me.TBbentuk.Location = New System.Drawing.Point(16, 221)
        Me.TBbentuk.Name = "TBbentuk"
        Me.TBbentuk.Size = New System.Drawing.Size(100, 20)
        Me.TBbentuk.TabIndex = 15
        '
        'TBid
        '
        Me.TBid.Location = New System.Drawing.Point(13, 248)
        Me.TBid.Name = "TBid"
        Me.TBid.Size = New System.Drawing.Size(100, 20)
        Me.TBid.TabIndex = 16
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 70)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 435)
        Me.Controls.Add(Me.TBid)
        Me.Controls.Add(Me.TBbentuk)
        Me.Controls.Add(Me.BTUpdate)
        Me.Controls.Add(Me.BTAdd)
        Me.Controls.Add(Me.LVPengajuan)
        Me.Controls.Add(Me.TBKP)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TBJP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBB)
        Me.Controls.Add(Me.TBP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form_Pengajuan_Dana"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBP As System.Windows.Forms.TextBox
    Friend WithEvents CBB As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBJP As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents TBKP As System.Windows.Forms.TextBox
    Friend WithEvents LVPengajuan As System.Windows.Forms.ListView
    Friend WithEvents BTAdd As System.Windows.Forms.Button
    Friend WithEvents BTUpdate As System.Windows.Forms.Button
    Friend WithEvents TBbentuk As System.Windows.Forms.TextBox
    Friend WithEvents TBid As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

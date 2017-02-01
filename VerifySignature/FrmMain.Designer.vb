<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.LV = New System.Windows.Forms.ListView()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LB = New System.Windows.Forms.ListBox()
        Me.MenuStrip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LV
        '
        Me.LV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV.Location = New System.Drawing.Point(3, 3)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(464, 138)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(470, 24)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LV, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LB, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(470, 289)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'LB
        '
        Me.LB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LB.FormattingEnabled = True
        Me.LB.ItemHeight = 12
        Me.LB.Location = New System.Drawing.Point(3, 147)
        Me.LB.Name = "LB"
        Me.LB.Size = New System.Drawing.Size(464, 139)
        Me.LB.TabIndex = 1
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 313)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FrmMain"
        Me.Text = "Verify Signature"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LV As ListView
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LB As ListBox
End Class

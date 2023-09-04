<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lab_frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.mnuFile = New System.Windows.Forms.MenuStrip()
        Me.tsmFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListDuplicatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAddUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(228, 191)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(796, 75)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Laboratory Asset Management"
        '
        'mnuFile
        '
        Me.mnuFile.BackColor = System.Drawing.Color.Teal
        Me.mnuFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFile, Me.DataManagementToolStripMenuItem, Me.FomsToolStripMenuItem})
        Me.mnuFile.Location = New System.Drawing.Point(0, 0)
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(1548, 24)
        Me.mnuFile.TabIndex = 1
        Me.mnuFile.Text = "MenuStrip1"
        '
        'tsmFile
        '
        Me.tsmFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNew, Me.tsmOpen, Me.tsmExport, Me.tsmExit})
        Me.tsmFile.ForeColor = System.Drawing.Color.White
        Me.tsmFile.Name = "tsmFile"
        Me.tsmFile.Size = New System.Drawing.Size(37, 20)
        Me.tsmFile.Text = "&File"
        '
        'tsmNew
        '
        Me.tsmNew.BackColor = System.Drawing.Color.Teal
        Me.tsmNew.ForeColor = System.Drawing.Color.White
        Me.tsmNew.Image = Global.PNGIMR_IS.My.Resources.Resources.new_btn
        Me.tsmNew.Name = "tsmNew"
        Me.tsmNew.Size = New System.Drawing.Size(108, 22)
        Me.tsmNew.Text = "&New"
        '
        'tsmOpen
        '
        Me.tsmOpen.BackColor = System.Drawing.Color.Teal
        Me.tsmOpen.ForeColor = System.Drawing.Color.White
        Me.tsmOpen.Image = Global.PNGIMR_IS.My.Resources.Resources.Open_file_icon
        Me.tsmOpen.Name = "tsmOpen"
        Me.tsmOpen.Size = New System.Drawing.Size(108, 22)
        Me.tsmOpen.Text = "&Open"
        '
        'tsmExport
        '
        Me.tsmExport.BackColor = System.Drawing.Color.Teal
        Me.tsmExport.ForeColor = System.Drawing.Color.White
        Me.tsmExport.Image = Global.PNGIMR_IS.My.Resources.Resources.export_icon
        Me.tsmExport.Name = "tsmExport"
        Me.tsmExport.Size = New System.Drawing.Size(108, 22)
        Me.tsmExport.Text = "&Export"
        '
        'tsmExit
        '
        Me.tsmExit.BackColor = System.Drawing.Color.Teal
        Me.tsmExit.ForeColor = System.Drawing.Color.White
        Me.tsmExit.Image = Global.PNGIMR_IS.My.Resources.Resources.close_icon
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(108, 22)
        Me.tsmExit.Text = "E&xit"
        '
        'DataManagementToolStripMenuItem
        '
        Me.DataManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListDuplicatesToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.DataManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DataManagementToolStripMenuItem.Name = "DataManagementToolStripMenuItem"
        Me.DataManagementToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.DataManagementToolStripMenuItem.Text = "&Data Management"
        '
        'ListDuplicatesToolStripMenuItem
        '
        Me.ListDuplicatesToolStripMenuItem.Image = Global.PNGIMR_IS.My.Resources.Resources.duplicate
        Me.ListDuplicatesToolStripMenuItem.Name = "ListDuplicatesToolStripMenuItem"
        Me.ListDuplicatesToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ListDuplicatesToolStripMenuItem.Text = "List Duplicates"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'FomsToolStripMenuItem
        '
        Me.FomsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAddUser, Me.tsmInventory})
        Me.FomsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FomsToolStripMenuItem.Name = "FomsToolStripMenuItem"
        Me.FomsToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.FomsToolStripMenuItem.Text = "&Forms"
        '
        'tsmAddUser
        '
        Me.tsmAddUser.Name = "tsmAddUser"
        Me.tsmAddUser.Size = New System.Drawing.Size(180, 22)
        Me.tsmAddUser.Text = "&User"
        '
        'tsmInventory
        '
        Me.tsmInventory.Name = "tsmInventory"
        Me.tsmInventory.Size = New System.Drawing.Size(180, 22)
        Me.tsmInventory.Text = "&Inventory"
        '
        'Lab_frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1548, 823)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuFile
        Me.Name = "Lab_frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.mnuFile.ResumeLayout(False)
        Me.mnuFile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents mnuFile As MenuStrip
    Friend WithEvents tsmFile As ToolStripMenuItem
    Friend WithEvents tsmNew As ToolStripMenuItem
    Friend WithEvents tsmOpen As ToolStripMenuItem
    Friend WithEvents tsmExit As ToolStripMenuItem
    Friend WithEvents tsmExport As ToolStripMenuItem
    Friend WithEvents DataManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListDuplicatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FomsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmAddUser As ToolStripMenuItem
    Friend WithEvents tsmInventory As ToolStripMenuItem
End Class

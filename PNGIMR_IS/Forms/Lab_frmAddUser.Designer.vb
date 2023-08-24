<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lab_frmAddUser
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lab_frmAddUser))
        Me.lblID = New System.Windows.Forms.Label()
        Me.TblDBUserDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblDBUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Users_ds = New PNGIMR_IS.users_ds()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cboAccess = New System.Windows.Forms.ComboBox()
        Me.lblEditedBy = New System.Windows.Forms.Label()
        Me.lblTimeStamp = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.pnlFullName = New System.Windows.Forms.Panel()
        Me.pnlUserName = New System.Windows.Forms.Panel()
        Me.pnlPassword = New System.Windows.Forms.Panel()
        Me.pnlConfirmPassword = New System.Windows.Forms.Panel()
        Me.pnlAccess = New System.Windows.Forms.Panel()
        Me.pnlID = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.lblEncryptedPassword = New System.Windows.Forms.Label()
        Me.TblDBUserTableAdapter = New PNGIMR_IS.users_dsTableAdapters.tblDBUserTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblAccess = New System.Windows.Forms.Label()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUsersTotal = New System.Windows.Forms.Label()
        CType(Me.TblDBUserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDBUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Users_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFullName.SuspendLayout()
        Me.pnlUserName.SuspendLayout()
        Me.pnlPassword.SuspendLayout()
        Me.pnlConfirmPassword.SuspendLayout()
        Me.pnlAccess.SuspendLayout()
        Me.pnlID.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(90, 17)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(24, 13)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "ID:"
        '
        'TblDBUserDataGridView
        '
        Me.TblDBUserDataGridView.AllowUserToAddRows = False
        Me.TblDBUserDataGridView.AllowUserToDeleteRows = False
        Me.TblDBUserDataGridView.AutoGenerateColumns = False
        Me.TblDBUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblDBUserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7})
        Me.TblDBUserDataGridView.DataSource = Me.TblDBUserBindingSource
        Me.TblDBUserDataGridView.Location = New System.Drawing.Point(265, 17)
        Me.TblDBUserDataGridView.Name = "TblDBUserDataGridView"
        Me.TblDBUserDataGridView.ReadOnly = True
        Me.TblDBUserDataGridView.Size = New System.Drawing.Size(539, 154)
        Me.TblDBUserDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "f_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Full Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "u_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "User Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "access"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Access"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "time_stamp"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Time Stamp"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'TblDBUserBindingSource
        '
        Me.TblDBUserBindingSource.DataMember = "tblDBUser"
        Me.TblDBUserBindingSource.DataSource = Me.Users_ds
        '
        'Users_ds
        '
        Me.Users_ds.DataSetName = "users_ds"
        Me.Users_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.White
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDBUserBindingSource, "id", True))
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.White
        Me.txtID.Location = New System.Drawing.Point(6, 3)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(143, 13)
        Me.txtID.TabIndex = 3
        '
        'txtFullName
        '
        Me.txtFullName.BackColor = System.Drawing.Color.White
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFullName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDBUserBindingSource, "f_name", True))
        Me.txtFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.ForeColor = System.Drawing.Color.White
        Me.txtFullName.Location = New System.Drawing.Point(5, 4)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(136, 13)
        Me.txtFullName.TabIndex = 5
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.White
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDBUserBindingSource, "u_name", True))
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.White
        Me.txtUserName.Location = New System.Drawing.Point(5, 4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(136, 13)
        Me.txtUserName.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(5, 6)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(136, 13)
        Me.txtPassword.TabIndex = 9
        '
        'cboAccess
        '
        Me.cboAccess.BackColor = System.Drawing.Color.Olive
        Me.cboAccess.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDBUserBindingSource, "access", True))
        Me.cboAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAccess.ForeColor = System.Drawing.Color.White
        Me.cboAccess.FormattingEnabled = True
        Me.cboAccess.Items.AddRange(New Object() {"Admin", "User"})
        Me.cboAccess.Location = New System.Drawing.Point(1, -1)
        Me.cboAccess.Name = "cboAccess"
        Me.cboAccess.Size = New System.Drawing.Size(144, 21)
        Me.cboAccess.TabIndex = 15
        '
        'lblEditedBy
        '
        Me.lblEditedBy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDBUserBindingSource, "edited_by", True))
        Me.lblEditedBy.Location = New System.Drawing.Point(814, 55)
        Me.lblEditedBy.Name = "lblEditedBy"
        Me.lblEditedBy.Size = New System.Drawing.Size(100, 19)
        Me.lblEditedBy.TabIndex = 16
        Me.lblEditedBy.Text = "EditedBy"
        '
        'lblTimeStamp
        '
        Me.lblTimeStamp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDBUserBindingSource, "time_stamp", True))
        Me.lblTimeStamp.Location = New System.Drawing.Point(814, 81)
        Me.lblTimeStamp.Name = "lblTimeStamp"
        Me.lblTimeStamp.Size = New System.Drawing.Size(100, 23)
        Me.lblTimeStamp.TabIndex = 17
        Me.lblTimeStamp.Text = "TimeStamp"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.White
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.White
        Me.txtConfirmPassword.Location = New System.Drawing.Point(5, 3)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(136, 13)
        Me.txtConfirmPassword.TabIndex = 19
        '
        'pnlFullName
        '
        Me.pnlFullName.BackColor = System.Drawing.Color.White
        Me.pnlFullName.Controls.Add(Me.txtFullName)
        Me.pnlFullName.Location = New System.Drawing.Point(114, 43)
        Me.pnlFullName.Name = "pnlFullName"
        Me.pnlFullName.Size = New System.Drawing.Size(145, 20)
        Me.pnlFullName.TabIndex = 20
        '
        'pnlUserName
        '
        Me.pnlUserName.BackColor = System.Drawing.Color.White
        Me.pnlUserName.Controls.Add(Me.txtUserName)
        Me.pnlUserName.Location = New System.Drawing.Point(114, 69)
        Me.pnlUserName.Name = "pnlUserName"
        Me.pnlUserName.Size = New System.Drawing.Size(145, 20)
        Me.pnlUserName.TabIndex = 21
        '
        'pnlPassword
        '
        Me.pnlPassword.BackColor = System.Drawing.Color.White
        Me.pnlPassword.Controls.Add(Me.txtPassword)
        Me.pnlPassword.Location = New System.Drawing.Point(114, 96)
        Me.pnlPassword.Name = "pnlPassword"
        Me.pnlPassword.Size = New System.Drawing.Size(145, 20)
        Me.pnlPassword.TabIndex = 22
        '
        'pnlConfirmPassword
        '
        Me.pnlConfirmPassword.BackColor = System.Drawing.Color.White
        Me.pnlConfirmPassword.Controls.Add(Me.txtConfirmPassword)
        Me.pnlConfirmPassword.Location = New System.Drawing.Point(114, 122)
        Me.pnlConfirmPassword.Name = "pnlConfirmPassword"
        Me.pnlConfirmPassword.Size = New System.Drawing.Size(145, 20)
        Me.pnlConfirmPassword.TabIndex = 23
        '
        'pnlAccess
        '
        Me.pnlAccess.BackColor = System.Drawing.Color.Olive
        Me.pnlAccess.Controls.Add(Me.cboAccess)
        Me.pnlAccess.Location = New System.Drawing.Point(114, 151)
        Me.pnlAccess.Name = "pnlAccess"
        Me.pnlAccess.Size = New System.Drawing.Size(145, 20)
        Me.pnlAccess.TabIndex = 24
        '
        'pnlID
        '
        Me.pnlID.BackColor = System.Drawing.Color.White
        Me.pnlID.Controls.Add(Me.txtID)
        Me.pnlID.Location = New System.Drawing.Point(114, 17)
        Me.pnlID.Name = "pnlID"
        Me.pnlID.Size = New System.Drawing.Size(145, 20)
        Me.pnlID.TabIndex = 25
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.TblDBUserBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.tsbAdd, Me.ToolStripSeparator1, Me.tsbSave, Me.ToolStripSeparator2, Me.tsbDelete, Me.ToolStripSeparator3, Me.tsbCancel, Me.ToolStripSeparator4, Me.tsbExit})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 186)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(787, 25)
        Me.BindingNavigator1.TabIndex = 26
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAdd
        '
        Me.tsbAdd.Image = CType(resources.GetObject("tsbAdd.Image"), System.Drawing.Image)
        Me.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdd.Name = "tsbAdd"
        Me.tsbAdd.Size = New System.Drawing.Size(49, 22)
        Me.tsbAdd.Text = "&Add"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbSave
        '
        Me.tsbSave.Image = CType(resources.GetObject("tsbSave.Image"), System.Drawing.Image)
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(51, 22)
        Me.tsbSave.Text = "&Save"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbDelete
        '
        Me.tsbDelete.Image = CType(resources.GetObject("tsbDelete.Image"), System.Drawing.Image)
        Me.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDelete.Name = "tsbDelete"
        Me.tsbDelete.Size = New System.Drawing.Size(60, 22)
        Me.tsbDelete.Text = "&Delete"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbCancel
        '
        Me.tsbCancel.Image = CType(resources.GetObject("tsbCancel.Image"), System.Drawing.Image)
        Me.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancel.Name = "tsbCancel"
        Me.tsbCancel.Size = New System.Drawing.Size(63, 22)
        Me.tsbCancel.Text = "&Cancel"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tsbExit
        '
        Me.tsbExit.Image = CType(resources.GetObject("tsbExit.Image"), System.Drawing.Image)
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(46, 22)
        Me.tsbExit.Text = "E&xit"
        '
        'lblEncryptedPassword
        '
        Me.lblEncryptedPassword.AutoSize = True
        Me.lblEncryptedPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDBUserBindingSource, "pw", True))
        Me.lblEncryptedPassword.Location = New System.Drawing.Point(814, 104)
        Me.lblEncryptedPassword.Name = "lblEncryptedPassword"
        Me.lblEncryptedPassword.Size = New System.Drawing.Size(101, 13)
        Me.lblEncryptedPassword.TabIndex = 27
        Me.lblEncryptedPassword.Text = "EncryptedPassword"
        '
        'TblDBUserTableAdapter
        '
        Me.TblDBUserTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.lblPassword)
        Me.pnlMain.Controls.Add(Me.lblAccess)
        Me.pnlMain.Controls.Add(Me.lblConfirmPassword)
        Me.pnlMain.Controls.Add(Me.lblFullName)
        Me.pnlMain.Controls.Add(Me.lblUserName)
        Me.pnlMain.Controls.Add(Me.TblDBUserDataGridView)
        Me.pnlMain.Controls.Add(Me.pnlAccess)
        Me.pnlMain.Controls.Add(Me.pnlID)
        Me.pnlMain.Controls.Add(Me.pnlConfirmPassword)
        Me.pnlMain.Controls.Add(Me.pnlPassword)
        Me.pnlMain.Controls.Add(Me.pnlUserName)
        Me.pnlMain.Controls.Add(Me.lblID)
        Me.pnlMain.Controls.Add(Me.pnlFullName)
        Me.pnlMain.Location = New System.Drawing.Point(4, 5)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(780, 178)
        Me.pnlMain.TabIndex = 28
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(49, 100)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(65, 13)
        Me.lblPassword.TabIndex = 30
        Me.lblPassword.Text = "Password:"
        '
        'lblAccess
        '
        Me.lblAccess.AutoSize = True
        Me.lblAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccess.Location = New System.Drawing.Point(62, 154)
        Me.lblAccess.Name = "lblAccess"
        Me.lblAccess.Size = New System.Drawing.Size(52, 13)
        Me.lblAccess.TabIndex = 33
        Me.lblAccess.Text = "Access:"
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.Location = New System.Drawing.Point(3, 125)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(111, 13)
        Me.lblConfirmPassword.TabIndex = 31
        Me.lblConfirmPassword.Text = "Confirm Password:"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(47, 47)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(67, 13)
        Me.lblFullName.TabIndex = 30
        Me.lblFullName.Text = "Full Name:"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(41, 76)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(73, 13)
        Me.lblUserName.TabIndex = 30
        Me.lblUserName.Text = "User Name:"
        '
        'lblUsersTotal
        '
        Me.lblUsersTotal.AutoSize = True
        Me.lblUsersTotal.Location = New System.Drawing.Point(814, 124)
        Me.lblUsersTotal.Name = "lblUsersTotal"
        Me.lblUsersTotal.Size = New System.Drawing.Size(58, 13)
        Me.lblUsersTotal.TabIndex = 29
        Me.lblUsersTotal.Text = "UsersTotal"
        '
        'Lab_frmAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(787, 211)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblUsersTotal)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.lblEncryptedPassword)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.lblTimeStamp)
        Me.Controls.Add(Me.lblEditedBy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lab_frmAddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User"
        CType(Me.TblDBUserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDBUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Users_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFullName.ResumeLayout(False)
        Me.pnlFullName.PerformLayout()
        Me.pnlUserName.ResumeLayout(False)
        Me.pnlUserName.PerformLayout()
        Me.pnlPassword.ResumeLayout(False)
        Me.pnlPassword.PerformLayout()
        Me.pnlConfirmPassword.ResumeLayout(False)
        Me.pnlConfirmPassword.PerformLayout()
        Me.pnlAccess.ResumeLayout(False)
        Me.pnlID.ResumeLayout(False)
        Me.pnlID.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Users_ds As users_ds
    Friend WithEvents TblDBUserBindingSource As BindingSource
    Friend WithEvents TblDBUserTableAdapter As users_dsTableAdapters.tblDBUserTableAdapter
    Friend WithEvents TblDBUserDataGridView As DataGridView
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cboAccess As ComboBox
    Friend WithEvents lblEditedBy As Label
    Friend WithEvents lblTimeStamp As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents pnlFullName As Panel
    Friend WithEvents pnlUserName As Panel
    Friend WithEvents pnlPassword As Panel
    Friend WithEvents pnlConfirmPassword As Panel
    Friend WithEvents pnlAccess As Panel
    Friend WithEvents pnlID As Panel
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents tsbAdd As ToolStripButton
    Friend WithEvents tsbSave As ToolStripButton
    Friend WithEvents tsbDelete As ToolStripButton
    Friend WithEvents tsbCancel As ToolStripButton
    Friend WithEvents lblEncryptedPassword As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblUsersTotal As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblAccess As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents tsbExit As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents lblID As Label
End Class

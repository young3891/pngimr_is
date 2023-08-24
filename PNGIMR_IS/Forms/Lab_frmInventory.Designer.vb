<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lab_frmInventory
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
        Dim lblId As System.Windows.Forms.Label
        Dim lblAssetName As System.Windows.Forms.Label
        Dim lblBrand As System.Windows.Forms.Label
        Dim lblDescription As System.Windows.Forms.Label
        Dim lblCategory As System.Windows.Forms.Label
        Dim lblAssetNumber As System.Windows.Forms.Label
        Dim lblModelNumber As System.Windows.Forms.Label
        Dim lblSerialNumber As System.Windows.Forms.Label
        Dim lblCondition As System.Windows.Forms.Label
        Dim lblReason As System.Windows.Forms.Label
        Dim lblServiceDate As System.Windows.Forms.Label
        Dim lblServiceDue As System.Windows.Forms.Label
        Dim lblSite As System.Windows.Forms.Label
        Dim lblDepartmentUnit As System.Windows.Forms.Label
        Dim lblRoomName As System.Windows.Forms.Label
        Dim lblRoomNum As System.Windows.Forms.Label
        Dim lblDateOfVerification As System.Windows.Forms.Label
        Dim lblDate As System.Windows.Forms.Label
        Dim lblSupplier As System.Windows.Forms.Label
        Dim lblWarrantyExpiration As System.Windows.Forms.Label
        Dim lblPrice As System.Windows.Forms.Label
        Dim lblDecontaminated As System.Windows.Forms.Label
        Dim lblDispose As System.Windows.Forms.Label
        Dim lblSold As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lab_frmInventory))
        Me.lblConfirmity = New System.Windows.Forms.Label()
        Me.InventoryList_ds = New inventoryList_ds()
        Me.TblInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblInventoryTableAdapter = New inventoryList_dsTableAdapters.tblInventoryTableAdapter()
        Me.TableAdapterManager = New inventoryList_dsTableAdapters.TableAdapterManager()
        Me.TblInventoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblInventoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtAssetName = New System.Windows.Forms.TextBox()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtAssetNo = New System.Windows.Forms.TextBox()
        Me.txtModelNo = New System.Windows.Forms.TextBox()
        Me.txtSerialNo = New System.Windows.Forms.TextBox()
        Me.txtCondition = New System.Windows.Forms.TextBox()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.dtpServiceDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpServiceDue = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateofPhysicalVerification = New System.Windows.Forms.DateTimePicker()
        Me.txtConfirmity = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpWarrantyExpiration = New System.Windows.Forms.DateTimePicker()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.dtpDecontaminated = New System.Windows.Forms.DateTimePicker()
        Me.dtpDispose = New System.Windows.Forms.DateTimePicker()
        Me.dtpSold = New System.Windows.Forms.DateTimePicker()
        Me.pnlInventoryDetails = New System.Windows.Forms.Panel()
        Me.btnAddSupplier = New System.Windows.Forms.Button()
        Me.btnAddRoomNo = New System.Windows.Forms.Button()
        Me.btnAddRoomName = New System.Windows.Forms.Button()
        Me.btnAddDept = New System.Windows.Forms.Button()
        Me.btnAddSite = New System.Windows.Forms.Button()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.BindingSource_supplier = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboRoomNo = New System.Windows.Forms.ComboBox()
        Me.BindingSource_room_num = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboRoomName = New System.Windows.Forms.ComboBox()
        Me.BindingSource_room_name = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboDepartmentUnit = New System.Windows.Forms.ComboBox()
        Me.BindingSource_dept = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboSite = New System.Windows.Forms.ComboBox()
        Me.BindingSource_site = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblEditedBy = New System.Windows.Forms.Label()
        Me.lblTimeStamp = New System.Windows.Forms.Label()
        Me.TblComboItemsTableAdapter = New inventoryList_dsTableAdapters.tblComboItemsTableAdapter()
        Me.lblGroupID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        lblId = New System.Windows.Forms.Label()
        lblAssetName = New System.Windows.Forms.Label()
        lblBrand = New System.Windows.Forms.Label()
        lblDescription = New System.Windows.Forms.Label()
        lblCategory = New System.Windows.Forms.Label()
        lblAssetNumber = New System.Windows.Forms.Label()
        lblModelNumber = New System.Windows.Forms.Label()
        lblSerialNumber = New System.Windows.Forms.Label()
        lblCondition = New System.Windows.Forms.Label()
        lblReason = New System.Windows.Forms.Label()
        lblServiceDate = New System.Windows.Forms.Label()
        lblServiceDue = New System.Windows.Forms.Label()
        lblSite = New System.Windows.Forms.Label()
        lblDepartmentUnit = New System.Windows.Forms.Label()
        lblRoomName = New System.Windows.Forms.Label()
        lblRoomNum = New System.Windows.Forms.Label()
        lblDateOfVerification = New System.Windows.Forms.Label()
        lblDate = New System.Windows.Forms.Label()
        lblSupplier = New System.Windows.Forms.Label()
        lblWarrantyExpiration = New System.Windows.Forms.Label()
        lblPrice = New System.Windows.Forms.Label()
        lblDecontaminated = New System.Windows.Forms.Label()
        lblDispose = New System.Windows.Forms.Label()
        lblSold = New System.Windows.Forms.Label()
        CType(Me.InventoryList_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInventoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblInventoryBindingNavigator.SuspendLayout()
        CType(Me.TblInventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInventoryDetails.SuspendLayout()
        CType(Me.BindingSource_supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_room_num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_room_name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_dept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource_site, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblId
        '
        lblId.AutoSize = True
        lblId.ForeColor = System.Drawing.Color.Lime
        lblId.Location = New System.Drawing.Point(119, 15)
        lblId.Name = "lblId"
        lblId.Size = New System.Drawing.Size(21, 13)
        lblId.TabIndex = 2
        lblId.Text = "ID:"
        '
        'lblAssetName
        '
        lblAssetName.AutoSize = True
        lblAssetName.ForeColor = System.Drawing.Color.Lime
        lblAssetName.Location = New System.Drawing.Point(76, 41)
        lblAssetName.Name = "lblAssetName"
        lblAssetName.Size = New System.Drawing.Size(67, 13)
        lblAssetName.TabIndex = 4
        lblAssetName.Text = "Asset Name:"
        '
        'lblBrand
        '
        lblBrand.AutoSize = True
        lblBrand.ForeColor = System.Drawing.Color.Lime
        lblBrand.Location = New System.Drawing.Point(105, 67)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New System.Drawing.Size(38, 13)
        lblBrand.TabIndex = 6
        lblBrand.Text = "Brand:"
        '
        'lblDescription
        '
        lblDescription.AutoSize = True
        lblDescription.ForeColor = System.Drawing.Color.Lime
        lblDescription.Location = New System.Drawing.Point(80, 93)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New System.Drawing.Size(63, 13)
        lblDescription.TabIndex = 8
        lblDescription.Text = "Description:"
        '
        'lblCategory
        '
        lblCategory.AutoSize = True
        lblCategory.ForeColor = System.Drawing.Color.Lime
        lblCategory.Location = New System.Drawing.Point(91, 119)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New System.Drawing.Size(52, 13)
        lblCategory.TabIndex = 10
        lblCategory.Text = "Category:"
        '
        'lblAssetNumber
        '
        lblAssetNumber.AutoSize = True
        lblAssetNumber.ForeColor = System.Drawing.Color.Lime
        lblAssetNumber.Location = New System.Drawing.Point(90, 145)
        lblAssetNumber.Name = "lblAssetNumber"
        lblAssetNumber.Size = New System.Drawing.Size(53, 13)
        lblAssetNumber.TabIndex = 12
        lblAssetNumber.Text = "Asset No:"
        '
        'lblModelNumber
        '
        lblModelNumber.AutoSize = True
        lblModelNumber.ForeColor = System.Drawing.Color.Lime
        lblModelNumber.Location = New System.Drawing.Point(87, 171)
        lblModelNumber.Name = "lblModelNumber"
        lblModelNumber.Size = New System.Drawing.Size(56, 13)
        lblModelNumber.TabIndex = 14
        lblModelNumber.Text = "Model No:"
        '
        'lblSerialNumber
        '
        lblSerialNumber.AutoSize = True
        lblSerialNumber.ForeColor = System.Drawing.Color.Lime
        lblSerialNumber.Location = New System.Drawing.Point(90, 197)
        lblSerialNumber.Name = "lblSerialNumber"
        lblSerialNumber.Size = New System.Drawing.Size(53, 13)
        lblSerialNumber.TabIndex = 16
        lblSerialNumber.Text = "Serial No:"
        '
        'lblCondition
        '
        lblCondition.AutoSize = True
        lblCondition.ForeColor = System.Drawing.Color.Lime
        lblCondition.Location = New System.Drawing.Point(89, 223)
        lblCondition.Name = "lblCondition"
        lblCondition.Size = New System.Drawing.Size(54, 13)
        lblCondition.TabIndex = 18
        lblCondition.Text = "Condition:"
        '
        'lblReason
        '
        lblReason.AutoSize = True
        lblReason.ForeColor = System.Drawing.Color.Lime
        lblReason.Location = New System.Drawing.Point(96, 249)
        lblReason.Name = "lblReason"
        lblReason.Size = New System.Drawing.Size(47, 13)
        lblReason.TabIndex = 20
        lblReason.Text = "Reason:"
        '
        'lblServiceDate
        '
        lblServiceDate.AutoSize = True
        lblServiceDate.ForeColor = System.Drawing.Color.Lime
        lblServiceDate.Location = New System.Drawing.Point(71, 276)
        lblServiceDate.Name = "lblServiceDate"
        lblServiceDate.Size = New System.Drawing.Size(72, 13)
        lblServiceDate.TabIndex = 22
        lblServiceDate.Text = "Service Date:"
        '
        'lblServiceDue
        '
        lblServiceDue.AutoSize = True
        lblServiceDue.ForeColor = System.Drawing.Color.Lime
        lblServiceDue.Location = New System.Drawing.Point(74, 302)
        lblServiceDue.Name = "lblServiceDue"
        lblServiceDue.Size = New System.Drawing.Size(69, 13)
        lblServiceDue.TabIndex = 24
        lblServiceDue.Text = "Service Due:"
        '
        'lblSite
        '
        lblSite.AutoSize = True
        lblSite.ForeColor = System.Drawing.Color.Lime
        lblSite.Location = New System.Drawing.Point(115, 327)
        lblSite.Name = "lblSite"
        lblSite.Size = New System.Drawing.Size(28, 13)
        lblSite.TabIndex = 26
        lblSite.Text = "Site:"
        '
        'lblDepartmentUnit
        '
        lblDepartmentUnit.AutoSize = True
        lblDepartmentUnit.ForeColor = System.Drawing.Color.Lime
        lblDepartmentUnit.Location = New System.Drawing.Point(54, 353)
        lblDepartmentUnit.Name = "lblDepartmentUnit"
        lblDepartmentUnit.Size = New System.Drawing.Size(89, 13)
        lblDepartmentUnit.TabIndex = 28
        lblDepartmentUnit.Text = "Department/Unit:"
        '
        'lblRoomName
        '
        lblRoomName.AutoSize = True
        lblRoomName.ForeColor = System.Drawing.Color.Lime
        lblRoomName.Location = New System.Drawing.Point(74, 379)
        lblRoomName.Name = "lblRoomName"
        lblRoomName.Size = New System.Drawing.Size(69, 13)
        lblRoomName.TabIndex = 30
        lblRoomName.Text = "Room Name:"
        '
        'lblRoomNum
        '
        lblRoomNum.AutoSize = True
        lblRoomNum.ForeColor = System.Drawing.Color.Lime
        lblRoomNum.Location = New System.Drawing.Point(88, 405)
        lblRoomNum.Name = "lblRoomNum"
        lblRoomNum.Size = New System.Drawing.Size(55, 13)
        lblRoomNum.TabIndex = 32
        lblRoomNum.Text = "Room No:"
        '
        'lblDateOfVerification
        '
        lblDateOfVerification.AutoSize = True
        lblDateOfVerification.ForeColor = System.Drawing.Color.Lime
        lblDateOfVerification.Location = New System.Drawing.Point(1, 432)
        lblDateOfVerification.Name = "lblDateOfVerification"
        lblDateOfVerification.Size = New System.Drawing.Size(142, 13)
        lblDateOfVerification.TabIndex = 34
        lblDateOfVerification.Text = "Date of Physical Verification:"
        '
        'lblDate
        '
        lblDate.AutoSize = True
        lblDate.ForeColor = System.Drawing.Color.Lime
        lblDate.Location = New System.Drawing.Point(110, 484)
        lblDate.Name = "lblDate"
        lblDate.Size = New System.Drawing.Size(33, 13)
        lblDate.TabIndex = 38
        lblDate.Text = "Date:"
        '
        'lblSupplier
        '
        lblSupplier.AutoSize = True
        lblSupplier.ForeColor = System.Drawing.Color.Lime
        lblSupplier.Location = New System.Drawing.Point(95, 509)
        lblSupplier.Name = "lblSupplier"
        lblSupplier.Size = New System.Drawing.Size(48, 13)
        lblSupplier.TabIndex = 40
        lblSupplier.Text = "Supplier:"
        '
        'lblWarrantyExpiration
        '
        lblWarrantyExpiration.AutoSize = True
        lblWarrantyExpiration.ForeColor = System.Drawing.Color.Lime
        lblWarrantyExpiration.Location = New System.Drawing.Point(41, 532)
        lblWarrantyExpiration.Name = "lblWarrantyExpiration"
        lblWarrantyExpiration.Size = New System.Drawing.Size(102, 13)
        lblWarrantyExpiration.TabIndex = 42
        lblWarrantyExpiration.Text = "Warranty Expiration:"
        '
        'lblPrice
        '
        lblPrice.AutoSize = True
        lblPrice.ForeColor = System.Drawing.Color.Lime
        lblPrice.Location = New System.Drawing.Point(109, 557)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New System.Drawing.Size(34, 13)
        lblPrice.TabIndex = 44
        lblPrice.Text = "Price:"
        '
        'lblDecontaminated
        '
        lblDecontaminated.AutoSize = True
        lblDecontaminated.ForeColor = System.Drawing.Color.Lime
        lblDecontaminated.Location = New System.Drawing.Point(55, 584)
        lblDecontaminated.Name = "lblDecontaminated"
        lblDecontaminated.Size = New System.Drawing.Size(88, 13)
        lblDecontaminated.TabIndex = 46
        lblDecontaminated.Text = "Decontaminated:"
        '
        'lblDispose
        '
        lblDispose.AutoSize = True
        lblDispose.ForeColor = System.Drawing.Color.Lime
        lblDispose.Location = New System.Drawing.Point(95, 610)
        lblDispose.Name = "lblDispose"
        lblDispose.Size = New System.Drawing.Size(48, 13)
        lblDispose.TabIndex = 48
        lblDispose.Text = "Dispose:"
        '
        'lblSold
        '
        lblSold.AutoSize = True
        lblSold.ForeColor = System.Drawing.Color.Lime
        lblSold.Location = New System.Drawing.Point(112, 636)
        lblSold.Name = "lblSold"
        lblSold.Size = New System.Drawing.Size(31, 13)
        lblSold.TabIndex = 50
        lblSold.Text = "Sold:"
        '
        'lblConfirmity
        '
        Me.lblConfirmity.AutoSize = True
        Me.lblConfirmity.ForeColor = System.Drawing.Color.Lime
        Me.lblConfirmity.Location = New System.Drawing.Point(87, 458)
        Me.lblConfirmity.Name = "lblConfirmity"
        Me.lblConfirmity.Size = New System.Drawing.Size(55, 13)
        Me.lblConfirmity.TabIndex = 36
        Me.lblConfirmity.Text = "Confirmity:"
        '
        'InventoryList_ds
        '
        Me.InventoryList_ds.DataSetName = "inventoryList_ds"
        Me.InventoryList_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblInventoryBindingSource
        '
        Me.TblInventoryBindingSource.DataMember = "tblInventory"
        Me.TblInventoryBindingSource.DataSource = Me.InventoryList_ds
        '
        'TblInventoryTableAdapter
        '
        Me.TblInventoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblComboItemsTableAdapter = Nothing
        Me.TableAdapterManager.tblInventoryTableAdapter = Me.TblInventoryTableAdapter
        Me.TableAdapterManager.UpdateOrder = inventoryList_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblInventoryBindingNavigator
        '
        Me.TblInventoryBindingNavigator.AddNewItem = Nothing
        Me.TblInventoryBindingNavigator.BindingSource = Me.TblInventoryBindingSource
        Me.TblInventoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblInventoryBindingNavigator.DeleteItem = Nothing
        Me.TblInventoryBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TblInventoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.tsbAdd, Me.tsbSave, Me.ToolStripSeparator1, Me.tsbCancel, Me.ToolStripSeparator2, Me.tsbDelete, Me.ToolStripSeparator3, Me.tsbExit, Me.ToolStripSeparator4})
        Me.TblInventoryBindingNavigator.Location = New System.Drawing.Point(0, 678)
        Me.TblInventoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblInventoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblInventoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblInventoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblInventoryBindingNavigator.Name = "TblInventoryBindingNavigator"
        Me.TblInventoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblInventoryBindingNavigator.Size = New System.Drawing.Size(1497, 25)
        Me.TblInventoryBindingNavigator.TabIndex = 0
        Me.TblInventoryBindingNavigator.Text = "BindingNavigator1"
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
        Me.tsbAdd.Image = Global.PNGIMR_IS.My.Resources.Resources.new_btn
        Me.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdd.Name = "tsbAdd"
        Me.tsbAdd.Size = New System.Drawing.Size(49, 22)
        Me.tsbAdd.Text = "&Add"
        '
        'tsbSave
        '
        Me.tsbSave.Image = Global.PNGIMR_IS.My.Resources.Resources.save_btn
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(51, 22)
        Me.tsbSave.Text = "&Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbCancel
        '
        Me.tsbCancel.Image = Global.PNGIMR_IS.My.Resources.Resources.cancel_btn
        Me.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancel.Name = "tsbCancel"
        Me.tsbCancel.Size = New System.Drawing.Size(63, 22)
        Me.tsbCancel.Text = "&Cancel"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbDelete
        '
        Me.tsbDelete.Image = Global.PNGIMR_IS.My.Resources.Resources.delete_btn
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
        'tsbExit
        '
        Me.tsbExit.Image = Global.PNGIMR_IS.My.Resources.Resources.close_icon
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(46, 22)
        Me.tsbExit.Text = "E&xit"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'TblInventoryDataGridView
        '
        Me.TblInventoryDataGridView.AllowUserToAddRows = False
        Me.TblInventoryDataGridView.AllowUserToDeleteRows = False
        Me.TblInventoryDataGridView.AutoGenerateColumns = False
        Me.TblInventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblInventoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27})
        Me.TblInventoryDataGridView.DataSource = Me.TblInventoryBindingSource
        Me.TblInventoryDataGridView.GridColor = System.Drawing.Color.Olive
        Me.TblInventoryDataGridView.Location = New System.Drawing.Point(381, 18)
        Me.TblInventoryDataGridView.Name = "TblInventoryDataGridView"
        Me.TblInventoryDataGridView.ReadOnly = True
        Me.TblInventoryDataGridView.Size = New System.Drawing.Size(1115, 643)
        Me.TblInventoryDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "asset_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Asset Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "brand"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Brand"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "category"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "asset_num"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Asset No"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "model_num"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Model No"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "serial_num"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Serial No"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "condition"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Condition"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "reason"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Reason"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "service_date"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Service Date"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "service_due"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Service Due"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "site"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Site"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "dept_unit"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Department/ Unit"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "room_name"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Room Name"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "room_num"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Room No"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "dov"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Date of Physical Verification"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "confirmity"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Confirmity"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "supplier"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Supplier"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "warranty"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Warranty Expiration "
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "decontaminated"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Decontaminated"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "dispose"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Dispose"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "sold"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Sold"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "edited_by"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Edited By"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "time_stamp"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Time Stamp"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "id", True))
        Me.txtID.Location = New System.Drawing.Point(147, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(200, 20)
        Me.txtID.TabIndex = 0
        '
        'txtAssetName
        '
        Me.txtAssetName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "asset_name", True))
        Me.txtAssetName.Location = New System.Drawing.Point(147, 38)
        Me.txtAssetName.Name = "txtAssetName"
        Me.txtAssetName.Size = New System.Drawing.Size(200, 20)
        Me.txtAssetName.TabIndex = 1
        '
        'txtBrand
        '
        Me.txtBrand.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "brand", True))
        Me.txtBrand.Location = New System.Drawing.Point(147, 64)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(200, 20)
        Me.txtBrand.TabIndex = 2
        '
        'txtDescription
        '
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "description", True))
        Me.txtDescription.Location = New System.Drawing.Point(147, 90)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(200, 20)
        Me.txtDescription.TabIndex = 3
        '
        'txtCategory
        '
        Me.txtCategory.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "category", True))
        Me.txtCategory.Location = New System.Drawing.Point(147, 116)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(200, 20)
        Me.txtCategory.TabIndex = 4
        '
        'txtAssetNo
        '
        Me.txtAssetNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "asset_num", True))
        Me.txtAssetNo.Location = New System.Drawing.Point(147, 142)
        Me.txtAssetNo.Name = "txtAssetNo"
        Me.txtAssetNo.Size = New System.Drawing.Size(200, 20)
        Me.txtAssetNo.TabIndex = 5
        '
        'txtModelNo
        '
        Me.txtModelNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "model_num", True))
        Me.txtModelNo.Location = New System.Drawing.Point(147, 168)
        Me.txtModelNo.Name = "txtModelNo"
        Me.txtModelNo.Size = New System.Drawing.Size(200, 20)
        Me.txtModelNo.TabIndex = 6
        '
        'txtSerialNo
        '
        Me.txtSerialNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "serial_num", True))
        Me.txtSerialNo.Location = New System.Drawing.Point(147, 194)
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.Size = New System.Drawing.Size(200, 20)
        Me.txtSerialNo.TabIndex = 7
        '
        'txtCondition
        '
        Me.txtCondition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "condition", True))
        Me.txtCondition.Location = New System.Drawing.Point(147, 220)
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.Size = New System.Drawing.Size(200, 20)
        Me.txtCondition.TabIndex = 8
        '
        'txtReason
        '
        Me.txtReason.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "reason", True))
        Me.txtReason.Location = New System.Drawing.Point(147, 246)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(200, 20)
        Me.txtReason.TabIndex = 9
        '
        'dtpServiceDate
        '
        Me.dtpServiceDate.Checked = False
        Me.dtpServiceDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpServiceDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblInventoryBindingSource, "service_date", True))
        Me.dtpServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpServiceDate.Location = New System.Drawing.Point(147, 272)
        Me.dtpServiceDate.Name = "dtpServiceDate"
        Me.dtpServiceDate.ShowCheckBox = True
        Me.dtpServiceDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpServiceDate.TabIndex = 10
        '
        'dtpServiceDue
        '
        Me.dtpServiceDue.Checked = False
        Me.dtpServiceDue.CustomFormat = "dd/MM/yyyy"
        Me.dtpServiceDue.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblInventoryBindingSource, "service_due", True))
        Me.dtpServiceDue.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpServiceDue.Location = New System.Drawing.Point(147, 298)
        Me.dtpServiceDue.Name = "dtpServiceDue"
        Me.dtpServiceDue.ShowCheckBox = True
        Me.dtpServiceDue.Size = New System.Drawing.Size(200, 20)
        Me.dtpServiceDue.TabIndex = 11
        '
        'dtpDateofPhysicalVerification
        '
        Me.dtpDateofPhysicalVerification.Checked = False
        Me.dtpDateofPhysicalVerification.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateofPhysicalVerification.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblInventoryBindingSource, "dov", True))
        Me.dtpDateofPhysicalVerification.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateofPhysicalVerification.Location = New System.Drawing.Point(146, 428)
        Me.dtpDateofPhysicalVerification.Name = "dtpDateofPhysicalVerification"
        Me.dtpDateofPhysicalVerification.ShowCheckBox = True
        Me.dtpDateofPhysicalVerification.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateofPhysicalVerification.TabIndex = 16
        '
        'txtConfirmity
        '
        Me.txtConfirmity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "confirmity", True))
        Me.txtConfirmity.Location = New System.Drawing.Point(146, 454)
        Me.txtConfirmity.Name = "txtConfirmity"
        Me.txtConfirmity.Size = New System.Drawing.Size(200, 20)
        Me.txtConfirmity.TabIndex = 17
        '
        'dtpDate
        '
        Me.dtpDate.Checked = False
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblInventoryBindingSource, "date", True))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(146, 480)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.ShowCheckBox = True
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 18
        '
        'dtpWarrantyExpiration
        '
        Me.dtpWarrantyExpiration.Checked = False
        Me.dtpWarrantyExpiration.CustomFormat = "dd/MM/yyyy"
        Me.dtpWarrantyExpiration.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblInventoryBindingSource, "warranty", True))
        Me.dtpWarrantyExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpWarrantyExpiration.Location = New System.Drawing.Point(146, 532)
        Me.dtpWarrantyExpiration.Name = "dtpWarrantyExpiration"
        Me.dtpWarrantyExpiration.ShowCheckBox = True
        Me.dtpWarrantyExpiration.Size = New System.Drawing.Size(200, 20)
        Me.dtpWarrantyExpiration.TabIndex = 20
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "price", True))
        Me.txtPrice.Location = New System.Drawing.Point(146, 558)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(200, 20)
        Me.txtPrice.TabIndex = 21
        '
        'dtpDecontaminated
        '
        Me.dtpDecontaminated.Checked = False
        Me.dtpDecontaminated.CustomFormat = "dd/MM/yyyy"
        Me.dtpDecontaminated.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblInventoryBindingSource, "decontaminated", True))
        Me.dtpDecontaminated.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDecontaminated.Location = New System.Drawing.Point(146, 584)
        Me.dtpDecontaminated.Name = "dtpDecontaminated"
        Me.dtpDecontaminated.ShowCheckBox = True
        Me.dtpDecontaminated.Size = New System.Drawing.Size(200, 20)
        Me.dtpDecontaminated.TabIndex = 22
        '
        'dtpDispose
        '
        Me.dtpDispose.Checked = False
        Me.dtpDispose.CustomFormat = "dd/MM/yyyy"
        Me.dtpDispose.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblInventoryBindingSource, "dispose", True))
        Me.dtpDispose.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDispose.Location = New System.Drawing.Point(146, 610)
        Me.dtpDispose.Name = "dtpDispose"
        Me.dtpDispose.ShowCheckBox = True
        Me.dtpDispose.Size = New System.Drawing.Size(200, 20)
        Me.dtpDispose.TabIndex = 23
        '
        'dtpSold
        '
        Me.dtpSold.Checked = False
        Me.dtpSold.CustomFormat = "dd/MM/yyyy"
        Me.dtpSold.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblInventoryBindingSource, "sold", True))
        Me.dtpSold.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSold.Location = New System.Drawing.Point(146, 636)
        Me.dtpSold.Name = "dtpSold"
        Me.dtpSold.ShowCheckBox = True
        Me.dtpSold.Size = New System.Drawing.Size(200, 20)
        Me.dtpSold.TabIndex = 24
        '
        'pnlInventoryDetails
        '
        Me.pnlInventoryDetails.Controls.Add(Me.btnAddSupplier)
        Me.pnlInventoryDetails.Controls.Add(Me.btnAddRoomNo)
        Me.pnlInventoryDetails.Controls.Add(Me.btnAddRoomName)
        Me.pnlInventoryDetails.Controls.Add(Me.btnAddDept)
        Me.pnlInventoryDetails.Controls.Add(Me.btnAddSite)
        Me.pnlInventoryDetails.Controls.Add(Me.cboSupplier)
        Me.pnlInventoryDetails.Controls.Add(Me.cboRoomNo)
        Me.pnlInventoryDetails.Controls.Add(Me.cboRoomName)
        Me.pnlInventoryDetails.Controls.Add(Me.cboDepartmentUnit)
        Me.pnlInventoryDetails.Controls.Add(Me.cboSite)
        Me.pnlInventoryDetails.Controls.Add(Me.lblConfirmity)
        Me.pnlInventoryDetails.Controls.Add(Me.txtID)
        Me.pnlInventoryDetails.Controls.Add(lblWarrantyExpiration)
        Me.pnlInventoryDetails.Controls.Add(lblServiceDate)
        Me.pnlInventoryDetails.Controls.Add(Me.dtpWarrantyExpiration)
        Me.pnlInventoryDetails.Controls.Add(lblId)
        Me.pnlInventoryDetails.Controls.Add(lblPrice)
        Me.pnlInventoryDetails.Controls.Add(Me.dtpServiceDate)
        Me.pnlInventoryDetails.Controls.Add(Me.txtPrice)
        Me.pnlInventoryDetails.Controls.Add(Me.txtReason)
        Me.pnlInventoryDetails.Controls.Add(lblDecontaminated)
        Me.pnlInventoryDetails.Controls.Add(lblServiceDue)
        Me.pnlInventoryDetails.Controls.Add(Me.dtpDecontaminated)
        Me.pnlInventoryDetails.Controls.Add(lblReason)
        Me.pnlInventoryDetails.Controls.Add(lblDispose)
        Me.pnlInventoryDetails.Controls.Add(Me.dtpServiceDue)
        Me.pnlInventoryDetails.Controls.Add(Me.dtpDispose)
        Me.pnlInventoryDetails.Controls.Add(lblAssetName)
        Me.pnlInventoryDetails.Controls.Add(lblSold)
        Me.pnlInventoryDetails.Controls.Add(lblSite)
        Me.pnlInventoryDetails.Controls.Add(Me.dtpSold)
        Me.pnlInventoryDetails.Controls.Add(Me.txtCondition)
        Me.pnlInventoryDetails.Controls.Add(Me.txtAssetName)
        Me.pnlInventoryDetails.Controls.Add(lblDepartmentUnit)
        Me.pnlInventoryDetails.Controls.Add(lblCondition)
        Me.pnlInventoryDetails.Controls.Add(lblBrand)
        Me.pnlInventoryDetails.Controls.Add(lblRoomName)
        Me.pnlInventoryDetails.Controls.Add(Me.txtSerialNo)
        Me.pnlInventoryDetails.Controls.Add(Me.txtBrand)
        Me.pnlInventoryDetails.Controls.Add(lblRoomNum)
        Me.pnlInventoryDetails.Controls.Add(lblSerialNumber)
        Me.pnlInventoryDetails.Controls.Add(lblDescription)
        Me.pnlInventoryDetails.Controls.Add(lblDateOfVerification)
        Me.pnlInventoryDetails.Controls.Add(Me.txtModelNo)
        Me.pnlInventoryDetails.Controls.Add(Me.dtpDateofPhysicalVerification)
        Me.pnlInventoryDetails.Controls.Add(Me.txtDescription)
        Me.pnlInventoryDetails.Controls.Add(Me.txtConfirmity)
        Me.pnlInventoryDetails.Controls.Add(lblModelNumber)
        Me.pnlInventoryDetails.Controls.Add(lblDate)
        Me.pnlInventoryDetails.Controls.Add(lblCategory)
        Me.pnlInventoryDetails.Controls.Add(Me.dtpDate)
        Me.pnlInventoryDetails.Controls.Add(Me.txtAssetNo)
        Me.pnlInventoryDetails.Controls.Add(lblSupplier)
        Me.pnlInventoryDetails.Controls.Add(Me.txtCategory)
        Me.pnlInventoryDetails.Controls.Add(lblAssetNumber)
        Me.pnlInventoryDetails.Location = New System.Drawing.Point(6, 5)
        Me.pnlInventoryDetails.Name = "pnlInventoryDetails"
        Me.pnlInventoryDetails.Size = New System.Drawing.Size(374, 665)
        Me.pnlInventoryDetails.TabIndex = 56
        '
        'btnAddSupplier
        '
        Me.btnAddSupplier.BackColor = System.Drawing.Color.Blue
        Me.btnAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddSupplier.Location = New System.Drawing.Point(347, 504)
        Me.btnAddSupplier.Name = "btnAddSupplier"
        Me.btnAddSupplier.Size = New System.Drawing.Size(25, 23)
        Me.btnAddSupplier.TabIndex = 55
        Me.btnAddSupplier.Text = "+"
        Me.btnAddSupplier.UseVisualStyleBackColor = False
        '
        'btnAddRoomNo
        '
        Me.btnAddRoomNo.BackColor = System.Drawing.Color.Blue
        Me.btnAddRoomNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddRoomNo.Location = New System.Drawing.Point(347, 400)
        Me.btnAddRoomNo.Name = "btnAddRoomNo"
        Me.btnAddRoomNo.Size = New System.Drawing.Size(25, 23)
        Me.btnAddRoomNo.TabIndex = 54
        Me.btnAddRoomNo.Text = "+"
        Me.btnAddRoomNo.UseVisualStyleBackColor = False
        '
        'btnAddRoomName
        '
        Me.btnAddRoomName.BackColor = System.Drawing.Color.Blue
        Me.btnAddRoomName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddRoomName.Location = New System.Drawing.Point(347, 374)
        Me.btnAddRoomName.Name = "btnAddRoomName"
        Me.btnAddRoomName.Size = New System.Drawing.Size(25, 23)
        Me.btnAddRoomName.TabIndex = 53
        Me.btnAddRoomName.Text = "+"
        Me.btnAddRoomName.UseVisualStyleBackColor = False
        '
        'btnAddDept
        '
        Me.btnAddDept.BackColor = System.Drawing.Color.Blue
        Me.btnAddDept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddDept.Location = New System.Drawing.Point(347, 348)
        Me.btnAddDept.Name = "btnAddDept"
        Me.btnAddDept.Size = New System.Drawing.Size(25, 23)
        Me.btnAddDept.TabIndex = 52
        Me.btnAddDept.Text = "+"
        Me.btnAddDept.UseVisualStyleBackColor = False
        '
        'btnAddSite
        '
        Me.btnAddSite.BackColor = System.Drawing.Color.Blue
        Me.btnAddSite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddSite.Location = New System.Drawing.Point(347, 322)
        Me.btnAddSite.Name = "btnAddSite"
        Me.btnAddSite.Size = New System.Drawing.Size(25, 23)
        Me.btnAddSite.TabIndex = 51
        Me.btnAddSite.Text = "+"
        Me.btnAddSite.UseVisualStyleBackColor = False
        '
        'cboSupplier
        '
        Me.cboSupplier.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "supplier", True))
        Me.cboSupplier.DataSource = Me.BindingSource_supplier
        Me.cboSupplier.DisplayMember = "items"
        Me.cboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(146, 505)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(200, 21)
        Me.cboSupplier.TabIndex = 19
        Me.cboSupplier.ValueMember = "id"
        '
        'BindingSource_supplier
        '
        Me.BindingSource_supplier.DataMember = "tblComboItems"
        Me.BindingSource_supplier.DataSource = Me.InventoryList_ds
        Me.BindingSource_supplier.Filter = ""
        Me.BindingSource_supplier.Sort = ""
        '
        'cboRoomNo
        '
        Me.cboRoomNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "room_num", True))
        Me.cboRoomNo.DataSource = Me.BindingSource_room_num
        Me.cboRoomNo.DisplayMember = "items"
        Me.cboRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoomNo.FormattingEnabled = True
        Me.cboRoomNo.Location = New System.Drawing.Point(147, 401)
        Me.cboRoomNo.Name = "cboRoomNo"
        Me.cboRoomNo.Size = New System.Drawing.Size(199, 21)
        Me.cboRoomNo.TabIndex = 15
        Me.cboRoomNo.ValueMember = "id"
        '
        'BindingSource_room_num
        '
        Me.BindingSource_room_num.DataMember = "tblComboItems"
        Me.BindingSource_room_num.DataSource = Me.InventoryList_ds
        Me.BindingSource_room_num.Filter = ""
        Me.BindingSource_room_num.Sort = ""
        '
        'cboRoomName
        '
        Me.cboRoomName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "room_name", True))
        Me.cboRoomName.DataSource = Me.BindingSource_room_name
        Me.cboRoomName.DisplayMember = "items"
        Me.cboRoomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoomName.FormattingEnabled = True
        Me.cboRoomName.Location = New System.Drawing.Point(147, 375)
        Me.cboRoomName.Name = "cboRoomName"
        Me.cboRoomName.Size = New System.Drawing.Size(199, 21)
        Me.cboRoomName.TabIndex = 14
        Me.cboRoomName.ValueMember = "id"
        '
        'BindingSource_room_name
        '
        Me.BindingSource_room_name.DataMember = "tblComboItems"
        Me.BindingSource_room_name.DataSource = Me.InventoryList_ds
        Me.BindingSource_room_name.Filter = ""
        Me.BindingSource_room_name.Sort = ""
        '
        'cboDepartmentUnit
        '
        Me.cboDepartmentUnit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "dept_unit", True))
        Me.cboDepartmentUnit.DataSource = Me.BindingSource_dept
        Me.cboDepartmentUnit.DisplayMember = "items"
        Me.cboDepartmentUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartmentUnit.FormattingEnabled = True
        Me.cboDepartmentUnit.Location = New System.Drawing.Point(147, 349)
        Me.cboDepartmentUnit.Name = "cboDepartmentUnit"
        Me.cboDepartmentUnit.Size = New System.Drawing.Size(199, 21)
        Me.cboDepartmentUnit.TabIndex = 13
        Me.cboDepartmentUnit.ValueMember = "id"
        '
        'BindingSource_dept
        '
        Me.BindingSource_dept.DataMember = "tblComboItems"
        Me.BindingSource_dept.DataSource = Me.InventoryList_ds
        Me.BindingSource_dept.Filter = ""
        Me.BindingSource_dept.Sort = ""
        '
        'cboSite
        '
        Me.cboSite.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "site", True))
        Me.cboSite.DataSource = Me.BindingSource_site
        Me.cboSite.DisplayMember = "items"
        Me.cboSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSite.FormattingEnabled = True
        Me.cboSite.Location = New System.Drawing.Point(147, 323)
        Me.cboSite.Name = "cboSite"
        Me.cboSite.Size = New System.Drawing.Size(199, 21)
        Me.cboSite.TabIndex = 12
        Me.cboSite.ValueMember = "id"
        '
        'BindingSource_site
        '
        Me.BindingSource_site.DataMember = "tblComboItems"
        Me.BindingSource_site.DataSource = Me.InventoryList_ds
        Me.BindingSource_site.Filter = ""
        Me.BindingSource_site.Sort = ""
        '
        'Timer1
        '
        '
        'lblEditedBy
        '
        Me.lblEditedBy.AutoSize = True
        Me.lblEditedBy.BackColor = System.Drawing.Color.White
        Me.lblEditedBy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "edited_by", True))
        Me.lblEditedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditedBy.Location = New System.Drawing.Point(1237, 683)
        Me.lblEditedBy.Name = "lblEditedBy"
        Me.lblEditedBy.Size = New System.Drawing.Size(56, 13)
        Me.lblEditedBy.TabIndex = 57
        Me.lblEditedBy.Text = "editedBy"
        '
        'lblTimeStamp
        '
        Me.lblTimeStamp.AutoSize = True
        Me.lblTimeStamp.BackColor = System.Drawing.Color.White
        Me.lblTimeStamp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblInventoryBindingSource, "time_stamp", True))
        Me.lblTimeStamp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeStamp.Location = New System.Drawing.Point(1346, 683)
        Me.lblTimeStamp.Name = "lblTimeStamp"
        Me.lblTimeStamp.Size = New System.Drawing.Size(65, 13)
        Me.lblTimeStamp.TabIndex = 58
        Me.lblTimeStamp.Text = "timeStamp"
        '
        'TblComboItemsTableAdapter
        '
        Me.TblComboItemsTableAdapter.ClearBeforeFill = True
        '
        'lblGroupID
        '
        Me.lblGroupID.AutoSize = True
        Me.lblGroupID.Location = New System.Drawing.Point(1501, 318)
        Me.lblGroupID.Name = "lblGroupID"
        Me.lblGroupID.Size = New System.Drawing.Size(45, 13)
        Me.lblGroupID.TabIndex = 60
        Me.lblGroupID.Text = "groupID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(722, 666)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Label1"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1497, 703)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblGroupID)
        Me.Controls.Add(Me.pnlInventoryDetails)
        Me.Controls.Add(Me.TblInventoryDataGridView)
        Me.Controls.Add(Me.lblEditedBy)
        Me.Controls.Add(Me.lblTimeStamp)
        Me.Controls.Add(Me.TblInventoryBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventory"
        CType(Me.InventoryList_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInventoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblInventoryBindingNavigator.ResumeLayout(False)
        Me.TblInventoryBindingNavigator.PerformLayout()
        CType(Me.TblInventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInventoryDetails.ResumeLayout(False)
        Me.pnlInventoryDetails.PerformLayout()
        CType(Me.BindingSource_supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_room_num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_room_name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_dept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource_site, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InventoryList_ds As inventoryList_ds
    Friend WithEvents TblInventoryBindingSource As BindingSource
    Friend WithEvents TblInventoryTableAdapter As inventoryList_dsTableAdapters.tblInventoryTableAdapter
    Friend WithEvents TableAdapterManager As inventoryList_dsTableAdapters.TableAdapterManager
    Friend WithEvents TblInventoryBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblInventoryDataGridView As DataGridView
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtAssetName As TextBox
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtAssetNo As TextBox
    Friend WithEvents txtModelNo As TextBox
    Friend WithEvents txtSerialNo As TextBox
    Friend WithEvents txtCondition As TextBox
    Friend WithEvents txtReason As TextBox
    Friend WithEvents dtpServiceDate As DateTimePicker
    Friend WithEvents dtpServiceDue As DateTimePicker
    Friend WithEvents dtpDateofPhysicalVerification As DateTimePicker
    Friend WithEvents txtConfirmity As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents dtpWarrantyExpiration As DateTimePicker
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents dtpDecontaminated As DateTimePicker
    Friend WithEvents dtpDispose As DateTimePicker
    Friend WithEvents dtpSold As DateTimePicker
    Friend WithEvents pnlInventoryDetails As Panel
    Friend WithEvents tsbDelete As ToolStripButton
    Friend WithEvents tsbSave As ToolStripButton
    Friend WithEvents tsbCancel As ToolStripButton
    Friend WithEvents tsbExit As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbAdd As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents cboSite As ComboBox
    Friend WithEvents cboRoomNo As ComboBox
    Friend WithEvents cboRoomName As ComboBox
    Friend WithEvents cboDepartmentUnit As ComboBox
    Friend WithEvents cboSupplier As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblEditedBy As Label
    Friend WithEvents lblTimeStamp As Label
    Friend WithEvents lblConfirmity As Label
    Friend WithEvents btnAddSupplier As Button
    Friend WithEvents btnAddRoomNo As Button
    Friend WithEvents btnAddRoomName As Button
    Friend WithEvents btnAddDept As Button
    Friend WithEvents btnAddSite As Button
    Friend WithEvents BindingSource_site As BindingSource
    Friend WithEvents BindingSource_dept As BindingSource
    Friend WithEvents BindingSource_room_num As BindingSource
    Friend WithEvents BindingSource_room_name As BindingSource
    Friend WithEvents BindingSource_supplier As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Public WithEvents TblComboItemsTableAdapter As inventoryList_dsTableAdapters.tblComboItemsTableAdapter
    Friend WithEvents lblGroupID As Label
    Friend WithEvents Label1 As Label
End Class

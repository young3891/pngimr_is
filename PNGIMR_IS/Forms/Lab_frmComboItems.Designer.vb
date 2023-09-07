<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lab_frmComboItems
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
        Me.TblComboItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblComboItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboItems_ds = New PNGIMR_IS.comboItems_ds()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblGroupID = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblNameOfItem = New System.Windows.Forms.Label()
        Me.txtNewItem = New System.Windows.Forms.TextBox()
        Me.TblComboItemsTableAdapter = New PNGIMR_IS.comboItems_dsTableAdapters.tblComboItemsTableAdapter()
        Me.TableAdapterManager = New PNGIMR_IS.comboItems_dsTableAdapters.TableAdapterManager()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.TblComboItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblComboItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboItems_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblComboItemsDataGridView
        '
        Me.TblComboItemsDataGridView.AllowUserToAddRows = False
        Me.TblComboItemsDataGridView.AutoGenerateColumns = False
        Me.TblComboItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblComboItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TblComboItemsDataGridView.DataSource = Me.TblComboItemsBindingSource
        Me.TblComboItemsDataGridView.Location = New System.Drawing.Point(12, 48)
        Me.TblComboItemsDataGridView.Name = "TblComboItemsDataGridView"
        Me.TblComboItemsDataGridView.ReadOnly = True
        Me.TblComboItemsDataGridView.Size = New System.Drawing.Size(339, 220)
        Me.TblComboItemsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.FillWeight = 60.9137!
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "items"
        Me.DataGridViewTextBoxColumn2.FillWeight = 139.0863!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Items"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'TblComboItemsBindingSource
        '
        Me.TblComboItemsBindingSource.DataMember = "tblComboItems"
        Me.TblComboItemsBindingSource.DataSource = Me.ComboItems_ds
        '
        'ComboItems_ds
        '
        Me.ComboItems_ds.DataSetName = "comboItems_ds"
        Me.ComboItems_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(278, 274)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 28)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save && Exit"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblGroupID
        '
        Me.lblGroupID.AutoSize = True
        Me.lblGroupID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblComboItemsBindingSource, "group_id", True))
        Me.lblGroupID.Location = New System.Drawing.Point(366, 28)
        Me.lblGroupID.Name = "lblGroupID"
        Me.lblGroupID.Size = New System.Drawing.Size(45, 13)
        Me.lblGroupID.TabIndex = 3
        Me.lblGroupID.Text = "groupID"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(205, 274)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 28)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblNameOfItem
        '
        Me.lblNameOfItem.AutoSize = True
        Me.lblNameOfItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOfItem.Location = New System.Drawing.Point(12, 25)
        Me.lblNameOfItem.Name = "lblNameOfItem"
        Me.lblNameOfItem.Size = New System.Drawing.Size(71, 13)
        Me.lblNameOfItem.TabIndex = 5
        Me.lblNameOfItem.Text = "Item Name:"
        '
        'txtNewItem
        '
        Me.txtNewItem.Location = New System.Drawing.Point(84, 22)
        Me.txtNewItem.Name = "txtNewItem"
        Me.txtNewItem.Size = New System.Drawing.Size(266, 20)
        Me.txtNewItem.TabIndex = 6
        '
        'TblComboItemsTableAdapter
        '
        Me.TblComboItemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblComboItemsTableAdapter = Me.TblComboItemsTableAdapter
        Me.TableAdapterManager.UpdateOrder = PNGIMR_IS.comboItems_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblComboItemsBindingSource, "id", True))
        Me.lblID.Location = New System.Drawing.Point(367, 48)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "ID"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(132, 274)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 28)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Lab_frmComboItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(481, 306)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtNewItem)
        Me.Controls.Add(Me.lblNameOfItem)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblGroupID)
        Me.Controls.Add(Me.TblComboItemsDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Lab_frmComboItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmComboItems"
        CType(Me.TblComboItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblComboItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboItems_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboItems_ds As comboItems_ds
    Friend WithEvents TblComboItemsBindingSource As BindingSource
    Friend WithEvents TblComboItemsTableAdapter As comboItems_dsTableAdapters.tblComboItemsTableAdapter
    Friend WithEvents TableAdapterManager As comboItems_dsTableAdapters.TableAdapterManager
    Friend WithEvents TblComboItemsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents btnSave As Button
    Friend WithEvents lblGroupID As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblNameOfItem As Label
    Friend WithEvents txtNewItem As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents btnDelete As Button
End Class

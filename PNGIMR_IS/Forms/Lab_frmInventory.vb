Imports PNGIMR_IS.GlobalVariablesClass
Public Class Lab_frmInventory
    Dim un As String
    Dim current_date_time As String
    'Dim selectedDate As DateTime?
    'Dim defaultDate As String
    Private Sub FrmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.TblInventoryTableAdapter.get_Total() = 0 Then
            Me.tsbSave.Enabled = False
            Me.tsbDelete.Enabled = False
            Me.tsbCancel.Enabled = False
            Me.pnlInventoryDetails.Enabled = False
        End If
        'Loads respective items onto the comboboxes
        Me.TblComboItemsTableAdapter.Fill(Me.InventoryList_ds.tblComboItems) 'Do not remove

        'Loads the data to the rest of the controls on the form
        Me.TblInventoryTableAdapter.Fill(Me.InventoryList_ds.tblInventory)

        'Filters combo items to each combobox
        Me.BindingSource_site.Filter = "group_id = 101"
        Me.BindingSource_site.Sort = "items ASC"

        Me.BindingSource_dept.Filter = "group_id = 102"
        Me.BindingSource_dept.Sort = "items ASC"

        Me.BindingSource_room_name.Filter = "group_id = 103"
        Me.BindingSource_room_name.Sort = "items ASC"

        Me.BindingSource_room_num.Filter = "group_id = 104"
        Me.BindingSource_room_num.Sort = "items ASC"

        Me.BindingSource_supplier.Filter = "group_id = 105"
        Me.BindingSource_supplier.Sort = "items ASC"

        Me.BindingSource_asset_name.Filter = "group_id = 106"
        Me.BindingSource_asset_name.Sort = "items ASC"
        'Sets focus to add btn
        Me.tsbAdd.Select()

        'Gets the user name of the person who logged in and stores the value in the label 'lblEditedBy'
        un = GlobalVariablesClass.User_Name
        'Me.lblEditedBy.Text = frmLogin.txtUsername.Text
        'Me.Label1.Text = frmLogin.txtUsername.Text
        'Starts the timer
        Me.Timer1.Start()

        'Sets format of the date columns of the dgv
        'Dim dateColumnIndex As Integer = 0
        Me.TblInventoryDataGridView.Columns(10).DefaultCellStyle.Format = "dd/MM/yyyy"
        Me.TblInventoryDataGridView.Columns(11).DefaultCellStyle.Format = "dd/MM/yyyy"
        Me.TblInventoryDataGridView.Columns(16).DefaultCellStyle.Format = "dd/MM/yyyy"
        Me.TblInventoryDataGridView.Columns(18).DefaultCellStyle.Format = "dd/MM/yyyy"
        Me.TblInventoryDataGridView.Columns(20).DefaultCellStyle.Format = "dd/MM/yyyy"
        Me.TblInventoryDataGridView.Columns(22).DefaultCellStyle.Format = "dd/MM/yyyy"
        Me.TblInventoryDataGridView.Columns(23).DefaultCellStyle.Format = "dd/MM/yyyy"
        Me.TblInventoryDataGridView.Columns(24).DefaultCellStyle.Format = "dd/MM/yyyy"

        'Disables cancel button
        Me.tsbCancel.Enabled = False
    End Sub
    Private Sub TsbExit_Click(sender As Object, e As EventArgs) Handles tsbExit.Click
        Me.Close()
    End Sub

    Private Sub TsbAdd_Click(sender As Object, e As EventArgs) Handles tsbAdd.Click
        Me.pnlInventoryDetails.Enabled = True

        Me.TblInventoryBindingSource.AddNew()



        Me.cboDepartmentUnit.SelectedIndex = -1
        Me.cboRoomName.SelectedIndex = -1
        Me.cboRoomNo.SelectedIndex = -1
        Me.cboSite.SelectedIndex = -1
        Me.cboSupplier.SelectedIndex = -1

        'Gets the user name of the person who logged in and stores the value in the label 'lblEditedBy'
        un = GlobalVariablesClass.User_Name
        Me.lblEditedBy.Text = un

        'Disables add,dgv,cancel and delete btns
        Me.tsbAdd.Enabled = False
        Me.tsbDelete.Enabled = False
        Me.tsbCancel.Enabled = True
        Me.TblInventoryDataGridView.Enabled = False
        Me.tsbSave.Enabled = True

        Me.dtpServiceDue.CustomFormat = " "
        Me.dtpServiceDue.Format = DateTimePickerFormat.Custom

    End Sub
    Private Function ChecksMandatoryFields()
        '->Ensures the mandatory field should have value        
        If Me.CboAssetName.SelectedIndex = -1 Then
            MessageBox.Show("Please select an asset name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.CboAssetName.Select()
            Return False
        ElseIf Me.txtBrand.TextLength = 0 Then
            MessageBox.Show("Please enter a brand name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtBrand.Select()
            Return False
        ElseIf Me.txtDescription.TextLength = 0 Then
            MessageBox.Show("Please specify a description.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtDescription.Select()
            Return False
        ElseIf Me.txtCategory.TextLength = 0 Then
            MessageBox.Show("Please specify category.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtCategory.Select()
            Return False
        ElseIf Me.txtAssetNo.TextLength = 0 Then
            MessageBox.Show("Please enter asset number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtAssetNo.Select()
            Return False
        ElseIf Me.txtModelNo.TextLength = 0 Then
            MessageBox.Show("Please enter model number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtModelNo.Select()
            Return False
        ElseIf Me.txtSerialNo.TextLength = 0 Then
            MessageBox.Show("Please enter serial number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtSerialNo.Select()
            Return False
        ElseIf Me.txtCondition.TextLength = 0 Then
            MessageBox.Show("Please specify condition of the asset.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtCondition.Select()
            Return False
        ElseIf Me.cboSite.SelectedIndex = -1 Then
            MessageBox.Show("Please specify IMR site.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cboSite.Select()
            Return False
        ElseIf Me.cboDepartmentUnit.SelectedIndex = -1 Then
            MessageBox.Show("Please specify department/ unit.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cboDepartmentUnit.Select()
            Return False
        ElseIf Me.cboRoomName.SelectedIndex = -1 Then
            MessageBox.Show("Please specify a room name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cboRoomName.Select()
            Return False
        ElseIf Me.cboRoomNo.SelectedIndex = -1 Then
            MessageBox.Show("Please enter a room number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cboRoomNo.Select()
            Return False
        ElseIf Me.cboSupplier.SelectedIndex = -1 Then
            MessageBox.Show("Please enter a supplier name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cboSupplier.Select()
            Return False
        ElseIf Me.txtPrice.TextLength = 0 Then
            MessageBox.Show("Please enter the price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtPrice.Select()
            Return False
        ElseIf Me.lblEditedBy.Text = "editedBy" Then
            MessageBox.Show("Cannot save! Try filling the other mandatory fields and try saving the record again.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.tsbSave.Select()
            Return False
        End If

        Return True

    End Function
    Private Sub TsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click

        Try
            '->Runs function for mandatory fields
            If Not ChecksMandatoryFields() Then
                Exit Sub
            End If

            'Switches binding sources for the comboboxes
            Me.cboSite.DataBindings.Clear()
            Me.cboSite.DataBindings.Add("Text", Me.TblInventoryBindingSource, "site")

            Me.cboDepartmentUnit.DataBindings.Clear()
            Me.cboDepartmentUnit.DataBindings.Add("Text", Me.TblInventoryBindingSource, "dept_unit")

            Me.cboRoomName.DataBindings.Clear()
            Me.cboRoomName.DataBindings.Add("Text", Me.TblInventoryBindingSource, "room_name")

            Me.cboRoomNo.DataBindings.Clear()
            Me.cboRoomNo.DataBindings.Add("Text", Me.TblInventoryBindingSource, "room_num")

            Me.cboSupplier.DataBindings.Clear()
            Me.cboSupplier.DataBindings.Add("Text", Me.TblInventoryBindingSource, "supplier")

            '->Saves the record
            Dim rv As Integer
            Me.TblInventoryBindingSource.EndEdit()
            rv = Me.TblInventoryTableAdapter.Update(Me.InventoryList_ds.tblInventory)

            If rv > 0 Then
                MessageBox.Show("Record sucessfully saved .", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record not saved.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            'Enables tsbAdd,dgv and delete btns
            Me.tsbAdd.Enabled = True
            Me.tsbDelete.Enabled = True
            Me.TblInventoryDataGridView.Enabled = True
            Me.tsbCancel.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnAddSite_Click(sender As Object, e As EventArgs) Handles btnAddSite.Click

        Me.lblGroupID.Text = 101
        GlobalVariablesClass.groupID = Me.lblGroupID.Text

        Dim comboItemsFrm As New Lab_frmComboItems

        Me.lblGroupID.DataBindings.Clear()
        Me.lblGroupID.DataBindings.Add("Text", Me.BindingSource_site, "group_id")

        comboItemsFrm.Text = "Add Site"
        comboItemsFrm.ShowDialog()

    End Sub
    Private Sub BtnAddDept_Click(sender As Object, e As EventArgs) Handles btnAddDept.Click

        Me.lblGroupID.Text = 102
        GlobalVariablesClass.groupID = Me.lblGroupID.Text

        Dim comboItemsFrm As New Lab_frmComboItems

        Me.lblGroupID.DataBindings.Clear()
        Me.lblGroupID.DataBindings.Add("Text", Me.BindingSource_dept, "group_id")

        comboItemsFrm.Text = "Add Department/ Unit"
        comboItemsFrm.ShowDialog()
    End Sub
    Private Sub BtnAddRoomName_Click(sender As Object, e As EventArgs) Handles btnAddRoomName.Click

        Me.lblGroupID.Text = 103
        GlobalVariablesClass.groupID = Me.lblGroupID.Text

        Dim comboItemsFrm As New Lab_frmComboItems

        Me.lblGroupID.DataBindings.Clear()
        Me.lblGroupID.DataBindings.Add("Text", Me.BindingSource_room_name, "group_id")

        comboItemsFrm.Text = "Add Room Name"
        comboItemsFrm.ShowDialog()
    End Sub
    Private Sub BtnAddRoomNo_Click(sender As Object, e As EventArgs) Handles btnAddRoomNo.Click
        Me.lblGroupID.Text = 104
        GlobalVariablesClass.groupID = Me.lblGroupID.Text

        Dim comboItemsFrm As New Lab_frmComboItems

        Me.lblGroupID.DataBindings.Clear()
        Me.lblGroupID.DataBindings.Add("Text", Me.BindingSource_room_num, "group_id")

        comboItemsFrm.Text = "Add Room No"
        comboItemsFrm.ShowDialog()
    End Sub
    Private Sub BtnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click

        Me.lblGroupID.Text = 105
        GlobalVariablesClass.groupID = Me.lblGroupID.Text

        Dim comboItemsFrm As New Lab_frmComboItems

        Me.lblGroupID.DataBindings.Clear()
        Me.lblGroupID.DataBindings.Add("Text", Me.BindingSource_supplier, "group_id")

        comboItemsFrm.Text = "Add Supplier"
        comboItemsFrm.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim current_date As String = Today.ToString(GlobalVariablesClass.current_date_settings)
        Dim current_time As String = TimeOfDay.ToString("h:mm:s tt")

        current_date_time = current_date + " " + current_time
        Me.lblTimeStamp.Text = current_date_time
    End Sub
    Private Sub TsbDelete_Click(sender As Object, e As EventArgs) Handles tsbDelete.Click
        Me.TblInventoryBindingSource.RemoveCurrent()
        Me.TblInventoryTableAdapter.Update(Me.InventoryList_ds.tblInventory)
        MessageBox.Show("1 record successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub CboSite_Click(sender As Object, e As EventArgs) Handles cboSite.Click
        With cboSite
            .DataSource = Me.TblComboItemsTableAdapter.DataTable_site
            .DisplayMember = "items"
        End With
    End Sub
    Private Sub CboDepartmentUnit_Click(sender As Object, e As EventArgs) Handles cboDepartmentUnit.Click

        With cboDepartmentUnit
            .DataSource = Me.TblComboItemsTableAdapter.DataTable_dept
            .DisplayMember = "items"
        End With
    End Sub
    Private Sub CboRoomName_Click(sender As Object, e As EventArgs) Handles cboRoomName.Click
        With cboRoomName
            .DataSource = Me.TblComboItemsTableAdapter.DataTable_room_name
            .DisplayMember = "items"
        End With
    End Sub
    Private Sub CboRoomNo_Click(sender As Object, e As EventArgs) Handles cboRoomNo.Click
        With cboRoomNo
            .DataSource = Me.TblComboItemsTableAdapter.DataTable_room_no
            .DisplayMember = "items"
        End With
    End Sub
    Private Sub CboSupplier_Click(sender As Object, e As EventArgs) Handles cboSupplier.Click
        With cboSupplier
            .DataSource = Me.TblComboItemsTableAdapter.DataTable_supplier
            .DisplayMember = "items"
        End With
    End Sub

    Private Sub TblInventoryDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles TblInventoryDataGridView.SelectionChanged

        If Me.TblInventoryDataGridView.Rows.Count > 0 Then

            Dim rowIndex As Integer
            Dim serviceDate_cIndex As Integer = 10
            Dim serviceDueDate_cIndex As Integer = 11
            Dim dateOfPhysicalVerification_cIndex As Integer = 16
            Dim date_cIndex As Integer = 18
            Dim warantyExpiration_cIndex As Integer = 20
            Dim decontaminated_cIndex As Integer = 22
            Dim dispose_cIndex As Integer = 23
            Dim sold_cIndex As Integer = 24

            rowIndex = Me.TblInventoryDataGridView.CurrentCell.RowIndex

            If serviceDate_cIndex >= 0 AndAlso serviceDate_cIndex < Me.TblInventoryDataGridView.Columns.Count Then

                Dim serviceDate_cellValue As Object = Me.TblInventoryDataGridView.Rows(rowIndex).Cells(serviceDate_cIndex).Value

                Dim sDate As String = serviceDate_cellValue.ToString

                If sDate = "" Then
                    Me.dtpServiceDate.CustomFormat = " "
                    Me.dtpServiceDate.Format = DateTimePickerFormat.Custom
                    Me.dtpServiceDate.Checked = False
                End If
            End If

            If serviceDueDate_cIndex >= 0 AndAlso serviceDueDate_cIndex < Me.TblInventoryDataGridView.Columns.Count Then

                Dim serviceDueDate_cellValue As Object = Me.TblInventoryDataGridView.Rows(rowIndex).Cells(serviceDueDate_cIndex).Value
                Dim sDueDate As String = serviceDueDate_cellValue.ToString

                If sDueDate = "" Then
                    Me.dtpServiceDue.CustomFormat = " "
                    Me.dtpServiceDue.Format = DateTimePickerFormat.Custom
                    Me.dtpServiceDue.Checked = False
                End If
            End If

            If dateOfPhysicalVerification_cIndex >= 0 AndAlso dateOfPhysicalVerification_cIndex < Me.TblInventoryDataGridView.Columns.Count Then

                Dim dateOfPhysicalVerification_cellValue As Object = Me.TblInventoryDataGridView.Rows(rowIndex).Cells(dateOfPhysicalVerification_cIndex).Value
                Dim dateOfPhysicalVerification As String = dateOfPhysicalVerification_cellValue.ToString

                If dateOfPhysicalVerification = "" Then
                    Me.dtpDateofPhysicalVerification.CustomFormat = " "
                    Me.dtpDateofPhysicalVerification.Format = DateTimePickerFormat.Custom
                    Me.dtpDateofPhysicalVerification.Checked = False
                End If
            End If

            If date_cIndex >= 0 AndAlso date_cIndex < Me.TblInventoryDataGridView.Columns.Count Then

                Dim date_cellValue As Object = Me.TblInventoryDataGridView.Rows(rowIndex).Cells(date_cIndex).Value
                Dim stringDate As String = date_cellValue.ToString

                If stringDate = "" Then
                    Me.dtpDate.CustomFormat = " "
                    Me.dtpDate.Format = DateTimePickerFormat.Custom
                    Me.dtpDate.Checked = False
                End If
            End If

            If warantyExpiration_cIndex >= 0 AndAlso warantyExpiration_cIndex < Me.TblInventoryDataGridView.Columns.Count Then

                Dim warantyExpiration_cellValue As Object = Me.TblInventoryDataGridView.Rows(rowIndex).Cells(warantyExpiration_cIndex).Value
                Dim warantyExpiration As String = warantyExpiration_cellValue.ToString

                If warantyExpiration = "" Then
                    Me.dtpWarrantyExpiration.CustomFormat = " "
                    Me.dtpWarrantyExpiration.Format = DateTimePickerFormat.Custom
                    Me.dtpWarrantyExpiration.Checked = False
                End If
            End If

            If decontaminated_cIndex >= 0 AndAlso decontaminated_cIndex < Me.TblInventoryDataGridView.Columns.Count Then

                Dim decontaminated_cellValue As Object = Me.TblInventoryDataGridView.Rows(rowIndex).Cells(decontaminated_cIndex).Value
                Dim decontaminated As String = decontaminated_cellValue.ToString

                If decontaminated = "" Then
                    Me.dtpDecontaminated.CustomFormat = " "
                    Me.dtpDecontaminated.Format = DateTimePickerFormat.Custom
                    Me.dtpDecontaminated.Checked = False
                End If
            End If

            If dispose_cIndex >= 0 AndAlso dispose_cIndex < Me.TblInventoryDataGridView.Columns.Count Then

                Dim dispose_cellValue As Object = Me.TblInventoryDataGridView.Rows(rowIndex).Cells(dispose_cIndex).Value
                Dim dispose As String = dispose_cellValue.ToString

                If dispose = "" Then
                    Me.dtpDispose.CustomFormat = " "
                    Me.dtpDispose.Format = DateTimePickerFormat.Custom
                    Me.dtpDispose.Checked = False
                End If
            End If

            If sold_cIndex >= 0 AndAlso sold_cIndex < Me.TblInventoryDataGridView.Columns.Count Then

                Dim sold_cellValue As Object = Me.TblInventoryDataGridView.Rows(rowIndex).Cells(sold_cIndex).Value
                Dim sold As String = sold_cellValue.ToString

                If sold = "" Then
                    Me.dtpSold.CustomFormat = " "
                    Me.dtpSold.Format = DateTimePickerFormat.Custom
                    Me.dtpSold.Checked = False
                End If
            End If

        End If
    End Sub

    Private Sub DtpServiceDue_ValueChanged(sender As Object, e As EventArgs) Handles dtpServiceDue.ValueChanged
        Me.dtpServiceDue.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub DtpServiceDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpServiceDate.ValueChanged
        Me.dtpServiceDate.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub DtpDateofPhysicalVerification_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateofPhysicalVerification.ValueChanged
        Me.dtpDateofPhysicalVerification.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub DtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub DtpWarrantyExpiration_ValueChanged(sender As Object, e As EventArgs) Handles dtpWarrantyExpiration.ValueChanged
        Me.dtpWarrantyExpiration.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub DtpDecontaminated_ValueChanged(sender As Object, e As EventArgs) Handles dtpDecontaminated.ValueChanged
        Me.dtpDecontaminated.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub DtpDispose_ValueChanged(sender As Object, e As EventArgs) Handles dtpDispose.ValueChanged
        Me.dtpDispose.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub DtpSold_ValueChanged(sender As Object, e As EventArgs) Handles dtpSold.ValueChanged
        Me.dtpSold.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub TblInventoryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblInventoryDataGridView.CellClick
        ' Check if the click was on a valid row (not on column headers or empty area)
        If e.RowIndex >= 0 Then
            ' Clear the selection of the DataGridView
            TblInventoryDataGridView.ClearSelection()

            ' Select the clicked row
            TblInventoryDataGridView.Rows(e.RowIndex).Selected = True

            ' Set the selection back color to the same as the row back color
            TblInventoryDataGridView.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.Green
            TblInventoryDataGridView.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Yellow
        End If
    End Sub

    Private Sub TblInventoryDataGridView_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles TblInventoryDataGridView.CellLeave
        ' Check if the click was on a valid row (not on column headers or empty area)
        If e.RowIndex >= 0 Then
            ' Clear the selection of the DataGridView
            Me.TblInventoryDataGridView.ClearSelection()

            ' Select the clicked row            
            Me.TblInventoryDataGridView.Rows(e.RowIndex).Selected = False

        End If
    End Sub

    Private Sub TblInventoryDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles TblInventoryDataGridView.CellEnter
        ' Check if the click was on a valid row (not on column headers or empty area)
        If e.RowIndex >= 0 Then
            ' Clear the selection of the DataGridView
            TblInventoryDataGridView.ClearSelection()

            ' Select the clicked row
            TblInventoryDataGridView.Rows(e.RowIndex).Selected = True

            ' Set the selection back color to the same as the row back color
            TblInventoryDataGridView.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.Green
            TblInventoryDataGridView.Rows(e.RowIndex).DefaultCellStyle.SelectionForeColor = Color.Yellow
        End If
    End Sub

    Private Sub TsbCancel_Click(sender As Object, e As EventArgs) Handles tsbCancel.Click
        'Cancel changes made
        Me.TblInventoryBindingSource.CancelEdit()
        Me.InventoryList_ds.tblInventory.RejectChanges()

        'Enables tsbAdd,dgv,cancel and the delete btns
        Me.tsbAdd.Enabled = True
        Me.tsbDelete.Enabled = True
        Me.TblInventoryDataGridView.Enabled = True
        Me.tsbCancel.Enabled = False
    End Sub

    Private Sub BtnAddAssetName_Click(sender As Object, e As EventArgs) Handles BtnAddAssetName.Click

        Me.lblGroupID.Text = 106
        GlobalVariablesClass.groupID = Me.lblGroupID.Text

        Dim comboItemsFrm As New Lab_frmComboItems

        Me.lblGroupID.DataBindings.Clear()
        Me.lblGroupID.DataBindings.Add("Text", Me.BindingSource_asset_name, "group_id")

        comboItemsFrm.Text = "Add Asset Name"
        comboItemsFrm.ShowDialog()

    End Sub

    Private Sub CboAssetName_Click(sender As Object, e As EventArgs) Handles CboAssetName.Click
        With CboAssetName
            .DataSource = Me.TblComboItemsTableAdapter.DataTable_asset_name
            .DisplayMember = "items"
        End With
    End Sub

    Private Sub BtnBrand_Click(sender As Object, e As EventArgs) Handles BtnBrand.Click

        Me.lblGroupID.Text = 107
        GlobalVariablesClass.groupID = Me.lblGroupID.Text

        Dim comboItemsFrm As New Lab_frmComboItems

        Me.lblGroupID.DataBindings.Clear()
        Me.lblGroupID.DataBindings.Add("Text", Me.BindingSource_brand, "group_id")

        comboItemsFrm.Text = "Add Brand"
        comboItemsFrm.ShowDialog()
    End Sub

    Private Sub CboBrand_Click(sender As Object, e As EventArgs) Handles CboBrand.Click
        With CboBrand
            .DataSource = Me.TblComboItemsTableAdapter.DataTable_brand
            .DisplayMember = "items"
        End With
    End Sub
End Class
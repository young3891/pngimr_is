Public Class Lab_frmComboItems
    Inherits Form
    Dim grpID As Integer
    'Dim inventoryfrm As New frmInventory()   
    Private Sub frmComboItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Passes the group id value from the global class to the group id label
        Me.lblGroupID.Text = GlobalVariablesClass.groupID
        grpID = GlobalVariablesClass.groupID

        'The dgv is populated with values according to add button associated to which combo btn
        'in the inventory form
        If Me.lblGroupID.Text = "101" Then
            Me.TblComboItemsTableAdapter.FillBy_Site(Me.ComboItems_ds.tblComboItems)
        ElseIf Me.lblGroupID.Text = "102" Then
            Me.TblComboItemsTableAdapter.FillBy_dept(Me.ComboItems_ds.tblComboItems)
        ElseIf Me.lblGroupID.Text = "103" Then
            Me.TblComboItemsTableAdapter.FillBy_room_name(Me.ComboItems_ds.tblComboItems)
        ElseIf Me.lblGroupID.Text = "104" Then
            Me.TblComboItemsTableAdapter.FillBy_room_no(Me.ComboItems_ds.tblComboItems)
        ElseIf Me.lblGroupID.Text = "105" Then
            Me.TblComboItemsTableAdapter.FillBy_supplier(Me.ComboItems_ds.tblComboItems)
        End If

        'Applies the rounded features of the btns coded in the CustomizedControlsClass class
        CustomizedControlsClass.frmComboItems_btnSave(Me)
        CustomizedControlsClass.frmComboItems_btnCancel(Me)
        CustomizedControlsClass.frmComboItems_btnDelete(Me)

        'Adds new record and gives the binding source to item control
        Me.TblComboItemsBindingSource.AddNew()
        Me.txtNewItem.DataBindings.Add("Text", Me.TblComboItemsBindingSource, "items")

        'Sets focus to the item field
        Me.txtNewItem.Select()

        'Disables DGV and the delete btn
        Me.TblComboItemsDataGridView.Enabled = False
        Me.btnDelete.Enabled = False

        'Disable save btn 
        Me.btnSave.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Me.lblID.Text < 0 Then
                'Checks to ensure that item field should have a value
                If Me.txtNewItem.Text = "" Then
                    MessageBox.Show("Item must be entered!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNewItem.Select()
                    Exit Sub
                End If
                'Assigns group id stored from grpID variable to the group id label
                Me.lblGroupID.Text = grpID

                'Ends record editing and saves the data
                Me.TblComboItemsBindingSource.EndEdit()
                Dim r As Integer
                r = Me.TblComboItemsTableAdapter.Update(Me.ComboItems_ds.tblComboItems)

                If r > 0 Then
                    'My.Forms.frmInventory.TblComboItemsTableAdapter.Fill(inventoryList_ds.tblInventory)
                    'frmInventory.TblComboItemsTableAdapter.Fill(inventoryList_ds.tblInventory)
                    ComboItemsClass.cboSiteItems()
                    MessageBox.Show("Saved!")
                    Me.DialogResult = DialogResult.OK

                Else
                    MessageBox.Show("Not Saved! Try again!")
                End If

                'My.Forms.frmInventory.TblComboItemsTableAdapter.Fill(inventoryList_ds.tblInventory)
                'ComboItemsClass.cboSiteItems()

                Me.Close()
            ElseIf Me.lblID.Text > 0 Then
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error! " + ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.txtNewItem.Enabled = False
        Me.TblComboItemsDataGridView.Enabled = True
        Me.btnDelete.Enabled = True
        Me.btnSave.Enabled = True

        Me.txtNewItem.DataBindings.Clear()
        Me.TblComboItemsBindingSource.CancelEdit()
        Me.ComboItems_ds.tblComboItems.RejectChanges()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.TblComboItemsBindingSource.RemoveCurrent()
        Me.TblComboItemsTableAdapter.Update(Me.ComboItems_ds.tblComboItems)
    End Sub

    Private Sub txtNewItem_TextChanged(sender As Object, e As EventArgs) Handles txtNewItem.TextChanged
        If Me.txtNewItem.TextLength = 0 Then
            Me.btnSave.Enabled = False
        ElseIf Me.txtNewItem.TextLength > 0 Then
            Me.btnSave.Enabled = True
        End If
    End Sub
End Class
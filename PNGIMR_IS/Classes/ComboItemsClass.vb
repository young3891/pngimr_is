Public Class ComboItemsClass
    'Public Shared Sub frmAddUser_pnlFullName(form As Form)
    '    Dim pnlFullName As Panel = form.Controls.Find("pnlFullName", True).FirstOrDefault

    '    If pnlFullName IsNot Nothing Then
    '        Dim path As New System.Drawing.Drawing2D.GraphicsPath()
    '        Dim radius As Integer = 10 ' Adjust the radius to control the curvature of the corners
    '        Dim rect As Rectangle = pnlFullName.ClientRectangle

    '        path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90) ' Top-left corner
    '        path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90) ' Top-right corner
    '        path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90) ' Bottom-right corner
    '        path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90) ' Bottom-left corner

    '        pnlFullName.Region = New System.Drawing.Region(path)
    '    End If
    'End Sub
    Public Shared Sub cboSiteItems()
        'Loads respective items onto the comboboxes        
        'TblComboItemsTableAdapter.Fill(inventoryList_ds.tblComboItems)
        With Lab_frmInventory.cboSite
            .DataSource = Lab_frmInventory.BindingSource_site
            .DisplayMember = "items"
        End With
    End Sub
End Class

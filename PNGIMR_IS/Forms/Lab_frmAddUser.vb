Imports System.Security.Cryptography
Imports System.Text
Imports System.Globalization.CultureInfo
Imports System.Windows.Forms
Public Class Lab_frmAddUser
    Inherits Form

    Dim current_date_time As String
    Dim totalUser As Integer
    Public Shared Function HashString(str As String) As String
        Return EncryptString(str)
    End Function
    Private Shared Function EncryptString(str As String)
        '----use this if "Imports System.Security.Cryptography" and "Imports System.Text" is imported at the top
        'Dim bytes As Byte() = Encoding.ASCII.GetBytes(str)'*use this when the class is imported in the top
        'Dim hashed = SHA256.Create().ComputeHash(bytes) '*use this when the class is imported in the top

        '----use this if "Imports System.Security.Cryptography" and "Imports System.Text" is not imported at the top
        Dim bytes As Byte() = System.Text.Encoding.ASCII.GetBytes(str)
        Dim hashed = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes)
        Return Convert.ToBase64String(hashed)
    End Function

    Public Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CustomizedControlsClass.frmAddUser_pnlFullName(Me)
        CustomizedControlsClass.frmAddUser_pnlUserName(Me)
        CustomizedControlsClass.frmAddUser_pnlID(Me)
        CustomizedControlsClass.frmAddUser_pnlAccess(Me)
        CustomizedControlsClass.frmAddUser_pnlPassword(Me)
        CustomizedControlsClass.frmAddUser_pnlConfirmPassword(Me)

        Me.TblDBUserTableAdapter.Fill(Me.Users_ds.tblDBUser)

        Me.lblUsersTotal.Text = Me.TblDBUserTableAdapter.UserCountQuery.GetValueOrDefault.ToString


        'Hide the confirm password controls        
        Me.pnlConfirmPassword.Visible = False
        Me.lblConfirmPassword.Visible = False
        Me.pnlPassword.Visible = False
        Me.lblPassword.Visible = False

        Me.pnlAccess.Location = New System.Drawing.Point(114, 96)
        Me.lblAccess.Location = New System.Drawing.Point(49, 100)

        'Disable/Enable controls
        Me.tsbSave.Enabled = False
        Me.tsbDelete.Enabled = True
        Me.tsbCancel.Enabled = False

        'Sets cursors of the buttons
        Me.tsbAdd.GetCurrentParent.Cursor = Cursors.Hand

        'Starts the timer
        Me.Timer1.Start()
    End Sub

    Private Sub tsbAdd_Click(sender As Object, e As EventArgs) Handles tsbAdd.Click
        Me.pnlMain.Enabled = True

        Me.TblDBUserBindingSource.AddNew()
        Me.cboAccess.SelectedIndex = -1
        Me.txtFullName.Select()

        'Unhides the confirm password controls
        Me.txtConfirmPassword.Visible = True
        Me.pnlConfirmPassword.Visible = True
        Me.lblConfirmPassword.Visible = True
        Me.pnlPassword.Visible = True
        Me.lblPassword.Visible = True

        'Returns access controls to its original location
        Me.pnlAccess.Location = New System.Drawing.Point(114, 151)
        Me.lblAccess.Location = New System.Drawing.Point(62, 153)

        'Clears password and confirm pass fields
        Me.txtPassword.Clear()
        Me.txtConfirmPassword.Clear()
        'Disable/Enable controls

        Me.tsbAdd.Enabled = False
        Me.tsbSave.Enabled = True
        Me.tsbDelete.Enabled = False
        Me.tsbCancel.Enabled = True

        'Sets focus of the cursor to full name field
        Me.txtFullName.Select()
    End Sub

    Private Sub tsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click
        '->Ensures that all fields must have values

        If Me.txtFullName.TextLength = 0 Then
            MessageBox.Show("Full Name field should not be blank. Please try again!", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtFullName.Select()
            Exit Sub
        ElseIf Me.txtUserName.TextLength = 0 Then
            MessageBox.Show("User name field should not be blank. Please try again!", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtUserName.Select()
            Exit Sub
        ElseIf Me.txtPassword.TextLength = 0 Then
            MessageBox.Show("Password field should not be blank. Please try again!", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtPassword.Select()
            Exit Sub
        ElseIf Me.txtConfirmPassword.TextLength = 0 Then
            MessageBox.Show("Confirm password field should not be blank. Please try again!", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtConfirmPassword.Select()
            Exit Sub
        ElseIf Me.cboAccess.SelectedIndex = -1 Then
            MessageBox.Show("Access field should not be blank. Please try again!", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cboAccess.Select()
            Exit Sub
        ElseIf Me.txtPassword.Text <> Me.txtConfirmPassword.Text Then
            MessageBox.Show("Confirm password doesn't match password.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtConfirmPassword.Select()
            Exit Sub
        End If


        '->encrypts the password
        Dim pw = EncryptString(Me.txtPassword.Text)
        If Me.txtPassword.TextLength > 0 Then
            Me.lblEncryptedPassword.Text = pw
        End If

        '->Gets the user name of the person who logged in and stores the value in the label 'lblEditedBy'
        ''un = PNGIMR_IS.GlobalVariablesClass.User_Name
        If Me.lblUsersTotal.Text = 0 Then
            Me.lblEditedBy.Text = Me.txtFullName.Text
            Me.pnlMain.Enabled = False
            GlobalVariablesClass.User_Name = Me.lblEditedBy.Text
        ElseIf Me.lblUsersTotal.Text > 0 Then
            Me.lblEditedBy.Text = GlobalVariablesClass.User_Name
        End If

        '->Gets the current date and time and stores the value in the label 'lblTimeStamp'
        Me.lblTimeStamp.Text = current_date_time

        '->Saves record
        Me.TblDBUserBindingSource.EndEdit()
        Me.TblDBUserTableAdapter.Update(Me.Users_ds.tblDBUser)

        Me.lblUsersTotal.Text = Me.TblDBUserTableAdapter.UserCountQuery.GetValueOrDefault.ToString

        GlobalVariablesClass.totalNumberOfUser = Me.lblUsersTotal.Text

        '->Disable/Enable controls
        Me.tsbAdd.Enabled = True
        Me.tsbSave.Enabled = False
        Me.tsbDelete.Enabled = True
        Me.tsbCancel.Enabled = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim current_date As String = Today.ToString(GlobalVariablesClass.current_date_settings)
        Dim current_time As String = TimeOfDay.ToString("h:mm:ss tt")

        current_date_time = current_date + " " + current_time
        Me.lblTimeStamp.Text = current_date_time
    End Sub
    Private Sub tsbCancel_Click(sender As Object, e As EventArgs) Handles tsbCancel.Click
        'Cancel changes
        Me.TblDBUserBindingSource.CancelEdit()
        Me.Users_ds.tblDBUser.RejectChanges()

        Me.TblDBUserTableAdapter.Fill(Users_ds.tblDBUser)
        Me.TblDBUserDataGridView.DataSource = Me.TblDBUserBindingSource

        'Disable controls when cancel button is clicked
        Me.tsbCancel.Enabled = False
        Me.tsbSave.Enabled = False
        Me.tsbAdd.Enabled = True
        Me.tsbDelete.Enabled = True

        'Hide the confirm password controls        
        Me.pnlConfirmPassword.Visible = False
        Me.lblConfirmPassword.Visible = False
        Me.pnlPassword.Visible = False
        Me.lblPassword.Visible = False

        'Me.pnlPassword.Visible = True
        'Me.lblPassword.Visible = True

        'Returns access controls to its original location
        'Me.pnlAccess.Location = New System.Drawing.Point(114, 151)
        'Me.lblAccess.Location = New System.Drawing.Point(62, 153)

        'Me.pnlConfirmPassword.Location = New System.Drawing.Point(114, 151)
        'Me.lblConfirmPassword.Location = New System.Drawing.Point(62, 154)

        Me.pnlAccess.Location = New System.Drawing.Point(114, 96)
        'Me.lblAccess.Location = New System.Drawing.Point(62, 125)
        Me.lblAccess.Location = New System.Drawing.Point(62, 100)




    End Sub
    Private Sub tsbDelete_Click(sender As Object, e As EventArgs) Handles tsbDelete.Click
        'Deletes a record and saves the dataset
        Me.TblDBUserBindingSource.RemoveCurrent()
        Me.TblDBUserTableAdapter.Update(Me.Users_ds.tblDBUser)
        MessageBox.Show("1 record successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub tsbExit_Click(sender As Object, e As EventArgs) Handles tsbExit.Click

        Me.Hide()

        If Me.lblUsersTotal.Text = 0 Then
            Lab_frmMain.tsmAddUser.Enabled = False
        ElseIf Me.lblUsersTotal.Text > 0 Then
            Lab_frmMain.tsmAddUser.Enabled = True
        End If

        Lab_frmMain.Show()

        Me.Close()
    End Sub
    Private Sub cboAccess_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboAccess.KeyPress
        'Check if the pressed key is a letter
        If Char.IsLetter(e.KeyChar) Then
            ' Find the first item that starts with the pressed letter
            Dim index As Integer = Me.cboAccess.FindString(e.KeyChar.ToString())

            'If an item is found, select it and save the selected value
            If index >= 0 Then
                Me.cboAccess.SelectedIndex = index
                Me.cboAccess.Text = Me.cboAccess.SelectedItem.ToString()
            End If
        End If
    End Sub
End Class
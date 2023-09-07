Imports System.Security.Cryptography
Imports System.Text

Public Class Lab_frmLogin

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
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Retest pushing updated code to github    
        Me.TblDBUserTableAdapter.Fill(Me.Login_ds.tblDBUser, Me.txtUsername.Text, Me.txtPassword.Text)

        CustomizedControlsClass.frmLogin_btnCancel(Me)
        CustomizedControlsClass.frmLogin_btnOK(Me)
        CustomizedControlsClass.frmLogin_pnlUsername(Me)
        CustomizedControlsClass.frmLogin_pnlPassword(Me)

        Me.txtUsername.Select()

        Me.lblUserCount.Text = Me.TblDBUserTableAdapter.UserCountQuery.GetValueOrDefault.ToString

        If Me.lblUserCount.Text = 0 Then

            MessageBox.Show("Since it is the initial login, please enter '""Admin""' as username and '""Admin""' as password!", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Public Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        '--Logging into the system for the first time--------------------------------------------------------------------------

        '->Checks number of users already registered        
        Me.lblUserCount.Text = Me.TblDBUserTableAdapter.UserCountQuery.GetValueOrDefault.ToString

        If Me.lblUserCount.Text = 0 Then

            If Me.txtUsername.Text <> "Admin" Then
                MessageBox.Show("Please enter 'Admin' as user name!", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtUsername.Select()
                Exit Sub
            ElseIf Me.txtPassword.Text <> "Admin" Then
                MessageBox.Show("Please enter 'Admin' as password!", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtPassword.Select()
                Exit Sub
            End If

            '->Enables the panel that holds all the controls            

            '->Hides the main form
            FrmMain.Hide()
            Me.Hide()

            '->Opens the add user form

            Lab_frmAddUser.ShowDialog()

            Exit Sub
        Else
            Dim rv As Integer
            Dim pw = EncryptString(Me.txtPassword.Text)

            '->Ensures the password field is not blank
            If Me.txtPassword.TextLength > 0 Then
                Me.lblEncryptPW.Text = pw
            Else
                MessageBox.Show("Please enter a password or user name!", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtUsername.Select()
                Exit Sub
            End If

            rv = Me.TblDBUserTableAdapter.Fill(Me.Login_ds.tblDBUser, Me.txtUsername.Text, Me.lblEncryptPW.Text)

            If rv <= 0 Then
                MessageBox.Show("Invalid user name or password!", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                MessageBox.Show("Login Successful!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()

                GlobalVariablesClass.User_Name = Me.txtUsername.Text

                '-> Hides the instance of Lab_frmMain form if it's open                

                If Application.OpenForms.OfType(Of Lab_frmMain)().Any() Then
                    Lab_frmMain.Hide()

                    If Application.OpenForms.OfType(Of FrmMain)().Any() Then
                        FrmMain.Hide()
                    End If

                    Lab_frmMain.Show()
                Else
                    FrmMain.Hide()
                    Lab_frmMain.Show()
                End If
            End If
        End If        '
    End Sub
End Class
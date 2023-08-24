Public Class Lab_frmMain

    Private Sub tsmExit_Click(sender As Object, e As EventArgs) Handles tsmExit.Click

        If Application.OpenForms.OfType(Of frmMain)().Any() Then
            frmMain.Hide()
        End If

        Me.Hide()

        frmMain.Show()
    End Sub
    Private Sub Lab_frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim totalNumOfUsers As Integer
        totalNumOfUsers = GlobalVariablesClass.totalNumberOfUser
    End Sub

    Private Sub tsmUser_Click(sender As Object, e As EventArgs)

        If Application.OpenForms.OfType(Of Lab_frmAddUser)().Any() Then
            Lab_frmAddUser.Close()
            Dim lab_addUser As New Lab_frmAddUser
            lab_addUser.ShowDialog()
        Else
            Lab_frmAddUser.ShowDialog()
        End If
    End Sub

    Private Sub tsmAddUser_Click(sender As Object, e As EventArgs) Handles tsmAddUser.Click

        If Application.OpenForms.OfType(Of Lab_frmAddUser)().Any() Then
            Lab_frmAddUser.Close()
            Dim lab_addUser As New Lab_frmAddUser
            lab_addUser.ShowDialog()
        Else
            Lab_frmAddUser.ShowDialog()
        End If
    End Sub

    Private Sub tsmInventory_Click(sender As Object, e As EventArgs) Handles tsmInventory.Click
        If Application.OpenForms.OfType(Of Lab_frmInventory)().Any() Then
            Lab_frmInventory.Close()
            Dim lab_inventory As New Lab_frmInventory
            lab_inventory.ShowDialog()
        Else
            Lab_frmInventory.ShowDialog()
        End If
    End Sub
End Class
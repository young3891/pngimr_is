Public Class FrmMain
    Private Sub BtnInventory_Click(sender As Object, e As EventArgs) Handles btnLabInventoryDatabase.Click
        'added some comments

        If Lab_frmLogin IsNot Nothing Then
            Lab_frmLogin.Hide()

            Dim lab_loginFrm As New Lab_frmLogin
            lab_loginFrm.ShowDialog()
        Else
            'Dim lab_loginFrm As New Lab_frmLogin
            'lab_loginFrm.ShowDialog()

            Lab_frmLogin.ShowDialog()
        End If
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizedControlsClass.frmMain_btnLabInventoryDatabase(Me)
        CustomizedControlsClass.frmMain_btnExitMainFrm(Me)
    End Sub

    Private Sub BtnExitMainFrm_Click(sender As Object, e As EventArgs) Handles btnExitMainFrm.Click
        Application.Exit()
    End Sub
End Class
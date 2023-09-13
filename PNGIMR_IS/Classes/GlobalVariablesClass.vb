Public Class GlobalVariablesClass
    '->Stores the user name
    Public Shared User_Name As String '= Lab_frmLogin.txtUsername.Text
    '------------------------------
    Public Shared totalNumberOfUser As Integer
    'Public Shared tempPW As String = tempPW

    '->Stores the date settings of the computer in use
    Public Shared current_date_settings As String = System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.ShortDatePattern()
    '-------------------------------------------
    Public Shared groupID As String '= Lab_frmInventory.lblGroupID.Text
    '->Stores the last id generated
    'Public Shared last_id_generated As String = frmStudentRegistration.lblTempID.Text
    '------------------------------------   
    'Public Shared usersRecordCount As Integer = frmLogin.lblUsersTotal.Text
    Public Shared txtTempUserName As String
    Public Shared txtTempPassWord As String
End Class

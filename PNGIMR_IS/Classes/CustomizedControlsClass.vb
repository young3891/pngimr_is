Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Public Class CustomizedControlsClass
    'Adds rounded edges to panel control of the full name field of the Add User form
    Public Shared Sub frmAddUser_pnlFullName(form As Form)
        Dim pnlFullName As Panel = form.Controls.Find("pnlFullName", True).FirstOrDefault

        If pnlFullName IsNot Nothing Then
            Dim path As New System.Drawing.Drawing2D.GraphicsPath()
            Dim radius As Integer = 10 ' Adjust the radius to control the curvature of the corners
            Dim rect As Rectangle = pnlFullName.ClientRectangle

            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90) ' Top-left corner
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90) ' Top-right corner
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90) ' Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90) ' Bottom-left corner

            pnlFullName.Region = New System.Drawing.Region(path)
        End If
    End Sub

    'Adds rounded edges to panel control of the user name field of the Add User form
    Public Shared Sub frmAddUser_pnlUserName(form As Form)
        Dim pnlUserName As Panel = form.Controls.Find("pnlUserName", True).FirstOrDefault

        If pnlUserName IsNot Nothing Then
            Dim path As New System.Drawing.Drawing2D.GraphicsPath()
            Dim radius As Integer = 10 ' Adjust the radius to control the curvature of the corners
            Dim rect As Rectangle = pnlUserName.ClientRectangle

            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90) ' Top-left corner
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90) ' Top-right corner
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90) ' Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90) ' Bottom-left corner

            pnlUserName.Region = New System.Drawing.Region(path)
        End If
    End Sub

    'Adds rounded edges to panel control of the ID field of the Add User form
    Public Shared Sub frmAddUser_pnlID(form As Form)
        Dim pnlID As Panel = form.Controls.Find("pnlID", True).FirstOrDefault

        If pnlID IsNot Nothing Then
            Dim path As New System.Drawing.Drawing2D.GraphicsPath()
            Dim radius As Integer = 10 ' Adjust the radius to control the curvature of the corners
            Dim rect As Rectangle = pnlID.ClientRectangle

            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90) ' Top-left corner
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90) ' Top-right corner
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90) ' Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90) ' Bottom-left corner

            pnlID.Region = New System.Drawing.Region(path)
        End If
    End Sub

    'Adds rounded edges to panel control of the access field of the Add User form
    Public Shared Sub frmAddUser_pnlAccess(form As Form)
        Dim pnlAccess As Panel = form.Controls.Find("pnlAccess", True).FirstOrDefault

        If pnlAccess IsNot Nothing Then
            Dim path As New System.Drawing.Drawing2D.GraphicsPath()
            Dim radius As Integer = 10 ' Adjust the radius to control the curvature of the corners
            Dim rect As Rectangle = pnlAccess.ClientRectangle

            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90) ' Top-left corner
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90) ' Top-right corner
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90) ' Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90) ' Bottom-left corner

            pnlAccess.Region = New System.Drawing.Region(path)
        End If
    End Sub

    'Adds rounded edges to panel control of the full password field of the Add User form
    Public Shared Sub frmAddUser_pnlPassword(form As Form)
        Dim pnlPassword As Panel = form.Controls.Find("pnlPassword", True).FirstOrDefault

        If pnlPassword IsNot Nothing Then
            Dim path As New System.Drawing.Drawing2D.GraphicsPath()
            Dim radius As Integer = 10 ' Adjust the radius to control the curvature of the corners
            Dim rect As Rectangle = pnlPassword.ClientRectangle

            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90) ' Top-left corner
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90) ' Top-right corner
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90) ' Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90) ' Bottom-left corner

            pnlPassword.Region = New System.Drawing.Region(path)
        End If
    End Sub

    'Adds rounded edges to panel control of the confirm password field of the Add User form
    Public Shared Sub frmAddUser_pnlConfirmPassword(form As Form)
        Dim pnlConfirmPassword As Panel = form.Controls.Find("pnlConfirmPassword", True).FirstOrDefault

        If pnlConfirmPassword IsNot Nothing Then
            Dim path As New System.Drawing.Drawing2D.GraphicsPath()
            Dim radius As Integer = 10 ' Adjust the radius to control the curvature of the corners
            Dim rect As Rectangle = pnlConfirmPassword.ClientRectangle

            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90) ' Top-left corner
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90) ' Top-right corner
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90) ' Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90) ' Bottom-left corner

            pnlConfirmPassword.Region = New System.Drawing.Region(path)
        End If
    End Sub

    'Adds rounded edges to save button of the combo items form
    Public Shared Sub frmComboItems_btnSave(form As Form)
        Dim btnSave As Button = form.Controls.Find("btnSave", True).FirstOrDefault

        If btnSave IsNot Nothing Then
            btnSave.FlatStyle = FlatStyle.Flat
            btnSave.FlatAppearance.BorderSize = 0

            Dim path As New Drawing2D.GraphicsPath()
            path.StartFigure()
            Dim radius As Integer = 15 ' Adjust the radius to control the curvature of the corners        
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 80) ' Top-left corner        
            path.AddArc(btnSave.Width - radius * 2, 0, radius * 2, radius * 2, 270, 80) ' Top-right corner
            path.AddArc(btnSave.Width - radius * 2, btnSave.Height - radius * 2, radius * 2, radius * 2, 0, 100) ' Bottom-right corner
            path.AddArc(0, btnSave.Height - radius * 2, radius * 2, radius * 2, 80, 80) ' Bottom-left corner
            btnSave.Region = New Region(path)
        End If
    End Sub

    'Adds rounded edges to cancel button of the combo items form
    Public Shared Sub frmComboItems_btnCancel(form As Form)
        Dim btnCancel As Button = form.Controls.Find("btnCancel", True).FirstOrDefault

        If btnCancel IsNot Nothing Then
            btnCancel.FlatStyle = FlatStyle.Flat
            btnCancel.FlatAppearance.BorderSize = 0

            Dim path As New Drawing2D.GraphicsPath()
            path.StartFigure()
            Dim radius As Integer = 15 ' Adjust the radius to control the curvature of the corners        
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 80) ' Top-left corner        
            path.AddArc(btnCancel.Width - radius * 2, 0, radius * 2, radius * 2, 270, 80) ' Top-right corner
            path.AddArc(btnCancel.Width - radius * 2, btnCancel.Height - radius * 2, radius * 2, radius * 2, 0, 100) ' Bottom-right corner
            path.AddArc(0, btnCancel.Height - radius * 2, radius * 2, radius * 2, 80, 80) ' Bottom-left corner
            btnCancel.Region = New Region(path)
        End If
    End Sub

    'Adds rounded edges to delete button of the combo items form
    Public Shared Sub frmComboItems_btnDelete(form As Form)
        Dim btnDelete As Button = form.Controls.Find("btnDelete", True).FirstOrDefault

        If btnDelete IsNot Nothing Then
            btnDelete.FlatStyle = FlatStyle.Flat
            btnDelete.FlatAppearance.BorderSize = 0

            Dim path As New Drawing2D.GraphicsPath()
            path.StartFigure()
            Dim radius As Integer = 15 ' Adjust the radius to control the curvature of the corners        
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 80) ' Top-left corner        
            path.AddArc(btnDelete.Width - radius * 2, 0, radius * 2, radius * 2, 270, 80) ' Top-right corner
            path.AddArc(btnDelete.Width - radius * 2, btnDelete.Height - radius * 2, radius * 2, radius * 2, 0, 100) ' Bottom-right corner
            path.AddArc(0, btnDelete.Height - radius * 2, radius * 2, radius * 2, 80, 80) ' Bottom-left corner
            btnDelete.Region = New Region(path)
        End If
    End Sub

    'Adds rounded edges to OK button of the Login form
    Public Shared Sub frmLogin_btnOK(form As Form)
        Dim btnOK As Button = form.Controls.Find("btnOK", True).FirstOrDefault

        If btnOK IsNot Nothing Then
            btnOK.FlatStyle = FlatStyle.Flat
            btnOK.FlatAppearance.BorderSize = 0

            Dim path As New Drawing2D.GraphicsPath()
            path.StartFigure()
            Dim radius As Integer = 15 ' Adjust the radius to control the curvature of the corners        
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 80) ' Top-left corner        
            path.AddArc(btnOK.Width - radius * 2, 0, radius * 2, radius * 2, 270, 80) ' Top-right corner
            path.AddArc(btnOK.Width - radius * 2, btnOK.Height - radius * 2, radius * 2, radius * 2, 0, 100) ' Bottom-right corner
            path.AddArc(0, btnOK.Height - radius * 2, radius * 2, radius * 2, 80, 80) ' Bottom-left corner
            btnOK.Region = New Region(path)
        End If
    End Sub

    'Adds rounded edges to cancel button of the Login form
    Public Shared Sub frmLogin_btnCancel(form As Form)
        Dim btnCancel As Button = form.Controls.Find("btnCancel", True).FirstOrDefault

        If btnCancel IsNot Nothing Then
            btnCancel.FlatStyle = FlatStyle.Flat
            btnCancel.FlatAppearance.BorderSize = 0

            Dim path As New Drawing2D.GraphicsPath()
            path.StartFigure()
            Dim radius As Integer = 15 ' Adjust the radius to control the curvature of the corners        
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 80) ' Top-left corner        
            path.AddArc(btnCancel.Width - radius * 2, 0, radius * 2, radius * 2, 270, 80) ' Top-right corner
            path.AddArc(btnCancel.Width - radius * 2, btnCancel.Height - radius * 2, radius * 2, radius * 2, 0, 100) ' Bottom-right corner
            path.AddArc(0, btnCancel.Height - radius * 2, radius * 2, radius * 2, 80, 80) ' Bottom-left corner
            btnCancel.Region = New Region(path)
        End If
    End Sub

    'Adds rounded edges to LABORATORY ASSET MANAGEMENT button of the Main form
    Public Shared Sub frmMain_btnLabInventoryDatabase(form As Form)
        Dim btnLabInventoryDatabase As Button = form.Controls.Find("btnLabInventoryDatabase", True).FirstOrDefault

        If btnLabInventoryDatabase IsNot Nothing Then
            btnLabInventoryDatabase.FlatStyle = FlatStyle.Flat
            btnLabInventoryDatabase.FlatAppearance.BorderSize = 0

            Dim path As New Drawing2D.GraphicsPath()
            path.StartFigure()
            Dim radius As Integer = 28 ' Adjust the radius to control the curvature of the corners        
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 80) ' Top-left corner        
            path.AddArc(btnLabInventoryDatabase.Width - radius * 2, 0, radius * 2, radius * 2, 270, 80) ' Top-right corner
            path.AddArc(btnLabInventoryDatabase.Width - radius * 2, btnLabInventoryDatabase.Height - radius * 2, radius * 2, radius * 2, 0, 100) ' Bottom-right corner
            path.AddArc(0, btnLabInventoryDatabase.Height - radius * 2, radius * 2, radius * 2, 80, 80) ' Bottom-left corner
            btnLabInventoryDatabase.Region = New Region(path)
        End If
    End Sub

    'Adds rounded edges to panel control of the user name field of the Lab Login form
    Public Shared Sub frmLogin_pnlUsername(form As Form)
        Dim pnlUsername As Panel = form.Controls.Find("pnlUsername", True).FirstOrDefault

        If pnlUsername IsNot Nothing Then
            Dim path As New System.Drawing.Drawing2D.GraphicsPath()
            Dim radius As Integer = 10 ' Adjust the radius to control the curvature of the corners
            Dim rect As Rectangle = pnlUsername.ClientRectangle

            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90) ' Top-left corner
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90) ' Top-right corner
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90) ' Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90) ' Bottom-left corner

            pnlUsername.Region = New System.Drawing.Region(path)
        End If
    End Sub

    'Adds rounded edges to panel control of the password field of the Lab Login form
    Public Shared Sub frmLogin_pnlPassword(form As Form)
        Dim pnlPassword As Panel = form.Controls.Find("pnlPassword", True).FirstOrDefault

        If pnlPassword IsNot Nothing Then
            Dim path As New System.Drawing.Drawing2D.GraphicsPath()
            Dim radius As Integer = 10 ' Adjust the radius to control the curvature of the corners
            Dim rect As Rectangle = pnlPassword.ClientRectangle

            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90) ' Top-left corner
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90) ' Top-right corner
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90) ' Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90) ' Bottom-left corner

            pnlPassword.Region = New System.Drawing.Region(path)
        End If
    End Sub
    'Adds rounded edges to Exit button of the Main form
    Public Shared Sub frmMain_btnExitMainFrm(form As Form)
        Dim btnExitMainFrm As Button = form.Controls.Find("btnExitMainFrm", True).FirstOrDefault

        If btnExitMainFrm IsNot Nothing Then
            btnExitMainFrm.FlatStyle = FlatStyle.Flat
            btnExitMainFrm.FlatAppearance.BorderSize = 0

            Dim path As New Drawing2D.GraphicsPath()
            path.StartFigure()
            Dim radius As Integer = 28 ' Adjust the radius to control the curvature of the corners        
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 80) ' Top-left corner        
            path.AddArc(btnExitMainFrm.Width - radius * 2, 0, radius * 2, radius * 2, 270, 80) ' Top-right corner
            path.AddArc(btnExitMainFrm.Width - radius * 2, btnExitMainFrm.Height - radius * 2, radius * 2, radius * 2, 0, 100) ' Bottom-right corner
            path.AddArc(0, btnExitMainFrm.Height - radius * 2, radius * 2, radius * 2, 80, 80) ' Bottom-left corner
            btnExitMainFrm.Region = New Region(path)
        End If
    End Sub
End Class

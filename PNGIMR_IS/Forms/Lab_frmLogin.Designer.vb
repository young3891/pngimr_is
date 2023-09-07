<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lab_frmLogin
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
        Me.pnlPassword = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.TblDBUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Login_ds = New PNGIMR_IS.login_ds()
        Me.pnlUsername = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserCount = New System.Windows.Forms.Label()
        Me.lblEncryptPW = New System.Windows.Forms.Label()
        Me.TblDBUserTableAdapter = New PNGIMR_IS.login_dsTableAdapters.tblDBUserTableAdapter()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.pnlPassword.SuspendLayout()
        CType(Me.TblDBUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Login_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUsername.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPassword
        '
        Me.pnlPassword.BackColor = System.Drawing.Color.White
        Me.pnlPassword.Controls.Add(Me.txtPassword)
        Me.pnlPassword.Location = New System.Drawing.Point(82, 71)
        Me.pnlPassword.Name = "pnlPassword"
        Me.pnlPassword.Size = New System.Drawing.Size(200, 26)
        Me.pnlPassword.TabIndex = 5
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(11, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(177, 15)
        Me.txtPassword.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDBUserBindingSource, "u_name", True))
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(11, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(177, 15)
        Me.txtUsername.TabIndex = 0
        '
        'TblDBUserBindingSource
        '
        Me.TblDBUserBindingSource.DataMember = "tblDBUser"
        Me.TblDBUserBindingSource.DataSource = Me.Login_ds
        '
        'Login_ds
        '
        Me.Login_ds.DataSetName = "login_ds"
        Me.Login_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pnlUsername
        '
        Me.pnlUsername.BackColor = System.Drawing.Color.White
        Me.pnlUsername.Controls.Add(Me.txtUsername)
        Me.pnlUsername.Location = New System.Drawing.Point(82, 38)
        Me.pnlUsername.Name = "pnlUsername"
        Me.pnlUsername.Size = New System.Drawing.Size(200, 26)
        Me.pnlUsername.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblLogin)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 27)
        Me.Panel1.TabIndex = 6
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(119, 6)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(43, 15)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Login"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(6, 46)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(73, 13)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "User Name:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(9, 76)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(65, 13)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "Password:"
        '
        'lblUserCount
        '
        Me.lblUserCount.AutoSize = True
        Me.lblUserCount.ForeColor = System.Drawing.Color.White
        Me.lblUserCount.Location = New System.Drawing.Point(310, 84)
        Me.lblUserCount.Name = "lblUserCount"
        Me.lblUserCount.Size = New System.Drawing.Size(67, 13)
        Me.lblUserCount.TabIndex = 9
        Me.lblUserCount.Text = "lblUserCount"
        '
        'lblEncryptPW
        '
        Me.lblEncryptPW.AutoSize = True
        Me.lblEncryptPW.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDBUserBindingSource, "pw", True))
        Me.lblEncryptPW.ForeColor = System.Drawing.Color.White
        Me.lblEncryptPW.Location = New System.Drawing.Point(310, 104)
        Me.lblEncryptPW.Name = "lblEncryptPW"
        Me.lblEncryptPW.Size = New System.Drawing.Size(61, 13)
        Me.lblEncryptPW.TabIndex = 10
        Me.lblEncryptPW.Text = "EncryptPW"
        '
        'TblDBUserTableAdapter
        '
        Me.TblDBUserTableAdapter.ClearBeforeFill = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Image = Global.PNGIMR_IS.My.Resources.Resources.cancel_btn__1_
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(172, 104)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(64, 30)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnOK
        '
        Me.BtnOK.BackColor = System.Drawing.Color.Yellow
        Me.BtnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOK.Image = Global.PNGIMR_IS.My.Resources.Resources.ok_icon__1_
        Me.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOK.Location = New System.Drawing.Point(102, 104)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(64, 30)
        Me.BtnOK.TabIndex = 2
        Me.BtnOK.Text = "&OK"
        Me.BtnOK.UseVisualStyleBackColor = False
        '
        'Lab_frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(285, 158)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblEncryptPW)
        Me.Controls.Add(Me.lblUserCount)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlUsername)
        Me.Controls.Add(Me.pnlPassword)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lab_frmLogin"
        Me.Opacity = 0.7R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.pnlPassword.ResumeLayout(False)
        Me.pnlPassword.PerformLayout()
        CType(Me.TblDBUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Login_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUsername.ResumeLayout(False)
        Me.pnlUsername.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnOK As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents pnlPassword As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents pnlUsername As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents TblDBUserBindingSource As BindingSource
    Friend WithEvents Login_ds As login_ds
    Friend WithEvents TblDBUserTableAdapter As login_dsTableAdapters.tblDBUserTableAdapter
    Friend WithEvents lblUserCount As Label
    Friend WithEvents lblEncryptPW As Label
    Public WithEvents txtUsername As TextBox
End Class

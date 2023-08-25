<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.btnLabInventoryDatabase = New System.Windows.Forms.Button()
        Me.btnExitMainFrm = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblWelcomMessage = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLabInventoryDatabase
        '
        Me.btnLabInventoryDatabase.BackColor = System.Drawing.Color.Maroon
        Me.btnLabInventoryDatabase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLabInventoryDatabase.ForeColor = System.Drawing.Color.Yellow
        Me.btnLabInventoryDatabase.Location = New System.Drawing.Point(572, 64)
        Me.btnLabInventoryDatabase.Name = "btnLabInventoryDatabase"
        Me.btnLabInventoryDatabase.Size = New System.Drawing.Size(226, 53)
        Me.btnLabInventoryDatabase.TabIndex = 1
        Me.btnLabInventoryDatabase.Text = "LABORATORY ASSET MANAGEMENT"
        Me.btnLabInventoryDatabase.UseVisualStyleBackColor = False
        '
        'btnExitMainFrm
        '
        Me.btnExitMainFrm.BackColor = System.Drawing.Color.OrangeRed
        Me.btnExitMainFrm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExitMainFrm.ForeColor = System.Drawing.Color.White
        Me.btnExitMainFrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExitMainFrm.Location = New System.Drawing.Point(572, 123)
        Me.btnExitMainFrm.Name = "btnExitMainFrm"
        Me.btnExitMainFrm.Size = New System.Drawing.Size(226, 53)
        Me.btnExitMainFrm.TabIndex = 4
        Me.btnExitMainFrm.Text = "E&XIT"
        Me.btnExitMainFrm.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblWelcomMessage)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1624, 43)
        Me.Panel1.TabIndex = 5
        '
        'lblWelcomMessage
        '
        Me.lblWelcomMessage.AutoSize = True
        Me.lblWelcomMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomMessage.Location = New System.Drawing.Point(418, 9)
        Me.lblWelcomMessage.Name = "lblWelcomMessage"
        Me.lblWelcomMessage.Size = New System.Drawing.Size(667, 31)
        Me.lblWelcomMessage.TabIndex = 6
        Me.lblWelcomMessage.Text = "WELCOME TO PNGIMR INFORMATION SYSTEM"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1434, 775)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExitMainFrm)
        Me.Controls.Add(Me.btnLabInventoryDatabase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLabInventoryDatabase As Button
    Friend WithEvents btnExitMainFrm As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblWelcomMessage As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblUsername = New Label()
        lblPassword = New Label()
        lblRetype = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        txtRetype = New TextBox()
        btnSave = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(30, 26)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(75, 20)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(30, 62)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(104, 20)
        lblPassword.TabIndex = 1
        lblPassword.Text = "Password Baru"
        ' 
        ' lblRetype
        ' 
        lblRetype.AutoSize = True
        lblRetype.Location = New Point(33, 98)
        lblRetype.Name = "lblRetype"
        lblRetype.Size = New Size(71, 20)
        lblRetype.TabIndex = 2
        lblRetype.Text = "Ketik lagi"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(180, 26)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(227, 27)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(180, 60)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(227, 27)
        txtPassword.TabIndex = 4
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtRetype
        ' 
        txtRetype.Location = New Point(180, 93)
        txtRetype.Name = "txtRetype"
        txtRetype.Size = New Size(227, 27)
        txtRetype.TabIndex = 5
        txtRetype.UseSystemPasswordChar = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(180, 147)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 6
        btnSave.Text = "Simpan"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(313, 147)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 7
        btnClose.Text = "Tutup"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmProfil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(455, 210)
        Controls.Add(btnClose)
        Controls.Add(btnSave)
        Controls.Add(txtRetype)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblRetype)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        KeyPreview = True
        Name = "frmProfil"
        StartPosition = FormStartPosition.CenterParent
        Text = "SIParkir- Profil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblRetype As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtRetype As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
End Class

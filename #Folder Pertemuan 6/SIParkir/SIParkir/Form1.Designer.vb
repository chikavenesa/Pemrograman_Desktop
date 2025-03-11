<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        usernameLogin = New Label()
        passwordLogin = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' usernameLogin
        ' 
        usernameLogin.AutoSize = True
        usernameLogin.Location = New Point(34, 75)
        usernameLogin.Name = "usernameLogin"
        usernameLogin.Size = New Size(75, 20)
        usernameLogin.TabIndex = 0
        usernameLogin.Text = "Username"
        ' 
        ' passwordLogin
        ' 
        passwordLogin.AutoSize = True
        passwordLogin.Location = New Point(34, 123)
        passwordLogin.Name = "passwordLogin"
        passwordLogin.Size = New Size(70, 20)
        passwordLogin.TabIndex = 1
        passwordLogin.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(126, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(189, 20)
        Label3.TabIndex = 2
        Label3.Text = "Selamat Datang di SI Parkir"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(145, 75)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(238, 27)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(145, 120)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(238, 27)
        TextBox2.TabIndex = 4
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(145, 170)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 5
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(289, 170)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "Keluar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(445, 271)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(passwordLogin)
        Controls.Add(usernameLogin)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SI Parkir - Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents usernameLogin As Label
    Friend WithEvents passwordLogin As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class

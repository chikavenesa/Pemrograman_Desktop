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
        Panel1 = New Panel()
        Panel2 = New Panel()
        TextBox2 = New TextBox()
        txtInput = New TextBox()
        Panel3 = New Panel()
        CmdCubeRoot = New Button()
        CmdFactorial = New Button()
        CmdEqual = New Button()
        CmdAddition = New Button()
        CmdInverse = New Button()
        CmdSubtract = New Button()
        CmdSqrt = New Button()
        CmdMultiply = New Button()
        CmdPowerOf = New Button()
        CmdDivision = New Button()
        CmdDecimal = New Button()
        CmdSign = New Button()
        Cmd0 = New Button()
        Cmd3 = New Button()
        Cmd2 = New Button()
        Cmd1 = New Button()
        Cmd6 = New Button()
        Cmd5 = New Button()
        Cmd4 = New Button()
        Cmd9 = New Button()
        Cmd8 = New Button()
        cmdC = New Button()
        cmdBackspace = New Button()
        cmdCE = New Button()
        Cmd7 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(txtInput)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(330, 73)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TextBox2)
        Panel2.Location = New Point(8, 88)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(330, 73)
        Panel2.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 18F)
        TextBox2.Location = New Point(17, 13)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(295, 47)
        TextBox2.TabIndex = 1
        TextBox2.Text = "0"
        TextBox2.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtInput
        ' 
        txtInput.Font = New Font("Segoe UI", 18F)
        txtInput.Location = New Point(17, 13)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(295, 47)
        txtInput.TabIndex = 1
        txtInput.Text = "0"
        txtInput.TextAlign = HorizontalAlignment.Right
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(CmdCubeRoot)
        Panel3.Controls.Add(CmdFactorial)
        Panel3.Controls.Add(CmdEqual)
        Panel3.Controls.Add(CmdAddition)
        Panel3.Controls.Add(CmdInverse)
        Panel3.Controls.Add(CmdSubtract)
        Panel3.Controls.Add(CmdSqrt)
        Panel3.Controls.Add(CmdMultiply)
        Panel3.Controls.Add(CmdPowerOf)
        Panel3.Controls.Add(CmdDivision)
        Panel3.Controls.Add(CmdDecimal)
        Panel3.Controls.Add(CmdSign)
        Panel3.Controls.Add(Cmd0)
        Panel3.Controls.Add(Cmd3)
        Panel3.Controls.Add(Cmd2)
        Panel3.Controls.Add(Cmd1)
        Panel3.Controls.Add(Cmd6)
        Panel3.Controls.Add(Cmd5)
        Panel3.Controls.Add(Cmd4)
        Panel3.Controls.Add(Cmd9)
        Panel3.Controls.Add(Cmd8)
        Panel3.Controls.Add(cmdC)
        Panel3.Controls.Add(cmdBackspace)
        Panel3.Controls.Add(cmdCE)
        Panel3.Controls.Add(Cmd7)
        Panel3.Location = New Point(12, 103)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(335, 235)
        Panel3.TabIndex = 1
        ' 
        ' CmdCubeRoot
        ' 
        CmdCubeRoot.Font = New Font("Segoe UI", 11F)
        CmdCubeRoot.Location = New Point(266, 76)
        CmdCubeRoot.Name = "CmdCubeRoot"
        CmdCubeRoot.Size = New Size(49, 29)
        CmdCubeRoot.TabIndex = 25
        CmdCubeRoot.Text = "∛"
        CmdCubeRoot.UseVisualStyleBackColor = True
        ' 
        ' CmdFactorial
        ' 
        CmdFactorial.Location = New Point(227, 28)
        CmdFactorial.Name = "CmdFactorial"
        CmdFactorial.Size = New Size(40, 29)
        CmdFactorial.TabIndex = 24
        CmdFactorial.Text = "n!"
        CmdFactorial.UseVisualStyleBackColor = True
        ' 
        ' CmdEqual
        ' 
        CmdEqual.Location = New Point(220, 181)
        CmdEqual.Name = "CmdEqual"
        CmdEqual.Size = New Size(40, 29)
        CmdEqual.TabIndex = 23
        CmdEqual.Text = "="
        CmdEqual.UseVisualStyleBackColor = True
        ' 
        ' CmdAddition
        ' 
        CmdAddition.Location = New Point(174, 181)
        CmdAddition.Name = "CmdAddition"
        CmdAddition.Size = New Size(40, 29)
        CmdAddition.TabIndex = 22
        CmdAddition.Text = "+"
        CmdAddition.UseVisualStyleBackColor = True
        ' 
        ' CmdInverse
        ' 
        CmdInverse.Location = New Point(220, 146)
        CmdInverse.Name = "CmdInverse"
        CmdInverse.Size = New Size(40, 29)
        CmdInverse.TabIndex = 21
        CmdInverse.Text = "1/X"
        CmdInverse.UseVisualStyleBackColor = True
        ' 
        ' CmdSubtract
        ' 
        CmdSubtract.Location = New Point(174, 146)
        CmdSubtract.Name = "CmdSubtract"
        CmdSubtract.Size = New Size(40, 29)
        CmdSubtract.TabIndex = 20
        CmdSubtract.Text = "-"
        CmdSubtract.UseVisualStyleBackColor = True
        ' 
        ' CmdSqrt
        ' 
        CmdSqrt.Location = New Point(220, 111)
        CmdSqrt.Name = "CmdSqrt"
        CmdSqrt.Size = New Size(52, 29)
        CmdSqrt.TabIndex = 19
        CmdSqrt.Text = "SQRT"
        CmdSqrt.UseVisualStyleBackColor = True
        ' 
        ' CmdMultiply
        ' 
        CmdMultiply.Location = New Point(174, 111)
        CmdMultiply.Name = "CmdMultiply"
        CmdMultiply.Size = New Size(40, 29)
        CmdMultiply.TabIndex = 18
        CmdMultiply.Text = "*"
        CmdMultiply.UseVisualStyleBackColor = True
        ' 
        ' CmdPowerOf
        ' 
        CmdPowerOf.Location = New Point(220, 76)
        CmdPowerOf.Name = "CmdPowerOf"
        CmdPowerOf.Size = New Size(40, 29)
        CmdPowerOf.TabIndex = 17
        CmdPowerOf.Text = "X^"
        CmdPowerOf.UseVisualStyleBackColor = True
        ' 
        ' CmdDivision
        ' 
        CmdDivision.Location = New Point(174, 76)
        CmdDivision.Name = "CmdDivision"
        CmdDivision.Size = New Size(40, 29)
        CmdDivision.TabIndex = 16
        CmdDivision.Text = "/"
        CmdDivision.UseVisualStyleBackColor = True
        ' 
        ' CmdDecimal
        ' 
        CmdDecimal.Location = New Point(118, 181)
        CmdDecimal.Name = "CmdDecimal"
        CmdDecimal.Size = New Size(40, 29)
        CmdDecimal.TabIndex = 15
        CmdDecimal.Text = "."
        CmdDecimal.UseVisualStyleBackColor = True
        ' 
        ' CmdSign
        ' 
        CmdSign.Location = New Point(72, 181)
        CmdSign.Name = "CmdSign"
        CmdSign.Size = New Size(40, 29)
        CmdSign.TabIndex = 14
        CmdSign.Text = "+/-"
        CmdSign.UseVisualStyleBackColor = True
        ' 
        ' Cmd0
        ' 
        Cmd0.Location = New Point(26, 181)
        Cmd0.Name = "Cmd0"
        Cmd0.Size = New Size(40, 29)
        Cmd0.TabIndex = 13
        Cmd0.Text = "0"
        Cmd0.UseVisualStyleBackColor = True
        ' 
        ' Cmd3
        ' 
        Cmd3.Location = New Point(118, 146)
        Cmd3.Name = "Cmd3"
        Cmd3.Size = New Size(40, 29)
        Cmd3.TabIndex = 12
        Cmd3.Text = "3"
        Cmd3.UseVisualStyleBackColor = True
        ' 
        ' Cmd2
        ' 
        Cmd2.Location = New Point(72, 146)
        Cmd2.Name = "Cmd2"
        Cmd2.Size = New Size(40, 29)
        Cmd2.TabIndex = 11
        Cmd2.Text = "2"
        Cmd2.UseVisualStyleBackColor = True
        ' 
        ' Cmd1
        ' 
        Cmd1.Location = New Point(26, 146)
        Cmd1.Name = "Cmd1"
        Cmd1.Size = New Size(40, 29)
        Cmd1.TabIndex = 10
        Cmd1.Text = "1"
        Cmd1.UseVisualStyleBackColor = True
        ' 
        ' Cmd6
        ' 
        Cmd6.Location = New Point(118, 111)
        Cmd6.Name = "Cmd6"
        Cmd6.Size = New Size(40, 29)
        Cmd6.TabIndex = 9
        Cmd6.Text = "6"
        Cmd6.UseVisualStyleBackColor = True
        ' 
        ' Cmd5
        ' 
        Cmd5.Location = New Point(72, 111)
        Cmd5.Name = "Cmd5"
        Cmd5.Size = New Size(40, 29)
        Cmd5.TabIndex = 8
        Cmd5.Text = "5"
        Cmd5.UseVisualStyleBackColor = True
        ' 
        ' Cmd4
        ' 
        Cmd4.Location = New Point(26, 111)
        Cmd4.Name = "Cmd4"
        Cmd4.Size = New Size(40, 29)
        Cmd4.TabIndex = 7
        Cmd4.Text = "4"
        Cmd4.UseVisualStyleBackColor = True
        ' 
        ' Cmd9
        ' 
        Cmd9.Location = New Point(118, 76)
        Cmd9.Name = "Cmd9"
        Cmd9.Size = New Size(40, 29)
        Cmd9.TabIndex = 6
        Cmd9.Text = "9"
        Cmd9.UseVisualStyleBackColor = True
        ' 
        ' Cmd8
        ' 
        Cmd8.Location = New Point(72, 76)
        Cmd8.Name = "Cmd8"
        Cmd8.Size = New Size(40, 29)
        Cmd8.TabIndex = 5
        Cmd8.Text = "8"
        Cmd8.UseVisualStyleBackColor = True
        ' 
        ' cmdC
        ' 
        cmdC.Location = New Point(179, 28)
        cmdC.Name = "cmdC"
        cmdC.Size = New Size(44, 29)
        cmdC.TabIndex = 4
        cmdC.Text = "C"
        cmdC.UseVisualStyleBackColor = True
        ' 
        ' cmdBackspace
        ' 
        cmdBackspace.Location = New Point(26, 26)
        cmdBackspace.Name = "cmdBackspace"
        cmdBackspace.Size = New Size(94, 29)
        cmdBackspace.TabIndex = 2
        cmdBackspace.Text = "Backspace"
        cmdBackspace.UseVisualStyleBackColor = True
        ' 
        ' cmdCE
        ' 
        cmdCE.Location = New Point(132, 28)
        cmdCE.Name = "cmdCE"
        cmdCE.Size = New Size(44, 29)
        cmdCE.TabIndex = 3
        cmdCE.Text = "CE"
        cmdCE.UseVisualStyleBackColor = True
        ' 
        ' Cmd7
        ' 
        Cmd7.Location = New Point(26, 76)
        Cmd7.Name = "Cmd7"
        Cmd7.Size = New Size(40, 29)
        Cmd7.TabIndex = 4
        Cmd7.Text = "7"
        Cmd7.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(365, 355)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Calculator"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cmdBackspace As Button
    Friend WithEvents cmdCE As Button
    Friend WithEvents Cmd7 As Button
    Friend WithEvents cmdC As Button
    Friend WithEvents Cmd3 As Button
    Friend WithEvents Cmd2 As Button
    Friend WithEvents Cmd1 As Button
    Friend WithEvents Cmd6 As Button
    Friend WithEvents Cmd5 As Button
    Friend WithEvents Cmd4 As Button
    Friend WithEvents Cmd9 As Button
    Friend WithEvents Cmd8 As Button
    Friend WithEvents CmdDecimal As Button
    Friend WithEvents CmdSign As Button
    Friend WithEvents Cmd0 As Button
    Friend WithEvents CmdEqual As Button
    Friend WithEvents CmdAddition As Button
    Friend WithEvents CmdInverse As Button
    Friend WithEvents CmdSubtract As Button
    Friend WithEvents CmdSqrt As Button
    Friend WithEvents CmdMultiply As Button
    Friend WithEvents CmdPowerOf As Button
    Friend WithEvents CmdDivision As Button
    Friend WithEvents CmdFactorial As Button
    Friend WithEvents CmdCubeRoot As Button

End Class

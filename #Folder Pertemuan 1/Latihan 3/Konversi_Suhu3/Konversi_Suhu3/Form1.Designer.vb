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
        lblCelcius = New Label()
        txtCelcius = New TextBox()
        txtFahrenheit = New TextBox()
        txtKelvin = New TextBox()
        btnConvert = New Button()
        btnKeluar = New Button()
        txtReamur = New TextBox()
        SuspendLayout()
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Location = New Point(43, 22)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(55, 20)
        lblCelcius.TabIndex = 0
        lblCelcius.Text = "Celcius"
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(114, 19)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(125, 27)
        txtCelcius.TabIndex = 2
        ' 
        ' txtFahrenheit
        ' 
        txtFahrenheit.Location = New Point(43, 75)
        txtFahrenheit.Name = "txtFahrenheit"
        txtFahrenheit.Size = New Size(125, 27)
        txtFahrenheit.TabIndex = 3
        ' 
        ' txtKelvin
        ' 
        txtKelvin.Location = New Point(350, 75)
        txtKelvin.Name = "txtKelvin"
        txtKelvin.Size = New Size(125, 27)
        txtKelvin.TabIndex = 4
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(269, 22)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(94, 29)
        btnConvert.TabIndex = 5
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(381, 22)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 6
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' txtReamur
        ' 
        txtReamur.Location = New Point(201, 75)
        txtReamur.Name = "txtReamur"
        txtReamur.Size = New Size(125, 27)
        txtReamur.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(508, 130)
        Controls.Add(txtReamur)
        Controls.Add(btnKeluar)
        Controls.Add(btnConvert)
        Controls.Add(txtKelvin)
        Controls.Add(txtFahrenheit)
        Controls.Add(txtCelcius)
        Controls.Add(lblCelcius)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCelcius As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents txtKelvin As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txtReamur As TextBox

End Class

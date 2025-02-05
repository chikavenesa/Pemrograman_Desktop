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
        lblFahrenheit = New Label()
        lblKelvin = New Label()
        txtCelcius = New TextBox()
        btnConvert = New Button()
        btnKeluar = New Button()
        lblReamur = New Label()
        SuspendLayout()
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Location = New Point(41, 56)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(55, 20)
        lblCelcius.TabIndex = 0
        lblCelcius.Text = "Celcius"
        ' 
        ' lblFahrenheit
        ' 
        lblFahrenheit.AutoSize = True
        lblFahrenheit.Location = New Point(61, 125)
        lblFahrenheit.Name = "lblFahrenheit"
        lblFahrenheit.Size = New Size(77, 20)
        lblFahrenheit.TabIndex = 1
        lblFahrenheit.Text = "Fahrenheit"
        ' 
        ' lblKelvin
        ' 
        lblKelvin.AutoSize = True
        lblKelvin.Location = New Point(365, 125)
        lblKelvin.Name = "lblKelvin"
        lblKelvin.Size = New Size(49, 20)
        lblKelvin.TabIndex = 2
        lblKelvin.Text = "Kelvin"
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(125, 49)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(125, 27)
        txtCelcius.TabIndex = 3
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(303, 52)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(94, 29)
        btnConvert.TabIndex = 4
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(412, 52)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 5
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' lblReamur
        ' 
        lblReamur.AutoSize = True
        lblReamur.Location = New Point(234, 125)
        lblReamur.Name = "lblReamur"
        lblReamur.Size = New Size(60, 20)
        lblReamur.TabIndex = 6
        lblReamur.Text = "Reamur"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(568, 180)
        Controls.Add(lblReamur)
        Controls.Add(btnKeluar)
        Controls.Add(btnConvert)
        Controls.Add(txtCelcius)
        Controls.Add(lblKelvin)
        Controls.Add(lblFahrenheit)
        Controls.Add(lblCelcius)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCelcius As Label
    Friend WithEvents lblFahrenheit As Label
    Friend WithEvents lblKelvin As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents lblReamur As Label

End Class

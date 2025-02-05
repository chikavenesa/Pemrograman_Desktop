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
        btnConvert = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Location = New Point(29, 37)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(55, 20)
        lblCelcius.TabIndex = 0
        lblCelcius.Text = "Celcius"
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(130, 37)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(125, 27)
        txtCelcius.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(277, 37)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(94, 29)
        btnConvert.TabIndex = 2
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(392, 37)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 3
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(518, 134)
        Controls.Add(btnKeluar)
        Controls.Add(btnConvert)
        Controls.Add(txtCelcius)
        Controls.Add(lblCelcius)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCelcius As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnKeluar As Button

End Class

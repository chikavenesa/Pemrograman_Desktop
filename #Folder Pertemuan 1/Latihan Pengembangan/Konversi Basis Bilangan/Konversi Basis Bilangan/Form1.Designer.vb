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
        lblInputDesimal = New Label()
        txtInput = New TextBox()
        btnConvert = New Button()
        btnKeluar = New Button()
        lblBiner = New Label()
        lblOktal = New Label()
        lblDesimal = New Label()
        lblHeksa = New Label()
        txtBiner = New TextBox()
        txtOktal = New TextBox()
        txtDesimal = New TextBox()
        txtHeksa = New TextBox()
        SuspendLayout()
        ' 
        ' lblInputDesimal
        ' 
        lblInputDesimal.AutoSize = True
        lblInputDesimal.Location = New Point(13, 16)
        lblInputDesimal.Name = "lblInputDesimal"
        lblInputDesimal.Size = New Size(130, 20)
        lblInputDesimal.TabIndex = 0
        lblInputDesimal.Text = "Basis 10 (Desimal)"
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(148, 12)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(125, 27)
        txtInput.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(289, 11)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(94, 29)
        btnConvert.TabIndex = 2
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(389, 10)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 3
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' lblBiner
        ' 
        lblBiner.AutoSize = True
        lblBiner.Location = New Point(13, 65)
        lblBiner.Name = "lblBiner"
        lblBiner.Size = New Size(106, 20)
        lblBiner.TabIndex = 4
        lblBiner.Text = "Basis 2 (Biner) "
        ' 
        ' lblOktal
        ' 
        lblOktal.AutoSize = True
        lblOktal.Location = New Point(173, 65)
        lblOktal.Name = "lblOktal"
        lblOktal.Size = New Size(107, 20)
        lblOktal.TabIndex = 5
        lblOktal.Text = "Basis 8 (Oktal) "
        ' 
        ' lblDesimal
        ' 
        lblDesimal.AutoSize = True
        lblDesimal.Location = New Point(332, 65)
        lblDesimal.Name = "lblDesimal"
        lblDesimal.Size = New Size(134, 20)
        lblDesimal.TabIndex = 6
        lblDesimal.Text = "Basis 10 (Desimal) "
        ' 
        ' lblHeksa
        ' 
        lblHeksa.AutoSize = True
        lblHeksa.Location = New Point(493, 65)
        lblHeksa.Name = "lblHeksa"
        lblHeksa.Size = New Size(172, 20)
        lblHeksa.TabIndex = 7
        lblHeksa.Text = "Basis 16 (Heksadesimal) "
        ' 
        ' txtBiner
        ' 
        txtBiner.Location = New Point(16, 88)
        txtBiner.Name = "txtBiner"
        txtBiner.ReadOnly = True
        txtBiner.Size = New Size(125, 27)
        txtBiner.TabIndex = 8
        ' 
        ' txtOktal
        ' 
        txtOktal.Location = New Point(175, 88)
        txtOktal.Name = "txtOktal"
        txtOktal.ReadOnly = True
        txtOktal.Size = New Size(125, 27)
        txtOktal.TabIndex = 9
        ' 
        ' txtDesimal
        ' 
        txtDesimal.Location = New Point(337, 88)
        txtDesimal.Name = "txtDesimal"
        txtDesimal.ReadOnly = True
        txtDesimal.Size = New Size(125, 27)
        txtDesimal.TabIndex = 10
        ' 
        ' txtHeksa
        ' 
        txtHeksa.Location = New Point(497, 87)
        txtHeksa.Name = "txtHeksa"
        txtHeksa.ReadOnly = True
        txtHeksa.Size = New Size(125, 27)
        txtHeksa.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(718, 186)
        Controls.Add(txtHeksa)
        Controls.Add(txtDesimal)
        Controls.Add(txtOktal)
        Controls.Add(txtBiner)
        Controls.Add(lblHeksa)
        Controls.Add(lblDesimal)
        Controls.Add(lblOktal)
        Controls.Add(lblBiner)
        Controls.Add(btnKeluar)
        Controls.Add(btnConvert)
        Controls.Add(txtInput)
        Controls.Add(lblInputDesimal)
        Name = "Form1"
        Text = "Konversi Bilangan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblInputDesimal As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents lblBiner As Label
    Friend WithEvents lblOktal As Label
    Friend WithEvents lblDesimal As Label
    Friend WithEvents lblHeksa As Label
    Friend WithEvents txtBiner As TextBox
    Friend WithEvents txtOktal As TextBox
    Friend WithEvents txtDesimal As TextBox
    Friend WithEvents txtHeksa As TextBox

End Class

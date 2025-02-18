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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblJudul = New Label()
        Label2 = New Label()
        Label1 = New Label()
        cbJmlkursi = New ComboBox()
        txtJmltamu = New TextBox()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label7 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        PictureBox2 = New PictureBox()
        Label10 = New Label()
        NumericUpDown1 = New NumericUpDown()
        NumericUpDown2 = New NumericUpDown()
        Label11 = New Label()
        PictureBox3 = New PictureBox()
        Label12 = New Label()
        NumericUpDown3 = New NumericUpDown()
        Label13 = New Label()
        PictureBox4 = New PictureBox()
        NumericUpDown4 = New NumericUpDown()
        Label14 = New Label()
        PictureBox5 = New PictureBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.BackColor = Color.Transparent
        lblJudul.Font = New Font("Monotype Corsiva", 16F, FontStyle.Bold Or FontStyle.Italic)
        lblJudul.ForeColor = Color.Maroon
        lblJudul.Location = New Point(209, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(274, 33)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Reservasi Meja Restoran"
        lblJudul.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(30, 200)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 20)
        Label2.TabIndex = 1
        Label2.Text = "Jumlah Kursi Meja "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 244)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 20)
        Label1.TabIndex = 2
        Label1.Text = "Jumlah Tamu"
        ' 
        ' cbJmlkursi
        ' 
        cbJmlkursi.FormattingEnabled = True
        cbJmlkursi.Items.AddRange(New Object() {"1 Kursi", "2 Kursi", "4 Kursi", "6 Kursi", "8 Kursi", "10 Kursi"})
        cbJmlkursi.Location = New Point(179, 197)
        cbJmlkursi.Name = "cbJmlkursi"
        cbJmlkursi.Size = New Size(151, 28)
        cbJmlkursi.TabIndex = 3
        ' 
        ' txtJmltamu
        ' 
        txtJmltamu.Location = New Point(179, 241)
        txtJmltamu.Name = "txtJmltamu"
        txtJmltamu.Size = New Size(151, 27)
        txtJmltamu.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(31, 291)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 5
        Label3.Text = "Nomor Meja"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        ComboBox1.Location = New Point(179, 286)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(439, 74)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(188, 215)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(483, 51)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 20)
        Label4.TabIndex = 8
        Label4.Text = "Meja Tersedia"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        Label5.Location = New Point(470, 292)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 38)
        Label5.TabIndex = 9
        Label5.Text = "Merah = Reserved" & vbCrLf & "Hijau = Available"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(30, 54)
        Label6.Name = "Label6"
        Label6.Size = New Size(135, 20)
        Label6.TabIndex = 10
        Label6.Text = "Tanggal Reservasi"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(179, 54)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(151, 27)
        DateTimePicker1.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(32, 105)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 20)
        Label7.TabIndex = 13
        Label7.Text = "Nama Lengkap"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(179, 101)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 27)
        TextBox1.TabIndex = 14
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(179, 149)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(151, 27)
        TextBox2.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(32, 153)
        Label8.Name = "Label8"
        Label8.Size = New Size(118, 20)
        Label8.TabIndex = 15
        Label8.Text = "Nomor Telepon"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Monotype Corsiva", 16F, FontStyle.Bold Or FontStyle.Italic)
        Label9.ForeColor = Color.Maroon
        Label9.Location = New Point(17, 354)
        Label9.Name = "Label9"
        Label9.Size = New Size(245, 33)
        Label9.TabIndex = 17
        Label9.Text = "Recommended for You"
        Label9.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(27, 390)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(128, 103)
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(42, 496)
        Label10.Name = "Label10"
        Label10.Size = New Size(101, 20)
        Label10.TabIndex = 19
        Label10.Text = "Nasi Sepiring"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(58, 519)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(58, 27)
        NumericUpDown1.TabIndex = 20
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(216, 519)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(58, 27)
        NumericUpDown2.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(202, 496)
        Label11.Name = "Label11"
        Label11.Size = New Size(89, 20)
        Label11.TabIndex = 22
        Label11.Text = "Mie Neraka"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(185, 390)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(128, 103)
        PictureBox3.TabIndex = 21
        PictureBox3.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Monotype Corsiva", 16F, FontStyle.Bold Or FontStyle.Italic)
        Label12.ForeColor = Color.Maroon
        Label12.Location = New Point(375, 355)
        Label12.Name = "Label12"
        Label12.Size = New Size(125, 33)
        Label12.TabIndex = 24
        Label12.Text = "Best Seller"
        Label12.TextAlign = ContentAlignment.TopCenter
        ' 
        ' NumericUpDown3
        ' 
        NumericUpDown3.Location = New Point(411, 519)
        NumericUpDown3.Name = "NumericUpDown3"
        NumericUpDown3.Size = New Size(58, 27)
        NumericUpDown3.TabIndex = 27
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(397, 496)
        Label13.Name = "Label13"
        Label13.Size = New Size(94, 20)
        Label13.TabIndex = 26
        Label13.Text = "Nasi Kuning"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(380, 390)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(128, 103)
        PictureBox4.TabIndex = 25
        PictureBox4.TabStop = False
        ' 
        ' NumericUpDown4
        ' 
        NumericUpDown4.Location = New Point(569, 519)
        NumericUpDown4.Name = "NumericUpDown4"
        NumericUpDown4.Size = New Size(58, 27)
        NumericUpDown4.TabIndex = 30
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(573, 496)
        Label14.Name = "Label14"
        Label14.Size = New Size(50, 20)
        Label14.TabIndex = 29
        Label14.Text = "Ayam"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(538, 390)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(128, 103)
        PictureBox5.TabIndex = 28
        PictureBox5.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(572, 595)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 31
        Button1.Text = "Reservasi"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(696, 652)
        Controls.Add(Button1)
        Controls.Add(NumericUpDown4)
        Controls.Add(Label14)
        Controls.Add(PictureBox5)
        Controls.Add(NumericUpDown3)
        Controls.Add(Label13)
        Controls.Add(PictureBox4)
        Controls.Add(Label12)
        Controls.Add(NumericUpDown2)
        Controls.Add(Label11)
        Controls.Add(PictureBox3)
        Controls.Add(NumericUpDown1)
        Controls.Add(Label10)
        Controls.Add(PictureBox2)
        Controls.Add(Label9)
        Controls.Add(TextBox2)
        Controls.Add(Label8)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(txtJmltamu)
        Controls.Add(cbJmlkursi)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(lblJudul)
        DoubleBuffered = True
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reservasi Meja Resto"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbJmlkursi As ComboBox
    Friend WithEvents txtJmltamu As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button1 As Button

End Class

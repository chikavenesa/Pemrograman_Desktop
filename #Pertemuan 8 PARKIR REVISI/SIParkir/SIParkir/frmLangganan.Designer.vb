<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLangganan
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
        lblNama = New Label()
        lblNoPlat = New Label()
        lblExpired = New Label()
        lblBiaya = New Label()
        lblJenis = New Label()
        lblId = New Label()
        Label7 = New Label()
        txtNama = New TextBox()
        txtNoPlat = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        txtBiaya = New TextBox()
        cmbJenis = New ComboBox()
        btnTambah = New Button()
        btnHapus = New Button()
        btnEdit = New Button()
        DataGridView1 = New DataGridView()
        btnCancel = New Button()
        Id = New DataGridViewTextBoxColumn()
        NoPlat = New DataGridViewTextBoxColumn()
        NamaPemilik = New DataGridViewTextBoxColumn()
        Biaya = New DataGridViewTextBoxColumn()
        Jenis = New DataGridViewTextBoxColumn()
        Expired = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(30, 24)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(122, 20)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama Pelanggan"
        ' 
        ' lblNoPlat
        ' 
        lblNoPlat.AutoSize = True
        lblNoPlat.Location = New Point(30, 59)
        lblNoPlat.Name = "lblNoPlat"
        lblNoPlat.Size = New Size(85, 20)
        lblNoPlat.TabIndex = 1
        lblNoPlat.Text = "Nomor Plat"
        ' 
        ' lblExpired
        ' 
        lblExpired.AutoSize = True
        lblExpired.Location = New Point(30, 143)
        lblExpired.Name = "lblExpired"
        lblExpired.Size = New Size(111, 20)
        lblExpired.TabIndex = 2
        lblExpired.Text = "Berlaku Hingga"
        ' 
        ' lblBiaya
        ' 
        lblBiaya.AutoSize = True
        lblBiaya.Location = New Point(30, 98)
        lblBiaya.Name = "lblBiaya"
        lblBiaya.Size = New Size(114, 20)
        lblBiaya.TabIndex = 3
        lblBiaya.Text = "Tarif Langganan"
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(319, 63)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(40, 20)
        lblJenis.TabIndex = 4
        lblJenis.Text = "Jenis"
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Location = New Point(463, 27)
        lblId.Name = "lblId"
        lblId.Size = New Size(100, 20)
        lblId.TabIndex = 5
        lblId.Text = "ID Pelanggan:"
        lblId.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(30, 193)
        Label7.Name = "Label7"
        Label7.Size = New Size(219, 20)
        Label7.TabIndex = 6
        Label7.Text = "Kendaraan terdaftar langganan:"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(174, 24)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(283, 27)
        txtNama.TabIndex = 7
        ' 
        ' txtNoPlat
        ' 
        txtNoPlat.Location = New Point(174, 57)
        txtNoPlat.Name = "txtNoPlat"
        txtNoPlat.Size = New Size(121, 27)
        txtNoPlat.TabIndex = 8
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(177, 138)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 9
        ' 
        ' txtBiaya
        ' 
        txtBiaya.Location = New Point(174, 94)
        txtBiaya.Name = "txtBiaya"
        txtBiaya.Size = New Size(121, 27)
        txtBiaya.TabIndex = 10
        ' 
        ' cmbJenis
        ' 
        cmbJenis.FormattingEnabled = True
        cmbJenis.Items.AddRange(New Object() {"Motor", "Mobil", "Taxi/Umum", "Truk", "Sepeda"})
        cmbJenis.Location = New Point(374, 59)
        cmbJenis.Name = "cmbJenis"
        cmbJenis.Size = New Size(151, 28)
        cmbJenis.TabIndex = 11
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(454, 138)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 12
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(654, 137)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 13
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(554, 137)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(94, 29)
        btnEdit.TabIndex = 14
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Id, NoPlat, NamaPemilik, Biaya, Jenis, Expired})
        DataGridView1.Location = New Point(30, 216)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(718, 188)
        DataGridView1.TabIndex = 15
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(654, 432)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 16
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        btnCancel.Visible = False
        ' 
        ' Id
        ' 
        Id.HeaderText = "Id"
        Id.MinimumWidth = 6
        Id.Name = "Id"
        Id.Width = 125
        ' 
        ' NoPlat
        ' 
        NoPlat.HeaderText = "No Plat"
        NoPlat.MinimumWidth = 6
        NoPlat.Name = "NoPlat"
        NoPlat.Width = 125
        ' 
        ' NamaPemilik
        ' 
        NamaPemilik.HeaderText = "Nama Pemilik"
        NamaPemilik.MinimumWidth = 6
        NamaPemilik.Name = "NamaPemilik"
        NamaPemilik.Width = 125
        ' 
        ' Biaya
        ' 
        Biaya.HeaderText = "Biaya"
        Biaya.MinimumWidth = 6
        Biaya.Name = "Biaya"
        Biaya.Width = 125
        ' 
        ' Jenis
        ' 
        Jenis.HeaderText = "Jenis"
        Jenis.MinimumWidth = 6
        Jenis.Name = "Jenis"
        Jenis.Width = 125
        ' 
        ' Expired
        ' 
        Expired.HeaderText = "Expired"
        Expired.MinimumWidth = 6
        Expired.Name = "Expired"
        Expired.Width = 125
        ' 
        ' frmLangganan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 485)
        Controls.Add(btnCancel)
        Controls.Add(DataGridView1)
        Controls.Add(btnEdit)
        Controls.Add(btnHapus)
        Controls.Add(btnTambah)
        Controls.Add(cmbJenis)
        Controls.Add(txtBiaya)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtNoPlat)
        Controls.Add(txtNama)
        Controls.Add(Label7)
        Controls.Add(lblId)
        Controls.Add(lblJenis)
        Controls.Add(lblBiaya)
        Controls.Add(lblExpired)
        Controls.Add(lblNoPlat)
        Controls.Add(lblNama)
        KeyPreview = True
        Name = "frmLangganan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIParkir - Langganan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblNoPlat As Label
    Friend WithEvents lblExpired As Label
    Friend WithEvents lblBiaya As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblId As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents NoPlat As DataGridViewTextBoxColumn
    Friend WithEvents NamaPemilik As DataGridViewTextBoxColumn
    Friend WithEvents Biaya As DataGridViewTextBoxColumn
    Friend WithEvents Jenis As DataGridViewTextBoxColumn
    Friend WithEvents Expired As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtama
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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        SistemToolStripMenuItem = New ToolStripMenuItem()
        AturProfilToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        DaftarKendaraanToolStripMenuItem = New ToolStripMenuItem()
        LaporanPendapatanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem1 = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        lblInputPlat = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblInfoUser = New Label()
        lblTgl = New Label()
        Label8 = New Label()
        lblPlat = New Label()
        txtNoPlat = New TextBox()
        lblHarga = New Label()
        Label10 = New Label()
        DataGridView1 = New DataGridView()
        ColNoPlat = New DataGridViewTextBoxColumn()
        ColMasuk = New DataGridViewTextBoxColumn()
        ColKeluar = New DataGridViewTextBoxColumn()
        ColHarga = New DataGridViewTextBoxColumn()
        ColJenis = New DataGridViewTextBoxColumn()
        Id = New DataGridViewTextBoxColumn()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        pnlPlat = New Panel()
        pnlHarga = New Panel()
        pnlInput = New Panel()
        lblInfoJenis = New Label()
        lblJenis = New Label()
        pnlGrid = New Panel()
        lblTekan = New Label()
        lblJmlKendaraan = New Label()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        ContextMenuStrip1.SuspendLayout()
        pnlPlat.SuspendLayout()
        pnlHarga.SuspendLayout()
        pnlInput.SuspendLayout()
        pnlGrid.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SistemToolStripMenuItem, AdminToolStripMenuItem, BantuanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(706, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SistemToolStripMenuItem
        ' 
        SistemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AturProfilToolStripMenuItem, LogoutToolStripMenuItem})
        SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        SistemToolStripMenuItem.Size = New Size(67, 24)
        SistemToolStripMenuItem.Text = "Sistem"
        ' 
        ' AturProfilToolStripMenuItem
        ' 
        AturProfilToolStripMenuItem.Name = "AturProfilToolStripMenuItem"
        AturProfilToolStripMenuItem.Size = New Size(139, 26)
        AturProfilToolStripMenuItem.Text = "Profil"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(139, 26)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DaftarKendaraanToolStripMenuItem, LaporanPendapatanToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(67, 24)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' DaftarKendaraanToolStripMenuItem
        ' 
        DaftarKendaraanToolStripMenuItem.Name = "DaftarKendaraanToolStripMenuItem"
        DaftarKendaraanToolStripMenuItem.Size = New Size(240, 26)
        DaftarKendaraanToolStripMenuItem.Text = "Kendaraan Langganan"
        ' 
        ' LaporanPendapatanToolStripMenuItem
        ' 
        LaporanPendapatanToolStripMenuItem.Name = "LaporanPendapatanToolStripMenuItem"
        LaporanPendapatanToolStripMenuItem.Size = New Size(240, 26)
        LaporanPendapatanToolStripMenuItem.Text = "Laporan Pendapatan"
        ' 
        ' BantuanToolStripMenuItem
        ' 
        BantuanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BantuanToolStripMenuItem1, TentangToolStripMenuItem})
        BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        BantuanToolStripMenuItem.Size = New Size(77, 24)
        BantuanToolStripMenuItem.Text = "Bantuan"
        ' 
        ' BantuanToolStripMenuItem1
        ' 
        BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        BantuanToolStripMenuItem1.Size = New Size(146, 26)
        BantuanToolStripMenuItem1.Text = "Bantuan"
        ' 
        ' TentangToolStripMenuItem
        ' 
        TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        TentangToolStripMenuItem.Size = New Size(146, 26)
        TentangToolStripMenuItem.Text = "Tentang"
        ' 
        ' lblInputPlat
        ' 
        lblInputPlat.AutoSize = True
        lblInputPlat.Location = New Point(6, 11)
        lblInputPlat.Name = "lblInputPlat"
        lblInputPlat.Size = New Size(85, 20)
        lblInputPlat.TabIndex = 2
        lblInputPlat.Text = "Nomor Plat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 347)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 20)
        Label4.TabIndex = 4
        Label4.Text = "Biaya Parkir"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(363, 210)
        Label5.Name = "Label5"
        Label5.Size = New Size(185, 20)
        Label5.TabIndex = 5
        Label5.Text = "Kendaaraan sedang parkir:"
        ' 
        ' lblInfoUser
        ' 
        lblInfoUser.AutoSize = True
        lblInfoUser.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInfoUser.Location = New Point(17, 420)
        lblInfoUser.Name = "lblInfoUser"
        lblInfoUser.Size = New Size(87, 20)
        lblInfoUser.TabIndex = 6
        lblInfoUser.Text = "Informasi -"
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.Location = New Point(17, 446)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(64, 20)
        lblTgl.TabIndex = 7
        lblTgl.Text = "Tanggal:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(211, 446)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 20)
        Label8.TabIndex = 8
        Label8.Text = "Jam: 00:00:00"
        ' 
        ' lblPlat
        ' 
        lblPlat.AutoSize = True
        lblPlat.Font = New Font("Segoe UI", 72F)
        lblPlat.Location = New Point(3, 0)
        lblPlat.Name = "lblPlat"
        lblPlat.Size = New Size(697, 159)
        lblPlat.TabIndex = 1
        lblPlat.Text = "AB 1234 CD"
        ' 
        ' txtNoPlat
        ' 
        txtNoPlat.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNoPlat.Location = New Point(101, 5)
        txtNoPlat.Name = "txtNoPlat"
        txtNoPlat.Size = New Size(141, 34)
        txtNoPlat.TabIndex = 9
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHarga.Location = New Point(3, 4)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(79, 50)
        lblHarga.TabIndex = 13
        lblHarga.Text = "Rp."
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(17, 400)
        Label10.Name = "Label10"
        Label10.Size = New Size(327, 20)
        Label10.TabIndex = 14
        Label10.Text = "_____________________________________________________"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColNoPlat, ColMasuk, ColKeluar, ColHarga, ColJenis, Id})
        DataGridView1.ContextMenuStrip = ContextMenuStrip1
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(324, 263)
        DataGridView1.TabIndex = 15
        ' 
        ' ColNoPlat
        ' 
        ColNoPlat.HeaderText = "No Plat"
        ColNoPlat.MinimumWidth = 6
        ColNoPlat.Name = "ColNoPlat"
        ColNoPlat.Width = 125
        ' 
        ' ColMasuk
        ' 
        ColMasuk.HeaderText = "Masuk"
        ColMasuk.MinimumWidth = 6
        ColMasuk.Name = "ColMasuk"
        ColMasuk.Width = 125
        ' 
        ' ColKeluar
        ' 
        ColKeluar.HeaderText = "Keluar"
        ColKeluar.MinimumWidth = 6
        ColKeluar.Name = "ColKeluar"
        ColKeluar.Width = 125
        ' 
        ' ColHarga
        ' 
        ColHarga.HeaderText = "Harga"
        ColHarga.MinimumWidth = 6
        ColHarga.Name = "ColHarga"
        ColHarga.Width = 125
        ' 
        ' ColJenis
        ' 
        ColJenis.HeaderText = "Jenis"
        ColJenis.MinimumWidth = 6
        ColJenis.Name = "ColJenis"
        ColJenis.Width = 125
        ' 
        ' Id
        ' 
        Id.HeaderText = "Id"
        Id.MinimumWidth = 6
        Id.Name = "Id"
        Id.ReadOnly = True
        Id.Visible = False
        Id.Width = 125
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {DeleteToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(211, 56)
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(210, 24)
        DeleteToolStripMenuItem.Text = "Delete"
        ' 
        ' pnlPlat
        ' 
        pnlPlat.BorderStyle = BorderStyle.Fixed3D
        pnlPlat.Controls.Add(lblPlat)
        pnlPlat.Dock = DockStyle.Top
        pnlPlat.Location = New Point(0, 28)
        pnlPlat.Name = "pnlPlat"
        pnlPlat.Size = New Size(706, 164)
        pnlPlat.TabIndex = 22
        ' 
        ' pnlHarga
        ' 
        pnlHarga.BorderStyle = BorderStyle.Fixed3D
        pnlHarga.Controls.Add(lblHarga)
        pnlHarga.Location = New Point(117, 347)
        pnlHarga.Name = "pnlHarga"
        pnlHarga.Size = New Size(223, 63)
        pnlHarga.TabIndex = 23
        ' 
        ' pnlInput
        ' 
        pnlInput.BorderStyle = BorderStyle.Fixed3D
        pnlInput.Controls.Add(lblInfoJenis)
        pnlInput.Controls.Add(lblJenis)
        pnlInput.Controls.Add(txtNoPlat)
        pnlInput.Controls.Add(lblInputPlat)
        pnlInput.Location = New Point(17, 211)
        pnlInput.Name = "pnlInput"
        pnlInput.Size = New Size(323, 130)
        pnlInput.TabIndex = 24
        ' 
        ' lblInfoJenis
        ' 
        lblInfoJenis.AutoSize = True
        lblInfoJenis.Location = New Point(248, 12)
        lblInfoJenis.Name = "lblInfoJenis"
        lblInfoJenis.Size = New Size(0, 20)
        lblInfoJenis.TabIndex = 11
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(6, 48)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(224, 40)
        lblJenis.TabIndex = 10
        lblJenis.Text = "F1 - Motor, F2 - Mobil, F3 -Taksi, " & vbCrLf & "F4 - Sepeda, F5 - Bis/Truk"
        ' 
        ' pnlGrid
        ' 
        pnlGrid.AutoScroll = True
        pnlGrid.Controls.Add(DataGridView1)
        pnlGrid.Location = New Point(364, 234)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Size = New Size(324, 263)
        pnlGrid.TabIndex = 25
        ' 
        ' lblTekan
        ' 
        lblTekan.AutoSize = True
        lblTekan.Location = New Point(25, 313)
        lblTekan.Name = "lblTekan"
        lblTekan.Size = New Size(227, 20)
        lblTekan.TabIndex = 11
        lblTekan.Text = "Tekan Enter untuk Masuk / Keluar"
        ' 
        ' lblJmlKendaraan
        ' 
        lblJmlKendaraan.AutoSize = True
        lblJmlKendaraan.Location = New Point(20, 477)
        lblJmlKendaraan.Name = "lblJmlKendaraan"
        lblJmlKendaraan.Size = New Size(310, 20)
        lblJmlKendaraan.TabIndex = 26
        lblJmlKendaraan.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Sepeda, 0 Bis/Truk"
        ' 
        ' frmUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(706, 510)
        Controls.Add(lblJmlKendaraan)
        Controls.Add(lblTekan)
        Controls.Add(pnlGrid)
        Controls.Add(pnlInput)
        Controls.Add(pnlHarga)
        Controls.Add(pnlPlat)
        Controls.Add(Label10)
        Controls.Add(Label8)
        Controls.Add(lblTgl)
        Controls.Add(lblInfoUser)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(MenuStrip1)
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "frmUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIParkir - Form Utama"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ContextMenuStrip1.ResumeLayout(False)
        pnlPlat.ResumeLayout(False)
        pnlPlat.PerformLayout()
        pnlHarga.ResumeLayout(False)
        pnlHarga.PerformLayout()
        pnlInput.ResumeLayout(False)
        pnlInput.PerformLayout()
        pnlGrid.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AturProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaftarKendaraanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPendapatanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblInputPlat As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblInfoUser As Label
    Friend WithEvents lblTgl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPlat As Label
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents lblHarga As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlPlat As Panel
    Friend WithEvents pnlHarga As Panel
    Friend WithEvents pnlInput As Panel
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblTekan As Label
    Friend WithEvents lblJmlKendaraan As Label
    Friend WithEvents lblInfoJenis As Label
    Friend WithEvents ColNoPlat As DataGridViewTextBoxColumn
    Friend WithEvents ColMasuk As DataGridViewTextBoxColumn
    Friend WithEvents ColKeluar As DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As DataGridViewTextBoxColumn
    Friend WithEvents ColJenis As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
End Class

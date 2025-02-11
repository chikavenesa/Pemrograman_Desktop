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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        TimerWall = New Timer(components)
        FolderBrowserDialog1 = New FolderBrowserDialog()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        txtPath = New TextBox()
        lblPath = New Label()
        btnBrowse = New Button()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusReady = New ToolStripStatusLabel()
        ToolStripStatusCurrent = New ToolStripStatusLabel()
        TimerElapsed = New Timer(components)
        lblapaja = New Label()
        clbWallpaper = New CheckedListBox()
        cbPreview = New CheckBox()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        lblInterval = New Label()
        cbInterval = New ComboBox()
        btnRun = New Button()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, ToolStripMenuItem1, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(122, 26)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(119, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(122, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem1, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(133, 26)
        HelpToolStripMenuItem1.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(133, 26)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' TimerWall
        ' 
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(100, 43)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(567, 27)
        txtPath.TabIndex = 2
        ' 
        ' lblPath
        ' 
        lblPath.AutoSize = True
        lblPath.Location = New Point(11, 46)
        lblPath.Name = "lblPath"
        lblPath.Size = New Size(86, 20)
        lblPath.TabIndex = 3
        lblPath.Text = "Folder Path:"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(673, 43)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(32, 29)
        btnBrowse.TabIndex = 4
        btnBrowse.Text = "..."
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusReady, ToolStripStatusCurrent})
        StatusStrip1.Location = New Point(0, 424)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 26)
        StatusStrip1.TabIndex = 5
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusReady
        ' 
        ToolStripStatusReady.Name = "ToolStripStatusReady"
        ToolStripStatusReady.Size = New Size(53, 20)
        ToolStripStatusReady.Text = "Ready."
        ' 
        ' ToolStripStatusCurrent
        ' 
        ToolStripStatusCurrent.Name = "ToolStripStatusCurrent"
        ToolStripStatusCurrent.Size = New Size(170, 20)
        ToolStripStatusCurrent.Text = "Current wallpaper: none."
        ' 
        ' TimerElapsed
        ' 
        TimerElapsed.Interval = 1000
        ' 
        ' lblapaja
        ' 
        lblapaja.AutoSize = True
        lblapaja.Location = New Point(11, 82)
        lblapaja.Name = "lblapaja"
        lblapaja.Size = New Size(280, 20)
        lblapaja.TabIndex = 6
        lblapaja.Text = "Please select one or more pictures below"
        ' 
        ' clbWallpaper
        ' 
        clbWallpaper.FormattingEnabled = True
        clbWallpaper.Location = New Point(12, 105)
        clbWallpaper.Name = "clbWallpaper"
        clbWallpaper.Size = New Size(279, 290)
        clbWallpaper.TabIndex = 7
        ' 
        ' cbPreview
        ' 
        cbPreview.AutoSize = True
        cbPreview.Checked = True
        cbPreview.CheckState = CheckState.Checked
        cbPreview.Location = New Point(342, 82)
        cbPreview.Name = "cbPreview"
        cbPreview.Size = New Size(128, 24)
        cbPreview.TabIndex = 8
        cbPreview.Text = "Preview Image"
        cbPreview.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(342, 112)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(363, 215)
        Panel1.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(2, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(353, 205)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' lblInterval
        ' 
        lblInterval.AutoSize = True
        lblInterval.Location = New Point(337, 337)
        lblInterval.Name = "lblInterval"
        lblInterval.Size = New Size(61, 20)
        lblInterval.TabIndex = 10
        lblInterval.Text = "Interval:"
        ' 
        ' cbInterval
        ' 
        cbInterval.FormattingEnabled = True
        cbInterval.Items.AddRange(New Object() {"10", "30", "60"})
        cbInterval.Location = New Point(409, 333)
        cbInterval.Name = "cbInterval"
        cbInterval.Size = New Size(151, 28)
        cbInterval.TabIndex = 11
        cbInterval.Text = "Select First"
        ' 
        ' btnRun
        ' 
        btnRun.Location = New Point(606, 333)
        btnRun.Name = "btnRun"
        btnRun.Size = New Size(94, 29)
        btnRun.TabIndex = 12
        btnRun.Text = "Run!"
        btnRun.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRun)
        Controls.Add(cbInterval)
        Controls.Add(lblInterval)
        Controls.Add(Panel1)
        Controls.Add(cbPreview)
        Controls.Add(clbWallpaper)
        Controls.Add(lblapaja)
        Controls.Add(StatusStrip1)
        Controls.Add(btnBrowse)
        Controls.Add(lblPath)
        Controls.Add(txtPath)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Wallpaper Changer"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerWall As Timer
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtPath As TextBox
    Friend WithEvents lblPath As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusCurrent As ToolStripStatusLabel
    Friend WithEvents TimerElapsed As Timer
    Friend WithEvents lblapaja As Label
    Friend WithEvents clbWallpaper As CheckedListBox
    Friend WithEvents cbPreview As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblInterval As Label
    Friend WithEvents cbInterval As ComboBox
    Friend WithEvents btnRun As Button

End Class

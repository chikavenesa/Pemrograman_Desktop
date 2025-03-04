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
        FolderBrowserDialog1 = New FolderBrowserDialog()
        lblPath = New Label()
        txtPath = New TextBox()
        btnPath = New Button()
        lblExt = New Label()
        txtExt = New TextBox()
        lblOri = New Label()
        lblPreview = New Label()
        lvOri = New ListView()
        chFileName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chAttribute = New ColumnHeader()
        chCreated = New ColumnHeader()
        chAccessed = New ColumnHeader()
        chModified = New ColumnHeader()
        lvPreview = New ListView()
        chFileName2 = New ColumnHeader()
        chExtension2 = New ColumnHeader()
        chAttribute2 = New ColumnHeader()
        chCreated2 = New ColumnHeader()
        chAccessed2 = New ColumnHeader()
        chModified2 = New ColumnHeader()
        TabControl1 = New TabControl()
        TpFilename = New TabPage()
        cbCaseF = New ComboBox()
        txtWithThisF = New TextBox()
        txtRightCropNCharF = New TextBox()
        txtLeftCropNCharF = New TextBox()
        txtInsertAfterF = New TextBox()
        txtInsertBeforeF = New TextBox()
        txtReplaceThisF = New TextBox()
        txtReplaceWithF = New TextBox()
        lblWithThisF = New Label()
        lblCaseF = New Label()
        rbRightCropNCharF = New RadioButton()
        rbLeftCropNCharF = New RadioButton()
        rbInsertAfterF = New RadioButton()
        rbInsertBeforeF = New RadioButton()
        rbReplaceThisF = New RadioButton()
        rbReplaceWithF = New RadioButton()
        TpExtension = New TabPage()
        cbCaseE = New ComboBox()
        txtWithThisE = New TextBox()
        txtRightCropNCharE = New TextBox()
        txtLeftCropNCharE = New TextBox()
        txtInsertAfterE = New TextBox()
        txtInsertBeforeE = New TextBox()
        txtReplaceThisE = New TextBox()
        txtReplaceWithE = New TextBox()
        lblWithThisE = New Label()
        lblCaseE = New Label()
        rbRightCropNCharE = New RadioButton()
        rbLeftCropNCharE = New RadioButton()
        rbInsertAfterE = New RadioButton()
        rbInsertBeforeE = New RadioButton()
        rbReplaceThisE = New RadioButton()
        rbReplaceWithE = New RadioButton()
        TpAutoNumber = New TabPage()
        gbWith = New GroupBox()
        nudIncrementBy = New NumericUpDown()
        nudStartWithNumber = New NumericUpDown()
        lblIncrementBy = New Label()
        lblStartWithNumber = New Label()
        gbPlace = New GroupBox()
        rbBeforeFileName = New RadioButton()
        rbAfterFileName = New RadioButton()
        btnPreview = New Button()
        btnRename = New Button()
        btnUndo = New Button()
        TabControl1.SuspendLayout()
        TpFilename.SuspendLayout()
        TpExtension.SuspendLayout()
        TpAutoNumber.SuspendLayout()
        gbWith.SuspendLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).BeginInit()
        gbPlace.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblPath
        ' 
        lblPath.AutoSize = True
        lblPath.Location = New Point(10, 22)
        lblPath.Name = "lblPath"
        lblPath.Size = New Size(40, 20)
        lblPath.TabIndex = 0
        lblPath.Text = "Path:"
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(57, 20)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(663, 27)
        txtPath.TabIndex = 1
        ' 
        ' btnPath
        ' 
        btnPath.Location = New Point(726, 19)
        btnPath.Name = "btnPath"
        btnPath.Size = New Size(50, 29)
        btnPath.TabIndex = 2
        btnPath.Text = "..."
        btnPath.UseVisualStyleBackColor = True
        ' 
        ' lblExt
        ' 
        lblExt.AutoSize = True
        lblExt.Location = New Point(783, 23)
        lblExt.Name = "lblExt"
        lblExt.Size = New Size(59, 20)
        lblExt.TabIndex = 3
        lblExt.Text = "File Ext:"
        ' 
        ' txtExt
        ' 
        txtExt.Location = New Point(848, 19)
        txtExt.Name = "txtExt"
        txtExt.Size = New Size(74, 27)
        txtExt.TabIndex = 4
        txtExt.Text = "*.*"
        ' 
        ' lblOri
        ' 
        lblOri.AutoSize = True
        lblOri.Location = New Point(12, 55)
        lblOri.Name = "lblOri"
        lblOri.Size = New Size(92, 20)
        lblOri.TabIndex = 5
        lblOri.Text = "Original File:"
        ' 
        ' lblPreview
        ' 
        lblPreview.AutoSize = True
        lblPreview.Location = New Point(474, 55)
        lblPreview.Name = "lblPreview"
        lblPreview.Size = New Size(90, 20)
        lblPreview.TabIndex = 6
        lblPreview.Text = "Preview File:"
        ' 
        ' lvOri
        ' 
        lvOri.Columns.AddRange(New ColumnHeader() {chFileName, chExtension, chAttribute, chCreated, chAccessed, chModified})
        lvOri.GridLines = True
        lvOri.Location = New Point(12, 78)
        lvOri.Name = "lvOri"
        lvOri.Size = New Size(449, 121)
        lvOri.TabIndex = 7
        lvOri.UseCompatibleStateImageBehavior = False
        lvOri.View = View.Details
        ' 
        ' chFileName
        ' 
        chFileName.Text = "File Name"
        chFileName.Width = 100
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        chExtension.Width = 100
        ' 
        ' chAttribute
        ' 
        chAttribute.Text = "Attributes"
        chAttribute.Width = 100
        ' 
        ' chCreated
        ' 
        chCreated.Text = "Date Created"
        chCreated.Width = 100
        ' 
        ' chAccessed
        ' 
        chAccessed.Text = "Date Accessed"
        chAccessed.Width = 150
        ' 
        ' chModified
        ' 
        chModified.Text = "Date Modified"
        chModified.Width = 150
        ' 
        ' lvPreview
        ' 
        lvPreview.Columns.AddRange(New ColumnHeader() {chFileName2, chExtension2, chAttribute2, chCreated2, chAccessed2, chModified2})
        lvPreview.GridLines = True
        lvPreview.Location = New Point(475, 78)
        lvPreview.Name = "lvPreview"
        lvPreview.Size = New Size(449, 121)
        lvPreview.TabIndex = 8
        lvPreview.UseCompatibleStateImageBehavior = False
        lvPreview.View = View.Details
        ' 
        ' chFileName2
        ' 
        chFileName2.Text = "File Name"
        chFileName2.Width = 100
        ' 
        ' chExtension2
        ' 
        chExtension2.Text = "Extension"
        chExtension2.Width = 100
        ' 
        ' chAttribute2
        ' 
        chAttribute2.Text = "Attributes"
        chAttribute2.Width = 100
        ' 
        ' chCreated2
        ' 
        chCreated2.Text = "Date Created"
        chCreated2.Width = 100
        ' 
        ' chAccessed2
        ' 
        chAccessed2.Text = "Date Accessed"
        chAccessed2.Width = 150
        ' 
        ' chModified2
        ' 
        chModified2.Text = "Date Modified"
        chModified2.Width = 150
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TpFilename)
        TabControl1.Controls.Add(TpExtension)
        TabControl1.Controls.Add(TpAutoNumber)
        TabControl1.Location = New Point(10, 217)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(814, 187)
        TabControl1.TabIndex = 9
        ' 
        ' TpFilename
        ' 
        TpFilename.Controls.Add(cbCaseF)
        TpFilename.Controls.Add(txtWithThisF)
        TpFilename.Controls.Add(txtRightCropNCharF)
        TpFilename.Controls.Add(txtLeftCropNCharF)
        TpFilename.Controls.Add(txtInsertAfterF)
        TpFilename.Controls.Add(txtInsertBeforeF)
        TpFilename.Controls.Add(txtReplaceThisF)
        TpFilename.Controls.Add(txtReplaceWithF)
        TpFilename.Controls.Add(lblWithThisF)
        TpFilename.Controls.Add(lblCaseF)
        TpFilename.Controls.Add(rbRightCropNCharF)
        TpFilename.Controls.Add(rbLeftCropNCharF)
        TpFilename.Controls.Add(rbInsertAfterF)
        TpFilename.Controls.Add(rbInsertBeforeF)
        TpFilename.Controls.Add(rbReplaceThisF)
        TpFilename.Controls.Add(rbReplaceWithF)
        TpFilename.Location = New Point(4, 29)
        TpFilename.Name = "TpFilename"
        TpFilename.Padding = New Padding(3)
        TpFilename.Size = New Size(806, 154)
        TpFilename.TabIndex = 0
        TpFilename.Text = "Filename"
        TpFilename.UseVisualStyleBackColor = True
        ' 
        ' cbCaseF
        ' 
        cbCaseF.FormattingEnabled = True
        cbCaseF.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        cbCaseF.Location = New Point(528, 6)
        cbCaseF.Name = "cbCaseF"
        cbCaseF.Size = New Size(272, 28)
        cbCaseF.TabIndex = 15
        ' 
        ' txtWithThisF
        ' 
        txtWithThisF.Location = New Point(528, 41)
        txtWithThisF.Name = "txtWithThisF"
        txtWithThisF.ReadOnly = True
        txtWithThisF.Size = New Size(272, 27)
        txtWithThisF.TabIndex = 14
        ' 
        ' txtRightCropNCharF
        ' 
        txtRightCropNCharF.Location = New Point(611, 116)
        txtRightCropNCharF.Name = "txtRightCropNCharF"
        txtRightCropNCharF.ReadOnly = True
        txtRightCropNCharF.Size = New Size(189, 27)
        txtRightCropNCharF.TabIndex = 13
        ' 
        ' txtLeftCropNCharF
        ' 
        txtLeftCropNCharF.Location = New Point(156, 113)
        txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        txtLeftCropNCharF.ReadOnly = True
        txtLeftCropNCharF.Size = New Size(293, 27)
        txtLeftCropNCharF.TabIndex = 12
        ' 
        ' txtInsertAfterF
        ' 
        txtInsertAfterF.Location = New Point(567, 74)
        txtInsertAfterF.Name = "txtInsertAfterF"
        txtInsertAfterF.ReadOnly = True
        txtInsertAfterF.Size = New Size(233, 27)
        txtInsertAfterF.TabIndex = 11
        ' 
        ' txtInsertBeforeF
        ' 
        txtInsertBeforeF.Location = New Point(156, 75)
        txtInsertBeforeF.Name = "txtInsertBeforeF"
        txtInsertBeforeF.ReadOnly = True
        txtInsertBeforeF.Size = New Size(293, 27)
        txtInsertBeforeF.TabIndex = 10
        ' 
        ' txtReplaceThisF
        ' 
        txtReplaceThisF.Location = New Point(156, 42)
        txtReplaceThisF.Name = "txtReplaceThisF"
        txtReplaceThisF.ReadOnly = True
        txtReplaceThisF.Size = New Size(293, 27)
        txtReplaceThisF.TabIndex = 9
        ' 
        ' txtReplaceWithF
        ' 
        txtReplaceWithF.Location = New Point(156, 9)
        txtReplaceWithF.Name = "txtReplaceWithF"
        txtReplaceWithF.ReadOnly = True
        txtReplaceWithF.Size = New Size(293, 27)
        txtReplaceWithF.TabIndex = 8
        ' 
        ' lblWithThisF
        ' 
        lblWithThisF.AutoSize = True
        lblWithThisF.Location = New Point(455, 44)
        lblWithThisF.Name = "lblWithThisF"
        lblWithThisF.Size = New Size(67, 20)
        lblWithThisF.TabIndex = 7
        lblWithThisF.Text = "With this"
        ' 
        ' lblCaseF
        ' 
        lblCaseF.AutoSize = True
        lblCaseF.Location = New Point(461, 12)
        lblCaseF.Name = "lblCaseF"
        lblCaseF.Size = New Size(43, 20)
        lblCaseF.TabIndex = 6
        lblCaseF.Text = "Case:"
        ' 
        ' rbRightCropNCharF
        ' 
        rbRightCropNCharF.AutoSize = True
        rbRightCropNCharF.Location = New Point(462, 114)
        rbRightCropNCharF.Name = "rbRightCropNCharF"
        rbRightCropNCharF.Size = New Size(145, 24)
        rbRightCropNCharF.TabIndex = 5
        rbRightCropNCharF.Text = "Right Crop n char"
        rbRightCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' rbLeftCropNCharF
        ' 
        rbLeftCropNCharF.AutoSize = True
        rbLeftCropNCharF.Location = New Point(6, 116)
        rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        rbLeftCropNCharF.Size = New Size(135, 24)
        rbLeftCropNCharF.TabIndex = 4
        rbLeftCropNCharF.Text = "Left Crop n char"
        rbLeftCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' rbInsertAfterF
        ' 
        rbInsertAfterF.AutoSize = True
        rbInsertAfterF.Location = New Point(463, 78)
        rbInsertAfterF.Name = "rbInsertAfterF"
        rbInsertAfterF.Size = New Size(103, 24)
        rbInsertAfterF.TabIndex = 3
        rbInsertAfterF.Text = "Insert After"
        rbInsertAfterF.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeF
        ' 
        rbInsertBeforeF.AutoSize = True
        rbInsertBeforeF.Location = New Point(6, 79)
        rbInsertBeforeF.Name = "rbInsertBeforeF"
        rbInsertBeforeF.Size = New Size(114, 24)
        rbInsertBeforeF.TabIndex = 2
        rbInsertBeforeF.Text = "Insert Before"
        rbInsertBeforeF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisF
        ' 
        rbReplaceThisF.AutoSize = True
        rbReplaceThisF.Location = New Point(6, 45)
        rbReplaceThisF.Name = "rbReplaceThisF"
        rbReplaceThisF.Size = New Size(113, 24)
        rbReplaceThisF.TabIndex = 1
        rbReplaceThisF.Text = "Replace This"
        rbReplaceThisF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithF
        ' 
        rbReplaceWithF.AutoSize = True
        rbReplaceWithF.Location = New Point(6, 10)
        rbReplaceWithF.Name = "rbReplaceWithF"
        rbReplaceWithF.Size = New Size(118, 24)
        rbReplaceWithF.TabIndex = 0
        rbReplaceWithF.Text = "Replace With"
        rbReplaceWithF.UseVisualStyleBackColor = True
        ' 
        ' TpExtension
        ' 
        TpExtension.Controls.Add(cbCaseE)
        TpExtension.Controls.Add(txtWithThisE)
        TpExtension.Controls.Add(txtRightCropNCharE)
        TpExtension.Controls.Add(txtLeftCropNCharE)
        TpExtension.Controls.Add(txtInsertAfterE)
        TpExtension.Controls.Add(txtInsertBeforeE)
        TpExtension.Controls.Add(txtReplaceThisE)
        TpExtension.Controls.Add(txtReplaceWithE)
        TpExtension.Controls.Add(lblWithThisE)
        TpExtension.Controls.Add(lblCaseE)
        TpExtension.Controls.Add(rbRightCropNCharE)
        TpExtension.Controls.Add(rbLeftCropNCharE)
        TpExtension.Controls.Add(rbInsertAfterE)
        TpExtension.Controls.Add(rbInsertBeforeE)
        TpExtension.Controls.Add(rbReplaceThisE)
        TpExtension.Controls.Add(rbReplaceWithE)
        TpExtension.Location = New Point(4, 29)
        TpExtension.Name = "TpExtension"
        TpExtension.Padding = New Padding(3)
        TpExtension.Size = New Size(806, 154)
        TpExtension.TabIndex = 1
        TpExtension.Text = "Extension"
        TpExtension.UseVisualStyleBackColor = True
        ' 
        ' cbCaseE
        ' 
        cbCaseE.FormattingEnabled = True
        cbCaseE.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        cbCaseE.Location = New Point(528, 9)
        cbCaseE.Name = "cbCaseE"
        cbCaseE.Size = New Size(272, 28)
        cbCaseE.TabIndex = 31
        ' 
        ' txtWithThisE
        ' 
        txtWithThisE.Location = New Point(528, 44)
        txtWithThisE.Name = "txtWithThisE"
        txtWithThisE.ReadOnly = True
        txtWithThisE.Size = New Size(272, 27)
        txtWithThisE.TabIndex = 30
        ' 
        ' txtRightCropNCharE
        ' 
        txtRightCropNCharE.Location = New Point(611, 119)
        txtRightCropNCharE.Name = "txtRightCropNCharE"
        txtRightCropNCharE.ReadOnly = True
        txtRightCropNCharE.Size = New Size(189, 27)
        txtRightCropNCharE.TabIndex = 29
        ' 
        ' txtLeftCropNCharE
        ' 
        txtLeftCropNCharE.Location = New Point(156, 116)
        txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        txtLeftCropNCharE.ReadOnly = True
        txtLeftCropNCharE.Size = New Size(293, 27)
        txtLeftCropNCharE.TabIndex = 28
        ' 
        ' txtInsertAfterE
        ' 
        txtInsertAfterE.Location = New Point(567, 77)
        txtInsertAfterE.Name = "txtInsertAfterE"
        txtInsertAfterE.ReadOnly = True
        txtInsertAfterE.Size = New Size(233, 27)
        txtInsertAfterE.TabIndex = 27
        ' 
        ' txtInsertBeforeE
        ' 
        txtInsertBeforeE.Location = New Point(156, 78)
        txtInsertBeforeE.Name = "txtInsertBeforeE"
        txtInsertBeforeE.ReadOnly = True
        txtInsertBeforeE.Size = New Size(293, 27)
        txtInsertBeforeE.TabIndex = 26
        ' 
        ' txtReplaceThisE
        ' 
        txtReplaceThisE.Location = New Point(156, 45)
        txtReplaceThisE.Name = "txtReplaceThisE"
        txtReplaceThisE.ReadOnly = True
        txtReplaceThisE.Size = New Size(293, 27)
        txtReplaceThisE.TabIndex = 25
        ' 
        ' txtReplaceWithE
        ' 
        txtReplaceWithE.Location = New Point(156, 12)
        txtReplaceWithE.Name = "txtReplaceWithE"
        txtReplaceWithE.ReadOnly = True
        txtReplaceWithE.Size = New Size(293, 27)
        txtReplaceWithE.TabIndex = 24
        ' 
        ' lblWithThisE
        ' 
        lblWithThisE.AutoSize = True
        lblWithThisE.Location = New Point(455, 47)
        lblWithThisE.Name = "lblWithThisE"
        lblWithThisE.Size = New Size(67, 20)
        lblWithThisE.TabIndex = 23
        lblWithThisE.Text = "With this"
        ' 
        ' lblCaseE
        ' 
        lblCaseE.AutoSize = True
        lblCaseE.Location = New Point(461, 15)
        lblCaseE.Name = "lblCaseE"
        lblCaseE.Size = New Size(43, 20)
        lblCaseE.TabIndex = 22
        lblCaseE.Text = "Case:"
        ' 
        ' rbRightCropNCharE
        ' 
        rbRightCropNCharE.AutoSize = True
        rbRightCropNCharE.Location = New Point(462, 117)
        rbRightCropNCharE.Name = "rbRightCropNCharE"
        rbRightCropNCharE.Size = New Size(145, 24)
        rbRightCropNCharE.TabIndex = 21
        rbRightCropNCharE.Text = "Right Crop n char"
        rbRightCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' rbLeftCropNCharE
        ' 
        rbLeftCropNCharE.AutoSize = True
        rbLeftCropNCharE.Location = New Point(6, 119)
        rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        rbLeftCropNCharE.Size = New Size(135, 24)
        rbLeftCropNCharE.TabIndex = 20
        rbLeftCropNCharE.Text = "Left Crop n char"
        rbLeftCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' rbInsertAfterE
        ' 
        rbInsertAfterE.AutoSize = True
        rbInsertAfterE.Location = New Point(463, 81)
        rbInsertAfterE.Name = "rbInsertAfterE"
        rbInsertAfterE.Size = New Size(103, 24)
        rbInsertAfterE.TabIndex = 19
        rbInsertAfterE.Text = "Insert After"
        rbInsertAfterE.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeE
        ' 
        rbInsertBeforeE.AutoSize = True
        rbInsertBeforeE.Location = New Point(6, 82)
        rbInsertBeforeE.Name = "rbInsertBeforeE"
        rbInsertBeforeE.Size = New Size(114, 24)
        rbInsertBeforeE.TabIndex = 18
        rbInsertBeforeE.Text = "Insert Before"
        rbInsertBeforeE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisE
        ' 
        rbReplaceThisE.AutoSize = True
        rbReplaceThisE.Location = New Point(6, 48)
        rbReplaceThisE.Name = "rbReplaceThisE"
        rbReplaceThisE.Size = New Size(113, 24)
        rbReplaceThisE.TabIndex = 17
        rbReplaceThisE.Text = "Replace This"
        rbReplaceThisE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithE
        ' 
        rbReplaceWithE.AutoSize = True
        rbReplaceWithE.Location = New Point(6, 13)
        rbReplaceWithE.Name = "rbReplaceWithE"
        rbReplaceWithE.Size = New Size(118, 24)
        rbReplaceWithE.TabIndex = 16
        rbReplaceWithE.Text = "Replace With"
        rbReplaceWithE.UseVisualStyleBackColor = True
        ' 
        ' TpAutoNumber
        ' 
        TpAutoNumber.Controls.Add(gbWith)
        TpAutoNumber.Controls.Add(gbPlace)
        TpAutoNumber.Location = New Point(4, 29)
        TpAutoNumber.Name = "TpAutoNumber"
        TpAutoNumber.Size = New Size(806, 154)
        TpAutoNumber.TabIndex = 2
        TpAutoNumber.Text = "Autonumber"
        TpAutoNumber.UseVisualStyleBackColor = True
        ' 
        ' gbWith
        ' 
        gbWith.Controls.Add(nudIncrementBy)
        gbWith.Controls.Add(nudStartWithNumber)
        gbWith.Controls.Add(lblIncrementBy)
        gbWith.Controls.Add(lblStartWithNumber)
        gbWith.Location = New Point(414, 12)
        gbWith.Name = "gbWith"
        gbWith.Size = New Size(377, 125)
        gbWith.TabIndex = 1
        gbWith.TabStop = False
        gbWith.Text = "With"
        ' 
        ' nudIncrementBy
        ' 
        nudIncrementBy.Location = New Point(150, 58)
        nudIncrementBy.Name = "nudIncrementBy"
        nudIncrementBy.Size = New Size(150, 27)
        nudIncrementBy.TabIndex = 16
        nudIncrementBy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' nudStartWithNumber
        ' 
        nudStartWithNumber.Location = New Point(150, 20)
        nudStartWithNumber.Name = "nudStartWithNumber"
        nudStartWithNumber.Size = New Size(150, 27)
        nudStartWithNumber.TabIndex = 15
        nudStartWithNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblIncrementBy
        ' 
        lblIncrementBy.AutoSize = True
        lblIncrementBy.Location = New Point(10, 60)
        lblIncrementBy.Name = "lblIncrementBy"
        lblIncrementBy.Size = New Size(98, 20)
        lblIncrementBy.TabIndex = 14
        lblIncrementBy.Text = "Increment by:"
        ' 
        ' lblStartWithNumber
        ' 
        lblStartWithNumber.AutoSize = True
        lblStartWithNumber.Location = New Point(10, 22)
        lblStartWithNumber.Name = "lblStartWithNumber"
        lblStartWithNumber.Size = New Size(130, 20)
        lblStartWithNumber.TabIndex = 13
        lblStartWithNumber.Text = "Start with number:"
        ' 
        ' gbPlace
        ' 
        gbPlace.Controls.Add(rbBeforeFileName)
        gbPlace.Controls.Add(rbAfterFileName)
        gbPlace.Location = New Point(14, 11)
        gbPlace.Name = "gbPlace"
        gbPlace.Size = New Size(383, 125)
        gbPlace.TabIndex = 0
        gbPlace.TabStop = False
        gbPlace.Text = "Place:"
        ' 
        ' rbBeforeFileName
        ' 
        rbBeforeFileName.AutoSize = True
        rbBeforeFileName.Location = New Point(17, 56)
        rbBeforeFileName.Name = "rbBeforeFileName"
        rbBeforeFileName.Size = New Size(136, 24)
        rbBeforeFileName.TabIndex = 1
        rbBeforeFileName.TabStop = True
        rbBeforeFileName.Text = "Before filename"
        rbBeforeFileName.UseVisualStyleBackColor = True
        ' 
        ' rbAfterFileName
        ' 
        rbAfterFileName.AutoSize = True
        rbAfterFileName.Location = New Point(17, 26)
        rbAfterFileName.Name = "rbAfterFileName"
        rbAfterFileName.Size = New Size(125, 24)
        rbAfterFileName.TabIndex = 0
        rbAfterFileName.TabStop = True
        rbAfterFileName.Text = "After filename"
        rbAfterFileName.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Location = New Point(830, 220)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(94, 29)
        btnPreview.TabIndex = 10
        btnPreview.Text = "Preview"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnRename
        ' 
        btnRename.Location = New Point(830, 253)
        btnRename.Name = "btnRename"
        btnRename.Size = New Size(94, 29)
        btnRename.TabIndex = 11
        btnRename.Text = "Rename"
        btnRename.UseVisualStyleBackColor = True
        ' 
        ' btnUndo
        ' 
        btnUndo.Location = New Point(830, 286)
        btnUndo.Name = "btnUndo"
        btnUndo.Size = New Size(94, 29)
        btnUndo.TabIndex = 12
        btnUndo.Text = "Undo"
        btnUndo.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 410)
        Controls.Add(btnUndo)
        Controls.Add(btnRename)
        Controls.Add(btnPreview)
        Controls.Add(TabControl1)
        Controls.Add(lvPreview)
        Controls.Add(lvOri)
        Controls.Add(lblPreview)
        Controls.Add(lblOri)
        Controls.Add(txtExt)
        Controls.Add(lblExt)
        Controls.Add(btnPath)
        Controls.Add(txtPath)
        Controls.Add(lblPath)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mass Renamer"
        TabControl1.ResumeLayout(False)
        TpFilename.ResumeLayout(False)
        TpFilename.PerformLayout()
        TpExtension.ResumeLayout(False)
        TpExtension.PerformLayout()
        TpAutoNumber.ResumeLayout(False)
        gbWith.ResumeLayout(False)
        gbWith.PerformLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).EndInit()
        gbPlace.ResumeLayout(False)
        gbPlace.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblPath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents lblExt As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents lblOri As Label
    Friend WithEvents lblPreview As Label
    Friend WithEvents lvOri As ListView
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chAttribute As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents lvPreview As ListView
    Friend WithEvents chFileName2 As ColumnHeader
    Friend WithEvents chExtension2 As ColumnHeader
    Friend WithEvents chAttribute2 As ColumnHeader
    Friend WithEvents chCreated2 As ColumnHeader
    Friend WithEvents chAccessed2 As ColumnHeader
    Friend WithEvents chModified2 As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpFilename As TabPage
    Friend WithEvents TpExtension As TabPage
    Friend WithEvents TpAutoNumber As TabPage
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents rbInsertAfterF As RadioButton
    Friend WithEvents rbInsertBeforeF As RadioButton
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents rbReplaceWithF As RadioButton
    Friend WithEvents lblCaseF As Label
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents lblWithThisF As Label
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents lblWithThisE As Label
    Friend WithEvents lblCaseE As Label
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents rbInsertBeforeE As RadioButton
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents gbWith As GroupBox
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents rbAfterFileName As RadioButton
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents lblIncrementBy As Label
    Friend WithEvents lblStartWithNumber As Label

End Class

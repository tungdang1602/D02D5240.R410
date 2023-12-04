<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F3021
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F3021))
        Me.tdbcReportID1 = New C1.Win.C1List.C1Combo()
        Me.txtReportName = New System.Windows.Forms.TextBox()
        Me.txtReportCode = New System.Windows.Forms.TextBox()
        Me.lblReportCode = New System.Windows.Forms.Label()
        Me.lblReportID1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.chkShowStopDepreciation = New System.Windows.Forms.CheckBox()
        Me.tdbcTo_Period = New C1.Win.C1List.C1Combo()
        Me.tdbcFrom_Period = New C1.Win.C1List.C1Combo()
        Me.tdbcTo_AssetID = New C1.Win.C1List.C1Combo()
        Me.tdbcFrom_AssetID = New C1.Win.C1List.C1Combo()
        Me.tdbcTo_ObjectID = New C1.Win.C1List.C1Combo()
        Me.tdbcFrom_ObjectID = New C1.Win.C1List.C1Combo()
        Me.tdbcObjectTypeID = New C1.Win.C1List.C1Combo()
        Me.lblObjectTypeID = New System.Windows.Forms.Label()
        Me.txtObjectTypeName = New System.Windows.Forms.TextBox()
        Me.lblFrom_ObjectID = New System.Windows.Forms.Label()
        Me.lblFrom_AssetID = New System.Windows.Forms.Label()
        Me.lblFrom_Period = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnFiter = New System.Windows.Forms.Button()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.grpReport = New System.Windows.Forms.GroupBox()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.grpSelection = New System.Windows.Forms.GroupBox()
        Me.lblTimeInfo = New System.Windows.Forms.Label()
        Me.grpTimeInfo = New System.Windows.Forms.GroupBox()
        Me.chkPrintOffsetPeriod = New System.Windows.Forms.CheckBox()
        Me.chkAllAsset = New System.Windows.Forms.CheckBox()
        Me.lblDivisionID = New System.Windows.Forms.Label()
        Me.tdbcDivisionID = New C1.Win.C1List.C1Combo()
        Me.txtDivisionName = New System.Windows.Forms.TextBox()
        Me.grpDivisionID = New System.Windows.Forms.GroupBox()
        Me.lblGrpDivisionID = New System.Windows.Forms.Label()
        Me.chkShowAssetLiquidated = New System.Windows.Forms.CheckBox()
        CType(Me.tdbcReportID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcTo_Period, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcFrom_Period, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcTo_AssetID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcFrom_AssetID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcTo_ObjectID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcFrom_ObjectID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcObjectTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tdbcReportID1
        '
        Me.tdbcReportID1.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcReportID1.AllowColMove = False
        Me.tdbcReportID1.AllowColSelect = True
        Me.tdbcReportID1.AllowSort = False
        Me.tdbcReportID1.AlternatingRows = True
        Me.tdbcReportID1.AutoCompletion = True
        Me.tdbcReportID1.AutoDropDown = True
        Me.tdbcReportID1.Caption = ""
        Me.tdbcReportID1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcReportID1.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcReportID1.DisplayMember = "ReportID"
        Me.tdbcReportID1.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcReportID1.DropDownWidth = 500
        Me.tdbcReportID1.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcReportID1.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportID1.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcReportID1.EmptyRows = True
        Me.tdbcReportID1.ExtendRightColumn = True
        Me.tdbcReportID1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportID1.Images.Add(CType(resources.GetObject("tdbcReportID1.Images"), System.Drawing.Image))
        Me.tdbcReportID1.Location = New System.Drawing.Point(116, 114)
        Me.tdbcReportID1.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcReportID1.MaxDropDownItems = CType(8, Short)
        Me.tdbcReportID1.MaxLength = 20
        Me.tdbcReportID1.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcReportID1.Name = "tdbcReportID1"
        Me.tdbcReportID1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcReportID1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcReportID1.Size = New System.Drawing.Size(99, 21)
        Me.tdbcReportID1.TabIndex = 11
        Me.tdbcReportID1.ValueMember = "ReportID"
        Me.tdbcReportID1.PropBag = resources.GetString("tdbcReportID1.PropBag")
        '
        'txtReportName
        '
        Me.txtReportName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtReportName.Location = New System.Drawing.Point(221, 88)
        Me.txtReportName.MaxLength = 250
        Me.txtReportName.Name = "txtReportName"
        Me.txtReportName.ReadOnly = True
        Me.txtReportName.Size = New System.Drawing.Size(277, 20)
        Me.txtReportName.TabIndex = 9
        '
        'txtReportCode
        '
        Me.txtReportCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtReportCode.Location = New System.Drawing.Point(116, 88)
        Me.txtReportCode.MaxLength = 20
        Me.txtReportCode.Name = "txtReportCode"
        Me.txtReportCode.ReadOnly = True
        Me.txtReportCode.Size = New System.Drawing.Size(99, 20)
        Me.txtReportCode.TabIndex = 8
        '
        'lblReportCode
        '
        Me.lblReportCode.AutoSize = True
        Me.lblReportCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportCode.Location = New System.Drawing.Point(16, 92)
        Me.lblReportCode.Name = "lblReportCode"
        Me.lblReportCode.Size = New System.Drawing.Size(61, 13)
        Me.lblReportCode.TabIndex = 7
        Me.lblReportCode.Text = "Mẫu chuẩn"
        Me.lblReportCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReportID1
        '
        Me.lblReportID1.AutoSize = True
        Me.lblReportID1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportID1.Location = New System.Drawing.Point(16, 120)
        Me.lblReportID1.Name = "lblReportID1"
        Me.lblReportID1.Size = New System.Drawing.Size(45, 13)
        Me.lblReportID1.TabIndex = 10
        Me.lblReportID1.Text = "Đặc thù"
        Me.lblReportID1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTitle.Location = New System.Drawing.Point(221, 115)
        Me.txtTitle.MaxLength = 100
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(277, 20)
        Me.txtTitle.TabIndex = 12
        Me.txtTitle.TabStop = False
        '
        'chkShowStopDepreciation
        '
        Me.chkShowStopDepreciation.AutoSize = True
        Me.chkShowStopDepreciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowStopDepreciation.Location = New System.Drawing.Point(16, 263)
        Me.chkShowStopDepreciation.Name = "chkShowStopDepreciation"
        Me.chkShowStopDepreciation.Size = New System.Drawing.Size(210, 17)
        Me.chkShowStopDepreciation.TabIndex = 24
        Me.chkShowStopDepreciation.Text = "Hiển thị những tài sản ngưng khấu hao"
        Me.chkShowStopDepreciation.UseVisualStyleBackColor = True
        '
        'tdbcTo_Period
        '
        Me.tdbcTo_Period.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcTo_Period.AllowColMove = False
        Me.tdbcTo_Period.AllowSort = False
        Me.tdbcTo_Period.AlternatingRows = True
        Me.tdbcTo_Period.AutoCompletion = True
        Me.tdbcTo_Period.AutoDropDown = True
        Me.tdbcTo_Period.AutoSelect = True
        Me.tdbcTo_Period.Caption = ""
        Me.tdbcTo_Period.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcTo_Period.ColumnHeaders = False
        Me.tdbcTo_Period.ColumnWidth = 100
        Me.tdbcTo_Period.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcTo_Period.DisplayMember = "Period"
        Me.tdbcTo_Period.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcTo_Period.DropDownWidth = 128
        Me.tdbcTo_Period.EditorBackColor = System.Drawing.SystemColors.Info
        Me.tdbcTo_Period.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcTo_Period.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcTo_Period.EmptyRows = True
        Me.tdbcTo_Period.ExtendRightColumn = True
        Me.tdbcTo_Period.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcTo_Period.Images.Add(CType(resources.GetObject("tdbcTo_Period.Images"), System.Drawing.Image))
        Me.tdbcTo_Period.Location = New System.Drawing.Point(250, 388)
        Me.tdbcTo_Period.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcTo_Period.MaxDropDownItems = CType(8, Short)
        Me.tdbcTo_Period.MaxLength = 20
        Me.tdbcTo_Period.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcTo_Period.Name = "tdbcTo_Period"
        Me.tdbcTo_Period.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcTo_Period.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcTo_Period.Size = New System.Drawing.Size(128, 21)
        Me.tdbcTo_Period.TabIndex = 32
        Me.tdbcTo_Period.ValueMember = "Period"
        Me.tdbcTo_Period.PropBag = resources.GetString("tdbcTo_Period.PropBag")
        '
        'tdbcFrom_Period
        '
        Me.tdbcFrom_Period.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcFrom_Period.AllowColMove = False
        Me.tdbcFrom_Period.AllowSort = False
        Me.tdbcFrom_Period.AlternatingRows = True
        Me.tdbcFrom_Period.AutoCompletion = True
        Me.tdbcFrom_Period.AutoDropDown = True
        Me.tdbcFrom_Period.AutoSelect = True
        Me.tdbcFrom_Period.Caption = ""
        Me.tdbcFrom_Period.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcFrom_Period.ColumnHeaders = False
        Me.tdbcFrom_Period.ColumnWidth = 100
        Me.tdbcFrom_Period.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcFrom_Period.DisplayMember = "Period"
        Me.tdbcFrom_Period.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcFrom_Period.DropDownWidth = 128
        Me.tdbcFrom_Period.EditorBackColor = System.Drawing.SystemColors.Info
        Me.tdbcFrom_Period.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFrom_Period.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcFrom_Period.EmptyRows = True
        Me.tdbcFrom_Period.ExtendRightColumn = True
        Me.tdbcFrom_Period.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFrom_Period.Images.Add(CType(resources.GetObject("tdbcFrom_Period.Images"), System.Drawing.Image))
        Me.tdbcFrom_Period.Location = New System.Drawing.Point(116, 388)
        Me.tdbcFrom_Period.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcFrom_Period.MaxDropDownItems = CType(8, Short)
        Me.tdbcFrom_Period.MaxLength = 20
        Me.tdbcFrom_Period.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcFrom_Period.Name = "tdbcFrom_Period"
        Me.tdbcFrom_Period.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcFrom_Period.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcFrom_Period.Size = New System.Drawing.Size(128, 21)
        Me.tdbcFrom_Period.TabIndex = 31
        Me.tdbcFrom_Period.ValueMember = "Period"
        Me.tdbcFrom_Period.PropBag = resources.GetString("tdbcFrom_Period.PropBag")
        '
        'tdbcTo_AssetID
        '
        Me.tdbcTo_AssetID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcTo_AssetID.AllowColMove = False
        Me.tdbcTo_AssetID.AllowColSelect = True
        Me.tdbcTo_AssetID.AllowSort = False
        Me.tdbcTo_AssetID.AlternatingRows = True
        Me.tdbcTo_AssetID.AutoCompletion = True
        Me.tdbcTo_AssetID.AutoDropDown = True
        Me.tdbcTo_AssetID.AutoSelect = True
        Me.tdbcTo_AssetID.Caption = ""
        Me.tdbcTo_AssetID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcTo_AssetID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcTo_AssetID.DisplayMember = "AssetID"
        Me.tdbcTo_AssetID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcTo_AssetID.DropDownWidth = 500
        Me.tdbcTo_AssetID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcTo_AssetID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcTo_AssetID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcTo_AssetID.EmptyRows = True
        Me.tdbcTo_AssetID.ExtendRightColumn = True
        Me.tdbcTo_AssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcTo_AssetID.Images.Add(CType(resources.GetObject("tdbcTo_AssetID.Images"), System.Drawing.Image))
        Me.tdbcTo_AssetID.Location = New System.Drawing.Point(250, 229)
        Me.tdbcTo_AssetID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcTo_AssetID.MaxDropDownItems = CType(8, Short)
        Me.tdbcTo_AssetID.MaxLength = 20
        Me.tdbcTo_AssetID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcTo_AssetID.Name = "tdbcTo_AssetID"
        Me.tdbcTo_AssetID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcTo_AssetID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcTo_AssetID.Size = New System.Drawing.Size(128, 21)
        Me.tdbcTo_AssetID.TabIndex = 23
        Me.tdbcTo_AssetID.ValueMember = "AssetID"
        Me.tdbcTo_AssetID.PropBag = resources.GetString("tdbcTo_AssetID.PropBag")
        '
        'tdbcFrom_AssetID
        '
        Me.tdbcFrom_AssetID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcFrom_AssetID.AllowColMove = False
        Me.tdbcFrom_AssetID.AllowColSelect = True
        Me.tdbcFrom_AssetID.AllowSort = False
        Me.tdbcFrom_AssetID.AlternatingRows = True
        Me.tdbcFrom_AssetID.AutoCompletion = True
        Me.tdbcFrom_AssetID.AutoDropDown = True
        Me.tdbcFrom_AssetID.AutoSelect = True
        Me.tdbcFrom_AssetID.Caption = ""
        Me.tdbcFrom_AssetID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcFrom_AssetID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcFrom_AssetID.DisplayMember = "AssetID"
        Me.tdbcFrom_AssetID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcFrom_AssetID.DropDownWidth = 500
        Me.tdbcFrom_AssetID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcFrom_AssetID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFrom_AssetID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcFrom_AssetID.EmptyRows = True
        Me.tdbcFrom_AssetID.ExtendRightColumn = True
        Me.tdbcFrom_AssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFrom_AssetID.Images.Add(CType(resources.GetObject("tdbcFrom_AssetID.Images"), System.Drawing.Image))
        Me.tdbcFrom_AssetID.Location = New System.Drawing.Point(116, 229)
        Me.tdbcFrom_AssetID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcFrom_AssetID.MaxDropDownItems = CType(8, Short)
        Me.tdbcFrom_AssetID.MaxLength = 20
        Me.tdbcFrom_AssetID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcFrom_AssetID.Name = "tdbcFrom_AssetID"
        Me.tdbcFrom_AssetID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcFrom_AssetID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcFrom_AssetID.Size = New System.Drawing.Size(128, 21)
        Me.tdbcFrom_AssetID.TabIndex = 22
        Me.tdbcFrom_AssetID.ValueMember = "AssetID"
        Me.tdbcFrom_AssetID.PropBag = resources.GetString("tdbcFrom_AssetID.PropBag")
        '
        'tdbcTo_ObjectID
        '
        Me.tdbcTo_ObjectID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcTo_ObjectID.AllowColMove = False
        Me.tdbcTo_ObjectID.AllowColSelect = True
        Me.tdbcTo_ObjectID.AllowSort = False
        Me.tdbcTo_ObjectID.AlternatingRows = True
        Me.tdbcTo_ObjectID.AutoCompletion = True
        Me.tdbcTo_ObjectID.AutoDropDown = True
        Me.tdbcTo_ObjectID.Caption = ""
        Me.tdbcTo_ObjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcTo_ObjectID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcTo_ObjectID.DisplayMember = "ObjectID"
        Me.tdbcTo_ObjectID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcTo_ObjectID.DropDownWidth = 500
        Me.tdbcTo_ObjectID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcTo_ObjectID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcTo_ObjectID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcTo_ObjectID.EmptyRows = True
        Me.tdbcTo_ObjectID.ExtendRightColumn = True
        Me.tdbcTo_ObjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcTo_ObjectID.Images.Add(CType(resources.GetObject("tdbcTo_ObjectID.Images"), System.Drawing.Image))
        Me.tdbcTo_ObjectID.Location = New System.Drawing.Point(250, 200)
        Me.tdbcTo_ObjectID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcTo_ObjectID.MaxDropDownItems = CType(8, Short)
        Me.tdbcTo_ObjectID.MaxLength = 20
        Me.tdbcTo_ObjectID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcTo_ObjectID.Name = "tdbcTo_ObjectID"
        Me.tdbcTo_ObjectID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcTo_ObjectID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcTo_ObjectID.Size = New System.Drawing.Size(128, 21)
        Me.tdbcTo_ObjectID.TabIndex = 20
        Me.tdbcTo_ObjectID.ValueMember = "ObjectID"
        Me.tdbcTo_ObjectID.PropBag = resources.GetString("tdbcTo_ObjectID.PropBag")
        '
        'tdbcFrom_ObjectID
        '
        Me.tdbcFrom_ObjectID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcFrom_ObjectID.AllowColMove = False
        Me.tdbcFrom_ObjectID.AllowColSelect = True
        Me.tdbcFrom_ObjectID.AllowSort = False
        Me.tdbcFrom_ObjectID.AlternatingRows = True
        Me.tdbcFrom_ObjectID.AutoCompletion = True
        Me.tdbcFrom_ObjectID.AutoDropDown = True
        Me.tdbcFrom_ObjectID.Caption = ""
        Me.tdbcFrom_ObjectID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcFrom_ObjectID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcFrom_ObjectID.DisplayMember = "ObjectID"
        Me.tdbcFrom_ObjectID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcFrom_ObjectID.DropDownWidth = 500
        Me.tdbcFrom_ObjectID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcFrom_ObjectID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFrom_ObjectID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcFrom_ObjectID.EmptyRows = True
        Me.tdbcFrom_ObjectID.ExtendRightColumn = True
        Me.tdbcFrom_ObjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFrom_ObjectID.Images.Add(CType(resources.GetObject("tdbcFrom_ObjectID.Images"), System.Drawing.Image))
        Me.tdbcFrom_ObjectID.Location = New System.Drawing.Point(116, 200)
        Me.tdbcFrom_ObjectID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcFrom_ObjectID.MaxDropDownItems = CType(8, Short)
        Me.tdbcFrom_ObjectID.MaxLength = 20
        Me.tdbcFrom_ObjectID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcFrom_ObjectID.Name = "tdbcFrom_ObjectID"
        Me.tdbcFrom_ObjectID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcFrom_ObjectID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcFrom_ObjectID.Size = New System.Drawing.Size(128, 21)
        Me.tdbcFrom_ObjectID.TabIndex = 19
        Me.tdbcFrom_ObjectID.ValueMember = "ObjectID"
        Me.tdbcFrom_ObjectID.PropBag = resources.GetString("tdbcFrom_ObjectID.PropBag")
        '
        'tdbcObjectTypeID
        '
        Me.tdbcObjectTypeID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcObjectTypeID.AllowColMove = False
        Me.tdbcObjectTypeID.AllowSort = False
        Me.tdbcObjectTypeID.AlternatingRows = True
        Me.tdbcObjectTypeID.AutoCompletion = True
        Me.tdbcObjectTypeID.AutoDropDown = True
        Me.tdbcObjectTypeID.AutoSelect = True
        Me.tdbcObjectTypeID.Caption = ""
        Me.tdbcObjectTypeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcObjectTypeID.ColumnWidth = 100
        Me.tdbcObjectTypeID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcObjectTypeID.DisplayMember = "ObjectTypeID"
        Me.tdbcObjectTypeID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcObjectTypeID.DropDownWidth = 400
        Me.tdbcObjectTypeID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcObjectTypeID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcObjectTypeID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcObjectTypeID.EmptyRows = True
        Me.tdbcObjectTypeID.ExtendRightColumn = True
        Me.tdbcObjectTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcObjectTypeID.Images.Add(CType(resources.GetObject("tdbcObjectTypeID.Images"), System.Drawing.Image))
        Me.tdbcObjectTypeID.Location = New System.Drawing.Point(116, 172)
        Me.tdbcObjectTypeID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcObjectTypeID.MaxDropDownItems = CType(8, Short)
        Me.tdbcObjectTypeID.MaxLength = 20
        Me.tdbcObjectTypeID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcObjectTypeID.Name = "tdbcObjectTypeID"
        Me.tdbcObjectTypeID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcObjectTypeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcObjectTypeID.Size = New System.Drawing.Size(128, 21)
        Me.tdbcObjectTypeID.TabIndex = 16
        Me.tdbcObjectTypeID.ValueMember = "ObjectTypeID"
        Me.tdbcObjectTypeID.PropBag = resources.GetString("tdbcObjectTypeID.PropBag")
        '
        'lblObjectTypeID
        '
        Me.lblObjectTypeID.AutoSize = True
        Me.lblObjectTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObjectTypeID.Location = New System.Drawing.Point(16, 178)
        Me.lblObjectTypeID.Name = "lblObjectTypeID"
        Me.lblObjectTypeID.Size = New System.Drawing.Size(75, 13)
        Me.lblObjectTypeID.TabIndex = 15
        Me.lblObjectTypeID.Text = "Loại đối tượng"
        Me.lblObjectTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObjectTypeName
        '
        Me.txtObjectTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtObjectTypeName.Location = New System.Drawing.Point(251, 173)
        Me.txtObjectTypeName.MaxLength = 100
        Me.txtObjectTypeName.Name = "txtObjectTypeName"
        Me.txtObjectTypeName.ReadOnly = True
        Me.txtObjectTypeName.Size = New System.Drawing.Size(248, 20)
        Me.txtObjectTypeName.TabIndex = 17
        Me.txtObjectTypeName.TabStop = False
        '
        'lblFrom_ObjectID
        '
        Me.lblFrom_ObjectID.AutoSize = True
        Me.lblFrom_ObjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom_ObjectID.Location = New System.Drawing.Point(16, 205)
        Me.lblFrom_ObjectID.Name = "lblFrom_ObjectID"
        Me.lblFrom_ObjectID.Size = New System.Drawing.Size(53, 13)
        Me.lblFrom_ObjectID.TabIndex = 18
        Me.lblFrom_ObjectID.Text = "Đối tượng"
        Me.lblFrom_ObjectID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFrom_AssetID
        '
        Me.lblFrom_AssetID.AutoSize = True
        Me.lblFrom_AssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom_AssetID.Location = New System.Drawing.Point(16, 234)
        Me.lblFrom_AssetID.Name = "lblFrom_AssetID"
        Me.lblFrom_AssetID.Size = New System.Drawing.Size(42, 13)
        Me.lblFrom_AssetID.TabIndex = 21
        Me.lblFrom_AssetID.Text = "Tài sản"
        Me.lblFrom_AssetID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFrom_Period
        '
        Me.lblFrom_Period.AutoSize = True
        Me.lblFrom_Period.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom_Period.Location = New System.Drawing.Point(16, 393)
        Me.lblFrom_Period.Name = "lblFrom_Period"
        Me.lblFrom_Period.Size = New System.Drawing.Size(19, 13)
        Me.lblFrom_Period.TabIndex = 30
        Me.lblFrom_Period.Text = "Kỳ"
        Me.lblFrom_Period.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(259, 424)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(76, 22)
        Me.btnPrint.TabIndex = 33
        Me.btnPrint.Text = "&In"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(419, 424)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 22)
        Me.btnClose.TabIndex = 35
        Me.btnClose.Text = "Đó&ng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnFiter
        '
        Me.btnFiter.Location = New System.Drawing.Point(339, 424)
        Me.btnFiter.Name = "btnFiter"
        Me.btnFiter.Size = New System.Drawing.Size(76, 22)
        Me.btnFiter.TabIndex = 34
        Me.btnFiter.Text = "&Lọc"
        Me.btnFiter.UseVisualStyleBackColor = True
        '
        'lblReport
        '
        Me.lblReport.AutoSize = True
        Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.Location = New System.Drawing.Point(5, 64)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(81, 13)
        Me.lblReport.TabIndex = 5
        Me.lblReport.Text = "Mẫu báo cáo"
        Me.lblReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpReport
        '
        Me.grpReport.Location = New System.Drawing.Point(137, 69)
        Me.grpReport.Name = "grpReport"
        Me.grpReport.Size = New System.Drawing.Size(355, 3)
        Me.grpReport.TabIndex = 6
        Me.grpReport.TabStop = False
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelection.Location = New System.Drawing.Point(5, 149)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(82, 13)
        Me.lblSelection.TabIndex = 13
        Me.lblSelection.Text = "Tiêu thức lọc"
        Me.lblSelection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpSelection
        '
        Me.grpSelection.Location = New System.Drawing.Point(137, 154)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.Size = New System.Drawing.Size(355, 3)
        Me.grpSelection.TabIndex = 14
        Me.grpSelection.TabStop = False
        '
        'lblTimeInfo
        '
        Me.lblTimeInfo.AutoSize = True
        Me.lblTimeInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeInfo.Location = New System.Drawing.Point(5, 335)
        Me.lblTimeInfo.Name = "lblTimeInfo"
        Me.lblTimeInfo.Size = New System.Drawing.Size(114, 13)
        Me.lblTimeInfo.TabIndex = 27
        Me.lblTimeInfo.Text = "Thông tin thời gian"
        Me.lblTimeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpTimeInfo
        '
        Me.grpTimeInfo.Location = New System.Drawing.Point(137, 340)
        Me.grpTimeInfo.Name = "grpTimeInfo"
        Me.grpTimeInfo.Size = New System.Drawing.Size(355, 3)
        Me.grpTimeInfo.TabIndex = 28
        Me.grpTimeInfo.TabStop = False
        '
        'chkPrintOffsetPeriod
        '
        Me.chkPrintOffsetPeriod.AutoSize = True
        Me.chkPrintOffsetPeriod.Location = New System.Drawing.Point(16, 364)
        Me.chkPrintOffsetPeriod.Name = "chkPrintOffsetPeriod"
        Me.chkPrintOffsetPeriod.Size = New System.Drawing.Size(127, 17)
        Me.chkPrintOffsetPeriod.TabIndex = 29
        Me.chkPrintOffsetPeriod.Text = "In theo năm tài chính"
        Me.chkPrintOffsetPeriod.UseVisualStyleBackColor = True
        '
        'chkAllAsset
        '
        Me.chkAllAsset.AutoSize = True
        Me.chkAllAsset.Location = New System.Drawing.Point(16, 286)
        Me.chkAllAsset.Name = "chkAllAsset"
        Me.chkAllAsset.Size = New System.Drawing.Size(276, 17)
        Me.chkAllAsset.TabIndex = 25
        Me.chkAllAsset.Text = "Hiển thị tất cả tài sản chưa thanh lý của các kỳ trước"
        Me.chkAllAsset.UseVisualStyleBackColor = True
        '
        'lblDivisionID
        '
        Me.lblDivisionID.AutoSize = True
        Me.lblDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisionID.Location = New System.Drawing.Point(16, 33)
        Me.lblDivisionID.Name = "lblDivisionID"
        Me.lblDivisionID.Size = New System.Drawing.Size(38, 13)
        Me.lblDivisionID.TabIndex = 2
        Me.lblDivisionID.Text = "Đơn vị"
        Me.lblDivisionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tdbcDivisionID
        '
        Me.tdbcDivisionID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcDivisionID.AllowColMove = False
        Me.tdbcDivisionID.AllowColSelect = True
        Me.tdbcDivisionID.AllowSort = False
        Me.tdbcDivisionID.AlternatingRows = True
        Me.tdbcDivisionID.AutoCompletion = True
        Me.tdbcDivisionID.AutoDropDown = True
        Me.tdbcDivisionID.Caption = ""
        Me.tdbcDivisionID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcDivisionID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcDivisionID.DisplayMember = "DivisionID"
        Me.tdbcDivisionID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcDivisionID.DropDownWidth = 500
        Me.tdbcDivisionID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcDivisionID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbcDivisionID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcDivisionID.EmptyRows = True
        Me.tdbcDivisionID.ExtendRightColumn = True
        Me.tdbcDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbcDivisionID.Images.Add(CType(resources.GetObject("tdbcDivisionID.Images"), System.Drawing.Image))
        Me.tdbcDivisionID.Location = New System.Drawing.Point(116, 30)
        Me.tdbcDivisionID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcDivisionID.MaxDropDownItems = CType(8, Short)
        Me.tdbcDivisionID.MaxLength = 32767
        Me.tdbcDivisionID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcDivisionID.Name = "tdbcDivisionID"
        Me.tdbcDivisionID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcDivisionID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcDivisionID.Size = New System.Drawing.Size(128, 21)
        Me.tdbcDivisionID.TabIndex = 3
        Me.tdbcDivisionID.ValueMember = "DivisionID"
        Me.tdbcDivisionID.PropBag = resources.GetString("tdbcDivisionID.PropBag")
        '
        'txtDivisionName
        '
        Me.txtDivisionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivisionName.Location = New System.Drawing.Point(250, 30)
        Me.txtDivisionName.Name = "txtDivisionName"
        Me.txtDivisionName.ReadOnly = True
        Me.txtDivisionName.Size = New System.Drawing.Size(248, 20)
        Me.txtDivisionName.TabIndex = 4
        Me.txtDivisionName.TabStop = False
        '
        'grpDivisionID
        '
        Me.grpDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDivisionID.Location = New System.Drawing.Point(137, 12)
        Me.grpDivisionID.Name = "grpDivisionID"
        Me.grpDivisionID.Size = New System.Drawing.Size(363, 3)
        Me.grpDivisionID.TabIndex = 1
        Me.grpDivisionID.TabStop = False
        '
        'lblGrpDivisionID
        '
        Me.lblGrpDivisionID.AutoSize = True
        Me.lblGrpDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrpDivisionID.Location = New System.Drawing.Point(7, 7)
        Me.lblGrpDivisionID.Name = "lblGrpDivisionID"
        Me.lblGrpDivisionID.Size = New System.Drawing.Size(44, 13)
        Me.lblGrpDivisionID.TabIndex = 0
        Me.lblGrpDivisionID.Text = "Đơn vị"
        Me.lblGrpDivisionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkShowAssetLiquidated
        '
        Me.chkShowAssetLiquidated.AutoSize = True
        Me.chkShowAssetLiquidated.Location = New System.Drawing.Point(16, 309)
        Me.chkShowAssetLiquidated.Name = "chkShowAssetLiquidated"
        Me.chkShowAssetLiquidated.Size = New System.Drawing.Size(182, 17)
        Me.chkShowAssetLiquidated.TabIndex = 26
        Me.chkShowAssetLiquidated.Text = "Hiển thị tất cả tài sản đã thanh lý"
        Me.chkShowAssetLiquidated.UseVisualStyleBackColor = True
        '
        'D02F3021
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 454)
        Me.Controls.Add(Me.grpDivisionID)
        Me.Controls.Add(Me.lblGrpDivisionID)
        Me.Controls.Add(Me.lblDivisionID)
        Me.Controls.Add(Me.tdbcDivisionID)
        Me.Controls.Add(Me.txtDivisionName)
        Me.Controls.Add(Me.chkShowAssetLiquidated)
        Me.Controls.Add(Me.chkAllAsset)
        Me.Controls.Add(Me.chkPrintOffsetPeriod)
        Me.Controls.Add(Me.grpTimeInfo)
        Me.Controls.Add(Me.lblTimeInfo)
        Me.Controls.Add(Me.grpSelection)
        Me.Controls.Add(Me.chkShowStopDepreciation)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.tdbcTo_Period)
        Me.Controls.Add(Me.tdbcFrom_Period)
        Me.Controls.Add(Me.tdbcReportID1)
        Me.Controls.Add(Me.lblFrom_Period)
        Me.Controls.Add(Me.grpReport)
        Me.Controls.Add(Me.tdbcTo_AssetID)
        Me.Controls.Add(Me.txtReportName)
        Me.Controls.Add(Me.tdbcFrom_AssetID)
        Me.Controls.Add(Me.txtReportCode)
        Me.Controls.Add(Me.tdbcTo_ObjectID)
        Me.Controls.Add(Me.tdbcFrom_ObjectID)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.lblFrom_ObjectID)
        Me.Controls.Add(Me.lblReportCode)
        Me.Controls.Add(Me.lblFrom_AssetID)
        Me.Controls.Add(Me.tdbcObjectTypeID)
        Me.Controls.Add(Me.btnFiter)
        Me.Controls.Add(Me.lblObjectTypeID)
        Me.Controls.Add(Me.lblReportID1)
        Me.Controls.Add(Me.txtObjectTypeName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.btnPrint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F3021"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BÀo cÀo khÊu hao TSC˜ theo kù - D02F3021"
        CType(Me.tdbcReportID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcTo_Period, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcFrom_Period, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcTo_AssetID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcFrom_AssetID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcTo_ObjectID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcFrom_ObjectID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcObjectTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtReportName As System.Windows.Forms.TextBox
    Private WithEvents txtReportCode As System.Windows.Forms.TextBox
    Private WithEvents lblReportCode As System.Windows.Forms.Label
    Private WithEvents tdbcReportID1 As C1.Win.C1List.C1Combo
    Private WithEvents lblReportID1 As System.Windows.Forms.Label
    Private WithEvents txtTitle As System.Windows.Forms.TextBox
    Private WithEvents tdbcObjectTypeID As C1.Win.C1List.C1Combo
    Private WithEvents lblObjectTypeID As System.Windows.Forms.Label
    Private WithEvents txtObjectTypeName As System.Windows.Forms.TextBox
    Private WithEvents tdbcFrom_ObjectID As C1.Win.C1List.C1Combo
    Private WithEvents lblFrom_ObjectID As System.Windows.Forms.Label
    Private WithEvents tdbcTo_ObjectID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcTo_AssetID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcFrom_AssetID As C1.Win.C1List.C1Combo
    Private WithEvents lblFrom_AssetID As System.Windows.Forms.Label
    Private WithEvents tdbcFrom_Period As C1.Win.C1List.C1Combo
    Private WithEvents lblFrom_Period As System.Windows.Forms.Label
    Private WithEvents tdbcTo_Period As C1.Win.C1List.C1Combo
    Private WithEvents btnPrint As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnFiter As System.Windows.Forms.Button
    Private WithEvents chkShowStopDepreciation As System.Windows.Forms.CheckBox
    Private WithEvents lblReport As System.Windows.Forms.Label
    Private WithEvents grpReport As System.Windows.Forms.GroupBox
    Private WithEvents lblSelection As System.Windows.Forms.Label
    Private WithEvents grpSelection As System.Windows.Forms.GroupBox
    Private WithEvents lblTimeInfo As System.Windows.Forms.Label
    Private WithEvents grpTimeInfo As System.Windows.Forms.GroupBox
    Private WithEvents chkPrintOffsetPeriod As System.Windows.Forms.CheckBox
    Private WithEvents chkAllAsset As System.Windows.Forms.CheckBox
    Private WithEvents lblDivisionID As System.Windows.Forms.Label
    Private WithEvents tdbcDivisionID As C1.Win.C1List.C1Combo
    Private WithEvents txtDivisionName As System.Windows.Forms.TextBox
    Private WithEvents grpDivisionID As System.Windows.Forms.GroupBox
    Private WithEvents lblGrpDivisionID As System.Windows.Forms.Label
    Private WithEvents chkShowAssetLiquidated As System.Windows.Forms.CheckBox
End Class
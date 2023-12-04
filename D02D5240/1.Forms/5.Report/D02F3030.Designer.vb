<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F3030
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F3030))
        Me.grpReportForm = New System.Windows.Forms.GroupBox()
        Me.tdbcReportID = New C1.Win.C1List.C1Combo()
        Me.tdbcReportTypeID = New C1.Win.C1List.C1Combo()
        Me.lblReportTypeID = New System.Windows.Forms.Label()
        Me.txtReportTypeName = New System.Windows.Forms.TextBox()
        Me.lblReportID = New System.Windows.Forms.Label()
        Me.txtReportName = New System.Windows.Forms.TextBox()
        Me.grpConditionFilter = New System.Windows.Forms.GroupBox()
        Me.tdbcToPeriodID = New C1.Win.C1List.C1Combo()
        Me.tdbcFromperiodID = New C1.Win.C1List.C1Combo()
        Me.tdbcDivisionID = New C1.Win.C1List.C1Combo()
        Me.lblDivisionID = New System.Windows.Forms.Label()
        Me.txtDivisionName = New System.Windows.Forms.TextBox()
        Me.lblFromperiodID = New System.Windows.Forms.Label()
        Me.lblToPeriodID = New System.Windows.Forms.Label()
        Me.grpDataGroup = New System.Windows.Forms.GroupBox()
        Me.tdbcCode3 = New C1.Win.C1List.C1Combo()
        Me.tdbcCode2 = New C1.Win.C1List.C1Combo()
        Me.tdbcCode1 = New C1.Win.C1List.C1Combo()
        Me.lblCode1 = New System.Windows.Forms.Label()
        Me.lblCode2 = New System.Windows.Forms.Label()
        Me.lblCode3 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chkShowStopDepreciationAssets = New System.Windows.Forms.CheckBox()
        Me.grpReportForm.SuspendLayout()
        CType(Me.tdbcReportID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcReportTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConditionFilter.SuspendLayout()
        CType(Me.tdbcToPeriodID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcFromperiodID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDataGroup.SuspendLayout()
        CType(Me.tdbcCode3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcCode2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcCode1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpReportForm
        '
        Me.grpReportForm.Controls.Add(Me.tdbcReportID)
        Me.grpReportForm.Controls.Add(Me.tdbcReportTypeID)
        Me.grpReportForm.Controls.Add(Me.lblReportTypeID)
        Me.grpReportForm.Controls.Add(Me.txtReportTypeName)
        Me.grpReportForm.Controls.Add(Me.lblReportID)
        Me.grpReportForm.Controls.Add(Me.txtReportName)
        Me.grpReportForm.Location = New System.Drawing.Point(7, 2)
        Me.grpReportForm.Name = "grpReportForm"
        Me.grpReportForm.Size = New System.Drawing.Size(610, 83)
        Me.grpReportForm.TabIndex = 0
        Me.grpReportForm.TabStop = False
        Me.grpReportForm.Text = "Dạng báo cáo"
        '
        'tdbcReportID
        '
        Me.tdbcReportID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcReportID.AllowColMove = False
        Me.tdbcReportID.AllowSort = False
        Me.tdbcReportID.AlternatingRows = True
        Me.tdbcReportID.AutoCompletion = True
        Me.tdbcReportID.AutoDropDown = True
        Me.tdbcReportID.Caption = ""
        Me.tdbcReportID.CaptionHeight = 17
        Me.tdbcReportID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcReportID.ColumnCaptionHeight = 17
        Me.tdbcReportID.ColumnFooterHeight = 17
        Me.tdbcReportID.ColumnWidth = 100
        Me.tdbcReportID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcReportID.DisplayMember = "ReportID"
        Me.tdbcReportID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcReportID.DropDownWidth = 300
        Me.tdbcReportID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcReportID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcReportID.EmptyRows = True
        Me.tdbcReportID.ExtendRightColumn = True
        Me.tdbcReportID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportID.Images.Add(CType(resources.GetObject("tdbcReportID.Images"), System.Drawing.Image))
        Me.tdbcReportID.ItemHeight = 15
        Me.tdbcReportID.Location = New System.Drawing.Point(105, 49)
        Me.tdbcReportID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcReportID.MaxDropDownItems = CType(8, Short)
        Me.tdbcReportID.MaxLength = 32767
        Me.tdbcReportID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcReportID.Name = "tdbcReportID"
        Me.tdbcReportID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcReportID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcReportID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcReportID.TabIndex = 4
        Me.tdbcReportID.ValueMember = "ReportID"
        Me.tdbcReportID.PropBag = resources.GetString("tdbcReportID.PropBag")
        '
        'tdbcReportTypeID
        '
        Me.tdbcReportTypeID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcReportTypeID.AllowColMove = False
        Me.tdbcReportTypeID.AllowSort = False
        Me.tdbcReportTypeID.AlternatingRows = True
        Me.tdbcReportTypeID.AutoCompletion = True
        Me.tdbcReportTypeID.AutoDropDown = True
        Me.tdbcReportTypeID.AutoSelect = True
        Me.tdbcReportTypeID.Caption = ""
        Me.tdbcReportTypeID.CaptionHeight = 17
        Me.tdbcReportTypeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcReportTypeID.ColumnCaptionHeight = 17
        Me.tdbcReportTypeID.ColumnFooterHeight = 17
        Me.tdbcReportTypeID.ColumnWidth = 100
        Me.tdbcReportTypeID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcReportTypeID.DisplayMember = "ReportTypeID"
        Me.tdbcReportTypeID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcReportTypeID.DropDownWidth = 300
        Me.tdbcReportTypeID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcReportTypeID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportTypeID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcReportTypeID.EmptyRows = True
        Me.tdbcReportTypeID.ExtendRightColumn = True
        Me.tdbcReportTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcReportTypeID.Images.Add(CType(resources.GetObject("tdbcReportTypeID.Images"), System.Drawing.Image))
        Me.tdbcReportTypeID.ItemHeight = 15
        Me.tdbcReportTypeID.Location = New System.Drawing.Point(105, 19)
        Me.tdbcReportTypeID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcReportTypeID.MaxDropDownItems = CType(8, Short)
        Me.tdbcReportTypeID.MaxLength = 32767
        Me.tdbcReportTypeID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcReportTypeID.Name = "tdbcReportTypeID"
        Me.tdbcReportTypeID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcReportTypeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcReportTypeID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcReportTypeID.TabIndex = 1
        Me.tdbcReportTypeID.ValueMember = "ReportTypeID"
        Me.tdbcReportTypeID.PropBag = resources.GetString("tdbcReportTypeID.PropBag")
        '
        'lblReportTypeID
        '
        Me.lblReportTypeID.AutoSize = True
        Me.lblReportTypeID.Location = New System.Drawing.Point(12, 24)
        Me.lblReportTypeID.Name = "lblReportTypeID"
        Me.lblReportTypeID.Size = New System.Drawing.Size(61, 13)
        Me.lblReportTypeID.TabIndex = 0
        Me.lblReportTypeID.Text = "Mẫu chuẩn"
        Me.lblReportTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReportTypeName
        '
        Me.txtReportTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtReportTypeName.Location = New System.Drawing.Point(238, 19)
        Me.txtReportTypeName.Name = "txtReportTypeName"
        Me.txtReportTypeName.ReadOnly = True
        Me.txtReportTypeName.Size = New System.Drawing.Size(361, 22)
        Me.txtReportTypeName.TabIndex = 2
        Me.txtReportTypeName.TabStop = False
        '
        'lblReportID
        '
        Me.lblReportID.AutoSize = True
        Me.lblReportID.Location = New System.Drawing.Point(12, 54)
        Me.lblReportID.Name = "lblReportID"
        Me.lblReportID.Size = New System.Drawing.Size(45, 13)
        Me.lblReportID.TabIndex = 3
        Me.lblReportID.Text = "Đặc thù"
        Me.lblReportID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReportName
        '
        Me.txtReportName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtReportName.Location = New System.Drawing.Point(238, 49)
        Me.txtReportName.Name = "txtReportName"
        Me.txtReportName.ReadOnly = True
        Me.txtReportName.Size = New System.Drawing.Size(361, 22)
        Me.txtReportName.TabIndex = 5
        Me.txtReportName.TabStop = False
        '
        'grpConditionFilter
        '
        Me.grpConditionFilter.Controls.Add(Me.tdbcToPeriodID)
        Me.grpConditionFilter.Controls.Add(Me.tdbcFromperiodID)
        Me.grpConditionFilter.Controls.Add(Me.tdbcDivisionID)
        Me.grpConditionFilter.Controls.Add(Me.lblDivisionID)
        Me.grpConditionFilter.Controls.Add(Me.txtDivisionName)
        Me.grpConditionFilter.Controls.Add(Me.lblFromperiodID)
        Me.grpConditionFilter.Controls.Add(Me.lblToPeriodID)
        Me.grpConditionFilter.Location = New System.Drawing.Point(7, 88)
        Me.grpConditionFilter.Name = "grpConditionFilter"
        Me.grpConditionFilter.Size = New System.Drawing.Size(610, 87)
        Me.grpConditionFilter.TabIndex = 1
        Me.grpConditionFilter.TabStop = False
        Me.grpConditionFilter.Text = "Điều kiện lọc"
        '
        'tdbcToPeriodID
        '
        Me.tdbcToPeriodID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcToPeriodID.AllowColMove = False
        Me.tdbcToPeriodID.AllowSort = False
        Me.tdbcToPeriodID.AlternatingRows = True
        Me.tdbcToPeriodID.AutoCompletion = True
        Me.tdbcToPeriodID.AutoDropDown = True
        Me.tdbcToPeriodID.Caption = ""
        Me.tdbcToPeriodID.CaptionHeight = 17
        Me.tdbcToPeriodID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcToPeriodID.ColumnCaptionHeight = 17
        Me.tdbcToPeriodID.ColumnFooterHeight = 17
        Me.tdbcToPeriodID.ColumnHeaders = False
        Me.tdbcToPeriodID.ColumnWidth = 100
        Me.tdbcToPeriodID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcToPeriodID.DisplayMember = "Period"
        Me.tdbcToPeriodID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcToPeriodID.DropDownWidth = 128
        Me.tdbcToPeriodID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcToPeriodID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToPeriodID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcToPeriodID.EmptyRows = True
        Me.tdbcToPeriodID.ExtendRightColumn = True
        Me.tdbcToPeriodID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToPeriodID.Images.Add(CType(resources.GetObject("tdbcToPeriodID.Images"), System.Drawing.Image))
        Me.tdbcToPeriodID.ItemHeight = 15
        Me.tdbcToPeriodID.Location = New System.Drawing.Point(294, 51)
        Me.tdbcToPeriodID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcToPeriodID.MaxDropDownItems = CType(8, Short)
        Me.tdbcToPeriodID.MaxLength = 32767
        Me.tdbcToPeriodID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcToPeriodID.Name = "tdbcToPeriodID"
        Me.tdbcToPeriodID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcToPeriodID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcToPeriodID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcToPeriodID.TabIndex = 6
        Me.tdbcToPeriodID.ValueMember = "Period"
        Me.tdbcToPeriodID.PropBag = resources.GetString("tdbcToPeriodID.PropBag")
        '
        'tdbcFromperiodID
        '
        Me.tdbcFromperiodID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcFromperiodID.AllowColMove = False
        Me.tdbcFromperiodID.AllowSort = False
        Me.tdbcFromperiodID.AlternatingRows = True
        Me.tdbcFromperiodID.AutoCompletion = True
        Me.tdbcFromperiodID.AutoDropDown = True
        Me.tdbcFromperiodID.Caption = ""
        Me.tdbcFromperiodID.CaptionHeight = 17
        Me.tdbcFromperiodID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcFromperiodID.ColumnCaptionHeight = 17
        Me.tdbcFromperiodID.ColumnFooterHeight = 17
        Me.tdbcFromperiodID.ColumnHeaders = False
        Me.tdbcFromperiodID.ColumnWidth = 100
        Me.tdbcFromperiodID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcFromperiodID.DisplayMember = "Period"
        Me.tdbcFromperiodID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcFromperiodID.DropDownWidth = 128
        Me.tdbcFromperiodID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcFromperiodID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromperiodID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcFromperiodID.EmptyRows = True
        Me.tdbcFromperiodID.ExtendRightColumn = True
        Me.tdbcFromperiodID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromperiodID.Images.Add(CType(resources.GetObject("tdbcFromperiodID.Images"), System.Drawing.Image))
        Me.tdbcFromperiodID.ItemHeight = 15
        Me.tdbcFromperiodID.Location = New System.Drawing.Point(105, 51)
        Me.tdbcFromperiodID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcFromperiodID.MaxDropDownItems = CType(8, Short)
        Me.tdbcFromperiodID.MaxLength = 32767
        Me.tdbcFromperiodID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcFromperiodID.Name = "tdbcFromperiodID"
        Me.tdbcFromperiodID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcFromperiodID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcFromperiodID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcFromperiodID.TabIndex = 4
        Me.tdbcFromperiodID.ValueMember = "Period"
        Me.tdbcFromperiodID.PropBag = resources.GetString("tdbcFromperiodID.PropBag")
        '
        'tdbcDivisionID
        '
        Me.tdbcDivisionID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcDivisionID.AllowColMove = False
        Me.tdbcDivisionID.AllowSort = False
        Me.tdbcDivisionID.AlternatingRows = True
        Me.tdbcDivisionID.AutoCompletion = True
        Me.tdbcDivisionID.AutoDropDown = True
        Me.tdbcDivisionID.Caption = ""
        Me.tdbcDivisionID.CaptionHeight = 17
        Me.tdbcDivisionID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcDivisionID.ColumnCaptionHeight = 17
        Me.tdbcDivisionID.ColumnFooterHeight = 17
        Me.tdbcDivisionID.ColumnWidth = 100
        Me.tdbcDivisionID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcDivisionID.DisplayMember = "DivisionID"
        Me.tdbcDivisionID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcDivisionID.DropDownWidth = 300
        Me.tdbcDivisionID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcDivisionID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDivisionID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcDivisionID.EmptyRows = True
        Me.tdbcDivisionID.ExtendRightColumn = True
        Me.tdbcDivisionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDivisionID.Images.Add(CType(resources.GetObject("tdbcDivisionID.Images"), System.Drawing.Image))
        Me.tdbcDivisionID.ItemHeight = 15
        Me.tdbcDivisionID.Location = New System.Drawing.Point(105, 20)
        Me.tdbcDivisionID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcDivisionID.MaxDropDownItems = CType(8, Short)
        Me.tdbcDivisionID.MaxLength = 32767
        Me.tdbcDivisionID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcDivisionID.Name = "tdbcDivisionID"
        Me.tdbcDivisionID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcDivisionID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcDivisionID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcDivisionID.TabIndex = 1
        Me.tdbcDivisionID.ValueMember = "DivisionID"
        Me.tdbcDivisionID.PropBag = resources.GetString("tdbcDivisionID.PropBag")
        '
        'lblDivisionID
        '
        Me.lblDivisionID.AutoSize = True
        Me.lblDivisionID.Location = New System.Drawing.Point(12, 29)
        Me.lblDivisionID.Name = "lblDivisionID"
        Me.lblDivisionID.Size = New System.Drawing.Size(38, 13)
        Me.lblDivisionID.TabIndex = 0
        Me.lblDivisionID.Text = "Đơn vị"
        Me.lblDivisionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDivisionName
        '
        Me.txtDivisionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtDivisionName.Location = New System.Drawing.Point(238, 20)
        Me.txtDivisionName.Name = "txtDivisionName"
        Me.txtDivisionName.ReadOnly = True
        Me.txtDivisionName.Size = New System.Drawing.Size(361, 22)
        Me.txtDivisionName.TabIndex = 2
        Me.txtDivisionName.TabStop = False
        '
        'lblFromperiodID
        '
        Me.lblFromperiodID.AutoSize = True
        Me.lblFromperiodID.Location = New System.Drawing.Point(12, 56)
        Me.lblFromperiodID.Name = "lblFromperiodID"
        Me.lblFromperiodID.Size = New System.Drawing.Size(19, 13)
        Me.lblFromperiodID.TabIndex = 3
        Me.lblFromperiodID.Text = "Kỳ"
        Me.lblFromperiodID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblToPeriodID
        '
        Me.lblToPeriodID.AutoSize = True
        Me.lblToPeriodID.Location = New System.Drawing.Point(256, 58)
        Me.lblToPeriodID.Name = "lblToPeriodID"
        Me.lblToPeriodID.Size = New System.Drawing.Size(10, 13)
        Me.lblToPeriodID.TabIndex = 5
        Me.lblToPeriodID.Text = "-"
        Me.lblToPeriodID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpDataGroup
        '
        Me.grpDataGroup.Controls.Add(Me.tdbcCode3)
        Me.grpDataGroup.Controls.Add(Me.tdbcCode2)
        Me.grpDataGroup.Controls.Add(Me.tdbcCode1)
        Me.grpDataGroup.Controls.Add(Me.lblCode1)
        Me.grpDataGroup.Controls.Add(Me.lblCode2)
        Me.grpDataGroup.Controls.Add(Me.lblCode3)
        Me.grpDataGroup.Location = New System.Drawing.Point(7, 226)
        Me.grpDataGroup.Name = "grpDataGroup"
        Me.grpDataGroup.Size = New System.Drawing.Size(610, 46)
        Me.grpDataGroup.TabIndex = 2
        Me.grpDataGroup.TabStop = False
        Me.grpDataGroup.Text = "Nhóm dữ liệu"
        Me.grpDataGroup.Visible = False
        '
        'tdbcCode3
        '
        Me.tdbcCode3.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcCode3.AllowColMove = False
        Me.tdbcCode3.AllowSort = False
        Me.tdbcCode3.AlternatingRows = True
        Me.tdbcCode3.AutoCompletion = True
        Me.tdbcCode3.AutoDropDown = True
        Me.tdbcCode3.Caption = ""
        Me.tdbcCode3.CaptionHeight = 17
        Me.tdbcCode3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcCode3.ColumnCaptionHeight = 17
        Me.tdbcCode3.ColumnFooterHeight = 17
        Me.tdbcCode3.ColumnWidth = 100
        Me.tdbcCode3.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcCode3.DisplayMember = "Code"
        Me.tdbcCode3.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcCode3.DropDownWidth = 300
        Me.tdbcCode3.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcCode3.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCode3.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcCode3.EmptyRows = True
        Me.tdbcCode3.ExtendRightColumn = True
        Me.tdbcCode3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCode3.Images.Add(CType(resources.GetObject("tdbcCode3.Images"), System.Drawing.Image))
        Me.tdbcCode3.ItemHeight = 15
        Me.tdbcCode3.Location = New System.Drawing.Point(497, 25)
        Me.tdbcCode3.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcCode3.MaxDropDownItems = CType(8, Short)
        Me.tdbcCode3.MaxLength = 32767
        Me.tdbcCode3.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcCode3.Name = "tdbcCode3"
        Me.tdbcCode3.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcCode3.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcCode3.Size = New System.Drawing.Size(128, 23)
        Me.tdbcCode3.TabIndex = 5
        Me.tdbcCode3.ValueMember = "Code"
        Me.tdbcCode3.PropBag = resources.GetString("tdbcCode3.PropBag")
        '
        'tdbcCode2
        '
        Me.tdbcCode2.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcCode2.AllowColMove = False
        Me.tdbcCode2.AllowSort = False
        Me.tdbcCode2.AlternatingRows = True
        Me.tdbcCode2.AutoCompletion = True
        Me.tdbcCode2.AutoDropDown = True
        Me.tdbcCode2.Caption = ""
        Me.tdbcCode2.CaptionHeight = 17
        Me.tdbcCode2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcCode2.ColumnCaptionHeight = 17
        Me.tdbcCode2.ColumnFooterHeight = 17
        Me.tdbcCode2.ColumnWidth = 100
        Me.tdbcCode2.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcCode2.DisplayMember = "Code"
        Me.tdbcCode2.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcCode2.DropDownWidth = 300
        Me.tdbcCode2.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcCode2.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCode2.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcCode2.EmptyRows = True
        Me.tdbcCode2.ExtendRightColumn = True
        Me.tdbcCode2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCode2.Images.Add(CType(resources.GetObject("tdbcCode2.Images"), System.Drawing.Image))
        Me.tdbcCode2.ItemHeight = 15
        Me.tdbcCode2.Location = New System.Drawing.Point(294, 25)
        Me.tdbcCode2.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcCode2.MaxDropDownItems = CType(8, Short)
        Me.tdbcCode2.MaxLength = 32767
        Me.tdbcCode2.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcCode2.Name = "tdbcCode2"
        Me.tdbcCode2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcCode2.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcCode2.Size = New System.Drawing.Size(128, 23)
        Me.tdbcCode2.TabIndex = 3
        Me.tdbcCode2.ValueMember = "Code"
        Me.tdbcCode2.PropBag = resources.GetString("tdbcCode2.PropBag")
        '
        'tdbcCode1
        '
        Me.tdbcCode1.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcCode1.AllowColMove = False
        Me.tdbcCode1.AllowSort = False
        Me.tdbcCode1.AlternatingRows = True
        Me.tdbcCode1.AutoCompletion = True
        Me.tdbcCode1.AutoDropDown = True
        Me.tdbcCode1.Caption = ""
        Me.tdbcCode1.CaptionHeight = 17
        Me.tdbcCode1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcCode1.ColumnCaptionHeight = 17
        Me.tdbcCode1.ColumnFooterHeight = 17
        Me.tdbcCode1.ColumnWidth = 100
        Me.tdbcCode1.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcCode1.DisplayMember = "Code"
        Me.tdbcCode1.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcCode1.DropDownWidth = 300
        Me.tdbcCode1.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcCode1.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCode1.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcCode1.EmptyRows = True
        Me.tdbcCode1.ExtendRightColumn = True
        Me.tdbcCode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcCode1.Images.Add(CType(resources.GetObject("tdbcCode1.Images"), System.Drawing.Image))
        Me.tdbcCode1.ItemHeight = 15
        Me.tdbcCode1.Location = New System.Drawing.Point(105, 25)
        Me.tdbcCode1.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcCode1.MaxDropDownItems = CType(8, Short)
        Me.tdbcCode1.MaxLength = 32767
        Me.tdbcCode1.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcCode1.Name = "tdbcCode1"
        Me.tdbcCode1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcCode1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcCode1.Size = New System.Drawing.Size(128, 23)
        Me.tdbcCode1.TabIndex = 1
        Me.tdbcCode1.ValueMember = "Code"
        Me.tdbcCode1.PropBag = resources.GetString("tdbcCode1.PropBag")
        '
        'lblCode1
        '
        Me.lblCode1.AutoSize = True
        Me.lblCode1.Location = New System.Drawing.Point(16, 30)
        Me.lblCode1.Name = "lblCode1"
        Me.lblCode1.Size = New System.Drawing.Size(44, 13)
        Me.lblCode1.TabIndex = 0
        Me.lblCode1.Text = "Nhóm 1"
        Me.lblCode1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCode2
        '
        Me.lblCode2.AutoSize = True
        Me.lblCode2.Location = New System.Drawing.Point(239, 30)
        Me.lblCode2.Name = "lblCode2"
        Me.lblCode2.Size = New System.Drawing.Size(44, 13)
        Me.lblCode2.TabIndex = 2
        Me.lblCode2.Text = "Nhóm 2"
        Me.lblCode2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCode3
        '
        Me.lblCode3.AutoSize = True
        Me.lblCode3.Location = New System.Drawing.Point(434, 30)
        Me.lblCode3.Name = "lblCode3"
        Me.lblCode3.Size = New System.Drawing.Size(44, 13)
        Me.lblCode3.TabIndex = 4
        Me.lblCode3.Text = "Nhóm 3"
        Me.lblCode3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(459, 201)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(76, 22)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "&In"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(541, 201)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 22)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Đó&ng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkShowStopDepreciationAssets
        '
        Me.chkShowStopDepreciationAssets.AutoSize = True
        Me.chkShowStopDepreciationAssets.Location = New System.Drawing.Point(7, 185)
        Me.chkShowStopDepreciationAssets.Name = "chkShowStopDepreciationAssets"
        Me.chkShowStopDepreciationAssets.Size = New System.Drawing.Size(239, 17)
        Me.chkShowStopDepreciationAssets.TabIndex = 3
        Me.chkShowStopDepreciationAssets.Text = "Hiển thị các tài sản ngưng khấu hao trong kỳ"
        Me.chkShowStopDepreciationAssets.UseVisualStyleBackColor = True
        '
        'D02F3030
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 229)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.grpDataGroup)
        Me.Controls.Add(Me.grpConditionFilter)
        Me.Controls.Add(Me.chkShowStopDepreciationAssets)
        Me.Controls.Add(Me.grpReportForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F3030"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BÀo cÀo ph¡n bå khÊu hao - D02F3030"
        Me.grpReportForm.ResumeLayout(False)
        Me.grpReportForm.PerformLayout()
        CType(Me.tdbcReportID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcReportTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConditionFilter.ResumeLayout(False)
        Me.grpConditionFilter.PerformLayout()
        CType(Me.tdbcToPeriodID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcFromperiodID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcDivisionID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDataGroup.ResumeLayout(False)
        Me.grpDataGroup.PerformLayout()
        CType(Me.tdbcCode3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcCode2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcCode1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents grpReportForm As System.Windows.Forms.GroupBox
    Private WithEvents grpConditionFilter As System.Windows.Forms.GroupBox
    Private WithEvents grpDataGroup As System.Windows.Forms.GroupBox
    Private WithEvents tdbcReportTypeID As C1.Win.C1List.C1Combo
    Private WithEvents lblReportTypeID As System.Windows.Forms.Label
    Private WithEvents txtReportTypeName As System.Windows.Forms.TextBox
    Private WithEvents tdbcReportID As C1.Win.C1List.C1Combo
    Private WithEvents lblReportID As System.Windows.Forms.Label
    Private WithEvents txtReportName As System.Windows.Forms.TextBox
    Private WithEvents tdbcDivisionID As C1.Win.C1List.C1Combo
    Private WithEvents lblDivisionID As System.Windows.Forms.Label
    Private WithEvents txtDivisionName As System.Windows.Forms.TextBox
    Private WithEvents tdbcFromperiodID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcToPeriodID As C1.Win.C1List.C1Combo
    Private WithEvents lblFromperiodID As System.Windows.Forms.Label
    Private WithEvents lblToPeriodID As System.Windows.Forms.Label
    Private WithEvents tdbcCode3 As C1.Win.C1List.C1Combo
    Private WithEvents tdbcCode2 As C1.Win.C1List.C1Combo
    Private WithEvents tdbcCode1 As C1.Win.C1List.C1Combo
    Private WithEvents lblCode1 As System.Windows.Forms.Label
    Private WithEvents lblCode2 As System.Windows.Forms.Label
    Private WithEvents lblCode3 As System.Windows.Forms.Label
    Private WithEvents btnPrint As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents chkShowStopDepreciationAssets As System.Windows.Forms.CheckBox
End Class
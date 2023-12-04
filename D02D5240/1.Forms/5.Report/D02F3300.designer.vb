<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F3300
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F3300))
        Me.grpConditionFilter = New System.Windows.Forms.GroupBox()
        Me.tdbcToPeriodID = New C1.Win.C1List.C1Combo()
        Me.tdbcFromperiodID = New C1.Win.C1List.C1Combo()
        Me.lblFromperiodID = New System.Windows.Forms.Label()
        Me.lblToPeriodID = New System.Windows.Forms.Label()
        Me.grpReportForm = New System.Windows.Forms.GroupBox()
        Me.tdbcReportID = New C1.Win.C1List.C1Combo()
        Me.tdbcReportTypeID = New C1.Win.C1List.C1Combo()
        Me.lblReportTypeID = New System.Windows.Forms.Label()
        Me.txtReportTypeName = New System.Windows.Forms.TextBox()
        Me.lblReportID = New System.Windows.Forms.Label()
        Me.txtReportName = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpConditionFilter.SuspendLayout()
        CType(Me.tdbcToPeriodID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcFromperiodID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpReportForm.SuspendLayout()
        CType(Me.tdbcReportID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcReportTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpConditionFilter
        '
        Me.grpConditionFilter.Controls.Add(Me.tdbcToPeriodID)
        Me.grpConditionFilter.Controls.Add(Me.tdbcFromperiodID)
        Me.grpConditionFilter.Controls.Add(Me.lblFromperiodID)
        Me.grpConditionFilter.Controls.Add(Me.lblToPeriodID)
        Me.grpConditionFilter.Location = New System.Drawing.Point(7, 90)
        Me.grpConditionFilter.Name = "grpConditionFilter"
        Me.grpConditionFilter.Size = New System.Drawing.Size(609, 60)
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
        Me.tdbcToPeriodID.Location = New System.Drawing.Point(294, 20)
        Me.tdbcToPeriodID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcToPeriodID.MaxDropDownItems = CType(8, Short)
        Me.tdbcToPeriodID.MaxLength = 32767
        Me.tdbcToPeriodID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcToPeriodID.Name = "tdbcToPeriodID"
        Me.tdbcToPeriodID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcToPeriodID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcToPeriodID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcToPeriodID.TabIndex = 3
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
        Me.tdbcFromperiodID.Location = New System.Drawing.Point(105, 20)
        Me.tdbcFromperiodID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcFromperiodID.MaxDropDownItems = CType(8, Short)
        Me.tdbcFromperiodID.MaxLength = 32767
        Me.tdbcFromperiodID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcFromperiodID.Name = "tdbcFromperiodID"
        Me.tdbcFromperiodID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcFromperiodID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcFromperiodID.Size = New System.Drawing.Size(128, 23)
        Me.tdbcFromperiodID.TabIndex = 1
        Me.tdbcFromperiodID.ValueMember = "Period"
        Me.tdbcFromperiodID.PropBag = resources.GetString("tdbcFromperiodID.PropBag")
        '
        'lblFromperiodID
        '
        Me.lblFromperiodID.AutoSize = True
        Me.lblFromperiodID.Location = New System.Drawing.Point(11, 27)
        Me.lblFromperiodID.Name = "lblFromperiodID"
        Me.lblFromperiodID.Size = New System.Drawing.Size(19, 13)
        Me.lblFromperiodID.TabIndex = 0
        Me.lblFromperiodID.Text = "Kỳ"
        Me.lblFromperiodID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblToPeriodID
        '
        Me.lblToPeriodID.AutoSize = True
        Me.lblToPeriodID.Location = New System.Drawing.Point(256, 25)
        Me.lblToPeriodID.Name = "lblToPeriodID"
        Me.lblToPeriodID.Size = New System.Drawing.Size(10, 13)
        Me.lblToPeriodID.TabIndex = 2
        Me.lblToPeriodID.Text = "-"
        Me.lblToPeriodID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpReportForm
        '
        Me.grpReportForm.Controls.Add(Me.tdbcReportID)
        Me.grpReportForm.Controls.Add(Me.tdbcReportTypeID)
        Me.grpReportForm.Controls.Add(Me.lblReportTypeID)
        Me.grpReportForm.Controls.Add(Me.txtReportTypeName)
        Me.grpReportForm.Controls.Add(Me.lblReportID)
        Me.grpReportForm.Controls.Add(Me.txtReportName)
        Me.grpReportForm.Location = New System.Drawing.Point(7, 4)
        Me.grpReportForm.Name = "grpReportForm"
        Me.grpReportForm.Size = New System.Drawing.Size(609, 83)
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
        Me.lblReportTypeID.Location = New System.Drawing.Point(11, 24)
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
        Me.txtReportTypeName.Size = New System.Drawing.Size(353, 22)
        Me.txtReportTypeName.TabIndex = 2
        Me.txtReportTypeName.TabStop = False
        '
        'lblReportID
        '
        Me.lblReportID.AutoSize = True
        Me.lblReportID.Location = New System.Drawing.Point(11, 54)
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
        Me.txtReportName.Size = New System.Drawing.Size(353, 22)
        Me.txtReportName.TabIndex = 5
        Me.txtReportName.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(458, 158)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(76, 22)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "&In"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(540, 158)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 22)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Đó&ng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'D02F3300
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 188)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.grpConditionFilter)
        Me.Controls.Add(Me.grpReportForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F3300"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BÀo cÀo lÜch sõ nghiÖp vó tÀc ¢èng - D02F3300"
        Me.grpConditionFilter.ResumeLayout(False)
        Me.grpConditionFilter.PerformLayout()
        CType(Me.tdbcToPeriodID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcFromperiodID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpReportForm.ResumeLayout(False)
        Me.grpReportForm.PerformLayout()
        CType(Me.tdbcReportID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcReportTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents grpConditionFilter As System.Windows.Forms.GroupBox
    Private WithEvents tdbcToPeriodID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcFromperiodID As C1.Win.C1List.C1Combo
    Private WithEvents lblFromperiodID As System.Windows.Forms.Label
    Private WithEvents lblToPeriodID As System.Windows.Forms.Label
    Private WithEvents grpReportForm As System.Windows.Forms.GroupBox
    Private WithEvents tdbcReportID As C1.Win.C1List.C1Combo
    Private WithEvents tdbcReportTypeID As C1.Win.C1List.C1Combo
    Private WithEvents lblReportTypeID As System.Windows.Forms.Label
    Private WithEvents txtReportTypeName As System.Windows.Forms.TextBox
    Private WithEvents lblReportID As System.Windows.Forms.Label
    Private WithEvents txtReportName As System.Windows.Forms.TextBox
    Private WithEvents btnPrint As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
End Class
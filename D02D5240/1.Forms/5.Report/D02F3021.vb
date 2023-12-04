'#-------------------------------------------------------------------------------------
'# Created Date: 
'# Created User: 
'# Modify Date: 31/07/2009 10:09:34 AM
'# Modify User: Thiên Huỳnh
'#-------------------------------------------------------------------------------------
Public Class D02F3021
	Dim report As D99C2003

    Dim dtObjectID As DataTable
    Dim dtPeriod As DataTable
    Dim dtPeriodOffset As DataTable
    Dim oFilterComboObj, oFilterCombo As Lemon3.Controls.FilterCombo


    Private Sub LoadTDBCombo()
        'Load tdbcFromPeriodID
        dtPeriod = LoadTablePeriodReport(D02) 'ReturnTablePeriod(D02)
        dtPeriodOffset = ReturnDataTable("Exec D90P1000 1, '02'")
        'LoadCboPeriodReport(tdbcFromPeriodID, tdbcToPeriodID, D02)
        LoadCboDivisionIDAll(tdbcDivisionID, D02, , gbUnicode)
        tdbcDivisionID.SelectedValue = gsDivisionID

        Dim sSQL As String = ""
        sSQL = "select B.ModuleID, B.ReportTypeID, B.ReportTypeName" & UnicodeJoin(gbUnicode) & " as ReportTypeName, A.ReportID, A.Title" & UnicodeJoin(gbUnicode) & " as Title, A.FileExt" & vbCrLf
        sSQL &= "from D89T1000 A  WITH (NOLOCK) Inner Join D89T0010 B  WITH (NOLOCK) on A.ReportTypeID=B.ReportTypeID" & vbCrLf
        sSQL &= "where A.ModuleID='02'and A.ReportTypeID='D02F3021'" & vbCrLf
        sSQL &= "And (DAGroupID= '' Or DAGroupID In (Select DAGroupID From Lemonsys.Dbo.D00V0080 " & vbCrLf
        sSQL &= "Where UserID = " & SQLString(gsUserID) & " Or UserID = 'LEMONADMIN')) " & vbCrLf
        sSQL &= "Order By A.ReportID"
        LoadDataSource(tdbcReportID1, sSQL, gbUnicode)

        sSQL = "Select 0 as DisplayOrder,'%' As ObjectTypeID,'%' AS ObjectID, " & AllName & " As ObjectName" & vbCrLf
        sSQL &= "Union All" & vbCrLf
        sSQL &= "Select 1 as DisplayOrder,ObjectTypeID,ObjectID, ObjectName" & UnicodeJoin(gbUnicode) & " as ObjectName" & vbCrLf
        sSQL &= "From Object  WITH (NOLOCK) " & vbCrLf
        sSQL &= "Where Disabled = 0 Order By DisplayOrder, ObjectTypeID, ObjectID"
        dtObjectID = ReturnDataTable(sSQL)

        LoadObjectTypeIDAll(tdbcObjectTypeID, gbUnicode)

        Dim dtAssetID As DataTable
        'sSQL = "Select  0 as DisplayOrder,'%' As AssetID, " & AllName & " As AssetName" & vbCrLf
        'sSQL &= "Union All" & vbCrLf
        'sSQL &= "Select 1 as DisplayOrder,AssetID, AssetName" & UnicodeJoin(gbUnicode) & " as AssetName" & vbCrLf
        'sSQL &= "From D02T0001 WITH (NOLOCK) " & vbCrLf
        'sSQL &= "Where Disabled = 0 And IsCompleted = 1 " & vbCrLf
        'sSQL &= "And TranMonth + TranYear*100 <= " & SQLString(giTranMonth) & "+" & SQLString(giTranYear) & "  *100" & vbCrLf
        'sSQL &= "Order By DisplayOrder,AssetID"
        'dtAssetID = ReturnDataTable(sSQL)
        'LoadDataSource(tdbcFrom_AssetID, dtAssetID.Copy, gbUnicode)
        'LoadDataSource(tdbcTo_AssetID, dtAssetID.Copy, gbUnicode)

        Dim dtReportID As DataTable
        sSQL = "Select ReportID As ReportCode, Description" & UnicodeJoin(gbUnicode) & "  As " & vbCrLf
        sSQL &= "ReportName, StrSQL, ReportType " & vbCrLf
        sSQL &= "From   D02V5555 " & vbCrLf
        sSQL &= "Where ReportType = 'D02F3021'" & vbCrLf
        sSQL &= "Order By ReportID"
        dtReportID = ReturnDataTable(sSQL)
        If dtReportID.Rows.Count > 0 Then
            txtReportCode.Text = dtReportID.Rows(0).Item("ReportCode").ToString
            txtReportName.Text = dtReportID.Rows(0).Item("ReportName").ToString
        End If


    End Sub

    Private Sub LoadTDBCPeriod()
        If chkPrintOffsetPeriod.Checked Then
            LoadCboPeriodReport(tdbcFrom_Period, tdbcTo_Period, dtPeriodOffset, tdbcDivisionID.Text)
        Else
            LoadCboPeriodReport(tdbcFrom_Period, tdbcTo_Period, dtPeriod, tdbcDivisionID.Text)
        End If
    End Sub

    Private Sub LoadTDBCAssetID()
        Dim sSQL As New StringBuilder(531)
        'Dim sACode As String
        ''Lọc Acode
        'sACode = GetAcode(sGroupTypeID)

        sSQL.Append(" Select 0 as DisplayOrder,'%' As AssetID, " & AllName & " As AssetName ")
        sSQL.Append(" Union All  ")
        sSQL.Append(" Select 1 as DisplayOrder,AssetID, AssetName" & UnicodeJoin(gbUnicode) & " as AssetName")
        sSQL.Append(" From D02T0001  WITH (NOLOCK) ")
        sSQL.Append(" Where Disabled = 0  ")
        sSQL.Append(" And IsCompleted = 1 " & vbCrLf)
        sSQL.Append("And TranMonth + TranYear*100 <= " & SQLString(giTranMonth) & "+" & SQLString(giTranYear) & "  *100" & vbCrLf)
        sSQL.Append(" And DivisionID LIKE " & SQLString(ReturnValueC1Combo(tdbcDivisionID)) & vbCrLf)
        sSQL.Append(" Order By DisplayOrder,AssetID")

        Dim dt As DataTable
        dt = ReturnDataTable(sSQL.ToString)
        LoadDataSource(tdbcFrom_AssetID, dt.DefaultView.ToTable, gbUnicode)
        LoadDataSource(tdbcTo_AssetID, dt.DefaultView.ToTable, gbUnicode)

        tdbcFrom_AssetID.SelectedValue = "%"
    End Sub


#Region "Events tdbcDivisionID with txtDivisionName load tdbcFromPeriodID"

    Private Sub tdbcDivisionID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.SelectedValueChanged
        If tdbcDivisionID.SelectedValue Is Nothing OrElse tdbcDivisionID.Text = "" Then
            txtDivisionName.Text = ""
        Else
            txtDivisionName.Text = tdbcDivisionID.Columns(1).Value.ToString
            LoadTDBCPeriod()
            LoadTDBCAssetID()

        End If
        'tdbcFrom_Period.SelectedIndex = 0
        'tdbcTo_Period.SelectedIndex = 0
    End Sub

    Private Sub tdbcDivisionID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.LostFocus
        If tdbcDivisionID.FindStringExact(tdbcDivisionID.Text) = -1 OrElse tdbcDivisionID.SelectedValue Is Nothing Then
            tdbcDivisionID.Text = ""
            'LoadtdbcFromPeriodID("-1")
            tdbcFrom_Period.Text = ""
            tdbcTo_Period.Text = ""
            Exit Sub
        End If
    End Sub
#End Region


    Private Sub D02F3021_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
            Exit Sub
        End If
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.NumPad1, Keys.D1
                    If tdbcDivisionID.Enabled Then tdbcDivisionID.Focus()
                Case Keys.NumPad2, Keys.D2
                    If tdbcReportID1.Enabled Then tdbcReportID1.Focus()
                Case Keys.NumPad3, Keys.D3
                    If tdbcObjectTypeID.Enabled Then tdbcObjectTypeID.Focus()
                Case Keys.NumPad4, Keys.D4
                    If tdbcFrom_Period.Enabled Then tdbcFrom_Period.Focus()
            End Select
        End If
    End Sub


    Private Sub D02F3021_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
	LoadInfoGeneral()
        Me.Cursor = Cursors.WaitCursor
        Loadlanguage()

        '18/10/2018, id 114011-Bổ sung filter lọc truy vấn TSCĐ - BC KH theo kỳ
        oFilterComboObj = New Lemon3.Controls.FilterCombo
        oFilterComboObj.CheckD91 = True
        oFilterComboObj.AddPairObject(tdbcObjectTypeID, tdbcFrom_ObjectID) 'Đă bổ sung cột Loại ĐT
        oFilterComboObj.AddPairObject(tdbcObjectTypeID, tdbcTo_ObjectID) 'Đă bổ sung cột Loại ĐT
        oFilterComboObj.UseFilterComboObjectID()

        oFilterCombo = New Lemon3.Controls.FilterCombo
        oFilterCombo.CheckD91 = True
        oFilterCombo.UseFilterCombo(tdbcFrom_AssetID, tdbcTo_AssetID)

        CheckPrintOffset()
        LoadTDBCombo()
        InputbyUnicode(Me, gbUnicode)
        LoadDefault()
        SetBackColorObligatory()
        SetResolutionForm(Me)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SetBackColorObligatory()
        tdbcFrom_Period.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcTo_Period.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub



    Private Sub LoadDefault()
        tdbcFrom_Period.SelectedValue = giTranMonth.ToString("00") & "/" & giTranYear
        ' tdbcFrom_Period.SelectedIndex = tdbcFrom_Period.FindStringExact(tdbcFrom_Period.Text)
        tdbcTo_Period.SelectedValue = giTranMonth.ToString("00") & "/" & giTranYear
    End Sub

    Private Sub CheckPrintOffset()
        Dim sSQL As String
        Dim dtTmp As DataTable
        sSQL = "Select ModePeriodCheck, PeriodOffset From D91T9102 WITH (NOLOCK) "
        dtTmp = ReturnDataTable(sSQL)
        If dtTmp.Rows.Count > 0 Then
            If dtTmp.Rows(0).Item("PeriodOffset").ToString = "0" Then
                chkPrintOffsetPeriod.Enabled = False
            End If
        Else
            chkPrintOffsetPeriod.Enabled = False
        End If
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Bao_cao_khau_hao_TSCD_theo_ky_-_D02F3021") & UnicodeCaption(gbUnicode) 'BÀo cÀo khÊu hao TSC˜ theo kù - D02F3021
        '================================================================ 
        lblReportCode.Text = rl3("Mau_chuan") 'Mẫu chuẩn
        lblReportID1.Text = rl3("Dac_thu") 'Đặc thù
        lblObjectTypeID.Text = rl3("Loai_doi_tuong") 'Loại đối tượng
        lblFrom_ObjectID.Text = rl3("Doi_tuong") 'Đối tượng
        lblFrom_AssetID.Text = rl3("Tai_san") 'Tài sản
        lblFrom_Period.Text = rl3("Ky") 'Kỳ
        lblDivisionID.Text = rl3("Don_vi")
        lblGrpDivisionID.Text = "1. " & rL3("Don_vi")
        lblReport.Text = "2. " & rl3("Mau_bao_cao")
        lblSelection.Text = "3. " & rl3("Tieu_thuc_loc")
        lblTimeInfo.Text = "4. " & rl3("Thong_tin_thoi_gian")
        '================================================================ 
        chkPrintOffsetPeriod.Text = rl3("In_theo_nam_tai_chinh")
        chkAllAsset.Text = rL3("Hien_thi_tat_ca_tai_san_chua_thanh_ly_cua_cac_ky_truoc") 'Hiển thị tất cả tài sản chưa thanh lý của các kỳ trước
        chkShowAssetLiquidated.Text = rL3("Hien_thi_tat_ca_tai_san_da_thanh_ly")
        '================================================================ 
        btnPrint.Text = rl3("_In") '&In
        btnClose.Text = rl3("Do_ng") 'Đó&ng
        btnFiter.Text = rl3("_Loc") '&Lọc
        chkShowStopDepreciation.Text = rl3("Hien_thi_nhung_tai_san_ngung_khau_hao")
        '================================================================ 
        tdbcReportID1.Columns("ReportID").Caption = rl3("Ma") 'Mã
        tdbcReportID1.Columns("Title").Caption = rl3("Ten") 'Tên
        tdbcDivisionID.Columns(0).Caption = rl3("Ma") 'Mã
        tdbcDivisionID.Columns(1).Caption = rl3("Ten") 'Tên
        tdbcTo_AssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcTo_AssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên
        tdbcFrom_AssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcFrom_AssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên

        tdbcTo_ObjectID.Columns("ObjectID").Caption = rl3("Ma") 'Mã
        tdbcTo_ObjectID.Columns("ObjectName").Caption = rl3("Ten") 'Tên

        tdbcFrom_ObjectID.Columns("ObjectID").Caption = rl3("Ma") 'Mã
        tdbcFrom_ObjectID.Columns("ObjectName").Caption = rl3("Ten") 'Tên
        tdbcObjectTypeID.Columns("ObjectTypeID").Caption = rl3("Ma") 'Mã
        tdbcObjectTypeID.Columns("ObjectTypeName").Caption = rl3("Ten") 'Tên
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#Region "Events tdbcReportID1 with txtTitle"

    'Private Sub tdbcReportID1_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportID1.Close
    '    If tdbcReportID1.FindStringExact(tdbcReportID1.Text) = -1 Then
    '        tdbcReportID1.Text = ""
    '        txtTitle.Text = ""
    '    End If
    'End Sub

    Private Sub tdbcReportID1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcReportID1.LostFocus
        If tdbcReportID1.FindStringExact(tdbcReportID1.Text) = -1 Then
            txtTitle.Text = ""
        End If
    End Sub

    Private Sub tdbcReportID1_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportID1.SelectedValueChanged

        txtTitle.Text = tdbcReportID1.Columns(1).Value.ToString


    End Sub

    'Private Sub tdbcReportID1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcReportID1.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
    '        tdbcReportID1.Text = ""
    '        txtTitle.Text = ""
    '    End If
    'End Sub
#End Region

#Region "Events tdbcObjectTypeID with txtObjectTypeName"

    Private Sub tdbcObjectTypeID_Validated(sender As Object, e As EventArgs) Handles tdbcObjectTypeID.Validated
        If tdbcObjectTypeID.FindStringExact(tdbcObjectTypeID.Text) = -1 Then '18/10/2018, id 114011-Bổ sung filter lọc truy vấn TSCĐ - BC KH theo kỳ
            tdbcObjectTypeID.Text = "%"
            LoadTDBComboObjectID("%")
            tdbcFrom_ObjectID.SelectedValue = "%"
            tdbcTo_ObjectID.SelectedValue = "%"
        End If
    End Sub

    Private Sub tdbcObjectTypeID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcObjectTypeID.SelectedValueChanged
        If tdbcObjectTypeID.SelectedValue Is Nothing OrElse tdbcObjectTypeID.Text = "" Then
            txtObjectTypeName.Text = ""
        Else
            txtObjectTypeName.Text = tdbcObjectTypeID.Columns(1).Value.ToString
        End If
        LoadTDBComboObjectID(ReturnValueC1Combo(tdbcObjectTypeID))
        tdbcFrom_ObjectID.SelectedValue = "%"
        tdbcTo_ObjectID.SelectedValue = "%"
    End Sub

    '18/10/2018, id 114011-Bổ sung filter lọc truy vấn TSCĐ - BC KH theo kỳ
    Private Sub LoadTDBComboObjectID(ByVal sObjectTypeID As String)
        If oFilterCombo.IsNewFilter Then
            tdbcFrom_ObjectID.Splits(0).DisplayColumns("ObjectTypeID").Visible = (sObjectTypeID = "" Or sObjectTypeID = "%")
        End If

        LoadDataSource(tdbcFrom_ObjectID, ReturnTableFilter(dtObjectID, " ObjectTypeID='%' or  ObjectTypeID like " & SQLString(tdbcObjectTypeID.Text)), gbUnicode)
        LoadDataSource(tdbcTo_ObjectID, ReturnTableFilter(dtObjectID, " ObjectTypeID='%' or  ObjectTypeID like " & SQLString(tdbcObjectTypeID.Text)), gbUnicode)
    End Sub

#End Region

#Region "Events tdbcFrom_ObjectID"

    Private Sub tdbcFrom_ObjectID_Validated(sender As Object, e As EventArgs) Handles tdbcFrom_ObjectID.Validated
        oFilterComboObj.FilterCombo(tdbcFrom_ObjectID, e) '18/10/2018, id 114011-Bổ sung filter lọc truy vấn TSCĐ - BC KH theo kỳ
        If tdbcFrom_ObjectID.FindStringExact(tdbcFrom_ObjectID.Text) = -1 Then tdbcFrom_ObjectID.Text = ""

        If tdbcFrom_ObjectID.Text = "%" Then
            tdbcTo_ObjectID.Enabled = False
        Else
            tdbcTo_ObjectID.Enabled = True
            SetValueTo(tdbcFrom_ObjectID, tdbcTo_ObjectID)
        End If
    End Sub


    Private Sub tdbcFrom_ObjectID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFrom_ObjectID.SelectedValueChanged
        If tdbcFrom_ObjectID.Text = "%" Then
            tdbcTo_ObjectID.Enabled = False
        Else
            tdbcTo_ObjectID.Enabled = True
        End If
    End Sub

#End Region

#Region "Events tdbcTo_ObjectID"
    Private Sub tdbcTo_ObjectID_Validated(sender As Object, e As EventArgs) Handles tdbcTo_ObjectID.Validated
        oFilterComboObj.FilterCombo(tdbcTo_ObjectID, e) '18/10/2018, id 114011-Bổ sung filter lọc truy vấn TSCĐ - BC KH theo kỳ
        If tdbcTo_ObjectID.FindStringExact(tdbcTo_ObjectID.Text) = -1 Then tdbcTo_ObjectID.Text = ""
    End Sub

#End Region

#Region "Events tdbcFrom_AssetID"

    Private Sub tdbcFrom_AssetID_Validated(sender As Object, e As EventArgs) Handles tdbcFrom_AssetID.Validated
        oFilterCombo.FilterCombo(tdbcFrom_AssetID, e) '18/10/2018, id 114011-Bổ sung filter lọc truy vấn TSCĐ - BC KH theo kỳ
        If tdbcFrom_AssetID.FindStringExact(tdbcFrom_AssetID.Text) = -1 Then tdbcFrom_AssetID.Text = ""
        If tdbcFrom_AssetID.Text = "%" Then
            tdbcTo_AssetID.Enabled = False
        Else
            tdbcTo_AssetID.Enabled = True
            SetValueTo(tdbcFrom_AssetID, tdbcTo_AssetID)
        End If
    End Sub

    Private Sub tdbcFrom_AssetID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFrom_AssetID.SelectedValueChanged
        If tdbcFrom_AssetID.Text = "%" Then
            tdbcTo_AssetID.Text = "%"
            tdbcTo_AssetID.Enabled = False
        Else
            tdbcTo_AssetID.Enabled = True
        End If
    End Sub
#End Region

#Region "Events tdbcTo_AssetID"

    Private Sub tdbcTo_AssetID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcTo_AssetID.Close
        If tdbcTo_AssetID.FindStringExact(tdbcTo_AssetID.Text) = -1 Then tdbcTo_AssetID.Text = ""
    End Sub

    Private Sub tdbcTo_AssetID_Validated(sender As Object, e As EventArgs) Handles tdbcTo_AssetID.Validated
        oFilterCombo.FilterCombo(tdbcTo_AssetID, e) '18/10/2018, id 114011-Bổ sung filter lọc truy vấn TSCĐ - BC KH theo kỳ
        If tdbcTo_AssetID.FindStringExact(tdbcTo_AssetID.Text) = -1 Then tdbcTo_AssetID.Text = ""
    End Sub
#End Region

#Region "Events tdbcFrom_Period"

    Private Sub tdbcFrom_Period_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcFrom_Period.Close
        If tdbcFrom_Period.FindStringExact(tdbcFrom_Period.Text) = -1 Then tdbcFrom_Period.Text = ""
    End Sub

    'Private Sub tdbcFrom_Period_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcFrom_Period.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcFrom_Period.Text = ""
    'End Sub
#End Region

#Region "Events tdbcTo_Period"

    Private Sub tdbcTo_Period_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcTo_Period.Close
        If tdbcTo_Period.FindStringExact(tdbcTo_Period.Text) = -1 Then tdbcTo_Period.Text = ""
    End Sub

    'Private Sub tdbcTo_Period_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcTo_Period.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcTo_Period.Text = ""
    'End Sub
    Private Function AllowPrint() As Boolean
        If tdbcFrom_Period.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Tu_ky"))
            tdbcFrom_Period.Focus()
            Return False
        End If
        If tdbcTo_Period.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Den_ky"))
            tdbcTo_Period.Focus()
            Return False
        End If
        If Not CheckValidPeriodFromTo(tdbcFrom_Period, tdbcTo_Period) Then
            Return False
        End If
        Return True
    End Function

#End Region

#Region "Active Find - List All "
    Private WithEvents Finder As New D99C1001
	Dim gbEnabledUseFind As Boolean = False
    'Cần sửa Tìm kiếm như sau:
	'Bỏ sự kiện Finder_FindClick.
	'Sửa tham số Me.Name -> Me
	'Phải tạo biến properties có tên chính xác strNewFind và strNewServer
	'Sửa gdtCaptionExcel thành dtCaptionCols: biến toàn cục trong form
	'Nếu có F12 dùng D09U1111 thì Sửa dtCaptionCols thành ResetTableByGrid(usrOption, dtCaptionCols.DefaultView.ToTable)
    Private sFind As String = ""
	Public WriteOnly Property strNewFind() As String
		Set(ByVal Value As String)
			sFind = Value
            btnPrint_Click(Nothing, Nothing)
            sFind = ""
		End Set
	End Property


    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiter.Click
        If Not AllowPrint() Then Exit Sub
        Dim sSQL As String = ""
        gbEnabledUseFind = True
        sSQL = "Select * From D02V1234 "
        sSQL &= "Where FormID = 'D02F3021' And Language = " & SQLString(gsLanguage)
        ShowFindDialog(Finder, sSQL, Me, gbUnicode)
       
    End Sub

    'Private Sub Finder_FindClick(ByVal ResultWhereClause As Object) Handles Finder.FindClick
    '    Dim sSQL As String = ""
    '    If ResultWhereClause Is Nothing Then Exit Sub
    '    sFind = ResultWhereClause.ToString()
    'End Sub


#End Region

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P3021
    '# Created User: Nguyễn Đức Trọng
    '# Created Date: 07/12/2010 01:14:07
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P3021() As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P3021 "
        sSQL &= SQLString(gsUserID) & COMMA 'UserID, varchar[20], NOT NULL
        sSQL &= SQLString(ReturnValueC1Combo(tdbcDivisionID)) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLNumber(tdbcFrom_Period.Columns("TranMonth").Value.ToString) & COMMA 'FromTranMonth, int, NOT NULL
        sSQL &= SQLNumber(tdbcFrom_Period.Columns("TranYear").Value.ToString) & COMMA 'FromTranYear, int, NOT NULL
        sSQL &= SQLNumber(tdbcTo_Period.Columns("TranMonth").Value.ToString) & COMMA 'ToTranMonth, int, NOT NULL
        sSQL &= SQLNumber(tdbcTo_Period.Columns("TranYear").Value.ToString) & COMMA 'ToTranYear, int, NOT NULL

        If tdbcFrom_AssetID.Text = "" Then
            sSQL &= SQLString("%") & COMMA 'FromAssetID, varchar[20], NOT NULL
        Else
            sSQL &= SQLString(tdbcFrom_AssetID.Text) & COMMA 'FromAssetID, varchar[20], NOT NULL
        End If

        If tdbcTo_AssetID.Text = "" Then
            sSQL &= SQLString("%") & COMMA 'ToAssetID, varchar[20], NOT NULL
        Else
            sSQL &= SQLString(tdbcTo_AssetID.Text) & COMMA 'ToAssetID, varchar[20], NOT NULL
        End If

        If tdbcObjectTypeID.Text = "" Then
            sSQL &= SQLString("%") & COMMA 'ObjectTypeID, varchar[20], NOT NULL
        Else
            sSQL &= SQLString(tdbcObjectTypeID.Text) & COMMA 'ObjectTypeID, varchar[20], NOT NULL
        End If

        If tdbcFrom_ObjectID.Text = "" Then
            sSQL &= SQLString("%") & COMMA 'ObjectTypeID, varchar[20], NOT NULL

        Else
            sSQL &= SQLString(tdbcFrom_ObjectID.Text) & COMMA 'FromObjectID, varchar[20], NOT NULL
        End If

        If tdbcTo_ObjectID.Text = "" Then
            sSQL &= SQLString("%") & COMMA 'ToObjectID, varchar[20], NOT NULL
        Else
            sSQL &= SQLString(tdbcTo_ObjectID.Text) & COMMA 'ToObjectID, varchar[20], NOT NULL
        End If
        sSQL &= SQLNumber(chkShowStopDepreciation.Checked) & COMMA
        sSQL &= SQLNumber(gnDecreaseAsset) & COMMA  'DecreaseAsset, tinyint, NOT NULL
        sSQL &= SQLString(sFind) & COMMA 'StrFilter, varchar[2000], NOT NULL
        sSQL &= SQLString("D02F3021") & COMMA 'ReportTypeID, varchar[20], NOT NULL
        If tdbcReportID1.Text = "" Then
            sSQL &= SQLString(txtReportCode.Text) & COMMA 'ReportID, varchar[20], NOT NULL
        Else
            sSQL &= SQLString(tdbcReportID1.Text) & COMMA 'ReportID, varchar[20], NOT NULL
        End If
        sSQL &= SQLNumber(chkPrintOffsetPeriod.Checked) & COMMA 'PrintOffsetPeriod, tinyint, NOT NULL
        sSQL &= SQLNumber(chkAllAsset.Checked) & COMMA 'IsAllAsset, tinyint, NOT NULL
        sSQL &= SQLNumber(gbUnicode) & COMMA 'IsAllAsset, tinyint, NOT NULL
        sSQL &= SQLNumber(chkShowAssetLiquidated.Checked)
        Return sSQL
    End Function

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Not AllowPrint() Then Exit Sub
        Print(Me, "D02F3021", "02")
        'If giAppMode = 0 Then
        '    PrintData()
        'Else
        '    PrintDataWS()
        'End If

    End Sub

    '  Private Sub PrintData()
    '      btnPrint.Enabled = False
    '      Me.Cursor = Cursors.WaitCursor
    '      'Dim report As New D99C1003
    '      'Đưa vể đầu tiên hàm In trước khi gọi AllowPrint()
    'If Not AllowNewD99C2003(report, Me) Then Exit Sub
    ''************************************
    '      Dim conn As New SqlConnection(gsConnectionString)

    '      Dim sSubReportName As String = "D02R0000"
    '      Dim sReportCaption As String = ""
    '      Dim sPathReport As String = ""
    '      Dim sSQL As String = ""
    '      Dim sSQLSub As String = ""
    '      Dim sReportName As String = "D02R3021"
    '      Dim sSQLMain As String

    '      If tdbcReportID1.Text <> "" Then
    '          sReportName = tdbcReportID1.Text
    '      End If
    '      sSQLMain = SQLStoreD02P3021()

    '      sReportCaption = rl3("Bao_cao_khau_hao_TSCD_theo_ky") & " - " & sReportName

    '      sSQLSub = "SELECT Top 1 * FROM D91T0025 WITH (NOLOCK) "
    '      UnicodeSubReport(sSubReportName, sSQLSub, tdbcDivisionID.Text, gbUnicode)

    '      sPathReport = UnicodeGetReportPath(gbUnicode, D02Options.ReportLanguage, tdbcReportID1.Text) & sReportName & ".rpt"
    '      With report
    '          .OpenConnection(conn)
    '          .AddSub(sSQLSub, sSubReportName & ".rpt")
    '          '.AddMain(sSQL)
    '          .AddMain(sSQLMain)
    '          .PrintReport(sPathReport, sReportCaption)
    '      End With

    '      Me.Cursor = Cursors.Default
    '      btnPrint.Enabled = True
    '  End Sub

    'Private Sub PrintDataWS()
    '    btnPrint.Enabled = False
    '    Me.Cursor = Cursors.WaitCursor
    '    bPrintUnicode = gbUnicode And Not chkIsPrintVNI.Checked
    '    Dim reportWS As New D99C0009
    '    CallWebService.Url = gsAppServer & "D91W0000.asmx"
    '    CallWebService.Timeout = nWSTimeOut

    '    Dim sSubReportName As String = "D91R0000"
    '    Dim sReportCaption As String = ""
    '    Dim sPathReport As String = ""
    '    Dim sSQL As String = ""
    '    Dim sSQLSub As String = ""
    '    Dim sReportName As String = "D02R3021"
    '    Dim sSQLMain As String

    '    If tdbcReportID1.Text <> "" Then
    '        sReportName = tdbcReportID1.Text
    '    End If
    '    sSQLMain = SQLStoreD02P3021()
    '    ' ExecuteSQL(sSQLMain)
    '    ' sSQL = "select * from D02T3021 where UserID=" & SQLString(gsUserID) & vbCrLf
    '    ' If sFind <> "" Then sSQL &= " and " & sFind
    '    ''  sSQL &= "Order By ObjectID, AssetID"
    '    sSQLSub = "SELECT Top 1 * FROM D91T0025 WITH (NOLOCK) "
    '    sReportCaption = rL3("Bao_cao_khau_hao_TSCD_theo_ky") & " - " & sReportName & UnicodeCaption(gbUnicode)
    '    ' sSQLSub = "Select *" & vbCrLf
    '    ' sSQLSub &= " FROM D91V0016 " & vbCrLf
    '    ' sSQLSub &= " WHERE   DivisionID = " & SQLString(gsDivisionID)
    '    sPathReport = UnicodeGetReportPath(bPrintUnicode, D02Options.ReportLanguage, tdbcReportID1.Text) & sReportName & ".rpt"
    '    With reportWS
    '        .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '        .AddSub(sSQLSub, sSubReportName & ".rpt")
    '        .AddMain(sSQLMain)
    '        .PrintReport(sReportName & ".rpt", sReportCaption)
    '    End With
    '    '    sReportCaption = rl3("Bao_cao_khau_hao_TSCD_theo_ky") & " - " & tdbcReportID1.Text
    '    '    ExecuteSQL(SQLStoreD02P3021)

    '    '    sSQL = "select * from D02T3021 where UserID=" & SQLString(gsUserID) & vbCrLf
    '    '    If sFind <> "" Then sSQL &= " and " & sFind
    '    '    sSQL &= "Order By ObjectID, AssetID"
    '    '    sSQLSub = "SELECT Top 1 * FROM D91T0025"
    '    '    With reportWS
    '    '        .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '    '        .AddSub(sSQLSub, sSubReportName & ".rpt")
    '    '        .AddMain(sSQL)
    '    '        .PrintReport(sReportName & ".rpt", sReportCaption)
    '    '    End With
    '    'End If

    '    Me.Cursor = Cursors.Default
    '    btnPrint.Enabled = True
    'End Sub

   

    

    'Private Sub tdbcFrom_Period_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFrom_Period.SelectedValueChanged
    '    If tdbcTo_Period.Text <> tdbcFrom_Period.Text Then
    '        tdbcTo_Period.Text = tdbcFrom_Period.Text
    '    End If
    'End Sub
    Private Sub Print(ByVal form As Form, Optional ByVal sReportTypeID As String = "", Optional ByVal ModuleID As String = "")
        ''If Not AllowNewD99C2003(report, Me) Then Exit Sub ''Mở rem khi form trong DLL
        Dim sReportName As String = ""
        Dim sSubReportName As String = "D02R0000"
        Dim sReportPath As String = ""
        Dim sReportTitle As String = "" ''Thêm biến
        Dim sCustomReport As String = ""
        'Dim file As String = D99D0541.GetReportPathNew(ModuleID, sReportTypeID, sReportName, sCustomReport, sReportPath, sReportTitle)
        Dim file As String = "rpt"
        If ReturnValueC1Combo(tdbcReportID1).ToString <> "" Then
            file = ReturnValueC1Combo(tdbcReportID1, "FileExt")
        End If
        'If sReportName = "" Then Exit Sub
        form.Cursor = Cursors.WaitCursor
    
        Dim sSQL As String = SQLStoreD02P3021()

        Select Case file.ToLower
            Case "rpt"
                printReport(sSubReportName, sReportPath, sReportTitle, sSQL)
            Case "xls", "xlsx"
                'Dim sPathFile As String = D99D0541.GetObjectFile(sReportTypeID, sReportName, file, sReportPath)
                sReportPath = UnicodeGetReportPath(False, D02Options.ReportLanguage, sReportName) & tdbcReportID1.Columns(0).Value.ToString & "." & file
                Dim sPathFile As String = D99D0541.GetObjectFile(sReportTypeID, ReturnValueC1Combo(tdbcReportID1).ToString, file, sReportPath)

                If sPathFile = "" Then Exit Select
                SetVariable()
                Dim excel As New Lemon3.Reports.L3XtraReportExcel()
                excel.ExcelType = Lemon3.Reports.PrintExcelType.Normal
                excel.MyExcel(sSQL, sPathFile, file)
                excel.OpenFileExcel(sPathFile)
        End Select
        form.Cursor = Cursors.Default
    End Sub

    Private Sub printReport(ByVal sSubReportName As String, ByVal sReportPath As String, ByVal sReportCaption As String, ByVal sSQL As String)
        Dim report As New D99C1003 'Chỉ Sử dụng khi Form trong Exe
        Dim conn As New SqlConnection(gsConnectionString)
        Dim sSQLSub As String = ""
        Dim sReportName As String = txtReportCode.Text
        Dim sPathReport As String = ""
        UnicodeSubReport(sSubReportName, sSQLSub, tdbcDivisionID.Text, gbUnicode)

        sPathReport = UnicodeGetReportPath(gbUnicode, D02Options.ReportLanguage, tdbcReportID1.Text) & sReportName & ".rpt"
        sReportCaption = rL3("Bao_cao_khau_hao_TSCD_theo_ky") & " - " & sReportName
        With report
            .OpenConnection(conn)
            .AddSub(sSQLSub, sSubReportName & ".rpt")
            .AddMain(sSQL)
            .PrintReport(sPathReport, sReportCaption)
        End With
    End Sub
    Private Sub chkPrintOffsetPeriod_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPrintOffsetPeriod.Click
        LoadTDBCPeriod()
    End Sub

  
    
   
End Class
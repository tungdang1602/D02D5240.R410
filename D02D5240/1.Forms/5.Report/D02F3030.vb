'#-------------------------------------------------------------------------------------
'# Created Date: 27/02/2008 5:05:55 PM
'# Created User: DOAN NHU THANH
'# Modify Date: 27/02/2008 5:05:55 PM
'# Modify User: DOAN NHU THANH
'#-------------------------------------------------------------------------------------
Public Class D02F3030
	Dim report As D99C2003
    Dim dtPeriod As DataTable


#Region "Events tdbcReportTypeID with txtReportTypeName"

    Private Sub tdbcReportTypeID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportTypeID.Close
        If tdbcReportTypeID.FindStringExact(tdbcReportTypeID.Text) = -1 Then
            tdbcReportTypeID.Text = ""
            txtReportTypeName.Text = ""
        End If
    End Sub

    Private Sub tdbcReportTypeID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportTypeID.SelectedValueChanged
        txtReportTypeName.Text = tdbcReportTypeID.Columns(1).Value.ToString
    End Sub

    Private Sub tdbcReportTypeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcReportTypeID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
            tdbcReportTypeID.Text = ""
            txtReportTypeName.Text = ""
        End If
    End Sub

#End Region

#Region "Events tdbcReportID with txtReportName"

    Private Sub tdbcReportID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportID.Close
        If tdbcReportID.FindStringExact(tdbcReportID.Text) = -1 Then
            'tdbcReportID.Text = ""
            txtReportName.Text = ""
        End If

        If tdbcReportID.Text = "" Then
            tdbcReportTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        Else
            tdbcReportTypeID.EditorBackColor = Color.White
        End If
    End Sub

    Private Sub tdbcReportID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportID.SelectedValueChanged
        txtReportName.Text = tdbcReportID.Columns(1).Value.ToString
        If tdbcReportID.Text = "" Then
            tdbcReportTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        Else
            tdbcReportTypeID.EditorBackColor = Color.White
        End If
    End Sub

    Private Sub tdbcReportID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcReportID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
            tdbcReportID.Text = ""
            txtReportName.Text = ""
        End If
    End Sub

#End Region

#Region "Events tdbcDivisionID with txtDivisionName"

    Private Sub tdbcDivisionID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.Close
        If tdbcDivisionID.FindStringExact(tdbcDivisionID.Text) = -1 Then
            tdbcDivisionID.Text = ""
            txtDivisionName.Text = ""
            tdbcDivisionID.Focus()
        End If
    End Sub

    Private Sub tdbcDivisionID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.SelectedValueChanged
        txtDivisionName.Text = tdbcDivisionID.Columns(1).Value.ToString
        LoadCboPeriodReport(tdbcFromperiodID, tdbcToPeriodID, dtPeriod, tdbcDivisionID.Text)
    End Sub

    'Private Sub tdbcDivisionID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcDivisionID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
    '        tdbcDivisionID.Text = ""
    '        txtDivisionName.Text = ""
    '    End If
    'End Sub

#End Region

#Region "Events tdbcFromperiodID"

    Private Sub tdbcFromperiodID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcFromperiodID.Close
        If tdbcFromperiodID.FindStringExact(tdbcFromperiodID.Text) = -1 Then
            tdbcFromperiodID.Text = ""
            tdbcFromperiodID.Focus()
        End If
    End Sub

    'Private Sub tdbcFromperiodID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcFromperiodID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcFromperiodID.Text = ""
    'End Sub

    'Private Sub tdbcFromperiodID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromperiodID.SelectedValueChanged
    '    tdbcToPeriodID.Text = tdbcFromperiodID.Text
    'End Sub
#End Region

#Region "Events tdbcToPeriodID"

    Private Sub tdbcToPeriodID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcToPeriodID.Close
        If tdbcToPeriodID.FindStringExact(tdbcToPeriodID.Text) = -1 Then
            tdbcToPeriodID.Text = ""
            tdbcToPeriodID.Focus()
        End If

    End Sub

    Private Sub tdbcToPeriodID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcToPeriodID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcToPeriodID.Text = ""
    End Sub

#End Region

#Region "Events tdbcCode1"

    Private Sub tdbcCode1_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcCode1.Close
        If tdbcCode1.FindStringExact(tdbcCode1.Text) = -1 Then
            tdbcCode1.Text = ""
            tdbcCode1.Focus()
        End If

    End Sub

    Private Sub tdbcCode1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcCode1.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcCode1.Text = ""
    End Sub

#End Region

#Region "Events tdbcCode2"

    Private Sub tdbcCode2_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcCode2.Close
        If tdbcCode2.FindStringExact(tdbcCode2.Text) = -1 Then
            tdbcCode2.Text = ""
            tdbcCode2.Focus()
        End If

    End Sub

    Private Sub tdbcCode2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcCode2.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcCode2.Text = ""
    End Sub

#End Region

#Region "Events tdbcCode3"

    Private Sub tdbcCode3_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcCode3.Close
        If tdbcCode3.FindStringExact(tdbcCode3.Text) = -1 Then
            tdbcCode3.Text = ""
            tdbcCode3.Focus()
        End If

    End Sub

    Private Sub tdbcCode3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcCode3.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcCode3.Text = ""
    End Sub

#End Region

    Private Sub D02F3030_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
            Exit Sub
        End If

        If e.Control Then
            If e.KeyCode = Keys.NumPad1 Or e.KeyCode = Keys.D1 Then
                Application.DoEvents()
                tdbcReportTypeID.Focus()
                Application.DoEvents()
                Exit Sub
            ElseIf e.KeyCode = Keys.NumPad2 Or e.KeyCode = Keys.D2 Then
                Application.DoEvents()
                tdbcDivisionID.Focus()
                Application.DoEvents()
                Exit Sub
            ElseIf e.KeyCode = Keys.NumPad3 Or e.KeyCode = Keys.D3 Then
                Application.DoEvents()
                tdbcCode1.Focus()
                Application.DoEvents()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub D02F3030_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
	LoadInfoGeneral()
        Loadlanguage()
        SetBackColorObligatory()
        LoadTDBCombo()
        dtPeriod = LoadTablePeriodReport(D02)
        tdbcCode1.SelectedValue = "DEF"
        tdbcCode2.SelectedValue = "DEF"
        InputbyUnicode(Me, gbUnicode)
        tdbcCode3.SelectedValue = "DEF"
        tdbcDivisionID.Text = gsDivisionID
        tdbcFromperiodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
        tdbcToPeriodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
    SetResolutionForm(Me)
Me.Cursor = Cursors.Default
End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Bao_cao_phan_bo_khau_hao_-_D02F3030") & UnicodeCaption(gbUnicode) 'BÀo cÀo ph¡n bå khÊu hao - D02F3030
        '================================================================ 
        lblReportTypeID.Text = rl3("Mau_chuan") 'Mẫu chuẩn
        lblReportID.Text = rl3("Dac_thu") 'Đặc thù
        lblDivisionID.Text = rl3("Don_vi") 'Đơn vị
        lblFromperiodID.Text = rl3("Ky") 'Kỳ
        lblCode1.Text = rl3("Nhom_1") 'Nhóm 1
        lblCode2.Text = rl3("Nhom_2") 'Nhóm 2
        lblCode3.Text = rl3("Nhom_3") 'Nhóm 3
        '================================================================ 
        btnPrint.Text = rl3("_In") '&In
        btnClose.Text = rl3("Do_ng") 'Đó&ng
        '================================================================ 
        grpReportForm.Text = "1. " & rl3("Dang_bao_cao") 'Dạng báo cáo
        grpConditionFilter.Text = "2. " & rl3("Dieu_kien_loc") 'Điều kiện lọc
        grpDataGroup.Text = "3. " & rl3("Nhom_du_lieu") 'Nhóm dữ liệu
        '================================================================ 
        tdbcReportID.Columns("ReportID").Caption = rl3("Ma") 'Mã
        tdbcReportID.Columns("Title").Caption = rl3("Ten") 'Tên
        tdbcReportTypeID.Columns("ReportTypeID").Caption = rl3("Mau_chuan") 'Mẫu chuẩn
        tdbcReportTypeID.Columns("ReportTypeName").Caption = rl3("Ten") 'Tên       

        tdbcDivisionID.Columns("DivisionID").Caption = rl3("Ma") 'Mã
        tdbcDivisionID.Columns("DivisionName").Caption = rl3("Ten") 'Tên 
        tdbcCode3.Columns("Code").Caption = rl3("Ma") 'Mã
        tdbcCode3.Columns("Description").Caption = rl3("Ten") 'Tên
        tdbcCode2.Columns("Code").Caption = rl3("Ma") 'Mã
        tdbcCode2.Columns("Description").Caption = rl3("Ten") 'Tên
        tdbcCode1.Columns("Code").Caption = rl3("Ma") 'Mã
        tdbcCode1.Columns("Description").Caption = rl3("Ten") 'Tên

        chkShowStopDepreciationAssets.Text = rl3("Hien_thi_cac_tai_san_ngung_khau_hao_trong_ky")
    End Sub

    Private Sub SetBackColorObligatory()
        tdbcReportTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcDivisionID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcFromperiodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToPeriodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub

    Private Sub LoadTDBCombo()
        Dim sSQL As New StringBuilder(299)

        sSQL.Append(" SELECT ReportID As ReportTypeID," & IIf(gsLanguage = "84", "Description" & UnicodeJoin(gbUnicode), "Description01" & UnicodeJoin(gbUnicode)).ToString & " As ")
        sSQL.Append(" ReportTypeName,StrSQL, ReportType ")
        sSQL.Append(" FROM D02V5555 ")
        sSQL.Append(" WHERE ReportType = 'D02F3030' ")
        sSQL.Append(" ORDER BY ReportTypeID")
        'Combo Mẫu chuẩn
        LoadDataSource(tdbcReportTypeID, sSQL.ToString, gbUnicode)

        sSQL.Remove(0, sSQL.Length)
        sSQL.Append(" SELECT A.ReportID, A.Title" & UnicodeJoin(gbUnicode) & " as Title , B.ModuleID, B.ReportTypeID, B.ReportTypeName" & UnicodeJoin(gbUnicode) & "  as ReportTypeName ")
        sSQL.Append(" FROM D89T1000 A  WITH (NOLOCK) Inner Join D89T0010 B  WITH (NOLOCK) On  A.ReportTypeID = B.ReportTypeID ")
        sSQL.Append(" WHERE A.ModuleID = '02' And A.ReportTypeID Like 'D02F3030_' ")
        sSQL.Append(" And (DAGroupID= '' Or DAGroupID In (Select DAGroupID From Lemonsys.Dbo.D00V0080 ")
        sSQL.Append(" Where UserID = " & SQLString(gsUserID) & " Or UserID = 'LEMONADMIN')) ")
        sSQL.Append(" ORDER BY	A.ReportTypeID")
        'Combo Đặc thù
        LoadDataSource(tdbcReportID, sSQL.ToString, gbUnicode)

        LoadCboDivisionIDReport(tdbcDivisionID, D02, , gbUnicode)

        sSQL.Remove(0, sSQL.Length)
        sSQL.Append(" SELECT Code, Description" & UnicodeJoin(gbUnicode) & " as Description, GroupField ")
        sSQL.Append(" FROM D02V3000 ")
        sSQL.Append(" WHERE Type = 'D02F3030' AND Language = " & SQLString(gsLanguage))
        sSQL.Append(" ORDER BY DisplayOrder, Code ")
        'Combo kỳ
        Dim dt As DataTable
        dt = ReturnDataTable(sSQL.ToString)
        LoadDataSource(tdbcCode1, dt.Copy, gbUnicode)
        LoadDataSource(tdbcCode2, dt.Copy, gbUnicode)
        LoadDataSource(tdbcCode3, dt.Copy, gbUnicode)
    End Sub

    Private Function AllowPrint() As Boolean

        If tdbcReportID.Text = "" Then
            tdbcReportTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        Else
            tdbcReportTypeID.EditorBackColor = Color.White
        End If

        If tdbcReportID.Text.Trim = "" Then
            If tdbcReportTypeID.Text.Trim = "" Then
                D99C0008.MsgNotYetChoose(rl3("Mau_chuan"))
                tdbcReportTypeID.Focus()
                Return False
            End If
        End If

        If tdbcDivisionID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Don_vi"))
            tdbcDivisionID.Focus()
            Return False
        End If

        If tdbcFromperiodID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Ky"))
            tdbcFromperiodID.Focus()
            Return False
        End If

        If tdbcToPeriodID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Ky"))
            tdbcToPeriodID.Focus()
            Return False
        End If
        If Not CheckValidPeriodFromTo(tdbcFromperiodID, tdbcToPeriodID) Then Return False
        Return True
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P3900
    '# Created User: DOAN NHU THANH
    '# Created Date: 28/02/2008 10:02:48
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P3900() As String
        Dim sSQL As String = ""
        sSQL &= ("-- In bao cao phan bo khau hao" & vbCrLf)
        sSQL &= "Exec D02P3900 "
        sSQL &= SQLString(tdbcDivisionID.Text) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLNumber(tdbcFromperiodID.Columns(1).Text) & COMMA 'FromMonth, tinyint, NOT NULL
        sSQL &= SQLNumber(tdbcFromperiodID.Columns(2).Text) & COMMA 'FromYear, smallint, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns(1).Text) & COMMA 'ToMonth, tinyint, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns(2).Text) & COMMA 'ToYear, smallint, NOT NULL
        sSQL &= SQLNumber(chkShowStopDepreciationAssets.Checked) & COMMA
        sSQL &= SQLNumber(gbUnicode) & COMMA 'CodeTable, tinyint, NOT NULL
        sSQL &= SQLString(gsUserID) 'UserID, varchar[50], NOT NULL 'Them ngay 29/8/2012 theo incident 50767 cua HOANGTUAN boi VANVINH
        Return sSQL
    End Function

    Private Sub PrintData()
        btnPrint.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        'Dim report As New D99C1003
        'Đưa vể đầu tiên hàm In trước khi gọi AllowPrint()
		If Not AllowNewD99C2003(report, Me) Then Exit Sub
		'************************************
        Dim conn As New SqlConnection(gsConnectionString)
        Dim sReportName As String = ""
        Dim sSubReportName As String = "D02R0000"
        Dim sReportCaption As String = ""
        Dim sPathReport As String = ""
        Dim sSQL As String = ""
        Dim sSQLSub As String = ""

        sSQL = SQLStoreD02P3900()
        ' sSQLSub = "Select Top 1 * from D91T0025 "
        ' sSQLSub = "Select Top 1 * from D91T0025 "
        'Sửa lại câu đổ nguồn cho Sub Report 
        'Incident 49629, Bảo Chi (16/7/2012)
        sSQLSub = "Select * from D91V0016 where DivisionID = " & SQLString(ReturnValueC1Combo(tdbcDivisionID).ToString)

        If tdbcReportID.Text = "" Then
            sReportName = tdbcReportTypeID.Text
        Else
            sReportName = tdbcReportID.Text
        End If
        sReportCaption = rl3("Bao_cao_phan_bo_khau_hao_") & " - " & sReportName
        sPathReport = UnicodeGetReportPath(gbUnicode, D02Options.ReportLanguage, tdbcReportID.Text) & sReportName & ".rpt"
        UnicodeSubReport(sSubReportName, sSQLSub, ReturnValueC1Combo(tdbcDivisionID).ToString, gbUnicode)
        'If tdbcReportID.Text = "" Then
        '    sReportName = tdbcReportTypeID.Text
        '    sReportCaption = rl3("Bao_cao_phan_bo_khau_hao_") & " - " & sReportName
        '    If D02Options.ReportLanguage = 0 Then
        '        sPathReport = Application.StartupPath & "\XReports\" & sReportName & ".rpt"
        '    ElseIf D02Options.ReportLanguage = 1 Then
        '        sPathReport = Application.StartupPath & "\XReports\VE-XReports\" & sReportName & ".rpt"
        '    ElseIf D02Options.ReportLanguage = 2 Then
        '        sPathReport = Application.StartupPath & "\XReports\E-XReports\" & sReportName & ".rpt"
        '    End If

        'Else
        '    sReportName = tdbcReportID.Text
        '    sReportCaption = rl3("Bao_cao_phan_bo_khau_hao_") & " - " & sReportName
        '    sPathReport = Application.StartupPath & "\Xcustom\" & sReportName & ".rpt"

        'End If

        With report
            .OpenConnection(conn)
            .AddSub(sSQLSub, sSubReportName & ".rpt")
            .AddMain(sSQL)
            .PrintReport(sPathReport, sReportCaption)
        End With

        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True
    End Sub

    'Private Sub PrintDataWS()
    '    btnPrint.Enabled = False
    '    Me.Cursor = Cursors.WaitCursor
    '    bPrintUnicode = gbUnicode And Not chkIsPrintVNI.Checked
    '    Dim reportWS As New D99C0009
    '    CallWebService.Url = gsAppServer & "D91W0000.asmx"
    '    CallWebService.Timeout = nWSTimeOut

    '    Dim sReportName As String = ""
    '    Dim sSubReportName As String = "D02R0000"
    '    Dim sReportCaption As String = ""
    '    Dim sPathReport As String = ""
    '    Dim sSQL As String = ""
    '    Dim sSQLSub As String = ""

    '    sSQL = SQLStoreD02P3900()
    '    ' sSQLSub = "Select Top 1 * from D91T0025 "
    '    'Sửa lại câu đổ nguồn cho Sub Report 
    '    'Incident 49629, Bảo Chi (16/7/2012)
    '    sSQLSub = "Select * from D91V0016 where DivisionID = " & SQLString(ReturnValueC1Combo(tdbcDivisionID).ToString)

    '    If tdbcReportID.Text = "" Then
    '        sReportName = tdbcReportTypeID.Text
    '    Else
    '        sReportName = tdbcReportID.Text
    '    End If
    '    sReportCaption = rl3("Bao_cao_phan_bo_khau_hao_") & " - " & sReportName & UnicodeCaption(gbUnicode)
    '    UnicodeSubReport(sSubReportName, sSQLSub, gsDivisionID, bPrintUnicode)
    '    With reportWS
    '        .OpenConnection(CallWebService.Url, gsUserID, gsCompanyID, gsWSSPara01, gsWSSPara02, gsWSSPara03, gsWSSPara04, gsWSSPara05)
    '        .AddSub(sSQLSub, sSubReportName & ".rpt")
    '        .AddMain(sSQL)
    '        .PrintReport(sReportName & ".rpt", sReportCaption)
    '    End With

    '    Me.Cursor = Cursors.Default
    '    btnPrint.Enabled = True
    'End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Not AllowPrint() Then Exit Sub
        PrintData()
        'If giAppMode = 0 Then

        '    PrintData()
        'Else
        '    PrintDataWS()
        'End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub tdbcReportID_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcReportID.ItemChanged
        If tdbcReportID.Text = "" Then
            tdbcReportTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        Else
            tdbcReportTypeID.EditorBackColor = Color.White
        End If
    End Sub

    Private Sub tdbcReportID_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcReportID.Validated
        If tdbcReportID.Text = "" Then
            tdbcReportTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        Else
            tdbcReportTypeID.EditorBackColor = Color.White
        End If
    End Sub

End Class
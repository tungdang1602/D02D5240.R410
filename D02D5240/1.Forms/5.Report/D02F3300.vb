
'#-------------------------------------------------------------------------------------
'# Created Date: 29/02/2008 11:50:14 AM
'# Created User: DOAN NHU THANH
'# Modify Date: 29/02/2008 11:50:14 AM
'# Modify User: DOAN NHU THANH
'#-------------------------------------------------------------------------------------
Public Class D02F3300
	Dim report As D99C2003


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

#Region "Events tdbcFromperiodID"

    Private Sub tdbcFromperiodID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcFromperiodID.Close
        If tdbcFromperiodID.FindStringExact(tdbcFromperiodID.Text) = -1 Then
            tdbcFromperiodID.Text = ""
            tdbcFromperiodID.Focus()
        End If

    End Sub

    Private Sub tdbcFromperiodID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcFromperiodID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcFromperiodID.Text = ""
    End Sub

    Private Sub tdbcFromperiodID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromperiodID.SelectedValueChanged
        tdbcToPeriodID.Text = tdbcFromperiodID.Text
    End Sub
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
                tdbcFromperiodID.Focus()
                Application.DoEvents()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub D02F3030_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
	LoadInfoGeneral()
        Me.Cursor = Cursors.WaitCursor
        Loadlanguage()
        SetBackColorObligatory()
        LoadTDBCombo()
        LoadDefault()
        InputbyUnicode(Me, gbUnicode)
        
    SetResolutionForm(Me)
Me.Cursor = Cursors.Default
End Sub

    Private Sub LoadDefault()
        tdbcFromPeriodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
        tdbcToPeriodID.Text = giTranMonth.ToString("00") & "/" & giTranYear
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Bao_cao_lich_su_nghiep_vu_tac_dong_-_D02F3300") & UnicodeCaption(gbUnicode) 'BÀo cÀo lÜch sõ nghiÖp vó tÀc ¢èng - D02F3300
        '================================================================ 
        lblFromperiodID.Text = rl3("Ky") 'Kỳ
        lblReportTypeID.Text = rl3("Mau_chuan") 'Mẫu chuẩn
        lblReportID.Text = rl3("Dac_thu") 'Đặc thù
        '================================================================ 
        btnPrint.Text = rl3("_In") '&In
        btnClose.Text = rl3("Do_ng") 'Đó&ng
        '================================================================ 
        grpConditionFilter.Text = rl3("Dieu_kien_loc") 'Điều kiện lọc
        grpReportForm.Text = rl3("Dang_bao_cao") 'Dạng báo cáo
        '================================================================ 

        tdbcReportID.Columns("ReportID").Caption = rl3("Ma") 'Mã
        tdbcReportID.Columns("Title").Caption = rl3("Ten") 'Tên
        tdbcReportTypeID.Columns("ReportTypeID").Caption = rl3("Mau_chuan") 'Mẫu chuẩn
        tdbcReportTypeID.Columns("ReportTypeName").Caption = rl3("Ten") 'Tên        
    End Sub

    Private Sub SetBackColorObligatory()
        tdbcReportTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcFromperiodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToPeriodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub

    Private Sub LoadTDBCombo()
        Dim sSQL As New StringBuilder(299)
        Dim sUnicode As String = UnicodeJoin(gbUnicode)
        sSQL.Append(" SELECT ReportID As ReportTypeID," & IIf(gsLanguage = "84", "Description", "Description01").ToString & sUnicode & " As ")
        sSQL.Append(" ReportTypeName, StrSQL, ReportType ")
        sSQL.Append(" FROM D02V5555 ")
        sSQL.Append(" WHERE ReportType = 'D02F3300' ")
        sSQL.Append(" ORDER BY ReportTypeID")
        'Combo Mẫu chuẩn
        LoadDataSource(tdbcReportTypeID, sSQL.ToString, gbUnicode)

        sSQL.Remove(0, sSQL.Length)
        sSQL.Append(" SELECT A.ReportID, A.Title" & sUnicode & " as Title, B.ModuleID, B.ReportTypeID, B.ReportTypeName" & sUnicode & " as ReportTypeName ")
        sSQL.Append(" FROM D89T1000 A  WITH (NOLOCK) Inner Join D89T0010 B  WITH (NOLOCK) On  A.ReportTypeID = B.ReportTypeID ")
        sSQL.Append(" WHERE A.ModuleID = '02' And A.ReportTypeID Like 'D02F3300_' ")
        sSQL.Append(" And (DAGroupID= '' Or DAGroupID In (Select DAGroupID From Lemonsys.Dbo.D00V0080 ")
        sSQL.Append(" Where UserID = " & SQLString(gsUserID) & " Or UserID = 'LEMONADMIN')) ")
        sSQL.Append(" ORDER BY	A.ReportTypeID")
        'Combo Đặc thù
        LoadDataSource(tdbcReportID, sSQL.ToString, gbUnicode)

        'Combo kỳ
        LoadCboPeriodReport(tdbcFromperiodID, tdbcToPeriodID, D02)
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
    '# Title: SQLStoreD02P3300
    '# Created User: DOAN NHU THANH
    '# Created Date: 28/02/2008 11:17:12
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------

    Private Function SQLStoreD02P3300() As String
        Dim sSQL As String = ""
        Dim LsPeriod As String
        If gbUnicode And geLanguage = EnumLanguage.Vietnamese Then
            LsPeriod = "Từ kỳ: " & tdbcFromperiodID.Columns(1).Text + " - Đến kỳ: " & tdbcToPeriodID.Columns(1).Text
        Else
            LsPeriod = rl3("Tu_ky_V") & " " & tdbcFromperiodID.Columns(1).Text + " - " & rl3("_Den_ky_") & " " & tdbcToPeriodID.Columns(1).Text
        End If

        sSQL &= "Exec D02P3300 "
        sSQL &= SQLString(gsDivisionID) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLNumber(tdbcFromperiodID.Columns(1).Text) & COMMA 'FromMonth, tinyint, NOT NULL
        sSQL &= SQLNumber(tdbcFromperiodID.Columns(2).Text) & COMMA 'FromYear, int, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns(1).Text) & COMMA 'ToMonth, tinyint, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns(2).Text) & COMMA 'ToYear, int, NOT NULL
        sSQL &= "N" & SQLString(LsPeriod)  'LsPeriod, varchar[50], NOT NULL
        sSQL &= COMMA & SQLNumber(gbUnicode)
        Return sSQL

    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P3301
    '# Created User: DOAN NHU THANH
    '# Created Date: 28/02/2008 11:17:26
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P3301() As String
        Dim sSQL As String = ""
        Dim LsPeriod As String
        If gbUnicode And geLanguage = EnumLanguage.Vietnamese Then
            LsPeriod = "Từ kỳ: " & tdbcFromperiodID.Columns(1).Text + " - Đến kỳ: " & tdbcToPeriodID.Columns(1).Text
        Else
            LsPeriod = rl3("Tu_ky_V") & " " & tdbcFromperiodID.Columns(1).Text + " - " & rl3("_Den_ky_") & " " & tdbcToPeriodID.Columns(1).Text
        End If
        sSQL &= "Exec D02P3301 "
        sSQL &= SQLString(gsDivisionID) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLNumber(tdbcFromperiodID.Columns(1).Text) & COMMA 'FromMonth, tinyint, NOT NULL
        sSQL &= SQLNumber(tdbcFromperiodID.Columns(2).Text) & COMMA 'FromYear, int, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns(1).Text) & COMMA 'ToMonth, tinyint, NOT NULL
        sSQL &= SQLNumber(tdbcToPeriodID.Columns(2).Text) & COMMA 'ToYear, int, NOT NULL
        sSQL &= "N" & SQLString(LsPeriod) 'LsPeriod, varchar[50], NOT NULL
        sSQL &= COMMA & SQLNumber(gbUnicode)
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

        sSQLSub = "Select Top 1 * from D91T0025  WITH (NOLOCK) "
        UnicodeSubReport(sSubReportName, sSQLSub, gsDivisionID, gbUnicode)
        If tdbcReportID.Text = "" Then
            sReportName = tdbcReportTypeID.Text
            If sReportName = "D02R3300" Then
                sSQL = SQLStoreD02P3300()
            Else
                sSQL = SQLStoreD02P3301()
            End If

            sReportCaption = rl3("Bao_cao_lich_su_nghiep_vu_tac_dong_") & " - " & sReportName
            'If D02Options.ReportLanguage = 0 Then
            '    sPathReport = Application.StartupPath & "\XReports\" & sReportName & ".rpt"
            'ElseIf D02Options.ReportLanguage = 1 Then
            '    sPathReport = Application.StartupPath & "\XReports\VE-XReports\" & sReportName & ".rpt"
            'ElseIf D02Options.ReportLanguage = 2 Then
            '    sPathReport = Application.StartupPath & "\XReports\E-XReports\" & sReportName & ".rpt"
            'End If

        Else
            sReportName = tdbcReportID.Text
            If tdbcReportID.Columns(3).Text = "D02F3300A" Then
                sSQL = SQLStoreD02P3300()
            Else
                sSQL = SQLStoreD02P3301()
            End If

            sReportCaption = rl3("Bao_cao_lich_su_nghiep_vu_tac_dong_") & " - " & sReportName
            'sPathReport = Application.StartupPath & "\Xcustom\" & sReportName & ".rpt"

        End If
        sPathReport = UnicodeGetReportPath(gbUnicode, D02Options.ReportLanguage, tdbcReportID.Text) & sReportName & ".rpt"
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

    '    Dim reportWS As New D99C0009
    '    CallWebService.Url = gsAppServer & "D91W0000.asmx"
    '    CallWebService.Timeout = nWSTimeOut

    '    Dim sReportName As String = ""
    '    Dim sSubReportName As String = "D02R0000"
    '    Dim sReportCaption As String = ""
    '    Dim sPathReport As String = ""
    '    Dim sSQL As String = ""
    '    Dim sSQLSub As String = ""

    '    sSQL = ""
    '    sSQLSub = "Select Top 1 * from D91T0025 WITH (NOLOCK)  "

    '    If tdbcReportID.Text = "" Then
    '        sReportName = tdbcReportTypeID.Text
    '        If sReportName = "D02R3300" Then
    '            sSQL = SQLStoreD02P3300()
    '        Else
    '            sSQL = SQLStoreD02P3301()
    '        End If
    '        sReportCaption = rl3("Bao_cao_lich_su_nghiep_vu_tac_dong_") & " - " & sReportName
    '    Else
    '        sReportName = tdbcReportID.Text
    '        If tdbcReportID.Columns(3).Text = "D02F3300A" Then
    '            sSQL = SQLStoreD02P3300()
    '        Else
    '            sSQL = SQLStoreD02P3301()
    '        End If
    '        sReportCaption = rl3("Bao_cao_lich_su_nghiep_vu_tac_dong_") & " - " & sReportName
    '    End If

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

    Private Sub tdbcReportID_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcReportID.Validated
        If tdbcReportID.Text = "" Then
            tdbcReportTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        Else
            tdbcReportTypeID.EditorBackColor = Color.White
        End If
    End Sub

    Private Sub tdbcReportID_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcReportID.ItemChanged
        If tdbcReportID.Text = "" Then
            tdbcReportTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        Else
            tdbcReportTypeID.EditorBackColor = Color.White
        End If
    End Sub

End Class
'#-------------------------------------------------------------------------------------
'# Created Date: 29/02/2008 11:50:28 AM
'# Created User: DOAN NHU THANH
'# Modify Date: 29/02/2008 11:50:28 AM
'# Modify User: DOAN NHU THANH
'#-------------------------------------------------------------------------------------
Public Class D02F3025
	Dim report As D99C2003
    Dim dtACodeID As DataTable
    Dim sFromMonth As String
    Dim sToMonth As String
    Dim sFromYear As String
    Dim sToYear As String

    Dim oFilterCheck As Lemon3.Controls.FilterCheckCombo

#Region "Events tdbcDivisionID with txtDivisionName"

    Private Sub tdbcDivisionID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.SelectedValueChanged
        'If tdbcDivisionID.SelectedValue Is Nothing Then
        '    txtDivisionName.Text = ""
        'Else
        '    txtDivisionName.Text = tdbcDivisionID.Columns(1).Value.ToString
        'End If
        ' LoadTDBCAssetID(tdbcACodeID.Columns(2).Value.ToString)
    End Sub

    Private Sub tdbcDivisionID_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.LostFocus
        'If tdbcDivisionID.FindStringExact(tdbcDivisionID.Text) = -1 Then
        '    tdbcDivisionID.Text = ""
        'End If
    End Sub

    Private Sub tdbcDivisionID_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcDivisionID.Validated
        oFilterCheck.FilterCheckCombo(tdbcDivisionID, e)
        LoadTDBCAssetID(tdbcACodeID.Columns(2).Value.ToString)

    End Sub

#End Region

#Region "Events tdbcReportID with txtReportName"

    Private Sub tdbcReportID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportID.Close
        If tdbcReportID.FindStringExact(tdbcReportID.Text) = -1 Then
            'tdbcReportID.Text = ""
            txtReportName.Text = ""
        End If

        
    End Sub

    Private Sub tdbcReportID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcReportID.SelectedValueChanged
        txtReportName.Text = tdbcReportID.Columns(1).Value.ToString
    End Sub

    Private Sub tdbcReportID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcReportID.KeyDown
        'If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
        '    tdbcReportID.Text = ""
        '    txtReportName.Text = ""
        'End If
    End Sub

#End Region

#Region "Events tdbcGroupTypeID"

    Private Sub tdbcGroupTypeID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.Close
        If tdbcGroupTypeID.FindStringExact(tdbcGroupTypeID.Text) = -1 Then
            tdbcGroupTypeID.Text = ""
            tdbcGroupTypeID.Focus()
        End If
    End Sub

    Private Sub tdbcGroupTypeID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.SelectedValueChanged
        If tdbcGroupTypeID.Text.Trim = "%" Then
            LoadDataSource(tdbcACodeID, ReturnTableFilter(dtACodeID, "TypeCodeID LIKE '%'"), gbUnicode)
        Else
            LoadDataSource(tdbcACodeID, ReturnTableFilter(dtACodeID, "TypeCodeID = '%' OR TypeCodeID LIKE " & SQLString(tdbcGroupTypeID.Text)), gbUnicode)
        End If
        tdbcACodeID.SelectedValue = "%"
    End Sub

    Private Sub tdbcGroupTypeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcGroupTypeID.KeyDown
        'If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcGroupTypeID.Text = ""
    End Sub

#End Region

#Region "Events tdbcACodeID with txtACodeName"

    Private Sub tdbcACodeID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcACodeID.Close
        If tdbcACodeID.FindStringExact(tdbcACodeID.Text) = -1 Then
            tdbcACodeID.Text = ""
            txtACodeName.Text = ""
            tdbcACodeID.Focus()
        End If
    End Sub

    Private Sub tdbcACodeID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcACodeID.SelectedValueChanged
        If tdbcACodeID.SelectedValue Is Nothing Then
            txtACodeName.Text = ""
        Else
            txtACodeName.Text = tdbcACodeID.Columns(1).Value.ToString
        End If
        LoadTDBCAssetID(tdbcACodeID.Columns(2).Value.ToString)
    End Sub

    Private Sub tdbcACodeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcACodeID.KeyDown
        'If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
        '    tdbcACodeID.Text = ""
        '    txtACodeName.Text = ""
        'End If
    End Sub

#End Region

#Region "Events tdbcFromAssetID"

    Private Sub tdbcFromAssetID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.Close
        If tdbcFromAssetID.FindStringExact(tdbcFromAssetID.Text) = -1 Then
            tdbcFromAssetID.Text = ""
            tdbcFromAssetID.Focus()
        End If

    End Sub

    'Private Sub tdbcFromAssetID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcFromAssetID.KeyDown
    '    If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcFromAssetID.Text = ""
    'End Sub

    Private Sub tdbcFromAssetID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.SelectedValueChanged
        If tdbcFromAssetID.Text = "%" Then
            tdbcToAssetID.Text = ""
            tdbcToAssetID.Enabled = False
        Else
            tdbcToAssetID.Enabled = True
            tdbcToAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        End If
    End Sub
    Private Sub tdbcFromAssetID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.TextChanged
        If tdbcFromAssetID.Text = "%" Then
            tdbcToAssetID.Text = ""
            tdbcToAssetID.Enabled = False
        Else
            tdbcToAssetID.Enabled = True
            tdbcToAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        End If
    End Sub

    Private Sub tdbcFromAssetID_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.Validated
        If tdbcFromAssetID.Text = "%" Then
            tdbcToAssetID.Text = ""
            tdbcToAssetID.Enabled = False
        Else
            tdbcToAssetID.Enabled = True
            tdbcToAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        End If
    End Sub
#End Region

#Region "Events tdbcToAssetID"

    Private Sub tdbcToAssetID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcToAssetID.Close
        If tdbcToAssetID.FindStringExact(tdbcToAssetID.Text) = -1 Then
            tdbcToAssetID.Text = ""
            tdbcToAssetID.Focus()
        End If

    End Sub

    Private Sub tdbcToAssetID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcToAssetID.KeyDown
        'If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcToAssetID.Text = ""
    End Sub

#End Region

#Region "Events tdbcFromperiodID"

    Private Sub tdbcFromperiodID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcFromperiodID.Close
        If tdbcFromperiodID.FindStringExact(tdbcFromperiodID.Text) = -1 Then
            tdbcFromperiodID.Text = ""
            tdbcFromperiodID.Focus()
        End If

        If CInt(tdbcFromperiodID.Columns(2).Text) > CInt(tdbcToPeriodID.Columns(2).Text) Then
            D99C0008.MsgL3(rl3("Ky_khong_hop_le"))
            tdbcToPeriodID.Focus()
        ElseIf CInt(tdbcFromperiodID.Columns(2).Text) = CInt(tdbcToPeriodID.Columns(2).Text) And CInt(tdbcFromperiodID.Columns(1).Text) > CInt(tdbcToPeriodID.Columns(1).Text) Then
            D99C0008.MsgL3(rl3("Ky_khong_hop_le"))
            tdbcToPeriodID.Focus()
        End If
    End Sub

    Private Sub tdbcFromperiodID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcFromperiodID.KeyDown
        'If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcFromperiodID.Text = ""
    End Sub

    Private Sub tdbcFromperiodID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromperiodID.SelectedValueChanged
        tdbcToPeriodID.Text = tdbcFromperiodID.Text
        LoadTDBCAssetID(tdbcACodeID.Columns(2).Value.ToString)
    End Sub
#End Region

#Region "Events tdbcToPeriodID"

    Private Sub tdbcToPeriodID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcToPeriodID.Close
        If tdbcToPeriodID.FindStringExact(tdbcToPeriodID.Text) = -1 Then
            tdbcToPeriodID.Text = ""
            tdbcToPeriodID.Focus()
        End If

        If CInt(tdbcFromperiodID.Columns(2).Text) > CInt(tdbcToPeriodID.Columns(2).Text) Then
            D99C0008.MsgL3(rl3("Ky_khong_hop_le"))
            tdbcToPeriodID.Focus()
        ElseIf CInt(tdbcFromperiodID.Columns(2).Text) = CInt(tdbcToPeriodID.Columns(2).Text) And CInt(tdbcFromperiodID.Columns(1).Text) > CInt(tdbcToPeriodID.Columns(1).Text) Then
            D99C0008.MsgL3(rl3("Ky_khong_hop_le"))
            tdbcToPeriodID.Focus()
        End If
    End Sub

    Private Sub tdbcToPeriodID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcToPeriodID.KeyDown
        'If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcToPeriodID.Text = ""
    End Sub

    Private Sub tdbcToPeriodID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcToPeriodID.SelectedValueChanged
        LoadTDBCAssetID(tdbcACodeID.Columns(2).Value.ToString)
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
                tdbcReportID.Focus()
                Application.DoEvents()
                Exit Sub
            ElseIf e.KeyCode = Keys.NumPad2 Or e.KeyCode = Keys.D2 Then
                Application.DoEvents()
                tdbcGroupTypeID.Focus()
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

        InputbyUnicode(Me, gbUnicode)

        'ID 79323 10/9/2015
        oFilterCheck = New Lemon3.Controls.FilterCheckCombo
        'oFilterCheck.Separator= ";" 'Mặc định hiển thị trên combo là ;. Chỉ truyền biến này khi phân cách các giá trị là ký tự khác ; trên combo
        oFilterCheck.UseFilterCheckCombo(tdbcDivisionID)
        LoadDefault()
    SetResolutionForm(Me)
Me.Cursor = Cursors.Default
End Sub

    Private Sub LoadDefault()
        'tdbcDivisionID.Text = gsDivisionID
        'ID 79323 10/9/2015
        oFilterCheck.SetValue(tdbcDivisionID, gsDivisionID) 'Không dùng tdbcxxx.SelectedValue=.Item("xxxx").ToString

        txtReportTypeID.Text = "D02R3025"
        Dim sName As String = rl3("A4_L_Tong_ket_khau_hao_TSCD")
        If gbUnicode And geLanguage = EnumLanguage.Vietnamese Then sName = ConvertVniToUnicode(sName)
        txtReportTypeName.Text = sName

        tdbcFromAssetID.SelectedValue = "%"
        tdbcFromperiodID.Enabled = False
        tdbcToPeriodID.Enabled = False
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Bao_cao_tong_ket_khau_hao_TSCD_-_D02F3025") & UnicodeCaption(gbUnicode) 'BÀo cÀo tång kÕt khÊu hao TSC˜ - D02F3025
        '================================================================ 
        lblGroupTypeID.Text = rl3("Phan_loai") 'Phân loại
        lblFromAssetID.Text = rl3("Tai_san") 'Tài sản
        lblReportTypeID.Text = rl3("Mau_chuan") 'Mẫu chuẩn
        lblReportID.Text = rl3("Dac_thu") 'Đặc thù
        lblDivisionID.Text = rl3("Don_vi") 'Đơn vị
        lbl1.Text = "1. " & rl3("Don_vi") 'Đơn vị
        lbl2.Text = "2. " & rl3("Mau_bao_cao") 'Mẫu báo cáo
        lbl3.Text = "3. " & rl3("Tieu_thuc_loc") 'Tiêu thức lọc
        '================================================================ 
        chkShowLiquidateTransaction.Text = rL3("Hien_thi_but_toan_thanh_ly") 'Hiển thị bút toán thanh lý
        '================================================================ 
        btnPrint.Text = rl3("_In") '&In
        btnFilter.Text = rl3("_Loc") '&Lọc
        btnClose.Text = rl3("Do_ng") 'Đó&ng
        '================================================================ 
        chkPeriod.Text = rl3("Ky") 'Kỳ
        chkNoShowLiquidatedAssets.Text = rl3("Khong_hien_thi_cac_tai_san_da_thanh_ly")
        '================================================================ 
        tdbcDivisionID.Columns("DivisionID").Caption = rl3("Ma") 'Mã
        tdbcDivisionID.Columns("DivisionName").Caption = rl3("Ten") 'Tên
        tdbcToAssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcToAssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên
        tdbcFromAssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcFromAssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên
        tdbcACodeID.Columns("ACodeID").Caption = rl3("Ma") 'Mã
        tdbcACodeID.Columns("Description").Caption = rl3("Ten") 'Tên
        tdbcGroupTypeID.Columns("GroupTypeID").Caption = rl3("Ma") 'Mã
        tdbcGroupTypeID.Columns("GroupCaption").Caption = rl3("Ten") 'Tên        
        tdbcReportID.Columns("ReportID").Caption = rl3("Ma") 'Mã
        tdbcReportID.Columns("Title").Caption = rl3("Ten") 'Tên        
    End Sub

    Private Sub SetBackColorObligatory()
        tdbcGroupTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcACodeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcFromAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcFromperiodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToPeriodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub

    Private Sub LoadTDBCombo()
        Dim sSQL As New StringBuilder(299)

        'Load tdbcDivisionID
        LoadCboDivisionIDReport(tdbcDivisionID, D02, False, gbUnicode)
        Dim sUnicode As String = UnicodeJoin(gbUnicode)

        'Combo Đặc thù
        sSQL.Append(" SELECT A.ReportID, A.Title" & sUnicode & " as Title, B.ModuleID, B.ReportTypeID, B.ReportTypeName" & sUnicode & " as ReportTypeName ")
        sSQL.Append(" FROM D89T1000 A  WITH (NOLOCK) Inner Join D89T0010 B  WITH (NOLOCK) On  A.ReportTypeID = B.ReportTypeID ")
        sSQL.Append(" WHERE A.ModuleID = '02' And A.ReportTypeID Like 'D02F3025' ")
        sSQL.Append(" And (DAGroupID= '' Or DAGroupID In (Select DAGroupID From Lemonsys.Dbo.D00V0080 ")
        sSQL.Append(" Where UserID = " & SQLString(gsUserID) & " Or UserID = 'LEMONADMIN')) ")
        sSQL.Append(" ORDER BY	A.ReportTypeID")
        LoadDataSource(tdbcReportID, sSQL.ToString, gbUnicode)

        'Combo ACodeID
        sSQL.Remove(0, sSQL.Length)
        sSQL.Append(" SELECT 0 as DisplayOrder,'%' as ACodeID, " & AllName & " as Description, '%'  As TypeCodeID ")
        sSQL.Append(" UNION ALL ")
        sSQL.Append(" SELECT 1 as DisplayOrder,ACodeID, Description" & sUnicode & " as Description, TypeCodeID As GroupTypeID ")
        sSQL.Append(" FROM D02V4444  ")
        sSQL.Append(" ORDER BY DisplayOrder,ACodeID")
        dtACodeID = ReturnDataTable(sSQL.ToString)
        LoadDataSource(tdbcACodeID, dtACodeID.DefaultView.ToTable, gbUnicode)

        'Combo Phân loại
        sSQL.Remove(0, sSQL.Length)
        sSQL.Append(" SELECT GroupTypeID, " & IIf(gsLanguage = "84", "VieTypeCaption", "EngTypeCaption").ToString & sUnicode & " As GroupCaption, ")
        sSQL.Append(" TableName, WhereClause, FieldName ")
        sSQL.Append(" FROM D02V3333 ")
        sSQL.Append(" ORDER BY GroupTypeID ")
        LoadDataSource(tdbcGroupTypeID, sSQL.ToString, gbUnicode)

        'Combo kỳ
        LoadCboPeriodReport(tdbcFromperiodID, tdbcToPeriodID, D02)

        Dim dt As DataTable
        sSQL.Remove(0, sSQL.Length)
        'Combo Tài sản
        sSQL.Append(" SELECT 0 as DisplayOrder,'%' As AssetID, " & AllName & " As AssetName ")
        sSQL.Append(" Union All  ")
        sSQL.Append(" SELECT 1 as DisplayOrder,AssetID, AssetName" & sUnicode & " as AssetName")
        sSQL.Append(" FROM D02T0001  WITH (NOLOCK) ")
        sSQL.Append(" WHERE Disabled = 0  ")
        sSQL.Append(" AND IsCompleted = 1 ")
        sSQL.Append(" AND TranMonth + TranYear*100 <= " & giTranMonth + giTranYear * 100)
        sSQL.Append(" AND DivisionID LIKE " & SQLString(tdbcDivisionID.Text))
        sSQL.Append(" ORDER BY DisplayOrder,AssetID")

        dt = ReturnDataTable(sSQL.ToString)
        LoadDataSource(tdbcFromAssetID, dt.DefaultView.ToTable, gbUnicode)
        LoadDataSource(tdbcToAssetID, dt.DefaultView.ToTable, gbUnicode)

    End Sub

    Private Sub LoadTDBCAssetID(ByVal sGroupTypeID As String)
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
        If chkPeriod.Checked Then
            sSQL.Append(" And TranMonth + TranYear*100 >= " & Number(tdbcFromperiodID.Columns("TranMonth").Text) & "+" & Number(tdbcFromperiodID.Columns("TranYear").Text) & "*100 " & vbCrLf)
            sSQL.Append(" And TranMonth + TranYear*100 <= " & Number(tdbcToPeriodID.Columns("TranMonth").Text) & "+" & Number(tdbcToPeriodID.Columns("TranYear").Text) & "*100  " & vbCrLf)
        Else
            sSQL.Append(" And TranMonth + TranYear*100 <= " & giTranMonth + giTranYear * 100 & vbCrLf)
        End If
        If tdbcDivisionID.Text = "" Then
            sSQL.Append(" And DivisionID LIKE " & SQLString(tdbcDivisionID.Text) & vbCrLf)
        ElseIf ReturnValueC1Combo(tdbcDivisionID).ToString = "%" Then
            sSQL.Append(" And DivisionID LIKE " & SQLString(ReturnValueC1Combo(tdbcDivisionID)) & vbCrLf)
        Else
            sSQL.Append(" And DivisionID IN " & oFilterCheck.GetValueServer(tdbcDivisionID) & vbCrLf)
        End If
        'sSQL.Append(" And DivisionID IN (" & SQLString(oFilterCheck.GetValueServer(tdbcDivisionID)) & ")" & vbCrLf)
            'If sGroupTypeID <> "" And sGroupTypeID <> "%" Then
            '    If sACode.Length = 2 Then
            '        sSQL.Append(" And ACode" & sACode & "ID = " & SQLString(tdbcACodeID.Text))
            '    Else
            '        sSQL.Append(" And " & sACode & " = " & SQLString(tdbcACodeID.Text))
            '    End If
            'End If
            If tdbcGroupTypeID.Text <> "" And tdbcGroupTypeID.Text <> "%" And tdbcACodeID.Text <> "" And tdbcACodeID.Text <> "%" Then
                sSQL.Append(" And " & tdbcGroupTypeID.Columns("FieldName").Value.ToString & " LIKE " & SQLString(tdbcACodeID.Text) & vbCrLf)
                If tdbcGroupTypeID.Columns("FieldName").Value.ToString = "ObjectID" Then
                    sSQL.Append(" And ObjectTypeID = " & SQLString(tdbcGroupTypeID.Text))
                End If
            End If

            sSQL.Append(" Order By DisplayOrder,AssetID")

            Dim dt As DataTable
            dt = ReturnDataTable(sSQL.ToString)
            LoadDataSource(tdbcFromAssetID, dt.DefaultView.ToTable, gbUnicode)
            LoadDataSource(tdbcToAssetID, dt.DefaultView.ToTable, gbUnicode)

            tdbcFromAssetID.SelectedValue = "%"
    End Sub

    Private Function GetAcode(ByVal sGroupTypeID As String) As String
        Dim sACode As String
        Select Case sGroupTypeID
            Case "A01", "A02", "A03", "A04", "A05", "A06", "A07", "A08", "A09", "A10"
                sACode = sGroupTypeID.Substring(1, 2)
            Case Else
                sACode = sGroupTypeID
        End Select

        Return sACode
    End Function

    Private Function AllowPrint() As Boolean
        If tdbcReportID.Text.Trim = "" Then
            If txtReportTypeID.Text.Trim = "" Then
                D99C0008.MsgNotYetChoose(rl3("Mau_chuan"))
                txtReportTypeID.Focus()
                Return False
            End If
        End If

        If tdbcGroupTypeID.Text.Trim = "" Then
            If tdbcGroupTypeID.Text.Trim = "" Then
                D99C0008.MsgNotYetChoose(rl3("Phan_loai"))
                tdbcGroupTypeID.Focus()
                Return False
            End If
        End If

        If tdbcACodeID.Text.Trim = "" Then
            If tdbcACodeID.Text.Trim = "" Then
                D99C0008.MsgNotYetChoose(rl3("Phan_loai"))
                tdbcACodeID.Focus()
                Return False
            End If
        End If

        If tdbcFromAssetID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Tai_san"))
            tdbcFromAssetID.Focus()
            Return False
        End If

        If tdbcFromAssetID.Text.Trim <> "%" Then
            If tdbcToAssetID.Text.Trim = "" Then
                D99C0008.MsgNotYetChoose(rl3("Tai_san"))
                tdbcToAssetID.Focus()
                Return False
            End If
        End If

        If chkPeriod.Checked Then
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
        End If
        Return True
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

        If chkPeriod.Checked Then
            sFromMonth = tdbcFromperiodID.Columns(1).Text
            sFromYear = tdbcFromperiodID.Columns(2).Text
            sToMonth = tdbcToPeriodID.Columns(1).Text
            sToYear = tdbcToPeriodID.Columns(2).Text
            sSQL = SQLStoreD02P3025("1")
        Else
            sFromMonth = giTranMonth.ToString
            sFromYear = giTranYear.ToString
            sToMonth = tdbcToPeriodID.Columns(1).Text
            sToYear = tdbcToPeriodID.Columns(2).Text
            sSQL = SQLStoreD02P3025("0")
        End If

        'ExecuteSQL(sSQL)
        Dim sUnicode As String = UnicodeJoin(gbUnicode)
        'Theo ThanhLong thi khong dung view nay nua. ma trả dữ liệu ra từ store luon
        'sSQL = "SELECT * "
        'sSQL &= " FROM D02V3025 WHERE UserID=" & SQLString(gsUserID)
        'If sFind <> "" Then sSQL &= " " & sFind
        'sSQL &= " ORDER BY GroupID,AssetID "

        sSQLSub = "Select Top 1 * from D91T0025  WITH (NOLOCK) "
        UnicodeSubReport(sSubReportName, sSQLSub, oFilterCheck.GetValueTDBCDivision(tdbcDivisionID), gbUnicode)
        If tdbcReportID.Text = "" Then
            sReportName = txtReportTypeID.Text

            sReportCaption = rl3("Bao_cao_tong_ket_khau_hao_TSCD") & " - " & sReportName

            'If D02Options.ReportLanguage = 0 Then
            '    sPathReport = Application.StartupPath & "\XReports\" & sReportName & ".rpt"
            'ElseIf D02Options.ReportLanguage = 1 Then
            '    sPathReport = Application.StartupPath & "\XReports\VE-XReports\" & sReportName & ".rpt"
            'ElseIf D02Options.ReportLanguage = 2 Then
            '    sPathReport = Application.StartupPath & "\XReports\E-XReports\" & sReportName & ".rpt"
            'End If

        Else
            sReportName = tdbcReportID.Text
            sReportCaption = rl3("Bao_cao_tong_ket_khau_hao_TSCD") & " - " & sReportName
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

    '    If chkPeriod.Checked Then
    '        sFromMonth = tdbcFromperiodID.Columns(1).Text
    '        sFromYear = tdbcFromperiodID.Columns(2).Text
    '        sToMonth = tdbcToPeriodID.Columns(1).Text
    '        sToYear = tdbcToPeriodID.Columns(2).Text

    '        sSQL = SQLStoreD02P3025("1")
    '    Else
    '        sFromMonth = giTranMonth.ToString
    '        sFromYear = giTranYear.ToString
    '        sToMonth = tdbcToPeriodID.Columns(1).Text
    '        sToYear = tdbcToPeriodID.Columns(2).Text

    '        sSQL = SQLStoreD02P3025("0")
    '    End If

    '    ExecuteSQL(sSQL)

    '    sSQL = " SELECT * FROM D02V3025 WHERE UserID=" & SQLString(gsUserID)
    '    If sFind <> "" Then sSQL &= " " & sFind
    '    sSQL &= " ORDER BY GroupID,AssetID "

    '    sSQLSub = "Select Top 1 * from D91T0025  WITH (NOLOCK) "

    '    If tdbcReportID.Text = "" Then
    '        sReportName = txtReportTypeID.Text
    '        sReportCaption = rL3("Bao_cao_tong_ket_khau_hao_TSCD") & " - " & sReportName
    '    Else
    '        sReportName = tdbcReportID.Text
    '        sReportCaption = rL3("Bao_cao_tong_ket_khau_hao_TSCD") & " - " & sReportName
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


    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        If Not AllowPrint() Then Exit Sub
        Dim sSQL As String = ""
        gbEnabledUseFind = True
        sSQL = "Select * From D02V1234 "
        sSQL &= "Where FormID = " & SQLString(Me.Name) & "And Language = " & SQLString(gsLanguage)
        ShowFindDialog(Finder, sSQL, Me, gbUnicode)
        If sFind <> "" Then sFind = " AND " & sFind
      
       
    End Sub

    'Private Sub Finder_FindClick(ByVal ResultWhereClause As Object) Handles Finder.FindClick
    '    If ResultWhereClause Is Nothing Then Exit Sub
    '    sFind = ResultWhereClause.ToString()
    'End Sub

#End Region

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P3025
    '# Created User: DOAN NHU THANH
    '# Created Date: 03/03/2008 08:18:05
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P3025(ByVal sMode As String) As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P3025 "
        sSQL &= SQLString(gsUserID) & COMMA 'UserID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcGroupTypeID.Text) & COMMA 'GroupTypeID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcACodeID.Text) & COMMA 'TypeCodeID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcFromAssetID.Text) & COMMA 'FromAssetID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcToAssetID.Text) & COMMA 'ToAssetID, varchar[20], NOT NULL
        sSQL &= SQLNumber(sFromMonth) & COMMA 'TranMonth, int, NOT NULL
        sSQL &= SQLNumber(sFromYear) & COMMA 'TranYear, int, NOT NULL
        sSQL &= SQLNumber(sToMonth) & COMMA 'ToMonth, tinyint, NOT NULL
        sSQL &= SQLNumber(sToYear) & COMMA 'ToYear, int, NOT NULL
        sSQL &= SQLNumber(sMode) & COMMA 'Mode, tinyint, NOT NULL
        sSQL &= SQLString(oFilterCheck.GetValueServer(tdbcDivisionID)) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLNumber(gnDecreaseAsset) & COMMA  'DecreaseAsset, tinyint, NOT NULL
        sSQL &= SQLNumber(chkNoShowLiquidatedAssets.Checked) & COMMA
        sSQL &= SQLNumber(gbUnicode) & COMMA 'CodeTable, tinyint, NOT NULL
        sSQL &= SQLNumber(chkShowLiquidateTransaction.Checked)  'ShowLiquidateTransaction, tinyint, NOT NULL
        Return sSQL
    End Function

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

    Private Sub chkPeriod_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPeriod.Click
        If chkPeriod.Checked Then
            tdbcFromperiodID.Enabled = True
            tdbcToPeriodID.Enabled = True
            tdbcFromperiodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
            tdbcToPeriodID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        Else
            tdbcFromperiodID.EditorBackColor = Color.White
            tdbcToPeriodID.EditorBackColor = Color.White
            tdbcFromperiodID.Enabled = False
            tdbcToPeriodID.Enabled = False
        End If
    End Sub


End Class
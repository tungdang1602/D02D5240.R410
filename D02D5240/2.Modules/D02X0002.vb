Imports System.Text
''' <summary>
''' Module này dùng để khai báo các Sub và Function toàn cục
''' </summary>
''' <remarks>Các khai báo Sub và Function ở đây không được trùng với các khai báo
''' ở các module D99Xxxxx
''' </remarks>

Module D02X0002

    ''' <summary>
    ''' Cập nhật số thứ tự cho lưới
    ''' </summary>
    Public Sub UpdateOrderNum(ByVal TDBGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal iCol As Integer)
        For i As Integer = 0 To TDBGrid.RowCount - 1
            TDBGrid(i, iCol) = i + 1
        Next
    End Sub

    ''' <summary>
    ''' Kiểm tra sự tồn tại của 1 giá trị trong 1 cột trên lưới với nguồn dữ liệu trong TDBDropdown
    ''' </summary>
    Public Function CheckExist(ByVal pTDBD As C1.Win.C1TrueDBGrid.C1TrueDBDropdown, ByVal piCol As Integer, ByVal sText As String) As Boolean
        For i As Integer = 0 To pTDBD.RowCount - 1
            pTDBD.Row = i
            If pTDBD.Columns(piCol).Text = sText Then Return True
        Next
        Return False
    End Function

    Private Function FindSxType(ByVal nType As String, ByVal s As String) As String
        Select Case nType.Trim
            Case "1" ' Theo tháng
                Return giTranMonth.ToString("00")
            Case "2" ' Theo năm
                Return giTranYear.ToString
            Case "3" ' Theo loại chứng từ
                Return s
            Case "4" ' Theo đơn vị
                Return gsDivisionID
            Case "5" ' Theo hằng
                Return s
            Case Else
                Return ""
        End Select
    End Function

    Public Sub GetNewVoucherNo(ByVal strS1 As String, ByVal strS2 As String, ByVal strS3 As String, ByVal sOutputOrder As String, ByVal iOutputLength As Integer, ByVal sSeperator As String, ByVal txtVoucherNo As TextBox, ByVal bState As Boolean)
        Dim conn As New SqlConnection(gsConnectionString)
        'Dim strS1 As String = ""
        'Dim strS2 As String = ""
        'Dim strS3 As String = ""
        'If c1Combo.Columns("S1Type").Text <> "0" Then
        '    strS1 = FindSxType(c1Combo.Columns("S1Type").Text, c1Combo.Columns("S1").Text)
        'End If
        'If c1Combo.Columns("S2Type").Text <> "0" Then
        '    strS2 = FindSxType(c1Combo.Columns("S2Type").Text, c1Combo.Columns("S2").Text)
        'End If
        'If c1Combo.Columns("S3Type").Text <> "0" Then
        '    strS3 = FindSxType(c1Combo.Columns("S3Type").Text, c1Combo.Columns("S3").Text)
        'End If

        Dim frm As New D99F1111
        frm.NewKeyString = strS1 & strS2 & strS3
        If bState Then
            frm.ShowDialog()
            If frm.Result = True Then
                Dim iOutputOrder As Integer = -1
                Select Case sOutputOrder
                    Case "NSSS"
                        iOutputOrder = D99D0041.OutOrderEnum.lmNSSS
                    Case "SNSS"
                        iOutputOrder = D99D0041.OutOrderEnum.lmSNSS
                    Case "SSNS"
                        iOutputOrder = D99D0041.OutOrderEnum.lmSSNS
                    Case "SSSN"
                        iOutputOrder = D99D0041.OutOrderEnum.lmSSSN
                End Select
                txtVoucherNo.Text = D99C0004.IGEVoucherNo(conn, False, gnNewLastKey, strS1, strS2, strS3, CType(iOutputOrder, D99D0041.OutOrderEnum), iOutputLength, sSeperator)
                frm.Dispose()
            Else
                frm.Dispose()
            End If

        Else
            Dim iOutputOrder As Integer = -1
            Select Case sOutputOrder
                Case "NSSS"
                    iOutputOrder = D99D0041.OutOrderEnum.lmNSSS
                Case "SNSS"
                    iOutputOrder = D99D0041.OutOrderEnum.lmSNSS
                Case "SSNS"
                    iOutputOrder = D99D0041.OutOrderEnum.lmSSNS
                Case "SSSN"
                    iOutputOrder = D99D0041.OutOrderEnum.lmSSSN
            End Select
            txtVoucherNo.Text = D99C0004.IGEVoucherNo(conn, False, gnNewLastKey, strS1, strS2, strS3, CType(iOutputOrder, D99D0041.OutOrderEnum), iOutputLength, sSeperator)
            frm.Dispose()
        End If
    End Sub

    ''' <summary>
    ''' Xác định ví trí hiện hành của lưới
    ''' </summary>
    Public Sub SetCurrentRow(ByVal TDBGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal iCol As Integer, ByVal sText As String)
        If TDBGrid.RowCount > 0 Then
            For i As Integer = 0 To TDBGrid.RowCount - 1
                If TDBGrid(i, iCol).ToString() = sText Then
                    TDBGrid.Row = i
                    Exit Sub
                End If
            Next
            TDBGrid.Row = 0
        End If
    End Sub

    ''' <summary>
    ''' Tính tổng cho 1 cột tương ứng trên lưới
    ''' </summary>
    ''' <param name="ipCol"></param>
    ''' <param name="C1Grid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function Sum(ByVal ipCol As Integer, ByVal C1Grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid) As Double
        Dim lSum As Double = 0
        For i As Integer = 0 To C1Grid.RowCount - 1
            If C1Grid(i, ipCol) Is Nothing OrElse TypeOf (C1Grid(i, ipcol)) Is DBNull Then Continue For
            lSum += Convert.ToDouble(C1Grid(i, ipCol))
        Next
        Return lSum
    End Function

    ''' <summary>
    ''' TONG CONG SO DONG TREN LUOI
    ''' </summary>
    ''' <param name="iRow"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TongCong(ByVal iRow As Int32) As String
        Return IIf(geLanguage = EnumLanguage.Vietnamese, "Toång coäng", "Total").ToString & " (" & iRow & ")"
    End Function
    '#--------------------------------------------------------------------------
    '#CreateUser: Trần Thị Ái Trâm
    '#CreateDate: 04/09/2007
    '#ModifiedUser:
    '#ModifiedDate:
    '#Description: Hàm kiểm tra Audit log
    '#--------------------------------------------------------------------------
    Public Function PermissionAudit(ByVal sAuditCode As String) As Byte
        Dim sSQL As String
        Dim dt As DataTable

        sSQL = "Select Audit From D91T9200  WITH (NOLOCK) " & vbCrLf
        sSQL &= "Where AuditCode=" & SQLString(sAuditCode)

        dt = ReturnDataTable(sSQL)
        If dt.Rows.Count > 0 Then
            If CByte(dt.Rows(0).Item("Audit")) = 1 Then
                Return 1
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD91P9106
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 04/09/2007 11:30:16
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD91P9106(ByVal sAuditCode As String, ByVal sEventID As String, ByVal sDesc1 As String, ByVal sDesc2 As String, ByVal sDesc3 As String, ByVal sDesc4 As String, ByVal sDesc5 As String) As String
        Dim sSQL As String = ""
        sSQL &= "Exec D91P9106 "
        sSQL &= SQLString(Date.Today) & COMMA 'AuditDate, datetime, NOT NULL
        sSQL &= SQLString(sAuditCode) & COMMA 'AuditCode, varchar[20], NOT NULL
        sSQL &= SQLString("") & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLString("02") & COMMA 'ModuleID, varchar[2], NOT NULL
        sSQL &= SQLString(gsUserID) & COMMA 'UserID, varchar[20], NOT NULL
        sSQL &= SQLString(sEventID) & COMMA 'EventID, varchar[20], NOT NULL
        sSQL &= SQLString(sDesc1) & COMMA 'Desc1, varchar[250], NOT NULL
        sSQL &= SQLString(sDesc2) & COMMA 'Desc2, varchar[250], NOT NULL
        sSQL &= SQLString(sDesc3) & COMMA 'Desc3, varchar[250], NOT NULL
        sSQL &= SQLString(sDesc4) & COMMA 'Desc4, varchar[250], NOT NULL
        sSQL &= SQLString(sDesc5) 'Desc5, varchar[250], NOT NULL
        Return sSQL
    End Function

    '#--------------------------------------------------------------------------
    '#CreateUser: Trần Thị ÁiTrâm
    '#CreateDate: 04/09/2007
    '#ModifiedUser:
    '#ModifiedDate:
    '#Description: Thực thi store Audit Log
    '#--------------------------------------------------------------------------
    Public Sub ExecuteAuditLog(ByVal sAuditCode As String, ByVal sEventID As String, Optional ByVal sDesc1 As String = "", Optional ByVal sDesc2 As String = "", Optional ByVal sDesc3 As String = "", Optional ByVal sDesc4 As String = "", Optional ByVal sDesc5 As String = "")
        Dim sSQL As String
        sSQL = SQLStoreD91P9106(sAuditCode, sEventID, sDesc1, sDesc2, sDesc3, sDesc4, sDesc5)
        ExecuteSQL(sSQL)
    End Sub
    ''' <summary>
    ''' Load toàn bộ các thông số format cho biến D91Format
    ''' </summary>
    Public Sub LoadFormats()
        Dim sSQL As New StringBuilder

        'Format du lieu theo D90
        sSQL.Append("DECLARE @DecimalsPlace INT " & vbCrLf)
        sSQL.Append("SET @DecimalsPlace=(SELECT MAX(ISNULL(DecimalPlaces,0)) " & vbCrLf)
        sSQL.Append("FROM D91T0010  WITH (NOLOCK) " & vbCrLf)
        sSQL.Append("WHERE CurrencyID <> (SELECT TOP 1 BaseCurrencyID FROM D91T0025 WITH (NOLOCK) )) " & vbCrLf)
        sSQL.Append("SELECT TOP 1 " & vbCrLf)
        sSQL.Append("D91T0025.ExchangeRateDecimals, D91T0025.BaseCurrencyID, " & vbCrLf)
        sSQL.Append("D91T0025.D90_ConvertedDecimals, " & vbCrLf)
        sSQL.Append("D90_MaxOriginalDecimals=(CASE WHEN ISNULL(D91T0025.D90_ConvertedDecimals,0)>@DecimalsPlace " & vbCrLf)
        sSQL.Append("THEN ISNULL(D91T0025.D90_ConvertedDecimals,0) ELSE @DecimalsPlace END) " & vbCrLf)
        sSQL.Append("FROM D91T0025 WITH (NOLOCK) " & vbCrLf)
        Dim dt As DataTable = ReturnDataTable(sSQL.ToString)
        If dt.Rows.Count = 0 Then Exit Sub
        For i As Integer = 0 To dt.Rows.Count - 1
            With D02Format
                .ExchangeRateRound = Convert.ToInt16(IIf(IsDBNull(dt.Rows(i).Item("ExchangeRateDecimals")), 0, dt.Rows(i).Item("ExchangeRateDecimals")))
                .ExchangeRate = "#,##0" & InsertZero(.ExchangeRateRound)
                .BaseCurrencyID = dt.Rows(i).Item("BaseCurrencyID").ToString
                .OriginalAmountRound = Convert.ToInt16(IIf(IsDBNull(dt.Rows(i).Item("D90_MaxOriginalDecimals")), 0, dt.Rows(i).Item("D90_MaxOriginalDecimals")))
                .OriginalAmount = "#,##0" & InsertZero(.OriginalAmountRound) '.OriginalAmountRound tra ve so, vd nhu ta muon insert 4 so 0
                .ConvertedAmountRound = Convert.ToInt16(IIf(IsDBNull(dt.Rows(i).Item("D90_ConvertedDecimals")), 0, dt.Rows(i).Item("D90_ConvertedDecimals")))
                .ConvertedAmount = "#,##0" & InsertZero(.ConvertedAmountRound)
                .DefaultNumber2 = "#,##0.00"
            End With
        Next
    End Sub

    Public Function InserZero(ByVal NumZero As Byte) As String
        '#------------------------------------------------------
        '#CreateUser: Nguyen Thi Minh Hoa
        '#CreateDate: 04/04/2006
        '#ModifiedUser:  Nguyen Thi Minh Hoa
        '#ModifiedDate:  04/04/2006
        '#Description: Format so theo D91
        '#------------------------------------------------------
        'Dim i As Byte

        If NumZero = 0 Then
            InserZero = ""
        Else
            InserZero = "."
            InserZero &= StrDup(NumZero, "0")
            'For i = 0 To CByte(NumZero - 1)
            'InserZero = InserZero & "0"
            'Next i
        End If
    End Function

    '# Ngan khong cho cbo so xuong khi nhan Alt cho tab
    Public Sub AutoDropdownCbo(ByVal TDBC As C1.Win.C1List.C1Combo, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.Alt And (e.KeyCode = Keys.NumPad1 Or e.KeyCode = Keys.D1 Or e.KeyCode = Keys.NumPad2 Or e.KeyCode = Keys.D2 Or e.KeyCode = Keys.NumPad3 Or e.KeyCode = Keys.D3 Or e.KeyCode = Keys.NumPad4 Or e.KeyCode = Keys.D4) Then
            TDBC.AutoDropDown = False
        Else
            TDBC.AutoDropDown = True
        End If
    End Sub

   End Module

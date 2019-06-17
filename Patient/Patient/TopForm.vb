Imports System.Data.OleDb

Public Class TopForm

    'データベースのパス
    Public dbFilePath As String = My.Application.Info.DirectoryPath & "\Patient.mdb"
    Public DB_Patient As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbFilePath

    'エクセルのパス
    Public excelFilePass As String = My.Application.Info.DirectoryPath & "\Patient.xls"

    '.iniファイルのパス
    Public iniFilePath As String = My.Application.Info.DirectoryPath & "\Patient.ini"

    '各フォーム
    Private historyForm As 入退履歴
    Private searchForm As 検索

    ''' <summary>
    ''' keyDownイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TopForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.Control = False Then
                Me.SelectNextControl(Me.ActiveControl, Not e.Shift, True, True, True)
            End If
        End If
        If (e.Modifiers And Keys.Alt) = Keys.Alt AndAlso e.KeyCode = Keys.F12 Then
            btnZai.Visible = True
        End If
    End Sub

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TopForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'データベース、エクセル、構成ファイルの存在チェック
        If Not System.IO.File.Exists(dbFilePath) Then
            MsgBox("データベースファイルが存在しません。ファイルを配置して下さい。")
            Me.Close()
            Exit Sub
        End If

        If Not System.IO.File.Exists(excelFilePass) Then
            MsgBox("エクセルファイルが存在しません。ファイルを配置して下さい。")
            Me.Close()
            Exit Sub
        End If

        If Not System.IO.File.Exists(iniFilePath) Then
            MsgBox("構成ファイルが存在しません。ファイルを配置して下さい。")
            Me.Close()
            Exit Sub
        End If

        Me.WindowState = FormWindowState.Maximized
        Me.KeyPreview = True

        'データグリッドビュー初期設定
        initDgvUsrM()

        'データ表示
        displayDgvUsrM()

        '初期フォーカス
        codBox.Focus()
    End Sub

    ''' <summary>
    ''' データグリッドビュー初期設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initDgvUsrM()
        Util.EnableDoubleBuffering(dgvUsrM)

        With dgvUsrM
            .AllowUserToAddRows = False '行追加禁止
            .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
            .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
            .AllowUserToDeleteRows = False '行削除禁止
            .BorderStyle = BorderStyle.FixedSingle
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .RowHeadersVisible = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersHeight = 20
            .RowTemplate.Height = 20
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
            .ShowCellToolTips = True
            .EnableHeadersVisualStyles = False
            '.Font = New Font("ＭＳ Ｐゴシック", 9)
        End With
    End Sub

    ''' <summary>
    ''' データ表示
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub displayDgvUsrM()
        'クリア
        dgvUsrM.Columns.Clear()

        'データ取得、表示
        Dim cnn As New ADODB.Connection
        cnn.Open(DB_Patient)
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select Cod, Nam, Kana, Diary, Sanato, Nurse, Birth, Sex, Doc, Jyu1, Tel1, KNam, Zok, Jyu2, Tel2, Tel3, KNam2, Zok2, Jyu3, Tel4, Tel5, Com1, Com2 from UsrM order by Kana"
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        Dim da As OleDbDataAdapter = New OleDbDataAdapter()
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, rs, "UsrM")
        Dim dt As DataTable = ds.Tables("UsrM")
        dgvUsrM.DataSource = dt

        '幅設定等
        With dgvUsrM
            With .Columns("Cod")
                .HeaderText = "ｺｰﾄﾞ"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 70
            End With
            With .Columns("Nam")
                .HeaderText = "氏名"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 90
                .Frozen = True
            End With
            With .Columns("Kana")
                .HeaderText = "ｶﾅ"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 90
            End With
            With .Columns("Diary")
                .HeaderText = "Diary"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 45
            End With
            With .Columns("Sanato")
                .HeaderText = "Sanato"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 45
            End With
            With .Columns("Nurse")
                .HeaderText = "Nurse"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 45
            End With
            With .Columns("Birth")
                .HeaderText = "生年月日"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 85
            End With
            With .Columns("Sex")
                .HeaderText = "性"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 20
            End With
            With .Columns("Doc")
                .HeaderText = "主治医"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 55
            End With
            With .Columns("Jyu1")
                .HeaderText = "現在所"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 240
            End With
            With .Columns("Tel1")
                .HeaderText = "電話番号"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 95
            End With
            With .Columns("KNam")
                .HeaderText = "ｷｰﾊﾟｰｿﾝ①"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 90
            End With
            With .Columns("Zok")
                .HeaderText = "ｷｰﾊﾟ①続柄"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 80
            End With
            With .Columns("Jyu2")
                .HeaderText = "ｷｰﾊﾟ①住所"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 240
            End With
            With .Columns("Tel2")
                .HeaderText = "ｷｰﾊﾟ①TEL1"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 95
            End With
            With .Columns("Tel3")
                .HeaderText = "ｷｰﾊﾟ①TEL2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 95
            End With
            With .Columns("KNam2")
                .HeaderText = "ｷｰﾊﾟｰｿﾝ②"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 90
            End With
            With .Columns("Zok2")
                .HeaderText = "ｷｰﾊﾟ②続柄"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 80
            End With
            With .Columns("Jyu3")
                .HeaderText = "ｷｰﾊﾟ②住所"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 240
            End With
            With .Columns("Tel4")
                .HeaderText = "ｷｰﾊﾟ②TEL1"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 95
            End With
            With .Columns("Tel5")
                .HeaderText = "ｷｰﾊﾟ②TEL2"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 95
            End With
            With .Columns("Com1")
                .HeaderText = "コメント１"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 250
            End With
            With .Columns("Com2")
                .HeaderText = "コメント２"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 250
            End With
        End With
    End Sub

    ''' <summary>
    ''' 入退履歴ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnHistory_Click(sender As System.Object, e As System.EventArgs) Handles btnHistory.Click
        '患者ｺｰﾄﾞ
        Dim cod As Integer
        If Not System.Text.RegularExpressions.Regex.IsMatch(codBox.Text, "^\d+$") Then
            MsgBox("患者ｺｰﾄﾞは数値を入力して下さい。", MsgBoxStyle.Exclamation)
            codBox.Focus()
            Return
        Else
            cod = CInt(codBox.Text)
        End If
        '患者氏名
        Dim nam As String = namBox.Text
        If nam = "" Then
            MsgBox("患者氏名を入力して下さい。", MsgBoxStyle.Exclamation)
            namBox.Focus()
            Return
        End If

        'フォーム表示
        If IsNothing(historyForm) OrElse historyForm.IsDisposed Then
            historyForm = New 入退履歴(cod, nam)
            historyForm.Owner = Me
            historyForm.Show()
        End If
    End Sub

    ''' <summary>
    ''' 検索ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        searchForm = New 検索(dgvUsrM)
        searchForm.Owner = Me
        searchForm.ShowDialog()
        searchForm.Dispose()
    End Sub

    ''' <summary>
    ''' 対象の頭文字までスクロール
    ''' </summary>
    ''' <param name="initialChar">頭文字</param>
    ''' <remarks></remarks>
    Private Sub initialSearch(initialChar As String)
        Dim rowsCount As Integer = dgvUsrM.Rows.Count
        For i As Integer = 0 To rowsCount - 1
            Dim kana As String = Util.checkDBNullValue(dgvUsrM("Kana", i).Value)
            If System.Text.RegularExpressions.Regex.IsMatch(kana, "^" & initialChar) Then
                dgvUsrM.Rows(i).Selected = True
                dgvUsrM.FirstDisplayedScrollingRowIndex = i
                displayPersonalInfo(dgvUsrM.Rows(i))
                Exit For
            End If
        Next
    End Sub

    ''' <summary>
    ''' ｱ～ﾜボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSearchKana_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchA.Click, btnSearchKA.Click, btnSearchSA.Click, btnSearchTA.Click, btnSearchNA.Click, btnSearchHA.Click, btnSearchMA.Click, btnSearchYA.Click, btnSearchRA.Click, btnSearchWA.Click
        Dim searchText As String = StrConv(sender.text, VbStrConv.Narrow)
        initialSearch(searchText)
    End Sub

    ''' <summary>
    ''' 入力内容クリア
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearInput()
        codBox.Text = ""
        namBox.Text = ""
        kanaBox.Text = ""
        chkDiary.Checked = False
        chkSanato.Checked = False
        chkNurse.Checked = False
        birthBox.clearText()
        sexBox.Text = ""
        docBox.Text = ""
        jyu1Box.Text = ""
        tel1Box.Text = ""
        KNamBox.Text = ""
        zokBox.Text = ""
        jyu2Box.Text = ""
        tel2Box.Text = ""
        tel3Box.Text = ""
        KNam2Box.Text = ""
        zok2Box.Text = ""
        jyu3Box.Text = ""
        tel4Box.Text = ""
        tel5Box.Text = ""
        com1Box.Text = ""
        com2Box.Text = ""
    End Sub

    ''' <summary>
    ''' セルマウスクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvUsrM_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvUsrM.CellMouseClick
        If e.RowIndex >= 0 Then
            displayPersonalInfo(dgvUsrM.Rows(e.RowIndex))
        End If
    End Sub

    ''' <summary>
    ''' 選択行のデータを各テキストボックスへ反映
    ''' </summary>
    ''' <param name="selectedRow"></param>
    ''' <remarks></remarks>
    Public Sub displayPersonalInfo(selectedRow As DataGridViewRow)
        Dim cod As String = Util.checkDBNullValue(selectedRow.Cells("Cod").Value) 'ｺｰﾄﾞ
        Dim nam As String = Util.checkDBNullValue(selectedRow.Cells("Nam").Value) '氏名
        Dim kana As String = Util.checkDBNullValue(selectedRow.Cells("Kana").Value) 'ｶﾅ
        Dim diary As String = Util.checkDBNullValue(selectedRow.Cells("Diary").Value) 'Diary
        Dim sanato As String = Util.checkDBNullValue(selectedRow.Cells("Sanato").Value) 'Sanato
        Dim nurse As String = Util.checkDBNullValue(selectedRow.Cells("Nurse").Value) 'Nurse
        Dim birth As String = Util.checkDBNullValue(selectedRow.Cells("Birth").Value) '生年月日
        Dim sex As String = Util.checkDBNullValue(selectedRow.Cells("Sex").Value) '性別
        Dim doc As String = Util.checkDBNullValue(selectedRow.Cells("Doc").Value) '主治医
        Dim jyu1 As String = Util.checkDBNullValue(selectedRow.Cells("Jyu1").Value) '現在所
        Dim tel1 As String = Util.checkDBNullValue(selectedRow.Cells("Tel1").Value) '電話番号
        Dim kNam As String = Util.checkDBNullValue(selectedRow.Cells("KNam").Value) 'ｷｰﾊﾟｰｿﾝ①
        Dim zok As String = Util.checkDBNullValue(selectedRow.Cells("Zok").Value) '　続柄
        Dim jyu2 As String = Util.checkDBNullValue(selectedRow.Cells("Jyu2").Value) '　住所
        Dim tel2 As String = Util.checkDBNullValue(selectedRow.Cells("Tel2").Value) '　電話1
        Dim tel3 As String = Util.checkDBNullValue(selectedRow.Cells("Tel3").Value) '　電話2
        Dim kNam2 As String = Util.checkDBNullValue(selectedRow.Cells("KNam2").Value) 'ｷｰﾊﾟｰｿﾝ②
        Dim zok2 As String = Util.checkDBNullValue(selectedRow.Cells("Zok2").Value) '　続柄
        Dim jyu3 As String = Util.checkDBNullValue(selectedRow.Cells("Jyu3").Value) '　住所
        Dim tel4 As String = Util.checkDBNullValue(selectedRow.Cells("Tel4").Value) '　電話1
        Dim tel5 As String = Util.checkDBNullValue(selectedRow.Cells("Tel5").Value) '　電話2
        Dim com1 As String = Util.checkDBNullValue(selectedRow.Cells("Com1").Value) 'コメント１
        Dim com2 As String = Util.checkDBNullValue(selectedRow.Cells("Com2").Value) 'コメント２

        clearInput()

        codBox.Text = cod
        namBox.Text = nam
        kanaBox.Text = kana
        chkDiary.Checked = If(diary = 1, True, False)
        chkSanato.Checked = If(sanato = 1, True, False)
        chkNurse.Checked = If(nurse = 1, True, False)
        birthBox.setADStr(birth)
        sexBox.Text = sex
        docBox.Text = doc
        jyu1Box.Text = jyu1
        tel1Box.Text = tel1
        KNamBox.Text = kNam
        zokBox.Text = zok
        jyu2Box.Text = jyu2
        tel2Box.Text = tel2
        tel3Box.Text = tel3
        KNam2Box.Text = kNam2
        zok2Box.Text = zok2
        jyu3Box.Text = jyu3
        tel4Box.Text = tel4
        tel5Box.Text = tel5
        com1Box.Text = com1
        com2Box.Text = com2
    End Sub

    ''' <summary>
    ''' 入力クリアボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        clearInput()
    End Sub

    ''' <summary>
    ''' 登録ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRegist_Click(sender As System.Object, e As System.EventArgs) Handles btnRegist.Click
        'ｺｰﾄﾞ
        Dim cod As String = codBox.Text
        If Not System.Text.RegularExpressions.Regex.IsMatch(cod, "^\d+$") Then
            MsgBox("数値を入力して下さい。", MsgBoxStyle.Exclamation)
            codBox.Focus()
            Return
        Else
            Dim codNum As Double = CDbl(cod)
            If codNum > 32767 Then
                MsgBox("数値は32767以下で入力して下さい。", MsgBoxStyle.Exclamation)
                codBox.Focus()
                Return
            End If
        End If
        '氏名
        Dim nam As String = namBox.Text
        If nam = "" Then
            MsgBox("氏名を入力して下さい。", MsgBoxStyle.Exclamation)
            namBox.Focus()
            Return
        End If
        'カナ
        Dim kana As String = kanaBox.Text
        If kana = "" Then
            MsgBox("ｶﾅを入力して下さい。", MsgBoxStyle.Exclamation)
            kanaBox.Focus()
            Return
        End If
        '生年月日
        Dim birth As String = birthBox.getADStr()
        If birth = "" Then
            MsgBox("生年月日を入力して下さい。", MsgBoxStyle.Exclamation)
            birthBox.Focus()
            Return
        End If
        'Diary(日誌)
        Dim diary As Integer = If(chkDiary.Checked, 1, 0)
        'Sanato(療養カルテ)
        Dim sanato As Integer = If(chkSanato.Checked, 1, 0)
        'Nurse(一般看護記録)
        Dim nurse As Integer = If(chkNurse.Checked, 1, 0)
        '性別
        Dim sex As String = sexBox.Text
        '主治医
        Dim doc As String = docBox.Text
        '現在所
        Dim jyu1 As String = jyu1Box.Text
        '電話番号
        Dim tel1 As String = tel1Box.Text
        'ｷｰﾊﾟｰｿﾝ①
        Dim kNam As String = KNamBox.Text
        '①続柄
        Dim zok As String = zokBox.Text
        '①住所
        Dim jyu2 As String = jyu2Box.Text
        '①電話1
        Dim tel2 As String = tel2Box.Text
        '①電話2
        Dim tel3 As String = tel3Box.Text
        'ｷｰﾊﾟｰｿﾝ②
        Dim kNam2 As String = KNam2Box.Text
        '②続柄
        Dim zok2 As String = zok2Box.Text
        '②住所
        Dim jyu3 As String = jyu3Box.Text
        '②電話1
        Dim tel4 As String = tel4Box.Text
        '②電話2
        Dim tel5 As String = tel5Box.Text
        'コメント1
        Dim com1 As String = com1Box.Text
        'コメント2
        Dim com2 As String = com2Box.Text

        '登録
        Dim addFlg As Boolean = False
        Dim cn As New ADODB.Connection()
        cn.Open(DB_Patient)
        Dim sql As String = "select * from UsrM where Cod = " & cod & ""
        Dim rs As New ADODB.Recordset
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If rs.RecordCount <= 0 Then
            addFlg = True
            rs.AddNew()
            rs.Fields("Cod").Value = cod
        End If
        rs.Fields("Nam").Value = nam
        rs.Fields("Kana").Value = kana
        rs.Fields("Diary").Value = diary
        rs.Fields("Sanato").Value = sanato
        rs.Fields("Nurse").Value = nurse
        rs.Fields("Birth").Value = birth
        rs.Fields("Sex").Value = sex
        rs.Fields("Doc").Value = doc
        rs.Fields("Jyu1").Value = jyu1
        rs.Fields("Tel1").Value = tel1
        rs.Fields("KNam").Value = kNam
        rs.Fields("Zok").Value = zok
        rs.Fields("Jyu2").Value = jyu2
        rs.Fields("Tel2").Value = tel2
        rs.Fields("Tel3").Value = tel3
        rs.Fields("KNam2").Value = kNam2
        rs.Fields("Zok2").Value = zok2
        rs.Fields("Jyu3").Value = jyu3
        rs.Fields("Tel4").Value = tel4
        rs.Fields("Tel5").Value = tel5
        rs.Fields("Com1").Value = com1
        rs.Fields("Com2").Value = com2

        rs.Update()
        rs.Close()
        cn.Close()

        If addFlg Then
            MsgBox("追加しました。", MsgBoxStyle.Information)
        Else
            MsgBox("変更しました。", MsgBoxStyle.Information)
        End If

        '再表示
        clearInput()
        displayDgvUsrM()
    End Sub

    ''' <summary>
    ''' 削除ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        'ｺｰﾄﾞ
        Dim cod As String = codBox.Text
        If Not System.Text.RegularExpressions.Regex.IsMatch(cod, "^\d+$") Then
            MsgBox("数値を入力して下さい。", MsgBoxStyle.Exclamation)
            codBox.Focus()
            Return
        Else
            Dim codNum As Double = CDbl(cod)
            If codNum > 32767 Then
                MsgBox("数値は32767以下で入力して下さい。", MsgBoxStyle.Exclamation)
                codBox.Focus()
                Return
            End If
        End If

        Dim cn As New ADODB.Connection()
        cn.Open(DB_Patient)
        Dim sql As String = "select * from UsrM where Cod = " & cod & ""
        Dim rs As New ADODB.Recordset
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If rs.RecordCount <= 0 Then
            rs.Close()
            cn.Close()
            MsgBox("患者ｺｰﾄﾞ " & cod & " は登録されていません。", MsgBoxStyle.Exclamation)
            Return
        Else
            Dim result As DialogResult = MessageBox.Show("削除してよろしいですか？", "削除", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                rs.Delete()
                rs.Update()
                rs.Close()
                cn.Close()

                MsgBox("削除しました。", MsgBoxStyle.Information)

                '再表示
                clearInput()
                displayDgvUsrM()
            Else
                rs.Close()
                cn.Close()
            End If
        End If
    End Sub

    ''' <summary>
    ''' 患者ｺｰﾄﾞボックスKeyDownイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub codBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles codBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim codStr As String = codBox.Text
            If codStr = "" OrElse Not System.Text.RegularExpressions.Regex.IsMatch(codStr, "^\d+$") Then
                Return
            End If

            '対象のｺｰﾄﾞのデータを選択、表示
            Dim targetCod As Integer = CInt(codStr)
            For i As Integer = 0 To dgvUsrM.Rows.Count - 1
                Dim cod As Integer = dgvUsrM("Cod", i).Value
                If cod = targetCod Then
                    displayPersonalInfo(dgvUsrM.Rows(i))
                    dgvUsrM.Rows(i).Selected = True
                    dgvUsrM.FirstDisplayedScrollingRowIndex = i
                End If
            Next
        End If
    End Sub
End Class

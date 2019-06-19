Imports System.Data.OleDb

Public Class 入退履歴

    '患者ｺｰﾄﾞ
    Private cod As Integer

    '患者氏名
    Private nam As String

    '患者氏名（カナ）
    Private kana As String

    '選択行データのAutono
    Private selectedAutono As Integer = -1

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="cod">患者ｺｰﾄﾞ</param>
    ''' <param name="nam">患者氏名</param>
    ''' <param name="kana">患者氏名（カナ）</param>
    ''' <remarks></remarks>
    Public Sub New(cod As Integer, nam As String, kana As String)
        InitializeComponent()
        Me.WindowState = FormWindowState.Maximized

        Me.cod = cod
        Me.nam = nam
        Me.kana = kana

        codBox.Text = cod
        namBox.Text = nam
    End Sub

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 入退履歴_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'データグリッドビュー初期設定
        initDgvHist()

        'データ表示
        displayDgvHist()
    End Sub

    ''' <summary>
    ''' データグリッドビュー初期設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initDgvHist()
        Util.EnableDoubleBuffering(dgvHist)

        With dgvHist
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
            .ReadOnly = True
            '.Font = New Font("ＭＳ Ｐゴシック", 9)
        End With
    End Sub

    ''' <summary>
    ''' データ表示
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub displayDgvHist()
        'クリア
        dgvHist.Columns.Clear()
        clearInput()

        'データ取得、表示
        Dim cnn As New ADODB.Connection
        cnn.Open(TopForm.DB_Patient)
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select Cod, Ymd1, Div, Ymd2, After, Doc, Broot, BrYmd1, BrYmd2, Karte, Autono from Hist where Cod = " & cod & " order by Ymd1"
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        Dim da As OleDbDataAdapter = New OleDbDataAdapter()
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, rs, "Hist")
        Dim dt As DataTable = ds.Tables("Hist")

        '列追加
        dt.Columns.Add("Nam", GetType(String)) '氏名
        dt.Columns.Add("Kana", GetType(String)) 'カナ
        For Each row As DataRow In dt.Rows
            row("Nam") = nam
            row("Kana") = kana
        Next

        '表示
        dgvHist.DataSource = dt
        cancelSelectedRow()

        '幅設定等
        With dgvHist

            '非表示
            .Columns("Autono").Visible = False
            .Columns("Broot").Visible = False
            .Columns("BrYmd1").Visible = False
            .Columns("BrYmd2").Visible = False

            With .Columns("Cod")
                .HeaderText = "ｺｰﾄﾞ"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 60
            End With
            With .Columns("Nam")
                .DisplayIndex = 1
                .HeaderText = "氏名"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 90
            End With
            With .Columns("Kana")
                .DisplayIndex = 2
                .HeaderText = "カナ"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 90
            End With
            With .Columns("Ymd1")
                .HeaderText = "入院日"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 90
            End With
            With .Columns("Div")
                .HeaderText = "病棟"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 60
            End With
            With .Columns("Ymd2")
                .HeaderText = "退院日"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 90
            End With
            With .Columns("After")
                .HeaderText = "退院後"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 60
            End With
            With .Columns("Doc")
                .HeaderText = "主治医"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 60
            End With
            With .Columns("Karte")
                .HeaderText = "カルテ保管"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                If dgvHist.Rows.Count >= 11 Then
                    .Width = 73
                Else
                    .Width = 90
                End If
            End With

        End With

    End Sub

    Private Sub dtpTai_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dtpTai.KeyDown
        If e.KeyData = Keys.Delete OrElse e.KeyData = Keys.Back Then
            dtpTai.CustomFormat = " "
        End If
    End Sub

    Private Sub dtpTai_ValueChanged(sender As Object, e As System.EventArgs) Handles dtpTai.ValueChanged
        If dtpTai.CustomFormat <> "yyyy/MM/dd" Then
            Dim dateTime As String = dtpTai.Value.ToString("yyyy/MM/dd")
            dtpTai.CustomFormat = "yyyy/MM/dd"
            dtpTai.Text = dateTime
        End If
    End Sub

    ''' <summary>
    ''' セルマウスクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvHist_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvHist.CellMouseClick
        If e.RowIndex >= 0 Then
            'クリア
            clearInput()

            'Autono
            selectedAutono = dgvHist("Autono", e.RowIndex).Value

            '各ボックスへ代入
            '入院日
            dtpNyu.Text = Util.checkDBNullValue(dgvHist("Ymd1", e.RowIndex).Value)
            '病棟
            divBox.Text = Util.checkDBNullValue(dgvHist("Div", e.RowIndex).Value)
            '退院日
            Dim ymd2 As String = Util.checkDBNullValue(dgvHist("Ymd2", e.RowIndex).Value)
            If ymd2 = "" Then
                dtpTai.CustomFormat = " "
            Else
                dtpTai.CustomFormat = "yyyy/MM/dd"
                dtpTai.Text = ymd2
            End If
            '退院後の行先
            afterBox.Text = Util.checkDBNullValue(dgvHist("After", e.RowIndex).Value)
            '主治医
            docBox.Text = Util.checkDBNullValue(dgvHist("Doc", e.RowIndex).Value)
            'カルテ保管
            karteBox.Text = Util.checkDBNullValue(dgvHist("Karte", e.RowIndex).Value)

        End If
    End Sub

    ''' <summary>
    ''' 選択行解除
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cancelSelectedRow()
        If Not IsNothing(dgvHist.CurrentRow) Then
            dgvHist.CurrentRow.Selected = False
            selectedAutono = -1
        End If
    End Sub

    ''' <summary>
    ''' 入力内容クリア
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearInput()
        '入院日
        dtpNyu.Text = DateTime.Now.ToString("yyyy/MM/dd")
        '病棟
        divBox.Text = "一般"
        '退院日
        dtpTai.CustomFormat = " "
        '退院後の行先
        afterBox.Text = ""
        '主治医
        docBox.Text = ""
        'カルテ保管
        karteBox.Text = ""
    End Sub

    ''' <summary>
    ''' クリアボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClearInput_Click(sender As System.Object, e As System.EventArgs) Handles btnClearInput.Click
        clearInput()
        cancelSelectedRow()
    End Sub

    ''' <summary>
    ''' 登録ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRegist_Click(sender As System.Object, e As System.EventArgs) Handles btnRegist.Click
        '病棟
        Dim div As String = divBox.Text
        If div = "" Then
            MsgBox("病棟を選択して下さい。", MsgBoxStyle.Exclamation)
            divBox.Focus()
            Return
        End If
        '入院日
        Dim ymd1 As String = dtpNyu.Text
        '退院日
        Dim ymd2 As String = If(dtpTai.CustomFormat = " ", "", dtpTai.Text)
        '退院後の行先
        Dim after As String = afterBox.Text
        '主治医
        Dim doc As String = docBox.Text
        'カルテ保管
        Dim karte As String = karteBox.Text

        '登録
        Dim addFlg As Boolean = False
        Dim cn As New ADODB.Connection()
        cn.Open(TopForm.DB_Patient)
        Dim sql As String = "select * from Hist where Autono = " & selectedAutono
        Dim rs As New ADODB.Recordset
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If rs.RecordCount <= 0 Then
            addFlg = True
            rs.AddNew()
        End If
        rs.Fields("Cod").Value = cod
        rs.Fields("Ymd1").Value = ymd1
        rs.Fields("Div").Value = div
        rs.Fields("Ymd2").Value = ymd2
        rs.Fields("After").Value = after
        rs.Fields("Doc").Value = doc
        rs.Fields("Karte").Value = karte
        rs.Update()
        rs.Close()
        cn.Close()

        If addFlg Then
            MsgBox("追加しました。", MsgBoxStyle.Information)
        Else
            MsgBox("変更しました。", MsgBoxStyle.Information)
        End If

        '再表示
        displayDgvHist()

    End Sub

    ''' <summary>
    ''' 削除ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        '行未選択時
        If selectedAutono = -1 Then
            MsgBox("削除データを選択して下さい。", MsgBoxStyle.Exclamation)
            Return
        End If

        '削除
        Dim cn As New ADODB.Connection()
        cn.Open(TopForm.DB_Patient)
        Dim sql As String = "select * from Hist where Autono = " & selectedAutono
        Dim rs As New ADODB.Recordset
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If rs.RecordCount > 0 Then
            rs.Delete()
            rs.Update()
            rs.Close()
            cn.Close()

            MsgBox("削除しました。", MsgBoxStyle.Information)
            '再表示
            displayDgvHist()
        Else
            rs.Close()
            cn.Close()
        End If
    End Sub

End Class
Public Class 検索
    '検索対象データグリッドビュー
    Private targetDgv As DataGridView

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="dgv">データグリッドビュー</param>
    ''' <remarks></remarks>
    Public Sub New(dgv As DataGridView)
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.KeyPreview = True

        targetDgv = dgv
    End Sub

    ''' <summary>
    ''' keyDownイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 検索_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) AndAlso Not e.Alt AndAlso Not e.Control Then
            Me.ProcessTabKey(Not e.Shift)
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 検索_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' キャンセルボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' 検索ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSeach_Click(sender As System.Object, e As System.EventArgs) Handles btnSeach.Click
        Dim searchText As String = searchBox.Text '検索対象文字列
        'ひらがなをカタカナに、全角を半角に変換
        searchText = StrConv(searchText, VbStrConv.Katakana Or VbStrConv.Narrow, &H411)

        Dim ln As Integer = targetDgv.Rows.Count
        For i = 0 To (ln - 1)
            Dim kana As String = Util.checkDBNullValue(targetDgv("Kana", i).Value)
            If System.Text.RegularExpressions.Regex.IsMatch(kana, "^" & searchText) Then
                targetDgv.Rows(i).Selected = True
                targetDgv.FirstDisplayedScrollingRowIndex = i
                CType(Me.Owner, TopForm).displayPersonalInfo(targetDgv.Rows(i))
                Me.Close()
                Exit For
            End If
            If i = (ln - 1) Then
                MsgBox("見つかりませんでした。", MsgBoxStyle.Exclamation)
                searchBox.Focus()
            End If
        Next
    End Sub
End Class
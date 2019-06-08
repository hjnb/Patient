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
        Me.KeyPreview = True

        targetDgv = dgv
    End Sub

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 検索_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
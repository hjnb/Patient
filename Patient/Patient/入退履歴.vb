Public Class 入退履歴

    '患者ｺｰﾄﾞ
    Private cod As Integer

    '患者氏名
    Private nam As String

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="cod">患者ｺｰﾄﾞ</param>
    ''' <param name="nam">患者氏名</param>
    ''' <remarks></remarks>
    Public Sub New(cod As Integer, nam As String)
        InitializeComponent()
        Me.WindowState = FormWindowState.Maximized

        Me.cod = cod
        Me.nam = nam

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

    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 検索
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSeach = New System.Windows.Forms.Button()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "検索したい人の名前を" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "半角カタカナで入力してください。"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(120, 100)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(66, 33)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSeach
        '
        Me.btnSeach.Location = New System.Drawing.Point(29, 100)
        Me.btnSeach.Name = "btnSeach"
        Me.btnSeach.Size = New System.Drawing.Size(68, 33)
        Me.btnSeach.TabIndex = 5
        Me.btnSeach.Text = "検索開始"
        Me.btnSeach.UseVisualStyleBackColor = True
        '
        'searchBox
        '
        Me.searchBox.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        Me.searchBox.Location = New System.Drawing.Point(29, 61)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(157, 19)
        Me.searchBox.TabIndex = 4
        '
        '検索
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 155)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSeach)
        Me.Controls.Add(Me.searchBox)
        Me.Name = "検索"
        Me.Text = "検索"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSeach As System.Windows.Forms.Button
    Friend WithEvents searchBox As System.Windows.Forms.TextBox
End Class

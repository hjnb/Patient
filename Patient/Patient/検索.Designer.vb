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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "検索したい名前を"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(120, 108)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(66, 33)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSeach
        '
        Me.btnSeach.Location = New System.Drawing.Point(29, 108)
        Me.btnSeach.Name = "btnSeach"
        Me.btnSeach.Size = New System.Drawing.Size(68, 33)
        Me.btnSeach.TabIndex = 5
        Me.btnSeach.Text = "検索開始"
        Me.btnSeach.UseVisualStyleBackColor = True
        '
        'searchBox
        '
        Me.searchBox.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        Me.searchBox.Location = New System.Drawing.Point(29, 69)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(157, 19)
        Me.searchBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(28, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ひらがな or カタカナ or 半角カタカナ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 12)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "で入力して下さい。"
        '
        '検索
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 155)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

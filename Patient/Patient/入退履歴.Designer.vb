<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 入退履歴
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
        Me.components = New System.ComponentModel.Container()
        Me.btnClearInput = New System.Windows.Forms.Button()
        Me.dtpTai = New System.Windows.Forms.DateTimePicker()
        Me.dtpNyu = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.codBox = New System.Windows.Forms.TextBox()
        Me.namBox = New System.Windows.Forms.TextBox()
        Me.divBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.docBox = New System.Windows.Forms.ComboBox()
        Me.afterBox = New System.Windows.Forms.ComboBox()
        Me.karteBox = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvHist = New Patient.HistDataGridView(Me.components)
        CType(Me.dgvHist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClearInput
        '
        Me.btnClearInput.Location = New System.Drawing.Point(406, 114)
        Me.btnClearInput.Name = "btnClearInput"
        Me.btnClearInput.Size = New System.Drawing.Size(67, 28)
        Me.btnClearInput.TabIndex = 2282
        Me.btnClearInput.Text = "入力クリア"
        Me.btnClearInput.UseVisualStyleBackColor = True
        '
        'dtpTai
        '
        Me.dtpTai.CustomFormat = " "
        Me.dtpTai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTai.Location = New System.Drawing.Point(359, 73)
        Me.dtpTai.Name = "dtpTai"
        Me.dtpTai.Size = New System.Drawing.Size(114, 19)
        Me.dtpTai.TabIndex = 2281
        '
        'dtpNyu
        '
        Me.dtpNyu.CustomFormat = "yyyy/MM/dd"
        Me.dtpNyu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNyu.Location = New System.Drawing.Point(69, 73)
        Me.dtpNyu.Name = "dtpNyu"
        Me.dtpNyu.Size = New System.Drawing.Size(105, 19)
        Me.dtpNyu.TabIndex = 2252
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(175, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 2277
        Me.Label6.Text = "氏名"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 12)
        Me.Label3.TabIndex = 2276
        Me.Label3.Text = "患者コード"
        '
        'codBox
        '
        Me.codBox.ForeColor = System.Drawing.Color.Blue
        Me.codBox.Location = New System.Drawing.Point(90, 21)
        Me.codBox.Name = "codBox"
        Me.codBox.ReadOnly = True
        Me.codBox.Size = New System.Drawing.Size(61, 19)
        Me.codBox.TabIndex = 2275
        '
        'namBox
        '
        Me.namBox.Location = New System.Drawing.Point(220, 21)
        Me.namBox.Name = "namBox"
        Me.namBox.ReadOnly = True
        Me.namBox.Size = New System.Drawing.Size(117, 19)
        Me.namBox.TabIndex = 2274
        '
        'divBox
        '
        Me.divBox.FormattingEnabled = True
        Me.divBox.Items.AddRange(New Object() {"一般", "療養"})
        Me.divBox.Location = New System.Drawing.Point(220, 72)
        Me.divBox.Name = "divBox"
        Me.divBox.Size = New System.Drawing.Size(77, 20)
        Me.divBox.TabIndex = 2254
        Me.divBox.Text = "一般"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(484, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 12)
        Me.Label5.TabIndex = 2272
        Me.Label5.Text = "退院後の行先"
        '
        'docBox
        '
        Me.docBox.FormattingEnabled = True
        Me.docBox.Items.AddRange(New Object() {"臼田", "清水", "齋藤", "櫻田", "畑野", "小出"})
        Me.docBox.Location = New System.Drawing.Point(69, 119)
        Me.docBox.Name = "docBox"
        Me.docBox.Size = New System.Drawing.Size(105, 20)
        Me.docBox.TabIndex = 2257
        '
        'afterBox
        '
        Me.afterBox.FormattingEnabled = True
        Me.afterBox.Items.AddRange(New Object() {"療養", "一般", "死亡", "自宅", "介護施設", "他病院"})
        Me.afterBox.Location = New System.Drawing.Point(578, 72)
        Me.afterBox.Name = "afterBox"
        Me.afterBox.Size = New System.Drawing.Size(80, 20)
        Me.afterBox.TabIndex = 2256
        '
        'karteBox
        '
        Me.karteBox.Location = New System.Drawing.Point(246, 119)
        Me.karteBox.Name = "karteBox"
        Me.karteBox.Size = New System.Drawing.Size(103, 19)
        Me.karteBox.TabIndex = 2263
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(593, 114)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(65, 28)
        Me.btnDelete.TabIndex = 2267
        Me.btnDelete.Text = "削除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRegist
        '
        Me.btnRegist.Location = New System.Drawing.Point(527, 114)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(67, 28)
        Me.btnRegist.TabIndex = 2265
        Me.btnRegist.Text = "登録"
        Me.btnRegist.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(185, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 12)
        Me.Label12.TabIndex = 2271
        Me.Label12.Text = "カルテ保管"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 12)
        Me.Label7.TabIndex = 2260
        Me.Label7.Text = "主治医"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(312, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 2255
        Me.Label4.Text = "退院日"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 2253
        Me.Label2.Text = "病棟"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 2251
        Me.Label1.Text = "入院日"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(552, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 22)
        Me.Button1.TabIndex = 2279
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvHist
        '
        Me.dgvHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHist.Location = New System.Drawing.Point(24, 173)
        Me.dgvHist.Name = "dgvHist"
        Me.dgvHist.RowTemplate.Height = 21
        Me.dgvHist.Size = New System.Drawing.Size(693, 222)
        Me.dgvHist.TabIndex = 2283
        '
        '入退履歴
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 431)
        Me.Controls.Add(Me.dgvHist)
        Me.Controls.Add(Me.btnClearInput)
        Me.Controls.Add(Me.dtpTai)
        Me.Controls.Add(Me.dtpNyu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.codBox)
        Me.Controls.Add(Me.namBox)
        Me.Controls.Add(Me.divBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.docBox)
        Me.Controls.Add(Me.afterBox)
        Me.Controls.Add(Me.karteBox)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "入退履歴"
        Me.Text = "入退履歴"
        CType(Me.dgvHist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClearInput As System.Windows.Forms.Button
    Friend WithEvents dtpTai As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpNyu As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents codBox As System.Windows.Forms.TextBox
    Friend WithEvents namBox As System.Windows.Forms.TextBox
    Friend WithEvents divBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents docBox As System.Windows.Forms.ComboBox
    Friend WithEvents afterBox As System.Windows.Forms.ComboBox
    Friend WithEvents karteBox As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvHist As Patient.HistDataGridView
End Class

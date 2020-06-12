<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopForm
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
        Me.btnZai = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearchWA = New System.Windows.Forms.Button()
        Me.btnSearchRA = New System.Windows.Forms.Button()
        Me.btnSearchYA = New System.Windows.Forms.Button()
        Me.btnSearchMA = New System.Windows.Forms.Button()
        Me.btnSearchHA = New System.Windows.Forms.Button()
        Me.btnSearchNA = New System.Windows.Forms.Button()
        Me.btnSearchTA = New System.Windows.Forms.Button()
        Me.btnSearchSA = New System.Windows.Forms.Button()
        Me.btnSearchKA = New System.Windows.Forms.Button()
        Me.btnSearchA = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkNurse = New System.Windows.Forms.CheckBox()
        Me.chkSanato = New System.Windows.Forms.CheckBox()
        Me.chkDiary = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.codBox = New System.Windows.Forms.TextBox()
        Me.namBox = New System.Windows.Forms.TextBox()
        Me.kanaBox = New System.Windows.Forms.TextBox()
        Me.birthBox = New ymdBox.ymdBox()
        Me.sexBox = New System.Windows.Forms.ComboBox()
        Me.docBox = New System.Windows.Forms.ComboBox()
        Me.jyu1Box = New System.Windows.Forms.TextBox()
        Me.tel1Box = New System.Windows.Forms.TextBox()
        Me.KNamBox = New System.Windows.Forms.TextBox()
        Me.zokBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.jyu2Box = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tel2Box = New System.Windows.Forms.TextBox()
        Me.tel3Box = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tel5Box = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tel4Box = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.jyu3Box = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.zok2Box = New System.Windows.Forms.TextBox()
        Me.KNam2Box = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.com1Box = New System.Windows.Forms.TextBox()
        Me.com2Box = New System.Windows.Forms.TextBox()
        Me.dgvUsrM = New System.Windows.Forms.DataGridView()
        Me.chkAllowTel = New System.Windows.Forms.CheckBox()
        Me.chkAllowNyu = New System.Windows.Forms.CheckBox()
        Me.memoText = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnPatientPrint = New System.Windows.Forms.Button()
        Me.rbtnAiueo = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtnByoto = New System.Windows.Forms.RadioButton()
        Me.chkCertificate = New System.Windows.Forms.CheckBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.searchPanel = New System.Windows.Forms.Panel()
        Me.itemListBox = New System.Windows.Forms.ListBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.resultKanaLabel = New System.Windows.Forms.Label()
        Me.resultNamLabel = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.allSearchBox = New System.Windows.Forms.TextBox()
        Me.btnAllSearch = New System.Windows.Forms.Button()
        CType(Me.dgvUsrM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.searchPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnZai
        '
        Me.btnZai.Location = New System.Drawing.Point(825, 33)
        Me.btnZai.Name = "btnZai"
        Me.btnZai.Size = New System.Drawing.Size(215, 89)
        Me.btnZai.TabIndex = 577
        Me.btnZai.Text = "在院"
        Me.btnZai.UseVisualStyleBackColor = True
        Me.btnZai.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(759, 234)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 33)
        Me.btnClear.TabIndex = 576
        Me.btnClear.Text = "入力クリア"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearchWA
        '
        Me.btnSearchWA.Location = New System.Drawing.Point(11, 493)
        Me.btnSearchWA.Name = "btnSearchWA"
        Me.btnSearchWA.Size = New System.Drawing.Size(22, 19)
        Me.btnSearchWA.TabIndex = 575
        Me.btnSearchWA.Text = "ワ"
        Me.btnSearchWA.UseVisualStyleBackColor = True
        '
        'btnSearchRA
        '
        Me.btnSearchRA.Location = New System.Drawing.Point(11, 475)
        Me.btnSearchRA.Name = "btnSearchRA"
        Me.btnSearchRA.Size = New System.Drawing.Size(22, 19)
        Me.btnSearchRA.TabIndex = 574
        Me.btnSearchRA.Text = "ラ"
        Me.btnSearchRA.UseVisualStyleBackColor = True
        '
        'btnSearchYA
        '
        Me.btnSearchYA.Location = New System.Drawing.Point(11, 457)
        Me.btnSearchYA.Name = "btnSearchYA"
        Me.btnSearchYA.Size = New System.Drawing.Size(22, 19)
        Me.btnSearchYA.TabIndex = 573
        Me.btnSearchYA.Text = "ヤ"
        Me.btnSearchYA.UseVisualStyleBackColor = True
        '
        'btnSearchMA
        '
        Me.btnSearchMA.Location = New System.Drawing.Point(11, 439)
        Me.btnSearchMA.Name = "btnSearchMA"
        Me.btnSearchMA.Size = New System.Drawing.Size(22, 19)
        Me.btnSearchMA.TabIndex = 572
        Me.btnSearchMA.Text = "マ"
        Me.btnSearchMA.UseVisualStyleBackColor = True
        '
        'btnSearchHA
        '
        Me.btnSearchHA.Location = New System.Drawing.Point(11, 421)
        Me.btnSearchHA.Name = "btnSearchHA"
        Me.btnSearchHA.Size = New System.Drawing.Size(22, 19)
        Me.btnSearchHA.TabIndex = 571
        Me.btnSearchHA.Text = "ハ"
        Me.btnSearchHA.UseVisualStyleBackColor = True
        '
        'btnSearchNA
        '
        Me.btnSearchNA.Location = New System.Drawing.Point(11, 403)
        Me.btnSearchNA.Name = "btnSearchNA"
        Me.btnSearchNA.Size = New System.Drawing.Size(22, 19)
        Me.btnSearchNA.TabIndex = 570
        Me.btnSearchNA.Text = "ナ"
        Me.btnSearchNA.UseVisualStyleBackColor = True
        '
        'btnSearchTA
        '
        Me.btnSearchTA.Location = New System.Drawing.Point(11, 385)
        Me.btnSearchTA.Name = "btnSearchTA"
        Me.btnSearchTA.Size = New System.Drawing.Size(22, 19)
        Me.btnSearchTA.TabIndex = 569
        Me.btnSearchTA.Text = "タ"
        Me.btnSearchTA.UseVisualStyleBackColor = True
        '
        'btnSearchSA
        '
        Me.btnSearchSA.Location = New System.Drawing.Point(11, 367)
        Me.btnSearchSA.Name = "btnSearchSA"
        Me.btnSearchSA.Size = New System.Drawing.Size(22, 19)
        Me.btnSearchSA.TabIndex = 568
        Me.btnSearchSA.Text = "サ"
        Me.btnSearchSA.UseVisualStyleBackColor = True
        '
        'btnSearchKA
        '
        Me.btnSearchKA.Location = New System.Drawing.Point(11, 349)
        Me.btnSearchKA.Name = "btnSearchKA"
        Me.btnSearchKA.Size = New System.Drawing.Size(22, 19)
        Me.btnSearchKA.TabIndex = 566
        Me.btnSearchKA.Text = "カ"
        Me.btnSearchKA.UseVisualStyleBackColor = True
        '
        'btnSearchA
        '
        Me.btnSearchA.Location = New System.Drawing.Point(11, 331)
        Me.btnSearchA.Name = "btnSearchA"
        Me.btnSearchA.Size = New System.Drawing.Size(22, 19)
        Me.btnSearchA.TabIndex = 564
        Me.btnSearchA.Text = "ア"
        Me.btnSearchA.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(72, 286)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(76, 31)
        Me.btnSearch.TabIndex = 554
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(335, 281)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(83, 41)
        Me.btnHistory.TabIndex = 550
        Me.btnHistory.Text = "入退院履歴"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 251)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 12)
        Me.Label14.TabIndex = 560
        Me.Label14.Text = "コメント２"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 217)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 12)
        Me.Label13.TabIndex = 559
        Me.Label13.Text = "コメント１"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(217, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 12)
        Me.Label11.TabIndex = 557
        Me.Label11.Text = "続柄"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 12)
        Me.Label10.TabIndex = 556
        Me.Label10.Text = "キーパーソン①"
        '
        'chkNurse
        '
        Me.chkNurse.AutoSize = True
        Me.chkNurse.Location = New System.Drawing.Point(727, 33)
        Me.chkNurse.Name = "chkNurse"
        Me.chkNurse.Size = New System.Drawing.Size(96, 16)
        Me.chkNurse.TabIndex = 567
        Me.chkNurse.Text = "一般看護記録"
        Me.chkNurse.UseVisualStyleBackColor = True
        '
        'chkSanato
        '
        Me.chkSanato.AutoSize = True
        Me.chkSanato.Location = New System.Drawing.Point(645, 33)
        Me.chkSanato.Name = "chkSanato"
        Me.chkSanato.Size = New System.Drawing.Size(76, 16)
        Me.chkSanato.TabIndex = 565
        Me.chkSanato.Text = "療養カルテ"
        Me.chkSanato.UseVisualStyleBackColor = True
        '
        'chkDiary
        '
        Me.chkDiary.AutoSize = True
        Me.chkDiary.Location = New System.Drawing.Point(591, 33)
        Me.chkDiary.Name = "chkDiary"
        Me.chkDiary.Size = New System.Drawing.Size(48, 16)
        Me.chkDiary.TabIndex = 563
        Me.chkDiary.Text = "日誌"
        Me.chkDiary.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 12)
        Me.Label8.TabIndex = 551
        Me.Label8.Text = "患者コード"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 12)
        Me.Label7.TabIndex = 548
        Me.Label7.Text = "現住所"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(449, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 546
        Me.Label6.Text = "電話番号"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 544
        Me.Label5.Text = "生年月日"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(165, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 543
        Me.Label4.Text = "性別"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(358, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 12)
        Me.Label3.TabIndex = 540
        Me.Label3.Text = "カナ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 538
        Me.Label2.Text = "氏名"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 537
        Me.Label1.Text = "主治医"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(635, 234)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(61, 33)
        Me.btnDelete.TabIndex = 547
        Me.btnDelete.Text = "削除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRegist
        '
        Me.btnRegist.Location = New System.Drawing.Point(575, 234)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(60, 33)
        Me.btnRegist.TabIndex = 606
        Me.btnRegist.Text = "登録"
        Me.btnRegist.UseVisualStyleBackColor = True
        '
        'codBox
        '
        Me.codBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.codBox.Location = New System.Drawing.Point(72, 29)
        Me.codBox.Name = "codBox"
        Me.codBox.Size = New System.Drawing.Size(85, 19)
        Me.codBox.TabIndex = 578
        '
        'namBox
        '
        Me.namBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.namBox.Location = New System.Drawing.Point(199, 29)
        Me.namBox.Name = "namBox"
        Me.namBox.Size = New System.Drawing.Size(152, 19)
        Me.namBox.TabIndex = 579
        '
        'kanaBox
        '
        Me.kanaBox.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        Me.kanaBox.Location = New System.Drawing.Point(387, 29)
        Me.kanaBox.Name = "kanaBox"
        Me.kanaBox.Size = New System.Drawing.Size(145, 19)
        Me.kanaBox.TabIndex = 580
        '
        'birthBox
        '
        Me.birthBox.boxType = 0
        Me.birthBox.DateText = ""
        Me.birthBox.EraLabelText = "R02"
        Me.birthBox.EraText = ""
        Me.birthBox.Location = New System.Drawing.Point(71, 63)
        Me.birthBox.MonthLabelText = "06"
        Me.birthBox.MonthText = ""
        Me.birthBox.Name = "birthBox"
        Me.birthBox.Size = New System.Drawing.Size(86, 20)
        Me.birthBox.TabIndex = 581
        Me.birthBox.textReadOnly = False
        '
        'sexBox
        '
        Me.sexBox.FormattingEnabled = True
        Me.sexBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.sexBox.Items.AddRange(New Object() {"男", "女"})
        Me.sexBox.Location = New System.Drawing.Point(199, 63)
        Me.sexBox.Name = "sexBox"
        Me.sexBox.Size = New System.Drawing.Size(42, 20)
        Me.sexBox.TabIndex = 582
        '
        'docBox
        '
        Me.docBox.FormattingEnabled = True
        Me.docBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.docBox.Location = New System.Drawing.Point(306, 63)
        Me.docBox.Name = "docBox"
        Me.docBox.Size = New System.Drawing.Size(66, 20)
        Me.docBox.TabIndex = 583
        '
        'jyu1Box
        '
        Me.jyu1Box.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.jyu1Box.Location = New System.Drawing.Point(72, 99)
        Me.jyu1Box.Name = "jyu1Box"
        Me.jyu1Box.Size = New System.Drawing.Size(362, 19)
        Me.jyu1Box.TabIndex = 584
        '
        'tel1Box
        '
        Me.tel1Box.Location = New System.Drawing.Point(511, 99)
        Me.tel1Box.Name = "tel1Box"
        Me.tel1Box.Size = New System.Drawing.Size(147, 19)
        Me.tel1Box.TabIndex = 585
        '
        'KNamBox
        '
        Me.KNamBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.KNamBox.Location = New System.Drawing.Point(94, 141)
        Me.KNamBox.Name = "KNamBox"
        Me.KNamBox.Size = New System.Drawing.Size(116, 19)
        Me.KNamBox.TabIndex = 586
        '
        'zokBox
        '
        Me.zokBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.zokBox.Location = New System.Drawing.Point(251, 141)
        Me.zokBox.Name = "zokBox"
        Me.zokBox.Size = New System.Drawing.Size(58, 19)
        Me.zokBox.TabIndex = 587
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(317, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 588
        Me.Label9.Text = "住所"
        '
        'jyu2Box
        '
        Me.jyu2Box.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.jyu2Box.Location = New System.Drawing.Point(351, 141)
        Me.jyu2Box.Name = "jyu2Box"
        Me.jyu2Box.Size = New System.Drawing.Size(247, 19)
        Me.jyu2Box.TabIndex = 589
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(603, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 12)
        Me.Label12.TabIndex = 590
        Me.Label12.Text = "電話1"
        '
        'tel2Box
        '
        Me.tel2Box.Location = New System.Drawing.Point(642, 141)
        Me.tel2Box.Name = "tel2Box"
        Me.tel2Box.Size = New System.Drawing.Size(107, 19)
        Me.tel2Box.TabIndex = 591
        '
        'tel3Box
        '
        Me.tel3Box.Location = New System.Drawing.Point(794, 141)
        Me.tel3Box.Name = "tel3Box"
        Me.tel3Box.Size = New System.Drawing.Size(107, 19)
        Me.tel3Box.TabIndex = 593
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(755, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 12)
        Me.Label15.TabIndex = 592
        Me.Label15.Text = "電話2"
        '
        'tel5Box
        '
        Me.tel5Box.Location = New System.Drawing.Point(794, 174)
        Me.tel5Box.Name = "tel5Box"
        Me.tel5Box.Size = New System.Drawing.Size(107, 19)
        Me.tel5Box.TabIndex = 603
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(755, 177)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 12)
        Me.Label16.TabIndex = 602
        Me.Label16.Text = "電話2"
        '
        'tel4Box
        '
        Me.tel4Box.Location = New System.Drawing.Point(642, 174)
        Me.tel4Box.Name = "tel4Box"
        Me.tel4Box.Size = New System.Drawing.Size(107, 19)
        Me.tel4Box.TabIndex = 601
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(603, 177)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 12)
        Me.Label17.TabIndex = 600
        Me.Label17.Text = "電話1"
        '
        'jyu3Box
        '
        Me.jyu3Box.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.jyu3Box.Location = New System.Drawing.Point(351, 174)
        Me.jyu3Box.Name = "jyu3Box"
        Me.jyu3Box.Size = New System.Drawing.Size(247, 19)
        Me.jyu3Box.TabIndex = 599
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(317, 177)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 12)
        Me.Label18.TabIndex = 598
        Me.Label18.Text = "住所"
        '
        'zok2Box
        '
        Me.zok2Box.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.zok2Box.Location = New System.Drawing.Point(251, 174)
        Me.zok2Box.Name = "zok2Box"
        Me.zok2Box.Size = New System.Drawing.Size(58, 19)
        Me.zok2Box.TabIndex = 597
        '
        'KNam2Box
        '
        Me.KNam2Box.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.KNam2Box.Location = New System.Drawing.Point(94, 174)
        Me.KNam2Box.Name = "KNam2Box"
        Me.KNam2Box.Size = New System.Drawing.Size(116, 19)
        Me.KNam2Box.TabIndex = 596
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(217, 177)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 12)
        Me.Label19.TabIndex = 595
        Me.Label19.Text = "続柄"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 177)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 12)
        Me.Label20.TabIndex = 594
        Me.Label20.Text = "キーパーソン②"
        '
        'com1Box
        '
        Me.com1Box.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.com1Box.Location = New System.Drawing.Point(72, 214)
        Me.com1Box.Name = "com1Box"
        Me.com1Box.Size = New System.Drawing.Size(237, 19)
        Me.com1Box.TabIndex = 604
        '
        'com2Box
        '
        Me.com2Box.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.com2Box.Location = New System.Drawing.Point(72, 248)
        Me.com2Box.Name = "com2Box"
        Me.com2Box.Size = New System.Drawing.Size(237, 19)
        Me.com2Box.TabIndex = 605
        '
        'dgvUsrM
        '
        Me.dgvUsrM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsrM.Location = New System.Drawing.Point(33, 332)
        Me.dgvUsrM.Name = "dgvUsrM"
        Me.dgvUsrM.RowTemplate.Height = 21
        Me.dgvUsrM.Size = New System.Drawing.Size(900, 339)
        Me.dgvUsrM.TabIndex = 607
        '
        'chkAllowTel
        '
        Me.chkAllowTel.AutoSize = True
        Me.chkAllowTel.Location = New System.Drawing.Point(348, 243)
        Me.chkAllowTel.Name = "chkAllowTel"
        Me.chkAllowTel.Size = New System.Drawing.Size(60, 16)
        Me.chkAllowTel.TabIndex = 608
        Me.chkAllowTel.Text = "電話×"
        Me.chkAllowTel.UseVisualStyleBackColor = True
        '
        'chkAllowNyu
        '
        Me.chkAllowNyu.AutoSize = True
        Me.chkAllowNyu.Location = New System.Drawing.Point(412, 242)
        Me.chkAllowNyu.Name = "chkAllowNyu"
        Me.chkAllowNyu.Size = New System.Drawing.Size(90, 16)
        Me.chkAllowNyu.TabIndex = 609
        Me.chkAllowNyu.Text = "入院伝える×"
        Me.chkAllowNyu.UseVisualStyleBackColor = True
        '
        'memoText
        '
        Me.memoText.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.memoText.Location = New System.Drawing.Point(484, 273)
        Me.memoText.Name = "memoText"
        Me.memoText.Size = New System.Drawing.Size(114, 19)
        Me.memoText.TabIndex = 610
        Me.memoText.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(452, 276)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 12)
        Me.Label21.TabIndex = 611
        Me.Label21.Text = "備考"
        Me.Label21.Visible = False
        '
        'btnPatientPrint
        '
        Me.btnPatientPrint.Location = New System.Drawing.Point(12, 32)
        Me.btnPatientPrint.Name = "btnPatientPrint"
        Me.btnPatientPrint.Size = New System.Drawing.Size(130, 50)
        Me.btnPatientPrint.TabIndex = 612
        Me.btnPatientPrint.Text = "在院患者一覧印刷"
        Me.btnPatientPrint.UseVisualStyleBackColor = True
        '
        'rbtnAiueo
        '
        Me.rbtnAiueo.AutoSize = True
        Me.rbtnAiueo.Location = New System.Drawing.Point(12, 10)
        Me.rbtnAiueo.Name = "rbtnAiueo"
        Me.rbtnAiueo.Size = New System.Drawing.Size(72, 16)
        Me.rbtnAiueo.TabIndex = 613
        Me.rbtnAiueo.Text = "ｱｲｳｴｵ順"
        Me.rbtnAiueo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbtnByoto)
        Me.Panel1.Controls.Add(Me.btnPatientPrint)
        Me.Panel1.Controls.Add(Me.rbtnAiueo)
        Me.Panel1.Location = New System.Drawing.Point(867, 199)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(158, 91)
        Me.Panel1.TabIndex = 614
        '
        'rbtnByoto
        '
        Me.rbtnByoto.AutoSize = True
        Me.rbtnByoto.Checked = True
        Me.rbtnByoto.Location = New System.Drawing.Point(86, 10)
        Me.rbtnByoto.Name = "rbtnByoto"
        Me.rbtnByoto.Size = New System.Drawing.Size(59, 16)
        Me.rbtnByoto.TabIndex = 615
        Me.rbtnByoto.TabStop = True
        Me.rbtnByoto.Text = "病棟別"
        Me.rbtnByoto.UseVisualStyleBackColor = True
        '
        'chkCertificate
        '
        Me.chkCertificate.AutoSize = True
        Me.chkCertificate.Location = New System.Drawing.Point(348, 215)
        Me.chkCertificate.Name = "chkCertificate"
        Me.chkCertificate.Size = New System.Drawing.Size(119, 16)
        Me.chkCertificate.TabIndex = 615
        Me.chkCertificate.Text = "入院証書記入済み"
        Me.chkCertificate.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(939, 332)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(86, 36)
        Me.btnUpdate.TabIndex = 616
        Me.btnUpdate.Text = "一覧更新"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'searchPanel
        '
        Me.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchPanel.Controls.Add(Me.itemListBox)
        Me.searchPanel.Controls.Add(Me.Label22)
        Me.searchPanel.Controls.Add(Me.resultKanaLabel)
        Me.searchPanel.Controls.Add(Me.resultNamLabel)
        Me.searchPanel.Controls.Add(Me.btnNext)
        Me.searchPanel.Controls.Add(Me.btnPrev)
        Me.searchPanel.Controls.Add(Me.allSearchBox)
        Me.searchPanel.Controls.Add(Me.btnAllSearch)
        Me.searchPanel.Location = New System.Drawing.Point(1085, 199)
        Me.searchPanel.Name = "searchPanel"
        Me.searchPanel.Size = New System.Drawing.Size(264, 295)
        Me.searchPanel.TabIndex = 617
        Me.searchPanel.Visible = False
        '
        'itemListBox
        '
        Me.itemListBox.BackColor = System.Drawing.SystemColors.Control
        Me.itemListBox.FormattingEnabled = True
        Me.itemListBox.ItemHeight = 12
        Me.itemListBox.Location = New System.Drawing.Point(77, 181)
        Me.itemListBox.Name = "itemListBox"
        Me.itemListBox.Size = New System.Drawing.Size(106, 88)
        Me.itemListBox.TabIndex = 8
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(76, 159)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 12)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "以下の項目でHit"
        '
        'resultKanaLabel
        '
        Me.resultKanaLabel.AutoSize = True
        Me.resultKanaLabel.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.resultKanaLabel.ForeColor = System.Drawing.Color.Blue
        Me.resultKanaLabel.Location = New System.Drawing.Point(75, 119)
        Me.resultKanaLabel.Name = "resultKanaLabel"
        Me.resultKanaLabel.Size = New System.Drawing.Size(0, 15)
        Me.resultKanaLabel.TabIndex = 6
        '
        'resultNamLabel
        '
        Me.resultNamLabel.AutoSize = True
        Me.resultNamLabel.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.resultNamLabel.ForeColor = System.Drawing.Color.Blue
        Me.resultNamLabel.Location = New System.Drawing.Point(75, 135)
        Me.resultNamLabel.Name = "resultNamLabel"
        Me.resultNamLabel.Size = New System.Drawing.Size(0, 15)
        Me.resultNamLabel.TabIndex = 4
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(210, 76)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(45, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(10, 76)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(45, 23)
        Me.btnPrev.TabIndex = 2
        Me.btnPrev.Text = "<<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'allSearchBox
        '
        Me.allSearchBox.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.allSearchBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.allSearchBox.Location = New System.Drawing.Point(61, 31)
        Me.allSearchBox.Name = "allSearchBox"
        Me.allSearchBox.Size = New System.Drawing.Size(143, 22)
        Me.allSearchBox.TabIndex = 1
        '
        'btnAllSearch
        '
        Me.btnAllSearch.Location = New System.Drawing.Point(61, 59)
        Me.btnAllSearch.Name = "btnAllSearch"
        Me.btnAllSearch.Size = New System.Drawing.Size(143, 51)
        Me.btnAllSearch.TabIndex = 0
        Me.btnAllSearch.Text = "全ての情報で検索"
        Me.btnAllSearch.UseVisualStyleBackColor = True
        '
        'TopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1399, 677)
        Me.Controls.Add(Me.searchPanel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.chkCertificate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.memoText)
        Me.Controls.Add(Me.chkAllowNyu)
        Me.Controls.Add(Me.chkAllowTel)
        Me.Controls.Add(Me.dgvUsrM)
        Me.Controls.Add(Me.com2Box)
        Me.Controls.Add(Me.com1Box)
        Me.Controls.Add(Me.tel5Box)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.tel4Box)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.jyu3Box)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.zok2Box)
        Me.Controls.Add(Me.KNam2Box)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tel3Box)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tel2Box)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.jyu2Box)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.zokBox)
        Me.Controls.Add(Me.KNamBox)
        Me.Controls.Add(Me.tel1Box)
        Me.Controls.Add(Me.jyu1Box)
        Me.Controls.Add(Me.docBox)
        Me.Controls.Add(Me.sexBox)
        Me.Controls.Add(Me.birthBox)
        Me.Controls.Add(Me.kanaBox)
        Me.Controls.Add(Me.namBox)
        Me.Controls.Add(Me.codBox)
        Me.Controls.Add(Me.btnZai)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearchWA)
        Me.Controls.Add(Me.btnSearchRA)
        Me.Controls.Add(Me.btnSearchYA)
        Me.Controls.Add(Me.btnSearchMA)
        Me.Controls.Add(Me.btnSearchHA)
        Me.Controls.Add(Me.btnSearchNA)
        Me.Controls.Add(Me.btnSearchTA)
        Me.Controls.Add(Me.btnSearchSA)
        Me.Controls.Add(Me.btnSearchKA)
        Me.Controls.Add(Me.btnSearchA)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.chkNurse)
        Me.Controls.Add(Me.chkSanato)
        Me.Controls.Add(Me.chkDiary)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRegist)
        Me.Name = "TopForm"
        Me.Text = "Patient- 入院患者 -"
        CType(Me.dgvUsrM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.searchPanel.ResumeLayout(False)
        Me.searchPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnZai As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSearchWA As System.Windows.Forms.Button
    Friend WithEvents btnSearchRA As System.Windows.Forms.Button
    Friend WithEvents btnSearchYA As System.Windows.Forms.Button
    Friend WithEvents btnSearchMA As System.Windows.Forms.Button
    Friend WithEvents btnSearchHA As System.Windows.Forms.Button
    Friend WithEvents btnSearchNA As System.Windows.Forms.Button
    Friend WithEvents btnSearchTA As System.Windows.Forms.Button
    Friend WithEvents btnSearchSA As System.Windows.Forms.Button
    Friend WithEvents btnSearchKA As System.Windows.Forms.Button
    Friend WithEvents btnSearchA As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkNurse As System.Windows.Forms.CheckBox
    Friend WithEvents chkSanato As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiary As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents codBox As System.Windows.Forms.TextBox
    Friend WithEvents namBox As System.Windows.Forms.TextBox
    Friend WithEvents kanaBox As System.Windows.Forms.TextBox
    Friend WithEvents birthBox As ymdBox.ymdBox
    Friend WithEvents sexBox As System.Windows.Forms.ComboBox
    Friend WithEvents docBox As System.Windows.Forms.ComboBox
    Friend WithEvents jyu1Box As System.Windows.Forms.TextBox
    Friend WithEvents tel1Box As System.Windows.Forms.TextBox
    Friend WithEvents KNamBox As System.Windows.Forms.TextBox
    Friend WithEvents zokBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents jyu2Box As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tel2Box As System.Windows.Forms.TextBox
    Friend WithEvents tel3Box As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tel5Box As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tel4Box As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents jyu3Box As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents zok2Box As System.Windows.Forms.TextBox
    Friend WithEvents KNam2Box As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents com1Box As System.Windows.Forms.TextBox
    Friend WithEvents com2Box As System.Windows.Forms.TextBox
    Friend WithEvents dgvUsrM As System.Windows.Forms.DataGridView
    Friend WithEvents chkAllowTel As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllowNyu As System.Windows.Forms.CheckBox
    Friend WithEvents memoText As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnPatientPrint As System.Windows.Forms.Button
    Friend WithEvents rbtnAiueo As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbtnByoto As System.Windows.Forms.RadioButton
    Friend WithEvents chkCertificate As System.Windows.Forms.CheckBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents searchPanel As System.Windows.Forms.Panel
    Friend WithEvents allSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents btnAllSearch As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents resultNamLabel As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents resultKanaLabel As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents itemListBox As System.Windows.Forms.ListBox

End Class

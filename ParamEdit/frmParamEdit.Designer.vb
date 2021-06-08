<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParamEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtParamdef = New System.Windows.Forms.TextBox()
        Me.lblGAFile = New System.Windows.Forms.Label()
        Me.btnBrowseParamdef = New System.Windows.Forms.Button()
        Me.txtParam = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowseParam = New System.Windows.Forms.Button()
        Me.dgvParams = New System.Windows.Forms.DataGridView()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblVer = New System.Windows.Forms.Label()
        Me.txtParamName = New System.Windows.Forms.TextBox()
        Me.lblParamName = New System.Windows.Forms.Label()
        Me.txtUnk0x8 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUnk0x6 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExportCSV = New System.Windows.Forms.Button()
        Me.btnImportCSV = New System.Windows.Forms.Button()
        Me.includeHeaderCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.commaSeparatedCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.dgvParams, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtParamdef
        '
        Me.txtParamdef.AllowDrop = True
        Me.txtParamdef.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtParamdef.Location = New System.Drawing.Point(89, 14)
        Me.txtParamdef.Name = "txtParamdef"
        Me.txtParamdef.Size = New System.Drawing.Size(634, 20)
        Me.txtParamdef.TabIndex = 29
        '
        'lblGAFile
        '
        Me.lblGAFile.AutoSize = True
        Me.lblGAFile.Location = New System.Drawing.Point(31, 17)
        Me.lblGAFile.Name = "lblGAFile"
        Me.lblGAFile.Size = New System.Drawing.Size(52, 13)
        Me.lblGAFile.TabIndex = 31
        Me.lblGAFile.Text = "Paramdef"
        '
        'btnBrowseParamdef
        '
        Me.btnBrowseParamdef.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseParamdef.Location = New System.Drawing.Point(726, 12)
        Me.btnBrowseParamdef.Name = "btnBrowseParamdef"
        Me.btnBrowseParamdef.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseParamdef.TabIndex = 30
        Me.btnBrowseParamdef.Text = "Browse"
        Me.btnBrowseParamdef.UseVisualStyleBackColor = True
        '
        'txtParam
        '
        Me.txtParam.AllowDrop = True
        Me.txtParam.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtParam.Location = New System.Drawing.Point(89, 43)
        Me.txtParam.Name = "txtParam"
        Me.txtParam.Size = New System.Drawing.Size(634, 20)
        Me.txtParam.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Param"
        '
        'btnBrowseParam
        '
        Me.btnBrowseParam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseParam.Location = New System.Drawing.Point(726, 41)
        Me.btnBrowseParam.Name = "btnBrowseParam"
        Me.btnBrowseParam.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseParam.TabIndex = 33
        Me.btnBrowseParam.Text = "Browse"
        Me.btnBrowseParam.UseVisualStyleBackColor = True
        '
        'dgvParams
        '
        Me.dgvParams.AllowDrop = True
        Me.dgvParams.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvParams.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParams.Location = New System.Drawing.Point(12, 172)
        Me.dgvParams.Name = "dgvParams"
        Me.dgvParams.Size = New System.Drawing.Size(789, 561)
        Me.dgvParams.TabIndex = 36
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.Location = New System.Drawing.Point(645, 70)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(78, 23)
        Me.btnOpen.TabIndex = 37
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(726, 70)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(12, 69)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(182, 23)
        Me.btnUpdate.TabIndex = 78
        Me.btnUpdate.Text = "Update Param Editor"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'lblVer
        '
        Me.lblVer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVer.AutoSize = True
        Me.lblVer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVer.Location = New System.Drawing.Point(725, 153)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(76, 13)
        Me.lblVer.TabIndex = 77
        Me.lblVer.Text = "2018.03.23.22"
        '
        'txtParamName
        '
        Me.txtParamName.AllowDrop = True
        Me.txtParamName.Location = New System.Drawing.Point(89, 139)
        Me.txtParamName.Name = "txtParamName"
        Me.txtParamName.Size = New System.Drawing.Size(207, 20)
        Me.txtParamName.TabIndex = 79
        '
        'lblParamName
        '
        Me.lblParamName.AutoSize = True
        Me.lblParamName.Location = New System.Drawing.Point(9, 142)
        Me.lblParamName.Name = "lblParamName"
        Me.lblParamName.Size = New System.Drawing.Size(68, 13)
        Me.lblParamName.TabIndex = 80
        Me.lblParamName.Text = "Param Name"
        '
        'txtUnk0x8
        '
        Me.txtUnk0x8.AllowDrop = True
        Me.txtUnk0x8.Location = New System.Drawing.Point(341, 139)
        Me.txtUnk0x8.Name = "txtUnk0x8"
        Me.txtUnk0x8.Size = New System.Drawing.Size(64, 20)
        Me.txtUnk0x8.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "(0x8?)"
        '
        'txtUnk0x6
        '
        Me.txtUnk0x6.AllowDrop = True
        Me.txtUnk0x6.Location = New System.Drawing.Point(341, 113)
        Me.txtUnk0x6.Name = "txtUnk0x6"
        Me.txtUnk0x6.Size = New System.Drawing.Size(64, 20)
        Me.txtUnk0x6.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(299, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "(0x6?)"
        '
        'btnExportCSV
        '
        Me.btnExportCSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportCSV.Location = New System.Drawing.Point(87, 19)
        Me.btnExportCSV.Name = "btnExportCSV"
        Me.btnExportCSV.Size = New System.Drawing.Size(75, 23)
        Me.btnExportCSV.TabIndex = 86
        Me.btnExportCSV.Text = "Export CSV"
        Me.btnExportCSV.UseVisualStyleBackColor = True
        '
        'btnImportCSV
        '
        Me.btnImportCSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportCSV.Location = New System.Drawing.Point(6, 19)
        Me.btnImportCSV.Name = "btnImportCSV"
        Me.btnImportCSV.Size = New System.Drawing.Size(75, 23)
        Me.btnImportCSV.TabIndex = 85
        Me.btnImportCSV.Text = "Import CSV"
        Me.btnImportCSV.UseVisualStyleBackColor = True
        '
        'includeHeaderCheckBox
        '
        Me.includeHeaderCheckBox.AutoSize = True
        Me.includeHeaderCheckBox.Location = New System.Drawing.Point(6, 48)
        Me.includeHeaderCheckBox.Name = "includeHeaderCheckBox"
        Me.includeHeaderCheckBox.Size = New System.Drawing.Size(104, 17)
        Me.includeHeaderCheckBox.TabIndex = 87
        Me.includeHeaderCheckBox.Text = "Include Headers"
        Me.includeHeaderCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.commaSeparatedCheckBox)
        Me.GroupBox1.Controls.Add(Me.includeHeaderCheckBox)
        Me.GroupBox1.Controls.Add(Me.btnImportCSV)
        Me.GroupBox1.Controls.Add(Me.btnExportCSV)
        Me.GroupBox1.Location = New System.Drawing.Point(411, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 96)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CSV Options"
        '
        'commaSeparatedCheckBox
        '
        Me.commaSeparatedCheckBox.AutoSize = True
        Me.commaSeparatedCheckBox.Location = New System.Drawing.Point(6, 71)
        Me.commaSeparatedCheckBox.Name = "commaSeparatedCheckBox"
        Me.commaSeparatedCheckBox.Size = New System.Drawing.Size(113, 17)
        Me.commaSeparatedCheckBox.TabIndex = 88
        Me.commaSeparatedCheckBox.Text = "Comma Separated"
        Me.commaSeparatedCheckBox.UseVisualStyleBackColor = True
        '
        'frmParamEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 741)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtUnk0x6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUnk0x8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtParamName)
        Me.Controls.Add(Me.lblParamName)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblVer)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.dgvParams)
        Me.Controls.Add(Me.txtParam)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBrowseParam)
        Me.Controls.Add(Me.txtParamdef)
        Me.Controls.Add(Me.lblGAFile)
        Me.Controls.Add(Me.btnBrowseParamdef)
        Me.Name = "frmParamEdit"
        Me.Text = "Wulf's Souls Series Parameter Editor"
        CType(Me.dgvParams, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents txtParamdef As System.Windows.Forms.TextBox
    Friend WithEvents lblGAFile As System.Windows.Forms.Label
    Friend WithEvents btnBrowseParamdef As System.Windows.Forms.Button
    Friend WithEvents txtParam As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseParam As System.Windows.Forms.Button
    Friend WithEvents dgvParams As System.Windows.Forms.DataGridView
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblVer As Label
    Friend WithEvents txtParamName As TextBox
    Friend WithEvents lblParamName As Label
    Friend WithEvents txtUnk0x8 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUnk0x6 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExportCSV As Button
    Friend WithEvents btnImportCSV As Button
    Friend WithEvents includeHeaderCheckBox As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents commaSeparatedCheckBox As CheckBox
End Class

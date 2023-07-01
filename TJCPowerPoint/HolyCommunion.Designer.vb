<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HolyCommunion
    Inherits DraggableForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HolyCommunion))
        Me.navBar = New System.Windows.Forms.Panel()
        Me.header = New System.Windows.Forms.Label()
        Me.enlargePreviewBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.colorCupBtn = New System.Windows.Forms.Button()
        Me.fontCupBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.prevHymn = New System.Windows.Forms.Button()
        Me.nextHymn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cupTxt = New System.Windows.Forms.TextBox()
        Me.fontBreadBtn = New System.Windows.Forms.Button()
        Me.HymnFontBtn = New System.Windows.Forms.Button()
        Me.HymnColorBtn = New System.Windows.Forms.Button()
        Me.colorBreadBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.delHymnBtn = New System.Windows.Forms.Button()
        Me.clearHymnsBtn = New System.Windows.Forms.Button()
        Me.previewBox = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.hymnsGroupBox = New System.Windows.Forms.GroupBox()
        Me.HymnsSelectionBox = New System.Windows.Forms.ListBox()
        Me.HymnNos = New System.Windows.Forms.TextBox()
        Me.updateHC = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.breadTxt = New System.Windows.Forms.TextBox()
        Me.navBar.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.previewBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.hymnsGroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'navBar
        '
        Me.navBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.navBar.BackColor = System.Drawing.Color.Transparent
        Me.navBar.Controls.Add(Me.header)
        Me.navBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.navBar.Location = New System.Drawing.Point(0, 0)
        Me.navBar.Name = "navBar"
        Me.navBar.Padding = New System.Windows.Forms.Padding(5)
        Me.navBar.Size = New System.Drawing.Size(800, 44)
        Me.navBar.TabIndex = 62
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.Transparent
        Me.header.Cursor = System.Windows.Forms.Cursors.Default
        Me.header.Dock = System.Windows.Forms.DockStyle.Left
        Me.header.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.SteelBlue
        Me.header.Location = New System.Drawing.Point(5, 5)
        Me.header.Margin = New System.Windows.Forms.Padding(10)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(187, 30)
        Me.header.TabIndex = 2
        Me.header.Text = "Holy Communion"
        Me.header.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'enlargePreviewBtn
        '
        Me.enlargePreviewBtn.BackColor = System.Drawing.Color.Transparent
        Me.enlargePreviewBtn.BackgroundImage = CType(resources.GetObject("enlargePreviewBtn.BackgroundImage"), System.Drawing.Image)
        Me.enlargePreviewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.enlargePreviewBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.enlargePreviewBtn.FlatAppearance.BorderSize = 0
        Me.enlargePreviewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enlargePreviewBtn.Location = New System.Drawing.Point(743, 337)
        Me.enlargePreviewBtn.Name = "enlargePreviewBtn"
        Me.enlargePreviewBtn.Size = New System.Drawing.Size(25, 25)
        Me.enlargePreviewBtn.TabIndex = 61
        Me.enlargePreviewBtn.TabStop = False
        Me.enlargePreviewBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(552, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Slide Preview"
        '
        'colorCupBtn
        '
        Me.colorCupBtn.BackgroundImage = CType(resources.GetObject("colorCupBtn.BackgroundImage"), System.Drawing.Image)
        Me.colorCupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.colorCupBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.colorCupBtn.Location = New System.Drawing.Point(3, 3)
        Me.colorCupBtn.Name = "colorCupBtn"
        Me.colorCupBtn.Size = New System.Drawing.Size(25, 25)
        Me.colorCupBtn.TabIndex = 56
        Me.colorCupBtn.TabStop = False
        Me.colorCupBtn.UseVisualStyleBackColor = True
        '
        'fontCupBtn
        '
        Me.fontCupBtn.BackgroundImage = CType(resources.GetObject("fontCupBtn.BackgroundImage"), System.Drawing.Image)
        Me.fontCupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fontCupBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fontCupBtn.Location = New System.Drawing.Point(34, 3)
        Me.fontCupBtn.Name = "fontCupBtn"
        Me.fontCupBtn.Size = New System.Drawing.Size(25, 25)
        Me.fontCupBtn.TabIndex = 57
        Me.fontCupBtn.TabStop = False
        Me.fontCupBtn.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel3.Controls.Add(Me.colorCupBtn)
        Me.FlowLayoutPanel3.Controls.Add(Me.fontCupBtn)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 345)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(194, 31)
        Me.FlowLayoutPanel3.TabIndex = 58
        '
        'prevHymn
        '
        Me.prevHymn.BackgroundImage = CType(resources.GetObject("prevHymn.BackgroundImage"), System.Drawing.Image)
        Me.prevHymn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.prevHymn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.prevHymn.Location = New System.Drawing.Point(3, 3)
        Me.prevHymn.Name = "prevHymn"
        Me.prevHymn.Size = New System.Drawing.Size(25, 25)
        Me.prevHymn.TabIndex = 47
        Me.prevHymn.TabStop = False
        Me.prevHymn.UseVisualStyleBackColor = True
        '
        'nextHymn
        '
        Me.nextHymn.BackgroundImage = CType(resources.GetObject("nextHymn.BackgroundImage"), System.Drawing.Image)
        Me.nextHymn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nextHymn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nextHymn.Location = New System.Drawing.Point(3, 34)
        Me.nextHymn.Name = "nextHymn"
        Me.nextHymn.Size = New System.Drawing.Size(25, 25)
        Me.nextHymn.TabIndex = 46
        Me.nextHymn.TabStop = False
        Me.nextHymn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.FlowLayoutPanel3)
        Me.GroupBox3.Controls.Add(Me.cupTxt)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(336, 44)
        Me.GroupBox3.MinimumSize = New System.Drawing.Size(200, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 379)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cup"
        '
        'cupTxt
        '
        Me.cupTxt.AcceptsReturn = True
        Me.cupTxt.AcceptsTab = True
        Me.cupTxt.BackColor = System.Drawing.Color.White
        Me.cupTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.cupTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cupTxt.ForeColor = System.Drawing.Color.Black
        Me.cupTxt.Location = New System.Drawing.Point(3, 22)
        Me.cupTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cupTxt.Multiline = True
        Me.cupTxt.Name = "cupTxt"
        Me.cupTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.cupTxt.Size = New System.Drawing.Size(194, 266)
        Me.cupTxt.TabIndex = 1
        Me.cupTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fontBreadBtn
        '
        Me.fontBreadBtn.BackgroundImage = CType(resources.GetObject("fontBreadBtn.BackgroundImage"), System.Drawing.Image)
        Me.fontBreadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fontBreadBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fontBreadBtn.Location = New System.Drawing.Point(34, 3)
        Me.fontBreadBtn.Name = "fontBreadBtn"
        Me.fontBreadBtn.Size = New System.Drawing.Size(25, 25)
        Me.fontBreadBtn.TabIndex = 55
        Me.fontBreadBtn.TabStop = False
        Me.fontBreadBtn.UseVisualStyleBackColor = True
        '
        'HymnFontBtn
        '
        Me.HymnFontBtn.BackgroundImage = CType(resources.GetObject("HymnFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.HymnFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnFontBtn.Location = New System.Drawing.Point(3, 65)
        Me.HymnFontBtn.Name = "HymnFontBtn"
        Me.HymnFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.HymnFontBtn.TabIndex = 52
        Me.HymnFontBtn.TabStop = False
        Me.HymnFontBtn.UseVisualStyleBackColor = True
        '
        'HymnColorBtn
        '
        Me.HymnColorBtn.BackgroundImage = CType(resources.GetObject("HymnColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.HymnColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnColorBtn.Location = New System.Drawing.Point(3, 96)
        Me.HymnColorBtn.Name = "HymnColorBtn"
        Me.HymnColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.HymnColorBtn.TabIndex = 51
        Me.HymnColorBtn.TabStop = False
        Me.HymnColorBtn.UseVisualStyleBackColor = True
        '
        'colorBreadBtn
        '
        Me.colorBreadBtn.BackgroundImage = CType(resources.GetObject("colorBreadBtn.BackgroundImage"), System.Drawing.Image)
        Me.colorBreadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.colorBreadBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.colorBreadBtn.Location = New System.Drawing.Point(3, 3)
        Me.colorBreadBtn.Name = "colorBreadBtn"
        Me.colorBreadBtn.Size = New System.Drawing.Size(25, 25)
        Me.colorBreadBtn.TabIndex = 54
        Me.colorBreadBtn.TabStop = False
        Me.colorBreadBtn.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Controls.Add(Me.colorBreadBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.fontBreadBtn)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 345)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(194, 31)
        Me.FlowLayoutPanel2.TabIndex = 56
        '
        'delHymnBtn
        '
        Me.delHymnBtn.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.icons8_delete_trash_20
        Me.delHymnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delHymnBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delHymnBtn.Location = New System.Drawing.Point(3, 127)
        Me.delHymnBtn.Name = "delHymnBtn"
        Me.delHymnBtn.Size = New System.Drawing.Size(25, 25)
        Me.delHymnBtn.TabIndex = 45
        Me.delHymnBtn.TabStop = False
        Me.delHymnBtn.UseVisualStyleBackColor = True
        '
        'clearHymnsBtn
        '
        Me.clearHymnsBtn.AutoSize = True
        Me.clearHymnsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.clearHymnsBtn.BackColor = System.Drawing.Color.Transparent
        Me.clearHymnsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.clearHymnsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearHymnsBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.clearHymnsBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearHymnsBtn.ForeColor = System.Drawing.Color.Maroon
        Me.clearHymnsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clearHymnsBtn.Location = New System.Drawing.Point(3, 351)
        Me.clearHymnsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.clearHymnsBtn.Name = "clearHymnsBtn"
        Me.clearHymnsBtn.Size = New System.Drawing.Size(130, 25)
        Me.clearHymnsBtn.TabIndex = 53
        Me.clearHymnsBtn.TabStop = False
        Me.clearHymnsBtn.Text = "Clear All"
        Me.clearHymnsBtn.UseVisualStyleBackColor = False
        '
        'previewBox
        '
        Me.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.previewBox.Image = Global.TJCPowerPoint.My.Resources.Resources.border1
        Me.previewBox.Location = New System.Drawing.Point(552, 226)
        Me.previewBox.Name = "previewBox"
        Me.previewBox.Size = New System.Drawing.Size(219, 139)
        Me.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.previewBox.TabIndex = 59
        Me.previewBox.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.prevHymn)
        Me.FlowLayoutPanel1.Controls.Add(Me.nextHymn)
        Me.FlowLayoutPanel1.Controls.Add(Me.HymnFontBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.HymnColorBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.delHymnBtn)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(102, 52)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(31, 299)
        Me.FlowLayoutPanel1.TabIndex = 54
        '
        'hymnsGroupBox
        '
        Me.hymnsGroupBox.AutoSize = True
        Me.hymnsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.hymnsGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.hymnsGroupBox.Controls.Add(Me.FlowLayoutPanel1)
        Me.hymnsGroupBox.Controls.Add(Me.HymnsSelectionBox)
        Me.hymnsGroupBox.Controls.Add(Me.clearHymnsBtn)
        Me.hymnsGroupBox.Controls.Add(Me.HymnNos)
        Me.hymnsGroupBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.hymnsGroupBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hymnsGroupBox.Location = New System.Drawing.Point(0, 44)
        Me.hymnsGroupBox.Name = "hymnsGroupBox"
        Me.hymnsGroupBox.Size = New System.Drawing.Size(136, 379)
        Me.hymnsGroupBox.TabIndex = 56
        Me.hymnsGroupBox.TabStop = False
        Me.hymnsGroupBox.Text = "Hymn(s)"
        '
        'HymnsSelectionBox
        '
        Me.HymnsSelectionBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnsSelectionBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.HymnsSelectionBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HymnsSelectionBox.FormattingEnabled = True
        Me.HymnsSelectionBox.ItemHeight = 21
        Me.HymnsSelectionBox.Location = New System.Drawing.Point(3, 52)
        Me.HymnsSelectionBox.Name = "HymnsSelectionBox"
        Me.HymnsSelectionBox.ScrollAlwaysVisible = True
        Me.HymnsSelectionBox.Size = New System.Drawing.Size(99, 299)
        Me.HymnsSelectionBox.TabIndex = 44
        Me.HymnsSelectionBox.TabStop = False
        '
        'HymnNos
        '
        Me.HymnNos.AcceptsReturn = True
        Me.HymnNos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HymnNos.Dock = System.Windows.Forms.DockStyle.Top
        Me.HymnNos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HymnNos.Location = New System.Drawing.Point(3, 23)
        Me.HymnNos.Multiline = True
        Me.HymnNos.Name = "HymnNos"
        Me.HymnNos.Size = New System.Drawing.Size(130, 29)
        Me.HymnNos.TabIndex = 42
        Me.HymnNos.TabStop = False
        '
        'updateHC
        '
        Me.updateHC.AutoSize = True
        Me.updateHC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.updateHC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateHC.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.updateHC.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateHC.ForeColor = System.Drawing.Color.Navy
        Me.updateHC.Location = New System.Drawing.Point(0, 423)
        Me.updateHC.Margin = New System.Windows.Forms.Padding(0)
        Me.updateHC.Name = "updateHC"
        Me.updateHC.Size = New System.Drawing.Size(800, 27)
        Me.updateHC.TabIndex = 55
        Me.updateHC.Text = "Update Holy Communion Slide"
        Me.updateHC.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupBox2.Controls.Add(Me.breadTxt)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(136, 44)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(200, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 379)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bread"
        '
        'breadTxt
        '
        Me.breadTxt.AcceptsReturn = True
        Me.breadTxt.AcceptsTab = True
        Me.breadTxt.BackColor = System.Drawing.Color.White
        Me.breadTxt.Dock = System.Windows.Forms.DockStyle.Top
        Me.breadTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breadTxt.ForeColor = System.Drawing.Color.Black
        Me.breadTxt.Location = New System.Drawing.Point(3, 22)
        Me.breadTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.breadTxt.MinimumSize = New System.Drawing.Size(100, 4)
        Me.breadTxt.Multiline = True
        Me.breadTxt.Name = "breadTxt"
        Me.breadTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.breadTxt.Size = New System.Drawing.Size(194, 266)
        Me.breadTxt.TabIndex = 0
        Me.breadTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HolyCommunion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.enlargePreviewBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.previewBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.hymnsGroupBox)
        Me.Controls.Add(Me.navBar)
        Me.Controls.Add(Me.updateHC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "HolyCommunion"
        Me.Text = "Holy Communion"
        Me.navBar.ResumeLayout(False)
        Me.navBar.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.previewBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.hymnsGroupBox.ResumeLayout(False)
        Me.hymnsGroupBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents navBar As Panel
    Friend WithEvents header As Label
    Friend WithEvents enlargePreviewBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents colorCupBtn As Button
    Friend WithEvents fontCupBtn As Button
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents prevHymn As Button
    Friend WithEvents nextHymn As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cupTxt As TextBox
    Friend WithEvents fontBreadBtn As Button
    Friend WithEvents HymnFontBtn As Button
    Friend WithEvents HymnColorBtn As Button
    Friend WithEvents colorBreadBtn As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents delHymnBtn As Button
    Friend WithEvents clearHymnsBtn As Button
    Friend WithEvents previewBox As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents hymnsGroupBox As GroupBox
    Friend WithEvents HymnsSelectionBox As ListBox
    Friend WithEvents HymnNos As TextBox
    Friend WithEvents updateHC As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents breadTxt As TextBox
End Class

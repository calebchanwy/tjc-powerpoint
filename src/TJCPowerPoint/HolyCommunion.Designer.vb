<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HolyCommunion
    Inherits Form

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
        Me.header = New System.Windows.Forms.Label()
        Me.enlargePreviewBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.colorCupBtn = New System.Windows.Forms.Button()
        Me.fontCupBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.prevHymn = New System.Windows.Forms.Button()
        Me.nextHymn = New System.Windows.Forms.Button()
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
        Me.HymnsSelectionBox = New System.Windows.Forms.ListBox()
        Me.HymnNos = New System.Windows.Forms.TextBox()
        Me.updateHC = New System.Windows.Forms.Button()
        Me.breadTxt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.previewBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.Transparent
        Me.header.Cursor = System.Windows.Forms.Cursors.Default
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.SystemColors.ControlText
        Me.header.Location = New System.Drawing.Point(10, 10)
        Me.header.Margin = New System.Windows.Forms.Padding(10)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(216, 30)
        Me.header.TabIndex = 2
        Me.header.Text = "Edit Holy Communion"
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
        Me.enlargePreviewBtn.Location = New System.Drawing.Point(764, 384)
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
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Preview"
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
        Me.fontCupBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fontCupBtn.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.icons8_color_16
        Me.fontCupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fontCupBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fontCupBtn.Location = New System.Drawing.Point(31, 3)
        Me.fontCupBtn.Margin = New System.Windows.Forms.Padding(0)
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
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 320)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(264, 31)
        Me.FlowLayoutPanel3.TabIndex = 58
        '
        'prevHymn
        '
        Me.prevHymn.BackgroundImage = CType(resources.GetObject("prevHymn.BackgroundImage"), System.Drawing.Image)
        Me.prevHymn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.prevHymn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.prevHymn.Location = New System.Drawing.Point(3, 74)
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
        Me.nextHymn.Location = New System.Drawing.Point(3, 105)
        Me.nextHymn.Name = "nextHymn"
        Me.nextHymn.Size = New System.Drawing.Size(25, 25)
        Me.nextHymn.TabIndex = 46
        Me.nextHymn.TabStop = False
        Me.nextHymn.UseVisualStyleBackColor = True
        '
        'cupTxt
        '
        Me.cupTxt.AcceptsReturn = True
        Me.cupTxt.AcceptsTab = True
        Me.cupTxt.BackColor = System.Drawing.Color.White
        Me.cupTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cupTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cupTxt.ForeColor = System.Drawing.Color.Black
        Me.cupTxt.Location = New System.Drawing.Point(0, 17)
        Me.cupTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cupTxt.Multiline = True
        Me.cupTxt.Name = "cupTxt"
        Me.cupTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.cupTxt.Size = New System.Drawing.Size(264, 303)
        Me.cupTxt.TabIndex = 1
        Me.cupTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fontBreadBtn
        '
        Me.fontBreadBtn.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.icons8_color_16
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
        Me.HymnFontBtn.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.icons8_font_25
        Me.HymnFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnFontBtn.Location = New System.Drawing.Point(3, 167)
        Me.HymnFontBtn.Name = "HymnFontBtn"
        Me.HymnFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.HymnFontBtn.TabIndex = 52
        Me.HymnFontBtn.TabStop = False
        Me.HymnFontBtn.UseVisualStyleBackColor = True
        '
        'HymnColorBtn
        '
        Me.HymnColorBtn.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.icons8_color_16
        Me.HymnColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnColorBtn.Location = New System.Drawing.Point(3, 198)
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
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 320)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(264, 31)
        Me.FlowLayoutPanel2.TabIndex = 56
        '
        'delHymnBtn
        '
        Me.delHymnBtn.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.icons8_delete_trash_20
        Me.delHymnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delHymnBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delHymnBtn.Location = New System.Drawing.Point(3, 136)
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
        Me.clearHymnsBtn.Location = New System.Drawing.Point(0, 201)
        Me.clearHymnsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.clearHymnsBtn.Name = "clearHymnsBtn"
        Me.clearHymnsBtn.Size = New System.Drawing.Size(187, 25)
        Me.clearHymnsBtn.TabIndex = 53
        Me.clearHymnsBtn.TabStop = False
        Me.clearHymnsBtn.Text = "Clear All"
        Me.clearHymnsBtn.UseVisualStyleBackColor = False
        '
        'previewBox
        '
        Me.previewBox.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.background
        Me.previewBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.previewBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.previewBox.Location = New System.Drawing.Point(5, 248)
        Me.previewBox.Name = "previewBox"
        Me.previewBox.Size = New System.Drawing.Size(218, 131)
        Me.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.previewBox.TabIndex = 59
        Me.previewBox.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.HymnColorBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.HymnFontBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.delHymnBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.nextHymn)
        Me.FlowLayoutPanel1.Controls.Add(Me.prevHymn)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(187, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(31, 226)
        Me.FlowLayoutPanel1.TabIndex = 54
        '
        'HymnsSelectionBox
        '
        Me.HymnsSelectionBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnsSelectionBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HymnsSelectionBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HymnsSelectionBox.FormattingEnabled = True
        Me.HymnsSelectionBox.ItemHeight = 20
        Me.HymnsSelectionBox.Location = New System.Drawing.Point(0, 46)
        Me.HymnsSelectionBox.Name = "HymnsSelectionBox"
        Me.HymnsSelectionBox.ScrollAlwaysVisible = True
        Me.HymnsSelectionBox.Size = New System.Drawing.Size(187, 155)
        Me.HymnsSelectionBox.TabIndex = 44
        Me.HymnsSelectionBox.TabStop = False
        '
        'HymnNos
        '
        Me.HymnNos.AcceptsReturn = True
        Me.HymnNos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HymnNos.Dock = System.Windows.Forms.DockStyle.Top
        Me.HymnNos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HymnNos.Location = New System.Drawing.Point(0, 17)
        Me.HymnNos.Multiline = True
        Me.HymnNos.Name = "HymnNos"
        Me.HymnNos.Size = New System.Drawing.Size(187, 29)
        Me.HymnNos.TabIndex = 42
        Me.HymnNos.TabStop = False
        '
        'updateHC
        '
        Me.updateHC.AutoSize = True
        Me.updateHC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.updateHC.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.background
        Me.updateHC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateHC.Dock = System.Windows.Forms.DockStyle.Right
        Me.updateHC.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateHC.ForeColor = System.Drawing.Color.White
        Me.updateHC.Location = New System.Drawing.Point(694, 0)
        Me.updateHC.Margin = New System.Windows.Forms.Padding(0)
        Me.updateHC.Name = "updateHC"
        Me.updateHC.Padding = New System.Windows.Forms.Padding(20, 5, 20, 5)
        Me.updateHC.Size = New System.Drawing.Size(86, 40)
        Me.updateHC.TabIndex = 55
        Me.updateHC.Text = "Save"
        Me.updateHC.UseVisualStyleBackColor = True
        '
        'breadTxt
        '
        Me.breadTxt.AcceptsReturn = True
        Me.breadTxt.AcceptsTab = True
        Me.breadTxt.BackColor = System.Drawing.Color.White
        Me.breadTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.breadTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breadTxt.ForeColor = System.Drawing.Color.Black
        Me.breadTxt.Location = New System.Drawing.Point(0, 17)
        Me.breadTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.breadTxt.MinimumSize = New System.Drawing.Size(100, 4)
        Me.breadTxt.Multiline = True
        Me.breadTxt.Name = "breadTxt"
        Me.breadTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.breadTxt.Size = New System.Drawing.Size(264, 303)
        Me.breadTxt.TabIndex = 0
        Me.breadTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.enlargePreviewBtn)
        Me.Panel1.Controls.Add(Me.previewBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(549, 3)
        Me.Panel1.MinimumSize = New System.Drawing.Size(0, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(228, 384)
        Me.Panel1.TabIndex = 62
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel4.Controls.Add(Me.HymnsSelectionBox)
        Me.Panel4.Controls.Add(Me.HymnNos)
        Me.Panel4.Controls.Add(Me.clearHymnsBtn)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(5, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(218, 226)
        Me.Panel4.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Hymns:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 393.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(780, 390)
        Me.TableLayoutPanel1.TabIndex = 62
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 30)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 30, 3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 360.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(540, 357)
        Me.TableLayoutPanel2.TabIndex = 59
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.Controls.Add(Me.breadTxt)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(264, 351)
        Me.Panel3.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Bread"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cupTxt)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(273, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(264, 351)
        Me.Panel2.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Cup"
        '
        'Panel5
        '
        Me.Panel5.AutoSize = True
        Me.Panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel5.Controls.Add(Me.cancelBtn)
        Me.Panel5.Controls.Add(Me.updateHC)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(10, 400)
        Me.Panel5.MinimumSize = New System.Drawing.Size(0, 40)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(780, 40)
        Me.Panel5.TabIndex = 64
        '
        'cancelBtn
        '
        Me.cancelBtn.AutoSize = True
        Me.cancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.cancelBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cancelBtn.Location = New System.Drawing.Point(617, 0)
        Me.cancelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cancelBtn.Size = New System.Drawing.Size(77, 40)
        Me.cancelBtn.TabIndex = 56
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'HolyCommunion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "HolyCommunion"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Holy Communion"
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.previewBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents header As Label
    Friend WithEvents enlargePreviewBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents colorCupBtn As Button
    Friend WithEvents fontCupBtn As Button
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents prevHymn As Button
    Friend WithEvents nextHymn As Button
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
    Friend WithEvents HymnsSelectionBox As ListBox
    Friend WithEvents HymnNos As TextBox
    Friend WithEvents updateHC As Button
    Friend WithEvents breadTxt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cancelBtn As Button
End Class

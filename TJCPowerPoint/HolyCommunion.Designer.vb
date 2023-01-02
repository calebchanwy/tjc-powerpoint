<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HolyCommunion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HolyCommunion))
        Me.breadTxt = New System.Windows.Forms.TextBox()
        Me.cupTxt = New System.Windows.Forms.TextBox()
        Me.header = New System.Windows.Forms.Label()
        Me.updateHC = New System.Windows.Forms.Button()
        Me.HCClose = New System.Windows.Forms.Button()
        Me.goToHCSlide = New System.Windows.Forms.Button()
        Me.navBar = New System.Windows.Forms.FlowLayoutPanel()
        Me.closeForm = New System.Windows.Forms.Button()
        Me.minForm = New System.Windows.Forms.Button()
        Me.HymnsSelectionBox = New System.Windows.Forms.ListBox()
        Me.HymnNos = New System.Windows.Forms.TextBox()
        Me.prevHymn = New System.Windows.Forms.Button()
        Me.nextHymn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HymnColorBtn = New System.Windows.Forms.Button()
        Me.HymnFontBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.delHymnBtn = New System.Windows.Forms.Button()
        Me.navBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'breadTxt
        '
        Me.breadTxt.AcceptsReturn = True
        Me.breadTxt.AcceptsTab = True
        Me.breadTxt.BackColor = System.Drawing.SystemColors.Control
        Me.breadTxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breadTxt.ForeColor = System.Drawing.Color.Black
        Me.breadTxt.Location = New System.Drawing.Point(6, 20)
        Me.breadTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.breadTxt.Multiline = True
        Me.breadTxt.Name = "breadTxt"
        Me.breadTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.breadTxt.Size = New System.Drawing.Size(274, 297)
        Me.breadTxt.TabIndex = 0
        Me.breadTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cupTxt
        '
        Me.cupTxt.AcceptsReturn = True
        Me.cupTxt.AcceptsTab = True
        Me.cupTxt.BackColor = System.Drawing.SystemColors.Control
        Me.cupTxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cupTxt.ForeColor = System.Drawing.Color.Black
        Me.cupTxt.Location = New System.Drawing.Point(6, 19)
        Me.cupTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cupTxt.Multiline = True
        Me.cupTxt.Name = "cupTxt"
        Me.cupTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.cupTxt.Size = New System.Drawing.Size(274, 297)
        Me.cupTxt.TabIndex = 1
        Me.cupTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.Transparent
        Me.header.Cursor = System.Windows.Forms.Cursors.Default
        Me.header.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.ForeColor = System.Drawing.Color.SteelBlue
        Me.header.Location = New System.Drawing.Point(10, 16)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(187, 30)
        Me.header.TabIndex = 2
        Me.header.Text = "Holy Communion"
        Me.header.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'updateHC
        '
        Me.updateHC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateHC.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateHC.ForeColor = System.Drawing.Color.Navy
        Me.updateHC.Location = New System.Drawing.Point(12, 391)
        Me.updateHC.Name = "updateHC"
        Me.updateHC.Size = New System.Drawing.Size(232, 36)
        Me.updateHC.TabIndex = 3
        Me.updateHC.Text = "Update Holy Communion Slide"
        Me.updateHC.UseVisualStyleBackColor = True
        '
        'HCClose
        '
        Me.HCClose.BackColor = System.Drawing.Color.White
        Me.HCClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HCClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HCClose.ForeColor = System.Drawing.Color.Maroon
        Me.HCClose.Location = New System.Drawing.Point(669, 395)
        Me.HCClose.Name = "HCClose"
        Me.HCClose.Size = New System.Drawing.Size(63, 32)
        Me.HCClose.TabIndex = 4
        Me.HCClose.Text = "Close"
        Me.HCClose.UseVisualStyleBackColor = False
        '
        'goToHCSlide
        '
        Me.goToHCSlide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.goToHCSlide.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goToHCSlide.Location = New System.Drawing.Point(250, 392)
        Me.goToHCSlide.Name = "goToHCSlide"
        Me.goToHCSlide.Size = New System.Drawing.Size(196, 36)
        Me.goToHCSlide.TabIndex = 7
        Me.goToHCSlide.Text = "Go To Holy Communion Slide"
        Me.goToHCSlide.UseVisualStyleBackColor = True
        '
        'navBar
        '
        Me.navBar.BackColor = System.Drawing.Color.Transparent
        Me.navBar.Controls.Add(Me.closeForm)
        Me.navBar.Controls.Add(Me.minForm)
        Me.navBar.Cursor = System.Windows.Forms.Cursors.Default
        Me.navBar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.navBar.Location = New System.Drawing.Point(0, -2)
        Me.navBar.Name = "navBar"
        Me.navBar.Padding = New System.Windows.Forms.Padding(5)
        Me.navBar.Size = New System.Drawing.Size(749, 51)
        Me.navBar.TabIndex = 8
        '
        'closeForm
        '
        Me.closeForm.BackColor = System.Drawing.Color.Transparent
        Me.closeForm.BackgroundImage = CType(resources.GetObject("closeForm.BackgroundImage"), System.Drawing.Image)
        Me.closeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.closeForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeForm.FlatAppearance.BorderSize = 0
        Me.closeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeForm.ForeColor = System.Drawing.Color.Transparent
        Me.closeForm.Location = New System.Drawing.Point(717, 12)
        Me.closeForm.Margin = New System.Windows.Forms.Padding(7)
        Me.closeForm.Name = "closeForm"
        Me.closeForm.Size = New System.Drawing.Size(15, 15)
        Me.closeForm.TabIndex = 9
        Me.closeForm.TabStop = False
        Me.closeForm.UseVisualStyleBackColor = False
        '
        'minForm
        '
        Me.minForm.BackColor = System.Drawing.Color.Transparent
        Me.minForm.BackgroundImage = CType(resources.GetObject("minForm.BackgroundImage"), System.Drawing.Image)
        Me.minForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minForm.FlatAppearance.BorderSize = 0
        Me.minForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minForm.ForeColor = System.Drawing.Color.Transparent
        Me.minForm.Location = New System.Drawing.Point(689, 13)
        Me.minForm.Margin = New System.Windows.Forms.Padding(8)
        Me.minForm.Name = "minForm"
        Me.minForm.Padding = New System.Windows.Forms.Padding(3)
        Me.minForm.Size = New System.Drawing.Size(13, 13)
        Me.minForm.TabIndex = 10
        Me.minForm.TabStop = False
        Me.minForm.UseVisualStyleBackColor = False
        '
        'HymnsSelectionBox
        '
        Me.HymnsSelectionBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnsSelectionBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HymnsSelectionBox.FormattingEnabled = True
        Me.HymnsSelectionBox.ItemHeight = 21
        Me.HymnsSelectionBox.Location = New System.Drawing.Point(11, 55)
        Me.HymnsSelectionBox.Name = "HymnsSelectionBox"
        Me.HymnsSelectionBox.ScrollAlwaysVisible = True
        Me.HymnsSelectionBox.Size = New System.Drawing.Size(89, 256)
        Me.HymnsSelectionBox.TabIndex = 44
        Me.HymnsSelectionBox.TabStop = False
        '
        'HymnNos
        '
        Me.HymnNos.AcceptsReturn = True
        Me.HymnNos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HymnNos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HymnNos.Location = New System.Drawing.Point(11, 20)
        Me.HymnNos.Multiline = True
        Me.HymnNos.Name = "HymnNos"
        Me.HymnNos.Size = New System.Drawing.Size(118, 29)
        Me.HymnNos.TabIndex = 42
        Me.HymnNos.TabStop = False
        '
        'prevHymn
        '
        Me.prevHymn.BackgroundImage = CType(resources.GetObject("prevHymn.BackgroundImage"), System.Drawing.Image)
        Me.prevHymn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.prevHymn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.prevHymn.Location = New System.Drawing.Point(104, 117)
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
        Me.nextHymn.Location = New System.Drawing.Point(104, 148)
        Me.nextHymn.Name = "nextHymn"
        Me.nextHymn.Size = New System.Drawing.Size(25, 25)
        Me.nextHymn.TabIndex = 46
        Me.nextHymn.TabStop = False
        Me.nextHymn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.delHymnBtn)
        Me.GroupBox1.Controls.Add(Me.HymnColorBtn)
        Me.GroupBox1.Controls.Add(Me.HymnFontBtn)
        Me.GroupBox1.Controls.Add(Me.prevHymn)
        Me.GroupBox1.Controls.Add(Me.HymnNos)
        Me.GroupBox1.Controls.Add(Me.nextHymn)
        Me.GroupBox1.Controls.Add(Me.HymnsSelectionBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 323)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hymn(s)"
        '
        'HymnColorBtn
        '
        Me.HymnColorBtn.BackgroundImage = CType(resources.GetObject("HymnColorBtn.BackgroundImage"), System.Drawing.Image)
        Me.HymnColorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnColorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnColorBtn.Location = New System.Drawing.Point(104, 55)
        Me.HymnColorBtn.Name = "HymnColorBtn"
        Me.HymnColorBtn.Size = New System.Drawing.Size(25, 25)
        Me.HymnColorBtn.TabIndex = 51
        Me.HymnColorBtn.TabStop = False
        Me.HymnColorBtn.UseVisualStyleBackColor = True
        '
        'HymnFontBtn
        '
        Me.HymnFontBtn.BackgroundImage = CType(resources.GetObject("HymnFontBtn.BackgroundImage"), System.Drawing.Image)
        Me.HymnFontBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HymnFontBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HymnFontBtn.Location = New System.Drawing.Point(104, 86)
        Me.HymnFontBtn.Name = "HymnFontBtn"
        Me.HymnFontBtn.Size = New System.Drawing.Size(25, 25)
        Me.HymnFontBtn.TabIndex = 52
        Me.HymnFontBtn.TabStop = False
        Me.HymnFontBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.breadTxt)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(153, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 323)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bread"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cupTxt)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(446, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(286, 323)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cup"
        '
        'delHymnBtn
        '
        Me.delHymnBtn.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.icons8_delete_trash_20
        Me.delHymnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delHymnBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delHymnBtn.Location = New System.Drawing.Point(104, 179)
        Me.delHymnBtn.Name = "delHymnBtn"
        Me.delHymnBtn.Size = New System.Drawing.Size(25, 25)
        Me.delHymnBtn.TabIndex = 45
        Me.delHymnBtn.TabStop = False
        Me.delHymnBtn.UseVisualStyleBackColor = True
        '
        'HolyCommunion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.border2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(750, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.goToHCSlide)
        Me.Controls.Add(Me.HCClose)
        Me.Controls.Add(Me.updateHC)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.navBar)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(750, 450)
        Me.MinimumSize = New System.Drawing.Size(750, 450)
        Me.Name = "HolyCommunion"
        Me.Text = "Holy Communion"
        Me.navBar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents breadTxt As TextBox
    Friend WithEvents cupTxt As TextBox
    Friend WithEvents header As Label
    Friend WithEvents updateHC As Button
    Friend WithEvents HCClose As Button
    Friend WithEvents goToHCSlide As Button
    Friend WithEvents navBar As FlowLayoutPanel
    Friend WithEvents closeForm As Button
    Friend WithEvents minForm As Button
    Friend WithEvents HymnsSelectionBox As ListBox
    Friend WithEvents HymnNos As TextBox
    Friend WithEvents prevHymn As Button
    Friend WithEvents nextHymn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents HymnColorBtn As Button
    Friend WithEvents HymnFontBtn As Button
    Friend WithEvents delHymnBtn As Button
End Class

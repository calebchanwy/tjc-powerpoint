﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.goToHCSlide = New System.Windows.Forms.Button()
        Me.navBar = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'breadTxt
        '
        Me.breadTxt.AcceptsReturn = True
        Me.breadTxt.AcceptsTab = True
        Me.breadTxt.BackColor = System.Drawing.Color.Black
        Me.breadTxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breadTxt.ForeColor = System.Drawing.Color.White
        Me.breadTxt.Location = New System.Drawing.Point(11, 97)
        Me.breadTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.breadTxt.Multiline = True
        Me.breadTxt.Name = "breadTxt"
        Me.breadTxt.Size = New System.Drawing.Size(326, 344)
        Me.breadTxt.TabIndex = 0
        Me.breadTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cupTxt
        '
        Me.cupTxt.AcceptsReturn = True
        Me.cupTxt.AcceptsTab = True
        Me.cupTxt.BackColor = System.Drawing.Color.Black
        Me.cupTxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cupTxt.ForeColor = System.Drawing.Color.White
        Me.cupTxt.Location = New System.Drawing.Point(343, 97)
        Me.cupTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cupTxt.Multiline = True
        Me.cupTxt.Name = "cupTxt"
        Me.cupTxt.Size = New System.Drawing.Size(326, 344)
        Me.cupTxt.TabIndex = 1
        Me.cupTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.Transparent
        Me.header.Cursor = System.Windows.Forms.Cursors.Default
        Me.header.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header.Location = New System.Drawing.Point(10, 23)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(285, 30)
        Me.header.TabIndex = 2
        Me.header.Text = "Edit Holy Communion Slide"
        Me.header.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'updateHC
        '
        Me.updateHC.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateHC.ForeColor = System.Drawing.Color.Navy
        Me.updateHC.Location = New System.Drawing.Point(675, 97)
        Me.updateHC.Name = "updateHC"
        Me.updateHC.Size = New System.Drawing.Size(63, 52)
        Me.updateHC.TabIndex = 3
        Me.updateHC.Text = "Update Slide"
        Me.updateHC.UseVisualStyleBackColor = True
        '
        'HCClose
        '
        Me.HCClose.BackColor = System.Drawing.Color.White
        Me.HCClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HCClose.ForeColor = System.Drawing.Color.Maroon
        Me.HCClose.Location = New System.Drawing.Point(675, 407)
        Me.HCClose.Name = "HCClose"
        Me.HCClose.Size = New System.Drawing.Size(63, 34)
        Me.HCClose.TabIndex = 4
        Me.HCClose.Text = "Close"
        Me.HCClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Bread:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(486, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cup:"
        '
        'Button1
        '
        Me.goToHCSlide.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.goToHCSlide.Location = New System.Drawing.Point(675, 155)
        Me.goToHCSlide.Name = "Button1"
        Me.goToHCSlide.Size = New System.Drawing.Size(63, 44)
        Me.goToHCSlide.TabIndex = 7
        Me.goToHCSlide.Text = "Go To Slide"
        Me.goToHCSlide.UseVisualStyleBackColor = True
        '
        'navBar
        '
        Me.navBar.BackColor = System.Drawing.Color.Transparent
        Me.navBar.Cursor = System.Windows.Forms.Cursors.Default
        Me.navBar.Location = New System.Drawing.Point(0, -2)
        Me.navBar.Name = "navBar"
        Me.navBar.Size = New System.Drawing.Size(749, 69)
        Me.navBar.TabIndex = 8
        '
        'HolyCommunion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TJCPowerPoint.My.Resources.Resources.border2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(750, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.goToHCSlide)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HCClose)
        Me.Controls.Add(Me.updateHC)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.cupTxt)
        Me.Controls.Add(Me.breadTxt)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents breadTxt As TextBox
    Friend WithEvents cupTxt As TextBox
    Friend WithEvents header As Label
    Friend WithEvents updateHC As Button
    Friend WithEvents HCClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents goToHCSlide As Button
    Friend WithEvents navBar As FlowLayoutPanel
End Class

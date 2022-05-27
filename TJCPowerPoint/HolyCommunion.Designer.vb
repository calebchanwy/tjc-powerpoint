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
        Me.HCLabel = New System.Windows.Forms.Label()
        Me.updateHC = New System.Windows.Forms.Button()
        Me.HCClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'breadTxt
        '
        Me.breadTxt.AcceptsReturn = True
        Me.breadTxt.AcceptsTab = True
        Me.breadTxt.BackColor = System.Drawing.Color.Black
        Me.breadTxt.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breadTxt.ForeColor = System.Drawing.Color.White
        Me.breadTxt.Location = New System.Drawing.Point(21, 95)
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
        Me.cupTxt.Location = New System.Drawing.Point(353, 95)
        Me.cupTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cupTxt.Multiline = True
        Me.cupTxt.Name = "cupTxt"
        Me.cupTxt.Size = New System.Drawing.Size(326, 344)
        Me.cupTxt.TabIndex = 1
        Me.cupTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HCLabel
        '
        Me.HCLabel.AutoSize = True
        Me.HCLabel.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HCLabel.Location = New System.Drawing.Point(12, 18)
        Me.HCLabel.Name = "HCLabel"
        Me.HCLabel.Size = New System.Drawing.Size(290, 25)
        Me.HCLabel.TabIndex = 2
        Me.HCLabel.Text = "Edit Holy Communion Slide:"
        Me.HCLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'updateHC
        '
        Me.updateHC.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateHC.Location = New System.Drawing.Point(685, 95)
        Me.updateHC.Name = "updateHC"
        Me.updateHC.Size = New System.Drawing.Size(112, 116)
        Me.updateHC.TabIndex = 3
        Me.updateHC.Text = "Update Holy Communion"
        Me.updateHC.UseVisualStyleBackColor = True
        '
        'HCClose
        '
        Me.HCClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HCClose.Location = New System.Drawing.Point(685, 405)
        Me.HCClose.Name = "HCClose"
        Me.HCClose.Size = New System.Drawing.Size(112, 34)
        Me.HCClose.TabIndex = 4
        Me.HCClose.Text = "Close"
        Me.HCClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Bread:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(496, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cup:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(685, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 74)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Go To Holy Communion Slide"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HolyCommunion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HCClose)
        Me.Controls.Add(Me.updateHC)
        Me.Controls.Add(Me.HCLabel)
        Me.Controls.Add(Me.cupTxt)
        Me.Controls.Add(Me.breadTxt)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(825, 500)
        Me.MinimumSize = New System.Drawing.Size(825, 500)
        Me.Name = "HolyCommunion"
        Me.Text = "Holy Communion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents breadTxt As TextBox
    Friend WithEvents cupTxt As TextBox
    Friend WithEvents HCLabel As Label
    Friend WithEvents updateHC As Button
    Friend WithEvents HCClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class

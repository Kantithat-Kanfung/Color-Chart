<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.pnColor = New System.Windows.Forms.Panel()
        Me.flpColor = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbRGB = New System.Windows.Forms.Label()
        Me.lbHex = New System.Windows.Forms.Label()
        Me.lbHexColor = New System.Windows.Forms.Label()
        Me.lbRGBColor = New System.Windows.Forms.Label()
        Me.lbNameColor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.copyNameColor = New System.Windows.Forms.Button()
        Me.copyRGBColor = New System.Windows.Forms.Button()
        Me.copyHexColor = New System.Windows.Forms.Button()
        Me.lbCopyName = New System.Windows.Forms.Label()
        Me.lbCopyRGB = New System.Windows.Forms.Label()
        Me.lbCopyHex = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pnColor
        '
        Me.pnColor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnColor.Location = New System.Drawing.Point(607, 12)
        Me.pnColor.Name = "pnColor"
        Me.pnColor.Size = New System.Drawing.Size(365, 189)
        Me.pnColor.TabIndex = 0
        '
        'flpColor
        '
        Me.flpColor.BackColor = System.Drawing.Color.White
        Me.flpColor.Location = New System.Drawing.Point(12, 12)
        Me.flpColor.Name = "flpColor"
        Me.flpColor.Size = New System.Drawing.Size(574, 470)
        Me.flpColor.TabIndex = 1
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbName.Location = New System.Drawing.Point(607, 204)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(365, 39)
        Me.lbName.TabIndex = 0
        Me.lbName.Text = "Name "
        Me.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbRGB
        '
        Me.lbRGB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRGB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbRGB.Location = New System.Drawing.Point(604, 281)
        Me.lbRGB.Name = "lbRGB"
        Me.lbRGB.Size = New System.Drawing.Size(365, 39)
        Me.lbRGB.TabIndex = 0
        Me.lbRGB.Text = "RGB"
        Me.lbRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbHex
        '
        Me.lbHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbHex.Location = New System.Drawing.Point(607, 359)
        Me.lbHex.Name = "lbHex"
        Me.lbHex.Size = New System.Drawing.Size(362, 39)
        Me.lbHex.TabIndex = 2
        Me.lbHex.Text = "Hex "
        Me.lbHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbHexColor
        '
        Me.lbHexColor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbHexColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHexColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbHexColor.Location = New System.Drawing.Point(604, 398)
        Me.lbHexColor.Name = "lbHexColor"
        Me.lbHexColor.Size = New System.Drawing.Size(368, 39)
        Me.lbHexColor.TabIndex = 3
        Me.lbHexColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbRGBColor
        '
        Me.lbRGBColor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbRGBColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRGBColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbRGBColor.Location = New System.Drawing.Point(604, 320)
        Me.lbRGBColor.Name = "lbRGBColor"
        Me.lbRGBColor.Size = New System.Drawing.Size(368, 39)
        Me.lbRGBColor.TabIndex = 1
        Me.lbRGBColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbNameColor
        '
        Me.lbNameColor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbNameColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNameColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbNameColor.Location = New System.Drawing.Point(604, 242)
        Me.lbNameColor.Name = "lbNameColor"
        Me.lbNameColor.Size = New System.Drawing.Size(368, 39)
        Me.lbNameColor.TabIndex = 1
        Me.lbNameColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(602, 437)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 44)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Press ( Fn + Esc ) for Close Application"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'copyNameColor
        '
        Me.copyNameColor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.copyNameColor.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.copyNameColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copyNameColor.Image = CType(resources.GetObject("copyNameColor.Image"), System.Drawing.Image)
        Me.copyNameColor.Location = New System.Drawing.Point(937, 246)
        Me.copyNameColor.Name = "copyNameColor"
        Me.copyNameColor.Size = New System.Drawing.Size(32, 32)
        Me.copyNameColor.TabIndex = 5
        Me.copyNameColor.UseVisualStyleBackColor = False
        '
        'copyRGBColor
        '
        Me.copyRGBColor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.copyRGBColor.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.copyRGBColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copyRGBColor.Image = CType(resources.GetObject("copyRGBColor.Image"), System.Drawing.Image)
        Me.copyRGBColor.Location = New System.Drawing.Point(937, 323)
        Me.copyRGBColor.Name = "copyRGBColor"
        Me.copyRGBColor.Size = New System.Drawing.Size(32, 32)
        Me.copyRGBColor.TabIndex = 6
        Me.copyRGBColor.UseVisualStyleBackColor = False
        '
        'copyHexColor
        '
        Me.copyHexColor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.copyHexColor.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.copyHexColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.copyHexColor.Image = CType(resources.GetObject("copyHexColor.Image"), System.Drawing.Image)
        Me.copyHexColor.Location = New System.Drawing.Point(937, 401)
        Me.copyHexColor.Name = "copyHexColor"
        Me.copyHexColor.Size = New System.Drawing.Size(32, 32)
        Me.copyHexColor.TabIndex = 7
        Me.copyHexColor.UseVisualStyleBackColor = False
        '
        'lbCopyName
        '
        Me.lbCopyName.AutoSize = True
        Me.lbCopyName.Location = New System.Drawing.Point(930, 258)
        Me.lbCopyName.Name = "lbCopyName"
        Me.lbCopyName.Size = New System.Drawing.Size(0, 13)
        Me.lbCopyName.TabIndex = 8
        '
        'lbCopyRGB
        '
        Me.lbCopyRGB.AutoSize = True
        Me.lbCopyRGB.Location = New System.Drawing.Point(930, 336)
        Me.lbCopyRGB.Name = "lbCopyRGB"
        Me.lbCopyRGB.Size = New System.Drawing.Size(0, 13)
        Me.lbCopyRGB.TabIndex = 9
        '
        'lbCopyHex
        '
        Me.lbCopyHex.AutoSize = True
        Me.lbCopyHex.Location = New System.Drawing.Point(930, 414)
        Me.lbCopyHex.Name = "lbCopyHex"
        Me.lbCopyHex.Size = New System.Drawing.Size(0, 13)
        Me.lbCopyHex.TabIndex = 10
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(985, 490)
        Me.Controls.Add(Me.copyHexColor)
        Me.Controls.Add(Me.lbCopyHex)
        Me.Controls.Add(Me.copyRGBColor)
        Me.Controls.Add(Me.lbCopyRGB)
        Me.Controls.Add(Me.copyNameColor)
        Me.Controls.Add(Me.lbCopyName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbHexColor)
        Me.Controls.Add(Me.flpColor)
        Me.Controls.Add(Me.lbHex)
        Me.Controls.Add(Me.lbRGBColor)
        Me.Controls.Add(Me.pnColor)
        Me.Controls.Add(Me.lbRGB)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.lbNameColor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Chart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnColor As Panel
    Friend WithEvents lbHexColor As Label
    Friend WithEvents lbHex As Label
    Friend WithEvents lbRGBColor As Label
    Friend WithEvents lbRGB As Label
    Friend WithEvents lbNameColor As Label
    Friend WithEvents lbName As Label
    Friend WithEvents flpColor As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents copyNameColor As Button
    Friend WithEvents copyRGBColor As Button
    Friend WithEvents copyHexColor As Button
    Friend WithEvents lbCopyName As Label
    Friend WithEvents lbCopyRGB As Label
    Friend WithEvents lbCopyHex As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.chkMoon = New System.Windows.Forms.CheckBox()
        Me.chkSun = New System.Windows.Forms.CheckBox()
        Me.chkEarth = New System.Windows.Forms.CheckBox()
        Me.picSun = New System.Windows.Forms.PictureBox()
        Me.PicMoon = New System.Windows.Forms.PictureBox()
        Me.PicEarth = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picSun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMoon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicEarth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(23, 239)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(70, 22)
        Me.btnQuitter.TabIndex = 2
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'chkMoon
        '
        Me.chkMoon.AutoSize = True
        Me.chkMoon.Location = New System.Drawing.Point(40, 38)
        Me.chkMoon.Name = "chkMoon"
        Me.chkMoon.Size = New System.Drawing.Size(53, 17)
        Me.chkMoon.TabIndex = 3
        Me.chkMoon.Text = "Moon"
        Me.chkMoon.UseVisualStyleBackColor = True
        '
        'chkSun
        '
        Me.chkSun.AutoSize = True
        Me.chkSun.Location = New System.Drawing.Point(40, 110)
        Me.chkSun.Name = "chkSun"
        Me.chkSun.Size = New System.Drawing.Size(45, 17)
        Me.chkSun.TabIndex = 4
        Me.chkSun.Text = "Sun"
        Me.chkSun.UseVisualStyleBackColor = True
        '
        'chkEarth
        '
        Me.chkEarth.AutoSize = True
        Me.chkEarth.Location = New System.Drawing.Point(40, 183)
        Me.chkEarth.Name = "chkEarth"
        Me.chkEarth.Size = New System.Drawing.Size(51, 17)
        Me.chkEarth.TabIndex = 5
        Me.chkEarth.Text = "Earth"
        Me.chkEarth.UseVisualStyleBackColor = True
        '
        'picSun
        '
        Me.picSun.ErrorImage = Global.WindowsApplication1.My.Resources.Resources.Sun
        Me.picSun.Image = Global.WindowsApplication1.My.Resources.Resources.Sun
        Me.picSun.InitialImage = Global.WindowsApplication1.My.Resources.Resources.Sun
        Me.picSun.Location = New System.Drawing.Point(141, 87)
        Me.picSun.Name = "picSun"
        Me.picSun.Size = New System.Drawing.Size(60, 60)
        Me.picSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSun.TabIndex = 6
        Me.picSun.TabStop = False
        '
        'PicMoon
        '
        Me.PicMoon.Image = Global.WindowsApplication1.My.Resources.Resources.Moon1
        Me.PicMoon.Location = New System.Drawing.Point(141, 12)
        Me.PicMoon.Name = "PicMoon"
        Me.PicMoon.Size = New System.Drawing.Size(60, 60)
        Me.PicMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMoon.TabIndex = 7
        Me.PicMoon.TabStop = False
        '
        'PicEarth
        '
        Me.PicEarth.ErrorImage = Global.WindowsApplication1.My.Resources.Resources.Sun
        Me.PicEarth.Image = Global.WindowsApplication1.My.Resources.Resources.Earth1
        Me.PicEarth.InitialImage = Global.WindowsApplication1.My.Resources.Resources.Sun
        Me.PicEarth.Location = New System.Drawing.Point(141, 169)
        Me.PicEarth.Name = "PicEarth"
        Me.PicEarth.Size = New System.Drawing.Size(60, 60)
        Me.PicEarth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicEarth.TabIndex = 8
        Me.PicEarth.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 22)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Quitter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PicEarth)
        Me.Controls.Add(Me.PicMoon)
        Me.Controls.Add(Me.picSun)
        Me.Controls.Add(Me.chkEarth)
        Me.Controls.Add(Me.chkSun)
        Me.Controls.Add(Me.chkMoon)
        Me.Controls.Add(Me.btnQuitter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picSun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMoon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicEarth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQuitter As System.Windows.Forms.Button
    Friend WithEvents chkMoon As System.Windows.Forms.CheckBox
    Friend WithEvents chkSun As System.Windows.Forms.CheckBox
    Friend WithEvents chkEarth As System.Windows.Forms.CheckBox
    Friend WithEvents picSun As System.Windows.Forms.PictureBox
    Friend WithEvents PicMoon As System.Windows.Forms.PictureBox
    Friend WithEvents PicEarth As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class

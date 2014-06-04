<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class live
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(live))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AfficherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FermerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CacherStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1002, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 96)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1016, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(117, 207)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(7, 157)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1002, 550)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(7, 706)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1002, 202)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(713, 205)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.ScrollBarsEnabled = False
        Me.WebBrowser2.Size = New System.Drawing.Size(291, 495)
        Me.WebBrowser2.TabIndex = 6
        Me.WebBrowser2.Url = New System.Uri("http://cdn.livestream.com/embed/ibuild_officiel?layout=6&showTimestamp=true&heigh" & _
        "t=445&width=342", System.UriKind.Absolute)
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 205)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(700, 495)
        Me.WebBrowser1.TabIndex = 5
        Me.WebBrowser1.Url = New System.Uri("http://cdn.livestream.com/embed/ibuild_officiel?layout=4&color=0xe7e7e7&autoPlay=" & _
        "true&mute=false&iconColorOver=0x888888&iconColor=0x777777&allowchat=true&height=" & _
        "445&width=650", System.UriKind.Absolute)
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "Bienvenue sur le logiciel de Ibuild LIVE."
        Me.NotifyIcon1.BalloonTipTitle = "Ibuild LIVE"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Ibuild LIVE"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CacherStripMenuItem1, Me.AfficherToolStripMenuItem, Me.ToolStripSeparator1, Me.FermerToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 98)
        '
        'AfficherToolStripMenuItem
        '
        Me.AfficherToolStripMenuItem.Name = "AfficherToolStripMenuItem"
        Me.AfficherToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AfficherToolStripMenuItem.Text = "Afficher"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'FermerToolStripMenuItem
        '
        Me.FermerToolStripMenuItem.Name = "FermerToolStripMenuItem"
        Me.FermerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FermerToolStripMenuItem.Text = "Fermer"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2500
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(906, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Aucun Live"
        '
        'CloseButton
        '
        Me.CloseButton.AutoSize = True
        Me.CloseButton.BackColor = System.Drawing.Color.White
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.CloseButton.Location = New System.Drawing.Point(987, 9)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(17, 16)
        Me.CloseButton.TabIndex = 8
        Me.CloseButton.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(963, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "-"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(854, 859)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(150, 37)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Location = New System.Drawing.Point(942, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "?"
        '
        'CacherStripMenuItem1
        '
        Me.CacherStripMenuItem1.Name = "CacherStripMenuItem1"
        Me.CacherStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.CacherStripMenuItem1.Text = "Cacher"
        '
        'live2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1016, 908)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "live2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ibuild LIVE"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AfficherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FermerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CloseButton As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CacherStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class

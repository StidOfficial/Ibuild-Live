Public Class live

    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim doc As New System.Xml.XmlDocument
        doc.Load("http://xibuild_officielx.api.channel.livestream.com/2.0/livestatus.xml")
        Dim list = doc.GetElementsByTagName("ls:isLive")
        For Each item As System.Xml.XmlElement In list
            If item.InnerText = "false" Then
                Label1.Text = "Aucun Live"
                Label1.BackColor = Color.Red
            Else
                Label1.Text = "Live en cour..."
                Label1.BackColor = Color.Green
            End If
            If item.InnerText = "false" And Not NotifyIcon1.BalloonTipText = "Le live vient de ce terminer." And Not NotifyIcon1.BalloonTipText = "Bienvenue sur le logiciel de Ibuild LIVE." Then
                Me.WindowState = FormWindowState.Minimized
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.BalloonTipText = "Le live vient de ce terminer."
                NotifyIcon1.ShowBalloonTip(5)
            End If
            If item.InnerText = "true" And Not NotifyIcon1.BalloonTipText = "Le live vient de commencer." Then
                Me.WindowState = FormWindowState.Minimized
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.BalloonTipText = "Le live vient de commencer."
                NotifyIcon1.ShowBalloonTip(5)
            End If
        Next
    End Sub

    Private Sub FermerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AfficherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_MouseDown1(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub PictureBox1_MouseMove1(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.Y -= (Y)
            NewPoint.X -= (X)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub live2_Load(sender As Object, e As EventArgs) Handles Me.Load
        NotifyIcon1.ShowBalloonTip(10)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        MsgBox("Créer par Stid, pour la communeauter d'ibuild.", MsgBoxStyle.Information, "A propos")
    End Sub

    Private Sub CacherStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CacherStripMenuItem1.Click
        Me.Hide()

    End Sub
End Class
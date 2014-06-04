Public Class loading

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity < 1.0 Then
            Me.Opacity = Me.Opacity + 0.1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Stop()
        Timer2.Stop()
        live.Show()
        Me.Hide()
    End Sub
    Private Sub loading_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not My.Computer.Network.IsAvailable Then
            MsgBox("Erreur : Impossible de joindre le serveur.", MsgBoxStyle.Exclamation, "Erreur de connexion")
            Me.Close()
        End If
    End Sub
End Class
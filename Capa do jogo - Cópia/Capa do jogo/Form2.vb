Public Class Form3
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = PBloading1.Value & "%"
        PBloading1.Value += 100

        If PBloading1.Value > 10 Then
            LblText.Text = "A carregar....... Por Favor espere"
        End If
        If PBloading1.Value > 25 Then
            LblText.Text = "A carregar....... Por Favor espere"
        End If
        If PBloading1.Value > 45 Then
            LblText.Text = "Que demora......."
        End If
        If PBloading1.Value > 75 Then
            LblText.Text = "Está quase!"
        End If
        If PBloading1.Value > 85 Then
            LblText.Text = "Mesmo perto!"
        End If
        If PBloading1.Value >= 100 Then
            LblText.Text = "Obrigado por esperar!"
            Form2.Show()
            Me.Hide()
            Timer1.Dispose()
        End If
    End Sub
End Class
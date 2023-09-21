Public Class Form4

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        Dim strpalavra As String
        Dim objRandom As New Random
        Dim mostletra As Integer
        Dim arrpalavra(2) As String
        Dim resperrada As Integer = 0
        Dim rndpalavra As Integer
        Dim checar As Boolean
        Dim tentativa As Char
        Const letras As String = "abcdefghijklmnopqrstuvwxyz"
        lblWord.Text = String.Empty
        picPicture.Visible = False
        lstLetters.Items.Clear()
        rndpalavra = objRandom.Next(0, 2)
        arrpalavra(0) = "portugal"
        arrpalavra(1) = "brasil"
        strpalavra = arrpalavra(rndpalavra)
        Select Case rndpalavra
            Case Is = 0
                Me.lblWord.Text = "________"

            Case Is = 1
                Me.lblWord.Text = "______"

        End Select
        btnStart.Hide()
        Button2.Hide()
        Button3.Hide()
        Do
            tentativa = InputBox("introduza uma letra de A-Z para tentares advinhar a palavra").ToLower
            If InStr(letras, tentativa) = 0 Then
                MessageBox.Show("so podes utilizar letras")
            Else
                If lstLetters.Items.Contains(tentativa) = False Then
                    checar = False
                    lstLetters.Items.Add(tentativa)
                    'Mostrar letra caso pertenca á palavra correta
                    For mostletra = 0 To Integer.Parse(arrpalavra(rndpalavra).Length - 1) Step 1
                        If strpalavra(mostletra) = tentativa Then
                            Me.lblWord.Text = lblWord.Text.Remove(mostletra, 1)
                            Me.lblWord.Text = lblWord.Text.Insert(mostletra, tentativa)
                            checar = True
                        End If
                    Next
                    'se errar uma letra mais uma parte do boneco irá aparecer
                    If checar = False Then
                        picPicture.Visible = True
                        picPicture.Image = ImageList.Images(resperrada)
                        resperrada += 1
                    End If
                Else MessageBox.Show("ja tentaste essa letra")
                End If
            End If
            'terminar quando o jogador errar 6 vezes
        Loop Until lblWord.Text = arrpalavra(rndpalavra) Or resperrada = 6

        If resperrada = 6 Then

            MessageBox.Show("infelizmente perdeste o jogo, para tentares de novo clique no botao de jogar novamente")
            btnStart.Show()
        Else
            If lblWord.Text = arrpalavra(rndpalavra) Then
                MessageBox.Show("Parabens completas-te o primeiro nivel, se quiseres continuar clica no nivel 2")
                Button2.Show()
            End If
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strpalavra As String
        Dim objRandom As New Random
        Dim mostletra As Integer
        Dim arrpalavra(2) As String
        Dim resperrada As Integer = 0
        Dim rndpalavra As Integer
        Dim checar As Boolean
        Dim tentativa As Char
        Const letras As String = "abcdefghijklmnopqrstuvwxyz"
        lblWord.Text = String.Empty
        picPicture.Visible = False
        lstLetters.Items.Clear()
        rndpalavra = objRandom.Next(0, 2)
        arrpalavra(0) = "hungria"
        arrpalavra(1) = "finlandia"
        strpalavra = arrpalavra(rndpalavra)
        Select Case rndpalavra
            Case Is = 0
                Me.lblWord.Text = "_______"
            Case Is = 1
                Me.lblWord.Text = "_________"
        End Select
        btnStart.Hide()
        Button2.Hide()
        Button3.Hide()
        Do
            tentativa = InputBox("introduza uma letra de A-Z para tentares advinhar a palavra").ToLower
            If InStr(letras, tentativa) = 0 Then
                MessageBox.Show("so podes utilizar letras")
            Else
                If lstLetters.Items.Contains(tentativa) = False Then
                    checar = False
                    lstLetters.Items.Add(tentativa)
                    'Mostrar letra caso pertenca á palavra correta
                    For mostletra = 0 To Integer.Parse(arrpalavra(rndpalavra).Length - 1) Step 1
                        If strpalavra(mostletra) = tentativa Then
                            Me.lblWord.Text = lblWord.Text.Remove(mostletra, 1)
                            Me.lblWord.Text = lblWord.Text.Insert(mostletra, tentativa)
                            checar = True
                        End If
                    Next
                    'se errar uma letra mais uma parte do boneco irá aparecer
                    If checar = False Then
                        picPicture.Visible = True
                        picPicture.Image = ImageList.Images(resperrada)
                        resperrada += 1
                    End If
                Else MessageBox.Show("ja tentaste essa letra")
                End If
            End If
            'terminar quando o jogador errar 6 vezes
        Loop Until lblWord.Text = arrpalavra(rndpalavra) Or resperrada = 6

        If resperrada = 6 Then
            MessageBox.Show("infelizmente perdeste o jogo, para tentares de novo clique no botao de jogar novamente")
            Button2.Show()
        Else
            If lblWord.Text = arrpalavra(rndpalavra) Then
                MessageBox.Show("Parabens liberas-te o ultimo Nivel")
                Button3.Show()
            End If
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim strpalavra As String
        Dim objRandom As New Random
        Dim mostletra As Integer
        Dim arrpalavra(2) As String
        Dim resperrada As Integer = 0
        Dim rndpalavra As Integer
        Dim checar As Boolean
        Dim tentativa As Char
        Const letras As String = "abcdefghijklmnopqrstuvwxyz"
        lblWord.Text = String.Empty
        picPicture.Visible = False
        lstLetters.Items.Clear()
        rndpalavra = objRandom.Next(0, 2)
        arrpalavra(0) = "paquistao"
        arrpalavra(1) = "taiwan"
        strpalavra = arrpalavra(rndpalavra)
        Select Case rndpalavra
            Case Is = 0
                Me.lblWord.Text = "_________"
            Case Is = 1
                Me.lblWord.Text = "______"
        End Select
        btnStart.Hide()
        Button2.Hide()
        Button3.Hide()
        Do
            tentativa = InputBox("introduza uma letra de A-Z para tentares advinhar a palavra").ToLower
            If InStr(letras, tentativa) = 0 Then
                MessageBox.Show("so podes utilizar letras")
            Else
                If lstLetters.Items.Contains(tentativa) = False Then
                    checar = False
                    lstLetters.Items.Add(tentativa)
                    'Mostrar letra caso pertenca á palavra correta
                    For mostletra = 0 To Integer.Parse(arrpalavra(rndpalavra).Length - 1) Step 1
                        If strpalavra(mostletra) = tentativa Then
                            Me.lblWord.Text = lblWord.Text.Remove(mostletra, 1)
                            Me.lblWord.Text = lblWord.Text.Insert(mostletra, tentativa)
                            checar = True
                        End If
                    Next
                    'se errar uma letra mais uma parte do boneco irá aparecer
                    If checar = False Then
                        picPicture.Visible = True
                        picPicture.Image = ImageList.Images(resperrada)
                        resperrada += 1
                    End If
                Else MessageBox.Show("ja tentaste essa letra")
                End If
            End If
            'terminar quando o jogador errar 6 vezes
        Loop Until lblWord.Text = arrpalavra(rndpalavra) Or resperrada = 6


        If resperrada = 6 Then
            MessageBox.Show("infelizmente perdeste o jogo, se quiseres continuar clica no nivel 1 de novo")
            Button3.Show()
        Else
            If lblWord.Text = arrpalavra(rndpalavra) Then
                MessageBox.Show("Parabens ja acabas-te o jogo, se quiseres repetir algum nivel clica no nivel que você quiser repetir. ")
                btnStart.Show()
                Button2.Show()
                Button3.Show()
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub
End Class
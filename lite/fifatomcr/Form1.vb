Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2
Imports System.Data

Imports System.IO






Public Class Form1
    Dim busctexto As String = ""
    Dim offsetbusc As Integer
    Dim playernombre As String = ""
    Dim clubactualname As String = ""
    Dim playernombre2 As String = ""
    Dim ultimaletra As String = ""
    Dim validtext As String
    Dim player1 As String = ""
    Dim player2 As String = ""
    Dim nameplayer1 As String = ""
    Dim nameplayer2 As String = ""
    Dim nameplayer3 As String = ""
    Dim nameplayer4 As String = ""
    Dim nameplayer5 As String = ""
    Dim nameplayer6 As String = ""
    Dim nameplayer7 As String = ""
    Dim nameplayer8 As String = ""
    Dim nameplayer9 As String = ""
    Dim nameplayer10 As String = ""
    Dim nameplayer11 As String = ""
    Dim nameplayer12 As String = ""
    Dim nameplayer13 As String = ""
    Dim nameplayer14 As String = ""
    Dim nameplayer15 As String = ""
    Dim nameplayer16 As String = ""
    Dim nameplayer17 As String = ""
    Dim nameplayer18 As String = ""
    Dim nameplayer19 As String = ""
    Dim nameplayer20 As String = ""
    Dim nameplayer21 As String = ""
    Dim nameplayer22 As String = ""
    Dim nameplayer23 As String = ""
    Dim nameplayer24 As String = ""
    Dim nameplayer25 As String = ""
    Dim nameplayer26 As String = ""
    Dim nameplayer27 As String = ""
    Dim nameplayer28 As String = ""
    Dim nameplayer29 As String = ""
    Dim nameplayer30 As String = ""
    Dim nameplayer31 As String = ""
    Dim nameplayer32 As String = ""
    Dim nameplayer33 As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        formmcr.MdiParent = Me
        formmcr.Show()
        formformation.MdiParent = Me
        formformation.Hide()

        WebView21.Source = New Uri("https://www.sofifa.com/teams")


    End Sub






    Public Sub calcmcr()
        'System.Threading.Thread.Sleep(3500)

        busctexto = RichTextBox1.Text
        'If Mid(Me.Text, 1, 23) = "https://sofifa.com/team" Then



        On Error Resume Next
        TextBox77.Text = ""

        'buscando nombre
        offsetbusc = InStr(busctexto, "ellipsis")
        Dim un As Integer
        Dim p As Integer
        p = 100
        For u = 1 To p
            playernombre2 = Mid(busctexto, offsetbusc + 10, 1)
            If playernombre2 = "<" Then
                Exit For
            Else
                p = p + 1
                TextBox77.Text = TextBox77.Text + playernombre2
                offsetbusc = offsetbusc + 1

            End If

        Next

        'busca team
        offsetbusc = InStr(busctexto, "affiliation")
        TextBox74.Text = ""
        p = 100
        For u = 1 To p
            playernombre2 = Mid(busctexto, offsetbusc + 15, 1)
            If playernombre2 = """" Then
                Exit For
            Else
                p = p + 1
                TextBox74.Text = TextBox74.Text + playernombre2
                offsetbusc = offsetbusc + 1

            End If

        Next

        'busca national team

        offsetbusc = InStr(busctexto, ">National team</")
        If offsetbusc <> 0 Then
            offsetbusc = InStr(offsetbusc, busctexto, txt_comillas.Text & "team" & txt_comillas.Text & ">")
            TextBox75.Text = ""
            p = 100
            For u = 1 To p
                playernombre2 = Mid(busctexto, offsetbusc + 7, 1)
                If playernombre2 = "<" Then
                    Exit For
                Else
                    p = p + 1
                    TextBox75.Text = TextBox75.Text + playernombre2
                    offsetbusc = offsetbusc + 1

                End If
            Next
        Else
            TextBox75.Text = ""
        End If




        'nacionalidad
        offsetbusc = InStr(busctexto, "nationality")
        TextBox76.Text = ""
        p = 100
        For u = 1 To p
            playernombre2 = Mid(busctexto, offsetbusc + 15, 1)
            If playernombre2 = """" Then
                Exit For
            Else
                p = p + 1
                TextBox76.Text = TextBox76.Text + playernombre2
                offsetbusc = offsetbusc + 1

            End If

        Next


        offsetbusc = InStr(busctexto, "familyName")

        playernombre = Mid(busctexto, offsetbusc + 14, 10)


        TextBox1.Text = playernombre
        TextBox1.Text = Trim(Replace(TextBox1.Text, " ", ""))
        TextBox1.Text = Trim(Replace(TextBox1.Text, ",", ""))
        TextBox1.Text = Trim(Replace(TextBox1.Text, """", ""))

        'buscador foto
        offsetbusc = InStr(busctexto, "https://s3p.sofifa.net")
        Dim cargafoto As String

        If offsetbusc = 0 Then
            offsetbusc = InStr(busctexto, "https://cdn.sofifa.net/players/")
        End If
        p = 100


        For u = 1 To p
            playernombre2 = Mid(busctexto, offsetbusc, 1)
            If playernombre2 = txt_comillas.Text Then
                Exit For
            Else
                p = p + 1
                cargafoto = cargafoto + playernombre2
                offsetbusc = offsetbusc + 1

            End If

        Next

        fotosofifa = cargafoto
        'buscando posicion
        offsetbusc = 0
        offsetbusc = InStr(busctexto, "jobTitle")
        playernombre = Mid(busctexto, offsetbusc + 12, 15)
        TextBox6.Text = playernombre
        TextBox6.Text = Trim(Replace(TextBox6.Text, " ", ""))
        TextBox6.Text = Trim(Replace(TextBox6.Text, ",", ""))
        TextBox6.Text = Trim(Replace(TextBox6.Text, """", ""))



        'buscando numero kit club
        offsetbusc = 0
        offsetbusc = InStr(busctexto, ">Club<")
        offsetbusc = InStr(offsetbusc + 6, busctexto, ">Kit number<")
        playernombre = Mid(busctexto, offsetbusc + 20, 2)
        TextBox66.Text = playernombre
        TextBox66.Text = Trim(Replace(TextBox66.Text, "<", ""))

        'buscando numero kit seleccion
        offsetbusc = InStr(busctexto, ">National team<")
        offsetbusc = InStr(offsetbusc + 15, busctexto, ">Kit number<")

        playernombre = Mid(busctexto, offsetbusc + 20, 2)
        TextBox44.Text = playernombre
        TextBox44.Text = Trim(Replace(TextBox44.Text, "<", ""))



        'buscando edad
        offsetbusc = 0
        offsetbusc = InStr(busctexto, "birthDate")
        playernombre = Mid(busctexto, offsetbusc + 13, 10)
        TextBox2.Text = playernombre
        TextBox2.Text = Trim(Replace(TextBox2.Text, " ", ""))
        TextBox2.Text = Trim(Replace(TextBox2.Text, ",", ""))
        TextBox2.Text = Trim(Replace(TextBox2.Text, """", ""))

        'buscando altura
        offsetbusc = InStr(busctexto, "heigh")
        playernombre = Mid(busctexto, offsetbusc + 10, 3)
        TextBox3.Text = playernombre
        TextBox3.Text = Trim(Replace(TextBox3.Text, " ", ""))
        TextBox3.Text = Trim(Replace(TextBox3.Text, ",", ""))
        TextBox3.Text = Trim(Replace(TextBox3.Text, """", ""))

        'buscando peso
        offsetbusc = InStr(busctexto, "weight")
        playernombre = Mid(busctexto, offsetbusc + 10, 2)
        TextBox4.Text = playernombre
        TextBox4.Text = Trim(Replace(TextBox4.Text, " ", ""))
        TextBox4.Text = Trim(Replace(TextBox4.Text, ",", ""))
        TextBox4.Text = Trim(Replace(TextBox4.Text, """", ""))

        'pie
        offsetbusc = InStr(busctexto, "Preferred foot")
        playernombre = Mid(busctexto, offsetbusc + 23, 1)
        TextBox5.Text = playernombre
        TextBox5.Text = Trim(Replace(TextBox5.Text, " ", ""))
        TextBox5.Text = Trim(Replace(TextBox5.Text, ",", ""))
        TextBox5.Text = Trim(Replace(TextBox5.Text, """", ""))

        Dim validfoot As String
        Dim x As Integer
        If TextBox5.Text = "L" Then
            validfoot = "Left"
            x = 0
        Else
            validfoot = "Right"
            x = 1
        End If

        'Weak foot
        offsetbusc = InStr(busctexto, "Weak foot")
        playernombre = Mid(busctexto, offsetbusc + 25, 1)
        TextBox7.Text = playernombre
        TextBox7.Text = Trim(Replace(TextBox7.Text, " ", ""))
        TextBox7.Text = Trim(Replace(TextBox7.Text, ",", ""))
        TextBox7.Text = Trim(Replace(TextBox7.Text, """", ""))

        'crossing

        offsetbusc = InStr(busctexto, ">Attacking<")
        playernombre = Mid(busctexto, offsetbusc + 34, 2)
        TextBox8.Text = playernombre


        'finishing
        offsetbusc = InStr(busctexto, ">Crossing<")
        playernombre = Mid(busctexto, offsetbusc + 39, 2)
        TextBox9.Text = playernombre

        'Heading accuracy
        offsetbusc = InStr(busctexto, ">Finishing<")
        playernombre = Mid(busctexto, offsetbusc + 40, 2)
        TextBox10.Text = playernombre
        TextBox10.Text = Trim(Replace(TextBox10.Text, """", ""))

        'Short passing
        offsetbusc = InStr(busctexto, ">Heading accuracy<")
        playernombre = Mid(busctexto, offsetbusc + 47, 2)
        TextBox11.Text = playernombre


        'Volleys
        offsetbusc = InStr(busctexto, ">Short passing<")
        playernombre = Mid(busctexto, offsetbusc + 44, 2)
        TextBox12.Text = playernombre


        'Dribbling
        offsetbusc = InStr(busctexto, ">Skill<")
        playernombre = Mid(busctexto, offsetbusc + 30, 2)
        TextBox13.Text = playernombre


        'Curve
        offsetbusc = InStr(busctexto, ">Dribbling<")
        playernombre = Mid(busctexto, offsetbusc + 40, 2)
        TextBox14.Text = playernombre


        'Free kick accuracy
        offsetbusc = InStr(busctexto, ">Curve<")
        playernombre = Mid(busctexto, offsetbusc + 36, 2)
        TextBox15.Text = playernombre


        'Long passing
        offsetbusc = InStr(busctexto, ">FK Accuracy<")
        playernombre = Mid(busctexto, offsetbusc + 42, 2)
        TextBox16.Text = playernombre


        'Ball control
        offsetbusc = InStr(busctexto, ">Long passing<")
        playernombre = Mid(busctexto, offsetbusc + 43, 2)
        TextBox17.Text = playernombre


        'Acceleration
        offsetbusc = InStr(busctexto, ">Movement<")
        playernombre = Mid(busctexto, offsetbusc + 33, 2)
        TextBox18.Text = playernombre

        'Sprint speed
        offsetbusc = InStr(busctexto, ">Acceleration<")
        playernombre = Mid(busctexto, offsetbusc + 43, 2)
        TextBox19.Text = playernombre


        'Agility
        offsetbusc = InStr(busctexto, ">Sprint speed<")
        playernombre = Mid(busctexto, offsetbusc + 43, 2)
        TextBox20.Text = playernombre


        'Reactions
        offsetbusc = InStr(busctexto, ">Agility<")
        playernombre = Mid(busctexto, offsetbusc + 38, 2)
        TextBox21.Text = playernombre


        'Balance
        offsetbusc = InStr(busctexto, ">Reactions<")
        playernombre = Mid(busctexto, offsetbusc + 40, 2)
        TextBox22.Text = playernombre
        'MsgBox(playernombre)

        'Shot power
        offsetbusc = InStr(busctexto, ">Power<")
        playernombre = Mid(busctexto, offsetbusc + 30, 2)
        TextBox23.Text = playernombre

        'Jumping
        offsetbusc = InStr(busctexto, ">Shot power<")
        playernombre = Mid(busctexto, offsetbusc + 41, 2)
        TextBox24.Text = playernombre

        'Stamina
        offsetbusc = InStr(busctexto, ">Jumping<")
        playernombre = Mid(busctexto, offsetbusc + 38, 2)
        TextBox25.Text = playernombre

        'Strength
        offsetbusc = InStr(busctexto, ">Stamina<")
        playernombre = Mid(busctexto, offsetbusc + 38, 2)
        TextBox26.Text = playernombre

        'Long shots
        offsetbusc = InStr(busctexto, ">Strength<")
        playernombre = Mid(busctexto, offsetbusc + 39, 2)
        TextBox27.Text = playernombre

        'Aggression
        offsetbusc = InStr(busctexto, ">Mentality<")
        playernombre = Mid(busctexto, offsetbusc + 34, 2)
        TextBox28.Text = playernombre

        'Interceptions
        offsetbusc = InStr(busctexto, ">Aggression<")
        playernombre = Mid(busctexto, offsetbusc + 41, 2)
        TextBox29.Text = playernombre
        TextBox29.Text = Trim(Replace(TextBox29.Text, """", ""))
        TextBox29.Text = Trim(Replace(TextBox29.Text, "<", ""))
        TextBox29.Text = Trim(Replace(TextBox29.Text, ">", ""))

        'Positioning
        offsetbusc = InStr(busctexto, ">Interceptions<")
        playernombre = Mid(busctexto, offsetbusc + 44, 2)
        TextBox30.Text = playernombre
        TextBox30.Text = Trim(Replace(TextBox30.Text, """", ""))
        TextBox30.Text = Trim(Replace(TextBox30.Text, "<", ""))
        TextBox30.Text = Trim(Replace(TextBox30.Text, ">", ""))

        'Vision
        offsetbusc = InStr(busctexto, ">Att. Position<")
        playernombre = Mid(busctexto, offsetbusc + 44, 2)
        TextBox31.Text = playernombre

        'Penalties
        offsetbusc = InStr(busctexto, ">Vision<")
        playernombre = Mid(busctexto, offsetbusc + 37, 2)
        TextBox32.Text = playernombre

        'Composure
        offsetbusc = InStr(busctexto, ">Penalties<")
        playernombre = Mid(busctexto, offsetbusc + 40, 2)
        TextBox33.Text = playernombre

        'Marking
        offsetbusc = InStr(busctexto, ">Defending<")
        playernombre = Mid(busctexto, offsetbusc + 34, 2)
        TextBox34.Text = playernombre

        'Standing tackle
        offsetbusc = InStr(busctexto, ">Defensive awareness<")
        playernombre = Mid(busctexto, offsetbusc + 50, 2)
        TextBox35.Text = playernombre

        'Sliding tackle
        offsetbusc = InStr(busctexto, ">Standing tackle<")
        playernombre = Mid(busctexto, offsetbusc + 46, 2)
        TextBox36.Text = playernombre
        TextBox36.Text = Trim(Replace(TextBox36.Text, """", ""))
        TextBox36.Text = Trim(Replace(TextBox36.Text, "<", ""))
        TextBox36.Text = Trim(Replace(TextBox36.Text, ">", ""))

        'GK diving
        offsetbusc = InStr(busctexto, ">Goalkeeping<")
        playernombre = Mid(busctexto, offsetbusc + 36, 2)
        TextBox37.Text = playernombre
        TextBox37.Text = Trim(Replace(TextBox37.Text, """", ""))
        TextBox37.Text = Trim(Replace(TextBox37.Text, "<", ""))
        TextBox37.Text = Trim(Replace(TextBox37.Text, ">", ""))

        'GK handling
        offsetbusc = InStr(busctexto, ">GK Diving<")
        playernombre = Mid(busctexto, offsetbusc + 40, 2)
        TextBox38.Text = playernombre
        TextBox38.Text = Trim(Replace(TextBox38.Text, """", ""))
        TextBox38.Text = Trim(Replace(TextBox38.Text, "<", ""))
        TextBox38.Text = Trim(Replace(TextBox38.Text, ">", ""))

        'GK kicking
        offsetbusc = InStr(busctexto, ">GK Handling<")
        playernombre = Mid(busctexto, offsetbusc + 42, 2)
        TextBox39.Text = playernombre
        TextBox39.Text = Trim(Replace(TextBox39.Text, """", ""))
        TextBox39.Text = Trim(Replace(TextBox39.Text, "<", ""))
        TextBox39.Text = Trim(Replace(TextBox39.Text, ">", ""))

        'GK positioning
        offsetbusc = InStr(busctexto, ">GK Kicking")
        playernombre = Mid(busctexto, offsetbusc + 41, 2)
        TextBox40.Text = playernombre
        TextBox40.Text = Trim(Replace(TextBox40.Text, """", ""))
        TextBox40.Text = Trim(Replace(TextBox40.Text, "<", ""))
        TextBox40.Text = Trim(Replace(TextBox40.Text, ">", ""))

        'GK reflexes
        offsetbusc = InStr(busctexto, ">GK Positioning")
        playernombre = Mid(busctexto, offsetbusc + 45, 2)
        TextBox41.Text = playernombre
        TextBox41.Text = Trim(Replace(TextBox41.Text, """", ""))
        TextBox41.Text = Trim(Replace(TextBox41.Text, "<", ""))
        TextBox41.Text = Trim(Replace(TextBox41.Text, ">", ""))

        'Overall Rating
        offsetbusc = InStr(busctexto, "card spacing")
        playernombre = Mid(busctexto, offsetbusc + 72, 2)
        TextBox42.Text = playernombre

        'Potential Rating

        offsetbusc = InStr(busctexto, ">Overall rating<")
        playernombre = Mid(busctexto, offsetbusc + 90, 2)
        TextBox43.Text = playernombre

        'we2002 convert==========================================================================================
        formmcr.txtplayername.Text = Regex.Replace(TextBox1.Text.Normalize(NormalizationForm.FormD), "['\u0308]+", "")

        formmcr.btname2.Text = formmcr.txtplayername.Text
        formmcr.btname2.Text = Regex.Replace(formmcr.btname2.Text.Normalize(NormalizationForm.FormD), "['\u0301]+", "")
        formmcr.btname2.Text = Regex.Replace(formmcr.btname2.Text.Normalize(NormalizationForm.FormD), "['\u0328]+", "")
        formmcr.btname2.Text = Regex.Replace(formmcr.btname2.Text.Normalize(NormalizationForm.FormD), "['\u0141]+", "L")
        formmcr.btname2.Text = Regex.Replace(formmcr.btname2.Text.Normalize(NormalizationForm.FormD), "['\u0142]+", "l")
        formmcr.btname2.Text = Regex.Replace(formmcr.btname2.Text.Normalize(NormalizationForm.FormD), "['\u030c]+", "")
        formmcr.btname2.Text = Regex.Replace(formmcr.btname2.Text.Normalize(NormalizationForm.FormD), "['\u00e6]+", "ae")

        formmcr.btname2.Text = Trim(Replace(formmcr.btname2.Text, " ", ""))
        formmcr.btname2.Text = Trim(Replace(formmcr.btname2.Text, "ø", "o"))

        'heigth
        formmcr.cmbheigth.Text = TextBox3.Text


        'club number
        If TextBox66.Text < 32 Then
            nclub = TextBox66.Text
        Else
            nclub = 32
        End If
        If TextBox66.Text = "" Then
            nclub = "32"
        End If
        If TextBox66.Text = "tm" Then
            nclub = "32"
        End If

        ' nat number
        If TextBox44.Text < 32 Then
            nnational = TextBox44.Text
        Else
            nnational = 32
        End If
        If TextBox44.Text = "" Then
            nnational = "32"
        End If
        If TextBox44.Text = "tm" Then
            nnational = "32"
        End If

        If formmcr.rbtnclub.Checked = True Then
            formmcr.cmbclubnumber.Text = nclub
        End If
        If formmcr.rbtnational.Checked = True Then
            formmcr.cmbclubnumber.Text = nnational
        End If


        formmcr.txtfifaname.Text = Regex.Replace(TextBox77.Text.Normalize(NormalizationForm.FormD), "['\u0308]+", "")
        formmcr.btname1.Text = formmcr.txtfifaname.Text
        formmcr.btname1.Text = Regex.Replace(formmcr.btname1.Text.Normalize(NormalizationForm.FormD), "['\u0301]+", "")
        formmcr.btname1.Text = Regex.Replace(formmcr.btname1.Text.Normalize(NormalizationForm.FormD), "['\u0328]+", "")
        formmcr.btname1.Text = Regex.Replace(formmcr.btname1.Text.Normalize(NormalizationForm.FormD), "['\u0141]+", "L")
        formmcr.btname1.Text = Regex.Replace(formmcr.btname1.Text.Normalize(NormalizationForm.FormD), "['\u0142]+", "l")
        formmcr.btname1.Text = Regex.Replace(formmcr.btname1.Text.Normalize(NormalizationForm.FormD), "['\u030c]+", "")
        formmcr.btname1.Text = Regex.Replace(formmcr.btname1.Text.Normalize(NormalizationForm.FormD), "['\u00e6]+", "ae")

        formmcr.btname1.Text = Trim(Replace(formmcr.btname1.Text, " ", ""))
        formmcr.btname1.Text = Trim(Replace(formmcr.btname1.Text, "ø", "o"))

        formmcr.txtplayername.Text = formmcr.btname1.Text



        formmcr.txtfechanacimiento.Text = TextBox2.Text
        formmcr.txtclub.Text = TextBox74.Text

        formmcr.txtnacionalidad.Text = TextBox76.Text

        Dim nameposition As String
        Dim nameposition2 As String
        nameposition = Mid(TextBox6.Text, 1, 7)
        nameposition2 = Mid(TextBox6.Text, 1, 10)
        If nameposition = "Striker" Then formmcr.cmbposition.Text = "CF"
        If nameposition2 = "Leftwinger" Then formmcr.cmbposition.Text = "WG"
        If nameposition2 = "Rightwinge" Then formmcr.cmbposition.Text = "WG"
        If nameposition2 = "Centermidf" Then formmcr.cmbposition.Text = "DH"
        If nameposition2 = "Centraldef" Then formmcr.cmbposition.Text = "DH"
        If nameposition2 = "Centerback" Then formmcr.cmbposition.Text = "CB"
        If nameposition2 = "Centerforw" Then formmcr.cmbposition.Text = "CF"
        If nameposition = "Rightba" Then formmcr.cmbposition.Text = "SB"
        If nameposition2 = "Goalkeeper" Then formmcr.cmbposition.Text = "GK"
        If nameposition2 = "Centralatt" Then formmcr.cmbposition.Text = "OH"
        If nameposition2 = "Leftmidfie" Then formmcr.cmbposition.Text = "SH"
        If nameposition2 = "Rightmidfi" Then formmcr.cmbposition.Text = "SH"
        If nameposition = "Leftbac" Then formmcr.cmbposition.Text = "SB"
        If nameposition2 = "Leftwingba" Then formmcr.cmbposition.Text = "SB"
        If nameposition2 = "Rightwingb" Then formmcr.cmbposition.Text = "SB"
        'national team
        formmcr.txt_nat_team.Text = TextBox75.Text


        'body


        Dim calcbody As Integer
        stat2 = TextBox3.Text
        stat3 = TextBox4.Text

        calcbody = (stat2 * stat3) / 200

        If calcbody >= 50 And calcbody <= 64 Then formmcr.cmbbody.Text = "a"
        If calcbody >= 65 And calcbody <= 69 Then formmcr.cmbbody.Text = "b"
        If calcbody >= 70 And calcbody <= 74 Then formmcr.cmbbody.Text = "c"
        If calcbody >= 75 And calcbody <= 79 Then formmcr.cmbbody.Text = "d"
        If calcbody >= 80 And calcbody <= 84 Then formmcr.cmbbody.Text = "e"
        If calcbody >= 85 And calcbody <= 89 Then formmcr.cmbbody.Text = "f"
        If calcbody >= 90 And calcbody <= 94 Then formmcr.cmbbody.Text = "g"
        If calcbody >= 95 And calcbody <= 110 Then formmcr.cmbbody.Text = "h"
        'foto
        formmcr.PictureFifa.Load(cargafoto)
        'Clipboard.SetText(cargafoto)
        'formmcr.PictureFifa.Image.Save(My.Computer.FileSystem.CurrentDirectory & "/tempfotofifa.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
        ''Age

        Dim calcage As Integer

        Dim fechact As Date = Date.Now
        Dim fechaborn As Date = TextBox2.Text

        If fechact.Month >= fechaborn.Month Then

            calcage = (fechact.Year - fechaborn.Year)
        Else
            calcage = fechact.Year - fechaborn.Year - 1


        End If
        formmcr.cmbage.Text = calcage

        'foot
        If TextBox7.Text > 3 And x = 1 Then
            formmcr.cmbfood.Text = "b"
        Else
            formmcr.cmbfood.Text = TextBox5.Text
        End If

        'offence
        If TextBox30.Text >= 0 And TextBox30.Text <= 10 Then formmcr.cmboffense.Text = "12"
        If TextBox30.Text >= 11 And TextBox30.Text <= 20 Then formmcr.cmboffense.Text = "13"
        If TextBox30.Text >= 21 And TextBox30.Text <= 30 Then formmcr.cmboffense.Text = "14"
        If TextBox30.Text >= 31 And TextBox30.Text <= 50 Then formmcr.cmboffense.Text = "15"
        If TextBox30.Text >= 51 And TextBox30.Text <= 74 Then formmcr.cmboffense.Text = "16"
        If TextBox30.Text >= 75 And TextBox30.Text <= 81 Then formmcr.cmboffense.Text = "17"
        If TextBox30.Text >= 82 And TextBox30.Text <= 88 Then formmcr.cmboffense.Text = "18"
        If TextBox30.Text >= 89 And TextBox30.Text <= 99 Then formmcr.cmboffense.Text = "19"

        If formmcr.cmboffense.Text >= 12 And formmcr.cmboffense.Text <= 16 Then formmcr.cmboffense.BackColor = Color.White
        If formmcr.cmboffense.Text = 17 Then formmcr.cmboffense.BackColor = Color.Yellow
        If formmcr.cmboffense.Text = 18 Then formmcr.cmboffense.BackColor = Color.Orange
        If formmcr.cmboffense.Text = 19 Then formmcr.cmboffense.BackColor = Color.Red


        'deffense
        Dim calcdeffense As Integer
        Dim markingvalue As Integer
        Dim taclevalue As Integer


        If formmcr.cmbposition.Text = "gk" Then

            markingvalue = TextBox37.Text
            taclevalue = TextBox41.Text
            calcdeffense = (markingvalue + taclevalue) / 2
            stat1 = calcdeffense

            If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
            If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
            If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
            If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
            If stat1 >= 51 And stat1 <= 67 Then resultstat = "16"
            If stat1 >= 68 And stat1 <= 74 Then resultstat = "17"
            If stat1 >= 75 And stat1 <= 81 Then resultstat = "18"
            If stat1 >= 82 And stat1 <= 100 Then resultstat = "19"

        Else
            markingvalue = TextBox34.Text
            taclevalue = TextBox35.Text
            calcdeffense = (markingvalue + taclevalue) / 2
            stat1 = calcdeffense

            If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
            If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
            If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
            If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
            If stat1 >= 51 And stat1 <= 71 Then resultstat = "16"
            If stat1 >= 72 And stat1 <= 78 Then resultstat = "17"
            If stat1 >= 79 And stat1 <= 85 Then resultstat = "18"
            If stat1 >= 86 And stat1 <= 100 Then resultstat = "19"
        End If

        formmcr.cmbdeffense.Text = resultstat

        If formmcr.cmbdeffense.Text >= 12 And formmcr.cmbdeffense.Text <= 16 Then formmcr.cmbdeffense.BackColor = Color.White
        If formmcr.cmbdeffense.Text = 17 Then formmcr.cmbdeffense.BackColor = Color.Yellow
        If formmcr.cmbdeffense.Text = 18 Then formmcr.cmbdeffense.BackColor = Color.Orange
        If formmcr.cmbdeffense.Text = 19 Then formmcr.cmbdeffense.BackColor = Color.Red


        'body balance
        stat1 = TextBox22.Text
        If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
        If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
        If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
        If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
        If stat1 >= 51 And stat1 <= 78 Then resultstat = "16"
        If stat1 >= 79 And stat1 <= 85 Then resultstat = "17"
        If stat1 >= 86 And stat1 <= 92 Then resultstat = "18"
        If stat1 >= 93 And stat1 <= 100 Then resultstat = "19"
        formmcr.cmbbodybalance.Text = resultstat

        If formmcr.cmbbodybalance.Text >= 12 And formmcr.cmbbodybalance.Text <= 16 Then formmcr.cmbbodybalance.BackColor = Color.White
        If formmcr.cmbbodybalance.Text = 17 Then formmcr.cmbbodybalance.BackColor = Color.Yellow
        If formmcr.cmbbodybalance.Text = 18 Then formmcr.cmbbodybalance.BackColor = Color.Orange
        If formmcr.cmbbodybalance.Text = 19 Then formmcr.cmbbodybalance.BackColor = Color.Red


        'stamina
        stat1 = TextBox25.Text
        If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
        If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
        If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
        If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
        If stat1 >= 51 And stat1 <= 78 Then resultstat = "16"
        If stat1 >= 79 And stat1 <= 85 Then resultstat = "17"
        If stat1 >= 86 And stat1 <= 92 Then resultstat = "18"
        If stat1 >= 93 And stat1 <= 100 Then resultstat = "19"
        formmcr.cmbstamina.Text = resultstat

        If formmcr.cmbstamina.Text >= 12 And formmcr.cmbstamina.Text <= 16 Then formmcr.cmbstamina.BackColor = Color.White
        If formmcr.cmbstamina.Text = 17 Then formmcr.cmbstamina.BackColor = Color.Yellow
        If formmcr.cmbstamina.Text = 18 Then formmcr.cmbstamina.BackColor = Color.Orange
        If formmcr.cmbstamina.Text = 19 Then formmcr.cmbstamina.BackColor = Color.Red


        'speed
        stat1 = TextBox19.Text
        If rbtonline.Checked = True Then


            If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
            If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
            If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
            If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
            If stat1 >= 51 And stat1 <= 78 Then resultstat = "16"
            If stat1 >= 79 And stat1 <= 92 Then resultstat = "17"
            If stat1 >= 93 And stat1 <= 100 Then resultstat = "18"
        Else
            If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
            If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
            If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
            If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
            If stat1 >= 51 And stat1 <= 78 Then resultstat = "16"
            If stat1 >= 79 And stat1 <= 85 Then resultstat = "17"
            If stat1 >= 86 And stat1 <= 92 Then resultstat = "18"
            If stat1 >= 93 And stat1 <= 100 Then resultstat = "19"
        End If


        formmcr.cmbspeed.Text = resultstat

        If formmcr.cmbspeed.Text >= 12 And formmcr.cmbspeed.Text <= 16 Then formmcr.cmbspeed.BackColor = Color.White
        If formmcr.cmbspeed.Text = 17 Then formmcr.cmbspeed.BackColor = Color.Yellow
        If formmcr.cmbspeed.Text = 18 Then formmcr.cmbspeed.BackColor = Color.Orange
        If formmcr.cmbspeed.Text = 19 Then formmcr.cmbspeed.BackColor = Color.Red

        'aceleration

        stat1 = TextBox18.Text
        'If rbtonline.Checked = True Then
        '    If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
        '    If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
        '    If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
        '    If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
        '    If stat1 >= 51 And stat1 <= 78 Then resultstat = "16"
        '    If stat1 >= 79 And stat1 <= 92 Then resultstat = "17"
        '    If stat1 >= 93 And stat1 <= 100 Then resultstat = "18"
        'Else
        If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
        If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
        If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
        If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
        If stat1 >= 51 And stat1 <= 79 Then resultstat = "16"
        If stat1 >= 80 And stat1 <= 86 Then resultstat = "17"
        If stat1 >= 87 And stat1 <= 93 Then resultstat = "18"
        If stat1 >= 94 And stat1 <= 100 Then resultstat = "19"
        'End If


        formmcr.cmbaceleration.Text = resultstat

        If formmcr.cmbaceleration.Text >= 12 And formmcr.cmbaceleration.Text <= 16 Then formmcr.cmbaceleration.BackColor = Color.White
        If formmcr.cmbaceleration.Text = 17 Then formmcr.cmbaceleration.BackColor = Color.Yellow
        If formmcr.cmbaceleration.Text = 18 Then formmcr.cmbaceleration.BackColor = Color.Orange
        If formmcr.cmbaceleration.Text = 19 Then formmcr.cmbaceleration.BackColor = Color.Red

        'pass
        stat2 = TextBox12.Text
        stat3 = TextBox16.Text
        promedio = (stat2 + stat3) / 2
        stat1 = promedio
        If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
        If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
        If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
        If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
        If stat1 >= 51 And stat1 <= 73 Then resultstat = "16"
        If stat1 >= 74 And stat1 <= 80 Then resultstat = "17"
        If stat1 >= 81 And stat1 <= 87 Then resultstat = "18"
        If stat1 >= 88 And stat1 <= 100 Then resultstat = "19"
        formmcr.cmbpass.Text = resultstat

        If formmcr.cmbpass.Text >= 12 And formmcr.cmbpass.Text <= 16 Then formmcr.cmbpass.BackColor = Color.White
        If formmcr.cmbpass.Text = 17 Then formmcr.cmbpass.BackColor = Color.Yellow
        If formmcr.cmbpass.Text = 18 Then formmcr.cmbpass.BackColor = Color.Orange
        If formmcr.cmbpass.Text = 19 Then formmcr.cmbpass.BackColor = Color.Red


        'shot power
        stat1 = TextBox23.Text
        If rbtonline.Checked = True Then
            If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
            If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
            If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
            If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
            If stat1 >= 51 And stat1 <= 78 Then resultstat = "16"
            If stat1 >= 79 And stat1 <= 92 Then resultstat = "17"
            If stat1 >= 93 And stat1 <= 100 Then resultstat = "18"

        Else
            If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
            If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
            If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
            If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
            If stat1 >= 51 And stat1 <= 73 Then resultstat = "16"
            If stat1 >= 74 And stat1 <= 80 Then resultstat = "17"
            If stat1 >= 81 And stat1 <= 87 Then resultstat = "18"
            If stat1 >= 88 And stat1 <= 100 Then resultstat = "19"
        End If

        formmcr.cmbshotpower.Text = resultstat

        If formmcr.cmbshotpower.Text >= 12 And formmcr.cmbshotpower.Text <= 16 Then formmcr.cmbshotpower.BackColor = Color.White
        If formmcr.cmbshotpower.Text = 17 Then formmcr.cmbshotpower.BackColor = Color.Yellow
        If formmcr.cmbshotpower.Text = 18 Then formmcr.cmbshotpower.BackColor = Color.Orange
        If formmcr.cmbshotpower.Text = 19 Then formmcr.cmbshotpower.BackColor = Color.Red

        'shot acc
        stat1 = TextBox9.Text
        If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
        If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
        If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
        If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
        If stat1 >= 51 And stat1 <= 73 Then resultstat = "16"
        If stat1 >= 74 And stat1 <= 80 Then resultstat = "17"
        If stat1 >= 81 And stat1 <= 87 Then resultstat = "18"
        If stat1 >= 88 And stat1 <= 100 Then resultstat = "19"
        formmcr.cmbshotacc.Text = resultstat

        'jump
        stat1 = TextBox24.Text
        If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
        If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
        If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
        If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
        If stat1 >= 51 And stat1 <= 76 Then resultstat = "16"
        If stat1 >= 77 And stat1 <= 84 Then resultstat = "17"
        If stat1 >= 85 And stat1 <= 91 Then resultstat = "18"
        If stat1 >= 92 And stat1 <= 100 Then resultstat = "19"
        formmcr.cmbjump.Text = resultstat


        If formmcr.cmbjump.Text >= 12 And formmcr.cmbjump.Text <= 16 Then formmcr.cmbjump.BackColor = Color.White
        If formmcr.cmbjump.Text = 17 Then formmcr.cmbjump.BackColor = Color.Yellow
        If formmcr.cmbjump.Text = 18 Then formmcr.cmbjump.BackColor = Color.Orange
        If formmcr.cmbjump.Text = 19 Then formmcr.cmbjump.BackColor = Color.Red


        'head acc
        stat1 = TextBox10.Text
        If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
        If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
        If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
        If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
        If stat1 >= 51 And stat1 <= 77 Then resultstat = "16"
        If stat1 >= 78 And stat1 <= 84 Then resultstat = "17"
        If stat1 >= 85 And stat1 <= 91 Then resultstat = "18"
        If stat1 >= 92 And stat1 <= 100 Then resultstat = "19"
        formmcr.cmbhead.Text = resultstat

        If formmcr.cmbhead.Text >= 12 And formmcr.cmbhead.Text <= 16 Then formmcr.cmbhead.BackColor = Color.White
        If formmcr.cmbhead.Text = 17 Then formmcr.cmbhead.BackColor = Color.Yellow
        If formmcr.cmbhead.Text = 18 Then formmcr.cmbhead.BackColor = Color.Orange
        If formmcr.cmbhead.Text = 19 Then formmcr.cmbhead.BackColor = Color.Red

        'ball control
        stat1 = TextBox17.Text
        If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
        If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
        If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
        If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
        If stat1 >= 51 And stat1 <= 75 Then resultstat = "16"
        If stat1 >= 76 And stat1 <= 82 Then resultstat = "17"
        If stat1 >= 83 And stat1 <= 88 Then resultstat = "18"
        If stat1 >= 88 And stat1 <= 100 Then resultstat = "19"
        formmcr.cmbtechnique.Text = resultstat

        If formmcr.cmbtechnique.Text >= 12 And formmcr.cmbtechnique.Text <= 16 Then formmcr.cmbtechnique.BackColor = Color.White
        If formmcr.cmbtechnique.Text = 17 Then formmcr.cmbtechnique.BackColor = Color.Yellow
        If formmcr.cmbtechnique.Text = 18 Then formmcr.cmbtechnique.BackColor = Color.Orange
        If formmcr.cmbtechnique.Text = 19 Then formmcr.cmbtechnique.BackColor = Color.Red

        'dribbling
        stat1 = TextBox13.Text
        If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
        If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
        If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
        If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
        If stat1 >= 51 And stat1 <= 75 Then resultstat = "16"
        If stat1 >= 76 And stat1 <= 82 Then resultstat = "17"
        If stat1 >= 83 And stat1 <= 88 Then resultstat = "18"
        If stat1 >= 88 And stat1 <= 100 Then resultstat = "19"
        formmcr.cmbdribble.Text = resultstat

        If formmcr.cmbdribble.Text >= 12 And formmcr.cmbdribble.Text <= 16 Then formmcr.cmbdribble.BackColor = Color.White
        If formmcr.cmbdribble.Text = 17 Then formmcr.cmbdribble.BackColor = Color.Yellow
        If formmcr.cmbdribble.Text = 18 Then formmcr.cmbdribble.BackColor = Color.Orange
        If formmcr.cmbdribble.Text = 19 Then formmcr.cmbdribble.BackColor = Color.Red

        'curve
        stat1 = TextBox14.Text
        If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
        If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
        If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
        If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
        If stat1 >= 51 And stat1 <= 72 Then resultstat = "16"
        If stat1 >= 73 And stat1 <= 79 Then resultstat = "17"
        If stat1 >= 80 And stat1 <= 86 Then resultstat = "18"
        If stat1 >= 87 And stat1 <= 100 Then resultstat = "19"
        formmcr.cmbcurve.Text = resultstat

        If formmcr.cmbcurve.Text >= 12 And formmcr.cmbcurve.Text <= 16 Then formmcr.cmbcurve.BackColor = Color.White
        If formmcr.cmbcurve.Text = 17 Then formmcr.cmbcurve.BackColor = Color.Yellow
        If formmcr.cmbcurve.Text = 18 Then formmcr.cmbcurve.BackColor = Color.Orange
        If formmcr.cmbcurve.Text = 19 Then formmcr.cmbcurve.BackColor = Color.Red

        'agresive

        stat2 = TextBox30.Text
        stat3 = TextBox28.Text
        promedio = (stat2 + stat3) / 2
        stat1 = promedio
        If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
        If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
        If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
        If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
        If stat1 >= 51 And stat1 <= 74 Then resultstat = "16"
        If stat1 >= 75 And stat1 <= 81 Then resultstat = "17"
        If stat1 >= 82 And stat1 <= 88 Then resultstat = "18"
        If stat1 >= 89 And stat1 <= 100 Then resultstat = "19"
        formmcr.cmbaggression.Text = resultstat

        If formmcr.cmbaggression.Text >= 12 And formmcr.cmbaggression.Text <= 16 Then formmcr.cmbaggression.BackColor = Color.White
        If formmcr.cmbaggression.Text = 17 Then formmcr.cmbaggression.BackColor = Color.Yellow
        If formmcr.cmbaggression.Text = 18 Then formmcr.cmbaggression.BackColor = Color.Orange
        If formmcr.cmbaggression.Text = 19 Then formmcr.cmbaggression.BackColor = Color.Red

        'response


        If formmcr.cmbposition.Text = "gk" Then


            stat1 = TextBox41.Text

            If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
            If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
            If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
            If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
            If stat1 >= 51 And stat1 <= 69 Then resultstat = "16"
            If stat1 >= 70 And stat1 <= 78 Then resultstat = "17"
            If stat1 >= 79 And stat1 <= 85 Then resultstat = "18"
            If stat1 >= 86 And stat1 <= 100 Then resultstat = "19"

        Else


            stat1 = TextBox21.Text

            If stat1 >= 0 And stat1 <= 10 Then resultstat = "12"
            If stat1 >= 11 And stat1 <= 20 Then resultstat = "13"
            If stat1 >= 21 And stat1 <= 30 Then resultstat = "14"
            If stat1 >= 31 And stat1 <= 50 Then resultstat = "15"
            If stat1 >= 51 And stat1 <= 73 Then resultstat = "16"
            If stat1 >= 74 And stat1 <= 80 Then resultstat = "17"
            If stat1 >= 81 And stat1 <= 87 Then resultstat = "18"
            If stat1 >= 88 And stat1 <= 100 Then resultstat = "19"
        End If

        formmcr.cmbresponse.Text = resultstat

        If formmcr.cmbresponse.Text >= 12 And formmcr.cmbresponse.Text <= 16 Then formmcr.cmbresponse.BackColor = Color.White
        If formmcr.cmbresponse.Text = 17 Then formmcr.cmbresponse.BackColor = Color.Yellow
        If formmcr.cmbresponse.Text = 18 Then formmcr.cmbresponse.BackColor = Color.Orange
        If formmcr.cmbresponse.Text = 19 Then formmcr.cmbresponse.BackColor = Color.Red

        'outsidee
        stat1 = TextBox8.Text
        If stat1 > 70 Then
            formmcr.cmbfeedoutside.Text = "yes"
        Else
            formmcr.cmbfeedoutside.Text = "no"
        End If

        If formmcr.chekbootsramdon.Checked Then
            Dim numeroAleatorio As New Random()
            Dim valorAleatorio As Integer = numeroAleatorio.Next(0, 8)
            formmcr.cmbboots.SelectedIndex = valorAleatorio
        End If

        'apariencia 
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\tempfotofifa.bmp"
        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        Dim offsetcolorpiel As Integer
        Dim colorpiel As Byte
        Dim lectorhex As String
        Dim bytehex As String

        offsetcolorpiel = 268607
        For m = 0 To 1
            FileGet(3, colorpiel, offsetcolorpiel)
            lectorhex = Hex(colorpiel)
            bytehex = lectorhex + lectorhex
            offsetcolorpiel = offsetcolorpiel + 1

        Next
        'MsgBox(bytehex)
        FileClose()



        'End If


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        WebView21.GoBack()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        WebView21.GoForward()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        WebView21.Reload()
    End Sub

    Private Sub EasyMCRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EasyMCRToolStripMenuItem.Click

        formmcr.Show()

    End Sub

    Private Sub BDWe2002ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BDWe2002ToolStripMenuItem.Click
        formmcr.Hide()


    End Sub

    Private Sub VagEdit2k22ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VagEdit2k22ToolStripMenuItem.Click

        Dim s As String = "\CARP cuac!\WE VagEdit 2K22\VagEdit2k22.exe"
        Dim p As New Process()
        p.StartInfo.FileName = My.Application.Info.DirectoryPath & s
        p.Start()

    End Sub

    Private Sub VagFixToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VagFixToolStripMenuItem.Click
        Dim s As String = "\CARP cuac!\Vag_fix\Vag_fix.exe"
        'Dim p As New Process()
        'p.StartInfo.FileName = My.Application.Info.DirectoryPath & s
        'p.Start()
        Shell("My.Application.Info.DirectoryPath &" & ScriptEngine & "", vbHide)

    End Sub

    Private Sub WeImageManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeImageManagerToolStripMenuItem.Click
        Dim s As String = "\CARP cuac!\WeImageManager\WeImageManager.exe"
        Dim p As New Process()
        p.StartInfo.FileName = My.Application.Info.DirectoryPath & s
        p.Start()
    End Sub

    Private Sub WeextractorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeextractorToolStripMenuItem.Click
        Dim s As String = "\CARP cuac!\WE_Extractor\WE_Extractor.exe"
        Dim p As New Process()
        p.StartInfo.FileName = My.Application.Info.DirectoryPath & s
        p.Start()
    End Sub

    Private Sub WeStadioEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeStadioEditorToolStripMenuItem.Click
        Dim s As String = "\CARP cuac!\WEStadioEditor\WEStadioEditor.exe"
        Dim p As New Process()
        p.StartInfo.FileName = My.Application.Info.DirectoryPath & s
        p.Start()
    End Sub

    Private Sub PES6We2k2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PES6We2k2ToolStripMenuItem.Click
        Dim s As String = "\\zeta\kitsPes6toWE2002\kits we2002 v.2.2.exe"
        Dim p As New Process()
        p.StartInfo.FileName = My.Application.Info.DirectoryPath & s
        p.Start()
    End Sub











    Private Sub rbtonline_CheckedChanged(sender As Object, e As EventArgs) Handles rbtonline.CheckedChanged
        If rbtonline.Checked = True Then rtbnormal.Checked = False

    End Sub

    Private Sub rtbnormal_CheckedChanged(sender As Object, e As EventArgs) Handles rtbnormal.CheckedChanged
        If rtbnormal.Checked = True Then rbtonline.Checked = False

    End Sub



    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ApExcel.Workbooks("players.xlsx").Close(SaveChanges:=False)
    End Sub

    Private Async Sub WebView21_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles WebView21.NavigationCompleted

        Dim sHTML As String = Await WebView21.ExecuteScriptAsync("document.documentElement.outerHTML;")

        sHTML = Regex.Unescape(sHTML)
        sHTML = sHTML.Remove(0, 1)
        sHTML = sHTML.Remove(sHTML.Length - 1, 1)


        RichTextBox1.Text = sHTML

        Dim rutaplayer As String
        Dim rutaplayer2 As String

        rutaplayer = Mid(WebView21.Source.AbsolutePath, 1, 6)
        rutaplayer2 = Mid(WebView21.Source.AbsolutePath, 1, 7)


        '
        rutaplayer = Mid(WebView21.Source.AbsolutePath, 1, 8)
        If rutaplayer = "/player/" Then
            calcmcr()
        End If

    End Sub





    Private Async Sub Stopweb()
        Await Task.Delay(750)
        WebView21.Stop()
        'MsgBox("stop")
        'SendKeys.Send(Keys.Enter)
    End Sub









    Private Sub WebView21_ContentLoading(sender As Object, e As CoreWebView2ContentLoadingEventArgs) Handles WebView21.ContentLoading
        Stopweb()
    End Sub


End Class



Imports System.Text
Imports System.Text.RegularExpressions
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports StatsManagerWe2002
Imports System.Data.Entity.Infrastructure.Design
Imports System.Globalization
Imports System.Numerics
Imports System.Runtime.Loader

Public Class FrmMCR
    Implements IDisposable


    Dim consulta As String

    Dim ord As DataSet
    Dim busca As Byte
    Dim izquierda As Integer
    Dim alto As Integer
    Dim activamovemouse As Integer
    Dim DragIndex As Integer
    Dim DragItem As String
    Dim posicion As String
    Dim idposicion As Integer
    Dim nameplayer As String


    ' Estructura para almacenar los datos
    Private Structure PlayerData
        Public Name As String
        Public ShirtName As String
        Public Nationality As String
        Public Age As Integer
        Public Foot As String
        Public Side As String
        Public Position1 As String
        Public Position2 As String
        Public InjuryTolerance As String
        Public Height As Integer
        Public Weight As String

        ' Variables para stats
        Public Attack As Integer
        Public Defence As Integer
        Public Balance As Integer
        Public Stamina As Integer
        Public TopSpeed As Integer
        Public Acceleration As Integer
        Public Response As Integer
        Public Agility As Integer
        Public DribbleAccuracy As Integer
        Public DribbleSpeed As Integer
        Public ShortPassAccuracy As Integer
        Public ShortPassSpeed As Integer
        Public LongPassAccuracy As Integer
        Public LongPassSpeed As Integer
        Public ShotAccuracy As Integer
        Public ShotPower As Integer
        Public ShotTechnique As Integer
        Public FreeKickAccuracy As Integer
        Public Curling As Integer
        Public Header As Integer
        Public Jump As Integer
        Public Technique As Integer
        Public Aggression As Integer
        Public Mentality As Integer
        Public KeeperSkills As Integer
        Public Teamwork As Integer
        Public Consistency As Integer
        Public ConditionFitness As Integer
        Public WeakFootAccuracy As Integer
        Public WeakFootFrequency As Integer

        ' Habilidad especial
        Public SpecialAbility As String

    End Structure

    Private Sub LeerDesdeRichTextBox()
        Dim player As New PlayerData
        'Diccionario para mapear posiciones
        Dim positionMapping As New Dictionary(Of String, String) From {
            {"GK", "GK"},
            {"CB", "CB"},
            {"CBT", "CB"},
            {"SW", "CB"},
            {"WB", "SB"},
            {"SB", "SB"},
            {"DMF", "DH"},
            {"CMF", "DH"},
            {"SMF", "SH"},
            {"AMF", "OH"},
            {"WF", "WG"},
            {"SS", "CF"},
            {"CF", "CF"}
        }
        ' Divide el texto del RichTextBox en líneas
        Dim lines() As String = RichPes.Lines

        For Each line As String In lines
            If line.Contains(":") Then
                Dim parts() As String = line.Split(":"c)
                Dim key As String = parts(0).Trim()
                Dim value As String = parts(1).Trim()

                ' Asignar valores a las propiedades correspondientes
                Select Case key
                    Case "Name"
                        player.Name = value
                    Case "Shirt Name"
                        player.ShirtName = value
                    Case "Nationality"
                        player.Nationality = value
                    Case "Age"
                        player.Age = Convert.ToInt32(value.Substring(0, 2))
                    Case "Foot"
                        player.Foot = value
                    Case "Side"
                        player.Side = value
                    Case "Positions"
                        ' Divide las posiciones por coma
                        Dim positions() As String = value.Split(","c)
                        player.Position1 = positions(0).Replace("*", "").Trim()
                        If positions.Length > 1 Then
                            player.Position2 = positions(1).Replace("*", "").Trim()
                        End If

                        ' Reemplaza Position1 y Position2 según el diccionario
                        If positionMapping.ContainsKey(player.Position1) Then
                            player.Position1 = positionMapping(player.Position1)
                        End If
                        If Not String.IsNullOrEmpty(player.Position2) AndAlso positionMapping.ContainsKey(player.Position2) Then
                            player.Position2 = positionMapping(player.Position2)
                        End If
                    Case "Injury Tolerance"
                        player.InjuryTolerance = value
                    Case "Height"
                        player.Height = Convert.ToInt32(value.Replace("cm", "").Trim())
                    Case "Weight"
                        player.Weight = (value.Replace("kg", "").Trim())
                    Case "Attack"
                        player.Attack = Convert.ToInt32(value)
                    Case "Defence"
                        player.Defence = Convert.ToInt32(value)
                    Case "Balance"
                        player.Balance = Convert.ToInt32(value)
                    Case "Stamina"
                        player.Stamina = Convert.ToInt32(value)
                    Case "Top Speed"
                        player.TopSpeed = Convert.ToInt32(value)
                    Case "Acceleration"
                        player.Acceleration = Convert.ToInt32(value)
                    Case "Response"
                        player.Response = Convert.ToInt32(value)
                    Case "Agility"
                        player.Agility = Convert.ToInt32(value)
                    Case "Dribble Accuracy"
                        player.DribbleAccuracy = Convert.ToInt32(value)
                    Case "Dribble Speed"
                        player.DribbleSpeed = Convert.ToInt32(value)
                    Case "Short Pass Accuracy"
                        player.ShortPassAccuracy = Convert.ToInt32(value)
                    Case "Short Pass Speed"
                        player.ShortPassSpeed = Convert.ToInt32(value)
                    Case "Long Pass Accuracy"
                        player.LongPassAccuracy = Convert.ToInt32(value)
                    Case "Long Pass Speed"
                        player.LongPassSpeed = Convert.ToInt32(value)
                    Case "Shot Accuracy"
                        player.ShotAccuracy = Convert.ToInt32(value)
                    Case "Shot Power"
                        player.ShotPower = Convert.ToInt32(value)
                    Case "Shot Technique"
                        player.ShotTechnique = Convert.ToInt32(value)
                    Case "Free Kick Accuracy"
                        player.FreeKickAccuracy = Convert.ToInt32(value)
                    Case "Curling"
                        player.Curling = Convert.ToInt32(value)
                    Case "Header"
                        player.Header = Convert.ToInt32(value)
                    Case "Jump"
                        player.Jump = Convert.ToInt32(value)
                    Case "Technique"
                        player.Technique = Convert.ToInt32(value)
                    Case "Aggression"
                        player.Aggression = Convert.ToInt32(value)
                    Case "Mentality"
                        player.Mentality = Convert.ToInt32(value)
                    Case "Keeper Skills"
                        player.KeeperSkills = Convert.ToInt32(value)
                    Case "Teamwork"
                        player.Teamwork = Convert.ToInt32(value)
                    Case "Consistency"
                        player.Consistency = Convert.ToInt32(value)
                    Case "Condition/Fitness"
                        player.ConditionFitness = Convert.ToInt32(value)
                    Case "Weak Foot Accuracy"
                        player.WeakFootAccuracy = Convert.ToInt32(value)
                    Case "Weak Foot Frequency"
                        player.WeakFootFrequency = Convert.ToInt32(value)
                End Select
            ElseIf line.StartsWith("*") Then
                ' Procesa las habilidades especiales
                Dim ability As String = line.TrimStart("*"c).Trim()
                If ability = "Outside" Then
                    player.SpecialAbility = ability
                End If
            End If
        Next

        'convert we2002
        'name
        nameplayer = player.Name
        ProcessPlayerName2()

        'age
        cmbage.Text = player.Age

        'position
        Dim position2 As String = player.Position2
        cmbposition.Text = player.Position1
        If position2 <> "" Then
            BTN_BESTPOSITION.Text = player.Position2
        Else
            BTN_BESTPOSITION.Text = ""
        End If


        'heigth
        cmbheigth.Text = player.Height

        'weight
        ' Declaración de variables
        Dim stat2 As Integer = player.Height
        Dim stat3 As Integer
        If player.Weight = "NaN" Then
            stat3 = 75
        Else
            stat3 = player.Weight ' Peso del jugador
        End If

        Dim calcheigthfix As Double = 0
        Dim calcbody As Integer = 0
        Dim body As String = ""

        ' Calcular calcheigthfix basado en el rango de stat2
        If stat2 >= 150 AndAlso stat2 <= 165 Then
            calcheigthfix = 1.4
        ElseIf stat2 >= 166 AndAlso stat2 <= 170 Then
            calcheigthfix = 1.25
        ElseIf stat2 >= 171 AndAlso stat2 <= 175 Then
            calcheigthfix = 1.1
        ElseIf stat2 >= 176 AndAlso stat2 <= 180 Then
            calcheigthfix = 0.95
        ElseIf stat2 >= 181 AndAlso stat2 <= 185 Then
            calcheigthfix = 0.93
        ElseIf stat2 >= 186 AndAlso stat2 <= 190 Then
            calcheigthfix = 0.91
        ElseIf stat2 >= 191 AndAlso stat2 <= 195 Then
            calcheigthfix = 0.89
        ElseIf stat2 >= 196 AndAlso stat2 <= 200 Then
            calcheigthfix = 0.87
        ElseIf stat2 >= 201 AndAlso stat2 <= 220 Then
            calcheigthfix = 0.85
        End If

        ' Calcular calcbody
        calcbody = calcheigthfix * stat3

        ' Asignar player.wight basado en el rango de calcbody
        If calcbody >= 50 AndAlso calcbody <= 64 Then
            body = "a"
        ElseIf calcbody >= 65 AndAlso calcbody <= 69 Then
            body = "b"
        ElseIf calcbody >= 70 AndAlso calcbody <= 74 Then
            body = "c"
        ElseIf calcbody >= 75 AndAlso calcbody <= 79 Then
            body = "d"
        ElseIf calcbody >= 80 AndAlso calcbody <= 84 Then
            body = "e"
        ElseIf calcbody >= 85 AndAlso calcbody <= 89 Then
            body = "f"
        ElseIf calcbody >= 90 AndAlso calcbody <= 94 Then
            body = "g"
        ElseIf calcbody >= 95 AndAlso calcbody <= 110 Then
            body = "h"
        End If

        cmbbody.Text = body

        'bota aleatorias
        Dim numeroAleatorio As New Random()
        Dim valorAleatorio As Integer = numeroAleatorio.Next(0, 8)
        cmbboots.SelectedIndex = valorAleatorio

        'offense
        stat1 = player.Attack
        LeerRangoPlayer()
        cmboffense.Text = resultstat

        'deffense
        stat1 = player.Defence
        LeerRangoPlayer()
        cmbdeffense.Text = resultstat

        'body balance
        stat1 = player.Balance
        LeerRangoPlayer()
        cmbbodybalance.Text = resultstat

        'stamina
        stat1 = player.Stamina
        LeerRangoPlayer()
        cmbstamina.Text = resultstat

        'speed
        stat1 = player.TopSpeed
        If Form1.rbtonline.Checked = True Then
            LeerSpeed_accOnline()
        Else
            LeerRangoPlayer()
        End If

        cmbspeed.Text = resultstat

        'acceleration
        stat1 = player.Acceleration
        LeerRangoPlayer()
        cmbaceleration.Text = resultstat

        'Pass acc
        stat2 = player.ShortPassAccuracy
        stat3 = player.LongPassAccuracy
        stat1 = (stat2 + stat3) / 2
        LeerRangoPlayer()
        cmbpass.Text = resultstat

        'shotpower
        stat1 = player.ShotPower
        LeerRangoPlayer()
        cmbshotpower.Text = resultstat

        'shotacc
        stat1 = player.ShotAccuracy
        LeerRangoPlayer()
        cmbshotacc.Text = resultstat

        'jump
        stat1 = player.Jump
        LeerRangoPlayer()
        cmbjump.Text = resultstat

        'head
        stat1 = player.Header
        LeerRangoPlayer()
        cmbhead.Text = resultstat

        'techniq
        stat1 = player.Technique
        LeerRangoPlayer()
        cmbtechnique.Text = resultstat

        'dribble
        stat2 = player.DribbleAccuracy
        stat3 = player.DribbleSpeed
        stat1 = (stat2 + stat3) / 2
        LeerRangoPlayer()
        cmbdribble.Text = resultstat

        'curve
        stat1 = player.Curling
        LeerRangoPlayer()
        cmbcurve.Text = resultstat

        'aggresion
        stat1 = player.Aggression
        LeerRangoPlayer()
        cmbaggression.Text = resultstat

        'response
        stat1 = player.Response
        LeerRangoPlayer()
        cmbresponse.Text = resultstat

        'outside

        If player.SpecialAbility = "Outside" Then
            cmbfeedoutside.Text = "yes"
        Else
            cmbfeedoutside.Text = "no"
        End If

        'foot
        stat1 = player.WeakFootAccuracy
        Dim foot As String = player.Foot
        If stat1 > 6 Then
            If foot = "L" Then
                cmbfood.Text = "L"
            Else
                cmbfood.Text = "B"
            End If
        Else
            cmbfood.Text = foot
        End If



    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        total = total - 1

        FileCopy(My.Application.Info.DirectoryPath & "\mc.dat", My.Application.Info.DirectoryPath & "\database.mcr")
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog1.FileName = My.Application.Info.DirectoryPath & "\database.mcr"



        FileClose(1)


        cargar()
        LeerYActualizarColores()

        cmbhair.DropDownStyle = ComboBoxStyle.DropDownList
        cmbhaircolor.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbaceleration.DropDownStyle = ComboBoxStyle.DropDownList
        cmbage.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbaggression.DropDownStyle = ComboBoxStyle.DropDownList
        cmbbody.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbbodybalance.DropDownStyle = ComboBoxStyle.DropDownList
        cmbboots.DropDownStyle = ComboBoxStyle.DropDownList
        cmbclubnumber.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbcredits.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbcurve.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbdeffense.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbdribble.DropDownStyle = ComboBoxStyle.DropDownList
        cmbfeedoutside.DropDownStyle = ComboBoxStyle.DropDownList
        cmbfood.DropDownStyle = ComboBoxStyle.DropDownList
        cmbhaircolorface.DropDownStyle = ComboBoxStyle.DropDownList
        cmbhairface.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbhead.DropDownStyle = ComboBoxStyle.DropDownList
        cmbheigth.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbjump.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbnationnumber.DropDownStyle = ComboBoxStyle.DropDownList
        'cmboffense.DropDownStyle = 2
        'cmbpass.DropDownStyle = ComboBoxStyle.DropDownList
        cmbposition.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbresponse.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbshotacc.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbshotpower.DropDownStyle = ComboBoxStyle.DropDownList
        cmbskincolor.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbspeed.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbstamina.DropDownStyle = ComboBoxStyle.DropDownList
        'cmbtechnique.DropDownStyle = ComboBoxStyle.DropDownList




        ' Establecer posiciones y colores de los jugadores
        formmcr.lblposiplayer1.Text = "GK"
        formmcr.lblposiplayer1.BackColor = Color.DarkGoldenrod

        'SetPlayerPositionAndColor(formformation.cbplayer1.Text, formmcr.lblposiplayer2)
        'SetPlayerPositionAndColor(formformation.CbPlayer2.Text, formmcr.lblposiplayer3)
        'SetPlayerPositionAndColor(formformation.CbPlayer3.Text, formmcr.lblposiplayer4)
        'SetPlayerPositionAndColor(formformation.CbPlayer4.Text, formmcr.lblposiplayer5)
        'SetPlayerPositionAndColor(formformation.CbPlayer5.Text, formmcr.lblposiplayer6)
        'SetPlayerPositionAndColor(formformation.CbPlayer6.Text, formmcr.lblposiplayer7)
        'SetPlayerPositionAndColor(formformation.CbPlayer7.Text, formmcr.lblposiplayer8)
        'SetPlayerPositionAndColor(formformation.CbPlayer8.Text, formmcr.lblposiplayer9)
        'SetPlayerPositionAndColor(formformation.CbPlayer9.Text, formmcr.lblposiplayer10)
        'SetPlayerPositionAndColor(formformation.CbPlayer10.Text, formmcr.lblposiplayer11)

    End Sub
    Private Sub SetPlayerPositionAndColor(positionText As String, label As Label)

        label.Text = positionText

        ' Estilo general moderno
        label.ForeColor = Color.White
        label.BorderStyle = BorderStyle.None

        Select Case positionText

        ' =========================
        ' PORTERO
        ' =========================
            Case "GK"
                label.BackColor = Color.FromArgb(185, 140, 40) ' dorado oscuro

        ' =========================
        ' DEFENSAS
        ' =========================
            Case "CB-L", "CB-C", "CB-R", "SW", "LIB"
                label.BackColor = Color.FromArgb(45, 120, 220) ' azul

            Case "LB", "RB", "LWB", "RWB"
                label.BackColor = Color.FromArgb(0, 140, 200) ' azul claro

        ' =========================
        ' MEDIOCAMPO DEFENSIVO
        ' =========================
            Case "DH-L", "DH-C", "DH-R", "DMF"
                label.BackColor = Color.FromArgb(70, 140, 70) ' verde oscuro

        ' =========================
        ' MEDIOCAMPO OFENSIVO
        ' =========================
            Case "LH", "RH", "OH-L", "OH-C", "OH-R"
                label.BackColor = Color.FromArgb(80, 170, 90) ' verde claro

            Case "CMF", "AMF"
                label.BackColor = Color.FromArgb(60, 160, 120)

        ' =========================
        ' EXTREMOS
        ' =========================
            Case "LW", "RW", "LWF", "RWF"
                label.BackColor = Color.FromArgb(210, 70, 70) ' rojo moderno

        ' =========================
        ' DELANTEROS
        ' =========================
            Case "CF-L", "CF-C", "CF-R", "CF", "SS"
                label.BackColor = Color.FromArgb(190, 50, 50) ' rojo oscuro

                ' =========================
                ' DEFAULT
                ' =========================
            Case Else
                label.BackColor = Color.FromArgb(55, 55, 55)

        End Select

    End Sub

    Private Sub IDPosiciones()
        If idposicion = 0 Then posicion = "[GK]"
        If idposicion = 1 Then posicion = "[CB]"
        If idposicion = 2 Then posicion = "[SB]"
        If idposicion = 3 Then posicion = "[DH]"
        If idposicion = 4 Then posicion = "[SH]"
        If idposicion = 5 Then posicion = "[OH]"
        If idposicion = 6 Then posicion = "[CF]"
        If idposicion = 7 Then posicion = "[WF]"
    End Sub

    Public Sub GrabarNationNumbers()
        Dim bytenum(bufersizenum - 1) As Byte
        Dim binaryStringBuilder As New System.Text.StringBuilder()
        Dim count As Integer = 0

        ' Limpiar el StringBuilder antes de usarlo
        binaryStringBuilder.Clear()

        ' Procesar los números de numberPlayer en bloques de 6
        While count < numberPlayer.Length
            binaryStringBuilder.Clear()

            ' Construir un bloque de 6 números (30 bits)
            For i As Integer = 0 To 5
                If count < numberPlayer.Length Then
                    ' Convertir el número a binario de 5 bits
                    Dim binValue As String = Convert.ToString(numberPlayer(count), 2).PadLeft(5, "0"c)

                    ' Concatenar de derecha a izquierda
                    binaryStringBuilder.Insert(0, binValue)
                    count += 1
                End If
            Next

            ' Convertir la cadena binaria completa a un arreglo de bytes
            Dim binaryString As String = binaryStringBuilder.ToString()
            Dim bitArray As New List(Of Byte)

            ' Dividir la cadena binaria en fragmentos de 8 bits de derecha a izquierda
            For i As Integer = binaryString.Length To 1 Step -8
                ' Tomar un bloque de 8 bits desde el final hacia el inicio
                Dim chunkStart As Integer = Math.Max(0, i - 8) ' Asegurar que no sea menor a 0
                Dim chunk As String = binaryString.Substring(chunkStart, i - chunkStart)

                ' Convertir el bloque a byte
                bitArray.Add(Convert.ToByte(chunk, 2))
            Next

            ' Convertir la lista de bytes a un arreglo
            bytenum = bitArray.ToArray()

            ' Escribir el bloque en el archivo binario
            FilePut(1, bytenum, offsetnum + 1)

            ' Incrementar el desplazamiento (4 bytes por bloque)
            offsetnum += 4
        End While
    End Sub


    Public Sub cargar()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        ' Arreglos para cargar las posiciones de los jugadores
        Dim playerPics() As PictureBox = {PicP1, PicP2, PicP3, PicP4, PicP5, PicP6, PicP7, PicP8, PicP9, PicP10}
        Dim playerLabels() As Label = {lblPic1, lblPic2, lblpic3, lblPic4, lblPic5, lblPic6, lblPic7, lblPic8, LblPic9, lblPic10}
        Dim playerCombos() As ComboBox = {cbplayer1, CbPlayer2, CbPlayer3, CbPlayer4, CbPlayer5, CbPlayer6, CbPlayer7, CbPlayer8, CbPlayer9, CbPlayer10}

        ' Leer las posiciones X e Y de los jugadores
        Dim offsetBaseX As Integer = 25256
        Dim offsetBaseY As Integer = 25266


        For i As Integer = 0 To playerPics.Length - 1
            ' Leer posición X
            offset1 = offsetBaseX + i
            Dim playerX As Byte
            FileGet(1, playerX, offset1 + 1)
            playerPics(i).Location = New Point(playerX * 7, playerPics(i).Location.Y)
            playerLabels(i).Location = New Point(playerX * 7, playerPics(i).Location.Y + (6 * 2)) ' Posicionar el Label debajo del PictureBox

            ' Leer posición Y
            offset1 = offsetBaseY + i
            Dim playerY As Byte
            FileGet(1, playerY, offset1 + 1)
            playerPics(i).Location = New Point(playerPics(i).Location.X, playerY * 2)
            playerLabels(i).Location = New Point(playerLabels(i).Location.X, playerY * 2 + (6 * 2)) ' Ajustar posición Y del Label también
        Next

        ' Leer las selecciones de los ComboBox
        Dim offsetComboBase As Integer = 25557

        For i As Integer = 0 To playerCombos.Length - 1
            offset1 = offsetComboBase + i
            Dim posPlayerCancha As Byte
            FileGet(1, posPlayerCancha, offset1 + 1)
            playerCombos(i).SelectedIndex = posPlayerCancha - 2
        Next

        lblposiplayer1.Text = "GK"
        lblposiplayer1.BackColor = Color.DarkGoldenrod

        SetPlayerPositionAndColor(cbplayer1.Text, lblposiplayer2)
        SetPlayerPositionAndColor(CbPlayer2.Text, lblposiplayer3)
        SetPlayerPositionAndColor(CbPlayer3.Text, lblposiplayer4)
        SetPlayerPositionAndColor(CbPlayer4.Text, lblposiplayer5)
        SetPlayerPositionAndColor(CbPlayer5.Text, lblposiplayer6)
        SetPlayerPositionAndColor(CbPlayer6.Text, lblposiplayer7)
        SetPlayerPositionAndColor(CbPlayer7.Text, lblposiplayer8)
        SetPlayerPositionAndColor(CbPlayer8.Text, lblposiplayer9)
        SetPlayerPositionAndColor(CbPlayer9.Text, lblposiplayer10)
        SetPlayerPositionAndColor(CbPlayer10.Text, lblposiplayer11)

        FileClose(1) ' Cerrar el archivo después de leer
    End Sub

    Private Sub PicP1_MouseMove(sender As Object, e As MouseEventArgs) Handles PicP1.MouseMove
        If PicP1.Cursor = Cursors.SizeAll Then
            PicP1.Location = New Point(PicP1.Left + e.X - izquierda, PicP1.Top + e.Y - alto)
            lblPic1.Location = New Point(lblPic1.Left + e.X - izquierda, lblPic1.Top + e.Y - alto)
        End If
    End Sub

    Private Sub PicP1_MouseDown(sender As Object, e As MouseEventArgs) Handles PicP1.MouseDown
        izquierda = e.X
        alto = e.Y
        PicP1.Cursor = Cursors.SizeAll

    End Sub

    Private Sub PicP1_MouseUp(sender As Object, e As MouseEventArgs) Handles PicP1.MouseUp
        PicP1.Cursor = Cursors.Default
    End Sub

    '
    Private Sub PicP2_MouseMove(sender As Object, e As MouseEventArgs) Handles PicP2.MouseMove
        If PicP2.Cursor = Cursors.SizeAll Then
            PicP2.Location = New Point(PicP2.Left + e.X - izquierda, PicP2.Top + e.Y - alto)
            Dim ejexpic2 As Integer = (PicP2.Left + e.X) / 8
            Dim ejeypic2 As Integer = (PicP2.Top + e.Y) / 2
            lblPic2.Location = New Point(lblPic2.Left + e.X - izquierda, lblPic2.Top + e.Y - alto)
            lblx.Text = ejexpic2
            lbly.Text = ejeypic2
        End If
    End Sub

    Private Sub PicP2_MouseDown(sender As Object, e As MouseEventArgs) Handles PicP2.MouseDown
        izquierda = e.X
        alto = e.Y
        PicP2.Cursor = Cursors.SizeAll
    End Sub

    Private Sub PicP2_MouseUp(sender As Object, e As MouseEventArgs) Handles PicP2.MouseUp
        PicP2.Cursor = Cursors.Default
    End Sub
    '
    Private Sub PicP3_MouseMove(sender As Object, e As MouseEventArgs) Handles PicP3.MouseMove
        If PicP3.Cursor = Cursors.SizeAll Then
            PicP3.Location = New Point(PicP3.Left + e.X - izquierda, PicP3.Top + e.Y - alto)
            lblpic3.Location = New Point(lblpic3.Left + e.X - izquierda, lblpic3.Top + e.Y - alto)
        End If
    End Sub

    Private Sub PicP3_MouseDown(sender As Object, e As MouseEventArgs) Handles PicP3.MouseDown
        izquierda = e.X
        alto = e.Y
        PicP3.Cursor = Cursors.SizeAll
    End Sub

    Private Sub PicP3_MouseUp(sender As Object, e As MouseEventArgs) Handles PicP3.MouseUp
        PicP3.Cursor = Cursors.Default
    End Sub

    '
    Private Sub PicP4_MouseMove(sender As Object, e As MouseEventArgs) Handles PicP4.MouseMove
        If PicP4.Cursor = Cursors.SizeAll Then
            PicP4.Location = New Point(PicP4.Left + e.X - izquierda, PicP4.Top + e.Y - alto)
            lblPic4.Location = New Point(lblPic4.Left + e.X - izquierda, lblPic4.Top + e.Y - alto)
        End If
    End Sub

    Private Sub PicP4_MouseDown(sender As Object, e As MouseEventArgs) Handles PicP4.MouseDown
        izquierda = e.X
        alto = e.Y
        PicP4.Cursor = Cursors.SizeAll
    End Sub

    Private Sub PicP4_MouseUp(sender As Object, e As MouseEventArgs) Handles PicP4.MouseUp
        PicP4.Cursor = Cursors.Default
    End Sub

    '
    Private Sub PicP5_MouseMove(sender As Object, e As MouseEventArgs) Handles PicP5.MouseMove
        If PicP5.Cursor = Cursors.SizeAll Then
            PicP5.Location = New Point(PicP5.Left + e.X - izquierda, PicP5.Top + e.Y - alto)
            lblPic5.Location = New Point(lblPic5.Left + e.X - izquierda, lblPic5.Top + e.Y - alto)
        End If
    End Sub

    Private Sub PicP5_MouseDown(sender As Object, e As MouseEventArgs) Handles PicP5.MouseDown
        izquierda = e.X
        alto = e.Y
        PicP5.Cursor = Cursors.SizeAll
    End Sub

    Private Sub PicP5_MouseUp(sender As Object, e As MouseEventArgs) Handles PicP5.MouseUp
        PicP5.Cursor = Cursors.Default
    End Sub

    '
    Private Sub PicP6_MouseMove(sender As Object, e As MouseEventArgs) Handles PicP6.MouseMove
        If PicP6.Cursor = Cursors.SizeAll Then
            PicP6.Location = New Point(PicP6.Left + e.X - izquierda, PicP6.Top + e.Y - alto)
            lblPic6.Location = New Point(lblPic6.Left + e.X - izquierda, lblPic6.Top + e.Y - alto)
        End If
    End Sub

    Private Sub PicP6_MouseDown(sender As Object, e As MouseEventArgs) Handles PicP6.MouseDown
        izquierda = e.X
        alto = e.Y
        PicP6.Cursor = Cursors.SizeAll
    End Sub

    Private Sub PicP6_MouseUp(sender As Object, e As MouseEventArgs) Handles PicP6.MouseUp
        PicP6.Cursor = Cursors.Default
    End Sub
    '
    Private Sub PicP7_MouseMove(sender As Object, e As MouseEventArgs) Handles PicP7.MouseMove
        If PicP7.Cursor = Cursors.SizeAll Then
            PicP7.Location = New Point(PicP7.Left + e.X - izquierda, PicP7.Top + e.Y - alto)
            lblPic7.Location = New Point(lblPic7.Left + e.X - izquierda, lblPic7.Top + e.Y - alto)
        End If
    End Sub

    Private Sub PicP7_MouseDown(sender As Object, e As MouseEventArgs) Handles PicP7.MouseDown
        izquierda = e.X
        alto = e.Y
        PicP7.Cursor = Cursors.SizeAll
    End Sub

    Private Sub PicP7_MouseUp(sender As Object, e As MouseEventArgs) Handles PicP7.MouseUp
        PicP7.Cursor = Cursors.Default
    End Sub
    '
    Private Sub PicP8_MouseMove(sender As Object, e As MouseEventArgs) Handles PicP8.MouseMove
        If PicP8.Cursor = Cursors.SizeAll Then
            PicP8.Location = New Point(PicP8.Left + e.X - izquierda, PicP8.Top + e.Y - alto)
            lblPic8.Location = New Point(lblPic8.Left + e.X - izquierda, lblPic8.Top + e.Y - alto)
        End If
    End Sub

    Private Sub PicP8_MouseDown(sender As Object, e As MouseEventArgs) Handles PicP8.MouseDown
        izquierda = e.X
        alto = e.Y
        PicP8.Cursor = Cursors.SizeAll
    End Sub

    Private Sub PicP8_MouseUp(sender As Object, e As MouseEventArgs) Handles PicP8.MouseUp
        PicP8.Cursor = Cursors.Default
    End Sub
    '
    Private Sub PicP9_MouseMove(sender As Object, e As MouseEventArgs) Handles PicP9.MouseMove
        If PicP9.Cursor = Cursors.SizeAll Then
            PicP9.Location = New Point(PicP9.Left + e.X - izquierda, PicP9.Top + e.Y - alto)
            LblPic9.Location = New Point(LblPic9.Left + e.X - izquierda, LblPic9.Top + e.Y - alto)
        End If
    End Sub

    Private Sub PicP9_MouseDown(sender As Object, e As MouseEventArgs) Handles PicP9.MouseDown
        izquierda = e.X
        alto = e.Y
        PicP9.Cursor = Cursors.SizeAll
    End Sub

    Private Sub PicP9_MouseUp(sender As Object, e As MouseEventArgs) Handles PicP9.MouseUp
        PicP9.Cursor = Cursors.Default
    End Sub
    '
    Private Sub PicP10_MouseMove(sender As Object, e As MouseEventArgs) Handles PicP10.MouseMove
        If PicP10.Cursor = Cursors.SizeAll Then
            PicP10.Location = New Point(PicP10.Left + e.X - izquierda, PicP10.Top + e.Y - alto)
            lblPic10.Location = New Point(lblPic10.Left + e.X - izquierda, lblPic10.Top + e.Y - alto)
        End If
    End Sub

    Private Sub PicP10_MouseDown(sender As Object, e As MouseEventArgs) Handles PicP10.MouseDown
        izquierda = e.X
        alto = e.Y
        PicP10.Cursor = Cursors.SizeAll
    End Sub

    Private Sub PicP10_MouseUp(sender As Object, e As MouseEventArgs) Handles PicP10.MouseUp
        PicP10.Cursor = Cursors.Default
    End Sub

    Private Sub EscribirValoresC(nuevoValorC As Byte)
        ' Abre el archivo en modo de escritura
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.Write)

        Dim offset1 As Integer = 25857 ' Offset para el primer valor


        ' Escribir los nuevos valores en el archivo
        FilePut(1, nuevoValorC, offset1) ' Escribe en el offset1


        ' Cierra el archivo después de escribir
        FileClose(1)

        ' Llama a la función para leer y actualizar los colores
        LeerYActualizarColores()
    End Sub
    Private Sub EscribirValoresPK(nuevoValorPK As Byte)
        ' Abre el archivo en modo de escritura
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.Write)

        Dim offset1 As Integer = 24882 ' Offset para el primer valor


        ' Escribir los nuevos valores en el archivo
        FilePut(1, nuevoValorPK, offset1) ' Escribe en el offset1


        ' Cierra el archivo después de escribir
        FileClose(1)

        ' Llama a la función para leer y actualizar los colores
        LeerYActualizarColores()
    End Sub
    Private Sub EscribirValoresLC(nuevoValorLC As Byte)
        ' Abre el archivo en modo de escritura
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.Write)

        Dim offset1 As Integer = 24852 ' Offset para el primer valor


        ' Escribir los nuevos valores en el archivo
        FilePut(1, nuevoValorLC, offset1) ' Escribe en el offset1


        ' Cierra el archivo después de escribir
        FileClose(1)

        ' Llama a la función para leer y actualizar los colores
        LeerYActualizarColores()
    End Sub

    Private Sub EscribirValoresRC(nuevoValorRC As Byte)
        ' Abre el archivo en modo de escritura
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.Write)

        Dim offset1 As Integer = 24867 ' Offset para el primer valor


        ' Escribir los nuevos valores en el archivo
        FilePut(1, nuevoValorRC, offset1) ' Escribe en el offset1


        ' Cierra el archivo después de escribir
        FileClose(1)

        ' Llama a la función para leer y actualizar los colores
        LeerYActualizarColores()
    End Sub
    Private Sub EscribirValores(nuevoValorSF As Byte)
        ' Abre el archivo en modo de escritura
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.Write)

        Dim offset1 As Integer = 24912 ' Offset para el primer valor


        ' Escribir los nuevos valores en el archivo
        FilePut(1, nuevoValorSF, offset1) ' Escribe en el offset1


        ' Cierra el archivo después de escribir
        FileClose(1)

        ' Llama a la función para leer y actualizar los colores
        LeerYActualizarColores()
    End Sub
    Private Sub EscribirValoresLF(nuevoValorLF As Byte)
        ' Abre el archivo en modo de escritura
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.Write)

        Dim offset1 As Integer = 24897 ' Offset para el primer valor


        ' Escribir los nuevos valores en el archivo
        FilePut(1, nuevoValorLF, offset1) ' Escribe en el offset1


        ' Cierra el archivo después de escribir
        FileClose(1)

        ' Llama a la función para leer y actualizar los colores
        LeerYActualizarColores()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim nuevoValorSF As Byte = 0
        EscribirValores(nuevoValorSF)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim nuevoValorSF As Byte = 1
        EscribirValores(nuevoValorSF)


    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim nuevoValorSF As Byte = 2
        EscribirValores(nuevoValorSF)

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim nuevoValorSF As Byte = 3
        EscribirValores(nuevoValorSF)

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim nuevoValorSF As Byte = 7
        EscribirValores(nuevoValorSF)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim nuevoValorSF As Byte = 6
        EscribirValores(nuevoValorSF)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim nuevoValorSF As Byte = 5
        EscribirValores(nuevoValorSF)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim nuevoValorSF As Byte = 4
        EscribirValores(nuevoValorSF)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim nuevoValorlF As Byte = 10
        EscribirValoresLF(nuevoValorlF)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim nuevoValorSF As Byte = 10
        EscribirValores(nuevoValorSF)
    End Sub
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim nuevoValorSF As Byte = 9
        EscribirValores(nuevoValorSF)
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Dim nuevoValorlF As Byte = 1
        EscribirValoresLF(nuevoValorlF)


    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Dim nuevoValorlF As Byte = 2
        EscribirValoresLF(nuevoValorlF)


    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Dim nuevoValorlF As Byte = 3
        EscribirValoresLF(nuevoValorlF)

    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim nuevoValorlF As Byte = 4
        EscribirValoresLF(nuevoValorlF)
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim nuevoValorlF As Byte = 5
        EscribirValoresLF(nuevoValorlF)
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim nuevoValorlF As Byte = 6
        EscribirValoresLF(nuevoValorlF)
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim nuevoValorlF As Byte = 7
        EscribirValoresLF(nuevoValorlF)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim nuevoValorlF As Byte = 8
        EscribirValoresLF(nuevoValorlF)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim nuevoValorlF As Byte = 9
        EscribirValoresLF(nuevoValorlF)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim nuevoValorSF As Byte = 8
        EscribirValores(nuevoValorSF)
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Dim nuevoValorRC As Byte = 0
        EscribirValoresRC(nuevoValorRC)

    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Dim nuevoValorRC As Byte = 1
        EscribirValoresRC(nuevoValorRC)
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Dim nuevoValorRC As Byte = 2
        EscribirValoresRC(nuevoValorRC)
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Dim nuevoValorRC As Byte = 3
        EscribirValoresRC(nuevoValorRC)
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Dim nuevoValorRC As Byte = 4
        EscribirValoresRC(nuevoValorRC)
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Dim nuevoValorRC As Byte = 5
        EscribirValoresRC(nuevoValorRC)
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        Dim nuevoValorRC As Byte = 6
        EscribirValoresRC(nuevoValorRC)
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Dim nuevoValorRC As Byte = 7
        EscribirValoresRC(nuevoValorRC)
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Dim nuevoValorRC As Byte = 8
        EscribirValoresRC(nuevoValorRC)
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        Dim nuevoValorRC As Byte = 9
        EscribirValoresRC(nuevoValorRC)
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Dim nuevoValorRC As Byte = 10
        EscribirValoresRC(nuevoValorRC)
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        Dim nuevoValorLC As Byte = 0
        EscribirValoresLC(nuevoValorLC)
    End Sub


    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        Dim nuevoValorLC As Byte = 1
        EscribirValoresLC(nuevoValorLC)
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        Dim nuevoValorLC As Byte = 2
        EscribirValoresLC(nuevoValorLC)
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        Dim nuevoValorLC As Byte = 3
        EscribirValoresLC(nuevoValorLC)
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        Dim nuevoValorLC As Byte = 4
        EscribirValoresLC(nuevoValorLC)
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        Dim nuevoValorLC As Byte = 5
        EscribirValoresLC(nuevoValorLC)
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        Dim nuevoValorLC As Byte = 6
        EscribirValoresLC(nuevoValorLC)
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        Dim nuevoValorLC As Byte = 7
        EscribirValoresLC(nuevoValorLC)
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        Dim nuevoValorLC As Byte = 8
        EscribirValoresLC(nuevoValorLC)
    End Sub


    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        Dim nuevoValorLC As Byte = 9
        EscribirValoresLC(nuevoValorLC)
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        Dim nuevoValorLC As Byte = 10
        EscribirValoresLC(nuevoValorLC)
    End Sub

    Private Sub Button70_Click(sender As Object, e As EventArgs) Handles Button70.Click
        Dim nuevoValorPK As Byte = 0
        EscribirValoresPK(nuevoValorPK)
    End Sub

    Private Sub Button69_Click(sender As Object, e As EventArgs) Handles Button69.Click
        Dim nuevoValorPK As Byte = 1
        EscribirValoresPK(nuevoValorPK)
    End Sub

    Private Sub Button68_Click(sender As Object, e As EventArgs) Handles Button68.Click
        Dim nuevoValorPK As Byte = 2
        EscribirValoresPK(nuevoValorPK)
    End Sub

    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click
        Dim nuevoValorPK As Byte = 3
        EscribirValoresPK(nuevoValorPK)
    End Sub

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click
        Dim nuevoValorPK As Byte = 4
        EscribirValoresPK(nuevoValorPK)
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        Dim nuevoValorPK As Byte = 5
        EscribirValoresPK(nuevoValorPK)
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        Dim nuevoValorPK As Byte = 6
        EscribirValoresPK(nuevoValorPK)
    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        Dim nuevoValorPK As Byte = 7
        EscribirValoresPK(nuevoValorPK)
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        Dim nuevoValorPK As Byte = 8
        EscribirValoresPK(nuevoValorPK)
    End Sub
    Private Sub Button37_Click_1(sender As Object, e As EventArgs) Handles Button37.Click
        Dim nuevoValorlF As Byte = 0
        EscribirValoresLF(nuevoValorlF)
    End Sub
    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        Dim nuevoValorPK As Byte = 9
        EscribirValoresPK(nuevoValorPK)
    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        Dim nuevoValorPK As Byte = 10
        EscribirValoresPK(nuevoValorPK)
    End Sub

    Private Sub Button81_Click(sender As Object, e As EventArgs) Handles Button81.Click
        Dim nuevoValorC As Byte = 0
        EscribirValoresC(nuevoValorC)
    End Sub

    Private Sub Button80_Click(sender As Object, e As EventArgs) Handles Button80.Click
        Dim nuevoValorC As Byte = 1
        EscribirValoresC(nuevoValorC)
    End Sub

    Private Sub Button79_Click(sender As Object, e As EventArgs) Handles Button79.Click
        Dim nuevoValorC As Byte = 2
        EscribirValoresC(nuevoValorC)
    End Sub

    Private Sub Button78_Click(sender As Object, e As EventArgs) Handles Button78.Click
        Dim nuevoValorC As Byte = 3
        EscribirValoresC(nuevoValorC)
    End Sub

    Private Sub Button77_Click(sender As Object, e As EventArgs) Handles Button77.Click
        Dim nuevoValorC As Byte = 4
        EscribirValoresC(nuevoValorC)
    End Sub

    Private Sub Button76_Click(sender As Object, e As EventArgs) Handles Button76.Click
        Dim nuevoValorC As Byte = 5
        EscribirValoresC(nuevoValorC)
    End Sub

    Private Sub Button75_Click(sender As Object, e As EventArgs) Handles Button75.Click
        Dim nuevoValorC As Byte = 6
        EscribirValoresC(nuevoValorC)
    End Sub

    Private Sub Button74_Click(sender As Object, e As EventArgs) Handles Button74.Click
        Dim nuevoValorC As Byte = 7
        EscribirValoresC(nuevoValorC)
    End Sub

    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles Button73.Click
        Dim nuevoValorC As Byte = 8
        EscribirValoresC(nuevoValorC)
    End Sub

    Private Sub Button72_Click(sender As Object, e As EventArgs) Handles Button72.Click
        Dim nuevoValorC As Byte = 9
        EscribirValoresC(nuevoValorC)
    End Sub

    Private Sub Button71_Click(sender As Object, e As EventArgs) Handles Button71.Click
        Dim nuevoValorC As Byte = 10
        EscribirValoresC(nuevoValorC)
    End Sub

    Private Sub LstFormation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstFormation.SelectedIndexChanged
        'STOCK
        If LstFormation.SelectedItem = "Stock" Then
            PicP1.Left = 11 * 7
            PicP1.Top = 41 * 2
            lblPic1.Left = 11 * 7
            lblPic1.Top = 47 * 2
            PicP2.Left = 11 * 7
            PicP2.Top = 63 * 2
            lblPic2.Left = 11 * 7
            lblPic2.Top = 69 * 2
            PicP3.Left = 14 * 7
            PicP3.Top = 19 * 2
            lblpic3.Left = 14 * 7
            lblpic3.Top = 25 * 2
            PicP4.Left = 14 * 7
            PicP4.Top = 85 * 2
            lblPic4.Left = 14 * 7
            lblPic4.Top = 91 * 2
            PicP5.Left = 28 * 7
            PicP5.Top = 23 * 2
            lblPic5.Left = 28 * 7
            lblPic5.Top = 29 * 2
            PicP6.Left = 26 * 7
            PicP6.Top = 43 * 2
            lblPic6.Left = 26 * 7
            lblPic6.Top = 49 * 2
            PicP7.Left = 25 * 7
            PicP7.Top = 63 * 2
            lblPic7.Left = 25 * 7
            lblPic7.Top = 69 * 2
            PicP8.Left = 28 * 7
            PicP8.Top = 81 * 2
            lblPic8.Left = 28 * 7
            lblPic8.Top = 87 * 2
            PicP9.Left = 43 * 7
            PicP9.Top = 38 * 2
            LblPic9.Left = 43 * 7
            LblPic9.Top = 44 * 2
            PicP10.Left = 40 * 7
            PicP10.Top = 64 * 2
            lblPic10.Left = 40 * 7
            lblPic10.Top = 70 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "LB"
            CbPlayer4.Text = "RB"
            CbPlayer5.Text = "OH-L"
            CbPlayer6.Text = "DH-L"
            CbPlayer7.Text = "DH-R"
            CbPlayer8.Text = "OH-R"
            CbPlayer9.Text = "CF-L"
            CbPlayer10.Text = "CF-R"




        End If
        '4-5-1A
        If LstFormation.SelectedItem = "4-5-1A" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 41 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 47 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 63 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 69 * 2
            PicP3.Left = 11 * 7
            PicP3.Top = 19 * 2
            lblpic3.Left = 11 * 7
            lblpic3.Top = 25 * 2
            PicP4.Left = 11 * 7
            PicP4.Top = 85 * 2
            lblPic4.Left = 11 * 7
            lblPic4.Top = 91 * 2
            PicP5.Left = 18 * 7
            PicP5.Top = 51 * 2
            lblPic5.Left = 18 * 7
            lblPic5.Top = 57 * 2
            PicP6.Left = 26 * 7
            PicP6.Top = 29 * 2
            lblPic6.Left = 26 * 7
            lblPic6.Top = 35 * 2
            PicP7.Left = 26 * 7
            PicP7.Top = 75 * 2
            lblPic7.Left = 26 * 7
            lblPic7.Top = 81 * 2
            PicP8.Left = 34 * 7
            PicP8.Top = 39 * 2
            lblPic8.Left = 34 * 7
            lblPic8.Top = 45 * 2
            PicP9.Left = 34 * 7
            PicP9.Top = 63 * 2
            LblPic9.Left = 34 * 7
            LblPic9.Top = 69 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 51 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 57 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "LB"
            CbPlayer4.Text = "RB"
            CbPlayer5.Text = "DH-C"
            CbPlayer6.Text = "LH"
            CbPlayer7.Text = "RH"
            CbPlayer8.Text = "OH-L"
            CbPlayer9.Text = "OH-R"
            CbPlayer10.Text = "CF-C"

        End If
        '4-5-1b
        If LstFormation.SelectedItem = "4-5-1B" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 41 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 47 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 63 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 69 * 2
            PicP3.Left = 11 * 7
            PicP3.Top = 19 * 2
            lblpic3.Left = 11 * 7
            lblpic3.Top = 25 * 2
            PicP4.Left = 11 * 7
            PicP4.Top = 85 * 2
            lblPic4.Left = 11 * 7
            lblPic4.Top = 91 * 2
            PicP5.Left = 18 * 7
            PicP5.Top = 43 * 2
            lblPic5.Left = 18 * 7
            lblPic5.Top = 49 * 2
            PicP6.Left = 18 * 7
            PicP6.Top = 61 * 2
            lblPic6.Left = 18 * 7
            lblPic6.Top = 67 * 2
            PicP7.Left = 26 * 7
            PicP7.Top = 29 * 2
            lblPic7.Left = 26 * 7
            lblPic7.Top = 35 * 2
            PicP8.Left = 26 * 7
            PicP8.Top = 75 * 2
            lblPic8.Left = 26 * 7
            lblPic8.Top = 81 * 2
            PicP9.Left = 34 * 7
            PicP9.Top = 51 * 2
            LblPic9.Left = 34 * 7
            LblPic9.Top = 57 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 51 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 57 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "LB"
            CbPlayer4.Text = "RB"
            CbPlayer5.Text = "DH-L"
            CbPlayer6.Text = "DH-R"
            CbPlayer7.Text = "LH"
            CbPlayer8.Text = "RH"
            CbPlayer9.Text = "OH-C"
            CbPlayer10.Text = "CF-C"
        End If
        If LstFormation.SelectedItem = "4-4-2A" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 41 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 47 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 63 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 69 * 2
            PicP3.Left = 11 * 7
            PicP3.Top = 19 * 2
            lblpic3.Left = 11 * 7
            lblpic3.Top = 25 * 2
            PicP4.Left = 11 * 7
            PicP4.Top = 85 * 2
            lblPic4.Left = 11 * 7
            lblPic4.Top = 91 * 2
            PicP5.Left = 18 * 7
            PicP5.Top = 51 * 2
            lblPic5.Left = 18 * 7
            lblPic5.Top = 57 * 2
            PicP6.Left = 26 * 7
            PicP6.Top = 29 * 2
            lblPic6.Left = 26 * 7
            lblPic6.Top = 35 * 2
            PicP7.Left = 26 * 7
            PicP7.Top = 75 * 2
            lblPic7.Left = 26 * 7
            lblPic7.Top = 81 * 2
            PicP8.Left = 34 * 7
            PicP8.Top = 51 * 2
            lblPic8.Left = 34 * 7
            lblPic8.Top = 57 * 2
            PicP9.Left = 43 * 7
            PicP9.Top = 37 * 2
            LblPic9.Left = 43 * 7
            LblPic9.Top = 43 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 65 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 71 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "LB"
            CbPlayer4.Text = "RB"
            CbPlayer5.Text = "DH-C"
            CbPlayer6.Text = "LH"
            CbPlayer7.Text = "RH"
            CbPlayer8.Text = "OH-C"
            CbPlayer9.Text = "CF-L"
            CbPlayer10.Text = "CF-R"
        End If
        If LstFormation.SelectedItem = "4-4-2B" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 41 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 47 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 63 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 69 * 2
            PicP3.Left = 11 * 7
            PicP3.Top = 19 * 2
            lblpic3.Left = 11 * 7
            lblpic3.Top = 25 * 2
            PicP4.Left = 11 * 7
            PicP4.Top = 85 * 2
            lblPic4.Left = 11 * 7
            lblPic4.Top = 91 * 2
            PicP5.Left = 18 * 7
            PicP5.Top = 43 * 2
            lblPic5.Left = 18 * 7
            lblPic5.Top = 49 * 2
            PicP6.Left = 18 * 7
            PicP6.Top = 61 * 2
            lblPic6.Left = 18 * 7
            lblPic6.Top = 67 * 2
            PicP7.Left = 30 * 7
            PicP7.Top = 33 * 2
            lblPic7.Left = 30 * 7
            lblPic7.Top = 39 * 2
            PicP8.Left = 30 * 7
            PicP8.Top = 69 * 2
            lblPic8.Left = 30 * 7
            lblPic8.Top = 75 * 2
            PicP9.Left = 43 * 7
            PicP9.Top = 37 * 2
            LblPic9.Left = 43 * 7
            LblPic9.Top = 43 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 65 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 71 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "LB"
            CbPlayer4.Text = "RB"
            CbPlayer5.Text = "DH-L"
            CbPlayer6.Text = "DH-R"
            CbPlayer7.Text = "OH-L"
            CbPlayer8.Text = "OH-R"
            CbPlayer9.Text = "CF-L"
            CbPlayer10.Text = "CF-R"


        End If
        If LstFormation.SelectedItem = "4-3-3A" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 41 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 47 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 63 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 69 * 2
            PicP3.Left = 11 * 7
            PicP3.Top = 19 * 2
            lblpic3.Left = 11 * 7
            lblpic3.Top = 25 * 2
            PicP4.Left = 11 * 7
            PicP4.Top = 85 * 2
            lblPic4.Left = 11 * 7
            lblPic4.Top = 91 * 2
            PicP5.Left = 18 * 7
            PicP5.Top = 51 * 2
            lblPic5.Left = 18 * 7
            lblPic5.Top = 57 * 2
            PicP6.Left = 30 * 7
            PicP6.Top = 39 * 2
            lblPic6.Left = 30 * 7
            lblPic6.Top = 45 * 2
            PicP7.Left = 30 * 7
            PicP7.Top = 63 * 2
            lblPic7.Left = 30 * 7
            lblPic7.Top = 69 * 2
            PicP8.Left = 43 * 7
            PicP8.Top = 51 * 2
            lblPic8.Left = 43 * 7
            lblPic8.Top = 57 * 2
            PicP9.Left = 43 * 7
            PicP9.Top = 31 * 2
            LblPic9.Left = 43 * 7
            LblPic9.Top = 37 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 71 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 77 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "LB"
            CbPlayer4.Text = "RB"
            CbPlayer5.Text = "DH-C"
            CbPlayer6.Text = "OH-L"
            CbPlayer7.Text = "OH-R"
            CbPlayer8.Text = "CF-C"
            CbPlayer9.Text = "LW"
            CbPlayer10.Text = "RW"


        End If
        If LstFormation.SelectedItem = "4-3-3B" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 41 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 47 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 63 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 69 * 2
            PicP3.Left = 11 * 7
            PicP3.Top = 19 * 2
            lblpic3.Left = 11 * 7
            lblpic3.Top = 25 * 2
            PicP4.Left = 11 * 7
            PicP4.Top = 85 * 2
            lblPic4.Left = 11 * 7
            lblPic4.Top = 91 * 2
            PicP5.Left = 18 * 7
            PicP5.Top = 43 * 2
            lblPic5.Left = 18 * 7
            lblPic5.Top = 49 * 2
            PicP6.Left = 18 * 7
            PicP6.Top = 61 * 2
            lblPic6.Left = 18 * 7
            lblPic6.Top = 67 * 2
            PicP7.Left = 30 * 7
            PicP7.Top = 51 * 2
            lblPic7.Left = 30 * 7
            lblPic7.Top = 57 * 2
            PicP8.Left = 43 * 7
            PicP8.Top = 51 * 2
            lblPic8.Left = 43 * 7
            lblPic8.Top = 57 * 2
            PicP9.Left = 43 * 7
            PicP9.Top = 31 * 2
            LblPic9.Left = 43 * 7
            LblPic9.Top = 37 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 71 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 77 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "LB"
            CbPlayer4.Text = "RB"
            CbPlayer5.Text = "DH-L"
            CbPlayer6.Text = "DH-R"
            CbPlayer7.Text = "OH-C"
            CbPlayer8.Text = "CF-C"
            CbPlayer9.Text = "LW"
            CbPlayer10.Text = "RW"
        End If
        If LstFormation.SelectedItem = "3-6-1A" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 31 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 37 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 51 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 57 * 2
            PicP3.Left = 9 * 7
            PicP3.Top = 71 * 2
            lblpic3.Left = 9 * 7
            lblpic3.Top = 77 * 2
            PicP4.Left = 18 * 7
            PicP4.Top = 51 * 2
            lblPic4.Left = 18 * 7
            lblPic4.Top = 57 * 2
            PicP5.Left = 26 * 7
            PicP5.Top = 27 * 2
            lblPic5.Left = 26 * 7
            lblPic5.Top = 33 * 2
            PicP6.Left = 26 * 7
            PicP6.Top = 77 * 2
            lblPic6.Left = 26 * 7
            lblPic6.Top = 83 * 2
            PicP7.Left = 26 * 7
            PicP7.Top = 51 * 2
            lblPic7.Left = 26 * 7
            lblPic7.Top = 57 * 2
            PicP8.Left = 34 * 7
            PicP8.Top = 39 * 2
            lblPic8.Left = 34 * 7
            lblPic8.Top = 45 * 2
            PicP9.Left = 34 * 7
            PicP9.Top = 63 * 2
            LblPic9.Left = 34 * 7
            LblPic9.Top = 69 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 51 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 57 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "CB-R"
            CbPlayer4.Text = "DH-C"
            CbPlayer5.Text = "LH"
            CbPlayer6.Text = "RH"
            CbPlayer7.Text = "OH-C"
            CbPlayer8.Text = "OH-L"
            CbPlayer9.Text = "OH-R"
            CbPlayer10.Text = "CF-C"

        End If
        If LstFormation.SelectedItem = "3-6-1B" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 31 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 37 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 51 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 57 * 2
            PicP3.Left = 9 * 7
            PicP3.Top = 71 * 2
            lblpic3.Left = 9 * 7
            lblpic3.Top = 77 * 2
            PicP4.Left = 18 * 7
            PicP4.Top = 43 * 2
            lblPic4.Left = 18 * 7
            lblPic4.Top = 49 * 2
            PicP5.Left = 18 * 7
            PicP5.Top = 61 * 2
            lblPic5.Left = 18 * 7
            lblPic5.Top = 67 * 2
            PicP6.Left = 26 * 7
            PicP6.Top = 27 * 2
            lblPic6.Left = 26 * 7
            lblPic6.Top = 33 * 2
            PicP7.Left = 26 * 7
            PicP7.Top = 77 * 2
            lblPic7.Left = 26 * 7
            lblPic7.Top = 83 * 2
            PicP8.Left = 34 * 7
            PicP8.Top = 39 * 2
            lblPic8.Left = 34 * 7
            lblPic8.Top = 45 * 2
            PicP9.Left = 34 * 7
            PicP9.Top = 63 * 2
            LblPic9.Left = 34 * 7
            LblPic9.Top = 69 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 51 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 57 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "CB-R"
            CbPlayer4.Text = "DH-L"
            CbPlayer5.Text = "DH-R"
            CbPlayer6.Text = "LH"
            CbPlayer7.Text = "RH"
            CbPlayer8.Text = "OH-L"
            CbPlayer9.Text = "OH-R"
            CbPlayer10.Text = "CF-C"
        End If
        If LstFormation.SelectedItem = "3-5-2A" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 31 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 37 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 51 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 57 * 2
            PicP3.Left = 9 * 7
            PicP3.Top = 71 * 2
            lblpic3.Left = 9 * 7
            lblpic3.Top = 77 * 2
            PicP4.Left = 18 * 7
            PicP4.Top = 51 * 2
            lblPic4.Left = 18 * 7
            lblPic4.Top = 57 * 2
            PicP5.Left = 26 * 7
            PicP5.Top = 27 * 2
            lblPic5.Left = 26 * 7
            lblPic5.Top = 33 * 2
            PicP6.Left = 26 * 7
            PicP6.Top = 77 * 2
            lblPic6.Left = 26 * 7
            lblPic6.Top = 83 * 2
            PicP7.Left = 34 * 7
            PicP7.Top = 39 * 2
            lblPic7.Left = 34 * 7
            lblPic7.Top = 45 * 2
            PicP8.Left = 34 * 7
            PicP8.Top = 63 * 2
            lblPic8.Left = 34 * 7
            lblPic8.Top = 69 * 2
            PicP9.Left = 43 * 7
            PicP9.Top = 37 * 2
            LblPic9.Left = 43 * 7
            LblPic9.Top = 43 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 65 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 71 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "CB-R"
            CbPlayer4.Text = "DH-C"
            CbPlayer5.Text = "LH"
            CbPlayer6.Text = "RH"
            CbPlayer7.Text = "OH-L"
            CbPlayer8.Text = "OH-R"
            CbPlayer9.Text = "CF-L"
            CbPlayer10.Text = "CF-R"


        End If
        If LstFormation.SelectedItem = "3-5-2B" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 31 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 37 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 51 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 57 * 2
            PicP3.Left = 9 * 7
            PicP3.Top = 71 * 2
            lblpic3.Left = 9 * 7
            lblpic3.Top = 77 * 2
            PicP4.Left = 18 * 7
            PicP4.Top = 43 * 2
            lblPic4.Left = 18 * 7
            lblPic4.Top = 49 * 2
            PicP5.Left = 18 * 7
            PicP5.Top = 61 * 2
            lblPic5.Left = 18 * 7
            lblPic5.Top = 67 * 2
            PicP6.Left = 26 * 7
            PicP6.Top = 27 * 2
            lblPic6.Left = 26 * 7
            lblPic6.Top = 33 * 2
            PicP7.Left = 26 * 7
            PicP7.Top = 77 * 2
            lblPic7.Left = 26 * 7
            lblPic7.Top = 83 * 2
            PicP8.Left = 34 * 7
            PicP8.Top = 51 * 2
            lblPic8.Left = 34 * 7
            lblPic8.Top = 57 * 2
            PicP9.Left = 43 * 7
            PicP9.Top = 37 * 2
            LblPic9.Left = 43 * 7
            LblPic9.Top = 43 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 65 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 71 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "CB-R"
            CbPlayer4.Text = "DH-L"
            CbPlayer5.Text = "DH-R"
            CbPlayer6.Text = "LH"
            CbPlayer7.Text = "RH"
            CbPlayer8.Text = "OH-C"
            CbPlayer9.Text = "CF-L"
            CbPlayer10.Text = "CF-R"


        End If
        If LstFormation.SelectedItem = "3-4-3A" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 31 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 37 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 51 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 57 * 2
            PicP3.Left = 9 * 7
            PicP3.Top = 71 * 2
            lblpic3.Left = 9 * 7
            lblpic3.Top = 77 * 2
            PicP4.Left = 18 * 7
            PicP4.Top = 51 * 2
            lblPic4.Left = 18 * 7
            lblPic4.Top = 57 * 2
            PicP5.Left = 26 * 7
            PicP5.Top = 27 * 2
            lblPic5.Left = 26 * 7
            lblPic5.Top = 33 * 2
            PicP6.Left = 26 * 7
            PicP6.Top = 77 * 2
            lblPic6.Left = 26 * 7
            lblPic6.Top = 83 * 2
            PicP7.Left = 34 * 7
            PicP7.Top = 51 * 2
            lblPic7.Left = 34 * 7
            lblPic7.Top = 57 * 2
            PicP8.Left = 43 * 7
            PicP8.Top = 51 * 2
            lblPic8.Left = 43 * 7
            lblPic8.Top = 57 * 2
            PicP9.Left = 43 * 7
            PicP9.Top = 31 * 2
            LblPic9.Left = 43 * 7
            LblPic9.Top = 37 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 71 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 77 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "CB-R"
            CbPlayer4.Text = "DH-C"
            CbPlayer5.Text = "LH"
            CbPlayer6.Text = "RH"
            CbPlayer7.Text = "OH-C"
            CbPlayer8.Text = "CF-C"
            CbPlayer9.Text = "LW"
            CbPlayer10.Text = "RW"

        End If
        If LstFormation.SelectedItem = "3-4-3B" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 31 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 37 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 51 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 57 * 2
            PicP3.Left = 9 * 7
            PicP3.Top = 71 * 2
            lblpic3.Left = 9 * 7
            lblpic3.Top = 77 * 2
            PicP4.Left = 18 * 7
            PicP4.Top = 43 * 2
            lblPic4.Left = 18 * 7
            lblPic4.Top = 49 * 2
            PicP5.Left = 18 * 7
            PicP5.Top = 61 * 2
            lblPic5.Left = 18 * 7
            lblPic5.Top = 67 * 2
            PicP6.Left = 30 * 7
            PicP6.Top = 33 * 2
            lblPic6.Left = 30 * 7
            lblPic6.Top = 39 * 2
            PicP7.Left = 30 * 7
            PicP7.Top = 69 * 2
            lblPic7.Left = 30 * 7
            lblPic7.Top = 75 * 2
            PicP8.Left = 43 * 7
            PicP8.Top = 51 * 2
            lblPic8.Left = 43 * 7
            lblPic8.Top = 57 * 2
            PicP9.Left = 43 * 7
            PicP9.Top = 31 * 2
            LblPic9.Left = 43 * 7
            LblPic9.Top = 37 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 71 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 77 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "CB-R"
            CbPlayer4.Text = "DH-L"
            CbPlayer5.Text = "DH-R"
            CbPlayer6.Text = "OH-L"
            CbPlayer7.Text = "OH-R"
            CbPlayer8.Text = "CF-C"
            CbPlayer9.Text = "LW"
            CbPlayer10.Text = "RW"
        End If
        If LstFormation.SelectedItem = "5-4-1A" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 31 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 37 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 51 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 57 * 2
            PicP3.Left = 9 * 7
            PicP3.Top = 71 * 2
            lblpic3.Left = 9 * 7
            lblpic3.Top = 77 * 2
            PicP4.Left = 12 * 7
            PicP4.Top = 17 * 2
            lblPic4.Left = 12 * 7
            lblPic4.Top = 23 * 2
            PicP5.Left = 12 * 7
            PicP5.Top = 87 * 2
            lblPic5.Left = 12 * 7
            lblPic5.Top = 93 * 2
            PicP6.Left = 18 * 7
            PicP6.Top = 51 * 2
            lblPic6.Left = 18 * 7
            lblPic6.Top = 57 * 2
            PicP7.Left = 26 * 7
            PicP7.Top = 29 * 2
            lblPic7.Left = 26 * 7
            lblPic7.Top = 35 * 2
            PicP8.Left = 26 * 7
            PicP8.Top = 75 * 2
            lblPic8.Left = 26 * 7
            lblPic8.Top = 81 * 2
            PicP9.Left = 34 * 7
            PicP9.Top = 51 * 2
            LblPic9.Left = 34 * 7
            LblPic9.Top = 57 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 51 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 57 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "CB-R"
            CbPlayer4.Text = "LB"
            CbPlayer5.Text = "RB"
            CbPlayer6.Text = "DH-C"
            CbPlayer7.Text = "LH"
            CbPlayer8.Text = "RH"
            CbPlayer9.Text = "OH-C"
            CbPlayer10.Text = "CF-C"


        End If
        If LstFormation.SelectedItem = "5-4-1B" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 31 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 37 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 51 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 57 * 2
            PicP3.Left = 9 * 7
            PicP3.Top = 71 * 2
            lblpic3.Left = 9 * 7
            lblpic3.Top = 77 * 2
            PicP4.Left = 12 * 7
            PicP4.Top = 17 * 2
            lblPic4.Left = 12 * 7
            lblPic4.Top = 23 * 2
            PicP5.Left = 12 * 7
            PicP5.Top = 87 * 2
            lblPic5.Left = 12 * 7
            lblPic5.Top = 93 * 2
            PicP6.Left = 18 * 7
            PicP6.Top = 43 * 2
            lblPic6.Left = 18 * 7
            lblPic6.Top = 49 * 2
            PicP7.Left = 18 * 7
            PicP7.Top = 61 * 2
            lblPic7.Left = 18 * 7
            lblPic7.Top = 67 * 2
            PicP8.Left = 30 * 7
            PicP8.Top = 33 * 2
            lblPic8.Left = 30 * 7
            lblPic8.Top = 39 * 2
            PicP9.Left = 30 * 7
            PicP9.Top = 69 * 2
            LblPic9.Left = 30 * 7
            LblPic9.Top = 75 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 51 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 57 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "CB-R"
            CbPlayer4.Text = "LB"
            CbPlayer5.Text = "RB"
            CbPlayer6.Text = "DH-L"
            CbPlayer7.Text = "DH-R"
            CbPlayer8.Text = "OH-L"
            CbPlayer9.Text = "OH-R"
            CbPlayer10.Text = "CF-C"

        End If
        If LstFormation.SelectedItem = "5-3-2A" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 31 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 37 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 51 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 57 * 2
            PicP3.Left = 9 * 7
            PicP3.Top = 71 * 2
            lblpic3.Left = 9 * 7
            lblpic3.Top = 77 * 2
            PicP4.Left = 12 * 7
            PicP4.Top = 17 * 2
            lblPic4.Left = 12 * 7
            lblPic4.Top = 23 * 2
            PicP5.Left = 12 * 7
            PicP5.Top = 87 * 2
            lblPic5.Left = 12 * 7
            lblPic5.Top = 93 * 2
            PicP6.Left = 18 * 7
            PicP6.Top = 51 * 2
            lblPic6.Left = 18 * 7
            lblPic6.Top = 57 * 2
            PicP7.Left = 34 * 7
            PicP7.Top = 39 * 2
            lblPic7.Left = 34 * 7
            lblPic7.Top = 45 * 2
            PicP8.Left = 34 * 7
            PicP8.Top = 63 * 2
            lblPic8.Left = 34 * 7
            lblPic8.Top = 69 * 2
            PicP9.Left = 43 * 7
            PicP9.Top = 37 * 2
            LblPic9.Left = 43 * 7
            LblPic9.Top = 43 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 65 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 71 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "CB-R"
            CbPlayer4.Text = "LB"
            CbPlayer5.Text = "RB"
            CbPlayer6.Text = "DH-C"
            CbPlayer7.Text = "OH-L"
            CbPlayer8.Text = "OH-R"
            CbPlayer9.Text = "CF-L"
            CbPlayer10.Text = "CF-R"

        End If
        If LstFormation.SelectedItem = "5-3-2B" Then
            PicP1.Left = 9 * 7
            PicP1.Top = 31 * 2
            lblPic1.Left = 9 * 7
            lblPic1.Top = 37 * 2
            PicP2.Left = 9 * 7
            PicP2.Top = 51 * 2
            lblPic2.Left = 9 * 7
            lblPic2.Top = 57 * 2
            PicP3.Left = 9 * 7
            PicP3.Top = 71 * 2
            lblpic3.Left = 9 * 7
            lblpic3.Top = 77 * 2
            PicP4.Left = 12 * 7
            PicP4.Top = 17 * 2
            lblPic4.Left = 12 * 7
            lblPic4.Top = 23 * 2
            PicP5.Left = 12 * 7
            PicP5.Top = 87 * 2
            lblPic5.Left = 12 * 7
            lblPic5.Top = 93 * 2
            PicP6.Left = 18 * 7
            PicP6.Top = 43 * 2
            lblPic6.Left = 18 * 7
            lblPic6.Top = 49 * 2
            PicP7.Left = 18 * 7
            PicP7.Top = 61 * 2
            lblPic7.Left = 18 * 7
            lblPic7.Top = 67 * 2
            PicP8.Left = 34 * 7
            PicP8.Top = 51 * 2
            lblPic8.Left = 34 * 7
            lblPic8.Top = 57 * 2
            PicP9.Left = 43 * 7
            PicP9.Top = 37 * 2
            LblPic9.Left = 43 * 7
            LblPic9.Top = 43 * 2
            PicP10.Left = 43 * 7
            PicP10.Top = 65 * 2
            lblPic10.Left = 43 * 7
            lblPic10.Top = 71 * 2
            cbplayer1.Text = "CB-L"
            CbPlayer2.Text = "CB-C"
            CbPlayer3.Text = "CB-R"
            CbPlayer4.Text = "LB"
            CbPlayer5.Text = "RB"
            CbPlayer6.Text = "DH-L"
            CbPlayer7.Text = "DH-R"
            CbPlayer8.Text = "OH-C"
            CbPlayer9.Text = "CF-L"
            CbPlayer10.Text = "CF-R"
        End If
    End Sub

    Private Sub LeerYActualizarColores()
        ' Abre el archivo en modo de lectura
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.Read)

        Dim offset1 As Integer = 24912 ' Offset inicial
        Dim SF As Byte ' Variable para almacenar el valor leído

        ' Leer el valor desde el archivo
        FileGet(1, SF, offset1) ' Lee el valor en la posición offset1

        ' Cierra el archivo después de leer


        ' Cambiar el color de los botones según el valor leído (0-10)
        For i As Integer = 0 To 10
            Dim btn As Button = TryCast(TabControl1.TabPages("TabPage2").Controls("Button" & (16 + i).ToString()), Button)
            If i = SF Then
                btn.BackColor = Color.Red ' Botón correspondiente al valor leído
            Else
                btn.BackColor = Color.WhiteSmoke ' Otros botones

            End If
        Next

        offset1 = 24897
        Dim LF As Byte
        FileGet(1, LF, offset1) ' Lee el valor en la posición offset1
        ' Cambiar el color de los botones según el valor leído (0-10)
        For i As Integer = 10 To 0 Step -1
            Dim btn As Button = TryCast(TabControl1.TabPages("TabPage2").Controls("Button" & (37 - i).ToString()), Button)
            If i = LF Then
                btn.BackColor = Color.DodgerBlue ' Botón correspondiente al valor leído
            Else
                btn.BackColor = Color.WhiteSmoke ' Otros botones
            End If
        Next

        offset1 = 24867
        Dim RC As Byte
        FileGet(1, RC, offset1) ' Lee el valor en la posición offset1
        ' Cambiar el color de los botones según el valor leído (0-10)
        For i As Integer = 10 To 0 Step -1
            Dim btn As Button = TryCast(TabControl1.TabPages("TabPage2").Controls("Button" & (48 - i).ToString()), Button)
            If i = RC Then
                btn.BackColor = Color.SeaGreen ' Botón correspondiente al valor leído
            Else
                btn.BackColor = Color.WhiteSmoke ' Otros botones
            End If
        Next

        offset1 = 24852
        Dim LC As Byte
        FileGet(1, LC, offset1) ' Lee el valor en la posición offset1
        ' Cambiar el color de los botones según el valor leído (0-10)
        For i As Integer = 10 To 0 Step -1
            Dim btn As Button = TryCast(TabControl1.TabPages("TabPage2").Controls("Button" & (59 - i).ToString()), Button)
            If i = LC Then
                btn.BackColor = Color.Orange ' Botón correspondiente al valor leído
            Else
                btn.BackColor = Color.WhiteSmoke ' Otros botones
            End If
        Next


        offset1 = 24882
        Dim PK As Byte
        FileGet(1, PK, offset1) ' Lee el valor en la posición offset1
        ' Cambiar el color de los botones según el valor leído (0-10)
        For i As Integer = 10 To 0 Step -1
            Dim btn As Button = TryCast(TabControl1.TabPages("TabPage2").Controls("Button" & (70 - i).ToString()), Button)
            If i = PK Then
                btn.BackColor = Color.BlueViolet ' Botón correspondiente al valor leído
            Else
                btn.BackColor = Color.WhiteSmoke ' Otros botones
            End If
        Next

        offset1 = 25857
        Dim C As Byte
        FileGet(1, C, offset1) ' Lee el valor en la posición offset1
        ' Cambiar el color de los botones según el valor leído (0-10)
        For i As Integer = 10 To 0 Step -1
            Dim btn As Button = TryCast(TabControl1.TabPages("TabPage2").Controls("Button" & (81 - i).ToString()), Button)
            If i = C Then
                btn.BackColor = Color.HotPink ' Botón correspondiente al valor leído
            Else
                btn.BackColor = Color.WhiteSmoke ' Otros botones
            End If
        Next
        FileClose(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim lecturabytes As Byte() = My.Computer.FileSystem.ReadAllBytes(OpenFileDialog1.FileName)

        Dim nombre1equipo1 As New String("", 10)
        Dim UrlEquipo As New String("", 48)

        'OpenFileDialog4.ShowDialog()
        OpenFileDialog4.Filter = "Archivos MCR (*.mcr)|*.mcr"
        OpenFileDialog4.FilterIndex = 1
        OpenFileDialog4.Title = "Seleccionar archivo MCR"
        If OpenFileDialog4.ShowDialog = DialogResult.OK Then


            FileCopy(OpenFileDialog4.FileName, My.Application.Info.DirectoryPath & "\database.mcr")



            idBinNumbers = 4
            FileOpen(idBinNumbers, OpenFileDialog4.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

            rutaarchivo = OpenFileDialog4.FileName

            Dim fileProcessor As New FileProcessor()
            Dim filePath As String = My.Application.Info.DirectoryPath & "\database.mcr"
            Dim offset As Long = 22788

            'cargar nombre club y cargar en webview21
            Dim offsetURLTeam As Integer = 130880
            Dim rawUrlEquipo As String = New String(Chr(0), 256) ' Tamaño adecuado para URL en el archivo binario
            FileGet(idBinNumbers, rawUrlEquipo, offsetURLTeam)

            ' Eliminar caracteres nulos de la cadena
            Dim cleanUrlEquipo As String = rawUrlEquipo.Trim(Chr(0))

            ' Verificar que la URL sea válida
            If Uri.IsWellFormedUriString(cleanUrlEquipo, UriKind.Absolute) Then
                ' Preguntar al usuario si desea usar esta URL
                Dim resultado As DialogResult = MessageBox.Show("¿Desea cargar esta URL: " & cleanUrlEquipo & "?", "Confirmación de carga de URL", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' Cargar la URL solo si el usuario elige "Sí"
                If resultado = DialogResult.Yes Then
                    Form1.WebView21.Source = New Uri(cleanUrlEquipo)
                Else
                    MessageBox.Show("URL no cargada.")
                End If
            Else
                MessageBox.Show("La URL cargada no es válida.")
            End If



            'cargando Lista de Jugadores y Posiciones


            Dim offsetnomequipo As Integer

            offsetnomequipo = 22801
            Dim m As Integer
            For m = 0 To 22
                'POSICIONES
                fileProcessor.ReadToFile(filePath, offset)
                'cargar posicion jugador
                idposicion = fileProcessor.Position
                IDPosiciones()
                'Cargar Nombres 
                FileGet(idBinNumbers, nombre1equipo1, offsetnomequipo)
                ListBoxMcR.Items.RemoveAt(m)
                ListBoxMcR.Items.Insert(m, posicion & nombre1equipo1)
                If m = 0 Then PLAYER1_FORMATION = nombre1equipo1
                If m = 1 Then PLAYER2_FORMATION = nombre1equipo1
                If m = 2 Then PLAYER3_FORMATION = nombre1equipo1
                If m = 3 Then PLAYER4_FORMATION = nombre1equipo1
                If m = 4 Then PLAYER5_FORMATION = nombre1equipo1
                If m = 5 Then PLAYER6_FORMATION = nombre1equipo1
                If m = 6 Then PLAYER7_FORMATION = nombre1equipo1
                If m = 7 Then PLAYER8_FORMATION = nombre1equipo1
                If m = 8 Then PLAYER9_FORMATION = nombre1equipo1
                If m = 9 Then PLAYER10_FORMATION = nombre1equipo1
                If m = 10 Then PLAYER11_FORMATION = nombre1equipo1



                offsetnomequipo = offsetnomequipo + 32
                offset = offset + 32
            Next


            'cargando numeros jugadores desde MCR
            offsetnum = 21508
            LeerNationNumbers()

            'cargar playerNumber a combo

            cmbnum1.Text = numberPlayer(0)
            cmbnum2.Text = numberPlayer(1)
            cmbnum3.Text = numberPlayer(2)
            cmbnum4.Text = numberPlayer(3)
            cmbnum5.Text = numberPlayer(4)
            cmbnum6.Text = numberPlayer(5)
            cmbnum7.Text = numberPlayer(6)
            cmbnum8.Text = numberPlayer(7)
            cmbnum9.Text = numberPlayer(8)
            cmbnum10.Text = numberPlayer(9)
            cmbnum11.Text = numberPlayer(10)
            cmbnum12.Text = numberPlayer(11)
            cmbnum13.Text = numberPlayer(12)
            cmbnum14.Text = numberPlayer(13)
            cmbnum15.Text = numberPlayer(14)
            cmbnum16.Text = numberPlayer(15)
            cmbnum17.Text = numberPlayer(16)
            cmbnum18.Text = numberPlayer(17)
            cmbnum19.Text = numberPlayer(18)
            cmbnum20.Text = numberPlayer(19)
            cmbnum21.Text = numberPlayer(20)
            cmbnum22.Text = numberPlayer(21)
            cmbnum23.Text = numberPlayer(22)

            FileClose(idBinNumbers)


            FileCopy(OpenFileDialog4.FileName, My.Application.Info.DirectoryPath & "\database.mcr")

            cargar()
            LeerYActualizarColores()
        End If


    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        ' Verificar si el usuario ha seleccionado TabPage2
        If TabControl1.SelectedTab Is TabPage2 Then
            ' Asegurar que ListBoxMcR tiene suficientes elementos antes de acceder a ellos
            If ListBoxMcR.Items.Count >= 11 Then
                LblPic0.Text = ListBoxMcR.Items(0).ToString()
                LblPlayer0.Text = ListBoxMcR.Items(0).ToString()
                lblPic1.Text = ListBoxMcR.Items(1).ToString()
                lblPlayer1.Text = ListBoxMcR.Items(1).ToString()
                lblPic2.Text = ListBoxMcR.Items(2).ToString()
                lblPlayer2.Text = ListBoxMcR.Items(2).ToString()
                lblpic3.Text = ListBoxMcR.Items(3).ToString()
                lblPlayer3.Text = ListBoxMcR.Items(3).ToString()
                lblPic4.Text = ListBoxMcR.Items(4).ToString()
                lblPlayer4.Text = ListBoxMcR.Items(4).ToString()
                lblPic5.Text = ListBoxMcR.Items(5).ToString()
                lblPlayer5.Text = ListBoxMcR.Items(5).ToString()
                lblPic6.Text = ListBoxMcR.Items(6).ToString()
                lblPlayer6.Text = ListBoxMcR.Items(6).ToString()
                lblPic7.Text = ListBoxMcR.Items(7).ToString()
                lblPlayer7.Text = ListBoxMcR.Items(7).ToString()
                lblPic8.Text = ListBoxMcR.Items(8).ToString()
                lblPlayer8.Text = ListBoxMcR.Items(8).ToString()
                LblPic9.Text = ListBoxMcR.Items(9).ToString()
                lblPlayer9.Text = ListBoxMcR.Items(9).ToString()
                lblPic10.Text = ListBoxMcR.Items(10).ToString()
                lblPlayer10.Text = ListBoxMcR.Items(10).ToString()
            Else
                MessageBox.Show("No hay suficientes elementos en ListBoxMcR.")
            End If

        Else
            'guardar formacion
            FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

            ' Definir arreglos para los controles PictureBox y ComboBox
            Dim playerPics() As PictureBox = {PicP1, PicP2, PicP3, PicP4, PicP5, PicP6, PicP7, PicP8, PicP9, PicP10}
            Dim playerCombos() As ComboBox = {cbplayer1, CbPlayer2, CbPlayer3, CbPlayer4, CbPlayer5, CbPlayer6, CbPlayer7, CbPlayer8, CbPlayer9, CbPlayer10}

            Dim offsetBaseX As Integer = 25256
            Dim offsetBaseY As Integer = 25266

            ' Iterar sobre cada jugador y procesar sus posiciones X e Y
            For i As Integer = 0 To playerPics.Length - 1
                Dim playerX As Int32 = playerPics(i).Location.X / 7
                Dim playerY As Int32 = playerPics(i).Location.Y / 2

                ' Procesamiento de posición X
                offset1 = offsetBaseX + i
                a = playerX
                algoritmo3()
                guardar()

                ' Procesamiento de posición Y
                offset1 = offsetBaseY + i
                a = playerY
                algoritmo3()
                guardar()
            Next

            ' Offset para las selecciones de ComboBox
            Dim offsetComboBase As Integer = 25557

            ' Iterar sobre cada ComboBox para guardar las posiciones seleccionadas
            For i As Integer = 0 To playerCombos.Length - 1
                offset1 = offsetComboBase + i
                Dim posPlayerCancha As Int32 = playerCombos(i).SelectedIndex + 2
                a = posPlayerCancha
                algoritmo3()
                guardar()
            Next


            'POSICION 11 TITULARES
            ' Asignación de posiciones y colores usando la función
            formmcr.lblposiplayer1.Text = "GK"
            formmcr.lblposiplayer1.BackColor = Color.DarkGoldenrod

            SetPlayerPositionAndColor(cbplayer1.Text, lblposiplayer2)
            SetPlayerPositionAndColor(CbPlayer2.Text, lblposiplayer3)
            SetPlayerPositionAndColor(CbPlayer3.Text, lblposiplayer4)
            SetPlayerPositionAndColor(CbPlayer4.Text, lblposiplayer5)
            SetPlayerPositionAndColor(CbPlayer5.Text, lblposiplayer6)
            SetPlayerPositionAndColor(CbPlayer6.Text, lblposiplayer7)
            SetPlayerPositionAndColor(CbPlayer7.Text, lblposiplayer8)
            SetPlayerPositionAndColor(CbPlayer8.Text, lblposiplayer9)
            SetPlayerPositionAndColor(CbPlayer9.Text, lblposiplayer10)
            SetPlayerPositionAndColor(CbPlayer10.Text, lblposiplayer11)


            FileClose(1)

        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnsave.Click



        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        'nombre Equipo
        offset1 = 130880
        sizeSTR = 48
        Dim TeamName As String = Form1.WebView21.Source.AbsoluteUri
        aa = TeamName
        guardarstr()

        'cambiar a 10 para nombres
        sizeSTR = 10


        'grabar numeros
        offsetnum = 21508
        For i As Integer = 0 To 22
            ' Buscar el ComboBox dentro de TabPage1
            Dim cmb As ComboBox = TryCast(TabPage1.Controls("cmbnum" & (i + 1).ToString()), ComboBox)

            ' Si el ComboBox existe, asigna el valor, si no, muestra un mensaje de error
            If cmb IsNot Nothing Then
                numberPlayer(i) = cmb.SelectedIndex
            Else
                Debug.Print("No se encontró: cmbnum" & (i + 1).ToString())
            End If
        Next
        GrabarNationNumbers()


        FileClose(1)

        SaveFileDialog1.FileName = txtclub.Text

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            MsgBox(SaveFileDialog1.FileName)
            FileCopy(My.Application.Info.DirectoryPath & "\database.mcr", SaveFileDialog1.FileName)

            'guardando nombres de jugadores
            Dim rutaArchivoMCR As String = SaveFileDialog1.FileName
            Dim rutaArchivoTXT As String = Path.ChangeExtension(rutaArchivoMCR, ".txt")

            ' Expresión regular para eliminar los prefijos y las iniciales de los nombres
            Dim patron As String = "\[.*?\]|\b\w\."

            ' Guardar el listado del ListBox en el archivo con la extensión .txt
            Using writer As New StreamWriter(rutaArchivoTXT)
                For Each item As String In ListBoxMcR.Items
                    ' Quitar el prefijo y la inicial del nombre usando la expresión regular
                    Dim textoProcesado As String = Regex.Replace(item.ToString(), patron, "").Trim()
                    writer.WriteLine(textoProcesado)
                Next
            End Using

        End If

    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If cmbhair.SelectedIndex > 0 Then

            cmbhair.SelectedIndex = cmbhair.SelectedIndex - 1


        End If

        indexcmbskikcolour = formmcr.cmbskincolor.Text
        indexcmbhaircolor = formmcr.cmbhaircolor.Text
        indexcmbhairface = formmcr.cmbhairface.SelectedIndex
        indexcmbhair = formmcr.cmbhair.SelectedIndex
        indexcmbhaircolourface = formmcr.cmbhaircolorface.Text

        SKINCOLOUR()



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        If cmbhair.SelectedIndex < 31 Then

            cmbhair.SelectedIndex = cmbhair.SelectedIndex + 1


        End If



        indexcmbskikcolour = formmcr.cmbskincolor.Text
        indexcmbhaircolor = formmcr.cmbhaircolor.Text
        indexcmbhairface = formmcr.cmbhairface.SelectedIndex
        indexcmbhair = formmcr.cmbhair.SelectedIndex
        indexcmbhaircolourface = formmcr.cmbhaircolorface.Text

        SKINCOLOUR()


    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If cmbhaircolor.SelectedIndex < 7 Then

            cmbhaircolor.SelectedIndex = cmbhaircolor.SelectedIndex + 1

        End If

        indexcmbskikcolour = formmcr.cmbskincolor.Text
        indexcmbhaircolor = formmcr.cmbhaircolor.Text
        indexcmbhairface = formmcr.cmbhairface.SelectedIndex
        indexcmbhair = formmcr.cmbhair.SelectedIndex
        indexcmbhaircolourface = formmcr.cmbhaircolorface.Text

        SKINCOLOUR()


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If cmbhaircolor.SelectedIndex > 0 Then

            cmbhaircolor.SelectedIndex = cmbhaircolor.SelectedIndex - 1
            indexcmbhaircolor = cmbhaircolor.SelectedIndex

        End If

        indexcmbskikcolour = formmcr.cmbskincolor.Text
        indexcmbhaircolor = formmcr.cmbhaircolor.Text
        indexcmbhairface = formmcr.cmbhairface.SelectedIndex
        indexcmbhair = formmcr.cmbhair.SelectedIndex
        indexcmbhaircolourface = formmcr.cmbhaircolorface.Text

        SKINCOLOUR()


    End Sub

    Private Sub txtplayername_TextChanged(sender As Object, e As EventArgs) Handles txtplayername.TextChanged
        lblname.Text = txtplayername.TextLength
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If cmbskincolor.SelectedIndex < 3 Then

            cmbskincolor.SelectedIndex = cmbskincolor.SelectedIndex + 1


        End If

        indexcmbskikcolour = formmcr.cmbskincolor.Text
        indexcmbhaircolor = formmcr.cmbhaircolor.Text
        indexcmbhairface = formmcr.cmbhairface.SelectedIndex
        indexcmbhair = formmcr.cmbhair.SelectedIndex
        indexcmbhaircolourface = formmcr.cmbhaircolorface.Text

        SKINCOLOUR()


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If cmbskincolor.SelectedIndex > 0 Then

            cmbskincolor.SelectedIndex = cmbskincolor.SelectedIndex - 1
            indexcmbskikcolour = cmbskincolor.SelectedIndex


        End If

        indexcmbskikcolour = formmcr.cmbskincolor.Text
        indexcmbhaircolor = formmcr.cmbhaircolor.Text
        indexcmbhairface = formmcr.cmbhairface.SelectedIndex
        indexcmbhair = formmcr.cmbhair.SelectedIndex
        indexcmbhaircolourface = formmcr.cmbhaircolorface.Text

        SKINCOLOUR()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        If cmbhairface.SelectedIndex > 0 Then

            cmbhairface.SelectedIndex = cmbhairface.SelectedIndex - 1

        End If
        indexcmbskikcolour = formmcr.cmbskincolor.Text
        indexcmbhaircolor = formmcr.cmbhaircolor.Text
        indexcmbhairface = formmcr.cmbhairface.SelectedIndex
        indexcmbhair = formmcr.cmbhair.SelectedIndex
        indexcmbhaircolourface = formmcr.cmbhaircolorface.Text

        SKINCOLOUR()


    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If cmbhaircolorface.SelectedIndex < 6 Then

            cmbhaircolorface.SelectedIndex = cmbhaircolorface.SelectedIndex + 1

        End If

        indexcmbskikcolour = formmcr.cmbskincolor.Text
        indexcmbhaircolor = formmcr.cmbhaircolor.Text
        indexcmbhairface = formmcr.cmbhairface.SelectedIndex
        indexcmbhair = formmcr.cmbhair.SelectedIndex
        indexcmbhaircolourface = formmcr.cmbhaircolorface.Text

        SKINCOLOUR()


    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If cmbhairface.SelectedIndex < 6 Then

            cmbhairface.SelectedIndex = cmbhairface.SelectedIndex + 1

        End If

        indexcmbskikcolour = formmcr.cmbskincolor.Text
        indexcmbhaircolor = formmcr.cmbhaircolor.Text
        indexcmbhairface = formmcr.cmbhairface.SelectedIndex
        indexcmbhair = formmcr.cmbhair.SelectedIndex
        indexcmbhaircolourface = formmcr.cmbhaircolorface.Text

        SKINCOLOUR()


    End Sub

    Dim indexcmbhaircolorface As Integer

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If cmbhaircolorface.SelectedIndex > 0 Then

            cmbhaircolorface.SelectedIndex = cmbhaircolorface.SelectedIndex - 1

        End If
        indexcmbskikcolour = formmcr.cmbskincolor.Text
        indexcmbhaircolor = formmcr.cmbhaircolor.Text
        indexcmbhairface = formmcr.cmbhairface.SelectedIndex
        indexcmbhair = formmcr.cmbhair.SelectedIndex
        indexcmbhaircolourface = formmcr.cmbhaircolorface.Text

        SKINCOLOUR()


    End Sub

    Private Sub cmboffense_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboffense.SelectedIndexChanged
        ColorFondoComboStats(cmboffense)
    End Sub

    Private Sub GrabarDataMcr()
        Dim processor As New FileProcessor()

        ' Asignar valores a las propiedades
        processor.Feet = cmbfood.SelectedIndex
        processor.Boots = cmbboots.SelectedIndex
        processor.Aggression = cmbaggression.SelectedIndex
        processor.Curve = cmbcurve.SelectedIndex
        processor.Jump = cmbjump.SelectedIndex
        processor.Head = cmbhead.SelectedIndex
        processor.Technique = cmbtechnique.SelectedIndex
        processor.PassAcc = cmbpass.SelectedIndex
        processor.ShotAcc = cmbshotacc.SelectedIndex
        processor.ShotPwr = cmbshotpower.SelectedIndex
        processor.Defense = cmbdeffense.SelectedIndex
        processor.Offense = cmboffense.SelectedIndex
        processor.Acceleration = cmbaceleration.SelectedIndex
        'invertir
        processor.Dribble = cmbspeed.SelectedIndex
        processor.Speed = cmbdribble.SelectedIndex
        '_----
        processor.Stamina = cmbstamina.SelectedIndex
        processor.BodyBalance = cmbbodybalance.SelectedIndex
        processor.Response = cmbresponse.SelectedIndex
        processor.Age = cmbage.SelectedIndex
        processor.Body = cmbbody.SelectedIndex
        processor.SkinColor = cmbskincolor.SelectedIndex
        processor.FeetOutside = cmbfeedoutside.SelectedIndex
        'processor.IDK = 0
        processor.Height = cmbheigth.SelectedIndex
        processor.HairColorFace = cmbhaircolorface.SelectedIndex
        processor.HairFace = cmbhairface.SelectedIndex
        processor.HairColor = cmbhaircolor.SelectedIndex
        processor.Hair = cmbhair.SelectedIndex
        processor.Position = cmbposition.SelectedIndex

        ' Especificar la ruta y el desplazamiento
        Dim filePath As String = My.Application.Info.DirectoryPath & "\database.mcr"
        Dim offset As Long = offset1

        ' Llamar al método para escribir los datos
        processor.WriteToFile(filePath, offset)

    End Sub
    Private Sub btnplayer1_Click_1(sender As Object, e As EventArgs) Handles btnplayer1.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 0

        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 22788
        GrabarDataMcr()

        '----------------------------------------------------------------
        'nombre player
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        ListBoxMcR.Items.RemoveAt(0)
        ListBoxMcR.Items.Insert(0, posicion & txtplayername.Text)
        PLAYER1_FORMATION = txtplayername.Text
        cmbnum1.Text = cmbclubnumber.Text
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        btnplayer1.Text = "Done"
        FileClose(1)
        itemColors(0) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer2_Click(sender As Object, e As EventArgs) Handles btnplayer2.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 6
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 22820
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        idposicion = cmbposition.SelectedIndex
        IDPosiciones()

        btnplayer2.Text = "Done"
        ListBoxMcR.Items.RemoveAt(1)
        ListBoxMcR.Items.Insert(1, posicion & txtplayername.Text)
        PLAYER2_FORMATION = txtplayername.Text
        cmbnum2.Text = cmbclubnumber.Text
        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(1) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer3_Click(sender As Object, e As EventArgs) Handles btnplayer3.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 12
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 22852
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer3.Text = "Done"
        ListBoxMcR.Items.RemoveAt(2)
        ListBoxMcR.Items.Insert(2, posicion & txtplayername.Text)
        PLAYER3_FORMATION = txtplayername.Text
        cmbnum3.Text = cmbclubnumber.Text

        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(2) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer4_Click(sender As Object, e As EventArgs) Handles btnplayer4.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 18
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 22884
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer4.Text = "Done"
        ListBoxMcR.Items.RemoveAt(3)
        ListBoxMcR.Items.Insert(3, posicion & txtplayername.Text)
        PLAYER4_FORMATION = txtplayername.Text
        cmbnum4.Text = cmbclubnumber.Text

        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(3) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer5_Click(sender As Object, e As EventArgs) Handles btnplayer5.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 24
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 22916
        GrabarDataMcr()

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer5.Text = "Done"
        ListBoxMcR.Items.RemoveAt(4)
        ListBoxMcR.Items.Insert(4, posicion & txtplayername.Text)
        PLAYER5_FORMATION = txtplayername.Text
        cmbnum5.Text = cmbclubnumber.Text

        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(4) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer6_Click(sender As Object, e As EventArgs) Handles btnplayer6.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 30
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 22948
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer6.Text = "Done"
        ListBoxMcR.Items.RemoveAt(5)
        ListBoxMcR.Items.Insert(5, posicion & txtplayername.Text)
        PLAYER6_FORMATION = txtplayername.Text
        cmbnum6.Text = cmbclubnumber.Text

        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(5) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer7_Click(sender As Object, e As EventArgs) Handles btnplayer7.Click

        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 36
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 22980
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer7.Text = "Done"
        ListBoxMcR.Items.RemoveAt(6)
        ListBoxMcR.Items.Insert(6, posicion & txtplayername.Text)
        PLAYER7_FORMATION = txtplayername.Text
        cmbnum7.Text = cmbclubnumber.Text
        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(6) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer8_Click(sender As Object, e As EventArgs) Handles btnplayer8.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 42
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23012
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer8.Text = "Done"
        ListBoxMcR.Items.RemoveAt(7)
        ListBoxMcR.Items.Insert(7, posicion & txtplayername.Text)
        PLAYER8_FORMATION = txtplayername.Text
        cmbnum8.Text = cmbclubnumber.Text
        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(7) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer9_Click(sender As Object, e As EventArgs) Handles btnplayer9.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 48
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23044
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer9.Text = "Done"
        ListBoxMcR.Items.RemoveAt(8)
        ListBoxMcR.Items.Insert(8, posicion & txtplayername.Text)
        PLAYER9_FORMATION = txtplayername.Text
        cmbnum9.Text = cmbclubnumber.Text
        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(8) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer10_Click(sender As Object, e As EventArgs) Handles btnplayer10.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 54
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23076
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer10.Text = "Done"
        ListBoxMcR.Items.RemoveAt(9)
        ListBoxMcR.Items.Insert(9, posicion & txtplayername.Text)
        PLAYER10_FORMATION = txtplayername.Text
        cmbnum10.Text = cmbclubnumber.Text
        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(9) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer11_Click(sender As Object, e As EventArgs) Handles btnplayer11.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 60
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23108
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer11.Text = "Done"
        ListBoxMcR.Items.RemoveAt(10)
        ListBoxMcR.Items.Insert(10, posicion & txtplayername.Text)
        PLAYER11_FORMATION = txtplayername.Text
        cmbnum11.Text = cmbclubnumber.Text
        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(10) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer12_Click(sender As Object, e As EventArgs) Handles btnplayer12.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 66
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23140
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer12.Text = "Done"
        ListBoxMcR.Items.RemoveAt(11)
        ListBoxMcR.Items.Insert(11, posicion & txtplayername.Text)
        cmbnum12.Text = cmbclubnumber.Text

        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(11) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer13_Click(sender As Object, e As EventArgs) Handles btnplayer13.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 72
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23172
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer13.Text = "Done"
        ListBoxMcR.Items.RemoveAt(12)
        ListBoxMcR.Items.Insert(12, posicion & txtplayername.Text)
        cmbnum13.Text = cmbclubnumber.Text
        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(12) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer14_Click(sender As Object, e As EventArgs) Handles btnplayer14.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 78
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23204
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer14.Text = "Done"
        ListBoxMcR.Items.RemoveAt(13)
        ListBoxMcR.Items.Insert(13, posicion & txtplayername.Text)
        cmbnum14.Text = cmbclubnumber.Text
        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(13) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer15_Click(sender As Object, e As EventArgs) Handles btnplayer15.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 84
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23236
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer15.Text = "Done"
        ListBoxMcR.Items.RemoveAt(14)
        ListBoxMcR.Items.Insert(14, posicion & txtplayername.Text)
        cmbnum15.Text = cmbclubnumber.Text
        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(14) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer16_Click(sender As Object, e As EventArgs) Handles btnplayer16.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 90
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23268
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer16.Text = "Done"
        ListBoxMcR.Items.RemoveAt(15)
        ListBoxMcR.Items.Insert(15, posicion & txtplayername.Text)
        cmbnum16.Text = cmbclubnumber.Text

        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(15) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer17_Click(sender As Object, e As EventArgs) Handles btnplayer17.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 96
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23300
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer17.Text = "Done"
        ListBoxMcR.Items.RemoveAt(16)
        ListBoxMcR.Items.Insert(16, posicion & txtplayername.Text)
        cmbnum17.Text = cmbclubnumber.Text
        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(16) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer18_Click(sender As Object, e As EventArgs) Handles btnplayer18.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 102
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23332
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer18.Text = "Done"
        ListBoxMcR.Items.RemoveAt(17)
        ListBoxMcR.Items.Insert(17, posicion & txtplayername.Text)
        cmbnum18.Text = cmbclubnumber.Text

        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(17) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer19_Click(sender As Object, e As EventArgs) Handles btnplayer19.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 108
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23364
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer19.Text = "Done"
        ListBoxMcR.Items.RemoveAt(18)
        ListBoxMcR.Items.Insert(18, posicion & txtplayername.Text)
        cmbnum19.Text = cmbclubnumber.Text
        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(18) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer20_Click(sender As Object, e As EventArgs) Handles btnplayer20.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 114
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23396
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer20.Text = "Done"
        ListBoxMcR.Items.RemoveAt(19)
        ListBoxMcR.Items.Insert(19, posicion & txtplayername.Text)
        cmbnum20.Text = cmbclubnumber.Text
        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(19) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer21_Click(sender As Object, e As EventArgs) Handles btnplayer21.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 120
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23428
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer21.Text = "Done"
        ListBoxMcR.Items.RemoveAt(20)
        ListBoxMcR.Items.Insert(20, posicion & txtplayername.Text)
        cmbnum21.Text = cmbclubnumber.Text
        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(20) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer22_Click(sender As Object, e As EventArgs) Handles btnplayer22.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 126
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23460
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer22.Text = "Done"
        ListBoxMcR.Items.RemoveAt(21)
        ListBoxMcR.Items.Insert(21, posicion & txtplayername.Text)
        cmbnum22.Text = cmbclubnumber.Text
        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(21) = Color.FromArgb(50, 85, 141)
    End Sub

    Private Sub btnplayer23_Click(sender As Object, e As EventArgs) Handles btnplayer23.Click
        InsertData()
        'Grabar ID Jugador en MCR
        offsetdata = 132
        If Form1.txt_id.Text <> "" Then
            dato = Form1.txt_id.Text
            GrabarData()
        End If
        offset1 = 23492
        GrabarDataMcr()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        idposicion = cmbposition.SelectedIndex
        IDPosiciones()
        btnplayer23.Text = "Done"
        ListBoxMcR.Items.RemoveAt(22)
        ListBoxMcR.Items.Insert(22, posicion & txtplayername.Text)
        cmbnum23.Text = cmbclubnumber.Text
        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 12
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()
        FileClose()
        itemColors(22) = Color.FromArgb(50, 85, 141)
    End Sub


    Private Sub btname1_Click(sender As Object, e As EventArgs) Handles btname1.Click
        If btname1.Text.Length > 10 Then
            MsgBox("more than 10 characters, Edit the nameplayer")
        End If
        txtplayername.Text = btname1.Text

    End Sub

    Private Sub btname2_Click(sender As Object, e As EventArgs) Handles btname2.Click
        txtplayername.Text = btname2.Text
    End Sub



    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        Dim result As DialogResult

        result = MessageBox.Show(
    "Are you sure?" & vbCrLf & vbCrLf &
    "All unsaved data will be deleted.",
    "New Memory Card",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning
)

        If result = DialogResult.No Then
            Exit Sub
        End If

        FileCopy(My.Application.Info.DirectoryPath & "\mc.dat", My.Application.Info.DirectoryPath & "\database.mcr")

        ' Guardar el color actual del formulario
        Dim currentColor As Color = Me.BackColor
        'guardar localizacion

        Dim locationx As Integer = Me.Location.X
        Dim locationy As Integer = Me.Location.Y
        ' Crear un diccionario para almacenar el color de cada Label
        Dim labelColors As New Dictionary(Of String, Color)
        For Each ctrl As Control In Controls
            If TypeOf ctrl Is Label Then
                labelColors(ctrl.Name) = ctrl.ForeColor
            End If
        Next

        Controls.Clear()
        InitializeComponent()

        ' Establecer todas las líneas a blanco en el diccionario
        For i As Integer = 0 To ListBoxMcR.Items.Count - 1
            itemColors(i) = Color.FromArgb(37, 37, 38)
        Next

        ' Restaurar el color del formulario
        Me.BackColor = currentColor



        ' Restaurar los colores de cada Label
        For Each ctrl As Control In Controls
            If TypeOf ctrl Is Label AndAlso labelColors.ContainsKey(ctrl.Name) Then
                ctrl.ForeColor = labelColors(ctrl.Name)
            End If
        Next

        Form1_Load(Me, Nothing)
        Me.Location = New Point(locationx, locationy)
        PLAYER1_FORMATION = "Player 1"
        PLAYER2_FORMATION = "Player 2"
        PLAYER3_FORMATION = "Player 3"
        PLAYER4_FORMATION = "Player 4"
        PLAYER5_FORMATION = "Player 5"
        PLAYER6_FORMATION = "Player 6"
        PLAYER7_FORMATION = "Player 7"
        PLAYER8_FORMATION = "Player 8"
        PLAYER9_FORMATION = "Player 9"
        PLAYER10_FORMATION = "Player 10"
        PLAYER11_FORMATION = "Player 11"

    End Sub

    Private Sub cmbclubnumber_TextChanged(sender As Object, e As EventArgs) Handles cmbclubnumber.TextChanged
        If cmbclubnumber.Text = "" Then
            cmbclubnumber.Text = "32"
        End If
        If cmbclubnumber.Text = "tm" Then
            cmbclubnumber.Text = "32"
        End If
    End Sub



    ' Flag para controlar el arrastre
    Private isDragging As Boolean = False
    Private Sub ListBoxMcR_MouseDown(sender As Object, e As MouseEventArgs) Handles ListBoxMcR.MouseDown

        ' Registrar el índice del ítem clickeado
        'lastClickedIndex = ListBoxMcR.IndexFromPoint(e.Location)

        If ListBoxMcR.SelectedIndex >= 0 Then
            DragIndex = ListBoxMcR.SelectedIndex
            DragItem = ListBoxMcR.Items(DragIndex).ToString()
            ListBoxMcR.DoDragDrop(DragItem, DragDropEffects.Move)



        End If
        If e.Button = MouseButtons.Left Then
            ' Obtener el índice del elemento en la posición del cursor

            Dim index As Integer = ListBoxMcR.IndexFromPoint(e.Location)
            If index <> -1 Then
                ' Prevenir el arrastre
                isDragging = False
                '' Seleccionar el elemento
                If index <> ListBox.NoMatches Then
                    ListBoxMcR.SelectedIndex = index
                End If

                ListBoxMcrOffset.SelectedIndex = index

                Dim fileProcessor As New FileProcessor()

                ' Ruta del archivo a procesar (ajusta según sea necesario)
                Dim filePath As String = OpenFileDialog1.FileName

                ' Offset de inicio (22788)
                Dim offset As Long = ListBoxMcrOffset.Text

                ' Llamar al método ProcessFile
                fileProcessor.ReadToFile(filePath, offset)
                'cargar apariencia al hacer clic derecho en el nombre listbox
                cmbhair.SelectedIndex = fileProcessor.Hair
                cmbhaircolor.SelectedIndex = fileProcessor.HairColor
                cmbskincolor.SelectedIndex = fileProcessor.SkinColor
                cmbhairface.SelectedIndex = fileProcessor.HairFace
                cmbhaircolorface.SelectedIndex = fileProcessor.HairColorFace

                indexcmbskikcolour = formmcr.cmbskincolor.Text
                indexcmbhaircolor = formmcr.cmbhaircolor.Text
                indexcmbhairface = formmcr.cmbhairface.SelectedIndex
                indexcmbhair = formmcr.cmbhair.SelectedIndex
                indexcmbhaircolourface = formmcr.cmbhaircolorface.Text

                SKINCOLOUR()

                'cargar stats al hacer clic derecho
                If Chek_LoadStats.Checked = True Then


                    cmboffense.SelectedIndex = fileProcessor.Offense
                    cmbdeffense.SelectedIndex = fileProcessor.Defense
                    cmbbodybalance.SelectedIndex = fileProcessor.BodyBalance
                    cmbstamina.SelectedIndex = fileProcessor.Stamina
                    cmbspeed.SelectedIndex = fileProcessor.Speed
                    cmbaceleration.SelectedIndex = fileProcessor.Acceleration
                    cmbpass.SelectedIndex = fileProcessor.PassAcc
                    cmbshotpower.SelectedIndex = fileProcessor.ShotPwr
                    cmbshotacc.SelectedIndex = fileProcessor.ShotAcc
                    cmbjump.SelectedIndex = fileProcessor.Jump
                    cmbhead.SelectedIndex = fileProcessor.Head
                    cmbtechnique.SelectedIndex = fileProcessor.Technique
                    cmbdribble.SelectedIndex = fileProcessor.Dribble
                    cmbcurve.SelectedIndex = fileProcessor.Curve
                    cmbaggression.SelectedIndex = fileProcessor.Aggression
                    cmbresponse.SelectedIndex = fileProcessor.Response
                    cmbposition.SelectedIndex = fileProcessor.Position
                    cmbheigth.SelectedIndex = fileProcessor.Height
                    cmbbody.SelectedIndex = fileProcessor.Body
                    cmbage.SelectedIndex = fileProcessor.Age
                    cmbboots.SelectedIndex = fileProcessor.Boots
                    cmbfeedoutside.SelectedIndex = fileProcessor.FeetOutside
                    cmbfood.SelectedIndex = fileProcessor.Feet




                    'cargar nombre desde listbox apartir del 4 caracter

                    ' Obtener el texto del ítem seleccionado
                    Dim selectedItem As String = ListBoxMcR.Items(index).ToString()

                    ' Verificar si el texto tiene al menos 4 caracteres
                    If selectedItem.Length >= 4 Then
                        ' Cargar a partir del cuarto carácter en la caja de texto
                        txtplayername.Text = selectedItem.Substring(4) ' Substring(3) comienza desde el cuarto carácter
                    Else
                        ' Si tiene menos de 4 caracteres, cargar el texto completo
                        txtplayername.Text = selectedItem
                    End If
                End If
                'cargar numeros

                cmbclubnumber.Text = numberPlayer(index)

                'cargar Id Jugador
                offsetdata = index * 6
                sizedata = 5
                LeerData()
                'MsgBox(values & " " & offsetdata)

                id = values
                If values <> 0 Then
                    If values <> 17229 Then
                        Form1.txt_id.Text = values
                        LoadContacts()
                    Else
                        Form1.txt_id.Text = 0
                        LoadContacts()

                    End If

                End If

            End If
        End If


    End Sub
    Private Sub ColorFondoComboStats(cmb As ComboBox)
        ' Cambiar el color de fondo según el valor de SelectedIndex
        Select Case cmb.SelectedIndex
            Case <= 4
                cmb.BackColor = Color.White
            Case 5
                cmb.BackColor = Color.Yellow
            Case 6
                cmb.BackColor = Color.Orange
            Case 7
                cmb.BackColor = Color.Red
            Case Else
                cmb.BackColor = SystemColors.Window ' Valor predeterminado
        End Select
    End Sub

    Private Sub ListBoxMcR_DragOver(sender As Object, e As DragEventArgs) Handles ListBoxMcR.DragOver

        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub ListBoxMcR_DragDrop(sender As Object, e As DragEventArgs) Handles ListBoxMcR.DragDrop
        Dim point As Point = ListBoxMcR.PointToClient(New Point(e.X, e.Y))
        Dim Dropindex As Integer = ListBoxMcR.IndexFromPoint(point)


        ' Remover el elemento de la posición original y agregarlo en la nueva posición
        If Dropindex >= 0 AndAlso Dropindex <> DragIndex Then
            Dim tempItem As String = ListBoxMcR.Items(Dropindex).ToString()

            ListBoxMcR.Items(Dropindex) = DragItem
            'MsgBox(ListBoxMcrOffset.Items(Dropindex))
            ListBoxMcR.Items(DragIndex) = tempItem
            'MsgBox(ListBoxMcrOffset.Items(DragIndex))
            Dim numpl1 As Integer
            Dim numpl2 As Integer

            Dim cmbnums(22) As ComboBox
            cmbnums(0) = cmbnum1
            cmbnums(1) = cmbnum2
            cmbnums(2) = cmbnum3
            cmbnums(3) = cmbnum4
            cmbnums(4) = cmbnum5
            cmbnums(5) = cmbnum6
            cmbnums(6) = cmbnum7
            cmbnums(7) = cmbnum8
            cmbnums(8) = cmbnum9
            cmbnums(9) = cmbnum10
            cmbnums(10) = cmbnum11
            cmbnums(11) = cmbnum12
            cmbnums(12) = cmbnum13
            cmbnums(13) = cmbnum14
            cmbnums(14) = cmbnum15
            cmbnums(15) = cmbnum16
            cmbnums(16) = cmbnum17
            cmbnums(17) = cmbnum18
            cmbnums(18) = cmbnum19
            cmbnums(19) = cmbnum20
            cmbnums(20) = cmbnum21
            cmbnums(21) = cmbnum22
            cmbnums(22) = cmbnum23


            numpl1 = cmbnums(DragIndex).Text
            numpl2 = cmbnums(Dropindex).Text

            cmbnums(DragIndex).Text = numpl2
            cmbnums(Dropindex).Text = numpl1
            numberPlayer(DragIndex) = numpl2
            numberPlayer(Dropindex) = numpl1


            'LEER DESDE DATABASE MCR PLAYER

            Dim PLTEMP1(BUFFERSIZE - 1) As Byte
            Dim pltemp2(buffersize2 - 1) As Byte
            Dim idtemp1(bufferziseId1 - 1) As Byte
            Dim idtemp2(bufferziseId2 - 1) As Byte

            'guardar array pl2
            Dim OFFSETPLAYER As Integer = ListBoxMcrOffset.Items(Dropindex)
            FileOpen(1, My.Application.Info.DirectoryPath & "/database.mcr", OpenMode.Binary, OpenAccess.ReadWrite)
            FileGet(1, pltemp2, OFFSETPLAYER + 1)

            'guardar array id2
            Dim offsetidplayer As Integer = Dropindex * 6
            FileGet(1, idtemp2, offsetidplayer + 1)

            ''FileClose()



            'guardar array pl1
            OFFSETPLAYER = ListBoxMcrOffset.Items(DragIndex)
            FileGet(1, PLTEMP1, OFFSETPLAYER + 1)

            'guardar array id1
            offsetidplayer = DragIndex * 6
            FileGet(1, idtemp1, offsetidplayer + 1)

            'guardar pl2 en nueva posicion
            FilePut(1, pltemp2, OFFSETPLAYER + 1)

            'guardar id2 en nueva posicion
            FilePut(1, idtemp2, offsetidplayer + 1)


            'grabar pl1 en nueva posicion
            OFFSETPLAYER = ListBoxMcrOffset.Items(Dropindex)
            FilePut(1, PLTEMP1, OFFSETPLAYER + 1)

            'grabar id1 en nueva posicion
            offsetidplayer = Dropindex * 6
            FilePut(1, idtemp1, offsetidplayer + 1)


            FileClose(1)

        End If

    End Sub



    Private Sub BtnImagenPlayerGoogle_Click(sender As Object, e As EventArgs) Handles BtnImagenPlayerGoogle.Click
        Process.Start(New ProcessStartInfo With {
       .FileName = "https://www.google.com/search?tbm=isch&q=" & Form1.TxtSofifaName.Text & " " & txtclub.Text,
       .UseShellExecute = True
   })
    End Sub

    Private Sub cmbdeffense_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdeffense.SelectedIndexChanged
        ColorFondoComboStats(cmbdeffense)
    End Sub

    Private Sub cmbbodybalance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbodybalance.SelectedIndexChanged
        ColorFondoComboStats(cmbbodybalance)
    End Sub

    Private Sub cmbstamina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbstamina.SelectedIndexChanged
        ColorFondoComboStats(cmbstamina)
    End Sub

    Private Sub cmbspeed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbspeed.SelectedIndexChanged
        ColorFondoComboStats(cmbspeed)
    End Sub

    Private Sub cmbaceleration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbaceleration.SelectedIndexChanged
        ColorFondoComboStats(cmbaceleration)
    End Sub

    Private Sub cmbpass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpass.SelectedIndexChanged
        ColorFondoComboStats(cmbpass)
    End Sub

    Private Sub cmbshotpower_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbshotpower.SelectedIndexChanged
        ColorFondoComboStats(cmbshotpower)
    End Sub

    Private Sub cmbshotacc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbshotacc.SelectedIndexChanged
        ColorFondoComboStats(cmbshotacc)
    End Sub

    Private Sub cmbjump_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbjump.SelectedIndexChanged
        ColorFondoComboStats(cmbjump)
    End Sub

    Private Sub cmbhead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbhead.SelectedIndexChanged
        ColorFondoComboStats(cmbhead)
    End Sub

    Private Sub cmbtechnique_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtechnique.SelectedIndexChanged
        ColorFondoComboStats(cmbtechnique)
    End Sub

    Private Sub cmbdribble_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdribble.SelectedIndexChanged
        ColorFondoComboStats(cmbdribble)
    End Sub

    Private Sub cmbcurve_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcurve.SelectedIndexChanged
        ColorFondoComboStats(cmbcurve)
    End Sub

    Private Sub cmbaggression_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbaggression.SelectedIndexChanged
        ColorFondoComboStats(cmbaggression)
    End Sub

    Private Sub cmbresponse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbresponse.SelectedIndexChanged
        ColorFondoComboStats(cmbresponse)
    End Sub

    Private Sub ListBoxMcR_MouseMove(sender As Object, e As MouseEventArgs) Handles ListBoxMcR.MouseMove
        If e.Button = MouseButtons.Right Then
            isDragging = False
        End If
    End Sub

    Private Sub ListBoxMcR_MouseUp(sender As Object, e As MouseEventArgs) Handles ListBoxMcR.MouseUp
        If e.Button = MouseButtons.Right Then
            isDragging = False
        End If
    End Sub

    Private Sub ListBoxMcR_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles ListBoxMcR.GiveFeedback
        ' Si el flag indica que no debe arrastrar, cancelar la operación de arrastre
        If isDragging Then
            e.UseDefaultCursors = True
        End If
    End Sub


    Private Sub BTN_BESTPOSITION_Click(sender As Object, e As EventArgs) Handles BTN_BESTPOSITION.Click
        cmbposition.Text = BTN_BESTPOSITION.Text
    End Sub

    Private Sub cmbPastePe6_Click(sender As Object, e As EventArgs) Handles cmbPastePe6.Click
        If Clipboard.ContainsText() Then
            RichPes.Clear()
            RichPes.Paste()
            LeerDesdeRichTextBox()
        End If
    End Sub

    Private Sub ProcessPlayerName2()
        ' Obtener el nombre del jugador del TextBox77
        Dim originalText As String = nameplayer

        ' Normalizar el texto a FormD (descomposición de caracteres)
        Dim normalizedText As String = originalText.Normalize(NormalizationForm.FormD)

        ' Crear un StringBuilder para construir el resultado final
        Dim stringBuilder As New StringBuilder()

        ' Filtrar y convertir caracteres especiales
        For Each ch As Char In normalizedText
            Dim unicodeCategory As UnicodeCategory = Char.GetUnicodeCategory(ch)
            If unicodeCategory <> UnicodeCategory.NonSpacingMark Then
                Select Case ch
                    Case "ø"c
                        stringBuilder.Append("o")
                    Case "Ø"c
                        stringBuilder.Append("O")
                    Case "æ"c
                        stringBuilder.Append("ae")
                    Case "Æ"c
                        stringBuilder.Append("AE")
                    Case "Ł"c
                        stringBuilder.Append("L")
                    Case "ł"c
                        stringBuilder.Append("l")
                    Case Else
                        stringBuilder.Append(ch)
                End Select
            End If
        Next

        ' Convertir el StringBuilder a una cadena y limpiar caracteres no alfabéticos excepto espacios
        Dim processedText As String = stringBuilder.ToString()
        processedText = Regex.Replace(processedText, "[^a-zA-Z\s]", "").Trim()

        ' Dividir en partes para obtener nombre y apellidos
        Dim partes() As String = processedText.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim nombreAbreviado As String = ""

        ' Asegurarse de que hay al menos un nombre y un apellido
        If partes.Length >= 2 Then
            ' Concatenar todos los apellidos (omitimos el primer nombre)
            Dim apellido As String = String.Join(" ", partes.Skip(1).Select(Function(p) Char.ToUpper(p(0)) & p.Substring(1).ToLower()))

            ' Verificar si la longitud de los apellidos es exactamente 10
            If apellido.Length = 10 Then
                ' Mostrar solo los apellidos sin la inicial del primer nombre
                nombreAbreviado = apellido
            Else
                ' Tomar la inicial del primer nombre con un punto y concatenarla con los apellidos
                Dim inicialNombre As String = partes(0).Substring(0, 1).ToUpper() & "."
                nombreAbreviado = $"{inicialNombre}{apellido}"

                ' Si la longitud total supera 10 caracteres, mostrar solo los primeros 10 caracteres
                If nombreAbreviado.Length > 10 Then
                    nombreAbreviado = nombreAbreviado.Substring(0, 10)
                End If
            End If
        ElseIf partes.Length = 1 Then
            ' Si solo hay una palabra, asumir que es el apellido y tomar solo los primeros 10 caracteres
            nombreAbreviado = partes(0)
            nombreAbreviado = Char.ToUpper(nombreAbreviado(0)) & nombreAbreviado.Substring(1).ToLower()
            If nombreAbreviado.Length > 10 Then
                nombreAbreviado = nombreAbreviado.Substring(0, 10)
            End If
        End If

        ' Asignar el nombre abreviado a los controles correspondientes
        formmcr.txtfifaname.Text = nombreAbreviado
        formmcr.btname1.Text = nombreAbreviado
        formmcr.txtplayername.Text = nombreAbreviado


    End Sub

    Private Sub FrmMCR_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Form1.Show()
    End Sub



    ' Diccionario para almacenar colores específicos para cada elemento
    Private itemColors As New Dictionary(Of Integer, Color)

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub ListBoxMcR_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ListBoxMcR.DrawItem
        If e.Index < 0 Then Return

        ' Obtener el color para el índice actual
        Dim backColor As Color = If(itemColors.ContainsKey(e.Index), itemColors(e.Index), e.BackColor)
        Dim foreColor As Color = e.ForeColor

        ' Dibujar el fondo personalizado
        e.Graphics.FillRectangle(New SolidBrush(backColor), e.Bounds)

        ' Dibujar el texto del elemento
        Using textBrush As New SolidBrush(foreColor)
            e.Graphics.DrawString(ListBoxMcR.Items(e.Index).ToString(), e.Font, textBrush, e.Bounds)
        End Using

        ' Dibujar el borde del elemento si está seleccionado
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.DrawFocusRectangle()
        End If
    End Sub

    Private Sub btnDecreaseOffense_Click(sender As Object, e As EventArgs) Handles btnDecreaseOffense.Click
        Dim currentValue = Convert.ToInt32(cmboffense.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmboffense.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnIncreaseOffense_Click(sender As Object, e As EventArgs) Handles btnIncreaseOffense.Click
        Dim currentValue = Convert.ToInt32(cmboffense.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmboffense.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub BtnDecDeffense_Click(sender As Object, e As EventArgs) Handles BtnDecDeffense.Click
        Dim currentValue = Convert.ToInt32(cmbdeffense.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmbdeffense.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub BtnInDeffense_Click(sender As Object, e As EventArgs) Handles BtnInDeffense.Click
        Dim currentValue = Convert.ToInt32(cmbdeffense.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmbdeffense.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnDecBalance_Click(sender As Object, e As EventArgs) Handles btnDecBalance.Click
        Dim currentValue = Convert.ToInt32(cmbbodybalance.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmbbodybalance.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnInBalance_Click(sender As Object, e As EventArgs) Handles btnInBalance.Click
        Dim currentValue = Convert.ToInt32(cmbbodybalance.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmbbodybalance.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnDecStamina_Click(sender As Object, e As EventArgs) Handles btnDecStamina.Click
        Dim currentValue = Convert.ToInt32(cmbstamina.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmbstamina.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnInStamina_Click(sender As Object, e As EventArgs) Handles btnInStamina.Click
        Dim currentValue = Convert.ToInt32(cmbstamina.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmbstamina.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnDecSpeed_Click(sender As Object, e As EventArgs) Handles btnDecSpeed.Click
        Dim currentValue = Convert.ToInt32(cmbspeed.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmbspeed.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub BtnInSpeed_Click(sender As Object, e As EventArgs) Handles BtnInSpeed.Click
        Dim currentValue = Convert.ToInt32(cmbspeed.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmbspeed.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnDecAcceleraton_Click(sender As Object, e As EventArgs) Handles btnDecAcceleraton.Click
        Dim currentValue = Convert.ToInt32(cmbaceleration.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmbaceleration.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnInAcceleraton_Click(sender As Object, e As EventArgs) Handles btnInAcceleraton.Click
        Dim currentValue = Convert.ToInt32(cmbaceleration.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmbaceleration.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnDecPassAcc_Click(sender As Object, e As EventArgs) Handles btnDecPassAcc.Click
        Dim currentValue = Convert.ToInt32(cmbpass.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmbpass.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnInPassAcc_Click(sender As Object, e As EventArgs) Handles btnInPassAcc.Click
        Dim currentValue = Convert.ToInt32(cmbpass.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmbpass.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnDecShotPower_Click(sender As Object, e As EventArgs) Handles btnDecShotPower.Click
        Dim currentValue = Convert.ToInt32(cmbshotpower.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmbshotpower.SelectedIndex = currentValue
        End If
    End Sub
    Private Sub btnInShotPower_Click(sender As Object, e As EventArgs) Handles btnInShotPower.Click
        Dim currentValue = Convert.ToInt32(cmbshotpower.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmbshotpower.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnDecShotAcc_Click(sender As Object, e As EventArgs) Handles btnDecShotAcc.Click
        Dim currentValue = Convert.ToInt32(cmbshotacc.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmbshotacc.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnInShotAcc_Click(sender As Object, e As EventArgs) Handles btnInShotAcc.Click
        Dim currentValue = Convert.ToInt32(cmbshotacc.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmbshotacc.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnDecJump_Click(sender As Object, e As EventArgs) Handles btnDecJump.Click
        Dim currentValue = Convert.ToInt32(cmbjump.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmbjump.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnInJump_Click(sender As Object, e As EventArgs) Handles btnInJump.Click
        Dim currentValue = Convert.ToInt32(cmbjump.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmbjump.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnDecHead_Click(sender As Object, e As EventArgs) Handles btnDecHead.Click
        Dim currentValue = Convert.ToInt32(cmbhead.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmbhead.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnInHead_Click(sender As Object, e As EventArgs) Handles btnInHead.Click
        Dim currentValue = Convert.ToInt32(cmbhead.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmbhead.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnDecTech_Click(sender As Object, e As EventArgs) Handles btnDecTech.Click
        Dim currentValue = Convert.ToInt32(cmbtechnique.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmbtechnique.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnInTech_Click(sender As Object, e As EventArgs) Handles btnInTech.Click
        Dim currentValue = Convert.ToInt32(cmbtechnique.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmbtechnique.SelectedIndex = currentValue
        End If
    End Sub



    Private Sub btnDecDribble_Click(sender As Object, e As EventArgs) Handles btnDecDribble.Click
        Dim currentValue = Convert.ToInt32(cmbdribble.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmbdribble.SelectedIndex = currentValue
        End If
    End Sub
    Private Sub btnInDribble_Click(sender As Object, e As EventArgs) Handles btnInDribble.Click
        Dim currentValue = Convert.ToInt32(cmbdribble.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmbdribble.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnDecCurve_Click(sender As Object, e As EventArgs) Handles btnDecCurve.Click
        Dim currentValue = Convert.ToInt32(cmbcurve.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmbcurve.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub BtnInCurve_Click(sender As Object, e As EventArgs) Handles BtnInCurve.Click
        Dim currentValue = Convert.ToInt32(cmbcurve.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmbcurve.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnDecAggre_Click(sender As Object, e As EventArgs) Handles btnDecAggre.Click
        Dim currentValue = Convert.ToInt32(cmbaggression.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmbaggression.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnInAggre_Click(sender As Object, e As EventArgs) Handles btnInAggre.Click
        Dim currentValue = Convert.ToInt32(cmbaggression.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmbaggression.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnDecResponse_Click(sender As Object, e As EventArgs) Handles btnDecResponse.Click
        Dim currentValue = Convert.ToInt32(cmbresponse.SelectedIndex)
        If currentValue > 0 Then
            currentValue -= 1
            cmbresponse.SelectedIndex = currentValue
        End If
    End Sub

    Private Sub btnInResponse_Click(sender As Object, e As EventArgs) Handles btnInResponse.Click
        Dim currentValue = Convert.ToInt32(cmbresponse.SelectedIndex)
        If currentValue < 7 Then
            currentValue += 1
            cmbresponse.SelectedIndex = currentValue
        End If
    End Sub


End Class

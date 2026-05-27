Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data
Imports System.Data.SQLite
Imports Newtonsoft.Json.Linq
Imports Microsoft.Web.WebView2
Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2.WinForms
Imports Newtonsoft.Json
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Globalization
Imports System.Windows.Forms.AxHost
Imports System.Linq.Expressions
Imports System.Security.Policy
Imports Microsoft
Imports System.Net
Imports System.ComponentModel


Public Class Form1
    Dim busctexto As String = ""
    Dim offsetbusc As Integer
    Dim busctexto2 As String = ""
    Dim offsetbusc2 As Integer
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

    Dim Btn_tm_player() As Button = {
        Btn_tm_player1, btn_tm_player2, btn_tm_player3, btn_tm_player4,
        btn_tm_player5, btn_tm_player6, btn_tm_player7, btn_tm_player8,
        btn_tm_player9, btn_tm_player10,
        btn_tm_player11, btn_tm_player12, btn_tm_player13, btn_tm_player14,
        btn_tm_player15, btn_tm_player16, btn_tm_player17, btn_tm_player18,
        btn_tm_player19, btn_tm_player20,
        btn_tm_player21, btn_tm_player22, btn_tm_player23, btn_tm_player24,
        btn_tm_player25, btn_tm_player26, btn_tm_player27, btn_tm_player28,
        btn_tm_player29, btn_tm_player30,
        btn_tm_player31, btn_tm_player32, btn_tm_player33, btn_tm_player34,
        btn_tm_player35, btn_tm_player36, btn_tm_player37, btn_tm_player38,
        btn_tm_player39, btn_tm_player40
    }

    Dim botones() As Button = {
    btnplayer1, Btnplayer2, btnplayer3, BtnPlayer4, btnplayer5,
    btnplayer6, btnplayer7, btnplayer8, btnplayer9, btnplayer10,
    btnplayer11, btnplayer12, btnplayer13, btnplayer14, btnplayer15,
    btnplayer16, btnplayer17, btnplayer18, btnplayer19, btnplayer20,
    btnplayer21, btnplayer22, btnplayer23, btnplayer24, btnplayer25,
    btnplayer26, btnplayer27, btnplayer28, btnplayer29, btnplayer30,
    btnplayer31, btnplayer32, btnplayer33
}

    Dim labelsPos() As Label = {
    lblPosPlayer1, lblPosPlayer2, lblPosPlayer3, lblPosPlayer4, lblPosPlayer5,
    lblPosPlayer6, lblPosPlayer7, lblPosPlayer8, lblPosPlayer9, lblPosPlayer10,
    lblPosPlayer11, lblPosPlayer12, lblPosPlayer13, lblPosPlayer14, lblPosPlayer15,
    lblPosPlayer16, lblPosPlayer17, lblPosPlayer18, lblPosPlayer19, lblPosPlayer20,
    lblPosPlayer21, lblPosPlayer22, lblPosPlayer23, lblPosPlayer24, lblPosPlayer25,
    lblPosPlayer26, lblPosPlayer27, lblPosPlayer28, lblPosPlayer29, lblPosPlayer30,
    lblPosPlayer31, lblPosPlayer32, lblPosPlayer33
}

    Public rn_number() As String

    Dim sHTML As String
    Dim rn_nummer() As Integer


    Dim clubnombre As String

    Dim id_efootball As String
    Dim nombreJugador_EF As String
    Dim squadnumber_EF As String
    Dim nsquadnumber_EF As String
    Dim offensive_awareness_EF As String
    Dim ball_control_EF As String
    Dim dribbling_EF As String
    Dim low_pass_EF As String
    Dim finishing_EF As String
    Dim heading_EF As String
    Dim tight_possession_EF As String
    Dim lofted_pass_EF As String
    Dim set_piece_taking_EF As String
    Dim curl_EF As String
    Dim speed_EF As String
    Dim acceleration_EF As String
    Dim kicking_power_EF As String
    Dim jumping_EF As String
    Dim physical_contact_EF As String
    Dim balance_EF As String
    Dim stamina_EF As String
    Dim defensive_awareness_EF As String
    Dim tackling_EF As String
    Dim defensive_engagement_EF As String
    Dim aggression_EF As String
    Dim gk_awareness_EF As String
    Dim gk_catching_EF As String
    Dim gk_parrying_EF As String
    Dim gk_reflexes_EF As String
    Dim gk_reach_EF As String
    Dim s_outside_curler_EF As String
    Dim pos_EF As String
    Dim weak_foot_acc_EF As String
    Dim posicion As String
    Dim equipo As String
    Dim age_EF As String
    Dim height_EF As String
    Dim weight_EF As String
    Dim foot_EF As String
    Dim team_name_display_EF As String
    Dim n_team_name_EF As String
    Dim nat_name_EF As String
    Dim fotoJugador_EF As String
    Dim UrlJugador_EF As String
    Dim BackWeb As Integer = 0

    Dim squadsize As Integer
    Dim visiblebtnplayerfifa As Boolean
    Dim visiblebtnplayerTM As Boolean
    Dim delayweb As Integer = 4000
    Dim delayweb2 As Integer = 4000
    Dim selectFM_Sofifa As Integer = 1
    Dim TmSelector As Integer = 0


    Private Sub HacerScroll(webView As Microsoft.Web.WebView2.WinForms.WebView2, x As Integer, y As Integer)
        Dim script As String = $"window.scrollTo({x}, {y});"
        webView.CoreWebView2.ExecuteScriptAsync(script)
    End Sub


    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rutaHtml As String = System.IO.Path.Combine(Application.StartupPath, "info.html")
        WebView21.Source = New Uri(rutaHtml)
        WebView22.Source = New Uri("https://sofifa.com/players")

        formmcr.MdiParent = Me
        formmcr.Show()
        LoadFromCSV()
        loadOptionsCVS()

        botones = New Button(32) {}

        For i = 0 To 32
            botones(i) = CType(Me.Controls.Find("btnplayer" & (i + 1), True).FirstOrDefault(), Button)
        Next

        labelsPos = New Label(32) {}

        For i = 0 To 32
            labelsPos(i) = CType(Me.Controls.Find("lblPosPlayer" & (i + 1), True).FirstOrDefault(), Label)
        Next

        Btn_tm_player = New Button(39) {}
        For i = 0 To 39
            Btn_tm_player(i) = CType(Me.Controls.Find("Btn_tm_player" & (i + 1), True).FirstOrDefault(), Button)
        Next


        ' Inicializar ambos WebView2
        Await Task.WhenAll(WebView21.EnsureCoreWebView2Async(), WebView22.EnsureCoreWebView2Async())

        ' WebView21 (normal) - Configuración SEGURA
        With WebView21.CoreWebView2.Settings
            .IsStatusBarEnabled = False
            .AreDevToolsEnabled = False
            .IsZoomControlEnabled = False
            ' 🚨 MANTENER activadas estas dos:
            .IsBuiltInErrorPageEnabled = True   ' ← IMPORTANTE
            .AreDefaultScriptDialogsEnabled = True ' ← IMPORTANTE
            ' El resto puede desactivarse
            .IsSwipeNavigationEnabled = False
            .AreDefaultContextMenusEnabled = False
            .IsWebMessageEnabled = False
            .IsPasswordAutosaveEnabled = False
            .IsGeneralAutofillEnabled = False


        End With

        ' WebView22 (scraping) - Puede ser más agresivo
        With WebView22.CoreWebView2.Settings
            .IsStatusBarEnabled = False
            .AreDevToolsEnabled = False
            .IsZoomControlEnabled = False
            .IsBuiltInErrorPageEnabled = False  ' ✅ Ok en scraping
            .AreDefaultScriptDialogsEnabled = False ' ✅ Ok en scraping
            .IsSwipeNavigationEnabled = False
            .AreDefaultContextMenusEnabled = False
            .IsWebMessageEnabled = False
            .IsPasswordAutosaveEnabled = False
            .IsGeneralAutofillEnabled = False
            .IsGeneralAutofillEnabled = False
            WebView22.CoreWebView2.AddWebResourceRequestedFilter("*", CoreWebView2WebResourceContext.Image)
            WebView22.CoreWebView2.AddWebResourceRequestedFilter("*", CoreWebView2WebResourceContext.Media)
            WebView22.CoreWebView2.AddWebResourceRequestedFilter("*", CoreWebView2WebResourceContext.Font)

        End With

        ' Ocultar  el WebView22
        WebView22.Visible = False



        'Bloqueo de anuncios
        'BloquearAnunciosSimple(WebView21)
        'BloquearAnunciosSimple(WebView22)

        allContatcs()

        'crear db we2002
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim command As New SQLiteCommand("CREATE TABLE IF NOT EXISTS Players (Id INTEGER, Name TEXT, SkinColor TEXT, Hair TEXT, HairColor TEXT, HairFace TEXT, HairColorFace TEXT, Club TEXT, NationalTeam TEXT, Nation TEXT, NumClub TEXT, NumNation TEXT, NAMEWE TEXT)", connection)
            command.ExecuteNonQuery()
            connection.Close()
        End Using

        '    'crear db fifa
        '    Using connection As New SQLiteConnection(connectionString)
        '        connection.Open()

        '        Dim sql As String =
        '"CREATE TABLE IF NOT EXISTS PlayerStats (
        '    PlayerId INTEGER PRIMARY KEY,

        '    -- ATTACKING
        '    Crossing INTEGER,
        '    Finishing INTEGER,
        '    HeadingAccuracy INTEGER,
        '    ShortPassing INTEGER,
        '    Volleys INTEGER,

        '    -- SKILL
        '    Dribbling INTEGER,
        '    Curve INTEGER,
        '    FKAccuracy INTEGER,
        '    LongPassing INTEGER,
        '    BallControl INTEGER,

        '    -- MOVEMENT
        '    Acceleration INTEGER,
        '    SprintSpeed INTEGER,
        '    Agility INTEGER,
        '    Reactions INTEGER,
        '    Balance INTEGER,

        '    -- POWER
        '    ShotPower INTEGER,
        '    Jumping INTEGER,
        '    Stamina INTEGER,
        '    Strength INTEGER,
        '    LongShots INTEGER,

        '    -- MENTALITY
        '    Aggression INTEGER,
        '    Interceptions INTEGER,
        '    AttackPosition INTEGER,
        '    Vision INTEGER,
        '    Penalties INTEGER,
        '    Composure INTEGER,

        '    -- DEFENDING
        '    DefensiveAwareness INTEGER,
        '    StandingTackle INTEGER,
        '    SlidingTackle INTEGER,

        '    -- GOALKEEPING
        '    GKDiving INTEGER,
        '    GKHandling INTEGER,
        '    GKKicking INTEGER,
        '    GKPositioning INTEGER,
        '    GKReflexes INTEGER
        ')"

        '        Using command As New SQLiteCommand(sql, connection)
        '            command.ExecuteNonQuery()
        '        End Using

        '    End Using

    End Sub

    Private Sub BloquearAnunciosSimple(webview As WebView2)
        ' Solo este script básico
        Dim script = "
    // Ocultar anuncios cada segundo
    setInterval(() => {
        document.querySelectorAll('[class*=""ad""], [id*=""ad""], .banner').forEach(el => {
            el.style.display = 'none';
        });
    }, 1000);
"

        AddHandler webview.NavigationCompleted,
    Async Sub(s, e)
        If e.IsSuccess Then
            Await webview.CoreWebView2.ExecuteScriptAsync(script)
        End If
    End Sub
    End Sub


    Private Sub CambiarColorLabels(formulario As Form, nuevoColor As Color)
        For Each ctrl As Control In formulario.Controls
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = nuevoColor
            End If
        Next
    End Sub


    Private Sub ProcessPlayerName()
        ' Obtener el nombre del jugador
        Dim originalText As String = txt_PlayerName.Text

        ' Normalizar el texto a FormD (descomposición de caracteres)
        Dim normalizedText As String = originalText.Normalize(NormalizationForm.FormD)

        ' Crear un StringBuilder para construir el resultado final
        Dim stringBuilder As New StringBuilder()

        ' Filtrar y convertir caracteres
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

        ' Convertir el StringBuilder a una cadena
        Dim processedText As String = stringBuilder.ToString()

        ' Eliminar todos los caracteres que no son del alfabeto inglés
        processedText = Regex.Replace(processedText, "[^a-zA-Z.]", "")

        ' Eliminar espacios adicionales
        processedText = processedText.Replace(" ", "")

        ' Asignar el texto procesado a los controles
        formmcr.txtplayername.Text = processedText
        formmcr.btname2.Text = processedText
    End Sub

    Private Sub ProcessPlayerName2()
        ' Obtener el nombre del jugador del TextBox77
        Dim originalText As String = TxtSofifaName.Text.Trim()

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

    Function PesoWE2002(altura As Integer, pos As String) As String
        Select Case pos

            Case "GK"
                If altura < 185 Then Return "f"
                If altura < 190 Then Return "g"
                Return "h"

            Case "CB"
                If altura < 175 Then Return "d"
                If altura < 182 Then Return "e"
                If altura < 188 Then Return "f"
                Return "g"

            Case "LB", "RB", "LWB", "RWB"
                If altura < 170 Then Return "b"
                If altura < 175 Then Return "c"
                If altura < 180 Then Return "d"
                Return "e"

            Case "DM", "CM"
                If altura < 170 Then Return "c"
                If altura < 175 Then Return "d"
                If altura < 180 Then Return "e"
                Return "f"

            Case "AM", "OH"
                If altura < 170 Then Return "b"
                If altura < 175 Then Return "c"
                If altura < 180 Then Return "d"
                Return "e"

            Case "WG"
                If altura < 168 Then Return "a"
                If altura < 172 Then Return "b"
                If altura < 176 Then Return "c"
                Return "d"

            Case "CF", "ST"
                If altura < 170 Then Return "c"
                If altura < 175 Then Return "d"
                If altura < 180 Then Return "e"
                If altura < 185 Then Return "f"
                Return "g"

            Case Else
                Return "d"
        End Select
    End Function

    Private Sub calcmcrFM()

        txt_comillas.Text = """"

        Dim busctexto As String = RichTextBox1.Text
        Dim offsetbusc As Integer
        Dim playernombre As String = ""
        Dim playernombre2 As String = ""
        Dim ultimaletra As String = ""
        Dim validtext As String


        'Variables FM
        Dim NombreFM As String = ""
        Dim IdFM As String = ""
        Dim Position1 As String = ""
        Dim Position2 As String = ""
        Dim Position3 As String = ""
        Dim ClubFm As String = ""
        Dim PhotoFm As String = ""
        txt_id.Text = ""

        On Error Resume Next

        Dim rxUrl As New Regex("<meta\s+property=""og:url""\s+content=""([^""]+)""", RegexOptions.IgnoreCase)
        Dim m As Match = rxUrl.Match(busctexto)

        If m.Success Then
            formmcr.lbl_link.Text = m.Groups(1).Value.Trim()
        Else
            formmcr.lbl_link.Text = ""
        End If


        'buscando nombre

        Dim un As Integer
        Dim p As Integer

        Dim rxName As New Regex(
    "<span class=""key"">Name</span>\s*<span class=""value"">([^<]+)",
    RegexOptions.IgnoreCase
)

        m = rxName.Match(busctexto)

        If m.Success Then
            NombreFM = m.Groups(1).Value.Trim()
        Else
            NombreFM = ""
        End If


        '>Unique ID<
        Dim rxId As New Regex("/players/[^/]+/(\d+)-")
        m = rxId.Match(busctexto)

        If m.Success Then
            txt_id.Text = m.Groups(1).Value
            id = CLng(m.Groups(1).Value)
        Else
            txt_id.Text = ""
            id = 0
        End If


        LoadContacts()

        'Position FM
        Dim rxPos As New Regex(
    "<span[^>]*class=""position natural""[^>]*>([^<]+)</span>",
    RegexOptions.IgnoreCase
)

        Dim matches As MatchCollection = rxPos.Matches(busctexto)

        Position1 = ""
        Position2 = ""
        Position3 = ""

        If matches.Count > 0 Then Position1 = matches(0).Groups(1).Value.Trim()
        If matches.Count > 1 Then Position2 = matches(1).Groups(1).Value.Trim()
        If matches.Count > 2 Then Position3 = matches(2).Groups(1).Value.Trim()


        'Busqueda Club

        Dim rxClub As New Regex(
    "<span class=""key"">Club</span>.*?<span class=""value"">([^<]+)</span>",
    RegexOptions.Singleline Or RegexOptions.IgnoreCase
)

        m = rxClub.Match(busctexto)

        If m.Success Then
            ClubFm = m.Groups(1).Value.Trim()
        Else
            ClubFm = ""
        End If


        'photo
        Dim rxPhoto As New Regex(
    "<meta[^>]*property\s*=\s*""og:image""[^>]*content\s*=\s*""([^""]+)""",
    RegexOptions.IgnoreCase
)

        m = rxPhoto.Match(busctexto)

        If m.Success Then
            PhotoFm = m.Groups(1).Value.Trim()

            If PhotoFm.StartsWith("//") Then
                PhotoFm = "https:" & PhotoFm
            End If
        Else
            PhotoFm = ""
        End If


        'nation
        Dim NationFm As String = ""

        Dim rxNation As New Regex(
    "<img[^>]*class=""flag""[^>]*>\s*([^<]+)",
    RegexOptions.IgnoreCase
)

        m = rxNation.Match(busctexto)

        If m.Success Then
            NationFm = m.Groups(1).Value.Trim()
        Else
            NationFm = ""
        End If


        'buscando edad
        Dim AgeFm As String = ""
        Dim rxAge As New Regex(
    "<span class=""key"">Age</span>\s*<span class=""value"">(\d+)",
    RegexOptions.IgnoreCase
)

        m = rxAge.Match(busctexto)

        If m.Success Then
            AgeFm = m.Groups(1).Value.Trim()
        Else
            AgeFm = ""
        End If


        'buscando altura
        Dim heigthFm As String = ""
        Dim rxHeight As New Regex(
    "<span class=""key"">Height</span>\s*<span class=""value"">(\d+)",
    RegexOptions.IgnoreCase
)

        m = rxHeight.Match(busctexto)

        If m.Success Then
            heigthFm = m.Groups(1).Value.Trim()
        Else
            heigthFm = ""
        End If


        'pie
        Dim LeftFootFm As String = ""
        Dim RightFootFm As String = ""
        Dim rxLeftFoot As New Regex(
    "<span class=""key"">Left foot</span>.*?<span class=""card[^""]*"">(\d+)</span>",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxLeftFoot.Match(busctexto)

        If m.Success Then
            LeftFootFm = m.Groups(1).Value.Trim()
        Else
            LeftFootFm = ""
        End If


        Dim rxRightFoot As New Regex(
    "<span class=""key"">Right foot</span>.*?<span class=""card[^""]*"">(\d+)</span>",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxRightFoot.Match(busctexto)

        If m.Success Then
            RightFootFm = m.Groups(1).Value.Trim()
        Else
            RightFootFm = ""
        End If

        Dim FootWE As String = ""

        Dim lf As Integer = Val(LeftFootFm)
        Dim rf As Integer = Val(RightFootFm)

        If Math.Abs(lf - rf) < 15 Then
            FootWE = "B"
        ElseIf rf > lf Then
            FootWE = "R"
        Else
            FootWE = "L"
        End If


        Dim CornersFM As String = ""
        Dim CrossingfM As String = ""
        Dim DribblingFm As String = ""
        Dim FinishingFm As String = ""
        Dim First_TouchFm As String = ""
        Dim HeadingFM As String = ""
        Dim LongShotsfM As String = ""
        Dim LongThrowsFm As String = ""
        Dim MarkingFm As String = ""
        Dim Passing_jugFm As String = ""
        Dim TacklingFm As String = ""
        Dim FsRatimgFm As String = ""
        Dim GkRatingFm As String = ""


        If Position1 <> "GK" Then
            'corners
            Dim rxCorners As New Regex(
    "<acronym[^>]*>\s*Corners\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxCorners.Match(busctexto)

            If m.Success Then
                CornersFM = m.Groups(1).Value
            Else
                CornersFM = ""
            End If


            '>Crossing<
            Dim rxCrossing As New Regex(
    "<acronym[^>]*>\s*Crossing\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxCrossing.Match(busctexto)

            If m.Success Then
                CrossingfM = m.Groups(1).Value
            Else
                CrossingfM = ""
            End If


            '">Dribbling</
            Dim rxDribbling As New Regex(
    "<acronym[^>]*>\s*Dribbling\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxDribbling.Match(busctexto)

            If m.Success Then
                DribblingFm = m.Groups(1).Value
            Else
                DribblingFm = ""
            End If

            '">Finishing<

            Dim rxFinishing As New Regex(
    "<acronym[^>]*>\s*Finishing\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxFinishing.Match(busctexto)

            If m.Success Then
                FinishingFm = m.Groups(1).Value
            Else
                FinishingFm = ""
            End If


            '">First Touch</
            Dim rxFirst_Touch As New Regex(
    "<acronym[^>]*>\s*First Touch\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxFirst_Touch.Match(busctexto)

            If m.Success Then
                First_TouchFm = m.Groups(1).Value
            Else
                First_TouchFm = ""
            End If

            '">Heading</
            Dim rxHeading As New Regex(
    "<acronym[^>]*>\s*Heading\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxHeading.Match(busctexto)

            If m.Success Then
                HeadingFM = m.Groups(1).Value
            Else
                HeadingFM = ""
            End If

            '">Long Shots</
            Dim rxLongShots As New Regex(
    "<acronym[^>]*>\s*Long Shots\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxLongShots.Match(busctexto)

            If m.Success Then
                LongShotsfM = m.Groups(1).Value
            Else
                LongShotsfM = ""
            End If

            '">Long Throws</
            Dim rxLongThrows As New Regex(
    "<acronym[^>]*>\s*Long Throws\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxLongThrows.Match(busctexto)

            If m.Success Then
                LongThrowsFm = m.Groups(1).Value
            Else
                LongThrowsFm = ""
            End If

            '">Marking</
            Dim rxMarking As New Regex(
    "<acronym[^>]*>\s*Marking\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxMarking.Match(busctexto)

            If m.Success Then
                MarkingFm = m.Groups(1).Value
            Else
                MarkingFm = ""
            End If

            '">Passing</
            Dim rxPassing As New Regex(
    "<acronym[^>]*>\s*Passing\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxPassing.Match(busctexto)

            If m.Success Then
                Passing_jugFm = m.Groups(1).Value
            Else
                Passing_jugFm = ""
            End If

            '">Tackling<
            Dim rxTackling As New Regex(
    "<acronym[^>]*>\s*Tackling\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxTackling.Match(busctexto)

            If m.Success Then
                TacklingFm = m.Groups(1).Value
            Else
                TacklingFm = ""
            End If

        End If

        Dim TechniqueFm As String = ""
        '">Technique</
        Dim rxTechnique As New Regex(
    "<acronym[^>]*>\s*Technique\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxTechnique.Match(busctexto)

        If m.Success Then
            TechniqueFm = m.Groups(1).Value
        Else
            TechniqueFm = ""
        End If

        Dim PenaltyTakingFm As String = ""
        '">Penalty Taking</
        Dim rxPenaltyTaking As New Regex(
    "<acronym[^>]*>\s*Penalty Taking\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxPenaltyTaking.Match(busctexto)

        If m.Success Then
            PenaltyTakingFm = m.Groups(1).Value
        Else
            PenaltyTakingFm = ""
        End If


        '">Free Kick Taking</
        Dim FreeKickTakingFm As String = ""
        Dim rxFreeKickTaking As New Regex(
    "<acronym[^>]*>\s*Free Kick Taking\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxFreeKickTaking.Match(busctexto)

        If m.Success Then
            FreeKickTakingFm = m.Groups(1).Value
        Else
            FreeKickTakingFm = ""
        End If

        '">Aggression</
        Dim AggressionFm As String = ""
        Dim rxAggression As New Regex(
    "<acronym[^>]*>\s*Aggression\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxAggression.Match(busctexto)

        If m.Success Then
            AggressionFm = m.Groups(1).Value
        Else
            AggressionFm = ""
        End If

        '">Anticipation</
        Dim AnticipationFm As String = ""
        Dim rxAnticipation As New Regex(
    "<acronym[^>]*>\s*Anticipation\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxAnticipation.Match(busctexto)

        If m.Success Then
            AnticipationFm = m.Groups(1).Value
        Else
            AnticipationFm = ""
        End If

        '">Bravery</
        Dim BraveryFm As String = ""
        Dim rxBravery As New Regex(
    "<acronym[^>]*>\s*Bravery\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxBravery.Match(busctexto)

        If m.Success Then
            BraveryFm = m.Groups(1).Value
        Else
            BraveryFm = ""
        End If

        '">Composure</
        Dim ComposureFm As String = ""
        Dim rxComposure As New Regex(
    "<acronym[^>]*>\s*Composure\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxComposure.Match(busctexto)

        If m.Success Then
            ComposureFm = m.Groups(1).Value
        Else
            ComposureFm = ""
        End If

        '">Concentration</
        Dim ConcentrationFm As String = ""
        Dim rxConcentration As New Regex(
    "<acronym[^>]*>\s*Concentration\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxConcentration.Match(busctexto)

        If m.Success Then
            ConcentrationFm = m.Groups(1).Value
        Else
            ConcentrationFm = ""
        End If

        '>Decisions</
        Dim DecisionsFm As String = ""
        Dim rxDecisions As New Regex(
    "<acronym[^>]*>\s*Decisions\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxDecisions.Match(busctexto)

        If m.Success Then
            DecisionsFm = m.Groups(1).Value
        Else
            DecisionsFm = ""
        End If

        '">Determination</
        Dim DeterminationFm As String = ""
        Dim rxDetermination As New Regex(
    "<acronym[^>]*>\s*Determination\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxDetermination.Match(busctexto)

        If m.Success Then
            DeterminationFm = m.Groups(1).Value
        Else
            DeterminationFm = ""
        End If

        '">Flair</
        Dim FlairFm As String = ""
        Dim rxFlair As New Regex(
    "<acronym[^>]*>\s*Flair\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxFlair.Match(busctexto)

        If m.Success Then
            FlairFm = m.Groups(1).Value
        Else
            FlairFm = ""
        End If

        '">Leadership</
        Dim LeadershipFm As String = ""
        Dim rxLeadership As New Regex(
    "<acronym[^>]*>\s*Leadership\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxLeadership.Match(busctexto)

        If m.Success Then
            LeadershipFm = m.Groups(1).Value
        Else
            LeadershipFm = ""
        End If

        '">Off the Ball
        Dim OfftheBallFm As String = ""
        Dim rxOfftheBallFm As New Regex(
    "<acronym[^>]*>\s*Off the Ball\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxOfftheBallFm.Match(busctexto)

        If m.Success Then
            OfftheBallFm = m.Groups(1).Value
        Else
            OfftheBallFm = ""
        End If

        '">Positioning</
        Dim PositioningFm As String = ""
        Dim rxPositioning As New Regex(
    "<acronym[^>]*>\s*Positioning\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxPositioning.Match(busctexto)

        If m.Success Then
            PositioningFm = m.Groups(1).Value
        Else
            PositioningFm = ""
        End If

        '">Teamwork</
        Dim TeamworkFm As String = ""
        Dim rxTeamwork As New Regex(
    "<acronym[^>]*>\s*Teamwork\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxTeamwork.Match(busctexto)

        If m.Success Then
            TeamworkFm = m.Groups(1).Value
        Else
            TeamworkFm = ""
        End If

        '">Vision<
        Dim VisionFm As String = ""
        Dim rxVision As New Regex(
    "<acronym[^>]*>\s*Vision\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxVision.Match(busctexto)

        If m.Success Then
            VisionFm = m.Groups(1).Value
        Else
            VisionFm = ""
        End If

        '>Work Rate</
        Dim WorkRateFm As String = ""
        Dim rxWorkRateFm As New Regex(
    "<acronym[^>]*>\s*Work Rate\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxWorkRateFm.Match(busctexto)

        If m.Success Then
            WorkRateFm = m.Groups(1).Value
        Else
            WorkRateFm = ""
        End If

        '">Acceleration</
        Dim accelerationFm As String = ""
        Dim rxAcceleration As New Regex(
    "<acronym[^>]*>\s*Acceleration\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxAcceleration.Match(busctexto)

        If m.Success Then
            accelerationFm = m.Groups(1).Value
        Else
            accelerationFm = ""
        End If

        '">Agility</
        Dim AgilityFm As String = ""
        Dim rxAgility As New Regex(
    "<acronym[^>]*>\s*Agility\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxAgility.Match(busctexto)

        If m.Success Then
            AgilityFm = m.Groups(1).Value
        Else
            AgilityFm = ""
        End If

        '">Balance</
        Dim balanceFm As String = ""
        Dim rxBalance As New Regex(
    "<acronym[^>]*>\s*Balance\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxBalance.Match(busctexto)

        If m.Success Then
            balanceFm = m.Groups(1).Value
        Else
            balanceFm = ""
        End If

        '">Jumping Reach</
        Dim Jump_ReacFm As String = ""
        Dim rxJump_ReacFm As New Regex(
    "<acronym[^>]*>\s*Jumping Reach\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxJump_ReacFm.Match(busctexto)

        If m.Success Then
            Jump_ReacFm = m.Groups(1).Value
        Else
            Jump_ReacFm = ""
        End If

        '">Natural Fitness</
        Dim NaturalFitnessFm As String = ""
        Dim rxNaturalFitnessFm As New Regex(
    "<acronym[^>]*>\s*Natural Fitness\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxNaturalFitnessFm.Match(busctexto)

        If m.Success Then
            NaturalFitnessFm = m.Groups(1).Value
        Else
            NaturalFitnessFm = ""
        End If

        '>Pace<
        Dim PaceFm As String = ""
        Dim rxPaceFm As New Regex(
    "<acronym[^>]*>\s*Pace\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxPaceFm.Match(busctexto)

        If m.Success Then
            PaceFm = m.Groups(1).Value
        Else
            PaceFm = ""
        End If

        '">Stamina</
        Dim StaminaFm As String = ""
        Dim rxStamina As New Regex(
    "<acronym[^>]*>\s*Stamina\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxStamina.Match(busctexto)

        If m.Success Then
            StaminaFm = m.Groups(1).Value
        Else
            StaminaFm = ""
        End If

        '">Strength</
        Dim strengthFm As String = ""
        Dim rxStrength As New Regex(
    "<acronym[^>]*>\s*Strength\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxStrength.Match(busctexto)

        If m.Success Then
            strengthFm = m.Groups(1).Value
        Else
            strengthFm = ""
        End If


        Dim arialreachFm As String = ""
        Dim commandofareaFm As String = ""
        Dim communicationFm As String = ""
        Dim EccentricityFm As String = ""
        Dim FirstTouchFm As String = ""
        Dim HandlingFm As String = ""
        Dim KickingFm As String = ""
        Dim OneonOnesFm As String = ""
        Dim PassingFm As String = ""
        Dim PunchingFm As String = ""
        Dim ReflexesFm As String = ""
        Dim RushingFm As String = ""
        Dim ThrowingFm As String = ""

        'STATS GK

        '">Passing</
        Dim rxPassingGK As New Regex(
    "<acronym[^>]*>\s*Passing\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

        m = rxPassingGK.Match(busctexto)

        If m.Success Then
            PassingFm = m.Groups(1).Value
        Else
            PassingFm = ""
        End If

        If Position1 = "GK" Then

            '">Aerial Reach</
            Dim rxarialreachFm As New Regex(
    "<acronym[^>]*>\s*Aerial Reach\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxarialreachFm.Match(busctexto)

            If m.Success Then
                arialreachFm = m.Groups(1).Value
            Else
                arialreachFm = ""
            End If

            '">Command of Area</
            Dim rxcommandofareaFm As New Regex(
    "<acronym[^>]*>\s*Command of Area\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxcommandofareaFm.Match(busctexto)

            If m.Success Then
                commandofareaFm = m.Groups(1).Value
            Else
                commandofareaFm = ""
            End If

            '">Communication</
            Dim rxCommunication As New Regex(
    "<acronym[^>]*>\s*Communication\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxCommunication.Match(busctexto)

            If m.Success Then
                communicationFm = m.Groups(1).Value
            Else
                communicationFm = ""
            End If

            '">Eccentricity</
            Dim rxEccentricity As New Regex(
    "<acronym[^>]*>\s*Eccentricity\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxEccentricity.Match(busctexto)

            If m.Success Then
                EccentricityFm = m.Groups(1).Value
            Else
                EccentricityFm = ""
            End If

            '">First Touch</
            Dim rxFirstTouchFm As New Regex(
    "<acronym[^>]*>\s*First Touch\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxFirstTouchFm.Match(busctexto)

            If m.Success Then
                FirstTouchFm = m.Groups(1).Value
            Else
                FirstTouchFm = ""
            End If

            '">Handling</
            Dim rxHandling As New Regex(
    "<acronym[^>]*>\s*Handling\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxHandling.Match(busctexto)

            If m.Success Then
                HandlingFm = m.Groups(1).Value
            Else
                HandlingFm = ""
            End If

            '">Kicking</
            Dim rxKicking As New Regex(
    "<acronym[^>]*>\s*Kicking\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxKicking.Match(busctexto)

            If m.Success Then
                KickingFm = m.Groups(1).Value
            Else
                KickingFm = ""
            End If

            '">One on Ones</
            Dim rxOneonOnesFm As New Regex(
    "<acronym[^>]*>\s*One on Ones\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxOneonOnesFm.Match(busctexto)

            If m.Success Then
                OneonOnesFm = m.Groups(1).Value
            Else
                OneonOnesFm = ""
            End If

            '">Punching (Tendency)</
            Dim rxPunchingFm As New Regex(
    "<acronym[^>]*>\s*Punching\s*\(Tendency\)\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxPunchingFm.Match(busctexto)

            If m.Success Then
                PunchingFm = m.Groups(1).Value
            Else
                PunchingFm = ""
            End If

            '">Reflexes
            Dim rxReflexes As New Regex(
    "<acronym[^>]*>\s*Reflexes\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxReflexes.Match(busctexto)

            If m.Success Then
                ReflexesFm = m.Groups(1).Value
            Else
                ReflexesFm = ""
            End If

            '">Rushing Out (Tendency)</
            Dim rxRushingFm As New Regex(
    "<acronym[^>]*>\s*Rushing Out\s*\(Tendency\)\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxRushingFm.Match(busctexto)

            If m.Success Then
                RushingFm = m.Groups(1).Value
            Else
                RushingFm = ""
            End If

            '">Throwing</
            Dim rxThrowing As New Regex(
    "<acronym[^>]*>\s*Throwing\s*</acronym>\s*</td>\s*<td[^>]*>\s*(\d+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)

            m = rxThrowing.Match(busctexto)

            If m.Success Then
                ThrowingFm = m.Groups(1).Value
            Else
                ThrowingFm = ""
            End If


        End If



        'we2002 convert==========================================================================================

        TxtSofifaName.Text = NombreFM
        ProcessPlayerName2()
        formmcr.cmbheigth.Text = heigthFm
        formmcr.cmbage.Text = AgeFm
        formmcr.txtnacionalidad.Text = NationFm
        If WebView22.Visible = False Then formmcr.txtclub.Text = ClubFm


        'cargar foto
        Dim photoTemp As String = Path.Combine(Application.StartupPath, "player_0.png")


        formmcr.PictureFifa.Load(photoTemp)

        Dim rutaLocal As String = Path.Combine(Application.StartupPath, "temp_face.png")

        If DescargarYGuardarImagen(PhotoFm, rutaLocal) Then
            formmcr.PictureFifa.Load(rutaLocal)

        End If



        'POSICION
        Select Case Position1
            Case "GK"
                formmcr.cmbposition.Text = "gk"
                formmcr.cmbposition.BackColor = Color.DarkGoldenrod

            Case "DC", "SW"
                formmcr.cmbposition.Text = "cb"
                formmcr.cmbposition.BackColor = Color.LightSeaGreen

            Case "DR", "DL", "WBR", "WBL"
                formmcr.cmbposition.Text = "sb"
                formmcr.cmbposition.BackColor = Color.LightSeaGreen

            Case "DM", "MC"
                formmcr.cmbposition.Text = "dh"
                formmcr.cmbposition.BackColor = Color.DarkSeaGreen

            Case "MR", "SH"
                formmcr.cmbposition.Text = "sh"
                formmcr.cmbposition.BackColor = Color.DarkSeaGreen

            Case "AMC"
                formmcr.cmbposition.Text = "oh"
                formmcr.cmbposition.BackColor = Color.DarkSeaGreen

            Case "ST"
                formmcr.cmbposition.Text = "cf"
                formmcr.cmbposition.BackColor = Color.PaleVioletRed


            Case "AMR", "AML"
                formmcr.cmbposition.Text = "wg"
                formmcr.cmbposition.BackColor = Color.PaleVioletRed

        End Select


        'pos2 
        Select Case Position2
            Case "GK"
                formmcr.BTN_BESTPOSITION.Text = "gk"
                formmcr.BTN_BESTPOSITION.BackColor = Color.DarkGoldenrod

            Case "DC", "SW"
                formmcr.BTN_BESTPOSITION.Text = "cb"
                formmcr.BTN_BESTPOSITION.BackColor = Color.LightSeaGreen

            Case "DR", "DL", "WBR", "WBL"
                formmcr.BTN_BESTPOSITION.Text = "sb"
                formmcr.BTN_BESTPOSITION.BackColor = Color.LightSeaGreen

            Case "DM", "MC"
                formmcr.BTN_BESTPOSITION.Text = "dh"
                formmcr.BTN_BESTPOSITION.BackColor = Color.DarkSeaGreen

            Case "MR", "SH"
                formmcr.BTN_BESTPOSITION.Text = "sh"
                formmcr.BTN_BESTPOSITION.BackColor = Color.DarkSeaGreen

            Case "AMC"
                formmcr.BTN_BESTPOSITION.Text = "oh"
                formmcr.BTN_BESTPOSITION.BackColor = Color.DarkSeaGreen

            Case "ST"
                formmcr.BTN_BESTPOSITION.Text = "cf"
                formmcr.BTN_BESTPOSITION.BackColor = Color.PaleVioletRed


            Case "AMR", "AML"
                formmcr.BTN_BESTPOSITION.Text = "wg"
                formmcr.BTN_BESTPOSITION.BackColor = Color.PaleVioletRed

        End Select


        'bota aleatorias
        Dim numeroAleatorio As New Random()
        Dim valorAleatorio As Integer = numeroAleatorio.Next(0, 8)
        formmcr.cmbboots.SelectedIndex = valorAleatorio



        'body
        Dim pesoLetra As String
        pesoLetra = PesoWE2002(CInt(heigthFm), Position1)

        formmcr.cmbbody.Text = pesoLetra


        Dim positionFMwe2002 As String = formmcr.cmbposition.Text
        'offence
        If positionFMwe2002 = "gk" Then
            stat1 = 30

        Else
            stat2 = OfftheBallFm / 5
            stat3 = AnticipationFm / 5
            stat1 = ConvertirStats((stat2 + stat3) / 2)

            If positionFMwe2002 = "cb" Or positionFMwe2002 = "sb" Then
                If stat1 > 0 And stat1 < 70 Then
                    stat1 = stat1 - 10
                ElseIf stat1 >= 70 And stat1 < 80 Then
                    stat1 = stat1 - 15
                ElseIf stat1 >= 80 And stat1 < 100 Then
                    stat1 = stat1 - 20
                End If
            End If
        End If

        LeerDeffen_Pass()
        formmcr.cmboffense.Text = resultstat

        'deffense
        If positionFMwe2002 = "gk" Then
            stat2 = ConvertirStats(PositioningFm / 5)
            stat3 = ConvertirStats(commandofareaFm / 5)
            stat1 = (stat2 + stat3) / 2
            LeerOffenceGK()
        Else
            stat2 = ConvertirStats(AnticipationFm / 5)
            stat3 = ConvertirStats(MarkingFm / 5)
            stat4 = ConvertirStats(PositioningFm / 5)
            stat5 = ConvertirStats(TacklingFm / 5)
            stat1 = (stat2 * 0.1) + (stat3 * 0.3) + (stat4 * 0.5) + (stat5 * 0.1)
            LeerRangoPlayer()

            If positionFMwe2002 = "cf" Or positionFMwe2002 = "wg" Then
                If stat1 > 0 And stat1 < 70 Then
                    stat1 = stat1 - 10
                ElseIf stat1 >= 70 And stat1 < 80 Then
                    stat1 = stat1 - 15
                ElseIf stat1 >= 80 And stat1 < 100 Then
                    stat1 = stat1 - 20
                End If
                LeerDeffen_Pass()
            End If
        End If

        formmcr.cmbdeffense.Text = resultstat


        'body balance
        If positionFMwe2002 = "gk" Then
            stat1 = ConvertirStatsArq(strengthFm / 5)
        Else
            stat1 = ConvertirStats(strengthFm / 5)
        End If

        LeerDeffen_Pass()
        formmcr.cmbbodybalance.Text = resultstat


        'stamina
        stat2 = ConvertirStats(StaminaFm / 5)
        stat1 = (82 + stat2) / 2
        LeerDeffen_Pass()
        formmcr.cmbstamina.Text = resultstat

        'speed

        stat1 = ConvertirStats(PaceFm / 5)
        If rbtonline.Checked = True Then
            LeerSpeed_accOnline()

        Else
            LeerRangoPlayer()
        End If


        formmcr.cmbspeed.Text = resultstat

        'aceleration

        stat1 = ConvertirStats(accelerationFm / 5)
        If rbtonline.Checked = True Then
            LeerSpeed_accOnline()

        Else
            LeerRangoPlayer()
        End If
        formmcr.cmbaceleration.Text = resultstat


        'pass

        If positionFMwe2002 = "gk" Then
            stat2 = ConvertirStatsArq(PassingFm / 5)
            stat3 = ConvertirStatsArq(KickingFm / 5)
            stat1 = (stat2 + stat3) / 2
        Else
            stat2 = ConvertirStats(PassingFm / 5)
            stat3 = ConvertirStats(CrossingfM / 5)
            stat1 = (stat2 + stat3) / 2


        End If

        LeerDeffen_Pass()

        formmcr.cmbpass.Text = resultstat

        'shot power
        If positionFMwe2002 = "gk" Then
            stat1 = ConvertirStats(KickingFm / 5)
        Else
            stat1 = ConvertirStats(LongShotsfM / 5)

        End If

        If rbtonline.Checked = True Then
            LeerSpeed_accOnline()

        Else
            LeerDeffen_Pass()
        End If
        formmcr.cmbshotpower.Text = resultstat

        'shot acc
        If positionFMwe2002 = "gk" Then
            stat1 = 45
        Else
            stat2 = ConvertirStats(FinishingFm / 5)
            stat3 = ConvertirStats(ComposureFm / 5)
            stat1 = (stat2 + stat3) / 2
        End If
        LeerRangoPlayer()
        formmcr.cmbshotacc.Text = resultstat

        'jump
        If positionFMwe2002 = "gk" Then
            stat2 = ConvertirStatsArq(Jump_ReacFm / 5)
            stat3 = ConvertirStatsArq(arialreachFm / 5)
            stat1 = (stat2 + stat3) / 2
        Else
            stat1 = ConvertirStats(Jump_ReacFm / 5)
        End If
        LeerDeffen_Pass()
        formmcr.cmbjump.Text = resultstat


        'head acc
        If positionFMwe2002 = "gk" Then
            stat1 = 55
        Else
            stat1 = ConvertirStats(HeadingFM / 5)
        End If
        LeerDeffen_Pass()
        formmcr.cmbhead.Text = resultstat

        'technique
        If positionFMwe2002 = "gk" Then
            stat1 = ConvertirStats(FlairFm / 5)
        Else
            stat2 = ConvertirStats(FlairFm / 5)
            stat3 = ConvertirStats(TechniqueFm / 5)
            stat1 = (stat2 + stat3) / 2
        End If
        LeerDeffen_Pass()
        formmcr.cmbtechnique.Text = resultstat

        'dribbling
        Dim dribbleacc As Integer
        Dim dribblespeed As Integer
        If positionFMwe2002 = "gk" Then
            stat2 = ConvertirStatsArq(FlairFm / 5)
            stat3 = ConvertirStatsArq(FirstTouchFm / 5)
            dribbleacc = (stat2 + stat3) / 2
            stat4 = ConvertirStatsArq(PaceFm / 5)
            dribblespeed = (stat2 + stat3 + stat4) / 3
            stat1 = (dribblespeed + dribbleacc) / 2
        Else
            stat2 = ConvertirStats(DribblingFm / 5)
            stat3 = ConvertirStats(FirstTouchFm / 5)
            dribbleacc = (stat2 + stat3) / 2
            promedio = (DribblingFm / 5) * 0.5
            stat4 = (accelerationFm / 5) * 0.25
            stat5 = (PaceFm / 5) * 0.25
            stat1 = ConvertirStats(promedio + stat4 + stat5)
        End If
        LeerDeffen_Pass()
        formmcr.cmbdribble.Text = resultstat

        'curve
        If positionFMwe2002 = "gk" Then
            stat2 = 45
        Else
            stat2 = ConvertirStats(FreeKickTakingFm / 5)
            stat3 = ConvertirStats(CornersFM / 5)
            stat1 = (stat2 + stat3) / 2
        End If
        LeerDeffen_Pass()
        formmcr.cmbcurve.Text = resultstat

        'agresive
        If positionFMwe2002 = "gk" Then
            stat2 = (PositioningFm / 5) * 0.7
            stat3 = (AnticipationFm / 5) * 0.3
            stat1 = ConvertirStatsArq(stat2 + stat3)
        Else
            stat2 = (VisionFm / 5) * 0.5
            stat3 = (OfftheBallFm / 5) * 0.5
            stat1 = ConvertirStats(stat2 + stat3)
        End If
        LeerDeffen_Pass()
        formmcr.cmbaggression.Text = resultstat

        'response
        If positionFMwe2002 = "gk" Then
            stat2 = (ReflexesFm / 5) * 0.8
            stat3 = (AnticipationFm / 5) * 0.2
            stat1 = ConvertirStats(stat2 + stat3)
            LeerResponseGk()
        Else
            stat1 = ConvertirStats(AnticipationFm / 5)
            LeerRangoPlayer()
        End If

        formmcr.cmbresponse.Text = resultstat

        'outsidee
        stat1 = TechniqueFm / 5
        If stat1 > 15 Then
            formmcr.cmbfeedoutside.Text = "yes"
        Else
            formmcr.cmbfeedoutside.Text = "no"
        End If


        'foot


        Dim foot As String = FootWE
        formmcr.cmbfood.Text = foot

    End Sub

    Public Function DescargarYGuardarImagen(url As String, rutaLocal As String) As Boolean
        Try
            Using client As New WebClient()


                client.Headers.Add(HttpRequestHeader.UserAgent,
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36")

                ' Descargar y guardar en disco
                client.DownloadFile(url, rutaLocal)
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al descargar: " & ex.Message)
            Return False
        End Try
    End Function


    Public Function ConvertirStatsArq(valor As Integer) As Integer
        If valor < 1 Or valor > 20 Then
            ' Valor fuera de rango
            Return 0
        End If

        If valor = 20 Then
            Return 99
        Else
            Return valor * 5
        End If
    End Function
    Public Function ConvertirStats(valor As Integer) As Integer
        If valor < 1 Or valor > 20 Then
            Return 0
        End If

        ' Rangos de valores estilo PES
        Dim minArray() As Integer = {40, 43, 46, 49, 52, 55, 58, 61, 64, 67, 70, 73, 76, 79, 82, 85, 88, 91, 94, 97}
        Dim maxArray() As Integer = {43, 46, 49, 52, 55, 58, 61, 64, 67, 70, 73, 76, 79, 82, 85, 88, 91, 94, 97, 100}

        Dim rnd As New Random()
        Return rnd.Next(minArray(valor - 1), maxArray(valor - 1) + 1)
    End Function


    ' Función para obtener un número aleatorio dentro de un rango
    Private Function GetRandomInt(minValue As Integer, maxValue As Integer) As Integer
        Dim random As New Random()
        Return random.Next(minValue, maxValue + 1) ' +1 para incluir el valor máximo
    End Function

    Public Sub Find_Stat()
        offsetbusc = InStr(offsetbusc + 11, busctexto, "><em title=")
        playernombre = Mid(busctexto, offsetbusc + 16, 2)
    End Sub
    Public Sub calcmcrEF()

        LoadContacts()

        On Error Resume Next
        txt_id.Text = ""

        'buscando id en bd apariencias

        txt_id.Text = id_efootball
        id = id_efootball
        LoadContacts()

        Dim validfoot As String
        Dim x As Integer
        If foot_EF = "1" Then
            validfoot = "L"
            x = 0
        Else
            validfoot = "R"
            x = 1
        End If



        'we2002 convert==========================================================================================
        Dim EXP_value As Decimal = 1.179
        Dim EXP_IDvalue As Decimal = 1.405
        Dim internationonalReputation As Integer = txt_repInternational.Text
        'Url Jug
        formmcr.lbl_link.Text = UrlJugador_EF

        txt_PlayerName.Text = nombreJugador_EF
        TxtSofifaName.Text = nombreJugador_EF
        ProcessPlayerName()

        'heigth
        formmcr.cmbheigth.Text = height_EF

        'cargar foto
        formmcr.PictureFifa.Load(fotoJugador_EF)
        formmcr.PictureFifa.Image.Save(My.Computer.FileSystem.CurrentDirectory & "/tempfotofifa.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

        'club number
        numclub = squadnumber_EF
        If squadnumber_EF < 32 Then
            nclub = squadnumber_EF
        Else
            nclub = 32
        End If
        If squadnumber_EF = "" Then
            nclub = "32"
        End If
        If squadnumber_EF = "tm" Then
            nclub = "32"
        End If

        ' nat number
        'If delayweb <= 1500 Then
        numnational = nsquadnumber_EF
        If nsquadnumber_EF < 32 Then
            nnational = numnational
        Else
            nnational = 32
        End If
        If nsquadnumber_EF = "" Then
            nnational = "32"
        End If
        If nsquadnumber_EF = "tm" Then
            nnational = "32"
        End If
        If formmcr.Rbt_Club.Checked = True Then formmcr.cmbclubnumber.Text = nclub
        If formmcr.Rbt_Nat.Checked = True Then formmcr.cmbclubnumber.Text = nnational

        'End If
        ProcessPlayerName2()

        If WebView22.Visible = False Then formmcr.txtclub.Text = team_name_display_EF

        formmcr.txtnacionalidad.Text = nat_name_EF

        Dim nameposition As String = pos_EF

        Select Case nameposition
            Case "CF", "SS"
                formmcr.cmbposition.Text = "cf"
                formmcr.cmbposition.BackColor = Color.PaleVioletRed
            Case "LWF", "RWF"
                formmcr.cmbposition.Text = "wg"
                formmcr.cmbposition.BackColor = Color.PaleVioletRed
            Case "DMF", "CMF"
                formmcr.cmbposition.Text = "dh"
                formmcr.cmbposition.BackColor = Color.DarkSeaGreen
            Case "AMF"
                formmcr.cmbposition.Text = "oh"
                formmcr.cmbposition.BackColor = Color.DarkSeaGreen

            Case "LMF", "RMF"
                formmcr.cmbposition.Text = "sh"
                formmcr.cmbposition.BackColor = Color.DarkSeaGreen
            Case "RB", "LB"
                formmcr.cmbposition.Text = "sb"
                formmcr.cmbposition.BackColor = Color.LightSeaGreen
            Case "CB"
                formmcr.cmbposition.Text = "cb"
                formmcr.cmbposition.BackColor = Color.LightSeaGreen
            Case "GK"
                formmcr.cmbposition.Text = "gk"
                formmcr.cmbposition.BackColor = Color.DarkGoldenrod
        End Select


        'national team
        formmcr.txt_nat_team.Text = n_team_name_EF


        Dim calcbody As Integer
        Dim calcheigthfix As Double
        stat2 = height_EF
        stat3 = weight_EF

        If stat2 >= 150 And stat2 <= 165 Then calcheigthfix = 1.4
        If stat2 >= 166 And stat2 <= 170 Then calcheigthfix = 1.25
        If stat2 >= 171 And stat2 <= 175 Then calcheigthfix = 1.1
        If stat2 >= 176 And stat2 <= 180 Then calcheigthfix = 0.95
        If stat2 >= 181 And stat2 <= 185 Then calcheigthfix = 0.93
        If stat2 >= 186 And stat2 <= 190 Then calcheigthfix = 0.91
        If stat2 >= 191 And stat2 <= 195 Then calcheigthfix = 0.89
        If stat2 >= 196 And stat2 <= 200 Then calcheigthfix = 0.87
        If stat2 >= 201 And stat2 <= 220 Then calcheigthfix = 0.85


        If formmcr.rbtn_Male.Checked = True Then
            calcbody = (calcheigthfix * stat3)

            If calcbody >= 50 And calcbody <= 64 Then formmcr.cmbbody.Text = "a"
            If calcbody >= 65 And calcbody <= 69 Then formmcr.cmbbody.Text = "b"
            If calcbody >= 70 And calcbody <= 74 Then formmcr.cmbbody.Text = "c"
            If calcbody >= 75 And calcbody <= 79 Then formmcr.cmbbody.Text = "d"
            If calcbody >= 80 And calcbody <= 84 Then formmcr.cmbbody.Text = "e"
            If calcbody >= 85 And calcbody <= 89 Then formmcr.cmbbody.Text = "f"
            If calcbody >= 90 And calcbody <= 94 Then formmcr.cmbbody.Text = "g"
            If calcbody >= 95 And calcbody <= 110 Then formmcr.cmbbody.Text = "h"
        Else
            formmcr.cmbbody.Text = "a"
        End If
        'foto
        'If fotosofifa <> "" Then
        '    'cargar predetermindada
        '    formmcr.PictureFifa.Load(My.Computer.FileSystem.CurrentDirectory & "/player_0.png")
        '    'cargar foto
        '    formmcr.PictureFifa.Load(cargafoto)
        '    'Clipboard.SetText(cargafoto)
        '    formmcr.PictureFifa.Image.Save(My.Computer.FileSystem.CurrentDirectory & "/tempfotofifa.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

        'End If
        ''Age

        formmcr.cmbage.Text = age_EF

        'foot
        If weak_foot_acc_EF > 2 And x = 1 Then
            formmcr.cmbfood.Text = "B"
        Else
            formmcr.cmbfood.Text = validfoot
        End If

        If formmcr.chekbootsramdon.Checked Then
            Dim numeroAleatorio As New Random()
            Dim valorAleatorio As Integer = numeroAleatorio.Next(0, 8)
            formmcr.cmbboots.SelectedIndex = valorAleatorio
        End If


        'STATS CONVERTION WE2002

        'offence
        stat1 = offensive_awareness_EF
        LeerRangoPlayer()
        formmcr.cmboffense.Text = resultstat


        'deffense
        If formmcr.cmbposition.Text = "gk" Then
            stat1 = (gk_awareness_EF * 0.2) + (gk_catching_EF * 0.2) + (gk_parrying_EF * 0.2) + (gk_reach_EF * 0.2) + (gk_reflexes_EF * 0.2)
            LeerOffenceGK()
        Else
            stat1 = defensive_awareness_EF
            LeerDeffen_Pass()
        End If
        formmcr.cmbdeffense.Text = resultstat

        'body balance
        stat1 = physical_contact_EF
        LeerRangoPlayer()
        formmcr.cmbbodybalance.Text = resultstat

        'stamina
        stat1 = stamina_EF
        LeerRangoPlayer()
        formmcr.cmbstamina.Text = resultstat

        'speed
        stat1 = speed_EF
        If rbtonline.Checked = True Then
            LeerSpeed_accOnline()
        Else
            LeerRangoPlayer()
        End If
        formmcr.cmbspeed.Text = resultstat


        'aceleration
        stat1 = acceleration_EF
        If rbtonline.Checked = True Then
            LeerSpeed_accOnline()
        Else
            LeerRangoPlayer()
        End If
        formmcr.cmbaceleration.Text = resultstat


        'pass
        promedio = (low_pass_EF + lofted_pass_EF) / 2
        stat1 = promedio
        LeerDeffen_Pass()
        formmcr.cmbpass.Text = resultstat

        'shot power
        stat1 = kicking_power_EF
        If rbtonline.Checked = True Then
            LeerSpeed_accOnline()
        Else
            LeerRangoPlayer()
        End If
        formmcr.cmbshotpower.Text = resultstat


        'shot acc
        stat1 = finishing_EF
        LeerDeffen_Pass()
        formmcr.cmbshotacc.Text = resultstat

        'jump
        stat1 = jumping_EF
        LeerDeffen_Pass()
        formmcr.cmbjump.Text = resultstat

        'head acc
        stat1 = heading_EF
        LeerDeffen_Pass()
        formmcr.cmbhead.Text = resultstat


        'tech
        stat1 = ball_control_EF
        LeerDeffen_Pass()
        formmcr.cmbtechnique.Text = resultstat


        'dribbling
        stat1 = dribbling_EF
        LeerDeffen_Pass()
        formmcr.cmbdribble.Text = resultstat

        'curve
        stat1 = curl_EF
        LeerDeffen_Pass()
        formmcr.cmbcurve.Text = resultstat

        'agresive
        If formmcr.cmbposition.Text = "gk" Then
            stat1 = (gk_awareness_EF * 0.6) + (gk_catching_EF * 0.4)
            LeerRangoPlayer()
        Else
            stat1 = (offensive_awareness_EF * 0.2) + (finishing_EF * 0.2) + (kicking_power_EF * 0.2) + (speed_EF * 0.4)
            LeerDeffen_Pass()
        End If
        formmcr.cmbaggression.Text = resultstat


        'response

        If formmcr.cmbposition.Text = "gk" Then
            stat1 = gk_reflexes_EF
            LeerResponseGk()
        Else
            If formmcr.cmbposition.Text = "cb" Or formmcr.cmbposition.Text = "sb" Then
                stat1 = (defensive_awareness_EF * 0.4) + (acceleration_EF * 0.3) + (defensive_engagement_EF * 0.3)
                LeerDeffen_Pass()
            ElseIf formmcr.cmbposition.Text = "dh" Or formmcr.cmbposition.Text = "oh" Or formmcr.cmbposition.Text = "sh" Then
                ' Supongo que "dh" es mediocentro defensivo (DMF)
                stat1 = (tight_possession_EF * 0.4) + (acceleration_EF * 0.3) + (defensive_engagement_EF * 0.3)
                LeerDeffen_Pass()
            ElseIf formmcr.cmbposition.Text = "cf" Then
                stat1 = (offensive_awareness_EF * 0.5) + (finishing_EF * 0.3) + (acceleration_EF * 0.2)
                LeerDeffen_Pass()
            ElseIf formmcr.cmbposition.Text = "wg" Then
                ' Asumo que "wg" es extremo / wing
                stat1 = (acceleration_EF * 0.4) + (offensive_awareness_EF * 0.4) + (dribbling_EF * 0.2)
                LeerDeffen_Pass()
            End If
        End If
        formmcr.cmbresponse.Text = resultstat

        'outsidee
        stat1 = s_outside_curler_EF
        If stat1 = 1 Then
            formmcr.cmbfeedoutside.Text = "yes"
        Else
            formmcr.cmbfeedoutside.Text = "no"
        End If



        'apariencia
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\tempfotofifa.bmp"
        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        Dim offsetcolorpiel As Integer

        Dim colorpiel As Byte
        Dim lectorhex As Integer
        Dim bytehex As Integer
        Dim piel As String

        '5091
        offsetcolorpiel = 3499

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex



        offsetcolorpiel = 3535

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex


        offsetcolorpiel = 3679

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex


        offsetcolorpiel = 3751

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex


        offsetcolorpiel = 3791

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex

        offsetcolorpiel = 291631

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex

        offsetcolorpiel = 285915

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex

        offsetcolorpiel = 284443

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex


        bytehex = bytehex / 8




        If bytehex >= 126 And bytehex <= 255 Then
            formmcr.cmbskincolor.SelectedIndex = 0


        End If
        If bytehex >= 111 And bytehex <= 125 Then
            formmcr.cmbskincolor.SelectedIndex = 1


        End If
        If bytehex >= 81 And bytehex <= 112 Then
            formmcr.cmbskincolor.SelectedIndex = 2


        End If
        If bytehex >= 0 And bytehex <= 80 Then
            formmcr.cmbskincolor.SelectedIndex = 3


        End If


        indexcmbskikcolour = formmcr.cmbskincolor.Text
        indexcmbhaircolor = formmcr.cmbhaircolor.Text
        indexcmbhairface = formmcr.cmbhairface.SelectedIndex
        indexcmbhair = formmcr.cmbhair.SelectedIndex
        indexcmbhaircolourface = formmcr.cmbhaircolorface.Text



        SKINCOLOUR()
        'MsgBox(bytehex)

        FileClose()


        LoadDataIntoTextBoxes()


        'End If


    End Sub

    Public Sub calcmcr()

        LoadContacts()

        busctexto = RichTextBox1.Text
        'If Mid(Me.Text, 1, 23) = "https://sofifa.com/team" Then

        On Error Resume Next

        'Url link
        Dim rx As New Regex("(\/player\/\d+)")
        Dim m As Match = rx.Match(busctexto)

        If m.Success Then
            formmcr.lbl_link.Text = "https://sofifa.com" & m.Groups(1).Value
        End If



        'buscando id

        Dim un As Integer
        Dim p As Integer
        Dim idJugador As String = ""

        rx = New Regex("player\/(\d+)")
        m = rx.Match(busctexto)

        If m.Success Then
            txt_id.Text = m.Groups(1).Value
        Else
            txt_id.Text = ""
        End If
        'buscando id en bd apariencias

        id = txt_id.Text
        LoadContacts()

        'buscando nombre
        rx = New Regex("ellipsis[^>]*>([^<]+)")
        m = rx.Match(busctexto)

        If m.Success Then
            TxtSofifaName.Text = m.Groups(1).Value.Trim()
        Else
            TxtSofifaName.Text = ""
        End If

        'busca team
        rx = New Regex("""affiliation""\s*:\s*""([^""]+)""", RegexOptions.IgnoreCase)
        m = rx.Match(busctexto)

        If m.Success Then
            txt_ClubActual.Text = m.Groups(1).Value.Trim()
        Else
            txt_ClubActual.Text = ""
        End If

        'busca national team
        rx = New Regex("<h5>National team</h5>[\s\S]*?data-type=""team"">\s*([^<]+)",
                    RegexOptions.IgnoreCase)

        m = rx.Match(busctexto)

        If m.Success Then
            txt_NationalTeam.Text = m.Groups(1).Value.Trim()
        Else
            txt_NationalTeam.Text = ""
        End If

        'nacionalidad

        rx = New Regex("""nationality""\s*:\s*""([^""]+)""", RegexOptions.IgnoreCase)
        m = rx.Match(busctexto)

        If m.Success Then
            txt_Country.Text = m.Groups(1).Value.Trim()
        Else
            txt_Country.Text = ""
        End If

        'playername
        rx = New Regex("""description""\s*:\s*""([^""(]+)")
        m = rx.Match(busctexto)

        If m.Success Then
            txt_PlayerName.Text = m.Groups(1).Value.Trim()
        Else
            txt_PlayerName.Text = ""
        End If

        'buscador foto
        offsetbusc = InStr(busctexto, "https://s3p.sofifa.net")
        Dim cargafoto As String = ""
        fotosofifa = ""

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
        rx = New Regex("<label>Position</label>\s*<span[^>]*>([^<]+)</span>")
        m = rx.Match(busctexto)

        If m.Success Then
            txt_Position.Text = m.Groups(1).Value.Trim()
        End If

        'Buscando jobTitle 
        Dim jobtitle As String
        rx = New Regex("""jobTitle""\s*:\s*""([^""]+)""")
        m = rx.Match(busctexto)

        If m.Success Then
            jobtitle = m.Groups(1).Value.Trim()
        End If


        'buscando best position
        rx = New Regex("Best position</label>\s*<span[^>]*>([^<]+)</span>")
        m = rx.Match(busctexto)

        Dim bestposition As String = ""

        If m.Success Then
            bestposition = m.Groups(1).Value.Trim()
        End If

        'club Number
        rx = New Regex("Club.*?Kit number</label>\s*(\d+)</p>", RegexOptions.Singleline)
        m = rx.Match(busctexto)

        If m.Success Then
            txt_ClubNumber.Text = m.Groups(1).Value
        Else
            txt_ClubNumber.Text = ""
        End If



        'buscando numero kit seleccion

        rx = New Regex("<h5>National team</h5>.*?Kit number</label>\s*(\d+)", RegexOptions.Singleline)
        m = rx.Match(busctexto)

        If m.Success Then
            txt_NationalNumber.Text = m.Groups(1).Value
        Else
            txt_NationalNumber.Text = ""
        End If


        ' buscando Attacking wingback
        Dim BuffoAgression As String = Nothing

        Dim rxAttackWing As New Regex(
    "Attacking wingback.*?<span class=""role-plus"">(\+{1,2})</span>",
    RegexOptions.Singleline Or RegexOptions.IgnoreCase
)

        m = rxAttackWing.Match(busctexto)

        If m.Success Then
            BuffoAgression = m.Groups(1).Value
        End If

        'buscando edad
        Dim rxBirth As New Regex("""birthDate""\s*:\s*""(\d{4}-\d{2}-\d{2})""")
        m = rxBirth.Match(busctexto)

        If m.Success Then
            txt_PlayerAge.Text = m.Groups(1).Value
        Else
            txt_PlayerAge.Text = ""
        End If


        'buscando altura
        Dim rxHeight As New Regex("""height""\s*:\s*""(\d+)")
        m = rxHeight.Match(busctexto)

        If m.Success Then
            txt_PlayerHeight.Text = m.Groups(1).Value
        End If


        'buscando peso
        Dim rxWeight As New Regex("""weight""\s*:\s*""(\d+)")
        m = rxWeight.Match(busctexto)

        If m.Success Then
            txt_PlayerWeight.Text = m.Groups(1).Value
        End If



        'pie
        Dim rxFoot As New Regex("Preferred foot</label>\s*(Left|Right)")
        m = rxFoot.Match(busctexto)

        If m.Success Then
            txt_foot.Text = If(m.Groups(1).Value = "Left", "L", "R")
        End If


        Dim validfoot As String
        Dim x As Integer
        If txt_foot.Text = "L" Then
            validfoot = "Left"
            x = 0
        Else
            validfoot = "Right"
            x = 1
        End If

        'Weak foot
        Dim regex As New Regex("<label>Skill moves</label>.*?<p>(\d+)")
        m = regex.Match(busctexto)

        If m.Success Then
            txt_weakFoot.Text = m.Groups(1).Value
        End If


        'Rep International


        offsetbusc = InStr(busctexto, "Weak foot")
        playernombre = Mid(busctexto, offsetbusc + 25, 1)
        txt_repInternational.Text = playernombre
        txt_repInternational.Text = Trim(Replace(txt_repInternational.Text, " ", ""))
        txt_repInternational.Text = Trim(Replace(txt_repInternational.Text, ",", ""))
        txt_repInternational.Text = Trim(Replace(txt_repInternational.Text, """", ""))



        'crossing

        offsetbusc = InStr(busctexto, ">Attacking<")
        Find_Stat()
        Txt_Crossing.Text = playernombre


        'finishing
        offsetbusc = InStr(busctexto, ">Crossing<")
        Find_Stat()
        Txt_Finishing.Text = playernombre

        'Heading accuracy
        offsetbusc = InStr(busctexto, ">Finishing<")
        Find_Stat()
        Txt_headAcc.Text = playernombre
        Txt_headAcc.Text = Trim(Replace(Txt_headAcc.Text, """", ""))

        'Short passing
        offsetbusc = InStr(busctexto, ">Heading accuracy<")
        Find_Stat()
        txt_Short_passing.Text = playernombre


        'Volleys
        offsetbusc = InStr(busctexto, ">Short passing<")
        Find_Stat()
        txt_Volleys.Text = playernombre


        'Dribbling
        offsetbusc = InStr(busctexto, ">Skill<")
        Find_Stat()
        Txt_Dribbling.Text = playernombre


        'Curve
        offsetbusc = InStr(busctexto, ">Dribbling<")
        Find_Stat()
        Txt_curve.Text = playernombre


        'Free kick accuracy
        offsetbusc = InStr(busctexto, ">Curve<")
        Find_Stat()
        Txt_FreeKickAcc.Text = playernombre


        'Long passing
        offsetbusc = InStr(busctexto, ">FK Accuracy<")
        Find_Stat()
        txt_LongPassing.Text = playernombre


        'Ball control
        offsetbusc = InStr(busctexto, ">Long passing<")
        Find_Stat()
        TxtBallControl.Text = playernombre


        'Acceleration
        offsetbusc = InStr(busctexto, ">Movement</h5>")
        Find_Stat()
        txt_Acceleration.Text = playernombre

        'Sprint speed
        offsetbusc = InStr(busctexto, ">Acceleration<")
        Find_Stat()
        txt_SprintSpeed.Text = playernombre


        'Agility
        offsetbusc = InStr(busctexto, ">Sprint speed<")
        Find_Stat()
        txt_Agility.Text = playernombre


        'Reactions
        offsetbusc = InStr(busctexto, ">Agility<")
        Find_Stat()
        txt_Reactions.Text = playernombre


        'Balance
        offsetbusc = InStr(busctexto, ">Reactions<")
        Find_Stat()
        txt_Balance.Text = playernombre
        'MsgBox(playernombre)

        'Shot power
        offsetbusc = InStr(busctexto, ">Power<")
        Find_Stat()
        txt_ShotPower.Text = playernombre

        'Jumping
        offsetbusc = InStr(busctexto, ">Shot power<")
        Find_Stat()
        txt_Jumping.Text = playernombre

        'Stamina
        offsetbusc = InStr(busctexto, ">Jumping<")
        Find_Stat()
        txt_Stamina.Text = playernombre

        'Strength
        offsetbusc = InStr(busctexto, ">Stamina<")
        Find_Stat()
        txt_Strength.Text = playernombre

        'Long shots
        offsetbusc = InStr(busctexto, ">Strength<")
        Find_Stat()
        txt_LongShots.Text = playernombre

        'Aggression
        offsetbusc = InStr(busctexto, ">Mentality<")
        Find_Stat()
        txt_Aggression.Text = playernombre

        'Interceptions
        offsetbusc = InStr(busctexto, ">Aggression<")
        Find_Stat()
        txt_Interceptions.Text = playernombre
        txt_Interceptions.Text = Trim(Replace(txt_Interceptions.Text, """", ""))
        txt_Interceptions.Text = Trim(Replace(txt_Interceptions.Text, "<", ""))
        txt_Interceptions.Text = Trim(Replace(txt_Interceptions.Text, ">", ""))

        'Positioning
        offsetbusc = InStr(busctexto, ">Interceptions<")
        Find_Stat()
        txt_Positioning.Text = playernombre
        txt_Positioning.Text = Trim(Replace(txt_Positioning.Text, """", ""))
        txt_Positioning.Text = Trim(Replace(txt_Positioning.Text, "<", ""))
        txt_Positioning.Text = Trim(Replace(txt_Positioning.Text, ">", ""))

        'Vision
        offsetbusc = InStr(busctexto, ">Att. Position<")
        Find_Stat()
        txt_Vision.Text = playernombre

        'Penalties
        offsetbusc = InStr(busctexto, ">Vision<")
        Find_Stat()
        txt_penalties.Text = playernombre

        'Composure
        offsetbusc = InStr(busctexto, ">Penalties<")
        Find_Stat()
        txt_composure.Text = playernombre

        'Marking
        offsetbusc = InStr(busctexto, ">Defending</h5")
        Find_Stat()
        txt_marking.Text = playernombre

        'Standing tackle
        offsetbusc = InStr(busctexto, ">Defensive awareness<")
        Find_Stat()
        txt_stadingTable.Text = playernombre

        'Sliding tackle
        offsetbusc = InStr(busctexto, ">Standing tackle<")
        Find_Stat()
        txt_SlidingTackle.Text = playernombre
        txt_SlidingTackle.Text = Trim(Replace(txt_SlidingTackle.Text, """", ""))
        txt_SlidingTackle.Text = Trim(Replace(txt_SlidingTackle.Text, "<", ""))
        txt_SlidingTackle.Text = Trim(Replace(txt_SlidingTackle.Text, ">", ""))

        'GK diving
        offsetbusc = InStr(busctexto, ">Goalkeeping<")
        Find_Stat()
        txt_GK_dividing.Text = playernombre
        txt_GK_dividing.Text = Trim(Replace(txt_GK_dividing.Text, """", ""))
        txt_GK_dividing.Text = Trim(Replace(txt_GK_dividing.Text, "<", ""))
        txt_GK_dividing.Text = Trim(Replace(txt_GK_dividing.Text, ">", ""))

        'GK handling
        offsetbusc = InStr(busctexto, ">GK Diving<")
        Find_Stat()
        txt_GK_handling.Text = playernombre
        txt_GK_handling.Text = Trim(Replace(txt_GK_handling.Text, """", ""))
        txt_GK_handling.Text = Trim(Replace(txt_GK_handling.Text, "<", ""))
        txt_GK_handling.Text = Trim(Replace(txt_GK_handling.Text, ">", ""))

        'GK kicking
        offsetbusc = InStr(busctexto, ">GK Handling<")
        Find_Stat()
        txt_GK_kicking.Text = playernombre
        txt_GK_kicking.Text = Trim(Replace(txt_GK_kicking.Text, """", ""))
        txt_GK_kicking.Text = Trim(Replace(txt_GK_kicking.Text, "<", ""))
        txt_GK_kicking.Text = Trim(Replace(txt_GK_kicking.Text, ">", ""))

        'GK positioning
        offsetbusc = InStr(busctexto, ">GK Kicking")
        Find_Stat()
        txt_GK_positioning.Text = playernombre
        txt_GK_positioning.Text = Trim(Replace(txt_GK_positioning.Text, """", ""))
        txt_GK_positioning.Text = Trim(Replace(txt_GK_positioning.Text, "<", ""))
        txt_GK_positioning.Text = Trim(Replace(txt_GK_positioning.Text, ">", ""))

        'GK reflexes
        offsetbusc = InStr(busctexto, ">GK Positioning")
        Find_Stat()
        txt_GK_reflexes.Text = playernombre
        txt_GK_reflexes.Text = Trim(Replace(txt_GK_reflexes.Text, """", ""))
        txt_GK_reflexes.Text = Trim(Replace(txt_GK_reflexes.Text, "<", ""))
        txt_GK_reflexes.Text = Trim(Replace(txt_GK_reflexes.Text, ">", ""))

        'Overall Rating
        offsetbusc = InStr(busctexto, "card spacing")
        Find_Stat()
        txt_Overall_Rating.Text = playernombre

        'Potential Rating

        offsetbusc = InStr(busctexto, ">Overall rating<")
        Find_Stat()
        txt_Potential_rating.Text = playernombre



        'we2002 convert==========================================================================================
        Dim EXP_value As Decimal = 1.179
        Dim EXP_IDvalue As Decimal = 1.405
        Dim internationonalReputation As Integer = txt_repInternational.Text

        ProcessPlayerName()

        'heigth
        formmcr.cmbheigth.Text = txt_PlayerHeight.Text


        'club number
        numclub = txt_ClubNumber.Text
        If txt_ClubNumber.Text < 32 Then
            nclub = txt_ClubNumber.Text
        Else
            nclub = 32
        End If
        If txt_ClubNumber.Text = "" Then
            nclub = "32"
        End If
        If txt_ClubNumber.Text = "tm" Then
            nclub = "32"
        End If

        ' nat number
        'If delayweb <= 1500 Then
        numnational = txt_NationalNumber.Text
        If txt_NationalNumber.Text < 32 Then
            nnational = txt_NationalNumber.Text
        Else
            nnational = 32
        End If
        If txt_NationalNumber.Text = "" Then
            nnational = "32"
        End If
        If txt_NationalNumber.Text = "tm" Then
            nnational = "32"
        End If
        If formmcr.Rbt_Club.Checked = True Then
            formmcr.cmbclubnumber.Text = nclub
        Else
            formmcr.cmbclubnumber.Text = nnational

        End If
        'End If
        ProcessPlayerName2()



        formmcr.txtfechanacimiento.Text = txt_PlayerAge.Text
        formmcr.txtclub.Text = txt_ClubActual.Text

        formmcr.txtnacionalidad.Text = txt_Country.Text

        Dim Position As String = txt_Position.Text
        If Position = "SUB" Or Position = "RES" Then
            Select Case jobtitle
                Case "Goalkeeper"
                    formmcr.cmbposition.Text = "gk"
                    formmcr.cmbposition.BackColor = Color.DarkGoldenrod

                Case "Center back"
                    formmcr.cmbposition.Text = "cb"
                    formmcr.cmbposition.BackColor = Color.LightSeaGreen

                Case "Left back", "Right back", "Left wing back", "Right wing back"
                    formmcr.cmbposition.Text = "sb"
                    formmcr.cmbposition.BackColor = Color.LightSeaGreen

                Case "Center midfield", "Central defensive midfielder"
                    formmcr.cmbposition.Text = "dh"
                    formmcr.cmbposition.BackColor = Color.DarkSeaGreen

                Case "Left midfield", "Right midfield"
                    formmcr.cmbposition.Text = "sh"
                    formmcr.cmbposition.BackColor = Color.DarkSeaGreen

                Case "Central attacking midfielder"
                    formmcr.cmbposition.Text = "oh"
                    formmcr.cmbposition.BackColor = Color.DarkSeaGreen

                Case "Striker", "Center forward"
                    formmcr.cmbposition.Text = "cf"
                    formmcr.cmbposition.BackColor = Color.PaleVioletRed


                Case "Left winger", "Right winger"
                    formmcr.cmbposition.Text = "wg"
                    formmcr.cmbposition.BackColor = Color.PaleVioletRed

            End Select
        Else
            Select Case Position
                Case "GK"
                    formmcr.cmbposition.Text = "gk"
                    formmcr.cmbposition.BackColor = Color.DarkGoldenrod

                Case "CB", "LCB", "RCB"
                    formmcr.cmbposition.Text = "cb"
                    formmcr.cmbposition.BackColor = Color.LightSeaGreen

                Case "LB", "RB", "LWB", "RWB"
                    formmcr.cmbposition.Text = "sb"
                    formmcr.cmbposition.BackColor = Color.LightSeaGreen

                Case "CM", "LCM", "RCM", "CDM", "LDM", "RDM"
                    formmcr.cmbposition.Text = "dh"
                    formmcr.cmbposition.BackColor = Color.DarkSeaGreen

                Case "LM", "RM"
                    formmcr.cmbposition.Text = "sh"
                    formmcr.cmbposition.BackColor = Color.DarkSeaGreen

                Case "CAM", "LAM", "RAM"
                    formmcr.cmbposition.Text = "oh"
                    formmcr.cmbposition.BackColor = Color.DarkSeaGreen

                Case "CF", "RF", "LF", "ST", "RS", "LS"
                    formmcr.cmbposition.Text = "cf"
                    formmcr.cmbposition.BackColor = Color.PaleVioletRed


                Case "LW", "RW"
                    formmcr.cmbposition.Text = "wg"
                    formmcr.cmbposition.BackColor = Color.PaleVioletRed

            End Select
        End If


        'national team
        formmcr.txt_nat_team.Text = txt_NationalTeam.Text

        'best position

        Select Case bestposition
            Case "GK"
                formmcr.BTN_BESTPOSITION.Text = "gk"
                formmcr.BTN_BESTPOSITION.BackColor = Color.DarkGoldenrod

            Case "CB", "LCB", "RCB"
                formmcr.BTN_BESTPOSITION.Text = "cb"
                formmcr.BTN_BESTPOSITION.BackColor = Color.LightSeaGreen

            Case "LB", "RB", "LWB", "RWB"
                formmcr.BTN_BESTPOSITION.Text = "sb"
                formmcr.BTN_BESTPOSITION.BackColor = Color.LightSeaGreen

            Case "CM", "LCM", "RCM", "CDM", "LDM", "RDM"
                formmcr.BTN_BESTPOSITION.Text = "dh"
                formmcr.BTN_BESTPOSITION.BackColor = Color.DarkSeaGreen

            Case "LM", "RM"
                formmcr.BTN_BESTPOSITION.Text = "sh"
                formmcr.BTN_BESTPOSITION.BackColor = Color.DarkSeaGreen

            Case "CAM", "LAM", "RAM"
                formmcr.BTN_BESTPOSITION.Text = "oh"
                formmcr.BTN_BESTPOSITION.BackColor = Color.DarkSeaGreen

            Case "CF", "RF", "LF", "ST", "RS", "LS"
                formmcr.BTN_BESTPOSITION.Text = "cf"
                formmcr.BTN_BESTPOSITION.BackColor = Color.PaleVioletRed


            Case "LW", "RW"
                formmcr.BTN_BESTPOSITION.Text = "wg"
                formmcr.BTN_BESTPOSITION.BackColor = Color.PaleVioletRed

        End Select
        'body

        Dim calcbody As Integer
        Dim calcheigthfix As Double
        stat2 = txt_PlayerHeight.Text
        stat3 = txt_PlayerWeight.Text

        If stat2 >= 150 And stat2 <= 165 Then calcheigthfix = 1.4
        If stat2 >= 166 And stat2 <= 170 Then calcheigthfix = 1.25
        If stat2 >= 171 And stat2 <= 175 Then calcheigthfix = 1.1
        If stat2 >= 176 And stat2 <= 180 Then calcheigthfix = 0.95
        If stat2 >= 181 And stat2 <= 185 Then calcheigthfix = 0.93
        If stat2 >= 186 And stat2 <= 190 Then calcheigthfix = 0.91
        If stat2 >= 191 And stat2 <= 195 Then calcheigthfix = 0.89
        If stat2 >= 196 And stat2 <= 200 Then calcheigthfix = 0.87
        If stat2 >= 201 And stat2 <= 220 Then calcheigthfix = 0.85


        If formmcr.rbtn_Male.Checked = True Then
            calcbody = (calcheigthfix * stat3)

            If calcbody >= 50 And calcbody <= 64 Then formmcr.cmbbody.Text = "a"
            If calcbody >= 65 And calcbody <= 69 Then formmcr.cmbbody.Text = "b"
            If calcbody >= 70 And calcbody <= 74 Then formmcr.cmbbody.Text = "c"
            If calcbody >= 75 And calcbody <= 79 Then formmcr.cmbbody.Text = "d"
            If calcbody >= 80 And calcbody <= 84 Then formmcr.cmbbody.Text = "e"
            If calcbody >= 85 And calcbody <= 89 Then formmcr.cmbbody.Text = "f"
            If calcbody >= 90 And calcbody <= 94 Then formmcr.cmbbody.Text = "g"
            If calcbody >= 95 And calcbody <= 110 Then formmcr.cmbbody.Text = "h"
        Else
            formmcr.cmbbody.Text = "a"
        End If
        'foto
        If fotosofifa <> "" Then

            'cargar predetermindada
            formmcr.PictureFifa.Image = Nothing
            formmcr.PictureFifa.Load(My.Computer.FileSystem.CurrentDirectory & "/player_0.png")
            'cargar foto
            formmcr.PictureFifa.Load(cargafoto)
            'Clipboard.SetText(cargafoto)
            formmcr.PictureFifa.Image.Save(My.Computer.FileSystem.CurrentDirectory & "/tempfotofifa.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
        End If


        ''Age

        Dim calcage As Integer

        Dim fechact As Date = Date.Now
        Dim fechaborn As Date = txt_PlayerAge.Text

        If fechact.Month >= fechaborn.Month Then

            calcage = (fechact.Year - fechaborn.Year)
        Else
            calcage = fechact.Year - fechaborn.Year - 1


        End If
        formmcr.cmbage.Text = calcage

        'foot
        If txt_weakFoot.Text > 4 And x = 1 Then
            formmcr.cmbfood.Text = "b"
        Else
            formmcr.cmbfood.Text = txt_foot.Text
        End If


        'STATS CONVERTION WE2002

        If rbtonline.Checked = True Then

            'offence
            stat1 = txt_Positioning.Text
            LeerRangoPlayer()


            formmcr.cmboffense.Text = resultstat


            'deffense
            Dim calcdeffense As Integer
            Dim markingvalue As Integer
            Dim slidingtackle As Integer
            Dim taclevalue As Integer


            If formmcr.cmbposition.Text = "gk" Then

                markingvalue = txt_GK_dividing.Text
                taclevalue = txt_GK_reflexes.Text
                calcdeffense = (markingvalue + taclevalue) / 2
                stat1 = calcdeffense

                LeerOffenceGK()

            Else
                markingvalue = txt_marking.Text
                taclevalue = txt_stadingTable.Text
                slidingtackle = txt_SlidingTackle.Text
                calcdeffense = (markingvalue + taclevalue + slidingtackle) / 3
                stat1 = calcdeffense


                LeerDeffen_Pass()

            End If

            formmcr.cmbdeffense.Text = resultstat




            'body balance
            If formmcr.cmbposition.Text = "gk" Then
                stat1 = txt_Strength.Text + 12

                LeerOffenceGK()
            Else
                stat1 = txt_Strength.Text
                LeerRangoPlayer()
            End If



            If formmcr.cmbposition.Text = "gk" Then
                If resultstat < 16 Then
                    formmcr.cmbbodybalance.Text = 16
                Else
                    formmcr.cmbbodybalance.Text = resultstat
                End If
            Else
                If resultstat < 14 Then
                    formmcr.cmbbodybalance.Text = 14
                Else
                    formmcr.cmbbodybalance.Text = resultstat
                End If

            End If





            'stamina
            stat1 = txt_Stamina.Text
            LeerRangoPlayer()


            formmcr.cmbstamina.Text = resultstat




            'speed
            stat1 = txt_SprintSpeed.Text
            If rbtonline.Checked = True Then

                LeerSpeed_accOnline()
            Else
                LeerRangoPlayer()
            End If


            formmcr.cmbspeed.Text = resultstat



            'aceleration

            stat1 = txt_Acceleration.Text
            If rbtonline.Checked = True Then
                LeerSpeed_accOnline()
            Else
                LeerRangoPlayer()
            End If


            formmcr.cmbaceleration.Text = resultstat


            'pass
            stat2 = txt_Short_passing.Text
            stat3 = txt_LongPassing.Text
            promedio = (stat2 + stat3) / 2
            stat1 = promedio

            LeerDeffen_Pass()


            formmcr.cmbpass.Text = resultstat



            'shot power
            stat1 = txt_ShotPower.Text
            If rbtonline.Checked = True Then
                LeerSpeed_accOnline()

            Else
                LeerRangoPlayer()
            End If

            formmcr.cmbshotpower.Text = resultstat


            'shot acc
            stat1 = Txt_Finishing.Text
            LeerRangoPlayer()

            formmcr.cmbshotacc.Text = resultstat

            'jump
            stat1 = txt_Jumping.Text
            LeerRangoPlayer()

            formmcr.cmbjump.Text = resultstat




            'head acc
            stat1 = Txt_headAcc.Text
            LeerRangoPlayer()

            formmcr.cmbhead.Text = resultstat



            'ball control
            stat1 = TxtBallControl.Text
            LeerRangoPlayer()

            formmcr.cmbtechnique.Text = resultstat



            'dribbling
            stat1 = Txt_Dribbling.Text
            LeerRangoPlayer()

            formmcr.cmbdribble.Text = resultstat


            'curve
            'stat1 = Txt_curve.Text
            'LeerRangoPlayer()

            stat1 = Txt_FreeKickAcc.Text
            LeerRangoPlayer()

            formmcr.cmbcurve.Text = resultstat


            'agresive
            Dim aggrValue As Integer = 0

            If BuffoAgression = "++" Then
                aggrValue = 8
            ElseIf BuffoAgression = "+" Then
                aggrValue = 4
            End If

            stat1 = txt_Aggression.Text
            If formmcr.cmbposition.Text = "gk" Then
                LeerAgressionGK()
            Else

                Dim AttackPos As Integer = txt_Positioning.Text
                Dim Vision As Integer = txt_Vision.Text
                Dim Composture As Integer = txt_composure.Text
                Dim Velocidad As Integer = txt_SprintSpeed.Text
                stat2 = (Vision + Composture) / 2
                stat3 = (AttackPos + stat2) / 2
                stat1 = (stat3) + aggrValue

                'End If
                LeerRangoPlayer()
            End If


            formmcr.cmbaggression.Text = resultstat



            'response


            If formmcr.cmbposition.Text = "gk" Then


                stat1 = txt_GK_reflexes.Text
                LeerResponseGk()

            Else
                stat1 = txt_Reactions.Text
                LeerRangoPlayer()
            End If

            formmcr.cmbresponse.Text = resultstat



            'outsidee
            stat1 = Txt_Crossing.Text
            If stat1 >= Options.cmb_feedoutside.Text Then
                formmcr.cmbfeedoutside.Text = "yes"
            Else
                formmcr.cmbfeedoutside.Text = "no"
            End If

            If formmcr.chekbootsramdon.Checked Then
                Dim numeroAleatorio As New Random()
                Dim valorAleatorio As Integer = numeroAleatorio.Next(0, 8)
                formmcr.cmbboots.SelectedIndex = valorAleatorio
            End If



        Else

            'OFLINE STATS PSD TO WE2002
            'offence

            stat2 = txt_Positioning.Text
            stat3 = txt_Reactions.Text
            promedio = ((stat2 + stat2 + stat3) / 3)
            If formmcr.cmbposition.Text = "cb" Then

                stat1 = 20 + promedio / EXP_IDvalue
                LeerRangoPlayer()
            Else


                stat1 = 25 + promedio / EXP_IDvalue
                LeerRangoPlayer()

            End If
            formmcr.cmboffense.Text = resultstat


            'deffense
            Dim calcdeffense As Integer
            Dim markingvalue As Integer
            Dim taclevalue As Integer


            If formmcr.cmbposition.Text = "gk" Then
                markingvalue = txt_GK_dividing.Text
                taclevalue = txt_GK_positioning.Text
                calcdeffense = (markingvalue + taclevalue) / 2
                promedio = calcdeffense
                stat1 = 25 + promedio / EXP_IDvalue

                LeerOffenceGK()

            End If

            If formmcr.cmbposition.Text = "cb" Then

                markingvalue = txt_marking.Text
                taclevalue = txt_stadingTable.Text
                calcdeffense = (markingvalue + markingvalue + taclevalue) / 3
                promedio = calcdeffense
                stat1 = 25 + promedio / EXP_IDvalue
                LeerDeffen_Pass()

            End If

            If formmcr.cmbposition.Text <> "cb" And formmcr.cmbposition.Text <> "gk" Then

                markingvalue = txt_marking.Text
                taclevalue = txt_stadingTable.Text
                calcdeffense = (markingvalue + markingvalue + taclevalue) / 3
                promedio = 25 + calcdeffense / EXP_IDvalue
                stat1 = 15 + promedio / 1.238

                LeerDeffen_Pass()

            End If

            formmcr.cmbdeffense.Text = resultstat



            'body balance
            Dim weigthxp As Integer = txt_PlayerHeight.Text - 100
            If formmcr.cmbposition.Text = "gk" Then
                stat2 = txt_Strength.Text
                stat3 = txt_GK_positioning.Text
                promedio = (stat2 + stat3 + weigthxp) / 3
                stat1 = 15 + promedio / EXP_IDvalue
                LeerRangoPlayer()

            Else

                stat2 = txt_Strength.Text
                stat3 = txt_Balance.Text
                If stat2 > stat3 Then
                    promedio = stat2
                    stat1 = 15 + promedio / EXP_value
                    LeerRangoPlayer()
                Else
                    promedio = (stat2 + stat3) / 2
                    stat1 = 15 + promedio / EXP_value
                    LeerRangoPlayer()
                End If
            End If


            formmcr.cmbbodybalance.Text = resultstat


            'stamina
            stat2 = txt_Stamina.Text
            stat1 = 25 + stat2 / EXP_IDvalue

            LeerRangoPlayer()


            formmcr.cmbstamina.Text = resultstat


            'speed
            stat2 = txt_SprintSpeed.Text
            stat1 = 15 + stat2 / EXP_value
            If rbtonline.Checked = True Then

                LeerSpeed_accOnline()
            Else
                LeerRangoPlayer()
            End If
            formmcr.cmbspeed.Text = resultstat


            'aceleration

            stat2 = txt_Acceleration.Text
            stat1 = 15 + stat2 / EXP_value
            LeerRangoPlayer()
            formmcr.cmbaceleration.Text = resultstat


            'pass
            stat2 = txt_Short_passing.Text
            stat3 = txt_LongPassing.Text
            promedio = (stat2 + stat3) / 2
            stat1 = 25 + promedio / EXP_IDvalue
            LeerDeffen_Pass()
            formmcr.cmbpass.Text = resultstat

            'shot power
            If formmcr.cmbposition.Text = "gk" Then
                stat2 = txt_GK_kicking.Text
                stat1 = 15 + stat2 / EXP_value
                LeerRangoPlayer()
            Else
                stat2 = txt_ShotPower.Text
                stat1 = 15 + stat2 / EXP_value
                LeerRangoPlayer()
            End If
            formmcr.cmbshotpower.Text = resultstat

            'shot acc
            stat2 = Txt_Finishing.Text
            stat1 = 25 + stat2 / EXP_IDvalue
            LeerRangoPlayer()
            formmcr.cmbshotacc.Text = resultstat

            'jump
            stat2 = txt_Jumping.Text
            stat1 = 15 + stat2 / EXP_value
            LeerRangoPlayer()
            formmcr.cmbjump.Text = resultstat


            'head acc
            stat2 = Txt_headAcc.Text
            stat1 = 25 + stat2 / EXP_IDvalue
            LeerRangoPlayer()
            formmcr.cmbhead.Text = resultstat


            'ball control
            stat2 = TxtBallControl.Text
            stat1 = 25 + stat2 / EXP_IDvalue
            LeerRangoPlayer()
            formmcr.cmbtechnique.Text = resultstat


            'dribbling
            stat3 = Txt_Dribbling.Text
            stat2 = TxtBallControl.Text
            promedio = (stat3 + stat2) / 2
            stat1 = 25 + promedio / EXP_IDvalue
            LeerRangoPlayer()
            formmcr.cmbdribble.Text = resultstat


            'curve
            stat2 = Txt_FreeKickAcc.Text
            stat1 = 15 + stat2 / EXP_value
            LeerRangoPlayer()
            formmcr.cmbcurve.Text = resultstat


            'agresive
            If formmcr.cmbposition.Text = "gk" Then
                stat2 = txt_Aggression.Text
                promedio = stat2
                stat1 = promedio
                LeerAgressionGK()
            Else
                If formmcr.cmbposition.Text = "cb" Then
                    stat2 = txt_Reactions.Text
                    stat3 = txt_Positioning.Text
                    promedio = (stat2 + stat3) / 2
                    stat1 = 15 + promedio / EXP_value
                    LeerRangoPlayer()
                Else
                    stat2 = txt_Reactions.Text
                    stat3 = txt_repInternational.Text
                    promedio = stat2 + stat3
                    stat1 = 25 + promedio / EXP_IDvalue
                    LeerRangoPlayer()
                End If

            End If
            formmcr.cmbaggression.Text = resultstat

            'response

            If formmcr.cmbposition.Text = "gk" Then

                stat2 = txt_GK_reflexes.Text
                stat1 = 25 + stat2 / 1.405
                LeerResponseGk()

            Else
                stat2 = txt_Reactions.Text
                stat3 = txt_Interceptions.Text
                If stat2 > stat3 Then
                    stat1 = (25 + stat2) / EXP_IDvalue
                    LeerRangoPlayer()
                Else
                    stat1 = (25 + stat3) / EXP_IDvalue
                    LeerRangoPlayer()
                End If

            End If
            formmcr.cmbresponse.Text = resultstat

            'outsidee
            stat1 = (TxtBallControl.Text * 0.3) + (Txt_curve.Text * 0.7)
            If stat1 >= Options.cmb_feedoutside.Text Then
                formmcr.cmbfeedoutside.Text = "yes"
            Else
                formmcr.cmbfeedoutside.Text = "no"
            End If

            If formmcr.chekbootsramdon.Checked Then
                Dim numeroAleatorio As New Random()
                Dim valorAleatorio As Integer = numeroAleatorio.Next(0, 8)
                formmcr.cmbboots.SelectedIndex = valorAleatorio
            End If
        End If

        'apariencia
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\tempfotofifa.bmp"
        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        Dim offsetcolorpiel As Integer

        Dim colorpiel As Byte
        Dim lectorhex As Integer
        Dim bytehex As Integer
        Dim piel As String

        '5091
        offsetcolorpiel = 3499

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex



        offsetcolorpiel = 3535

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex


        offsetcolorpiel = 3679

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex


        offsetcolorpiel = 3751

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex


        offsetcolorpiel = 3791

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex

        offsetcolorpiel = 291631

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex

        offsetcolorpiel = 285915

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex

        offsetcolorpiel = 284443

        FileGet(3, colorpiel, offsetcolorpiel)
        lectorhex = (colorpiel)
        bytehex = bytehex + lectorhex


        bytehex = bytehex / 8




        If bytehex >= 126 And bytehex <= 255 Then
            formmcr.cmbskincolor.SelectedIndex = 0


        End If
        If bytehex >= 111 And bytehex <= 125 Then
            formmcr.cmbskincolor.SelectedIndex = 1


        End If
        If bytehex >= 81 And bytehex <= 112 Then
            formmcr.cmbskincolor.SelectedIndex = 2


        End If
        If bytehex >= 0 And bytehex <= 80 Then
            formmcr.cmbskincolor.SelectedIndex = 3


        End If


        indexcmbskikcolour = formmcr.cmbskincolor.Text
        indexcmbhaircolor = formmcr.cmbhaircolor.Text
        indexcmbhairface = formmcr.cmbhairface.SelectedIndex
        indexcmbhair = formmcr.cmbhair.SelectedIndex
        indexcmbhaircolourface = formmcr.cmbhaircolorface.Text



        SKINCOLOUR()
        'MsgBox(bytehex)

        FileClose()


        LoadDataIntoTextBoxes()


        'End If


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        WebView21.GoBack()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        WebView21.GoForward()
    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        WebView21.Reload()

    End Sub

    Private Sub EasyMCRToolStripMenuItem_Click(sender As Object, e As EventArgs)

        formmcr.Show()

    End Sub

    Private Sub BDWe2002ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        formmcr.Hide()


    End Sub


    Private Sub btnplayerfifavisibe()
        btnplayer1.Visible = visiblebtnplayerfifa
        Btnplayer2.Visible = visiblebtnplayerfifa
        btnplayer3.Visible = visiblebtnplayerfifa
        BtnPlayer4.Visible = visiblebtnplayerfifa
        btnplayer5.Visible = visiblebtnplayerfifa
        btnplayer6.Visible = visiblebtnplayerfifa
        btnplayer7.Visible = visiblebtnplayerfifa
        btnplayer8.Visible = visiblebtnplayerfifa
        btnplayer9.Visible = visiblebtnplayerfifa
        btnplayer10.Visible = visiblebtnplayerfifa
        btnplayer11.Visible = visiblebtnplayerfifa
        btnplayer12.Visible = visiblebtnplayerfifa
        btnplayer13.Visible = visiblebtnplayerfifa
        btnplayer14.Visible = visiblebtnplayerfifa
        btnplayer15.Visible = visiblebtnplayerfifa
        btnplayer16.Visible = visiblebtnplayerfifa
        btnplayer17.Visible = visiblebtnplayerfifa
        btnplayer18.Visible = visiblebtnplayerfifa
        btnplayer19.Visible = visiblebtnplayerfifa
        btnplayer20.Visible = visiblebtnplayerfifa
        btnplayer21.Visible = visiblebtnplayerfifa
        btnplayer22.Visible = visiblebtnplayerfifa
        btnplayer23.Visible = visiblebtnplayerfifa
        btnplayer24.Visible = visiblebtnplayerfifa
        btnplayer25.Visible = visiblebtnplayerfifa
        btnplayer26.Visible = visiblebtnplayerfifa
        btnplayer27.Visible = visiblebtnplayerfifa
        btnplayer28.Visible = visiblebtnplayerfifa
        btnplayer29.Visible = visiblebtnplayerfifa
        btnplayer30.Visible = visiblebtnplayerfifa
        btnplayer31.Visible = visiblebtnplayerfifa
        btnplayer32.Visible = visiblebtnplayerfifa
        btnplayer33.Visible = visiblebtnplayerfifa
        lblPosPlayer1.Visible = visiblebtnplayerfifa
        lblPosPlayer2.Visible = visiblebtnplayerfifa
        lblPosPlayer3.Visible = visiblebtnplayerfifa
        lblPosPlayer4.Visible = visiblebtnplayerfifa
        lblPosPlayer5.Visible = visiblebtnplayerfifa
        lblPosPlayer6.Visible = visiblebtnplayerfifa
        lblPosPlayer7.Visible = visiblebtnplayerfifa
        lblPosPlayer8.Visible = visiblebtnplayerfifa
        lblPosPlayer9.Visible = visiblebtnplayerfifa
        lblPosPlayer10.Visible = visiblebtnplayerfifa
        lblPosPlayer11.Visible = visiblebtnplayerfifa
        lblPosPlayer12.Visible = visiblebtnplayerfifa
        lblPosPlayer13.Visible = visiblebtnplayerfifa
        lblPosPlayer14.Visible = visiblebtnplayerfifa
        lblPosPlayer15.Visible = visiblebtnplayerfifa
        lblPosPlayer16.Visible = visiblebtnplayerfifa
        lblPosPlayer17.Visible = visiblebtnplayerfifa
        lblPosPlayer18.Visible = visiblebtnplayerfifa
        lblPosPlayer19.Visible = visiblebtnplayerfifa
        lblPosPlayer20.Visible = visiblebtnplayerfifa
        lblPosPlayer21.Visible = visiblebtnplayerfifa
        lblPosPlayer22.Visible = visiblebtnplayerfifa
        lblPosPlayer23.Visible = visiblebtnplayerfifa
        lblPosPlayer24.Visible = visiblebtnplayerfifa
        lblPosPlayer25.Visible = visiblebtnplayerfifa
        lblPosPlayer26.Visible = visiblebtnplayerfifa
        lblPosPlayer27.Visible = visiblebtnplayerfifa
        lblPosPlayer28.Visible = visiblebtnplayerfifa
        lblPosPlayer29.Visible = visiblebtnplayerfifa
        lblPosPlayer30.Visible = visiblebtnplayerfifa
        lblPosPlayer31.Visible = visiblebtnplayerfifa
        lblPosPlayer32.Visible = visiblebtnplayerfifa
        lblPosPlayer33.Visible = visiblebtnplayerfifa
    End Sub

    Private Sub allplayers()

        visiblebtnplayerfifa = True
        btnplayerfifavisibe()
        btnplayer1.BackColor = Color.FromArgb(45, 45, 48)
        Btnplayer2.BackColor = Color.FromArgb(45, 45, 48)
        btnplayer3.BackColor = Color.FromArgb(45, 45, 48)
        BtnPlayer4.BackColor = Color.FromArgb(45, 45, 48)
        btnplayer5.BackColor = Color.FromArgb(45, 45, 48)
        btnplayer6.BackColor = Color.FromArgb(45, 45, 48)
        btnplayer7.BackColor = Color.FromArgb(45, 45, 48)
        btnplayer8.BackColor = Color.FromArgb(45, 45, 48)
        btnplayer9.BackColor = Color.FromArgb(45, 45, 48)
        btnplayer10.BackColor = Color.FromArgb(45, 45, 48)
        btnplayer11.BackColor = Color.FromArgb(45, 45, 48)
        btnplayer12.BackColor = Color.FromArgb(50, 50, 54)
        btnplayer13.BackColor = Color.FromArgb(50, 50, 54)
        btnplayer14.BackColor = Color.FromArgb(50, 50, 54)
        btnplayer15.BackColor = Color.FromArgb(50, 50, 54)
        btnplayer16.BackColor = Color.FromArgb(50, 50, 54)
        btnplayer17.BackColor = Color.FromArgb(50, 50, 54)
        btnplayer18.BackColor = Color.FromArgb(50, 50, 54)
        btnplayer19.BackColor = Color.FromArgb(50, 50, 54)
        btnplayer20.BackColor = Color.FromArgb(50, 50, 54)
        btnplayer21.BackColor = Color.FromArgb(50, 50, 54)
        btnplayer22.BackColor = Color.FromArgb(50, 50, 54)
        btnplayer23.BackColor = Color.FromArgb(50, 50, 54)
        btnplayer24.BackColor = Color.FromArgb(38, 38, 40)
        btnplayer25.BackColor = Color.FromArgb(38, 38, 40)
        btnplayer26.BackColor = Color.FromArgb(38, 38, 40)
        btnplayer27.BackColor = Color.FromArgb(38, 38, 40)
        btnplayer28.BackColor = Color.FromArgb(38, 38, 40)
        btnplayer29.BackColor = Color.FromArgb(38, 38, 40)
        btnplayer30.BackColor = Color.FromArgb(38, 38, 40)
        btnplayer31.BackColor = Color.FromArgb(38, 38, 40)
        btnplayer32.BackColor = Color.FromArgb(38, 38, 40)
        btnplayer33.BackColor = Color.FromArgb(38, 38, 40)
        lblPosPlayer1.Text = ""
        lblPosPlayer2.Text = ""
        lblPosPlayer3.Text = ""
        lblPosPlayer4.Text = ""
        lblPosPlayer5.Text = ""
        lblPosPlayer6.Text = ""
        lblPosPlayer7.Text = ""
        lblPosPlayer8.Text = ""
        lblPosPlayer9.Text = ""
        lblPosPlayer10.Text = ""
        lblPosPlayer11.Text = ""
        lblPosPlayer12.Text = ""
        lblPosPlayer13.Text = ""
        lblPosPlayer14.Text = ""
        lblPosPlayer15.Text = ""
        lblPosPlayer16.Text = ""
        lblPosPlayer17.Text = ""
        lblPosPlayer18.Text = ""
        lblPosPlayer19.Text = ""
        lblPosPlayer20.Text = ""
        lblPosPlayer21.Text = ""
        lblPosPlayer22.Text = ""
        lblPosPlayer23.Text = ""
        lblPosPlayer24.Text = ""
        lblPosPlayer25.Text = ""
        lblPosPlayer26.Text = ""
        lblPosPlayer27.Text = ""
        lblPosPlayer28.Text = ""
        lblPosPlayer29.Text = ""
        lblPosPlayer30.Text = ""
        lblPosPlayer31.Text = ""
        lblPosPlayer32.Text = ""
        lblPosPlayer33.Text = ""


        busctexto = RichTextBox1.Text

        Dim rxRows As New Regex("<tr[^>]*>.*?</tr>", RegexOptions.Singleline)
        Dim filas As MatchCollection = rxRows.Matches(busctexto)

        Dim i As Integer = 0

        For Each fila As Match In filas

            If i >= botones.Length Then Exit For

            Dim filaHtml As String = fila.Value

            ' ===== LINK =====
            Dim rxLink As New Regex("<a href=""(/player/[^""]+)""")
            Dim m As Match = rxLink.Match(filaHtml)

            ' 🚫 si no hay jugador → saltar fila
            If Not m.Success Then Continue For

            botones(i).Tag = "https://sofifa.com" & m.Groups(1).Value

            ' ===== NOMBRE =====
            Dim rxName As New Regex("<a href=""/player/[^""]+"".*?>([^<]+)</a>")
            m = rxName.Match(filaHtml)
            botones(i).Text = If(m.Success, m.Groups(1).Value.Trim(), "")

            ' ===== POSICIÓN =====
            Dim rxPos As New Regex("<span class=""pos pos\d+"">([^<]+)</span>")
            m = rxPos.Match(filaHtml)
            posplayer = If(m.Success, m.Groups(1).Value.Trim(), "")

            ' ===== TU EVENTO =====
            positionjug()
            labelsPos(i).Text = playerposition
            labelsPos(i).BackColor = COLORPOSITION
            labelsPos(i).AutoSize = False
            labelsPos(i).Height = 15
            labelsPos(i).Width = 30

            i += 1
        Next


    End Sub

    Private Sub btnplayer_Click(sender As Object, e As EventArgs) _
    Handles btnplayer1.Click, Btnplayer2.Click, btnplayer3.Click, BtnPlayer4.Click,
            btnplayer5.Click, btnplayer6.Click, btnplayer7.Click, btnplayer8.Click,
            btnplayer9.Click, btnplayer10.Click, btnplayer11.Click, btnplayer12.Click,
            btnplayer13.Click, btnplayer14.Click, btnplayer15.Click, btnplayer16.Click,
            btnplayer17.Click, btnplayer18.Click, btnplayer19.Click, btnplayer20.Click,
            btnplayer21.Click, btnplayer22.Click, btnplayer23.Click, btnplayer24.Click,
            btnplayer25.Click, btnplayer26.Click, btnplayer27.Click, btnplayer28.Click,
            btnplayer29.Click, btnplayer30.Click, btnplayer31.Click, btnplayer32.Click,
            btnplayer33.Click

        Dim btn As Button = CType(sender, Button)


        ' marcar el presionado
        btn.BackColor = Color.WhiteSmoke

        '  abrir link
        If btn.Tag IsNot Nothing AndAlso btn.Tag.ToString() <> "" Then
            WebView22.Source = New Uri(btn.Tag.ToString())
        End If
    End Sub
    Private Async Sub Btn_tm_player_Click(sender As Object, e As EventArgs) _
Handles Btn_tm_player1.Click, btn_tm_player2.Click, btn_tm_player3.Click, btn_tm_player4.Click,
        btn_tm_player5.Click, btn_tm_player6.Click, btn_tm_player7.Click, btn_tm_player8.Click,
        btn_tm_player9.Click, btn_tm_player10.Click, btn_tm_player11.Click, btn_tm_player12.Click,
        btn_tm_player13.Click, btn_tm_player14.Click, btn_tm_player15.Click, btn_tm_player16.Click,
        btn_tm_player17.Click, btn_tm_player18.Click, btn_tm_player19.Click, btn_tm_player20.Click,
        btn_tm_player21.Click, btn_tm_player22.Click, btn_tm_player23.Click, btn_tm_player24.Click,
        btn_tm_player25.Click, btn_tm_player26.Click, btn_tm_player27.Click, btn_tm_player28.Click,
        btn_tm_player29.Click, btn_tm_player30.Click, btn_tm_player31.Click, btn_tm_player32.Click,
        btn_tm_player33.Click, btn_tm_player34.Click, btn_tm_player35.Click, btn_tm_player36.Click,
        btn_tm_player37.Click, btn_tm_player38.Click, btn_tm_player39.Click, btn_tm_player40.Click

        Dim btn As Button = CType(sender, Button)

        ' 👇 AQUÍ está lo que buscabas
        Dim index As Integer = CInt(btn.Tag)

        Dim nombre As String = btn.Text
        Dim numero As String = rn_number(index)

        ' --- tu lógica ---
        If selectFM_Sofifa = 0 Then

            Await EjecutarBusquedaPorNombre(nombre)

        ElseIf selectFM_Sofifa = 2 Then

            WebView22.Source = New Uri(
        "https://www.pesmaster.com/efootball-2022/?q=" &
        Uri.EscapeDataString(nombre)
    )

        Else

            WebView22.Source = New Uri(
        "https://sofifa.com/players?keyword=" &
        Uri.EscapeDataString(nombre)
    )

            txt_PlayerSofifa.Text = nombre
            txt_CustomPlayerSofifa.Text = nombre

        End If

        formmcr.cmbclubnumber.Text = numero
        btn.BackColor = Color.Lavender

        If clubnombre = "" Then
            formmcr.txtclub.Text = club
        End If

    End Sub

    Private Sub rbtonline_CheckedChanged(sender As Object, e As EventArgs) Handles rbtonline.CheckedChanged
        If rbtonline.Checked = True Then rtbnormal.Checked = False
    End Sub

    Private Sub rtbnormal_CheckedChanged(sender As Object, e As EventArgs) Handles rtbnormal.CheckedChanged
        If rtbnormal.Checked = True Then rbtonline.Checked = False
    End Sub

    Private Sub visiblebtnTM()
        For i As Integer = 1 To 40
            Dim btn As Button = CType(Me.Controls($"btn_tm_player{i}"), Button)
            If btn IsNot Nothing Then
                btn.Visible = visiblebtnplayerTM
            End If
        Next
    End Sub

    Private Sub ColorButtonTM()
        For i As Integer = 1 To 32
            Dim btn As Button = CType(Me.Controls($"btn_tm_player{i}"), Button)
            If btn IsNot Nothing Then
                btn.BackColor = Color.FromArgb(37, 37, 38)
            End If
        Next
    End Sub

    Dim club As String
    Private Sub EliminarChar()
        club = Trim(Replace(club, """", ""))
        club = Trim(Replace(club, "0", ""))
        club = Trim(Replace(club, "1", ""))
        club = Trim(Replace(club, "2", ""))
        club = Trim(Replace(club, "3", ""))
        club = Trim(Replace(club, "4", ""))
        club = Trim(Replace(club, "5", ""))
        club = Trim(Replace(club, "6", ""))
        club = Trim(Replace(club, "7", ""))
        club = Trim(Replace(club, "8", ""))
        club = Trim(Replace(club, "9", ""))
        club = Trim(Replace(club, "/", ""))
        club = Trim(Replace(club, ">", ""))
        club = Trim(Replace(club, vbLf, ""))
    End Sub
    Private Sub NamePlayerChar()
        nameplayer1 = Trim(Replace(nameplayer1, """", ""))
        nameplayer1 = Trim(Replace(nameplayer1, "0", ""))
        nameplayer1 = Trim(Replace(nameplayer1, "1", ""))
        nameplayer1 = Trim(Replace(nameplayer1, "2", ""))
        nameplayer1 = Trim(Replace(nameplayer1, "3", ""))
        nameplayer1 = Trim(Replace(nameplayer1, "4", ""))
        nameplayer1 = Trim(Replace(nameplayer1, "5", ""))
        nameplayer1 = Trim(Replace(nameplayer1, "6", ""))
        nameplayer1 = Trim(Replace(nameplayer1, "7", ""))
        nameplayer1 = Trim(Replace(nameplayer1, "8", ""))
        nameplayer1 = Trim(Replace(nameplayer1, "9", ""))
        nameplayer1 = Trim(Replace(nameplayer1, "/", ""))
        nameplayer1 = Trim(Replace(nameplayer1, ">", ""))
        nameplayer1 = Trim(Replace(nameplayer1, vbLf, ""))
    End Sub

    ' Función para detectar URL de jugador
    Private Function EsJugador(url As String) As Boolean
        Dim patron As String = "/player/\d+/?$"
        Return System.Text.RegularExpressions.Regex.IsMatch(url, patron)
    End Function

    Private Function LimitStat99(value As Double) As Integer
        If value > 99 Then
            Return 99
        Else
            Return CInt(Math.Floor(value))
        End If
    End Function

    Private Function ConvertirStat(key As String, valorBase As Integer) As Integer
        Dim attacking As String() = {"Offensive Awareness", "Finishing", "Kicking Power"}
        Dim dribbling As String() = {"Ball Control", "Dribbling", "Tight Possession", "Balance"}
        Dim defending As String() = {"Heading", "Jumping", "Defensive Awareness", "Tackling", "Defensive Engagement", "Aggression"}
        Dim passing As String() = {"Low Pass", "Lofted Pass", "Set Piece Taking"}
        Dim physicality As String() = {"Speed", "Acceleration", "Physical Contact", "Stamina"}
        Dim goalkeeping As String() = {"GK Awareness", "GK Catching", "GK Parrying", "GK Reflexes", "GK Reach"}

        Dim value As Double = valorBase

        If attacking.Contains(key) Then
            value += value * 0.075
        ElseIf dribbling.Contains(key) Then
            value += value * 0.0625
        ElseIf defending.Contains(key) Then
            value += value * 0.03
        ElseIf passing.Contains(key) Then
            value += value * 0.105
        ElseIf physicality.Contains(key) Then
            value += value * 0.065
        ElseIf goalkeeping.Contains(key) Then
            value += value * 0.03
        End If

        Return LimitStat99(value)
    End Function


    Private Async Sub WebView21_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles WebView21.NavigationCompleted

        'document.getElementById('tuElementoId').outerHTML;
        Dim sHTML As String = Await WebView21.ExecuteScriptAsync("document.documentElement.outerHTML;")
        sHTML = Regex.Unescape(sHTML)

        sHTML = sHTML.Substring(1, sHTML.Length - 2)

        RichTextBox1.Text = sHTML


        Dim rutaplayer As String

        Dim rutaplayer2 As String
        Dim rutaEfootball As String
        Dim rutatransfermark As String

        rutaplayer2 = Mid(WebView21.Source.AbsolutePath, 1, 7)
        rutaplayer = Mid(WebView21.Source.AbsolutePath, 1, 6)

        If rutaplayer = "/team/" Then

            allplayers()
            HacerScroll(WebView21, 250, 0)

        Else

            If rutaplayer2 = "/squad/" Then

                allplayers()
                HacerScroll(WebView21, 250, 0)

            End If

        End If

        '
        rutaplayer = Mid(WebView21.Source.AbsolutePath, 1, 8)
        If rutaplayer = "/player/" Then
            calcmcr()


            comboindex = 1
        End If
        rutaplayer2 = Mid(WebView21.Source.AbsolutePath, 1, 9)
        If rutaplayer2 = "/players/" Then
            calcmcrFM()
            comboindex = 1

        End If

        'pesmasters

        rutaEfootball = WebView21.Source.AbsoluteUri

        ' Verifica si pertenece a pesmaster y si es de jugador
        If rutaEfootball.StartsWith("https://www.pesmaster.com/") AndAlso EsJugador(rutaEfootball) Then
            Dim inicio As Integer = sHTML.IndexOf("const player = {")
            If inicio <> -1 Then
                Dim fin As Integer = sHTML.IndexOf("};", inicio)
                If fin <> -1 Then
                    ' Extraer JSON de player
                    Dim jsonPlayer As String = sHTML.Substring(inicio + "const player = ".Length, fin - (inicio + "const player = ".Length)) & "}"
                    ' Parsear JSON usando JObject
                    Dim playerData As JObject = JObject.Parse(jsonPlayer)

                    ' Asignar variables directamente
                    id_efootball = playerData("id").ToString()
                    nombreJugador_EF = playerData("name").ToString()
                    squadnumber_EF = playerData("squadnumber").ToString()
                    nsquadnumber_EF = playerData("nsquadnumber").ToString()

                    offensive_awareness_EF = ConvertirStat("Offensive Awareness", CInt(playerData("offensive_awareness")))
                    ball_control_EF = ConvertirStat("Ball Control", CInt(playerData("ball_control")))
                    dribbling_EF = ConvertirStat("Dribbling", CInt(playerData("dribbling")))
                    low_pass_EF = ConvertirStat("Low Pass", CInt(playerData("low_pass")))
                    finishing_EF = ConvertirStat("Finishing", CInt(playerData("finishing")))
                    heading_EF = ConvertirStat("Heading", CInt(playerData("heading")))
                    tight_possession_EF = ConvertirStat("Tight Possession", CInt(playerData("tight_possession")))
                    lofted_pass_EF = ConvertirStat("Lofted Pass", CInt(playerData("lofted_pass")))
                    set_piece_taking_EF = ConvertirStat("Set Piece Taking", CInt(playerData("set_piece_taking")))
                    curl_EF = ConvertirStat("Curl", CInt(playerData("curl")))
                    speed_EF = ConvertirStat("Speed", CInt(playerData("speed")))
                    acceleration_EF = ConvertirStat("Acceleration", CInt(playerData("acceleration")))
                    kicking_power_EF = ConvertirStat("Kicking Power", CInt(playerData("kicking_power")))
                    jumping_EF = ConvertirStat("Jumping", CInt(playerData("jumping")))
                    physical_contact_EF = ConvertirStat("Physical Contact", CInt(playerData("physical_contact")))
                    balance_EF = ConvertirStat("Balance", CInt(playerData("balance")))
                    stamina_EF = ConvertirStat("Stamina", CInt(playerData("stamina")))
                    defensive_awareness_EF = ConvertirStat("Defensive Awareness", CInt(playerData("defensive_awareness")))
                    tackling_EF = ConvertirStat("Tackling", CInt(playerData("tackling")))
                    defensive_engagement_EF = ConvertirStat("Defensive Engagement", CInt(playerData("defensive_engagement")))
                    aggression_EF = ConvertirStat("Aggression", CInt(playerData("aggression")))
                    gk_awareness_EF = ConvertirStat("GK Awareness", CInt(playerData("gk_awareness")))
                    gk_catching_EF = ConvertirStat("GK Catching", CInt(playerData("gk_catching")))
                    gk_parrying_EF = ConvertirStat("GK Parrying", CInt(playerData("gk_parrying")))
                    gk_reflexes_EF = ConvertirStat("GK Reflexes", CInt(playerData("gk_reflexes")))
                    gk_reach_EF = ConvertirStat("GK Reach", CInt(playerData("gk_reach")))
                    UrlJugador_EF = rutaEfootball

                    ' Estos valores no se calculan con Max Out
                    s_outside_curler_EF = playerData("s_outside_curler").ToString()
                    pos_EF = playerData("pos").ToString()
                    weak_foot_acc_EF = playerData("weak_foot_acc").ToString()
                    posicion = playerData("pos_name").ToString()
                    equipo = playerData("team_real_name").ToString()
                    age_EF = playerData("age").ToString()
                    height_EF = playerData("height").ToString()
                    weight_EF = playerData("weight").ToString()
                    foot_EF = playerData("foot").ToString()
                    team_name_display_EF = playerData("team_name_display").ToString()
                    n_team_name_EF = playerData("n_team_name").ToString()
                    nat_name_EF = playerData("nat_name").ToString()

                    ' Buscar el inicio del atributo data-src del PNG
                    Dim fotoUrl As String = ""
                    Dim tagImg As String = "<img class=""player-card-image"
                    Dim idxImg As Integer = sHTML.IndexOf(tagImg)

                    If idxImg <> -1 Then
                        Dim idxDataSrc As Integer = sHTML.IndexOf("data-src=""", idxImg)
                        If idxDataSrc <> -1 Then
                            idxDataSrc += "data-src=""".Length
                            Dim idxEnd As Integer = sHTML.IndexOf("""", idxDataSrc)
                            If idxEnd <> -1 Then
                                fotoUrl = sHTML.Substring(idxDataSrc, idxEnd - idxDataSrc)
                                ' Asegurar que sea URL absoluta
                                If fotoUrl.StartsWith("/") Then
                                    fotoUrl = "https://www.pesmaster.com" & fotoUrl
                                End If
                            End If
                        End If
                    End If

                    ' Guardar en variable
                    fotoJugador_EF = fotoUrl


                    calcmcrEF()

                End If
            End If
        End If

        'transfermark
        rutatransfermark = Mid(WebView21.Source.AbsoluteUri, 1, 25)


        If rutatransfermark = "https://www.transfermarkt" Then


            busctexto2 = sHTML
            offsetbusc2 = InStr(busctexto2, "keywords")


            Try
                If offsetbusc2 = 0 Then
                    visiblebtnplayerTM = False
                    visiblebtnTM()
                    ColorButtonTM()
                    TmSelector = 0

                Else
                    ' ===============================
                    ' SQUAD SIZE
                    ' ===============================
                    If TmSelector = 0 Then
                        TmSelector = 1
                        Dim rxSquadSize As New Regex(
                        "Squad size:\s*<span[^>]*>\s*(\d+)",
                        RegexOptions.IgnoreCase Or RegexOptions.Singleline
                    )

                        Dim squadSizeInt As Integer = 0
                        Dim m = rxSquadSize.Match(busctexto2)

                        If m.Success Then
                            Integer.TryParse(m.Groups(1).Value, squadSizeInt)
                        End If


                        ' ===============================
                        ' CLUB
                        ' ===============================
                        Dim rxClub As New Regex(
                        "<h1[^>]*data-header__headline-wrapper[^>]*>\s*([^<]+)",
                        RegexOptions.IgnoreCase Or RegexOptions.Singleline
                    )

                        If rxClub.IsMatch(busctexto2) Then
                            club = rxClub.Match(busctexto2).Groups(1).Value.Trim()
                        End If


                        ' ===============================
                        ' NUMEROS
                        ' ===============================
                        Dim rxNumber As New Regex(
    "<div\s+class\s*=\s*[""']?rn_nummer[""']?\s*>\s*([-\d]+)\s*</div>",
    RegexOptions.IgnoreCase
)

                        ' ===============================
                        ' NOMBRES
                        Dim rxName As New Regex(
    "<a\s+href=""/[^""]+/profil/spieler/\d+""[^>]*>\s*([^<]+)",
    RegexOptions.IgnoreCase Or RegexOptions.Singleline
)
                        Dim numbers = rxNumber.Matches(busctexto2)
                        Dim names = rxName.Matches(busctexto2)

                        Dim totalPlayers As Integer = Math.Min(numbers.Count, names.Count)

                        If squadSizeInt > 0 Then
                            totalPlayers = Math.Min(totalPlayers, squadSizeInt)
                        End If

                        ReDim rn_number(totalPlayers - 1)

                        For i As Integer = 0 To totalPlayers - 1

                            Dim num As String = numbers(i).Groups(1).Value.Trim()

                            If num = "-" Then
                                rn_number(i) = "32" ' 👈 reemplazo
                            Else
                                rn_number(i) = num
                            End If

                            Btn_tm_player(i).Text =
                            names(i).Groups(1).Value.Trim()

                            Btn_tm_player(i).Tag = i          ' 👈 USA EL ÍNDICE, NO EL NÚMERO
                            Btn_tm_player(i).Visible = True

                        Next

                    End If
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End If
    End Sub

    Private Async Sub WebView22_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles WebView22.NavigationCompleted
        If selectFM_Sofifa = 0 Then HacerScroll(WebView22, 220, 0)
        Dim rutaplayer As String
        Dim rutaplayer2 As String
        Dim rutaefootball As String


        Dim sHTML As String = Await WebView22.ExecuteScriptAsync("document.documentElement.outerHTML;")

        sHTML = Regex.Unescape(sHTML)
        sHTML = sHTML.Remove(0, 1)
        sHTML = sHTML.Remove(sHTML.Length - 1, 1)



        'Sofifa
        rutaplayer = Mid(WebView22.Source.AbsolutePath, 1, 8)
        If rutaplayer = "/player/" Then
            RichTextBox1.Text = sHTML
            calcmcr()
            comboindex = 1
        End If

        'FmInside
        rutaplayer2 = Mid(WebView22.Source.AbsolutePath, 1, 9)
        If rutaplayer2 = "/players/" Then
            RichTextBox1.Text = sHTML
            calcmcrFM()
            comboindex = 1
            Await Task.Delay(1000)
            WebView22.CoreWebView2.Navigate("https://fminside.net/players")
        End If


        'pesmasters
        rutaefootball = WebView22.Source.AbsoluteUri

        ' Verifica si pertenece a pesmaster y si es de jugador
        If rutaefootball.StartsWith("https://www.pesmaster.com/") AndAlso EsJugador(rutaefootball) Then
            Dim inicio As Integer = sHTML.IndexOf("const player = {")
            If inicio <> -1 Then
                Dim fin As Integer = sHTML.IndexOf("};", inicio)
                If fin <> -1 Then
                    ' Extraer JSON de player
                    Dim jsonPlayer As String = sHTML.Substring(inicio + "const player = ".Length, fin - (inicio + "const player = ".Length)) & "}"
                    ' Parsear JSON usando JObject
                    Dim playerData As JObject = JObject.Parse(jsonPlayer)

                    ' Asignar variables directamente
                    id_efootball = playerData("id").ToString()
                    nombreJugador_EF = playerData("name").ToString()
                    squadnumber_EF = playerData("squadnumber").ToString()
                    nsquadnumber_EF = playerData("nsquadnumber").ToString()

                    offensive_awareness_EF = ConvertirStat("Offensive Awareness", CInt(playerData("offensive_awareness")))
                    ball_control_EF = ConvertirStat("Ball Control", CInt(playerData("ball_control")))
                    dribbling_EF = ConvertirStat("Dribbling", CInt(playerData("dribbling")))
                    low_pass_EF = ConvertirStat("Low Pass", CInt(playerData("low_pass")))
                    finishing_EF = ConvertirStat("Finishing", CInt(playerData("finishing")))
                    heading_EF = ConvertirStat("Heading", CInt(playerData("heading")))
                    tight_possession_EF = ConvertirStat("Tight Possession", CInt(playerData("tight_possession")))
                    lofted_pass_EF = ConvertirStat("Lofted Pass", CInt(playerData("lofted_pass")))
                    set_piece_taking_EF = ConvertirStat("Set Piece Taking", CInt(playerData("set_piece_taking")))
                    curl_EF = ConvertirStat("Curl", CInt(playerData("curl")))
                    speed_EF = ConvertirStat("Speed", CInt(playerData("speed")))
                    acceleration_EF = ConvertirStat("Acceleration", CInt(playerData("acceleration")))
                    kicking_power_EF = ConvertirStat("Kicking Power", CInt(playerData("kicking_power")))
                    jumping_EF = ConvertirStat("Jumping", CInt(playerData("jumping")))
                    physical_contact_EF = ConvertirStat("Physical Contact", CInt(playerData("physical_contact")))
                    balance_EF = ConvertirStat("Balance", CInt(playerData("balance")))
                    stamina_EF = ConvertirStat("Stamina", CInt(playerData("stamina")))
                    defensive_awareness_EF = ConvertirStat("Defensive Awareness", CInt(playerData("defensive_awareness")))
                    tackling_EF = ConvertirStat("Tackling", CInt(playerData("tackling")))
                    defensive_engagement_EF = ConvertirStat("Defensive Engagement", CInt(playerData("defensive_engagement")))
                    aggression_EF = ConvertirStat("Aggression", CInt(playerData("aggression")))
                    gk_awareness_EF = ConvertirStat("GK Awareness", CInt(playerData("gk_awareness")))
                    gk_catching_EF = ConvertirStat("GK Catching", CInt(playerData("gk_catching")))
                    gk_parrying_EF = ConvertirStat("GK Parrying", CInt(playerData("gk_parrying")))
                    gk_reflexes_EF = ConvertirStat("GK Reflexes", CInt(playerData("gk_reflexes")))
                    gk_reach_EF = ConvertirStat("GK Reach", CInt(playerData("gk_reach")))
                    UrlJugador_EF = rutaefootball

                    ' Estos valores no se calculan con Max Out
                    s_outside_curler_EF = playerData("s_outside_curler").ToString()
                    pos_EF = playerData("pos").ToString()
                    weak_foot_acc_EF = playerData("weak_foot_acc").ToString()
                    posicion = playerData("pos_name").ToString()
                    equipo = playerData("team_real_name").ToString()
                    age_EF = playerData("age").ToString()
                    height_EF = playerData("height").ToString()
                    weight_EF = playerData("weight").ToString()
                    foot_EF = playerData("foot").ToString()
                    team_name_display_EF = playerData("team_name_display").ToString()
                    n_team_name_EF = playerData("n_team_name").ToString()
                    nat_name_EF = playerData("nat_name").ToString()

                    ' Buscar el inicio del atributo data-src del PNG
                    Dim fotoUrl As String = ""
                    Dim tagImg As String = "<img class=""player-card-image"
                    Dim idxImg As Integer = sHTML.IndexOf(tagImg)

                    If idxImg <> -1 Then
                        Dim idxDataSrc As Integer = sHTML.IndexOf("data-src=""", idxImg)
                        If idxDataSrc <> -1 Then
                            idxDataSrc += "data-src=""".Length
                            Dim idxEnd As Integer = sHTML.IndexOf("""", idxDataSrc)
                            If idxEnd <> -1 Then
                                fotoUrl = sHTML.Substring(idxDataSrc, idxEnd - idxDataSrc)
                                ' Asegurar que sea URL absoluta
                                If fotoUrl.StartsWith("/") Then
                                    fotoUrl = "https://www.pesmaster.com" & fotoUrl
                                End If
                            End If
                        End If
                    End If

                    ' Guardar en variable
                    fotoJugador_EF = fotoUrl


                    calcmcrEF()

                End If
            End If
        End If
    End Sub


    Private Async Sub Stopweb()
        If delayweb <> 0 Then
            Await Task.Delay(delayweb)
            WebView21.Stop()
        End If
    End Sub


    Private Async Sub Stopweb2()
        If delayweb2 <> 0 Then
            Await Task.Delay(delayweb2)
            WebView22.Stop()
        End If
    End Sub



    Private Sub WebView22_ContentLoading(sender As Object, e As CoreWebView2ContentLoadingEventArgs) Handles WebView22.ContentLoading
        Stopweb2()
    End Sub



    Private Sub WebView21_ContentLoading(sender As Object, e As CoreWebView2ContentLoadingEventArgs) Handles WebView21.ContentLoading
        Stopweb()
    End Sub

    Private Sub SelectMCR()
        If SelectCalcMCR = 1 Then calcmcr()
        If SelectCalcMCR = 2 Then calcmcrFM()
        If SelectCalcMCR = 3 Then calcmcrEF()
    End Sub
    Private Sub rbtonline_Click(sender As Object, e As EventArgs) Handles rbtonline.Click
        SelectMCR()
    End Sub

    Private Sub rtbnormal_Click(sender As Object, e As EventArgs) Handles rtbnormal.Click
        SelectMCR()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Options.Show()

    End Sub




    Private Sub BTN_Sofifa_Click(sender As Object, e As EventArgs) Handles BTN_Sofifa.Click
        SelectCalcMCR = 1
        'delayweb = 5000
        'delayweb2 = 2000
        WebView21.Source = New Uri("https://sofifa.com/teams")
        WebView21.ZoomFactor = 0.6
        WebView22.Visible = False
        WebView21.Width = 623
        visiblebtnplayerfifa = True
        txt_searchplayer.Visible = False
        lbl_searchplayer.Visible = False
        lbl_customizedplayer111.Visible = False
        Btn_FmInsidePlayers.Visible = False
        txt_searchClub.Visible = False
        Lbl_searchClub.Visible = False
        txt_PlayerSofifa.Visible = False
        Lbl_Player_Sofifa.Visible = False
        txt_CustomPlayerSofifa.Visible = False
        Lbl_CustomPlayer_Sofifa.Visible = False
        btn_FC_TM.Visible = False
        DataGridView2.Visible = False
        TxtBuscaNombre.Visible = False
        Txt_BuscaNat.Visible = False
        txt_BuscarClub.Visible = False
        Txt_BuscarNatTeam.Visible = False
        BtnUpdateAll.Visible = False
        BtnUpdateSel.Visible = False
        BtnDeleted.Visible = False
        Btn_ExportJSon.Visible = False
        btnplayerfifavisibe()

        visiblebtnplayerTM = False
        visiblebtnTM()
    End Sub

    Private Sub Btn_TransferMark_Click(sender As Object, e As EventArgs) Handles Btn_TransferMark.Click
        SelectCalcMCR = 2
        BackWeb = 0
        'delayweb = 10000
        delayweb2 = 0
        selectFM_Sofifa = 0
        WebView21.CoreWebView2.Navigate("https://www.transfermarkt.com/schnellsuche/keinergebnis/schnellsuche?query=")

        WebView21.ZoomFactor = 1.04
        WebView21.Width = 415
        WebView22.CoreWebView2.Navigate("https://fminside.net/players")
        WebView22.Visible = True
        visiblebtnplayerfifa = False
        txt_searchplayer.Visible = True
        lbl_searchplayer.Visible = True
        lbl_customizedplayer111.Visible = True
        Btn_FmInsidePlayers.Visible = True
        btn_FC_TM.Visible = True
        btn_EF_TM.Visible = True
        txt_searchClub.Visible = True
        Lbl_searchClub.Visible = True
        txt_PlayerSofifa.Visible = False
        Lbl_Player_Sofifa.Visible = False
        txt_CustomPlayerSofifa.Visible = False
        Lbl_CustomPlayer_Sofifa.Visible = False
        DataGridView2.Visible = False
        TxtBuscaNombre.Visible = False
        Txt_BuscaNat.Visible = False
        txt_BuscarClub.Visible = False
        Txt_BuscarNatTeam.Visible = False
        BtnUpdateAll.Visible = False
        BtnUpdateSel.Visible = False
        BtnDeleted.Visible = False
        Btn_ExportJSon.Visible = False
        btnplayerfifavisibe()
    End Sub


    Private Async Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn_FmInsidePlayers.Click
        delayweb2 = 0
        WebView22.CoreWebView2.Navigate("https://fminside.net/players")
        'Await SeleccionarBaseDeDatos()
        selectFM_Sofifa = 0
        visiblebtnplayerfifa = False
        txt_searchplayer.Visible = True
        lbl_searchplayer.Visible = True
        lbl_customizedplayer111.Visible = True
        Btn_FmInsidePlayers.Visible = True
        btn_FC_TM.Visible = True
        txt_searchClub.Visible = True
        Lbl_searchClub.Visible = True
        txt_PlayerSofifa.Visible = False
        Lbl_Player_Sofifa.Visible = False
        txt_CustomPlayerSofifa.Visible = False
        Lbl_CustomPlayer_Sofifa.Visible = False

    End Sub

    Private Sub TxtBuscaNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscaNombre.TextChanged
        Dim BuscaName As String = TxtBuscaNombre.Text
        If BuscaName <> "" Then
            WeName = BuscaName
            ContactsByName()
            Txt_BuscaNat.Text = ""
            Txt_BuscarNatTeam.Text = ""
            txt_BuscarClub.Text = ""
        Else
            allContatcs()
        End If
    End Sub

    Private originalFormMcrPosition As Point
    Private originalFormFormationPosition As Point

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start(New ProcessStartInfo With {
          .FileName = "https://www.patreon.com/PasionWeGenesis/about",
          .UseShellExecute = True
      })
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start(New ProcessStartInfo With {
          .FileName = "https://www.paypal.com/paypalme/PwPatch",
          .UseShellExecute = True
      })
    End Sub
    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        ' Verifica si hay filas en el DataGridView
        If DataGridView1.Rows.Count > 1 Then
            ' Seleccionar la primera celda (fila 0, columna 0)
            DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
            LoadDataIntoTextBoxes()

        End If
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            formmcr.cmbskincolor.Text = selectedRow.Cells("SkinColor").Value.ToString()
            formmcr.cmbhair.Text = selectedRow.Cells("Hair").Value.ToString()
            formmcr.cmbhaircolor.Text = selectedRow.Cells("HairColor").Value.ToString()
            formmcr.cmbhairface.Text = selectedRow.Cells("HairFace").Value.ToString()
            formmcr.cmbhaircolorface.Text = selectedRow.Cells("HairColorFace").Value.ToString()
            formmcr.txtplayername.Text = selectedRow.Cells("NAMEWE").Value.ToString()

            indexcmbskikcolour = formmcr.cmbskincolor.Text
            indexcmbhaircolor = formmcr.cmbhaircolor.Text
            indexcmbhairface = formmcr.cmbhairface.SelectedIndex
            indexcmbhair = formmcr.cmbhair.SelectedIndex
            indexcmbhaircolourface = formmcr.cmbhaircolorface.Text

            SKINCOLOUR()


        End If
    End Sub

    Private Sub CMBADDCOLUMNSDB_Click(sender As Object, e As EventArgs) Handles CMBADDCOLUMNSDB.Click
        AddColumnsToDatabase()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        LoadDataIntoTextBoxes()
    End Sub

    Private Sub LoadDataIntoTextBoxes()
        If DataGridView1.CurrentRow IsNot Nothing Then
            formmcr.cmbskincolor.Text = DataGridView1.CurrentRow.Cells("SkinColor").Value.ToString()
            formmcr.cmbhair.Text = DataGridView1.CurrentRow.Cells("Hair").Value.ToString()
            formmcr.cmbhaircolor.Text = DataGridView1.CurrentRow.Cells("HairColor").Value.ToString()
            formmcr.cmbhairface.Text = DataGridView1.CurrentRow.Cells("HairFace").Value.ToString()
            formmcr.cmbhaircolorface.Text = DataGridView1.CurrentRow.Cells("HairColorFace").Value.ToString()
            formmcr.txtplayername.Text = DataGridView1.CurrentRow.Cells("NAMEWE").Value.ToString()
            indexcmbskikcolour = formmcr.cmbskincolor.Text
            indexcmbhaircolor = formmcr.cmbhaircolor.Text
            indexcmbhairface = formmcr.cmbhairface.SelectedIndex
            indexcmbhair = formmcr.cmbhair.SelectedIndex
            indexcmbhaircolourface = formmcr.cmbhaircolorface.Text
            formmcr.btname1.Text = DataGridView1.CurrentRow.Cells("NAMEWE").Value.ToString()
            Dim valorName = DataGridView1.CurrentRow.Cells("name").Value
            If valorName IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(valorName.ToString()) Then
                TxtSofifaName.Text = valorName.ToString()
            End If
            SKINCOLOUR()
            If ChkStats.Checked = True Then
                formmcr.cmbheigth.Text = DataGridView1.CurrentRow.Cells("Height").Value.ToString()
                formmcr.cmbbody.Text = DataGridView1.CurrentRow.Cells("Body").Value.ToString()
                formmcr.cmbage.Text = DataGridView1.CurrentRow.Cells("Age").Value.ToString()
                formmcr.cmbboots.Text = DataGridView1.CurrentRow.Cells("Boots").Value.ToString()
                formmcr.cmbfood.Text = DataGridView1.CurrentRow.Cells("Feet").Value.ToString()
                formmcr.cmbfeedoutside.Text = DataGridView1.CurrentRow.Cells("FeetOutside").Value.ToString()
                formmcr.cmboffense.Text = DataGridView1.CurrentRow.Cells("Ofensse").Value.ToString()
                formmcr.cmbdeffense.Text = DataGridView1.CurrentRow.Cells("Deffense").Value.ToString()
                formmcr.cmbbodybalance.Text = DataGridView1.CurrentRow.Cells("BodyBalance").Value.ToString()
                formmcr.cmbstamina.Text = DataGridView1.CurrentRow.Cells("Stamina").Value.ToString()
                formmcr.cmbspeed.Text = DataGridView1.CurrentRow.Cells("Speed").Value.ToString()
                formmcr.cmbaceleration.Text = DataGridView1.CurrentRow.Cells("Acceleration").Value.ToString()
                formmcr.cmbpass.Text = DataGridView1.CurrentRow.Cells("Pass").Value.ToString()
                formmcr.cmbshotpower.Text = DataGridView1.CurrentRow.Cells("ShotPower").Value.ToString()
                formmcr.cmbshotacc.Text = DataGridView1.CurrentRow.Cells("ShotAcc").Value.ToString()
                formmcr.cmbjump.Text = DataGridView1.CurrentRow.Cells("Jump").Value.ToString()
                formmcr.cmbhead.Text = DataGridView1.CurrentRow.Cells("Head").Value.ToString()
                formmcr.cmbtechnique.Text = DataGridView1.CurrentRow.Cells("Technique").Value.ToString()
                formmcr.cmbdribble.Text = DataGridView1.CurrentRow.Cells("Dribble").Value.ToString()
                formmcr.cmbcurve.Text = DataGridView1.CurrentRow.Cells("Curve").Value.ToString()
                formmcr.cmbaggression.Text = DataGridView1.CurrentRow.Cells("Aggresive").Value.ToString()
                formmcr.cmbresponse.Text = DataGridView1.CurrentRow.Cells("Response").Value.ToString()
                formmcr.txtclub.Text = DataGridView1.CurrentRow.Cells("Club").Value.ToString()
                formmcr.txt_nat_team.Text = DataGridView1.CurrentRow.Cells("NationalTeam").Value.ToString()
                formmcr.txtnacionalidad.Text = DataGridView1.CurrentRow.Cells("Nation").Value.ToString()
            End If

        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start(New ProcessStartInfo With {
      .FileName = "https://ko-fi.com/zetapasionwe",
      .UseShellExecute = True
  })
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Process.Start(New ProcessStartInfo With {
.FileName = "https://pasionwe.webnode.ec/tools/",
.UseShellExecute = True
})
    End Sub

    Private Sub btnPSDaddon_Click(sender As Object, e As EventArgs) Handles btnPSDaddon.Click
        Process.Start(New ProcessStartInfo With {
       .FileName = "https://chromewebstore.google.com/detail/pes-stats-converter-copy/egeeiijmegmigmllhhebdhmckofoldaf?hl=es-419",
       .UseShellExecute = True
   })
    End Sub


    Private Async Function EjecutarBusquedaPorNombre(nombre As String) As Task

        Dim script As String = $"
(function() {{
    // Buscar el campo de entrada con name='name'
    var input = document.querySelector('input[name=""name""]');
    if (input) {{
        input.value = '{nombre}';
        var inputEvent = new Event('input', {{ bubbles: true }});
        input.dispatchEvent(inputEvent);
        var changeEvent = new Event('change', {{ bubbles: true }});
        input.dispatchEvent(changeEvent);
        var keyEvent = new KeyboardEvent('keydown', {{
            bubbles: true,
            cancelable: true,
            key: 'Enter',
            keyCode: 13
        }});
        input.dispatchEvent(keyEvent);
    }} else {{
        console.log('No se encontró el campo de búsqueda.');
    }}
}})();
"
        ' Esperar antes de ejecutar, por si el sitio tarda en cargar los scripts JS
        Await Task.Delay(delaybusquedaFm)
        Await WebView22.ExecuteScriptAsync(script)

    End Function


    Private Async Function SeleccionarBaseDeDatos() As Task
        Dim script As String = "
    (function() {
        var select = document.querySelector('select[name=""database_version""]');
        if (select) {
            select.value = '7';

            select.dispatchEvent(new Event('input', { bubbles: true }));
            select.dispatchEvent(new Event('change', { bubbles: true }));
        } else {
            console.log('No se encontró el select con name=""database_version"".');
        }
    })();
    "
        Await WebView22.ExecuteScriptAsync(script)
    End Function



    Private Async Function EjecutarBusquedaPorClub(club As String) As Task
        ' JavaScript con comillas escapadas
        Dim script As String = $"
(function() {{
    // Buscar el campo de entrada con name=""club""
    var input = document.querySelector('input[name=""club""]');
    if (input) {{
        // Asignar el valor al input
        input.value = '{club}';

        // Simular un evento 'input' para notificar cambios
        var inputEvent = new Event('input', {{ bubbles: true }});
        input.dispatchEvent(inputEvent);

        // Simular un evento 'change' por si el sitio lo requiere
        var changeEvent = new Event('change', {{ bubbles: true }});
        input.dispatchEvent(changeEvent);

        // Simular el evento 'keydown' para la tecla Enter
        var keyEvent = new KeyboardEvent('keydown', {{
            bubbles: true,
            cancelable: true,
            key: 'Enter',
            keyCode: 13
        }});
        input.dispatchEvent(keyEvent);
    }} else {{
        console.log('No se encontró el campo con name=""club"".');
    }}
}})();
"
        Await Task.Delay(delaybusquedaFm)

        ' Ejecutar el script en WebView2
        Await WebView22.ExecuteScriptAsync(script)
        'delayweb2 = 500
    End Function


    Dim delaybusquedaFm As Integer



    Private Sub btn_fm_Click(sender As Object, e As EventArgs) Handles btn_FC_TM.Click
        delayweb2 = 0
        selectFM_Sofifa = 1
        'WebView21.Source = New Uri("https://www.transfermarkt.com/statistik/neuestetransfers")
        WebView22.Source = New Uri("https://www.sofifa.com/players")
        WebView21.ZoomFactor = 0.85
        WebView22.Visible = True
        visiblebtnplayerfifa = False
        txt_PlayerSofifa.Visible = True
        Lbl_Player_Sofifa.Visible = True
        txt_CustomPlayerSofifa.Visible = True
        Lbl_CustomPlayer_Sofifa.Visible = True
        txt_searchplayer.Visible = False
        lbl_searchplayer.Visible = False
        lbl_customizedplayer111.Visible = False
        txt_searchClub.Visible = False
        Lbl_searchClub.Visible = False


        btnplayerfifavisibe()
    End Sub

    Private Sub Btn_Restored_Click(sender As Object, e As EventArgs) Handles Btn_Restored.Click
        formmcr.Location = originalFormMcrPosition

        ' Restaurar el tamaño original del formulario principal
        Me.Width = 1366
        Me.Height = 768
        Me.TopMost = False

        ' Mostrar todos los controles ocultos
        For Each ctrl As Control In Me.Controls
            ctrl.Visible = True
        Next

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Visible = False ' Ocultar los TextBox
            End If
        Next
    End Sub

    Private Async Sub txt_searchplayer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_searchplayer.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim nombre = txt_searchplayer.Text
            Await EjecutarBusquedaPorNombre(nombre)
        End If
    End Sub

    Private Async Sub txt_searchClub_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_searchClub.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim club = txt_searchClub.Text
            Await EjecutarBusquedaPorClub(club)
        End If
    End Sub

    Private Sub btn_zoom1_Click(sender As Object, e As EventArgs) Handles btn_zoom1.Click
        WebView21.ZoomFactor = 0.78
    End Sub

    Private Sub Btn_zoom2_Click(sender As Object, e As EventArgs) Handles Btn_zoom2.Click
        WebView21.ZoomFactor = 0.95
    End Sub



    Private Sub txt_PlayerSofifa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PlayerSofifa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            WebView22.Source = New Uri("https://sofifa.com/players?keyword=" & txt_PlayerSofifa.Text)
        End If
    End Sub


    Private Sub txt_CustomPlayerSofifa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CustomPlayerSofifa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            WebView22.Source = New Uri("https://sofifa.com/players?keyword=" & txt_CustomPlayerSofifa.Text & "&type=customized")
        End If
    End Sub


    Private Sub Btn_PesMasters_Click(sender As Object, e As EventArgs) Handles Btn_PesMasters.Click
        SelectCalcMCR = 3
        'delayweb = 3500
        'delayweb2 = 0
        selectFM_Sofifa = 0
        WebView21.CoreWebView2.Navigate("https://www.pesmaster.com/efootball-2022/#leagues")

        WebView21.ZoomFactor = 0.78
        WebView21.Width = 623
        WebView22.Visible = False
        visiblebtnplayerfifa = False
        txt_searchplayer.Visible = False
        lbl_searchplayer.Visible = False
        lbl_customizedplayer111.Visible = False
        Btn_FmInsidePlayers.Visible = False
        btn_FC_TM.Visible = False
        txt_searchClub.Visible = False
        Lbl_searchClub.Visible = False
        txt_PlayerSofifa.Visible = False
        Lbl_Player_Sofifa.Visible = False
        txt_CustomPlayerSofifa.Visible = False
        Lbl_CustomPlayer_Sofifa.Visible = False
        DataGridView2.Visible = False
        TxtBuscaNombre.Visible = False
        Txt_BuscaNat.Visible = False
        txt_BuscarClub.Visible = False
        Txt_BuscarNatTeam.Visible = False
        BtnUpdateAll.Visible = False
        BtnUpdateSel.Visible = False
        BtnDeleted.Visible = False
        Btn_ExportJSon.Visible = False

        btnplayerfifavisibe()
        visiblebtnplayerTM = False
        visiblebtnTM()
    End Sub


    Private Sub Btn_DB_Click(sender As Object, e As EventArgs) Handles Btn_DB.Click
        BackWeb = 1
        visiblebtnplayerfifa = False
        WebView22.Visible = False

        txt_searchplayer.Visible = False
        lbl_searchplayer.Visible = False
        lbl_customizedplayer111.Visible = False
        Btn_FmInsidePlayers.Visible = False
        txt_searchClub.Visible = False
        Lbl_searchClub.Visible = False
        txt_PlayerSofifa.Visible = False
        Lbl_Player_Sofifa.Visible = False
        txt_CustomPlayerSofifa.Visible = False
        Lbl_CustomPlayer_Sofifa.Visible = False
        btn_FC_TM.Visible = False
        DataGridView2.Visible = True
        TxtBuscaNombre.Visible = True
        Txt_BuscaNat.Visible = True
        txt_BuscarClub.Visible = True
        Txt_BuscarNatTeam.Visible = True
        BtnUpdateAll.Visible = True
        BtnUpdateSel.Visible = True
        BtnDeleted.Visible = True
        Btn_ExportJSon.Visible = True
        btnplayerfifavisibe()

        visiblebtnplayerTM = False
        visiblebtnTM()

    End Sub

    Private Sub txt_BuscarClub_TextChanged(sender As Object, e As EventArgs) Handles txt_BuscarClub.TextChanged
        Dim BuscaClub As String = txt_BuscarClub.Text
        If BuscaClub <> "" Then
            WeClub = BuscaClub
            ContactsByClub()
            Txt_BuscaNat.Text = ""
            Txt_BuscarNatTeam.Text = ""
            TxtBuscaNombre.Text = ""
        Else
            allContatcs()
        End If
    End Sub

    Private Sub Txt_BuscarNatTeam_TextChanged(sender As Object, e As EventArgs) Handles Txt_BuscarNatTeam.TextChanged
        Dim BuscaNatTeam As String = Txt_BuscarNatTeam.Text
        If BuscaNatTeam <> "" Then
            WeNationTeam = BuscaNatTeam
            ContactsByNationalTeam()
            Txt_BuscaNat.Text = ""
            txt_BuscarClub.Text = ""
            TxtBuscaNombre.Text = ""
        Else
            allContatcs()
        End If
    End Sub

    Private Sub Txt_BuscaNat_TextChanged(sender As Object, e As EventArgs) Handles Txt_BuscaNat.TextChanged
        Dim BuscaNat As String = Txt_BuscaNat.Text
        If BuscaNat <> "" Then
            WeNation = BuscaNat
            ContactsByNat()
            txt_BuscarClub.Text = ""
            Txt_BuscarNatTeam.Text = ""
            TxtBuscaNombre.Text = ""
        Else
            allContatcs()
        End If
    End Sub

    'Private Async Sub BtnUpdatePlayers_Click(sender As Object, e As EventArgs) Handles BtnUpdatePlayers.Click
    '    ' Desactivar botón mientras se ejecuta
    '    BtnUpdatePlayers.Enabled = False

    '    ' Recorrer las filas del DataGridView2
    '    For Each row As DataGridViewRow In DataGridView2.Rows
    '        If Not row.IsNewRow Then
    '            Dim playerId As String = row.Cells("id").Value.ToString().Trim()

    '            If playerId <> "" Then
    '                ' Construir URL
    '                Dim url As String = $"https://sofifa.com/player/{playerId}"
    '                WebView22.Source = New Uri(url)

    '                ' Esperar 5 segundos antes del siguiente
    '                Await Task.Delay(5000)
    '
    '                ()
    '            End If
    '    End If
    '    Next

    '    ' Reactivar botón al terminar
    '    BtnUpdatePlayers.Enabled = True
    'End Sub
    Private Async Sub BtnUpdatePlayers_Click(sender As Object, e As EventArgs) Handles BtnUpdatePlayers.Click
        BtnUpdatePlayers.Enabled = False

        ' Verificar que hay una fila seleccionada y que tiene ID
        If DataGridView2.CurrentRow IsNot Nothing AndAlso
           Not DataGridView2.CurrentRow.IsNewRow AndAlso
           DataGridView2.CurrentRow.Cells("id").Value IsNot Nothing Then

            ' Guardar posición actual
            Dim rowIndex = DataGridView2.CurrentRow.Index
            Dim colIndex = DataGridView2.CurrentCell.ColumnIndex

            Dim playerId = DataGridView2.CurrentRow.Cells("id").Value.ToString.Trim

            If playerId <> "" Then
                Dim url = $"https://sofifa.com/player/{playerId}"
                WebView22.Source = New Uri(url)

                ' Esperar 5 segundos antes de insertar
                Await Task.Delay(5000)
                InsertData()

                ' Volver a aplicar el filtro actual
                If TxtBuscaNombre.Text <> "" Then
                    ContactsByName()
                ElseIf txt_BuscarClub.Text <> "" Then
                    ContactsByClub()
                ElseIf Txt_BuscaNat.Text <> "" Then
                    ContactsByNat()
                ElseIf Txt_BuscarNatTeam.Text <> "" Then
                    ContactsByNationalTeam()
                Else
                    allContatcs()
                End If

                ' Restaurar foco a la misma celda
                If rowIndex < DataGridView2.Rows.Count AndAlso colIndex < DataGridView2.Columns.Count Then
                    DataGridView2.CurrentCell = DataGridView2.Rows(rowIndex).Cells(colIndex)
                End If
            End If
        End If

        BtnUpdatePlayers.Enabled = True
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
            txt_id.Text = selectedRow.Cells("id").Value.ToString()
            id = selectedRow.Cells("id").Value.ToString()
            numclub = selectedRow.Cells("NumClub").Value.ToString()
            numnational = selectedRow.Cells("NumNation").Value.ToString()
            formmcr.cmbskincolor.Text = selectedRow.Cells("SkinColor").Value.ToString()
            formmcr.cmbhair.Text = selectedRow.Cells("Hair").Value.ToString()
            formmcr.cmbhaircolor.Text = selectedRow.Cells("HairColor").Value.ToString()
            formmcr.cmbhairface.Text = selectedRow.Cells("HairFace").Value.ToString()
            formmcr.cmbhaircolorface.Text = selectedRow.Cells("HairColorFace").Value.ToString()
            formmcr.txtplayername.Text = selectedRow.Cells("NAMEWE").Value.ToString()
            formmcr.cmbposition.Text = selectedRow.Cells("Position").Value.ToString
            formmcr.cmbheigth.Text = selectedRow.Cells("Height").Value.ToString
            formmcr.cmbbody.Text = selectedRow.Cells("Body").Value.ToString
            formmcr.cmbage.Text = selectedRow.Cells("Age").Value.ToString
            formmcr.cmbboots.Text = selectedRow.Cells("Boots").Value.ToString
            formmcr.cmbfood.Text = selectedRow.Cells("Feet").Value.ToString
            formmcr.cmbfeedoutside.Text = selectedRow.Cells("FeetOutside").Value.ToString
            formmcr.cmboffense.Text = selectedRow.Cells("Ofensse").Value.ToString
            formmcr.cmbdeffense.Text = selectedRow.Cells("Deffense").Value.ToString
            formmcr.cmbbodybalance.Text = selectedRow.Cells("BodyBalance").Value.ToString
            formmcr.cmbstamina.Text = selectedRow.Cells("Stamina").Value.ToString
            formmcr.cmbspeed.Text = selectedRow.Cells("Speed").Value.ToString
            formmcr.cmbaceleration.Text = selectedRow.Cells("Acceleration").Value.ToString
            formmcr.cmbpass.Text = selectedRow.Cells("Pass").Value.ToString
            formmcr.cmbshotpower.Text = selectedRow.Cells("ShotPower").Value.ToString
            formmcr.cmbshotacc.Text = selectedRow.Cells("ShotAcc").Value.ToString
            formmcr.cmbjump.Text = selectedRow.Cells("Jump").Value.ToString
            formmcr.cmbhead.Text = selectedRow.Cells("Head").Value.ToString
            formmcr.cmbtechnique.Text = selectedRow.Cells("Technique").Value.ToString
            formmcr.cmbdribble.Text = selectedRow.Cells("Dribble").Value.ToString
            formmcr.cmbcurve.Text = selectedRow.Cells("Curve").Value.ToString
            formmcr.cmbaggression.Text = selectedRow.Cells("Aggresive").Value.ToString
            formmcr.cmbresponse.Text = selectedRow.Cells("Response").Value.ToString
            formmcr.cmbclubnumber.Text = selectedRow.Cells("NumClub").Value.ToString
            formmcr.txtnacionalidad.Text = selectedRow.Cells("Nation").Value.ToString
            formmcr.txt_nat_team.Text = selectedRow.Cells("NationalTeam").Value.ToString
            formmcr.txtclub.Text = selectedRow.Cells("Club").Value.ToString
            formmcr.lbl_link.Text = selectedRow.Cells("Link").Value.ToString
            Dim valorName = DataGridView2.CurrentRow.Cells("name").Value
            If valorName IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(valorName.ToString()) Then
                TxtSofifaName.Text = valorName.ToString()
            End If


            indexcmbskikcolour = formmcr.cmbskincolor.Text
            indexcmbhaircolor = formmcr.cmbhaircolor.Text
            indexcmbhairface = formmcr.cmbhairface.SelectedIndex
            indexcmbhair = formmcr.cmbhair.SelectedIndex
            indexcmbhaircolourface = formmcr.cmbhaircolorface.Text

            SKINCOLOUR()
            LoadContacts()
            If Not String.IsNullOrEmpty(txt_id.Text) Then
                Using connection As New SQLiteConnection(connectionString)
                    connection.Open()
                    Dim command As New SQLiteCommand("SELECT PhotoBlob FROM Players WHERE Id = @Id", connection)
                    command.Parameters.AddWithValue("@Id", txt_id.Text)
                    formmcr.PictureFifa.Image = Image.FromFile(My.Computer.FileSystem.CurrentDirectory & "\player_0.png")
                    connection.Close()
                End Using
            End If

        End If
    End Sub



    Private Async Sub BtnUpdateAllSF_Click(sender As Object, e As EventArgs) Handles BtnUpdateAllSF.Click
        ' Desactivar botón mientras se ejecuta
        BtnUpdateAllSF.Enabled = False

        ' Recorrer las filas del DataGridView2
        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow Then
                Dim playerId As String = row.Cells("id").Value.ToString().Trim()

                If playerId <> "" Then
                    ' Construir URL
                    Dim url As String = $"https://sofifa.com/player/{playerId}"
                    WebView22.Source = New Uri(url)

                    ' Esperar 5 segundos antes del siguiente
                    Await Task.Delay(5000)
                    InsertData()
                End If
            End If
        Next

        ' Reactivar botón al terminar
        BtnUpdateAllSF.Enabled = True
    End Sub

    Private Async Sub BtnUpdatedAllFm_Click(sender As Object, e As EventArgs) Handles BtnUpdatedAllFm.Click
        ' Desactivar botón mientras se ejecuta
        BtnUpdatedAllFm.Enabled = False

        ' Recorrer las filas del DataGridView2
        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow Then
                Dim playerId As String = row.Cells("id").Value.ToString().Trim()

                If playerId <> "" Then
                    ' Construir URL
                    Dim url As String = $"https://fminside.net/players/5-fm-243/{playerId}" & "-a"
                    WebView22.Source = New Uri(url)

                    ' Esperar 5 segundos antes del siguiente
                    Await Task.Delay(5000)
                    InsertData()
                End If
            End If
        Next

        ' Reactivar botón al terminar
        BtnUpdatedAllFm.Enabled = True
    End Sub

    Private Sub BtnSinFoto_Click(sender As Object, e As EventArgs) Handles BtnSinFoto.Click
        AllPlayersWithoutPhoto()
    End Sub

    Private Sub BtnDeleted_Click(sender As Object, e As EventArgs) Handles BtnDeleted.Click
        If DataGridView2.SelectedRows.Count > 0 Then
            ' Obtener el ID de la fila seleccionada
            Dim id As Long = CLng(DataGridView2.SelectedRows(0).Cells("id").Value)

            ' Confirmar borrado
            If MessageBox.Show("¿Seguro que quieres eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Using connection As New SQLiteConnection(connectionString)
                    connection.Open()
                    Dim cmd As New SQLiteCommand("DELETE FROM Players WHERE id = @id", connection)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using

                ' Quitar la fila del DataGridView
                DataGridView2.Rows.RemoveAt(DataGridView2.SelectedRows(0).Index)
            End If
        Else
            MessageBox.Show("Selecciona una fila primero.")
        End If

    End Sub
    Private Async Sub UpdateSel_Click(sender As Object, e As EventArgs) Handles BtnUpdateSel.Click
        BtnUpdateSel.Enabled = False
        Try
            If DataGridView2.CurrentRow IsNot Nothing AndAlso
               Not DataGridView2.CurrentRow.IsNewRow AndAlso
               DataGridView2.CurrentRow.Cells("Link").Value IsNot Nothing Then

                Dim rowIndex = DataGridView2.CurrentRow.Index
                Dim colIndex = DataGridView2.CurrentCell.ColumnIndex
                Dim LinkId = DataGridView2.CurrentRow.Cells("Link").Value.ToString().Trim()

                If LinkId <> "" Then
                    Dim uri As Uri = Nothing
                    If Uri.TryCreate(LinkId, UriKind.Absolute, uri) Then

                        ' 🚫 No guardar historial → forzamos a limpiar antes
                        Await WebView22.EnsureCoreWebView2Async(Nothing)
                        WebView22.CoreWebView2.Navigate("about:blank")
                        Await Task.Delay(200) ' un pequeño delay para asegurar que cargue en blanco

                        ' Ahora sí cargar la URL real
                        WebView22.Source = uri

                        Await Task.Delay(5000)

                        InsertData() ' si lo haces Async

                        If TxtBuscaNombre.Text <> "" Then
                            ContactsByName()
                        ElseIf txt_BuscarClub.Text <> "" Then
                            ContactsByClub()
                        ElseIf Txt_BuscaNat.Text <> "" Then
                            ContactsByNat()
                        ElseIf Txt_BuscarNatTeam.Text <> "" Then
                            ContactsByNationalTeam()
                        Else
                            allContatcs()
                        End If

                        If rowIndex < DataGridView2.Rows.Count AndAlso colIndex < DataGridView2.Columns.Count Then
                            DataGridView2.CurrentCell = DataGridView2.Rows(rowIndex).Cells(colIndex)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            BtnUpdateSel.Enabled = True
        End Try
    End Sub

    Private Async Sub BtnUpdateAll_Click(sender As Object, e As EventArgs) Handles BtnUpdateAll.Click
        ' Desactivar botón mientras se ejecuta
        BtnUpdateAll.Enabled = False

        ' Recorrer las filas del DataGridView2
        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow AndAlso row.Cells("Link").Value IsNot Nothing Then
                Dim link As String = row.Cells("Link").Value.ToString().Trim()

                If link <> "" Then
                    ' Asignar la URL directamente al WebView2
                    WebView22.Source = New Uri(link)

                    ' Esperar 5 segundos antes de procesar la siguiente
                    Await Task.Delay(7000)

                    ' Llamar a InsertData para procesar la fila
                    InsertData()

                    If TxtBuscaNombre.Text <> "" Then
                        ContactsByName()
                    ElseIf txt_BuscarClub.Text <> "" Then
                        ContactsByClub()
                    ElseIf Txt_BuscaNat.Text <> "" Then
                        ContactsByNat()
                    ElseIf Txt_BuscarNatTeam.Text <> "" Then
                        ContactsByNationalTeam()
                    Else
                        allContatcs()
                    End If

                End If
            End If
        Next

        BtnUpdateAll.Enabled = True
    End Sub


    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged
        LoadContacts()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Process.Start(New ProcessStartInfo With {
    .FileName = "https://www.youtube.com/@Pasionwe",
    .UseShellExecute = True
})
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start(New ProcessStartInfo With {
.FileName = "https://pasionwemod.blogspot.com/",
.UseShellExecute = True
})
    End Sub


    Public Sub RemovePhotoColumn()
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            ' Crear tabla temporal sin la columna PhotoBlob
            Dim commands As String() = {
                "CREATE TABLE Players_temp AS SELECT Id, Name, SkinColor, Hair, HairColor, HairFace, HairColorFace, Club, NationalTeam, Nation, NumClub, NumNation, NAMEWE, Position, Birthday, Height, Body, Age, Boots, Feet, FeetOutside, Ofensse, Deffense, BodyBalance, Stamina, Speed, Acceleration, Pass, ShotPower, ShotAcc, Jump, Head, Technique, Dribble, Curve, Aggresive, Response, Link, Photo FROM Players",
                "DROP TABLE Players",
                "ALTER TABLE Players_temp RENAME TO Players"
            }

            For Each cmdText As String In commands
                Using command As New SQLiteCommand(cmdText, connection)
                    command.ExecuteNonQuery()
                End Using
            Next

            connection.Close()
        End Using

        MessageBox.Show("Columna de fotos eliminada completamente.")
        LoadContacts()
    End Sub
    Public Sub DeleteAllPhotos()
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Dim updateCommand As New SQLiteCommand("UPDATE Players SET PhotoBlob = NULL", connection)
            updateCommand.ExecuteNonQuery()

            connection.Close()
        End Using

        MessageBox.Show("Todas las fotos han sido eliminadas.")
        LoadContacts()
    End Sub
    Public Sub CompactDatabase()
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            ' Ejecutar VACUUM para liberar espacio
            Dim vacuumCommand As New SQLiteCommand("VACUUM", connection)
            vacuumCommand.ExecuteNonQuery()

            connection.Close()
        End Using

        MessageBox.Show("Base de datos compactada exitosamente.")

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        DeleteAllPhotos()
        CompactDatabase()
    End Sub
    Public Sub ExportarSQLiteAJson()
        Dim jugadoresList As List(Of Jugador) = CargarJugadoresDesdeSQLite()
        GuardarJugadoresAJson(jugadoresList, "jugadores_exportados.json")
        MessageBox.Show("Datos exportados de SQLite a JSON exitosamente.")
    End Sub

    Public Function CargarJugadoresDesdeSQLite() As List(Of Jugador)
        Dim jugadoresList As New List(Of Jugador)()

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Dim command As New SQLiteCommand("SELECT * FROM Players", connection)
            Using reader As SQLiteDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim jugador As New Jugador() With {
                        .Indice = Convert.ToInt32(reader("Id")),
                        .Nombre = If(reader("NAMEWE") Is DBNull.Value, "", reader("NAMEWE").ToString()),
                        .Position = If(reader("Position") Is DBNull.Value, "", reader("Position").ToString()),
                        .Offense = If(reader("Ofensse") Is DBNull.Value, 0, Convert.ToInt32(reader("Ofensse"))),
                        .Defense = If(reader("Deffense") Is DBNull.Value, 0, Convert.ToInt32(reader("Deffense"))),
                        .BodyBalance = If(reader("BodyBalance") Is DBNull.Value, 0, Convert.ToInt32(reader("BodyBalance"))),
                        .Stamina = If(reader("Stamina") Is DBNull.Value, 0, Convert.ToInt32(reader("Stamina"))),
                        .Speed = If(reader("Speed") Is DBNull.Value, 0, Convert.ToInt32(reader("Speed"))),
                        .Acceleration = If(reader("Acceleration") Is DBNull.Value, 0, Convert.ToInt32(reader("Acceleration"))),
                        .PassAcc = If(reader("Pass") Is DBNull.Value, 0, Convert.ToInt32(reader("Pass"))),
                        .ShotPwr = If(reader("ShotPower") Is DBNull.Value, 0, Convert.ToInt32(reader("ShotPower"))),
                        .ShotAcc = If(reader("ShotAcc") Is DBNull.Value, 0, Convert.ToInt32(reader("ShotAcc"))),
                        .Jump = If(reader("Jump") Is DBNull.Value, 0, Convert.ToInt32(reader("Jump"))),
                        .Head = If(reader("Head") Is DBNull.Value, 0, Convert.ToInt32(reader("Head"))),
                        .Technique = If(reader("Technique") Is DBNull.Value, 0, Convert.ToInt32(reader("Technique"))),
                        .Dribble = If(reader("Dribble") Is DBNull.Value, 0, Convert.ToInt32(reader("Dribble"))),
                        .Curve = If(reader("Curve") Is DBNull.Value, 0, Convert.ToInt32(reader("Curve"))),
                        .Aggression = If(reader("Aggresive") Is DBNull.Value, 0, Convert.ToInt32(reader("Aggresive"))),
                        .Response = If(reader("Response") Is DBNull.Value, 0, Convert.ToInt32(reader("Response"))),
                        .Age = If(reader("Age") Is DBNull.Value, 0, Convert.ToInt32(reader("Age"))),
                        .Height = If(reader("Height") Is DBNull.Value, 0, Convert.ToInt32(reader("Height"))),
                        .Body = If(reader("Body") Is DBNull.Value, "", reader("Body").ToString()),
                        .SkinColor = If(reader("SkinColor") Is DBNull.Value, "", reader("SkinColor").ToString()),
                        .PlayerNumber = If(reader("NumClub") Is DBNull.Value, 0, Convert.ToInt32(reader("NumClub"))),
                        .Hair = If(reader("Hair") Is DBNull.Value, "", reader("Hair").ToString()),
                        .HairColor = If(reader("HairColor") Is DBNull.Value, "", reader("HairColor").ToString()),
                        .HairFace = If(reader("HairFace") Is DBNull.Value, "", reader("HairFace").ToString()),
                        .HairColorFace = If(reader("HairColorFace") Is DBNull.Value, "", reader("HairColorFace").ToString()),
                        .Feet = If(reader("Feet") Is DBNull.Value, "", reader("Feet").ToString()),
                        .Boots = If(reader("Boots") Is DBNull.Value, "", reader("Boots").ToString()),
                        .FeetOutside = If(reader("FeetOutside") Is DBNull.Value, "", reader("FeetOutside").ToString()),
                        .Team = If(reader("NationalTeam") Is DBNull.Value, "", reader("NationalTeam").ToString()),
                        .NatNumber = If(reader("NumNation") Is DBNull.Value, "", reader("NumNation").ToString()),
                        .Club = If(reader("Club") Is DBNull.Value, "", reader("Club").ToString()),
                        .ClubNumber = If(reader("NumClub") Is DBNull.Value, "", reader("NumClub").ToString())
                    }
                    jugadoresList.Add(jugador)
                End While
            End Using

            connection.Close()
        End Using

        Return jugadoresList
    End Function

    Public Sub GuardarJugadoresAJson(jugadores As List(Of Jugador), filePath As String)
        Dim json As String = JsonConvert.SerializeObject(jugadores, Formatting.Indented)
        File.WriteAllText(filePath, json)
    End Sub

    Private Sub Btn_ExportJSon_Click(sender As Object, e As EventArgs) Handles Btn_ExportJSon.Click
        ExportarSQLiteAJson()

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles BtnFM.Click
        SelectCalcMCR = 2
        'delayweb = 3500
        'delayweb2 = 3500
        selectFM_Sofifa = 0
        WebView21.CoreWebView2.Navigate("https://fminside.net/players")

        WebView21.ZoomFactor = 0.6
        WebView21.Width = 623
        WebView22.Visible = False
        visiblebtnplayerfifa = False
        txt_searchplayer.Visible = False
        lbl_searchplayer.Visible = False
        lbl_customizedplayer111.Visible = False
        Btn_FmInsidePlayers.Visible = False
        btn_FC_TM.Visible = False
        txt_searchClub.Visible = False
        Lbl_searchClub.Visible = False
        txt_PlayerSofifa.Visible = False
        Lbl_Player_Sofifa.Visible = False
        txt_CustomPlayerSofifa.Visible = False
        Lbl_CustomPlayer_Sofifa.Visible = False
        DataGridView2.Visible = False
        TxtBuscaNombre.Visible = False
        Txt_BuscaNat.Visible = False
        txt_BuscarClub.Visible = False
        Txt_BuscarNatTeam.Visible = False
        BtnUpdateAll.Visible = False
        BtnUpdateSel.Visible = False
        BtnDeleted.Visible = False
        Btn_ExportJSon.Visible = False

        btnplayerfifavisibe()
        visiblebtnplayerTM = False
        visiblebtnTM()
    End Sub


    Private Sub btnDelay_Click(sender As Object, e As EventArgs) Handles btnDelay.Click
        delayweb = cmbDelay.Text
        delayweb2 = cmbDelay.Text
    End Sub


    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        SelectCalcMCR = 0
        'delayweb = 3500
        'delayweb2 = 0
        selectFM_Sofifa = 0
        WebView21.CoreWebView2.Navigate("https://pesretrostats.com/leagues")

        WebView21.ZoomFactor = 0.78
        WebView21.Width = 623
        WebView22.Visible = False
        visiblebtnplayerfifa = False
        txt_searchplayer.Visible = False
        lbl_searchplayer.Visible = False
        lbl_customizedplayer111.Visible = False
        Btn_FmInsidePlayers.Visible = False
        btn_FC_TM.Visible = False
        txt_searchClub.Visible = False
        Lbl_searchClub.Visible = False
        txt_PlayerSofifa.Visible = False
        Lbl_Player_Sofifa.Visible = False
        txt_CustomPlayerSofifa.Visible = False
        Lbl_CustomPlayer_Sofifa.Visible = False
        DataGridView2.Visible = False
        TxtBuscaNombre.Visible = False
        Txt_BuscaNat.Visible = False
        txt_BuscarClub.Visible = False
        Txt_BuscarNatTeam.Visible = False
        BtnUpdateAll.Visible = False
        BtnUpdateSel.Visible = False
        BtnDeleted.Visible = False
        Btn_ExportJSon.Visible = False

        btnplayerfifavisibe()
        visiblebtnplayerTM = False
        visiblebtnTM()
    End Sub

    Private Sub WebView21_Click(sender As Object, e As EventArgs) Handles WebView21.Click

    End Sub

    Private Sub WebView22_Click(sender As Object, e As EventArgs) Handles WebView22.Click

    End Sub

    Private Sub btn_EF_TM_Click(sender As Object, e As EventArgs) Handles btn_EF_TM.Click
        delayweb2 = 0
        selectFM_Sofifa = 2
        WebView22.Source = New Uri("https://www.pesmaster.com/efootball-2022/")
        'WebView21.ZoomFactor = 2.0
        WebView22.Visible = True
        visiblebtnplayerfifa = False
        txt_PlayerSofifa.Visible = False
        Lbl_Player_Sofifa.Visible = False
        txt_CustomPlayerSofifa.Visible = False
        Lbl_CustomPlayer_Sofifa.Visible = False
        txt_searchplayer.Visible = False
        lbl_searchplayer.Visible = False
        lbl_customizedplayer111.Visible = False
        txt_searchClub.Visible = False
        Lbl_searchClub.Visible = False


        btnplayerfifavisibe()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim result As DialogResult

        result = MessageBox.Show(
    "Are you sure?" & vbCrLf & vbCrLf &
    "All unsaved data will be deleted.",
    "New Memory Card",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning
)

        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class

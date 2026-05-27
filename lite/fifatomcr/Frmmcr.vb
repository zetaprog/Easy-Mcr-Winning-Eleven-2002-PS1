
'Imports Player.StatsSkills
'Imports Player.PlayerProperties
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient


Public Class FrmMCR
    Dim indexcmbhair As Integer
    Dim indexcmbhaircolor As Integer
    Dim indexcmbskikcolour As Integer
    Dim indexcmbhairface As Integer
    Dim con As New OleDbConnection
    Dim sql As New OleDbCommand
    Dim consulta As String
    Dim dr As OleDbDataAdapter
    Dim ord As DataSet
    Dim busca As Byte
    Dim izquierda As Integer
    Dim alto As Integer
    Dim activamovemouse As Integer




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        total = libro.Sheets(1).Range("a1").CurrentRegion.Rows.Count
        total = total - 1

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog1.FileName = My.Application.Info.DirectoryPath & "\database.mcr"



        'FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        'OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        'picapariencia.ImageLocation = OpenFileDialog2.FileName
        'FileClose(2)

        'FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        'OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        'picapariencia.ImageLocation = OpenFileDialog2.FileName
        FileClose(1)


        'Dim apppath As String = My.Application.Info.DirectoryPath & "\pelo\pelo_0.bmp"

        'MsgBox(apppath)
        rbtnclub.Checked = True

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

        'formformation.Hide()



        formmcr.lblposiplayer1.Text = "GK"

        formmcr.lblposiplayer2.Text = formformation.cbplayer1.Text
        If formformation.cbplayer1.Text = "CB-L" Or formformation.cbplayer1.Text = "CB-R" Or formformation.cbplayer1.Text = "SW" Or formformation.cbplayer1.Text = "LIB" Or formformation.cbplayer1.Text = "CB-C" Or formformation.cbplayer1.Text = "LB" Or formformation.cbplayer1.Text = "RB" Then
            formmcr.lblposiplayer2.BackColor = Color.LightSeaGreen
        End If
        If formformation.cbplayer1.Text = "DH-L" Or formformation.cbplayer1.Text = "DH-C" Or formformation.cbplayer1.Text = "DH-R" Or formformation.cbplayer1.Text = "LH" Or formformation.cbplayer1.Text = "RH" Or formformation.cbplayer1.Text = "OH-L" Or formformation.cbplayer1.Text = "OH-C" Or formformation.cbplayer1.Text = "OH-R" Then
            formmcr.lblposiplayer2.BackColor = Color.DarkSeaGreen
        End If
        If formformation.cbplayer1.Text = "CF-L" Or formformation.cbplayer1.Text = "CF-C" Or formformation.cbplayer1.Text = "CF-R" Or formformation.cbplayer1.Text = "LW" Or formformation.cbplayer1.Text = "RW" Then
            formmcr.lblposiplayer2.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer3.Text = formformation.CbPlayer2.Text
        If formformation.CbPlayer2.Text = "CB-L" Or formformation.CbPlayer2.Text = "CB-R" Or formformation.CbPlayer2.Text = "SW" Or formformation.CbPlayer2.Text = "LIB" Or formformation.CbPlayer2.Text = "CB-C" Or formformation.CbPlayer2.Text = "LB" Or formformation.CbPlayer2.Text = "RB" Then
            formmcr.lblposiplayer3.BackColor = Color.LightSeaGreen
        End If
        If formformation.CbPlayer2.Text = "DH-L" Or formformation.CbPlayer2.Text = "DH-C" Or formformation.CbPlayer2.Text = "DH-R" Or formformation.CbPlayer2.Text = "LH" Or formformation.CbPlayer2.Text = "RH" Or formformation.CbPlayer2.Text = "OH-L" Or formformation.CbPlayer2.Text = "OH-C" Or formformation.CbPlayer2.Text = "OH-R" Then
            formmcr.lblposiplayer3.BackColor = Color.DarkSeaGreen
        End If
        If formformation.CbPlayer2.Text = "CF-L" Or formformation.CbPlayer2.Text = "CF-C" Or formformation.CbPlayer2.Text = "CF-R" Or formformation.CbPlayer2.Text = "LW" Or formformation.CbPlayer2.Text = "RW" Then
            formmcr.lblposiplayer3.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer4.Text = formformation.CbPlayer3.Text
        If formformation.CbPlayer3.Text = "CB-L" Or formformation.CbPlayer3.Text = "CB-R" Or formformation.CbPlayer3.Text = "SW" Or formformation.CbPlayer3.Text = "LIB" Or formformation.CbPlayer3.Text = "CB-C" Or formformation.CbPlayer3.Text = "LB" Or formformation.CbPlayer3.Text = "RB" Then
            formmcr.lblposiplayer4.BackColor = Color.LightSeaGreen
        End If
        If formformation.CbPlayer3.Text = "DH-L" Or formformation.CbPlayer3.Text = "DH-C" Or formformation.CbPlayer3.Text = "DH-R" Or formformation.CbPlayer3.Text = "LH" Or formformation.CbPlayer3.Text = "RH" Or formformation.CbPlayer3.Text = "OH-L" Or formformation.CbPlayer3.Text = "OH-C" Or formformation.CbPlayer3.Text = "OH-R" Then
            formmcr.lblposiplayer4.BackColor = Color.DarkSeaGreen
        End If
        If formformation.CbPlayer3.Text = "CF-L" Or formformation.CbPlayer3.Text = "CF-C" Or formformation.CbPlayer3.Text = "CF-R" Or formformation.CbPlayer3.Text = "LW" Or formformation.CbPlayer3.Text = "RW" Then
            formmcr.lblposiplayer4.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer5.Text = formformation.CbPlayer4.Text
        If formformation.CbPlayer4.Text = "CB-L" Or formformation.CbPlayer4.Text = "CB-R" Or formformation.CbPlayer4.Text = "SW" Or formformation.CbPlayer4.Text = "LIB" Or formformation.CbPlayer4.Text = "CB-C" Or formformation.CbPlayer4.Text = "LB" Or formformation.CbPlayer4.Text = "RB" Then
            formmcr.lblposiplayer5.BackColor = Color.LightSeaGreen
        End If
        If formformation.CbPlayer4.Text = "DH-L" Or formformation.CbPlayer4.Text = "DH-C" Or formformation.CbPlayer4.Text = "DH-R" Or formformation.CbPlayer4.Text = "LH" Or formformation.CbPlayer4.Text = "RH" Or formformation.CbPlayer4.Text = "OH-L" Or formformation.CbPlayer4.Text = "OH-C" Or formformation.CbPlayer4.Text = "OH-R" Then
            formmcr.lblposiplayer5.BackColor = Color.DarkSeaGreen
        End If
        If formformation.CbPlayer4.Text = "CF-L" Or formformation.CbPlayer4.Text = "CF-C" Or formformation.CbPlayer4.Text = "CF-R" Or formformation.CbPlayer4.Text = "LW" Or formformation.CbPlayer4.Text = "RW" Then
            formmcr.lblposiplayer5.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer6.Text = formformation.CbPlayer5.Text
        If formformation.CbPlayer5.Text = "CB-L" Or formformation.CbPlayer5.Text = "CB-R" Or formformation.CbPlayer5.Text = "SW" Or formformation.CbPlayer5.Text = "LIB" Or formformation.CbPlayer5.Text = "CB-C" Or formformation.CbPlayer5.Text = "LB" Or formformation.CbPlayer5.Text = "RB" Then
            formmcr.lblposiplayer6.BackColor = Color.LightSeaGreen
        End If
        If formformation.CbPlayer5.Text = "DH-L" Or formformation.CbPlayer5.Text = "DH-C" Or formformation.CbPlayer5.Text = "DH-R" Or formformation.CbPlayer5.Text = "LH" Or formformation.CbPlayer5.Text = "RH" Or formformation.CbPlayer5.Text = "OH-L" Or formformation.CbPlayer5.Text = "OH-C" Or formformation.CbPlayer5.Text = "OH-R" Then
            formmcr.lblposiplayer6.BackColor = Color.DarkSeaGreen
        End If
        If formformation.CbPlayer5.Text = "CF-L" Or formformation.CbPlayer5.Text = "CF-C" Or formformation.CbPlayer5.Text = "CF-R" Or formformation.CbPlayer5.Text = "LW" Or formformation.CbPlayer5.Text = "RW" Then
            formmcr.lblposiplayer6.BackColor = Color.PaleVioletRed
        End If


        formmcr.lblposiplayer7.Text = formformation.CbPlayer6.Text
        If formformation.CbPlayer6.Text = "CB-L" Or formformation.CbPlayer6.Text = "CB-R" Or formformation.CbPlayer6.Text = "SW" Or formformation.CbPlayer6.Text = "LIB" Or formformation.CbPlayer6.Text = "CB-C" Or formformation.CbPlayer6.Text = "LB" Or formformation.CbPlayer6.Text = "RB" Then
            formmcr.lblposiplayer7.BackColor = Color.LightSeaGreen
        End If
        If formformation.CbPlayer6.Text = "DH-L" Or formformation.CbPlayer6.Text = "DH-C" Or formformation.CbPlayer6.Text = "DH-R" Or formformation.CbPlayer6.Text = "LH" Or formformation.CbPlayer6.Text = "RH" Or formformation.CbPlayer6.Text = "OH-L" Or formformation.CbPlayer6.Text = "OH-C" Or formformation.CbPlayer6.Text = "OH-R" Then
            formmcr.lblposiplayer7.BackColor = Color.DarkSeaGreen
        End If
        If formformation.CbPlayer6.Text = "CF-L" Or formformation.CbPlayer6.Text = "CF-C" Or formformation.CbPlayer6.Text = "CF-R" Or formformation.CbPlayer6.Text = "LW" Or formformation.CbPlayer6.Text = "RW" Then
            formmcr.lblposiplayer7.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer8.Text = formformation.CbPlayer7.Text
        If formformation.CbPlayer7.Text = "CB-L" Or formformation.CbPlayer7.Text = "CB-R" Or formformation.CbPlayer7.Text = "SW" Or formformation.CbPlayer7.Text = "LIB" Or formformation.CbPlayer7.Text = "CB-C" Or formformation.CbPlayer7.Text = "LB" Or formformation.CbPlayer7.Text = "RB" Then
            formmcr.lblposiplayer8.BackColor = Color.LightSeaGreen
        End If
        If formformation.CbPlayer7.Text = "DH-L" Or formformation.CbPlayer7.Text = "DH-C" Or formformation.CbPlayer7.Text = "DH-R" Or formformation.CbPlayer7.Text = "LH" Or formformation.CbPlayer7.Text = "RH" Or formformation.CbPlayer7.Text = "OH-L" Or formformation.CbPlayer7.Text = "OH-C" Or formformation.CbPlayer7.Text = "OH-R" Then
            formmcr.lblposiplayer8.BackColor = Color.DarkSeaGreen
        End If
        If formformation.CbPlayer7.Text = "CF-L" Or formformation.CbPlayer7.Text = "CF-C" Or formformation.CbPlayer7.Text = "CF-R" Or formformation.CbPlayer7.Text = "LW" Or formformation.CbPlayer7.Text = "RW" Then
            formmcr.lblposiplayer8.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer9.Text = formformation.CbPlayer8.Text
        If formformation.CbPlayer8.Text = "CB-L" Or formformation.CbPlayer8.Text = "CB-R" Or formformation.CbPlayer8.Text = "SW" Or formformation.CbPlayer8.Text = "LIB" Or formformation.CbPlayer8.Text = "CB-C" Or formformation.CbPlayer8.Text = "LB" Or formformation.CbPlayer8.Text = "RB" Then
            formmcr.lblposiplayer9.BackColor = Color.LightSeaGreen
        End If
        If formformation.CbPlayer8.Text = "DH-L" Or formformation.CbPlayer8.Text = "DH-C" Or formformation.CbPlayer8.Text = "DH-R" Or formformation.CbPlayer8.Text = "LH" Or formformation.CbPlayer8.Text = "RH" Or formformation.CbPlayer8.Text = "OH-L" Or formformation.CbPlayer8.Text = "OH-C" Or formformation.CbPlayer8.Text = "OH-R" Then
            formmcr.lblposiplayer9.BackColor = Color.DarkSeaGreen
        End If
        If formformation.CbPlayer8.Text = "CF-L" Or formformation.CbPlayer8.Text = "CF-C" Or formformation.CbPlayer8.Text = "CF-R" Or formformation.CbPlayer8.Text = "LW" Or formformation.CbPlayer8.Text = "RW" Then
            formmcr.lblposiplayer9.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer10.Text = formformation.CbPlayer9.Text
        If formformation.CbPlayer9.Text = "CB-L" Or formformation.CbPlayer9.Text = "CB-R" Or formformation.CbPlayer9.Text = "SW" Or formformation.CbPlayer9.Text = "LIB" Or formformation.CbPlayer9.Text = "CB-C" Or formformation.CbPlayer9.Text = "LB" Or formformation.CbPlayer9.Text = "RB" Then
            formmcr.lblposiplayer10.BackColor = Color.LightSeaGreen
        End If
        If formformation.CbPlayer9.Text = "DH-L" Or formformation.CbPlayer9.Text = "DH-C" Or formformation.CbPlayer9.Text = "DH-R" Or formformation.CbPlayer9.Text = "LH" Or formformation.CbPlayer9.Text = "RH" Or formformation.CbPlayer9.Text = "OH-L" Or formformation.CbPlayer9.Text = "OH-C" Or formformation.CbPlayer9.Text = "OH-R" Then
            formmcr.lblposiplayer10.BackColor = Color.DarkSeaGreen
        End If
        If formformation.CbPlayer9.Text = "CF-L" Or formformation.CbPlayer9.Text = "CF-C" Or formformation.CbPlayer9.Text = "CF-R" Or formformation.CbPlayer9.Text = "LW" Or formformation.CbPlayer9.Text = "RW" Then
            formmcr.lblposiplayer10.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer11.Text = formformation.CbPlayer10.Text
        If formformation.CbPlayer10.Text = "CB-L" Or formformation.CbPlayer10.Text = "CB-R" Or formformation.CbPlayer10.Text = "SW" Or formformation.CbPlayer10.Text = "LIB" Or formformation.CbPlayer10.Text = "CB-C" Or formformation.CbPlayer10.Text = "LB" Or formformation.CbPlayer10.Text = "RB" Then
            formmcr.lblposiplayer11.BackColor = Color.LightSeaGreen
        End If
        If formformation.CbPlayer10.Text = "DH-L" Or formformation.CbPlayer10.Text = "DH-C" Or formformation.CbPlayer10.Text = "DH-R" Or formformation.CbPlayer10.Text = "LH" Or formformation.CbPlayer10.Text = "RH" Or formformation.CbPlayer10.Text = "OH-L" Or formformation.CbPlayer10.Text = "OH-C" Or formformation.CbPlayer10.Text = "OH-R" Then
            formmcr.lblposiplayer11.BackColor = Color.DarkSeaGreen
        End If
        If formformation.CbPlayer10.Text = "CF-L" Or formformation.CbPlayer10.Text = "CF-C" Or formformation.CbPlayer10.Text = "CF-R" Or formformation.CbPlayer10.Text = "LW" Or formformation.CbPlayer10.Text = "RW" Then
            formmcr.lblposiplayer11.BackColor = Color.PaleVioletRed
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim lecturabytes As Byte() = My.Computer.FileSystem.ReadAllBytes(OpenFileDialog1.FileName)

        Dim nombre1equipo1 As New String("", 10)

        OpenFileDialog4.ShowDialog()
        Dim x As Integer
        x = 4
        FileOpen(x, OpenFileDialog4.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        rutaarchivo = OpenFileDialog4.FileName

        'cargando nombres en botones de nombres
        Dim offsetnomequipo As Integer

        offsetnomequipo = 22801
        Dim m As Integer
        For m = 0 To 22
            FileGet(x, nombre1equipo1, offsetnomequipo)
            ListBoxMcR.Items.RemoveAt(m)
            ListBoxMcR.Items.Insert(m, nombre1equipo1)
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
        Next

        'cargando numeros 
        'num1 - 2
        Dim offsetnumerojugador As Integer
        Dim numjug As Byte
        offsetnumerojugador = 21509
        For m = 0 To 22
            FileGet(x, numjug, offsetnumerojugador)

            'MsgBox(offsetnumerojugador)
            'MsgBox(numjug)
            offsetnumerojugador = offsetnumerojugador + 1
        Next
        FileClose()

        FileCopy(OpenFileDialog4.FileName, My.Application.Info.DirectoryPath & "\database.mcr")


        'offsets = 22788
        'RichTextBox1.Clear()

        'For x = 1 To 12
        '    caracteristicas()


        '    If Hex(Mid(lectorByte, 1)) >= 0 And Hex(Mid(lectorByte, 1)) <= 9 Then
        '        RichTextBox1.Text += 0 & Hex(lectorByte)

        '    Else




        '        If x = 1 Then TextBox1.Text = Hex(lectorByte)
        '        If TextBox1.TextLength = 1 Then TextBox1.Text = 0 & Hex(lectorByte)


        '        If x = 2 Then TextBox2.Text = Hex(lectorByte)
        '        If TextBox2.TextLength = 1 Then TextBox2.Text = 0 & Hex(lectorByte)

        '        If x = 3 Then TextBox3.Text = Hex(lectorByte)
        '        If TextBox3.TextLength = 1 Then TextBox3.Text = 0 & Hex(lectorByte)

        '        If x = 4 Then TextBox4.Text = Hex(lectorByte)
        '        If TextBox4.TextLength = 1 Then TextBox4.Text = 0 & Hex(lectorByte)

        '        If x = 5 Then TextBox5.Text = Hex(lectorByte)
        '        If TextBox5.TextLength = 1 Then TextBox5.Text = 0 & Hex(lectorByte)

        '        If x = 6 Then TextBox6.Text = Hex(lectorByte)
        '        If TextBox6.TextLength = 1 Then TextBox6.Text = 0 & Hex(lectorByte)

        '        If x = 7 Then TextBox7.Text = Hex(lectorByte)
        '        If TextBox7.TextLength = 1 Then TextBox7.Text = 0 & Hex(lectorByte)

        '        If x = 8 Then TextBox8.Text = Hex(lectorByte)
        '        If TextBox8.TextLength = 1 Then TextBox8.Text = 0 & Hex(lectorByte)

        '        If x = 9 Then TextBox9.Text = Hex(lectorByte)
        '        If TextBox9.TextLength = 1 Then TextBox9.Text = 0 & Hex(lectorByte)

        '        If x = 10 Then TextBox10.Text = Hex(lectorByte)
        '        If TextBox10.TextLength = 1 Then TextBox10.Text = 0 & Hex(lectorByte)

        '        If x = 11 Then TextBox11.Text = Hex(lectorByte)
        '        If TextBox11.TextLength = 1 Then TextBox11.Text = 0 & Hex(lectorByte)

        '        If x = 12 Then TextBox12.Text = Hex(lectorByte)
        '        If TextBox12.TextLength = 1 Then TextBox12.Text = 0 & Hex(lectorByte)

        '        RichTextBox1.Text += "-" & Convert.ToString(lectorByte, 2)




        '        offsets = offsets + 1

        '        RichTextBox1.Text += lectorByte
        'Next
        'ALLBYTES = TextBox1.Text & TextBox2.Text & TextBox3.Text & TextBox4.Text & TextBox5.Text & TextBox6.Text & TextBox7.Text & TextBox8.Text & TextBox9.Text & TextBox10.Text & TextBox11.Text & TextBox12.Text
        'TextBox15.Text = ALLBYTES

        'SS = TextBox15.Text





        'FileClose()




    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim a As Integer
        Dim b As Integer
        Dim c As Integer


        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)

        MsgBox(a + b + c)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        'num1 - 2
        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbnum1.FindString(cmbnum1.Text)
        cmbnum1.SelectedIndex = indexclubnumer
        cmbnum1index.SelectedIndex = indexclubnumer


        Dim indexclubnumer2 As Integer
        indexclubnumer2 = cmbnum2.FindString(cmbnum2.Text)
        cmbnum2.SelectedIndex = indexclubnumer2
        cmbnum2index.SelectedIndex = indexclubnumer2


        a = Convert.ToInt32(cmbnum1index.Text)
        b = Convert.ToInt32(cmbnum2index.Text)


        algoritmo2()


        guardar()

        'num3 - num4
        offset1 = 21509


        indexclubnumer = cmbnum3.FindString(cmbnum3.Text)
        cmbnum3.SelectedIndex = indexclubnumer
        cmbnum3index.SelectedIndex = indexclubnumer



        indexclubnumer2 = cmbnum4.FindString(cmbnum4.Text)
        cmbnum4.SelectedIndex = indexclubnumer2
        cmbnum4index.SelectedIndex = indexclubnumer2



        a = Convert.ToInt32(cmbnum3index.Text)
        b = Convert.ToInt32(cmbnum4index.Text)



        algoritmo2()



        guardar()


        'num5 - num6
        offset1 = 21510


        indexclubnumer = cmbnum5.FindString(cmbnum5.Text)
        cmbnum5.SelectedIndex = indexclubnumer
        cmbnum5index.SelectedIndex = indexclubnumer






        a = Convert.ToInt32(cmbnum5index.Text)
        b = 0



        algoritmo2()

        guardar()

        offset1 = 21511
        indexclubnumer2 = cmbnum6.FindString(cmbnum6.Text)
        cmbnum6.SelectedIndex = indexclubnumer2
        cmbnum6index.SelectedIndex = indexclubnumer2

        b = Convert.ToInt32(cmbnum6index.Text)
        a = 0
        algoritmo2()


        guardar()


        'num7 - num8
        offset1 = 21512

        indexclubnumer = cmbnum7.FindString(cmbnum7.Text)
        cmbnum7.SelectedIndex = indexclubnumer
        cmbnum7index.SelectedIndex = indexclubnumer

        indexclubnumer2 = cmbnum8.FindString(cmbnum8.Text)
        cmbnum8.SelectedIndex = indexclubnumer2
        cmbnum8index.SelectedIndex = indexclubnumer2


        a = Convert.ToInt32(cmbnum7index.Text)
        b = Convert.ToInt32(cmbnum8index.Text)



        algoritmo2()


        guardar()


        'num 9 - 10
        offset1 = 21513


        indexclubnumer = cmbnum9.FindString(cmbnum9.Text)
        cmbnum9.SelectedIndex = indexclubnumer
        cmbnum9index.SelectedIndex = indexclubnumer



        indexclubnumer2 = cmbnum10.FindString(cmbnum10.Text)
        cmbnum10.SelectedIndex = indexclubnumer2
        cmbnum10index.SelectedIndex = indexclubnumer2


        a = Convert.ToInt32(cmbnum9index.Text)
        b = Convert.ToInt32(cmbnum10index.Text)


        algoritmo2()


        guardar()

        'num 11-12

        offset1 = 21514


        indexclubnumer = cmbnum11.FindString(cmbnum11.Text)
        cmbnum11.SelectedIndex = indexclubnumer
        cmbnum11index.SelectedIndex = indexclubnumer






        a = Convert.ToInt32(cmbnum11index.Text)
        b = 0



        algoritmo2()

        guardar()

        offset1 = 21515
        indexclubnumer2 = cmbnum12.FindString(cmbnum12.Text)
        cmbnum12.SelectedIndex = indexclubnumer2
        cmbnum12index.SelectedIndex = indexclubnumer2

        b = Convert.ToInt32(cmbnum12index.Text)
        a = 0
        algoritmo2()


        guardar()


        'num 13- 14
        offset1 = 21516


        indexclubnumer = cmbnum13.FindString(cmbnum13.Text)
        cmbnum13.SelectedIndex = indexclubnumer
        cmbnum13index.SelectedIndex = indexclubnumer



        indexclubnumer2 = cmbnum14.FindString(cmbnum14.Text)
        cmbnum14.SelectedIndex = indexclubnumer2
        cmbnum14index.SelectedIndex = indexclubnumer2


        a = Convert.ToInt32(cmbnum13index.Text)
        b = Convert.ToInt32(cmbnum14index.Text)


        algoritmo2()


        guardar()

        'num 15- 16
        offset1 = 21517


        indexclubnumer = cmbnum15.FindString(cmbnum15.Text)
        cmbnum15.SelectedIndex = indexclubnumer
        cmbnum15index.SelectedIndex = indexclubnumer



        indexclubnumer2 = cmbnum16.FindString(cmbnum16.Text)
        cmbnum16.SelectedIndex = indexclubnumer2
        cmbnum16index.SelectedIndex = indexclubnumer2


        a = Convert.ToInt32(cmbnum15index.Text)
        b = Convert.ToInt32(cmbnum16index.Text)


        algoritmo2()


        guardar()

        'num 17-18

        offset1 = 21518


        indexclubnumer = cmbnum17.FindString(cmbnum17.Text)
        cmbnum17.SelectedIndex = indexclubnumer
        cmbnum17index.SelectedIndex = indexclubnumer






        a = Convert.ToInt32(cmbnum17index.Text)
        b = 0



        algoritmo2()

        guardar()

        offset1 = 21519
        indexclubnumer2 = cmbnum18.FindString(cmbnum18.Text)
        cmbnum18.SelectedIndex = indexclubnumer2
        cmbnum18index.SelectedIndex = indexclubnumer2

        b = Convert.ToInt32(cmbnum18index.Text)
        a = 0
        algoritmo2()


        guardar()


        'num 19- 20
        offset1 = 21520


        indexclubnumer = cmbnum19.FindString(cmbnum19.Text)
        cmbnum19.SelectedIndex = indexclubnumer
        cmbnum19index.SelectedIndex = indexclubnumer



        indexclubnumer2 = cmbnum20.FindString(cmbnum20.Text)
        cmbnum20.SelectedIndex = indexclubnumer2
        cmbnum20index.SelectedIndex = indexclubnumer2


        a = Convert.ToInt32(cmbnum19index.Text)
        b = Convert.ToInt32(cmbnum20index.Text)


        algoritmo2()


        guardar()

        'num 21- 22
        offset1 = 21521


        indexclubnumer = cmbnum21.FindString(cmbnum21.Text)
        cmbnum21.SelectedIndex = indexclubnumer
        cmbnum21index.SelectedIndex = indexclubnumer



        indexclubnumer2 = cmbnum22.FindString(cmbnum22.Text)
        cmbnum22.SelectedIndex = indexclubnumer2
        cmbnum22index.SelectedIndex = indexclubnumer2


        a = Convert.ToInt32(cmbnum21index.Text)
        b = Convert.ToInt32(cmbnum22index.Text)


        algoritmo2()


        guardar()


        'num 23

        offset1 = 21522


        indexclubnumer = cmbnum23.FindString(cmbnum23.Text)
        cmbnum23.SelectedIndex = indexclubnumer
        cmbnum23index.SelectedIndex = indexclubnumer



        a = Convert.ToInt32(cmbnum23index.Text)
        b = 0



        algoritmo2()

        guardar()


        offset1 = 21523
        b = 0
        a = 0

        algoritmo2()


        guardar()


        FileClose()

        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName <> "" Then
            MsgBox(SaveFileDialog1.FileName)
            FileCopy(My.Application.Info.DirectoryPath & "\database.mcr", SaveFileDialog1.FileName)
            SaveFileDialog1.FileName = ""
        End If

        ApExcel.Application.ActiveWorkbook.Save
        ApExcel.Application.ActiveWorkbook.Saved = True

        total = libro.Sheets(1).Range("a1").CurrentRegion.Rows.Count
        total = total - 1

    End Sub

    Private Sub cmbhair_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbhair.SelectedIndexChanged
        'If cmbhair.SelectedIndex <> 0 Then


        '    FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        'OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        'FileClose(2)

        'ident = cmbhaircolor.Text


        'FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        'OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"

        'colorcabellopic()
        ''MsgBox(OpenFileDialog2.FileName)


        'picapariencia.ImageLocation = OpenFileDialog2.FileName

        'FileClose(2)
        'End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmbposition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbposition.SelectedIndexChanged

    End Sub

    Private Sub cmbhaircolor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbhaircolor.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        ' picapariencia.Image = ImageList1.Images("A.png")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picapariencia.Click

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileClose(2)

        ident = cmbhaircolor.Text


        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"

        colorcabellopic()
        'MsgBox(OpenFileDialog2.FileName)


        picapariencia.ImageLocation = OpenFileDialog2.FileName

        FileClose(2)
    End Sub

    Private Sub cmbhaircolor_Click(sender As Object, e As EventArgs) Handles cmbhaircolor.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If cmbhair.SelectedIndex > 0 Then

            cmbhair.SelectedIndex = cmbhair.SelectedIndex - 1
            indexcmbhair = cmbhair.SelectedIndex

        End If

        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileClose(2)

        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"
        FileClose(3)


        ident = cmbhaircolor.Text




        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"

        colorcabellopic()
        'MsgBox(OpenFileDialog2.FileName)


        picapariencia.ImageLocation = OpenFileDialog2.FileName

        FileClose(2)


        ident = cmbskincolor.Text
        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbskincolor.Text

        skincolourpic()
        skincolourpic2()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)


        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbhaircolorface.Text

        hairfacecolourpic()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        If cmbhair.SelectedIndex < 31 Then

            cmbhair.SelectedIndex = cmbhair.SelectedIndex + 1
            indexcmbhair = cmbhair.SelectedIndex

        End If

        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileClose(2)

        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"
        FileClose(3)


        ident = cmbhaircolor.Text




        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"

        colorcabellopic()
        'MsgBox(OpenFileDialog2.FileName)


        picapariencia.ImageLocation = OpenFileDialog2.FileName

        FileClose(2)


        ident = cmbskincolor.Text
        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbskincolor.Text

        skincolourpic()
        skincolourpic2()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)


        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbhaircolorface.Text

        hairfacecolourpic()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub cmbhair_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbhair.MouseClick


    End Sub

    Private Sub picapariencia_LoadCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles picapariencia.LoadCompleted




    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If cmbhaircolor.SelectedIndex < 7 Then

            cmbhaircolor.SelectedIndex = cmbhaircolor.SelectedIndex + 1
            indexcmbhaircolor = cmbhaircolor.SelectedIndex

        End If

        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileClose(2)

        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"
        FileClose(3)


        ident = cmbhaircolor.Text




        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"

        colorcabellopic()
        'MsgBox(OpenFileDialog2.FileName)


        picapariencia.ImageLocation = OpenFileDialog2.FileName

        FileClose(2)


        ident = cmbskincolor.Text
        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbskincolor.Text

        skincolourpic()
        skincolourpic2()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)


        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbhaircolorface.Text

        hairfacecolourpic()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If cmbhaircolor.SelectedIndex > 0 Then

            cmbhaircolor.SelectedIndex = cmbhaircolor.SelectedIndex - 1
            indexcmbhaircolor = cmbhaircolor.SelectedIndex

        End If

        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileClose(2)

        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"
        FileClose(3)


        ident = cmbhaircolor.Text




        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"

        colorcabellopic()
        'MsgBox(OpenFileDialog2.FileName)


        picapariencia.ImageLocation = OpenFileDialog2.FileName

        FileClose(2)


        ident = cmbskincolor.Text
        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbskincolor.Text

        skincolourpic()
        skincolourpic2()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)


        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbhaircolorface.Text

        hairfacecolourpic()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)
    End Sub

    Private Sub txtplayername_TextChanged(sender As Object, e As EventArgs) Handles txtplayername.TextChanged
        lblname.Text = txtplayername.TextLength
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If cmbskincolor.SelectedIndex < 3 Then

            cmbskincolor.SelectedIndex = cmbskincolor.SelectedIndex + 1
            indexcmbskikcolour = cmbskincolor.SelectedIndex

        End If

        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileClose(2)

        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"
        FileClose(3)


        ident = cmbhaircolor.Text




        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"

        colorcabellopic()
        'MsgBox(OpenFileDialog2.FileName)


        picapariencia.ImageLocation = OpenFileDialog2.FileName

        FileClose(2)


        ident = cmbskincolor.Text
        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbskincolor.Text

        skincolourpic()
        skincolourpic2()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)


        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbhaircolorface.Text

        hairfacecolourpic()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If cmbskincolor.SelectedIndex > 0 Then

            cmbskincolor.SelectedIndex = cmbskincolor.SelectedIndex - 1
            indexcmbskikcolour = cmbskincolor.SelectedIndex

        End If

        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileClose(2)

        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"
        FileClose(3)


        ident = cmbhaircolor.Text




        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"

        colorcabellopic()
        'MsgBox(OpenFileDialog2.FileName)


        picapariencia.ImageLocation = OpenFileDialog2.FileName

        FileClose(2)


        ident = cmbskincolor.Text
        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbskincolor.Text

        skincolourpic()
        skincolourpic2()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)


        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbhaircolorface.Text

        hairfacecolourpic()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        If cmbhairface.SelectedIndex > 0 Then

            cmbhairface.SelectedIndex = cmbhairface.SelectedIndex - 1
            indexcmbhairface = cmbhairface.SelectedIndex

        End If
        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileClose(2)

        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"
        FileClose(3)


        ident = cmbhaircolor.Text




        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"

        colorcabellopic()
        'MsgBox(OpenFileDialog2.FileName)


        picapariencia.ImageLocation = OpenFileDialog2.FileName

        FileClose(2)


        ident = cmbskincolor.Text
        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbskincolor.Text

        skincolourpic()
        skincolourpic2()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)


        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbhaircolorface.Text

        hairfacecolourpic()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If cmbhaircolorface.SelectedIndex < 6 Then

            cmbhaircolorface.SelectedIndex = cmbhaircolorface.SelectedIndex + 1
            indexcmbhaircolorface = cmbhaircolorface.SelectedIndex

        End If

        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileClose(2)

        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"
        FileClose(3)


        ident = cmbhaircolor.Text




        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"

        colorcabellopic()
        'MsgBox(OpenFileDialog2.FileName)


        picapariencia.ImageLocation = OpenFileDialog2.FileName

        FileClose(2)


        ident = cmbskincolor.Text
        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbskincolor.Text

        skincolourpic()
        skincolourpic2()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)


        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbhaircolorface.Text

        hairfacecolourpic()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)
    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If cmbhairface.SelectedIndex < 6 Then

            cmbhairface.SelectedIndex = cmbhairface.SelectedIndex + 1
            indexcmbhairface = cmbhairface.SelectedIndex

        End If

        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileClose(2)

        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"
        FileClose(3)


        ident = cmbhaircolor.Text




        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"

        colorcabellopic()
        'MsgBox(OpenFileDialog2.FileName)


        picapariencia.ImageLocation = OpenFileDialog2.FileName

        FileClose(2)


        ident = cmbskincolor.Text
        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbskincolor.Text

        skincolourpic()
        skincolourpic2()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)


        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbhaircolorface.Text

        hairfacecolourpic()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)
    End Sub

    Dim indexcmbhaircolorface As Integer

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If cmbhaircolorface.SelectedIndex > 0 Then

            cmbhaircolorface.SelectedIndex = cmbhaircolorface.SelectedIndex - 1
            indexcmbhaircolorface = cmbhaircolorface.SelectedIndex

        End If
        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileClose(2)

        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"
        FileClose(3)


        ident = cmbhaircolor.Text




        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"

        colorcabellopic()
        'MsgBox(OpenFileDialog2.FileName)


        picapariencia.ImageLocation = OpenFileDialog2.FileName

        FileClose(2)


        ident = cmbskincolor.Text
        FileOpen(2, OpenFileDialog2.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog2.FileName = My.Application.Info.DirectoryPath & "\pelo" & "\pelo_" & cmbhair.SelectedIndex & ".bmp"
        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbskincolor.Text

        skincolourpic()
        skincolourpic2()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)


        FileOpen(3, OpenFileDialog3.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        OpenFileDialog3.FileName = My.Application.Info.DirectoryPath & "\barba" & "\barba_" & cmbhairface.SelectedIndex & ".bmp"

        ident = cmbhaircolorface.Text

        hairfacecolourpic()


        picapariencia.ImageLocation = OpenFileDialog2.FileName
        picbarba.ImageLocation = OpenFileDialog3.FileName

        FileClose(2)
        FileClose(3)
    End Sub

    Private Sub cmboffense_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboffense.SelectedIndexChanged

    End Sub

    Private Sub btnplayer1_Click_1(sender As Object, e As EventArgs) Handles btnplayer1.Click

        idxls = 2
        xls()




        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)


        btnplayer1.Text = "Done"
        ListBoxMcR.Items.RemoveAt(0)
        ListBoxMcR.Items.Insert(0, txtplayername.Text)
        PLAYER1_FORMATION = txtplayername.Text


        cmbnum1.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 22788
        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = 22790
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1



        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number




        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub
    Public Sub xls()


        libro.Sheets(1).cells(idxls + total, 1) = txtplayername.Text
        libro.Sheets(1).cells(idxls + total, 2) = txtnacionalidad.Text
        libro.Sheets(1).cells(idxls + total, 3) = txtclub.Text
        libro.Sheets(1).cells(idxls + total, 4) = cmbposition.Text
        libro.Sheets(1).cells(idxls + total, 5) = cmbskincolor.Text
        libro.Sheets(1).cells(idxls + total, 6) = cmbhair.Text
        libro.Sheets(1).cells(idxls + total, 7) = cmbhaircolor.Text
        libro.Sheets(1).cells(idxls + total, 8) = cmbhairface.Text
        libro.Sheets(1).cells(idxls + total, 9) = cmbhaircolorface.Text
        libro.Sheets(1).cells(idxls + total, 10) = cmbage.Text
        libro.Sheets(1).cells(idxls + total, 11) = cmbheigth.Text
        libro.Sheets(1).cells(idxls + total, 12) = cmbbody.Text
        libro.Sheets(1).cells(idxls + total, 13) = cmbboots.Text
        libro.Sheets(1).cells(idxls + total, 14) = cmbfood.Text
        libro.Sheets(1).cells(idxls + total, 15) = cmbfeedoutside.Text
        libro.Sheets(1).cells(idxls + total, 16) = cmboffense.Text
        libro.Sheets(1).cells(idxls + total, 17) = cmbdeffense.Text
        libro.Sheets(1).cells(idxls + total, 18) = cmbbodybalance.Text
        libro.Sheets(1).cells(idxls + total, 19) = cmbstamina.Text
        libro.Sheets(1).cells(idxls + total, 20) = cmbspeed.Text
        libro.Sheets(1).cells(idxls + total, 21) = cmbaceleration.Text
        libro.Sheets(1).cells(idxls + total, 22) = cmbpass.Text
        libro.Sheets(1).cells(idxls + total, 23) = cmbshotpower.Text
        libro.Sheets(1).cells(idxls + total, 24) = cmbshotacc.Text
        libro.Sheets(1).cells(idxls + total, 25) = cmbjump.Text
        libro.Sheets(1).cells(idxls + total, 26) = cmbhead.Text
        libro.Sheets(1).cells(idxls + total, 27) = cmbtechnique.Text
        libro.Sheets(1).cells(idxls + total, 28) = cmbdribble.Text
        libro.Sheets(1).cells(idxls + total, 29) = cmbcurve.Text
        libro.Sheets(1).cells(idxls + total, 30) = cmbaggression.Text
        libro.Sheets(1).cells(idxls + total, 31) = cmbresponse.Text
        libro.Sheets(1).cells(idxls + total, 32) = nclub
        libro.Sheets(1).cells(idxls + total, 33) = txtfifaname.Text
        libro.Sheets(1).cells(idxls + total, 34) = txtfechanacimiento.Text
        libro.Sheets(1).cells(idxls + total, 35) = txt_nat_team.Text
        libro.Sheets(1).cells(idxls + total, 36) = nnational
        libro.Sheets(1).cells(idxls + total, 37) = fotosofifa
    End Sub
    Private Sub btnplayer2_Click(sender As Object, e As EventArgs) Handles btnplayer2.Click
        idxls = 3
        xls()


        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)


        btnplayer2.Text = "Done"
        ListBoxMcR.Items.RemoveAt(1)
        ListBoxMcR.Items.Insert(1, txtplayername.Text)
        PLAYER2_FORMATION = txtplayername.Text
        cmbnum2.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 22820
        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number



        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer3_Click(sender As Object, e As EventArgs) Handles btnplayer3.Click
        idxls = 4
        xls()


        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer3.Text = "Done"
        ListBoxMcR.Items.RemoveAt(2)
        ListBoxMcR.Items.Insert(2, txtplayername.Text)
        formformation.lblPic2.Text = txtplayername.Text
        PLAYER3_FORMATION = txtplayername.Text
        cmbnum3.Text = cmbclubnumber.Text



        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 22852

        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number




        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer4_Click(sender As Object, e As EventArgs) Handles btnplayer4.Click
        idxls = 5
        xls()

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer4.Text = "Done"
        ListBoxMcR.Items.RemoveAt(3)
        ListBoxMcR.Items.Insert(3, txtplayername.Text)
        PLAYER4_FORMATION = txtplayername.Text
        cmbnum4.Text = cmbclubnumber.Text



        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 22884


        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number




        'MsgBox(aa)
        'caracteristicas()
        FileClose()

    End Sub

    Private Sub btnplayer5_Click(sender As Object, e As EventArgs) Handles btnplayer5.Click
        idxls = 6
        xls()

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer5.Text = "Done"
        ListBoxMcR.Items.RemoveAt(4)
        ListBoxMcR.Items.Insert(4, txtplayername.Text)
        PLAYER5_FORMATION = txtplayername.Text
        cmbnum5.Text = cmbclubnumber.Text




        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 22916



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number




        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer6_Click(sender As Object, e As EventArgs) Handles btnplayer6.Click

        idxls = 7
        xls()

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer6.Text = "Done"
        ListBoxMcR.Items.RemoveAt(5)
        ListBoxMcR.Items.Insert(5, txtplayername.Text)
        PLAYER6_FORMATION = txtplayername.Text
        cmbnum6.Text = cmbclubnumber.Text


        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 22948



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number




        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer7_Click(sender As Object, e As EventArgs) Handles btnplayer7.Click

        idxls = 8
        xls()

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer7.Text = "Done"
        ListBoxMcR.Items.RemoveAt(6)
        ListBoxMcR.Items.Insert(6, txtplayername.Text)
        PLAYER7_FORMATION = txtplayername.Text
        cmbnum7.Text = cmbclubnumber.Text


        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 22980



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number




        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer8_Click(sender As Object, e As EventArgs) Handles btnplayer8.Click
        idxls = 9
        xls()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer8.Text = "Done"
        ListBoxMcR.Items.RemoveAt(7)
        ListBoxMcR.Items.Insert(7, txtplayername.Text)
        PLAYER8_FORMATION = txtplayername.Text
        cmbnum8.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23012



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number



        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer9_Click(sender As Object, e As EventArgs) Handles btnplayer9.Click
        idxls = 10
        xls()

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer9.Text = "Done"
        ListBoxMcR.Items.RemoveAt(8)
        ListBoxMcR.Items.Insert(8, txtplayername.Text)
        PLAYER9_FORMATION = txtplayername.Text
        cmbnum9.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23044



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number


        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbclubnumber.FindString(cmbclubnumber.Text)
        cmbclubnumber.SelectedIndex = indexclubnumer
        idclubnumber.SelectedIndex = indexclubnumer

        'Dim indexcredits As Integer
        'indexcredits = cmbcredits.FindString(cmbcredits.Text)
        'cmbcredits.SelectedIndex = indexcredits
        'idcredits.SelectedIndex = indexcredits

        'Dim indexnationnumber As Integer
        'indexnationnumber = cmbnationnumber.FindString(cmbnationnumber.Text)
        'cmbnationnumber.SelectedIndex = indexnationnumber
        'idnationnumber.SelectedIndex = indexnationnumber


        a = Convert.ToInt32(idclubnumber.Text)
        'b = Convert.ToInt32(idcredits.Text)
        algoritmo3()



        guardar()

        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer10_Click(sender As Object, e As EventArgs) Handles btnplayer10.Click
        idxls = 11
        xls()


        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer10.Text = "Done"
        ListBoxMcR.Items.RemoveAt(9)
        ListBoxMcR.Items.Insert(9, txtplayername.Text)
        PLAYER10_FORMATION = txtplayername.Text
        cmbnum10.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23076



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number


        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbclubnumber.FindString(cmbclubnumber.Text)
        cmbclubnumber.SelectedIndex = indexclubnumer
        idclubnumber.SelectedIndex = indexclubnumer

        'Dim indexcredits As Integer
        'indexcredits = cmbcredits.FindString(cmbcredits.Text)
        'cmbcredits.SelectedIndex = indexcredits
        'idcredits.SelectedIndex = indexcredits

        'Dim indexnationnumber As Integer
        'indexnationnumber = cmbnationnumber.FindString(cmbnationnumber.Text)
        'cmbnationnumber.SelectedIndex = indexnationnumber
        'idnationnumber.SelectedIndex = indexnationnumber


        a = Convert.ToInt32(idclubnumber.Text)
        'b = Convert.ToInt32(idcredits.Text)
        algoritmo3()



        guardar()

        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer11_Click(sender As Object, e As EventArgs) Handles btnplayer11.Click

        idxls = 12
        xls()

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer11.Text = "Done"
        ListBoxMcR.Items.RemoveAt(10)
        ListBoxMcR.Items.Insert(10, txtplayername.Text)
        PLAYER11_FORMATION = txtplayername.Text
        cmbnum11.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23108



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number


        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbclubnumber.FindString(cmbclubnumber.Text)
        cmbclubnumber.SelectedIndex = indexclubnumer
        idclubnumber.SelectedIndex = indexclubnumer

        'Dim indexcredits As Integer
        'indexcredits = cmbcredits.FindString(cmbcredits.Text)
        'cmbcredits.SelectedIndex = indexcredits
        'idcredits.SelectedIndex = indexcredits

        'Dim indexnationnumber As Integer
        'indexnationnumber = cmbnationnumber.FindString(cmbnationnumber.Text)
        'cmbnationnumber.SelectedIndex = indexnationnumber
        'idnationnumber.SelectedIndex = indexnationnumber


        a = Convert.ToInt32(idclubnumber.Text)
        'b = Convert.ToInt32(idcredits.Text)
        algoritmo3()



        guardar()

        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer12_Click(sender As Object, e As EventArgs) Handles btnplayer12.Click
        idxls = 13
        xls()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer12.Text = "Done"
        ListBoxMcR.Items.RemoveAt(11)
        ListBoxMcR.Items.Insert(11, txtplayername.Text)
        cmbnum12.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23140



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number


        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbclubnumber.FindString(cmbclubnumber.Text)
        cmbclubnumber.SelectedIndex = indexclubnumer
        idclubnumber.SelectedIndex = indexclubnumer

        'Dim indexcredits As Integer
        'indexcredits = cmbcredits.FindString(cmbcredits.Text)
        'cmbcredits.SelectedIndex = indexcredits
        'idcredits.SelectedIndex = indexcredits

        'Dim indexnationnumber As Integer
        'indexnationnumber = cmbnationnumber.FindString(cmbnationnumber.Text)
        'cmbnationnumber.SelectedIndex = indexnationnumber
        'idnationnumber.SelectedIndex = indexnationnumber


        a = Convert.ToInt32(idclubnumber.Text)
        'b = Convert.ToInt32(idcredits.Text)
        algoritmo3()



        guardar()

        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer13_Click(sender As Object, e As EventArgs) Handles btnplayer13.Click
        idxls = 14
        xls()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer13.Text = "Done"
        ListBoxMcR.Items.RemoveAt(12)
        ListBoxMcR.Items.Insert(12, txtplayername.Text)
        cmbnum13.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23172



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number


        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbclubnumber.FindString(cmbclubnumber.Text)
        cmbclubnumber.SelectedIndex = indexclubnumer
        idclubnumber.SelectedIndex = indexclubnumer

        'Dim indexcredits As Integer
        'indexcredits = cmbcredits.FindString(cmbcredits.Text)
        'cmbcredits.SelectedIndex = indexcredits
        'idcredits.SelectedIndex = indexcredits

        'Dim indexnationnumber As Integer
        'indexnationnumber = cmbnationnumber.FindString(cmbnationnumber.Text)
        'cmbnationnumber.SelectedIndex = indexnationnumber
        'idnationnumber.SelectedIndex = indexnationnumber


        a = Convert.ToInt32(idclubnumber.Text)
        'b = Convert.ToInt32(idcredits.Text)
        algoritmo3()



        guardar()

        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer14_Click(sender As Object, e As EventArgs) Handles btnplayer14.Click
        idxls = 15
        xls()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer14.Text = "Done"
        ListBoxMcR.Items.RemoveAt(13)
        ListBoxMcR.Items.Insert(13, txtplayername.Text)
        cmbnum14.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23204



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number


        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbclubnumber.FindString(cmbclubnumber.Text)
        cmbclubnumber.SelectedIndex = indexclubnumer
        idclubnumber.SelectedIndex = indexclubnumer

        'Dim indexcredits As Integer
        'indexcredits = cmbcredits.FindString(cmbcredits.Text)
        'cmbcredits.SelectedIndex = indexcredits
        'idcredits.SelectedIndex = indexcredits

        'Dim indexnationnumber As Integer
        'indexnationnumber = cmbnationnumber.FindString(cmbnationnumber.Text)
        'cmbnationnumber.SelectedIndex = indexnationnumber
        'idnationnumber.SelectedIndex = indexnationnumber


        a = Convert.ToInt32(idclubnumber.Text)
        'b = Convert.ToInt32(idcredits.Text)
        algoritmo3()



        guardar()

        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer15_Click(sender As Object, e As EventArgs) Handles btnplayer15.Click
        idxls = 16
        xls()

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer15.Text = "Done"
        ListBoxMcR.Items.RemoveAt(14)
        ListBoxMcR.Items.Insert(14, txtplayername.Text)
        cmbnum15.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23236



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number


        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbclubnumber.FindString(cmbclubnumber.Text)
        cmbclubnumber.SelectedIndex = indexclubnumer
        idclubnumber.SelectedIndex = indexclubnumer

        'Dim indexcredits As Integer
        'indexcredits = cmbcredits.FindString(cmbcredits.Text)
        'cmbcredits.SelectedIndex = indexcredits
        'idcredits.SelectedIndex = indexcredits

        'Dim indexnationnumber As Integer
        'indexnationnumber = cmbnationnumber.FindString(cmbnationnumber.Text)
        'cmbnationnumber.SelectedIndex = indexnationnumber
        'idnationnumber.SelectedIndex = indexnationnumber


        a = Convert.ToInt32(idclubnumber.Text)
        'b = Convert.ToInt32(idcredits.Text)
        algoritmo3()



        guardar()

        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer16_Click(sender As Object, e As EventArgs) Handles btnplayer16.Click
        idxls = 17
        xls()

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer16.Text = "Done"
        ListBoxMcR.Items.RemoveAt(15)
        ListBoxMcR.Items.Insert(15, txtplayername.Text)
        cmbnum16.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23268



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number


        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbclubnumber.FindString(cmbclubnumber.Text)
        cmbclubnumber.SelectedIndex = indexclubnumer
        idclubnumber.SelectedIndex = indexclubnumer

        'Dim indexcredits As Integer
        'indexcredits = cmbcredits.FindString(cmbcredits.Text)
        'cmbcredits.SelectedIndex = indexcredits
        'idcredits.SelectedIndex = indexcredits

        'Dim indexnationnumber As Integer
        'indexnationnumber = cmbnationnumber.FindString(cmbnationnumber.Text)
        'cmbnationnumber.SelectedIndex = indexnationnumber
        'idnationnumber.SelectedIndex = indexnationnumber


        a = Convert.ToInt32(idclubnumber.Text)
        'b = Convert.ToInt32(idcredits.Text)
        algoritmo3()



        guardar()

        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer17_Click(sender As Object, e As EventArgs) Handles btnplayer17.Click
        idxls = 18
        xls()

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer17.Text = "Done"
        ListBoxMcR.Items.RemoveAt(16)
        ListBoxMcR.Items.Insert(16, txtplayername.Text)
        cmbnum17.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23300



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number


        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbclubnumber.FindString(cmbclubnumber.Text)
        cmbclubnumber.SelectedIndex = indexclubnumer
        idclubnumber.SelectedIndex = indexclubnumer

        'Dim indexcredits As Integer
        'indexcredits = cmbcredits.FindString(cmbcredits.Text)
        'cmbcredits.SelectedIndex = indexcredits
        'idcredits.SelectedIndex = indexcredits

        'Dim indexnationnumber As Integer
        'indexnationnumber = cmbnationnumber.FindString(cmbnationnumber.Text)
        'cmbnationnumber.SelectedIndex = indexnationnumber
        'idnationnumber.SelectedIndex = indexnationnumber


        a = Convert.ToInt32(idclubnumber.Text)
        'b = Convert.ToInt32(idcredits.Text)
        algoritmo3()



        guardar()

        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer18_Click(sender As Object, e As EventArgs) Handles btnplayer18.Click
        idxls = 19
        xls()

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer18.Text = "Done"
        ListBoxMcR.Items.RemoveAt(17)
        ListBoxMcR.Items.Insert(17, txtplayername.Text)
        cmbnum18.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23332



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number


        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbclubnumber.FindString(cmbclubnumber.Text)
        cmbclubnumber.SelectedIndex = indexclubnumer
        idclubnumber.SelectedIndex = indexclubnumer

        'Dim indexcredits As Integer
        'indexcredits = cmbcredits.FindString(cmbcredits.Text)
        'cmbcredits.SelectedIndex = indexcredits
        'idcredits.SelectedIndex = indexcredits

        'Dim indexnationnumber As Integer
        'indexnationnumber = cmbnationnumber.FindString(cmbnationnumber.Text)
        'cmbnationnumber.SelectedIndex = indexnationnumber
        'idnationnumber.SelectedIndex = indexnationnumber


        a = Convert.ToInt32(idclubnumber.Text)
        'b = Convert.ToInt32(idcredits.Text)
        algoritmo3()



        guardar()

        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer19_Click(sender As Object, e As EventArgs) Handles btnplayer19.Click
        idxls = 20
        xls()

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer19.Text = "Done"
        ListBoxMcR.Items.RemoveAt(18)
        ListBoxMcR.Items.Insert(18, txtplayername.Text)
        cmbnum19.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23364



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number


        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbclubnumber.FindString(cmbclubnumber.Text)
        cmbclubnumber.SelectedIndex = indexclubnumer
        idclubnumber.SelectedIndex = indexclubnumer

        'Dim indexcredits As Integer
        'indexcredits = cmbcredits.FindString(cmbcredits.Text)
        'cmbcredits.SelectedIndex = indexcredits
        'idcredits.SelectedIndex = indexcredits

        'Dim indexnationnumber As Integer
        'indexnationnumber = cmbnationnumber.FindString(cmbnationnumber.Text)
        'cmbnationnumber.SelectedIndex = indexnationnumber
        'idnationnumber.SelectedIndex = indexnationnumber


        a = Convert.ToInt32(idclubnumber.Text)
        'b = Convert.ToInt32(idcredits.Text)
        algoritmo3()



        guardar()

        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer20_Click(sender As Object, e As EventArgs) Handles btnplayer20.Click
        idxls = 21
        xls()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer20.Text = "Done"
        ListBoxMcR.Items.RemoveAt(19)
        ListBoxMcR.Items.Insert(19, txtplayername.Text)
        cmbnum20.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23396



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number


        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbclubnumber.FindString(cmbclubnumber.Text)
        cmbclubnumber.SelectedIndex = indexclubnumer
        idclubnumber.SelectedIndex = indexclubnumer

        'Dim indexcredits As Integer
        'indexcredits = cmbcredits.FindString(cmbcredits.Text)
        'cmbcredits.SelectedIndex = indexcredits
        'idcredits.SelectedIndex = indexcredits

        'Dim indexnationnumber As Integer
        'indexnationnumber = cmbnationnumber.FindString(cmbnationnumber.Text)
        'cmbnationnumber.SelectedIndex = indexnationnumber
        'idnationnumber.SelectedIndex = indexnationnumber


        a = Convert.ToInt32(idclubnumber.Text)
        'b = Convert.ToInt32(idcredits.Text)
        algoritmo3()



        guardar()

        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer21_Click(sender As Object, e As EventArgs) Handles btnplayer21.Click
        idxls = 22
        xls()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer21.Text = "Done"
        ListBoxMcR.Items.RemoveAt(20)
        ListBoxMcR.Items.Insert(20, txtplayername.Text)
        cmbnum21.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23428



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number


        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbclubnumber.FindString(cmbclubnumber.Text)
        cmbclubnumber.SelectedIndex = indexclubnumer
        idclubnumber.SelectedIndex = indexclubnumer

        'Dim indexcredits As Integer
        'indexcredits = cmbcredits.FindString(cmbcredits.Text)
        'cmbcredits.SelectedIndex = indexcredits
        'idcredits.SelectedIndex = indexcredits

        'Dim indexnationnumber As Integer
        'indexnationnumber = cmbnationnumber.FindString(cmbnationnumber.Text)
        'cmbnationnumber.SelectedIndex = indexnationnumber
        'idnationnumber.SelectedIndex = indexnationnumber


        a = Convert.ToInt32(idclubnumber.Text)
        'b = Convert.ToInt32(idcredits.Text)
        algoritmo3()



        guardar()

        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer22_Click(sender As Object, e As EventArgs) Handles btnplayer22.Click
        idxls = 23
        xls()

        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer22.Text = "Done"
        ListBoxMcR.Items.RemoveAt(21)
        ListBoxMcR.Items.Insert(21, txtplayername.Text)
        cmbnum22.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23460



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number


        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbclubnumber.FindString(cmbclubnumber.Text)
        cmbclubnumber.SelectedIndex = indexclubnumer
        idclubnumber.SelectedIndex = indexclubnumer

        'Dim indexcredits As Integer
        'indexcredits = cmbcredits.FindString(cmbcredits.Text)
        'cmbcredits.SelectedIndex = indexcredits
        'idcredits.SelectedIndex = indexcredits

        'Dim indexnationnumber As Integer
        'indexnationnumber = cmbnationnumber.FindString(cmbnationnumber.Text)
        'cmbnationnumber.SelectedIndex = indexnationnumber
        'idnationnumber.SelectedIndex = indexnationnumber


        a = Convert.ToInt32(idclubnumber.Text)
        'b = Convert.ToInt32(idcredits.Text)
        algoritmo3()



        guardar()

        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub btnplayer23_Click(sender As Object, e As EventArgs) Handles btnplayer23.Click

        idxls = 24
        xls()
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        btnplayer23.Text = "Done"
        ListBoxMcR.Items.RemoveAt(22)
        ListBoxMcR.Items.Insert(22, txtplayername.Text)
        cmbnum23.Text = cmbclubnumber.Text

        'save to hair stile..........................................
        Dim primerbite As String
        Dim indexhair As Integer
        indexhair = cmbhair.FindString(cmbhair.Text)
        cmbhair.SelectedIndex = indexhair
        idhair.SelectedIndex = indexhair

        'save to position...............................................
        Dim indexposition As Integer
        indexposition = cmbposition.FindString(cmbposition.Text)
        cmbposition.SelectedIndex = indexposition
        idposition.SelectedIndex = indexposition

        primerbite = idhair.Text & idposition.Text

        offset1 = 23492



        aa = (Convert.ToByte(primerbite, 16))
        guardar()

        '--------------------------------------------------------------------
        'save to hairface.....................................................
        Dim segundobyte As String
        Dim indexhairface As Integer
        indexhairface = cmbhairface.FindString(cmbhairface.Text)
        cmbhairface.SelectedIndex = indexhairface
        idhairface.SelectedIndex = indexhairface

        Dim indexhaircolor As Integer
        indexhaircolor = cmbhaircolor.FindString(cmbhaircolor.Text)
        cmbhaircolor.SelectedIndex = indexhaircolor

        cmbhaircolor.SelectedIndex = indexhaircolor
        idhair2.SelectedIndex = indexhaircolor
        idhaircolor.SelectedIndex = indexhaircolor


        offset1 = offset1 + 1
        If indexhair >= 16 Then
            segundobyte = idhairface.Text & idhair2.Text

        Else
            segundobyte = idhairface.Text & idhaircolor.Text
        End If

        aa = (Convert.ToByte(segundobyte, 16))

        guardar()

        '-----------------------------------------------------------------------------
        'heigth
        offset1 = offset1 + 1
        Dim tercerbite As String
        Dim indexheigth As Integer
        indexheigth = cmbheigth.FindString(cmbheigth.Text)
        cmbheigth.SelectedIndex = indexheigth
        idheigth.SelectedIndex = indexheigth
        idheigth2.SelectedIndex = indexheigth

        '--------------------------------------------------------------------------------
        'hair color face


        Dim indexhaircolorface As Integer
        indexhaircolorface = cmbhaircolorface.FindString(cmbhaircolorface.Text)
        cmbhaircolorface.SelectedIndex = indexhaircolorface
        idhaircolorface.SelectedIndex = indexhaircolorface

        tercerbite = idheigth.Text & idhaircolorface.Text


        aa = (Convert.ToByte(tercerbite, 16))
        guardar()


        '---------------------------------------------------------------------------
        'feet outside
        offset1 = offset1 + 1
        Dim cuartobite As String
        Dim indexfeetoutside As Integer
        indexfeetoutside = cmbfeedoutside.FindString(cmbfeedoutside.Text)
        cmbfeedoutside.SelectedIndex = indexfeetoutside
        idfeedoutside.SelectedIndex = indexfeetoutside

        cuartobite = idfeedoutside.Text & idheigth2.Text


        aa = (Convert.ToByte(cuartobite, 16))

        guardar()



        '---------------------------------------------------------------------------
        'save to age - skincolor, body
        offset1 = offset1 + 1


        Dim indexage As Integer
        indexage = cmbage.FindString(cmbage.Text)
        cmbage.SelectedIndex = indexage
        idage.SelectedIndex = indexage

        Dim indexskincolor As Integer
        indexskincolor = cmbskincolor.FindString(cmbskincolor.Text)
        cmbskincolor.SelectedIndex = indexskincolor
        idskincolor.SelectedIndex = indexskincolor

        Dim indexbody As Integer
        indexbody = cmbbody.FindString(cmbbody.Text)
        cmbbody.SelectedIndex = indexbody
        idbody.SelectedIndex = indexbody

        'suma de tres caractersiticas en un solo byte
        a = Convert.ToInt32(idskincolor.Text)

        b = Convert.ToInt32(idbody.Text)

        c = Convert.ToInt32(idage.Text)


        algoritmo1()

        guardar()

        '______________________________________________________________________________________
        ' response - body balance

        offset1 = offset1 + 1



        Dim indexresponse As Integer
        indexresponse = cmbresponse.FindString(cmbresponse.Text)
        cmbresponse.SelectedIndex = indexresponse
        idresponse.SelectedIndex = indexresponse

        Dim indexbodybalance As Integer
        indexbodybalance = cmbbodybalance.FindString(cmbbodybalance.Text)
        cmbbodybalance.SelectedIndex = indexbodybalance
        idbodybalance.SelectedIndex = indexbodybalance


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idbodybalance.Text)
        b = Convert.ToInt32(idresponse.Text)



        algoritmo2()


        guardar()


        '______________________________________________________________________________________
        ' stamina dribble -speed

        offset1 = offset1 + 1



        Dim indexstamina As Integer
        indexstamina = cmbstamina.FindString(cmbstamina.Text)
        cmbstamina.SelectedIndex = indexstamina
        idstamina.SelectedIndex = indexstamina

        Dim indexdribble As Integer
        indexdribble = cmbdribble.FindString(cmbdribble.Text)
        cmbdribble.SelectedIndex = indexdribble
        iddribble.SelectedIndex = indexdribble

        Dim indexspeed As Integer
        indexspeed = cmbspeed.FindString(cmbspeed.Text)
        cmbspeed.SelectedIndex = indexspeed
        idspeed.SelectedIndex = indexspeed

        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(iddribble.Text)
        b = Convert.ToInt32(idstamina.Text)
        c = Convert.ToInt32(idspeed.Text)


        algoritmo1()

        guardar()


        '???------------------------------------------------------------------------------
        'offensa - aceleration

        offset1 = offset1 + 1

        Dim indexoffense As Integer
        indexoffense = cmboffense.FindString(cmboffense.Text)
        cmboffense.SelectedIndex = indexoffense
        idoffense.SelectedIndex = indexoffense

        Dim indexaceleration As Integer
        indexaceleration = cmbaceleration.FindString(cmbaceleration.Text)
        cmbaceleration.SelectedIndex = indexaceleration
        idaceleration.SelectedIndex = indexaceleration


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idaceleration.Text)
        b = Convert.ToInt32(idoffense.Text)


        algoritmo2()

        guardar()

        '-----------------------------------------------------------------
        ' deffense - shot power - shot acc

        offset1 = offset1 + 1



        Dim indexdeffense As Integer
        indexdeffense = cmbdeffense.FindString(cmbdeffense.Text)
        cmbdeffense.SelectedIndex = indexdeffense
        iddeffense.SelectedIndex = indexdeffense

        Dim indexshotpower As Integer
        indexshotpower = cmbshotpower.FindString(cmbshotpower.Text)
        cmbshotpower.SelectedIndex = indexshotpower
        idshotpower.SelectedIndex = indexshotpower

        Dim indexshotacc As Integer
        indexshotacc = cmbshotacc.FindString(cmbshotacc.Text)
        cmbshotacc.SelectedIndex = indexshotacc
        idshotacc.SelectedIndex = indexshotacc


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idshotacc.Text)
        b = Convert.ToInt32(idshotpower.Text)
        c = Convert.ToInt32(iddeffense.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' pass - technique - head

        offset1 = offset1 + 1



        Dim indexpass As Integer
        indexpass = cmbpass.FindString(cmbpass.Text)
        cmbpass.SelectedIndex = indexpass
        idpass.SelectedIndex = indexpass

        Dim indextechnique As Integer
        indextechnique = cmbtechnique.FindString(cmbtechnique.Text)
        cmbtechnique.SelectedIndex = indextechnique
        idtechnique.SelectedIndex = indextechnique

        Dim indexhead As Integer
        indexhead = cmbhead.FindString(cmbhead.Text)
        cmbhead.SelectedIndex = indexhead
        idhead.SelectedIndex = indexhead


        'suma de dos caractersiticas en un solo byte

        a = Convert.ToInt32(idhead.Text)
        b = Convert.ToInt32(idtechnique.Text)
        c = Convert.ToInt32(idpass.Text)
        algoritmo1()


        guardar()

        '-----------------------------------------------------------------
        ' jump - curve 

        offset1 = offset1 + 1



        Dim indexjump As Integer
        indexjump = cmbjump.FindString(cmbjump.Text)
        cmbjump.SelectedIndex = indexjump
        idjump.SelectedIndex = indexjump

        Dim indexcurve As Integer
        indexcurve = cmbcurve.FindString(cmbcurve.Text)
        cmbcurve.SelectedIndex = indexcurve
        idcurve.SelectedIndex = indexcurve





        a = Convert.ToInt32(idjump.Text)
        b = Convert.ToInt32(idcurve.Text)
        algoritmo2()



        guardar()


        '-----------------------------------------------------------------
        ' boots - food - agression

        offset1 = offset1 + 1



        Dim indexboots As Integer
        indexboots = cmbboots.FindString(cmbboots.Text)
        cmbboots.SelectedIndex = indexboots
        idboots.SelectedIndex = indexboots

        Dim indefood As Integer
        indefood = cmbfood.FindString(cmbfood.Text)
        cmbfood.SelectedIndex = indefood
        idfoot.SelectedIndex = indefood

        Dim indexaggression As Integer
        indexaggression = cmbaggression.FindString(cmbaggression.Text)
        cmbaggression.SelectedIndex = indexaggression
        idaggression.SelectedIndex = indexaggression

        a = Convert.ToInt32(idfoot.Text)
        b = Convert.ToInt32(idboots.Text)
        c = Convert.ToInt32(idaggression.Text)

        algoritmo1()


        guardar()


        '----------------------------------------------------------------
        'nombre player
        offset1 = offset1 + 1
        Dim playername As String
        playername = txtplayername.Text
        aa = playername
        guardarstr()


        '----------------------------------------------------------------
        'club number


        offset1 = 21508

        Dim indexclubnumer As Integer
        indexclubnumer = cmbclubnumber.FindString(cmbclubnumber.Text)
        cmbclubnumber.SelectedIndex = indexclubnumer
        idclubnumber.SelectedIndex = indexclubnumer

        'Dim indexcredits As Integer
        'indexcredits = cmbcredits.FindString(cmbcredits.Text)
        'cmbcredits.SelectedIndex = indexcredits
        'idcredits.SelectedIndex = indexcredits

        'Dim indexnationnumber As Integer
        'indexnationnumber = cmbnationnumber.FindString(cmbnationnumber.Text)
        'cmbnationnumber.SelectedIndex = indexnationnumber
        'idnationnumber.SelectedIndex = indexnationnumber


        a = Convert.ToInt32(idclubnumber.Text)
        'b = Convert.ToInt32(idcredits.Text)
        algoritmo3()



        guardar()

        'MsgBox(aa)
        'caracteristicas()
        FileClose()
    End Sub

    Private Sub cmbnum1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbnum1_MouseMove(sender As Object, e As MouseEventArgs)

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



    Private Sub rbtnclub_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnclub.CheckedChanged
        If rbtnclub.Checked = True Then rbtnational.Checked = False
    End Sub

    Private Sub rbtnational_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnational.CheckedChanged
        If rbtnational.Checked = True Then rbtnclub.Checked = False
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        FileOpen(1, My.Application.Info.DirectoryPath & "\export.tt2002", OpenMode.Binary, OpenAccess.ReadWrite)

        offset1 = 462
        aa = (Convert.ToByte(idposition.Text, 16))


        guardar()

    End Sub

    Private Sub btnsaveplantilla_Click_1(sender As Object, e As EventArgs) Handles btnsaveplantilla.Click


        SaveFileDialog2.ShowDialog()


        Dim rutaFichero As String
        Dim i As Integer

        rutaFichero = SaveFileDialog2.FileName
        Dim fichero As New IO.StreamWriter(rutaFichero)
        For i = 0 To ListBoxMcR.Items.Count - 1
            fichero.WriteLine(ListBoxMcR.Items(i))
        Next
        fichero.Close()

        MsgBox(rutaFichero)
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click

        Controls.Clear()
        InitializeComponent()
        con.Close()

        Form1_Load(Me, Nothing)

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






    Private Sub ListBoxMcR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMcR.SelectedIndexChanged

    End Sub

    Private Sub PicP3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBoxMcR_TextChanged(sender As Object, e As EventArgs) Handles ListBoxMcR.TextChanged

    End Sub



    Private Sub lblPlayer8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbnum1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbnum1.SelectedIndexChanged

    End Sub

    Private Sub cmbclubnumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbclubnumber.SelectedIndexChanged

    End Sub

    Private Sub cmbclubnumber_TextChanged(sender As Object, e As EventArgs) Handles cmbclubnumber.TextChanged
        If cmbclubnumber.Text = "" Then
            cmbclubnumber.Text = "32"
        End If
        If cmbclubnumber.Text = "tm" Then
            cmbclubnumber.Text = "32"
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles chkheadacc.CheckedChanged

    End Sub

    Private Sub btnup_Click(sender As Object, e As EventArgs) Handles btnup.Click
        If chkoffense.Checked = True And cmboffense.Text > 12 And cmboffense.Text < 19 Then cmboffense.Text = cmboffense.Text + 1
        If chkdeffense.Checked = True And cmbdeffense.Text > 12 And cmbdeffense.Text < 19 Then cmbdeffense.Text = cmbdeffense.Text + 1
        If chkbodybal.Checked = True And cmbbodybalance.Text > 12 And cmbbodybalance.Text < 19 Then cmbbodybalance.Text = cmbbodybalance.Text + 1
        If chkstamina.Checked = True And cmbstamina.Text > 12 And cmbstamina.Text < 19 Then cmbstamina.Text = cmbstamina.Text + 1
        If chkspeed.Checked = True And cmbspeed.Text > 12 And cmbspeed.Text < 19 Then cmbspeed.Text = cmbspeed.Text + 1
        If chkacceleration.Checked = True And cmbaceleration.Text > 12 And cmbaceleration.Text < 19 Then cmbaceleration.Text = cmbaceleration.Text + 1
        If chkpassacc.Checked = True And cmbpass.Text > 12 And cmbpass.Text < 19 Then cmbpass.Text = cmbpass.Text + 1
        If chkshotpower.Checked = True And cmbshotpower.Text > 12 And cmbshotpower.Text < 19 Then cmbshotpower.Text = cmbshotpower.Text + 1
        If chkshotacc.Checked = True And cmbshotacc.Text > 12 And cmbshotacc.Text < 19 Then cmbshotacc.Text = cmbshotacc.Text + 1
        If chkjump.Checked = True And cmbjump.Text > 12 And cmbjump.Text < 19 Then cmbjump.Text = cmbjump.Text + 1
        If chkheadacc.Checked = True And cmbhead.Text > 12 And cmbhead.Text < 19 Then cmbhead.Text = cmbhead.Text + 1
        If chktechique.Checked = True And cmbtechnique.Text > 12 And cmbtechnique.Text < 19 Then cmbtechnique.Text = cmbtechnique.Text + 1
        If chkdribble.Checked = True And cmbdribble.Text > 12 And cmbdribble.Text < 19 Then cmbdribble.Text = cmbdribble.Text + 1
        If chkcurve.Checked = True And cmbcurve.Text > 12 And cmbcurve.Text < 19 Then cmbcurve.Text = cmbcurve.Text + 1
        If chkaggression.Checked = True And cmbaggression.Text > 12 And cmbaggression.Text < 19 Then cmbaggression.Text = cmbaggression.Text + 1
        If chkresponse.Checked = True And cmbresponse.Text > 12 And cmbresponse.Text < 19 Then cmbresponse.Text = cmbresponse.Text + 1
    End Sub

    Private Sub BTNdown_Click(sender As Object, e As EventArgs) Handles BTNdown.Click
        If chkoffense.Checked = True And cmboffense.Text > 12 And cmboffense.Text < 19 Then cmboffense.Text = cmboffense.Text - 1
        If chkdeffense.Checked = True And cmbdeffense.Text > 12 And cmbdeffense.Text < 19 Then cmbdeffense.Text = cmbdeffense.Text - 1
        If chkbodybal.Checked = True And cmbbodybalance.Text > 12 And cmbbodybalance.Text < 19 Then cmbbodybalance.Text = cmbbodybalance.Text - 1
        If chkstamina.Checked = True And cmbstamina.Text > 12 And cmbstamina.Text < 19 Then cmbstamina.Text = cmbstamina.Text - 1
        If chkspeed.Checked = True And cmbspeed.Text > 12 And cmbspeed.Text < 19 Then cmbspeed.Text = cmbspeed.Text - 1
        If chkacceleration.Checked = True And cmbaceleration.Text > 12 And cmbaceleration.Text < 19 Then cmbaceleration.Text = cmbaceleration.Text - 1
        If chkpassacc.Checked = True And cmbpass.Text > 12 And cmbpass.Text < 19 Then cmbpass.Text = cmbpass.Text - 1
        If chkshotpower.Checked = True And cmbshotpower.Text > 12 And cmbshotpower.Text < 19 Then cmbshotpower.Text = cmbshotpower.Text - 1
        If chkshotacc.Checked = True And cmbshotacc.Text > 12 And cmbshotacc.Text < 19 Then cmbshotacc.Text = cmbshotacc.Text - 1
        If chkjump.Checked = True And cmbjump.Text > 12 And cmbjump.Text < 19 Then cmbjump.Text = cmbjump.Text - 1
        If chkheadacc.Checked = True And cmbhead.Text > 12 And cmbhead.Text < 19 Then cmbhead.Text = cmbhead.Text - 1
        If chktechique.Checked = True And cmbtechnique.Text > 12 And cmbtechnique.Text < 19 Then cmbtechnique.Text = cmbtechnique.Text - 1
        If chkdribble.Checked = True And cmbdribble.Text > 12 And cmbdribble.Text < 19 Then cmbdribble.Text = cmbdribble.Text - 1
        If chkcurve.Checked = True And cmbcurve.Text > 12 And cmbcurve.Text < 19 Then cmbcurve.Text = cmbcurve.Text - 1
        If chkaggression.Checked = True And cmbaggression.Text > 12 And cmbaggression.Text < 19 Then cmbaggression.Text = cmbaggression.Text - 1
        If chkresponse.Checked = True And cmbresponse.Text > 12 And cmbresponse.Text < 19 Then cmbresponse.Text = cmbresponse.Text - 1
    End Sub

    Private Sub chkall_CheckedChanged(sender As Object, e As EventArgs) Handles chkall.CheckedChanged
        If chkall.Checked = True Then
            chkoffense.Checked = True
            chkoffense.Checked = True
            chkbodybal.Checked = True
            chkstamina.Checked = True
            chkspeed.Checked = True
            chkacceleration.Checked = True
            chkpassacc.Checked = True
            chkshotpower.Checked = True
            chkshotacc.Checked = True
            chkjump.Checked = True
            chkheadacc.Checked = True
            chktechique.Checked = True
            chkdribble.Checked = True
            chkcurve.Checked = True
            chkaggression.Checked = True
            chkresponse.Checked = True
        Else
            chkoffense.Checked = False
            chkoffense.Checked = False
            chkbodybal.Checked = False
            chkstamina.Checked = False
            chkspeed.Checked = False
            chkacceleration.Checked = False
            chkpassacc.Checked = False
            chkshotpower.Checked = False
            chkshotacc.Checked = False
            chkjump.Checked = False
            chkheadacc.Checked = False
            chktechique.Checked = False
            chkdribble.Checked = False
            chkcurve.Checked = False
            chkaggression.Checked = False
            chkresponse.Checked = False



        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PicP6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnformation_Click(sender As Object, e As EventArgs) Handles btnformation.Click
        formformation.LblPic0.Text = PLAYER1_FORMATION
        formformation.LblPlayer0.Text = PLAYER1_FORMATION
        formformation.lblPic1.Text = PLAYER2_FORMATION
        formformation.lblPlayer1.Text = PLAYER2_FORMATION
        formformation.lblPic2.Text = PLAYER3_FORMATION
        formformation.lblPlayer2.Text = PLAYER3_FORMATION
        formformation.lblpic3.Text = PLAYER4_FORMATION
        formformation.lblPlayer3.Text = PLAYER4_FORMATION
        formformation.lblPic4.Text = PLAYER5_FORMATION
        formformation.lblPlayer4.Text = PLAYER5_FORMATION
        formformation.lblPic5.Text = PLAYER6_FORMATION
        formformation.lblPlayer5.Text = PLAYER6_FORMATION
        formformation.lblPic6.Text = PLAYER7_FORMATION
        formformation.lblPlayer6.Text = PLAYER7_FORMATION
        formformation.lblPic7.Text = PLAYER8_FORMATION
        formformation.lblPlayer7.Text = PLAYER8_FORMATION
        formformation.lblPic8.Text = PLAYER9_FORMATION
        formformation.lblPlayer8.Text = PLAYER9_FORMATION
        formformation.LblPic9.Text = PLAYER10_FORMATION
        formformation.lblPlayer9.Text = PLAYER10_FORMATION
        formformation.lblPic10.Text = PLAYER11_FORMATION
        formformation.lblPlayer10.Text = PLAYER11_FORMATION

        formformation.Show()
        Me.Hide()
    End Sub

    Private Sub PicP0_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        System.Diagnostics.Process.Start("https://www.paypal.com/paypalme/PwPatch")

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub
End Class

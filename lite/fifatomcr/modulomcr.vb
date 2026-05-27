Imports System.Data
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Module modulomcr
    Public offsets As Integer
    Public offsethaircolour As Integer
    Public lectorByte As New Byte
    Public segundobyte As New Byte
    Public SS As String

    Public bin1 As String
    Public ALLBYTES As String
    Public binhair As String

    Public datograbar As Byte
    Public datograbarstr As String
    Public offset1 As Integer
    Public rutaarchivo As String
    Public aa As String

    Public conexion As OleDb.OleDbConnection
    Public adaptador As New OleDb.OleDbDataAdapter
    Public registro As New DataSet

    Public posplayer As String
    Public playerposition As String
    Public COLORPOSITION As Color

    Public PLAYER1_FORMATION As String
    Public PLAYER2_FORMATION As String
    Public PLAYER3_FORMATION As String
    Public PLAYER4_FORMATION As String
    Public PLAYER5_FORMATION As String
    Public PLAYER6_FORMATION As String
    Public PLAYER7_FORMATION As String
    Public PLAYER8_FORMATION As String
    Public PLAYER9_FORMATION As String
    Public PLAYER10_FORMATION As String
    Public PLAYER11_FORMATION As String

    Public nclub As Integer
    Public nnational As Integer

    Public fotosofifa As String

    Public ApExcel = New Microsoft.Office.Interop.Excel.Application
    Public libro = ApExcel.Workbooks.Open(My.Application.Info.DirectoryPath & "\players.xlsx")
    Public idxls As Integer
    Public total As Integer


    Public Sub dbconexion()

    End Sub

    Public Sub positionjug()
        playerposition = ""
        If posplayer = "ST" Then playerposition = "CF"
        If posplayer = "LW" Then playerposition = "WG"
        If posplayer = "RW" Then playerposition = "WG"
        If posplayer = "CM" Then playerposition = "DH"
        If posplayer = "CDM" Then playerposition = "DH"
        If posplayer = "CB" Then playerposition = "CB"
        If posplayer = "CF" Then playerposition = "CF"
        If posplayer = "RB" Then playerposition = "SB"
        If posplayer = "GK" Then playerposition = "GK"
        If posplayer = "CAM" Then playerposition = "OH"
        If posplayer = "LM" Then playerposition = "SH"
        If posplayer = "RM" Then playerposition = "SH"
        If posplayer = "LB" Then playerposition = "SB"
        If posplayer = "LWB" Then playerposition = "SB"
        If posplayer = "RWB" Then playerposition = "SB"


        If playerposition = "CB" Then COLORPOSITION = Color.LightSeaGreen
        If playerposition = "SB" Then COLORPOSITION = Color.LightSeaGreen
        If playerposition = "DH" Then COLORPOSITION = Color.DarkSeaGreen
        If playerposition = "OH" Then COLORPOSITION = Color.DarkSeaGreen
        If playerposition = "SH" Then COLORPOSITION = Color.DarkSeaGreen
        If playerposition = "CF" Then COLORPOSITION = Color.PaleVioletRed
        If playerposition = "WG" Then COLORPOSITION = Color.PaleVioletRed
        If playerposition = "GK" Then COLORPOSITION = Color.DarkGoldenrod
    End Sub


    Public Sub caracteristicas()

        'offsethaircolour = 22789


        FileGet(1, lectorByte, offsets + 1)

        'FilePut(1, datograbar, offset1 + 1)

    End Sub
    Public Sub guardar()

        'offset1 = 22788
        datograbar = aa
        FilePut(1, datograbar, offset1 + 1)
        'FilePut(2, 165, offset1)

    End Sub
    Public Sub guardarstr()

        'offset1 = 22788
        Dim borrarstr As Byte
        Dim countoffset As Integer
        countoffset = offset1

        borrarstr = "00"
        For w = 0 To 10
            FilePut(1, borrarstr, countoffset + 1)
            countoffset = countoffset + 1
        Next


        datograbarstr = aa
        FilePut(1, datograbarstr, offset1 + 1)


    End Sub
    Public Sub binconvert()
        'Dim HEX0 As String = "0000"
        'Dim HEX1 As String = "0001"
        'Dim HEX2 As String = "0010"
        'Dim HEX3 As String = "0011"
        'Dim HEX4 As String = "0100"
        'Dim HEX5 As String = "0101"
        'Dim HEX6 As String = "0110"
        'Dim HEX7 As String = "0111"
        'Dim HEX8 As String = "1000"
        'Dim HEX9 As String = "1001"
        'Dim HEXA As String = "1010"
        'Dim HEXB As String = "1011"
        'Dim HEXC As String = "1100"
        'Dim HEXD As String = "1101"
        'Dim HEXE As String = "1110"
        'Dim HEXF As String = "1111"



        'For A = 0 To 23
        '    If SS.Substring(A, 1) = "0" Then bin1 = HEX0
        '    If SS.Substring(A, 1) = "1" Then bin1 = HEX1
        '    If SS.Substring(A, 1) = "2" Then bin1 = HEX2
        '    If SS.Substring(A, 1) = "3" Then bin1 = HEX3
        '    If SS.Substring(A, 1) = "4" Then bin1 = HEX4
        '    If SS.Substring(A, 1) = "5" Then bin1 = HEX5
        '    If SS.Substring(A, 1) = "6" Then bin1 = HEX6
        '    If SS.Substring(A, 1) = "7" Then bin1 = HEX7
        '    If SS.Substring(A, 1) = "8" Then bin1 = HEX8
        '    If SS.Substring(A, 1) = "9" Then bin1 = HEX9
        '    If SS.Substring(A, 1) = "A" Then bin1 = HEXA
        '    If SS.Substring(A, 1) = "B" Then bin1 = HEXB
        '    If SS.Substring(A, 1) = "C" Then bin1 = HEXC
        '    If SS.Substring(A, 1) = "D" Then bin1 = HEXD
        '    If SS.Substring(A, 1) = "E" Then bin1 = HEXE
        '    If SS.Substring(A, 1) = "F" Then bin1 = HEXF

        'Next



    End Sub


    Public Sub algoritmo1()
        If residuo = "A" Then residuo = 10
        If residuo = "B" Then residuo = 11
        If residuo = "C" Then residuo = 12
        If residuo = "D" Then residuo = 13
        If residuo = "E" Then residuo = 14
        If residuo = "F" Then residuo = 15
        cadena = Hex(a + b + c + residuo)


        If cadena.Length >= 2 Then
            grababyte = cadena.Substring(cadena.Length - 2, 2)
        Else
            grababyte = cadena
        End If


        If cadena.Length > 2 Then
            residuo = cadena.Substring(0, 1)
        Else
            residuo = 0
        End If


        aa = (Convert.ToByte(grababyte, 16))

    End Sub
    Public Sub algoritmo2()
        If residuo = "A" Then residuo = 10
        If residuo = "B" Then residuo = 11
        If residuo = "C" Then residuo = 12
        If residuo = "D" Then residuo = 13
        If residuo = "E" Then residuo = 14
        If residuo = "F" Then residuo = 15

        cadena = Hex(a + b + residuo)

        If cadena.Length >= 2 Then
            grababyte = cadena.Substring(cadena.Length - 2, 2)
        Else
            grababyte = cadena
        End If


        If cadena.Length > 2 Then
            residuo = cadena.Substring(0, 1)
        Else
            residuo = 0
        End If

        aa = (Convert.ToByte(grababyte, 16))
        'MsgBox(grababyte)
        'residuo = residuo

    End Sub
    Public Sub algoritmo3()



        cadena = Hex(a)

        aa = (Convert.ToByte(cadena, 16))

    End Sub
    Public Sub algoritmonumberclub()
        If residuo = "A" Then residuo = 10
        If residuo = "B" Then residuo = 11
        If residuo = "C" Then residuo = 12
        If residuo = "D" Then residuo = 13
        If residuo = "E" Then residuo = 14
        If residuo = "F" Then residuo = 15
        cadena = Hex(a + b + residuo)

        If cadena.Length >= 2 Then
            grababyte = cadena.Substring(cadena.Length - 2, 2)
        Else
            grababyte = cadena
        End If


        If cadena.Length > 2 Then
            residuo = cadena.Substring(0, 1)
        Else
            residuo = 0
        End If

        aa = (Convert.ToByte(grababyte, 16))
        'MsgBox(residuo)
        'residuo = residuo

    End Sub

    Public Sub colorcabellopic()


        Dim grabarbytepic As String
        Dim cadena2 As String
        Dim coloragrabar As Byte
        cadena2 = "30303000202020001010100020384A00080808"

        Dim count As Integer
        count = 0
        Dim offsetini As Integer
        offsetini = 159
        If ident = "a" Then cadena2 = "30303000202020001010100020384A00080808"
        If ident = "b" Then cadena2 = "2038640008284A000020380018426300001031"
        If ident = "c" Then cadena2 = "386272002852620018425A0021527B0008314A"
        If ident = "d" Then cadena2 = "4A525A00424A520042424A00314A6B00212931"
        If ident = "e" Then cadena2 = "A4A4A4009494940084848400737B8B006B6B6B"
        If ident = "f" Then cadena2 = "4ABCE6002894C6001072A400216B9B00106E93"
        If ident = "g" Then cadena2 = "004A840000386A0000305A001042730000214A"
        If ident = "h" Then cadena2 = "1884AC00106A9400105A8400185A8300004A73"



        For nn = 0 To 18

            grabarbytepic = cadena2.Substring(count, 2)
            count = count + 2
            coloragrabar = (Convert.ToByte(grabarbytepic, 16))
            'MsgBox(grabarbytepic)
            FilePut(2, coloragrabar, offsetini)
            offsetini = offsetini + 1
        Next

        FileClose(2)

        'End If

    End Sub
    Public Sub skincolourpic()
        Dim grabarbytepic2 As String
        Dim cadena3 As String
        Dim coloragrabar2 As Byte
        cadena3 = "A5D6F70094C6E70073ADCE006394BD004A84A500396B9C00396B3000426B940039638C00295A8C005A738400315A8400184A840029527B00214A7300083973"

        Dim count1 As Integer
        count1 = 0
        Dim offsetini1 As Integer
        offsetini1 = 95
        If ident = "a" Then cadena3 = "A5D6F70094C6E70073ADCE006394BD004A84A500396B9C00396B3000426B940039638C00295A8C005A738400315A8400184A840029527B00214A7300083973"
        If ident = "b" Then cadena3 = "52ADE7004A9CD6003984BD00317BB500216B9C00185A94002973B5003173B500296BAD00104A8C005A738400215AA500184A840021529C00184A9400083973"
        If ident = "c" Then cadena3 = "5587ED004477DC003366BA003355A900224487001133770018559800225598001144870011336600505A640011338700002255001133770000336600001144"
        If ident = "d" Then cadena3 = "336698003355870022446600193C55001133440011224400083355001133550011225500002233005050500011224400001122000022440000223300001111"




        For nn = 0 To 62

            grabarbytepic2 = cadena3.Substring(count1, 2)
            count1 = count1 + 2
            coloragrabar2 = (Convert.ToByte(grabarbytepic2, 16))
            'MsgBox(grabarbytepic)
            FilePut(2, coloragrabar2, offsetini1)
            offsetini1 = offsetini1 + 1
        Next

        FileClose(2)




    End Sub


    Public Sub skincolourpic2()
        Dim count2 As Integer
        count2 = 0
        Dim offsetini2 As Integer
        offsetini2 = 95
        Dim cadena4 As String
        Dim grabarbytepic3 As String
        Dim colorgrabar3 As Byte
        cadena4 = "A5D6F70094C6E70073ADCE006394BD004A84A500396B9C00396B3000426B940039638C00295A8C005A738400315A8400184A840029527B00214A7300083973"

        If ident = "a" Then cadena4 = "A5D6F70094C6E70073ADCE006394BD004A84A500396B9C00396B3000426B940039638C00295A8C005A738400315A8400184A840029527B00214A7300083973"
        If ident = "b" Then cadena4 = "52ADE7004A9CD6003984BD00317BB500216B9C00185A94002973B5003173B500296BAD00104A8C005A738400215AA500184A840021529C00184A9400083973"
        If ident = "c" Then cadena4 = "5587ED004477DC003366BA003355A900224487001133770018559800225598001144870011336600505A640011338700002255001133770000336600001144"
        If ident = "d" Then cadena4 = "336698003355870022446600193C55001133440011224400083355001133550011225500002233005050500011224400001122000022440000223300001111"

        For nn = 0 To 62

            grabarbytepic3 = cadena4.Substring(count2, 2)
            count2 = count2 + 2
            colorgrabar3 = (Convert.ToByte(grabarbytepic3, 16))
            'MsgBox(grabarbytepic)
            FilePut(3, colorgrabar3, offsetini2)
            offsetini2 = offsetini2 + 1
        Next

    End Sub

    Public Sub hairfacecolourpic()
        Dim count3 As Integer
        count3 = 0
        Dim offsetini3 As Integer
        offsetini3 = 179
        Dim cadena5 As String
        Dim grabarbytepic4 As String
        Dim colorgrabar4 As Byte
        cadena5 = "30527A0028426200203042"

        If ident = "a" Then cadena5 = "30527A0028426200203042"
        If ident = "b" Then cadena5 = "285A8C0020527A00003052"
        If ident = "c" Then cadena5 = "3862940038628400386272"
        If ident = "d" Then cadena5 = "5A8CA400629CA40072ACAC"
        If ident = "e" Then cadena5 = "848484008C949C00A4A4A4"
        If ident = "f" Then cadena5 = "4294BC0042A4CE004ABCE6"
        If ident = "g" Then cadena5 = "42526A00424A5A004A4A4A"

        For nn = 0 To 10

            grabarbytepic4 = cadena5.Substring(count3, 2)
            count3 = count3 + 2
            colorgrabar4 = (Convert.ToByte(grabarbytepic4, 16))
            'MsgBox(grabarbytepic)
            FilePut(3, colorgrabar4, offsetini3)
            offsetini3 = offsetini3 + 1
        Next
    End Sub

    Public ident As String

    Public grababyte As String
    Public cadena As String
    Public residuo As String
    Public a As Integer
    Public b As Integer
    Public c As Integer
    Public offsetresiduo As String


End Module


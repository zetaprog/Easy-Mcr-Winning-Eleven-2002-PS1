Imports System.IO
Imports System.Net.WebSockets
Imports System.Runtime.InteropServices
Imports System.Runtime.Serialization

Module stats1
    Public formmcr As New FrmMCR

    'Public formplayer As New PlayerEdit


    Public stat1 As Integer
    Public stat2 As Integer
    Public stat3 As Integer
    Public stat4 As Integer
    Public stat5 As Integer

    Public promedio As Integer

    Public resultstat As Integer
    Public BUFFERSIZE As Integer = 22
    Public buffersize2 As Integer = 22
    Public bufferziseId1 As Integer = 6
    Public bufferziseId2 As Integer = 6

    Public bufersizenum As Integer = 5

    Public offsetnum As Integer

    Public idBinNumbers As Integer
    Public numberPlayer(23) As Integer

    Public fileExists As Boolean = File.Exists(csvFilePath)
    Public csvFilePath As String = My.Application.Info.DirectoryPath & "/Option.cvs"

    Public stats_1 As Integer = Options.cmb_Stat1.Text
    Public stats1a As Integer = Options.Cmb_stat1a.Text
    Public stats2 As Integer = Options.Cmb_stat2.Text
    Public stats2a As Integer = Options.Cmb_stat2a.Text
    Public stats3 As Integer = Options.Cmb_stat3.Text
    Public stats3a As Integer = Options.Cmb_stat3a.Text
    Public stats4 As Integer = Options.Cmb_stat4.Text
    Public stats4a As Integer = Options.Cmb_stat4a.Text
    Public stats5 As Integer = Options.Cmb_stat5.Text
    Public stats5a As Integer = Options.Cmb_stat5a.Text
    Public stats6 As Integer = Options.Cmb_stat6.Text
    Public stats6a As Integer = Options.Cmb_stat6a.Text
    Public stats7 As Integer = Options.Cmb_stat7.Text
    Public stats7a As Integer = Options.Cmb_stat7a.Text
    Public stats8 As Integer = Options.Cmb_stat8.Text
    Public stats8a As Integer = Options.Cmb_stat8a.Text


    Public defgk1 As Integer = Options.cmb_deffGk1.Text
    Public defgk1a As Integer = Options.cmb_deffGk1a.Text
    Public defgk2 As Integer = Options.cmb_deffGk2.Text
    Public defgk2a As Integer = Options.cmb_deffGk2a.Text
    Public defgk3 As Integer = Options.cmb_deffGk3.Text
    Public defgk3a As Integer = Options.cmb_deffGk3a.Text
    Public defgk4 As Integer = Options.cmb_deffGk4.Text
    Public defgk4a As Integer = Options.cmb_deffGk4a.Text
    Public defgk5 As Integer = Options.cmb_deffGk5.Text
    Public defgk5a As Integer = Options.cmb_deffGk5a.Text
    Public defgk6 As Integer = Options.cmb_deffGk6.Text
    Public defgk6a As Integer = Options.cmb_deffGk6a.Text
    Public defgk7 As Integer = Options.cmb_deffGk7.Text
    Public defgk7a As Integer = Options.cmb_deffGk7a.Text
    Public defgk8 As Integer = Options.cmb_deffGk8.Text
    Public defgk8a As Integer = Options.cmb_deffGk8a.Text


    Public pass_deff1 As Integer = Options.Cmb_Acc_spped1.Text
    Public pass_deff1a As Integer = Options.cmb_pass_shorpwr1a.Text
    Public pass_deff2 As Integer = Options.cmb_pass_shorpwr2.Text
    Public pass_deff2a As Integer = Options.cmb_pass_shorpwr2a.Text
    Public pass_deff3 As Integer = Options.cmb_pass_shorpwr3.Text
    Public pass_deff3a As Integer = Options.cmb_pass_shorpwr3a.Text
    Public pass_deff4 As Integer = Options.cmb_pass_shorpwr4.Text
    Public pass_deff4a As Integer = Options.cmb_pass_shorpwr4a.Text
    Public pass_deff5 As Integer = Options.cmb_pass_shorpwr5.Text
    Public pass_deff5a As Integer = Options.cmb_pass_shorpwr5a.Text
    Public pass_deff6 As Integer = Options.cmb_pass_shorpwr6.Text
    Public pass_deff6a As Integer = Options.cmb_pass_shorpwr6a.Text
    Public pass_deff7 As Integer = Options.cmb_pass_shorpwr7.Text
    Public pass_deff7a As Integer = Options.cmb_pass_shorpwr7a.Text
    Public pass_deff8 As Integer = Options.cmb_pass_shorpwr8.Text
    Public pass_deff8a As Integer = Options.cmb_pass_shorpwr8a.Text

    Public Acc_spped1 As Integer = Options.Cmb_Acc_spped1.Text
    Public Acc_spped1a As Integer = Options.Cmb_Acc_spped1a.Text
    Public Acc_spped2 As Integer = Options.Cmb_Acc_spped2.Text
    Public Acc_spped2a As Integer = Options.Cmb_Acc_spped2a.Text
    Public Acc_spped3 As Integer = Options.Cmb_Acc_spped3.Text
    Public Acc_spped3a As Integer = Options.Cmb_Acc_spped3a.Text
    Public Acc_spped4 As Integer = Options.Cmb_Acc_spped4.Text
    Public Acc_spped4a As Integer = Options.Cmb_Acc_spped4a.Text
    Public Acc_spped5 As Integer = Options.Cmb_Acc_spped5.Text
    Public Acc_spped5a As Integer = Options.Cmb_Acc_spped5a.Text
    Public Acc_spped6 As Integer = Options.Cmb_Acc_spped6.Text
    Public Acc_spped6a As Integer = Options.Cmb_Acc_spped6a.Text
    Public Acc_spped7 As Integer = Options.Cmb_Acc_spped7.Text
    Public Acc_spped7a As Integer = Options.Cmb_Acc_spped7a.Text

    Public RespGK1 As Integer = Options.Cmb_RespGK1.Text
    Public RespGK1a As Integer = Options.Cmb_RespGK1a.Text
    Public RespGK2 As Integer = Options.Cmb_RespGK2.Text
    Public RespGK2a As Integer = Options.Cmb_RespGK2a.Text
    Public RespGK3 As Integer = Options.Cmb_RespGK3.Text
    Public RespGK3a As Integer = Options.Cmb_RespGK3a.Text
    Public RespGK4 As Integer = Options.Cmb_RespGK4.Text
    Public RespGK4a As Integer = Options.Cmb_RespGK4a.Text
    Public RespGK5 As Integer = Options.Cmb_RespGK5.Text
    Public RespGK5a As Integer = Options.Cmb_RespGK5a.Text
    Public RespGK6 As Integer = Options.Cmb_RespGK6.Text
    Public RespGK6a As Integer = Options.Cmb_RespGK6a.Text
    Public RespGK7 As Integer = Options.Cmb_RespGK7.Text
    Public RespGK7a As Integer = Options.Cmb_RespGK7a.Text
    Public RespGK8 As Integer = Options.Cmb_RespGK8.Text
    Public RespGK8a As Integer = Options.Cmb_RespGK8a.Text
    Public AgressionGK1 As Integer = Options.Cmb_AggresionGK1.Text
    Public AgressionGK1a As Integer = Options.Cmb_AggresionGK1a.Text
    Public AgressionGK2 As Integer = Options.Cmb_AggresionGK2.Text
    Public AgressionGK2a As Integer = Options.Cmb_AggresionGK2a.Text
    Public AgressionGK3 As Integer = Options.Cmb_AggresionGK3.Text
    Public AgressionGK3a As Integer = Options.Cmb_AggresionGK3a.Text
    Public AgressionGK4 As Integer = Options.Cmb_AggresionGK4.Text
    Public AgressionGK4a As Integer = Options.Cmb_AggresionGK4a.Text
    Public AgressionGK5 As Integer = Options.Cmb_AggresionGK5.Text
    Public AgressionGK5a As Integer = Options.Cmb_AggresionGK5a.Text
    Public AgressionGK6 As Integer = Options.Cmb_AggresionGK6.Text
    Public AgressionGK6a As Integer = Options.Cmb_AggresionGK6a.Text
    Public AgressionGK7 As Integer = Options.Cmb_AggresionGK7.Text
    Public AgressionGK7a As Integer = Options.Cmb_AggresionGK7a.Text

    Public Sub loadOptionsCVS()
        stats_1 = Options.cmb_Stat1.Text
        stats1a = Options.Cmb_stat1a.Text
        stats2 = Options.Cmb_stat2.Text
        stats2a = Options.Cmb_stat2a.Text
        stats3 = Options.Cmb_stat3.Text
        stats3a = Options.Cmb_stat3a.Text
        stats4 = Options.Cmb_stat4.Text
        stats4a = Options.Cmb_stat4a.Text
        stats5 = Options.Cmb_stat5.Text
        stats5a = Options.Cmb_stat5a.Text
        stats6 = Options.Cmb_stat6.Text
        stats6a = Options.Cmb_stat6a.Text
        stats7 = Options.Cmb_stat7.Text
        stats7a = Options.Cmb_stat7a.Text
        stats8 = Options.Cmb_stat8.Text
        stats8a = Options.Cmb_stat8a.Text


        defgk1 = Options.cmb_deffGk1.Text
        defgk1a = Options.cmb_deffGk1a.Text
        defgk2 = Options.cmb_deffGk2.Text
        defgk2a = Options.cmb_deffGk2a.Text
        defgk3 = Options.cmb_deffGk3.Text
        defgk3a = Options.cmb_deffGk3a.Text
        defgk4 = Options.cmb_deffGk4.Text
        defgk4a = Options.cmb_deffGk4a.Text
        defgk5 = Options.cmb_deffGk5.Text
        defgk5a = Options.cmb_deffGk5a.Text
        defgk6 = Options.cmb_deffGk6.Text
        defgk6a = Options.cmb_deffGk6a.Text
        defgk7 = Options.cmb_deffGk7.Text
        defgk7a = Options.cmb_deffGk7a.Text
        defgk8 = Options.cmb_deffGk8.Text
        defgk8a = Options.cmb_deffGk8a.Text


        pass_deff1 = Options.Cmb_Acc_spped1.Text
        pass_deff1a = Options.cmb_pass_shorpwr1a.Text
        pass_deff2 = Options.cmb_pass_shorpwr2.Text
        pass_deff2a = Options.cmb_pass_shorpwr2a.Text
        pass_deff3 = Options.cmb_pass_shorpwr3.Text
        pass_deff3a = Options.cmb_pass_shorpwr3a.Text
        pass_deff4 = Options.cmb_pass_shorpwr4.Text
        pass_deff4a = Options.cmb_pass_shorpwr4a.Text
        pass_deff5 = Options.cmb_pass_shorpwr5.Text
        pass_deff5a = Options.cmb_pass_shorpwr5a.Text
        pass_deff6 = Options.cmb_pass_shorpwr6.Text
        pass_deff6a = Options.cmb_pass_shorpwr6a.Text
        pass_deff7 = Options.cmb_pass_shorpwr7.Text
        pass_deff7a = Options.cmb_pass_shorpwr7a.Text
        pass_deff8 = Options.cmb_pass_shorpwr8.Text
        pass_deff8a = Options.cmb_pass_shorpwr8a.Text

        Acc_spped1 = Options.Cmb_Acc_spped1.Text
        Acc_spped1a = Options.Cmb_Acc_spped1a.Text
        Acc_spped2 = Options.Cmb_Acc_spped2.Text
        Acc_spped2a = Options.Cmb_Acc_spped2a.Text
        Acc_spped3 = Options.Cmb_Acc_spped3.Text
        Acc_spped3a = Options.Cmb_Acc_spped3a.Text
        Acc_spped4 = Options.Cmb_Acc_spped4.Text
        Acc_spped4a = Options.Cmb_Acc_spped4a.Text
        Acc_spped5 = Options.Cmb_Acc_spped5.Text
        Acc_spped5a = Options.Cmb_Acc_spped5a.Text
        Acc_spped6 = Options.Cmb_Acc_spped6.Text
        Acc_spped6a = Options.Cmb_Acc_spped6a.Text
        Acc_spped7 = Options.Cmb_Acc_spped7.Text
        Acc_spped7a = Options.Cmb_Acc_spped7a.Text

        RespGK1 = Options.Cmb_RespGK1.Text
        RespGK1a = Options.Cmb_RespGK1a.Text
        RespGK2 = Options.Cmb_RespGK2.Text
        RespGK2a = Options.Cmb_RespGK2a.Text
        RespGK3 = Options.Cmb_RespGK3.Text
        RespGK3a = Options.Cmb_RespGK3a.Text
        RespGK4 = Options.Cmb_RespGK4.Text
        RespGK4a = Options.Cmb_RespGK4a.Text
        RespGK5 = Options.Cmb_RespGK5.Text
        RespGK5a = Options.Cmb_RespGK5a.Text
        RespGK6 = Options.Cmb_RespGK6.Text
        RespGK6a = Options.Cmb_RespGK6a.Text
        RespGK7 = Options.Cmb_RespGK7.Text
        RespGK7a = Options.Cmb_RespGK7a.Text
        RespGK8 = Options.Cmb_RespGK8.Text
        RespGK8a = Options.Cmb_RespGK8a.Text
        AgressionGK1 = Options.Cmb_AggresionGK1.Text
        AgressionGK1a = Options.Cmb_AggresionGK1a.Text
        AgressionGK2 = Options.Cmb_AggresionGK2.Text
        AgressionGK2a = Options.Cmb_AggresionGK2a.Text
        AgressionGK3 = Options.Cmb_AggresionGK3.Text
        AgressionGK3a = Options.Cmb_AggresionGK3a.Text
        AgressionGK4 = Options.Cmb_AggresionGK4.Text
        AgressionGK4a = Options.Cmb_AggresionGK4a.Text
        AgressionGK5 = Options.Cmb_AggresionGK5.Text
        AgressionGK5a = Options.Cmb_AggresionGK5a.Text
        AgressionGK6 = Options.Cmb_AggresionGK6.Text
        AgressionGK6a = Options.Cmb_AggresionGK6a.Text
        AgressionGK7 = Options.Cmb_AggresionGK7.Text
        AgressionGK7a = Options.Cmb_AggresionGK7a.Text
    End Sub


    Public Sub LeerAgressionGK()

        If stat1 >= AgressionGK1 And stat1 <= AgressionGK1a Then resultstat = "12"
        If stat1 >= AgressionGK2 And stat1 <= AgressionGK2a Then resultstat = "13"
        If stat1 >= AgressionGK3 And stat1 <= AgressionGK3a Then resultstat = "14"
        If stat1 >= AgressionGK4 And stat1 <= AgressionGK4a Then resultstat = "15"
        If stat1 >= AgressionGK5 And stat1 <= AgressionGK5a Then resultstat = "16"
        If stat1 >= AgressionGK6 And stat1 <= AgressionGK6a Then resultstat = "17"
        If stat1 >= AgressionGK7 And stat1 <= AgressionGK7a Then resultstat = "18"
    End Sub




    Public Sub LeerRangoPlayer()

        If stat1 >= stats_1 And stat1 <= stats1a Then resultstat = "12"
        If stat1 >= stats2 And stat1 <= stats2a Then resultstat = "13"
        If stat1 >= stats3 And stat1 <= stats3a Then resultstat = "14"
        If stat1 >= stats4 And stat1 <= stats4a Then resultstat = "15"
        If stat1 >= stats5 And stat1 <= stats5a Then resultstat = "16"
        If stat1 >= stats6 And stat1 <= stats6a Then resultstat = "17"
        If stat1 >= stats7 And stat1 <= stats7a Then resultstat = "18"
        If stat1 >= stats8 And stat1 <= stats8a Then resultstat = "19"
    End Sub
    Public Sub LeerOffenceGK()
        If stat1 >= defgk1 And stat1 <= defgk1a Then resultstat = "12"
        If stat1 >= defgk2 And stat1 <= defgk2a Then resultstat = "13"
        If stat1 >= defgk3 And stat1 <= defgk3a Then resultstat = "14"
        If stat1 >= defgk4 And stat1 <= defgk4a Then resultstat = "15"
        If stat1 >= defgk5 And stat1 <= defgk5a Then resultstat = "16"
        If stat1 >= defgk6 And stat1 <= defgk6a Then resultstat = "17"
        If stat1 >= defgk7 And stat1 <= defgk7a Then resultstat = "18"
        If stat1 >= defgk8 And stat1 <= defgk8a Then resultstat = "19"
    End Sub
    Public Sub LeerDeffen_Pass()
        If stat1 >= pass_deff1 And stat1 <= pass_deff1a Then resultstat = "12"
        If stat1 >= pass_deff2 And stat1 <= pass_deff2a Then resultstat = "13"
        If stat1 >= pass_deff3 And stat1 <= pass_deff3a Then resultstat = "14"
        If stat1 >= pass_deff4 And stat1 <= pass_deff4a Then resultstat = "15"
        If stat1 >= pass_deff5 And stat1 <= pass_deff5a Then resultstat = "16"
        If stat1 >= pass_deff6 And stat1 <= pass_deff6a Then resultstat = "17"
        If stat1 >= pass_deff7 And stat1 <= pass_deff7a Then resultstat = "18"
        If stat1 >= pass_deff8 And stat1 <= pass_deff8a Then resultstat = "19"
    End Sub
    Public Sub LeerResponseGk()
        If stat1 >= RespGK1 And stat1 <= RespGK1a Then resultstat = "12"
        If stat1 >= RespGK2 And stat1 <= RespGK2a Then resultstat = "13"
        If stat1 >= RespGK3 And stat1 <= RespGK3a Then resultstat = "14"
        If stat1 >= RespGK4 And stat1 <= RespGK4a Then resultstat = "15"
        If stat1 >= RespGK5 And stat1 <= RespGK5a Then resultstat = "16"
        If stat1 >= RespGK6 And stat1 <= RespGK6a Then resultstat = "17"
        If stat1 >= RespGK7 And stat1 <= RespGK7a Then resultstat = "18"
        If stat1 >= RespGK8 And stat1 <= RespGK8a Then resultstat = "19"
    End Sub

    Public Sub LeerSpeed_accOnline()
        If stat1 >= Acc_spped1 And stat1 <= Acc_spped1a Then resultstat = "12"
        If stat1 >= Acc_spped2 And stat1 <= Acc_spped2a Then resultstat = "13"
        If stat1 >= Acc_spped3 And stat1 <= Acc_spped3a Then resultstat = "14"
        If stat1 >= Acc_spped4 And stat1 <= Acc_spped4a Then resultstat = "15"
        If stat1 >= Acc_spped5 And stat1 <= Acc_spped5a Then resultstat = "16"
        If stat1 >= Acc_spped6 And stat1 <= Acc_spped6a Then resultstat = "17"
        If stat1 >= Acc_spped7 And stat1 <= Acc_spped7a Then resultstat = "18"
    End Sub


    Public Sub LeerNationNumbers()
        Dim bytenum(bufersizenum - 1) As Byte
        Dim binaryStringBuilder As New System.Text.StringBuilder()

        Dim binaryString As String = binaryStringBuilder.ToString()
        Dim inputString As String = binaryString
        Dim cadenatamaño As Integer = 5
        Dim bloque As Integer = 0
        Dim count As Integer = 0
        Dim ReadNumber As String
        ' Limpiar el arreglo numberPlayer antes de usarlo
        Array.Clear(numberPlayer, 0, numberPlayer.Length)



        For bloque = 1 To 4


            FileGet(idBinNumbers, bytenum, offsetnum + 1)


            Array.Reverse(bytenum)
            binaryStringBuilder.Clear()

            For Each b As Byte In bytenum
                ' Convertir el byte a una cadena de bits y añadirlo al StringBuilder
                binaryStringBuilder.Append(Convert.ToString(b, 2).PadLeft(8, "0"c))
            Next

            ' Obtener la cadena de bits completa
            binaryString = binaryStringBuilder.ToString()
            Clipboard.SetText(binaryString)
            inputString = binaryString
            cadenatamaño = 5
            ' Seleccionar los últimos 5 caracteres
            For k = 0 To 5
                ReadNumber = inputString.Substring(inputString.Length - cadenatamaño, 5)
                cadenatamaño = cadenatamaño + 5
                If numberPlayer(count) <= 22 Then

                    numberPlayer(count) = Convert.ToInt32(ReadNumber, 2) + 1
                    'MsgBox(numberPlayer(count))
                    count = count + 1
                End If

            Next
            offsetnum = offsetnum + 4
        Next

    End Sub

    Public Sub LoadFromCSV()
        Try
            ' Verificar si el archivo existe
            If File.Exists(csvFilePath) Then
                ' Leer todas las líneas del archivo CSV
                Dim lines() As String = File.ReadAllLines(csvFilePath)

                ' Verificar que haya al menos una línea en el archivo
                If lines.Length > 0 Then
                    ' Procesar solo la primera línea por ahora (puedes ajustar para manejar más líneas según sea necesario)
                    Dim line As String = lines(0)

                    ' Dividir la línea en partes utilizando la coma como delimitador
                    Dim parts() As String = line.Split(","c)

                    ' Verificar que haya suficientes partes para llenar todos los ComboBox
                    If parts.Length >= 79 Then
                        Options.cmb_Stat1.Text = parts(0).Trim()
                        Options.Cmb_stat1a.Text = parts(1).Trim()
                        Options.Cmb_stat2.Text = parts(2).Trim()
                        Options.Cmb_stat2a.Text = parts(3).Trim()
                        Options.Cmb_stat3.Text = parts(4).Trim()
                        Options.Cmb_stat3a.Text = parts(5).Trim()
                        Options.Cmb_stat4.Text = parts(6).Trim()
                        Options.Cmb_stat4a.Text = parts(7).Trim()
                        Options.Cmb_stat5.Text = parts(8).Trim()
                        Options.Cmb_stat5a.Text = parts(9).Trim()
                        Options.Cmb_stat6.Text = parts(10).Trim()
                        Options.Cmb_stat6a.Text = parts(11).Trim()
                        Options.Cmb_stat7.Text = parts(12).Trim()
                        Options.Cmb_stat7a.Text = parts(13).Trim()
                        Options.Cmb_stat8.Text = parts(14).Trim()
                        Options.Cmb_stat8a.Text = parts(15).Trim()

                        Options.cmb_deffGk1.Text = parts(16).Trim()
                        Options.cmb_deffGk1a.Text = parts(17).Trim()
                        Options.cmb_deffGk2.Text = parts(18).Trim()
                        Options.cmb_deffGk2a.Text = parts(19).Trim()
                        Options.cmb_deffGk3.Text = parts(20).Trim()
                        Options.cmb_deffGk3a.Text = parts(21).Trim()
                        Options.cmb_deffGk4.Text = parts(22).Trim()
                        Options.cmb_deffGk4a.Text = parts(23).Trim()
                        Options.cmb_deffGk5.Text = parts(24).Trim()
                        Options.cmb_deffGk5a.Text = parts(25).Trim()
                        Options.cmb_deffGk6.Text = parts(26).Trim()
                        Options.cmb_deffGk6a.Text = parts(27).Trim()
                        Options.cmb_deffGk7.Text = parts(28).Trim()
                        Options.cmb_deffGk7a.Text = parts(29).Trim()
                        Options.cmb_deffGk8.Text = parts(30).Trim()
                        Options.cmb_deffGk8a.Text = parts(31).Trim()


                        Options.Cmb_RespGK1.Text = parts(32).Trim()
                        Options.Cmb_RespGK1a.Text = parts(33).Trim()
                        Options.Cmb_RespGK2.Text = parts(34).Trim()
                        Options.Cmb_RespGK2a.Text = parts(35).Trim()
                        Options.Cmb_RespGK3.Text = parts(36).Trim()
                        Options.Cmb_RespGK3a.Text = parts(37).Trim()
                        Options.Cmb_RespGK4.Text = parts(38).Trim()
                        Options.Cmb_RespGK4a.Text = parts(39).Trim()
                        Options.Cmb_RespGK5.Text = parts(40).Trim()
                        Options.Cmb_RespGK5a.Text = parts(41).Trim()
                        Options.Cmb_RespGK6.Text = parts(42).Trim()
                        Options.Cmb_RespGK6a.Text = parts(43).Trim()
                        Options.Cmb_RespGK7.Text = parts(44).Trim()
                        Options.Cmb_RespGK7a.Text = parts(45).Trim()
                        Options.Cmb_RespGK8.Text = parts(46).Trim()
                        Options.Cmb_RespGK8a.Text = parts(47).Trim()

                        Options.Cmb_Acc_spped1.Text = parts(48).Trim()
                        Options.Cmb_Acc_spped1a.Text = parts(49).Trim()
                        Options.Cmb_Acc_spped2.Text = parts(50).Trim()
                        Options.Cmb_Acc_spped2a.Text = parts(51).Trim()
                        Options.Cmb_Acc_spped3.Text = parts(52).Trim()
                        Options.Cmb_Acc_spped3a.Text = parts(53).Trim()
                        Options.Cmb_Acc_spped4.Text = parts(54).Trim()
                        Options.Cmb_Acc_spped4a.Text = parts(55).Trim()
                        Options.Cmb_Acc_spped5.Text = parts(56).Trim()
                        Options.Cmb_Acc_spped5a.Text = parts(57).Trim()
                        Options.Cmb_Acc_spped6.Text = parts(58).Trim()
                        Options.Cmb_Acc_spped6a.Text = parts(59).Trim()
                        Options.Cmb_Acc_spped7.Text = parts(60).Trim()
                        Options.Cmb_Acc_spped7a.Text = parts(61).Trim()

                        Options.cmb_pass_shorpwr1.Text = parts(62).Trim()
                        Options.cmb_pass_shorpwr1a.Text = parts(63).Trim()
                        Options.cmb_pass_shorpwr2.Text = parts(64).Trim()
                        Options.cmb_pass_shorpwr2a.Text = parts(65).Trim()
                        Options.cmb_pass_shorpwr3.Text = parts(66).Trim()
                        Options.cmb_pass_shorpwr3a.Text = parts(67).Trim()
                        Options.cmb_pass_shorpwr4.Text = parts(68).Trim()
                        Options.cmb_pass_shorpwr4a.Text = parts(69).Trim()
                        Options.cmb_pass_shorpwr5.Text = parts(70).Trim()
                        Options.cmb_pass_shorpwr5a.Text = parts(71).Trim()
                        Options.cmb_pass_shorpwr6.Text = parts(72).Trim()
                        Options.cmb_pass_shorpwr6a.Text = parts(73).Trim()
                        Options.cmb_pass_shorpwr7.Text = parts(74).Trim()
                        Options.cmb_pass_shorpwr7a.Text = parts(75).Trim()
                        Options.cmb_pass_shorpwr8.Text = parts(76).Trim()
                        Options.cmb_pass_shorpwr8a.Text = parts(77).Trim()

                        Options.cmb_feedoutside.Text = parts(78).Trim()






                        'MessageBox.Show("Datos cargados correctamente.")
                    Else
                        MessageBox.Show("La primera línea del archivo CSV no tiene suficientes partes para llenar todos los ComboBox.")
                    End If
                Else
                    MessageBox.Show("El archivo CSV está vacío.")
                End If
            Else
                MessageBox.Show("El archivo CSV no existe.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos desde el archivo CSV: " & ex.Message)
        End Try
    End Sub


End Module

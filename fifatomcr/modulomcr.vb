Imports System.Data
Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System.IO
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

    Public SelectCalcMCR As Integer = 1


    Public posplayer As String
    Public playerposition As String
    Public COLORPOSITION As Color

    Public PLAYER1_FORMATION As String = "Player 1"
    Public PLAYER2_FORMATION As String = "Player 2"
    Public PLAYER3_FORMATION As String = "Player 3"
    Public PLAYER4_FORMATION As String = "Player 4"
    Public PLAYER5_FORMATION As String = "Player 5"
    Public PLAYER6_FORMATION As String = "Player 6"
    Public PLAYER7_FORMATION As String = "Player 7"
    Public PLAYER8_FORMATION As String = "Player 8"
    Public PLAYER9_FORMATION As String = "Player 9"
    Public PLAYER10_FORMATION As String = "Player 10"
    Public PLAYER11_FORMATION As String = "Player 11"

    Public nclub As Integer
    Public numclub As Integer
    Public nnational As Integer
    Public numnational As Integer

    Public indexcmbhair As String
    Public indexcmbhaircolor As String
    Public indexcmbskikcolour As String
    Public indexcmbhairface As String
    Public indexcmbhaircolourface As String

    Public comboindex As Integer

    Public connectionString As String = "Data Source=mydatabase.db;Version=3;"

    Public fotosofifa As String
    Public total As Integer
    Public id As Long
    Public WeName As String
    Public WeClub As String
    Public WeNation As String
    Public WeNationTeam As String
    Public dato As Integer
    Public offsetdata As Integer
    Public sizedata As Integer
    Public values As Long
    Public bytes() As Byte
    Public sizeSTR As Integer = 10

    Public bs As New BindingSource()


    Public RutaArchivoBin As String = My.Application.Info.DirectoryPath & "\database.mcr"
    Public Sub LeerData()
        Using fs As New FileStream(RutaArchivoBin, FileMode.Open, FileAccess.Read)
            ' Posicionamos el flujo en el offset especificado
            fs.Seek(offsetdata, SeekOrigin.Begin)
            values = 0
            ' Usamos BinaryReader para leer los  valores numéricos
            Using br As New BinaryReader(fs)
                '    For i As Integer = 0 To sizedata
                '        ' Leemos cada valor y lo almacenamos en el array
                '        values(i) = br.ReadInt32()
                '    Next
                bytes = br.ReadBytes(sizedata) ' Leemos sizedata tamaño 

                For i As Integer = 0 To bytes.Length - 1
                    values = values Or (CLng(bytes(i)) << (8 * i))
                Next

            End Using

        End Using
    End Sub

    Public Sub GrabarData()
        Using fs As New FileStream(RutaArchivoBin, FileMode.OpenOrCreate, FileAccess.Write)
            ' Posicionamos el flujo al inicio del archivo
            fs.Seek(offsetdata, SeekOrigin.Begin)

            ' Escribimos el dato como Integer (4 bytes)
            Dim bw As New BinaryWriter(fs)
            bw.Write(dato)

            ' Rellenamos con 2 ceros adicionales para completar los 6 bytes
            bw.Write(New Byte(1) {0, 0}) ' Escribe dos bytes ceros

            ' Liberamos los recursos del BinaryWriter
            bw.Flush()
            bw = Nothing
        End Using
    End Sub

    Public Sub ContactsByName()
        Dim dt As New Data.DataTable()
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim command As New SQLiteCommand("SELECT * FROM Players WHERE Name LIKE @Name", connection)
            command.Parameters.AddWithValue("@Name", "%" & WeName & "%") ' Buscar en cualquier parte del nombre
            Dim adapter As New SQLiteDataAdapter(command)
            adapter.Fill(dt)
            connection.Close()
        End Using

        Form1.DataGridView2.DataSource = dt
    End Sub

    Public Sub ContactsByClub()
        Dim dt As New Data.DataTable()
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim command As New SQLiteCommand("SELECT * FROM Players WHERE Club LIKE @Club", connection)
            command.Parameters.AddWithValue("@Club", "%" & WeClub & "%") ' Buscar en cualquier parte del nombre
            Dim adapter As New SQLiteDataAdapter(command)
            adapter.Fill(dt)
            connection.Close()
        End Using

        Form1.DataGridView2.DataSource = dt
    End Sub

    Public Sub ContactsByNat()
        Dim dt As New Data.DataTable()
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim command As New SQLiteCommand("SELECT * FROM Players WHERE Nation LIKE @Nation", connection)
            command.Parameters.AddWithValue("@Nation", "%" & WeNation & "%") ' Buscar en cualquier parte del nombre
            Dim adapter As New SQLiteDataAdapter(command)
            adapter.Fill(dt)
            connection.Close()
        End Using

        Form1.DataGridView2.DataSource = dt
    End Sub

    Public Sub ContactsByNationalTeam()
        Dim dt As New Data.DataTable()
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim command As New SQLiteCommand("SELECT * FROM Players WHERE NationalTeam LIKE @NationalTeam", connection)
            command.Parameters.AddWithValue("@NationalTeam", "%" & WeNationTeam & "%") ' Buscar en cualquier parte del nombre
            Dim adapter As New SQLiteDataAdapter(command)
            adapter.Fill(dt)
            connection.Close()
        End Using

        Form1.DataGridView2.DataSource = dt
    End Sub

    Public Sub AllPlayersWithoutPhoto()
        Dim dt As New Data.DataTable()
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim command As New SQLiteCommand(
            "SELECT * FROM Players 
             WHERE PhotoBlob IS NULL OR LENGTH(PhotoBlob) = 0", connection)

            Dim adapter As New SQLiteDataAdapter(command)
            adapter.Fill(dt)
            connection.Close()
        End Using

        Form1.DataGridView2.DataSource = dt
    End Sub


    Public Sub allContatcs()
        Dim dt As New Data.DataTable()
        Using connection As New SQLiteConnection(connectionString)
                connection.Open()
            Dim command As New SQLiteCommand("SELECT * FROM Players", connection)
            Dim adapter As New SQLiteDataAdapter(command)
            adapter.Fill(dt)
                connection.Close()
            End Using

        Form1.DataGridView2.DataSource = dt


    End Sub


    Public Sub LoadContacts()
        If Form1.txt_id.Text <> "" And Form1.txt_id.Text <> "0" Then
            Dim dt As New Data.DataTable()
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Dim command As New SQLiteCommand("SELECT * FROM Players WHERE Id = @Id", connection)
                command.Parameters.AddWithValue("@Id", id) ' Agregar el parámetro
                Dim adapter As New SQLiteDataAdapter(command)
                adapter.Fill(dt)
                connection.Close()
            End Using

            Form1.DataGridView1.DataSource = dt
        Else
            Form1.DataGridView1.DataSource = Nothing
        End If

    End Sub

    Public Sub AddColumnsToDatabase()
        ' Ruta de la base de datos SQLite
        Dim connectionString As String = "Data Source=mydatabase.db;Version=3;"

        Using connection As New SQLiteConnection(connectionString)
            Try
                connection.Open()

                ' Lista de comandos para agregar columnas
                Dim queries As String() = {
                "ALTER TABLE Players ADD COLUMN PhotoBlob BLOB",
                "ALTER TABLE Players ADD COLUMN Link TEXT",
                "ALTER TABLE Players ADD COLUMN Photo TEXT"
            }

                For Each query As String In queries
                    Dim command As New SQLiteCommand(query, connection)
                    command.ExecuteNonQuery()
                Next

                MsgBox("Las columnas se han agregado correctamente.")
            Catch ex As Exception
                MsgBox("Error al agregar columnas: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Public Function ResizeImage(img As Image, maxWidth As Integer, maxHeight As Integer) As Image
        Dim ratioX As Double = maxWidth / img.Width
        Dim ratioY As Double = maxHeight / img.Height
        Dim ratio As Double = Math.Min(ratioX, ratioY)
        Dim newWidth As Integer = CInt(img.Width * ratio)
        Dim newHeight As Integer = CInt(img.Height * ratio)
        Dim newImg As New Bitmap(newWidth, newHeight)
        Using g As Graphics = Graphics.FromImage(newImg)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(img, 0, 0, newWidth, newHeight)
        End Using
        Return newImg
    End Function

    Public Sub InsertData()
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            ' Verificar si el ID ya existe
            If Form1.txt_id.Text <> "" And Form1.txt_id.Text <> "0" Then


                id = Form1.txt_id.Text
                Dim checkIdCommand As New SQLiteCommand("SELECT COUNT(*) FROM Players WHERE Id = @Id", connection)
                checkIdCommand.Parameters.AddWithValue("@Id", id)
                Dim count As Integer = Convert.ToInt32(checkIdCommand.ExecuteScalar())
                'Dim resizedImg As Image = ResizeImage(formmcr.PictureFifa.Image, 150, 150) ' nuevo tamaño

                'Dim ms As New MemoryStream()
                'resizedImg.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                'Dim photoBytes() As Byte = ms.ToArray()
                'num
                If SelectCalcMCR = 2 Then
                    If formmcr.Rbt_Club.Checked = True Then numclub = formmcr.cmbclubnumber.Text
                    If formmcr.Rbt_Nat.Checked = True Then numnational = formmcr.cmbclubnumber.Text
                End If

                If count > 0 Then
                        ' Si el ID existe, actualizar los datos
                        Dim updateCommand As New SQLiteCommand("UPDATE Players SET Name = @name, SkinColor = @SkinColor, Hair = @Hair, HairColor = @HairColor, HairFace = @HairFace, HairColorFace = @HairColorFace, Club = @Club, NationalTeam = @NationalTeam, Nation = @Nation, NumClub = @NumClub, NumNation = @NumNation, NAMEWE = @NameWe, Position = @Position, Birthday = @Birthday, Height = @Height, Body = @Body, Age = @Age, Boots = @Boots, Feet = @Feet, FeetOutside = @FeetOutside, Ofensse = @Ofensse, Deffense = @Deffense, BodyBalance = @BodyBalance, Stamina = @Stamina, Speed = @Speed, Acceleration = @Acceleration, Pass = @Pass, ShotPower = @ShotPower, ShotAcc = @ShotAcc, Jump = @Jump, Head = @Head, Technique = @Technique, Dribble = @Dribble, Curve = @Curve, Aggresive = @Aggresive, Response = @Response, Link = @Link, Photo = @Photo WHERE Id = @Id", connection)

                        updateCommand.Parameters.AddWithValue("@Id", id)
                    updateCommand.Parameters.AddWithValue("@name", Form1.txt_PlayerName.Text)
                    updateCommand.Parameters.AddWithValue("@SkinColor", formmcr.cmbskincolor.Text)
                        updateCommand.Parameters.AddWithValue("@Hair", formmcr.cmbhair.Text)
                        updateCommand.Parameters.AddWithValue("@HairColor", formmcr.cmbhaircolor.Text)
                        updateCommand.Parameters.AddWithValue("@HairFace", formmcr.cmbhairface.Text)
                        updateCommand.Parameters.AddWithValue("@HairColorFace", formmcr.cmbhaircolorface.Text)
                        updateCommand.Parameters.AddWithValue("@Club", formmcr.txtclub.Text)
                        updateCommand.Parameters.AddWithValue("@NationalTeam", formmcr.txt_nat_team.Text)
                        updateCommand.Parameters.AddWithValue("@Nation", formmcr.txtnacionalidad.Text)
                        updateCommand.Parameters.AddWithValue("@NumClub", numclub)
                        updateCommand.Parameters.AddWithValue("@NumNation", numnational)
                        updateCommand.Parameters.AddWithValue("@NameWe", formmcr.txtplayername.Text)
                        updateCommand.Parameters.AddWithValue("@Position", formmcr.cmbposition.Text)
                    updateCommand.Parameters.AddWithValue("@Birthday", If(String.IsNullOrEmpty(Form1.txt_PlayerAge.Text), DBNull.Value, Form1.txt_PlayerAge.Text))
                    updateCommand.Parameters.AddWithValue("@Height", formmcr.cmbheigth.Text)
                    updateCommand.Parameters.AddWithValue("@Body", formmcr.cmbbody.Text)
                    updateCommand.Parameters.AddWithValue("@Age", formmcr.cmbage.Text)
                    updateCommand.Parameters.AddWithValue("@Boots", formmcr.cmbboots.Text)
                    updateCommand.Parameters.AddWithValue("@Feet", formmcr.cmbfood.Text)
                    updateCommand.Parameters.AddWithValue("@FeetOutside", formmcr.cmbfeedoutside.Text)
                    updateCommand.Parameters.AddWithValue("@Ofensse", formmcr.cmboffense.Text)
                    updateCommand.Parameters.AddWithValue("@Deffense", formmcr.cmbdeffense.Text)
                    updateCommand.Parameters.AddWithValue("@BodyBalance", formmcr.cmbbodybalance.Text)
                    updateCommand.Parameters.AddWithValue("@Stamina", formmcr.cmbstamina.Text)
                    updateCommand.Parameters.AddWithValue("@Speed", formmcr.cmbspeed.Text)
                    updateCommand.Parameters.AddWithValue("@Acceleration", formmcr.cmbaceleration.Text)
                    updateCommand.Parameters.AddWithValue("@Pass", formmcr.cmbpass.Text)
                    updateCommand.Parameters.AddWithValue("@ShotPower", formmcr.cmbshotpower.Text)
                    updateCommand.Parameters.AddWithValue("@ShotAcc", formmcr.cmbshotacc.Text)
                    updateCommand.Parameters.AddWithValue("@Jump", formmcr.cmbjump.Text)
                    updateCommand.Parameters.AddWithValue("@Head", formmcr.cmbhead.Text)
                    updateCommand.Parameters.AddWithValue("@Technique", formmcr.cmbtechnique.Text)
                    updateCommand.Parameters.AddWithValue("@Dribble", formmcr.cmbdribble.Text)
                    updateCommand.Parameters.AddWithValue("@Curve", formmcr.cmbcurve.Text)
                    updateCommand.Parameters.AddWithValue("@Aggresive", formmcr.cmbaggression.Text)
                    updateCommand.Parameters.AddWithValue("@Response", formmcr.cmbresponse.Text)
                    updateCommand.Parameters.AddWithValue("@Link", formmcr.lbl_link.Text)
                    updateCommand.Parameters.AddWithValue("@Photo", "")
                    'updateCommand.Parameters.Add("@PhotoBlob", DbType.Binary).Value = photoBytes
                    updateCommand.ExecuteNonQuery()
                    'MessageBox.Show("Datos actualizados correctamente.")
                Else
                    ' Si el ID no existe, insertar un nuevo registro
                    Dim insertCommand As New SQLiteCommand("INSERT INTO Players (Id, Name, SkinColor, Hair, HairColor, HairFace, HairColorFace, Club, NationalTeam, Nation, NumClub, NumNation, NAMEWE, Position, Birthday, Height, Body, Age, Boots, Feet, FeetOutside, Ofensse, Deffense, BodyBalance, Stamina, Speed, Acceleration, Pass, ShotPower, ShotAcc, Jump, Head, Technique, Dribble, Curve, Aggresive, Response, Link) VALUES (@id, @name, @SkinColor, @Hair, @HairColor, @HairFace, @HairColorFace, @Club, @NationalTeam, @Nation, @NumClub, @NumNation, @NameWe, @Position, @Birthday, @Height, @Body, @Age, @Boots, @Feet, @FeetOutside, @Ofensse, @Deffense, @BodyBalance, @Stamina, @Speed, @Acceleration, @Pass, @ShotPower, @ShotAcc, @Jump, @Head, @Technique, @Dribble, @Curve, @Aggresive, @Response, @Link)", connection)

                    insertCommand.Parameters.AddWithValue("@id", id)
                    insertCommand.Parameters.AddWithValue("@name", Form1.txt_PlayerName.Text)
                    insertCommand.Parameters.AddWithValue("@SkinColor", formmcr.cmbskincolor.Text)
                    insertCommand.Parameters.AddWithValue("@Hair", formmcr.cmbhair.Text)
                    insertCommand.Parameters.AddWithValue("@HairColor", formmcr.cmbhaircolor.Text)
                    insertCommand.Parameters.AddWithValue("@HairFace", formmcr.cmbhairface.Text)
                    insertCommand.Parameters.AddWithValue("@HairColorFace", formmcr.cmbhaircolorface.Text)
                    insertCommand.Parameters.AddWithValue("@Club", formmcr.txtclub.Text)
                    insertCommand.Parameters.AddWithValue("@NationalTeam", formmcr.txt_nat_team.Text)
                    insertCommand.Parameters.AddWithValue("@Nation", formmcr.txtnacionalidad.Text)
                    insertCommand.Parameters.AddWithValue("@NumClub", numclub)
                    insertCommand.Parameters.AddWithValue("@NumNation", numnational)
                    insertCommand.Parameters.AddWithValue("@NameWe", formmcr.txtplayername.Text)
                    insertCommand.Parameters.AddWithValue("@Position", formmcr.cmbposition.Text)
                    insertCommand.Parameters.AddWithValue("@Birthday", If(String.IsNullOrEmpty(Form1.txt_PlayerAge.Text), DBNull.Value, Form1.txt_PlayerAge.Text))
                    insertCommand.Parameters.AddWithValue("@Height", formmcr.cmbheigth.Text)
                        insertCommand.Parameters.AddWithValue("@Body", formmcr.cmbbody.Text)
                        insertCommand.Parameters.AddWithValue("@Age", formmcr.cmbage.Text)
                        insertCommand.Parameters.AddWithValue("@Boots", formmcr.cmbboots.Text)
                        insertCommand.Parameters.AddWithValue("@Feet", formmcr.cmbfood.Text)
                        insertCommand.Parameters.AddWithValue("@FeetOutside", formmcr.cmbfeedoutside.Text)
                        insertCommand.Parameters.AddWithValue("@Ofensse", formmcr.cmboffense.Text)
                        insertCommand.Parameters.AddWithValue("@Deffense", formmcr.cmbdeffense.Text)
                        insertCommand.Parameters.AddWithValue("@BodyBalance", formmcr.cmbbodybalance.Text)
                        insertCommand.Parameters.AddWithValue("@Stamina", formmcr.cmbstamina.Text)
                        insertCommand.Parameters.AddWithValue("@Speed", formmcr.cmbspeed.Text)
                        insertCommand.Parameters.AddWithValue("@Acceleration", formmcr.cmbaceleration.Text)
                        insertCommand.Parameters.AddWithValue("@Pass", formmcr.cmbpass.Text)
                        insertCommand.Parameters.AddWithValue("@ShotPower", formmcr.cmbshotpower.Text)
                        insertCommand.Parameters.AddWithValue("@ShotAcc", formmcr.cmbshotacc.Text)
                        insertCommand.Parameters.AddWithValue("@Jump", formmcr.cmbjump.Text)
                        insertCommand.Parameters.AddWithValue("@Head", formmcr.cmbhead.Text)
                        insertCommand.Parameters.AddWithValue("@Technique", formmcr.cmbtechnique.Text)
                        insertCommand.Parameters.AddWithValue("@Dribble", formmcr.cmbdribble.Text)
                        insertCommand.Parameters.AddWithValue("@Curve", formmcr.cmbcurve.Text)
                        insertCommand.Parameters.AddWithValue("@Aggresive", formmcr.cmbaggression.Text)
                        insertCommand.Parameters.AddWithValue("@Response", formmcr.cmbresponse.Text)
                        insertCommand.Parameters.AddWithValue("@Link", formmcr.lbl_link.Text)
                        'insertCommand.Parameters.Add("@PhotoBlob", DbType.Binary).Value = photoBytes


                        insertCommand.ExecuteNonQuery()
                        'MessageBox.Show("Contacto agregado correctamente.")
                    End If



                End If
                connection.Close()
        End Using
        LoadContacts()
    End Sub

    Public Sub SKINCOLOUR()
        Try
            ' Simular apertura y cierre rápido con FileOpen
            Dim hairFilePath As String = My.Application.Info.DirectoryPath & "\pelo\pelo_" & indexcmbhair & ".bmp"
            Dim beardFilePath As String = My.Application.Info.DirectoryPath & "\barba\barba_" & indexcmbhairface & ".bmp"

            ' Abrir y cerrar archivo de pelo
            Try
                FileOpen(2, hairFilePath, OpenMode.Binary, OpenAccess.ReadWrite)
                ' Operaciones rápidas
            Finally
                FileClose(2)
            End Try
            formmcr.OpenFileDialog2.FileName = hairFilePath

            ' Abrir y cerrar archivo de barba
            Try
                FileOpen(1, beardFilePath, OpenMode.Binary, OpenAccess.ReadWrite)
                ' Operaciones rápidas
            Finally
                FileClose(1)
            End Try
            formmcr.OpenFileDialog3.FileName = beardFilePath

            ' Operaciones de pelo
            ident = indexcmbhaircolor
            Try
                FileOpen(2, hairFilePath, OpenMode.Binary, OpenAccess.ReadWrite)
                colorcabellopic()
            Finally
                FileClose(2)
            End Try
            formmcr.picapariencia.ImageLocation = hairFilePath

            ' Operaciones de colores de piel
            ident = indexcmbskikcolour
            Try
                FileOpen(2, hairFilePath, OpenMode.Binary, OpenAccess.ReadWrite)
                FileOpen(1, beardFilePath, OpenMode.Binary, OpenAccess.ReadWrite)
                skincolourpic()
                skincolourpic2()
            Finally
                FileClose(2)
                FileClose(1)
            End Try
            formmcr.picapariencia.ImageLocation = hairFilePath
            formmcr.picbarba.ImageLocation = beardFilePath

            ' Operaciones de barba
            ident = indexcmbhaircolourface
            Try
                FileOpen(1, beardFilePath, OpenMode.Binary, OpenAccess.ReadWrite)
                hairfacecolourpic()
            Finally
                FileClose(1)
            End Try
            formmcr.picapariencia.ImageLocation = hairFilePath
            formmcr.picbarba.ImageLocation = beardFilePath

        Catch ex As Exception
            ' Manejo de errores
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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


        If playerposition = "CB" Then COLORPOSITION = Color.FromArgb(45, 120, 220)
        If playerposition = "SB" Then COLORPOSITION = Color.FromArgb(0, 140, 200)
        If playerposition = "DH" Then COLORPOSITION = Color.FromArgb(70, 140, 70)
        If playerposition = "OH" Then COLORPOSITION = Color.FromArgb(80, 170, 90)
        If playerposition = "SH" Then COLORPOSITION = Color.FromArgb(80, 170, 90)
        If playerposition = "CF" Then COLORPOSITION = Color.FromArgb(190, 50, 50)
        If playerposition = "WG" Then COLORPOSITION = Color.FromArgb(210, 70, 70)
        If playerposition = "GK" Then COLORPOSITION = Color.FromArgb(185, 140, 40)
    End Sub


    Public Sub caracteristicas()

        FileGet(1, lectorByte, offsets + 1)

    End Sub
    Public Sub guardar()
        datograbar = aa
        FilePut(1, datograbar, offset1 + 1)
    End Sub
    Public Sub guardarstr()

        Dim borrarstr As Byte
        Dim countoffset As Integer
        countoffset = offset1

        borrarstr = "00"
        For w = 0 To sizeSTR
            FilePut(1, borrarstr, countoffset + 1)
            countoffset = countoffset + 1
        Next


        datograbarstr = aa
        FilePut(1, datograbarstr, offset1 + 1)


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
            FilePut(1, colorgrabar3, offsetini2)
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
            FilePut(1, colorgrabar4, offsetini3)
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


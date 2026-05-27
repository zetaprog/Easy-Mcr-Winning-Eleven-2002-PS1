Public Class FrmFormation

    Dim izquierda As Integer
    Dim alto As Integer
    Dim activamovemouse As Integer
    Private Sub FrmFormation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FrmMCR.OpenFileDialog1.FileName = My.Application.Info.DirectoryPath & "\database.mcr"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24911
        Dim SF As Int32 = 0

        a = SF
        algoritmo3()
        guardar()
        FileClose()

        Button16.BackColor = Color.Red
        Button17.BackColor = Color.WhiteSmoke
        Button18.BackColor = Color.WhiteSmoke
        Button19.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke
        Button21.BackColor = Color.WhiteSmoke
        Button20.BackColor = Color.WhiteSmoke
        Button27.BackColor = Color.WhiteSmoke
        Button26.BackColor = Color.WhiteSmoke
        Button25.BackColor = Color.WhiteSmoke





    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24911
        Dim SF As Int32 = 1

        a = SF
        algoritmo3()
        guardar()
        FileClose()

        Button16.BackColor = Color.WhiteSmoke
        Button17.BackColor = Color.Red
        Button18.BackColor = Color.WhiteSmoke
        Button19.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke
        Button21.BackColor = Color.WhiteSmoke
        Button20.BackColor = Color.WhiteSmoke
        Button27.BackColor = Color.WhiteSmoke
        Button26.BackColor = Color.WhiteSmoke
        Button25.BackColor = Color.WhiteSmoke

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24911
        Dim SF As Int32 = 2

        a = SF
        algoritmo3()
        guardar()
        FileClose()

        Button16.BackColor = Color.WhiteSmoke
        Button17.BackColor = Color.WhiteSmoke
        Button18.BackColor = Color.Red
        Button19.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke
        Button21.BackColor = Color.WhiteSmoke
        Button20.BackColor = Color.WhiteSmoke
        Button27.BackColor = Color.WhiteSmoke
        Button26.BackColor = Color.WhiteSmoke
        Button25.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24911
        Dim SF As Int32 = 3

        a = SF
        algoritmo3()
        guardar()
        FileClose()
        Button16.BackColor = Color.WhiteSmoke
        Button17.BackColor = Color.WhiteSmoke
        Button18.BackColor = Color.WhiteSmoke
        Button19.BackColor = Color.Red
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke
        Button21.BackColor = Color.WhiteSmoke
        Button20.BackColor = Color.WhiteSmoke
        Button27.BackColor = Color.WhiteSmoke
        Button26.BackColor = Color.WhiteSmoke
        Button25.BackColor = Color.WhiteSmoke

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24911
        Dim SF As Int32 = 4

        a = SF
        algoritmo3()
        guardar()
        FileClose()
        Button16.BackColor = Color.WhiteSmoke
        Button17.BackColor = Color.WhiteSmoke
        Button18.BackColor = Color.WhiteSmoke
        Button19.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.Red
        Button22.BackColor = Color.WhiteSmoke
        Button21.BackColor = Color.WhiteSmoke
        Button20.BackColor = Color.WhiteSmoke
        Button27.BackColor = Color.WhiteSmoke
        Button26.BackColor = Color.WhiteSmoke
        Button25.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24911
        Dim SF As Int32 = 5

        a = SF
        algoritmo3()
        guardar()
        FileClose()
        Button16.BackColor = Color.WhiteSmoke
        Button17.BackColor = Color.WhiteSmoke
        Button18.BackColor = Color.WhiteSmoke
        Button19.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.Red
        Button21.BackColor = Color.WhiteSmoke
        Button20.BackColor = Color.WhiteSmoke
        Button27.BackColor = Color.WhiteSmoke
        Button26.BackColor = Color.WhiteSmoke
        Button25.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24911
        Dim SF As Int32 = 6

        a = SF
        algoritmo3()
        guardar()
        FileClose()
        Button16.BackColor = Color.WhiteSmoke
        Button17.BackColor = Color.WhiteSmoke
        Button18.BackColor = Color.WhiteSmoke
        Button19.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke
        Button21.BackColor = Color.Red
        Button20.BackColor = Color.WhiteSmoke
        Button27.BackColor = Color.WhiteSmoke
        Button26.BackColor = Color.WhiteSmoke
        Button25.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24911
        Dim SF As Int32 = 7

        a = SF
        algoritmo3()
        guardar()
        FileClose()
        Button16.BackColor = Color.WhiteSmoke
        Button17.BackColor = Color.WhiteSmoke
        Button18.BackColor = Color.WhiteSmoke
        Button19.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke
        Button21.BackColor = Color.WhiteSmoke
        Button20.BackColor = Color.Red
        Button27.BackColor = Color.WhiteSmoke
        Button26.BackColor = Color.WhiteSmoke
        Button25.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24911
        Dim SF As Int32 = 8

        a = SF
        algoritmo3()
        guardar()
        FileClose()
        Button16.BackColor = Color.WhiteSmoke
        Button17.BackColor = Color.WhiteSmoke
        Button18.BackColor = Color.WhiteSmoke
        Button19.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke
        Button21.BackColor = Color.WhiteSmoke
        Button20.BackColor = Color.WhiteSmoke
        Button27.BackColor = Color.Red
        Button26.BackColor = Color.WhiteSmoke
        Button25.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24911
        Dim SF As Int32 = 9

        a = SF
        algoritmo3()
        guardar()
        FileClose()
        Button16.BackColor = Color.WhiteSmoke
        Button17.BackColor = Color.WhiteSmoke
        Button18.BackColor = Color.WhiteSmoke
        Button19.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke
        Button21.BackColor = Color.WhiteSmoke
        Button20.BackColor = Color.WhiteSmoke
        Button27.BackColor = Color.WhiteSmoke
        Button26.BackColor = Color.Red
        Button25.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24911
        Dim SF As Int32 = 10

        a = SF
        algoritmo3()
        guardar()
        FileClose()
        Button16.BackColor = Color.WhiteSmoke
        Button17.BackColor = Color.WhiteSmoke
        Button18.BackColor = Color.WhiteSmoke
        Button19.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke
        Button21.BackColor = Color.WhiteSmoke
        Button20.BackColor = Color.WhiteSmoke
        Button27.BackColor = Color.WhiteSmoke
        Button26.BackColor = Color.WhiteSmoke
        Button25.BackColor = Color.Red
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24896
        Dim LF As Int32 = 1

        a = LF
        algoritmo3()
        guardar()
        FileClose()

        Button37.BackColor = Color.WhiteSmoke
        Button36.BackColor = Color.Red
        Button35.BackColor = Color.WhiteSmoke
        Button34.BackColor = Color.WhiteSmoke
        Button33.BackColor = Color.WhiteSmoke
        Button32.BackColor = Color.WhiteSmoke
        Button31.BackColor = Color.WhiteSmoke
        Button30.BackColor = Color.WhiteSmoke
        Button29.BackColor = Color.WhiteSmoke
        Button28.BackColor = Color.WhiteSmoke
        Button24.BackColor = Color.WhiteSmoke



    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24896
        Dim LF As Int32 = 2

        a = LF
        algoritmo3()
        guardar()
        FileClose()

        Button37.BackColor = Color.White
        Button36.BackColor = Color.WhiteSmoke
        Button35.BackColor = Color.Red
        Button34.BackColor = Color.WhiteSmoke
        Button33.BackColor = Color.WhiteSmoke
        Button32.BackColor = Color.WhiteSmoke
        Button31.BackColor = Color.WhiteSmoke
        Button30.BackColor = Color.WhiteSmoke
        Button29.BackColor = Color.WhiteSmoke
        Button28.BackColor = Color.WhiteSmoke
        Button24.BackColor = Color.WhiteSmoke



    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24896
        Dim LF As Int32 = 3

        a = LF
        algoritmo3()
        guardar()
        FileClose()

        Button37.BackColor = Color.White
        Button36.BackColor = Color.WhiteSmoke
        Button35.BackColor = Color.WhiteSmoke
        Button34.BackColor = Color.Red
        Button33.BackColor = Color.WhiteSmoke
        Button32.BackColor = Color.WhiteSmoke
        Button31.BackColor = Color.WhiteSmoke
        Button30.BackColor = Color.WhiteSmoke
        Button29.BackColor = Color.WhiteSmoke
        Button28.BackColor = Color.WhiteSmoke
        Button24.BackColor = Color.WhiteSmoke

    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24896
        Dim LF As Int32 = 4

        a = LF
        algoritmo3()
        guardar()
        FileClose()

        Button37.BackColor = Color.White
        Button36.BackColor = Color.WhiteSmoke
        Button35.BackColor = Color.WhiteSmoke
        Button34.BackColor = Color.WhiteSmoke
        Button33.BackColor = Color.Red
        Button32.BackColor = Color.WhiteSmoke
        Button31.BackColor = Color.WhiteSmoke
        Button30.BackColor = Color.WhiteSmoke
        Button29.BackColor = Color.WhiteSmoke
        Button28.BackColor = Color.WhiteSmoke
        Button24.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24896
        Dim LF As Int32 = 5

        a = LF
        algoritmo3()
        guardar()
        FileClose()

        Button37.BackColor = Color.White
        Button36.BackColor = Color.WhiteSmoke
        Button35.BackColor = Color.WhiteSmoke
        Button34.BackColor = Color.WhiteSmoke
        Button33.BackColor = Color.WhiteSmoke
        Button32.BackColor = Color.Red
        Button31.BackColor = Color.WhiteSmoke
        Button30.BackColor = Color.WhiteSmoke
        Button29.BackColor = Color.WhiteSmoke
        Button28.BackColor = Color.WhiteSmoke
        Button24.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24896
        Dim LF As Int32 = 6

        a = LF
        algoritmo3()
        guardar()
        FileClose()

        Button37.BackColor = Color.White
        Button36.BackColor = Color.WhiteSmoke
        Button35.BackColor = Color.WhiteSmoke
        Button34.BackColor = Color.WhiteSmoke
        Button33.BackColor = Color.WhiteSmoke
        Button32.BackColor = Color.WhiteSmoke
        Button31.BackColor = Color.Red
        Button30.BackColor = Color.WhiteSmoke
        Button29.BackColor = Color.WhiteSmoke
        Button28.BackColor = Color.WhiteSmoke
        Button24.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24896
        Dim LF As Int32 = 7

        a = LF
        algoritmo3()
        guardar()
        FileClose()

        Button37.BackColor = Color.White
        Button36.BackColor = Color.WhiteSmoke
        Button35.BackColor = Color.WhiteSmoke
        Button34.BackColor = Color.WhiteSmoke
        Button33.BackColor = Color.WhiteSmoke
        Button32.BackColor = Color.WhiteSmoke
        Button31.BackColor = Color.WhiteSmoke
        Button30.BackColor = Color.Red
        Button29.BackColor = Color.WhiteSmoke
        Button28.BackColor = Color.WhiteSmoke
        Button24.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24896
        Dim LF As Int32 = 8

        a = LF
        algoritmo3()
        guardar()
        FileClose()

        Button37.BackColor = Color.White
        Button36.BackColor = Color.WhiteSmoke
        Button35.BackColor = Color.WhiteSmoke
        Button34.BackColor = Color.WhiteSmoke
        Button33.BackColor = Color.WhiteSmoke
        Button32.BackColor = Color.WhiteSmoke
        Button31.BackColor = Color.WhiteSmoke
        Button30.BackColor = Color.WhiteSmoke
        Button29.BackColor = Color.Red
        Button28.BackColor = Color.WhiteSmoke
        Button24.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24896
        Dim LF As Int32 = 9

        a = LF
        algoritmo3()
        guardar()
        FileClose()

        Button37.BackColor = Color.White
        Button36.BackColor = Color.WhiteSmoke
        Button35.BackColor = Color.WhiteSmoke
        Button34.BackColor = Color.WhiteSmoke
        Button33.BackColor = Color.WhiteSmoke
        Button32.BackColor = Color.WhiteSmoke
        Button31.BackColor = Color.WhiteSmoke
        Button30.BackColor = Color.WhiteSmoke
        Button29.BackColor = Color.WhiteSmoke
        Button28.BackColor = Color.Red
        Button24.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24896
        Dim LF As Int32 = 10

        a = LF
        algoritmo3()
        guardar()
        FileClose()

        Button37.BackColor = Color.White
        Button36.BackColor = Color.WhiteSmoke
        Button35.BackColor = Color.WhiteSmoke
        Button34.BackColor = Color.WhiteSmoke
        Button33.BackColor = Color.WhiteSmoke
        Button32.BackColor = Color.WhiteSmoke
        Button31.BackColor = Color.WhiteSmoke
        Button30.BackColor = Color.WhiteSmoke
        Button29.BackColor = Color.WhiteSmoke
        Button28.BackColor = Color.WhiteSmoke
        Button24.BackColor = Color.Red
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24866
        Dim RC As Int32 = 0

        a = RC
        algoritmo3()
        guardar()
        FileClose()

        Button48.BackColor = Color.Red
        Button47.BackColor = Color.WhiteSmoke
        Button46.BackColor = Color.WhiteSmoke
        Button45.BackColor = Color.WhiteSmoke
        Button44.BackColor = Color.WhiteSmoke
        Button43.BackColor = Color.WhiteSmoke
        Button42.BackColor = Color.WhiteSmoke
        Button41.BackColor = Color.WhiteSmoke
        Button40.BackColor = Color.WhiteSmoke
        Button39.BackColor = Color.WhiteSmoke
        Button38.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24866
        Dim RC As Int32 = 1

        a = RC
        algoritmo3()
        guardar()
        FileClose()

        Button48.BackColor = Color.WhiteSmoke
        Button47.BackColor = Color.Red
        Button46.BackColor = Color.WhiteSmoke
        Button45.BackColor = Color.WhiteSmoke
        Button44.BackColor = Color.WhiteSmoke
        Button43.BackColor = Color.WhiteSmoke
        Button42.BackColor = Color.WhiteSmoke
        Button41.BackColor = Color.WhiteSmoke
        Button40.BackColor = Color.WhiteSmoke
        Button39.BackColor = Color.WhiteSmoke
        Button38.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24866
        Dim RC As Int32 = 2

        a = RC
        algoritmo3()
        guardar()
        FileClose()

        Button48.BackColor = Color.WhiteSmoke
        Button47.BackColor = Color.WhiteSmoke
        Button46.BackColor = Color.Red
        Button45.BackColor = Color.WhiteSmoke
        Button44.BackColor = Color.WhiteSmoke
        Button43.BackColor = Color.WhiteSmoke
        Button42.BackColor = Color.WhiteSmoke
        Button41.BackColor = Color.WhiteSmoke
        Button40.BackColor = Color.WhiteSmoke
        Button39.BackColor = Color.WhiteSmoke
        Button38.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24866
        Dim RC As Int32 = 3

        a = RC
        algoritmo3()
        guardar()
        FileClose()

        Button48.BackColor = Color.WhiteSmoke
        Button47.BackColor = Color.WhiteSmoke
        Button46.BackColor = Color.WhiteSmoke
        Button45.BackColor = Color.Red
        Button44.BackColor = Color.WhiteSmoke
        Button43.BackColor = Color.WhiteSmoke
        Button42.BackColor = Color.WhiteSmoke
        Button41.BackColor = Color.WhiteSmoke
        Button40.BackColor = Color.WhiteSmoke
        Button39.BackColor = Color.WhiteSmoke
        Button38.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24866
        Dim RC As Int32 = 4

        a = RC
        algoritmo3()
        guardar()
        FileClose()

        Button48.BackColor = Color.WhiteSmoke
        Button47.BackColor = Color.WhiteSmoke
        Button46.BackColor = Color.WhiteSmoke
        Button45.BackColor = Color.WhiteSmoke
        Button44.BackColor = Color.Red
        Button43.BackColor = Color.WhiteSmoke
        Button42.BackColor = Color.WhiteSmoke
        Button41.BackColor = Color.WhiteSmoke
        Button40.BackColor = Color.WhiteSmoke
        Button39.BackColor = Color.WhiteSmoke
        Button38.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24866
        Dim RC As Int32 = 5

        a = RC
        algoritmo3()
        guardar()
        FileClose()

        Button48.BackColor = Color.WhiteSmoke
        Button47.BackColor = Color.WhiteSmoke
        Button46.BackColor = Color.WhiteSmoke
        Button45.BackColor = Color.WhiteSmoke
        Button44.BackColor = Color.WhiteSmoke
        Button43.BackColor = Color.Red
        Button42.BackColor = Color.WhiteSmoke
        Button41.BackColor = Color.WhiteSmoke
        Button40.BackColor = Color.WhiteSmoke
        Button39.BackColor = Color.WhiteSmoke
        Button38.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24866
        Dim RC As Int32 = 6

        a = RC
        algoritmo3()
        guardar()
        FileClose()

        Button48.BackColor = Color.WhiteSmoke
        Button47.BackColor = Color.WhiteSmoke
        Button46.BackColor = Color.WhiteSmoke
        Button45.BackColor = Color.WhiteSmoke
        Button44.BackColor = Color.WhiteSmoke
        Button43.BackColor = Color.WhiteSmoke
        Button42.BackColor = Color.Red
        Button41.BackColor = Color.WhiteSmoke
        Button40.BackColor = Color.WhiteSmoke
        Button39.BackColor = Color.WhiteSmoke
        Button38.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24866
        Dim RC As Int32 = 7

        a = RC
        algoritmo3()
        guardar()
        FileClose()

        Button48.BackColor = Color.WhiteSmoke
        Button47.BackColor = Color.WhiteSmoke
        Button46.BackColor = Color.WhiteSmoke
        Button45.BackColor = Color.WhiteSmoke
        Button44.BackColor = Color.WhiteSmoke
        Button43.BackColor = Color.WhiteSmoke
        Button42.BackColor = Color.WhiteSmoke
        Button41.BackColor = Color.Red
        Button40.BackColor = Color.WhiteSmoke
        Button39.BackColor = Color.WhiteSmoke
        Button38.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24866
        Dim RC As Int32 = 8

        a = RC
        algoritmo3()
        guardar()
        FileClose()

        Button48.BackColor = Color.WhiteSmoke
        Button47.BackColor = Color.WhiteSmoke
        Button46.BackColor = Color.WhiteSmoke
        Button45.BackColor = Color.WhiteSmoke
        Button44.BackColor = Color.WhiteSmoke
        Button43.BackColor = Color.WhiteSmoke
        Button42.BackColor = Color.WhiteSmoke
        Button41.BackColor = Color.WhiteSmoke
        Button40.BackColor = Color.Red
        Button39.BackColor = Color.WhiteSmoke
        Button38.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24866
        Dim RC As Int32 = 9

        a = RC
        algoritmo3()
        guardar()
        FileClose()

        Button48.BackColor = Color.WhiteSmoke
        Button47.BackColor = Color.WhiteSmoke
        Button46.BackColor = Color.WhiteSmoke
        Button45.BackColor = Color.WhiteSmoke
        Button44.BackColor = Color.WhiteSmoke
        Button43.BackColor = Color.WhiteSmoke
        Button42.BackColor = Color.WhiteSmoke
        Button41.BackColor = Color.WhiteSmoke
        Button40.BackColor = Color.WhiteSmoke
        Button39.BackColor = Color.Red
        Button38.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24866
        Dim RC As Int32 = 10

        a = RC
        algoritmo3()
        guardar()
        FileClose()

        Button48.BackColor = Color.WhiteSmoke
        Button47.BackColor = Color.WhiteSmoke
        Button46.BackColor = Color.WhiteSmoke
        Button45.BackColor = Color.WhiteSmoke
        Button44.BackColor = Color.WhiteSmoke
        Button43.BackColor = Color.WhiteSmoke
        Button42.BackColor = Color.WhiteSmoke
        Button41.BackColor = Color.WhiteSmoke
        Button40.BackColor = Color.WhiteSmoke
        Button39.BackColor = Color.WhiteSmoke
        Button38.BackColor = Color.Red
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24851
        Dim LC As Int32 = 0

        a = LC
        algoritmo3()
        guardar()
        FileClose()

        Button59.BackColor = Color.Red
        Button58.BackColor = Color.WhiteSmoke
        Button57.BackColor = Color.WhiteSmoke
        Button56.BackColor = Color.WhiteSmoke
        Button55.BackColor = Color.WhiteSmoke
        Button54.BackColor = Color.WhiteSmoke
        Button53.BackColor = Color.WhiteSmoke
        Button52.BackColor = Color.WhiteSmoke
        Button51.BackColor = Color.WhiteSmoke
        Button50.BackColor = Color.WhiteSmoke
        Button49.BackColor = Color.WhiteSmoke
    End Sub


    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24851
        Dim LC As Int32 = 1

        a = LC
        algoritmo3()
        guardar()
        FileClose()

        Button59.BackColor = Color.WhiteSmoke
        Button58.BackColor = Color.Red
        Button57.BackColor = Color.WhiteSmoke
        Button56.BackColor = Color.WhiteSmoke
        Button55.BackColor = Color.WhiteSmoke
        Button54.BackColor = Color.WhiteSmoke
        Button53.BackColor = Color.WhiteSmoke
        Button52.BackColor = Color.WhiteSmoke
        Button51.BackColor = Color.WhiteSmoke
        Button50.BackColor = Color.WhiteSmoke
        Button49.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24851
        Dim LC As Int32 = 2

        a = LC
        algoritmo3()
        guardar()
        FileClose()

        Button59.BackColor = Color.WhiteSmoke
        Button58.BackColor = Color.WhiteSmoke
        Button57.BackColor = Color.Red
        Button56.BackColor = Color.WhiteSmoke
        Button55.BackColor = Color.WhiteSmoke
        Button54.BackColor = Color.WhiteSmoke
        Button53.BackColor = Color.WhiteSmoke
        Button52.BackColor = Color.WhiteSmoke
        Button51.BackColor = Color.WhiteSmoke
        Button50.BackColor = Color.WhiteSmoke
        Button49.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24851
        Dim LC As Int32 = 3

        a = LC
        algoritmo3()
        guardar()
        FileClose()

        Button59.BackColor = Color.WhiteSmoke
        Button58.BackColor = Color.WhiteSmoke
        Button57.BackColor = Color.WhiteSmoke
        Button56.BackColor = Color.Red
        Button55.BackColor = Color.WhiteSmoke
        Button54.BackColor = Color.WhiteSmoke
        Button53.BackColor = Color.WhiteSmoke
        Button52.BackColor = Color.WhiteSmoke
        Button51.BackColor = Color.WhiteSmoke
        Button50.BackColor = Color.WhiteSmoke
        Button49.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24851
        Dim LC As Int32 = 4

        a = LC
        algoritmo3()
        guardar()
        FileClose()

        Button59.BackColor = Color.WhiteSmoke
        Button58.BackColor = Color.WhiteSmoke
        Button57.BackColor = Color.WhiteSmoke
        Button56.BackColor = Color.WhiteSmoke
        Button55.BackColor = Color.Red
        Button54.BackColor = Color.WhiteSmoke
        Button53.BackColor = Color.WhiteSmoke
        Button52.BackColor = Color.WhiteSmoke
        Button51.BackColor = Color.WhiteSmoke
        Button50.BackColor = Color.WhiteSmoke
        Button49.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24851
        Dim LC As Int32 = 5

        a = LC
        algoritmo3()
        guardar()
        FileClose()

        Button59.BackColor = Color.WhiteSmoke
        Button58.BackColor = Color.WhiteSmoke
        Button57.BackColor = Color.WhiteSmoke
        Button56.BackColor = Color.WhiteSmoke
        Button55.BackColor = Color.WhiteSmoke
        Button54.BackColor = Color.Red
        Button53.BackColor = Color.WhiteSmoke
        Button52.BackColor = Color.WhiteSmoke
        Button51.BackColor = Color.WhiteSmoke
        Button50.BackColor = Color.WhiteSmoke
        Button49.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24851
        Dim LC As Int32 = 6

        a = LC
        algoritmo3()
        guardar()
        FileClose()

        Button59.BackColor = Color.WhiteSmoke
        Button58.BackColor = Color.WhiteSmoke
        Button57.BackColor = Color.WhiteSmoke
        Button56.BackColor = Color.WhiteSmoke
        Button55.BackColor = Color.WhiteSmoke
        Button54.BackColor = Color.WhiteSmoke
        Button53.BackColor = Color.Red
        Button52.BackColor = Color.WhiteSmoke
        Button51.BackColor = Color.WhiteSmoke
        Button50.BackColor = Color.WhiteSmoke
        Button49.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24851
        Dim LC As Int32 = 7

        a = LC
        algoritmo3()
        guardar()
        FileClose()

        Button59.BackColor = Color.WhiteSmoke
        Button58.BackColor = Color.WhiteSmoke
        Button57.BackColor = Color.WhiteSmoke
        Button56.BackColor = Color.WhiteSmoke
        Button55.BackColor = Color.WhiteSmoke
        Button54.BackColor = Color.WhiteSmoke
        Button53.BackColor = Color.WhiteSmoke
        Button52.BackColor = Color.Red
        Button51.BackColor = Color.WhiteSmoke
        Button50.BackColor = Color.WhiteSmoke
        Button49.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24851
        Dim LC As Int32 = 8

        a = LC
        algoritmo3()
        guardar()
        FileClose()

        Button59.BackColor = Color.WhiteSmoke
        Button58.BackColor = Color.WhiteSmoke
        Button57.BackColor = Color.WhiteSmoke
        Button56.BackColor = Color.WhiteSmoke
        Button55.BackColor = Color.WhiteSmoke
        Button54.BackColor = Color.WhiteSmoke
        Button53.BackColor = Color.WhiteSmoke
        Button52.BackColor = Color.WhiteSmoke
        Button51.BackColor = Color.Red
        Button50.BackColor = Color.WhiteSmoke
        Button49.BackColor = Color.WhiteSmoke
    End Sub


    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24851
        Dim LC As Int32 = 9

        a = LC
        algoritmo3()
        guardar()
        FileClose()

        Button59.BackColor = Color.WhiteSmoke
        Button58.BackColor = Color.WhiteSmoke
        Button57.BackColor = Color.WhiteSmoke
        Button56.BackColor = Color.WhiteSmoke
        Button55.BackColor = Color.WhiteSmoke
        Button54.BackColor = Color.WhiteSmoke
        Button53.BackColor = Color.WhiteSmoke
        Button52.BackColor = Color.WhiteSmoke
        Button51.BackColor = Color.WhiteSmoke
        Button50.BackColor = Color.Red
        Button49.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24851
        Dim LC As Int32 = 10

        a = LC
        algoritmo3()
        guardar()
        FileClose()

        Button59.BackColor = Color.WhiteSmoke
        Button58.BackColor = Color.WhiteSmoke
        Button57.BackColor = Color.WhiteSmoke
        Button56.BackColor = Color.WhiteSmoke
        Button55.BackColor = Color.WhiteSmoke
        Button54.BackColor = Color.WhiteSmoke
        Button53.BackColor = Color.WhiteSmoke
        Button52.BackColor = Color.WhiteSmoke
        Button51.BackColor = Color.WhiteSmoke
        Button50.BackColor = Color.WhiteSmoke
        Button49.BackColor = Color.Red
    End Sub

    Private Sub Button70_Click(sender As Object, e As EventArgs) Handles Button70.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24881
        Dim PK As Int32 = 0

        a = PK
        algoritmo3()
        guardar()
        FileClose()

        Button70.BackColor = Color.Red
        Button69.BackColor = Color.WhiteSmoke
        Button68.BackColor = Color.WhiteSmoke
        Button67.BackColor = Color.WhiteSmoke
        Button66.BackColor = Color.WhiteSmoke
        Button65.BackColor = Color.WhiteSmoke
        Button64.BackColor = Color.WhiteSmoke
        Button63.BackColor = Color.WhiteSmoke
        Button62.BackColor = Color.WhiteSmoke
        Button61.BackColor = Color.WhiteSmoke
        Button60.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button69_Click(sender As Object, e As EventArgs) Handles Button69.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24881
        Dim PK As Int32 = 1

        a = PK
        algoritmo3()
        guardar()
        FileClose()

        Button70.BackColor = Color.WhiteSmoke
        Button69.BackColor = Color.Red
        Button68.BackColor = Color.WhiteSmoke
        Button67.BackColor = Color.WhiteSmoke
        Button66.BackColor = Color.WhiteSmoke
        Button65.BackColor = Color.WhiteSmoke
        Button64.BackColor = Color.WhiteSmoke
        Button63.BackColor = Color.WhiteSmoke
        Button62.BackColor = Color.WhiteSmoke
        Button61.BackColor = Color.WhiteSmoke
        Button60.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button68_Click(sender As Object, e As EventArgs) Handles Button68.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24881
        Dim PK As Int32 = 2

        a = PK
        algoritmo3()
        guardar()
        FileClose()

        Button70.BackColor = Color.WhiteSmoke
        Button69.BackColor = Color.WhiteSmoke
        Button68.BackColor = Color.Red
        Button67.BackColor = Color.WhiteSmoke
        Button66.BackColor = Color.WhiteSmoke
        Button65.BackColor = Color.WhiteSmoke
        Button64.BackColor = Color.WhiteSmoke
        Button63.BackColor = Color.WhiteSmoke
        Button62.BackColor = Color.WhiteSmoke
        Button61.BackColor = Color.WhiteSmoke
        Button60.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24881
        Dim PK As Int32 = 3

        a = PK
        algoritmo3()
        guardar()
        FileClose()

        Button70.BackColor = Color.WhiteSmoke
        Button69.BackColor = Color.WhiteSmoke
        Button68.BackColor = Color.WhiteSmoke
        Button67.BackColor = Color.Red
        Button66.BackColor = Color.WhiteSmoke
        Button65.BackColor = Color.WhiteSmoke
        Button64.BackColor = Color.WhiteSmoke
        Button63.BackColor = Color.WhiteSmoke
        Button62.BackColor = Color.WhiteSmoke
        Button61.BackColor = Color.WhiteSmoke
        Button60.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24881
        Dim PK As Int32 = 4

        a = PK
        algoritmo3()
        guardar()
        FileClose()

        Button70.BackColor = Color.WhiteSmoke
        Button69.BackColor = Color.WhiteSmoke
        Button68.BackColor = Color.WhiteSmoke
        Button67.BackColor = Color.WhiteSmoke
        Button66.BackColor = Color.Red
        Button65.BackColor = Color.WhiteSmoke
        Button64.BackColor = Color.WhiteSmoke
        Button63.BackColor = Color.WhiteSmoke
        Button62.BackColor = Color.WhiteSmoke
        Button61.BackColor = Color.WhiteSmoke
        Button60.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24881
        Dim PK As Int32 = 5

        a = PK
        algoritmo3()
        guardar()
        FileClose()

        Button70.BackColor = Color.WhiteSmoke
        Button69.BackColor = Color.WhiteSmoke
        Button68.BackColor = Color.WhiteSmoke
        Button67.BackColor = Color.WhiteSmoke
        Button66.BackColor = Color.WhiteSmoke
        Button65.BackColor = Color.Red
        Button64.BackColor = Color.WhiteSmoke
        Button63.BackColor = Color.WhiteSmoke
        Button62.BackColor = Color.WhiteSmoke
        Button61.BackColor = Color.WhiteSmoke
        Button60.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24881
        Dim PK As Int32 = 6

        a = PK
        algoritmo3()
        guardar()
        FileClose()

        Button70.BackColor = Color.WhiteSmoke
        Button69.BackColor = Color.WhiteSmoke
        Button68.BackColor = Color.WhiteSmoke
        Button67.BackColor = Color.WhiteSmoke
        Button66.BackColor = Color.WhiteSmoke
        Button65.BackColor = Color.WhiteSmoke
        Button64.BackColor = Color.Red
        Button63.BackColor = Color.WhiteSmoke
        Button62.BackColor = Color.WhiteSmoke
        Button61.BackColor = Color.WhiteSmoke
        Button60.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24881
        Dim PK As Int32 = 7

        a = PK
        algoritmo3()
        guardar()
        FileClose()

        Button70.BackColor = Color.WhiteSmoke
        Button69.BackColor = Color.WhiteSmoke
        Button68.BackColor = Color.WhiteSmoke
        Button67.BackColor = Color.WhiteSmoke
        Button66.BackColor = Color.WhiteSmoke
        Button65.BackColor = Color.WhiteSmoke
        Button64.BackColor = Color.WhiteSmoke
        Button63.BackColor = Color.Red
        Button62.BackColor = Color.WhiteSmoke
        Button61.BackColor = Color.WhiteSmoke
        Button60.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24881
        Dim PK As Int32 = 8

        a = PK
        algoritmo3()
        guardar()
        FileClose()

        Button70.BackColor = Color.WhiteSmoke
        Button69.BackColor = Color.WhiteSmoke
        Button68.BackColor = Color.WhiteSmoke
        Button67.BackColor = Color.WhiteSmoke
        Button66.BackColor = Color.WhiteSmoke
        Button65.BackColor = Color.WhiteSmoke
        Button64.BackColor = Color.WhiteSmoke
        Button63.BackColor = Color.WhiteSmoke
        Button62.BackColor = Color.Red
        Button61.BackColor = Color.WhiteSmoke
        Button60.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24881
        Dim PK As Int32 = 9

        a = PK
        algoritmo3()
        guardar()
        FileClose()

        Button70.BackColor = Color.WhiteSmoke
        Button69.BackColor = Color.WhiteSmoke
        Button68.BackColor = Color.WhiteSmoke
        Button67.BackColor = Color.WhiteSmoke
        Button66.BackColor = Color.WhiteSmoke
        Button65.BackColor = Color.WhiteSmoke
        Button64.BackColor = Color.WhiteSmoke
        Button63.BackColor = Color.WhiteSmoke
        Button62.BackColor = Color.WhiteSmoke
        Button61.BackColor = Color.Red
        Button60.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24881
        Dim PK As Int32 = 10

        a = PK
        algoritmo3()
        guardar()
        FileClose()

        Button70.BackColor = Color.WhiteSmoke
        Button69.BackColor = Color.WhiteSmoke
        Button68.BackColor = Color.WhiteSmoke
        Button67.BackColor = Color.WhiteSmoke
        Button66.BackColor = Color.WhiteSmoke
        Button65.BackColor = Color.WhiteSmoke
        Button64.BackColor = Color.WhiteSmoke
        Button63.BackColor = Color.WhiteSmoke
        Button62.BackColor = Color.WhiteSmoke
        Button61.BackColor = Color.WhiteSmoke
        Button60.BackColor = Color.Red
    End Sub

    Private Sub Button81_Click(sender As Object, e As EventArgs) Handles Button81.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 25856
        Dim CP As Int32 = 0

        a = CP
        algoritmo3()
        guardar()
        FileClose()

        Button81.BackColor = Color.Red
        Button80.BackColor = Color.WhiteSmoke
        Button79.BackColor = Color.WhiteSmoke
        Button78.BackColor = Color.WhiteSmoke
        Button77.BackColor = Color.WhiteSmoke
        Button76.BackColor = Color.WhiteSmoke
        Button75.BackColor = Color.WhiteSmoke
        Button74.BackColor = Color.WhiteSmoke
        Button73.BackColor = Color.WhiteSmoke
        Button72.BackColor = Color.WhiteSmoke
        Button71.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button80_Click(sender As Object, e As EventArgs) Handles Button80.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 25856
        Dim CP As Int32 = 1

        a = CP
        algoritmo3()
        guardar()
        FileClose()

        Button81.BackColor = Color.WhiteSmoke
        Button80.BackColor = Color.Red
        Button79.BackColor = Color.WhiteSmoke
        Button78.BackColor = Color.WhiteSmoke
        Button77.BackColor = Color.WhiteSmoke
        Button76.BackColor = Color.WhiteSmoke
        Button75.BackColor = Color.WhiteSmoke
        Button74.BackColor = Color.WhiteSmoke
        Button73.BackColor = Color.WhiteSmoke
        Button72.BackColor = Color.WhiteSmoke
        Button71.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button79_Click(sender As Object, e As EventArgs) Handles Button79.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 25856
        Dim CP As Int32 = 2

        a = CP
        algoritmo3()
        guardar()
        FileClose()

        Button81.BackColor = Color.WhiteSmoke
        Button80.BackColor = Color.WhiteSmoke
        Button79.BackColor = Color.Red
        Button78.BackColor = Color.WhiteSmoke
        Button77.BackColor = Color.WhiteSmoke
        Button76.BackColor = Color.WhiteSmoke
        Button75.BackColor = Color.WhiteSmoke
        Button74.BackColor = Color.WhiteSmoke
        Button73.BackColor = Color.WhiteSmoke
        Button72.BackColor = Color.WhiteSmoke
        Button71.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button78_Click(sender As Object, e As EventArgs) Handles Button78.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 25856
        Dim CP As Int32 = 3

        a = CP
        algoritmo3()
        guardar()
        FileClose()

        Button81.BackColor = Color.WhiteSmoke
        Button80.BackColor = Color.WhiteSmoke
        Button79.BackColor = Color.WhiteSmoke
        Button78.BackColor = Color.Red
        Button77.BackColor = Color.WhiteSmoke
        Button76.BackColor = Color.WhiteSmoke
        Button75.BackColor = Color.WhiteSmoke
        Button74.BackColor = Color.WhiteSmoke
        Button73.BackColor = Color.WhiteSmoke
        Button72.BackColor = Color.WhiteSmoke
        Button71.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button77_Click(sender As Object, e As EventArgs) Handles Button77.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 25856
        Dim CP As Int32 = 4

        a = CP
        algoritmo3()
        guardar()
        FileClose()

        Button81.BackColor = Color.WhiteSmoke
        Button80.BackColor = Color.WhiteSmoke
        Button79.BackColor = Color.WhiteSmoke
        Button78.BackColor = Color.WhiteSmoke
        Button77.BackColor = Color.Red
        Button76.BackColor = Color.WhiteSmoke
        Button75.BackColor = Color.WhiteSmoke
        Button74.BackColor = Color.WhiteSmoke
        Button73.BackColor = Color.WhiteSmoke
        Button72.BackColor = Color.WhiteSmoke
        Button71.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button76_Click(sender As Object, e As EventArgs) Handles Button76.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 25856
        Dim CP As Int32 = 5

        a = CP
        algoritmo3()
        guardar()
        FileClose()

        Button81.BackColor = Color.WhiteSmoke
        Button80.BackColor = Color.WhiteSmoke
        Button79.BackColor = Color.WhiteSmoke
        Button78.BackColor = Color.WhiteSmoke
        Button77.BackColor = Color.WhiteSmoke
        Button76.BackColor = Color.Red
        Button75.BackColor = Color.WhiteSmoke
        Button74.BackColor = Color.WhiteSmoke
        Button73.BackColor = Color.WhiteSmoke
        Button72.BackColor = Color.WhiteSmoke
        Button71.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button75_Click(sender As Object, e As EventArgs) Handles Button75.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 25856
        Dim CP As Int32 = 6

        a = CP
        algoritmo3()
        guardar()
        FileClose()

        Button81.BackColor = Color.WhiteSmoke
        Button80.BackColor = Color.WhiteSmoke
        Button79.BackColor = Color.WhiteSmoke
        Button78.BackColor = Color.WhiteSmoke
        Button77.BackColor = Color.WhiteSmoke
        Button76.BackColor = Color.WhiteSmoke
        Button75.BackColor = Color.Red
        Button74.BackColor = Color.WhiteSmoke
        Button73.BackColor = Color.WhiteSmoke
        Button72.BackColor = Color.WhiteSmoke
        Button71.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button74_Click(sender As Object, e As EventArgs) Handles Button74.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 25856
        Dim CP As Int32 = 7

        a = CP
        algoritmo3()
        guardar()
        FileClose()

        Button81.BackColor = Color.WhiteSmoke
        Button80.BackColor = Color.WhiteSmoke
        Button79.BackColor = Color.WhiteSmoke
        Button78.BackColor = Color.WhiteSmoke
        Button77.BackColor = Color.WhiteSmoke
        Button76.BackColor = Color.WhiteSmoke
        Button75.BackColor = Color.WhiteSmoke
        Button74.BackColor = Color.Red
        Button73.BackColor = Color.WhiteSmoke
        Button72.BackColor = Color.WhiteSmoke
        Button71.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles Button73.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 25856
        Dim CP As Int32 = 8

        a = CP
        algoritmo3()
        guardar()
        FileClose()

        Button81.BackColor = Color.WhiteSmoke
        Button80.BackColor = Color.WhiteSmoke
        Button79.BackColor = Color.WhiteSmoke
        Button78.BackColor = Color.WhiteSmoke
        Button77.BackColor = Color.WhiteSmoke
        Button76.BackColor = Color.WhiteSmoke
        Button75.BackColor = Color.WhiteSmoke
        Button74.BackColor = Color.WhiteSmoke
        Button73.BackColor = Color.Red
        Button72.BackColor = Color.WhiteSmoke
        Button71.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button72_Click(sender As Object, e As EventArgs) Handles Button72.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 25856
        Dim CP As Int32 = 9

        a = CP
        algoritmo3()
        guardar()
        FileClose()

        Button81.BackColor = Color.WhiteSmoke
        Button80.BackColor = Color.WhiteSmoke
        Button79.BackColor = Color.WhiteSmoke
        Button78.BackColor = Color.WhiteSmoke
        Button77.BackColor = Color.WhiteSmoke
        Button76.BackColor = Color.WhiteSmoke
        Button75.BackColor = Color.WhiteSmoke
        Button74.BackColor = Color.WhiteSmoke
        Button73.BackColor = Color.WhiteSmoke
        Button72.BackColor = Color.Red
        Button71.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button71_Click(sender As Object, e As EventArgs) Handles Button71.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 25856
        Dim CP As Int32 = 10

        a = CP
        algoritmo3()
        guardar()
        FileClose()

        Button81.BackColor = Color.WhiteSmoke
        Button80.BackColor = Color.WhiteSmoke
        Button79.BackColor = Color.WhiteSmoke
        Button78.BackColor = Color.WhiteSmoke
        Button77.BackColor = Color.WhiteSmoke
        Button76.BackColor = Color.WhiteSmoke
        Button75.BackColor = Color.WhiteSmoke
        Button74.BackColor = Color.WhiteSmoke
        Button73.BackColor = Color.WhiteSmoke
        Button72.BackColor = Color.WhiteSmoke
        Button71.BackColor = Color.Red
    End Sub

    Private Sub LstFormation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstFormation.SelectedIndexChanged
        'STOCK
        If LstFormation.SelectedItem = "Stock" Then
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
            CbPlayer2.Text = "CB-R"
            CbPlayer3.Text = "CB-C"
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
            CbPlayer2.Text = "CB-R"
            CbPlayer3.Text = "CB-C"
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
            CbPlayer2.Text = "CB-R"
            CbPlayer3.Text = "CB-C"
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
            CbPlayer2.Text = "CB-R"
            CbPlayer3.Text = "CB-C"
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
            CbPlayer2.Text = "CB-R"
            CbPlayer3.Text = "CB-C"
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
            CbPlayer2.Text = "CB-R"
            CbPlayer3.Text = "CB-C"
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
            CbPlayer2.Text = "CB-R"
            CbPlayer3.Text = "CB-C"
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
            CbPlayer2.Text = "CB-R"
            CbPlayer3.Text = "CB-C"
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
            CbPlayer2.Text = "CB-R"
            CbPlayer3.Text = "CB-C"
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
            CbPlayer2.Text = "CB-R"
            CbPlayer3.Text = "CB-C"
            CbPlayer4.Text = "LB"
            CbPlayer5.Text = "RB"
            CbPlayer6.Text = "DH-L"
            CbPlayer7.Text = "DH-R"
            CbPlayer8.Text = "OH-C"
            CbPlayer9.Text = "CF-L"
            CbPlayer10.Text = "CF-R"
        End If
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

    Private Sub PicP2_Click(sender As Object, e As EventArgs) Handles PicP2.Click

    End Sub

    Private Sub btnsaveformation_Click(sender As Object, e As EventArgs) Handles btnsaveformation.Click
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)

        'posicionamiento x y 
        Dim player1x As Int32 = PicP1.Location.X / 8
        Dim player1y As Int32 = PicP1.Location.Y / 2
        offset1 = 25256
        a = player1x
        algoritmo3()
        guardar()

        offset1 = 25266
        a = player1y
        algoritmo3()
        guardar()

        Dim player2x As Int32 = PicP2.Location.X / 7
        Dim player2y As Int32 = PicP2.Location.Y / 2

        offset1 = 25257
        a = player2x
        algoritmo3()
        guardar()


        offset1 = 25267
        a = player2y
        algoritmo3()
        guardar()

        Dim player3x As Int32 = PicP3.Location.X / 7
        Dim player3y As Int32 = PicP3.Location.Y / 2

        offset1 = 25258
        a = player3x
        algoritmo3()
        guardar()


        offset1 = 25268
        a = player3y
        algoritmo3()
        guardar()

        Dim player4x As Int32 = PicP4.Location.X / 7
        Dim player4y As Int32 = PicP4.Location.Y / 2

        offset1 = 25259
        a = player4x
        algoritmo3()
        guardar()


        offset1 = 25269
        a = player4y
        algoritmo3()
        guardar()

        Dim player5x As Int32 = PicP5.Location.X / 7
        Dim player5y As Int32 = PicP5.Location.Y / 2

        offset1 = 25260
        a = player5x
        algoritmo3()
        guardar()


        offset1 = 25270
        a = player5y
        algoritmo3()
        guardar()

        Dim player6x As Int32 = PicP6.Location.X / 7
        Dim player6y As Int32 = PicP6.Location.Y / 2

        offset1 = 25261
        a = player6x
        algoritmo3()
        guardar()


        offset1 = 25271
        a = player6y
        algoritmo3()
        guardar()

        Dim player7x As Int32 = PicP7.Location.X / 7
        Dim player7y As Int32 = PicP7.Location.Y / 2

        offset1 = 25262
        a = player7x
        algoritmo3()
        guardar()


        offset1 = 25272
        a = player7y
        algoritmo3()
        guardar()

        Dim player8x As Int32 = PicP8.Location.X / 7
        Dim player8y As Int32 = PicP8.Location.Y / 2

        offset1 = 25263
        a = player8x
        algoritmo3()
        guardar()


        offset1 = 25273
        a = player8y
        algoritmo3()
        guardar()

        Dim player9x As Int32 = PicP9.Location.X / 7
        Dim player9y As Int32 = PicP9.Location.Y / 2

        offset1 = 25264
        a = player9x
        algoritmo3()
        guardar()


        offset1 = 25274
        a = player9y
        algoritmo3()
        guardar()

        Dim player10x As Int32 = PicP10.Location.X / 7
        Dim player10y As Int32 = PicP10.Location.Y / 2

        offset1 = 25265
        a = player10x
        algoritmo3()
        guardar()


        offset1 = 25275
        a = player10y
        algoritmo3()
        guardar()


        offset1 = 25557
        Dim posplayercancha1 As Int32 = cbplayer1.SelectedIndex + 2
        a = posplayercancha1
        algoritmo3()
        guardar()

        offset1 = 25558
        Dim posplayercancha2 As Int32 = CbPlayer2.SelectedIndex + 2
        a = posplayercancha2
        algoritmo3()
        guardar()

        offset1 = 25559
        Dim posplayercancha3 As Int32 = CbPlayer3.SelectedIndex + 2
        a = posplayercancha3
        algoritmo3()
        guardar()

        offset1 = 25560
        Dim posplayercancha4 As Int32 = CbPlayer4.SelectedIndex + 2
        a = posplayercancha4
        algoritmo3()
        guardar()

        offset1 = 25561
        Dim posplayercancha5 As Int32 = CbPlayer5.SelectedIndex + 2
        a = posplayercancha5
        algoritmo3()
        guardar()

        offset1 = 25562
        Dim posplayercancha6 As Int32 = CbPlayer6.SelectedIndex + 2
        a = posplayercancha6
        algoritmo3()
        guardar()

        offset1 = 25563
        Dim posplayercancha7 As Int32 = CbPlayer7.SelectedIndex + 2
        a = posplayercancha7
        algoritmo3()
        guardar()


        offset1 = 25564
        Dim posplayercancha8 As Int32 = CbPlayer8.SelectedIndex + 2
        a = posplayercancha8
        algoritmo3()
        guardar()

        offset1 = 25565
        Dim posplayercancha9 As Int32 = CbPlayer9.SelectedIndex + 2
        a = posplayercancha9
        algoritmo3()
        guardar()

        offset1 = 25566
        Dim posplayercancha10 As Int32 = CbPlayer10.SelectedIndex + 2
        a = posplayercancha10
        algoritmo3()
        guardar()

        'POSICION 11 TITULARES
        formmcr.lblposiplayer1.Text = "GK"

        formmcr.lblposiplayer2.Text = formformation.cbplayer1.Text
        If cbplayer1.Text = "CB-L" Or cbplayer1.Text = "CB-R" Or cbplayer1.Text = "SW" Or cbplayer1.Text = "LIB" Or cbplayer1.Text = "CB-C" Or cbplayer1.Text = "LB" Or cbplayer1.Text = "RB" Then
            formmcr.lblposiplayer2.BackColor = Color.LightSeaGreen
        End If
        If cbplayer1.Text = "DH-L" Or cbplayer1.Text = "DH-C" Or cbplayer1.Text = "DH-R" Or cbplayer1.Text = "LH" Or cbplayer1.Text = "RH" Or cbplayer1.Text = "OH-L" Or cbplayer1.Text = "OH-C" Or cbplayer1.Text = "OH-R" Then
            formmcr.lblposiplayer2.BackColor = Color.DarkSeaGreen
        End If
        If cbplayer1.Text = "CF-L" Or cbplayer1.Text = "CF-C" Or cbplayer1.Text = "CF-R" Or cbplayer1.Text = "LW" Or cbplayer1.Text = "RW" Then
            formmcr.lblposiplayer2.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer3.Text = formformation.CbPlayer2.Text
        If CbPlayer2.Text = "CB-L" Or CbPlayer2.Text = "CB-R" Or CbPlayer2.Text = "SW" Or CbPlayer2.Text = "LIB" Or CbPlayer2.Text = "CB-C" Or CbPlayer2.Text = "LB" Or CbPlayer2.Text = "RB" Then
            formmcr.lblposiplayer3.BackColor = Color.LightSeaGreen
        End If
        If CbPlayer2.Text = "DH-L" Or CbPlayer2.Text = "DH-C" Or CbPlayer2.Text = "DH-R" Or CbPlayer2.Text = "LH" Or CbPlayer2.Text = "RH" Or CbPlayer2.Text = "OH-L" Or CbPlayer2.Text = "OH-C" Or CbPlayer2.Text = "OH-R" Then
            formmcr.lblposiplayer3.BackColor = Color.DarkSeaGreen
        End If
        If CbPlayer2.Text = "CF-L" Or CbPlayer2.Text = "CF-C" Or CbPlayer2.Text = "CF-R" Or CbPlayer2.Text = "LW" Or CbPlayer2.Text = "RW" Then
            formmcr.lblposiplayer3.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer4.Text = formformation.CbPlayer3.Text
        If CbPlayer3.Text = "CB-L" Or CbPlayer3.Text = "CB-R" Or CbPlayer3.Text = "SW" Or CbPlayer3.Text = "LIB" Or CbPlayer3.Text = "CB-C" Or CbPlayer3.Text = "LB" Or CbPlayer3.Text = "RB" Then
            formmcr.lblposiplayer4.BackColor = Color.LightSeaGreen
        End If
        If CbPlayer3.Text = "DH-L" Or CbPlayer3.Text = "DH-C" Or CbPlayer3.Text = "DH-R" Or CbPlayer3.Text = "LH" Or CbPlayer3.Text = "RH" Or CbPlayer3.Text = "OH-L" Or CbPlayer3.Text = "OH-C" Or CbPlayer3.Text = "OH-R" Then
            formmcr.lblposiplayer4.BackColor = Color.DarkSeaGreen
        End If
        If CbPlayer3.Text = "CF-L" Or CbPlayer3.Text = "CF-C" Or CbPlayer3.Text = "CF-R" Or CbPlayer3.Text = "LW" Or CbPlayer3.Text = "RW" Then
            formmcr.lblposiplayer4.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer5.Text = formformation.CbPlayer4.Text
        If CbPlayer4.Text = "CB-L" Or CbPlayer4.Text = "CB-R" Or CbPlayer4.Text = "SW" Or CbPlayer4.Text = "LIB" Or CbPlayer4.Text = "CB-C" Or CbPlayer4.Text = "LB" Or CbPlayer4.Text = "RB" Then
            formmcr.lblposiplayer5.BackColor = Color.LightSeaGreen
        End If
        If CbPlayer4.Text = "DH-L" Or CbPlayer4.Text = "DH-C" Or CbPlayer4.Text = "DH-R" Or CbPlayer4.Text = "LH" Or CbPlayer4.Text = "RH" Or CbPlayer4.Text = "OH-L" Or CbPlayer4.Text = "OH-C" Or CbPlayer4.Text = "OH-R" Then
            formmcr.lblposiplayer5.BackColor = Color.DarkSeaGreen
        End If
        If CbPlayer4.Text = "CF-L" Or CbPlayer4.Text = "CF-C" Or CbPlayer4.Text = "CF-R" Or CbPlayer4.Text = "LW" Or CbPlayer4.Text = "RW" Then
            formmcr.lblposiplayer5.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer6.Text = formformation.CbPlayer5.Text
        If CbPlayer5.Text = "CB-L" Or CbPlayer5.Text = "CB-R" Or CbPlayer5.Text = "SW" Or CbPlayer5.Text = "LIB" Or CbPlayer5.Text = "CB-C" Or CbPlayer5.Text = "LB" Or CbPlayer5.Text = "RB" Then
            formmcr.lblposiplayer6.BackColor = Color.LightSeaGreen
        End If
        If CbPlayer5.Text = "DH-L" Or CbPlayer5.Text = "DH-C" Or CbPlayer5.Text = "DH-R" Or CbPlayer5.Text = "LH" Or CbPlayer5.Text = "RH" Or CbPlayer5.Text = "OH-L" Or CbPlayer5.Text = "OH-C" Or CbPlayer5.Text = "OH-R" Then
            formmcr.lblposiplayer6.BackColor = Color.DarkSeaGreen
        End If
        If CbPlayer5.Text = "CF-L" Or CbPlayer5.Text = "CF-C" Or CbPlayer5.Text = "CF-R" Or CbPlayer5.Text = "LW" Or CbPlayer5.Text = "RW" Then
            formmcr.lblposiplayer6.BackColor = Color.PaleVioletRed
        End If


        formmcr.lblposiplayer7.Text = formformation.CbPlayer6.Text
        If CbPlayer6.Text = "CB-L" Or CbPlayer6.Text = "CB-R" Or CbPlayer6.Text = "SW" Or CbPlayer6.Text = "LIB" Or CbPlayer6.Text = "CB-C" Or CbPlayer6.Text = "LB" Or CbPlayer6.Text = "RB" Then
            formmcr.lblposiplayer7.BackColor = Color.LightSeaGreen
        End If
        If CbPlayer6.Text = "DH-L" Or CbPlayer6.Text = "DH-C" Or CbPlayer6.Text = "DH-R" Or CbPlayer6.Text = "LH" Or CbPlayer6.Text = "RH" Or CbPlayer6.Text = "OH-L" Or CbPlayer6.Text = "OH-C" Or CbPlayer6.Text = "OH-R" Then
            formmcr.lblposiplayer7.BackColor = Color.DarkSeaGreen
        End If
        If CbPlayer6.Text = "CF-L" Or CbPlayer6.Text = "CF-C" Or CbPlayer6.Text = "CF-R" Or CbPlayer6.Text = "LW" Or CbPlayer6.Text = "RW" Then
            formmcr.lblposiplayer7.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer8.Text = formformation.CbPlayer7.Text
        If CbPlayer7.Text = "CB-L" Or CbPlayer7.Text = "CB-R" Or CbPlayer7.Text = "SW" Or CbPlayer7.Text = "LIB" Or CbPlayer7.Text = "CB-C" Or CbPlayer7.Text = "LB" Or CbPlayer7.Text = "RB" Then
            formmcr.lblposiplayer8.BackColor = Color.LightSeaGreen
        End If
        If CbPlayer7.Text = "DH-L" Or CbPlayer7.Text = "DH-C" Or CbPlayer7.Text = "DH-R" Or CbPlayer7.Text = "LH" Or CbPlayer7.Text = "RH" Or CbPlayer7.Text = "OH-L" Or CbPlayer7.Text = "OH-C" Or CbPlayer7.Text = "OH-R" Then
            formmcr.lblposiplayer8.BackColor = Color.DarkSeaGreen
        End If
        If CbPlayer7.Text = "CF-L" Or CbPlayer7.Text = "CF-C" Or CbPlayer7.Text = "CF-R" Or CbPlayer7.Text = "LW" Or CbPlayer7.Text = "RW" Then
            formmcr.lblposiplayer8.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer9.Text = formformation.CbPlayer8.Text
        If CbPlayer8.Text = "CB-L" Or CbPlayer8.Text = "CB-R" Or CbPlayer8.Text = "SW" Or CbPlayer8.Text = "LIB" Or CbPlayer8.Text = "CB-C" Or CbPlayer8.Text = "LB" Or CbPlayer8.Text = "RB" Then
            formmcr.lblposiplayer9.BackColor = Color.LightSeaGreen
        End If
        If CbPlayer8.Text = "DH-L" Or CbPlayer8.Text = "DH-C" Or CbPlayer8.Text = "DH-R" Or CbPlayer8.Text = "LH" Or CbPlayer8.Text = "RH" Or CbPlayer8.Text = "OH-L" Or CbPlayer8.Text = "OH-C" Or CbPlayer8.Text = "OH-R" Then
            formmcr.lblposiplayer9.BackColor = Color.DarkSeaGreen
        End If
        If CbPlayer8.Text = "CF-L" Or CbPlayer8.Text = "CF-C" Or CbPlayer8.Text = "CF-R" Or CbPlayer8.Text = "LW" Or CbPlayer8.Text = "RW" Then
            formmcr.lblposiplayer9.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer10.Text = formformation.CbPlayer9.Text
        If CbPlayer9.Text = "CB-L" Or CbPlayer9.Text = "CB-R" Or CbPlayer9.Text = "SW" Or CbPlayer9.Text = "LIB" Or CbPlayer9.Text = "CB-C" Or CbPlayer9.Text = "LB" Or CbPlayer9.Text = "RB" Then
            formmcr.lblposiplayer10.BackColor = Color.LightSeaGreen
        End If
        If CbPlayer9.Text = "DH-L" Or CbPlayer9.Text = "DH-C" Or CbPlayer9.Text = "DH-R" Or CbPlayer9.Text = "LH" Or CbPlayer9.Text = "RH" Or CbPlayer9.Text = "OH-L" Or CbPlayer9.Text = "OH-C" Or CbPlayer9.Text = "OH-R" Then
            formmcr.lblposiplayer10.BackColor = Color.DarkSeaGreen
        End If
        If CbPlayer9.Text = "CF-L" Or CbPlayer9.Text = "CF-C" Or CbPlayer9.Text = "CF-R" Or CbPlayer9.Text = "LW" Or CbPlayer9.Text = "RW" Then
            formmcr.lblposiplayer10.BackColor = Color.PaleVioletRed
        End If

        formmcr.lblposiplayer11.Text = formformation.CbPlayer10.Text
        If CbPlayer10.Text = "CB-L" Or CbPlayer10.Text = "CB-R" Or CbPlayer10.Text = "SW" Or CbPlayer10.Text = "LIB" Or CbPlayer10.Text = "CB-C" Or CbPlayer10.Text = "LB" Or CbPlayer10.Text = "RB" Then
            formmcr.lblposiplayer11.BackColor = Color.LightSeaGreen
        End If
        If CbPlayer10.Text = "DH-L" Or CbPlayer10.Text = "DH-C" Or CbPlayer10.Text = "DH-R" Or CbPlayer10.Text = "LH" Or CbPlayer10.Text = "RH" Or CbPlayer10.Text = "OH-L" Or CbPlayer10.Text = "OH-C" Or CbPlayer10.Text = "OH-R" Then
            formmcr.lblposiplayer11.BackColor = Color.DarkSeaGreen
        End If
        If CbPlayer10.Text = "CF-L" Or CbPlayer10.Text = "CF-C" Or CbPlayer10.Text = "CF-R" Or CbPlayer10.Text = "LW" Or CbPlayer10.Text = "RW" Then
            formmcr.lblposiplayer11.BackColor = Color.PaleVioletRed
        End If

        FileClose()

        formmcr.Show()
        'Me.Hide()
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs)
        FileOpen(1, FrmMCR.OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.ReadWrite)
        offset1 = 24896
        Dim LF As Int32 = 0

        a = LF
        algoritmo3()
        guardar()
        FileClose()

        Button37.BackColor = Color.Red
        Button36.BackColor = Color.WhiteSmoke
        Button35.BackColor = Color.WhiteSmoke
        Button34.BackColor = Color.WhiteSmoke
        Button33.BackColor = Color.WhiteSmoke
        Button32.BackColor = Color.WhiteSmoke
        Button31.BackColor = Color.WhiteSmoke
        Button30.BackColor = Color.WhiteSmoke
        Button29.BackColor = Color.WhiteSmoke
        Button28.BackColor = Color.WhiteSmoke
        Button24.BackColor = Color.WhiteSmoke


    End Sub
End Class
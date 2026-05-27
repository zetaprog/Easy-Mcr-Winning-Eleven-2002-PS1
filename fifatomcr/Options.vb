Imports System.IO
Imports System.Net.WebSockets
Imports System.Runtime.InteropServices
Imports System.Runtime.Serialization

Public Class Options


    Private Sub Btn_Default_Click(sender As Object, e As EventArgs) Handles Btn_Default.Click
        cmb_Stat1.Text = 0
        Cmb_stat1a.Text = 19
        Cmb_stat2.Text = 20
        Cmb_stat2a.Text = 34
        Cmb_stat3.Text = 35
        Cmb_stat3a.Text = 49
        Cmb_stat4.Text = 50
        Cmb_stat4a.Text = 64
        Cmb_stat5.Text = 65
        Cmb_stat5a.Text = 74
        Cmb_stat6.Text = 75
        Cmb_stat6a.Text = 84
        Cmb_stat7.Text = 85
        Cmb_stat7a.Text = 94
        Cmb_stat8.Text = 95
        Cmb_stat8a.Text = 100

        cmb_feedoutside.Text = 75

        cmb_deffGk1.Text = 0
        cmb_deffGk1a.Text = 9
        cmb_deffGk2.Text = 10
        cmb_deffGk2a.Text = 19
        cmb_deffGk3.Text = 20
        cmb_deffGk3a.Text = 29
        cmb_deffGk4.Text = 30
        cmb_deffGk4a.Text = 39
        cmb_deffGk5.Text = 40
        cmb_deffGk5a.Text = 59
        cmb_deffGk6.Text = 60
        cmb_deffGk6a.Text = 77
        cmb_deffGk7.Text = 78
        cmb_deffGk7a.Text = 89
        cmb_deffGk8.Text = 90
        cmb_deffGk8a.Text = 100

        Cmb_RespGK1.Text = 0
        Cmb_RespGK1a.Text = 10
        Cmb_RespGK2.Text = 11
        Cmb_RespGK2a.Text = 20
        Cmb_RespGK3.Text = 21
        Cmb_RespGK3a.Text = 30
        Cmb_RespGK4.Text = 31
        Cmb_RespGK4a.Text = 44
        Cmb_RespGK5.Text = 45
        Cmb_RespGK5a.Text = 59
        Cmb_RespGK6.Text = 60
        Cmb_RespGK6a.Text = 79
        Cmb_RespGK7.Text = 80
        Cmb_RespGK7a.Text = 90
        Cmb_RespGK8.Text = 91
        Cmb_RespGK8a.Text = 100

        Cmb_Acc_spped1.Text = 0
        Cmb_Acc_spped1a.Text = 19
        Cmb_Acc_spped2.Text = 20
        Cmb_Acc_spped2a.Text = 34
        Cmb_Acc_spped3.Text = 35
        Cmb_Acc_spped3a.Text = 49
        Cmb_Acc_spped4.Text = 50
        Cmb_Acc_spped4a.Text = 64
        Cmb_Acc_spped5.Text = 65
        Cmb_Acc_spped5a.Text = 74
        Cmb_Acc_spped6.Text = 75
        Cmb_Acc_spped6a.Text = 89
        Cmb_Acc_spped7.Text = 90
        Cmb_Acc_spped7a.Text = 100

        cmb_pass_shorpwr1.Text = 0
        cmb_pass_shorpwr1a.Text = 19
        cmb_pass_shorpwr2.Text = 20
        cmb_pass_shorpwr2a.Text = 34
        cmb_pass_shorpwr3.Text = 35
        cmb_pass_shorpwr3a.Text = 49
        cmb_pass_shorpwr4.Text = 50
        cmb_pass_shorpwr4a.Text = 59
        cmb_pass_shorpwr5.Text = 60
        cmb_pass_shorpwr5a.Text = 72
        cmb_pass_shorpwr6.Text = 73
        cmb_pass_shorpwr6a.Text = 82
        cmb_pass_shorpwr7.Text = 83
        cmb_pass_shorpwr7a.Text = 90
        cmb_pass_shorpwr8.Text = 91
        cmb_pass_shorpwr8a.Text = 100

    End Sub

    Private Sub SaveToCSV()
        Try
            ' Verificar si el archivo existe


            ' Usar StreamWriter para escribir en el archivo
            Using writer As New StreamWriter(csvFilePath)
                '' Escribir encabezado si el archivo no existe
                'If Not fileExists Then
                '    writer.WriteLine("Option")
                'End If

                ' Escribir el valor de cmb_prueba.Text
                writer.WriteLine($"{cmb_Stat1.Text},{Cmb_stat1a.Text},{Cmb_stat2.Text},{Cmb_stat2a.Text},{Cmb_stat3.Text},{Cmb_stat3a.Text},{Cmb_stat4.Text},{Cmb_stat4a.Text},{Cmb_stat5.Text},{Cmb_stat5a.Text},{Cmb_stat6.Text},{Cmb_stat6a.Text},{Cmb_stat7.Text},{Cmb_stat7a.Text},{Cmb_stat8.Text},{Cmb_stat8a.Text},{cmb_deffGk1.Text},{cmb_deffGk1a.Text},{cmb_deffGk2.Text},{cmb_deffGk2a.Text},{cmb_deffGk3.Text},{cmb_deffGk3a.Text},{cmb_deffGk4.Text},{cmb_deffGk4a.Text},{cmb_deffGk5.Text},{cmb_deffGk5a.Text},{cmb_deffGk6.Text},{cmb_deffGk6a.Text},{cmb_deffGk7.Text},{cmb_deffGk7a.Text},{cmb_deffGk8.Text},{cmb_deffGk8a.Text},{Cmb_RespGK1.Text},{Cmb_RespGK1a.Text},{Cmb_RespGK2.Text},{Cmb_RespGK2a.Text},{Cmb_RespGK3.Text},{Cmb_RespGK3a.Text},{Cmb_RespGK4.Text},{Cmb_RespGK4a.Text},{Cmb_RespGK5.Text},{Cmb_RespGK5a.Text},{Cmb_RespGK6.Text},{Cmb_RespGK6a.Text},{Cmb_RespGK7.Text},{Cmb_RespGK7a.Text},{Cmb_RespGK8.Text},{Cmb_RespGK8a.Text},{Cmb_Acc_spped1.Text},{Cmb_Acc_spped1a.Text},{Cmb_Acc_spped2.Text},{Cmb_Acc_spped2a.Text},{Cmb_Acc_spped3.Text},{Cmb_Acc_spped3a.Text},{Cmb_Acc_spped4.Text},{Cmb_Acc_spped4a.Text},{Cmb_Acc_spped5.Text},{Cmb_Acc_spped5a.Text},{Cmb_Acc_spped6.Text},{Cmb_Acc_spped6a.Text},{Cmb_Acc_spped7.Text},{Cmb_Acc_spped7a.Text},{cmb_pass_shorpwr1.Text},{cmb_pass_shorpwr1a.Text},{cmb_pass_shorpwr2.Text},{cmb_pass_shorpwr2a.Text},{cmb_pass_shorpwr3.Text},{cmb_pass_shorpwr3a.Text},{cmb_pass_shorpwr4.Text},{cmb_pass_shorpwr4a.Text},{cmb_pass_shorpwr5.Text},{cmb_pass_shorpwr5a.Text},{cmb_pass_shorpwr6.Text},{cmb_pass_shorpwr6a.Text},{cmb_pass_shorpwr7.Text},{cmb_pass_shorpwr7a.Text},{cmb_pass_shorpwr8.Text},{cmb_pass_shorpwr8a.Text},{cmb_feedoutside.Text}")

            End Using

            MessageBox.Show("Datos guardados correctamente.")
        Catch ex As Exception
            MessageBox.Show("Error al guardar en el archivo CSV: " & ex.Message)
        End Try
    End Sub


    Private Sub Btn_Saved_Click(sender As Object, e As EventArgs) Handles Btn_Saved.Click
        SaveToCSV()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        loadOptionsCVS()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadFromCSV()
    End Sub

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_AggresionGK1.SelectedIndexChanged

    End Sub

    Private Sub Cmb_AggresionGK3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_AggresionGK3.SelectedIndexChanged

    End Sub
End Class
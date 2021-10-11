Public Class Form1
    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        LimpiarEntradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Dim B As Byte


        For B = 0 To 7

            Edad(B) = Nothing
            Genero(B) = Nothing
            Registro(B) = Nothing
            Daños(B) = Nothing
            Taller(B) = Nothing
            Deducible(B) = Nothing

        Next B

        List_Edad.Items.Clear()
        List_Género.Items.Clear()
        List_Registro.Items.Clear()
        List_MontoDeDaños.Items.Clear()
        List_Taller.Items.Clear()
        List_Deducible.Items.Clear()
        TXTTOTALMONTO.Clear()

        indice = 0

        MsgBox("Vectores limpios", vbOKOnly, Title:="Limpiar Vectores")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        If IsNumeric(TXTEDAD.Text) = False Or IsNumeric(TXTMONTO.Text) = False Then
            MsgBox("El valor debe ser un número, corrija el valor ingresado para continuar", vbExclamation, Title:="Error de ingreso")
            TXTEDAD.Focus()
            Exit Sub
        End If

        If (TXTEDAD.Text = "") Or (CMBGENERO.Text = "") Or (CMBCODIGOREGISTRO.Text = "") Or (TXTMONTO.Text = "") Or (CMBTALLER.Text = "") Then
            MsgBox("Por favor revise que todos los campos estén completos", vbExclamation, Title:="Advertencia")

            TXTEDAD.Focus()
            Exit Sub
        End If

        If (indice < 7) Then
            Edad(indice) = Val(TXTEDAD.Text)
            Genero(indice) = CMBGENERO.SelectedItem
            Registro(indice) = CMBCODIGOREGISTRO.Text
            Daños(indice) = Val(TXTMONTO.Text)
            Taller(indice) = CMBTALLER.SelectedItem.ToString()
            Deducible(indice) = Val(TXTMONTO.Text) * 0.06

        End If
        LimpiarEntradas()
        indice = indice + 1

        If (indice >= 7) Then

            MsgBox("Los vectores estan llenos", vbExclamation, Title:="Sistema dice")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNMOSTRAR.Click
        Dim m As Byte

        List_Edad.Items.Clear()
        List_Género.Items.Clear()
        List_Registro.Items.Clear()
        List_MontoDeDaños.Items.Clear()
        List_Taller.Items.Clear()
        List_Deducible.Items.Clear()

        For m = 0 To 7
            If Edad(m) <> Nothing Then
                List_Edad.Items.Add(Edad(m))
                List_Género.Items.Add(Genero(m))
                List_Registro.Items.Add(Registro(m))
                List_MontoDeDaños.Items.Add(Daños(m))
                List_Taller.Items.Add(Taller(m))
                List_Deducible.Items.Add(Deducible(m))
            Else
                Exit For
            End If
        Next m

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim total As Integer = 0
        Dim a As Integer

        For a = 0 To List_MontoDeDaños.Items.Count - 1
            total = total + Val(List_MontoDeDaños.Items.Item(a))

        Next a

        TXTTOTALMONTO.Text = Str(total)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LimpiarEntradas()
        End If
    End Sub

    Private Sub LimpiarEstadisticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEstadisticasToolStripMenuItem.Click
        TXT25AÑOS.Text = ""
        TXTFEMENINO.Text = ""
        TXT1825AÑOS.Text = ""
        TXTREGISTROEXTRANJERO.Text = ""
        TXTCONDUCTORES.Text = ""

    End Sub

    Private Sub CalcularEstadisticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularEstadisticasToolStripMenuItem.Click

        Dim x As Byte
        Dim R1 As Byte = 0
        Dim R2 As Byte = 0
        Dim R3 As Byte = 0
        Dim R4 As Byte = 0
        Dim R5 As Byte = 0


        For x = 0 To 7

            If (Edad(x) > 0) And (Edad(x) < 25) Then
                R1 = R1 + 1
            End If

            If (Genero(x) = "F") Then
                R2 = R2 + 1
            End If

            Select Case Edad(x)
                Case 18 To 25 And Genero(x) = "M" : R3 = R3 + 1
            End Select

            If (Registro(x) = "0 - Extranjero") Then
                R4 = R4 + 1
            Else
                R4 = R4 + 0
            End If

            R5 = List_Edad.Items.Count()

        Next x

        TXT25AÑOS.Text = Math.Round((Str(R1) / indice) * 100, 2) & " %"
        TXTFEMENINO.Text = Math.Round((Str(R2) / indice) * 100, 2) & " %"
        TXT1825AÑOS.Text = Math.Round((Str(R3) / indice) * 100, 2) & " %"
        TXTREGISTROEXTRANJERO.Text = Math.Round((Str(R4) / indice) * 100, 2) & " %"
        TXTCONDUCTORES.Text = Str(R5)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles BTNTOTAL.Click

        Dim total_daños As Integer = 0
        Dim M As Integer

        For M = 0 To List_MontoDeDaños.Items.Count - 1
            total_daños = total_daños + Val(List_MontoDeDaños.Items.Item(M))

        Next M

        TXTTOTALMONTO.Text = Str(total_daños)
    End Sub


End Class

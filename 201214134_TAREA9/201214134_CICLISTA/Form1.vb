Public Class Form1
    Private Sub GuGuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuGuardarToolStripMenuItem.Click
        If VerificarRepetido() Then
        Else
            MsgBox("Número de etapa repetido, debe ingresar uno diferente")
        End If

        If (INDICE < 12) Then
            NumeroEtapa(INDICE) = Str(Val(TextBox1.Text))
            Equipo(INDICE) = ComboBox1.SelectedItem
            KmsRecorridos(INDICE) = Str(Val(TextBox2.Text))
            TiempoMinutos(INDICE) = Str(Val(TextBox3.Text))
        End If

        If RadioButton1.Checked Then
            Nacionalidad(INDICE) = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            Nacionalidad(INDICE) = RadioButton2.Text
        End If

        If Val(TiempoMinutos(INDICE)) > 120 Then
            Penalización(INDICE) = 30
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) > 140 Then
            Penalización(INDICE) = 40
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) > 160 Then
            Penalización(INDICE) = 50
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) < 85 And Equipo(INDICE) = "Movistar" Then
            Penalización(INDICE) = 0
            Reduccion(INDICE) = 15
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) < 85 And Equipo(INDICE) = "Pro Team" Then
            Penalización(INDICE) = 0
            Reduccion(INDICE) = 10
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        Else
            Penalización(INDICE) = 0
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        End If

        INDICE = INDICE + 1
        LimpiarEntradas()
        If (INDICE = 11) Then
            MsgBox("MATRIZ LLENA", vbExclamation, "IMPORTANTE")
        End If
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        MostrarDatosVectores()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        LimpiarEntradas()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        LimpiarVectores()
    End Sub

    Private Sub OrdenarAscendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarAscendenteToolStripMenuItem.Click
        DataGridView1.Sort(Column1, System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub EsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsToolStripMenuItem.Click
        MostrarEstadisticas()
    End Sub

    Private Sub LimpiarEstadisticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEstadisticasToolStripMenuItem.Click
        LimpiarEstadisticas()
    End Sub

    Private Sub SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LimpiarEntradas()
            LimpiarEstadisticas()
            LimpiarVectores()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        EliminarVector()
        LimpiarEntradas()
        MsgBox("Registro eliminado exitosamente")
        MostrarDatosVectores()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        EliminarVector()
        If VerificarRepetido() Then
        Else
            MsgBox("Número de etapa repetido, debe ingresar uno diferente")
        End If

        NumeroEtapa(INDICE) = Str(Val(TextBox1.Text))
        Equipo(INDICE) = ComboBox1.SelectedItem
        KmsRecorridos(INDICE) = Str(Val(TextBox2.Text))
        TiempoMinutos(INDICE) = Str(Val(TextBox3.Text))

        If RadioButton1.Checked Then
            Nacionalidad(INDICE) = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            Nacionalidad(INDICE) = RadioButton2.Text
        End If

        If Val(TiempoMinutos(INDICE)) > 120 Then
            Penalización(INDICE) = 30
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) > 140 Then
            Penalización(INDICE) = 40
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) > 160 Then
            Penalización(INDICE) = 50
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) < 85 And Equipo(INDICE) = "Movistar" Then
            Penalización(INDICE) = 0
            Reduccion(INDICE) = 15
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) < 85 And Equipo(INDICE) = "Pro Team" Then
            Penalización(INDICE) = 0
            Reduccion(INDICE) = 10
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        Else
            Penalización(INDICE) = 0
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        End If

        MsgBox("Numero de etapa actualizado correctamente en los vectores", vbExclamation, "IMPORTANTE")
        INDICE = 12
        LimpiarEntradas()
        MostrarDatosVectores()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim existe As Boolean = True
        INDICE = 0
        While (INDICE <= 11) And (existe)
            If (NumeroEtapa(INDICE) <> Nothing) Then
                If (NumeroEtapa(INDICE) = Str(TextBox14.Text)) Then
                    existe = False
                Else
                    INDICE = INDICE + 1
                End If
            Else
                Exit While
            End If
        End While

        If (existe) Then
            MsgBox("Número de etapa no encontrado")
            TextBox8.Focus()
        Else
            MsgBox("Numero de etapa encontrado exitosamente")

            TextBox1.Text = NumeroEtapa(INDICE)
            ComboBox1.Text = Equipo(INDICE)
            TextBox2.Text = KmsRecorridos(INDICE)
            TextBox3.Text = TiempoMinutos(INDICE)

            If Nacionalidad(INDICE) = "Guatemalteco" Then
                RadioButton1.Checked = True
            ElseIf Nacionalidad(INDICE) = "Extranjero" Then
                RadioButton2.Checked = True
            End If

            TextBox14.Clear()
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(NumeroEtapa(INDICE), Equipo(INDICE), KmsRecorridos(INDICE), TiempoMinutos(INDICE), Nacionalidad(INDICE), Penalización(INDICE), Reduccion(INDICE), TotalMinutos(INDICE))
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 1000
        Me.Height = 525
    End Sub
End Class

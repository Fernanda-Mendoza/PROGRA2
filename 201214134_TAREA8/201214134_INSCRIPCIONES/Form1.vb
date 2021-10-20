Public Class Form1

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RDTDIVERSIFICADO.CheckedChanged
        If (RDTDIVERSIFICADO.Checked) Then

            CMBCARRERA.Visible = True
            CMBCARRERA.Focus()
        Else

            CMBCARRERA.Visible = False

        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("DESEA SALIR?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNLIMPIAR.Click
        LIMPIAR_ESTADISTICAS()
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        If TXTNOMBRE.Text = "" Or TXTCARNET.Text = "" Then
            MsgBox("INGRESE SUS DATOS")
            Exit Sub
        End If

        If RDTBASICOS.Checked = False And RDTDIVERSIFICADO.Checked = False Then
            MsgBox("SELECCIONE EL NIVEL")
            Exit Sub

        End If

        If CMBFORMADEPAGO.SelectedItem = Nothing Then
            MsgBox("SELECCIONE FORMA DE PAGO")
            Exit Sub
        End If

        If (INDICE <= 6) Then

            INSCRIPCIONES(INDICE, 0) = TXTNOMBRE.Text
            INSCRIPCIONES(INDICE, 1) = TXTCARNET.Text

            If RDTBASICOS.Checked = True Then

                INSCRIPCIONES(INDICE, 2) = RDTBASICOS.Text
                INSCRIPCIONES(INDICE, 4) = InscripcionBasicos
                INSCRIPCIONES(INDICE, 5) = CuotaBasicos
                PagoInicial = InscripcionBasicos + CuotaBasicos
                INSCRIPCIONES(INDICE, 6) = PagoInicial

                Select Case CMBFORMADEPAGO.SelectedIndex
                    Case 0 : INSCRIPCIONES(INDICE, 7) = "EFECTIVO"
                    Case 1 : INSCRIPCIONES(INDICE, 7) = "TARJETA DE CREDITO"
                    Case 2 : INSCRIPCIONES(INDICE, 7) = "TRANSFERENCIA ACH"
                    Case 3 : INSCRIPCIONES(INDICE, 7) = "DEPOSITO BANCARIO"

                End Select

                Select Case CMBFORMADEPAGO.SelectedIndex
                    Case 1 : INSCRIPCIONES(INDICE, 8) = PagoInicial * 0.1
                    Case Else : INSCRIPCIONES(INDICE, 8) = 0
                End Select

                INSCRIPCIONES(INDICE, 9) = Val(INSCRIPCIONES(INDICE, 6)) + Val(INSCRIPCIONES(INDICE, 8))

            End If

            If RDTDIVERSIFICADO.Checked = True Then

                INSCRIPCIONES(INDICE, 2) = RDTDIVERSIFICADO.Text
                INSCRIPCIONES(INDICE, 4) = InscripcionDiversificado
                INSCRIPCIONES(INDICE, 5) = CuotaDiversificado
                PagoInicial = InscripcionDiversificado + CuotaDiversificado
                INSCRIPCIONES(INDICE, 6) = PagoInicial

                Select Case CMBFORMADEPAGO.SelectedIndex
                    Case 0 : INSCRIPCIONES(INDICE, 7) = "EFECTIVO"
                    Case 1 : INSCRIPCIONES(INDICE, 7) = "TARJETA DE CREDITO"
                    Case 2 : INSCRIPCIONES(INDICE, 7) = "TRANSFERENCIA ACH"
                    Case 3 : INSCRIPCIONES(INDICE, 7) = "DEPOSITO BANCARIO"

                End Select

                Select Case CMBFORMADEPAGO.SelectedIndex
                    Case 1 : INSCRIPCIONES(INDICE, 8) = PagoInicial * 0.1
                    Case Else : INSCRIPCIONES(INDICE, 8) = 0
                End Select

                INSCRIPCIONES(INDICE, 9) = Val(INSCRIPCIONES(INDICE, 6)) + Val(INSCRIPCIONES(INDICE, 8))

            End If

            If RDTDIVERSIFICADO.Checked = True Then

                CMBCARRERA.Enabled = True

            End If

            Select Case CMBCARRERA.SelectedIndex
                Case 0 : INSCRIPCIONES(INDICE, 3) = "PERITO CONTADOR"
                Case 1 : INSCRIPCIONES(INDICE, 3) = "BACHILLERATO"
                Case 2 : INSCRIPCIONES(INDICE, 3) = "ELECTRONICA"
                Case 3 : INSCRIPCIONES(INDICE, 3) = "DISEÑO GRAFICO"
            End Select

            INDICE = INDICE + 1

        End If

        If (INDICE = 7) Then

            MsgBox("LA MATRIZ ESTÁ LLENA")

        End If

        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        MOSTRAR()
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        Dim i As Byte, J As Byte

        DataGridView1.Rows.Clear()
        'instrucción que colocar a cero la variable que controla las posiciones o filas de la matriz, para poder
        'iniciar a ingresar datos desde la primera posición de la matriz
        For i = 0 To 6
            For J = 0 To 9
                INSCRIPCIONES(i, J) = Nothing
            Next J
        Next i
        INDICE = 0

        MsgBox("LA MATRIZ ESTA LIMPIA")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNMOSTRAR.Click
        Dim r As Byte = 0

        Dim r1 As Double = 0
        Dim r2 As Double = 0
        Dim r3 As Double = 0
        Dim r4 As Double = 0
        Dim r5 As Double = 0
        Dim r6 As Double = 0
        Dim r7 As Double = 0
        Dim r8 As Double = 0
        Dim r9 As Double = 0
        Dim r10 As Double = 0
        Dim r11 As Double = 0

        For r = 0 To 7

            r1 = r1 + Val(INSCRIPCIONES(r, 9))

            If (Str(INSCRIPCIONES(r, 7) = "EFECTIVO")) Then
                r2 = r2 + Val(INSCRIPCIONES(r, 9))
            End If

            If (Str(INSCRIPCIONES(r, 7) = "TARJETA DE CREDITO")) Then
                r3 = r3 + Val(INSCRIPCIONES(r, 9))
            End If

            If (Str(INSCRIPCIONES(r, 7) = "TRANSFERENCIA ACH")) Then
                r4 = r4 + Val(INSCRIPCIONES(r, 9))
            End If

            If (Str(INSCRIPCIONES(r, 7) = "DEPOSITO BANCARIO")) Then
                r5 = r5 + Val(INSCRIPCIONES(r, 9))
            End If

            If (Str(INSCRIPCIONES(r, 2) = "Básicos")) Then
                r6 = r6 + Val(INSCRIPCIONES(r, 9))
            End If

            If (Str(INSCRIPCIONES(r, 2) = "Diversificado")) Then
                r7 = r7 + Val(INSCRIPCIONES(r, 9))
            End If

            If (Str(INSCRIPCIONES(r, 3) = "PERITO CONTADOR")) Then
                r8 = r8 + 1
            End If

            If (Str(INSCRIPCIONES(r, 3) = "BACHILLERATO")) Then
                r9 = r9 + 1
            End If

            If (Str(INSCRIPCIONES(r, 3) = "ELECTRONICA")) Then
                r10 = r10 + 1
            End If

            If (Str(INSCRIPCIONES(r, 3) = "DISEÑO GRAFICO")) Then
                r11 = r11 + 1
            End If

        Next r

        TXTTOTALG.Text = Math.Round(r1, 2).ToString
        TXTTOTALEFECTIVO.Text = Math.Round(r2, 2).ToString
        TXTTOTALTARJETA.Text = Math.Round(r3, 2).ToString
        TXTTRANSFERENCIA.Text = Math.Round(r4, 2).ToString
        TXTDEPOSITO.Text = Math.Round(r5, 2).ToString
        TXTBASICOS.Text = Math.Round(r6, 2).ToString
        TXTDIVERSIFICADO.Text = Math.Round(r7, 2).ToString
        TXTPERITO.Text = Str(r8)
        TXTBACHILLERATO.Text = Str(r9)
        TXTELECTRONICA.Text = Str(r10)
        TXTDISEÑO.Text = Str(r11)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 600
        Me.Width = 1100
    End Sub
End Class

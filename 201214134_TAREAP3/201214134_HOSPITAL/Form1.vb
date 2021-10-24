Imports System.Math
Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Close()
        Else
            limpiar_entradas()
            limpiar_estadisticas()
        End If
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click
        limpiar_matriz()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub LimpiarEstadisticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEstadisticaToolStripMenuItem.Click
        limpiar_estadisticas()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar_Matriz()
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        If TextBox1.Text = "" Then
            MsgBox("Ingrese el nombre", vbExclamation, "ERROR")
        ElseIf TextBox2.Text = "" Or IsNumeric(TextBox2.Text) = 0 Then
            MsgBox("Ingrese el número de NIT", vbExclamation, "ERROR")
        ElseIf TextBox3.Text = "" Or IsNumeric(TextBox3.Text) = 0 Then
            MsgBox("Ingrese la cantidad de días hospitalizado", vbExclamation, "ERROR")
        ElseIf TextBox4.Text = "" Then
            MsgBox("Ingrese los honorarios del medico", vbExclamation, "ERROR")
        ElseIf ComboBox1.Text = "" Then
            MsgBox("Seleccione el tipo de habitación", vbExclamation, "ERROR")
        ElseIf ComboBox2.Text = "" Then
            MsgBox("Seleccione la forma de pago", vbExclamation, "ERROR")
        End If

        If comprobar_repetido() Then
        Else
            MsgBox("Número de NIT repetido, debe ingresar uno diferente")
            TextBox2.Clear()
            TextBox2.Focus()
        End If

        If (fila <= 5) Then

            Pacientes(fila, 0) = TextBox1.Text
            Pacientes(fila, 1) = Str(Val(TextBox2.Text))
            Pacientes(fila, 2) = Str(Val(TextBox3.Text))
            Pacientes(fila, 3) = Str(Round(Val(TextBox4.Text), 2))
            Pacientes(fila, 4) = ComboBox1.SelectedItem
            Pacientes(fila, 6) = ComboBox2.SelectedItem

            Select Case ComboBox1.SelectedItem
                Case "1. Privada"
                    Pacientes(fila, 5) = privado
                Case "2. Semiprivada"
                    Pacientes(fila, 5) = semiprivado
                Case "3. No Privada"
                    Pacientes(fila, 5) = noprivado
            End Select

            Pacientes(fila, 7) = Val(Pacientes(fila, 2)) * Val(Pacientes(fila, 5))

            Select Case ComboBox2.SelectedItem
                Case "Efectivo"
                    Pacientes(fila, 8) = Val(Pacientes(fila, 7)) * 0.1 * -1
                Case "Transferencia ACH"
                    Pacientes(fila, 8) = Val(Pacientes(fila, 7)) * 0.08 * -1
                Case "Depósito Bancario"
                    Pacientes(fila, 8) = Val(Pacientes(fila, 7)) * 0.1 * -1
                Case "Tarjeta de crédito"
                    Pacientes(fila, 8) = Val(Pacientes(fila, 7)) * 0.015
                Case "Seguro Médico"
                    Pacientes(fila, 8) = Val(Pacientes(fila, 7)) * 0
            End Select
            Pacientes(fila, 9) = Val(Pacientes(fila, 7)) + Val(Pacientes(fila, 8))
        End If


        fila = fila + 1

            limpiar_entradas()

            If (fila = 6) Then
            MsgBox("vectores llenos")
        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = True
        fila = 0
        While (fila <= 5) And (existe)
            If (Pacientes(fila, 0) <> Nothing) Then
                If Str(Pacientes(fila, 1) = Str(TextBox5.Text)) Then
                    existe = False
                Else
                    fila = fila + 1
                End If
            Else
                Exit While
            End If
        End While

        If (existe) Then
            MsgBox("NIT no encontrado")
            TextBox5.Focus()
        Else
            MsgBox("NIT Encontrado exitosamente")

            TextBox1.Text = Pacientes(fila, 0)
            TextBox2.Text = Pacientes(fila, 1)
            TextBox3.Text = Pacientes(fila, 2)
            TextBox4.Text = Pacientes(fila, 3)
            ComboBox1.Text = Pacientes(fila, 4)
            ComboBox2.Text = Pacientes(fila, 6)

            TextBox5.Clear()
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Pacientes(fila, 0), Pacientes(fila, 1), Pacientes(fila, 2), Pacientes(fila, 3), Pacientes(fila, 4), Pacientes(fila, 5), Pacientes(fila, 6), Pacientes(fila, 7), Pacientes(fila, 8), Pacientes(fila, 9))

        End If

    End Sub

    Private Sub EstadisticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticaToolStripMenuItem.Click
        MostrarEstadisticas()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Width = 1010
    End Sub
End Class

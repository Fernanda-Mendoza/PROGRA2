Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        LimpiarVectores()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        If ComboBox1.Text = "" Then
            MsgBox("Eliga el cine que desea", vbQuestion)
        End If
        If ComboBox2.Text = "" Then
            MsgBox("Eliga la función que desea", vbQuestion)
        End If
        If TXTCANTIDAD.Text = "" Then
            MsgBox("Indique el número de Entradas", vbQuestion)
        End If

        If INDICE <= 8 Then
            vfuncion(INDICE) = ComboBox2.SelectedItem
            vcine(INDICE) = ComboBox1.SelectedItem
            subtotal_a_pagar(INDICE) = TXTCANTIDAD.Text * calcularSubtotal(vfuncion(INDICE), vcine(INDICE))
            vdescuento1(INDICE) = Math.Round(subtotal_a_pagar(INDICE) * calculoDescuento1(vfuncion(INDICE), vcine(INDICE)), 2)
            vdescuento2(INDICE) = Math.Round(subtotal_a_pagar(INDICE) * calculoDescuento2(subtotal_a_pagar(INDICE)), 2)
            total_a_pagar(INDICE) = Math.Round(subtotal_a_pagar(INDICE) - vdescuento1(INDICE) - vdescuento2(INDICE), 2)

            Función.Items.Add(vfuncion(INDICE))
            Cine.Items.Add(vcine(INDICE))
            SubTotal.Items.Add(subtotal_a_pagar(INDICE))
            Descuento_1.Items.Add(vdescuento1(INDICE))
            Descuento_2.Items.Add(vdescuento2(INDICE))
            Total.Items.Add(total_a_pagar(INDICE))
            INDICE = INDICE + 1
        ElseIf (INDICE = 9) Then
            MsgBox("VECTORES LLENOS")
        End If

    End Sub
End Class

Public Class Form1

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub LimpiarListasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarListasToolStripMenuItem.Click
        LimpiarVectores()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            TXTEFECTIVO.Visible = True
            TXTEFECTIVO.Focus()
        Else
            TXTEFECTIVO.Clear()
            TXTEFECTIVO.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            TXTTARJETA.Visible = True
            TXTTARJETA.Focus()
        Else
            TXTTARJETA.Clear()
            TXTTARJETA.Visible = False
        End If
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
       
        If CMBMARCA.Text = "" Then
            MsgBox("Eliga la marca que desea", vbQuestion)

            Exit Sub

            CMBMARCA.Focus()
        End If

        If TXTCANTIDAD.Text = "" Then
            MsgBox("Indique la cantidad de días", vbQuestion)
            Exit Sub

            TXTCANTIDAD.Focus()
        End If
        If TXTNIT.Text = "" Then
            MsgBox("Ingrese el número de NIT", vbQuestion)
            Exit Sub

            TXTNIT.Focus()
        End If

        If TXTPLACA.Text = "" Then
            MsgBox("Ingrese el número de Placa", vbQuestion)
            Exit Sub

            TXTPLACA.Focus()
        End If

        If indice <= 5 Then
            NitDelcliente(indice) = TXTNIT.Text
            Placa(indice) = TXTPLACA.Text
            Marca(indice) = CMBMARCA.SelectedItem
            Descuento(indice) = TXTEFECTIVO.Text
            Descuento(indice) = TXTTARJETA.Text
            DíaDeAlquiler(indice) = TXTCANTIDAD.Text
            PagoParcial(indice) = DíaDeAlquiler(indice) * calculoPrecio(Marca(indice))
            DescuentoRecargo()


            LIST_PLACA.Items.Add(Placa(indice))
            LIST_MARCA.Items.Add(Marca(indice))
            LIST_DÍAS.Items.Add(DíaDeAlquiler(indice))
            LIST_PARCIAL.Items.Add(PagoParcial(indice))
            LIST_DESCUENTO.Items.Add(Descuento(indice))
            LIST_NIT.Items.Add(NitDelcliente(indice))
            LIST_FINAL.Items.Add(PagoTotal(indice))

        ElseIf (indice = 6) Then
            MsgBox("VECTORES LLENOS")

        End If

        indice = indice + 1

    End Sub
End Class

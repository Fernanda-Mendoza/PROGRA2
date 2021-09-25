Module Module1
    Public indice As Byte = 0
    Public Placa(6)
    Public Marca(6)
    Public DíaDeAlquiler(6)
    Public PagoParcial(6)
    Public Descuento(6)
    Public PagoTotal(6)
    Public NitDelcliente(6)

    Public Const Tarjeta = 0.025
    Public Const Efectivo = 0.05

    Public Const PrecioHonda = 250
    Public Const PrecioMercedesBenz = 450
    Public Const PrecioToyota = 325
    Public Const PrecioMazda = 300

    Sub LIMPIAR_ENTRADAS()

        Form1.CMBMARCA.Text = ""
        Form1.TXTNIT.Text = ""
        Form1.TXTPLACA.Text = ""
        Form1.TXTCANTIDAD.Text = ""
        Form1.TXTEFECTIVO.Text = ""
        Form1.TXTTARJETA.Text = ""
        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False
        Form1.TXTNIT.Focus()
    End Sub

    Sub LimpiarVectores()
        Form1.LIST_PLACA.Items.Clear()
        Form1.LIST_MARCA.Items.Clear()
        Form1.LIST_DÍAS.Items.Clear()
        Form1.LIST_PARCIAL.Items.Clear()
        Form1.LIST_DESCUENTO.Items.Clear()
        Form1.LIST_NIT.Items.Clear()
        Form1.LIST_FINAL.Items.Clear()

        indice = 0

    End Sub


    Function calculoPrecio(Marca As String) As Double
        If Marca = "Honda" Then
            calculoPrecio = PrecioHonda
        ElseIf Marca = "Mercedes Benz" Then
            calculoPrecio = PrecioMercedesBenz
        ElseIf Marca = "Toyota" Then
            calculoPrecio = PrecioToyota
        ElseIf Marca = "Mazda" Then
            calculoPrecio = PrecioMazda
        End If
        Return calculoPrecio
    End Function

    Sub DescuentoRecargo()
        If Form1.CheckBox1.Checked = True And Form1.CheckBox2.Checked = False Then
            If Val(Form1.TXTEFECTIVO.Text) = 100 Then
                MsgBox("Descuento del 5% por Pagar todo en efectivo")

                Descuento(indice) = PagoParcial(indice) * Efectivo
                PagoTotal(indice) = Math.Round((PagoParcial(indice) - Descuento(indice)), 2)

            ElseIf Val(Form1.TXTEFECTIVO.Text) <> "100" Then

                MsgBox("Debe ingresar un porcentaje de pago")
            End If
        End If

        If Form1.CheckBox1.Checked = False And Form1.CheckBox2.Checked = True Then
            If Val(Form1.TXTTARJETA.Text) = 100 Then
                MsgBox("Recargo del 2.5% por Pagar todo con tarjeta")

                Descuento(indice) = PagoParcial(indice) * Tarjeta
                PagoTotal(indice) = Math.Round((PagoParcial(indice) + Descuento(indice)), 2)

            ElseIf Val(Form1.TXTTARJETA.Text) <> "100" Then

                MsgBox("Debe ingresar un porcentaje de pago")
            End If
        End If

        If Form1.CheckBox1.Checked = True And Form1.CheckBox2.Checked = True Then

            If (Val(Form1.TXTEFECTIVO.Text) + Val(Form1.TXTTARJETA.Text)) = 100 Then
                Descuento(indice) = 0
                PagoTotal(indice) = Math.Round(PagoParcial(indice), 2)

            ElseIf (Val(Form1.TXTEFECTIVO.Text) + Val(Form1.TXTTARJETA.Text)) <> 100 Then
                MsgBox("El % entre los pagos debe de ser 100")

            End If

        End If
    End Sub

End Module

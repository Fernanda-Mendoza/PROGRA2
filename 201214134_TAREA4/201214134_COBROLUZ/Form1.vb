Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        INDICE = 0

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        ListBox7.Items.Clear()
        ListBox8.Items.Clear()
        ListBox9.Items.Clear()
        ListBox10.Items.Clear()

    End Sub

    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If TextBox1.Text = "" Then
            MsgBox("Ingrese Nombre del Consumidor", vbQuestion)
        End If
        If TextBox2.Text = "" Then
            MsgBox("Ingrese Número de NIT", vbQuestion)
        End If
        If TextBox3.Text = "" Then
            MsgBox("Ingrese Saldo Anterior", vbQuestion)
        End If
        If TextBox4.Text = "" Then
            MsgBox("Ingrese Consumo de Kilowatts por mes", vbQuestion)
        End If

        If (INDICE <= 10) Then
            Consumidor(INDICE) = TextBox1.Text
            Servicio(INDICE) = ComboBox1.Text
            Tarifa(INDICE) = ComboBox2.Text
            SaldoAnterior(INDICE) = TextBox3.Text
        End If
        If (ComboBox1.Text = "Residencial") Then
            Select Case Val(TextBox4.Text)
                Case 1 To 100
                    Cpagoincial = Val(TextBox4.Text) * Residencial1
                Case 101 To 300
                    Cpagoincial = Val(TextBox4.Text) * Residencial2
                Case >= 301
                    Cpagoincial = Val(TextBox4.Text) * Residencial3

            End Select
            PagoIncial(INDICE) = Math.Round(Cpagoparcial, 2)

            If (ComboBox2.Text = "Industria") Then
                Select Case Val(TextBox4.Text)
                    Case 1 To 100
                        Cpagoincial = Val(TextBox4.Text) * Industrial1
                    Case 101 To 300
                        Cpagoincial = Val(TextBox4.Text) * Industrial2
                    Case >= 301
                        Cpagoincial = Val(TextBox4.Text) * Industrial3

                End Select
                PagoIncial(INDICE) = Math.Round(Cpagoparcial, 2)

            End If
            If Val(TextBox3.Text) > 0 Then
                Crecargo = Val((TextBox3.Text) * CMora)
                Mora(INDICE) = (CMora * 100).ToString + "%"
            ElseIf Val(TextBox3.Text) <= 0 Then
                Mora(INDICE) = "No se aplica Mora"
            End If
            Cpagoconmora = Val(TextBox3.Text) + Crecargo
            PagoConMora(INDICE) = Math.Round(Cpagoconmora, 2)

            Select Case ComboBox2.Text
                Case "Social"
                    Cpagoparcial = (Val(TextBox3.Text) + Cpagoincial) + Crecargo
                    PagoParcial(INDICE) = Cpagoparcial

                    Ctarifa = Cpagoparcial * DescuentoSocial
                    Descuento(INDICE) = (DescuentoSocial * 100).ToString + "%"

                    Cpagototal = Cpagoparcial - Ctarifa
                    PagoTotal(INDICE) = Math.Round(Cpagototal, 2)

                Case "No Social"
                    Ctarifa = Cpagoparcial * DescuentoNoSocial
                    Descuento(INDICE) = (DescuentoNoSocial * 100).ToString + "%"

                    PagoIncial(INDICE) = Math.Round(Ctarifa, 2)

                    Cpagoparcial = Ctarifa + Cpagoconmora
                    PagoParcial(INDICE) = Math.Round(Cpagoparcial, 2)

                    Cpagototal = Cpagoparcial
                    PagoTotal(INDICE) = Math.Round(Cpagototal, 2)

            End Select
        End If

        Mostrardatos()
            INDICE = INDICE + 1


            If (INDICE = 11) Then
            MsgBox("VECTORES LLENOS")
        End If
        LIMPIAR_ENTRADAS()
    End Sub
End Class

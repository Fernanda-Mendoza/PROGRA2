Module Module1


    Public INSCRIPCIONES(7, 10) As String
    Public INDICE As Byte = 0

    Public Const InscripcionBasicos As Double = 350
    Public Const InscripcionDiversificado As Double = 450
    Public Const CuotaBasicos As Double = 250
    Public Const CuotaDiversificado As Double = 350
    Public PagoInicial As Double = 0

    Public Sub LIMPIAR_ENTRADAS()

        Form1.TXTNOMBRE.Text = ""
        Form1.TXTCARNET.Text = ""
        Form1.RDTBASICOS.Checked = False
        Form1.RDTDIVERSIFICADO.Checked = False
        Form1.CMBCARRERA.SelectedIndex = -1
        Form1.CMBFORMADEPAGO.SelectedIndex = -1

        Form1.TXTNOMBRE.Focus()

    End Sub
    Public Sub LIMPIAR_ESTADISTICAS()
        Form1.TXTTOTALG.Text = ""
        Form1.TXTTOTALEFECTIVO.Text = ""
        Form1.TXTTOTALTARJETA.Text = ""
        Form1.TXTTRANSFERENCIA.Text = ""
        Form1.TXTDEPOSITO.Text = ""
        Form1.TXTBASICOS.Text = ""
        Form1.TXTDIVERSIFICADO.Text = ""
        Form1.TXTPERITO.Text = ""
        Form1.TXTBACHILLERATO.Text = ""
        Form1.TXTELECTRONICA.Text = ""
        Form1.TXTDISEÑO.Text = ""
    End Sub

    Public Sub MOSTRAR()

        Dim i As Byte
        Form1.DataGridView1.Rows.Clear()

        For i = 0 To 6

            If (INSCRIPCIONES(i, 0) <> Nothing) Then

                Form1.DataGridView1.Rows.Add(INSCRIPCIONES(i, 0), INSCRIPCIONES(i, 1), INSCRIPCIONES(i, 2), INSCRIPCIONES(i, 3), INSCRIPCIONES(i, 4), INSCRIPCIONES(i, 5), INSCRIPCIONES(i, 6), INSCRIPCIONES(i, 7), INSCRIPCIONES(i, 8), INSCRIPCIONES(i, 9))

            Else
                Exit For
            End If
        Next i
    End Sub

End Module

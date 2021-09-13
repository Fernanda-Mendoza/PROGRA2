Module Module1
    Public INDICE As Byte = 0
    Public vfuncion(9)
    Public vcine(9)
    Public vcantidad(9)
    Public subtotal_a_pagar(9)
    Public vdescuento1(9)
    Public vdescuento2(9)
    Public total_a_pagar(9)


    Public calculo_subtotal As Double = 0
    Public calculo_desc1 As Double = 0
    Public calculo_desc2 As Double = 0
    Public calculo_total As Double = 0


    Function calcularSubtotal(funcion As String, cine As String) As Double

        Select Case cine
            Case "A"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 30
                    Case "2"
                        calculo_subtotal = 35
                    Case Else
                        calculo_subtotal = 40

                End Select
            Case "B"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 24
                    Case "2"
                        calculo_subtotal = 34
                    Case Else
                        calculo_subtotal = 39

                End Select
            Case "C"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 35
                    Case "2"
                        calculo_subtotal = 40
                    Case Else
                        calculo_subtotal = 50
                End Select
        End Select

        Return calculo_subtotal
    End Function

    Function calculoDescuento1(funcion As String, cine As String) As Double
        If (funcion = "3" Or funcion = "4") And (cine = "C" Or cine = "B") Then
            calculoDescuento1 = 0.055
        ElseIf (funcion = "1") And (cine = "C" Or cine = "B") Then
            calculoDescuento1 = 0.03
        ElseIf (funcion = "2") And (cine = "A") Then
            calculoDescuento1 = 0.015
        End If
        Return calculoDescuento1
    End Function
    Function calculoDescuento2(subtotal_a_pagar As String) As Double

        Select Case Val(subtotal_a_pagar)
            Case 100 To 300
                calculoDescuento2 = 0.02
            Case 301 To 500
                calculoDescuento2 = 0.04
            Case 501 To 1000
                calculoDescuento2 = 0.06

        End Select

        Return calculoDescuento2
    End Function
    Sub LIMPIAR_ENTRADAS()

        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.TXTCANTIDAD.Text = ""
        Form1.ComboBox1.Focus()
    End Sub

    Sub LimpiarVectores()
        Form1.Cine.Items.Clear()
        Form1.Función.Items.Clear()
        Form1.SubTotal.Items.Clear()
        Form1.Descuento_1.Items.Clear()
        Form1.Descuento_2.Items.Clear()
        Form1.Total.Items.Clear()

        INDICE = 0

    End Sub
End Module

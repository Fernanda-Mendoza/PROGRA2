Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TArroz.Clear()
        TFrijol.Clear()
        TAzucar.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("Desea Salir", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Const Parroz = 2.0
        Const Pfrijol = 1.75
        Const Pazucar = 2.5

        Dim arroz As Double, frijol As Double, azucar As Double
        arroz = Val(TArroz.Text)
        frijol = Val(TFrijol.Text)
        azucar = Val(TAzucar.Text)

        Dim sbarroz As Double, sbfrijol As Double, sbazucar As Double
        sbarroz = arroz * Parroz
        sbfrijol = frijol * Pfrijol
        sbazucar = azucar * Pazucar

        Dim TSIVA As Double, IVA As Double, PPCIVA As Double
        TSIVA = sbarroz + sbfrijol + sbazucar
        IVA = TSIVA * 0.12
        PPCIVA = TSIVA + IVA

        TextBox1.Text = "Q" + Str(System.Math.Round(TSIVA, 2))
        TextBox2.Text = "Q" + Str(System.Math.Round(IVA, 2))
        TextBox3.Text = "Q" + Str(System.Math.Round(PPCIVA, 2))

        Dim Descuento1 As Double
        If (PPCIVA > 15) Then
            Descuento1 = PPCIVA * 0.025
            TextBox4.Text = "Q" + Str(System.Math.Round(Descuento1, 2))
        Else
            Descuento1 = 0
            TextBox4.Text = "Q 0"
        End If

        Dim Descuento2 As Double
        If (frijol > 5) Then
            Descuento2 = PPCIVA * 0.03
            TextBox5.Text = "Q" + Str(System.Math.Round(Descuento2, 2))
        Else
            Descuento2 = 0
            TextBox5.Text = "Q 0"
        End If

        Dim Pagof As Double
        Pagof = PPCIVA - Descuento1 - Descuento2
        TextBox6.Text = "Q" + Str(System.Math.Round(Pagof, 2))
    End Sub


End Class

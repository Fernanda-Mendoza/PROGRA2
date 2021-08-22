Public Class Form1
    Sub Detallematerial()
        lino = preciolino * Val(TextBox1.Text)
        TextBox7.Text = lino

        algodon = precioalgodon * Val(TextBox2.Text)
        TextBox8.Text = algodon

        seda = precioseda * Val(TextBox3.Text)
        TextBox9.Text = seda

        hilocrudo = preciohilocrudo * Val(TextBox4.Text)
        TextBox10.Text = hilocrudo

    End Sub
    Sub limpiar()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        CheckBox1.Checked = 0
        CheckBox2.Checked = 0
        CheckBox3.Checked = 0
        CheckBox4.Checked = 0
        TextBox1.Focus()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            TextBox1.Visible = True
            TextBox1.Focus()
        Else
            TextBox1.Clear()
            TextBox1.Visible = False
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            TextBox2.Visible = True
            TextBox2.Focus()
        Else
            TextBox2.Clear()
            TextBox2.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked) Then
            TextBox3.Visible = True
            TextBox3.Focus()
        Else
            TextBox3.Clear()
            TextBox3.Visible = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If (CheckBox4.Checked) Then
            TextBox4.Visible = True
            TextBox4.Focus()
        Else
            TextBox4.Clear()
            TextBox4.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
        Else limpiar()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox5.Text = "0.00"
        preciocosto = 0.00
        sumayardas = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text)

        If RadioButton1.Checked = True Then
            If sumayardas = materialimperial Then
                preciocosto = precioimperial + (Val(TextBox1.Text) * preciolino) + (Val(TextBox2.Text) + precioalgodon) + (Val(TextBox3.Text) * precioseda) + (Val(TextBox4.Text) * preciohilocrudo)
                precioventa = preciocosto + (preciocosto * 0.65)
                Detallematerial()

            Else
                MsgBox("SE NECESITAN 3 YARDAS DE MATERIAL", vbOKOnly, "ERROR")

            End If

        ElseIf RadioButton2.Checked = True Then
            If sumayardas = materialmatrimonial Then
                preciocosto = preciomatrimonial + (Val(TextBox1.Text) * preciolino) + (Val(TextBox2.Text) + precioalgodon) + (Val(TextBox3.Text) * precioseda) + (Val(TextBox4.Text) * preciohilocrudo)
                precioventa = preciocosto + (preciocosto * 0.65)
                Detallematerial()

            Else
                MsgBox("SE NECESITAN 5 YARDAS DE MATERIAL", vbOKOnly, "ERROR")

            End If

        ElseIf RadioButton3.Checked Then
            If sumayardas = materialqueen Then
                preciocosto = precioqueen + (Val(TextBox1.Text) * preciolino) + (Val(TextBox2.Text) + precioalgodon) + (Val(TextBox3.Text) * precioseda) + (Val(TextBox4.Text) * preciohilocrudo)
                precioventa = preciocosto + (preciocosto * 0.65)
                Detallematerial()

            Else
                MsgBox("SE NECESITAN 6 YARDAS DE MATERIAL", vbOKOnly, "ERROR")

            End If

        ElseIf RadioButton4.Checked Then
            If sumayardas = materialking Then
                preciocosto = precioking + (Val(TextBox1.Text) * preciolino) + (Val(TextBox2.Text) * precioalgodon) + (Val(TextBox3.Text) * precioseda) + (Val(TextBox4.Text) * preciohilocrudo)
                precioventa = preciocosto + (preciocosto * 0.65)
                Detallematerial()

            Else
                MsgBox("SE NECESITAN 7 YARDAS DE MATERIAL", vbOKOnly, "ERROR")

            End If

        End If

        TextBox5.Text = Str(preciocosto)
        TextBox6.Text = Str(precioventa)

        
    End Sub


End Class

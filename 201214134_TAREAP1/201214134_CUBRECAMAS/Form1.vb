Public Class Form1
    Sub precio()
        txtpreciocosto.Text = Str(preciocosto)
        txtprecioventa.Text = Str(precioventa)
    End Sub
    Sub Detallematerial()
        lino = preciolino * Val(txtlino.Text)
        txtmateriallino.Text = lino

        algodon = precioalgodon * Val(txtalgodon.Text)
        txtmaterialalgodon.Text = algodon

        seda = precioseda * Val(txtseda.Text)
        txtmaterialseda.Text = seda

        hilocrudo = preciohilocrudo * Val(txthilocrudo.Text)
        txtmaterialhilocrudo.Text = hilocrudo

    End Sub
    Sub limpiar()
        txtlino.Clear()
        txtalgodon.Clear()
        txtseda.Clear()
        txthilocrudo.Clear()
        txtpreciocosto.Clear()
        txtprecioventa.Clear()
        txtmateriallino.Clear()
        txtmaterialalgodon.Clear()
        txtmaterialseda.Clear()
        txtmaterialhilocrudo.Clear()
        rdbimperial.Checked = False
        rdbmatrimonial.Checked = False
        rdbqueen.Checked = False
        rdbking.Checked = False
        ckblino.Checked = 0
        ckbalgodon.Checked = 0
        ckbseda.Checked = 0
        ckbhilocrudo.Checked = 0
        txtlino.Focus()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ckblino.CheckedChanged
        If (ckblino.Checked) Then
            txtlino.Visible = True
            txtlino.Focus()
        Else
            txtlino.Clear()
            txtlino.Visible = False
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles ckbalgodon.CheckedChanged
        If (ckbalgodon.Checked) Then
            txtalgodon.Visible = True
            txtalgodon.Focus()
        Else
            txtalgodon.Clear()
            txtalgodon.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles ckbseda.CheckedChanged
        If (ckbseda.Checked) Then
            txtseda.Visible = True
            txtseda.Focus()
        Else
            txtseda.Clear()
            txtseda.Visible = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles ckbhilocrudo.CheckedChanged
        If (ckbhilocrudo.Checked) Then
            txthilocrudo.Visible = True
            txthilocrudo.Focus()
        Else
            txthilocrudo.Clear()
            txthilocrudo.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
        Else limpiar()
            txtlino.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        txtpreciocosto.Text = "0.00"
        preciocosto = 0.00
        txtprecioventa.Text = "0.00"
        precioventa = 0.00

        sumayardas = Val(txtlino.Text) + Val(txtalgodon.Text) + Val(txtseda.Text) + Val(txthilocrudo.Text)

        If rdbimperial.Checked = True Then
            If sumayardas = materialimperial Then
                preciocosto = precioimperial + (Val(txtlino.Text) * preciolino) + (Val(txtalgodon.Text) + precioalgodon) + (Val(txtseda.Text) * precioseda) + (Val(txthilocrudo.Text) * preciohilocrudo)
                precioventa = preciocosto + (preciocosto * 0.65)
                Detallematerial()
                precio()

            Else
                MsgBox("SE NECESITAN 3 YARDAS DE MATERIAL", vbOKOnly, "ERROR")

            End If

        ElseIf rdbmatrimonial.Checked = True Then
            If sumayardas = materialmatrimonial Then
                preciocosto = preciomatrimonial + (Val(txtlino.Text) * preciolino) + (Val(txtalgodon.Text) + precioalgodon) + (Val(txtseda.Text) * precioseda) + (Val(txthilocrudo.Text) * preciohilocrudo)
                precioventa = preciocosto + (preciocosto * 0.65)
                Detallematerial()
                precio()

            Else
                MsgBox("SE NECESITAN 5 YARDAS DE MATERIAL", vbOKOnly, "ERROR")

            End If

        ElseIf rdbqueen.Checked Then
            If sumayardas = materialqueen Then
                preciocosto = precioqueen + (Val(txtlino.Text) * preciolino) + (Val(txtalgodon.Text) + precioalgodon) + (Val(txtseda.Text) * precioseda) + (Val(txthilocrudo.Text) * preciohilocrudo)
                precioventa = preciocosto + (preciocosto * 0.65)
                Detallematerial()
                precio()

            Else
                MsgBox("SE NECESITAN 6 YARDAS DE MATERIAL", vbOKOnly, "ERROR")

            End If

        ElseIf rdbking.Checked Then
            If sumayardas = materialking Then
                preciocosto = precioking + (Val(txtlino.Text) * preciolino) + (Val(txtalgodon.Text) * precioalgodon) + (Val(txtseda.Text) * precioseda) + (Val(txthilocrudo.Text) * preciohilocrudo)
                precioventa = preciocosto + (preciocosto * 0.65)
                Detallematerial()
                precio()


            Else
                MsgBox("SE NECESITAN 7 YARDAS DE MATERIAL", vbOKOnly, "ERROR")

            End If

        End If




    End Sub


End Class

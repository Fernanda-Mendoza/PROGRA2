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

    End Sub

    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub
End Class

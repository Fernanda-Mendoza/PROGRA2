Module Module1
    Public INDICE As Byte = 0
    Public Servicio(11) As String
    Public Tarifa(11) As String
    Public SaldoAnterior(11) As Integer
    Public PagoIncial(11) As Integer
    Public Mora(11) As Integer


    Sub LIMPIAR_ENTRADAS()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.TextBox1.Focus()
    End Sub
    Sub LimpiarVectores()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        Form1.ListBox9.Items.Clear()

    End Sub
End Module

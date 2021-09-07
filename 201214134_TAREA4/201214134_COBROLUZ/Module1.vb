Module Module1
    Public INDICE As Byte = 0
    Public Consumidor(11) As String
    Public Servicio(11) As String
    Public Tarifa(11) As String
    Public SaldoAnterior(11) As Integer
    Public PagoIncial(11) As Integer
    Public Mora(11) As Integer
    Public PagoConMora(11) As Integer
    Public PagoParcial(11) As Integer
    Public Descuento(11) As Integer
    Public PagoTotal(11) As Integer

    Public Const Residencial1 As Double = 0.99
    Public Const Residencial2 As Double = 1.2
    Public Const Residencial3 As Double = 3.0
    Public Const Industrial1 As Double = 1.99
    Public Const Industrial2 As Double = 2.2
    Public Const Industrial3 As Double = 4.0

    Public Cpagoincial As Double
    Public CMora As Double = 0.02
    Public Cpagoconmora As Double
    Public Cpagoparcial As Double
    Public Cdescuento As Double
    Public Cpagototal As Double
    Public Crecargo As Double
    Public Ctarifa As Double


    Public DescuentoSocial = 0.2
    Public DescuentoNoSocial = 0.1

    Sub Mostrardatos()
        Form1.ListBox1.Items.Add(Consumidor(INDICE))
        Form1.ListBox2.Items.Add(Servicio(INDICE))
        Form1.ListBox3.Items.Add(Tarifa(INDICE))
        Form1.ListBox4.Items.Add(SaldoAnterior(INDICE))
        Form1.ListBox5.Items.Add(PagoIncial(INDICE))
        Form1.ListBox6.Items.Add(Mora(INDICE))
        Form1.ListBox7.Items.Add(PagoConMora(INDICE))
        Form1.ListBox8.Items.Add(PagoParcial(INDICE))
        Form1.ListBox9.Items.Add(Descuento(INDICE))
        Form1.ListBox10.Items.Add(PagoTotal(INDICE))
    End Sub



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
        Form1.ListBox10.Items.Clear()

        INDICE = 0

    End Sub
End Module

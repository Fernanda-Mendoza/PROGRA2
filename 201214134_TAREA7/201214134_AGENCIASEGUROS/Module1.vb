Module Module1
    Public indice As Byte = 0

    Public Edad(7) As Integer
    Public Genero(7) As String
    Public Registro(7) As String
    Public Daños(7) As Integer
    Public Taller(7) As String
    Public Deducible(7) As Integer


    Public Sub LimpiarEntradas()

        Form1.TXTEDAD.Clear()
        Form1.CMBGENERO.SelectedIndex = -1
        Form1.CMBCODIGOREGISTRO.SelectedIndex = -1
        Form1.TXTMONTO.Clear()
        Form1.CMBTALLER.SelectedIndex = -1
        Form1.TXTTOTALMONTO.Clear()

    End Sub

End Module

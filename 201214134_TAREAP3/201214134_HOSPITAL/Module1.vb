Imports System.Math
Module Module1
    Public Pacientes(6, 10) As String
    Public fila As Byte = 0
    Public Const privado As Integer = 350
    Public Const semiprivado As Integer = 250
    Public Const noprivado As Integer = 150

    Sub limpiar_entradas()

        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""

        Form1.TextBox1.Focus()
    End Sub
    Sub limpiar_estadisticas()

        Form1.TextBox6.Clear()
        Form1.TextBox7.Clear()
        Form1.TextBox8.Clear()

    End Sub
    Sub limpiar_matriz()

        Form1.DataGridView1.Rows.Clear()

        fila = 0

        While (fila <= 5)
            Pacientes(fila, 0) = Nothing
            Pacientes(fila, 1) = Nothing
            Pacientes(fila, 2) = Nothing
            Pacientes(fila, 3) = Nothing
            Pacientes(fila, 4) = Nothing
            Pacientes(fila, 5) = Nothing
            Pacientes(fila, 6) = Nothing
            Pacientes(fila, 7) = Nothing
            Pacientes(fila, 8) = Nothing
            Pacientes(fila, 9) = Nothing

            fila = fila + 1
        End While
    End Sub
    Sub Mostrar_Matriz()

        Dim i As Byte
        Form1.DataGridView1.Rows.Clear()

        For i = 0 To 5
            If (Pacientes(i, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Pacientes(i, 0), Pacientes(i, 1), Pacientes(i, 2), Pacientes(i, 3), Pacientes(i, 4), Pacientes(i, 5), Pacientes(i, 6), Pacientes(i, 7), Pacientes(i, 8), Pacientes(i, 9))
            Else
                Exit For
            End If
        Next i

    End Sub

    Function comprobar_repetido() As Boolean
        Dim encontrado As Boolean = True

        fila = 0

        comprobar_repetido = True

        While (fila <= 5) And (encontrado)

            If (Pacientes(fila, 0) <> Nothing) Then

                If (Pacientes(fila, 1) = Val(Form1.TextBox2.Text)) Then
                    comprobar_repetido = encontrado = False
                    Return comprobar_repetido

                Else
                    fila = fila + 1
                End If
            Else
                Exit While
            End If
        End While
        If (encontrado) Then
            Return comprobar_repetido
        End If

    End Function
    Sub MostrarEstadisticas()
        Dim i As Byte
        Dim cantidad1 As Byte = 0
        Dim cantidad2 As Double = 0
        Dim cantidad3 As Double = 0

        While (i <= 5)
            If (Pacientes(i, 0) <> Nothing) Then
                If Pacientes(i, 4) = "1. Privada" Then
                    cantidad1 = cantidad1 + 1
                End If
                If Pacientes(i, 6) = "Transferencia ACH" Then
                    cantidad2 = cantidad2 + Val(Pacientes(i, 9))
                End If
                If Pacientes(i, 4) = "3. No Privada" Then
                    cantidad3 = cantidad3 + Val(Pacientes(i, 2))
                End If
                i = i + 1
            Else
                Exit While
            End If
        End While

        Form1.TextBox6.Text = Str(cantidad1)
        Form1.TextBox7.Text = Str(Round(cantidad2, 2))
        Form1.TextBox8.Text = Str(cantidad3)
    End Sub
End Module

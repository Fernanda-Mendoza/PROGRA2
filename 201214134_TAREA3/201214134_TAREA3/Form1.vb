Imports System.Math
Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTSALIR.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
        Else limpiar()
        End If
    End Sub

    Private Sub LIMP_Click(sender As Object, e As EventArgs) Handles BTLIMPIAR.Click
        limpiar()
    End Sub

    Private Sub CALC_Click(sender As Object, e As EventArgs) Handles BTCALC.Click

        Dim Res1, Res2, ResF As Double
        Res1 = Val(TBMON.Text) + Val(TBCHEOBC.Text) + Val(TBEFECC.Text) + Val(TBSALDA.Text)
        Res2 = Val(TBSALDA.Text)

        If RBAHO.Checked = True Then
            Select Case Res1
                Case 1 To 1000.99
                    ResF = (Val(Res1) * 0.015) + Val(Res1)
                Case 1001 To 5000.99
                    ResF = (Val(Res1) * 0.025) + Val(Res1)
                Case 5001 To 15000.99
                    ResF = (Val(Res1) * 0.075) + Val(Res1)
                Case >= 15001
                    ResF = (Val(Res1) * 0.1) + Val(Res1)
            End Select
        ElseIf RBMONP.Checked = True Then
            Select Case Res2
                Case 1 To 1000.99
                    ResF = (Val(Res2) * 0.025) + Val(Res2) + Val(TBMON.Text) + Val(TBCHEOBC.Text) + Val(TBEFECC.Text)
                Case 1001 To 15000.99
                    ResF = (Val(Res2) * 0.03) + Val(Res2) + Val(TBMON.Text) + Val(TBCHEOBC.Text) + Val(TBEFECC.Text)
                Case >= 15001
                    ResF = (Val(Res2) * 0.045) + Val(Res2) + Val(TBMON.Text) + Val(TBCHEOBC.Text) + Val(TBEFECC.Text)
            End Select
        ElseIf RBMON.Checked = True Then
            ResF = Val(Res2) + Val(TBMON.Text) + Val(TBCHEOBC.Text) + Val(TBEFECC.Text)
        End If

        TBSALDF.Text = Str(Round(ResF, 2))
    End Sub

    Private Sub CHEP_CheckedChanged(sender As Object, e As EventArgs) Handles CBCHEP.CheckedChanged

        If (CBCHEP.Checked) Then
            TBMON.Visible = True
            TBMON.Focus()
        Else
            TBMON.Clear()
            TBMON.Visible = False
        End If
    End Sub

    Private Sub CHEOB_CheckedChanged(sender As Object, e As EventArgs) Handles CBCHEOB.CheckedChanged

        If (CBCHEOB.Checked) Then
            TBCHEOBC.Visible = True
            TBCHEOBC.Focus()
        Else
            TBCHEOBC.Clear()
            TBCHEOBC.Visible = False
        End If
    End Sub

    Private Sub EFEC_CheckedChanged(sender As Object, e As EventArgs) Handles CBEFEC.CheckedChanged

        If (CBEFEC.Checked) Then
            TBEFECC.Visible = True
            TBEFECC.Focus()
        Else
            TBEFECC.Clear()
            TBEFECC.Visible = False
        End If
    End Sub
End Class

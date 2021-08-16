Module Module1
    Sub limpiar()
        Form1.RBMON.Checked = 0
        Form1.RBMONP.Checked = 0
        Form1.RBAHO.Checked = 0
        Form1.CBCHEP.Checked = False
        Form1.CBCHEOB.Checked = False
        Form1.CBEFEC.Checked = False
        Form1.TBMON.Clear()
        Form1.TBCHEOBC.Clear()
        Form1.TBEFECC.Clear()
        Form1.TBSALDA.Clear()
        Form1.TBSALDF.Clear()
    End Sub
End Module
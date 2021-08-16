<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTCALC = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TBSALDA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TBEFECC = New System.Windows.Forms.TextBox()
        Me.TBCHEOBC = New System.Windows.Forms.TextBox()
        Me.TBMON = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CBEFEC = New System.Windows.Forms.CheckBox()
        Me.CBCHEOB = New System.Windows.Forms.CheckBox()
        Me.CBCHEP = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBAHO = New System.Windows.Forms.RadioButton()
        Me.RBMONP = New System.Windows.Forms.RadioButton()
        Me.RBMON = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBSALDF = New System.Windows.Forms.TextBox()
        Me.BTLIMPIAR = New System.Windows.Forms.Button()
        Me.BTSALIR = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTCALC
        '
        Me.BTCALC.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTCALC.Location = New System.Drawing.Point(540, 263)
        Me.BTCALC.Name = "BTCALC"
        Me.BTCALC.Size = New System.Drawing.Size(115, 42)
        Me.BTCALC.TabIndex = 9
        Me.BTCALC.Text = "Calcular"
        Me.BTCALC.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TBSALDA)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(493, 181)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 64)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Saldo Anterior"
        '
        'TBSALDA
        '
        Me.TBSALDA.Location = New System.Drawing.Point(47, 26)
        Me.TBSALDA.Name = "TBSALDA"
        Me.TBSALDA.Size = New System.Drawing.Size(100, 26)
        Me.TBSALDA.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Q"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TBEFECC)
        Me.GroupBox3.Controls.Add(Me.TBCHEOBC)
        Me.GroupBox3.Controls.Add(Me.TBMON)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(273, 181)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 125)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Monto"
        '
        'TBEFECC
        '
        Me.TBEFECC.Location = New System.Drawing.Point(47, 91)
        Me.TBEFECC.Name = "TBEFECC"
        Me.TBEFECC.Size = New System.Drawing.Size(100, 26)
        Me.TBEFECC.TabIndex = 5
        '
        'TBCHEOBC
        '
        Me.TBCHEOBC.Location = New System.Drawing.Point(47, 59)
        Me.TBCHEOBC.Name = "TBCHEOBC"
        Me.TBCHEOBC.Size = New System.Drawing.Size(100, 26)
        Me.TBCHEOBC.TabIndex = 4
        '
        'TBMON
        '
        Me.TBMON.Location = New System.Drawing.Point(47, 26)
        Me.TBMON.Name = "TBMON"
        Me.TBMON.Size = New System.Drawing.Size(100, 26)
        Me.TBMON.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Q"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Q"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Q"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CBEFEC)
        Me.GroupBox2.Controls.Add(Me.CBCHEOB)
        Me.GroupBox2.Controls.Add(Me.CBCHEP)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 124)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Método de depósito"
        '
        'CBEFEC
        '
        Me.CBEFEC.AutoSize = True
        Me.CBEFEC.Location = New System.Drawing.Point(7, 88)
        Me.CBEFEC.Name = "CBEFEC"
        Me.CBEFEC.Size = New System.Drawing.Size(92, 24)
        Me.CBEFEC.TabIndex = 2
        Me.CBEFEC.Text = "Efectivo"
        Me.CBEFEC.UseVisualStyleBackColor = True
        '
        'CBCHEOB
        '
        Me.CBCHEOB.AutoSize = True
        Me.CBCHEOB.Location = New System.Drawing.Point(7, 57)
        Me.CBCHEOB.Name = "CBCHEOB"
        Me.CBCHEOB.Size = New System.Drawing.Size(217, 24)
        Me.CBCHEOB.TabIndex = 1
        Me.CBCHEOB.Text = "Cheques de otros bancos"
        Me.CBCHEOB.UseVisualStyleBackColor = True
        '
        'CBCHEP
        '
        Me.CBCHEP.AutoSize = True
        Me.CBCHEP.Location = New System.Drawing.Point(7, 26)
        Me.CBCHEP.Name = "CBCHEP"
        Me.CBCHEP.Size = New System.Drawing.Size(156, 24)
        Me.CBCHEP.TabIndex = 0
        Me.CBCHEP.Text = "Cheques Propios"
        Me.CBCHEP.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBAHO)
        Me.GroupBox1.Controls.Add(Me.RBMONP)
        Me.GroupBox1.Controls.Add(Me.RBMON)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 119)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipos de depósito"
        '
        'RBAHO
        '
        Me.RBAHO.AutoSize = True
        Me.RBAHO.Location = New System.Drawing.Point(7, 85)
        Me.RBAHO.Name = "RBAHO"
        Me.RBAHO.Size = New System.Drawing.Size(90, 24)
        Me.RBAHO.TabIndex = 2
        Me.RBAHO.TabStop = True
        Me.RBAHO.Text = "Ahorros"
        Me.RBAHO.UseVisualStyleBackColor = True
        '
        'RBMONP
        '
        Me.RBMONP.AutoSize = True
        Me.RBMONP.Location = New System.Drawing.Point(7, 57)
        Me.RBMONP.Name = "RBMONP"
        Me.RBMONP.Size = New System.Drawing.Size(171, 24)
        Me.RBMONP.TabIndex = 1
        Me.RBMONP.TabStop = True
        Me.RBMONP.Text = "Monetarios Premier"
        Me.RBMONP.UseVisualStyleBackColor = True
        '
        'RBMON
        '
        Me.RBMON.AutoSize = True
        Me.RBMON.Location = New System.Drawing.Point(7, 26)
        Me.RBMON.Name = "RBMON"
        Me.RBMON.Size = New System.Drawing.Size(113, 24)
        Me.RBMON.TabIndex = 0
        Me.RBMON.TabStop = True
        Me.RBMON.Text = "Monetarios"
        Me.RBMON.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Saldo Final"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(135, 345)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Q"
        '
        'TBSALDF
        '
        Me.TBSALDF.Location = New System.Drawing.Point(182, 338)
        Me.TBSALDF.Name = "TBSALDF"
        Me.TBSALDF.Size = New System.Drawing.Size(100, 26)
        Me.TBSALDF.TabIndex = 12
        '
        'BTLIMPIAR
        '
        Me.BTLIMPIAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTLIMPIAR.Location = New System.Drawing.Point(364, 341)
        Me.BTLIMPIAR.Name = "BTLIMPIAR"
        Me.BTLIMPIAR.Size = New System.Drawing.Size(109, 41)
        Me.BTLIMPIAR.TabIndex = 13
        Me.BTLIMPIAR.Text = "Limpiar"
        Me.BTLIMPIAR.UseVisualStyleBackColor = False
        '
        'BTSALIR
        '
        Me.BTSALIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTSALIR.Location = New System.Drawing.Point(517, 338)
        Me.BTSALIR.Name = "BTSALIR"
        Me.BTSALIR.Size = New System.Drawing.Size(107, 44)
        Me.BTSALIR.TabIndex = 14
        Me.BTSALIR.Text = "Salir"
        Me.BTSALIR.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(710, 431)
        Me.Controls.Add(Me.BTSALIR)
        Me.Controls.Add(Me.BTLIMPIAR)
        Me.Controls.Add(Me.TBSALDF)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTCALC)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTCALC As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TBSALDA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TBEFECC As TextBox
    Friend WithEvents TBCHEOBC As TextBox
    Friend WithEvents TBMON As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CBEFEC As CheckBox
    Friend WithEvents CBCHEOB As CheckBox
    Friend WithEvents CBCHEP As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBAHO As RadioButton
    Friend WithEvents RBMONP As RadioButton
    Friend WithEvents RBMON As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TBSALDF As TextBox
    Friend WithEvents BTLIMPIAR As Button
    Friend WithEvents BTSALIR As Button
End Class

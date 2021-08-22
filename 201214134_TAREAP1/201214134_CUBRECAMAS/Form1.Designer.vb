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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbking = New System.Windows.Forms.RadioButton()
        Me.rdbqueen = New System.Windows.Forms.RadioButton()
        Me.rdbmatrimonial = New System.Windows.Forms.RadioButton()
        Me.rdbimperial = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txthilocrudo = New System.Windows.Forms.TextBox()
        Me.txtseda = New System.Windows.Forms.TextBox()
        Me.txtalgodon = New System.Windows.Forms.TextBox()
        Me.txtlino = New System.Windows.Forms.TextBox()
        Me.ckbhilocrudo = New System.Windows.Forms.CheckBox()
        Me.ckbseda = New System.Windows.Forms.CheckBox()
        Me.ckbalgodon = New System.Windows.Forms.CheckBox()
        Me.ckblino = New System.Windows.Forms.CheckBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpreciocosto = New System.Windows.Forms.TextBox()
        Me.txtprecioventa = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtmaterialhilocrudo = New System.Windows.Forms.TextBox()
        Me.txtmaterialseda = New System.Windows.Forms.TextBox()
        Me.txtmaterialalgodon = New System.Windows.Forms.TextBox()
        Me.txtmateriallino = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbking)
        Me.GroupBox1.Controls.Add(Me.rdbqueen)
        Me.GroupBox1.Controls.Add(Me.rdbmatrimonial)
        Me.GroupBox1.Controls.Add(Me.rdbimperial)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño"
        '
        'rdbking
        '
        Me.rdbking.AutoSize = True
        Me.rdbking.Location = New System.Drawing.Point(6, 117)
        Me.rdbking.Name = "rdbking"
        Me.rdbking.Size = New System.Drawing.Size(65, 24)
        Me.rdbking.TabIndex = 3
        Me.rdbking.TabStop = True
        Me.rdbking.Text = "King"
        Me.rdbking.UseVisualStyleBackColor = True
        '
        'rdbqueen
        '
        Me.rdbqueen.AutoSize = True
        Me.rdbqueen.Location = New System.Drawing.Point(6, 86)
        Me.rdbqueen.Name = "rdbqueen"
        Me.rdbqueen.Size = New System.Drawing.Size(82, 24)
        Me.rdbqueen.TabIndex = 2
        Me.rdbqueen.TabStop = True
        Me.rdbqueen.Text = "Queen"
        Me.rdbqueen.UseVisualStyleBackColor = True
        '
        'rdbmatrimonial
        '
        Me.rdbmatrimonial.AutoSize = True
        Me.rdbmatrimonial.Location = New System.Drawing.Point(6, 55)
        Me.rdbmatrimonial.Name = "rdbmatrimonial"
        Me.rdbmatrimonial.Size = New System.Drawing.Size(115, 24)
        Me.rdbmatrimonial.TabIndex = 1
        Me.rdbmatrimonial.TabStop = True
        Me.rdbmatrimonial.Text = "Matrimonial"
        Me.rdbmatrimonial.UseVisualStyleBackColor = True
        '
        'rdbimperial
        '
        Me.rdbimperial.AutoSize = True
        Me.rdbimperial.Location = New System.Drawing.Point(6, 25)
        Me.rdbimperial.Name = "rdbimperial"
        Me.rdbimperial.Size = New System.Drawing.Size(90, 24)
        Me.rdbimperial.TabIndex = 0
        Me.rdbimperial.TabStop = True
        Me.rdbimperial.Text = "Imperial"
        Me.rdbimperial.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txthilocrudo)
        Me.GroupBox2.Controls.Add(Me.txtseda)
        Me.GroupBox2.Controls.Add(Me.txtalgodon)
        Me.GroupBox2.Controls.Add(Me.txtlino)
        Me.GroupBox2.Controls.Add(Me.ckbhilocrudo)
        Me.GroupBox2.Controls.Add(Me.ckbseda)
        Me.GroupBox2.Controls.Add(Me.ckbalgodon)
        Me.GroupBox2.Controls.Add(Me.ckblino)
        Me.GroupBox2.Location = New System.Drawing.Point(227, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 154)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material "
        '
        'txthilocrudo
        '
        Me.txthilocrudo.Location = New System.Drawing.Point(163, 120)
        Me.txthilocrudo.Name = "txthilocrudo"
        Me.txthilocrudo.Size = New System.Drawing.Size(100, 26)
        Me.txthilocrudo.TabIndex = 7
        Me.txthilocrudo.Text = "0"
        Me.txthilocrudo.Visible = False
        '
        'txtseda
        '
        Me.txtseda.Location = New System.Drawing.Point(163, 88)
        Me.txtseda.Name = "txtseda"
        Me.txtseda.Size = New System.Drawing.Size(100, 26)
        Me.txtseda.TabIndex = 6
        Me.txtseda.Text = "0"
        Me.txtseda.Visible = False
        '
        'txtalgodon
        '
        Me.txtalgodon.Location = New System.Drawing.Point(163, 56)
        Me.txtalgodon.Name = "txtalgodon"
        Me.txtalgodon.Size = New System.Drawing.Size(100, 26)
        Me.txtalgodon.TabIndex = 5
        Me.txtalgodon.Text = "0"
        Me.txtalgodon.Visible = False
        '
        'txtlino
        '
        Me.txtlino.Location = New System.Drawing.Point(163, 21)
        Me.txtlino.Name = "txtlino"
        Me.txtlino.Size = New System.Drawing.Size(100, 26)
        Me.txtlino.TabIndex = 4
        Me.txtlino.Text = "0"
        Me.txtlino.Visible = False
        '
        'ckbhilocrudo
        '
        Me.ckbhilocrudo.AutoSize = True
        Me.ckbhilocrudo.Location = New System.Drawing.Point(6, 118)
        Me.ckbhilocrudo.Name = "ckbhilocrudo"
        Me.ckbhilocrudo.Size = New System.Drawing.Size(106, 24)
        Me.ckbhilocrudo.TabIndex = 3
        Me.ckbhilocrudo.Text = "Hilo crudo"
        Me.ckbhilocrudo.UseVisualStyleBackColor = True
        '
        'ckbseda
        '
        Me.ckbseda.AutoSize = True
        Me.ckbseda.Location = New System.Drawing.Point(7, 87)
        Me.ckbseda.Name = "ckbseda"
        Me.ckbseda.Size = New System.Drawing.Size(73, 24)
        Me.ckbseda.TabIndex = 2
        Me.ckbseda.Text = "Seda"
        Me.ckbseda.UseVisualStyleBackColor = True
        '
        'ckbalgodon
        '
        Me.ckbalgodon.AutoSize = True
        Me.ckbalgodon.Location = New System.Drawing.Point(7, 56)
        Me.ckbalgodon.Name = "ckbalgodon"
        Me.ckbalgodon.Size = New System.Drawing.Size(94, 24)
        Me.ckbalgodon.TabIndex = 1
        Me.ckbalgodon.Text = "Algodón"
        Me.ckbalgodon.UseVisualStyleBackColor = True
        '
        'ckblino
        '
        Me.ckblino.AutoSize = True
        Me.ckblino.Location = New System.Drawing.Point(7, 24)
        Me.ckblino.Name = "ckblino"
        Me.ckblino.Size = New System.Drawing.Size(65, 24)
        Me.ckblino.TabIndex = 0
        Me.ckblino.Text = "Lino"
        Me.ckblino.UseVisualStyleBackColor = True
        '
        'btncalcular
        '
        Me.btncalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncalcular.Location = New System.Drawing.Point(570, 29)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(109, 48)
        Me.btncalcular.TabIndex = 2
        Me.btncalcular.Text = "CALCULAR"
        Me.btncalcular.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlimpiar.Location = New System.Drawing.Point(570, 97)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(109, 41)
        Me.btnlimpiar.TabIndex = 3
        Me.btnlimpiar.Text = "LIMPIAR"
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsalir.Location = New System.Drawing.Point(570, 150)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(109, 50)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(404, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Precio del Costo:  Q"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(404, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Precio Venta:  Q"
        '
        'txtpreciocosto
        '
        Me.txtpreciocosto.Location = New System.Drawing.Point(579, 239)
        Me.txtpreciocosto.Name = "txtpreciocosto"
        Me.txtpreciocosto.Size = New System.Drawing.Size(100, 26)
        Me.txtpreciocosto.TabIndex = 7
        '
        'txtprecioventa
        '
        Me.txtprecioventa.Location = New System.Drawing.Point(579, 298)
        Me.txtprecioventa.Name = "txtprecioventa"
        Me.txtprecioventa.Size = New System.Drawing.Size(100, 26)
        Me.txtprecioventa.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtmaterialhilocrudo)
        Me.GroupBox3.Controls.Add(Me.txtmaterialseda)
        Me.GroupBox3.Controls.Add(Me.txtmaterialalgodon)
        Me.GroupBox3.Controls.Add(Me.txtmateriallino)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 203)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(354, 159)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle del Precio de Costo: "
        '
        'txtmaterialhilocrudo
        '
        Me.txtmaterialhilocrudo.Location = New System.Drawing.Point(219, 124)
        Me.txtmaterialhilocrudo.Name = "txtmaterialhilocrudo"
        Me.txtmaterialhilocrudo.Size = New System.Drawing.Size(100, 26)
        Me.txtmaterialhilocrudo.TabIndex = 15
        '
        'txtmaterialseda
        '
        Me.txtmaterialseda.Location = New System.Drawing.Point(219, 92)
        Me.txtmaterialseda.Name = "txtmaterialseda"
        Me.txtmaterialseda.Size = New System.Drawing.Size(100, 26)
        Me.txtmaterialseda.TabIndex = 14
        '
        'txtmaterialalgodon
        '
        Me.txtmaterialalgodon.Location = New System.Drawing.Point(219, 60)
        Me.txtmaterialalgodon.Name = "txtmaterialalgodon"
        Me.txtmaterialalgodon.Size = New System.Drawing.Size(100, 26)
        Me.txtmaterialalgodon.TabIndex = 13
        '
        'txtmateriallino
        '
        Me.txtmateriallino.Location = New System.Drawing.Point(219, 27)
        Me.txtmateriallino.Name = "txtmateriallino"
        Me.txtmateriallino.Size = New System.Drawing.Size(100, 26)
        Me.txtmateriallino.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Material Hilo crudo:  Q"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Material Seda:  Q"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Material Algodón:  Q"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Material Lino:  Q"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 374)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtprecioventa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpreciocosto)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbking As RadioButton
    Friend WithEvents rdbqueen As RadioButton
    Friend WithEvents rdbmatrimonial As RadioButton
    Friend WithEvents rdbimperial As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ckbhilocrudo As CheckBox
    Friend WithEvents ckbseda As CheckBox
    Friend WithEvents ckbalgodon As CheckBox
    Friend WithEvents ckblino As CheckBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents txthilocrudo As TextBox
    Friend WithEvents txtseda As TextBox
    Friend WithEvents txtalgodon As TextBox
    Friend WithEvents txtlino As TextBox
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpreciocosto As TextBox
    Friend WithEvents txtprecioventa As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmaterialhilocrudo As TextBox
    Friend WithEvents txtmaterialseda As TextBox
    Friend WithEvents txtmaterialalgodon As TextBox
    Friend WithEvents txtmateriallino As TextBox
End Class

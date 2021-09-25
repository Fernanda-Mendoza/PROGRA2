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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTNIT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTPLACA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CMBMARCA = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTCANTIDAD = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarListasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTTARJETA = New System.Windows.Forms.TextBox()
        Me.TXTEFECTIVO = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LIST_PLACA = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LIST_FINAL = New System.Windows.Forms.ListBox()
        Me.LIST_NIT = New System.Windows.Forms.ListBox()
        Me.LIST_DESCUENTO = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LIST_PARCIAL = New System.Windows.Forms.ListBox()
        Me.LIST_DÍAS = New System.Windows.Forms.ListBox()
        Me.LIST_MARCA = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIT del Cliente"
        '
        'TXTNIT
        '
        Me.TXTNIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXTNIT.Location = New System.Drawing.Point(194, 62)
        Me.TXTNIT.Name = "TXTNIT"
        Me.TXTNIT.Size = New System.Drawing.Size(100, 26)
        Me.TXTNIT.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Placa del auto"
        '
        'TXTPLACA
        '
        Me.TXTPLACA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXTPLACA.Location = New System.Drawing.Point(194, 121)
        Me.TXTPLACA.Name = "TXTPLACA"
        Me.TXTPLACA.Size = New System.Drawing.Size(100, 26)
        Me.TXTPLACA.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(323, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Marca del auto"
        '
        'CMBMARCA
        '
        Me.CMBMARCA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CMBMARCA.FormattingEnabled = True
        Me.CMBMARCA.Items.AddRange(New Object() {"Honda", "Mercedes Benz", "Toyota", "Mazda"})
        Me.CMBMARCA.Location = New System.Drawing.Point(456, 60)
        Me.CMBMARCA.Name = "CMBMARCA"
        Me.CMBMARCA.Size = New System.Drawing.Size(121, 28)
        Me.CMBMARCA.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(323, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cantidad de días de Alquiler:"
        '
        'TXTCANTIDAD
        '
        Me.TXTCANTIDAD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXTCANTIDAD.Location = New System.Drawing.Point(560, 121)
        Me.TXTCANTIDAD.Name = "TXTCANTIDAD"
        Me.TXTCANTIDAD.Size = New System.Drawing.Size(100, 26)
        Me.TXTCANTIDAD.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.LimpiarListasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1139, 33)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(94, 29)
        Me.CalcularToolStripMenuItem.Text = "Calcular "
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(159, 30)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarListasToolStripMenuItem
        '
        Me.LimpiarListasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LimpiarListasToolStripMenuItem.Name = "LimpiarListasToolStripMenuItem"
        Me.LimpiarListasToolStripMenuItem.Size = New System.Drawing.Size(158, 30)
        Me.LimpiarListasToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTTARJETA)
        Me.GroupBox1.Controls.Add(Me.TXTEFECTIVO)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(726, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 125)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forma de pago:"
        '
        'TXTTARJETA
        '
        Me.TXTTARJETA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXTTARJETA.Location = New System.Drawing.Point(164, 77)
        Me.TXTTARJETA.Name = "TXTTARJETA"
        Me.TXTTARJETA.Size = New System.Drawing.Size(100, 26)
        Me.TXTTARJETA.TabIndex = 3
        Me.TXTTARJETA.Visible = False
        '
        'TXTEFECTIVO
        '
        Me.TXTEFECTIVO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXTEFECTIVO.Location = New System.Drawing.Point(164, 33)
        Me.TXTEFECTIVO.Name = "TXTEFECTIVO"
        Me.TXTEFECTIVO.Size = New System.Drawing.Size(100, 26)
        Me.TXTEFECTIVO.TabIndex = 2
        Me.TXTEFECTIVO.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(7, 77)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(84, 24)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Tarjeta"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 36)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 24)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Efectivo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LIST_PLACA
        '
        Me.LIST_PLACA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LIST_PLACA.FormattingEnabled = True
        Me.LIST_PLACA.ItemHeight = 20
        Me.LIST_PLACA.Location = New System.Drawing.Point(166, 54)
        Me.LIST_PLACA.Name = "LIST_PLACA"
        Me.LIST_PLACA.Size = New System.Drawing.Size(133, 144)
        Me.LIST_PLACA.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LIST_FINAL)
        Me.GroupBox2.Controls.Add(Me.LIST_NIT)
        Me.GroupBox2.Controls.Add(Me.LIST_DESCUENTO)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.LIST_PARCIAL)
        Me.GroupBox2.Controls.Add(Me.LIST_DÍAS)
        Me.GroupBox2.Controls.Add(Me.LIST_MARCA)
        Me.GroupBox2.Controls.Add(Me.LIST_PLACA)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1126, 212)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1005, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Pago Final"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "NIT del Cliente"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(816, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Descuento/Recargo"
        '
        'LIST_FINAL
        '
        Me.LIST_FINAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LIST_FINAL.FormattingEnabled = True
        Me.LIST_FINAL.ItemHeight = 20
        Me.LIST_FINAL.Location = New System.Drawing.Point(980, 55)
        Me.LIST_FINAL.Name = "LIST_FINAL"
        Me.LIST_FINAL.Size = New System.Drawing.Size(133, 144)
        Me.LIST_FINAL.TabIndex = 20
        '
        'LIST_NIT
        '
        Me.LIST_NIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LIST_NIT.FormattingEnabled = True
        Me.LIST_NIT.ItemHeight = 20
        Me.LIST_NIT.Location = New System.Drawing.Point(7, 55)
        Me.LIST_NIT.Name = "LIST_NIT"
        Me.LIST_NIT.Size = New System.Drawing.Size(133, 144)
        Me.LIST_NIT.TabIndex = 19
        '
        'LIST_DESCUENTO
        '
        Me.LIST_DESCUENTO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LIST_DESCUENTO.FormattingEnabled = True
        Me.LIST_DESCUENTO.ItemHeight = 20
        Me.LIST_DESCUENTO.Location = New System.Drawing.Point(820, 54)
        Me.LIST_DESCUENTO.Name = "LIST_DESCUENTO"
        Me.LIST_DESCUENTO.Size = New System.Drawing.Size(133, 144)
        Me.LIST_DESCUENTO.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(678, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Pago Parcial"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(506, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Días de Alquiler"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(362, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Marca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(201, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Placa"
        '
        'LIST_PARCIAL
        '
        Me.LIST_PARCIAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LIST_PARCIAL.FormattingEnabled = True
        Me.LIST_PARCIAL.ItemHeight = 20
        Me.LIST_PARCIAL.Location = New System.Drawing.Point(660, 54)
        Me.LIST_PARCIAL.Name = "LIST_PARCIAL"
        Me.LIST_PARCIAL.Size = New System.Drawing.Size(133, 144)
        Me.LIST_PARCIAL.TabIndex = 13
        '
        'LIST_DÍAS
        '
        Me.LIST_DÍAS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LIST_DÍAS.FormattingEnabled = True
        Me.LIST_DÍAS.ItemHeight = 20
        Me.LIST_DÍAS.Location = New System.Drawing.Point(497, 54)
        Me.LIST_DÍAS.Name = "LIST_DÍAS"
        Me.LIST_DÍAS.Size = New System.Drawing.Size(133, 144)
        Me.LIST_DÍAS.TabIndex = 12
        '
        'LIST_MARCA
        '
        Me.LIST_MARCA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LIST_MARCA.FormattingEnabled = True
        Me.LIST_MARCA.ItemHeight = 20
        Me.LIST_MARCA.Location = New System.Drawing.Point(331, 54)
        Me.LIST_MARCA.Name = "LIST_MARCA"
        Me.LIST_MARCA.Size = New System.Drawing.Size(133, 144)
        Me.LIST_MARCA.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1139, 432)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXTCANTIDAD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CMBMARCA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTPLACA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTNIT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TXTNIT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTPLACA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CMBMARCA As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTCANTIDAD As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarListasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXTTARJETA As TextBox
    Friend WithEvents TXTEFECTIVO As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LIST_PLACA As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LIST_PARCIAL As ListBox
    Friend WithEvents LIST_DÍAS As ListBox
    Friend WithEvents LIST_MARCA As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LIST_FINAL As ListBox
    Friend WithEvents LIST_NIT As ListBox
    Friend WithEvents LIST_DESCUENTO As ListBox
End Class

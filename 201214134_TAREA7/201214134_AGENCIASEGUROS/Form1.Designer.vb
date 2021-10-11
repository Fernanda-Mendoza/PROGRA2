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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularEstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNMOSTRAR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.CMBTALLER = New System.Windows.Forms.ComboBox()
        Me.TXTMONTO = New System.Windows.Forms.TextBox()
        Me.CMBCODIGOREGISTRO = New System.Windows.Forms.ComboBox()
        Me.CMBGENERO = New System.Windows.Forms.ComboBox()
        Me.TXTEDAD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.List_Deducible = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.List_Taller = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.List_MontoDeDaños = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.List_Registro = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.List_Género = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.List_Edad = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TXTCONDUCTORES = New System.Windows.Forms.TextBox()
        Me.TXTREGISTROEXTRANJERO = New System.Windows.Forms.TextBox()
        Me.TXT1825AÑOS = New System.Windows.Forms.TextBox()
        Me.TXTFEMENINO = New System.Windows.Forms.TextBox()
        Me.TXT25AÑOS = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BTNTOTAL = New System.Windows.Forms.Button()
        Me.TXTTOTALMONTO = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularEstadisticasToolStripMenuItem, Me.LimpiarEstadisticasToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1077, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularEstadisticasToolStripMenuItem
        '
        Me.CalcularEstadisticasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CalcularEstadisticasToolStripMenuItem.Name = "CalcularEstadisticasToolStripMenuItem"
        Me.CalcularEstadisticasToolStripMenuItem.Size = New System.Drawing.Size(184, 30)
        Me.CalcularEstadisticasToolStripMenuItem.Text = "Calcular Estadisticas"
        '
        'LimpiarEstadisticasToolStripMenuItem
        '
        Me.LimpiarEstadisticasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LimpiarEstadisticasToolStripMenuItem.Name = "LimpiarEstadisticasToolStripMenuItem"
        Me.LimpiarEstadisticasToolStripMenuItem.Size = New System.Drawing.Size(181, 30)
        Me.LimpiarEstadisticasToolStripMenuItem.Text = "Limpiar Estadisticas"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(159, 30)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(158, 30)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(61, 30)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNMOSTRAR)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Controls.Add(Me.CMBTALLER)
        Me.GroupBox1.Controls.Add(Me.TXTMONTO)
        Me.GroupBox1.Controls.Add(Me.CMBCODIGOREGISTRO)
        Me.GroupBox1.Controls.Add(Me.CMBGENERO)
        Me.GroupBox1.Controls.Add(Me.TXTEDAD)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 241)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Cliente"
        '
        'BTNMOSTRAR
        '
        Me.BTNMOSTRAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNMOSTRAR.Location = New System.Drawing.Point(373, 92)
        Me.BTNMOSTRAR.Name = "BTNMOSTRAR"
        Me.BTNMOSTRAR.Size = New System.Drawing.Size(104, 42)
        Me.BTNMOSTRAR.TabIndex = 11
        Me.BTNMOSTRAR.Text = "Mostrar"
        Me.BTNMOSTRAR.UseVisualStyleBackColor = False
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNGUARDAR.Location = New System.Drawing.Point(373, 26)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(104, 42)
        Me.BTNGUARDAR.TabIndex = 10
        Me.BTNGUARDAR.Text = "Guardar"
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'CMBTALLER
        '
        Me.CMBTALLER.FormattingEnabled = True
        Me.CMBTALLER.Items.AddRange(New Object() {"De Confianza", "De Aseguradora"})
        Me.CMBTALLER.Location = New System.Drawing.Point(65, 193)
        Me.CMBTALLER.Name = "CMBTALLER"
        Me.CMBTALLER.Size = New System.Drawing.Size(121, 28)
        Me.CMBTALLER.TabIndex = 9
        '
        'TXTMONTO
        '
        Me.TXTMONTO.Location = New System.Drawing.Point(259, 151)
        Me.TXTMONTO.Name = "TXTMONTO"
        Me.TXTMONTO.Size = New System.Drawing.Size(100, 26)
        Me.TXTMONTO.TabIndex = 8
        '
        'CMBCODIGOREGISTRO
        '
        Me.CMBCODIGOREGISTRO.FormattingEnabled = True
        Me.CMBCODIGOREGISTRO.Items.AddRange(New Object() {"1 - Guatemalteco", "0 - Extranjero"})
        Me.CMBCODIGOREGISTRO.Location = New System.Drawing.Point(163, 114)
        Me.CMBCODIGOREGISTRO.Name = "CMBCODIGOREGISTRO"
        Me.CMBCODIGOREGISTRO.Size = New System.Drawing.Size(121, 28)
        Me.CMBCODIGOREGISTRO.TabIndex = 7
        '
        'CMBGENERO
        '
        Me.CMBGENERO.FormattingEnabled = True
        Me.CMBGENERO.Items.AddRange(New Object() {"M", "F"})
        Me.CMBGENERO.Location = New System.Drawing.Point(83, 75)
        Me.CMBGENERO.Name = "CMBGENERO"
        Me.CMBGENERO.Size = New System.Drawing.Size(121, 28)
        Me.CMBGENERO.TabIndex = 6
        '
        'TXTEDAD
        '
        Me.TXTEDAD.Location = New System.Drawing.Point(83, 42)
        Me.TXTEDAD.Name = "TXTEDAD"
        Me.TXTEDAD.Size = New System.Drawing.Size(100, 26)
        Me.TXTEDAD.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Taller:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(246, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Monto de los daños ocasionados:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Código de Registro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Género:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edad:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.List_Deducible)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.List_Taller)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.List_MontoDeDaños)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.List_Registro)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.List_Género)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.List_Edad)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 314)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1031, 241)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'List_Deducible
        '
        Me.List_Deducible.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.List_Deducible.FormattingEnabled = True
        Me.List_Deducible.ItemHeight = 20
        Me.List_Deducible.Location = New System.Drawing.Point(857, 50)
        Me.List_Deducible.Name = "List_Deducible"
        Me.List_Deducible.Size = New System.Drawing.Size(120, 184)
        Me.List_Deducible.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(881, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Deducible"
        '
        'List_Taller
        '
        Me.List_Taller.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.List_Taller.FormattingEnabled = True
        Me.List_Taller.ItemHeight = 20
        Me.List_Taller.Location = New System.Drawing.Point(687, 50)
        Me.List_Taller.Name = "List_Taller"
        Me.List_Taller.Size = New System.Drawing.Size(120, 184)
        Me.List_Taller.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(715, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Taller"
        '
        'List_MontoDeDaños
        '
        Me.List_MontoDeDaños.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.List_MontoDeDaños.FormattingEnabled = True
        Me.List_MontoDeDaños.ItemHeight = 20
        Me.List_MontoDeDaños.Location = New System.Drawing.Point(522, 50)
        Me.List_MontoDeDaños.Name = "List_MontoDeDaños"
        Me.List_MontoDeDaños.Size = New System.Drawing.Size(120, 184)
        Me.List_MontoDeDaños.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(518, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Monto de Daños"
        '
        'List_Registro
        '
        Me.List_Registro.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.List_Registro.FormattingEnabled = True
        Me.List_Registro.ItemHeight = 20
        Me.List_Registro.Location = New System.Drawing.Point(353, 50)
        Me.List_Registro.Name = "List_Registro"
        Me.List_Registro.Size = New System.Drawing.Size(120, 184)
        Me.List_Registro.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(376, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Registro"
        '
        'List_Género
        '
        Me.List_Género.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.List_Género.FormattingEnabled = True
        Me.List_Género.ItemHeight = 20
        Me.List_Género.Location = New System.Drawing.Point(177, 50)
        Me.List_Género.Name = "List_Género"
        Me.List_Género.Size = New System.Drawing.Size(120, 184)
        Me.List_Género.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(201, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Género"
        '
        'List_Edad
        '
        Me.List_Edad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.List_Edad.FormattingEnabled = True
        Me.List_Edad.ItemHeight = 20
        Me.List_Edad.Location = New System.Drawing.Point(7, 50)
        Me.List_Edad.Name = "List_Edad"
        Me.List_Edad.Size = New System.Drawing.Size(120, 184)
        Me.List_Edad.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Edad"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TXTCONDUCTORES)
        Me.GroupBox3.Controls.Add(Me.TXTREGISTROEXTRANJERO)
        Me.GroupBox3.Controls.Add(Me.TXT1825AÑOS)
        Me.GroupBox3.Controls.Add(Me.TXTFEMENINO)
        Me.GroupBox3.Controls.Add(Me.TXT25AÑOS)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(546, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(519, 196)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estadisticas"
        '
        'TXTCONDUCTORES
        '
        Me.TXTCONDUCTORES.Location = New System.Drawing.Point(392, 155)
        Me.TXTCONDUCTORES.Name = "TXTCONDUCTORES"
        Me.TXTCONDUCTORES.Size = New System.Drawing.Size(100, 26)
        Me.TXTCONDUCTORES.TabIndex = 9
        '
        'TXTREGISTROEXTRANJERO
        '
        Me.TXTREGISTROEXTRANJERO.Location = New System.Drawing.Point(392, 123)
        Me.TXTREGISTROEXTRANJERO.Name = "TXTREGISTROEXTRANJERO"
        Me.TXTREGISTROEXTRANJERO.Size = New System.Drawing.Size(100, 26)
        Me.TXTREGISTROEXTRANJERO.TabIndex = 8
        '
        'TXT1825AÑOS
        '
        Me.TXT1825AÑOS.Location = New System.Drawing.Point(392, 91)
        Me.TXT1825AÑOS.Name = "TXT1825AÑOS"
        Me.TXT1825AÑOS.Size = New System.Drawing.Size(100, 26)
        Me.TXT1825AÑOS.TabIndex = 7
        '
        'TXTFEMENINO
        '
        Me.TXTFEMENINO.Location = New System.Drawing.Point(392, 57)
        Me.TXTFEMENINO.Name = "TXTFEMENINO"
        Me.TXTFEMENINO.Size = New System.Drawing.Size(100, 26)
        Me.TXTFEMENINO.TabIndex = 6
        '
        'TXT25AÑOS
        '
        Me.TXT25AÑOS.Location = New System.Drawing.Point(392, 25)
        Me.TXT25AÑOS.Name = "TXT25AÑOS"
        Me.TXT25AÑOS.Size = New System.Drawing.Size(100, 26)
        Me.TXT25AÑOS.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 155)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(245, 20)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Total de Conductores Ingresados"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 126)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(261, 20)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Conductores con registro extranjero"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(357, 20)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Conductores de género masculino de 18-25 años"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(246, 20)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Conductores de género femenino"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(249, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Conductores menores de 25 años"
        '
        'BTNTOTAL
        '
        Me.BTNTOTAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNTOTAL.Location = New System.Drawing.Point(979, 48)
        Me.BTNTOTAL.Name = "BTNTOTAL"
        Me.BTNTOTAL.Size = New System.Drawing.Size(72, 39)
        Me.BTNTOTAL.TabIndex = 15
        Me.BTNTOTAL.Text = "Total"
        Me.BTNTOTAL.UseVisualStyleBackColor = False
        '
        'TXTTOTALMONTO
        '
        Me.TXTTOTALMONTO.Location = New System.Drawing.Point(865, 61)
        Me.TXTTOTALMONTO.Name = "TXTTOTALMONTO"
        Me.TXTTOTALMONTO.Size = New System.Drawing.Size(100, 26)
        Me.TXTTOTALMONTO.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(545, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(296, 20)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Total de montos por daños ocasionados:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1077, 567)
        Me.Controls.Add(Me.BTNTOTAL)
        Me.Controls.Add(Me.TXTTOTALMONTO)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CMBTALLER As ComboBox
    Friend WithEvents TXTMONTO As TextBox
    Friend WithEvents CMBCODIGOREGISTRO As ComboBox
    Friend WithEvents CMBGENERO As ComboBox
    Friend WithEvents TXTEDAD As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTNMOSTRAR As Button
    Friend WithEvents BTNGUARDAR As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents List_Deducible As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents List_Taller As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents List_MontoDeDaños As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents List_Registro As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents List_Género As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents List_Edad As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CalcularEstadisticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEstadisticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TXTCONDUCTORES As TextBox
    Friend WithEvents TXTREGISTROEXTRANJERO As TextBox
    Friend WithEvents TXT1825AÑOS As TextBox
    Friend WithEvents TXTFEMENINO As TextBox
    Friend WithEvents TXT25AÑOS As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BTNTOTAL As Button
    Friend WithEvents TXTTOTALMONTO As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class

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
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTCARNET = New System.Windows.Forms.TextBox()
        Me.CMBCARRERA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CMBFORMADEPAGO = New System.Windows.Forms.ComboBox()
        Me.RDTBASICOS = New System.Windows.Forms.RadioButton()
        Me.RDTDIVERSIFICADO = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarMatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carnet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inscripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pago_Inicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Forma_de_Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNLIMPIAR = New System.Windows.Forms.Button()
        Me.BTNMOSTRAR = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TXTTOTALG = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TXTDISEÑO = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTELECTRONICA = New System.Windows.Forms.TextBox()
        Me.TXTBACHILLERATO = New System.Windows.Forms.TextBox()
        Me.TXTPERITO = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TXTDIVERSIFICADO = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTBASICOS = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TXTDEPOSITO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTTRANSFERENCIA = New System.Windows.Forms.TextBox()
        Me.TXTTOTALTARJETA = New System.Windows.Forms.TextBox()
        Me.TXTTOTALEFECTIVO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Alumno:"
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNOMBRE.Location = New System.Drawing.Point(182, 54)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(100, 26)
        Me.TXTNOMBRE.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Carnet:"
        '
        'TXTCARNET
        '
        Me.TXTCARNET.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTCARNET.Location = New System.Drawing.Point(182, 86)
        Me.TXTCARNET.Name = "TXTCARNET"
        Me.TXTCARNET.Size = New System.Drawing.Size(100, 26)
        Me.TXTCARNET.TabIndex = 3
        '
        'CMBCARRERA
        '
        Me.CMBCARRERA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBCARRERA.FormattingEnabled = True
        Me.CMBCARRERA.Items.AddRange(New Object() {"Perito contador", "Bachillerato", "Electrónica", "Diseño gráfico"})
        Me.CMBCARRERA.Location = New System.Drawing.Point(136, 55)
        Me.CMBCARRERA.Name = "CMBCARRERA"
        Me.CMBCARRERA.Size = New System.Drawing.Size(121, 28)
        Me.CMBCARRERA.TabIndex = 7
        Me.CMBCARRERA.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(319, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Forma de pago:"
        '
        'CMBFORMADEPAGO
        '
        Me.CMBFORMADEPAGO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBFORMADEPAGO.FormattingEnabled = True
        Me.CMBFORMADEPAGO.Items.AddRange(New Object() {"Efectivo", "Tarjeta de crédito", "Transferencia por ACH", "Depósito bancario"})
        Me.CMBFORMADEPAGO.Location = New System.Drawing.Point(446, 51)
        Me.CMBFORMADEPAGO.Name = "CMBFORMADEPAGO"
        Me.CMBFORMADEPAGO.Size = New System.Drawing.Size(193, 28)
        Me.CMBFORMADEPAGO.TabIndex = 9
        '
        'RDTBASICOS
        '
        Me.RDTBASICOS.AutoSize = True
        Me.RDTBASICOS.Location = New System.Drawing.Point(6, 25)
        Me.RDTBASICOS.Name = "RDTBASICOS"
        Me.RDTBASICOS.Size = New System.Drawing.Size(90, 24)
        Me.RDTBASICOS.TabIndex = 10
        Me.RDTBASICOS.TabStop = True
        Me.RDTBASICOS.Text = "Básicos"
        Me.RDTBASICOS.UseVisualStyleBackColor = True
        '
        'RDTDIVERSIFICADO
        '
        Me.RDTDIVERSIFICADO.AutoSize = True
        Me.RDTDIVERSIFICADO.Location = New System.Drawing.Point(6, 56)
        Me.RDTDIVERSIFICADO.Name = "RDTDIVERSIFICADO"
        Me.RDTDIVERSIFICADO.Size = New System.Drawing.Size(124, 24)
        Me.RDTDIVERSIFICADO.TabIndex = 11
        Me.RDTDIVERSIFICADO.TabStop = True
        Me.RDTDIVERSIFICADO.Text = "Diversificado"
        Me.RDTDIVERSIFICADO.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RDTBASICOS)
        Me.GroupBox1.Controls.Add(Me.RDTDIVERSIFICADO)
        Me.GroupBox1.Controls.Add(Me.CMBCARRERA)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 101)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nivel Estudios a Inscribirse:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.LimpiarMatrizToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1619, 33)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AceptarToolStripMenuItem
        '
        Me.AceptarToolStripMenuItem.BackColor = System.Drawing.Color.Fuchsia
        Me.AceptarToolStripMenuItem.Name = "AceptarToolStripMenuItem"
        Me.AceptarToolStripMenuItem.Size = New System.Drawing.Size(89, 29)
        Me.AceptarToolStripMenuItem.Text = "Aceptar"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.BackColor = System.Drawing.Color.Fuchsia
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(90, 29)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'LimpiarMatrizToolStripMenuItem
        '
        Me.LimpiarMatrizToolStripMenuItem.BackColor = System.Drawing.Color.Fuchsia
        Me.LimpiarMatrizToolStripMenuItem.Name = "LimpiarMatrizToolStripMenuItem"
        Me.LimpiarMatrizToolStripMenuItem.Size = New System.Drawing.Size(140, 29)
        Me.LimpiarMatrizToolStripMenuItem.Text = "Limpiar Matriz"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.BackColor = System.Drawing.Color.Fuchsia
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(159, 29)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.Fuchsia
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Carnet, Me.Nivel, Me.Carrera, Me.Inscripción, Me.Cuota, Me.Pago_Inicial, Me.Forma_de_Pago, Me.Recargo, Me.Total})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 262)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1595, 227)
        Me.DataGridView1.TabIndex = 14
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 8
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 80
        '
        'Carnet
        '
        Me.Carnet.HeaderText = "Carnet"
        Me.Carnet.MinimumWidth = 8
        Me.Carnet.Name = "Carnet"
        Me.Carnet.Width = 80
        '
        'Nivel
        '
        Me.Nivel.HeaderText = "Nivel"
        Me.Nivel.MinimumWidth = 8
        Me.Nivel.Name = "Nivel"
        Me.Nivel.Width = 130
        '
        'Carrera
        '
        Me.Carrera.HeaderText = "Carrera"
        Me.Carrera.MinimumWidth = 8
        Me.Carrera.Name = "Carrera"
        Me.Carrera.Width = 150
        '
        'Inscripción
        '
        Me.Inscripción.HeaderText = "Inscripción"
        Me.Inscripción.MinimumWidth = 8
        Me.Inscripción.Name = "Inscripción"
        Me.Inscripción.Width = 150
        '
        'Cuota
        '
        Me.Cuota.HeaderText = "Cuota"
        Me.Cuota.MinimumWidth = 8
        Me.Cuota.Name = "Cuota"
        Me.Cuota.Width = 60
        '
        'Pago_Inicial
        '
        Me.Pago_Inicial.HeaderText = "Pago Inicial"
        Me.Pago_Inicial.MinimumWidth = 8
        Me.Pago_Inicial.Name = "Pago_Inicial"
        Me.Pago_Inicial.Width = 80
        '
        'Forma_de_Pago
        '
        Me.Forma_de_Pago.HeaderText = "Forma de Pago"
        Me.Forma_de_Pago.MinimumWidth = 8
        Me.Forma_de_Pago.Name = "Forma_de_Pago"
        Me.Forma_de_Pago.Width = 150
        '
        'Recargo
        '
        Me.Recargo.HeaderText = "Recargo"
        Me.Recargo.MinimumWidth = 8
        Me.Recargo.Name = "Recargo"
        Me.Recargo.Width = 60
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 8
        Me.Total.Name = "Total"
        Me.Total.Width = 60
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.BTNLIMPIAR)
        Me.GroupBox2.Controls.Add(Me.BTNMOSTRAR)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(269, 508)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1012, 309)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados:"
        '
        'BTNLIMPIAR
        '
        Me.BTNLIMPIAR.BackColor = System.Drawing.Color.Fuchsia
        Me.BTNLIMPIAR.Location = New System.Drawing.Point(709, 140)
        Me.BTNLIMPIAR.Name = "BTNLIMPIAR"
        Me.BTNLIMPIAR.Size = New System.Drawing.Size(185, 71)
        Me.BTNLIMPIAR.TabIndex = 8
        Me.BTNLIMPIAR.Text = "Limpiar Estadisticas"
        Me.BTNLIMPIAR.UseVisualStyleBackColor = False
        '
        'BTNMOSTRAR
        '
        Me.BTNMOSTRAR.BackColor = System.Drawing.Color.Fuchsia
        Me.BTNMOSTRAR.Location = New System.Drawing.Point(709, 36)
        Me.BTNMOSTRAR.Name = "BTNMOSTRAR"
        Me.BTNMOSTRAR.Size = New System.Drawing.Size(185, 71)
        Me.BTNMOSTRAR.TabIndex = 7
        Me.BTNMOSTRAR.Text = "Mostrar Estadisticas"
        Me.BTNMOSTRAR.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.TXTTOTALG)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Location = New System.Drawing.Point(15, 24)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(295, 47)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        '
        'TXTTOTALG
        '
        Me.TXTTOTALG.Location = New System.Drawing.Point(180, 12)
        Me.TXTTOTALG.Name = "TXTTOTALG"
        Me.TXTTOTALG.Size = New System.Drawing.Size(100, 26)
        Me.TXTTOTALG.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total General:  (Q)"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.TXTDISEÑO)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.TXTELECTRONICA)
        Me.GroupBox5.Controls.Add(Me.TXTBACHILLERATO)
        Me.GroupBox5.Controls.Add(Me.TXTPERITO)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Location = New System.Drawing.Point(359, 126)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(277, 162)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Total Inscritos por carrera:  (Q)"
        '
        'TXTDISEÑO
        '
        Me.TXTDISEÑO.Location = New System.Drawing.Point(138, 128)
        Me.TXTDISEÑO.Name = "TXTDISEÑO"
        Me.TXTDISEÑO.Size = New System.Drawing.Size(100, 26)
        Me.TXTDISEÑO.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Diseño gráfico:"
        '
        'TXTELECTRONICA
        '
        Me.TXTELECTRONICA.Location = New System.Drawing.Point(138, 94)
        Me.TXTELECTRONICA.Name = "TXTELECTRONICA"
        Me.TXTELECTRONICA.Size = New System.Drawing.Size(100, 26)
        Me.TXTELECTRONICA.TabIndex = 13
        '
        'TXTBACHILLERATO
        '
        Me.TXTBACHILLERATO.Location = New System.Drawing.Point(138, 59)
        Me.TXTBACHILLERATO.Name = "TXTBACHILLERATO"
        Me.TXTBACHILLERATO.Size = New System.Drawing.Size(100, 26)
        Me.TXTBACHILLERATO.TabIndex = 12
        '
        'TXTPERITO
        '
        Me.TXTPERITO.Location = New System.Drawing.Point(138, 27)
        Me.TXTPERITO.Name = "TXTPERITO"
        Me.TXTPERITO.Size = New System.Drawing.Size(100, 26)
        Me.TXTPERITO.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(34, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 20)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Electrónica:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 20)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Bachillerato:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 20)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Perito contador:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.TXTDIVERSIFICADO)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.TXTBASICOS)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(359, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(277, 105)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total Por Nivel:  (Q)"
        '
        'TXTDIVERSIFICADO
        '
        Me.TXTDIVERSIFICADO.Location = New System.Drawing.Point(124, 66)
        Me.TXTDIVERSIFICADO.Name = "TXTDIVERSIFICADO"
        Me.TXTDIVERSIFICADO.Size = New System.Drawing.Size(100, 26)
        Me.TXTDIVERSIFICADO.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Diversificado:"
        '
        'TXTBASICOS
        '
        Me.TXTBASICOS.Location = New System.Drawing.Point(125, 33)
        Me.TXTBASICOS.Name = "TXTBASICOS"
        Me.TXTBASICOS.Size = New System.Drawing.Size(100, 26)
        Me.TXTBASICOS.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Básicos:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.TXTDEPOSITO)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TXTTRANSFERENCIA)
        Me.GroupBox3.Controls.Add(Me.TXTTOTALTARJETA)
        Me.GroupBox3.Controls.Add(Me.TXTTOTALEFECTIVO)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 82)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(297, 200)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total en forma de pago:  (Q)"
        '
        'TXTDEPOSITO
        '
        Me.TXTDEPOSITO.Location = New System.Drawing.Point(188, 146)
        Me.TXTDEPOSITO.Name = "TXTDEPOSITO"
        Me.TXTDEPOSITO.Size = New System.Drawing.Size(100, 26)
        Me.TXTDEPOSITO.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Depósito bancario:"
        '
        'TXTTRANSFERENCIA
        '
        Me.TXTTRANSFERENCIA.Location = New System.Drawing.Point(188, 109)
        Me.TXTTRANSFERENCIA.Name = "TXTTRANSFERENCIA"
        Me.TXTTRANSFERENCIA.Size = New System.Drawing.Size(100, 26)
        Me.TXTTRANSFERENCIA.TabIndex = 5
        '
        'TXTTOTALTARJETA
        '
        Me.TXTTOTALTARJETA.Location = New System.Drawing.Point(188, 74)
        Me.TXTTOTALTARJETA.Name = "TXTTOTALTARJETA"
        Me.TXTTOTALTARJETA.Size = New System.Drawing.Size(100, 26)
        Me.TXTTOTALTARJETA.TabIndex = 4
        '
        'TXTTOTALEFECTIVO
        '
        Me.TXTTOTALEFECTIVO.Location = New System.Drawing.Point(188, 35)
        Me.TXTTOTALEFECTIVO.Name = "TXTTOTALEFECTIVO"
        Me.TXTTOTALEFECTIVO.Size = New System.Drawing.Size(100, 26)
        Me.TXTTOTALEFECTIVO.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Transferencia por ACH:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tarjeta de crédito:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Efectivo:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1619, 845)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CMBFORMADEPAGO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTCARNET)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTNOMBRE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTCARNET As TextBox
    Friend WithEvents CMBCARRERA As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CMBFORMADEPAGO As ComboBox
    Friend WithEvents RDTBASICOS As RadioButton
    Friend WithEvents RDTDIVERSIFICADO As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AceptarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarMatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TXTDISEÑO As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TXTELECTRONICA As TextBox
    Friend WithEvents TXTBACHILLERATO As TextBox
    Friend WithEvents TXTPERITO As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TXTDIVERSIFICADO As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXTBASICOS As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTTOTALG As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXTDEPOSITO As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTTRANSFERENCIA As TextBox
    Friend WithEvents TXTTOTALTARJETA As TextBox
    Friend WithEvents TXTTOTALEFECTIVO As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BTNLIMPIAR As Button
    Friend WithEvents BTNMOSTRAR As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Carnet As DataGridViewTextBoxColumn
    Friend WithEvents Nivel As DataGridViewTextBoxColumn
    Friend WithEvents Carrera As DataGridViewTextBoxColumn
    Friend WithEvents Inscripción As DataGridViewTextBoxColumn
    Friend WithEvents Cuota As DataGridViewTextBoxColumn
    Friend WithEvents Pago_Inicial As DataGridViewTextBoxColumn
    Friend WithEvents Forma_de_Pago As DataGridViewTextBoxColumn
    Friend WithEvents Recargo As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class

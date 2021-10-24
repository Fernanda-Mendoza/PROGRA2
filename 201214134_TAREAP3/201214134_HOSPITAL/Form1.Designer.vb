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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarMatrizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEstadisticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Días_Hospitalizado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Honorarios_del_Médico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_de_habitación = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Habitación = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_de_Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pago_Parcial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc_Reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pago_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del paciente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Número de nit:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Número de días hospitalizado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Honorarios del médico (Q): "
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightCyan
        Me.TextBox1.Location = New System.Drawing.Point(176, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.LightCyan
        Me.TextBox2.Location = New System.Drawing.Point(129, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.LightCyan
        Me.TextBox3.Location = New System.Drawing.Point(238, 85)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 26)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.LightCyan
        Me.TextBox4.Location = New System.Drawing.Point(209, 116)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 26)
        Me.TextBox4.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Cyan
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(418, 215)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información del Paciente:"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.LightCyan
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Efectivo", "Transferencia ACH", "Depósito Bancario", "Tarjeta de crédito", "Seguro Médico"})
        Me.ComboBox2.Location = New System.Drawing.Point(273, 176)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox2.TabIndex = 14
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.LightCyan
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1. Privada", "2. Semiprivada", "3. No Privada"})
        Me.ComboBox1.Location = New System.Drawing.Point(176, 146)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(256, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tipo de pago por la hospitalización:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tipo de habitación:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarMatrizToolStripMenuItem, Me.EstadisticaToolStripMenuItem, Me.LimpiarEstadisticaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1924, 33)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AceptarToolStripMenuItem
        '
        Me.AceptarToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine
        Me.AceptarToolStripMenuItem.Name = "AceptarToolStripMenuItem"
        Me.AceptarToolStripMenuItem.Size = New System.Drawing.Size(89, 29)
        Me.AceptarToolStripMenuItem.Text = "Aceptar"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(90, 29)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(103, 29)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(159, 29)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarMatrizToolStripMenuItem
        '
        Me.LimpiarMatrizToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine
        Me.LimpiarMatrizToolStripMenuItem.Name = "LimpiarMatrizToolStripMenuItem"
        Me.LimpiarMatrizToolStripMenuItem.Size = New System.Drawing.Size(140, 29)
        Me.LimpiarMatrizToolStripMenuItem.Text = "Limpiar Matriz"
        '
        'EstadisticaToolStripMenuItem
        '
        Me.EstadisticaToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine
        Me.EstadisticaToolStripMenuItem.Name = "EstadisticaToolStripMenuItem"
        Me.EstadisticaToolStripMenuItem.Size = New System.Drawing.Size(110, 29)
        Me.EstadisticaToolStripMenuItem.Text = "Estadistica"
        '
        'LimpiarEstadisticaToolStripMenuItem
        '
        Me.LimpiarEstadisticaToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine
        Me.LimpiarEstadisticaToolStripMenuItem.Name = "LimpiarEstadisticaToolStripMenuItem"
        Me.LimpiarEstadisticaToolStripMenuItem.Size = New System.Drawing.Size(173, 29)
        Me.LimpiarEstadisticaToolStripMenuItem.Text = "Limpiar Estadistica"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Cyan
        Me.GroupBox4.Controls.Add(Me.TextBox5)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(468, 61)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(147, 133)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Consultar:"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.LightCyan
        Me.TextBox5.Location = New System.Drawing.Point(23, 76)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 26)
        Me.TextBox5.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Número de nit:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.NIT, Me.Días_Hospitalizado, Me.Honorarios_del_Médico, Me.Tipo_de_habitación, Me.Precio_Habitación, Me.Tipo_de_Pago, Me.Pago_Parcial, Me.Desc_Reg, Me.Pago_Total})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 283)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1462, 207)
        Me.DataGridView1.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cyan
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(640, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 175)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estadisticas:"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.LightCyan
        Me.TextBox8.Location = New System.Drawing.Point(339, 130)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 26)
        Me.TextBox8.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.LightCyan
        Me.TextBox7.Location = New System.Drawing.Point(391, 82)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 26)
        Me.TextBox7.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.LightCyan
        Me.TextBox6.Location = New System.Drawing.Point(357, 33)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 26)
        Me.TextBox6.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(325, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Cuántos días se utilizó habitación no privada:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(368, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "El total (Q) de lo recaudado por transferencia ACH:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(331, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Cuántos pacientes usaron habitación privada:"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 8
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 80
        '
        'NIT
        '
        Me.NIT.HeaderText = "Número de NIT"
        Me.NIT.MinimumWidth = 8
        Me.NIT.Name = "NIT"
        Me.NIT.Width = 80
        '
        'Días_Hospitalizado
        '
        Me.Días_Hospitalizado.HeaderText = "Días Hospitalizado"
        Me.Días_Hospitalizado.MinimumWidth = 8
        Me.Días_Hospitalizado.Name = "Días_Hospitalizado"
        Me.Días_Hospitalizado.Width = 80
        '
        'Honorarios_del_Médico
        '
        Me.Honorarios_del_Médico.HeaderText = "Honorarios del Médico"
        Me.Honorarios_del_Médico.MinimumWidth = 8
        Me.Honorarios_del_Médico.Name = "Honorarios_del_Médico"
        Me.Honorarios_del_Médico.Width = 70
        '
        'Tipo_de_habitación
        '
        Me.Tipo_de_habitación.HeaderText = "Tipo de habitación"
        Me.Tipo_de_habitación.MinimumWidth = 8
        Me.Tipo_de_habitación.Name = "Tipo_de_habitación"
        Me.Tipo_de_habitación.Width = 150
        '
        'Precio_Habitación
        '
        Me.Precio_Habitación.HeaderText = "Precio Habitación"
        Me.Precio_Habitación.MinimumWidth = 8
        Me.Precio_Habitación.Name = "Precio_Habitación"
        Me.Precio_Habitación.Width = 70
        '
        'Tipo_de_Pago
        '
        Me.Tipo_de_Pago.HeaderText = "Tipo de Pago"
        Me.Tipo_de_Pago.MinimumWidth = 8
        Me.Tipo_de_Pago.Name = "Tipo_de_Pago"
        Me.Tipo_de_Pago.Width = 150
        '
        'Pago_Parcial
        '
        Me.Pago_Parcial.HeaderText = "Pago Parcial"
        Me.Pago_Parcial.MinimumWidth = 8
        Me.Pago_Parcial.Name = "Pago_Parcial"
        Me.Pago_Parcial.Width = 70
        '
        'Desc_Reg
        '
        Me.Desc_Reg.HeaderText = "Desc. / Reg."
        Me.Desc_Reg.MinimumWidth = 8
        Me.Desc_Reg.Name = "Desc_Reg"
        Me.Desc_Reg.Width = 70
        '
        'Pago_Total
        '
        Me.Pago_Total.HeaderText = "Pago Total"
        Me.Pago_Total.MinimumWidth = 8
        Me.Pago_Total.Name = "Pago_Total"
        Me.Pago_Total.Width = 70
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(1924, 512)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AceptarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarMatrizToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadisticaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEstadisticaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents NIT As DataGridViewTextBoxColumn
    Friend WithEvents Días_Hospitalizado As DataGridViewTextBoxColumn
    Friend WithEvents Honorarios_del_Médico As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_de_habitación As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Habitación As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_de_Pago As DataGridViewTextBoxColumn
    Friend WithEvents Pago_Parcial As DataGridViewTextBoxColumn
    Friend WithEvents Desc_Reg As DataGridViewTextBoxColumn
    Friend WithEvents Pago_Total As DataGridViewTextBoxColumn
End Class

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTCANTIDAD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Total = New System.Windows.Forms.ListBox()
        Me.Descuento_2 = New System.Windows.Forms.ListBox()
        Me.Descuento_1 = New System.Windows.Forms.ListBox()
        Me.SubTotal = New System.Windows.Forms.ListBox()
        Me.Función = New System.Windows.Forms.ListBox()
        Me.Cine = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTCANTIDAD)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrada"
        '
        'TXTCANTIDAD
        '
        Me.TXTCANTIDAD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTCANTIDAD.Location = New System.Drawing.Point(169, 120)
        Me.TXTCANTIDAD.Name = "TXTCANTIDAD"
        Me.TXTCANTIDAD.Size = New System.Drawing.Size(121, 26)
        Me.TXTCANTIDAD.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Número de Entradas"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBox2.Location = New System.Drawing.Point(82, 77)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox2.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"A", "B", "C"})
        Me.ComboBox1.Location = New System.Drawing.Point(82, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Función "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cine"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Total)
        Me.GroupBox2.Controls.Add(Me.Descuento_2)
        Me.GroupBox2.Controls.Add(Me.Descuento_1)
        Me.GroupBox2.Controls.Add(Me.SubTotal)
        Me.GroupBox2.Controls.Add(Me.Función)
        Me.GroupBox2.Controls.Add(Me.Cine)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1025, 284)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'Total
        '
        Me.Total.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Total.FormattingEnabled = True
        Me.Total.ItemHeight = 20
        Me.Total.Location = New System.Drawing.Point(869, 25)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(145, 244)
        Me.Total.TabIndex = 5
        '
        'Descuento_2
        '
        Me.Descuento_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Descuento_2.FormattingEnabled = True
        Me.Descuento_2.ItemHeight = 20
        Me.Descuento_2.Location = New System.Drawing.Point(697, 26)
        Me.Descuento_2.Name = "Descuento_2"
        Me.Descuento_2.Size = New System.Drawing.Size(145, 244)
        Me.Descuento_2.TabIndex = 4
        '
        'Descuento_1
        '
        Me.Descuento_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Descuento_1.FormattingEnabled = True
        Me.Descuento_1.ItemHeight = 20
        Me.Descuento_1.Location = New System.Drawing.Point(524, 25)
        Me.Descuento_1.Name = "Descuento_1"
        Me.Descuento_1.Size = New System.Drawing.Size(145, 244)
        Me.Descuento_1.TabIndex = 3
        '
        'SubTotal
        '
        Me.SubTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubTotal.FormattingEnabled = True
        Me.SubTotal.ItemHeight = 20
        Me.SubTotal.Location = New System.Drawing.Point(348, 25)
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Size = New System.Drawing.Size(145, 244)
        Me.SubTotal.TabIndex = 2
        '
        'Función
        '
        Me.Función.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Función.FormattingEnabled = True
        Me.Función.ItemHeight = 20
        Me.Función.Location = New System.Drawing.Point(176, 25)
        Me.Función.Name = "Función"
        Me.Función.Size = New System.Drawing.Size(145, 244)
        Me.Función.TabIndex = 1
        '
        'Cine
        '
        Me.Cine.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cine.FormattingEnabled = True
        Me.Cine.ItemHeight = 20
        Me.Cine.Location = New System.Drawing.Point(7, 26)
        Me.Cine.Name = "Cine"
        Me.Cine.Size = New System.Drawing.Size(145, 244)
        Me.Cine.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1075, 33)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AceptarToolStripMenuItem
        '
        Me.AceptarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AceptarToolStripMenuItem.Name = "AceptarToolStripMenuItem"
        Me.AceptarToolStripMenuItem.Size = New System.Drawing.Size(89, 29)
        Me.AceptarToolStripMenuItem.Text = "Aceptar"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(159, 29)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(158, 29)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(494, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(505, 126)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1075, 515)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Total As ListBox
    Friend WithEvents Descuento_2 As ListBox
    Friend WithEvents Descuento_1 As ListBox
    Friend WithEvents SubTotal As ListBox
    Friend WithEvents Función As ListBox
    Friend WithEvents Cine As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AceptarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TXTCANTIDAD As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio10_Andres
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ejercicio10_Andres))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUnidades = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.txtVelocidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.lblInstruccion = New System.Windows.Forms.Label()
        Me.lblTítulo = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbCalcular = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.lblUnidades)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblAutor)
        Me.Panel1.Controls.Add(Me.txtVelocidad)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblAltura)
        Me.Panel1.Controls.Add(Me.txtAltura)
        Me.Panel1.Controls.Add(Me.lblInstruccion)
        Me.Panel1.Controls.Add(Me.lblTítulo)
        Me.Panel1.Location = New System.Drawing.Point(85, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(530, 318)
        Me.Panel1.TabIndex = 0
        '
        'lblUnidades
        '
        Me.lblUnidades.AutoSize = True
        Me.lblUnidades.Font = New System.Drawing.Font("Californian FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidades.ForeColor = System.Drawing.Color.Brown
        Me.lblUnidades.Location = New System.Drawing.Point(464, 266)
        Me.lblUnidades.Name = "lblUnidades"
        Me.lblUnidades.Size = New System.Drawing.Size(32, 18)
        Me.lblUnidades.TabIndex = 18
        Me.lblUnidades.Text = "m/s"
        Me.lblUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(378, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Location = New System.Drawing.Point(213, 266)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(173, 39)
        Me.lblAutor.TabIndex = 16
        Me.lblAutor.Text = "Elaborado por Andrés Felipe Patiño" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cód. 1054987920" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UNAD"
        Me.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVelocidad
        '
        Me.txtVelocidad.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtVelocidad.Cursor = System.Windows.Forms.Cursors.No
        Me.txtVelocidad.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVelocidad.ForeColor = System.Drawing.Color.Black
        Me.txtVelocidad.Location = New System.Drawing.Point(407, 261)
        Me.txtVelocidad.Name = "txtVelocidad"
        Me.txtVelocidad.Size = New System.Drawing.Size(51, 26)
        Me.txtVelocidad.TabIndex = 15
        Me.txtVelocidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Californian FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Brown
        Me.Label1.Location = New System.Drawing.Point(299, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Velocidad inicial de lanzamiento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Font = New System.Drawing.Font("Californian FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltura.ForeColor = System.Drawing.Color.Brown
        Me.lblAltura.Location = New System.Drawing.Point(23, 266)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(96, 18)
        Me.lblAltura.TabIndex = 13
        Me.lblAltura.Text = "Altura ganada"
        Me.lblAltura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAltura
        '
        Me.txtAltura.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtAltura.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltura.ForeColor = System.Drawing.Color.Black
        Me.txtAltura.Location = New System.Drawing.Point(125, 261)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(74, 26)
        Me.txtAltura.TabIndex = 12
        Me.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblInstruccion
        '
        Me.lblInstruccion.Font = New System.Drawing.Font("Californian FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruccion.ForeColor = System.Drawing.Color.Brown
        Me.lblInstruccion.Location = New System.Drawing.Point(20, 98)
        Me.lblInstruccion.Name = "lblInstruccion"
        Me.lblInstruccion.Size = New System.Drawing.Size(352, 128)
        Me.lblInstruccion.TabIndex = 11
        Me.lblInstruccion.Text = resources.GetString("lblInstruccion.Text")
        Me.lblInstruccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTítulo
        '
        Me.lblTítulo.AutoSize = True
        Me.lblTítulo.Font = New System.Drawing.Font("Californian FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTítulo.Location = New System.Drawing.Point(144, 50)
        Me.lblTítulo.Name = "lblTítulo"
        Me.lblTítulo.Size = New System.Drawing.Size(270, 48)
        Me.lblTítulo.TabIndex = 10
        Me.lblTítulo.Text = "Tiro Vertical" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cálculo de la velocidad inicial"
        Me.lblTítulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCalcular, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(530, 40)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbCalcular
        '
        Me.tsbCalcular.AutoSize = False
        Me.tsbCalcular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCalcular.Image = CType(resources.GetObject("tsbCalcular.Image"), System.Drawing.Image)
        Me.tsbCalcular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbCalcular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCalcular.Name = "tsbCalcular"
        Me.tsbCalcular.Size = New System.Drawing.Size(35, 35)
        Me.tsbCalcular.Text = "ToolStripButton1"
        Me.tsbCalcular.ToolTipText = "Realiza el cálculo de la velocidad inicial"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(35, 35)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Borra la información del formulario"
        '
        'Ejercicio10_Andres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ejercicio10_Andres"
        Me.Size = New System.Drawing.Size(700, 380)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblUnidades As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAutor As Label
    Friend WithEvents txtVelocidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAltura As Label
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents lblInstruccion As Label
    Friend WithEvents lblTítulo As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbCalcular As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio9_Andres
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ejercicio9_Andres))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtResultado2 = New System.Windows.Forms.TextBox()
        Me.txtResultado1 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResultado1 = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblInstruccion = New System.Windows.Forms.Label()
        Me.lblTítulo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Panel1.Controls.Add(Me.lblAutor)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtResultado2)
        Me.Panel1.Controls.Add(Me.txtResultado1)
        Me.Panel1.Controls.Add(Me.btnCalcular)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblResultado1)
        Me.Panel1.Controls.Add(Me.txtC)
        Me.Panel1.Controls.Add(Me.txtB)
        Me.Panel1.Controls.Add(Me.txtA)
        Me.Panel1.Controls.Add(Me.lblC)
        Me.Panel1.Controls.Add(Me.lblB)
        Me.Panel1.Controls.Add(Me.lblA)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblInstruccion)
        Me.Panel1.Controls.Add(Me.lblTítulo)
        Me.Panel1.Location = New System.Drawing.Point(107, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 296)
        Me.Panel1.TabIndex = 0
        '
        'lblAutor
        '
        Me.lblAutor.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutor.ForeColor = System.Drawing.Color.Transparent
        Me.lblAutor.Location = New System.Drawing.Point(189, 232)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(191, 51)
        Me.lblAutor.TabIndex = 31
        Me.lblAutor.Text = "Elaborado por Andrés Felipe Patiño" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cód. 1054987920" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UNAD"
        Me.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(460, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 38)
        Me.Button1.TabIndex = 30
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtResultado2
        '
        Me.txtResultado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado2.Location = New System.Drawing.Point(499, 174)
        Me.txtResultado2.Name = "txtResultado2"
        Me.txtResultado2.Size = New System.Drawing.Size(50, 26)
        Me.txtResultado2.TabIndex = 29
        '
        'txtResultado1
        '
        Me.txtResultado1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado1.Location = New System.Drawing.Point(499, 108)
        Me.txtResultado1.Name = "txtResultado1"
        Me.txtResultado1.Size = New System.Drawing.Size(50, 26)
        Me.txtResultado1.TabIndex = 28
        '
        'btnCalcular
        '
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcular.Image = CType(resources.GetObject("btnCalcular.Image"), System.Drawing.Image)
        Me.btnCalcular.Location = New System.Drawing.Point(60, 232)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(49, 38)
        Me.btnCalcular.TabIndex = 27
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(386, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 32)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Resultado x2:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblResultado1
        '
        Me.lblResultado1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado1.ForeColor = System.Drawing.Color.Transparent
        Me.lblResultado1.Location = New System.Drawing.Point(386, 105)
        Me.lblResultado1.Name = "lblResultado1"
        Me.lblResultado1.Size = New System.Drawing.Size(114, 32)
        Me.lblResultado1.TabIndex = 25
        Me.lblResultado1.Text = "Resultado x1:"
        Me.lblResultado1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtC
        '
        Me.txtC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.Location = New System.Drawing.Point(130, 177)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(50, 26)
        Me.txtC.TabIndex = 24
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(130, 144)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(50, 26)
        Me.txtB.TabIndex = 23
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(130, 109)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(50, 26)
        Me.txtA.TabIndex = 22
        '
        'lblC
        '
        Me.lblC.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.ForeColor = System.Drawing.Color.Transparent
        Me.lblC.Location = New System.Drawing.Point(20, 174)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(94, 32)
        Me.lblC.TabIndex = 21
        Me.lblC.Text = "Valor de c:"
        Me.lblC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblB
        '
        Me.lblB.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.ForeColor = System.Drawing.Color.Transparent
        Me.lblB.Location = New System.Drawing.Point(20, 141)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(94, 32)
        Me.lblB.TabIndex = 20
        Me.lblB.Text = "Valor de b:"
        Me.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblA
        '
        Me.lblA.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.ForeColor = System.Drawing.Color.Transparent
        Me.lblA.Location = New System.Drawing.Point(20, 105)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(94, 32)
        Me.lblA.TabIndex = 19
        Me.lblA.Text = "Valor de a:"
        Me.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(205, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'lblInstruccion
        '
        Me.lblInstruccion.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruccion.ForeColor = System.Drawing.Color.Transparent
        Me.lblInstruccion.Location = New System.Drawing.Point(20, 49)
        Me.lblInstruccion.Name = "lblInstruccion"
        Me.lblInstruccion.Size = New System.Drawing.Size(529, 50)
        Me.lblInstruccion.TabIndex = 17
        Me.lblInstruccion.Text = "Ingrese los valores para cada una de las variables de la ecuación cuadrática:"
        Me.lblInstruccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTítulo
        '
        Me.lblTítulo.AutoSize = True
        Me.lblTítulo.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTítulo.ForeColor = System.Drawing.Color.Gold
        Me.lblTítulo.Location = New System.Drawing.Point(125, 21)
        Me.lblTítulo.Name = "lblTítulo"
        Me.lblTítulo.Size = New System.Drawing.Size(335, 28)
        Me.lblTítulo.TabIndex = 16
        Me.lblTítulo.Text = "Cálculo de la Ecuación Cuadrática"
        '
        'Ejercicio9_Andres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ejercicio9_Andres"
        Me.Size = New System.Drawing.Size(782, 437)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAutor As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtResultado2 As TextBox
    Friend WithEvents txtResultado1 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblResultado1 As Label
    Friend WithEvents txtC As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtA As TextBox
    Friend WithEvents lblC As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblA As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblInstruccion As Label
    Friend WithEvents lblTítulo As Label
End Class

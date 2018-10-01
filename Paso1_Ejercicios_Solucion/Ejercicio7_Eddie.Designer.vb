<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio7_Eddie
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCoseno = New System.Windows.Forms.TextBox()
        Me.lblCoseno = New System.Windows.Forms.Label()
        Me.txtSeno = New System.Windows.Forms.TextBox()
        Me.txtAbsoluto = New System.Windows.Forms.TextBox()
        Me.lblSeno = New System.Windows.Forms.Label()
        Me.lblAbsoluto = New System.Windows.Forms.Label()
        Me.txtRaiz = New System.Windows.Forms.TextBox()
        Me.lblRaiz = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.FallaEdad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FallaEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.btnCalcular)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtNumero)
        Me.Panel1.Controls.Add(Me.lblInfo)
        Me.Panel1.Location = New System.Drawing.Point(110, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 257)
        Me.Panel1.TabIndex = 0
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnCalcular.Font = New System.Drawing.Font("Baskerville Old Face", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(362, 80)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(69, 29)
        Me.btnCalcular.TabIndex = 10
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtLog)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtCoseno)
        Me.GroupBox2.Controls.Add(Me.lblCoseno)
        Me.GroupBox2.Controls.Add(Me.txtSeno)
        Me.GroupBox2.Controls.Add(Me.txtAbsoluto)
        Me.GroupBox2.Controls.Add(Me.lblSeno)
        Me.GroupBox2.Controls.Add(Me.lblAbsoluto)
        Me.GroupBox2.Controls.Add(Me.txtRaiz)
        Me.GroupBox2.Controls.Add(Me.lblRaiz)
        Me.GroupBox2.Font = New System.Drawing.Font("Baskerville Old Face", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(27, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 122)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operaciones:"
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtLog.Location = New System.Drawing.Point(233, 89)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(58, 20)
        Me.txtLog.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Logoaritmo:"
        '
        'txtCoseno
        '
        Me.txtCoseno.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtCoseno.Location = New System.Drawing.Point(296, 53)
        Me.txtCoseno.Name = "txtCoseno"
        Me.txtCoseno.Size = New System.Drawing.Size(58, 20)
        Me.txtCoseno.TabIndex = 9
        Me.txtCoseno.Visible = False
        '
        'lblCoseno
        '
        Me.lblCoseno.AutoSize = True
        Me.lblCoseno.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoseno.Location = New System.Drawing.Point(232, 55)
        Me.lblCoseno.Name = "lblCoseno"
        Me.lblCoseno.Size = New System.Drawing.Size(58, 14)
        Me.lblCoseno.TabIndex = 8
        Me.lblCoseno.Text = "Coseno:"
        Me.lblCoseno.Visible = False
        '
        'txtSeno
        '
        Me.txtSeno.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtSeno.Location = New System.Drawing.Point(296, 23)
        Me.txtSeno.Name = "txtSeno"
        Me.txtSeno.Size = New System.Drawing.Size(58, 20)
        Me.txtSeno.TabIndex = 7
        '
        'txtAbsoluto
        '
        Me.txtAbsoluto.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtAbsoluto.Location = New System.Drawing.Point(131, 53)
        Me.txtAbsoluto.Name = "txtAbsoluto"
        Me.txtAbsoluto.Size = New System.Drawing.Size(58, 20)
        Me.txtAbsoluto.TabIndex = 3
        '
        'lblSeno
        '
        Me.lblSeno.AutoSize = True
        Me.lblSeno.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeno.Location = New System.Drawing.Point(248, 25)
        Me.lblSeno.Name = "lblSeno"
        Me.lblSeno.Size = New System.Drawing.Size(42, 14)
        Me.lblSeno.TabIndex = 6
        Me.lblSeno.Text = "Seno:"
        '
        'lblAbsoluto
        '
        Me.lblAbsoluto.AutoSize = True
        Me.lblAbsoluto.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbsoluto.Location = New System.Drawing.Point(23, 55)
        Me.lblAbsoluto.Name = "lblAbsoluto"
        Me.lblAbsoluto.Size = New System.Drawing.Size(106, 14)
        Me.lblAbsoluto.TabIndex = 2
        Me.lblAbsoluto.Text = "Valor Absoluto:"
        '
        'txtRaiz
        '
        Me.txtRaiz.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtRaiz.Location = New System.Drawing.Point(131, 23)
        Me.txtRaiz.Name = "txtRaiz"
        Me.txtRaiz.Size = New System.Drawing.Size(58, 20)
        Me.txtRaiz.TabIndex = 1
        '
        'lblRaiz
        '
        Me.lblRaiz.AutoSize = True
        Me.lblRaiz.Font = New System.Drawing.Font("Baskerville Old Face", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaiz.Location = New System.Drawing.Point(23, 25)
        Me.lblRaiz.Name = "lblRaiz"
        Me.lblRaiz.Size = New System.Drawing.Size(102, 14)
        Me.lblRaiz.TabIndex = 0
        Me.lblRaiz.Text = "Raiz Cuadrada:"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.lblBienvenido)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 51)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenido.Font = New System.Drawing.Font("Ravie", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.Location = New System.Drawing.Point(1, 9)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(419, 30)
        Me.lblBienvenido.TabIndex = 0
        Me.lblBienvenido.Text = "Calculadora de operaciones"
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtNumero.Location = New System.Drawing.Point(173, 84)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(67, 20)
        Me.txtNumero.TabIndex = 7
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(26, 84)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(141, 18)
        Me.lblInfo.TabIndex = 6
        Me.lblInfo.Text = "Digite un número:"
        '
        'FallaEdad
        '
        Me.FallaEdad.ContainerControl = Me
        '
        'Ejercicio7_Eddie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ejercicio7_Eddie"
        Me.Size = New System.Drawing.Size(682, 419)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FallaEdad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCalcular As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtLog As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCoseno As TextBox
    Friend WithEvents lblCoseno As Label
    Friend WithEvents txtSeno As TextBox
    Friend WithEvents txtAbsoluto As TextBox
    Friend WithEvents lblSeno As Label
    Friend WithEvents lblAbsoluto As Label
    Friend WithEvents txtRaiz As TextBox
    Friend WithEvents lblRaiz As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents FallaEdad As ErrorProvider
End Class

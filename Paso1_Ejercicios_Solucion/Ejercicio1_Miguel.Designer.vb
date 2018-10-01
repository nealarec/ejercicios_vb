<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio1_Miguel
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtNegro = New System.Windows.Forms.RadioButton()
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.rbtVerde = New System.Windows.Forms.RadioButton()
        Me.rbtAmarillo = New System.Windows.Forms.RadioButton()
        Me.rbtRojo = New System.Windows.Forms.RadioButton()
        Me.rbtAzul = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.rbtNegro)
        Me.Panel1.Controls.Add(Me.lblTexto)
        Me.Panel1.Controls.Add(Me.lblInfo)
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Controls.Add(Me.rbtVerde)
        Me.Panel1.Controls.Add(Me.rbtAmarillo)
        Me.Panel1.Controls.Add(Me.rbtRojo)
        Me.Panel1.Controls.Add(Me.rbtAzul)
        Me.Panel1.Location = New System.Drawing.Point(120, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 303)
        Me.Panel1.TabIndex = 0
        '
        'rbtNegro
        '
        Me.rbtNegro.AutoSize = True
        Me.rbtNegro.ForeColor = System.Drawing.Color.Blue
        Me.rbtNegro.Location = New System.Drawing.Point(43, 167)
        Me.rbtNegro.Name = "rbtNegro"
        Me.rbtNegro.Size = New System.Drawing.Size(14, 13)
        Me.rbtNegro.TabIndex = 9
        Me.rbtNegro.UseVisualStyleBackColor = True
        Me.rbtNegro.Visible = False
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.Location = New System.Drawing.Point(133, 221)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(277, 39)
        Me.lblTexto.TabIndex = 14
        Me.lblTexto.Text = "Texto de prueba"
        Me.lblTexto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(85, 100)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(366, 38)
        Me.lblInfo.TabIndex = 15
        Me.lblInfo.Text = "Seleccione uno de los siguientes Colores para que " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sea aplicado al texto de abaj" &
    "o."
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(52, 42)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(438, 39)
        Me.lblTitulo.TabIndex = 16
        Me.lblTitulo.Text = "Cambio de Color del Texto"
        '
        'rbtVerde
        '
        Me.rbtVerde.AutoSize = True
        Me.rbtVerde.ForeColor = System.Drawing.Color.Green
        Me.rbtVerde.Location = New System.Drawing.Point(425, 165)
        Me.rbtVerde.Name = "rbtVerde"
        Me.rbtVerde.Size = New System.Drawing.Size(53, 17)
        Me.rbtVerde.TabIndex = 13
        Me.rbtVerde.Text = "Verde"
        Me.rbtVerde.UseVisualStyleBackColor = True
        '
        'rbtAmarillo
        '
        Me.rbtAmarillo.AutoSize = True
        Me.rbtAmarillo.ForeColor = System.Drawing.Color.Yellow
        Me.rbtAmarillo.Location = New System.Drawing.Point(301, 165)
        Me.rbtAmarillo.Name = "rbtAmarillo"
        Me.rbtAmarillo.Size = New System.Drawing.Size(61, 17)
        Me.rbtAmarillo.TabIndex = 12
        Me.rbtAmarillo.Text = "Amarillo"
        Me.rbtAmarillo.UseVisualStyleBackColor = True
        '
        'rbtRojo
        '
        Me.rbtRojo.AutoSize = True
        Me.rbtRojo.ForeColor = System.Drawing.Color.Red
        Me.rbtRojo.Location = New System.Drawing.Point(180, 165)
        Me.rbtRojo.Name = "rbtRojo"
        Me.rbtRojo.Size = New System.Drawing.Size(47, 17)
        Me.rbtRojo.TabIndex = 11
        Me.rbtRojo.Text = "Rojo"
        Me.rbtRojo.UseVisualStyleBackColor = True
        '
        'rbtAzul
        '
        Me.rbtAzul.AutoSize = True
        Me.rbtAzul.ForeColor = System.Drawing.Color.Blue
        Me.rbtAzul.Location = New System.Drawing.Point(63, 165)
        Me.rbtAzul.Name = "rbtAzul"
        Me.rbtAzul.Size = New System.Drawing.Size(45, 17)
        Me.rbtAzul.TabIndex = 10
        Me.rbtAzul.Text = "Azul"
        Me.rbtAzul.UseVisualStyleBackColor = True
        '
        'Ejercicio1_Miguel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ejercicio1_Miguel"
        Me.Size = New System.Drawing.Size(773, 413)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbtNegro As RadioButton
    Friend WithEvents lblTexto As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents rbtVerde As RadioButton
    Friend WithEvents rbtAmarillo As RadioButton
    Friend WithEvents rbtRojo As RadioButton
    Friend WithEvents rbtAzul As RadioButton
End Class

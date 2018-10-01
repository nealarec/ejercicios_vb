<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio8_Andres
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
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtImc = New System.Windows.Forms.TextBox()
        Me.lblImc = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblInstruccion = New System.Windows.Forms.Label()
        Me.lblTítulo = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.lblAutor)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.txtImc)
        Me.Panel1.Controls.Add(Me.lblImc)
        Me.Panel1.Controls.Add(Me.btnBorrar)
        Me.Panel1.Controls.Add(Me.btnCalcular)
        Me.Panel1.Controls.Add(Me.lblAltura)
        Me.Panel1.Controls.Add(Me.txtAltura)
        Me.Panel1.Controls.Add(Me.lblPeso)
        Me.Panel1.Controls.Add(Me.lblInstruccion)
        Me.Panel1.Controls.Add(Me.lblTítulo)
        Me.Panel1.Controls.Add(Me.txtPeso)
        Me.Panel1.Location = New System.Drawing.Point(107, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(453, 305)
        Me.Panel1.TabIndex = 0
        '
        'lblAutor
        '
        Me.lblAutor.Location = New System.Drawing.Point(140, 243)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(177, 44)
        Me.lblAutor.TabIndex = 23
        Me.lblAutor.Text = "Elaborado por Andrés Felipe Patiño. Código 1054987920." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UNAD"
        Me.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(254, 202)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(115, 26)
        Me.txtDescripcion.TabIndex = 22
        '
        'txtImc
        '
        Me.txtImc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImc.Location = New System.Drawing.Point(162, 202)
        Me.txtImc.Name = "txtImc"
        Me.txtImc.Size = New System.Drawing.Size(75, 26)
        Me.txtImc.TabIndex = 21
        '
        'lblImc
        '
        Me.lblImc.AutoSize = True
        Me.lblImc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImc.ForeColor = System.Drawing.Color.Blue
        Me.lblImc.Location = New System.Drawing.Point(88, 205)
        Me.lblImc.Name = "lblImc"
        Me.lblImc.Size = New System.Drawing.Size(68, 20)
        Me.lblImc.TabIndex = 20
        Me.lblImc.Text = "Su IMC"
        '
        'btnBorrar
        '
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(266, 158)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(103, 30)
        Me.btnBorrar.TabIndex = 19
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(92, 158)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(103, 30)
        Me.btnCalcular.TabIndex = 18
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltura.ForeColor = System.Drawing.Color.Blue
        Me.lblAltura.Location = New System.Drawing.Point(129, 125)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(48, 16)
        Me.lblAltura.TabIndex = 17
        Me.lblAltura.Text = "Altura"
        '
        'txtAltura
        '
        Me.txtAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltura.Location = New System.Drawing.Point(228, 124)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(100, 22)
        Me.txtAltura.TabIndex = 16
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.ForeColor = System.Drawing.Color.Blue
        Me.lblPeso.Location = New System.Drawing.Point(129, 93)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(44, 16)
        Me.lblPeso.TabIndex = 15
        Me.lblPeso.Text = "Peso"
        '
        'lblInstruccion
        '
        Me.lblInstruccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruccion.Location = New System.Drawing.Point(44, 42)
        Me.lblInstruccion.Name = "lblInstruccion"
        Me.lblInstruccion.Size = New System.Drawing.Size(365, 47)
        Me.lblInstruccion.TabIndex = 14
        Me.lblInstruccion.Text = "Por favor ingrese su peso (kg)  y estatura (m) en las casillas correspondientes"
        Me.lblInstruccion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTítulo
        '
        Me.lblTítulo.AutoSize = True
        Me.lblTítulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTítulo.ForeColor = System.Drawing.Color.Blue
        Me.lblTítulo.Location = New System.Drawing.Point(118, 17)
        Me.lblTítulo.Name = "lblTítulo"
        Me.lblTítulo.Size = New System.Drawing.Size(219, 25)
        Me.lblTítulo.TabIndex = 13
        Me.lblTítulo.Text = "Calculadora de IMC"
        '
        'txtPeso
        '
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(228, 92)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(100, 22)
        Me.txtPeso.TabIndex = 12
        '
        'Ejercicio8_Andres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ejercicio8_Andres"
        Me.Size = New System.Drawing.Size(667, 404)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAutor As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtImc As TextBox
    Friend WithEvents lblImc As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblAltura As Label
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblInstruccion As Label
    Friend WithEvents lblTítulo As Label
    Friend WithEvents txtPeso As TextBox
End Class

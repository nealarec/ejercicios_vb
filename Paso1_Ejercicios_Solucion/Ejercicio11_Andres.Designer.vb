<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio11_Andres
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
        Me.lblDias = New System.Windows.Forms.Label()
        Me.lblMeses = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.lblInstruccion = New System.Windows.Forms.Label()
        Me.lblTítulo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.lblDias)
        Me.Panel1.Controls.Add(Me.lblMeses)
        Me.Panel1.Controls.Add(Me.btnCalcular)
        Me.Panel1.Controls.Add(Me.lblEdad)
        Me.Panel1.Controls.Add(Me.dtpNacimiento)
        Me.Panel1.Controls.Add(Me.lblAutor)
        Me.Panel1.Controls.Add(Me.lblInstruccion)
        Me.Panel1.Controls.Add(Me.lblTítulo)
        Me.Panel1.Location = New System.Drawing.Point(212, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(453, 264)
        Me.Panel1.TabIndex = 0
        '
        'lblDias
        '
        Me.lblDias.AutoSize = True
        Me.lblDias.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDias.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblDias.Location = New System.Drawing.Point(356, 171)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(0, 19)
        Me.lblDias.TabIndex = 15
        Me.lblDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMeses
        '
        Me.lblMeses.AutoSize = True
        Me.lblMeses.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeses.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblMeses.Location = New System.Drawing.Point(34, 171)
        Me.lblMeses.Name = "lblMeses"
        Me.lblMeses.Size = New System.Drawing.Size(0, 19)
        Me.lblMeses.TabIndex = 14
        Me.lblMeses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcular
        '
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.Color.Red
        Me.btnCalcular.Location = New System.Drawing.Point(289, 92)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(111, 32)
        Me.btnCalcular.TabIndex = 13
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblEdad.Location = New System.Drawing.Point(34, 135)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(0, 19)
        Me.lblEdad.TabIndex = 12
        Me.lblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(93, 97)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(106, 20)
        Me.dtpNacimiento.TabIndex = 11
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Location = New System.Drawing.Point(157, 213)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(173, 39)
        Me.lblAutor.TabIndex = 10
        Me.lblAutor.Text = "Elaborado por Andrés Felipe Patiño" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cód. 1054987920" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UNAD"
        Me.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInstruccion
        '
        Me.lblInstruccion.AutoSize = True
        Me.lblInstruccion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruccion.ForeColor = System.Drawing.Color.Crimson
        Me.lblInstruccion.Location = New System.Drawing.Point(20, 55)
        Me.lblInstruccion.Name = "lblInstruccion"
        Me.lblInstruccion.Size = New System.Drawing.Size(412, 19)
        Me.lblInstruccion.TabIndex = 9
        Me.lblInstruccion.Text = "Ingrese su fecha de nacimiento para obtener su edad exacta:"
        '
        'lblTítulo
        '
        Me.lblTítulo.AutoSize = True
        Me.lblTítulo.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTítulo.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblTítulo.Location = New System.Drawing.Point(145, 13)
        Me.lblTítulo.Name = "lblTítulo"
        Me.lblTítulo.Size = New System.Drawing.Size(211, 24)
        Me.lblTítulo.TabIndex = 8
        Me.lblTítulo.Text = "Calcule su edad exacta"
        '
        'Ejercicio11_Andres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ejercicio11_Andres"
        Me.Size = New System.Drawing.Size(877, 497)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDias As Label
    Friend WithEvents lblMeses As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblEdad As Label
    Friend WithEvents dtpNacimiento As DateTimePicker
    Friend WithEvents lblAutor As Label
    Friend WithEvents lblInstruccion As Label
    Friend WithEvents lblTítulo As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Distance = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VelMovil1 = New System.Windows.Forms.TextBox()
        Me.VelMovil2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DeltaTime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ResTime = New System.Windows.Forms.Label()
        Me.ResDistance = New System.Windows.Forms.Label()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Distancia (Km):"
        '
        'Distance
        '
        Me.Distance.Location = New System.Drawing.Point(255, 107)
        Me.Distance.Name = "Distance"
        Me.Distance.Size = New System.Drawing.Size(100, 20)
        Me.Distance.TabIndex = 1
        Me.Distance.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Velocidad M1:"
        '
        'VelMovil1
        '
        Me.VelMovil1.Location = New System.Drawing.Point(255, 132)
        Me.VelMovil1.Name = "VelMovil1"
        Me.VelMovil1.Size = New System.Drawing.Size(100, 20)
        Me.VelMovil1.TabIndex = 2
        Me.VelMovil1.Text = "0"
        '
        'VelMovil2
        '
        Me.VelMovil2.Location = New System.Drawing.Point(255, 163)
        Me.VelMovil2.Name = "VelMovil2"
        Me.VelMovil2.Size = New System.Drawing.Size(100, 20)
        Me.VelMovil2.TabIndex = 3
        Me.VelMovil2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(171, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Velocidad M2:"
        '
        'DeltaTime
        '
        Me.DeltaTime.Location = New System.Drawing.Point(255, 192)
        Me.DeltaTime.Name = "DeltaTime"
        Me.DeltaTime.Size = New System.Drawing.Size(100, 20)
        Me.DeltaTime.TabIndex = 5
        Me.DeltaTime.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(171, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Delta T (h)"
        '
        'ResTime
        '
        Me.ResTime.AutoSize = True
        Me.ResTime.Location = New System.Drawing.Point(271, 259)
        Me.ResTime.Name = "ResTime"
        Me.ResTime.Size = New System.Drawing.Size(39, 13)
        Me.ResTime.TabIndex = 6
        Me.ResTime.Text = "Label5"
        '
        'ResDistance
        '
        Me.ResDistance.AutoSize = True
        Me.ResDistance.Location = New System.Drawing.Point(271, 289)
        Me.ResDistance.Name = "ResDistance"
        Me.ResDistance.Size = New System.Drawing.Size(39, 13)
        Me.ResDistance.TabIndex = 7
        Me.ResDistance.Text = "Label5"
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(226, 218)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 8
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Distancia entre A y V"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Movimiento Rectilineo Uniforme"
        '
        'Ejercicio5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.ResDistance)
        Me.Controls.Add(Me.ResTime)
        Me.Controls.Add(Me.DeltaTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.VelMovil2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.VelMovil1)
        Me.Controls.Add(Me.Distance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ejercicio5"
        Me.Size = New System.Drawing.Size(756, 452)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Distance As TextBox
    Protected Friend WithEvents Label2 As Label
    Protected Friend WithEvents VelMovil1 As TextBox
    Protected Friend WithEvents VelMovil2 As TextBox
    Protected Friend WithEvents Label3 As Label
    Protected Friend WithEvents DeltaTime As TextBox
    Protected Friend WithEvents Label4 As Label
    Friend WithEvents ResTime As Label
    Friend WithEvents ResDistance As Label
    Friend WithEvents Calcular As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label5 As Label
End Class

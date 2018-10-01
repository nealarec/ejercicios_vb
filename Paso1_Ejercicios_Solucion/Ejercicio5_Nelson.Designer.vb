<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio5_Nelson
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ejercicio5_Nelson))
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N (Km):"
        '
        'Distance
        '
        Me.Distance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Distance.Location = New System.Drawing.Point(99, 25)
        Me.Distance.Name = "Distance"
        Me.Distance.Size = New System.Drawing.Size(100, 20)
        Me.Distance.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Script MT Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "V1 (Km/h):"
        '
        'VelMovil1
        '
        Me.VelMovil1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VelMovil1.Location = New System.Drawing.Point(318, 25)
        Me.VelMovil1.Name = "VelMovil1"
        Me.VelMovil1.Size = New System.Drawing.Size(100, 20)
        Me.VelMovil1.TabIndex = 2
        '
        'VelMovil2
        '
        Me.VelMovil2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VelMovil2.Location = New System.Drawing.Point(318, 56)
        Me.VelMovil2.Name = "VelMovil2"
        Me.VelMovil2.Size = New System.Drawing.Size(100, 20)
        Me.VelMovil2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Script MT Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(216, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "V2 (Km/h):"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'DeltaTime
        '
        Me.DeltaTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeltaTime.Location = New System.Drawing.Point(99, 56)
        Me.DeltaTime.Name = "DeltaTime"
        Me.DeltaTime.Size = New System.Drawing.Size(100, 20)
        Me.DeltaTime.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Script MT Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "T (h):"
        '
        'ResTime
        '
        Me.ResTime.AutoSize = True
        Me.ResTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResTime.Location = New System.Drawing.Point(26, 44)
        Me.ResTime.Name = "ResTime"
        Me.ResTime.Size = New System.Drawing.Size(25, 18)
        Me.ResTime.TabIndex = 6
        Me.ResTime.Text = "R/"
        '
        'ResDistance
        '
        Me.ResDistance.AutoSize = True
        Me.ResDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResDistance.Location = New System.Drawing.Point(26, 83)
        Me.ResDistance.Name = "ResDistance"
        Me.ResDistance.Size = New System.Drawing.Size(25, 18)
        Me.ResDistance.TabIndex = 7
        Me.ResDistance.Text = "R/"
        '
        'Calcular
        '
        Me.Calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calcular.Location = New System.Drawing.Point(53, 207)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(164, 29)
        Me.Calcular.TabIndex = 8
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(113, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(325, 28)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Movimiento Rectilineo Uniforme"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(541, 57)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = resources.GetString("Label6.Text")
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Distance)
        Me.GroupBox1.Controls.Add(Me.VelMovil1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.VelMovil2)
        Me.GroupBox1.Controls.Add(Me.DeltaTime)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(53, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 86)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Variables"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ResTime)
        Me.GroupBox2.Controls.Add(Me.ResDistance)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(53, 242)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 110)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(226, 18)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "La posición donde se encuentran"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(246, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "El tiempo que tardan en encontrarse"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.ClearButton)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Calcular)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(175, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(551, 369)
        Me.Panel1.TabIndex = 13
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(333, 207)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(164, 29)
        Me.ClearButton.TabIndex = 13
        Me.ClearButton.Text = "Limpiar"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Ejercicio5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ejercicio5"
        Me.Size = New System.Drawing.Size(900, 600)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ClearButton As Button
End Class

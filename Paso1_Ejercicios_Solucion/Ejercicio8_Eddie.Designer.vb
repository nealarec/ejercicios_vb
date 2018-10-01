<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio8_Eddie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ejercicio8_Eddie))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.TxtIMC = New System.Windows.Forms.TextBox()
        Me.LblIMC = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.LblPeso = New System.Windows.Forms.Label()
        Me.LblEstatura = New System.Windows.Forms.Label()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.TxtEstatura = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(195, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 408)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(72, 227)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(417, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblEstado)
        Me.GroupBox2.Controls.Add(Me.TxtEstado)
        Me.GroupBox2.Controls.Add(Me.TxtIMC)
        Me.GroupBox2.Controls.Add(Me.LblIMC)
        Me.GroupBox2.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(72, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(417, 94)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.Location = New System.Drawing.Point(6, 60)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(165, 17)
        Me.LblEstado.TabIndex = 3
        Me.LblEstado.Text = "Atendiendo al IMC, tiene:"
        '
        'TxtEstado
        '
        Me.TxtEstado.BackColor = System.Drawing.Color.NavajoWhite
        Me.TxtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEstado.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEstado.Location = New System.Drawing.Point(177, 57)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.ReadOnly = True
        Me.TxtEstado.Size = New System.Drawing.Size(222, 24)
        Me.TxtEstado.TabIndex = 2
        '
        'TxtIMC
        '
        Me.TxtIMC.BackColor = System.Drawing.Color.NavajoWhite
        Me.TxtIMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIMC.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIMC.Location = New System.Drawing.Point(177, 24)
        Me.TxtIMC.Name = "TxtIMC"
        Me.TxtIMC.ReadOnly = True
        Me.TxtIMC.Size = New System.Drawing.Size(100, 24)
        Me.TxtIMC.TabIndex = 1
        '
        'LblIMC
        '
        Me.LblIMC.AutoSize = True
        Me.LblIMC.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIMC.Location = New System.Drawing.Point(6, 27)
        Me.LblIMC.Name = "LblIMC"
        Me.LblIMC.Size = New System.Drawing.Size(159, 17)
        Me.LblIMC.TabIndex = 0
        Me.LblIMC.Text = "Índice de Masa Corporal:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCalcular)
        Me.GroupBox1.Controls.Add(Me.LblPeso)
        Me.GroupBox1.Controls.Add(Me.LblEstatura)
        Me.GroupBox1.Controls.Add(Me.TxtPeso)
        Me.GroupBox1.Controls.Add(Me.TxtEstatura)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(72, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 93)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cálculo de IMC"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCalcular.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalcular.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCalcular.Location = New System.Drawing.Point(301, 32)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(98, 45)
        Me.BtnCalcular.TabIndex = 4
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'LblPeso
        '
        Me.LblPeso.AutoSize = True
        Me.LblPeso.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPeso.Location = New System.Drawing.Point(6, 32)
        Me.LblPeso.Name = "LblPeso"
        Me.LblPeso.Size = New System.Drawing.Size(143, 17)
        Me.LblPeso.TabIndex = 2
        Me.LblPeso.Text = "Escriba su peso en Kg:"
        '
        'LblEstatura
        '
        Me.LblEstatura.AutoSize = True
        Me.LblEstatura.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstatura.Location = New System.Drawing.Point(6, 60)
        Me.LblEstatura.Name = "LblEstatura"
        Me.LblEstatura.Size = New System.Drawing.Size(166, 17)
        Me.LblEstatura.TabIndex = 3
        Me.LblEstatura.Text = "Escriba su estatura en cm:"
        '
        'TxtPeso
        '
        Me.TxtPeso.BackColor = System.Drawing.Color.NavajoWhite
        Me.TxtPeso.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPeso.Location = New System.Drawing.Point(178, 29)
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.Size = New System.Drawing.Size(67, 24)
        Me.TxtPeso.TabIndex = 0
        '
        'TxtEstatura
        '
        Me.TxtEstatura.BackColor = System.Drawing.Color.NavajoWhite
        Me.TxtEstatura.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEstatura.Location = New System.Drawing.Point(178, 57)
        Me.TxtEstatura.Name = "TxtEstatura"
        Me.TxtEstatura.Size = New System.Drawing.Size(67, 24)
        Me.TxtEstatura.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Ejercicio8_Eddie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ejercicio8_Eddie"
        Me.Size = New System.Drawing.Size(951, 632)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblEstado As Label
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents TxtIMC As TextBox
    Friend WithEvents LblIMC As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents LblPeso As Label
    Friend WithEvents LblEstatura As Label
    Friend WithEvents TxtPeso As TextBox
    Friend WithEvents TxtEstatura As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class

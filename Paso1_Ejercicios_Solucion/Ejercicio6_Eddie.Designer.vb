<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio6_Eddie
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAgregar = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.LstNumero = New System.Windows.Forms.ListBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.LblRegistros = New System.Windows.Forms.Label()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(171, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 215)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAgregar)
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.LstNumero)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.LblRegistros)
        Me.GroupBox1.Controls.Add(Me.LblInfo)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 200)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Almacenar Números"
        '
        'txtAgregar
        '
        Me.txtAgregar.BackColor = System.Drawing.Color.FloralWhite
        Me.txtAgregar.Location = New System.Drawing.Point(37, 19)
        Me.txtAgregar.Name = "txtAgregar"
        Me.txtAgregar.Size = New System.Drawing.Size(100, 25)
        Me.txtAgregar.TabIndex = 2
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLimpiar.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.BtnLimpiar.Location = New System.Drawing.Point(159, 85)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(77, 31)
        Me.BtnLimpiar.TabIndex = 6
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'LstNumero
        '
        Me.LstNumero.BackColor = System.Drawing.Color.FloralWhite
        Me.LstNumero.FormattingEnabled = True
        Me.LstNumero.ItemHeight = 18
        Me.LstNumero.Location = New System.Drawing.Point(37, 61)
        Me.LstNumero.Name = "LstNumero"
        Me.LstNumero.Size = New System.Drawing.Size(100, 94)
        Me.LstNumero.TabIndex = 0
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEliminar.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Black
        Me.BtnEliminar.Location = New System.Drawing.Point(159, 50)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(77, 29)
        Me.BtnEliminar.TabIndex = 5
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregar.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Location = New System.Drawing.Point(159, 13)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(77, 30)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'LblRegistros
        '
        Me.LblRegistros.AutoSize = True
        Me.LblRegistros.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegistros.Location = New System.Drawing.Point(192, 175)
        Me.LblRegistros.Name = "LblRegistros"
        Me.LblRegistros.Size = New System.Drawing.Size(11, 17)
        Me.LblRegistros.TabIndex = 4
        Me.LblRegistros.Text = "."
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.Location = New System.Drawing.Point(6, 173)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(184, 17)
        Me.LblInfo.TabIndex = 3
        Me.LblInfo.Text = "Cantidad de registros agregados:"
        '
        'Ejercicio6_Eddie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ejercicio6_Eddie"
        Me.Size = New System.Drawing.Size(614, 413)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAgregar As TextBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents LstNumero As ListBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents LblRegistros As Label
    Friend WithEvents LblInfo As Label
End Class

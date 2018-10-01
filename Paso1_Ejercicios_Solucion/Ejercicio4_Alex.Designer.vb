<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio4_Alex
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
        Me.Txt_Vi = New System.Windows.Forms.TextBox()
        Me.Lbl_Vi = New System.Windows.Forms.Label()
        Me.Lbl_h = New System.Windows.Forms.Label()
        Me.Lbl_altura = New System.Windows.Forms.Label()
        Me.Lbl_g = New System.Windows.Forms.Label()
        Me.Txt_t = New System.Windows.Forms.TextBox()
        Me.Lbl_t = New System.Windows.Forms.Label()
        Me.Lbl_formulah = New System.Windows.Forms.Label()
        Me.Lbl_formula = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Txt_Vi)
        Me.Panel1.Controls.Add(Me.Lbl_Vi)
        Me.Panel1.Controls.Add(Me.Lbl_h)
        Me.Panel1.Controls.Add(Me.Lbl_altura)
        Me.Panel1.Controls.Add(Me.Lbl_g)
        Me.Panel1.Controls.Add(Me.Txt_t)
        Me.Panel1.Controls.Add(Me.Lbl_t)
        Me.Panel1.Controls.Add(Me.Lbl_formulah)
        Me.Panel1.Controls.Add(Me.Lbl_formula)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(95, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 197)
        Me.Panel1.TabIndex = 0
        '
        'Txt_Vi
        '
        Me.Txt_Vi.Location = New System.Drawing.Point(169, 66)
        Me.Txt_Vi.Name = "Txt_Vi"
        Me.Txt_Vi.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Vi.TabIndex = 23
        '
        'Lbl_Vi
        '
        Me.Lbl_Vi.AutoSize = True
        Me.Lbl_Vi.Location = New System.Drawing.Point(17, 69)
        Me.Lbl_Vi.Name = "Lbl_Vi"
        Me.Lbl_Vi.Size = New System.Drawing.Size(84, 13)
        Me.Lbl_Vi.TabIndex = 22
        Me.Lbl_Vi.Text = "Velocidad Inicial"
        '
        'Lbl_h
        '
        Me.Lbl_h.AutoSize = True
        Me.Lbl_h.ForeColor = System.Drawing.Color.Brown
        Me.Lbl_h.Location = New System.Drawing.Point(344, 104)
        Me.Lbl_h.Name = "Lbl_h"
        Me.Lbl_h.Size = New System.Drawing.Size(13, 13)
        Me.Lbl_h.TabIndex = 21
        Me.Lbl_h.Text = "?"
        '
        'Lbl_altura
        '
        Me.Lbl_altura.AutoSize = True
        Me.Lbl_altura.ForeColor = System.Drawing.Color.Brown
        Me.Lbl_altura.Location = New System.Drawing.Point(295, 104)
        Me.Lbl_altura.Name = "Lbl_altura"
        Me.Lbl_altura.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_altura.TabIndex = 20
        Me.Lbl_altura.Text = "Altura ="
        '
        'Lbl_g
        '
        Me.Lbl_g.AutoSize = True
        Me.Lbl_g.Location = New System.Drawing.Point(17, 104)
        Me.Lbl_g.Name = "Lbl_g"
        Me.Lbl_g.Size = New System.Drawing.Size(155, 13)
        Me.Lbl_g.TabIndex = 19
        Me.Lbl_g.Text = "Gravedad constante de 9.8m/s"
        '
        'Txt_t
        '
        Me.Txt_t.Location = New System.Drawing.Point(169, 40)
        Me.Txt_t.Name = "Txt_t"
        Me.Txt_t.Size = New System.Drawing.Size(100, 20)
        Me.Txt_t.TabIndex = 18
        '
        'Lbl_t
        '
        Me.Lbl_t.AutoSize = True
        Me.Lbl_t.Location = New System.Drawing.Point(17, 43)
        Me.Lbl_t.Name = "Lbl_t"
        Me.Lbl_t.Size = New System.Drawing.Size(122, 13)
        Me.Lbl_t.TabIndex = 17
        Me.Lbl_t.Text = "Ingrese el tiempo en seg"
        '
        'Lbl_formulah
        '
        Me.Lbl_formulah.AutoSize = True
        Me.Lbl_formulah.Location = New System.Drawing.Point(295, 69)
        Me.Lbl_formulah.Name = "Lbl_formulah"
        Me.Lbl_formulah.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_formulah.TabIndex = 16
        Me.Lbl_formulah.Text = "h=V°t+0.5gt^2"
        '
        'Lbl_formula
        '
        Me.Lbl_formula.AutoSize = True
        Me.Lbl_formula.Location = New System.Drawing.Point(295, 43)
        Me.Lbl_formula.Name = "Lbl_formula"
        Me.Lbl_formula.Size = New System.Drawing.Size(47, 13)
        Me.Lbl_formula.TabIndex = 15
        Me.Lbl_formula.Text = "Formula:"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(298, 149)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(217, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "CALCULAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(136, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "LIMPIAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Caida Libre"
        '
        'Ejercicio4_Alex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ejercicio4_Alex"
        Me.Size = New System.Drawing.Size(594, 357)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Vi As TextBox
    Friend WithEvents Lbl_Vi As Label
    Friend WithEvents Lbl_h As Label
    Friend WithEvents Lbl_altura As Label
    Friend WithEvents Lbl_g As Label
    Friend WithEvents Txt_t As TextBox
    Friend WithEvents Lbl_t As Label
    Friend WithEvents Lbl_formulah As Label
    Friend WithEvents Lbl_formula As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class

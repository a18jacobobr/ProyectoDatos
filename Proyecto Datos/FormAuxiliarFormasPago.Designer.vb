<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAuxiliarFormasPago
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.txtDescipcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCadencia = New System.Windows.Forms.TextBox()
        Me.txtPlazos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMuestraCodFormaPago = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(529, 325)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(117, 36)
        Me.BtnCancelar.TabIndex = 62
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(173, 325)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(117, 36)
        Me.BtnAceptar.TabIndex = 61
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'txtDescipcion
        '
        Me.txtDescipcion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDescipcion.Location = New System.Drawing.Point(448, 132)
        Me.txtDescipcion.Name = "txtDescipcion"
        Me.txtDescipcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescipcion.TabIndex = 60
        Me.txtDescipcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(230, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Código forma de pago:"
        '
        'txtCadencia
        '
        Me.txtCadencia.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCadencia.Location = New System.Drawing.Point(448, 206)
        Me.txtCadencia.Name = "txtCadencia"
        Me.txtCadencia.Size = New System.Drawing.Size(100, 20)
        Me.txtCadencia.TabIndex = 66
        Me.txtCadencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPlazos
        '
        Me.txtPlazos.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtPlazos.Location = New System.Drawing.Point(448, 168)
        Me.txtPlazos.Name = "txtPlazos"
        Me.txtPlazos.Size = New System.Drawing.Size(100, 20)
        Me.txtPlazos.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 209)
        Me.Label1.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Cadencia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Plazos:"
        '
        'lblMuestraCodFormaPago
        '
        Me.lblMuestraCodFormaPago.AutoSize = True
        Me.lblMuestraCodFormaPago.Location = New System.Drawing.Point(445, 94)
        Me.lblMuestraCodFormaPago.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblMuestraCodFormaPago.Name = "lblMuestraCodFormaPago"
        Me.lblMuestraCodFormaPago.Size = New System.Drawing.Size(0, 13)
        Me.lblMuestraCodFormaPago.TabIndex = 67
        '
        'FormAuxiliarFormasPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMuestraCodFormaPago)
        Me.Controls.Add(Me.txtCadencia)
        Me.Controls.Add(Me.txtPlazos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.txtDescipcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormAuxiliarFormasPago"
        Me.Text = "FormAuxiliarFormasPago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents txtDescipcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCadencia As TextBox
    Friend WithEvents txtPlazos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMuestraCodFormaPago As Label
End Class

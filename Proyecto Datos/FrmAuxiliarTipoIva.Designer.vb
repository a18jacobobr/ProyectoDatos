<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAuxiliarTipoIva
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
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTipoIva = New System.Windows.Forms.Label()
        Me.lblMuestraTipoIva = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(557, 453)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(117, 36)
        Me.BtnCancelar.TabIndex = 56
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(201, 453)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(117, 36)
        Me.BtnAceptar.TabIndex = 55
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtPorcentaje.Location = New System.Drawing.Point(285, 102)
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(100, 20)
        Me.txtPorcentaje.TabIndex = 47
        Me.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Porcentaje:"
        '
        'lblTipoIva
        '
        Me.lblTipoIva.AutoSize = True
        Me.lblTipoIva.Location = New System.Drawing.Point(67, 64)
        Me.lblTipoIva.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblTipoIva.Name = "lblTipoIva"
        Me.lblTipoIva.Size = New System.Drawing.Size(49, 13)
        Me.lblTipoIva.TabIndex = 36
        Me.lblTipoIva.Text = "Tipo Iva:"
        '
        'lblMuestraTipoIva
        '
        Me.lblMuestraTipoIva.AutoSize = True
        Me.lblMuestraTipoIva.Location = New System.Drawing.Point(282, 64)
        Me.lblMuestraTipoIva.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblMuestraTipoIva.Name = "lblMuestraTipoIva"
        Me.lblMuestraTipoIva.Size = New System.Drawing.Size(0, 13)
        Me.lblMuestraTipoIva.TabIndex = 57
        '
        'FrmAuxiliarTipoIva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 520)
        Me.Controls.Add(Me.lblMuestraTipoIva)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.txtPorcentaje)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTipoIva)
        Me.Name = "FrmAuxiliarTipoIva"
        Me.Text = "FrmAuxiliarTipoIva"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents txtPorcentaje As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTipoIva As Label
    Friend WithEvents lblMuestraTipoIva As Label
End Class

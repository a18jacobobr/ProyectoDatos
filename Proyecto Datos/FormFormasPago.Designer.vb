<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFormasPago
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DtgFormasPago = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.textCodPost = New System.Windows.Forms.GroupBox()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.txtCadencia = New System.Windows.Forms.TextBox()
        Me.txtPlazos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescipcion = New System.Windows.Forms.TextBox()
        Me.txtCodFPago = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DtgFormasPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.textCodPost.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtgFormasPago
        '
        Me.DtgFormasPago.AllowUserToAddRows = False
        Me.DtgFormasPago.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DtgFormasPago.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgFormasPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgFormasPago.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DtgFormasPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgFormasPago.DefaultCellStyle = DataGridViewCellStyle3
        Me.DtgFormasPago.Location = New System.Drawing.Point(67, 451)
        Me.DtgFormasPago.Name = "DtgFormasPago"
        Me.DtgFormasPago.ReadOnly = True
        Me.DtgFormasPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgFormasPago.Size = New System.Drawing.Size(1135, 196)
        Me.DtgFormasPago.TabIndex = 98
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.BtnEliminar)
        Me.Panel2.Controls.Add(Me.BtnModificar)
        Me.Panel2.Controls.Add(Me.BtnNuevo)
        Me.Panel2.Location = New System.Drawing.Point(818, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 176)
        Me.Panel2.TabIndex = 97
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(66, 124)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(214, 32)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar forma de pago"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(43, 74)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(253, 32)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar forma de pago"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(66, 20)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(214, 32)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nueva forma de pago"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'textCodPost
        '
        Me.textCodPost.Controls.Add(Me.BtnUltimo)
        Me.textCodPost.Controls.Add(Me.BtnSiguiente)
        Me.textCodPost.Controls.Add(Me.BtnAnterior)
        Me.textCodPost.Controls.Add(Me.BtnPrimero)
        Me.textCodPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.textCodPost.Location = New System.Drawing.Point(67, 364)
        Me.textCodPost.Name = "textCodPost"
        Me.textCodPost.Size = New System.Drawing.Size(1111, 72)
        Me.textCodPost.TabIndex = 96
        Me.textCodPost.TabStop = False
        '
        'BtnUltimo
        '
        Me.BtnUltimo.Location = New System.Drawing.Point(868, 33)
        Me.BtnUltimo.Name = "BtnUltimo"
        Me.BtnUltimo.Size = New System.Drawing.Size(89, 33)
        Me.BtnUltimo.TabIndex = 3
        Me.BtnUltimo.Text = ">>"
        Me.BtnUltimo.UseVisualStyleBackColor = True
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Location = New System.Drawing.Point(601, 33)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(89, 33)
        Me.BtnSiguiente.TabIndex = 2
        Me.BtnSiguiente.Text = ">"
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.Location = New System.Drawing.Point(334, 33)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(89, 33)
        Me.BtnAnterior.TabIndex = 1
        Me.BtnAnterior.Text = "<"
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnPrimero
        '
        Me.BtnPrimero.Location = New System.Drawing.Point(67, 33)
        Me.BtnPrimero.Name = "BtnPrimero"
        Me.BtnPrimero.Size = New System.Drawing.Size(89, 33)
        Me.BtnPrimero.TabIndex = 0
        Me.BtnPrimero.Text = "<<"
        Me.BtnPrimero.UseVisualStyleBackColor = True
        '
        'txtCadencia
        '
        Me.txtCadencia.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCadencia.Location = New System.Drawing.Point(470, 256)
        Me.txtCadencia.Name = "txtCadencia"
        Me.txtCadencia.Size = New System.Drawing.Size(100, 20)
        Me.txtCadencia.TabIndex = 106
        Me.txtCadencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPlazos
        '
        Me.txtPlazos.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtPlazos.Location = New System.Drawing.Point(470, 218)
        Me.txtPlazos.Name = "txtPlazos"
        Me.txtPlazos.Size = New System.Drawing.Size(100, 20)
        Me.txtPlazos.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(252, 259)
        Me.Label1.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Cadencia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 218)
        Me.Label4.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Plazos:"
        '
        'txtDescipcion
        '
        Me.txtDescipcion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDescipcion.Location = New System.Drawing.Point(470, 182)
        Me.txtDescipcion.Name = "txtDescipcion"
        Me.txtDescipcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescipcion.TabIndex = 102
        Me.txtDescipcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodFPago
        '
        Me.txtCodFPago.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCodFPago.Location = New System.Drawing.Point(470, 144)
        Me.txtCodFPago.Name = "txtCodFPago"
        Me.txtCodFPago.Size = New System.Drawing.Size(100, 20)
        Me.txtCodFPago.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(252, 185)
        Me.Label3.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(252, 144)
        Me.Label2.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Código forma de pago:"
        '
        'FormFormasPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 788)
        Me.Controls.Add(Me.txtCadencia)
        Me.Controls.Add(Me.txtPlazos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescipcion)
        Me.Controls.Add(Me.txtCodFPago)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtgFormasPago)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.textCodPost)
        Me.Name = "FormFormasPago"
        Me.Text = "FormFormasPago"
        CType(Me.DtgFormasPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.textCodPost.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtgFormasPago As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents textCodPost As GroupBox
    Friend WithEvents BtnUltimo As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents BtnPrimero As Button
    Friend WithEvents txtCadencia As TextBox
    Friend WithEvents txtPlazos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescipcion As TextBox
    Friend WithEvents txtCodFPago As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class

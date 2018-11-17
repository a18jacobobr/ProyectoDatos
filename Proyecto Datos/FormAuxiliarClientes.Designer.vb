<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAuxiliarClientes
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
        Me.comboFormaPago = New System.Windows.Forms.ComboBox()
        Me.lblCodFormaPago = New System.Windows.Forms.Label()
        Me.dateTimeFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaAlta = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.txtTelfn = New System.Windows.Forms.TextBox()
        Me.lblTlfn = New System.Windows.Forms.Label()
        Me.comboCodSucursal = New System.Windows.Forms.ComboBox()
        Me.comboCodBanc = New System.Windows.Forms.ComboBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtPoblacion = New System.Windows.Forms.TextBox()
        Me.txtCodPost = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.TxtNif = New System.Windows.Forms.TextBox()
        Me.lblCodBanc = New System.Windows.Forms.Label()
        Me.lblCodSucursal = New System.Windows.Forms.Label()
        Me.LblCodProvee = New System.Windows.Forms.Label()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.lblPoblacion = New System.Windows.Forms.Label()
        Me.lblCodPost = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblNif = New System.Windows.Forms.Label()
        Me.LblTCodP = New System.Windows.Forms.Label()
        Me.txtDireccEnvio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(596, 523)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(117, 36)
        Me.BtnCancelar.TabIndex = 56
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(240, 523)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(117, 36)
        Me.BtnAceptar.TabIndex = 55
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'comboFormaPago
        '
        Me.comboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboFormaPago.FormattingEnabled = True
        Me.comboFormaPago.Location = New System.Drawing.Point(367, 423)
        Me.comboFormaPago.Name = "comboFormaPago"
        Me.comboFormaPago.Size = New System.Drawing.Size(100, 21)
        Me.comboFormaPago.TabIndex = 95
        '
        'lblCodFormaPago
        '
        Me.lblCodFormaPago.AutoSize = True
        Me.lblCodFormaPago.Location = New System.Drawing.Point(149, 423)
        Me.lblCodFormaPago.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCodFormaPago.Name = "lblCodFormaPago"
        Me.lblCodFormaPago.Size = New System.Drawing.Size(81, 13)
        Me.lblCodFormaPago.TabIndex = 94
        Me.lblCodFormaPago.Text = "Forma de pago:"
        '
        'dateTimeFechaAlta
        '
        Me.dateTimeFechaAlta.Location = New System.Drawing.Point(367, 323)
        Me.dateTimeFechaAlta.Name = "dateTimeFechaAlta"
        Me.dateTimeFechaAlta.Size = New System.Drawing.Size(200, 20)
        Me.dateTimeFechaAlta.TabIndex = 93
        '
        'lblFechaAlta
        '
        Me.lblFechaAlta.AutoSize = True
        Me.lblFechaAlta.Location = New System.Drawing.Point(149, 326)
        Me.lblFechaAlta.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblFechaAlta.Name = "lblFechaAlta"
        Me.lblFechaAlta.Size = New System.Drawing.Size(61, 13)
        Me.lblFechaAlta.TabIndex = 92
        Me.lblFechaAlta.Text = "Fecha Alta:"
        '
        'txtEmail
        '
        Me.txtEmail.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtEmail.Location = New System.Drawing.Point(367, 297)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(419, 20)
        Me.txtEmail.TabIndex = 91
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(149, 300)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 90
        Me.lblEmail.Text = "Email:"
        '
        'txtFax
        '
        Me.txtFax.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtFax.Location = New System.Drawing.Point(367, 268)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(100, 20)
        Me.txtFax.TabIndex = 89
        Me.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(149, 271)
        Me.lblFax.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(27, 13)
        Me.lblFax.TabIndex = 88
        Me.lblFax.Text = "Fax:"
        '
        'txtTelfn
        '
        Me.txtTelfn.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTelfn.Location = New System.Drawing.Point(367, 242)
        Me.txtTelfn.Name = "txtTelfn"
        Me.txtTelfn.Size = New System.Drawing.Size(100, 20)
        Me.txtTelfn.TabIndex = 87
        Me.txtTelfn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTlfn
        '
        Me.lblTlfn.AutoSize = True
        Me.lblTlfn.Location = New System.Drawing.Point(149, 245)
        Me.lblTlfn.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblTlfn.Name = "lblTlfn"
        Me.lblTlfn.Size = New System.Drawing.Size(52, 13)
        Me.lblTlfn.TabIndex = 86
        Me.lblTlfn.Text = "Teléfono:"
        '
        'comboCodSucursal
        '
        Me.comboCodSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCodSucursal.FormattingEnabled = True
        Me.comboCodSucursal.Location = New System.Drawing.Point(368, 391)
        Me.comboCodSucursal.Name = "comboCodSucursal"
        Me.comboCodSucursal.Size = New System.Drawing.Size(100, 21)
        Me.comboCodSucursal.TabIndex = 85
        '
        'comboCodBanc
        '
        Me.comboCodBanc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCodBanc.FormattingEnabled = True
        Me.comboCodBanc.Location = New System.Drawing.Point(368, 358)
        Me.comboCodBanc.Name = "comboCodBanc"
        Me.comboCodBanc.Size = New System.Drawing.Size(100, 21)
        Me.comboCodBanc.TabIndex = 84
        '
        'txtProvincia
        '
        Me.txtProvincia.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtProvincia.Location = New System.Drawing.Point(368, 216)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(100, 20)
        Me.txtProvincia.TabIndex = 83
        Me.txtProvincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPoblacion
        '
        Me.txtPoblacion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtPoblacion.Location = New System.Drawing.Point(368, 187)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(100, 20)
        Me.txtPoblacion.TabIndex = 82
        Me.txtPoblacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodPost
        '
        Me.txtCodPost.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCodPost.Location = New System.Drawing.Point(368, 156)
        Me.txtCodPost.Name = "txtCodPost"
        Me.txtCodPost.Size = New System.Drawing.Size(100, 20)
        Me.txtCodPost.TabIndex = 81
        Me.txtCodPost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDireccion
        '
        Me.txtDireccion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDireccion.Location = New System.Drawing.Point(368, 129)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(418, 20)
        Me.txtDireccion.TabIndex = 80
        Me.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombre
        '
        Me.txtNombre.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtNombre.Location = New System.Drawing.Point(368, 100)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 79
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNif
        '
        Me.TxtNif.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtNif.Location = New System.Drawing.Point(368, 68)
        Me.TxtNif.Name = "TxtNif"
        Me.TxtNif.Size = New System.Drawing.Size(100, 20)
        Me.TxtNif.TabIndex = 78
        '
        'lblCodBanc
        '
        Me.lblCodBanc.AutoSize = True
        Me.lblCodBanc.Location = New System.Drawing.Point(150, 358)
        Me.lblCodBanc.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCodBanc.Name = "lblCodBanc"
        Me.lblCodBanc.Size = New System.Drawing.Size(88, 13)
        Me.lblCodBanc.TabIndex = 77
        Me.lblCodBanc.Text = "Código Bancario:"
        '
        'lblCodSucursal
        '
        Me.lblCodSucursal.AutoSize = True
        Me.lblCodSucursal.Location = New System.Drawing.Point(150, 391)
        Me.lblCodSucursal.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCodSucursal.Name = "lblCodSucursal"
        Me.lblCodSucursal.Size = New System.Drawing.Size(87, 13)
        Me.lblCodSucursal.TabIndex = 76
        Me.lblCodSucursal.Text = "Código Sucursal:"
        '
        'LblCodProvee
        '
        Me.LblCodProvee.Location = New System.Drawing.Point(365, 34)
        Me.LblCodProvee.Name = "LblCodProvee"
        Me.LblCodProvee.Size = New System.Drawing.Size(83, 24)
        Me.LblCodProvee.TabIndex = 75
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(150, 219)
        Me.lblProvincia.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(54, 13)
        Me.lblProvincia.TabIndex = 74
        Me.lblProvincia.Text = "Provincia:"
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Location = New System.Drawing.Point(150, 187)
        Me.lblPoblacion.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(57, 13)
        Me.lblPoblacion.TabIndex = 73
        Me.lblPoblacion.Text = "Población:"
        '
        'lblCodPost
        '
        Me.lblCodPost.AutoSize = True
        Me.lblCodPost.Location = New System.Drawing.Point(150, 161)
        Me.lblCodPost.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblCodPost.Name = "lblCodPost"
        Me.lblCodPost.Size = New System.Drawing.Size(75, 13)
        Me.lblCodPost.TabIndex = 72
        Me.lblCodPost.Text = "Código Postal:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(150, 129)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lblDireccion.TabIndex = 71
        Me.lblDireccion.Text = "Direccion:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(150, 103)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 70
        Me.lblNombre.Text = "Nombre:"
        '
        'lblNif
        '
        Me.lblNif.AutoSize = True
        Me.lblNif.Location = New System.Drawing.Point(150, 68)
        Me.lblNif.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblNif.Name = "lblNif"
        Me.lblNif.Size = New System.Drawing.Size(27, 13)
        Me.lblNif.TabIndex = 69
        Me.lblNif.Text = "NIF:"
        '
        'LblTCodP
        '
        Me.LblTCodP.AutoSize = True
        Me.LblTCodP.Location = New System.Drawing.Point(150, 34)
        Me.LblTCodP.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.LblTCodP.Name = "LblTCodP"
        Me.LblTCodP.Size = New System.Drawing.Size(95, 13)
        Me.LblTCodP.TabIndex = 68
        Me.LblTCodP.Text = "Código Proveedor:"
        '
        'txtDireccEnvio
        '
        Me.txtDireccEnvio.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDireccEnvio.Location = New System.Drawing.Point(367, 459)
        Me.txtDireccEnvio.Name = "txtDireccEnvio"
        Me.txtDireccEnvio.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccEnvio.TabIndex = 97
        Me.txtDireccEnvio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(150, 462)
        Me.Label1.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Dirección de envío:"
        '
        'FormAuxiliarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 587)
        Me.Controls.Add(Me.txtDireccEnvio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboFormaPago)
        Me.Controls.Add(Me.lblCodFormaPago)
        Me.Controls.Add(Me.dateTimeFechaAlta)
        Me.Controls.Add(Me.lblFechaAlta)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.lblFax)
        Me.Controls.Add(Me.txtTelfn)
        Me.Controls.Add(Me.lblTlfn)
        Me.Controls.Add(Me.comboCodSucursal)
        Me.Controls.Add(Me.comboCodBanc)
        Me.Controls.Add(Me.txtProvincia)
        Me.Controls.Add(Me.txtPoblacion)
        Me.Controls.Add(Me.txtCodPost)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.TxtNif)
        Me.Controls.Add(Me.lblCodBanc)
        Me.Controls.Add(Me.lblCodSucursal)
        Me.Controls.Add(Me.LblCodProvee)
        Me.Controls.Add(Me.lblProvincia)
        Me.Controls.Add(Me.lblPoblacion)
        Me.Controls.Add(Me.lblCodPost)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblNif)
        Me.Controls.Add(Me.LblTCodP)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Name = "FormAuxiliarClientes"
        Me.Text = "FormAuxiliarClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents comboFormaPago As ComboBox
    Friend WithEvents lblCodFormaPago As Label
    Friend WithEvents dateTimeFechaAlta As DateTimePicker
    Friend WithEvents lblFechaAlta As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtFax As TextBox
    Friend WithEvents lblFax As Label
    Friend WithEvents txtTelfn As TextBox
    Friend WithEvents lblTlfn As Label
    Friend WithEvents comboCodSucursal As ComboBox
    Friend WithEvents comboCodBanc As ComboBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtPoblacion As TextBox
    Friend WithEvents txtCodPost As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents TxtNif As TextBox
    Friend WithEvents lblCodBanc As Label
    Friend WithEvents lblCodSucursal As Label
    Friend WithEvents LblCodProvee As Label
    Friend WithEvents lblProvincia As Label
    Friend WithEvents lblPoblacion As Label
    Friend WithEvents lblCodPost As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblNif As Label
    Friend WithEvents LblTCodP As Label
    Friend WithEvents txtDireccEnvio As TextBox
    Friend WithEvents Label1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProveedores))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblFiltrar = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.lblBuscarCodProveedor = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtCodBuscar = New System.Windows.Forms.TextBox()
        Me.textCodPost = New System.Windows.Forms.GroupBox()
        Me.BtnUltimo = New System.Windows.Forms.Button()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnPrimero = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtTlfn = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtPoblacion = New System.Windows.Forms.TextBox()
        Me.txtCodPos = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNif = New System.Windows.Forms.TextBox()
        Me.TxtCodProveedor = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.lblTlfn = New System.Windows.Forms.Label()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.lblPoblacion = New System.Windows.Forms.Label()
        Me.lblCodPost = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblNif = New System.Windows.Forms.Label()
        Me.lblCodProv = New System.Windows.Forms.Label()
        Me.txtFechaAlta = New System.Windows.Forms.TextBox()
        Me.lblFechaAlta = New System.Windows.Forms.Label()
        Me.txtCodFormaPago = New System.Windows.Forms.TextBox()
        Me.lblCodFormaPago = New System.Windows.Forms.Label()
        Me.txtCodSucursal = New System.Windows.Forms.TextBox()
        Me.lblCodSucursal = New System.Windows.Forms.Label()
        Me.txtCodBanc = New System.Windows.Forms.TextBox()
        Me.lblCodBanco = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.textCodPost.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.BtnEliminar)
        Me.Panel2.Controls.Add(Me.BtnModificar)
        Me.Panel2.Controls.Add(Me.BtnNuevo)
        Me.Panel2.Location = New System.Drawing.Point(821, 246)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 176)
        Me.Panel2.TabIndex = 47
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(66, 124)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(214, 32)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar Proveedor"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(43, 74)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(253, 32)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar Datos Proveedor"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(66, 20)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(214, 32)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo Proveedor"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LblFiltrar)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.BtnFiltrar)
        Me.Panel1.Controls.Add(Me.lblBuscarCodProveedor)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Controls.Add(Me.TxtCodBuscar)
        Me.Panel1.Location = New System.Drawing.Point(821, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(338, 162)
        Me.Panel1.TabIndex = 46
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(217, 108)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'LblFiltrar
        '
        Me.LblFiltrar.AutoSize = True
        Me.LblFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFiltrar.ForeColor = System.Drawing.Color.White
        Me.LblFiltrar.Location = New System.Drawing.Point(16, 112)
        Me.LblFiltrar.Name = "LblFiltrar"
        Me.LblFiltrar.Size = New System.Drawing.Size(63, 24)
        Me.LblFiltrar.TabIndex = 5
        Me.LblFiltrar.Text = "Filtrar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(16, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 24)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Buscar"
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Location = New System.Drawing.Point(85, 106)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(126, 36)
        Me.BtnFiltrar.TabIndex = 3
        Me.BtnFiltrar.Text = "..."
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'lblBuscarCodProveedor
        '
        Me.lblBuscarCodProveedor.AutoSize = True
        Me.lblBuscarCodProveedor.ForeColor = System.Drawing.Color.White
        Me.lblBuscarCodProveedor.Location = New System.Drawing.Point(16, 60)
        Me.lblBuscarCodProveedor.Name = "lblBuscarCodProveedor"
        Me.lblBuscarCodProveedor.Size = New System.Drawing.Size(81, 13)
        Me.lblBuscarCodProveedor.TabIndex = 0
        Me.lblBuscarCodProveedor.Text = "Cod.Proveedor:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(265, 55)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(54, 29)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtCodBuscar
        '
        Me.TxtCodBuscar.Location = New System.Drawing.Point(150, 55)
        Me.TxtCodBuscar.Name = "TxtCodBuscar"
        Me.TxtCodBuscar.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodBuscar.TabIndex = 1
        '
        'textCodPost
        '
        Me.textCodPost.Controls.Add(Me.BtnUltimo)
        Me.textCodPost.Controls.Add(Me.BtnSiguiente)
        Me.textCodPost.Controls.Add(Me.BtnAnterior)
        Me.textCodPost.Controls.Add(Me.BtnPrimero)
        Me.textCodPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.textCodPost.Location = New System.Drawing.Point(75, 542)
        Me.textCodPost.Name = "textCodPost"
        Me.textCodPost.Size = New System.Drawing.Size(1111, 72)
        Me.textCodPost.TabIndex = 45
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
        'txtEmail
        '
        Me.txtEmail.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtEmail.Location = New System.Drawing.Point(338, 359)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 43
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFax
        '
        Me.txtFax.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtFax.Location = New System.Drawing.Point(338, 321)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.ReadOnly = True
        Me.txtFax.Size = New System.Drawing.Size(100, 20)
        Me.txtFax.TabIndex = 42
        Me.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTlfn
        '
        Me.txtTlfn.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTlfn.Location = New System.Drawing.Point(338, 282)
        Me.txtTlfn.Name = "txtTlfn"
        Me.txtTlfn.ReadOnly = True
        Me.txtTlfn.Size = New System.Drawing.Size(100, 20)
        Me.txtTlfn.TabIndex = 41
        Me.txtTlfn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtProvincia
        '
        Me.txtProvincia.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtProvincia.Location = New System.Drawing.Point(338, 244)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.ReadOnly = True
        Me.txtProvincia.Size = New System.Drawing.Size(100, 20)
        Me.txtProvincia.TabIndex = 40
        Me.txtProvincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPoblacion
        '
        Me.txtPoblacion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtPoblacion.Location = New System.Drawing.Point(338, 204)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.ReadOnly = True
        Me.txtPoblacion.Size = New System.Drawing.Size(100, 20)
        Me.txtPoblacion.TabIndex = 39
        Me.txtPoblacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodPos
        '
        Me.txtCodPos.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCodPos.Location = New System.Drawing.Point(338, 168)
        Me.txtCodPos.Name = "txtCodPos"
        Me.txtCodPos.ReadOnly = True
        Me.txtCodPos.Size = New System.Drawing.Size(100, 20)
        Me.txtCodPos.TabIndex = 38
        Me.txtCodPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombre
        '
        Me.txtNombre.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtNombre.Location = New System.Drawing.Point(338, 91)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 37
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNif
        '
        Me.txtNif.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtNif.Location = New System.Drawing.Point(338, 52)
        Me.txtNif.Name = "txtNif"
        Me.txtNif.ReadOnly = True
        Me.txtNif.Size = New System.Drawing.Size(100, 20)
        Me.txtNif.TabIndex = 36
        '
        'TxtCodProveedor
        '
        Me.TxtCodProveedor.ForeColor = System.Drawing.Color.Blue
        Me.TxtCodProveedor.Location = New System.Drawing.Point(338, 20)
        Me.TxtCodProveedor.Name = "TxtCodProveedor"
        Me.TxtCodProveedor.ReadOnly = True
        Me.TxtCodProveedor.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodProveedor.TabIndex = 35
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(94, 362)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 33
        Me.lblEmail.Text = "Email:"
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(94, 324)
        Me.lblFax.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(27, 13)
        Me.lblFax.TabIndex = 32
        Me.lblFax.Text = "Fax:"
        '
        'lblTlfn
        '
        Me.lblTlfn.AutoSize = True
        Me.lblTlfn.Location = New System.Drawing.Point(94, 285)
        Me.lblTlfn.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTlfn.Name = "lblTlfn"
        Me.lblTlfn.Size = New System.Drawing.Size(52, 13)
        Me.lblTlfn.TabIndex = 31
        Me.lblTlfn.Text = "Teléfono:"
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Location = New System.Drawing.Point(94, 245)
        Me.lblProvincia.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(57, 13)
        Me.lblProvincia.TabIndex = 30
        Me.lblProvincia.Text = "Provincia.:"
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Location = New System.Drawing.Point(94, 207)
        Me.lblPoblacion.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(57, 13)
        Me.lblPoblacion.TabIndex = 29
        Me.lblPoblacion.Text = "Población:"
        '
        'lblCodPost
        '
        Me.lblCodPost.AutoSize = True
        Me.lblCodPost.Location = New System.Drawing.Point(94, 171)
        Me.lblCodPost.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCodPost.Name = "lblCodPost"
        Me.lblCodPost.Size = New System.Drawing.Size(75, 13)
        Me.lblCodPost.TabIndex = 28
        Me.lblCodPost.Text = "Código Postal:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(94, 94)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 27
        Me.lblNombre.Text = "Nombre:"
        '
        'lblNif
        '
        Me.lblNif.AutoSize = True
        Me.lblNif.Location = New System.Drawing.Point(94, 55)
        Me.lblNif.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblNif.Name = "lblNif"
        Me.lblNif.Size = New System.Drawing.Size(27, 13)
        Me.lblNif.TabIndex = 26
        Me.lblNif.Text = "NIF:"
        '
        'lblCodProv
        '
        Me.lblCodProv.AutoSize = True
        Me.lblCodProv.Location = New System.Drawing.Point(94, 18)
        Me.lblCodProv.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCodProv.Name = "lblCodProv"
        Me.lblCodProv.Size = New System.Drawing.Size(95, 13)
        Me.lblCodProv.TabIndex = 25
        Me.lblCodProv.Text = "Código Proveedor:"
        '
        'txtFechaAlta
        '
        Me.txtFechaAlta.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtFechaAlta.Location = New System.Drawing.Point(338, 395)
        Me.txtFechaAlta.Name = "txtFechaAlta"
        Me.txtFechaAlta.ReadOnly = True
        Me.txtFechaAlta.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaAlta.TabIndex = 49
        Me.txtFechaAlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFechaAlta
        '
        Me.lblFechaAlta.AutoSize = True
        Me.lblFechaAlta.Location = New System.Drawing.Point(94, 398)
        Me.lblFechaAlta.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblFechaAlta.Name = "lblFechaAlta"
        Me.lblFechaAlta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaAlta.TabIndex = 48
        Me.lblFechaAlta.Text = "Fecha de Alta:"
        '
        'txtCodFormaPago
        '
        Me.txtCodFormaPago.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCodFormaPago.Location = New System.Drawing.Point(338, 502)
        Me.txtCodFormaPago.Name = "txtCodFormaPago"
        Me.txtCodFormaPago.ReadOnly = True
        Me.txtCodFormaPago.Size = New System.Drawing.Size(100, 20)
        Me.txtCodFormaPago.TabIndex = 51
        Me.txtCodFormaPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCodFormaPago
        '
        Me.lblCodFormaPago.AutoSize = True
        Me.lblCodFormaPago.Location = New System.Drawing.Point(94, 505)
        Me.lblCodFormaPago.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCodFormaPago.Name = "lblCodFormaPago"
        Me.lblCodFormaPago.Size = New System.Drawing.Size(81, 13)
        Me.lblCodFormaPago.TabIndex = 50
        Me.lblCodFormaPago.Text = "Forma de pago:"
        '
        'txtCodSucursal
        '
        Me.txtCodSucursal.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCodSucursal.Location = New System.Drawing.Point(338, 466)
        Me.txtCodSucursal.Name = "txtCodSucursal"
        Me.txtCodSucursal.ReadOnly = True
        Me.txtCodSucursal.Size = New System.Drawing.Size(100, 20)
        Me.txtCodSucursal.TabIndex = 53
        Me.txtCodSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCodSucursal
        '
        Me.lblCodSucursal.AutoSize = True
        Me.lblCodSucursal.Location = New System.Drawing.Point(94, 469)
        Me.lblCodSucursal.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCodSucursal.Name = "lblCodSucursal"
        Me.lblCodSucursal.Size = New System.Drawing.Size(87, 13)
        Me.lblCodSucursal.TabIndex = 52
        Me.lblCodSucursal.Text = "Código Sucursal:"
        '
        'txtCodBanc
        '
        Me.txtCodBanc.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCodBanc.Location = New System.Drawing.Point(338, 429)
        Me.txtCodBanc.Name = "txtCodBanc"
        Me.txtCodBanc.ReadOnly = True
        Me.txtCodBanc.Size = New System.Drawing.Size(100, 20)
        Me.txtCodBanc.TabIndex = 55
        Me.txtCodBanc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCodBanco
        '
        Me.lblCodBanco.AutoSize = True
        Me.lblCodBanco.Location = New System.Drawing.Point(94, 432)
        Me.lblCodBanco.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCodBanco.Name = "lblCodBanco"
        Me.lblCodBanco.Size = New System.Drawing.Size(77, 13)
        Me.lblCodBanco.TabIndex = 54
        Me.lblCodBanco.Text = "Código Banco:"
        '
        'txtDireccion
        '
        Me.txtDireccion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDireccion.Location = New System.Drawing.Point(338, 129)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 57
        Me.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(94, 132)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(66, 13)
        Me.lblDireccion.TabIndex = 56
        Me.lblDireccion.Text = "Descripción:"
        '
        'FormProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 634)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtCodBanc)
        Me.Controls.Add(Me.lblCodBanco)
        Me.Controls.Add(Me.txtCodSucursal)
        Me.Controls.Add(Me.lblCodSucursal)
        Me.Controls.Add(Me.txtCodFormaPago)
        Me.Controls.Add(Me.lblCodFormaPago)
        Me.Controls.Add(Me.txtFechaAlta)
        Me.Controls.Add(Me.lblFechaAlta)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.textCodPost)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtTlfn)
        Me.Controls.Add(Me.txtProvincia)
        Me.Controls.Add(Me.txtPoblacion)
        Me.Controls.Add(Me.txtCodPos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtNif)
        Me.Controls.Add(Me.TxtCodProveedor)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblFax)
        Me.Controls.Add(Me.lblTlfn)
        Me.Controls.Add(Me.lblProvincia)
        Me.Controls.Add(Me.lblPoblacion)
        Me.Controls.Add(Me.lblCodPost)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblNif)
        Me.Controls.Add(Me.lblCodProv)
        Me.Name = "FormProveedores"
        Me.Text = "FormProveedores"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.textCodPost.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblFiltrar As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents lblBuscarCodProveedor As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtCodBuscar As TextBox
    Friend WithEvents textCodPost As GroupBox
    Friend WithEvents BtnUltimo As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents BtnPrimero As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFax As TextBox
    Friend WithEvents txtTlfn As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtPoblacion As TextBox
    Friend WithEvents txtCodPos As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtNif As TextBox
    Friend WithEvents TxtCodProveedor As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblFax As Label
    Friend WithEvents lblTlfn As Label
    Friend WithEvents lblProvincia As Label
    Friend WithEvents lblPoblacion As Label
    Friend WithEvents lblCodPost As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblNif As Label
    Friend WithEvents lblCodProv As Label
    Friend WithEvents txtFechaAlta As TextBox
    Friend WithEvents lblFechaAlta As Label
    Friend WithEvents txtCodFormaPago As TextBox
    Friend WithEvents lblCodFormaPago As Label
    Friend WithEvents txtCodSucursal As TextBox
    Friend WithEvents lblCodSucursal As Label
    Friend WithEvents txtCodBanc As TextBox
    Friend WithEvents lblCodBanco As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblDireccion As Label
End Class

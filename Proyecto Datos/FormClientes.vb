Imports System.Data.OleDb
Public Class FormClientes

    Dim DtsMClientes As DataSet
    Dim DtaClientes, DtaCPedidosC, DtaSucursales, DtaFormasPago, DtaDirEnvio As OleDbDataAdapter
    Public OperadoresString, OperadoresNumFec As String()
    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles Me.Load

        CnnGestion = New OleDbConnection _
            ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
            "C:\Users\Malocho\proyectos_visual_studio\source\repos\ProyectoDatos\Gestion comercial.mdb")
        DtaClientes = New OleDbDataAdapter("Select * from Clientes order by Codigo", CnnGestion)
        DtsMClientes = New DataSet
        DtaClientes.Fill(DtsMClientes, "Clientes")
        'Dim cmbProveedores As New OleDbCommandBuilder(DtaProveedores)

        DtaSucursales = New OleDbDataAdapter("Select * from Sucursales order by CodSuc", CnnGestion)
        DtaSucursales.Fill(DtsMClientes, "Sucursales")

        DtaFormasPago = New OleDbDataAdapter("Select * from FormasPago order by CodFPago", CnnGestion)
        DtaFormasPago.Fill(DtsMClientes, "FormasPago")

        DtaDirEnvio = New OleDbDataAdapter("Select * from Direcciones order by CodCli", CnnGestion)
        DtaDirEnvio.Fill(DtsMClientes, "Direccion")

        EnlazarControles()

    End Sub
    Private Sub EnlazarControles()
        TxtCodCliente.DataBindings.Add("Text", DtsMClientes.Tables("Clientes"), "Codigo")
        txtNif.DataBindings.Add("Text", DtsMClientes.Tables("Clientes"), "NIF")
        txtNombre.DataBindings.Add("Text", DtsMClientes.Tables("Clientes"), "Nombre")
        txtDireccion.DataBindings.Add("Text", DtsMClientes.Tables("Clientes"), "Dirección")
        txtCodPost.DataBindings.Add("Text", DtsMClientes.Tables("Clientes"), "Codpos")
        txtPoblacion.DataBindings.Add("Text", DtsMClientes.Tables("Clientes"), "Poblac")
        txtProvincia.DataBindings.Add("Text", DtsMClientes.Tables("Clientes"), "Provin")
        txtTlfn.DataBindings.Add("Text", DtsMClientes.Tables("Clientes"), "Tfno")
        txtFax.DataBindings.Add("Text", DtsMClientes.Tables("Clientes"), "Fax")
        txtEmail.DataBindings.Add("Text", DtsMClientes.Tables("Clientes"), "email")
        dateTimeFechaAlta.DataBindings.Add("Text", DtsMClientes.Tables("Clientes"), "FecAlta")
        txtCodBanc.DataBindings.Add("Text", DtsMClientes.Tables("Clientes"), "CodBan")
        txtCodSucur.DataBindings.Add("Text", DtsMClientes.Tables("Clientes"), "CodSuc")
        txtDireccEnvio.DataBindings.Add("Text", DtsMClientes.Tables("Clientes"), "DirEnv")
        txtFormaPago.DataBindings.Add("Text", DtsMClientes.Tables("Clientes"), "CodFPago")
        DtgProductos.DataSource = DtsMClientes.Tables("Clientes") '
        'ESTO ES EL DATA GRID'

    End Sub

    Private Sub BtnPrimero_Click(sender As Object, e As EventArgs) Handles BtnPrimero.Click
        Me.BindingContext(DtsMClientes.Tables("Clientes")).Position = 0
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        Me.BindingContext(DtsMClientes.Tables("Clientes")).Position -= 1
    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Me.BindingContext(DtsMClientes.Tables("Clientes")).Position += 1
    End Sub

    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click
        Me.BindingContext(DtsMClientes.Tables("Clientes")).Position =
                Me.BindingContext(DtsMClientes.Tables("Clientes")).Count - 1
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim FrmNuevo As New FormAuxiliarClientes
        EnlazarCombos(FrmNuevo)                                     'enlaza los combos con los campos existentes en la base de datos
        FrmNuevo.Text = "Nuevo Cliente"
        FrmNuevo.LblTCodC.Visible = False
        FrmNuevo.LblCodCliente.Visible = False
        If FrmNuevo.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim fCliente As DataRow
        fCliente = DtsMClientes.Tables("Clientes").NewRow()        'crea nueva columna en el dataset
        fCliente("Codigo") = ObtenerUltimoCodigo()                'pilla el ultimo ID
        CargarDatos(FrmNuevo, fCliente)                           'carga los datos del auxiliar
        DtsMClientes.Tables("Clientes").Rows.Add(fCliente)         'añade el row
        DtaClientes.Update(DtsMClientes.Tables("Clientes"))
        DtsMClientes.Tables("Clientes").AcceptChanges()
        BtnUltimo_Click(Nothing, Nothing)

    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim FrmModif As New FormAuxiliarClientes
        EnlazarCombos(FrmModif)
        FrmModif.Text = "Modificar Cliente"
        PasarDatos(FrmModif)
        FrmModif.dateTimeFechaAlta.Enabled = False
        If FrmModif.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim fCliente As DataRow
        fCliente = DtsMClientes.Tables("Clientes").Rows(Me.BindingContext(DtsMClientes.Tables("Clientes")).Position)
        fCliente.BeginEdit()
        CargarDatos(FrmModif, fCliente)
        fCliente.EndEdit()
        DtaClientes.Update(DtsMClientes.Tables("Clientes"))
        DtsMClientes.Tables("Clientes").AcceptChanges()

    End Sub
    Private Sub PasarDatos(FormularioDestino As FormAuxiliarClientes)
        With FormularioDestino
            .LblCodCliente.Text = TxtCodCliente.Text
            .TxtNif.Text = txtNif.Text
            .txtNombre.Text = txtNombre.Text
            .txtDireccion.Text = txtDireccion.Text
            .txtCodPost.Text = txtCodPost.Text
            .txtPoblacion.Text = txtPoblacion.Text
            .txtProvincia.Text = txtProvincia.Text
            .txtTelfn.Text = txtTlfn.Text
            .txtEmail.Text = txtEmail.Text
            .dateTimeFechaAlta.Value = dateTimeFechaAlta.Value
            MostrarValorEnCombo(DtsMClientes.Tables("Clientes"), "CodBan", .comboCodBanc, txtCodBanc.Text)             'metodo en procedimientos y datos globales
            MostrarValorEnCombo(DtsMClientes.Tables("Clientes"), "CodSuc", .comboCodSucursal, txtCodSucur.Text)
            MostrarValorEnCombo(DtsMClientes.Tables("Clientes"), "CodFPago", .comboFormaPago, txtFormaPago.Text)
            'MostrarValorEnCombo(DtsMClientes.Tables("Clientes"), "DirEnv", .comboDirEnvio, txtDireccEnvio.Text)
        End With

    End Sub
    Private Sub EnlazarCombos(formauxM As FormAuxiliarClientes)               'ENLAZAR LOS COMBOS, SON DEPENDIENTES EL UNO DEL OTRO y me falta por hacer
        With formauxM
            .comboCodBanc.DataSource = DtsMClientes.Tables("Sucursales")
            .comboCodBanc.DisplayMember = "CodSuc"          'esto es lo que enseña
            .comboCodBanc.ValueMember = "CodSuc"            'esto es lo que envía internamente
            .comboCodSucursal.DataSource = DtsMClientes.Tables("Sucursales")
            .comboCodSucursal.DisplayMember = "CodBanco"
            .comboCodSucursal.ValueMember = "CodBanco"
            .comboFormaPago.DataSource = DtsMClientes.Tables("FormasPago")
            .comboFormaPago.DisplayMember = "Descrip"
            .comboFormaPago.ValueMember = "CodFPago"
            .comboDirEnvio.DataSource = DtsMClientes.Tables("Direccion")
            .comboDirEnvio.DisplayMember = "Direccion"
            .comboDirEnvio.ValueMember = "CodCli"
        End With

    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("Eliminar cliente", MsgBoxStyle.Question + MsgBoxStyle.YesNo +
                        MsgBoxStyle.DefaultButton2, "Atención") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim fcliente As DataRow
        fcliente = DtsMClientes.Tables("Clientes").Rows(Me.BindingContext(DtsMClientes.Tables("Clientes")).Position)
        fcliente.Delete()
        DtaClientes.Update(DtsMClientes.Tables("Clientes"))
        DtsMClientes.Tables("Clientes").AcceptChanges()

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtCodBuscar.Text = "" Then
            MsgBox("Debe teclear un código de cliente", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If
        Dim posicion As Integer
        DtsMClientes.Tables("Clientes").DefaultView.Sort = "Codigo"
        posicion = DtsMClientes.Tables("Clientes").DefaultView.Find(TxtCodBuscar.Text)
        If posicion = -1 Then
            MsgBox("No hay ningún Cliente con el Código " & TxtCodBuscar.Text, MsgBoxStyle.Information, "Atención")
            TxtCodBuscar.Focus()
            TxtCodBuscar.SelectAll()

            Exit Sub
        End If
        TxtCodBuscar.Text = ""
        Me.BindingContext(DtsMClientes.Tables("Clientes")).Position = posicion
    End Sub



    Private Sub CargarDatos(FormularioOrigen As FormAuxiliarClientes, fila As DataRow)
        With FormularioOrigen

            fila("NIF") = .TxtNif.Text
            fila("Nombre") = .txtNombre.Text
            fila("Dirección") = .txtDireccion.Text
            fila("CodPos") = .txtCodPost.Text
            fila("Poblac") = .txtPoblacion.Text
            fila("Tfno") = CSng(.txtTelfn.Text)
            fila("fax") = CSng(.txtFax.Text)               'controlar valor num listo
            fila("email") = .txtEmail.Text
            fila("FecAlta") = .dateTimeFechaAlta.Value    'no se 
            fila("CodBan") = .comboCodBanc.SelectedValue
            fila("CodSuc") = .comboCodSucursal.SelectedValue
            fila("CodFPago") = .comboFormaPago.SelectedValue
            fila("DirEnv") = .comboDirEnvio.SelectedValue
        End With

    End Sub

    'Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Click

    '    Dim a = Color.CadetBlue.ToArgb


    'End Sub

    Private Function ObtenerUltimoCodigo() As Short
        Dim cmdultimo As New OleDbCommand("select max(Codigo) from Clientes", CnnGestion)
        Dim ultimo As Object
        Dim ultimoCod As Short
        CnnGestion.Open()
        ultimo = cmdultimo.ExecuteScalar
        CnnGestion.Close()

        If ultimo Is DBNull.Value Then
            ultimoCod = 1
        Else
            ultimoCod = CShort(ultimo) + 1
        End If
        Return ultimoCod
    End Function

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        Try
            OperadoresString = {"Igual a...", "Empieza por...", "Contiene...", "Es uno de estos...", "Distinto de"}
            OperadoresNumFec = {"=", "<", ">", "<=", ">=", "<>"}
            Dim TitulosCampos As String() = {"Codigo", "NIF", "Nombre", "Dirección", "Código Postal", "Población", "Provincia", "Teléfono", "Fax", "Email", "Fecha de Alta", "Código Banco", "Código Sucursal", "Forma de pago", "Dirección de envío"}

            If BtnFiltrar.Text = "Ver Todos" Then
                DtsMClientes.Tables("Clientes").DefaultView.RowFilter = ""
                BtnFiltrar.Text = "..."
                PictureBox1.Visible = False
                'Timer1.Stop()

                Exit Sub
            End If

            Dim frmf As New FormFiltrosClientes
            frmf.LblValores.Visible = False

            frmf.CmbCampos.Items.AddRange(TitulosCampos)
            'Dim columna As DataColumn
            'For Each columna In DtsMProductos.Tables("Prod").Columns
            '    frmf.CmbCampos.Items.Add(columna.ColumnName)
            'Next
            frmf.CmbCampos.SelectedIndex = 0

            If frmf.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If

            'Dim sfiltro As String = frmf.CmbCampos.Text
            Dim sfiltro As String = DtsMClientes.Tables("Clientes").Columns(frmf.CmbCampos.SelectedIndex).ColumnName
            Select Case frmf.CmbCampos.SelectedIndex
                Case 1, 2, 3, 5, 6, 9, 14

                    Select Case frmf.CmbOperadores.SelectedIndex

                        Case 0

                            sfiltro += " like '" & frmf.TxtValor.Text & "'"
                        Case 1

                            sfiltro += " like '" & frmf.TxtValor.Text & "%'"
                        Case 2

                            sfiltro += " like '%" & frmf.TxtValor.Text & "%'"
                        Case 3
                            sfiltro += " IN (" & frmf.TxtValor.Text & ")"
                        Case 4
                            sfiltro += "<> '" & frmf.TxtValor.Text & "'"
                    End Select
                Case 0, 4, 7, 8, 11, 12, 13
                    sfiltro += frmf.CmbOperadores.Text & frmf.TxtValor.Text
                Case 10
                    'FILTRO DATA TIME PICKER
                    sfiltro += frmf.CmbOperadores.Text & "'" & Format(dateTimeFechaAlta.Value, "Short Date") & "'"
            End Select
            Me.Cursor = Cursors.WaitCursor
            DtsMClientes.Tables("Clientes").DefaultView.RowFilter = sfiltro
            Me.Cursor = Cursors.Default
            PictureBox1.Visible = True
            'Timer1.Start()
            BtnFiltrar.Text = "Ver Todos"
        Catch ErrorNoNumerico As InvalidCastException
            MsgBox("No se pudo filtrar, revise el valor introducido", MsgBoxStyle.Exclamation, "Atención")

        Catch ErrorFiltro As EvaluateException
            MsgBox("No se pudo filtrar, revise el valor introducido", MsgBoxStyle.Exclamation, "Atención")

        Catch ErrorGeneral As Exception
            MsgBox("Error de la aplicación, avise a mantenimiento", MsgBoxStyle.Critical, "Atención")
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    ' Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    'PictureBox1.Visible = Not PictureBox1.Visible

    ' End Sub

End Class

Imports System.Data.OleDb
Public Class FormProveedores
    Dim DtsMProveedores As DataSet
    Dim DtaProveedores, DtaCPedidosC, DtaSucursales, DtaFormasPago As OleDbDataAdapter
    Public OperadoresString, OperadoresNumFec As String()
    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles Me.Load

        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "L:\DesenvolvementoInterfaces\proyectos visual studio\Proyecto Datos\Gestion comercial.mdb")
        DtaProveedores = New OleDbDataAdapter("Select * from Proveedores order by Codigo", CnnGestion)
        DtsMProveedores = New DataSet
        DtaProveedores.Fill(DtsMProveedores, "Provee")
        Dim cmbProveedores As New OleDbCommandBuilder(DtaProveedores)

        DtaSucursales = New OleDbDataAdapter("Select * from Sucursales order by CodSuc", CnnGestion)
        DtaSucursales.Fill(DtsMProveedores, "Sucursales")

        DtaFormasPago = New OleDbDataAdapter("Select * from FormasPago order by CodFPago", CnnGestion)
        DtaFormasPago.Fill(DtsMProveedores, "FormasPago")

        EnlazarControles()

    End Sub
    Private Sub EnlazarControles()
        TxtCodProveedor.DataBindings.Add("Text", DtsMProveedores.Tables("Provee"), "Codigo")
        txtNif.DataBindings.Add("Text", DtsMProveedores.Tables("Provee"), "NIF")
        txtNombre.DataBindings.Add("Text", DtsMProveedores.Tables("Provee"), "Nombre")
        txtDireccion.DataBindings.Add("Text", DtsMProveedores.Tables("Provee"), "Dirección")
        txtCodPos.DataBindings.Add("Text", DtsMProveedores.Tables("Provee"), "Codpos")
        txtPoblacion.DataBindings.Add("Text", DtsMProveedores.Tables("Provee"), "Poblac")
        txtProvincia.DataBindings.Add("Text", DtsMProveedores.Tables("Provee"), "Provin")
        txtTlfn.DataBindings.Add("Text", DtsMProveedores.Tables("Provee"), "Tfno")
        txtFax.DataBindings.Add("Text", DtsMProveedores.Tables("Provee"), "Fax")
        txtEmail.DataBindings.Add("Text", DtsMProveedores.Tables("Provee"), "email")
        dateTimeFechaAlltaProv.DataBindings.Add("Text", DtsMProveedores.Tables("Provee"), "FecAlta")
        txtCodBanc.DataBindings.Add("Text", DtsMProveedores.Tables("Provee"), "CodBan")
        txtCodSucursal.DataBindings.Add("Text", DtsMProveedores.Tables("Provee"), "CodSuc")
        txtCodFormaPago.DataBindings.Add("Text", DtsMProveedores.Tables("Provee"), "CodFPago")
        DtgProveedores.DataSource = DtsMProveedores.Tables("Provee") '
        'ESTO ES EL DATA GRID'

    End Sub

    Private Sub BtnPrimero_Click(sender As Object, e As EventArgs) Handles BtnPrimero.Click
        Me.BindingContext(DtsMProveedores.Tables("Provee")).Position = 0
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        Me.BindingContext(DtsMProveedores.Tables("Provee")).Position -= 1
    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Me.BindingContext(DtsMProveedores.Tables("Provee")).Position += 1
    End Sub

    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click
        Me.BindingContext(DtsMProveedores.Tables("Provee")).Position =
            Me.BindingContext(DtsMProveedores.Tables("Provee")).Count - 1
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim FrmNuevo As New frmAuxiliarProveedores
        EnlazarCombos(FrmNuevo)                                     'enlaza los combos con los campos existentes en la base de datos
        FrmNuevo.Text = "Nuevo Proveedor"
        FrmNuevo.LblTCodP.Visible = False
        FrmNuevo.LblCodProvee.Visible = False
        If FrmNuevo.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim fproveedor As DataRow
        fproveedor = DtsMProveedores.Tables("Provee").NewRow()        'crea nueva columna en el dataset
        fproveedor("Codigo") = ObtenerUltimoCodigo()                'pilla el ultimo ID
        CargarDatos(FrmNuevo, fproveedor)                           'carga los datos del auxiliar
        DtsMProveedores.Tables("Provee").Rows.Add(fproveedor)         'añade el row
        DtaProveedores.Update(DtsMProveedores.Tables("Provee"))
        DtsMProveedores.Tables("Provee").AcceptChanges()
        BtnUltimo_Click(Nothing, Nothing)

    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim FrmModif As New frmAuxiliarProveedores
        EnlazarCombos(FrmModif)
        FrmModif.Text = "Modificar Proveedor"
        PasarDatos(FrmModif)
        FrmModif.dateTimeFechaAlta.Enabled = False
        If FrmModif.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim fproveedor As DataRow
        fproveedor = DtsMProveedores.Tables("Provee").Rows(Me.BindingContext(DtsMProveedores.Tables("Provee")).Position)
        fproveedor.BeginEdit()
        CargarDatos(FrmModif, fproveedor)
        fproveedor.EndEdit()
        DtaProveedores.Update(DtsMProveedores.Tables("Provee"))
        DtsMProveedores.Tables("Provee").AcceptChanges()

    End Sub
    Private Sub PasarDatos(FormularioDestino As frmAuxiliarProveedores)
        With FormularioDestino
            .LblCodProvee.Text = TxtCodProveedor.Text
            .TxtNif.Text = txtNif.Text
            .txtNombre.Text = txtNombre.Text
            .txtDireccion.Text = txtDireccion.Text
            .txtCodPost.Text = txtCodPos.Text
            .txtPoblacion.Text = txtPoblacion.Text
            .txtProvincia.Text = txtProvincia.Text
            .txtTelfn.Text = txtTlfn.Text
            .txtEmail.Text = txtEmail.Text
            .dateTimeFechaAlta.Value = dateTimeFechaAlltaProv.Value
            MostrarValorEnCombo(DtsMProveedores.Tables("Provee"), "CodBan", .comboCodBanc, txtCodBanc.Text)             'metodo en procedimientos y datos globales
            MostrarValorEnCombo(DtsMProveedores.Tables("Provee"), "CodSuc", .comboCodSucursal, txtCodSucursal.Text)
            MostrarValorEnCombo(DtsMProveedores.Tables("Provee"), "CodFPago", .comboFormaPago, txtCodFormaPago.Text)
        End With

    End Sub
    Private Sub EnlazarCombos(formauxM As frmAuxiliarProveedores)               'ENLAZAR LOS COMBOS, SON DEPENDIENTES EL UNO DEL OTRO y me falta por hacer
        With formauxM
            .comboCodBanc.DataSource = DtsMProveedores.Tables("Sucursales")
            .comboCodBanc.DisplayMember = "CodSuc"          'esto es lo que enseña
            .comboCodBanc.ValueMember = "CodSuc"            'esto es lo que envía internamente
            .comboCodSucursal.DataSource = DtsMProveedores.Tables("Sucursales")
            .comboCodSucursal.DisplayMember = "CodBanco"
            .comboCodSucursal.ValueMember = "CodBanco"
            .comboFormaPago.DataSource = DtsMProveedores.Tables("FormasPago")
            .comboFormaPago.DisplayMember = "Descrip"
            .comboFormaPago.ValueMember = "CodFPago"
        End With

    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("Eliminar proveedor", MsgBoxStyle.Question + MsgBoxStyle.YesNo +
                  MsgBoxStyle.DefaultButton2, "Atención") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim fproveedor As DataRow
        fproveedor = DtsMProveedores.Tables("Provee").Rows(Me.BindingContext(DtsMProveedores.Tables("Provee")).Position)
        fproveedor.Delete()
        DtaProveedores.Update(DtsMProveedores.Tables("Provee"))
        DtsMProveedores.Tables("Provee").AcceptChanges()

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If TxtCodBuscar.Text = "" Then
            MsgBox("Debe teclear un código de proveedor", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End If
        Dim posicion As Integer
        DtsMProveedores.Tables("Provee").DefaultView.Sort = "Codigo"
        posicion = DtsMProveedores.Tables("Provee").DefaultView.Find(TxtCodBuscar.Text)
        If posicion = -1 Then
            MsgBox("No hay ningún Proveedor con el Código " & TxtCodBuscar.Text, MsgBoxStyle.Information, "Atención")
            TxtCodBuscar.Focus()
            TxtCodBuscar.SelectAll()

            Exit Sub
        End If
        TxtCodBuscar.Text = ""
        Me.BindingContext(DtsMProveedores.Tables("Provee")).Position = posicion
    End Sub



    Private Sub CargarDatos(FormularioOrigen As frmAuxiliarProveedores, fila As DataRow)
        With FormularioOrigen

            fila("NIF") = .TxtNif.Text
            fila("Nombre") = .txtNombre.Text
            fila("Dirección") = .txtDireccion.Text
            fila("CodPos") = CSng(.txtCodPost.Text)
            fila("Poblac") = .txtPoblacion.Text
            fila("Tfno") = CSng(.txtTelfn.Text)
            fila("fax") = CSng(.txtFax.Text)               'controlar valor num listo
            fila("email") = .txtEmail.Text
            fila("FecAlta") = .dateTimeFechaAlta.Value    'no se 
            fila("CodBan") = .comboCodBanc.SelectedValue
            fila("CodSuc") = .comboCodSucursal.SelectedValue
            fila("CodFPago") = .comboFormaPago.SelectedValue
        End With

    End Sub

    'Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Click

    '    Dim a = Color.CadetBlue.ToArgb


    'End Sub

    Private Function ObtenerUltimoCodigo() As Short
        Dim cmdultimo As New OleDbCommand("select max(Codigo) from Proveedores", CnnGestion)
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
            Dim TitulosCampos As String() = {"Codigo", "NIF", "Nombre", "Dirección", "Código Posta", "Población", "Provincia", "Teléfono", "Fax", "Email", "Fecha de Alta", "Código Banco", "Código Sucursal", "Forma de pago"}

            If BtnFiltrar.Text = "Ver Todos" Then
                DtsMProveedores.Tables("Provee").DefaultView.RowFilter = ""
                BtnFiltrar.Text = "..."
                PictureBox1.Visible = False
                'Timer1.Stop()

                Exit Sub
            End If

            Dim frmf As New FormFiltrosProvee
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
            Dim sfiltro As String = DtsMProveedores.Tables("Provee").Columns(frmf.CmbCampos.SelectedIndex).ColumnName
            Select Case frmf.CmbCampos.SelectedIndex
                Case 1, 2, 3, 5, 6, 9

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
                    sfiltro += frmf.CmbOperadores.Text & "'" & Format(dateTimeFechaAlltaProv.Value, "Short Date") & "'"
            End Select
            Me.Cursor = Cursors.WaitCursor
            DtsMProveedores.Tables("Provee").DefaultView.RowFilter = sfiltro
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
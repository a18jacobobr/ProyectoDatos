Imports System.Data.OleDb
Public Class FormFormasPago

    Dim DtsMFormasPago As DataSet
    Dim DtaMFormasPago As OleDbDataAdapter
    Public OperadoresString, OperadoresNumFec As String()
    Private Sub FrmFormasPago_Load(sender As Object, e As EventArgs) Handles Me.Load

        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "L:\DesenvolvementoInterfaces\proyectos visual studio\Proyecto Datos\Gestion comercial.mdb")
        DtaMFormasPago = New OleDbDataAdapter("Select * from FormasPago order by CodFPago", CnnGestion)
        DtsMFormasPago = New DataSet
        DtaMFormasPago.Fill(DtsMFormasPago, "FormasPago")
        Dim cmbFormasPago As New OleDbCommandBuilder(DtaMFormasPago)        'permite modificar


        EnlazarControles()

    End Sub
    Private Sub EnlazarControles()
        txtCodFPago.DataBindings.Add("Text", DtsMFormasPago.Tables("FormasPago"), "CodFPago")
        txtDescipcion.DataBindings.Add("Text", DtsMFormasPago.Tables("FormasPago"), "Descrip")
        txtPlazos.DataBindings.Add("Text", DtsMFormasPago.Tables("FormasPago"), "Plazos")
        txtCadencia.DataBindings.Add("Text", DtsMFormasPago.Tables("FormasPago"), "Cadencia")
        DtgFormasPago.DataSource = DtsMFormasPago.Tables("FormasPago") '
        'ESTO ES EL DATA GRID'

    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        Me.BindingContext(DtsMFormasPago.Tables("FormasPago")).Position -= 1
    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Me.BindingContext(DtsMFormasPago.Tables("FormasPago")).Position += 1
    End Sub

    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click
        Me.BindingContext(DtsMFormasPago.Tables("FormasPago")).Position =
            Me.BindingContext(DtsMFormasPago.Tables("FormasPago")).Count - 1
    End Sub

    Private Sub BtnPrimero_Click(sender As Object, e As EventArgs) Handles BtnPrimero.Click
        Me.BindingContext(DtsMFormasPago.Tables("FormasPago")).Position = 0
    End Sub
    Private Sub PasarDatos(FormularioDestino As FormAuxiliarFormasPago)
        With FormularioDestino
            .lblMuestraCodFormaPago.Text = txtCodFPago.Text
            .txtDescipcion.Text = txtDescipcion.Text
            .txtPlazos.Text = txtPlazos.Text
            .txtCadencia.Text = txtCadencia.Text
            ' MostrarValorEnCombo(DtsMProveedores.Tables("Provee"), "CodBan", .comboCodBanc, txtCodBanc.Text)             'metodo en procedimientos y datos globales
        End With

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim FrmNuevo As New FormAuxiliarFormasPago
        'enlaza los combos con los campos existentes en la base de datos
        FrmNuevo.Text = "Nueva forma de pago"
        FrmNuevo.lblMuestraCodFormaPago.Visible = False
        FrmNuevo.Label2.Visible = False
        If FrmNuevo.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim fFormaPago As DataRow
        fFormaPago = DtsMFormasPago.Tables("FormasPago").NewRow()        'crea nueva columna en el dataset
        fFormaPago("CodFPago") = ObtenerUltimoCodigo()                'pilla el ultimo ID
        CargarDatos(FrmNuevo, fFormaPago)                           'carga los datos del auxiliar
        DtsMFormasPago.Tables("FormasPago").Rows.Add(fFormaPago)         'añade el row
        DtaMFormasPago.Update(DtsMFormasPago.Tables("FormasPago"))
        DtsMFormasPago.Tables("FormasPago").AcceptChanges()
        BtnUltimo_Click(Nothing, Nothing)

    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim FrmModif As New FormAuxiliarFormasPago
        'EnlazarCombos(FrmModif)
        FrmModif.Text = "Modificar forma de pago"
        PasarDatos(FrmModif)
        If FrmModif.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim fFormaPago As DataRow
        fFormaPago = DtsMFormasPago.Tables("FormasPago").Rows(Me.BindingContext(DtsMFormasPago.Tables("FormasPago")).Position)
        fFormaPago.BeginEdit()
        CargarDatos(FrmModif, fFormaPago)
        fFormaPago.EndEdit()
        DtaMFormasPago.Update(DtsMFormasPago.Tables("FormasPago"))
        DtsMFormasPago.Tables("FormasPago").AcceptChanges()

    End Sub




    ' Private Sub EnlazarCombos(formauxM As frmAuxiliarProveedores)               'ENLAZAR LOS COMBOS, SON DEPENDIENTES EL UNO DEL OTRO y me falta por hacer
    'With formauxM
    '.comboCodBanc.DataSource = DtsMProveedores.Tables("Sucursales")
    '.comboCodBanc.DisplayMember = "CodSuc"          'esto es lo que enseña
    '.comboCodBanc.ValueMember = "CodSuc"            'esto es lo que envía internamente
    '.comboCodSucursal.DataSource = DtsMProveedores.Tables("Sucursales")
    '.comboCodSucursal.DisplayMember = "CodBanco"
    '.comboCodSucursal.ValueMember = "CodBanco"
    '.comboFormaPago.DataSource = DtsMProveedores.Tables("FormasPago")
    '.comboFormaPago.DisplayMember = "Descrip"
    '.comboFormaPago.ValueMember = "CodFPago"
    'End With

    'End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If MsgBox("Eliminar forma de pago", MsgBoxStyle.Question + MsgBoxStyle.YesNo +
                  MsgBoxStyle.DefaultButton2, "Atención") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim fFormaPago As DataRow
        fFormaPago = DtsMFormasPago.Tables("FormasPago").Rows(Me.BindingContext(DtsMFormasPago.Tables("FormasPago")).Position)
        fFormaPago.Delete()
        DtaMFormasPago.Update(DtsMFormasPago.Tables("FormasPago"))
        DtsMFormasPago.Tables("FormasPago").AcceptChanges()

    End Sub



    Private Sub CargarDatos(FormularioOrigen As FormAuxiliarFormasPago, fila As DataRow)
        With FormularioOrigen

            'fila("CodFPago") = .lblMuestraCodFormaPago.Text
            fila("Descrip") = .txtDescipcion.Text
            fila("Plazos") = .txtPlazos.Text
            fila("Cadencia") = .txtCadencia.Text
        End With

    End Sub

    'Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Click

    '    Dim a = Color.CadetBlue.ToArgb


    'End Sub

    Private Function ObtenerUltimoCodigo() As Short
        Dim cmdultimo As New OleDbCommand("select max(CodFPago) from FormasPago", CnnGestion)
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

    ' Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    'PictureBox1.Visible = Not PictureBox1.Visible

    ' End Sub


End Class
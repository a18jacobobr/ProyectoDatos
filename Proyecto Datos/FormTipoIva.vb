Imports System.Data.OleDb

Public Class FormTipoIva


    Dim DtsMTiposIva As DataSet
    Dim DtaMTiposIva As OleDbDataAdapter
    Public OperadoresString, OperadoresNumFec As String()
    Private Sub FrmTiposIva_Load(sender As Object, e As EventArgs) Handles Me.Load

        CnnGestion = New OleDbConnection _
        ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        "C:\Users\Malocho\proyectos_visual_studio\source\repos\ProyectoDatos\Gestion comercial.mdb")
        DtaMTiposIva = New OleDbDataAdapter("Select * from TiposIva order by TipoIva", CnnGestion)
        DtsMTiposIva = New DataSet
        DtaMTiposIva.Fill(DtsMTiposIva, "TipoIva")
        Dim cmbTiposIva As New OleDbCommandBuilder(DtaMTiposIva)


        EnlazarControles()

    End Sub
    Private Sub EnlazarControles()
        TxtTipoIva.DataBindings.Add("Text", DtsMTiposIva.Tables("TipoIva"), "TipoIva")
        txtPorcentaje.DataBindings.Add("Text", DtsMTiposIva.Tables("TipoIva"), "Porcentaje")
        DtgTipoIva.DataSource = DtsMTiposIva.Tables("TipoIva") '
        'ESTO ES EL DATA GRID'

    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        Me.BindingContext(DtsMTiposIva.Tables("TipoIva")).Position -= 1
    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Me.BindingContext(DtsMTiposIva.Tables("TipoIva")).Position += 1
    End Sub

    Private Sub BtnUltimo_Click(sender As Object, e As EventArgs) Handles BtnUltimo.Click
        Me.BindingContext(DtsMTiposIva.Tables("TipoIva")).Position =
            Me.BindingContext(DtsMTiposIva.Tables("TipoIva")).Count - 1
    End Sub

    Private Sub BtnPrimero_Click(sender As Object, e As EventArgs) Handles BtnPrimero.Click
        Me.BindingContext(DtsMTiposIva.Tables("TipoIva")).Position = 0
    End Sub
    Private Sub PasarDatos(FormularioDestino As FrmAuxiliarTipoIva)
        With FormularioDestino
            .lblMuestraTipoIva.Text = TxtTipoIva.Text
            .txtPorcentaje.Text = txtPorcentaje.Text
            ' MostrarValorEnCombo(DtsMProveedores.Tables("Provee"), "CodBan", .comboCodBanc, txtCodBanc.Text)             'metodo en procedimientos y datos globales
        End With

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim FrmNuevo As New FrmAuxiliarTipoIva
        'enlaza los combos con los campos existentes en la base de datos
        FrmNuevo.Text = "Nuevo Tipo Iva"
        FrmNuevo.lblTipoIva.Visible = False
        FrmNuevo.lblMuestraTipoIva.Visible = False
        If FrmNuevo.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim fTipoIva As DataRow
        fTipoIva = DtsMTiposIva.Tables("TipoIva").NewRow()        'crea nueva columna en el dataset
        fTipoIva("TipoIva") = ObtenerUltimoCodigo()                'pilla el ultimo ID
        CargarDatos(FrmNuevo, fTipoIva)                           'carga los datos del auxiliar
        DtsMTiposIva.Tables("TipoIva").Rows.Add(fTipoIva)         'añade el row
        DtaMTiposIva.Update(DtsMTiposIva.Tables("TipoIva"))
        DtsMTiposIva.Tables("TipoIva").AcceptChanges()
        BtnUltimo_Click(Nothing, Nothing)

    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim FrmModif As New FrmAuxiliarTipoIva
        'EnlazarCombos(FrmModif)
        FrmModif.Text = "Modificar Tipo Iva"
        PasarDatos(FrmModif)
        If FrmModif.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim fTipoIva As DataRow
        fTipoIva = DtsMTiposIva.Tables("TipoIva").Rows(Me.BindingContext(DtsMTiposIva.Tables("TipoIva")).Position)
        fTipoIva.BeginEdit()
        CargarDatos(FrmModif, fTipoIva)
        fTipoIva.EndEdit()
        DtaMTiposIva.Update(DtsMTiposIva.Tables("TipoIva"))
        DtsMTiposIva.Tables("TipoIva").AcceptChanges()

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
        If MsgBox("Eliminar Tipo Iva", MsgBoxStyle.Question + MsgBoxStyle.YesNo +
                  MsgBoxStyle.DefaultButton2, "Atención") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim fTipoIva As DataRow
        fTipoIva = DtsMTiposIva.Tables("TipoIva").Rows(Me.BindingContext(DtsMTiposIva.Tables("TipoIva")).Position)
        fTipoIva.Delete()
        DtaMTiposIva.Update(DtsMTiposIva.Tables("TipoIva"))
        DtsMTiposIva.Tables("TipoIva").AcceptChanges()

    End Sub



    Private Sub CargarDatos(FormularioOrigen As FrmAuxiliarTipoIva, fila As DataRow)
        With FormularioOrigen

            fila("TipoIva") = CShort(.lblMuestraTipoIva.Text)
            fila("Porcentaje") = CInt(.txtPorcentaje.Text)
        End With

    End Sub

    'Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Click

    '    Dim a = Color.CadetBlue.ToArgb


    'End Sub

    Private Function ObtenerUltimoCodigo() As Short
        Dim cmdultimo As New OleDbCommand("select max(TipoIva) from TiposIva", CnnGestion)
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

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '   PictureBox1.Visible = Not PictureBox1.Visible

    'End Sub




End Class
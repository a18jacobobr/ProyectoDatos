Public Class FormFiltrosProvee


    Private Sub FrmFiltros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtTimeFechaFiltro.Visible = False
        CmbCampos.SelectedIndex = 0

        CmbOperadores.Items.AddRange(FormProveedores.OperadoresNumFec)

        CmbOperadores.SelectedIndex = 0
        TxtValor.Visible = True


    End Sub

    Private Sub CmbCampos_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbCampos.SelectionChangeCommitted
        CmbOperadores.Items.Clear()
        LblSiNo.Hide()

        Select Case CmbCampos.SelectedIndex
            Case 1, 2, 3, 5, 6, 9
                CmbOperadores.Items.AddRange(FormProveedores.OperadoresString)
                dtTimeFechaFiltro.Visible = False
                TxtValor.Visible = True

            Case 0, 4, 7, 8, 12, 11, 13
                CmbOperadores.Items.AddRange(FormProveedores.OperadoresNumFec)
                dtTimeFechaFiltro.Visible = False
                TxtValor.Visible = True

            Case 10
                CmbOperadores.Items.AddRange(FormProveedores.OperadoresNumFec)
                dtTimeFechaFiltro.Visible = True
                TxtValor.Visible = False


        End Select
        CmbOperadores.SelectedIndex = 0
    End Sub
    Private Sub CmbOperadores_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbOperadores.SelectionChangeCommitted
        If CmbOperadores.SelectedItem = "Es uno de estos..." Then
            LblValores.Visible = True
        Else
            LblValores.Visible = False
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtValor.Text = "" And TxtValor.Visible = True Then
            MsgBox("No ha escrito ningún valor", MsgBoxStyle.Exclamation, "Atención")
            TxtValor.Focus()
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


End Class
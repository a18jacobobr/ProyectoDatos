Public Class FormAuxiliarClientes

    Dim dts As DataSet
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub


    Private Sub NumericosEnteros_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtTelfn.KeyPress, txtCodPost.KeyPress, txtFax.KeyPress
        Dim CajaTexto As System.Windows.Forms.TextBox
        CajaTexto = CType(sender, System.Windows.Forms.TextBox)
        Dim Validos As String = "0123456789" + Chr(8)
        If Not Validos.Contains(e.KeyChar) Then
            e.Handled = True
        End If

        'If e.KeyChar = "-" And (CajaTexto.Text.Contains("-") Or CajaTexto.SelectionStart <> 0) Then
        'e.Handled = True
        'End If
        ' If CajaTexto.SelectionStart = 0 And CajaTexto.Text.Contains("-") Then
        'e.Handled = True
        'End If
    End Sub

    'Private Sub NumericosConDecimales_KeyPress(sender As Object, e As KeyPressEventArgs) _
    '    Handles TxtPVP.KeyPress, TxtPCM.KeyPress
    '    Dim CajaTexto As System.Windows.Forms.TextBox
    '    CajaTexto = CType(sender, System.Windows.Forms.TextBox)
    '    Dim Validos As String = "0123456789.,-" + Chr(8)
    '    If Not Validos.Contains(e.KeyChar) Then
    '        e.Handled = True
    '    End If
    '    If e.KeyChar = "." Then
    '        e.KeyChar = ","
    '    End If
    '    If e.KeyChar = "," And CajaTexto.Text.Contains(",") Then
    '        e.Handled = True
    '    End If
    '    If e.KeyChar = "-" And (CajaTexto.Text.Contains("-") Or CajaTexto.SelectionStart <> 0) Then
    '        e.Handled = True
    '    End If
    '    If CajaTexto.SelectionStart = 0 And CajaTexto.Text.Contains("-") Then
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub ColorearCajasTexto_Enter(sender As Object, e As EventArgs) _
        Handles TxtNif.Enter, txtNombre.Enter, txtDireccion.Enter, txtCodPost.Enter, txtPoblacion.Enter, txtProvincia.Enter, txtTelfn.Enter, txtEmail.Enter, txtFax.Enter, dateTimeFechaAlta.Enter
        sender.backcolor = Color.Aquamarine

    End Sub

    Private Sub TxtDescri_Leave(sender As Object, e As EventArgs) _
        Handles TxtNif.Enter, txtNombre.Enter, txtDireccion.Enter, txtCodPost.Enter, txtPoblacion.Enter, txtProvincia.Enter, txtTelfn.Enter, txtEmail.Enter, txtFax.Enter, dateTimeFechaAlta.Enter
        sender.backcolor = Color.White
    End Sub

    Private Sub comboCodBanc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles comboCodBanc.SelectionChangeCommitted
        Dim filter As String = "CodBanco = " & comboCodBanc.SelectedValue
        dependeciaComb(dts, "Sucursales", comboCodSucursal, filter)
    End Sub

    Public Sub setDataset(data As DataSet)
        dts = data
    End Sub
End Class
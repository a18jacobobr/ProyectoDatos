Public Class FormMenu
    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim formulario As New FrmProductos
        formulario.ShowDialog()
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        Dim formulario As New FormProveedores
        formulario.ShowDialog()
    End Sub

    Private Sub btnTiposIva_Click(sender As Object, e As EventArgs) Handles btnTiposIva.Click
        Dim formulario As New FormTipoIva
        formulario.ShowDialog()
    End Sub

    Private Sub btnMetodosPago_Click(sender As Object, e As EventArgs) Handles btnMetodosPago.Click
        Dim formulario As New FormFormasPago
        formulario.ShowDialog()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim formulario As New FormClientes
        formulario.ShowDialog()
    End Sub
End Class
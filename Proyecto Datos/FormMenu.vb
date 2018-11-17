Public Class FormMenu
    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        FrmProductos.ShowDialog()
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        FormProveedores.ShowDialog()
    End Sub

    Private Sub btnTiposIva_Click(sender As Object, e As EventArgs) Handles btnTiposIva.Click
        FormTipoIva.ShowDialog()
    End Sub

    Private Sub btnMetodosPago_Click(sender As Object, e As EventArgs) Handles btnMetodosPago.Click
        FormFormasPago.ShowDialog()
    End Sub
End Class
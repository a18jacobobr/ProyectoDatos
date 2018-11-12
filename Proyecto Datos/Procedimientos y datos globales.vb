Imports System.Data.OleDb
Module Procedimientos_y_datos_globales
    Public CnnGestion As OleDbConnection

    Public Sub MostrarValorEnCombo(tabla As DataTable, campo As String, combo As ComboBox, valorABuscar As String)
        tabla.DefaultView.Sort = campo
        Dim posicion As Integer = tabla.DefaultView.Find(valorABuscar)

        If posicion = -1 Then
            combo.SelectedIndex = 0
        End If
        combo.SelectedIndex = posicion


    End Sub
End Module

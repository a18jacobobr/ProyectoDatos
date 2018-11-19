<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.AlbarLTableAdapter1 = New Proyecto_Datos.Gestion_comercialDataSetTableAdapters.AlbarLTableAdapter()
        Me.AlbarLTableAdapter2 = New Proyecto_Datos.Gestion_comercialDataSetTableAdapters.AlbarLTableAdapter()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnTiposIva = New System.Windows.Forms.Button()
        Me.btnMetodosPago = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProductos
        '
        Me.btnProductos.Location = New System.Drawing.Point(35, 24)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(239, 168)
        Me.btnProductos.TabIndex = 0
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'AlbarLTableAdapter1
        '
        Me.AlbarLTableAdapter1.ClearBeforeFill = True
        '
        'AlbarLTableAdapter2
        '
        Me.AlbarLTableAdapter2.ClearBeforeFill = True
        '
        'btnProveedores
        '
        Me.btnProveedores.Location = New System.Drawing.Point(540, 24)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(239, 168)
        Me.btnProveedores.TabIndex = 4
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'btnTiposIva
        '
        Me.btnTiposIva.Location = New System.Drawing.Point(35, 252)
        Me.btnTiposIva.Name = "btnTiposIva"
        Me.btnTiposIva.Size = New System.Drawing.Size(239, 168)
        Me.btnTiposIva.TabIndex = 5
        Me.btnTiposIva.Text = "Tipos de iva"
        Me.btnTiposIva.UseVisualStyleBackColor = True
        '
        'btnMetodosPago
        '
        Me.btnMetodosPago.Location = New System.Drawing.Point(540, 252)
        Me.btnMetodosPago.Name = "btnMetodosPago"
        Me.btnMetodosPago.Size = New System.Drawing.Size(239, 168)
        Me.btnMetodosPago.TabIndex = 6
        Me.btnMetodosPago.Text = "Métodos de pago"
        Me.btnMetodosPago.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(289, 132)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(239, 168)
        Me.btnClientes.TabIndex = 7
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.btnMetodosPago)
        Me.Controls.Add(Me.btnTiposIva)
        Me.Controls.Add(Me.btnProveedores)
        Me.Controls.Add(Me.btnProductos)
        Me.Name = "FormMenu"
        Me.Text = "FormMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProductos As Button
    Friend WithEvents AlbarLTableAdapter1 As Gestion_comercialDataSetTableAdapters.AlbarLTableAdapter
    Friend WithEvents AlbarLTableAdapter2 As Gestion_comercialDataSetTableAdapters.AlbarLTableAdapter
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnTiposIva As Button
    Friend WithEvents btnMetodosPago As Button
    Friend WithEvents btnClientes As Button
End Class

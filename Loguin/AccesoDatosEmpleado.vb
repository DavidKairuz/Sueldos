﻿Public Class AccesoDatosEmpleado

    Shared ctx As New LiquidacionSueldosEntities1

    Shared Sub MostrarEstadoCivil(combo As ComboBox)
        Dim dato = (From e In ctx.Estado_Civil
                    Select e.descripcion).ToList

        combo.DataSource = dato
        combo.DisplayMember = "descripcion"
        combo.ValueMember = "id_estadoCiv"
        combo.SelectedValue = -1

    End Sub

    Shared Sub AgregarEmpleado(emp As Empleado)
        ctx.Empleado.Add(emp)
        ctx.SaveChanges()
    End Sub



    Shared Sub EliminarEmpleado(idemp As Integer)
        Dim dato = (From e In ctx.Empleado
                    Where e.id_empleado = idemp
                    Select e).SingleOrDefault

        dato.estadobaja = 1
        ctx.SaveChanges()
    End Sub

    Shared Sub ActualizarConcepto(idemp As Integer, nombre As String, apellido As String, direc As String, dni As Integer, tel As Integer, fechna As Date, feching As Date, hijo As Integer, estciv As Integer)
        Dim dato = (From e In ctx.Empleado
                    Where e.id_empleado = idemp
                    Select e).SingleOrDefault
        With dato
            .nombre = nombre
            .apellido = apellido
            .direccion = direc
            .dni = dni
            .telefono = tel
            .fecha_nac = fechna
            .fecha_ing = feching
            .hijos = hijo


        End With

        ctx.SaveChanges()
    End Sub
    Shared Sub MostrarGridEmpleados(grid As DataGridView)
        Dim dato = (From s In ctx.Empleado
                    Select s).ToList
        grid.DataSource = dato
        grid.Columns(0).Visible = False

    End Sub

End Class

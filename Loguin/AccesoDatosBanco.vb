Public Class AccesoDatosBanco

    Shared ctx As New LiquidSueldosEntities

    Shared Sub MostrarBancosGrid(grid As DataGridView)


        Dim bank = (From b In ctx.Banco
                    Select b.id_banco, Nombre = b.nombre, Direccion = b.direccion, Telefono = b.telefono, Sucursal = b.sucursal_banco).ToList

        grid.DataSource = bank
        grid.Columns(0).Visible = False
        'Catch ex As NullReferenceException
        'MsgBox(ex.Message, MsgBoxStyle.Information, "nothing")

        'End Try

    End Sub

    ''Permite agregar un banco
    Shared Sub AgregarBanco(bank As Banco)
        ctx.Banco.Add(bank)
        ctx.SaveChanges()
    End Sub
    ''Da de baja logica un banco
    Shared Sub EliminarBanco(id As Integer)
        Try
            Dim dato = (From e In ctx.Banco
                        Where e.id_banco = id
                        Select e).SingleOrDefault

            dato.estadobaja = 1
            ctx.SaveChanges()
        Catch ex As Exception
            MsgBox(ex.Message("Algo paso"))
        End Try

    End Sub
    ''Modifica los datos del banco
    Shared Sub ActualizarBanco(Id As Integer, nom As String, dir As String, tel As String, suc As Integer)
        Dim bank = (From e In ctx.Banco
                    Where e.id_banco = Id
                    Select e).SingleOrDefault

        With bank
            .id_banco = Id
            .nombre = nom
            .direccion = dir
            .telefono = tel
            .sucursal_banco = suc
        End With

        ctx.SaveChanges()
    End Sub

    Shared Function MostrarBancoID(Id As Integer) As Banco

        Dim bank = (From e In ctx.Banco
                    Where e.id_banco = Id
                    Select e).SingleOrDefault 'para un solo registro utilizo singleordefault
        Return bank
    End Function


    Shared Function Existe(Id As Integer) As Boolean
        Dim result As Boolean
        '  Not context.Employees.Any (c => c.PayrollNumber = PropertyToCheck)
        'If (context.MyEntity.Any(o >= o.Id <> idToMAtch)) Then
        If (ctx.Banco.Any()) Then
            Dim ban = (From b In ctx.Banco
                       Where b.id_banco = Id
                       Select b).SingleOrDefault
            result = True


            ' If ctx.Banco.Any(Function(o) o.id_banco = Id) Then
            'MsgBox("ya existe")
            'End If

        Else
            result = False

        End If

        Return result

    End Function




End Class

Public Class EntidadBanco
    Private _id_banco As Integer
    Private _nombre As String
    Private _direccion As String
    Private _telefono As String
    Private _sucursal As String


    Property id_banco As Integer
        Get
            Return _id_banco
        End Get
        Set(value As Integer)
            _id_banco = value
        End Set
    End Property
    Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Property direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Property telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Property sucursal As Integer
        Get
            Return _sucursal
        End Get
        Set(value As Integer)
            _sucursal = value
        End Set
    End Property


End Class

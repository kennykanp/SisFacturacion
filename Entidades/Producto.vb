Public Class Producto
    Private _idCategoria, _idUnidadMedida As Integer
    Private _nombre, _estado As String
    Private _precioCompra, _precioVentas As Decimal


    Public Property idCategoria As Integer
        Get
            Return _idCategoria
        End Get
        Set(value As Integer)
            _idCategoria = value
        End Set
    End Property
    Public Property idUnidadMedida As Integer
        Get
            Return _idUnidadMedida
        End Get
        Set(value As Integer)
            _idUnidadMedida = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property


    Public Property precioCompra As Decimal
        Get
            Return _precioCompra
        End Get
        Set(value As Decimal)
            _precioCompra = value
        End Set
    End Property

    Public Property precioVentas As Decimal
        Get
            Return _precioVentas
        End Get
        Set(value As Decimal)
            _precioVentas = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(IdCate As Integer, IdUniMe As Integer, Nombre As String, estado As String, PrecioCompra As Decimal, PrecioVenta As Decimal)

        _idCategoria = IdCate
        _idUnidadMedida = IdUniMe
        _nombre = Nombre
        _precioCompra = PrecioCompra
        _precioVentas = PrecioVenta
        _estado = estado

    End Sub

End Class

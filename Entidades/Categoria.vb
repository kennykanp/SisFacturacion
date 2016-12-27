Public Class Categoria
    Dim _nombre, _abreviatura, _estado As String
    Dim _idCategoria As Integer

    Public Property idCategoria As String
        Get
            Return _idCategoria
        End Get
        Set(Value As String)
            _idCategoria = Value
        End Set
    End Property
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(Value As String)
            _nombre = Value
        End Set
    End Property

    Public Property abreviatura As String
        Get
            Return _abreviatura
        End Get
        Set(Value As String)
            _abreviatura = Value
        End Set
    End Property
    Public Property estado As String
        Get
            Return _estado
        End Get
        Set(Value As String)
            _estado = Value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(idCategoria As Integer, Nombre As String, Abreviatura As String, estado As String)
        _estado = estado
        _idCategoria = idCategoria
        _nombre = Nombre
        _abreviatura = Abreviatura
    End Sub


End Class

Public Class Cliente

    Private _nroDoc, _telefono As Integer
    Private _Nombres, _Direccion, _estado As String

    Public Property nroDoc As Integer
        Get
            Return _nroDoc
        End Get
        Set(Value As Integer)
            _nroDoc = Value
        End Set
    End Property

    Public Property telefono As Integer
        Get
            Return _telefono
        End Get
        Set(Value As Integer)
            _telefono = Value
        End Set
    End Property

    Public Property Nombres As String
        Get
            Return _Nombres
        End Get
        Set(Value As String)
            _Nombres = Value
        End Set
    End Property
    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(Value As String)
            _Direccion = Value
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

    Public Sub New(nroDoc As Integer, telefono As Integer, nombres As String, direccion As String, estado As String)

        _Nombres = nombres
        _nroDoc = nroDoc
        _Direccion = direccion
        _telefono = telefono
        _estado = estado

    End Sub

End Class

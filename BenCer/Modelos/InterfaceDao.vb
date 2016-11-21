Public Interface InterfaceDao(Of T)

    Function guardar(ByVal elemento As T) As Integer
    Function modificar(ByVal elemento As T, ByVal cod As Integer) As Integer
    Sub eliminar(ByVal cod As Integer)
    Function obtener(ByVal cod As Integer) As T
    Function listar() As List(Of T)

End Interface

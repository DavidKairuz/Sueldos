'------------------------------------------------------------------------------
' <auto-generated>
'    Este código se generó a partir de una plantilla.
'
'    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Tipo_Contrato
    Public Property id_tipoContrato As Integer
    Public Property descripcion As String
    Public Property estadobaja As Nullable(Of Boolean)

    Public Overridable Property Contrato As ICollection(Of Contrato) = New HashSet(Of Contrato)

End Class

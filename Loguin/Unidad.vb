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

Partial Public Class Unidad
    Public Property id_unidad As Integer
    Public Property descripcion As String
    Public Property estadobaja As Nullable(Of Boolean)

    Public Overridable Property Actividad As ICollection(Of Actividad) = New HashSet(Of Actividad)

End Class

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

Partial Public Class Actividad
    Public Property id_actividad As Integer
    Public Property id_convenio As Nullable(Of Integer)
    Public Property id_categoria As Nullable(Of Integer)
    Public Property descripcion As String
    Public Property id_unidad As Nullable(Of Integer)
    Public Property estadobaja As Nullable(Of Boolean)
    Public Property categoriaAct As Nullable(Of Integer)

    Public Overridable Property Empleado As ICollection(Of Empleado) = New HashSet(Of Empleado)
    Public Overridable Property Unidad As Unidad
    Public Overridable Property CategoriaA As CategoriaA
    Public Overridable Property Remuneraciones As ICollection(Of Remuneraciones) = New HashSet(Of Remuneraciones)
    Public Overridable Property CategoriaC As CategoriaC

End Class

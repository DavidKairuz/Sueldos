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

Partial Public Class Periodo
    Public Property id_periodo As Integer
    Public Property mes As String
    Public Property estadobaja As Nullable(Of Boolean)
    Public Property año As Nullable(Of Integer)

    Public Overridable Property Sueldo_Cab As ICollection(Of Sueldo_Cab) = New HashSet(Of Sueldo_Cab)

End Class

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

Partial Public Class Empresa
    Public Property id_empresa As Integer
    Public Property nombrefantasia As String
    Public Property direccion As String
    Public Property telefono As String
    Public Property cuitEmp As String
    Public Property provincia As Nullable(Of Integer)
    Public Property estadobaja As Nullable(Of Boolean)
    Public Property id_razon_social As Nullable(Of Integer)

    Public Overridable Property Empleado As ICollection(Of Empleado) = New HashSet(Of Empleado)
    Public Overridable Property Provincia1 As Provincia
    Public Overridable Property Razon_Social As Razon_Social
    Public Overridable Property Empresa_Sucursal As ICollection(Of Empresa_Sucursal) = New HashSet(Of Empresa_Sucursal)

End Class

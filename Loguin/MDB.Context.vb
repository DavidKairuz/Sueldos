﻿'------------------------------------------------------------------------------
' <auto-generated>
'    Este código se generó a partir de una plantilla.
'
'    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class LiquidSueldosEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=LiquidSueldosEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Property Actividad() As DbSet(Of Actividad)
    Public Property Banco() As DbSet(Of Banco)
    Public Property CategoriaA() As DbSet(Of CategoriaA)
    Public Property CategoriaC() As DbSet(Of CategoriaC)
    Public Property Concepto() As DbSet(Of Concepto)
    Public Property Contrato() As DbSet(Of Contrato)
    Public Property Convenio() As DbSet(Of Convenio)
    Public Property Empleado() As DbSet(Of Empleado)
    Public Property Empresa() As DbSet(Of Empresa)
    Public Property Empresa_Sucursal() As DbSet(Of Empresa_Sucursal)
    Public Property Estado_Civil() As DbSet(Of Estado_Civil)
    Public Property Localidad() As DbSet(Of Localidad)
    Public Property Obra_Social() As DbSet(Of Obra_Social)
    Public Property Periodo() As DbSet(Of Periodo)
    Public Property Provincia() As DbSet(Of Provincia)
    Public Property Razon_Social() As DbSet(Of Razon_Social)
    Public Property Remuneraciones() As DbSet(Of Remuneraciones)
    Public Property Sueldo_Cab() As DbSet(Of Sueldo_Cab)
    Public Property Sueldo_Det() As DbSet(Of Sueldo_Det)
    Public Property Tipo_Concepto() As DbSet(Of Tipo_Concepto)
    Public Property Tipo_Contrato() As DbSet(Of Tipo_Contrato)
    Public Property Unidad() As DbSet(Of Unidad)

End Class
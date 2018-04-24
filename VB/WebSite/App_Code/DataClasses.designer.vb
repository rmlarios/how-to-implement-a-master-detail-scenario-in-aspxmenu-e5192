﻿#Disable Warning 1591
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34003
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection



<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Nwind")> _
Partial Public Class DataClassesDataContext
    Inherits System.Data.Linq.DataContext

    Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()

  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertCategory(ByVal instance As Category)
  End Sub
  Partial Private Sub UpdateCategory(ByVal instance As Category)
  End Sub
  Partial Private Sub DeleteCategory(ByVal instance As Category)
  End Sub
  #End Region

    Public Sub New()
        MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("NwindConnectionString").ConnectionString, mappingSource)
        OnCreated()
    End Sub

    Public Sub New(ByVal connection As String)
        MyBase.New(connection, mappingSource)
        OnCreated()
    End Sub

    Public Sub New(ByVal connection As System.Data.IDbConnection)
        MyBase.New(connection, mappingSource)
        OnCreated()
    End Sub

    Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
        MyBase.New(connection, mappingSource)
        OnCreated()
    End Sub

    Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
        MyBase.New(connection, mappingSource)
        OnCreated()
    End Sub

    Public ReadOnly Property Categories() As System.Data.Linq.Table(Of Category)
        Get
            Return Me.GetTable(Of Category)()
        End Get
    End Property

    Public ReadOnly Property Products() As System.Data.Linq.Table(Of Product)
        Get
            Return Me.GetTable(Of Product)()
        End Get
    End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Categories")> _
Partial Public Class Category
    Implements INotifyPropertyChanging, INotifyPropertyChanged

    Private Shared emptyChangingEventArgs As New PropertyChangingEventArgs(String.Empty)

    Private _CategoryID As Integer

    Private _CategoryName As String

    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCategoryIDChanging(ByVal value As Integer)
    End Sub
    Partial Private Sub OnCategoryIDChanged()
    End Sub
    Partial Private Sub OnCategoryNameChanging(ByVal value As String)
    End Sub
    Partial Private Sub OnCategoryNameChanged()
    End Sub
    #End Region

    Public Sub New()
        OnCreated()
    End Sub

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CategoryID", DbType:="Int NOT NULL", IsPrimaryKey:=True)> _
    Public Property CategoryID() As Integer
        Get
            Return Me._CategoryID
        End Get
        Set(ByVal value As Integer)
            If (Me._CategoryID <> value) Then
                Me.OnCategoryIDChanging(value)
                Me.SendPropertyChanging()
                Me._CategoryID = value
                Me.SendPropertyChanged("CategoryID")
                Me.OnCategoryIDChanged()
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CategoryName", DbType:="NVarChar(15) NOT NULL", CanBeNull:=False)> _
    Public Property CategoryName() As String
        Get
            Return Me._CategoryName
        End Get
        Set(ByVal value As String)
            If (Me._CategoryName <> value) Then
                Me.OnCategoryNameChanging(value)
                Me.SendPropertyChanging()
                Me._CategoryName = value
                Me.SendPropertyChanged("CategoryName")
                Me.OnCategoryNameChanged()
            End If
        End Set
    End Property

    Public Event PropertyChanging As PropertyChangingEventHandler Implements INotifyPropertyChanging.PropertyChanging

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub SendPropertyChanging()
        RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
    End Sub

    Protected Overridable Sub SendPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Products")> _
Partial Public Class Product

    Private _ProductID As Integer

    Private _ProductName As String

    Private _CategoryID? As Integer

    Public Sub New()
    End Sub

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductID", DbType:="Int NOT NULL")> _
    Public Property ProductID() As Integer
        Get
            Return Me._ProductID
        End Get
        Set(ByVal value As Integer)
            If (Me._ProductID <> value) Then
                Me._ProductID = value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ProductName", DbType:="NVarChar(40) NOT NULL", CanBeNull:=False)> _
    Public Property ProductName() As String
        Get
            Return Me._ProductName
        End Get
        Set(ByVal value As String)
            If (Me._ProductName <> value) Then
                Me._ProductName = value
            End If
        End Set
    End Property

    <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CategoryID", DbType:="Int")> _
    Public Property CategoryID() As Integer?
        Get
            Return Me._CategoryID
        End Get
        Set(ByVal value? As Integer)
            If (Not Me._CategoryID.Equals(value)) Then
                Me._CategoryID = value
            End If
        End Set
    End Property
End Class
#Enable Warning 1591

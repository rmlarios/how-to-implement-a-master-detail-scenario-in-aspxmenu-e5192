Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.UI
Public Class MyDataSource
    Implements IHierarchicalDataSource

    Public Event DataSourceChanged As EventHandler ' This event is never used, but it's necessary for correct implementation of the IHierarchialDataSource interface

    Public Function GetHierarchicalView(ByVal viewPath As String) As HierarchicalDataSourceView
        Return New MyHierarchicalView()
    End Function
End Class
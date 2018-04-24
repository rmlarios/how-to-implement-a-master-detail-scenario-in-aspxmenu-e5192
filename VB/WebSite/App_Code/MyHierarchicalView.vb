Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.UI

Public Class MyHierarchicalView
    Inherits HierarchicalDataSourceView

    Public Overrides Function [Select]() As IHierarchicalEnumerable
        Using context As New DataClassesDataContext()
            Dim collection As List(Of MyHierarchyData) = context.Categories.Select(Function(Category) New MyHierarchyData(Category.CategoryID.ToString(), Nothing, Category.CategoryName)).ToList()
            Return New MyHierarchicalCollection(collection)
        End Using
    End Function
End Class
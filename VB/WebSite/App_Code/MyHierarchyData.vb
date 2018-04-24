Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.UI

Public Class MyHierarchyData
    Implements IHierarchyData

    Private Sub New()
    End Sub

    Public Sub New(ByVal id As String, ByVal parentID As String, ByVal text As String)
        Me.ID = id
        Me.ParentID = parentID
        Me.DisplayText = text
    End Sub

    Public ReadOnly Property Item() As Object
        Get
            Return Me
        End Get
    End Property
    Public ReadOnly Property Path() As String
        Get
            Return Me.ID
        End Get
    End Property
    Public ReadOnly Property Type() As String
        Get
            Return Me.GetType().ToString()
        End Get
    End Property

    Public ReadOnly Property HasChildren() As Boolean
        Get
            Dim children As MyHierarchicalCollection = TryCast(GetChildren(), MyHierarchicalCollection)
            Return children.Count > 0
        End Get
    End Property

    Public Property ID() As String
    Public Property ParentID() As String
    Public Property DisplayText() As String

    Public Overrides Function ToString() As String
        Return Me.DisplayText
    End Function

    Public Function GetChildren() As IHierarchicalEnumerable
        If Me.ID.Contains(";"c) Then ' ';' is separator between CategoryID and ProductID
            Return New MyHierarchicalCollection()
        End If
        Using context As New DataClassesDataContext()
            Dim categoryID As Integer = context.Categories.Where(Function(category) category.CategoryID.ToString() = Me.ID).Select(Function(category) category.CategoryID).FirstOrDefault()
            Dim collection() As MyHierarchyData = context.Products.Where(Function(product) categoryID = product.CategoryID).Select(Function(product) New MyHierarchyData(String.Format("{0};{1}", Me.ID, product.ProductID), Me.ID, product.ProductName)).ToArray()
            Return New MyHierarchicalCollection(collection)
        End Using
    End Function

    Public Function GetParent() As IHierarchyData
        If Not Me.ID.Contains(";"c) Then
            Return Nothing
        End If
        Using context As New DataClassesDataContext()
            Return context.Categories.Where(Function(category) category.CategoryID.ToString() = Me.ParentID).Select(Function(category) New MyHierarchyData(category.CategoryID.ToString(), Nothing, category.CategoryName)).FirstOrDefault()
        End Using
    End Function

End Class
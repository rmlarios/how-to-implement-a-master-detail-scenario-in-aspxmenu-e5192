Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.UI

Public Class MyHierarchicalCollection
	Inherits List(Of MyHierarchyData)
	Implements IHierarchicalEnumerable
	Public Sub New(ByVal collection As IEnumerable(Of MyHierarchyData))
		MyBase.New(collection)
	End Sub

	Public Sub New()
		MyBase.New()
	End Sub

	Public Function GetHierarchyData(ByVal enumeratedItem As Object) As IHierarchyData Implements IHierarchicalEnumerable.GetHierarchyData
		Return TryCast(enumeratedItem, IHierarchyData)
	End Function
End Class
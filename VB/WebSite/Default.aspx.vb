Imports Microsoft.VisualBasic
Imports DevExpress.Web.ASPxMenu
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Web.UI

Partial Public Class _Default
	Inherits Page
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		CreateMenuItems()
	End Sub

	Private Sub CreateMenuItems()
		Dim data As New MyDataSource()
		Menu.DataSource = data
		Menu.DataBind()
	End Sub
End Class

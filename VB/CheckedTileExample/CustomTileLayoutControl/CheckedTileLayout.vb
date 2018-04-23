Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.LayoutControl
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows

Namespace CheckedTileExample
	Friend Class CheckedTileLayout
		Inherits TileLayoutControl
		Public Shared ReadOnly CheckedTilesProperty As DependencyProperty = DependencyProperty.Register("CheckedTiles", GetType(ObservableCollection(Of Object)), GetType(CheckedTile), New PropertyMetadata(New ObservableCollection(Of Object)()))

		Public Property CheckedTiles() As ObservableCollection(Of Object)
			Get
				Return CType(GetValue(CheckedTilesProperty), ObservableCollection(Of Object))
			End Get
			Private Set(ByVal value As ObservableCollection(Of Object))
				SetValue(CheckedTilesProperty, value)
			End Set
		End Property

		Protected Overrides Sub OnMouseRightButtonDown(ByVal e As System.Windows.Input.MouseButtonEventArgs)
			MyBase.OnMouseRightButtonDown(e)
			ChangeCheckedTileState(e.Source)
		End Sub

		Public Sub SelectTile(ByVal tile As CheckedTile)
			ChangeCheckedTileState(tile)
		End Sub

		Private Sub ChangeCheckedTileState(ByVal obj As Object)
			If obj.GetType() Is GetType(CheckedTile) Then
				Dim element = TryCast(obj, CheckedTile)

				element.CheckTile()

				If element.IsChecked = True Then
					CheckedTiles.Add(element)
				Else
					CheckedTiles.Remove(element)
				End If
			End If
		End Sub
	End Class
End Namespace

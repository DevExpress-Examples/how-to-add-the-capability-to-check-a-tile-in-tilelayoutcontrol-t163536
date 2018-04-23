Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.LayoutControl
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Data

Namespace CheckedTileExample
	Public Class BorderConverter
		Implements IValueConverter
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			If CBool(value) = True Then
                Return 3
			Else
                Return 0
			End If
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class

	Friend Class CheckedTile
		Inherits Tile
		Public Shared ReadOnly IsCheckedProperty As DependencyProperty = DependencyProperty.Register("IsChecked", GetType(Boolean), GetType(CheckedTile), New PropertyMetadata(False))

		Public Property IsChecked() As Boolean
			Get
				Return CBool(GetValue(IsCheckedProperty))
			End Get
			Private Set(ByVal value As Boolean)
				SetValue(IsCheckedProperty, value)
			End Set
		End Property

		Public Sub CheckTile()
			IsChecked = Not IsChecked
		End Sub
	End Class
End Namespace

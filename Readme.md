<!-- default file list -->
*Files to look at*:

* [CheckedTileStyle.xaml](./CS/CheckedTileExample/CheckedTileStyle.xaml) (VB: [CheckedTileStyle.xaml](./VB/CheckedTileExample/CheckedTileStyle.xaml))
* [CheckedTile.cs](./CS/CheckedTileExample/CustomTile/CheckedTile.cs) (VB: [CheckedTile.vb](./VB/CheckedTileExample/CustomTile/CheckedTile.vb))
* [CheckedTileLayout.cs](./CS/CheckedTileExample/CustomTileLayoutControl/CheckedTileLayout.cs) (VB: [CheckedTileLayout.vb](./VB/CheckedTileExample/CustomTileLayoutControl/CheckedTileLayout.vb))
* [MainWindow.xaml](./CS/CheckedTileExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CheckedTileExample/MainWindow.xaml))
<!-- default file list end -->
# How to add the capability to check a Tile in TileLayoutControl


This example demonstrates how to add the capability to check a Tile into TileLayoutControl.<br />Our TileLayoutControl doesn't support it for now. To provide this functionality in this sample, we create a Tile class descendant with a custom dependency IsChecked property. We also create a TileLayoutControl class descendant with a custom collection of objects and a public SelectTile method. Then, we override the TileLayoutControl class descendant's OnMouseRightButtonDown method. When MouseRightButtonDown is raised, we change a corresponding Tile's IsChecked property and add/remove it to/from a custom collection. If we want to change the Tile's IsChecked property in code behind, we call the SelectTile method with this Tile as a parameter.

<br/>



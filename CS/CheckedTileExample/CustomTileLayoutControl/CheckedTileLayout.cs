using DevExpress.Xpf.LayoutControl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CheckedTileExample
{
    class CheckedTileLayout : TileLayoutControl
    {
        public static readonly DependencyProperty CheckedTilesProperty = DependencyProperty.Register("CheckedTiles", typeof(ObservableCollection<Object>), typeof(CheckedTile), new PropertyMetadata(new ObservableCollection<Object>()));

        public ObservableCollection<Object> CheckedTiles
        {
            get { return (ObservableCollection<Object>)GetValue(CheckedTilesProperty); }
            private set { SetValue(CheckedTilesProperty, value); }
        }

        protected override void OnMouseRightButtonDown(System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseRightButtonDown(e);
            ChangeCheckedTileState(e.Source);
        }

        public void SelectTile(CheckedTile tile)
        {
            ChangeCheckedTileState(tile);
        }

        void ChangeCheckedTileState(Object obj)
        {
            if (obj.GetType() == typeof(CheckedTile))
            {
                var element = obj as CheckedTile;

                element.CheckTile();

                if (element.IsChecked == true)
                {
                    CheckedTiles.Add(element);
                }
                else CheckedTiles.Remove(element);
            }
        }
    }
}

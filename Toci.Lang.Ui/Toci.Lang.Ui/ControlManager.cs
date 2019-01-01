

using System.Drawing;
using System.Windows.Forms;

namespace Toci.Lang.Ui
{
    public static class ControlManager
    {
        public static TControl CreateControl<TControl>(int sizeX, int sizeY, int locationX, int locationY, string text) where TControl : Control, new()
        {
            //DummySingleton ds = new DummySingleton();

            TControl lb = new TControl();
            
            lb.Text = text;
            lb.Size = new Size(sizeX, sizeY);
            lb.Location = new Point(locationX, locationY);
            return lb;
        }
    }
}
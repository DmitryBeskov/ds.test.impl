using System.Drawing;

namespace ds.test.impl.Plugins.Concrete;

internal class MultiPlugin : AbstractPlugin // Реализация плагина по умножению 
{
    public MultiPlugin(string pluginName, string version, Image image, string description) : base(pluginName, version, image, description)
    {
    }

    public override int Run(int input1, int input2)
    {
        return input1 * input2;
    }
}

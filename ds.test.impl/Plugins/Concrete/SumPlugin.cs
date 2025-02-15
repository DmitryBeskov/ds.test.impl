using System.Drawing;

namespace ds.test.impl.Plugins.Concrete;

internal class SumPlugin : AbstractPlugin // Реализация плагина по сложению 
{
    public SumPlugin(string pluginName, string version, Image image, string description) : base(pluginName, version, image, description)
    {
    }

    public override int Run(int input1, int input2)
    {
        return input1 + input2;
    }
}
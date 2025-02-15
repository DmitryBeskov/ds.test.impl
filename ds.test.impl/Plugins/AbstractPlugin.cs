using ds.test.impl.Interfaces;
using System.Drawing;

namespace ds.test.impl.Plugins;

internal abstract class AbstractPlugin : IPlugin // Частичная реализация интерфейса абстрактным классом
{
    public string PluginName { get; } = string.Empty;
    public string Version { get; } = string.Empty;
    public Image Image { get; } = null!;
    public string Description { get; } = string.Empty;

    public AbstractPlugin(string pluginName, string version, Image image, string description) 
    {
        PluginName = pluginName;
        Version = version;
        Image = image;
        Description = description;
    }

    public abstract int Run(int input1, int input2);
}
using ds.test.impl.Interfaces;
using ds.test.impl.Plugins.Concrete;

namespace ds.test.impl.Plugins;

public class Plugins : PluginFactory // Реализация интерфейса классом Plugins
{
    private List<IPlugin> _plugins = new List<IPlugin>()
    {
        new MultiPlugin("multiPlugin", "1.1", null, "умножение двух целочисленных"),
        new SumPlugin("sumPlugin", "1.4", null, "сложение двух целочисленных")
    };

    public int PluginsCount => _plugins.Count;
    public string[] GetPluginNames => _plugins.Select(x => x.PluginName).ToArray();

    public IPlugin GetPlugin(string pluginName)
    {
        IPlugin? plugin = _plugins.FirstOrDefault(x => x.PluginName == pluginName);
        
        if (plugin == null)
            throw new Exception("Плагин не найден");

        return plugin;
    }

    public void AddPlugin(IPlugin plugin)
    {
        if (plugin == null)
            throw new Exception("Плагин должен быть не null");

        _plugins.Add(plugin);
    }
}
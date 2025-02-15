using System.Drawing;

namespace ds.test.impl.Interfaces;

public interface IPlugin // Интерфейс, который будет доступен пользователю
{
    string PluginName { get; }
    string Version { get; }
    Image Image { get; }
    string Description { get; }
    int Run(int input1, int input2);
}
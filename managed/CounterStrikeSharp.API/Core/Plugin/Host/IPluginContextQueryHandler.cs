﻿namespace CounterStrikeSharp.API.Core.Plugin.Host;

public interface IPluginContextQueryHandler
{
    PluginContext? FindPluginByType(Type moduleClass);

    PluginContext? FindPluginById(int id);

    PluginContext? FindPluginByModuleName(string name);

    PluginContext? FindPluginByModulePath(string path);

    PluginContext? FindPluginByIdOrName(string query);
}
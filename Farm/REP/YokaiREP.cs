/*
name: null
description: null
tags: null
*/
//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
using Skua.Core.Interfaces;

public class YokaiREP
{
    public CoreBots Core => CoreBots.Instance;
    public CoreFarms Farm = new CoreFarms();
    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        Farm.YokaiREP();

        Core.SetOptions(false);
    }
}

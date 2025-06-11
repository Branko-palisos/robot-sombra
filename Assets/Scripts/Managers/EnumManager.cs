using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumManager : MonoBehaviour
{
   internal static EnumManager instance;

    internal enum Scenes
    {
        BananaScene,
        LevelLog,
        MainMenu,
        SettingsMenu,
        LevelMaker,
        Level1,
        Level2,
            
    };
   internal enum AnimatiorParameters
    {
        DanceTrigger,
    }
}

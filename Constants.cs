using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants : MonoBehaviour {

    // Scenes
    public const string SceneBattle = "Battle";
    public const string SceneMenu = "MainMenu";

    // Pickup Types
    public const int PickUpHealth = 4;
    public const int PickUpArmor = 5;

    // Misc
    public const string Game = "Game";
    public const float CameraDefaultZoom = 60f;

    public static readonly int[] AllPickupTypes = new int[2] {
      PickUpHealth,
      PickUpArmor,
        
    };
}

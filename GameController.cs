using UnityEngine;
using TMPro;

public static class GameController
{
    public static int collectableCount;
    public static int lifeCount;
    public static bool gameOver
    {
        get {return collectableCount >= 8 || lifeCount <= 0;}
    }

    public static void Init()
    {
        collectableCount = 0;
        lifeCount = 3;
    }

    public static void Collect()
    {
        collectableCount++;
    }

    public static void Damage()
    {
        lifeCount--;
    }
}

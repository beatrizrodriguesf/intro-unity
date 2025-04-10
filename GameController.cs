using UnityEngine;

public static class GameController
{
    private static int collectableCount;
    private static int lifeCount;
    public static bool gameOver
    {
        get {return collectableCount <= 0 || lifeCount <= 0;}
    }

    public static void Init()
    {
        collectableCount = 5;
        lifeCount = 3;
    }

    public static void Collect()
    {
        collectableCount--;
    }

    public static void Damage()
    {
        lifeCount--;
    }
}

using UnityEngine;
using TMPro;

public class InfoEnd : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalTime;
    [SerializeField] TextMeshProUGUI finalScore;
    private bool updated;

    void Start()
    {
        updated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.gameOver && !updated) {
            finalTime.text = string.Format("{0:00}:{1:00}", DisplayInfo.minutes, DisplayInfo.seconds);

            if (GameController.lifeCount == 0)
            {
                finalScore.text = "0";
            }
            else
            {
                finalScore.text = (50 + 400/(60*DisplayInfo.minutes + DisplayInfo.seconds)).ToString();
            }
            updated = true;
        }
    }
}

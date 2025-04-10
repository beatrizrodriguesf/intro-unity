using UnityEngine;
using TMPro;

public class DisplayInfo : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI lifeCount;
    float elapsedTime;

    // Update is called once per frame
    void Update()
    {
        if (!GameController.gameOver) {
            
            // time
            elapsedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(elapsedTime/60);
            int seconds = Mathf.FloorToInt(elapsedTime%60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

            // score e life count
            score.text = GameController.collectableCount.ToString();
            lifeCount.text = GameController.lifeCount.ToString();
        }
    }
}

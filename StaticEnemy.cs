using UnityEngine;

public class StaticEnemy : MonoBehaviour
{
    private AudioSource audio_enemy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audio_enemy = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            audio_enemy.Play();
            GameController.Damage();
        }
    }
}
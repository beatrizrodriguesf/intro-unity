using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    private AudioSource audio_enemy;
    private int direction;
    public float speed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio_enemy = GetComponent<AudioSource>();
        direction = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 movement = new Vector2(1, 0);
        rb.MovePosition(rb.position + movement*Time.fixedDeltaTime*speed*direction);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "obstacle")
        {
            direction *= -1;
        }
        else if (other.tag == "Player")
        {
            audio_enemy.Play();
            GameController.Damage();
        }
    }
}

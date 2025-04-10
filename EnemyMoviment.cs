using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    private AudioSource audio_enemy;
    public float speed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio_enemy = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 movement = PlayerMovement.rb.position - rb.position;
        rb.MovePosition(rb.position + movement*Time.fixedDeltaTime*speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            audio_enemy.Play();
            GameController.Damage();
        }
    }
}

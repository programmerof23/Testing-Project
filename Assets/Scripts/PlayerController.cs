using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int Score = 5;
    public float health = 10.0f;
    public string greeting = "Hi Player 1";
    public bool Alive = true;
    public float speed = 6;
    public GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        Score -= 3;
        if (health > 7 || Score > 3)
        {
            Debug.Log("Health is greater than 7");
        }
        Score += 1;
        Debug.Log("Score: " + Score);
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        Debug.Log("moveHorizontal= " + moveHorizontal);

        float moveVertical = Input.GetAxisRaw("Vertical");
        Debug.Log("moveVertical= " + moveVertical);

        Vector2 movement = new Vector2(moveHorizontal,moveVertical);

        transform.Translate(movement * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W was pressed");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
        scoreText.GetComponent<ScoreKeeper>().scoreValue += 5;
        //scoreText.GetComponent<ScoreKeeper>
        
    }
}

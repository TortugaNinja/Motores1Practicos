/*using System.Collections.Generic;
using UnityEngine;

public class LifeCounter : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private List<Sprite> sprites = new List<Sprite>();
    private SpriteRenderer heart;
    private int lives;
    private Animator playerAnimator;
    void Awake()
    {
      
        lives = player.GetLives();
        heart = GetComponent<SpriteRenderer>();
        heart.sprite = sprites[0];
        playerAnimator = player.GetComponent<Animator>();  
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int newlives = LooseLives();
        Die(newlives);
    }

    private int LooseLives()
    {
        if (player != null) { 
            
            if (player.gameObject.CompareTag("Obstacle") && lives > 0)
            {
                lives--;
            }
            
        }
        return lives;
    }

    private void Die(int lives) {

        if (player != null)
        {

            if (player.gameObject.CompareTag("Obstacle") && lives == 0)
            {
                GameManager.instance.ShowGameOverScreen();
                playerAnimator.SetTrigger("Die");
                Time.timeScale = 0;
                
            }
            else if (player.gameObject.CompareTag("Obstacle") && lives == 2)
            {
                heart.sprite = sprites[1];
            }
            else if (player.gameObject.CompareTag("Obstacle") && lives == 1)
            {
                heart.sprite = sprites[2];
            }

        }
    }


}*/

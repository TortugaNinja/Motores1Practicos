using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int lives = 3;
    [SerializeField] private int jumpingForce;
    [SerializeField] private GameObject gameOverScreen;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D player;
    private BoxCollider2D playerCollider;
    [SerializeField] private Ground collisionGround;



    private Animator playerAnimator;


    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerCollider = GetComponent<BoxCollider2D>();
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        bool isGrounded = Physics2D.IsTouching(playerCollider, collisionGround.GetComponent<BoxCollider2D>());
        playerAnimator.SetBool("isGrounded", isGrounded);

        if (isGrounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpingForce);

        }
    }

    public int GetLives()
    {
        return lives;
    }

    public void SetLives(int newlives)
    {
        lives = newlives;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //GameManager.Instance.ShowGameOverScreen();
            gameOverScreen.SetActive(true);
            playerAnimator.SetTrigger("Die");
            Time.timeScale = 0f;

        }
    }

    public void RestartScene()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       Time.timeScale = 1f;
    }
}


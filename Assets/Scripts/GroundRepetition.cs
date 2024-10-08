using UnityEngine;

public class GroundRepetition : MonoBehaviour
{
    private float spriteWidth;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteWidth = spriteRenderer.bounds.size.x;

    }

    // Update is called once per frame
    void Update()
    {

        RepeatGround();
    }

    private void RepeatGround()
    {
        if(transform.position.x < -spriteWidth)
        {
            transform.Translate(Vector2.right * 2f * spriteWidth);
        }
    }
}

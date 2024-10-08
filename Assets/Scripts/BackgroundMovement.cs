using UnityEngine;

public class BackGroundMovement : MonoBehaviour
{
   
    [SerializeField] private float scrollSpeed;
    void Start()
    {
       
    }

    private void Update()
    {
        ScrollLeft();
    }
   

    public void ScrollLeft()
    {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
    }
}

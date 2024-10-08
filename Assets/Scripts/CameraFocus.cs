using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Player player;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        if (player != null)
        {
            this.transform.position = new Vector3 (player.GetComponent<Rigidbody2D>().position.x, this.transform.position.y, this.transform.position.z);
        }
    }
}

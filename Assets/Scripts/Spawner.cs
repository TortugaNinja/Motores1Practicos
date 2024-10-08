using System.Collections;
using UnityEditor;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, obstacles.Length);
            float maxTime = 3f;
            float minTime = 1f;
            float randomTime = Random.Range(minTime, maxTime);
            Instantiate(obstacles[randomIndex], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(randomTime);
        }

    }


}

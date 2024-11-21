using UnityEngine;

public class TMPSpawnerScript : MonoBehaviour
{
    public GameObject tmp;
    public float spawnRate = 3;
    public float timer = 0;
    public float heightOffset = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTMP();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
        spawnTMP();
        timer = 0;
        }
    }
    void spawnTMP()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(tmp, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),0), transform.rotation);
    }
}

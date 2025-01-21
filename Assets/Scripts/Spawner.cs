using UnityEngine;

public class Spawner : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeigth = -1f;
    public float maxHeigth = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeigth, maxHeigth);
    }
}

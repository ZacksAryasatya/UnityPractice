using UnityEngine;

public class Coin : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Collider coinCollider;

    public Vector3 spawnAreaMin = new Vector3(-5, 0.5f, -5);
    public Vector3 spawnAreaMax = new Vector3(5, 0.5f, 5);

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        coinCollider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            meshRenderer.enabled = false;
            coinCollider.enabled = false;

            GameManager.instance.AddScore(1);



            Invoke(nameof(Respawn), 5f);

        }
    }

    void Respawn()
    {

        float randX = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
        float randY = spawnAreaMin.y; 
        float randZ = Random.Range(spawnAreaMin.z, spawnAreaMax.z);

        transform.position = new Vector3(randX, randY, randZ);

        meshRenderer.enabled = true;
        coinCollider.enabled = true;
    }
}

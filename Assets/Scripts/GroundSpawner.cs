using UnityEngine;

public class GroundSpawner : MonoBehaviour

{
    public GameObject groundTile;
    Vector3 nextSpawn;

    public void SpawnTile(bool spanwItems) 
    {
        GameObject temp = Instantiate(groundTile, nextSpawn, Quaternion.identity);
        nextSpawn = temp.transform.GetChild(1).transform.position;

        if (spanwItems)
        {
            temp.GetComponent<GroundTile>().SpawnObstacle();
            temp.GetComponent<GroundTile>().SpawCoins();
        }

    }

    void Start()
    {
        for (int i = 0; i < 15; i++) {
            if (i < 3)
            {
                SpawnTile(false);
            } else
            {
                SpawnTile(true);
            }
        }
    }
}

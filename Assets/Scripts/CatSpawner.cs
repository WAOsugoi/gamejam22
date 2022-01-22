using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] stoveSpawnRef;
    [SerializeField]
    private GameObject objectToBeSpawned;
    private GameObject spawnedCat;
    private GameObject logic;

    private int randomIndex;

    private void Awake()
    {
        logic = GameObject.Find("GameLogicManager");
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCat());
    }

    IEnumerator SpawnCat()
    {

        while (logic.GetComponent<GameLogicManager>().AllowedToSpawn())
        {

            yield return new WaitForSeconds(Random.Range(1, 3));

            randomIndex = Random.Range(0, stoveSpawnRef.Length);

            if (stoveSpawnRef[randomIndex].GetComponent<StoveController>().isSpawnable)
            {
                GameObject stove = stoveSpawnRef[randomIndex];
                spawnedCat = Instantiate(objectToBeSpawned);
                spawnedCat.transform.position = stove.GetComponent<StoveController>().spawner.transform.position;
                spawnedCat.transform.parent = stove.transform.parent;
                spawnedCat.transform.SetAsFirstSibling();
                stove.GetComponent<StoveController>().cat = spawnedCat;
                stove.GetComponent<StoveController>().isSpawnable = false;
                logic.GetComponent<GameLogicManager>().SpawnCatIfAllowed();
                Debug.Log("Cat spawned");
            }
        }
    }
}

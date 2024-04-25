using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditorInternal;

public class genertareEnemy : MonoBehaviour
{
    public GameObject BatPrefab;
    public int cuantityBat;
    public GameObject Character;

    // Start is called before the first frame update
    void Start()
    {
        cloneBat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void cloneBat()
    {
        for (int i = 0; i < cuantityBat-1; i++)
        {
            float characterpositionx = Character.transform.position.x;
            float characterpositionz = Character.transform.position.z;
            float xPosition = Random.Range(-9f, 10f);
            float zPosition = Random.Range(-8f, 8f);
            Vector3 spawnPosition = new Vector3(xPosition, 0f, zPosition);
            GameObject newBat = Instantiate(BatPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
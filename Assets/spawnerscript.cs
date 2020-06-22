using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerscript : MonoBehaviour
{
    public GameObject[] myObjects;



    float PositionX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);

    }

    // Update is called once per frame
    void Update()
    {


    }

    void SpawnObjects()
    {
        int randomIndex = Random.Range(0, myObjects.Length);
        PositionX = Random.Range(2, -2f);
        this.transform.position = new Vector3(PositionX, transform.position.y, transform.position.z);
        Instantiate(myObjects[randomIndex], transform.position, transform.rotation);
    }
}

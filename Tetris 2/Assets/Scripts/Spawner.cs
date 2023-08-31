using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject[] groups;

    public static int counter = 1;

    public GameObject randomprefab;

   
    public void spawnNext(int i)
    {
        if (counter % Playfield.frequency != 0)
        {


            //// Random Index
            //int i = Random.Range(0, groups.Length);

            // Spawn Group at current Position
            Instantiate(groups[i],
                        transform.position,
                        Quaternion.identity);
        counter++;
        }

        else
        {

            Instantiate(randomprefab, transform.position, Quaternion.identity);

        counter++;
        }

    }


    void Start()
    {
        int j = Random.Range(0, groups.Length);
        // Spawn initial Group
        spawnNext(j);
    }


}


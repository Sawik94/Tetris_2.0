using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Preview : MonoBehaviour
{
    public GameObject[] groups;

    public static int counter = 1;


    public GameObject randomprefab;

    public GameObject blok;

    public void spawnNext()
    {
        if (counter % 2 != 0)
        {


            // Random Index
            int i = Random.Range(0, groups.Length);

            // Spawn Group at current Position
            blok = Instantiate(groups[i],
                        transform.position,
                        Quaternion.identity);
            counter++;
        }

        else
        {

            blok = Instantiate(randomprefab, transform.position, Quaternion.identity);

            counter++;
        }

    }

    public void deleteObject()
    {
        Destroy(blok);
    }




    void Start()
    {

        // Spawn initial Group
        spawnNext();
    }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Preview : MonoBehaviour
{
    public GameObject[] groups;

    public static int counter = 2;

    public GameObject randomprefab;

    public GameObject blok;

    public static int number;

    public static int i;


    public void spawnNext()
    {

        i = Random.Range(0, groups.Length);
        number = i;
        if (counter % Playfield.frequency != 0)
        {


            // Random Index
            
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
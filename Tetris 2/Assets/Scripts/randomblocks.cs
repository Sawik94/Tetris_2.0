using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomblocks : MonoBehaviour
{


    public GameObject block;

    void SpawnRandom(StaticArrayHolder.Coord[,] tab)
    {
        for (int z = 0; z <= 4; z++)
        {
            for (int s = 0; s <= 4; s++)
            {

                if (tab[z, s]._exists == 1)
                {
                    birth(tab[z, s]._x+3, tab[z, s]._y+14);
                }

            }

        }
    }



    public void birth(int x, int y)
    {
        GameObject segment = Instantiate(this.block);
        segment.transform.position = new Vector3(x, y, 0);

        segment.transform.parent = this.transform;

    }

    void Start()
    {


    SpawnRandom(StaticArrayHolder.randtab);
        
    }

    void Update()
    {
        
    }
}


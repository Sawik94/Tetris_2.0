using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomblocks : MonoBehaviour
{


    public GameObject block;

    public struct Coord
    {
        public int _x;
        public int _y;
        public int _exists;
        public int _tag;
    }



    void SpawnRandom()
    {

        Coord[,] tab = new Coord[5, 5];

        for (int i = 0; i <= 4; i++)
        {
            for (int j = 0; j <= 4; j++)
            {
                tab[i, j]._x = 3 + i;
                tab[i, j]._y = 12 + j;
                tab[i, j]._exists = 0;
                tab[i, j]._tag = 0;
            }

        }

        int k = Random.Range(1, 100);

        if (k == 1)
        {
            k = 0;
        }
        else if (k == 2)
        {
            k = 1;
        }
        else if (k == 3)
        {
            k = 2;
        }
        else if (k <= 15)
        {
            k = 4;
        }
        else if (k <= 30)
        {
            k = 5;
        }
        else if (k <= 44)
        {
            k = 6;
        }
        else if (k <= 57)
        {
            k = 7;
        }
        else if (k <= 69)
        {
            k = 8;
        }
        else if (k <= 80)
        {
            k = 9;
        }
        else if (k <= 90)
        {
            k = 10;
        }
        else if (k <= 93)
        {
            k = 11;
        }
        else if (k <= 96)
        {
            k = 12;
        }
        else if (k <= 98)
        {
            k = 13;
        }
        else if (k == 99)
        {
            k = 14;
        }
        else if (k == 100)
        {
            k = 15;
        }

        int randx;
        int randy;
        birth(tab[2, 2]._x, tab[2, 2]._y);
        tab[2, 2]._exists = 1;
        tab[2, 1]._tag = 1;
        tab[2, 3]._tag = 1;
        tab[1, 2]._tag = 1; 
        tab[3, 2]._tag = 1;

        for (int l = 0; l < k; l++)
        {

            randx = Random.Range(0, 4);
            randy = Random.Range(0, 4);
            if (tab[randx, randy]._tag == 1 && tab[randx, randy]._exists == 0)
            {
                tab[randx, randy]._tag = 0;
              
                if (randx < 4)
                {
                    tab[randx + 1, randy]._tag = 1;
                }
                if (randx > 0)
                {
                    tab[randx - 1, randy]._tag = 1;
                }

                if (randy < 4)
                {
                    tab[randx, randy+1]._tag = 1;
                }
                if (randy > 0)
                {
                    tab[randx, randy-1]._tag = 1;
                }

                birth(tab[randx, randy]._x, tab[randx, randy]._y);
                tab[randx, randy]._exists = 1;

            }
            else
            {
                l--;
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

        SpawnRandom();
  
    }

    void Update()
    {
        
    }
}

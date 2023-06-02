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
    }



    void Funkcja()
    {

        Coord[,] tab = new Coord[5, 5];

        tab[1, 2]._x = 3;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                tab[i, j]._x = 3 + i;
                tab[i, j]._y = 12 + j;
                tab[i, j]._exists = 0;
            }

        }

        int k = Random.Range(5, 10);

        int randx;
        int randy;
        tab[2, 2]._exists = 1;
       


        for (int l = 0; l < k;l++)
        {
            randx = Random.Range(0, 4);
            randy = Random.Range(0, 4);
            if ((tab[randx, randy - 1]._exists == 1 || tab[randx + 1, randy]._exists == 1 || tab[randx - 1, randy]._exists == 1 || tab[randx, randy + 1]._exists == 1) && tab[randx, randy]._exists == 0)
            {
                birth(tab[randx, randy]._x, tab[randx, randy]._y);
                tab[randx, randy]._exists = 1;

            }
            else
            {
                l--;
            }
            birth(tab[2, 2]._x, tab[2, 2]._y);
        }


        //for (int l = 1; l < k; )
        //{
        //    randx = Random.Range(0, 4);
        //    randy = Random.Range(0, 4);

        //    if (tab[randx, randy]._exists == 0 && (tab[randx, randy - 1]._exists == 1 || tab[randx + 1, randy]._exists == 1 || tab[randx - 1, randy]._exists == 1 || tab[randx, randy+1]._exists == 1))
        //    {
        //        tab[randx, randy]._exists = 1;
        //        birth(tab[randx, randy]._x, tab[randx, randy]._y);

        //        l++;
        //    }
        //    else
        //    {
        //        continue;
        //    }



        //}



    }







    public void birth(int x, int y)
    {
        GameObject segment = Instantiate(this.block);
        segment.transform.position = new Vector3(x, y, 0);

        segment.transform.parent = this.transform;

    }

    void Start()
    {

        Funkcja();
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

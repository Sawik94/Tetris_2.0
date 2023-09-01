using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Group : MonoBehaviour
{
    private UI _UI;

    public bool isValidGridPos()
    {
        foreach (Transform child in transform)
        {
            Vector2 v = Playfield.roundVec2(child.position);

        
            if (!Playfield.insideBorder(v))
                return false;

     
            if (Playfield.grid[(int)v.x, (int)v.y] != null &&
                Playfield.grid[(int)v.x, (int)v.y].parent != transform)
                return false;
        }
        return true;
    }

    void updateGrid()
    {
  
        for (int y = 0; y < Playfield.h; ++y)
            for (int x = 0; x < Playfield.w; ++x)
                if (Playfield.grid[x, y] != null)
                    if (Playfield.grid[x, y].parent == transform)
                        Playfield.grid[x, y] = null;

    
        foreach (Transform child in transform)
        {
            Vector2 v = Playfield.roundVec2(child.position);
            Playfield.grid[(int)v.x, (int)v.y] = child;
        }
    }
 
    float lastFall = 0;




    void Start()
    {
        _UI = GameObject.Find("Score").GetComponent<UI>();
        if (_UI == null)
        {
            Debug.LogError("The UI is NULL");
        }



       
        if (!isValidGridPos())
        {
            UI.gameoverswitch = 1;
            Debug.Log("GAME OVER: " + UI.gameoverswitch);
            Destroy(gameObject);

        }
    }

    void Update()
    {
     
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           
            transform.position += new Vector3(-1, 0, 0);

          
            if (isValidGridPos())
           
                updateGrid();
            else
          
                transform.position += new Vector3(1, 0, 0);
        }


        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            transform.position += new Vector3(1, 0, 0);

            
            if (isValidGridPos())
             
                updateGrid();
            else
            
                transform.position += new Vector3(-1, 0, 0);
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, -90);

         
            if (isValidGridPos())
           
                updateGrid();
            else
           
                transform.Rotate(0, 0, 90);
        }

      
        else if (Input.GetKeyDown(KeyCode.DownArrow) ||
                 Time.time - lastFall >= 1)
        {
        
            transform.position += new Vector3(0, -1, 0);

            if (isValidGridPos())
            {
    
                updateGrid();
            }
            else
            {
               
                transform.position += new Vector3(0, 1, 0);

         
                Playfield.deleteFullRows();
                if (_UI != null)
                {
                    _UI.updatescore(UI.NumberOfRows);
                }

                FindObjectOfType<Spawner>().spawnNext(Preview.number);
                FindObjectOfType<Preview>().deleteObject();
                FindObjectOfType<Preview>().spawnNext();

                enabled = false;
            }

            lastFall = Time.time;
        }
    }
}








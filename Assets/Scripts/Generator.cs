using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public Transform transform;
    public GameObject O18E69P1;
    public GameObject O69E18P1;
    public GameObject O18E69P2;
    public GameObject O69E18P2;
    public int heightSpawn = 38;
    public int lastUsed;
    public GameObject selected;
    public int temp;
    public Transform parentTransform;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y+10 > heightSpawn){
            heightSpawn += 3;
            if(lastUsed == 1869){
                Debug.Log("Run1");
                lastUsed = 6918;
                temp = Random.Range(1,3);
                switch(temp){
                    case 1:
                        selected = O69E18P1;
                        break;
                    
                    case 2:
                        selected = O69E18P2;
                        break;
                }
                var position = new Vector3(0,heightSpawn-3,0);
                Instantiate(selected,position,Quaternion.identity);
            }
            else if(lastUsed == 6918){
                Debug.Log("Run2");
                lastUsed = 1869;
                temp = Random.Range(1,3);
                switch(temp){
                    case 1:
                        selected = O18E69P1;
                        break;
                    
                    case 2:
                        selected = O18E69P2;
                        break;
                }
                var position = new Vector3(transform.position.x,heightSpawn-3,transform.position.z);
                Instantiate(selected,position,Quaternion.identity);
            }
        }
    }
}

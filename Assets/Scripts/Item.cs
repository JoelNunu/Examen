using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int ID;
    public Sprite Sprite;
    // Start is called before the first frame update
    void OnCollected()
    {
        GameManager.gameManager.ItemCollected(Sprite, ID);
        Destroy(Gameobject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

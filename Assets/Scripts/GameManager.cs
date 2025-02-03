using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager gameManager;
    public int Orbs = 0, Coins = 0;
    public TextMeshProUGUI CoinsText, OrbsText;
    public List <Image> items;
    // Start is called before the first frame update
    private void Awake() 
    {
        if (GameManager.gameManager != null && GameManager.gameManager != this)
        Destroy(gameObject);

        else
        {
            GameManager.gameManager = this;
            DontDestroyOnLoad(gameObject);

        }
        CoinsText.text = "Coins: " + Coins;
        OrbsText.text = "Orbs: " + Orbs;
    }
    public void OrbCollected()
        {
            Orbs++;
            OrbsText.text = "Orbs: " + Orbs;
        }
    public void CoinCollected()
    {
        Coins++;
        CoinsText.text = "Coins: " + Coins;
    }
    public interface ICollectable
    {
        public void OnCollected();

    }
        
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

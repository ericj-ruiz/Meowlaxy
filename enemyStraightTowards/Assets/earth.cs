using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class earth : MonoBehaviour
{
    public Image healthBar;
    public float hp =10f;

   
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.GetComponent<enemy>() || collision.gameObject.GetComponent<enemy2>())
        {
            
            hp--;
            healthBar.fillAmount = hp /10f;
            Destroy(collision.gameObject);
            
            if (hp <= 0)
            {
                Destroy(gameObject);
            }

        }
        
    }
}

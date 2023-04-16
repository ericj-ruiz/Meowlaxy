using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] private GameObject earth;
    [SerializeField] private float speed = 1.5f;
    public float hp = 20;


    // Start is called before the first frame update
    void Start()
    {
        earth = GameObject.FindGameObjectWithTag("planet");
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        BulletController bc = collision.gameObject.GetComponent<BulletController>();
        if (bc) 
        {
    
            hp--;
            if(hp <= 0 )
            {
                Destroy(gameObject);
            }
        
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, earth.transform.position, speed * Time.deltaTime);  
        
    }
}

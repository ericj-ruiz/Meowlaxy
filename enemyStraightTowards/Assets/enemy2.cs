using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
    [SerializeField] private GameObject earth;
    [SerializeField] private float speed = 2.0f;
    public float hp = 2;
    //faster speed
    // more hp

    Vector2 pos, target;
    float currentTime =0f;
    float startingTime =1f;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        pos = transform.position;
        target = earth.transform.position;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        BulletController bc = collision.gameObject.GetComponent<BulletController>();
        if (bc)
        {
            hp--;
            if (hp <= 0)
            {
                Destroy(gameObject);
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
       currentTime -= Time.deltaTime;
        if (currentTime <=0)
        {
            target.x += Random.Range(-2f, 2f);
            target.y += Random.Range(-2f,2f);
            currentTime = startingTime;
        }
       
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rotateAround;
    public float speed;
    [SerializeField] GameObject EnemyPrefab;
    [SerializeField] GameObject spawnPoint;

    public float hp = 20;

    float currentTime = 0f;
    float startingTime = 0f;
    
 
    private void SpawnEnemy()
    {
        GameObject en = Instantiate(EnemyPrefab);
        en.transform.position = spawnPoint.transform.position;
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

    void Update()
    {
        transform.RotateAround(rotateAround.transform.position, Vector3.forward, speed * Time.deltaTime);

        currentTime += Time.deltaTime;
        if (currentTime >= 3)
        {
            SpawnEnemy();
            currentTime = startingTime;
        }
    }
}

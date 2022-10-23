using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletController : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpawnInterval = 1.0f;

    [SerializeField] public AudioSource bulletSpawnSound;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootBullet", bulletSpawnInterval, bulletSpawnInterval); 
    }

    private void ShootBullet()
    {
        GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
        bulletSpawnSound.Play();
    }
}

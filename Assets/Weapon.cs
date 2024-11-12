using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 0.2f;
    public float bulletForce = 10f;

    private void Start()
    {
        StartCoroutine(AutomaticFire());
    }


    private IEnumerator AutomaticFire()
    {
        while (true)
        {
            Fire();
            yield return new WaitForSeconds(fireRate);  // Espera antes del siguiente disparo
        }
    }




    public void Fire()
    {
        // Crea una bala en la posición y rotación del punto de disparo
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Obtiene el Rigidbody2D de la bala para aplicar fuerza
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            // Aplica fuerza en la dirección en la que está mirando el `firePoint`
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        }
    }


}

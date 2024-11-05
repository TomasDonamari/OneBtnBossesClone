using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadDeRotacion = 50f;
    public Transform pivote;

    public Rigidbody2D rb;
    public Weapon weapon;

    //Vector2 moveDirection;
    //Vector2 mouseDirection;



    void Update()
    {
      
        if (Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
        }

        
        //mouseDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        this.transform.RotateAround(pivote.transform.position, Vector3.forward, velocidadDeRotacion * Time.deltaTime);


        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.RotateAround(pivote.transform.position, Vector3.forward, velocidadDeRotacion * Time.deltaTime);
        }


        
    }

    private void FixedUpdate()
    {
       

        //Vector2 aimDirection = mouseDirection - rb.position;
        //float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        //rb.rotation = aimAngle;
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour
{
    public float velocidadDeRotacion = 50f;
    public Transform pivote;
    private bool clockwise = true;

    public Rigidbody2D rb;
    public Weapon weapon;

    //Vector2 moveDirection;
    //Vector2 mouseDirection;



    void Update()
    {

        //if (Input.GetMouseButtonDown(0))
        //{
           // weapon.Fire();
        //}


        //mouseDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float direction = clockwise ? 1f : -1f;
        transform.RotateAround(pivote.position, Vector3.forward, direction * velocidadDeRotacion * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.R))
        {
            clockwise = !clockwise; // Invierte el sentido de rotación
        }


    }



    private void FixedUpdate()
    {
       

        //Vector2 aimDirection = mouseDirection - rb.position;
        //float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        //rb.rotation = aimAngle;
    }

    
}

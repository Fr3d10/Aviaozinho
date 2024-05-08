using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    [SerializeField]private float forca = 8;
    Rigidbody2D fisica;

    void Awake(){
        this.fisica = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump")){
            this.Impulsionar();
        }
    }

    void Impulsionar(){
        this.fisica.AddForce(Vector2.up*forca,ForceMode2D.Impulse);
    }

}

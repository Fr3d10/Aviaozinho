using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    [SerializeField]private float forca;
    private Diretor diretor;
    Rigidbody2D fisica;
    private Vector3 posicaoInicial;

    void Awake(){
        this.posicaoInicial = this.transform.position;
        this.fisica = this.GetComponent<Rigidbody2D>();
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump")){
            this.Impulsionar();
        }
    }

    private void Impulsionar(){
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up*this.forca,ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D colisao){
        this.fisica.simulated = false;
        this.diretor.FinalizarJogo();
    }

    public void Reiniciar(){
        this.fisica.simulated = true;
        this.transform.position = posicaoInicial;
    }

}

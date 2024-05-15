using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]private float velocidade = 0.5f;
    [SerializeField] private float variacaoDaPosicaoY;
    private Vector3 posicaoDoAviao;
    private Pontuacao pontuacao;

    private bool pontuei;
    // Update is called once per frame
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY,variacaoDaPosicaoY));
    }

    private void Start(){
        this.posicaoDoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade*Time.deltaTime);

        if(!this.pontuei && this.transform.position.x < this.posicaoDoAviao.x){
            Debug.Log("pontuou");
            this.pontuei = true;
            this.pontuacao.AdicionarPontos();
        }
    }
    

    private void OnTriggerEnter2D(Collider2D outro)
    {
        Debug.Log("Colidiu");
        this.Destruir();
    }
    public void Destruir(){
        GameObject.Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pontuacao : MonoBehaviour
{
    private int pontos = -1;
    [SerializeField] private TextMeshProUGUI textoPontuacao;
    private AudioSource audioPontuacao;

    private void Awake(){
        audioPontuacao = GetComponent<AudioSource>();
    }

    public void AdicionarPontos(){
        this.pontos++;
        this.textoPontuacao.text = this.pontos.ToString();
        this.audioPontuacao.Play();
    }

    public void Reiniciar(){
        this.pontos = 0;
        this.textoPontuacao.text = this.pontos.ToString();
    }
}


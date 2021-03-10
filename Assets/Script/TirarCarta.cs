using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirarCarta : MonoBehaviour
{
    int NumNaipe; //varia de 1 a 4 para escolher o naipe
    string TipoNaipe; //imprime o nome do naipe
    int NumFigura; // varia de 1 a 13 para escolher numero ou figura da carta
    string TipoCarta; //imprime numero ou figura da carta

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Olá, carrega no espaço para tirar uma carta.");  
    }

    // Update is called once per frame
    void Update()
    {
       /* int NumNaipe; //varia de 1 a 4 para escolher o naipe
        string TipoNaipe; //imprime o nome do naipe
        int NumFigura; // varia de 1 a 13 para escolher numero ou figura da carta
        string TipoCarta; //imprime numero ou figura da carta*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //novacarta();
            //Escolha do Naipe
            NumNaipe = Random.Range(1, 5); //escolher numeros aleatorios entre 1 e 4

            if (NumNaipe == 1)
            {
                TipoNaipe = "Ouros";
            }
            else if (NumNaipe == 2)
            {
                TipoNaipe = "Copas";
            }
            else if (NumNaipe == 3)
            {
                TipoNaipe = "Paus";
            }
            else if (NumNaipe == 4)
            {
                TipoNaipe = "Espadas";
            }

            //Escolha do número ou Figura e imprime a carta para a consola
            NumFigura = Random.Range(2, 15); //escolher numeros aleatorios entre 2 e 14

            if (NumFigura <= 10)
            {
                Debug.Log("A tua carta é um " + NumFigura + " de " + TipoNaipe + ".");
            }
            else if (NumFigura == 11)
            {
                TipoCarta = "Valete";
                Debug.Log("A tua carta é um " + TipoCarta + " de " + TipoNaipe + ".");
            }
            else if (NumFigura == 12)
            {
                TipoCarta = "Dama";
                Debug.Log("A tua carta é uma " + TipoCarta + " de " + TipoNaipe + ".");
            }
            else if (NumFigura == 13)
            {
                TipoCarta = "Rei";
                Debug.Log("A tua carta é um " + TipoCarta + " de " + TipoNaipe + ".");
            }
            else if (NumFigura == 14)
            {
                TipoCarta = "Ás";
                Debug.Log("A tua carta é um " + TipoCarta + " de " + TipoNaipe + ".");
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MeuJogo.Bus.Manager { }


public class PrimeiroScript : MonoBehaviour
{
    #region VARIAVEIS
    public float position;
    #endregion

    #region METODOS
    // Start is called before the first frame update
    void Start()
    {
        position = PlayerPrefs.GetFloat("POSICAO", 1);
        //aumentar um valor na nossa posição
        //position = position + 1;
        position++;

        PlayerPrefs.SetFloat("POSICAO", 150);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Serializable]
    public class BusSetup
    {
        public GameObject bus;
        public int doors;
    }
    #endregion
}

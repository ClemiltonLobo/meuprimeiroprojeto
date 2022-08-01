using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    #region VARIAVEIS
    [Header("Variaveis")]
    public int doors = 4;

    public float life = 10f;
    public float damage = 0.5f;

    public bool canAcelerate = false;

    [Header("Cor")]
    public Color color = Color.red;

    [Header("Inputs")]
    public KeyCode KeyCode = KeyCode.Escape;

    private GameObject _meuObject;
    private GameObject _myTransform;
    #endregion



    #region METODOS UNITY
    public void ChangeColor(Color newColor)
    {
        color=newColor;
        life-= damage;
    }

    public void Test()
    {
        Debug.Log("Test");
    }

    public void Test(int i)
    {
        Debug.Log("Test int");
    }

    public void Test(float i)
    {
        Debug.Log("Test Float");
    }

    public void Acelerate()
    {
        canAcelerate = true;
    }

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode))
        {
            ChangeColor(Color.yellow);
        }
        else if (Input.GetKeyUp(KeyCode))
        {
            ChangeColor(Color.magenta);
        }
        else if (Input.GetKey(KeyCode))
        {
            ChangeColor(Color.blue);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse down");
        }

        if (Input.GetButtonDown("Fire1"))
        {

        }
    }
    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MeuJogo.Bus.Manager;
using UnityEngine.Events;
using TMPro;


public enum Animals
{
    Cat,
    Dog,
    Fish,
}

public class ScriptTest : MonoBehaviour
{
    public TMP_InputField InputField;

    public UnityEvent eventCallback;

    public EnemyBase enemybase;

    public List<GameObject> listOfObjects;

    private void _Attack()
    {
        foreach(var o in listOfObjects)
        {
            if (o != null) return;
            {
                var damageable = o.GetComponent<IDamageable<int>>();
                if (damageable != null)
                {
                    damageable.Damage(1);
                }
            }            
        }
    }

    public void DebugLog()
    {
        Debug.Log("Cliquei no botão :: "+ InputField.text);
    }

    public List<AnimalSetup> animalSetup;

    private void CheckSwitchCase(Animals a)
    {
        switch (a)
        {
            case Animals.Cat:
                OnReadCat();
                break;
            case Animals.Dog:
                OnReadDog();
                break;
            case Animals.Fish:
                OnReadFish();
                break;
            default:
                Debug.Log("Default");
                break;
        }
    }   

    private void CheckKeys()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            eventCallback.Invoke();

            //CheckSwitchCase(Animals.Cat);
            ShowTextByAnimal(Animals.Cat);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            enemybase.Attack();

            //CheckSwitchCase(Animals.Dog);
            //ShowTextByAnimal(Animals.Dog);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            enemybase.Attack();
            //CheckSwitchCase(Animals.Fish);
            //ShowTextByAnimal(Animals.Fish);
        }
    }

    private void ShowTextByAnimal(Animals a)
    {
        foreach (AnimalSetup animal in animalSetup)
        {
            if (animal.animalType == a)
                Debug.Log(animal.text);
        }
    }
    private void CheckCValues()
    {
        /*(if true E true)
        if (value01 == checkOne)
        {

        }
        else if (value01 == 1)
        {

        }
        else if (value01 == 2)
        {

        }*/

    }

    private void OnReadCat()
    {
        foreach (AnimalSetup animal in animalSetup)
        {
            if (animal.animalType == Animals.Cat)
            Debug.Log(animal.text);
        }
    }

    private void OnReadDog()
    {
        foreach (AnimalSetup animal in animalSetup)
        {
            if (animal.animalType == Animals.Dog)
                Debug.Log(animal.text);
        }
    } 

    private void OnReadFish()
    {
        foreach (AnimalSetup animal in animalSetup)
        {
            if (animal.animalType == Animals.Fish)
                Debug.Log(animal.text);
        }
    }

    private void Update()
    {
        //CheckSwitchCase();
        CheckKeys();
        //CheckCValues();
    }
}

[System.Serializable]

public class AnimalSetup
{
    public Animals animalType;
    public string text;
}
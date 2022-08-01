using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject projectile;
    public Transform shootPoint;
    public Vector3 dir;

    public PoolManager poolManager;

    public bool canMove = false;
    //public int deathNumber = 0;

    public MeshRenderer meshRenderer;

    public void ChangeColor(Color c)
    {
        meshRenderer.material.SetColor("_Color", c);
    }

    void Update()
    {
        if (!canMove) return;
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(dir*Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-dir*Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
    }
    private void SpawnObject()
    {
        var obj = poolManager.GetPolledObject();
        obj.SetActive(true);
        obj.GetComponent<Projectile>().StartProjectile();
        //obj.GetComponent<Projectile>().OnHitTarget = CountDeaths;
        //obj.transform.SetParent(null);
        obj.transform.position = shootPoint.transform.position;    
    }
    /*private void CountDeaths()
    {
        deathNumber++;
        Debug.Log("Count "+deathNumber);
    }*/

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehavior : MonoBehaviour
{
    //Class Itens
    static public int quantity;


    // Object Itens
    void OnMouseDown()
    {
        ChangeFoodPlace();
        FoodBehavior.quantity++;
    }

    void ChangeFoodPlace()
    {
        float x = Random.Range(-8, 8f);
        float y = Random.Range(-4, 4f);
        Vector3 vector = new Vector3(x, y, 0);
        this.gameObject.transform.position = vector;
    }
}

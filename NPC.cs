using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //здоровье НПС
    public int health = 5;

    //уровень НПС
    public int level = 1;

    //скорость НПС
    public float speed = 5;

    Vector3 newPosition;

    void Start()
    {
        health = health + level; //прибавляем уровень к здоровью
        print(health); //выводим в консоль
        newPosition = transform.position; //приравниваем
    }

    void Update()
    {
        newPosition.z += speed * Time.deltaTime; //приравниваем
        transform.position = newPosition; //приравниваем
    }
}

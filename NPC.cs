using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //�������� ���
    public int health = 5;

    //������� ���
    public int level = 1;

    //�������� ���
    public float speed = 5;

    Vector3 newPosition;

    void Start()
    {
        health = health + level; //���������� ������� � ��������
        print(health); //������� � �������
        newPosition = transform.position; //������������
    }

    void Update()
    {
        newPosition.z += speed * Time.deltaTime; //������������
        transform.position = newPosition; //������������
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    Transform player;
    NavMeshAgent nav; //UnityEngine.AI.NavMeshAgent agent;


    private void Awake()
    {
        // ���忡�� player �±׸� ���� ������Ʈ�� ������ �� ������Ʈ�� Ʈ������ ������ ����
        player = GameObject.FindGameObjectWithTag("Player").transform;
        // �������� ������ �ִ� NavMeshAgent ���� ����
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(nav.enabled)
        {
            nav.SetDestination(player.position);
        }
    }

    //public void SpeedUp()
    //{
    //    if(nav.enabled)
    //    {
    //        nav.speed++;
    //        nav.angularSpeed++; // ������Ʈ ȸ�� ��
    //    }
    //}
}

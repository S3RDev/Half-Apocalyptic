using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public bool isAttacking;

    public GameObject attackArea;

    void Start()
    {
        attackArea.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            isAttacking = true;

            StartCoroutine(Attacking());
        }
    }

    public IEnumerator Attacking()
    {
        attackArea.SetActive(true);

        yield return new WaitForSeconds(0.25f);

        attackArea.SetActive(false);
    }
}

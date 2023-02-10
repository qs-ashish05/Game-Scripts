using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelBuilder : MonoBehaviour
{
    public GameObject lastLineObject;
    [SerializeField] private GameObject linePrefab;
    private GameObject newLineObject;


    [SerializeField] private float spawnTime;


    void Start()
    {
        StartCoroutine(nameof(CreateNewLineObject));
    }



    IEnumerator CreateNewLineObject()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            newLineObject = Instantiate(linePrefab, lastLineObject.transform.GetChild(2).transform.GetChild(2).GetComponent<Transform>().position, transform.rotation);
            lastLineObject = newLineObject;
        }
    }
}

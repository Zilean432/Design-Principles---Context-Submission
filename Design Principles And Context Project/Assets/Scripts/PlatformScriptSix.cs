using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class PlatformScriptSix : MonoBehaviour
{
    public GameObject Prefab;
    public Transform SpawnPosition;
    public ItemCountScript itemCountScript;

    private void Update()
    {
        if (itemCountScript.itemCount == 6f)
        {
            SpawnPlatform();
        }
    }

    public void SpawnPlatform()
    {
        Instantiate(Prefab, SpawnPosition.position, SpawnPosition.rotation);
        Destroy(gameObject);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Dropbomb : NetworkBehaviour {
    [SerializeField]
    private GameObject bombPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            CmdDropBomb();
        }
    }

    [Command]
    void CmdDropBomb()
    {
        Instantiate(bombPrefab, this.gameObject.transform.position, Quaternion.identity);

        NetworkServer.Spawn(bombPrefab);
    }
}

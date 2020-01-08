using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerObject : NetworkBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    //public GameObject cam;
    private float movementSpeed = 5f;
    public GameObject projectile;
    private Transform playerPos;

    public static bool GamePause = false;
    public GameObject PauseMenu;
    public Animator animator;

    void Start()
    {
        playerPos = GetComponent<Transform>();
    }
    [Client]
    void Update()
    {

        if (!base.hasAuthority)
        {
            return;
        }
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        
        float x = Input.GetAxis("Horizontal") * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * Time.deltaTime;


        Vector3 tempVect = new Vector3(x, z, 0);
        tempVect = tempVect.normalized * movementSpeed * Time.deltaTime;

        this.transform.position += tempVect;

        Vector3 characterscale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterscale.x = -1;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterscale.x = 1;
        }
        transform.localScale = characterscale;
        /*
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime;
        */
        if (Input.GetMouseButtonDown(0))
        {
            CmdFire();
        }
        if (Input.GetKeyDown("e"))
        {
            if (GamePause == true)
            {
                CmdResume();
            }
            else
            {
                CmdStop();
            }
        }
    }
    [Command]
    void CmdFire()
    {
        Instantiate(projectile, playerPos.position, Quaternion.identity);
        GameObject item = (GameObject)Instantiate(projectile, playerPos.position, Quaternion.identity);
        NetworkServer.Spawn(item);
    }
    [Command]
    public void CmdResume()
    {
        PauseMenu.SetActive(false);
        GamePause = false;
    }
    [Command]
    public void CmdStop()
    {
        PauseMenu.SetActive(true);
        GamePause = true;
    }

}

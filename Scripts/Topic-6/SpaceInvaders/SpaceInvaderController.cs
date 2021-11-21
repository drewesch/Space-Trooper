using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceInvaderController : MonoBehaviour
{
    private int listSize;
    public int spotInList;
    public int lives;
    public List<GameObject> movementLocations = new List<GameObject>();

    public GameObject canonnball;

    // Start is called before the first frame update
    void Start()
    {
        listSize = movementLocations.Count;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            if (requestMovePosition("left"))
                spotInList--;

        if (Input.GetKeyUp(KeyCode.RightArrow))
            if (requestMovePosition("right"))
                spotInList++;

        transform.position = movementLocations[spotInList].transform.position;
    }

    bool requestMovePosition(string direction)
    {
        // Basically checking if (0 < spotInList < listSize). If so, allow movement request.
        if (spotInList - 1 >= 0 && direction == "left" || spotInList + 1 < listSize && direction == "right")
            return true;

        return false;
    }

    void fire()
    {
        //Fire cannon code goes here. Instantiate GameObject cannonball and apply force probably.
    }

    void takeDamage()
    {
        //Take damage code goes here. If lives < 1, game over.
    }
}

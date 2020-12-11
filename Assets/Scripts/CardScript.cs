using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CardScript : MonoBehaviour
{
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                GameObject go = raycastHit.collider.gameObject;
                Interaction[] interactions = go.GetComponents<Interaction>();
                foreach(Interaction interaction in interactions)
                {
                    interaction.Interact();
                }
                
            }
        }
    }
}

using UnityEngine;
using System.Collections;

public class DrawStar : MonoBehaviour
{
    public Texture2D texture;
    public bool Crosshairs_visible=false;
    public LayerMask guideboard_layer;
    public Camera main_camera;
    public GameObject teleport_notice;
    public bool whether_first = false;

    // Use this for initialization
    void OnGUI()
    {

        if (Crosshairs_visible == true)
        {
            //Debug.Log("show");
            Vector3 center_pos = new Vector3(Screen.width / 2, Screen.height / 2, 0);

            Rect rect = new Rect(center_pos.x - (texture.width / 2), Screen.height - center_pos.y - (texture.height / 2), texture.width, texture.height);

            GUI.DrawTexture(rect, texture);

            if (Input.GetMouseButtonUp(0))
            {
                teleport_notice.SetActive(false);
                Ray ray = main_camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));//射线
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 1000, guideboard_layer))
                {
                    //cvs2.GetComponent<button_delete>().debugClick();

                    hit.collider.gameObject.GetComponent<click_teleport>().OnMouseUpAsButton();

                }
            }
        }

    }
}
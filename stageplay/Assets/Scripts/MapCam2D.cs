using UnityEngine;
using System.Collections;

public class MapCam2D : MonoBehaviour {

    [SerializeField] public new Camera camera = null;
    [SerializeField] public GameObject target = null;
    [SerializeField] public Vector3 offset =  default;
    [Space]
    [SerializeField] public Vector2 boundsLowerLeft = default;
    [SerializeField] public Vector2 boundsUpperRight = default;

    public void LateUpdate() {
        var pos = target.transform.position + offset;
        pos.x = Mathf.Clamp(pos.x, boundsLowerLeft.x, boundsUpperRight.x);
        pos.y = Mathf.Clamp(pos.y, boundsLowerLeft.y, boundsUpperRight.y);
        camera.gameObject.transform.position = pos;
    }
}

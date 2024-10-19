using Kit.Physic;
using UnityEngine;

public class RaycastGizmosVisualizer_Demo : MonoBehaviour
{
    public RaycastHelper raycast_1;

	private void Awake()
	{
        raycast_1.OnHit.AddListener((t) => {
            Debug.Log(t.name);
        });

    }

}

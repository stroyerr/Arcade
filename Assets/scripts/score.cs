using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

	public Transform player;
	public Text stext;

    void Update()
    {
		stext.text ="Score: "+player.position.z.ToString("0");
    }
}

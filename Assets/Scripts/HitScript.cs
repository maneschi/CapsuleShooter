using UnityEngine;
using System.Collections;

public class HitScript : MonoBehaviour {

	public Material hitMaterial;
	public Material neutralMaterial;

	private MeshRenderer meshRenderer;

	void Awake () {
		meshRenderer = GetComponent<MeshRenderer> ();

		SetState (false);
	}

	// change object's material if it hit by a ray
	public void SetState (bool hit) {
		if (hit)
			meshRenderer.material = hitMaterial;
		else
			meshRenderer.material = neutralMaterial;
	}
}

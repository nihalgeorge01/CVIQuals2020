using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBorder : MonoBehaviour {
	
	public ePlayer player;
	public ScoreUI score;
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Ball") {
			col.gameObject.transform.position = new Vector3(0f, 1f, 0f);
			if (player == ePlayer.Right) score.scorePlayerLeft += 1;
			else if (player == ePlayer.Left) score.scorePlayerRight += 1;
		}
	}
}

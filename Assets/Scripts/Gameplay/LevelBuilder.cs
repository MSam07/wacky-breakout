using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A level builder
/// </summary>
public class LevelBuilder : MonoBehaviour 
{
	//paddle
	[SerializeField]
	GameObject prefabPaddle;

	//bonus block
	[SerializeField]
	GameObject prefabBonusBlock;

	//stadart block
	[SerializeField]
	GameObject prefabStandartBlock;
	
	//pickup block
	[SerializeField]
	GameObject prefabPickupBlock;

	//for working with randomize blocks
	float probability;
	float cummulativePorbability;
	int effect;
	GameObject newBlock;


	// Use this for initialization
	void Start () 
	{
		//Saving the block width and height
		GameObject block = Instantiate<GameObject>(prefabStandartBlock);
		BoxCollider2D collider = block.GetComponent<BoxCollider2D>();
		float blockWidth = collider.size.x;
		float blockHeight = collider.size.y;
		Destroy(block);

		//create paddle
		Instantiate(prefabPaddle);
		
		// 1/5 of the screen height down from the top of the screen
		float rowValueY = (ScreenUtils.ScreenTop - ScreenUtils.ScreenBottom)/5;

		//creating blocks on the level
		for (int i = 0; i < 3; i++)
		{
			Vector3 vector = new Vector3(0,rowValueY,0);

			for (float rowValueX = ScreenUtils.ScreenLeft + blockWidth + .2f;
				rowValueX <= ScreenUtils.ScreenRight - blockWidth; rowValueX = rowValueX + blockWidth + .2f)
			{
				
				vector.x = rowValueX;
				PickBlock(vector);
				
			}
			rowValueY = rowValueY + 0.8f;
		}

		
	}
	
	//randomly picks a block to place at a given location
	void PickBlock(Vector3 vector)
	{
		probability = Random.Range(0,100);
	  	if (probability <= ConfigurationUtils.PickupBlockProbability)
	 	{
	 		newBlock = Instantiate(prefabPickupBlock, vector, Quaternion.identity);
	 		effect = Random.Range(0,2);
	 		if (effect == 0)
	 		{
	 			newBlock.GetComponent<PickupBlock>().Effect = PickupEffect.Freezer;
	 		}
	 		else
	 		{
	 			newBlock.GetComponent<PickupBlock>().Effect = PickupEffect.Speedup;
	 		}
	 	}
	 	else if (probability <= ConfigurationUtils.PickupBlockProbability + ConfigurationUtils.BonusBlockProbability)
	 	{
	 		Instantiate(prefabBonusBlock, vector, Quaternion.identity);
	 	}
	 	else
	 	{
	 		Instantiate(prefabStandartBlock, vector, Quaternion.identity);
	 	}
	}
	
}


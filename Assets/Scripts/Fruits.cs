using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Fruits : MonoBehaviour {

    public GameObject masterObj;
    
    public GameObject scoreBoard;


    [SerializeField]
    private RectTransform rectTransform;

    public string fruiteName;
    public  int score;
    public collisionAction collisionAction;
    public int uniqueNumX;
    public int uniqueNumY;

    private bool isHit = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {

//       scoreBoard.GetComponent<Score>().scoreBoard(score);
       
        switch (collisionAction)
        {
            case collisionAction.DESTROY:
                Debug.Log("消します");

                if (isHit)
                {
                    return;
                }
                scoreBoard.GetComponent<Score>().scoreBoard(score);

                masterObj.GetComponent<BallSE>().PlaySE(SE.WOOD);
                Destroy(gameObject);
                masterObj.GetComponent<GameMaster>().boxNum--;
                break;

            case collisionAction.FREEZE:

                scoreBoard.GetComponent<Score>().scoreBoard(score);

                masterObj.GetComponent<BallSE>().PlaySE(SE.METAL);
                break;

            case collisionAction.BOM:
/*
                if (isHit)
                {
                    return;
                }
*/                
                /*
                gameObject.transform.localScale = new Vector3(
                    gameObject.transform.localScale.x * 1.7f,
                    gameObject.transform.localScale.y * 1.7f,
                    gameObject.transform.localScale.z * 1.7f);
                Invoke("bomber", 0.3f);
                */
/*
                gameObject.transform.DOScale(
                    gameObject.transform.localScale * 1.7f,
                    0.3f
                )
                .OnComplete(() => bomber());
*/
                bomberFruit();

                break;

            default:
                break;
            
        }
       
    }

    private void bomber()
    {
        masterObj.GetComponent<BallSE>().PlaySE(SE.BOM);
        

        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                Debug.Log("爆弾");
                Debug.Log("i : " + i + "\t j : " + j);

                GameObject fruit = null;

                if (((uniqueNumY + i) * 10) + (uniqueNumX + j) > 0 && ((uniqueNumY + i) * 10) + (uniqueNumX + j) < 50)
                {
                    fruit = masterObj.GetComponent<GameMaster>().uniqueNum[((uniqueNumY + i) * 10) + (uniqueNumX + j)];
                }

                if ((!(i == 0 && j == 0)) && fruit != null)
                {
                    Debug.Log(fruit.name);
                    fruit.GetComponent<Fruits>().bomberFruit();
                }

            }
        }
        collisionAction = collisionAction.DESTROY;
        bomberFruit();

    }

   private void bomberFruit()
    {
        if (collisionAction == collisionAction.BOM)
        {
            if (isHit)
            {
                return;
            }
        isHit = true;

            /*
            gameObject.transform.localScale = new Vector3(
                gameObject.transform.localScale.x * 1.7f,
                gameObject.transform.localScale.y * 1.7f,
                gameObject.transform.localScale.z * 1.7f);
            Invoke("bomber", 0.3f);
            */

            gameObject.transform.DOScale(
                gameObject.transform.localScale * 1.7f,
                0.5f
            )
            .OnComplete(() => bomber());
        }
        else
        {
            scoreBoard.GetComponent<Score>().scoreBoard(score);
            Destroy(gameObject);
            masterObj.GetComponent<GameMaster>().boxNum--;
        }
    }
}


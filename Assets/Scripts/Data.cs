using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * 
 * 難易度別データ 
 * 
 */
namespace Data
{
    public class SelectableData
    {
        //爆弾の数
        public readonly int bomNum;
        //ラケット幅(倍率)
        public readonly float racketSize;
        //ラケット速さ
        public readonly float racketSpeed;
        //クリア得点
        public readonly int passScore;
        //ボールのサイズ(倍率)
        public readonly float ballSize;
        //ブロックの大きさ(倍率)
        public readonly float blockSize;
        //制限時間
        public readonly int timeLimit;

        public SelectableData(int bom, float racSize, float racSpeed, int pass, float ball, float block, int time)
        {
            bomNum = bom;
            racketSize = racSize;
            racketSpeed = racSpeed;
            passScore = pass;
            ballSize = ball;
            blockSize = block;
            timeLimit = time;
        }
    }

    public static class SettingDataUtility
    {
        public static SelectableData GetDifficltySelectableData(difficulty difficulty)
        {
            SelectableData data;

            switch (difficulty)
            {
                case difficulty.EASY:
                    Debug.Log("Select EASY");
                    data = new SelectableData(5, 1.5f, 0.15f, 2000, 1.2f, 1.0f, 120);
                    break;
                case difficulty.NOMAL:
                    Debug.Log("Select NOMAL");
                    data = new SelectableData(3, 1.0f, 0.1f, 3000, 1.0f, 1.0f, 90);
                    break;
                case difficulty.HARD:
                    Debug.Log("Select HARD");
                    data = new SelectableData(1, 0.8f, 0.08f, 4000, 0.8f, 0.8f, 60);
                    break;
                default:
                    data = null;
                    break;
            }

            return data;
        }

    }

}

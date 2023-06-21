using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Autohand.Demo{
    public class DialHandScaler : PhysicsGadgetHingeAngleReader{
        public Hand hand;
        public GameObject line;
        public Vector3 minScale;
        public Vector3 maxScale;

        float startReach;
        Vector3 startScale;
        float[] fingersStartScale;
        Vector3 lastHandScale;

        public int whatDialType;

        new protected void Start() {
            base.Start();
          //  line.transform.position = new Vector3(0, 0.16f, -0.05f);
            if (whatDialType == 1)
            {
                startScale = hand.transform.localScale;
                startReach = hand.reachDistance;
                fingersStartScale = new float[hand.fingers.Length];
                for (int i = 0; i < hand.fingers.Length; i++)
                {
                    fingersStartScale[i] = hand.fingers[i].tipRadius;
                }
                lastHandScale = hand.transform.localScale;
            }
        }

        void Update(){ 
            var value = GetValue();

            if (whatDialType == 1)
            {
                var scaleDiff = hand.transform.localScale.magnitude / startScale.magnitude;

                if (value >= 0)
                    hand.transform.localScale = Vector3.Lerp(startScale, maxScale, value);
                else if (value < 0)
                    hand.transform.localScale = Vector3.Lerp(startScale, minScale, -value);

                //The hands reach distance, and the fingers tip radius all need to be set based on the scale
                hand.reachDistance = startReach * scaleDiff;
                for (int i = 0; i < hand.fingers.Length; i++)
                    hand.fingers[i].tipRadius = fingersStartScale[i] * scaleDiff;

                if (hand.transform.localScale != lastHandScale)
                    hand.ForceReleaseGrab();

                lastHandScale = hand.transform.localScale;
            }

            if (whatDialType == 2)
            {
                if (value >= -0.05)
                    line.transform.position = Vector3.Lerp(startScale, maxScale, value);
                else if (value < -0.05)
                    line.transform.position = Vector3.Lerp(startScale, minScale, -value);
            }


        }
    }
}

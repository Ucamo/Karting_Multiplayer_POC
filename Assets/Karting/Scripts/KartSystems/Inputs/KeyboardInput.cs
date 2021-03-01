using UnityEngine;

namespace KartGame.KartSystems {

    public class KeyboardInput : BaseInput
    {
        public string forward;
        public string backward;
        public string left;
        public string right;
        public float valY=0;
        public float valX=0;

        public override Vector2 GenerateInput() {
            if (Input.GetKey(forward))
            {
                valY=1;
            }
            if (Input.GetKey(backward))
            {
                valY=-1;
            }
            if (Input.GetKey(right))
            {
                valX=1;
            }
            if (Input.GetKey(left))
            {
                valX=-1;
            }
            Vector2 vector = new Vector2 {
                x = valX,
                y = valY
            };
            valX=0;
            valY=0;
            return vector;
        }
    }
}

using UnityEngine;

namespace KartGame.KartSystems {

    public class KeyboardInput : BaseInput
    {
        public string forward;
        public string backward;
        public string left;
        public string right;

        public override Vector2 GenerateInput() {

            int valY =0;
            int valX=0;

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
            return new Vector2 {
                x = valX,
                y = valY
            };
        }
    }
}

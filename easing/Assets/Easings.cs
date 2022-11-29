using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easings
{
    public static float Linear(float w, float p)
    {
        return w;
    }
    public class Quadratic
    {
        public static float In(float w)
        {
            return w * w;
        }
        public static float Out(float w)
        {
            return w * (2f - w);
        }
        public static float InOut(float w)
        {
            if ((w *= 2f) < 1f) return 0.5f * w * w;
            return -0.5f * ((w -= 1f) * (w - 2f) - 1f);
        }

        public static float Bezier(float w, float p)
        {
            return p * 2 * w * (1 - w) + w * w;
        }
    };
    //https://gist.github.com/Fonserbc/3d31a25e87fdaa541ddf
    public class Cubic
    {
        public static float In(float w)
        {
            return w * w * w;
        }

        public static float Out(float w)
        {
            return 1f + ((w -= 1f) * w * w);
        }

        public static float InOut(float w)
        {
            if ((w *= 2f) < 1f) return 0.5f * w * w * w;
            return 0.5f * ((w -= 2f) * w * w + 2f);
        }
    };

    public class Quartic
    {
        public static float In(float w)
        {
            return w * w * w * w;
        }

        public static float Out(float w)
        {
            return 1f - ((w -= 1f) * w * w * w);
        }

        public static float InOut(float w)
        {
            if ((w *= 2f) < 1f) return 0.5f * w * w * w * w;
            return -0.5f * ((w -= 2f) * w * w * w - 2f);
        }
    };

    public class Quintic
    {
        public static float In(float w)
        {
            return w * w * w * w * w;
        }

        public static float Out(float w)
        {
            return 1f + ((w -= 1f) * w * w * w * w);
        }

        public static float InOut(float w)
        {
            if ((w *= 2f) < 1f) return 0.5f * w * w * w * w * w;
            return 0.5f * ((w -= 2f) * w * w * w * w + 2f);
        }
    };

    public class Sinusoidal
    {
        public static float In(float w)
        {
            return 1f - Mathf.Cos(w * Mathf.PI / 2f);
        }

        public static float Out(float w)
        {
            return Mathf.Sin(w * Mathf.PI / 2f);
        }

        public static float InOut(float w)
        {
            return 0.5f * (1f - Mathf.Cos(Mathf.PI * w));
        }
    };

    public class Exponential
    {
        public static float In(float w)
        {
            return w == 0f ? 0f : Mathf.Pow(1024f, w - 1f);
        }

        public static float Out(float w)
        {
            return w == 1f ? 1f : 1f - Mathf.Pow(2f, -10f * w);
        }

        public static float InOut(float w)
        {
            if (w == 0f) return 0f;
            if (w == 1f) return 1f;
            if ((w *= 2f) < 1f) return 0.5f * Mathf.Pow(1024f, w - 1f);
            return 0.5f * (-Mathf.Pow(2f, -10f * (w - 1f)) + 2f);
        }
    };

    public class Circular
    {
        public static float In(float w)
        {
            return 1f - Mathf.Sqrt(1f - w * w);
        }

        public static float Out(float w)
        {
            return Mathf.Sqrt(1f - ((w -= 1f) * w));
        }

        public static float InOut(float w)
        {
            if ((w *= 2f) < 1f) return -0.5f * (Mathf.Sqrt(1f - w * w) - 1);
            return 0.5f * (Mathf.Sqrt(1f - (w -= 2f) * w) + 1f);
        }
    };

    public class Elastic
    {
        public static float In(float w)
        {
            if (w == 0) return 0;
            if (w == 1) return 1;
            return -Mathf.Pow(2f, 10f * (w -= 1f)) * Mathf.Sin((w - 0.1f) * (2f * Mathf.PI) / 0.4f);
        }

        public static float Out(float w)
        {
            if (w == 0) return 0;
            if (w == 1) return 1;
            return Mathf.Pow(2f, -10f * w) * Mathf.Sin((w - 0.1f) * (2f * Mathf.PI) / 0.4f) + 1f;
        }

        public static float InOut(float w)
        {
            if ((w *= 2f) < 1f) return -0.5f * Mathf.Pow(2f, 10f * (w -= 1f)) * Mathf.Sin((w - 0.1f) * (2f * Mathf.PI) / 0.4f);
            return Mathf.Pow(2f, -10f * (w -= 1f)) * Mathf.Sin((w - 0.1f) * (2f * Mathf.PI) / 0.4f) * 0.5f + 1f;
        }
    };

    public class Back
    {
        static float q = 1.70158f;
        static float q2 = 2.5949095f;

        public static float In(float w)
        {
            return w * w * ((q + 1f) * w - q);
        }

        public static float Out(float w)
        {
            return (w -= 1f) * w * ((q + 1f) * w + q) + 1f;
        }

        public static float InOut(float w)
        {
            if ((w *= 2f) < 1f) return 0.5f * (w * w * ((q2 + 1f) * w - q2));
            return 0.5f * ((w -= 2f) * w * ((q2 + 1f) * w + q2) + 2f);
        }
    };

    public class Bounce
    {
        public static float In(float w)
        {
            return 1f - Out(1f - w);
        }

        public static float Out(float w)
        {
            if (w < (1f / 2.75f))
            {
                return 7.5625f * w * w;
            }
            else if (w < (2f / 2.75f))
            {
                return 7.5625f * (w -= (1.5f / 2.75f)) * w + 0.75f;
            }
            else if (w < (2.5f / 2.75f))
            {
                return 7.5625f * (w -= (2.25f / 2.75f)) * w + 0.9375f;
            }
            else
            {
                return 7.5625f * (w -= (2.625f / 2.75f)) * w + 0.984375f;
            }
        }

        public static float InOut(float w)
        {
            if (w < 0.5f) return In(w * 2f) * 0.5f;
            return Out(w * 2f - 1f) * 0.5f + 0.5f;
        }
    }

}

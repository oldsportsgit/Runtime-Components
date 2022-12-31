using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;

namespace RuntimeConstructers
{
    /// <summary>
    /// Class for creating basic TextMeshPro UI Objects.
    /// </summary>
    public class GUIInteractablesTMP
    {
        private static Sprite UISprite()
        {
            Texture2D tex = new Texture2D(2, 2);
            string UISprite = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAACq0lEQVR4nO1XPYgaURAe3fW3iYVdtAiciEIgaGcjBAKmCoIggt1B4MAf8CcgpDwIBKKIgiBcJ4ooaIrAQSCQUkQJHATELtjYB/9/MrPxLc/DwGmUa/xgGN3Zne97896+fSPa7XbgodVqQalUSr9Xq5Xk1+s1KBQK2Af8M3y+yWSydZ+o0WhgOp0C8/TgcrkEQRDgmKCcDDRIEkJeJCK9Xg+j0UgKcsRWtLdobrQXFNqXE+0H2ne0IubtsQCREydBJGV8BTZKY2jXsVhM53Q6wWq1ymV8KLDcQq/Xc3Y6HWc6nb7CS+/R0hQjLhoweZFICRuvxnn77PP5PMFgEMxmMxwKEmyz2SRzu926Uqn0qV6vv8LQG+SaMU5pDXD4GAgEPIlEAo4JGkgqlQKVSuWpVCof8FKcxUSutM+xbKFoNCr9oRW7WCwkz96GfUG5yURRlHw4HIZyuRzFhX6D4Z+SAC75ZTKZFFClRDybzeB/wcRTPrVaLc05rishk8lcwqYKIne/x+Vy8QvxqKABUV7iQAEeWQC3wTwzGo0nIWeg3AaDgfaap+waXwH1vrvdIaDNB3me7BLwKDgLOAs4CzgLOAvgBczm87maPsenxHg8Jvd7l4Bfw+HwwmQynVQAckhcuwTctlqt0KkFtNtt+hx/lQVwn+AiHhSuvF6vsO8J+KHAKYZsNrvE/DeyAGpENrhDMYV8Ph+KRCInEVAoFMjl8Zh2Jwu41yrFa7XaBSr1+P1+ONZ0DAYDqFar0Gw2b/HI946P3W/NZliR141GI4Z2jadYncPhAIvFchBxv9+HbrcLuVyOlv5WY8I4/9Wa0Y1fcDqoNXsJf1uzQ0Ct2TfMWUQvt2ZELrdmrGNlDSM7lG56uTgcCfxhd6s1Y2uAeXorTvEWUGVZD8K3g38A8BxHBF/VD5oAAAAASUVORK5CYII=";
            tex.LoadImage(Convert.FromBase64String(UISprite));
            return Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(10, 10, 10, 10));
        }

        private static Sprite Background()
        {
            Texture2D Backgroundtex = new Texture2D(2, 2);
            string BackgroundSprite = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAACd0lEQVR4nO1Xv4saURAe3UU9m2AhFilEOIgIkeD9AYGoqFVKEVSEg8CBEDghVcpAIJBUgYBwIKJYpwgqSiD/QfBETGk6C7tgVPyRbzb7lndiQD2XNPvBMLqz++Z7897bnU8NhUIkw+Vykd1u136v12vNbzYbstlsdAjkZ+TxZrPZnftUp9NJ8/mchOcHV6sVKYpCpwSPKcCTZCLsVU7kdrtpOp1qQSnxI9gL2FPYEw4dmhP2HfYNVsa4P0SAk3NOhsrM5AroTK9hb7LZ7FkwGCS/32+UcV+g3MpoNLoYDocXtVrtCpdewz5wjHPxhNmrnJShewfW7XMsFkumUiny+Xx0LJhwIBDQLBKJnDWbzffdbjeO0HPkWoic2h6Q8C6RSCRzuRydEjyRQqHAy5tst9tvcakkYqpU2scoWzGTyZBZSKfT1Gq1XmKj3+DvQCMgjhpwmc/nFVVVTSPgcDgI+0qp1+uXpFdBzpYMh8NkNjgHCCQNAtILJuD1ek0n4PF4+F3zUPyXK+Aws/wCfP4x6Qe7CPwXWAQsAhYBi4BFQCawWC6Xpn8P9K741y4CPyeTyfl92rB9gBxarl0EWr1erxiPx00l0O/3+XPcMQhI/UC5UqlcRaNR5dAOeF9gialara4w/o1BgIWIjluQ+YRupXjqplSg0Wiw+4g28NYgsCWVSuhaz6EN7t2WyxiPx4S2nNCWt9CKv5Jj29JsgYqkOp3ONUwTJqwdWZgcAwgTGgwGBGHym7aEicj5L2nGN37BcrA0e0Z/pdkxYGn2FWOW4Q1pxskNaSYUqxCMQkTqWq5EJ4IsTu9IM7EHhOdTYcYp4MoKDSLLwT/3fBrTaDIx7wAAAABJRU5ErkJggg==";
            Backgroundtex.LoadImage(Convert.FromBase64String(BackgroundSprite));
            return Sprite.Create(Backgroundtex, new Rect(0.0f, 0.0f, Backgroundtex.width, Backgroundtex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(10, 10, 10, 10));
        }

        private static Sprite Checkmark()
        {
            Texture2D Checkmark_image = new Texture2D(2, 2);
            string checkmarksp = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAABhWlDQ1BJQ0MgcHJvZmlsZQAAKJF9kT1Iw0AcxV9TpaKVInYQUchQnSz4hThKFYtgobQVWnUwufQLmjQkKS6OgmvBwY/FqoOLs64OroIg+AHi6OSk6CIl/i8ptIj14Lgf7+497t4BQq3EVLNjHFA1y0hEI2I6syr6XtGDAPowjAmJmXosuZhC2/F1Dw9f78I8q/25P0evkjUZ4BGJ55huWMQbxDObls55nzjICpJCfE48ZtAFiR+5Lrv8xjnvsMAzg0YqMU8cJBbzLSy3MCsYKvE0cUhRNcoX0i4rnLc4q6UKa9yTv9Cf1VaSXKc5hCiWEEMcImRUUEQJFsK0aqSYSNB+pI1/0PHHySWTqwhGjgWUoUJy/OB/8LtbMzc16Sb5I0Dni21/jAC+XaBete3vY9uunwDeZ+BKa/rLNWD2k/RqUwsdAYFt4OK6qcl7wOUOMPCkS4bkSF6aQi4HvJ/RN2WA/luge83trbGP0wcgRV0t3wAHh8BonrLX27y7q7W3f880+vsBvYNyxdTubWUAAAAGYktHRAAAAAAAAPlDu38AAAAJcEhZcwAALiMAAC4jAXilP3YAAAAHdElNRQfmCw8RHwdtoCECAAAAGXRFWHRDb21tZW50AENyZWF0ZWQgd2l0aCBHSU1QV4EOFwAAAaNJREFUWMPtlzFrwkAUx8+0KBShU0ALpYtroTyH0HQMVNwytOCQDimdHPMFDDgFBJdaLn6GFl2Li4t7QhcpblIMCQhFihhJr1NKCFIj1pjhfttBwvvxcv93F4QoFAqFQqH8N51O50HX9Voi5UzTvOQ4bgEAJIrkYZxyjuPkJUl6Xi6XaYQQmkwmZ4npnOu6aVmWBwBAAIBUKhVjPp8frXvvIC7BTCbz1O/3RYQQymazn61W65plWSsxofA7VywWv3u93k0iQwEApNFoNHdSSNf12qajwXGcfKlU+vDlZFkeuK6b3omcXySqZDgUgiDYlmWdblqbifIQISQVkFWjSGqa9miaJo8QQgzDePV6/S6Xy413tpcwxqrfjXWdDIYCAAjGWI1lw0eRDIeiWq2+ep4X2zj7U9K27ZNgKMrl8ng6nbKxj45VkuFQcBy3MAzjattaqW0k2+32b/cKhcLbaDQ699eKoiiSJDX3JrhK0kcQhBdN024ZhiF7PynCn1sUxffZbHacqDueL8nz/NdwOLxI5EUUY6x2u917+r9AoVAolGTxA15E9m3FZltgAAAAAElFTkSuQmCC";
            Checkmark_image.LoadImage(Convert.FromBase64String(checkmarksp));
            return Sprite.Create(Checkmark_image, new Rect(0.0f, 0.0f, Checkmark_image.width, Checkmark_image.height), new Vector2(20f, 20f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(0, 0, 0, 0));
        }

        private static Sprite Knob()
        {
            string knobsp = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAABhWlDQ1BJQ0MgcHJvZmlsZQAAKJF9kT1Iw0AYht+mSkUqDlYQEcxQnSyIFXGUKhbBQmkrtOpgcukfNGlIUlwcBdeCgz+LVQcXZ10dXAVB8AfE0clJ0UVK/C4ptIjxjuMe3vvel7vvAKFRYarZNQmommWk4jExm1sVA68IYBSDNKMSM/VEejEDz/F1Dx/f7yI8y7vuz9Gn5E0G+ETiOaYbFvEG8cympXPeJw6xkqQQnxNPGHRB4keuyy6/cS46LPDMkJFJzROHiMViB8sdzEqGSjxNHFZUjfKFrMsK5y3OaqXGWvfkLwzmtZU012mNII4lJJCECBk1lFGBhQjtGikmUnQe8/APO/4kuWRylcHIsYAqVEiOH/wPfvfWLESn3KRgDOh+se2PMSCwCzTrtv19bNvNE8D/DFxpbX+1Acx+kl5va+EjoH8buLhua/IecLkDDD3pkiE5kp+WUCgA72f0TTlg4BboXXP71jrH6QOQoV4t3wAHh8B4kbLXPd7d09m3f2ta/fsB1qVyzyTSm1wAAAAGYktHRAD/AP8A/6C9p5MAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAAHdElNRQfmBx8VGAbHBpURAAAE1UlEQVRYw+2Y32sTWRTHv/cmWgpCQQwWJUFoSqUvTWdsTHVkUXaXXYRlCzvgwwb6uoIvCV3YP0CkyG4tCEvxrbDah2UbAqI0LlaJTdgww1gwGOKDBGGcl7JVu+ncydyzD2tFMa2tbZN98Pt2mXu4nznn/jjnAJ+0PbGPNUwkEvs9z/uKiD4johhjLEBEMQBgjFlE5DPGLMbYvT179twuFotLLQFUFGWEiH7o6ur64sSJE1BVFX19feCco6+vDwBQqVQgpUSlUoFhGFhYWMDy8nKOMfaraZqzu+JqVVXjiqIspNNpKhaLtFUVi0VKp9OkKMqCqqrxHQPTdT0wODh4JZlMUjabpe0qm81SMpmkwcHBK7quB7brtS5FUW6Nj4+TEOKdhaSU5Hkeua5L9Xqd6vU6rays0MrKypux67rkeR5JKd+xFULQ+Pg4KYpyq7+/f99GDIGN4IhoYXR0dDiVSiEQ+G+q7/vwPA9CCPi+DykliAhE9MZ2bSylhO/7aDQakFKCMQbOOQKBAE6ePInV1dXoo0ePvj106NBvtm27mwbUdT2wtLT0x+jo6PCFCxcAAFJKuK6LRqPxDsxmRUTwfR++74NzDsYYEokEhBAhy7JimqbNlMtl2hRgR0fHxLlz575PpVIAACEEhBAfBdYMdO0nA4EAjh8/juXl5ej9+/e7nj9/fvuDgKqqarFYbOrixYvgnL8J5U5LSgkpJYLBIOLxOAzDSHDO/7Rtu/b2PN7E8JKu6wgGg3Bdd1fg1uT7PlZXVxEMBqHrOqSUlzb0oKIoI2fOnBk7f/48hBCQUu76U7Z2oI4ePYpqtRpxXXfRtu3H63lwTNf1XQvrRp4UQkDXdQAYaxpiVVUj3d3dw0NDQ2g0Gi1PChqNBoaGhtDd3T2sqmrkPUAiOqtpGoQQbctchBDQNA1EdLYZoDYwMNCSfbfRyR4YGAARae8BMsb6w+Fw2/O/cDgMxlh/Mw9GQqFQ2wFDoRCIKNLMg/s6OzvbDtjZ2QnG2L51L+r/m94O8at6vd52oHq9DiJ61SzENcdx2g7oOA4YY7VmIa7UarW2Az59+hREVG4GeM+yrLYDLi4ugjGWbxbim4VCoe2AhUIBjLGb7wEahlFzHKdQKpXaBlcqleA4TsEwjNp618zlTCbTNsDXa19eNx+0bfux67qfh8PhSE9PT0vhcrkcpqenC6Zpjm2YUXPOf8pkMi1NGqSUyGQyYIz9+MGaxLbtGuf8wMuXL+OJRKIlgJOTk5ifn79qmubUpqo6TdPm8vn8sOd5PceOHdtVuKmpKczMzOSi0Why02VnuVymw4cPZx8+fDji+/4BVVV3Be7atWuYnp6ucM6/vHPnTn1LnQXbtt0jR45cNwxDefHiRU88HgdjbMf23OTkJG7cuJHr6Oj4ulQq/b3l1gcAPHv2rH7q1KnrDx482G+aZnzv3r3Y7unO5XKYmJjA/Pz81Wg0mpybm/tnR/qDqqpqUsqfT58+HR8ZGYGiKFsCM00Ts7OzuHv37l+c87RhGPldaWDGYrHvOOepgwcPDmuahmg0it7eXnDO0dvbCwCoVquQUqJareLJkyfI5/NwHKcgpfzFsqzfW9ICVlU1IqX8hjEWAxB7vV1irz9bAHwAFhFZnPPs28/XJ7VS/wKxLQ+pyCdnyAAAAABJRU5ErkJggg==";
            Texture2D Knob_Sprite = new Texture2D(2, 2);
            Knob_Sprite.LoadImage(Convert.FromBase64String(knobsp));
            return Sprite.Create(Knob_Sprite, new Rect(0.0f, 0.0f, Knob_Sprite.width, Knob_Sprite.height), new Vector2(20f, 20f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(0, 0, 0, 0));
        }

        private static Sprite UIMask()
        {
            Texture2D UImasktex = new Texture2D(2, 2);
            string UImaskSprite = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAAArUlEQVR4nO2W2QqAIBBFpQ36/2+NHiLNgYkKs0YdUWouXHpyPNJ2OmOMKplOFY4AvAH02DZy/mq7YIMAGtsRrylpsYPtbKupABybn7MfaKIA9MybnyFg9uV2+AByhQQQ+8BR4syu/jUUAAEQAAEQgM8BOAp+BwAaleuPSDKiJSOA44Y+AHA4bivSVAAICCSnF2qc6cQHAAtAIFO03Kjj1MFavudxMUd+9x2oD2AD0CEefVmsbD0AAAAASUVORK5CYII=";
            UImasktex.LoadImage(Convert.FromBase64String(UImaskSprite));
            return Sprite.Create(UImasktex, new Rect(0.0f, 0.0f, UImasktex.width, UImasktex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(10, 10, 10, 10));
        }

        private static Sprite DropdownArrow()
        {
            Texture2D DropdownArrowtex = new Texture2D(2, 2);
            string DropdownArrow = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAABhGlDQ1BJQ0MgcHJvZmlsZQAAKJF9kT1Iw0AcxV9TpSoVBTuIOGSoThakijhKFYtgobQVWnUwufQLmjQkKS6OgmvBwY/FqoOLs64OroIg+AHi6OSk6CIl/i8ptIjx4Lgf7+497t4BQqPCVLNrElA1y0jFY2I2tyoGXhHAIHrhR1Ripp5IL2bgOb7u4ePrXYRneZ/7c/QreZMBPpF4jumGRbxBPLNp6Zz3iUOsJCnE58QTBl2Q+JHrsstvnIsOCzwzZGRS88QhYrHYwXIHs5KhEk8ThxVVo3wh67LCeYuzWqmx1j35C4N5bSXNdZqjiGMJCSQhQkYNZVRgIUKrRoqJFO3HPPwjjj9JLplcZTByLKAKFZLjB/+D392ahamomxSMAd0vtv0xBgR2gWbdtr+Pbbt5AvifgSut7a82gNlP0uttLXwEDGwDF9dtTd4DLneA4SddMiRH8tMUCgXg/Yy+KQcM3QJ9a25vrX2cPgAZ6mr5Bjg4BMaLlL3u8e6ezt7+PdPq7wdjgXKhFu6GPwAAAAZiS0dEAAAAAAAA+UO7fwAAAAlwSFlzAAAOwwAADsMBx2+oZAAAAAd0SU1FB+YHEAkEJyBHklAAAACcSURBVFjD7dNLDsMgDEXRpEt6iwJ2EXcXNpt1J6ViEKmQT0HVO8MowJVDloWIiIiIZmFmm5lto9Z/3RyAA/Ajhxxd/2h90d3X6jDpOeQ9Odnb61KqKmUKrZOoJwfAVVVuvYc9kT+P64kcFtcSeWXcejYy5/wJizFK+YnKsxDCM6U0JnAvsnY27rbPPeTO9UROF1dHThtHRERE/+kFyfmdhdXwERIAAAAASUVORK5CYII=";
            DropdownArrowtex.LoadImage(Convert.FromBase64String(DropdownArrow));
            return Sprite.Create(DropdownArrowtex, new Rect(0.0f, 0.0f, DropdownArrowtex.width, DropdownArrowtex.height), new Vector2(20f, 20f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(0, 0, 0, 0));
        }

        private static Sprite InputFieldBackground()
        {
            Texture2D tex = new Texture2D(2, 2);
            string InputFieldBackground = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAAC30lEQVR4nO1XTWhaQRAe856aqCBeI0EqAUEoFCSHnIqFBj316sE/CBYCQsGEnnoMFEpqQAqFQE4JJBAvPRSTFBp6E70UAgWP1oveiyYaY+fbuLKKLWh8tId8MKw4u/N9OzvvvR3d7/eTivn5eZqbmxO/b29vxdjr9chkMtEkUNeo8a6urobm6Varla6vr0mOWNjtdknTNJolEFMCm4QQjDqIbDYbNZtN4VSIfWwv2Z6yPYFrUk6272zf2PY4bkU6QA5OQIcyNQN9pRm27UgksuDz+cjj8UycEY6jVavVQKVSCRwfH2/wX2/YsvCBCxvGqIMU6I8WPrdPwWAwFA6Hye12C2Kc4TQ1gPrCBgKBwEKhUHh/cXHxnF0vmKstOUUNKHi3trYWSiaTQp3FYiFd1wciJgEKDtm8ubkRZ51KpchsNofOz8/fsntTztOVwI95UTqRSJDD4RCLIOI+GZAisFMmp1gsRmdnZ6/Yt89TfggB8lFjrPPONafTKQoEAlTyaQRIESBHJhErHo9rBwcH6zILurImtLq6Sna7/e7x6C+YFlI0YqibAAcLCA0EKDt7hGoXlXlP8lEgFmIi9uLiIjLjlj41AxakftbkoyJcLhcy4RwnwDByVcTo+2RIwKSFNq2IvwowUsS4+Dr9YzwIeBDwIOC/EtDudDoWXEKMRKvVwvBrnICfjUZj2ev1GiqgXq8LrnECTovFYtpoAaVSCZ/jLwMByrt5b2dnZ4NvwppRX8R2u027u7tdjr8/EIBrUx+XLOZjNptNb21tGSIgl8th+MDXtMuBgJFWafPo6GiZizEUjUZpaWlpJsS1Wo0ODw8pn8+f8gX1teobbc3anJHwyclJhm07k8ksrKysiLv9NOCmhMrlMnFWUfpDjYnk/FNrhomf+bzQmj2ju9ZsGqA1+8ox96BH/gnyQWsmO1bZMMomst/LbdKMoDanQ62ZrAE5yqv0rIHMyh5EbQd/A+JMPJandV0rAAAAAElFTkSuQmCC";
            tex.LoadImage(Convert.FromBase64String(InputFieldBackground));
            return Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(10, 10, 10, 10));
        }

        private static void AddLayerForEach(GameObject Base)
        {
            Transform[] transforms = Base.GetComponentsInChildren<Transform>(true);
            for (int i = 0; i < transforms.Length; i++)
            {
                transforms[i].gameObject.layer = 5;
            }
        }

        /// <summary>
        /// Creates a TextMeshPro Button.
        /// </summary>
        public static GameObject ButtonTMP(string Name, GameObject Canvas, Vector2 Position, string text)
        {
            GameObject button = new GameObject(Name, typeof(Image), typeof(Button));
            GameObject GUI_text = new GameObject("Text (TMP)", typeof(TextMeshProUGUI));
            button.transform.SetParent(Canvas.transform);
            button.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
            button.GetComponent<Image>().sprite = UISprite();
            button.GetComponent<Image>().type = Image.Type.Sliced;
            GUI_text.transform.SetParent(button.transform);
            TextMeshProUGUI textMeshProUGUI = GUI_text.GetComponent<TextMeshProUGUI>();
            textMeshProUGUI.text = text;
            textMeshProUGUI.alignment = TextAlignmentOptions.Center;
            textMeshProUGUI.color = new Vector4(0.20f, 0.20f, 0.20f, 1);
            textMeshProUGUI.fontSize = 24;
            RectTransform rect = GUI_text.GetComponent<RectTransform>();
            rect.anchorMin = new Vector2(0, 0);
            rect.anchorMax = new Vector2(1, 1);
            rect.offsetMax = new Vector2(0, 0);
            rect.offsetMin = new Vector2(0, 0);
            button.GetComponent<RectTransform>().anchoredPosition = Position;
            AddLayerForEach(button);
            return button;
        }

        /// <summary>
        /// Creates a TextMeshProUGUI Object.
        /// </summary>
        public static GameObject textTMP(string name, GameObject Canvas, Vector2 position, string text)
        {
            GameObject TMPtext = new GameObject(name, typeof(TextMeshProUGUI));
            TMPtext.transform.SetParent(Canvas.transform);
            TMPtext.GetComponent<TextMeshProUGUI>().text = text;
            TMPtext.GetComponent<RectTransform>().anchoredPosition = position;
            TMPtext.layer = 5;
            return TMPtext;
        }

        /// <summary>
        /// Creates a TextMeshPro InputField.
        /// </summary>
        public static GameObject InputFieldTMP(string name, GameObject Canvas, Vector2 position)
        {
            GameObject InputField = new GameObject(name, typeof(Image), typeof(TMP_InputField));
            GameObject Text_area = new GameObject("Text Area", typeof(RectMask2D));
            GameObject Placeholder = new GameObject("Placeholder", typeof(TextMeshProUGUI), typeof(LayoutElement));
            GameObject text = new GameObject("Text", typeof(TextMeshProUGUI));
            InputField.transform.SetParent(Canvas.transform);
            InputField.GetComponent<Image>().type = Image.Type.Sliced;
            InputField.GetComponent<Image>().sprite = InputFieldBackground();
            InputField.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
            Text_area.transform.SetParent(InputField.transform);
            RectTransform Text_areaRect = Text_area.GetComponent<RectTransform>();
            Text_areaRect.anchorMax = new Vector2(1, 1);
            Text_areaRect.anchorMin = new Vector2(0, 0);
            Text_areaRect.anchoredPosition = new Vector2(0, -0.50f);
            Text_areaRect.sizeDelta = new Vector2(-20, -13);
            Placeholder.transform.SetParent(Text_area.transform);
            Placeholder.GetComponent<LayoutElement>().ignoreLayout = true;
            RectTransform PlaceholderRect = Placeholder.GetComponent<RectTransform>();
            PlaceholderRect.anchorMax = new Vector2(1, 1);
            PlaceholderRect.anchorMin = new Vector2(0, 0);
            PlaceholderRect.offsetMax = new Vector2(0, 0);
            PlaceholderRect.offsetMin = new Vector2(0, 0);
            PlaceholderRect.anchoredPosition = Vector2.zero;
            PlaceholderRect.sizeDelta = Vector2.zero;
            TextMeshProUGUI PlaceholderText = Placeholder.GetComponent<TextMeshProUGUI>();
            PlaceholderText.text = "Enter text...";
            PlaceholderText.enableWordWrapping = false;
            PlaceholderText.fontSize = 14;
            PlaceholderText.fontStyle = FontStyles.Italic;
            PlaceholderText.color = new Vector4(0.20f, 0.20f, 0.20f, 0.5f);
            text.transform.SetParent(Text_area.transform);
            RectTransform textRect = text.GetComponent<RectTransform>();
            textRect.anchorMax = new Vector2(1, 1);
            textRect.anchorMin = new Vector2(0, 0);
            textRect.offsetMax = new Vector2(0, 0);
            textRect.offsetMin = new Vector2(0, 0);
            textRect.sizeDelta = Vector2.zero;
            textRect.anchoredPosition = Vector2.zero;
            text.GetComponent<TextMeshProUGUI>().fontSize = 14;
            text.GetComponent<TextMeshProUGUI>().color = new Vector4(0.20f, 0.20f, 0.20f, 1);
            TMP_InputField IFTMP = InputField.GetComponent<TMP_InputField>();
            IFTMP.textViewport = Text_area.GetComponent<RectTransform>();
            IFTMP.textComponent = text.GetComponent<TextMeshProUGUI>();
            IFTMP.fontAsset = text.GetComponent<TextMeshProUGUI>().font;
            IFTMP.placeholder = Placeholder.GetComponent<TextMeshProUGUI>();
            InputField.GetComponent<RectTransform>().anchoredPosition = position;
            AddLayerForEach(InputField);
            return InputField;
        }

        /// <summary>
        /// Creates a TextMeshPro DropDown.
        /// </summary>
        public static GameObject DropDownTMP(string name, GameObject Canvas, Vector2 position)
        {
            GameObject Dropdown = new GameObject(name, typeof(UnityEngine.UI.Image), typeof(TMP_Dropdown));
            GameObject Label = new GameObject("Label", typeof(TextMeshProUGUI));
            GameObject Arrow = new GameObject("Arrow", typeof(Image));
            GameObject Template = new GameObject("Template", typeof(Image), typeof(ScrollRect));
            GameObject Viewport = new GameObject("Viewport", typeof(Mask), typeof(Image));
            GameObject Content = new GameObject("Content", typeof(RectTransform));
            GameObject Item = new GameObject("Item", typeof(Toggle));
            GameObject ItemBackground = new GameObject("Item Background", typeof(Image));
            GameObject ItemCheckmark = new GameObject("Item Checkmark", typeof(Image));
            GameObject ItemLabel = new GameObject("Item Label", typeof(TextMeshProUGUI));
            GameObject scrollbar = new GameObject("Scrollbar", typeof(Image), typeof(Scrollbar));
            GameObject slidingArea = new GameObject("Sliding Area", typeof(RectTransform));
            GameObject Handle = new GameObject("Handle", typeof(Image));
            Dropdown.transform.SetParent(Canvas.transform);
            Dropdown.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
            TMP_Dropdown.OptionData optionDataA = new TMP_Dropdown.OptionData();
            optionDataA.text = "Option A";
            TMP_Dropdown.OptionData optionDataB = new TMP_Dropdown.OptionData();
            optionDataB.text = "Option B";
            TMP_Dropdown.OptionData optionDataC = new TMP_Dropdown.OptionData();
            optionDataC.text = "Option C";
            Dropdown.GetComponent<Image>().sprite = UISprite();
            Dropdown.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
            Dropdown.GetComponent<Image>().type = Image.Type.Sliced;
            Dropdown.GetComponent<TMP_Dropdown>().options.Add(optionDataA);
            Dropdown.GetComponent<TMP_Dropdown>().options.Add(optionDataB);
            Dropdown.GetComponent<TMP_Dropdown>().options.Add(optionDataC);
            Label.transform.SetParent(Dropdown.transform);
            TextMeshProUGUI LabelText = Label.GetComponent<TextMeshProUGUI>();
            LabelText.fontSize = 14;
            LabelText.color = new Vector4(0.20f, 0.20f, 0.20f, 1);
            LabelText.alignment = TextAlignmentOptions.Left;
            RectTransform LabelRT = Label.GetComponent<RectTransform>();
            LabelRT.anchorMax = new Vector2(1, 1);
            LabelRT.anchorMin = new Vector2(0, 0);
            LabelRT.sizeDelta = new Vector2(-35, -13);
            LabelRT.anchoredPosition = new Vector2(-7.50f, -0.50f);
            Arrow.transform.SetParent(Dropdown.transform);
            RectTransform ArrowRT = Arrow.GetComponent<RectTransform>();
            ArrowRT.anchorMax = new Vector2(1, 0.5f);
            ArrowRT.anchorMin = new Vector2(1, 0.5f);
            ArrowRT.sizeDelta = new Vector2(20, 20);
            ArrowRT.anchoredPosition = new Vector2(-15, 0);
            Arrow.GetComponent<Image>().sprite = DropdownArrow();
            Template.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 150);
            Template.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 2);
            Template.transform.SetParent(Dropdown.transform);
            Template.SetActive(false);
            Template.GetComponent<Image>().sprite = Dropdown.GetComponent<Image>().sprite;
            Template.GetComponent<Image>().type = Image.Type.Sliced;
            RectTransform TPRT = Template.GetComponent<RectTransform>();
            TPRT.anchorMax = new Vector2(1, 0);
            TPRT.anchorMin = new Vector2(0, 0);
            TPRT.pivot = new Vector2(0.5f, 1);
            TPRT.sizeDelta = new Vector2(0, 150);
            TPRT.anchoredPosition = new Vector2(0, 2);
            ScrollRect TPTMP = Template.GetComponent<ScrollRect>();
            TPTMP.movementType = ScrollRect.MovementType.Clamped;
            TPTMP.horizontal = false;
            TPTMP.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
            TPTMP.verticalScrollbarSpacing = -3;
            Viewport.GetComponent<RectTransform>().sizeDelta = new Vector2(-18, -0);
            Viewport.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            Viewport.transform.SetParent(Template.transform);
            Viewport.GetComponent<Image>().sprite = UIMask();
            Viewport.GetComponent<Image>().type = Image.Type.Sliced;
            Viewport.GetComponent<Mask>().showMaskGraphic = false;
            RectTransform VPTMP = Viewport.GetComponent<RectTransform>();
            VPTMP.pivot = new Vector2(0, 1);
            VPTMP.anchorMax = new Vector2(1, 1);
            VPTMP.anchorMin = new Vector2(0, 0);
            VPTMP.sizeDelta = new Vector2(-18, 0);
            VPTMP.anchoredPosition = Vector2.zero;
            scrollbar.transform.SetParent(Template.transform);
            scrollbar.GetComponent<Image>().sprite = Background();
            RectTransform sbrt = scrollbar.GetComponent<RectTransform>();
            sbrt.pivot = new Vector2(1, 1);
            sbrt.anchorMax = new Vector2(1, 1);
            sbrt.anchorMin = new Vector2(1, 0);
            sbrt.sizeDelta = new Vector2(20, 0);
            sbrt.anchoredPosition = Vector2.zero;
            slidingArea.transform.SetParent(scrollbar.transform);
            RectTransform slareart = slidingArea.GetComponent<RectTransform>();
            slareart.anchorMax = new Vector2(1, 1);
            slareart.anchorMin = new Vector2(0, 0);
            slareart.sizeDelta = new Vector2(-20, -20);
            slareart.anchoredPosition = Vector2.zero;
            Handle.transform.SetParent(slidingArea.transform);
            Handle.GetComponent<Image>().sprite = scrollbar.GetComponent<Image>().sprite;
            Handle.GetComponent<Image>().type = Image.Type.Sliced;
            Handle.GetComponent<RectTransform>().sizeDelta = new Vector2(20, 20);
            Handle.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            Scrollbar scrollbarbar = scrollbar.GetComponent<Scrollbar>();
            scrollbarbar.targetGraphic = Handle.GetComponent<Image>();
            scrollbarbar.handleRect = Handle.GetComponent<RectTransform>();
            scrollbarbar.direction = Scrollbar.Direction.BottomToTop;
            Content.transform.SetParent(Viewport.transform);
            RectTransform ContentRect = Content.GetComponent<RectTransform>();
            ContentRect.pivot = new Vector2(0.5f, 1);
            ContentRect.anchorMax = new Vector2(1, 1);
            ContentRect.anchorMin = new Vector2(0, 1);
            ContentRect.sizeDelta = new Vector2(0, 28);
            ContentRect.anchoredPosition = Vector2.zero;
            Item.GetComponent<Toggle>().isOn = true;
            Item.transform.SetParent(Content.transform);
            RectTransform ItemRect = Item.GetComponent<RectTransform>();
            ItemRect.anchorMax = new Vector2(1, 0.5f);
            ItemRect.anchorMin = new Vector2(0, 0.5f);
            ItemRect.sizeDelta = new Vector2(0, 20);
            ItemRect.anchoredPosition = Vector2.zero;
            Item.GetComponent<Toggle>().targetGraphic = ItemBackground.GetComponent<Image>();
            ItemBackground.transform.SetParent(Item.transform);
            RectTransform ItemBackgroundRect = ItemBackground.GetComponent<RectTransform>();
            ItemBackgroundRect.anchorMax = new Vector2(1, 1);
            ItemBackgroundRect.anchorMin = new Vector2(0, 0);
            ItemBackgroundRect.sizeDelta = Vector2.zero;
            ItemBackgroundRect.anchoredPosition = Vector2.zero;
            Item.GetComponent<Toggle>().graphic = ItemCheckmark.GetComponent<Image>();
            ItemCheckmark.transform.SetParent(Item.transform);
            ItemCheckmark.GetComponent<Image>().sprite = Checkmark();
            RectTransform ICRect = ItemCheckmark.GetComponent<RectTransform>();
            ICRect.anchorMax = new Vector2(0, 0.5f);
            ICRect.anchorMin = new Vector2(0, 0.5f);
            ICRect.sizeDelta = new Vector2(20, 20);
            ICRect.anchoredPosition = new Vector2(10, 0);
            ItemLabel.transform.SetParent(Item.transform);
            TextMeshProUGUI ItemLabelTMPU = ItemLabel.GetComponent<TextMeshProUGUI>();
            ItemLabelTMPU.alignment = TextAlignmentOptions.Left;
            ItemLabelTMPU.text = "Option A";
            ItemLabelTMPU.fontSize = 14;
            ItemLabelTMPU.color = new Vector4(0.20f, 0.20f, 0.20f, 1);
            RectTransform ItemLabelRect = ItemLabel.GetComponent<RectTransform>();
            ItemLabelRect.anchorMax = new Vector2(1, 1);
            ItemLabelRect.anchorMin = new Vector2(0, 0);
            ItemLabelRect.sizeDelta = new Vector2(-30, -3);
            ItemLabelRect.anchoredPosition = new Vector2(5, -0.50f);
            TMP_Dropdown DDTMP = Dropdown.GetComponent<TMP_Dropdown>();
            DDTMP.targetGraphic = Dropdown.GetComponent<Image>();
            DDTMP.template = Template.GetComponent<RectTransform>();
            DDTMP.captionText = Label.GetComponent<TextMeshProUGUI>();
            DDTMP.itemText = ItemLabel.GetComponent<TextMeshProUGUI>();
            ScrollRect TemplateScrollRect = Template.GetComponent<ScrollRect>();
            TemplateScrollRect.content = Content.GetComponent<RectTransform>();
            TemplateScrollRect.viewport = Viewport.GetComponent<RectTransform>();
            TemplateScrollRect.verticalScrollbar = scrollbar.GetComponent<Scrollbar>();
            Dropdown.GetComponent<RectTransform>().anchoredPosition = position;
            AddLayerForEach(Dropdown);
            return Dropdown;
        }
    }
}

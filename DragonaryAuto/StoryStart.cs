using KAutoHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonaryAuto
{
    public class StoryStart
    {
        Util util = new Util();
        List<string> images = new List<string>(new Constants().storyImagesRev);

        public void handleStoryStart(bool _stoploop)
        {
            for (int i = images.Count - 1; i >= 0 && !_stoploop; i--)
            {
                bool result = util.handleMouseClickPoint(images[i]);
                if (result && (images[i] == "exit.png" || images[i] == "network-error.png"))
                {
                    images = new List<string>(new Constants().storyImagesRev);
                    //stop = true;
                    break;
                }
                else if (result && images[i] != "continue.png")
                {
                    images.RemoveAt(i);
                    break;
                }
            }
        }
    }
}

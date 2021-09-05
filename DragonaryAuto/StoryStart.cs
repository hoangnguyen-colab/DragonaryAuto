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
        Constants constants = new Constants();
        List<string> images;

        public StoryStart()
        {
            images = new List<string>(constants.storyMenuImgs);
        }

        public StoryStart(string type)
        {
            switch (type)
            {
                case "story":
                    {
                        images = new List<string>(constants.storyMenuImgs);
                        break;
                    }
                case "ingame":
                    {
                        images = new List<string>(constants.storyIngameImgs);
                        break;
                    }
                default:
                    break;
            }
        }

        public void handleStoryStart(bool _stoploop)
        {
            for (int i = images.Count - 1; i >= 0 && !_stoploop; i--)
            {
                bool result = util.handleMouseClickPoint(images[i]);
                if (result && images[i] == "play.png")
                {
                    images = new List<string>(constants.storyIngameImgs);
                }
                else if (result && (images[i] == "exit.png" || images[i] == "network-error.png"))
                {
                    images = new List<string>(constants.storyMenuImgs);
                    break;
                }
                else if (result && images[i] != "continue.png")
                {
                    images.RemoveAt(i);
                    break;
                }
            }
        }

        public void handleIngameContinue(bool _stoploop)
        {
            for (int i = images.Count - 1; i >= 0 && !_stoploop; i--)
            {
                bool result = util.handleMouseClickPoint(images[i]);
                if (result && (images[i] == "exit.png" || images[i] == "network-error.png"))
                {
                    return;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonaryAuto
{
    public class Constants
    {
        public List<string> storyImages = new List<string>{
            "mission-new.png",
            "story-big.png",
            "play-ing.png",
            "manual.png",
            "1x-speed-2.png",
            "claim.png",
            "continue.png",
            "mission-8.png",
            "play.png",
            "exit.png",
            "network-error.png"
        };

        public List<string> storyImagesRev = new List<string>{
            "network-error.png",
            "exit.png",
            "play.png",
            "mission-8.png",
            "continue.png",
            "claim.png",
            "1x-speed-2.png",
            "manual.png",
            "play-ing.png",
            "story-big.png",
            "mission-new.png",
        };

        public List<string> storyImagesReverse()
        {
            storyImages.Reverse();
            return storyImages;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_2nd_lab_part2
{
    interface IMusicPlayerInterface
    {
        void Switch(bool on);
        void Play(bool on);
        void SetVolume(int loudness);
        void PlayNext();
        void PlayPrevious();

    }
}

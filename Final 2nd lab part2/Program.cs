using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_2nd_lab_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile m1 = new Phone("char botal botka", "arijit  singh", 2014, 230);
            MusicFile m2 = new Phone("Mitthe", "sahrukh khan", 2018, 230);
            MusicFile m3 = new Phone("Avijog ", "Tanveer Evan ", 2014, 230);
            Phone p1 = new Phone("Iphon 7", 1);
            p1.AddMusic(m1, m2, m3);
            p1.PhonInfo();
            Console.WriteLine();
            Console.WriteLine("Radio player : ");
            p1.Switch(true);
            p1.Retune(88.0);
            p1.SetVolume(10);
            p1.ChangeChannel();
            Console.WriteLine();
            Console.WriteLine("Music player : ");
            p1.Switch(true);
            p1.Play(true);
            p1.PlayPrevious();
            p1.PlayNext();
            



        }
    }
}

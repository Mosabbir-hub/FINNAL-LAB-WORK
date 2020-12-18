using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_2nd_lab_part2
{
    abstract class MusicFile
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int YearOfRelease { get; set; }
        public int DurationInSecond { get; set; }
        public MusicFile()
        {
        }
        public MusicFile(string title,string artist,int yearOfRelease, int durationInSecond)
        {
            Title = title;
            Artist = artist;
            YearOfRelease = yearOfRelease;
            DurationInSecond = durationInSecond;
        }
        public void ChangeTitle(string title)
        {
            Title = title;
            Console.WriteLine("Title Changed.");
        }
        public abstract void MusicInfo();
    }
}

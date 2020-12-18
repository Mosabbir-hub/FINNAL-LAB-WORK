using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_2nd_lab_part2
{
    class Phone :MusicFile,IMusicPlayerInterface,IRadioPlayerInterface
    {
        public string ModelName { get; set; }
        MusicFile[] musicFile;
        private int musicFileCount;
        public int CurrentPlay { get; set; }

        public void ChangeChannel()
        {
            Console.WriteLine("Channel Changed");
        }

        public void Play(bool on)
        {
            if(on)
            {
                Console.WriteLine("Playing");
                musicFile[CurrentPlay].MusicInfo();
                Console.WriteLine();
            }
           

            else
                Console.WriteLine("Pause");
        }

        public void PlayNext()
        {
            Console.WriteLine("Next song :");
            musicFile[CurrentPlay+1].MusicInfo();
            Console.WriteLine();
        }

        public void PlayPrevious()
        {
            Console.WriteLine("Previous Song :");
            musicFile[CurrentPlay-1].MusicInfo();
            Console.WriteLine();
        }

        public void Retune(double frequency)
        {
            Console.WriteLine("frequency of the radio is : "+frequency);
        }

        public void SetVolume(int loudness)
        {
            Console.WriteLine("Volume : "+loudness);
        }

        public void Switch(bool on)
        {
            if(on)
            Console.WriteLine("On");
            else
                Console.WriteLine("Off");
        }

        override public void MusicInfo()
        {
            Console.WriteLine("Song Title : " + Title);
            Console.WriteLine("Artist name :"+Artist);
            Console.WriteLine("Year of Release :"+YearOfRelease);
            Console.WriteLine("Duration in Second : "+DurationInSecond);
        }
       public Phone()
        {
            Console.WriteLine("Empty phon constructor.");
            musicFile = new MusicFile[500];
            musicFileCount = 0;
        }
        public Phone(string modelName,int currentPlay)
        {
            ModelName = modelName;
            musicFile = new MusicFile[500];
            musicFileCount = 0;
            CurrentPlay = currentPlay;
        }
        public Phone(string title, string artist, int yearOfRelease, int durationInSecond):base(title,artist,yearOfRelease,durationInSecond)
        {

        }
        public void AddMusic(params MusicFile[] files)
        {
            foreach (var musicFile in files)
            {
                if (musicFileCount < 500)
                    this.musicFile[musicFileCount++] = musicFile;
                else
                    Console.WriteLine("Cannot Add music.");
                
            }
        }

        public void PhonInfo()
        {
            Console.WriteLine("Phon Model : " + ModelName);
            Console.WriteLine("Featuers :");
            Console.WriteLine("1.Radio Player \n2.Music player.");
            Console.WriteLine("Currently Avilable music number :" + musicFileCount);
        }

    }
}

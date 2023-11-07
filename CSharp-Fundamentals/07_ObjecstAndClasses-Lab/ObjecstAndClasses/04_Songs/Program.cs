namespace _04_Songs
{
    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberSongs; i++)
            {
                List<string> data = Console.ReadLine().Split('_').ToList();

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeSong = Console.ReadLine();

            if (typeSong == "all")
            {
                foreach (Song song in songs) 
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach(Song song in songs)
                {
                    if(song.TypeList == typeSong)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }


}
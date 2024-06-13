using System;

namespace AdapterPatternExample
{
    // The target interface that the client expects
    public interface IMediaPlayer
    {
        void Play(string audioType, string fileName);
    }

    // A concrete implementation of the target interface
    public class ModernMediaPlayer : IMediaPlayer
    {
        public void Play(string audioType, string fileName)
        {
            Console.WriteLine("Playing " + audioType + " file. Name: " + fileName);
        }
    }

    // The adaptee class that needs to be adapted
    public class CassettePlayer
    {
        public void PlayCassette(string cassetteName)
        {
            Console.WriteLine("Playing cassette. Name: " + cassetteName);
        }
    }

    // The adapter class that makes the adaptee compatible with the target interface
    public class CassettePlayerAdapter : IMediaPlayer
    {
        private readonly CassettePlayer _cassettePlayer;

        public CassettePlayerAdapter(CassettePlayer cassettePlayer)
        {
            _cassettePlayer = cassettePlayer;
        }

        public void Play(string audioType, string fileName)
        {
            if(audioType.Equals("cassette", StringComparison.OrdinalIgnoreCase))
            {
                _cassettePlayer.PlayCassette(fileName);
            }
            else
            {
                Console.WriteLine("Invalid media. " + audioType + " format not supported.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a modern media player
            IMediaPlayer modernMediaPlayer = new ModernMediaPlayer();
            modernMediaPlayer.Play("mp3", "song.mp3");

            // Creating a cassette player
            CassettePlayer cassettePlayer = new CassettePlayer();
            // Creating an adapter to use the cassette player with the media player interface
            IMediaPlayer cassetteAdapter = new CassettePlayerAdapter(cassettePlayer);
            cassetteAdapter.Play("cassette", "old_song.cassette");

            // Trying to play an unsupported format
            cassetteAdapter.Play("mp4", "video.mp4");

            Console.ReadKey();
        }
    }
}

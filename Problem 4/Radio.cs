using System;

class Radio
{
    private string _artist = "None";
    private string _song = "None";
    private int _minuts = 0;
    private int _second = 0;

    public Radio(string name, string name_song, int minuts, int second)
    {
        _artist = name;
        _song = name_song;
        _minuts = minuts;
        _second = second;

        Console.WriteLine("Song added");
    }

    public string Artist
    {
        get
        {
            return _artist;
        }
        set
        {
            if (value.Length <= 3)
            {
                Console.WriteLine("The artist's name must be at least 3 characters long.");
            }
            else
                _artist = value;
        }
    }

    public string Song
    {
        get
        {
            return _song;
        }
        set
        {
            if (value.Length <= 3)
            {
                Console.WriteLine("The song's name must be at least 3 characters long");
            }
            else
                _song = value;
        }
    }

    public int Minuts
    {
        get
        {
            return _minuts;
        }
        set
        {
            if (value < 0 || value > 14)
            {
                Console.WriteLine("Song minutes should be between 0 and 14.");
            }
            _minuts = value;
        }
    }

    public int Second
    {
        get
        {
            return _second;
        }
        set
        {
            if (value < 0 || value > 59)
            {
                Console.WriteLine("Song seconds should be between 0 and 59.");
            }
        }
    }
}
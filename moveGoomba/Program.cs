using System;


public class Goomba
{
    public Array CharacterSprite;
    public int MoveSpeed;
    public bool MovingForward;
    public int CurrentLocation;

    public Goomba(Array characterSprite, int moveSpeed, bool movingForward, int currentLocation) 
    {
        CharacterSprite = characterSprite;
        MoveSpeed = moveSpeed; 
        MovingForward = movingForward; 
        CurrentLocation = currentLocation;
    }

    public void MoveSprite()
    {
        if (CurrentLocation >= 100)
        {
            MovingForward = false;
        }
        if (CurrentLocation <= 0) 
        {
            MovingForward = true;
        }
        if (MovingForward)
        {
            CurrentLocation += 1;
        }
        if (!MovingForward)
        {
            CurrentLocation -= 1;
        }
    }
    public void DrawSprite(string emptyString)
    {
        foreach (string characters in CharacterSprite)
        {
            Console.WriteLine(emptyString + characters);
        }
    }
}

class Program
{
    static string CreateEmptyString(int numberOfSpaces)
    {
        string emptyString = "";
        for (int i = 0; i < numberOfSpaces; i++)
        {
            emptyString += " ";
        }

        return emptyString;
    }
    static void Main()
    {
        int moveSpeed = 10;
        int currentLocation = 0;
        bool movingForward = true;
        Array asciiSprite = new string[] { "1 2 3", 
                                           "4 5 6", 
                                           "7 8 9" };

        Goomba newGoomba = new Goomba(asciiSprite, moveSpeed, movingForward, currentLocation);

        while (true) {
            string emptyString = CreateEmptyString(newGoomba.CurrentLocation);
            newGoomba.DrawSprite(emptyString);
            newGoomba.MoveSprite();
            Thread.Sleep(100 / newGoomba.MoveSpeed);
            Console.Clear();
           
        }
    }
}
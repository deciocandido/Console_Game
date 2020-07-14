using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string keyPressed, out int xCoord, out int yCoord){  
      xCoord = 0;
        yCoord = 0;
      
      switch(keyPressed){
        

        case "DownArrow":
        yCoord += 1;
        break;
        
        case "UpArrow":
        yCoord -= 1;
        break;

        case "LeftArrow":
        xCoord -= 1;
        break;

        case "RightArrow":
        xCoord += 1;
        break;

        default:
        Console.WriteLine("Try Again!");
        break;
      }
    }

    public new static char UpdateCursor(string keyPressed){
      switch(keyPressed){
        case "LeftArrow":
        return '<';
        break;

        case "RightArrow":
        return '>';
        break;

        case "UpArrow":
        return '^';
        break;

        case "DownArrow":
        return 'v';
        break;

        default:
        return 'O';
        break;
      }
    }

    public new static int KeepInBounds(int coord, int maxValue){
      if(coord > maxValue){
        return 0;
      } else if (coord < 0){
        return maxValue;
      } else {
        return coord;
      }
    }

    public new static bool DidScore(int x, int y, int xFruit, int yFruit){
      if((x == xFruit) && (y == yFruit)){
        return true;
      } else {
        return false;
      }
    }
  }
}
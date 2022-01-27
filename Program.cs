// See https://aka.ms/new-console-template for more information
using System;
// Tic-Tac- Toe game by Isaac Creer
// This is a game of Tic-Tac-Toe for CSE 210
// The namespace for this program is tictactoe
namespace tictactoe
{
    public class Program
    {
        static void Main(string[] agrs)
        {
            bool xwinner = false;
            bool owinner = false;
            bool xuserinput = false;
            bool ouserinput = false;
            string[] xando = {"1","2","3","4","5","6","7","8","9"};
            int[] xsquares = {10,20,30,40,50};
            int[] osquares = {10,20,30,40,50};
            int place = 0;
            int xnumber = 0;
            int onumber = 0;
            //This function contorls the displaying the borad
            void Display()
            {
                Console.WriteLine($"{xando[0]}|{xando[1]}|{xando[2]}");
                Console.WriteLine($"-+-+-");
                Console.WriteLine($"{xando[3]}|{xando[4]}|{xando[5]}");
                Console.WriteLine($"-+-+-");
                Console.WriteLine($"{xando[6]}|{xando[7]}|{xando[8]}");
            }
            // This function deals with the user inputs
            int Userinputs()
            {
                // This loop deals with the x user input
                while(xuserinput)
                {
                    Console.WriteLine("x's turn to chose a square(1-9):");
                    int x = Convert.ToInt32(Console.ReadLine());
                    if (xando[x-1]== "X" || xando[x-1] =="O")
                    {
                        Console.WriteLine("That line is already taken");
                    }
                    else
                    {
                        xuserinput = false;
                        place = x-1;
                    }
                }
                // This loop deals with the o user input
                while(ouserinput)
                {
                    Console.WriteLine("o's turn to chose a square(1-9):");
                    int x = Convert.ToInt32(Console.ReadLine());
                    if (xando[x-1]== "X" || xando[x-1] =="O")
                    {
                        Console.WriteLine("That line is already taken");
                    }
                    else
                    {
                        ouserinput = false;
                        place = x-1;
                    }
                }
               return place;
            }

            // This loop deals with the game play
            for(int k =1; k < 10; k++)
            {
                Display();
                if(k % 2 != 0)
                {
                    xuserinput = true;
                    xsquares[xnumber] = Userinputs();                    
                    xando[xsquares[xnumber]] = "X";
                    if ( xando[0]=="X" && xando[1]=="X" && xando[2]=="X" ||
                         xando[3]=="X" && xando[4]=="X" && xando[5]=="X" ||
                         xando[6]=="X" && xando[7]=="X" && xando[8]=="X" ||
                         xando[0]=="X" && xando[3]=="X" && xando[6]=="X" ||
                         xando[1]=="X" && xando[4]=="X" && xando[7]=="X" ||
                         xando[2]=="X" && xando[5]=="X" && xando[8]=="X" ||
                         xando[0]=="X" && xando[4]=="X" && xando[8]=="X" ||
                         xando[2]=="X" && xando[4]=="X" && xando[6]=="X")
                    {
                        xwinner = true;
                        break;
                    }
                    
                    xnumber = xnumber + 1;

                }
                else
                {
                    ouserinput= true;
                    osquares[onumber] = Userinputs();
                    xando[osquares[onumber]] = "O";
                    if ( xando[0]=="O" && xando[1]=="O" && xando[2]=="O" ||
                         xando[3]=="O" && xando[4]=="O" && xando[5]=="O" ||
                         xando[6]=="O" && xando[7]=="O" && xando[8]=="O" ||
                         xando[0]=="O" && xando[3]=="O" && xando[6]=="O" ||
                         xando[1]=="O" && xando[4]=="O" && xando[7]=="O" ||
                         xando[2]=="O" && xando[5]=="O" && xando[8]=="O" ||
                         xando[0]=="O" && xando[4]=="O" && xando[8]=="O" ||
                         xando[2]=="O" && xando[4]=="O" && xando[6]=="O")
                    {
                        owinner = true;
                        break;
                    }
                    onumber = onumber + 1;
                }
            }
            if (xwinner)
            {
                Display();
                Console.WriteLine("Congradulation on Winning player 1");
            }
            else if (owinner)
            {
                Display();
                Console.WriteLine("Congradulation on Winning player 2");
            }
            else
            {
                Display();
                Console.WriteLine("Sorry you guys drawed");
            }
            
        }
    }
}

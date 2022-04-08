using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LRC
{
    class Program
    {
    static void Main(string[] args)
    {
        updater.update();
        Console.WriteLine("Welcome to Left Right Center!");
        Console.WriteLine("______            _________             ________");
        Console.WriteLine("|    |            |   ___  \\           /      __|");
        Console.WriteLine("|    |            |   |  |  \\         /      /");
        Console.WriteLine("|    |            |   |  |   \\        |     |");
        Console.WriteLine("|    |            |   |__|   /        |     |");
        Console.WriteLine("|    |            |         /         |     |");
        Console.WriteLine("|    |            |_________|         |     |");
        Console.WriteLine("|    |            |     |\\   \\        |     |");
        Console.WriteLine("|    |            |     | \\   \\       |     |");
        Console.WriteLine("|    |_________   |     |  \\   \\      |     |");
        Console.WriteLine("|              |  |     |   \\   \\     \\     \\___");
        Console.WriteLine("|______________|  |_____|    \\___\\     \\________|");
        Console.WriteLine("                   https://github.com/ToadSaidBye");
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("Version:");
        Console.WriteLine(" __    __ ");
        Console.WriteLine("|  |     |");
        Console.WriteLine("|  |   --| ");
        Console.WriteLine("|  |     |");
        Console.WriteLine("|__| o --   ");
        
        
        if (variables.shouldbeversion == variables.version){Console.WriteLine("Up to date");} else {Console.WriteLine("Looks like you need an update! Download at https://github.com/ToadSaidBye/LRC");}

        Console.WriteLine("Layout:");
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("             Com2/Player2             ");
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("Com3/Player3              Com1/Player1");
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("              You/Player              ");
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine(Environment.NewLine);

        Console.WriteLine("You start with 5 tokens");
        Console.WriteLine("Press ENTER to start");
        Console.ReadLine();
        Console.WriteLine(Environment.NewLine);
    int tokens = 5;
    int com1 = 5;
    int com2 = 5;
    int com3 = 5;
    bool game = true; 
    int turn = 0;
    int temp3 = 0;
    bool out0 = false;
    bool out1 = false;
    bool out2 = false;
    bool out3 = false;

    while (game == true){
        if (turn == 0){if (tokens > 2){temp3 = 3;} else {temp3 = tokens;}}
        if (turn == 1){if (com1 > 2){temp3 = 3;} else {temp3 = com1;}}
        if (turn == 2){if (com2 > 2){temp3 = 3;} else {temp3 = com2;}}
        if (turn == 3){if (com3 > 2){temp3 = 3;} else {temp3 = com3;}}
        while (temp3 > 0){
            Console.WriteLine("Rolls left: " + temp3 + "                       Player " + turn + "'s turn");
    Random diceRandomizer = new Random();
    int dice = diceRandomizer.Next(0, 5);
    if (dice == 0){
        Console.WriteLine("Left");    if (turn == 0){tokens --; com3 ++;}
    else if (turn == 1){com1 --; tokens ++;}
    else if (turn == 2){com2 --; com1 ++;}
   else if (turn == 3){com3 --; com2 ++;} 
        }
    if (dice == 1){
        Console.WriteLine("Right");     if (turn == 0){tokens --; com1 ++;}
    else if (turn == 1){com1 --; com2 ++;}
    else if (turn == 2){com2 --; com3 ++;}
   else if (turn == 3){com3 --; tokens ++;} 
        }
    if (dice == 2){
        Console.WriteLine("Center");if (turn == 0){tokens --; }
    else if (turn == 1){com1 --;}
    else if (turn == 2){com2 --;}
   else if (turn == 3){com3 --;} 
        }
    if (dice == 3){Console.WriteLine("Wild"); 
    if (turn == 0){
    Console.WriteLine("Who should you take from? 1, 2, or 3?");
    Console.WriteLine("1 has " + com1);
    Console.WriteLine("2 has " + com2);
    Console.WriteLine("3 has " + com3);
    Console.WriteLine("type 1, 2, or 3");
    bool temp1 = true;
    while (temp1 == true){
    string temp2 = Console.ReadLine();
    if (temp2 == "1"){com1 --; tokens ++; temp1 = false;}
   else if (temp2 == "2"){com2 --; tokens ++; temp1 = false;}
   else if (temp2 == "3"){com3 --; tokens ++; temp1 = false;}
   else {Console.WriteLine("Please say 1, 2, or 3");}
    }
    
    }
    if (turn == 1){

    bool temp4 = true;
    while (temp4 == true){
    Random wildRandomizer = new Random();
    int wildc = wildRandomizer.Next(0, 3);
if (wildc == 0){
    if(tokens > 0){
        Console.WriteLine("Took from player"); tokens --; com1 ++; temp4 = false;
    }
}
if (wildc == 1){
    if(com2 > 0){
        Console.WriteLine("Took from com 2"); com2 --; com1 ++; temp4 = false;
    }
}
if (wildc == 2){
    if(com3 > 0){
        Console.WriteLine("Took from com 3"); com3 --; com1 ++; temp4 = false;
    }
}
    }
    }
if (turn == 2){

    bool temp4 = true;
    while (temp4 == true){
    Random wildRandomizer = new Random();
    int wildc = wildRandomizer.Next(0, 3);
if (wildc == 0){
    if(tokens > 0){
        Console.WriteLine("Took from player"); tokens --; com2 ++; temp4 = false;
    }
}
if (wildc == 1){
    if(com1 > 0){
        Console.WriteLine("Took from com 1"); com1 --; com2 ++; temp4 = false;
    }
}
if (wildc == 2){
    if(com3 > 0){
        Console.WriteLine("Took from com 3"); com3 --; com2 ++; temp4 = false;
    }
}
    }
    }
    if (turn == 3){

    bool temp4 = true;
    while (temp4 == true){
    Random wildRandomizer = new Random();
    int wildc = wildRandomizer.Next(0, 3);
if (wildc == 0){
    if(tokens > 0){
        Console.WriteLine("Took from player"); tokens --; com3 ++; temp4 = false;
    }
}
if (wildc == 1){
    if(com1 > 0){
        Console.WriteLine("Took from com 1"); com1 --; com3 ++; temp4 = false;
    }
}
if (wildc == 2){
    if(com2 > 0){
        Console.WriteLine("Took from com 2"); com2 --; com3 ++; temp4 = false;
    }
}
    }
    }}
if (dice == 4){
    Console.WriteLine("Nothing");
}
    temp3 --;
    if (tokens == 0){Console.WriteLine("You are out"); out0 = true;}
    else{out0 = false;}
    if (com1 == 0){Console.WriteLine("Com 1 is out"); out1 = true;}
    else{out1 = false;}
    if (com2 == 0){Console.WriteLine("Com 2 is out"); out2 = true;}
    else{out2 = false;}
    if (com3 == 0){Console.WriteLine("Com 3 is out"); out3 = true;}
    else{out3 = false;}

    if (out1 == true){if(out2==true){if(out3==true){game = false; temp3 = 0; Console.WriteLine("Player Wins!");}}}
    if (out0 == true){if(out2==true){if(out3==true){game = false; temp3 = 0; Console.WriteLine("Com 1 Wins!");}}}
    if (out1 == true){if(out0==true){if(out3==true){game = false; temp3 = 0; Console.WriteLine("Com 2 Wins!");}}}
    if (out1 == true){if(out2==true){if(out0==true){game = false; temp3 = 0; Console.WriteLine("Com 3 Wins!");}}}
    if (game == true){if(temp3 > 0){Console.WriteLine("Going on to next roll"); Console.ReadLine(); Console.Clear();}}
    }
    if (game == true){
    if (turn == 0){turn = 1;}
    else if (turn == 1){turn = 2;}
    else if (turn == 2){turn = 3;}
   else if (turn == 3){turn = 0;}
   Console.ReadLine();
    Console.WriteLine(Environment.NewLine + "Switching to player " + turn);
    Console.WriteLine("You have " + tokens);
    Console.WriteLine("Com1 has " + com1);
    Console.WriteLine("Com2 has " + com2);
    Console.WriteLine("Com3 has " + com3);
    Console.ReadLine();}
    }
    Console.WriteLine("game over");
    }
    }
}

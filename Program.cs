bool isRaining = true;
bool isRiding = true;

if (isRaining)
{Console.Writeline("I'm not going for a ride in the rain!");}

else
{Console.Writeline ("I can go for a ride");}

Console.Writeline("How old are you?");
string response = System.Console. Readline();
int age = int.Parse(responce);

string output = age >= 16 ? "You can ride!" : "You're too young to ride.";

Console.Writeline (output);
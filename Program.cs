//Coded by: Ulises Ortega
//Date Revised:09.08.22
//Project Name: Even or Odd
//Description: The Program will ask the user to input a number, the number will be store in a variable,
//the program will calculate the remainder, is the remainder is equal to 0 even if not odd
//once the program is done, It will ask the user ot run the program again yes or no
//Review By (code && play again) :Manuel L, Great Job :)

string userChoice = "";

do{
Console.Clear();
int num1, rem1;
bool checkNum1;

do{
Console.WriteLine("--------------------------------------------------------");
Console.Write("Please Type a Number to check if it's Odd or Even: ");

checkNum1 = Int32.TryParse(Console.ReadLine(), out num1);
if (checkNum1 == false)
{
    Console.WriteLine("that is not a number, please enter a number");
}
}while(checkNum1 == false);

rem1 = num1 % 2;
if (rem1 == 0){
Console.WriteLine("---------------------------------");
Console.WriteLine(num1 + " is an even number.\n",num1);
Console.WriteLine("---------------------------------");
}
else{
Console.WriteLine("---------------------------------");
Console.WriteLine(num1 + " is an odd number.\n",num1);
Console.WriteLine("---------------------------------");
}

do
{
    Console.WriteLine("Run the program again: Yes or No?");
    userChoice = Console.ReadLine().ToUpper();
    if(userChoice != "YES" && userChoice != "NO")
    {
        Console.WriteLine("Invalid Choice, pLease say Yes or No");
    }
}while (userChoice !="YES" && userChoice != "NO");
}while(userChoice == "YES");
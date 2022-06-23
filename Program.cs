int theNumber=new Random().Next(20);
bool keepGoing =true;
Console.WriteLine("Let's play 'Guess the number'");
Console.WriteLine("I am thinking of  a number between 0 and 20");
Console.WriteLine("Enter your guess,or -1 to give up ");
int guessNum=0;
int guessCount=0;
do{
    Console.WriteLine("What's your guess?");
    string theGuess=Console.ReadLine();
    bool result =Int32.TryParse(theGuess,out guessNum);
    if(!result)
{
    Console.WriteLine("That does not look like a number.Try again");
}
else{
    if(guessNum==-1){
        Console.WriteLine("I was thinking of {0}", theNumber);
        keepGoing=false;
    }else{
        guessCount++;
    }
if(guessNum==theNumber){
 Console.WriteLine("You got it in {0} guesses!!",guessCount);
 keepGoing=false;
 }
 else{
    Console.WriteLine("Nope,{0} than that.",guessNum<theNumber?"higher" :"lower");
 }

}
 }while(keepGoing);   



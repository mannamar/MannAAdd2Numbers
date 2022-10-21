// Amardeep Mann
// 10-17-2022
// Mini Challenge #2 - "Add 2 numbers"
// The challenge is adding two numbers. We'll take the user's input, add the numbers, then output the total to the console
// Peer Reviewed by Brandon Le: Program works as intended with no issues. I was able to get the sum of the numberinos that I inputted. I was able to loop to the beginning by typing y and ending by typing n. All of the data validation worked properly for the user inputs and also the play again/end function. Simple, straight to the point and good work! Very nice.
// Github link: https://github.com/peedrama/MannAAdd2Numbers

Console.Clear();

bool playAgain = true;

while (playAgain) {
  Console.WriteLine("\nWe're going to add some numberinos!\n");
  Console.WriteLine("Enter the first number");

  //string numOne = Console.ReadLine();

  bool isNumOneValid = false;
  string numOne;
  int num1 = 0;

  while (!isNumOneValid) {
    numOne = Console.ReadLine();
    isNumOneValid = Int32.TryParse(numOne, out num1);
    if (!isNumOneValid) {
      Console.WriteLine("Invalid entry. Please type a number");
    }
  }

  Console.WriteLine("Enter the second number");

  //string numTwo = Console.ReadLine();

  bool isNumTwoValid = false;
  string numTwo;
  int num2 = 0;

  while (!isNumTwoValid) {
    numTwo = Console.ReadLine();
    isNumTwoValid = Int32.TryParse(numTwo, out num2);
    if (!isNumTwoValid) {
      Console.WriteLine("Invalid entry. Please tpye a number");
    }
  }

  //int num1 = Convert.ToInt32(numOne);
  //int num2 = Convert.ToInt32(numTwo);
  int sum = num1 + num2;

  Console.WriteLine($"\nThe grand total of {num1} plus {num2} is: {sum}\n");


  string response = "default";
  while (response != "yes" && response != "no" && response != "y" && response != "n") {
    Console.WriteLine("Do you want to play again? (Type \"y\" or \"n\")");
    response = Console.ReadLine().ToLower();
  }

  if (response == "no" || response == "n") {
    playAgain = false;
    Console.WriteLine("\nGoodbye!");
  }
}
using Microsoft.AspNetCore.Mvc;

namespace DDecoito_bestTAsControllerQuiz.Controllers;
//
[ApiController]
[Route("[controller]")]
// change name here 
public class BestTAsController : ControllerBase
{
    [HttpGet]
 [Route("AddTwoNumbers/{num1}/{num2}")]
 public int AddTwoNumbers(string num1, string num2)
 {
    int number1 = int.Parse(num1);
    int number2 = int.Parse(num2);

    return number1 + number2;

}


[HttpGet]
[Route("reverseIt/{wordinput}")]
public string reverseIt(string wordinput)
{
    string numberOne = "";
    string numberTwo = "";
      char[] intArray = wordinput.ToCharArray();
                for (int i = 0; i < intArray.Length; i++)
                {
                    numberOne = numberOne + intArray[i].ToString();
                }
                
                for (int j = intArray.Length - 1; j > -1; j--)
                {
                    numberTwo = numberTwo + intArray[j].ToString();
                }
    return $" --Reverse it-- \nYour number is \n{number} \nYour number reversed is \n{numberTwo}";
}



[HttpGet]
[Route("SayHello/{name}")]

public string Hello(string name)
{
    return $"Hello {name} how are you today?";

}

}
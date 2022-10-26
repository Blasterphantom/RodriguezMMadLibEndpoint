//Marcel Rodriguez
//10-25-22
//Mad Lib Endpoint
//This controller will ask for 11 input strings in the url to output a story
//Peer review - Caroline Hana- The code was neat and way different then how I did mine but looks very good. The story was very creative and funny. Good job!!
using Microsoft.AspNetCore.Mvc;

namespace RodriguezMMadLibEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class EndpointController : ControllerBase
{
    [HttpGet]
    [Route("madlib/{nameOne}/{nounOne}/{verbOne}/{adjectiveOne}/{verbTwo}/{nounTwo}/{adjectiveTwo}/{adjectiveThree}/{verbThree}/{verbFour}/{verbFive}")]

    public string MadLib(string nameOne, string nounOne, string verbOne, string adjectiveOne, string verbTwo, string nounTwo, string adjectiveTwo, string adjectiveThree, string verbThree, string verbFour, string verbFive)
    {
        string story = "";


        story +="There once was a person named " +nameOne+ " who loved " +nounOne+ " a lot.";
        story +=" They loved " +nounOne+ " so much that they always had to " +verbOne+ " with it.";
        story +=" It had a " +adjectiveOne+ " look to it, and that made " +nameOne+ " want to " +verbTwo+ " when they were apart.";
        story +=" There was another thing that they had, which was a " +nounTwo;
        story +=" The " +nounTwo+ " was " +adjectiveTwo+ " and " +adjectiveThree+ ".";
        story +=$" {nameOne} dropped the {nounTwo} off a cliff, which caused {nameOne} to ";
        story +=$"{verbThree}, {verbFour}, and {verbFive} off the cliff as well.";
        story +=$" {nounOne} watched from the top and laughed. The End :D";

        return story;
    }
}
using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string question, response;

            Console.Write("Place your question? ");
            question = Console.ReadLine();

            while (question != "EXIT")
            {
                question = Console.ReadLine();
                switch (question)
                {
                    case "How are you?":
                        response = "I'm fine, thank you";
                        break;
                    case "What's your name?":
                        response = "ChatGPTOne";
                        break;
                    case "What's your mission?":
                        response = "To be better than the ChatGPTZero!";
                        break;
                    case "Are you more  intelligent  than me?":
                        response = "Obviously!";
                        break;    
                    default:
                        response = "I don't recognize your question.";
                        break;
                }
                // Responder adequadamente
                Console.WriteLine(response);
                
            }
            
        }
    }
}

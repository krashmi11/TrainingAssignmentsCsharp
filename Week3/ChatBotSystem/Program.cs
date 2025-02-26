using System;
using System.Text;

namespace ChatBotSystem
{
    class Chatbot
    {
        // 1. Respond to basic queries
        public string RespondToQuery(string query)
        {
            return "Bot: Thank you for your query. We will assist you soon.";
        }

        // 2. Respond to priority queries
        public string RespondToQuery(string query, bool isImportant)
        {
            if (isImportant)
            {
                return "Bot: Your query is of high priority. We will assist you immediately.";
            }
            return RespondToQuery(query);
        }

        // 3. Respond to multi-language queries
        public string RespondToQuery(string query, string language)
        {
            switch (language.ToLower())
            {
                case "spanish":
                    return "Bot: Gracias por su consulta. Le asistiremos en breve.";
                case "french":
                    return "Bot: Merci pour votre demande. Nous vous aiderons bientôt.";
                case "hindi":
                    return "Bot: आपकी पूछताछ के लिए धन्यवाद। हम जल्द ही आपकी सहायता करेंगे।";
                default:
                    return RespondToQuery(query); // Default to English response
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Chatbot chatbot = new Chatbot();
            Console.OutputEncoding = Encoding.UTF8;
            bool running = true;

            while (running)
            {
                Console.WriteLine("Choose query type:");
                Console.WriteLine("1. Basic Query");
                Console.WriteLine("2. Priority Query");
                Console.WriteLine("3. Multi-Language Query");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter your query: ");
                        string basicQuery = Console.ReadLine();
                        Console.WriteLine(chatbot.RespondToQuery(basicQuery));
                        break;

                    case 2:
                        Console.Write("Enter your query: ");
                        string priorityQuery = Console.ReadLine();
                        Console.Write("Is this a priority query? (yes/no): ");
                        bool isPriority = Console.ReadLine().Trim().ToLower() == "yes";
                        Console.WriteLine(chatbot.RespondToQuery(priorityQuery, isPriority));
                        break;

                    case 3:
                        Console.Write("Enter your query: ");
                        string multiLangQuery = Console.ReadLine();
                        Console.Write("Enter language (English/French/Spanish/Hindi): ");
                        string language = Console.ReadLine().Trim();
                        Console.WriteLine(chatbot.RespondToQuery(multiLangQuery, language));
                        break;

                    case 4:
                        running = false;
                        Console.WriteLine("Exiting chatbot. Have a great day!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

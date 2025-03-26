#pragma warning disable SKEXP0010 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;

var booking = File.ReadAllText("../booking.json");

var urlBase = Environment.GetEnvironmentVariable("BASE_URL") ?? "http://localhost:11434/v1";
var apiKey = Environment.GetEnvironmentVariable("API_KEY") ?? "ollama";
var model = Environment.GetEnvironmentVariable("OLLAMA_MODEL")
    ?? (apiKey == "ollama" ? "llama3.2" : "gpt-3.5-turbo");

var client = new OpenAIChatCompletionService(
    modelId: model,
    endpoint: new Uri(urlBase),
    apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
);

ChatHistory history = [];
history.AddSystemMessage(
    $"""
    You are Shelley an automated travel assistant to answer questions about a customers holiday,
    start by greeting them by their first name and asking them how you can help with their holiday
    mention where they are going
    This customers holiday details are here:
    {booking}"
    """);

string Prompt()
{
    Console.Write("User: ");
    return Console.ReadLine()!;
}

Console.WriteLine("Travel Assistant Chatbot");

const string waiting = "Waiting for response...";

while (Prompt() is string input && input != "exit")
{
    Console.WriteLine();
    history.AddUserMessage(input);
    Console.Write(waiting);
    var result = await client
        .GetChatMessageContentAsync(history);
    var response = result.Content!;
    history.AddAssistantMessage(response);
    Console.Write($"\r{Enumerable.Repeat(' ', waiting.Length).ToArray()}\r");
    Console.WriteLine($"Assistant: {result.Content}\n");
}

Console.WriteLine("Goodbye!");
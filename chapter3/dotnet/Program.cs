#pragma warning disable SKEXP0010 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;

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
history.AddSystemMessage("You are a helpful conversational AI expert.");
history.AddUserMessage("Suggest a good name for a customer support chatbot working for a holiday company");

var result = await client
    .GetChatMessageContentAsync(history);

Console.WriteLine(result.Content);
import os
import openai

base_url = os.environ.get("OPENAI_BASE_URL") or "http://localhost:11434/v1"
api_key = os.environ.get("OPENAI_API_KEY") or "ollama"
model_name = os.environ.get("MODEL_NAME") or "llama3.2" if api_key == "ollama" else "gpt-3.5-turbo"

client = openai.OpenAI(
    base_url = base_url,
    api_key=api_key,
)

def chat_with_gpt(
    model,
    user_message,
    top_p=1,
    frequency_penalty=0,
    presence_penalty=0,
    temperature=0
):
    try:
        response = client.chat.completions.create(
            model=model,
            messages=[
                {
                    "role": "system",
                    "content": "You are a helpful conversational AI expert.",
                },
                {"role": "user", "content": user_message},
            ],
            top_p=top_p,
            frequency_penalty=frequency_penalty,
            presence_penalty=presence_penalty,
            temperature=temperature
        )
        return response
    except Exception as e:
        return str(e)
    
# Example usage
response = chat_with_gpt(
    model_name,
    "Suggest a good name for a customer support chatbot working for a holiday company",
    top_p=0.9,
    frequency_penalty=-0.5,
    presence_penalty=0.6,
)

if isinstance(response, str):
    print(response)
else:
    print(response.choices[0].message.content)

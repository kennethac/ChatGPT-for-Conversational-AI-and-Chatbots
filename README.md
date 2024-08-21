# ChatGPT for Conversational AI and Chatbots

<a href="https://www.packtpub.com/en-us/product/chatgpt-for-conversational-ai-and-chatbots-9781805129530?type=print"><img src="https://m.media-amazon.com/images/I/61QAJPEb0-L._SL1233_.jpg" alt=" ChatGPT for Conversational AI and Chatbots" height="256px" align="right"></a>

This is the code repository for [ ChatGPT for Conversational AI and Chatbots](https://www.packtpub.com/en-us/product/chatgpt-for-conversational-ai-and-chatbots-9781805129530?type=print), published by Packt.

**Learn how to automate conversations with the latest large language model technologies**

## What is this book about?

This book explores the potential of ChatGPT-powered chatbots and conversational AI. You’ll delve into understanding the technology, its implementation, and practical use cases, while leveraging AI-powered conversations.

This book covers the following exciting features: 
* Gain a solid understanding of ChatGPT and its capabilities and limitations
* Understand how to use ChatGPT for conversation design
* Discover how to use advanced LangChain techniques, such as prompting, memory, agents, chains, vector stores, and tools
* Create a ChatGPT chatbot that can answer questions about your own data
* Develop a chatbot powered by ChatGPT API
* Explore the future of conversational AI, LLMs, and ChatGPT alternatives

If you feel this book is for you, get your [copy](https://www.amazon.com/ChatGPT-Conversational-Chatbots-conversations-technologies/dp/1805129538/ref=sr_1_1?sr=8-1) today!


## Instructions and Navigations
All of the code is organized into folders.

The code will look like the following:
```python
def format_evaluator_inputs(run: Run, example: Example):
    return {
        "input": example.inputs["question"],
        "prediction": next(iter(run.outputs.values())),
        "reference": example.outputs["answer"],
    }
```

**Following is what you need for this book:**
This book is for tech-savvy readers, conversational AI practitioners, engineers, product owners, business analysts, and entrepreneurs wanting to integrate ChatGPT into conversational experiences and explore the possibilities of this game-changing technology. Anyone curious about using internal data with ChatGPT and looking to stay up to date with the developments in large language models will also find this book helpful. Some expertise in coding and standard web design concepts would be useful, along with familiarity with conversational AI terminology, though not essential.

With the following software and hardware list you can run all code files present in the book (Chapter 1-9).

### Software and Hardware List

| Chapter  | Software required                                                                    | OS required                        |
| -------- | -------------------------------------------------------------------------------------| -----------------------------------|
|  	1-9	   | Python 3 | Cross-platform |
|  	1-9	   | LangChain | Cross-platform |

### Related products <Other books you may enjoy>
* Building AI Applications with ChatGPT APIs [[Packt]](https://www.packtpub.com/en-us/product/building-ai-applications-with-chatgpt-apis-9781805127567?type=print) [[Amazon]](https://www.amazon.com/Building-Applications-ChatGPT-APIs-DALL/dp/180512756X/ref=sr_1_1?sr=8-1)
  
* The Future of Finance with ChatGPT and Power BI  [[Packt]](https://www.packtpub.com/en-us/product/the-future-of-finance-with-chatgpt-and-power-bi-9781805123347?type=print) [[Amazon]](https://www.amazon.com/Future-Finance-ChatGPT-PowerBI-Transform/dp/1805123343/ref=sr_1_1?sr=8-1)
  
## Get to Know the Author
**Adrian Thompson**, a leading expert in Conversational AI (CAI), has been at the forefront of building chatbots and voice assistants since 2018. As the founder of The Bot Forge, he established a pioneering consultancy service recognized for its cutting-edge innovations in CAI. Adrian’s expertise spans the latest large language models (LLMs), such as ChatGPT and Google Gemini. A versatile programmer and prompt engineer, he is adept in the LLM landscape and related technologies. At loveholidays, Adrian enhances customer experiences by developing advanced CAI systems. He is passionate about the latest advancements in CAI and is renowned for his proficiency in conversation design, AI development, and strategic consultancy across various industries.

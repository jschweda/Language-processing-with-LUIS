## Nie wieder Missverständnisse
### Language processing mit LUIS

---

Absicht erkennen
Inhalte erkennnen

Ich hätte gerne ein Bier!
Ein Bier bitte!
Zwei Helle!

---

Abstract:
Schon die Kommunikation zwischen Menschen ist nicht immer einfach und führt nicht selten zu Missverständnissen. Wie soll dann erst eine Software verstehen, was wir von ihr wollen?! Mit dem Language Understanding Intelligent Service bietet Azure einen Dienst, der den Inhalt einer Aussage erkennen kann. Im Laufe der Session werden wir zunächst ein einfaches Modell anlegen und nutzen, um im Folgenden zu demonstrieren, welche Möglichkeiten LUIS uns beim Überwachen und Verbessern des Modells liefert.



---

### Was ist LUIS?
- NLP Service
- ML
- Cloud
- API 

### Wo kann LUIS genutz werden?
What is Language Understanding (LUIS)?
Language Understanding (LUIS) is a cloud-based API service that applies custom machine-learning intelligence to a user's conversational, natural language text to predict overall meaning, and pull out relevant, detailed information.

A client application for LUIS is any conversational application that communicates with a user in natural language to complete a task. Examples of client applications include social media apps, chat bots, and speech-enabled desktop applications.

Conceptual image of 3 client applications working with Cognitive Services Language Understanding (LUIS)

Use LUIS in a chat bot

Once the LUIS app is published, a client application sends utterances (text) to the LUIS natural language processing endpoint API and receives the results as JSON responses. A common client application for LUIS is a chat bot.

Conceptual imagery of LUIS working with Chat bot to predict user text with natural language understanding (NLP)

Step	Action
1	The client application sends the user utterance (text in their own words), "I want to call my HR rep." to the LUIS endpoint as an HTTP request.
2	LUIS applies the learned model to the natural language text to provide intelligent understanding about the user input. LUIS returns a JSON-formatted response, with a top intent, "HRContact". The minimum JSON endpoint response contains the query utterance, and the top scoring intent. It can also extract data such as the Contact Type entity.
3	The client application uses the JSON response to make decisions about how to fulfill the user's requests. These decisions can include some decision tree in the bot framework code and calls to other services.
The LUIS app provides intelligence so the client application can make smart choices. LUIS doesn't provide those choices.


Natural language processing
A LUIS app contains a domain-specific natural language model. You can start the LUIS app with a prebuilt domain model, build your own model, or blend pieces of a prebuilt domain with your own custom information.

Prebuilt model LUIS has many prebuilt domain models including intents, utterances, and prebuilt entities. You can use the prebuilt entities without having to use the intents and utterances of the prebuilt model. Prebuilt domain models include the entire design for you and are a great way to start using LUIS quickly.

Custom Entities LUIS gives you several ways to identify your own custom intents and entities including machine-learned entities, specific or literal entities, and a combination of machine-learned and literal.

Build the LUIS model
Build the model with the authoring APIs or with the LUIS portal.

The LUIS model begins with categories of user intentions called intents. Each intent needs examples of user utterances. Each utterance can provide a variety of data that needs to be extracted with entities.

Example user utterance	Intent	Entities
"Book a flight to Seattle?"	BookFlight	Seattle
"When does your store open?"	StoreHoursAndLocation	open
"Schedule a meeting at 1pm with Bob in Distribution"	ScheduleMeeting	1pm, Bob
Query prediction endpoint
After the model is built and published to the endpoint, the client application sends utterances to the published prediction endpoint API. The API applies the model to the text for analysis. The API responds with the prediction results in a JSON format.

The minimum JSON endpoint response contains the query utterance, and the top scoring intent. It can also extract data such as the following Contact Type entity.

JSON

Copy
{
  "query": "I want to call my HR rep.",
  "topScoringIntent": {
    "intent": "HRContact",
    "score": 0.921233
  },
  "entities": [
    {
      "entity": "call",
      "type": "Contact Type",
      "startIndex": 10,
      "endIndex": 13,
      "score": 0.7615982
    }
  ]
}
Improve model prediction
After a LUIS model is published and receives real user utterances, LUIS provides several methods to improve prediction accuracy: active learning of endpoint utterances, phrase lists for domain word inclusion, and patterns to reduce the number of utterances needed.


Development Lifecycle
LUIS provides tools, versioning, and collaboration with other LUIS authors to integrate into the full development life cycle at the level of the client application and the language model.

Implementing LUIS
LUIS, as a REST API, can be used with any product, service, or framework that makes an HTTP request. The following list contains the top Microsoft products and services used with LUIS.

The top client application for LUIS is:

Web app bot quickly creates a LUIS-enabled chat bot to talk with a user via text input. Uses Bot Framework version 3.x or 4.x for a complete bot experience.
Tools to quickly and easily use LUIS with a bot:

LUIS CLI The NPM package provides authoring and predecition with as either a stand-alone command line tool or as import.
LUISGen LUISGen is a tool for generating strongly typed C# and typescript source code from an exported LUIS model.
Dispatch allows several LUIS and QnA Maker apps to be used from a parent app using dispatcher model.
LUDown LUDown is a command line tool that helps manage language models for your bot.
Other Cognitive Services used with LUIS:

QnA Maker allows several types of text to combine into a question and answer knowledge base.
Bing Spell Check API provides text correction before prediction.
Speech service converts spoken language requests into text.
Conversation learner allows you to build bot conversations quicker with LUIS.
Project personality chat to handle bot small talk.

--- 
### Was macht LUIS aus?

--- 
### Wie kann ich LUIS nutzen?

- www.luis.ai
- Modell defninieren
- Beispiele 
- endpunkt veröffentlichen
- Modell verbessern
- endpunkt veröffentlichen
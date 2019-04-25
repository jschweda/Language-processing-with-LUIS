---?color=#303030&image=logo.png&position=right 10px top 10px&size=5%
@title[Nie wieder Missverständnisse]

## Nie wieder Missverständnisse
#### Language processing mit LUIS

@snap[south-west span-60]
Jan Schweda
@snapend

@snap[south-east span-60]
@jschweda
@snapend


+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%
@title[Agenda]

@snap[west span-40]
# Agenda
@snapend

@snap[north-east span-60 fragment]
@box[bg-blue text-white box-narrow-padding](LUIS#Was bitte ist ein LUIS?)
@snapend

@snap[east span-60 fragment]
@box[bg-blue text-white box-narrow-padding](Ok#Anschauen kann ja nicht schaden)
@snapend

@snap[south-east span-60 fragment]
@box[bg-blue text-white box-narrow-padding](Schön wärs ja schon...#Aber ich kann nicht. Datenschutz und so :()
@snapend
---?color=#303030&image=logo.png&position=right 10px top 10px&size=5%

@title[LUIS]
@snap[center]
# LUIS
## Was bitte ist ein LUIS?
@snapend

+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%
@title[Was ist LUIS?]
@snap[north-west]
### Was ist LUIS?
@snapend

@ul
- Language Understanding Intelligent Service
- Natural Language Processing Service
  - Domänen-spezifisches Modell
  - Vorbereitete Modelle verfügbar
- Pre-Build Machine Learning
- Cloud basierend
  - [API](https://westus.dev.cognitive.microsoft.com/docs/services/5890b47c39e2bb17b84a55ff/export?DocumentFormat=Swagger&ApiName=LUIS%20Programmatic%20APIs%20v2.0) ;)
@ulend

+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%
@title[Wann brauche ich sowas?]
@snap[north-west]
### Wann brauche ich sowas?
@snapend

@ul
- Social Media Apps
- Chat Bots
- Conversational User Interfaces
@ulend

Note:
- Wecker Challenge

+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%
@title[Wer hat gekellnert?]
@snap[north-west]
### Wer hat gekellnert?
@snapend


<table>
  <tr>
    <th>Aussage</th>
    <th>Absicht</th>
    <th>Ojekte</th>
  </tr>
  <tr>
    <td>Ein Helles bitte!</td>
    <td>Order</td>
    <td>1 Helles</td>
  </tr>
  <tr class="fragment">
    <td>Noch a Seidla</td>
    <td></td>
    <td></td>
  </tr>
  <tr class="fragment">
    <td>Mir dadn dann zahlen</td>
    <td></td>
    <td></td>
  </tr>
   <tr class="fragment">
    <td>Eine halbe bitte</td>
    <td></td>
    <td></td>
  </tr> <tr class="fragment">
    <td>Ein Bier</td>
    <td></td>
    <td></td>
  </tr> 
  <tr class="fragment">
    <td>Wo bleibt mein Essen?</td>
    <td></td>
    <td></td>
  </tr>
</table>

---?color=#303030&image=logo.png&position=right 10px top 10px&size=5%

@title[Ok]
@snap[center]
# Ok
## Anschauen kann ja nicht schaden
@snapend

+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%
@title[ML Workflow]
@snap[north-west span-40]
@box[bg-orange text-white box-wide-padding rounded](Daten aufbereiten)
@snapend

@snap[north-east span-40]
@box[bg-orange text-white box-wide-padding rounded](Daten hochladen)
@snapend

@snap[south-east span-40]
@box[bg-orange text-white box-wide-padding rounded](Modell trainieren)
@snapend

@snap[south-west span-40]
@box[bg-orange text-white box-wide-padding rounded](Modell benutzen)
@snapend

@snap[midpoint]
@fa[refresh fa-3x]
@snapend

+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%

@title[Daten aufbereiten]
@snap[north-west]
### Daten aufbereiten
@snapend
@ul
- Protokolle
- Simulation
- [Wizard of Oz](https://en.wikipedia.org/wiki/Wizard_of_Oz_experiment)
@ulend
+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%

@title[Daten hochladen]
@snap[north-west]
### Daten hochladen
@snapend
- [Portal](www.luis.ai)
- API

+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%

@title[Modell trainieren]
@snap[north-west]
### Modell trainieren
@snapend

@ol
- Intents definieren
- Entitäten definieren
- Modell trainieren
- Modell veröffentlichen
@olend

+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%

@title[Modell benutzen]
@snap[north-west]
### Modell benutzen
@snapend

@ol
- Client sendet Aussage
- LUIS versteht und erstellt eine Antwort
- Client entscheidet je nach Antwort
@olend
+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%

@title[Daten aufbereiten]
@snap[north-west]
### Daten aufbereiten
@snapend
- [Portal](www.luis.ai)

+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%
@title[Tools to make live easy]
@snap[north-west]
### Tools to make live easy
@snapend
@ul
- [LUIS CLI](https://github.com/Microsoft/botbuilder-tools/tree/master/packages/LUIS)
- [LUISGen](https://github.com/Microsoft/botbuilder-tools/blob/master/packages/LUISGen/src/npm/readme.md)
- [Dispatch](https://github.com/Microsoft/botbuilder-tools/tree/master/packages/Dispatch)
- [LUDown](https://github.com/Microsoft/botbuilder-tools/tree/master/packages/Ludown)
@ulend
+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%

@title[Tools to build something]
@snap[north-west]
### Tools to build something
@snapend
@ul
- [QnA Maker](https://www.qnamaker.ai/)
- [Bing Spell Check](https://azure.microsoft.com/en-us/services/cognitive-services/spell-check/)
- [Speech Services](https://azure.microsoft.com/en-us/services/cognitive-services/speech-services/)
- [Conversation Learner](https://labs.cognitive.microsoft.com/en-us/project-conversation-learner)
- [Project Personality Chat](https://labs.cognitive.microsoft.com/en-us/project-personality-chat)
- Was ihr wollt!
@ulend

@snap[south span-90]
[LUIS Dokumentation](https://docs.microsoft.com/de-de/azure/cognitive-services/luis)
@snapende
---?color=#303030&image=logo.png&position=right 10px top 10px&size=5%

@title[Schön wärs ja schon...]
@snap[center]
# Schön wärs ja schon...
## Aber ich kann nicht. Datenschutz und so :(
@snapend


+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%
@title[Datenschutz]
@snap[north-west]
### Datenschutz
@snapend
@ul
- [User privacy](https://docs.microsoft.com/en-us/azure/cognitive-services/luis/luis-user-privacy)
- 100 g LUIS zum mitnehmen bitte!
- [LUIS Container Preview](https://docs.microsoft.com/en-us/azure/cognitive-services/luis/luis-container-howto)
@ulend

+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%
@title[ML Workflow - Docker]
@snap[north-west span-40]
@box[bg-orange text-white box-wide-padding rounded](Daten aufbereiten)
@snapend

@snap[north-east span-40]
@box[bg-orange text-white box-wide-padding rounded](Daten hochladen)
@snapend

@snap[east span-30]
@box[bg-orange text-white box-wide-padding rounded](Modell trainieren)
@snapend

@snap[south-east span-40]
@box[bg-orange text-white box-wide-padding rounded](Modell exportieren)
@snapend

@snap[south-west span-40]
@box[bg-orange text-white box-wide-padding rounded](Modell hosten)
@snapend

@snap[west span-30]
@box[bg-orange text-white box-wide-padding rounded](Modell benutzen)
@snapend

@snap[midpoint]
@fa[refresh fa-3x]
@snapend

+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%
@title[Docker run]
@snap[north-west]
### Docker run
@snapend
``` docker run --rm -it -p 5000:5000 --memory 4g --cpus 2 --mount type=bind,src=c:\luis\in,target=/input --mount type=bind,src=c:\luis\out,target=/output mcr.microsoft.com/azure-cognitive-services/luis Eula=accept Billing=https://westeurope.api.cognitive.microsoft.com/luis/v2.0 ApiKey=**key** ```

+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%
@title[Fragen]
@snap[midpoint]
## Fragen    Anmerkungen   Diskussion
@snapend

+++?color=#303030&image=logo.png&position=right 10px top 10px&size=5%
@title[Danke]
@snap[midpoint]
## Danke!
@snapend
@snap[south-west span-60]
Jan Schweda
@snapend

@snap[south-east span-60]
@jschweda
@snapend


+++?image=logo_color.png&size=50%
@title[INCLUSIFY AG]
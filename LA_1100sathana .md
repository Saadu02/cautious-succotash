# Projekt-Dokumentation

Sathana Suganthasri



| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|25.08.2022| 0.0.1   | Im PAP habe ich die Anweisungen hingeschrieben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |


## 1 Informieren

### 1.1 Ihr Projekt
Der Computer wählt eine zufällige Zahl zwischen 1 bis 100, der Benutzer muss eine Zahl erraten und eingeben.


### 1.2 User Stories                


| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1 |muss|Funktional| Ich als Spieler, möchte ich ein Hinweis haben, damit ich weiss, ob ich die erratene Zahl grösser ist. 
| 2 | muss | Funktional | Ich als Spieler, möchte ich ein Hinweis haben, damit ich weiss, ob die erratene Zahl kleiner ist.
| 3 | kann | Funktional | Ich als Spieler, möchte ich so weit wie möglich mit wenige versuche im Game eine Zahl einzugeben, damit ich den gleichen Ergebnissen habe wie der Computer.|
| 4 | kann | Funktional | Ich als Spieler, möchte ich im Spiel, dass man auch mit Dezimalzahlen eingeben kann, damit das Spiel ein bisschen schwieriger wird  |
| 5 | kann | Funktional | Ich als Spieler, möchte ich im Spiel, das man auch die Zahlwörter eingeben kann, damit man das Spiel spannender macht. |
| 6 | kann | Funktional | Ich als Spieler, möchte ich im Spiel, das man auch Wörter eingeben kann, damit man mehr überlegen muss. |
| 7 | muss | Funktional | Ich als Spieler, möchte ich im Spiel ein Hinweis haben, damit Ich weiss zu welcher Gruppe das Wort gehört |


### 1.3 Testfälle


| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1. | Code eingeben für den Satz|Console.Write("Wählen Sie eine Zahl aus zwischen 1 bis 100") |Wählen Sie eine Zahl aus zwischen 1 bis 100|
| 2. | Programm laufen lassen  |Im Ergebnis eine Zahl eingeben |Wählen Sie eine Zahl aus zwischen 1 bis 100:___ |
| 3. | Code für eine zufällige Zahl | int zufaelligezahl = new Random(). Next(1, 100); | Computer speichert eine zufällige Zahl |
| 4. | Code eingeben, zufällige Zahl grösser oder kleiner | if zufaelligezahl ...... | Geratene Zahl muss grösser/kleiner sein. |
| 5. | Code eingeben, wie viele versuche | Console.WriteLine("Du hast ___ versuche gebraucht") | Du hast ___ versuche gebraucht |
| 6. | Code eingeben für den Schlussteil | Console.Write.Line("Bravo, du hast im Spiel mit ___ Versuche geschafft den richtige zufällige Zahl einzugeben")| Bravo! du hast im Spiel mit ___ Versuche geschafft die richtige zufällige Zahl einzugeben.



### 1.4 Diagramme

![Zahlenspiel](https://user-images.githubusercontent.com/111046257/186751410-699f9f2b-d937-4d2a-97b6-4d9736ed40ac.png)


## 2 Planen      


| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.| 01.09.2022 | Ich | Im Visual Studio stelle ich ein, so dass der Satz; "Wähle eine Zahl aus zwischen 1 bis 100:" rauskommt.| 4min |
| 2.| 01.09.2022 | Ich | Kontrollieren, ob das Ergebnis so zeigt "Wähle eine Zahl aus zwischen 1 bis 100:" und eine Zahl hinschreiben kann.| 3min|
| 3.| 01.09.2022 | Ich | So einstellen, dass der Computer eine Zufällige Zahl wählt. und Programm laufen lassen| 15min|
| 4.| 01.09.2022 | Ich | so einstellen, damit es beim Ergebnis zeigt, ob das hingeschriebene Zahl grösser oder kleiner sein soll. |30min |
| 5.| 01.09.2022 | Ich | Wieder kontrollieren, ob das funktioniert.  | 5min |
| 6.| 01.09.2022 | Ich | Falls, das nicht funktioniert, die Probleme beheben. | 20 min |
| 7.| 01.09.2022 | Ich | Danach muss ich eingeben, wie viele Versuche der Benutzer gebraucht hat. Am Schluss beim Ergebnis soll das anzeigen | 20min |
| 8.| 01.09.2022 | Ich | Am Schluss gebe so ein, wenn der Benutzer die richtigen Zahl erraten hat "Bravo! du hast im Spiel mit ...Versuche geschafft die richtige zufällige Zahl  einzugeben. | 20min |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1. | 01.09.2022 | Ich | 4 min | 2 min |
| 2. | 01.09.2022 | Ich | 3 min | 1.5 min |
| 3. | 01.09.2022 | Ich | 15 min | 9 min |
| 4. | 01.09.2022 | Ich | 30 min | 15 min |
| 5. | 01.09.2022 | Ich | 5 min | 2 min |
| 6. | 01.09.2022 | Ich | 20 min | - |
| 7. | 01.09.2022 | Ich |
| 8. | 01.09.2022 | Ich |


✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |



✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.
                                              
## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.

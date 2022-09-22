# Projekt-Dokumentation

Sathana Suganthasri

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|25.08.2022| 0.0.1   | Im PAP habe ich die Anweisungen hingeschrieben. |
|01.09.2022| 1.0.0   | Neues Projekt im Visual Studio erstellt. |
|15.09.2022| 1.0.1   |   Projekt fertig erstellt. |
|22.09.2022| 1.0.1   | Projektdokumentation fertig erstellt |


## 1 Informieren

### 1.1 Ihr Projekt
Der Computer wählt eine zufällige Zahl zwischen 1 bis 100, der Benutzer muss eine Zahl erraten und eingeben.


### 1.2 User Stories                


| US-№ | Verbindlichkeit | Typ | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1. | muss| Funktional| Ich als Spieler, möchte ich ein Hinweis haben, damit ich weiss, ob ich die erratene Zahl grösser ist. 
| 2. | muss | Funktional | Ich als Spieler, möchte ich ein Hinweis haben, damit ich weiss, ob die erratene Zahl kleiner ist.
| 3. | kann | Funktional | Ich als Spieler, möchte ich so weit wie möglich mit wenige versuche im Spiel eine Zahl einzugeben, damit ich den gleichen Ergebnissen habe wie der Computer.|

| 4. | muss | Funktional | Ich als Spieler, möchte ich erneut eine Zahl eingeben, damit ich nicht verlieren möchte.

| 5. | kann | Funktional | Ich als Spieler, möchte ich im Spiel, das man auch die Zahlwörter eingeben kann, damit man das Spiel spannender macht. |
| 6. | muss | Qualität | Ich als Spieler, möchte ich im Spiel, wenn ich irgendetwas schreibe, muss ein Message zeigen, dass es Ungültig ist, damit das Programm nicht gleich abstürtzt.| 

| 7.| kann | Funktional | Ich als Spieler, möchte ich im Spiel, das es Anzahl Versuche zeigt, damit ich mit meine Lernpartnerin vergleichen kann.|
| 8.| muss | Funktional | Ich als Spieler, möchte ich im Spiel noch einmal spielen, damit ich eine chance habe mit wenige Versuche zuspielen|
| 9. | muss | Funktional | Ich als Spieler, möchte ich im Spiel, wenn ich nicht mehr Spielen möchte, dass der Programm zeigt "Danke fürs Mitspielen", damit das Spiel ohne zu bedanken aufhört/schliesst. |
| 10. | kann | Qualität | Ich als Spieler, möchte ich im Spiel, dass es farbig ist, damit es viel schöner aussieht. |

### 1.3 Testfälle


| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1&2. | Programm startet | Benutzer gibt ein Zahl ein. | Programm gibt Himweise, ob die geratene Zahl grösser oder niedriger ist. |
| 3&7. | Programm läuft weiter | Benuter gibt ein Zahl ein mit wenige Versuchen. | Programm zeigt Anzhal Versuche.|
| 4. | Programm läuft weiter. Zweite versuch: | Benutzer gibt eine Zahl ein. | Programm gibt Hinweise, ob die geratene Zahl grösser/ niedriger ist. |
| 4.1 | Programm läuft weiter|  Benutzer hat den richtigen Zahl geraten | Benutzer gibt ein Zahl ein | Programm zeigt, das die Benutzer die richtige Zahl rausgefunden hat. |
| 5. | - | - | Geht nicht, weil ich das nicht programmiert habe.|
| 6. | Programm läuft weiter. | Benutzer gibt eine Buchstabe. | Programm zeigt: Ungültige Eingabe. Bitte starten Sie das Spiel von vorne an. |
| 8. | Programm läut weiter. Programm fragt ob die Benutzer wieder spielen möchte | Benutzer gibt Y ein | Das Spiel fängt von vorne an.|
| 9. | Wiederholt sich das ganze. Programm fragt ob die Benutzer wieder spielen möchte | Benutzer gibt n ein | Progamm zeigt: Danke fürs mitspielen. |
| 10. | Prgramm läuft weiter. | Benutzer spielt das ganze nochmal. | Das Programm soll farbig aussehen. |

                          

Debugging 

### 1.4 Diagramme

![Zahlenspiel](https://user-images.githubusercontent.com/111046257/191668160-a1098be1-58aa-404a-89d4-04386c73df61.png)


## 2 Planen      


| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.| 01.09.2022 | Ich | Im Visual Studio stelle ich ein, so dass der Satz; "Wähle eine Zahl aus zwischen 1 bis 100:" rauskommt.| 4min |
| 2.| 01.09.2022 | Ich | Kontrollieren, ob das Ergebnis so zeigt "Wähle eine Zahl aus zwischen 1 bis 100:" und eine Zahl hinschreiben kann.| 3min|
| 3.| 01.09.2022 | Ich | So einstellen, dass der Computer eine Zufällige Zahl wählt. und Programm laufen lassen| 30min|
| 4.| 01.09.2022 | Ich | so einstellen, damit es beim Ergebnis zeigt, ob das hingeschriebene Zahl grösser oder kleiner sein soll. |30min |
| 5.| 01.09.2022 | Ich | Wieder kontrollieren, ob das funktioniert.  | 5min |
| 6.| 01.09.2022 | Ich | Falls, das nicht funktioniert, die Probleme beheben. | 20 min |
| 7.| 01.09.2022 | Ich | Danach muss ich eingeben, wie viele Versuche der Benutzer gebraucht hat. Am Schluss beim Ergebnis soll das anzeigen | 30min |
| 8.| 01.09.2022 | Ich | Am Schluss gebe so ein, wenn der Benutzer die richtige Zahl erraten hat "Bravo! du hast im Spiel mit ...Versuche geschafft die richtige zufällige Zahl herauszufinden. | 20min |
| 9.| 08.09.2002 | Ich | So einstellen, dass man der Benutzer fragt, ob er wieder spielen möchte. | 20 min |
| 10.| 08.09.2022 | Ich | Wenn der Spieler anstatt einer Zahl ein Buchstabe eingibt, soll das Programm sagen, dass das eine Ungültige Eingabe ist. | 30min |
| 11.| 15.09.2022 | Ich | Nach ungültige Eingabe, muss man das Programm neustarten | 25 min|
| 12.| 15.09.2022 | Ich | Probleme beheben, die von letzten Mal. | 40 min |
| 13.| 15.09.2022 | Ich | Wenn man im Spiel dee korrekte Zahl herausgefunden hat, die richtige Zahl im grün markieren. | 30 min |
| 14.| 15.09.2022 | Ich | Wenn man im Spiel eine falsche Zahl eingibt, wird es mit Magenta Farbe markiert. | 20 min |
| 15.| 15.09.2022 | Ich | Wenn man im Spiel soll den Satz "Danke für mitspielen..." mit gelb markieren. | 20 min |
| 16.| 15.09.2022 | Ich | Das Probleme mit (wie viele versuche der Benutzer benötigt hat) lösen | 30 min |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.
Try catch
Debugging
Wiederhol Modus
Text Farbe

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1. | 01.09.2022 | Ich | 4 min | 3 min |
| 2. | 01.09.2022 | Ich | 3 min | 2 min |
| 3. | 01.09.2022 | Ich | 30 min | 15 min |
| 4. | 01.09.2022 | Ich | 30 min | 25 min |
| 5. | 01.09.2022 | Ich | 5 min | 2 min |
| 6. | 01.09.2022 | Ich | 20 min | - |
| 7. | 01.09.2022 | Ich | 30 min | 25 min |
| 8. | 01.09.2022 | Ich | 20 min | 8 min |
| 9. | 08.09.2022 | Ich | 20 min | 50 min |
| 10.| 08.09.2022 | Ich | 30 min | 40 min |
| 11.| 15.09.2022 | Ich | 25 min | 30 min |
| 12.| 15.09.2022 | Ich | 40 min | 45 min |
| 13.| 15.09.2022 | Ich | 30 min | 35 min |
| 14.| 15.09.2022 | Ich | 20 min | 15 min |
| 15.| 15.09.2022 | Ich | 20 min | 15 min |
| 16.| 15.09.2022 | Ich | 30 min | 18 min |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.0  |22.09.2022|OK|Sathana Suganthasri|
| 2.0  |22.09.2022|OK|Sathana Suganthasri|
| 3.0  |22.09.2022|OK|Sathana Suganthasri|
| 4.0  |22.09.2022|OK|Sathana Suganthasri|
| 5.0  |22.09.2022|NOK|Sathana Suganthasri|
| 6.0  |22.09.2022|OK|Sathana Suganthasri|
| 7.0  |22.09.2022|OK|Sathana Suganthasri|
| 8.0  |22.09.2022|OK|Sathana Suganthasri|
| 9.0  |22.09.2022|OK|Sathana Suganthasri|
| 10.0 |22.09.2022|OK|Sathana Suganthasri|



Die Tests sind weitgehend erfolgreich verlaufen.

                                              
## 6 Auswerten
https://github.com/Saadu02/cautious-succotash/blob/main/Lern_Bericht_Sathana.md


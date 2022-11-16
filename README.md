# 06-smuehlmann_Random
Random in Unity

## Warum könnte man den Zufall beim Programmieren brauchen?

+ Um beispielsweise ein Objekt per Zufall irgendwo auftauchen zu lassen.

## Was ist der Unterschied zwischen Random aus System bzw. aus UnityEngine?

+ UnityEngine.Random ist eine statische Klasse, die nur einen einzigen, „globalen“ Strom von Zufallswerten pro Spiel bereitstellt. 

+ Jede Instanz von System.Random, ist ein unabhängiger Zufallszahlengenerator-Stream. Jeder Generator wird nur erweitert, wenn sein nextValue() aufgerufen wird, was bedeutet, dass es viel einfacher ist, reproduzierbare Sequenzen von Zufallszahlen ausgehend von einem bestimmten Seed zu erstellen.

+ Beispiel UnityEngine.Random: wenn man mehrere male die gleiche zufällige Reihenfolge will.
+ Beispiel System.Random: wenn man unterschiedliche Reihenfolgen haben will.

## Warum ist es sinnvoll den seed zu setzen bei Random?

+ Damit man den zufall vorraussehen kann.

## Was macht Random.Range 

+ Mit Random.Range kann man den bereich des Zufalls festlegen.

## Beispiele erklärt

+ Random.value: zufallszahl
+ Random.ColorHSV: zufällige Frabe
+ RandomRotation: zufällige Rotation

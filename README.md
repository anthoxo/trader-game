# trader-game

## Introduction
This repository is a meaning for me to learn C# easily by creating a game.

## Summary

The goal of this game is to earn the most money possible.

We can buy resources and with that, we can create buildings. But the more there are trading, the more there are moving. 

## Rules

* We can play between 2 and 10 players.

* The play last 6 or 12 months. Each month is a round where you can first buy resources and second built things to sell.

* There are three types of resources (A,B,C) and three buildings (Gold, Silver, Bronze).

* The initial cost of these are pointed out below.

<center>

|Purchases| A | B | C |
|---|---|---|---|
||40|30|20|

|Sales|Gold|Silver|Bronze|
|---|---|---|---|
||120|105|90|

</center>

* The cost to built are pointed out below.

<center>

| X | A | B | C |
|---|---|---|---|
|Gold|2|1|0|
|Silver|1|1|1|
|Bronze|0|1|2|

</center>

* Here is the array of price variation by purchase number below.

<center>

|0|1|2|3|4|5|6|7|8|9|10|
|-|-|-|-|-|-|-|-|-|-|-|
-10|-9|-8|-7|-6|-5|-4|-3|-2|-1|0|

|11|12|13|14|15|16|17|18|19|20|
|-|-|-|-|-|-|-|-|-|-|
|1|2|3|4|5|6|7|8|9|10|

</center>

* Here is the array of price variation by sale number below.

<center>

|0|1|2|3|4|5|6|7|8|9|10|
|-|-|-|-|-|-|-|-|-|-|-|
+11|+9|+7|+5|+3|+1|-1|-3|-5|-7|-9|

|11|12|13|14|15|
|-|-|-|-|-|
|-11|-13|-15|-17|-19|

</center>


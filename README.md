# WordCounter

#### Program that tells how many times your chosen word is included in your chosen sentence. 2/16/2018

#### By **Drew Tucker**

## Description

A website that allows users to enter both a word and a sentence. When both are submitted, the page will then show how many times the user's word appears in the user's sentence. This project is practice in C#, MVC web apps, and Testing.


### Specs

#Behavior
* Program detects that a single letter is matching in both the inputted word and inputted sentence. This is the smallest possible string entry to test. Input: Word-"I", Sentence-"I" Result: "1"

* Program detects that a full word is matching in both the inputted word and inputted sentence. This is the next easiest test to run. Input: Word-"Hello", Sentence-"Hello World!", Result: "1"

* Program detects that a full word has been inputted multiple times in the same sentence. This is the final logical test of the function. Input: Word-"and", Sentence-"You and I and my friend", Result: "2"

* If no input word or sentence has been given, and the submit button is clicked, the user will then be prompted to fill out both fields. Input: Word-"", Sentence-"", Result: "Please enter a word and a sentence."

* Since this program is designed to check for words and not for numbers, the user will receive an error message if anything other than letters are inputted. A single number input is the easiest way to test this. Input: Word-"1", Sentence-"1", Result: "Numbers not accepted, please enter letters only."

## Setup/Installation Requirements
(Requires Microsoft .NET Framework)

1. Clone this repository from GitHub.

2. Open the Mono command prompt and navigate to the 'word-counter' directory of the cloned 'word-counter.Solution' folder.

3. Enter 'dotnet build' followed by 'dotnet run' in the Mono command prompt.

4. Enter http://localhost:5000/ in your web browser and enjoy!

## Technologies Used
* HTML
* CSS
* Bootstrap
* GitHub
* C#
* MVC
* Razor

## Support and contact details

_Email Drew Tucker at dtuck43@gmail.com with any questions, comments, or concerns._

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2018 **_{Drew Tucker}_**

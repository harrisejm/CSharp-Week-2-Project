# Word Counter Part 2

#### Epicodus Word Counter (for Epicodus), 7/6/18
#### By Eddie Harris


## Description

This web app allows the user to enter an initial word and compare it to a user inputed string. The app will then count the number of times the initial word appears in the string.

## Specifications

- 1.) Allow user to input a word.

   - Example input: "hello"

- 2.) Allow user to input a string.

  - Example input: "hello world thought I would say hello"

- 3.) Inputed word will be compared against the inputed string. The number of times the inputed word appears in the inputed string will be returned.

    - Example input:
      Word: "hello"
      String: "hello world thought I would say hello"

    - Example output: "hello appeared 2 times"

- 4.) User inputs will not be affected by case-sensitivity or punctuation. The number of times the inputed word appears in the inputed string will be returned regardless of both of these differences.

    - Example input:
      Word: "hello"
      String: "Hello. World? Hello: helLO! HELLO; hellO!"

    - Example output: "hello appeared 5 times"

- 5.) Based on the inputs, the outputted results will be added to a list the user can view.

    - Example input:
        - First Entry:
            - Word: "hello"
            - String: "Hello. World? Hello: helLO! HELLO; hellO!"

        - Second Entry:
            - Word: "Eddie"
            - String: "Hi, Eddie. It's Eddie, right?"

    - Example output:
        - List:   
          - "hello" appears 5 times in the sentence: "hello. world? hello: hello! hello; hello!"
          - "eddie" appears 2 times in the sentence: "hi, eddie. it's eddie, right?"

- 6.) The user will also have the ability to delete the entire list and start from the beginning.

## Setup/Installation Requirements

* Clone his repository
* Save to Desktop
* Open folder and navigate to the WordCount directory
* Enter "dotnet run" and enter "http://localhost:5000" into the web browser. Enter "dotnet restore" before "dotnet run" if page does not open


## Technologies Used

C#


### License

This software is licensed under the MIT license

###Legal

Copyright (c) 2018 Eddie Harris
